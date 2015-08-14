Imports System.Collections.Generic
Imports FacturaElectronica
Public Class ComprobanteElectronico
    Inherits Comprobante

    Dim _cae As String
    Public Property CAE() As String
        Get
            Return _cae
        End Get
        Set(ByVal value As String)
            _cae = value
        End Set
    End Property

    Dim clienteFE As New ClienteFE

    Public Overrides Function crear() As Object



        clienteFE.crearComprobante(Me.convertirADictionary())
        If nofalla Then
            Return MyBase.crear()
        Else

        End If
        log()
        'llamamos a la clase padre, para insertar el comprobante en base de datos. 

    End Function
    Private Function convertirADictionary() As Dictionary(Of String, Object)


        convertirADictionary = New Dictionary(Of String, Object)





        Return convertirADictionary


    End Function

End Class
