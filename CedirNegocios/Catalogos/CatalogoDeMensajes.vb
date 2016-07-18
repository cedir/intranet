Imports System.Collections.Generic
Imports CedirDataAccess
Imports Npgsql

Public Class CatalogoDeMensajes
    Dim com As String = """"
    Dim da As Consultas
    Public Sub New()
        da = New Consultas
    End Sub
    Public Function traerMensajes(Optional ByVal estado As Integer = 0, Optional ByVal todos As Boolean = False) As List(Of Mensaje)
        Dim drMensajes As NpgsqlDataReader
        Dim vMensaje As Mensaje

        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser

        Dim condicion As String = " where " & com & "idReceptor" & com & " = " & cUsuario.id
        Dim inner As String = " inner join " & com & "webData" & com & "." & com & "tblUsuarios" & com & " on " & com & "idEmisor" & com & " = " & com & "idUsuario" & com
        Dim c2 As String = " and estado = " & estado
        Dim order As String = " order by " & com & "fecha" & com & " desc"

        Dim sel As String
        If todos Then
            sel = inner & condicion & order
        Else
            sel = inner & condicion & c2 & order
        End If

        drMensajes = da.Tabla("tblMensajes", sel)
        traerMensajes = New List(Of Mensaje)
        While drMensajes.Read
            vMensaje = New Mensaje
            vMensaje.idMensaje = drMensajes.Item("idMensaje")
            vMensaje.mensaje = drMensajes.Item("mensaje")
            vMensaje.fecha = drMensajes.Item("fecha")
            vMensaje.hora = drMensajes.Item("hora")
            vMensaje.estado = drMensajes.Item("estado")
            'del emisor solo cargo id+nombre
            vMensaje.emisor.id = drMensajes.Item("idUsuario")
            vMensaje.emisor.nombreUsuario = drMensajes.Item("nombreUsuario")
            'el usuario siempre es el destinatario de estos mensajes
            vMensaje.destinatarios.Add(cUsuario)
            traerMensajes.Add(vMensaje)
        End While
        drMensajes.Close()

    End Function
    Public Function nuevoMensaje(ByVal mensaje As Mensaje) As String

        Dim nuevo As New Nuevo
        Dim resp As String
        Try
            Dim sSecurity As Security = Security.GetInstance()
            Dim cUsuario As Usuario = sSecurity.getLoggedUser

            mensaje.emisor = cUsuario
            'tenemos que hacer un insert por cada destinatario
            For Each usr As Usuario In mensaje.destinatarios
                resp = nuevo.insert(com & "public" & com & "." & com & "tblMensajes" & com, com & "mensaje" & com & ", " & com & "estado" & com & ", " & com & "fecha" & com & ", " & com & "hora" & com & ", " & com & "idEmisor" & com & ", " & com & "idReceptor" & com, "'" & mensaje.mensaje & "', " & 0 & ", '" & mensaje.fecha & "', '" & mensaje.hora & "', " & mensaje.emisor.id & ", " & usr.id)
            Next
            Return resp

        Catch ex As Exception
            Return ex.Message

        Finally
            nuevo = Nothing
        End Try



    End Function
End Class
