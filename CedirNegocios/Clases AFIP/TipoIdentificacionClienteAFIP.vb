Public Class TipoIdentificacionClienteAFIP

    Private m_id As Integer
    Private m_idAFIP As Integer
    Private m_descripcion As String
    Public Property id() As Integer
        Get
            id = m_id
        End Get
        Set(ByVal Value As Integer)
            m_id = Value
        End Set
    End Property
    Public Property idAFIP() As Integer
        Get
            id = m_idAFIP
        End Get
        Set(ByVal Value As Integer)
            m_idAFIP = Value
        End Set
    End Property
    'CUIT, DNI, CUIL, ETC..
    Public Property descripcion() As String
        Get
            descripcion = m_descripcion
        End Get
        Set(ByVal Value As String)
            m_descripcion = Value
        End Set
    End Property
End Class
