Public Class TipoDeGravadoAFIP
    Inherits Gravado

    Private m_idAFIP As Integer
    Public Property IdAFIP() As Integer
        Get
            Return m_idAFIP
        End Get
        Set(ByVal value As Integer)
            m_idAFIP = value
        End Set
    End Property

End Class
