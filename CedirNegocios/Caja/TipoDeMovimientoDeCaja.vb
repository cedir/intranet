Public Class TipoDeMovimientoDeCaja

    Private m_id As Integer
    Private m_desc As String

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
            m_desc = value
        End Set
    End Property


    Public ReadOnly Property Self() As TipoDeMovimientoDeCaja
        Get
            Return Me
        End Get
    End Property


#Region "CONSTRUCTOR"
    Public Sub New()
        descripcion = ""
    End Sub
#End Region


    Public Overrides Function ToString() As String
        Return Me.descripcion
    End Function


End Class
