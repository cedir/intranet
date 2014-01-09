Imports CedirDataAccess
Imports System.Collections.Generic


Public Class ArancelAnestesia
    Private m_id As Integer
    Private m_lista As Integer()
    Private form As String

    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property
    Public Property formula() As String
        Get
            Return form
        End Get
        Set(ByVal value As String)
            form = value
        End Set
    End Property
    Public Property estudios() As Integer()
        Get
            Return m_lista
        End Get
        Set(ByVal value As Integer())
            m_lista = value
        End Set
    End Property

    Public Sub New()

        form = ""
    End Sub

    Public Function isArancel(ByVal arr As Array) As Boolean
        'Ordenamos el array
        Array.Sort(arr)

        'comparamos ahora el array con la lista de estudios de esta clase.
        If Me.estudios.Length <> arr.Length Then
            Return False
        Else
            Dim i As Integer
            For i = 0 To arr.Length - 1
                If arr(i) <> estudios(i) Then
                    Return False
                End If
            Next

        End If
        Return True
    End Function



End Class
