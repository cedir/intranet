Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Text
Imports System.Threading
Imports System.Xml


Public Class ClienteFE
    Private Shared _singleton As New Dictionary(Of String, ClienteFE)
    Private Shared _mu As New Mutex
    Dim lt As New LoginTicket
    Dim objWSFE As wsfe.Service = New wsfe.Service()
    Dim aut As wsfe.FEAuthRequest

    Public Const CUR_ARS As String = "PES"

    Public Function iniciar(ByVal responsable As String) As Boolean
        'Llamamos al servicio de autenticacion de afip LoginCMS

        'inicializarombos()
        Try
            InicializarAutenticador(responsable)
            inicializarServicio(responsable)
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
    Private Sub InicializarAutenticador(ByVal responsable As String)
        If lt.ExpirationTime <= DateTime.Now Then
            lt.ObtenerLoginTicketResponse("wsfe", GetKeyLocationFromResponsable(responsable), GetPasswordFromResponsable(responsable))
        End If
    End Sub

    Private Sub inicializarServicio(ByVal responsable As String)
        aut = New wsfe.FEAuthRequest()
        aut.Cuit = GetCUITFromResponsable(responsable)
        aut.Sign = lt.Sign
        aut.Token = lt.Token
    End Sub

    Shared Function GetCUITFromResponsable(ByVal responsable As String) As String
        Try
            Dim config = CType(My.Settings(responsable.ToLower), Global.System.Collections.Specialized.StringCollection)
            Return config.Item(0)
        Catch
            Return String.Empty
        End Try
    End Function

    Shared Function GetPVFromResponsable(ByVal responsable As String) As Integer
        Try
            Dim config = CType(My.Settings(responsable.ToLower), Global.System.Collections.Specialized.StringCollection)
            Return config.Item(1)
        Catch
            Return 0
        End Try
    End Function

    Shared Function GetPasswordFromResponsable(ByVal responsable As String) As String
        Try
            Dim config = CType(My.Settings(responsable.ToLower), Global.System.Collections.Specialized.StringCollection)
            Return config.Item(2)
        Catch
            Return String.Empty
        End Try
    End Function

    Shared Function GetKeyLocationFromResponsable(ByVal responsable As String) As String
        Return String.Format(My.Settings.rutaClaveCertificadoFE, responsable.ToLower)
    End Function

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

    Public Function getUltimoNroComprobante(ByVal nroTerminal As Integer, ByVal cbteTipo As Integer) As Integer

        Dim ultimoComprobante As wsfe.FERecuperaLastCbteResponse = New wsfe.FERecuperaLastCbteResponse()

        Try
            ultimoComprobante = objWSFE.FECompUltimoAutorizado(aut, nroTerminal, cbteTipo)
            Return ultimoComprobante.CbteNro
        Catch ex As Exception
            Throw ex
        End Try

    End Function

    Public Function crearComprobante(ByVal dict As Dictionary(Of String, Object), ByVal lineas As List(Of Dictionary(Of String, Object))) As Object

        'Información del comprobante o lote de comprobantes de ingreso. Contiene los datos de FeCabReq y FeDetReq
        Dim request As New wsfe.FECAERequest
        Dim response As wsfe.FECAEResponse

        'fecaeResponse = New wsfe.FECAEResponse()
        'IMPORTANTE: INSERTAR ULTIMO NRO DE COMPROBANTE +1 ACA!!

        'Información de la cabecera del comprobante o lote de comprobantes de ingreso
        request.FeCabReq = New wsfe.FECAECabRequest()
        With request.FeCabReq
            .PtoVta = Convert.ToInt16(dict.Item("PtoVta"))  'punto de venta factura electronica.
            .CbteTipo = Convert.ToInt16(dict.Item("CbteTipo")) 'tipo de comprobante
            .CantReg = 1 'cant registros del detalle = cant. lineas de comprobante
        End With

        'Información del detalle del comprobante o lote de comprobantes de ingreso
        Dim comprobante As wsfe.FECAEDetRequest = New wsfe.FECAEDetRequest()
        With comprobante
            .Concepto = 2 ' puede ser producto, servicios o ambos. Cedir solo ofrece servicios.
            .DocTipo = Convert.ToInt16(dict.Item("DocTipo"))
            .DocNro = Convert.ToInt64(dict.Item("DocNumero"))
            .CbteFch = dict.Item("CbteFch")
            .CbteDesde = dict.Item("CbteDesde")
            .CbteHasta = dict.Item("CbteHasta")
            .ImpTotal = Convert.ToDouble(dict.Item("ImpTotal"))
            .ImpTotConc = Convert.ToDouble(dict.Item("ImpTotConc"))
            .ImpNeto = Convert.ToDouble(dict.Item("ImpNeto"))
            .ImpOpEx = Convert.ToDouble(dict.Item("ImpOpEx"))
            .ImpTrib = Convert.ToDouble(dict.Item("ImpTrib"))
            .ImpIVA = Convert.ToDouble(dict.Item("ImpIVA"))
            .FchServDesde = dict.Item("FchServDesde")
            .FchServHasta = dict.Item("FchServHasta")
            .FchVtoPago = dict.Item("FchVtoPago")
            .MonId = CUR_ARS
            .MonCotiz = 1.0
            .Iva = New wsfe.AlicIva(0) {}
        End With

        'Todas las líneas poseen el mismo IVA, asi que sumarizamos
        comprobante.Iva(0) = New wsfe.AlicIva
        comprobante.Iva(0).Id = Convert.ToInt32(lineas(0).Item("Id"))
        comprobante.Iva(0).BaseImp = 0
        comprobante.Iva(0).Importe = 0

        Dim i As Integer = 0
        For i = 0 To lineas.Count - 1
            comprobante.Iva(0).BaseImp += Convert.ToDecimal(lineas(i).Item("BaseImp"))
            comprobante.Iva(0).Importe += Convert.ToDecimal(lineas(i).Item("Importe"))
        Next

        request.FeDetReq = New wsfe.FECAEDetRequest() {comprobante}

        Dim result As New Dictionary(Of String, String)
        Dim message As String = ""
        Try
            response = objWSFE.FECAESolicitar(aut, request)

            If response.Errors IsNot Nothing Then
                result("success") = False

                For Each e As wsfe.Err In response.Errors
                    message &= e.Code & ": " & e.Msg & " - "
                Next
                result("message") = message
            End If

            If response.FeDetResp IsNot Nothing Then
                For Each detResponse As wsfe.FECAEDetResponse In response.FeDetResp
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

    Shared Function FormatDate(ByVal value As DateTime) As String
        Return value.ToString("yyyyMMdd")
    End Function

    Public Sub New(ByVal cuenta As String)
        'Iniciamos el web service aqui.
        Me.iniciar(cuenta)
    End Sub

    Public Shared Function GetInstance(ByVal responsable As String) As ClienteFE
        _mu.WaitOne()

        Try
            responsable = responsable.ToLower

            If Not _singleton.ContainsKey(responsable) Then
                _singleton(responsable) = New ClienteFE(responsable)
            End If

        Finally
            _mu.ReleaseMutex()
        End Try

        Return _singleton(responsable)

    End Function
End Class



