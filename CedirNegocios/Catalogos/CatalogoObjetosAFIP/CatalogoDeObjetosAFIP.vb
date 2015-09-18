Imports System.Collections.Generic
Imports CedirDataAccess
Imports Npgsql
Public Class CatalogoDeObjetosAFIP
    Dim com As String = """"

    Public Function getTiposDeComprobanteAFIP() As List(Of TipoDeComprobanteAFIP)
        Dim cDatos As New Consultas
        Dim listTipos As New List(Of TipoDeComprobanteAFIP)
        Dim cTipoComprobante As TipoDeComprobanteAFIP

        Dim dr As NpgsqlDataReader = cDatos.Tabla("cedirData", "AFIP_TipoDeComprobantes", " order by " & com & "id" & com)
        While dr.Read()
            cTipoComprobante = New TipoDeComprobanteAFIP
            cTipoComprobante.Id = dr.Item("id")
            cTipoComprobante.Descripcion = dr.Item("descripcion")
            cTipoComprobante.IdAFIP = dr.Item("idAFIP")
            cTipoComprobante.idTblTipoDeComprobantes = dr.Item("id_tblTipoDeComprobantes")
            cTipoComprobante.SubTipo = dr.Item("subtipo")

            listTipos.Add(cTipoComprobante)
        End While

        Return listTipos

    End Function

    Public Function getTiposDeGravadoAFIP() As List(Of TipoDeGravadoAFIP)
        Dim cDatos As New Consultas
        Dim listTipos As New List(Of TipoDeGravadoAFIP)
        Dim cTipoGravadoAFIP As TipoDeGravadoAFIP

        Dim dr As NpgsqlDataReader = cDatos.Tabla("cedirData", "AFIP_Gravados", " order by " & com & "id" & com)
        While dr.Read()
            cTipoGravadoAFIP = New TipoDeGravadoAFIP
            cTipoGravadoAFIP.id = dr.Item("id")
            cTipoGravadoAFIP.descripcion = dr.Item("descripcion")
            cTipoGravadoAFIP.IdAFIP = dr.Item("idAFIP")
            cTipoGravadoAFIP.idTblGravados = dr.Item("id_tblGravado")
            cTipoGravadoAFIP.porcentaje = dr.Item("porcentaje")
            listTipos.Add(cTipoGravadoAFIP)
        End While

        Return listTipos

    End Function
    Public Function getTiposDeIdentificacionClienteAFIP() As List(Of TipoIdentificacionClienteAFIP)
        Dim cDatos As New Consultas
        Dim listTipos As New List(Of TipoIdentificacionClienteAFIP)
        Dim cTipoIdentificacionCliente As TipoIdentificacionClienteAFIP

        Dim dr As NpgsqlDataReader = cDatos.Tabla("cedirData", "AFIP_TipoDeIdentificacionCliente", " order by " & com & "id" & com)
        While dr.Read()
            cTipoIdentificacionCliente = New TipoIdentificacionClienteAFIP
            cTipoIdentificacionCliente.id = dr.Item("id")
            cTipoIdentificacionCliente.descripcion = dr.Item("descripcion")
            cTipoIdentificacionCliente.idAFIP = Convert.ToInt32(dr.Item("idAFIP"))

            listTipos.Add(cTipoIdentificacionCliente)
        End While

        Return listTipos

    End Function

End Class
