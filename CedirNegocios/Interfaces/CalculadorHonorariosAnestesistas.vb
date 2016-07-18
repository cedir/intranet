Imports System.Collections.Generic
Imports NCalc

Public Class CalculadorHonorariosAnestesistas
    Implements ICalculadorHonorarios



    Private colComplejidades As New List(Of Complejidad)
    Private colArancelAnestesia As New List(Of ArancelAnestesia)
    Private colEstudiosConPagoParticular As New List(Of Estudio)
    Public Property EstudiosConPagoParticular() As List(Of Estudio)
        Get
            Return colEstudiosConPagoParticular
        End Get
        Set(ByVal value As List(Of Estudio))
            colEstudiosConPagoParticular = value
        End Set
    End Property


    Public Sub New()
        'traemos todas las complejidades y sus formulas.
        Dim cCat As New CatalogoDeComplejidades
        Dim cCatA As New CatalogoArancelAnestesia
        Try
            'las complejidades son el Maestro. poseen precio.(tabla tblComplejidaad)
            colComplejidades = cCat.getAll()
            'los aranceles poseen las distintas colecciones de practicas y los respectivos importes de complejidad(tblComplejidadEstudios)
            colArancelAnestesia = cCatA.getAll()
        Catch ex As Exception

        Finally
            cCat = Nothing
            cCatA = Nothing
        End Try

    End Sub

    Public Function getHonorarios(ByVal estudios As ArrayList) As Decimal()
        'pseudo-codigo
        'voy a devolver un array de importes. 0 para los primeros estudios del paciente
        'y recien en el ultimo voy a cargar los honorarios para esa fecha
        Dim t() As Decimal
        ReDim t(estudios.Count - 1)


        'arreglo de los estudios por paciente
        Dim arrEstudios As New List(Of Estudio)
        Dim pac As Paciente = estudios(0).paciente

        Dim i As Integer
        For i = 0 To estudios.Count - 1
            Dim pacEstudio As New Paciente
            pacEstudio = CType(estudios(i).paciente, Paciente)
            If (pacEstudio.dni = pac.dni) Then ' comparar por id si dni esta vacio
                arrEstudios.Add(estudios(i))
            Else
                'si ya no es el mismo paciente, calculo los honorarios
                'del arreglo anterior,y lo cargo a t()
                t(i - 1) = getImporteComplejidad(arrEstudios)
                'tengo que hacer algo con el importe de la complejidad y luego sigo
                pac = estudios(i).paciente
                arrEstudios.Clear()
                arrEstudios.Add(estudios(i))
            End If
        Next
        'hasta aca tenemos cargados hasta el ultimo estudio en t
        'pero me falta justamente cargar el ultimo importe
        If arrEstudios.Count > 0 Then
            t(estudios.Count - 1) = getImporteComplejidad(arrEstudios)
            arrEstudios.Clear()
        End If
        'ahora tenemos que ver que vamos a devolver , si el importe o algun 
        'arreglo de importes
        arrEstudios = Nothing
        'devolvemos el array de importes calculados
        Return t

    End Function

    Public Function getImporteComplejidad(ByVal colEstudios As List(Of Estudio)) As Decimal
        Dim arr() As Integer
        Dim i As Integer = 0
        'tabla para guardar los id's
        ReDim arr(colEstudios.Count - 1)
        'aca guardo solo los id's de los estudios
        For Each est As Estudio In colEstudios
            arr(i) = est.practica.idEstudio
            i += 1
        Next

        For Each a As ArancelAnestesia In Me.colArancelAnestesia
            If a.isArancel(arr) Then
                Return Me.getImporteFormula(a.formula)
                Exit For
            End If
        Next
    End Function

    ''' <summary>
    ''' Este metodo devuelve el importe actual de los estudios que son pagados
    ''' de modo particular
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getImporteEstudiosConPagosEnFormaParticular() As Decimal
        Dim col As New List(Of Complejidad)
        Dim c As New CatalogoDeComplejidades
        Try
            col = c.getAll()
            ' actualmente, el importe es el de complejidad uno
            For Each o As Complejidad In col
                If o.id = 1 Then
                    Return o.importe
                    Exit For
                End If
            Next
        Catch ex As Exception
            Return ex.Message
        Finally
            col = Nothing
            c = Nothing
        End Try



    End Function


    Private Function getImporteFormula(ByVal formula As String) As Decimal
        'esta funcion lo que hace es transformar el string del arancel que tiene la formula
        'a aplicar, y luego devuelve ese importe, el cual esta en el maestro complejidades

        Dim suma As Decimal = 0
        formula = formula.Replace("c1", colComplejidades(0).importe.ToString())
        formula = formula.Replace("c2", colComplejidades(1).importe.ToString())
        formula = formula.Replace("c3", colComplejidades(2).importe.ToString())
        formula = formula.Replace("c4", colComplejidades(3).importe.ToString())
        formula = formula.Replace("c5", colComplejidades(4).importe.ToString())
        formula = formula.Replace("c6", colComplejidades(5).importe.ToString())

        Dim expr As New Expression(formula)
        Return expr.Evaluate()
    End Function

End Class
