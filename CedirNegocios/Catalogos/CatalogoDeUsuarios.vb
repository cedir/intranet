Imports CedirDataAccess
Imports Npgsql
Imports System.Collections.Generic
Public Class CatalogoDeUsuarios


    Dim com As String = """"
    Dim da As Consultas
    'Dim daNuevo As Nuevo

    Public Sub New()
        da = New Consultas
        'daNuevo = New Nuevo
    End Sub
    Public Function getUsuario(ByVal nombreUsuario As String, ByVal psw As String) As Usuario
        Dim cUsuario As Usuario
        Dim drUsuarios As NpgsqlDataReader = da.Tabla("webData", "tblUsuarios", " where " & com & "nombreUsuario" & com & " = '" & nombreUsuario & "' and " & com & "password" & com & " = '" & psw & "'")

        While drUsuarios.Read()
            cUsuario = New Usuario
            cUsuario.id = drUsuarios.Item(0)
            cUsuario.nombreUsuario = drUsuarios.Item(1)
            cUsuario.password = drUsuarios.Item(2)
            cUsuario.idMedico = drUsuarios.Item(3)
        End While

        Return cUsuario
    End Function

    Public Function getAll() As List(Of Usuario)
        Dim arrUsers As New List(Of Usuario)
        Dim cUsuario As Usuario
        Dim drUsuarios As NpgsqlDataReader = da.Tabla("webData", "tblUsuarios", " order by " & com & "nombreUsuario" & com)
        While drUsuarios.Read()
            cUsuario = New Usuario
            cUsuario.id = drUsuarios.Item(0)
            cUsuario.nombreUsuario = drUsuarios.Item(1)
            cUsuario.password = drUsuarios.Item(2)
            cUsuario.idMedico = drUsuarios.Item(3)
            arrUsers.Add(cUsuario)
        End While

        Return arrUsers

    End Function

End Class
