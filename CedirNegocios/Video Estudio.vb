Imports CedirDataAccess

Public Class VideoEstudio

    'Esta clase en un futuro puede contener un codigo hash para entregar, que sea mas 
    'legible que el enlace que se obtiene por MEGA.

#Region "VARIABLES"

    Private m_id As Integer
    Private m_enlace As String

#End Region

#Region "Propiedades"

    Public Property id() As Integer
        Get
            Return m_id
        End Get
        Set(ByVal value As Integer)
            m_id = value
        End Set
    End Property
    Public Property enlaceMega() As String
        Get
            Return m_enlace
        End Get
        Set(ByVal value As String)
            m_enlace = value
        End Set
    End Property

#End Region



End Class
