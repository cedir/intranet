Imports FacturaElectronica
Imports System.Collections.Generic


Public Class ControladorComprobanteElectronico

    Dim catObjetosAfip As New CedirNegocios.CatalogoDeObjetosAFIP
    Private m_ClienteFE As ClienteFE

#Region "Propiedades"
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

    Public Function ObtenerTiposDeIdentificacionDeClienteAFIP() As List(Of TipoIdentificacionClienteAFIP)
        Return Me.catObjetosAfip.getTiposDeIdentificacionClienteAFIP()
    End Function
    Private Function getTiposDeGravadoAFIP() As List(Of TipoDeGravadoAFIP)
        Return Me.catObjetosAfip.getTiposDeGravadoAFIP()
    End Function
    ''' <summary>
    ''' Este metodo decide que tipo de comprobante crear, con los parametros listados. Pudiendo ser electronico o no . 
    ''' 
    ''' Observacion : no es conveniente usar patron factory?
    ''' </summary>
    ''' <param name="terminal"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function crearComprobante(ByVal terminal As String) As Comprobante
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

    ''' <summary>
    ''' metodo para cargar el comprobante con los datos que poseemos de AFIP, y 
    ''' convertir los que nosotros usamos en base de datos, que estan cargados en el objeto comprobante
    ''' </summary>
    ''' <param name="comprobante"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function cargarComprobanteModeloAFIP(ByVal comprobante As ComprobanteElectronico) As ComprobanteElectronico

        'El nro de documento, es cargado en la vista. No hace falta identificarlo. 

        For Each tipoGravadoAFIP As TipoDeGravadoAFIP In Me.getTiposDeGravadoAFIP
            If comprobante.Gravado.id = tipoGravadoAFIP.idTblGravados Then
                comprobante.gravadoAFIP = tipoGravadoAFIP
                Exit For
            End If
        Next

        For Each tipoCompAFIP As TipoDeComprobanteAFIP In Me.getTipoDeComprobanteAFIP
            If comprobante.tipoComprobanteAFIP.Id = tipoCompAFIP.idTblTipoDeComprobantes Then
                comprobante.tipoComprobanteAFIP = tipoCompAFIP
            End If
        Next


        Return comprobante
    End Function
End Class
