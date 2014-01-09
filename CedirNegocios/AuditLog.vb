Imports CedirDataAccess
Public Class AuditLog
    Private m_id As Single
    Private m_user As New Usuario
    Private m_userId As Integer
    Private m_userActionId As Integer
    Private m_objectTypeId As Integer
    Private m_objectId As Integer
    Private m_dateTime As Date
    Private m_observacion As String

    Public Property id() As Integer
        Get
            id = m_id
        End Get
        Set(ByVal Value As Integer)
            m_id = Value
        End Set
    End Property

    Public Property usuario() As Usuario
        Get
            usuario = m_user
        End Get
        Set(ByVal Value As Usuario)
            m_user = Value
        End Set
    End Property
    Public Property userActionId() As Integer
        Get
            userActionId = m_userActionId
        End Get
        Set(ByVal Value As Integer)
            m_userActionId = Value
        End Set
    End Property
    Public Property objectTypeId() As Integer
        Get
            objectTypeId = m_objectTypeId
        End Get
        Set(ByVal Value As Integer)
            m_objectTypeId = Value
        End Set
    End Property
    Public Property objectId() As Integer
        Get
            objectId = m_objectId
        End Get
        Set(ByVal Value As Integer)
            m_objectId = Value
        End Set
    End Property
    Public Property observacion() As String
        Get
            observacion = m_observacion
        End Get
        Set(ByVal Value As String)
            m_observacion = Value
        End Set
    End Property
    Public Property fechaHora() As Date
        Get
            fechaHora = m_dateTime
        End Get
        Set(ByVal Value As Date)
            m_dateTime = Value
        End Set
    End Property

    Function create() As Object
        Dim com As String = """"
        Dim upd As New Nuevo
        Dim currentDate As String = CStr(Now.Date) & " " & CStr(Now.TimeOfDay.Hours) & ":" & CStr(Now.TimeOfDay.Minutes)
        Dim resp As String = upd.insert(com & "cedirData" & com & "." & com & "AuditUserActionsLog" & com, com & "userId" & com & ", " & com & "userActionId" & com & ", " & com & "objectTypeId" & com & ", " & com & "objectId" & com & ", " & com & "dateTime" & com & ", " & com & "observacion" & com, Me.usuario.id & ", " & Me.userActionId & ", " & Me.objectTypeId & ", " & Me.objectId & ", '" & currentDate & "', '" & Me.observacion & "'")
        Return resp
    End Function

End Class
