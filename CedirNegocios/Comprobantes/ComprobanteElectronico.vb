Imports System.Collections.Generic
Imports FacturaElectronica
Imports CedirDataAccess
Public Class ComprobanteElectronico
    Inherits Comprobante

    Dim _cae As String
    Dim _gravado As TipoDeGravadoAFIP
    Dim _tipoComprobante As TipoDeComprobanteAFIP
    Dim _ImporteIva As Decimal

    Public Property importeIva() As Decimal
        Get
            Return _ImporteIva
        End Get
        Set(ByVal value As Decimal)
            _ImporteIva = value
        End Set
    End Property

    Public Property CAE() As String
        Get
            Return _cae
        End Get
        Set(ByVal value As String)
            _cae = value
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
    Dim _clienteFE As ClienteFE
    Public Property clienteFE() As ClienteFE
        Get
            Return _clienteFE
        End Get
        Set(ByVal value As ClienteFE)
            _clienteFE = value
        End Set
    End Property
    Public Overrides Function crear() As Object
        Dim responseError As Boolean = False
        Dim responseObs As Boolean = False
        Dim mensajeError As String = "..Sin errores.."
        Dim mensajeResultado As String = " "
        'primero insertamos la linea en base de datos, para obtener id's en las lineas
        MyBase.crear()
        'cargamos los datos al comprobante, con valores que sean homonimos a los nuestros       
        Me.cargarComprobanteModeloAFIP()
        'luego, insertamos esa factura en AFIP
        Dim response As New Dictionary(Of String, String)
        response = clienteFE.crearComprobante(Me.convertComprobanteElectronicoToDictionary(), Me.convertLineasDeComprobanteElectronicoToDictionary())

        For Each pair As KeyValuePair(Of String, String) In response
            If pair.Key.Contains("error") Then
                mensajeError += "Error : " & pair.Value & vbCrLf
                responseError = True
            End If
            If pair.Key.Contains("observacionCode") Then
                mensajeResultado += "Observacion ...: " & pair.Value & vbCrLf
                responseError = True
            End If
        Next
        mensajeResultado += "Resultado....: " & response("Resultado") & vbCrLf
        If Not responseError And Not responseObs Then
            mensajeResultado += "Nro de CAE ..: " & response("CAE") & vbCrLf
            mensajeResultado += "UltimoNro ...: " & response("ultimoNro") & vbCrLf

            Me.InsertarCAE(response.Item("CAE"))
        End If
        'Insertamos los resultados en el LOG
        Dim log As New LogComprobanteElectronico
        log.detalle = mensajeResultado & mensajeError
        log.insert()

        Return mensajeResultado
    End Function
    Private Sub InsertarCAE(ByVal cae As String)
        Dim com As String = """"
        Dim cDatos As New Nuevo

        Dim tabla As String = com & "cedirData" & com & "." & com & "tblComprobantes" & com
        Dim campos As String = com & "CAE" & com & " = " & Me.CAE
        Dim filtro As String = " where id = " & Me.IdComprobante
        cDatos.update(tabla, campos, filtro)

        cDatos = Nothing
    End Sub

    Private Function convertComprobanteElectronicoToDictionary() As Dictionary(Of String, Object)
        Dim ultimoNro As Integer = clienteFE.getUltimoNroComprobante(Me.TipoComprobante.Descripcion, Me.NroTerminal.ToString, Me.SubTipo)
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
        dic.Item("CbteDesde") = ultimoNro + 1
        dic.Item("CbteHasta") = ultimoNro + 1
        dic.Item("CbteFch") = DateTime.Today.ToString("yyyyMMdd") 'fecha de hoy
        dic.Item("ImpTotal") = Me.TotalFacturado
        'Importe total del comprobante
        'ImporteTotal = Importe neto no gravado + Importe exento + Importe neto gravado + todos los campos de IVA al XX% + Importe de tributos.
        dic.Item("ImpTotConc") = 0.0
        'Importe neto no gravado.Debe ser menor o igual a Importe total y no puede ser menor a cero.
        'No puede ser mayor al Importe total de la operación ni menor a cero (0).
        'Para comprobantes tipo C debe ser igual a cero (0).
        'Para comprobantes tipo Bienes Usados – Emisor Monotributista este campo corresponde al importe subtotal.

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
            linea.Item("Id") = CType(lineaComprobante.Comprobante, ComprobanteElectronico).gravadoAFIP.IdAFIP.ToString
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
    Public Sub New()
        Me.tipoComprobanteAFIP = New TipoDeComprobanteAFIP
        Me.clienteFE = New ClienteFE
        clienteFE.iniciar()
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
