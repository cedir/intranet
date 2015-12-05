Public Class ManagerComprobante
    Public Function crearTipoDeComprobanteSegunNroTerminal(ByVal terminal As String) As Comprobante
        Select Case True
            Case (terminal = "0091")
                Return New ComprobanteElectronico
            Case Else
                Return New Comprobante
        End Select
    End Function
End Class
