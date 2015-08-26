Imports FacturaElectronica
Imports System.Collections.Generic


Public Class ControladorFacturaElectronica

    Private m_ClienteFE As ClienteFE

    Public Property clienteFE() As ClienteFE
        Get
            Return m_ClienteFE
        End Get
        Set(ByVal value As ClienteFE)
            m_ClienteFE = value
        End Set
    End Property
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
    ''' </summary>
    ''' <param name="terminal"></param>
    ''' <param name="subtipo"></param>
    ''' <param name="responsable"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function crearComprobante(ByVal terminal As String, ByVal subtipo As String, ByVal responsable As String) As Comprobante
        Select Case True
            Case (terminal = "0091" And subtipo = "A" And responsable.ToUpper().Trim() = "CEDIR")
                Return New ComprobanteElectronico
            Case Else
                Return New Comprobante
        End Select

    End Function


End Class
