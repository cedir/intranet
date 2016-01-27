Imports System.Threading
Imports System.Configuration
Imports Npgsql
Public Class DbConnectionSingleton
    Private Shared _singleton As DbConnectionSingleton
    Private Shared _mu As New Mutex

    Dim myConnection As NpgsqlConnection
    Private Sub New()
        myConnection = New NpgsqlConnection(ConfigurationManager.ConnectionStrings("Default").ConnectionString)
        myConnection.Open()
    End Sub

    Public Shared Function GetInstance() As DbConnectionSingleton
        _mu.WaitOne()

        Try
            If _singleton Is Nothing Then
                _singleton = New DbConnectionSingleton
            End If

        Finally
            _mu.ReleaseMutex()
        End Try

        Return _singleton

    End Function

    Public Function getDbConnection() As NpgsqlConnection
        'If myConnection.state = 0 Then 'borrar comentario
        'myConnection.Open()
        'End If
        Return myConnection
    End Function

End Class
