Imports System.Collections.Generic
Imports Npgsql
Imports CedirDataAccess

Public Class CatalogoDeComplejidades

    Public Function getAll() As List(Of Complejidad)
        Dim cDatos As New Consultas
        Dim col As New List(Of Complejidad)
        Try
            Dim dr As NpgsqlDataReader
            dr = cDatos.getAll("tblComplejidades", , " order by id")

            While dr.Read
                Dim c As New Complejidad
                c.id = Convert.ToInt32(dr("id"))
                c.importe = Convert.ToDecimal(dr("importe"))

                col.Add(c)
            End While

            Return col
        Catch ex As Exception

        Finally
            cDatos = Nothing
            col = Nothing
        End Try
    End Function
    Public Function eliminar(ByVal c As Complejidad) As String
        Dim cDatos As New Nuevo
        Try

            Return cDatos.delete("tblComplejidades", " id = " & c.id)
        Catch
            Return "Insert Not Ok"
        Finally
            cDatos = Nothing
        End Try
    End Function

End Class




