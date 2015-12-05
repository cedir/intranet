Imports System.Collections.Generic
Imports FacturaElectronica
Imports CedirDataAccess
Public Class ComprobanteElectronico
    Inherits Comprobante


    Dim _gravado As TipoDeGravadoAFIP
    Dim _tipoComprobante As TipoDeComprobanteAFIP
    Dim _ImporteIva As Decimal
    Dim _clienteFE As ClienteFE

    Public Sub New()
        Me.tipoComprobanteAFIP = New TipoDeComprobanteAFIP
        Me.clienteFE = New ClienteFE  'TODO: ojo con esto que se crean conexiones con la afip cada vez que se hace un new ClienteFE
    End Sub

    Public Property importeIva() As Decimal
        Get
            Return _ImporteIva
        End Get
        Set(ByVal value As Decimal)
            _ImporteIva = value
        End Set
    End Property

    Public Property gravadoAFIP() As TipoDeGravadoAFIP
        Get
            Return _gravado
        End Get
        Set(ByVal value As TipoDeGravadoAFIP)
            _gravado = value
        End Set
    End Property
    Public Property tipoComprobanteAFIP() As TipoDeComprobanteAFIP
        Get
            Return _tipoComprobante
        End Get
        Set(ByVal value As TipoDeComprobanteAFIP)
            _tipoComprobante = value
        End Set
    End Property
    Public Property clienteFE() As ClienteFE
        Get
            Return _clienteFE
        End Get
        Set(ByVal value As ClienteFE)
            _clienteFE = value
        End Set
    End Property
    Public Overrides Function crear() As Dictionary(Of String, String)
        Dim mensajeError As String = "..Sin errores.."
        Dim mensajeResultado As String = " "
        Dim log As New LogComprobanteElectronico

        'cargamos los datos al comprobante, con valores que sean homonimos a los nuestros       
        Me.cargarComprobanteModeloAFIP()
        'luego, insertamos esa factura en AFIP
        Dim response As New Dictionary(Of String, String)
        response = clienteFE.crearComprobante(Me.convertComprobanteElectronicoToDictionary(), Me.convertLineasDeComprobanteElectronicoToDictionary())

        If Not Boolean.Parse(response.Item("success")) Then
            response.Item("success") = False
            mensajeResultado = " ---Se Rechaz� el comporobante. No va a poder crearse el comprobante en AFIP ni en Base de Datos--- " & vbCrLf

            For Each pair As KeyValuePair(Of String, String) In response
                If pair.Key.Contains("error") Then
                    mensajeError += "Error : " & pair.Value & vbCrLf
                End If
                If pair.Key.Contains("observacionCode") Then
                    mensajeResultado += "Observacion ...: " & pair.Value & vbCrLf
                End If
            Next

            'Insertamos los resultados en el LOG

            log.detalle = mensajeResultado & mensajeError
            log.insert()  'TODO: loguear mas datos

            response.Item("message") = mensajeResultado & mensajeError
            Return response
        End If

        'seteamos nuestro CAE recuperado, antes de realizar el insert en base de datos
        Me.CAE = response("CAE")

        'logueamos el resultado de insertar comprobante en base de datos
        Dim resultDB As Dictionary(Of String, String)
        resultDB = MyBase.crear()

        response.Add("success", resultDB.Item("success"))
        response.Add("message", resultDB.Item("message"))

        mensajeResultado += "Resultado....: " & response("ResultadoDatabase") & vbCrLf & "Errores:" & resultDB.Item("message")
        mensajeResultado += "Nro de CAE ..: " & Me.CAE & vbCrLf
        'Insertamos los resultados en el LOG
        log.detalle = "Error al crear comprobante en base de datos. " & resultDB.Item("message")
        log.insert()  'TODO: loguear mas datos
        Return response
    End Function
    Private Function convertComprobanteElectronicoToDictionary() As Dictionary(Of String, Object)
        Dim ultimoNro As Integer = clienteFE.getUltimoNroComprobante(Me.TipoComprobante.Descripcion, Me.NroTerminal.ToString, Me.SubTipo)
        Me.NroComprobante = ultimoNro + 1

        Me.calcularImpIVA()
        Dim dic As New Dictionary(Of String, Object)
        dic.Item("PtoVta") = Me.NroTerminal   'punto de venta factura electronica.
        dic.Item("CbteDesde") = Me.NroComprobante
        dic.Item("CbteHasta") = Me.NroComprobante

        'recordar de buscar en la capa de datos, el id que me da el afip. (FAC/ND/NC)
        dic.Item("CbteTipo") = Me.tipoComprobanteAFIP.IdAFIP
        ' puede ser producto, servicios o ambos. Cedir solo ofrece servicios = 2 .
        dic.Item("Concepto") = 2
        'Tipo de documento : CUIT / DNI / CUIL / ETC
        dic.Item("DocTipo") = Me.DocumentoCliente.idTipoDocumento
        'sacamos los guiones medios de existir en el tipo de documento
        dic.Item("DocNumero") = Convert.ToInt64(Me.DocumentoCliente.NroDocumento.Replace("-", ""))
        dic.Item("CbteDesde") = Me.NroComprobante
        dic.Item("CbteHasta") = Me.NroComprobante
        dic.Item("CbteFch") = DateTime.Today.ToString("yyyyMMdd") 'fecha de hoy
        dic.Item("ImpTotal") = Me.TotalFacturado
        'Importe total del comprobante
        'ImporteTotal = Importe neto no gravado + Importe exento + Importe neto gravado + todos los campos de IVA al XX% + Importe de tributos.
        dic.Item("ImpTotConc") = 0.0
        'Importe neto no gravado.Debe ser menor o igual a Importe total y no puede ser menor a cero.
        'No puede ser mayor al Importe total de la operaci�n ni menor a cero (0).
        'Para comprobantes tipo C debe ser igual a cero (0).
        'Para comprobantes tipo Bienes Usados � Emisor Monotributista este campo corresponde al importe subtotal.

        dic.Item("ImpNeto") = (Me.TotalFacturado - Me.importeIva) 'es la sumatoria de las lineas de comprobante
        'Importe neto gravado. Debe ser menor o igual a Importe total y no puede ser menor a cero. 
        'Para comprobantes tipo C este campo corresponde al Importe del Sub Total

        dic.Item("ImpOpEx") = 0.0
        'Importe exento. Debe ser menor o igual a Importe total y no puede ser menor a cero.

        dic.Item("ImpTrib") = 0.0
        'Suma de los importes del array de tributos

        dic.Item("FchServDesde") = DateTime.Today.ToString("yyyyMMdd")
        'Fecha de inicio del abono para el servicio a facturar. Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios).
        'Formato(yyyymmdd)

        'Suma de los importes del array de IVA.
        dic.Item("ImpIVA") = Me.importeIva


        dic.Item("FchServHasta") = DateTime.Today.ToString("yyyyMMdd")
        'Fecha de fin del abono para el servicio a facturar. Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios).
        ' Formato yyyymmdd. FchServHasta no puede ser menor a FchServDesde

        dic.Item("FchVtoPago") = (DateTime.Today).AddDays(30).ToString("yyyyMMdd")
        'Fecha de vencimiento del pago servicio a facturar. Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios). 
        'Formato yyyymmdd. Debe ser igual o posterior a la fecha del comprobante

        dic.Item("MonId") = "PES"
        dic.Item("MonCotiz") = 1.0

        Return dic
    End Function
    Private Function convertLineasDeComprobanteElectronicoToDictionary() As List(Of Dictionary(Of String, Object))
        Dim colLineas As New List(Of Dictionary(Of String, Object))

        For Each lineaComprobante As LineaDeComprobante In Me.LineasDeComprobante
            'Esta linea es para cargar el objeto Iva.AlicIva de la linea de comprobante.
            Dim linea As New Dictionary(Of String, Object)()
            'tenemos que hacer un cast, ya que cuando asignamos el comprobante a la linea, esta no sabe que puede ser un comprobante electronico
            'solo vamos a guardar un tipo de Gravado por comprobante. Las lineas deben tener un mismo tipo de iva (0%,21% o 10.5%)
            linea.Item("Id") = Me.gravadoAFIP.IdAFIP.ToString
            linea.Item("BaseImp") = lineaComprobante.importeNeto.ToString
            linea.Item("Importe") = lineaComprobante.ImporteIVA.ToString
            colLineas.Add(linea)
        Next
        Return colLineas
    End Function
    Private Sub calcularImpIVA()
        For Each lineaComprobante As LineaDeComprobante In Me.LineasDeComprobante
            Me.importeIva = Me.importeIva + lineaComprobante.ImporteIVA
        Next
    End Sub
    ''' <summary>
    ''' metodo para cargar el comprobante con los datos que poseemos de AFIP, y 
    ''' convertir los que nosotros usamos en base de datos, que estan cargados en el objeto comprobante
    ''' </summary>
    ''' <param name="comprobante"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Sub cargarComprobanteModeloAFIP()
        'El nro de documento, es cargado en la vista. No hace falta identificarlo. 
        Dim catalogoAfip As New CatalogoDeObjetosAFIP
        For Each tipoGravadoAFIP As TipoDeGravadoAFIP In catalogoAfip.getTiposDeGravadoAFIP
            If Me.Gravado.id = tipoGravadoAFIP.idTblGravados Then
                Me.gravadoAFIP = tipoGravadoAFIP
                Exit For
            End If
        Next
        For Each tipoCompAFIP As TipoDeComprobanteAFIP In catalogoAfip.getTiposDeComprobanteAFIP
            If (Me.TipoComprobante.Id = tipoCompAFIP.idTblTipoDeComprobantes) And (tipoCompAFIP.SubTipo = Me.SubTipo) Then
                Me.tipoComprobanteAFIP = tipoCompAFIP
                Exit For
            End If
        Next
        'ahora podemos usar los ids, que estan cargados en los objetosAFIP
    End Sub
End Class
