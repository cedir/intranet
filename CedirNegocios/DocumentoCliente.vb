Public Class DocumentoCliente

    Private m_nroDocumento As String
    Private m_descripcion As String
    Private m_idTipoDocumento As Integer

    Public Property idTipoDocumento() As Integer
        Get
            Return m_idTipoDocumento
        End Get
        Set(ByVal value As Integer)
            m_idTipoDocumento = value
        End Set
    End Property
    Public Property NroDocumento() As String
        Get
            Return m_nroDocumento.ToUpper
        End Get
        Set(ByVal value As String)
            m_nroDocumento = value.ToUpper
        End Set
    End Property
    Public Property Descripcion() As String
        Get
            Return m_descripcion.ToUpper
        End Get
        Set(ByVal value As String)
            m_descripcion = value.ToUpper
        End Set
    End Property

End Class
