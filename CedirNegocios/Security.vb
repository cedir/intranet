Imports System.Threading
Imports Npgsql

Public Class Security
    Private Shared _security As Security
    Private Shared _mu As New Mutex

    Dim s_usuario As Usuario = Nothing
    Private Sub New()
        'se llama solo una vez
    End Sub

    Public Shared Function GetInstance() As Security
        _mu.WaitOne()

        Try
            If _security Is Nothing Then
                _security = New Security
            End If

        Finally
            _mu.ReleaseMutex()
        End Try

        Return _security

    End Function

    Public Function setLoggedUser(ByVal cUsuario As Usuario)
        s_usuario = cUsuario
    End Function
    Public Function getLoggedUser() As Usuario
        Return s_usuario
    End Function

    Public Function logOutUser() As Boolean
        s_usuario = Nothing
    End Function
End Class
