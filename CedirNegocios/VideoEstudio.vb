Imports CedirDataAccess

Public Class VideoEstudio

    'Esta clase en un futuro puede contener un codigo hash para entregar, que sea mas 
    'legible que el enlace que se obtiene por MEGA.

#Region "VARIABLES"


    <VBFixedString(256)> Private m_enlace As String

#End Region

#Region "Propiedades"

    Public Property enlaceMega() As String
        Get
            Return m_enlace
        End Get
        Set(ByVal value As String)
            m_enlace = value.Trim()
        End Set
    End Property

#End Region

    Public Sub New()
        Me.enlaceMega = ""
    End Sub


End Class
