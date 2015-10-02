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

    Private m_idTblGravado As Integer
    Public Property idTblGravados() As Integer
        Get
            Return m_idTblGravado
        End Get
        Set(ByVal value As Integer)
            m_idTblGravado = value
        End Set
    End Property

End Class
