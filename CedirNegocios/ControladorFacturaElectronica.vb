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


End Class
