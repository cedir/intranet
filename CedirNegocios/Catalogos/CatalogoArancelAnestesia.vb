Imports CedirDataAccess
Imports Npgsql
Imports System.Collections.Generic
Public Class CatalogoArancelAnestesia

    Private colAranceles As New List(Of ArancelAnestesia)

    Public Function getAll() As List(Of ArancelAnestesia)
        'este metodo devuelve todas las filas de la tabla tblComplejidadEstudios
        'tenemos que crear una instancia de arancelAnestesia e ir agregandola a la lista
        Dim cDatos As New Consultas
        Dim dr As NpgsqlDataReader
        dr = cDatos.getAll("tblComplejidadEstudios")
        While dr.Read()
            Dim a As New ArancelAnestesia
            Dim s As String = dr("estudios")
            Dim complejidades() As String = s.Split(",")
            Dim i As Integer = 0
            'cargamos los ids de los distintos estudios
            ReDim a.estudios(complejidades.Length - 1)
            For i = 0 To complejidades.Length - 1
                a.estudios(i) = Convert.ToInt32(complejidades(i))
            Next
            'ahora ordenamos la coleccion de estudios
            Array.Sort(a.estudios)
            a.formula = dr("formula")
            colAranceles.Add(a)
        End While

        Return colAranceles
    End Function
  
End Class
