Public Class Grupo
    Dim com As String = """"
    Private m_idGrupo As Integer
    Private m_nombre As String
    Public Property id() As Integer
        Get
            id = m_idGrupo
        End Get
        Set(ByVal Value As Integer)
            m_idGrupo = Value
        End Set
    End Property

    Public Property nombre() As String
        Get
            nombre = m_nombre
        End Get
        Set(ByVal Value As String)
            m_nombre = Value
        End Set
    End Property
End Class
