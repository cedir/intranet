Imports FacturaElectronica
Imports System.Collections.Generic


Public Class ControladorDeComprobantes

    Dim catObjetosAfip As New CedirNegocios.CatalogoDeObjetosAFIP
    Public Function ObtenerTiposDeIdentificacionDeClienteAFIP() As List(Of TipoIdentificacionClienteAFIP)
        Return Me.catObjetosAfip.getTiposDeIdentificacionClienteAFIP()
    End Function
    Private Function getTiposDeGravadoAFIP() As List(Of TipoDeGravadoAFIP)
        Return Me.catObjetosAfip.getTiposDeGravadoAFIP()
    End Function
    ''' <summary>
    ''' Este metodo decide que tipo de comprobante crear, con los parametros listados. Pudiendo ser electronico o no . 
    ''' Observacion : no es conveniente usar patron factory?
    ''' </summary>
    ''' <param name="terminal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function crearTipoDeComprobanteSegunNroTerminal(ByVal terminal As String) As Comprobante
        Select Case True
            Case (terminal = "0091")
                Return New ComprobanteElectronico
            Case Else
                Return New Comprobante
        End Select
    End Function
    Private Function getTipoDeComprobanteAFIP() As List(Of TipoDeComprobanteAFIP)
        getTipoDeComprobanteAFIP = Me.catObjetosAfip.getTiposDeComprobanteAFIP()
    End Function
    Public Function crearComprobante(ByVal c As Comprobante) As String
        If (c.GetType() Is GetType(ComprobanteElectronico)) Then
            'cargamos los datos al comprobante, con valores que sean homonimos a los nuestros       
            CType(c, ComprobanteElectronico).cargarComprobanteModeloAFIP()
        End If
        Return c.crear().ToString()
    End Function
End Class
