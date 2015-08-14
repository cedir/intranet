Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Xml


Public Class ClienteFE


    Dim lt As New LoginTicket
    Dim objWSFE As wsfe.Service = New wsfe.Service()
    Dim aut As wsfe.FEAuthRequest
    Dim fecaeReq As wsfe.FECAERequest




    Public Function iniciar() As Boolean
        'Llamamos al servicio de autenticacion de afip LoginCMS

        'inicializarombos()
        Try
            InicializarAutenticador()
            inicializarServicio()
            Return True

        Catch ex As Exception
            Throw ex
        End Try
        'InicializarFactura()
    End Function
    ''' <summary>
    ''' Prueba para crear un comprobante "directo" a AFIP
    ''' </summary>
    ''' <remarks></remarks>
    

    Private Sub InicializarAutenticador()

        lt.ObtenerLoginTicketResponse("wsfe", "https://wsaahomo.afip.gov.ar/ws/services/LoginCms?wsdl", My.Settings.rutaClaveCertificadoFE)

    End Sub

    Private Sub inicializarServicio()

        aut = New wsfe.FEAuthRequest()
        aut.Cuit = 30709300152
        aut.Sign = lt.Sign
        aut.Token = lt.Token

    End Sub

    Private Sub inicializarCombos()

        Me.getIVA()
        Me.getTipoMoneda()
        Me.getTiposComprobante()
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

    Private Sub getIVA()

        Dim objIvaTipo As wsfe.IvaTipoResponse = New wsfe.IvaTipoResponse()
        objIvaTipo = objWSFE.FEParamGetTiposIva(aut)
        If (objIvaTipo.Errors Is Nothing) Then

            'this.cmbIva.DisplayMember = "Desc"
            'this.cmbIva.ValueMember = "Id"

            'cmbIva.DataSource = objIvaTipo.ResultGet



        Else
            Dim i As Integer = 0
            For i = 0 To (objIvaTipo.ResultGet.Length - 1)

                '   MessageBox.Show(objIvaTipo.ResultGet(i).Desc)
            Next

        End If


    End Sub

    Private Sub getTiposComprobante()


        Dim objCbteTipo As wsfe.CbteTipoResponse = New wsfe.CbteTipoResponse()
        objCbteTipo = objWSFE.FEParamGetTiposCbte(aut)
        If (objCbteTipo.Errors IsNot Nothing) Then
            '  MessageBox.Show("No se pudieron obtener datos del ws" + objCbteTipo.Errors[0].Msg )

        Else
            'this.cmbTipoComprobante.DisplayMember = "Desc"
            'this.cmbTipoComprobante.ValueMember = "Id"

            'cmbTipoComprobante.DataSource = objCbteTipo.ResultGet


        End If

    End Sub

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

    Private Function getTipoComprobante() As Dictionary(Of Integer, String)

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




    Public Sub crearComprobante(ByVal dict As Dictionary(Of String, Object))


        'Información del comprobante o lote de comprobantes de ingreso. Contiene los datos de FeCabReq y FeDetReq
        fecaeReq = New wsfe.FECAERequest()
        'Información de la cabecera del comprobante o lote de comprobantes de ingreso
        Dim fecaeCabReq As wsfe.FECAECabRequest = New wsfe.FECAECabRequest()
        fecaeCabReq.PtoVta = Convert.ToInt16(dict.Item("PtoVta"))  'punto de venta factura electronica.
        fecaeCabReq.CbteTipo = Convert.ToInt16(dict.Item("CbteTipo")) 'Convert.ToInt32(this.cmbTipoComprobante.SelectedValue) //tipo de comprobante
        fecaeCabReq.CantReg = 1 'cant registros del detalle. AGREGAR UN PARAMETRO CON LAS LINEAS DE COMPROBANTE

        fecaeReq.FeCabReq = fecaeCabReq

        'Información del detalle del comprobante o lote de comprobantes de ingreso
        Dim objFECAEDetRequest As wsfe.FECAEDetRequest = New wsfe.FECAEDetRequest()
        objFECAEDetRequest.Concepto = 2 ' puede ser producto, servicios o ambos. Cedir solo ofrece servicios.
        objFECAEDetRequest.DocTipo = Convert.ToInt16(dict.Item("DocTipo")) ' //tipo id del comprador. CUIT/DNI/ETC
        objFECAEDetRequest.DocNro = Convert.ToInt16(dict.Item("DocTipo")) 'nro id del comprador
        objFECAEDetRequest.CbteDesde = 1 'nro de comprobante desde
        objFECAEDetRequest.CbteHasta = 1 'nro de comprobante desde
        objFECAEDetRequest.CbteFch = DateTime.Today.ToString("yyyyMMdd") 'fecha de hoy
        objFECAEDetRequest.ImpTotal = Convert.ToDouble(dict.Item("ImpTotal"))
        objFECAEDetRequest.ImpTotConc = Convert.ToDouble(dict.Item("ImpTotalConciliado"))
        objFECAEDetRequest.ImpNeto = Convert.ToDouble(dict.Item("ImpNeto"))
        objFECAEDetRequest.ImpOpEx = Convert.ToDouble(dict.Item("ImpOpEx"))
        objFECAEDetRequest.ImpTrib = Convert.ToDouble(dict.Item("ImpTrib"))
        objFECAEDetRequest.ImpIVA = Convert.ToDouble(dict.Item("ImpIVA"))
        objFECAEDetRequest.FchServDesde = DateTime.Today.ToString()
        objFECAEDetRequest.FchServHasta = DateTime.Today.ToString()
        objFECAEDetRequest.FchVtoPago = (DateTime.Today).AddDays(30).ToString()
        objFECAEDetRequest.MonId = "PES" 'Me.cmbTipoMoneda.SelectedValue.ToString()
        objFECAEDetRequest.MonCotiz = 1.0


        Dim arrayFECAEDetRequest(0) As wsfe.FECAEDetRequest
        arrayFECAEDetRequest(0) = objFECAEDetRequest



    End Sub

    Public Sub New()

    End Sub
