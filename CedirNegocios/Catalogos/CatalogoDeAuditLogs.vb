Imports CedirDataAccess
Imports System.Collections.Generic
Imports Npgsql
Public Class CatalogoDeAuditLogs
    Dim com As String = """"
    Public Function buscar(ByVal userActionId As Integer, ByVal objectTypeId As Integer, ByVal objectId As Integer) As List(Of AuditLog)
        buscar = New List(Of AuditLog)
        Dim cDatos As New Consultas
        Dim dr As NpgsqlDataReader
        dr = cDatos.getAuditLogs(com & "objectTypeId" & com & " = " & CStr(objectTypeId) & " and " & com & "objectId" & com & " = " & CStr(objectId) & " and " & com & "userActionId" & com & " = " & CStr(userActionId))
        While (dr.Read)
            Dim vLog As New AuditLog
            vLog.id = Convert.ToInt64(dr("id"))
            vLog.usuario.id = Convert.ToInt32(dr("idUsuario"))
            vLog.usuario.nombreUsuario = Convert.ToString(dr("nombreUsuario"))
            vLog.objectId = Convert.ToInt64(dr("objectId"))
            vLog.userActionId = Convert.ToInt16(dr("userActionId"))
            vLog.objectTypeId = Convert.ToInt16(dr("objectTypeId"))
            vLog.fechaHora = Convert.ToDateTime(dr("dateTime"))
            vLog.observacion = Convert.ToString(dr("observacion"))
            buscar.Add(vLog)
        End While
    End Function
    Public Function buscarNew(ByVal objectId As Integer, ByVal app As String, ByVal model As String) As List(Of AuditLog)
        buscarNew = New List(Of AuditLog)
        Dim cDatos As New Consultas
        Dim dr As NpgsqlDataReader
        dr = cDatos.getAuditLogsNew(CStr(objectId), app, model)
        While (dr.Read)
            Dim vLog As New AuditLog
            vLog.id = Convert.ToInt64(dr("id"))
            vLog.usuario.id = Convert.ToInt32(dr("idUsuario"))
            vLog.usuario.nombreUsuario = Convert.ToString(dr("nombreUsuario"))
            vLog.objectId = Convert.ToInt64(dr("objectId"))
            vLog.userActionId = Convert.ToInt16(dr("userActionId"))
            vLog.objectTypeId = Convert.ToInt16(dr("objectTypeId"))
            vLog.fechaHora = Convert.ToDateTime(dr("dateTime"))
            vLog.observacion = Convert.ToString(dr("observacion"))
            buscarNew.Add(vLog)
        End While
    End Function
End Class
