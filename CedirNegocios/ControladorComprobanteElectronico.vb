Imports FacturaElectronica
Imports System.Collections.Generic


Public Class ControladorComprobanteElectronico

#Region "Propiedades"
    Private m_ClienteFE As ClienteFE
    Public Property clienteFE() As ClienteFE
        Get
            Return m_ClienteFE
        End Get
        Set(ByVal value As ClienteFE)
            m_ClienteFE = value
        End Set
    End Property
#End Region


    Public Sub New()
        Me.clienteFE = New ClienteFE()
        clienteFE.iniciar()
    End Sub
    Public Function ObtenerUltimoNro(ByVal tipoComprobante As String, ByVal nroTerminal As Integer, ByVal subtipo As String) As String
        Return clienteFE.getUltimoNroComprobante(tipoComprobante, nroTerminal, subtipo)
    End Function
    Public Function ObtenerTiposDeDocumentoCliente() As Dictionary(Of Integer, String)
        Return clienteFE.getTiposDeDocumentoCliente()
    End Function
    ''' <summary>
    ''' Este metodo decide que tipo de comprobante crear, con los parametros listados. Pudiendo ser electronico o no . 
    ''' 
    ''' Observacion : no es conveniente usar patron factory?
    ''' </summary>
    ''' <param name="terminal"></param>
    ''' <param name="subtipo"></param>
    ''' <param name="responsable"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function crearComprobante(ByVal terminal As String, ByVal tipoComprobante As TipoComprobante, ByVal subtipo As String, ByVal responsable As String) As Comprobante
        Select Case True
            Case (terminal = "0091" And subtipo = "A" And responsable.ToUpper().Trim() = "CEDIR")
                Return New ComprobanteElectronico

            Case Else
                Return New Comprobante
        End Select

    End Function

    Public Function getTipoDeComprobanteAFIP(ByVal descripcionTipoComprobante As String, ByVal subtipo As String) As Integer
        Dim dic As New Dictionary(Of Integer, String)
        dic = Me.clienteFE.getTipoComprobante()

        Dim pair As KeyValuePair(Of Integer, String)
        For Each pair In dic
            If pair.Value.ToLower.Trim() = String.Concat(descripcionTipoComprobante.ToLower.Trim(), " ", subtipo.ToLower()) Then
                Return pair.Key
            End If
        Next
        Return 0
    End Function

End Class
