Imports CedirDataAccess

Public Class TipoComprobante

    Private m_id As Integer
    Private m_desc As String
    Private m_subTipo As String



    Public Sub New()
        Me.Descripcion = ""
        Me.Id = Nothing
    End Sub

    Public Property Id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value
        End Set
    End Property
    Public Property SubTipo() As String
        Get
            Return m_subTipo
        End Get
        Set(ByVal value As String)
            m_subTipo = value
        End Set
    End Property





End Class
