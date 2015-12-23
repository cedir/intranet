Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Threading
Imports System.Xml


Public Class ClienteFE
    Private Shared _singleton As ClienteFE
    Private Shared _mu As New Mutex
    Dim lt As New LoginTicket
    Dim objWSFE As wsfe.Service = New wsfe.Service()
    Dim aut As wsfe.FEAuthRequest
    Dim fecaeReq As wsfe.FECAERequest
    Dim fecaeResponse As wsfe.FECAEResponse

    Public Function iniciar() As Boolean
        'Llamamos al servicio de autenticacion de afip LoginCMS

        'inicializarombos()
        Try
            InicializarAutenticador()
            inicializarServicio()
            Return True

        Catch ex As Exception
            Return False
            ' TODO: log error in tblComprobanteelectronicoLog
        End Try
        'InicializarFactura()
    End Function
    ''' <summary>
    ''' eL Metodo INICIALIZARAUTENTICADOR debe primero traer de base de datos, de existir, el loginTicket. Ya que puede ser valido
    ''' todavia
    '''</summary>
    ''' <remarks></remarks>
    Private Sub InicializarAutenticador()
        If lt.ExpirationTime <= DateTime.Now Then
            lt.ObtenerLoginTicketResponse("wsfe", "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?wsdl", My.Settings.rutaClaveCertificadoFE)
        End If
    End Sub

    Private Sub inicializarServicio()

        aut = New wsfe.FEAuthRequest()
        aut.Cuit = 30709300152
        aut.Sign = lt.Sign
        aut.Token = lt.Token

    End Sub

    Private Sub inicializarCombos()

        ' Me.getIVA()
        Me.getTipoMoneda()
        '  Me.getTiposComprobante()
        Me.getTipoMonedaCotizacion()
        Me.getTipoConcepto()
        Me.getTipoComprobante()
        Me.getPuntoVta()
    End Sub

    Private Sub getPuntoVta()

        Dim objPtoVta As wsfe.FEPtoVentaResponse = New wsfe.FEPtoVentaResponse()
        objPtoVta = objWSFE.FEParamGetPtosVenta(aut)
        If (objPtoVta.Errors Is Nothing) Then

            'cmbPtoVenta.DisplayMember = "Nro"
            'cmbPtoVenta.ValueMember = "Nro"

            'cmbPtoVenta.DataSource = objPtoVta.ResultGet

        Else

            '  MessageBox.Show("No se pudieron obtener datos del ws" + objPtoVta.Errors[0].Msg)
        End If
    End Sub

    Private Sub getTipoMoneda()

        Dim objMoneda As wsfe.MonedaResponse = New wsfe.MonedaResponse()
        objMoneda = objWSFE.FEParamGetTiposMonedas(aut)
        If (objMoneda.Errors Is Nothing) Then

            'cmbTipoMoneda.DisplayMember = "Desc"
            'cmbTipoMoneda.ValueMember = "Id"

            'cmbTipoMoneda.DataSource = objMoneda.ResultGet



        Else

            'MessageBox.Show("No se pudieron obtener datos del ws" + objMoneda.Errors[0].Msg)

        End If

    End Sub

    Public Function getTiposIVA() As Dictionary(Of Integer, String)
        Dim objIvaTipo As wsfe.IvaTipoResponse = New wsfe.IvaTipoResponse()
        objIvaTipo = objWSFE.FEParamGetTiposIva(aut)

        Dim dic As New Dictionary(Of Integer, String)

        If (objIvaTipo.Errors Is Nothing) Then
            For Each ob As wsfe.IvaTipo In objIvaTipo.ResultGet
                dic.Add(ob.Id, ob.Desc)
            Next
        End If
        Return dic
    End Function

    Public Function getTiposDeDocumentoCliente() As Dictionary(Of Integer, String)

        Dim objDocumentosTipo As wsfe.DocTipoResponse = New wsfe.DocTipoResponse()
        objDocumentosTipo = objWSFE.FEParamGetTiposDoc(aut)

        Dim dic As New Dictionary(Of Integer, String)

        If (objDocumentosTipo.Errors Is Nothing) Then
            For Each ob As wsfe.DocTipo In objDocumentosTipo.ResultGet
                dic.Add(ob.Id, ob.Desc)
            Next
        End If

        Return dic


    End Function

    Private Sub getTipoMonedaCotizacion()

        'Dim objCotizacion As wsfe.FECotizacionResponse = New wsfe.FECotizacionResponse()
        'objCotizacion = objWSFE.FEParamGetCotizacion(aut, cmbTipoMoneda.SelectedValue.ToString())
        'If (objCotizacion Is Nothing) Then
        '    'cmbCotizacion.DisplayMember = "MonCotiz"
        '    'cmbCotizacion.ValueMember = "MonId"

        '    'cmbCotizacion.DataSource = objCotizacion


        'Else
        '    'MessageBox.Show("No se pudieron obtener datos del ws" + objMoneda.Errors[0].Msg)

        'End If

    End Sub

    Private Sub getTipoConcepto()

        Dim objConceptos As wsfe.ConceptoTipoResponse = New wsfe.ConceptoTipoResponse()
        objConceptos = objWSFE.FEParamGetTiposConcepto(aut)
        If (objConceptos.Errors Is Nothing) Then

            'cmbTipoConcepto.DisplayMember = "Desc"
            'cmbTipoConcepto.ValueMember = "Id"

            'cmbTipoConcepto.DataSource = objConceptos.ResultGet
        Else
            ' MessageBox.Show("No se pudieron obtener datos del ws" + objConceptos.Errors(0).Msg)
        End If

    End Sub

    Public Function getTipoComprobante() As Dictionary(Of Integer, String)

        Dim dic As New Dictionary(Of Integer, String)

        Dim objCompTipo As wsfe.CbteTipoResponse = New wsfe.CbteTipoResponse()
        objCompTipo = objWSFE.FEParamGetTiposCbte(aut)
        If (objCompTipo.Errors Is Nothing) Then
            For Each ob As wsfe.CbteTipo In objCompTipo.ResultGet()
                dic.Add(ob.Id, ob.Desc)
            Next
        End If

        Return dic
    End Function

    Public Function getUltimoNroComprobante(ByVal tipoComprobante As String, ByVal nroTerminal As Integer, ByVal subtipo As String) As Integer

        Dim ultimoComprobante As wsfe.FERecuperaLastCbteResponse = New wsfe.FERecuperaLastCbteResponse()
        Dim cbteTipo As Integer
        Dim dic As New Dictionary(Of Integer, String)
        dic = Me.getTipoComprobante()
        Dim pair As KeyValuePair(Of Integer, String)

        For Each pair In dic
            If pair.Value.ToLower.Trim() = String.Concat(tipoComprobante.ToLower.Trim(), " ", subtipo.ToLower()) Then
                cbteTipo = pair.Key
                Exit For
            End If
        Next

        Try
            ultimoComprobante = objWSFE.FECompUltimoAutorizado(aut, nroTerminal, cbteTipo)
            Return ultimoComprobante.CbteNro
        Catch ex As Exception
            Throw ex
        End Try

    End Function
    Public Function crearComprobante(ByVal dict As Dictionary(Of String, Object), ByVal lineas As List(Of Dictionary(Of String, Object))) As Object
        'Información del comprobante o lote de comprobantes de ingreso. Contiene los datos de FeCabReq y FeDetReq
        fecaeReq = New wsfe.FECAERequest()
        fecaeResponse = New wsfe.FECAEResponse()
        'IMPORTANTE: INSERTAR ULTIMO NRO DE COMPROBANTE +1 ACA!!

        'Información de la cabecera del comprobante o lote de comprobantes de ingreso
        Dim fecaeCabReq As wsfe.FECAECabRequest = New wsfe.FECAECabRequest()
        fecaeCabReq.PtoVta = Convert.ToInt16(dict.Item("PtoVta"))  'punto de venta factura electronica.
        fecaeCabReq.CbteTipo = Convert.ToInt16(dict.Item("CbteTipo")) 'tipo de comprobante
        fecaeCabReq.CantReg = lineas.Count 'cant registros del detalle = cant. lineas de comprobante

        fecaeReq.FeCabReq = fecaeCabReq

        'Información del detalle del comprobante o lote de comprobantes de ingreso
        Dim objFECAEDetRequest As wsfe.FECAEDetRequest = New wsfe.FECAEDetRequest()
        objFECAEDetRequest.Concepto = 2 ' puede ser producto, servicios o ambos. Cedir solo ofrece servicios.
        objFECAEDetRequest.DocTipo = Convert.ToInt16(dict.Item("DocTipo"))
        objFECAEDetRequest.DocNro = Convert.ToInt64(dict.Item("DocNumero"))
        objFECAEDetRequest.CbteFch = dict.Item("CbteFch")
        objFECAEDetRequest.CbteDesde = dict.Item("CbteDesde")
        objFECAEDetRequest.CbteHasta = dict.Item("CbteHasta")
        objFECAEDetRequest.ImpTotal = Convert.ToDouble(dict.Item("ImpTotal"))
        objFECAEDetRequest.ImpTotConc = Convert.ToDouble(dict.Item("ImpTotConc"))
        objFECAEDetRequest.ImpNeto = Convert.ToDouble(dict.Item("ImpNeto"))
        objFECAEDetRequest.ImpOpEx = Convert.ToDouble(dict.Item("ImpOpEx"))
        objFECAEDetRequest.ImpTrib = Convert.ToDouble(dict.Item("ImpTrib"))
        objFECAEDetRequest.ImpIVA = Convert.ToDouble(dict.Item("ImpIVA"))
        objFECAEDetRequest.FchServDesde = dict.Item("FchServDesde")
        objFECAEDetRequest.FchServHasta = dict.Item("FchServHasta")
        objFECAEDetRequest.FchVtoPago = dict.Item("FchVtoPago")
        objFECAEDetRequest.MonId = "PES"
        objFECAEDetRequest.MonCotiz = 1.0

        objFECAEDetRequest.Iva = New wsfe.AlicIva(lineas.Count - 1) {}
        Dim i As Integer = 0
        For i = 0 To lineas.Count - 1
            objFECAEDetRequest.Iva(i) = New wsfe.AlicIva
            objFECAEDetRequest.Iva(i).Id = Convert.ToInt32(lineas(i).Item("Id"))
            objFECAEDetRequest.Iva(i).BaseImp = Convert.ToDecimal(lineas(i).Item("BaseImp"))
            objFECAEDetRequest.Iva(i).Importe = Convert.ToDecimal(lineas(i).Item("Importe"))
        Next
        Dim arrayFECAEDetRequest(0) As wsfe.FECAEDetRequest
        arrayFECAEDetRequest(0) = objFECAEDetRequest

        With fecaeReq
            .FeCabReq = fecaeCabReq
            .FeDetReq = arrayFECAEDetRequest
        End With

        Dim result As New Dictionary(Of String, String)
        Dim message As String = ""
        Try
            fecaeResponse = objWSFE.FECAESolicitar(aut, fecaeReq)

            If fecaeResponse.Errors IsNot Nothing Then
                result("success") = False

                For Each e As wsfe.Err In fecaeResponse.Errors
                    message &= e.Code & ": " & e.Msg & " - "
                Next
                result("message") = message
            End If

            If fecaeResponse.FeDetResp IsNot Nothing Then
                For Each detResponse As wsfe.FECAEDetResponse In fecaeResponse.FeDetResp
                    If detResponse.Resultado = "R" Then  'R significa error.
                        'If detResponse.Observaciones IsNot Nothing Then
                        result("success") = False
                        For Each o As wsfe.Obs In detResponse.Observaciones
                            message &= o.Code & ": " & o.Msg & " - "
                        Next
                        'End If
                    Else
                        result("success") = True
                        result.Add("CAE", detResponse.CAE)
                    End If
                    result("message") = message
                Next
            End If
            Return result
        Catch ex As Exception
            result("success") = False
            result("message") = ex.Message
            Return result
        End Try
    End Function

    Public Sub New()
        'Iniciamos el web service aqui.
        Me.iniciar()
    End Sub

    Public Shared Function GetInstance() As ClienteFE
        _mu.WaitOne()

        Try
            If _singleton Is Nothing Then
                _singleton = New ClienteFE
            End If

        Finally
            _mu.ReleaseMutex()
        End Try

        Return _singleton

    End Function
End Class



