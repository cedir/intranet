Imports System.Collections.Generic
Imports FacturaElectronica
Imports CedirDataAccess
Public Class ComprobanteElectronico
    Shared _listaGravado As List(Of TipoDeGravadoAFIP)
    Shared _listaTipoComprobante As List(Of TipoDeComprobanteAFIP)
    Shared _gravado As TipoDeGravadoAFIP
    Shared _tipoComprobante As TipoDeComprobanteAFIP
    Shared _ImporteIva As Decimal

    Shared Sub New()
        Dim catalogoAfip As New CatalogoDeObjetosAFIP
        _listaGravado = catalogoAfip.getTiposDeGravadoAFIP
        _listaTipoComprobante = catalogoAfip.getTiposDeComprobanteAFIP
    End Sub

    Private Shared Property importeIva() As Decimal
        Get
            Return _ImporteIva
        End Get
        Set(ByVal value As Decimal)
            _ImporteIva = value
        End Set
    End Property

    Private Shared Property gravadoAFIP() As TipoDeGravadoAFIP
        Get
            Return _gravado
        End Get
        Set(ByVal value As TipoDeGravadoAFIP)
            _gravado = value
        End Set
    End Property

    Private Shared Property tipoComprobanteAFIP() As TipoDeComprobanteAFIP
        Get
            Return _tipoComprobante
        End Get
        Set(ByVal value As TipoDeComprobanteAFIP)
            _tipoComprobante = value
        End Set
    End Property

    Public Shared Function Crear(ByVal comprobante As Comprobante) As Dictionary(Of String, String)
        Dim response As New Dictionary(Of String, String)

        If Not Helper.EsComprobanteElectronico(comprobante.TipoComprobante.Id) Then
            Return Helper.Result(response, True, "El comprobante no aplica para ser enviado a AFIP.")
        End If

        Dim log As New LogComprobanteElectronico
        Dim mensajeResultado As String = String.Empty
        importeIva = 0
        gravadoAFIP = Nothing
        tipoComprobanteAFIP = Nothing

        'cargamos los datos al comprobante, con valores que sean homonimos a los nuestros       
        CargarComprobanteModeloAFIP(comprobante)

        'luego, insertamos esa factura en AFIP
        response = ClienteFE.GetInstance(comprobante.Responsable).crearComprobante(ConvertComprobanteElectronicoToDictionary(comprobante), ConvertLineasDeComprobanteElectronicoToDictionary(comprobante))

        If Not Helper.IsSuccess(response) Then
            'response.Item("success") = False 'es innecesario
            mensajeResultado = " ---Se Rechazó el comporobante. No va a poder crearse el comprobante en AFIP ni en Base de Datos--- " & vbCrLf
            mensajeResultado += Helper.GetMessage(response)

            'Insertamos los resultados en el LOG

            log.detalle = mensajeResultado
            log.insert()  'TODO: loguear mas datos

            Helper.SetMessage(response, mensajeResultado)
            Return response
        End If

        'seteamos nuestro CAE recuperado, antes de realizar el insert en base de datos
        comprobante.CAE = response("CAE")

        mensajeResultado += "Resultado....: " & Helper.GetMessage(response) & vbCrLf
        mensajeResultado += "Nro de CAE ..: " & comprobante.CAE & vbCrLf

        Helper.Result(response, True, mensajeResultado)

        'Insertamos los resultados en el LOG
        log.detalle = mensajeResultado
        log.insert()  'TODO: loguear mas datos

        Return response
    End Function

    Private Shared Function ConvertComprobanteElectronicoToDictionary(ByVal comprobante As Comprobante) As Dictionary(Of String, Object)
        CalcularImpIVA(comprobante)
        Dim dic As New Dictionary(Of String, Object)
        dic.Item("PtoVta") = comprobante.NroTerminal   'punto de venta factura electronica.
        dic.Item("CbteDesde") = comprobante.NroComprobante
        dic.Item("CbteHasta") = comprobante.NroComprobante

        'recordar de buscar en la capa de datos, el id que me da el afip. (FAC/ND/NC)
        dic.Item("CbteTipo") = tipoComprobanteAFIP.IdAFIP
        ' puede ser producto, servicios o ambos. Cedir solo ofrece servicios = 2 .
        dic.Item("Concepto") = 2
        'Tipo de documento : CUIT / DNI / CUIL / ETC
        dic.Item("DocTipo") = comprobante.DocumentoCliente.idTipoDocumento
        'sacamos los guiones medios de existir en el tipo de documento
        dic.Item("DocNumero") = Convert.ToInt64(comprobante.DocumentoCliente.NroDocumento.Replace("-", ""))
        dic.Item("CbteDesde") = comprobante.NroComprobante
        dic.Item("CbteHasta") = comprobante.NroComprobante
        dic.Item("CbteFch") = ClienteFE.FormatDate(DateTime.Today) 'fecha de hoy
        dic.Item("ImpTotal") = Math.Round(comprobante.TotalFacturado, 2)
        'Importe total del comprobante
        'ImporteTotal = Importe neto no gravado + Importe exento + Importe neto gravado + todos los campos de IVA al XX% + Importe de tributos.
        dic.Item("ImpTotConc") = 0.0
        'Importe neto no gravado.Debe ser menor o igual a Importe total y no puede ser menor a cero.
        'No puede ser mayor al Importe total de la operación ni menor a cero (0).
        'Para comprobantes tipo C debe ser igual a cero (0).
        'Para comprobantes tipo Bienes Usados – Emisor Monotributista este campo corresponde al importe subtotal.

        dic.Item("ImpNeto") = Math.Round(comprobante.TotalFacturado - importeIva, 2) 'es la sumatoria de las lineas de comprobante
        'Importe neto gravado. Debe ser menor o igual a Importe total y no puede ser menor a cero. 
        'Para comprobantes tipo C este campo corresponde al Importe del Sub Total

        dic.Item("ImpOpEx") = 0.0
        'Importe exento. Debe ser menor o igual a Importe total y no puede ser menor a cero.

        dic.Item("ImpTrib") = 0.0
        'Suma de los importes del array de tributos

        dic.Item("FchServDesde") = ClienteFE.FormatDate(DateTime.Today)
        'Fecha de inicio del abono para el servicio a facturar. Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios).
        'Formato(yyyymmdd)

        'Suma de los importes del array de IVA.
        dic.Item("ImpIVA") = Math.Round(importeIva, 2)


        dic.Item("FchServHasta") = ClienteFE.FormatDate(DateTime.Today)
        'Fecha de fin del abono para el servicio a facturar. Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios).
        ' Formato yyyymmdd. FchServHasta no puede ser menor a FchServDesde

        dic.Item("FchVtoPago") = ClienteFE.FormatDate(DateTime.Today.AddDays(30))
        'Fecha de vencimiento del pago servicio a facturar. Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios). 
        'Formato yyyymmdd. Debe ser igual o posterior a la fecha del comprobante

        dic.Item("MonId") = ClienteFE.CUR_ARS
        dic.Item("MonCotiz") = 1.0

        Return dic
    End Function

    Private Shared Function ConvertLineasDeComprobanteElectronicoToDictionary(ByVal comprobante As Comprobante) As List(Of Dictionary(Of String, Object))
        Dim colLineas As New List(Of Dictionary(Of String, Object))

        For Each lineaComprobante As LineaDeComprobante In comprobante.LineasDeComprobante
            'Esta linea es para cargar el objeto Iva.AlicIva de la linea de comprobante.
            Dim linea As New Dictionary(Of String, Object)()
            'tenemos que hacer un cast, ya que cuando asignamos el comprobante a la linea, esta no sabe que puede ser un comprobante electronico
            'solo vamos a guardar un tipo de Gravado por comprobante. Las lineas deben tener un mismo tipo de iva (0%,21% o 10.5%)
            linea.Item("Id") = gravadoAFIP.IdAFIP.ToString
            linea.Item("BaseImp") = lineaComprobante.importeNeto.ToString("F2")
            linea.Item("Importe") = lineaComprobante.ImporteIVA.ToString("F2")
            colLineas.Add(linea)
        Next
        Return colLineas
    End Function

    Private Shared Sub CalcularImpIVA(ByVal comprobante As Comprobante)
        For Each lineaComprobante As LineaDeComprobante In comprobante.LineasDeComprobante
            importeIva = importeIva + lineaComprobante.ImporteIVA
        Next
    End Sub

    ''' <summary>
    ''' metodo para cargar el comprobante con los datos que poseemos de AFIP, y 
    ''' convertir los que nosotros usamos en base de datos, que estan cargados en el objeto comprobante
    ''' </summary>
    Private Shared Sub CargarComprobanteModeloAFIP(ByVal comprobante As Comprobante)
        'El nro de documento, es cargado en la vista. No hace falta identificarlo. 
        For Each tipoGravadoAFIP As TipoDeGravadoAFIP In _listaGravado
            If comprobante.Gravado.id = tipoGravadoAFIP.idTblGravados Then
                gravadoAFIP = tipoGravadoAFIP
                Exit For
            End If
        Next
        For Each tipoCompAFIP As TipoDeComprobanteAFIP In _listaTipoComprobante
            If (comprobante.TipoComprobante.Id = tipoCompAFIP.idTblTipoDeComprobantes) And (tipoCompAFIP.SubTipo = comprobante.SubTipo) Then
                tipoComprobanteAFIP = tipoCompAFIP
                Exit For
            End If
        Next
        'ahora podemos usar los ids, que estan cargados en los objetosAFIP
    End Sub
End Class
