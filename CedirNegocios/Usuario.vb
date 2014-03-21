Public Class Usuario

    Private m_id As Integer
    Private m_nombre As String
    Private m_password As String
    Public idMedico As Integer

    Private arrGrupos As ArrayList

    Dim com As String = """"
    Public Property id() As Integer
        Get
            id = m_id
        End Get
        Set(ByVal Value As Integer)
            m_id = Value
        End Set
    End Property

    Public Property nombreUsuario() As String
        Get
            nombreUsuario = m_nombre
        End Get
        Set(ByVal Value As String)
            m_nombre = Value
        End Set
    End Property
    Public Property password() As String
        Get
            password = m_password
        End Get
        Set(ByVal Value As String)
            m_password = Value
        End Set
    End Property

    Public Sub New()
        nombreUsuario = ""
        password = ""
    End Sub

    Public Function getGrupos() As ArrayList
        If arrGrupos Is Nothing Then
            arrGrupos = New ArrayList
            Dim da As New CedirDataAccess.Consultas
            Dim drGrupos As Npgsql.NpgsqlDataReader = da.getGruposUsuario(Me.id)

            Dim vGrupo As Grupo
            While drGrupos.Read()
                vGrupo = New Grupo
                vGrupo.id = drGrupos.Item(0)
                vGrupo.nombre = drGrupos.Item(1)
                arrGrupos.Add(vGrupo)
            End While
        End If

        Return arrGrupos
    End Function

    Public Function getGroupByName(ByVal groupName As String) As Grupo
        Dim sGrupos As ArrayList = Me.getGrupos
        Dim cGrupo As Grupo
        For i As Integer = 0 To arrGrupos.Count - 1
            cGrupo = arrGrupos(i)
            If cGrupo.nombre = groupName Then
                Return cGrupo
            End If
        Next

        Return Nothing
    End Function

    Public Function belongToGroup(ByVal groupName As String) As Boolean
        Dim cGrupo As Grupo = Me.getGroupByName(groupName)
        If cGrupo Is Nothing Then
            Return False
        End If
        Return True
    End Function

    Public Function update() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String

        Dim uptString1 As String = com & "password" & com & " = " & "'" & Me.password & "'"
        Dim uptString2 As String = com & "nombreUsuario" & com & " = " & "'" & Me.nombreUsuario & "'"
        resp = upd.update(com & "webData" & com & "." & com & "tblUsuarios" & com, uptString1 & ", " & uptString2, " where " & com & "idUsuario" & com & " = " & Me.id)
        Return resp




        Return True

    End Function


End Class
