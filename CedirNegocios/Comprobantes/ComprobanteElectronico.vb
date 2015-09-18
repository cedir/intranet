Imports System.Collections.Generic
Imports FacturaElectronica
Public Class ComprobanteElectronico
    Inherits Comprobante

    Dim _cae As String
    Dim _gravado As TipoDeGravadoAFIP
    Dim _tipoComprobante As TipoDeComprobanteAFIP

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
    Dim clienteFE As New ClienteFE

    Public Overrides Function crear() As Object

        'primero insertamos la linea en base de datos, para obtener id's en las lineas
        MyBase.crear()
        'luego, insertamos esa factura en AFIP
        Return clienteFE.crearComprobante(Me.convertComprobanteElectronicoToDictionary(), Me.convertLineasDeComprobanteElectronicoToDictionary())

        'If nofalla Then
        '    Return MyBase.crear()
        'Else

        'End If
        '  log()
        'llamamos a la clase padre, para insertar el comprobante en base de datos. 

    End Function
    Private Function convertComprobanteElectronicoToDictionary() As Dictionary(Of String, Object)
        Dim dic As New Dictionary(Of String, Object)
        dic.Item("PtoVta") = Me.NroTerminal   'punto de venta factura electronica.

        'recordar de buscar en la capa de datos, el id que me da el afip. (FAC/ND/NC)
        dic.Item("CbteTipo") = Me.TipoComprobante.Id

        ' puede ser producto, servicios o ambos. Cedir solo ofrece servicios = 2 .
        dic.Item("Concepto") = 2

        'Tipo de documento : CUIT / DNI / CUIL / ETC
        dic.Item("DocTipo") = Me.DocumentoCliente.idTipoDocumento
        'sacamos los guiones medios de existir en el tipo de documento
        dic.Item("DocNumero") = Convert.ToInt64(Me.DocumentoCliente.NroDocumento.Replace("-", ""))

        dic.Item("CbteDesde") = 1 'nro de comprobante desde
        dic.Item("CbteHasta") = 1 'nro de comprobante hasta
        dic.Item("CbteFch") = DateTime.Today.ToString("yyyyMMdd") 'fecha de hoy

        dic.Item("ImpTotal") = Me.TotalFacturado
        'Importe total del comprobante
        'ImporteTotal = Importe neto no gravado + Importe exento + Importe neto gravado + todos los campos de IVA al XX% + Importe de tributos.

        dic.Item("ImpTotConc") = 0.0
        'Importe neto no gravado.Debe ser menor o igual a Importe total y no puede ser menor a cero.
        'No puede ser mayor al Importe total de la operación ni menor a cero (0).
        'Para comprobantes tipo C debe ser igual a cero (0).
        'Para comprobantes tipo Bienes Usados – Emisor Monotributista este campo corresponde al importe subtotal.

        dic.Item("ImpNeto") = Me.TotalFacturado 'es la sumatoria de las lineas de comprobante
        'Importe neto gravado. Debe ser menor o igual a Importe total y no puede ser menor a cero. 
        'Para comprobantes tipo C este campo corresponde al Importe del Sub Total

        dic.Item("ImpOpEx") = 0.0
        'Importe exento. Debe ser menor o igual a Importe total y no puede ser menor a cero.

        dic.Item("ImpTrib") = 0.0
        'Suma de los importes del array de tributos

        dic.Item("ImpIVA") = 0.0
        'Suma de los importes del array de IVA.

        dic.Item("FchServDesde") = DateTime.Today.ToString("yyyyMMdd")
        'Fecha de inicio del abono para el servicio a facturar. Dato obligatorio para concepto 2 o 3 (Servicios / Productos y Servicios).
        'Formato(yyyymmdd)

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
    Public Sub New()
        Me.tipoComprobanteAFIP = New TipoDeComprobanteAFIP
    End Sub
End Class
