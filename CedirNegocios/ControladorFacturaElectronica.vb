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


    Private Sub devolverIdComprobante(ByVal tipoComprobante As String)
        'este medoto recibe el nombre del comprobante guardado en base de datos. 
        'Y busca en el servicio AFIP, el id del comprobante que corresponde.


    End Sub

End Class