End Class



'#Region "eventos"
'        private void cmbTipoMoneda_SelectedIndexChanged(object sender, EventArgs e)
'        {
'            MessageBox.Show(this.cmbTipoMoneda.SelectedValue.ToString())
'        }

'        private void btnIniciarFactura_Click(object sender, EventArgs e)
'        {
'            this.InicializarFactura()
'            this.solicitarCAE()
'        }

'        private void solicitarCAE()
'        {

'            wsfe.FECAEResponse(objFECAEResponse = New wsfe.FECAEResponse())
'            objFECAEResponse = objWSFE.FECAESolicitar(aut, fecaeReq)

'            if (objFECAEResponse != null && objFECAEResponse.FeDetResp[0].Observaciones !=null )
'            {
'                MessageBox.Show(objFECAEResponse.FeDetResp[0].Observaciones[0].Msg)
'            }
'            if (objFECAEResponse.Errors != null )
'            {
'                MessageBox.Show(objFECAEResponse.Errors[0].Msg )

'            }
'            if (objFECAEResponse.Events != null )
'            {
'                MessageBox.Show(objFECAEResponse.Events[0].Msg )

'            }

'            MessageBox.Show(objFECAEResponse.FeDetResp[0].Observaciones[0].Msg  )
'            // Dim objFECAEResponse As New wsfev1.FECAEResponse

'            //  objFECAEResponse = objWSFEV1.FECAESolicitar(FEAuthRequest, objFECAERequest)
'            //If objFECAEResponse IsNot Nothing Then
'            //    'Serialize object to a text file.
'            //    Dim objStreamWriter As New StreamWriter("C:\WSFEV1_objFECAEResponse.xml")
'            //    Dim x As New XmlSerializer(objFECAEResponse.GetType)
'            //    x.Serialize(objStreamWriter, objFECAEResponse)
'            //    objStreamWriter.Close()
'            //    MessageBox.Show("Se generó el archivo C:\WSFEV1_objFECAEResponse.xml")
'            //End If
'            //If objFECAEResponse.Errors IsNot Nothing Then
'            //    For i = 0 To objFECAEResponse.Errors.Length - 1
'            //        MessageBox.Show("objFECAEResponse.Errors(i).Code: " + objFECAEResponse.Errors(i).Code.ToString + vbCrLf +
'            //        "objFECAEResponse.Errors(i).Msg: " + objFECAEResponse.Errors(i).Msg)
'            //    Next
'            //End If
'            //If objFECAEResponse.Events IsNot Nothing Then
'            //    For i = 0 To objFECAEResponse.Events.Length - 1
'            //        MessageBox.Show("objFECAEResponse.Events(i).Code: " + objFECAEResponse.Events(i).Code.ToString + vbCrLf +
'            //        "objFECAEResponse.Events(i).Msg: " + objFECAEResponse.Events(i).Msg)
'            //    Next
'            //End If

'        }

'        #endregion



