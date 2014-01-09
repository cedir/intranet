Public Class Gravado

    Private m_id As Integer
    Private m_desc As String
    Private m_porc As Decimal

#Region "PROPIEDADES"
    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value.Trim
        End Set
    End Property
    Public Property porcentaje() As Decimal
        Get
            Return m_porc
        End Get
        Set(ByVal value As Decimal)
            m_porc = value
        End Set
    End Property
    Public ReadOnly Property Self() As Gravado
        Get
            Return Me
        End Get
    End Property
#End Region

End Class
