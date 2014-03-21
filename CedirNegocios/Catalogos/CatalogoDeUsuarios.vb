Imports CedirDataAccess
Imports Npgsql
Imports System.Collections.Generic
Public Class CatalogoDeUsuarios

    Dim com As String = """"
    Dim m_usuarioActual As Usuario
    Dim da As Consultas
    Public Property usuarioActual() As Usuario
        Get
            Return Me.m_usuarioActual
        End Get
        Set(ByVal value As Usuario)
            m_usuarioActual = value
        End Set
    End Property



    Public Sub New()
        da = New Consultas
    End Sub
    Public Function getUsuario(ByVal nombreUsuario As String, ByVal psw As String) As Usuario
        Dim cUsuario As Usuario
        Dim drUsuarios As NpgsqlDataReader = da.Tabla("webData", "tblUsuarios", " where " & com & "nombreUsuario" & com & " = '" & nombreUsuario & "' and " & com & "password" & com & " = '" & psw & "' ")
        While drUsuarios.Read()
            cUsuario = New Usuario
            cUsuario.id = drUsuarios.Item(0)
            cUsuario.nombreUsuario = drUsuarios.Item(1)
            cUsuario.password = drUsuarios.Item(2)
            cUsuario.idMedico = drUsuarios.Item(3)
        End While

        Return cUsuario
    End Function
    Public Function nameExists(ByVal nombreUsuarioAValidar As String) As Boolean
        nameExists = False
        Dim drUsuarios As NpgsqlDataReader = da.Tabla("webData", "tblUsuarios", " where " & com & "nombreUsuario" & com & " = '" & nombreUsuarioAValidar & "' and " & com & "idUsuario" & com & " <> " & Me.usuarioActual.id)
        While drUsuarios.Read()
            nameExists = True
        End While
        Return nameExists
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
