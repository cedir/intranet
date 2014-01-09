Imports CedirDataAccess
Imports System.Collections.Generic
Imports Npgsql

Public Class CatalogoDeTiposComprobante


    Public Function getTiposComprobante() As List(Of TipoComprobante)
        getTiposComprobante = New List(Of TipoComprobante)
        Dim dr As NpgsqlDataReader
        Dim cDatos As New Consultas

        Try
            dr = cDatos.getComprobantesTipos
            Do While (dr.Read)
                Dim t As New TipoComprobante
                t.Id = dr("id")
                t.Descripcion = dr("tipoComprobante")
                getTiposComprobante.Add(t)
            Loop

        Catch ex As Exception

        Finally

        End Try

    End Function

End Class
