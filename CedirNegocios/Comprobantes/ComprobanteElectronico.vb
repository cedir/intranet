Imports System.Collections.Generic
Imports FacturaElectronica
Public Class ComprobanteElectronico
    Inherits Comprobante

    Dim _cae As String
    Public Property CAE() As String
        Get
            Return _cae
        End Get
        Set(ByVal value As String)
            _cae = value
        End Set
    End Property

    Dim clienteFE As New ClienteFE

    Public Overrides Function crear() As Object



        clienteFE.crearComprobante(Me.convertComprobanteElectronicoToDictionary())
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


  


End Class
