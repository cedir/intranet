Public Class Practica
    Public idEstudio As Integer
    Public Estudio As String
    Public PorcentajeMedAct As Integer
    Public codigoMedico As String
    Private codMedicoOsde As String
    Private m_Abreviatura As String

    Public Property abreviatura() As String
        Get
            Return m_Abreviatura
        End Get
        Set(ByVal value As String)
            m_Abreviatura = value
        End Set
    End Property


    Public Property codigoMedicoOSDE() As String
        Get
            Return codMedicoOsde
        End Get
        Set(ByVal value As String)
            codMedicoOsde = value
        End Set
    End Property

    Public Sub New()
        abreviatura = ""
    End Sub
    Public Function crear() As String
        If Not validarUsuario() Then
            Return "El usuario no tiene los permisos para crear la práctica. Comuniquese con Facturación."
        End If

        Dim resp As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim com As String = """"
        resp = upd.insert(com & "public" & com & "." & com & "AlmacenEstudios" & com, com & "estudio" & com & ", " & com & "porcentajeMedico" & com & ", " & com & "codigoMedico" & com & ", " & com & "abreviatura" & com & ", " & com & "codigoMedicoOSDE" & com, "'" & Me.Estudio & "', " & 0 & ", '" & Me.codigoMedico & "'" & ", '" & Me.abreviatura & "'" & ", '" & Me.codigoMedicoOSDE & "'")

        Return resp

    End Function

    Public Function actualizar() As String
        Dim resp As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim com As String = """"
        resp = upd.update(com & "public" & com & "." & com & "AlmacenEstudios" & com, com & "estudio" & com & " = '" & Me.Estudio & "', " & com & "codigoMedico" & com & " = '" & Me.codigoMedico & "'" & ", " & com & "abreviatura" & com & " = '" & Me.abreviatura & "'" & ", " & com & "codigoMedicoOSDE" & com & " = '" & Me.codigoMedicoOSDE & "'", " where " & com & "idEstudio" & com & " = " & Me.idEstudio)

        Return resp
    End Function


    Private Function validarUsuario() As Boolean
        Dim ssecu As Security = Security.GetInstance()

        Dim usuarioActual As Usuario = ssecu.getLoggedUser()
        If usuarioActual.belongToGroup("facturacion") Or usuarioActual.belongToGroup("administrador") Then
            Return True
        Else
            Return False
        End If




    End Function







    Public Overrides Function ToString() As String
        Return Me.Estudio
    End Function
End Class
