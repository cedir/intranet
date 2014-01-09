Imports CedirDataAccess
Imports System.Collections.Generic
Imports Npgsql
Public Class CatalogoDeTipoDeMovimientosDeCaja

    Public Function getAll() As List(Of TipoDeMovimientoDeCaja)
        getAll = New List(Of TipoDeMovimientoDeCaja)
        Dim cDatos As New Consultas
        Dim dr As NpgsqlDataReader
        dr = cDatos.getAll("tblCajaTipoDeMovimientos")
        While (dr.Read)
            Dim c As New TipoDeMovimientoDeCaja
            c.Id = Convert.ToInt32(dr("id"))
            c.descripcion = Convert.ToString(dr("descripcion"))
            getAll.Add(c)
        End While
    End Function

End Class
