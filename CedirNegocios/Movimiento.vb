Public Class Movimiento

#Region "PROPIEDADES"
    Private m_id As Integer
    Private m_fecha As Date
    Private m_hora As String
    Private m_usr As Usuario

    Public Property Id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property
    Public Property Usuario() As Usuario
        Get
            Return m_usr
        End Get
        Set(ByVal value As Usuario)
            m_usr = value
        End Set
    End Property
    Public Property Fecha() As Date
        Get
            Return m_fecha
        End Get
        Set(ByVal value As Date)
            m_fecha = value
        End Set
    End Property
    Public Property Hora() As String
        Get
            Return m_hora
        End Get
        Set(ByVal value As String)
            m_hora = value
        End Set
    End Property


#End Region

    Public Sub New()
        Me.Id = 0
        Me.Hora = Now.TimeOfDay().ToString.Remove(5)
        Me.Fecha = Date.Today.Date
        Me.Usuario = New Usuario

    End Sub



End Class
