Imports CedirDataAccess
Imports System.Collections.Generic
Imports Npgsql

Public Class CatalogoDeGravados

    Private m_gravados As New List(Of Gravado)

    Public Property gravados() As List(Of Gravado)
        Get
            Return m_gravados
        End Get
        Set(ByVal value As List(Of Gravado))
            m_gravados = value
        End Set
    End Property


    Public Function getGravadosAll() As List(Of Gravado)
        Dim com As String = """"
        Dim cDatos As New Consultas
        Dim dr As NpgsqlDataReader
        getGravadosAll = New List(Of Gravado)

        Try
            Dim query As String = "select * from " & com & "public" & com & "." & com & "tblGravado" & com
            dr = cDatos.EjecutarSelect(query)
            While (dr.Read)
                Dim g As New Gravado
                g.id = Convert.ToInt32(dr("id"))
                g.descripcion = Convert.ToString(dr("descripcionGravado"))
                g.porcentaje = Convert.ToDecimal(dr("porcentajeGravado"))
                getGravadosAll.Add(g)
                g = Nothing
            End While

        Catch ex As Exception

        Finally
            cDatos = Nothing
            dr = Nothing
        End Try

    End Function
    
End Class
