Imports CedirDataAccess
Public Class Paciente
    Private m_id As Integer
    Private m_dni As Integer
    Private m_nombres As String
    Private m_apellido As String
    Private m_fechaNacimiento As Date
    Private m_edad As Integer
    Private m_mail As String
    Private m_direccion As String
    Private m_tel As String
    Private m_sexo As String
    Private m_nroAfiliado As String

    Dim com As String = """"

#Region "Propiedades"
    Public Property dni() As Integer
        Get
            dni = m_dni
        End Get
        Set(ByVal Value As Integer)
            m_dni = Value
        End Set
    End Property

    Public Property nombres() As String
        Get
            nombres = m_nombres
        End Get
        Set(ByVal Value As String)
            m_nombres = Value
        End Set
    End Property


    Public Property apellido() As String
        Get
            apellido = m_apellido
        End Get
        Set(ByVal Value As String)
            m_apellido = Value
        End Set
    End Property
    Public ReadOnly Property edad() As Integer
        Get
            Return calcularEdad()
        End Get
        
    End Property

    Public Property tel() As String
        Get
            tel = m_tel
        End Get
        Set(ByVal Value As String)
            m_tel = Value
        End Set
    End Property

    Public Property sexo() As String
        Get
            sexo = m_sexo
        End Get
        Set(ByVal Value As String)
            m_sexo = Value
        End Set
    End Property

    Public Property direccion() As String
        Get
            direccion = m_direccion
        End Get
        Set(ByVal Value As String)
            m_direccion = Value
        End Set
    End Property

    Public Property nroAfiliado() As String
        Get
            nroAfiliado = m_nroAfiliado
        End Get
        Set(ByVal Value As String)
            m_nroAfiliado = Value
        End Set
    End Property
    Public ReadOnly Property nombreCompleto() As String
        Get
            If Me.apellido <> "" Then
                nombreCompleto = Me.apellido & ", " & Me.nombres
            Else
                nombreCompleto = ""
            End If

        End Get

    End Property

    Public Property Id() As Int32
        Get
            Return m_id
        End Get
        Set(ByVal value As Int32)
            m_id = value
        End Set
    End Property

    Public Property fechaDeNacimiento() As Date
        Get
            Return m_fechaNacimiento
        End Get
        Set(ByVal value As Date)

            m_fechaNacimiento = value
        End Set
    End Property
    Public Property e_mail() As String
        Get
            Return Me.m_mail
        End Get
        Set(ByVal value As String)
            m_mail = value
        End Set
    End Property
#End Region

#Region "Constructor"
    Public Sub New()
        Me.fechaDeNacimiento = Nothing

    End Sub


    Public Sub New(ByVal dni As Integer, ByVal nombres As String, ByVal apellido As String, ByVal edad As Integer, ByVal direccion As String, ByVal tel As String, ByVal sexo As String, ByVal mail As String)
        m_dni = dni
        m_nombres = nombres
        m_edad = edad
        m_tel = tel
        m_apellido = apellido
        m_direccion = direccion
        m_sexo = sexo
        m_mail = mail


    End Sub

#End Region



    Public Function AltaPaciente() As String
        Dim upd As New CedirDataAccess.Nuevo

        Me.Id = upd.nuevoPaciente(dni, nombres, apellido, Me.fechaDeNacimiento, direccion, tel, sexo, nroAfiliado, Me.e_mail)
        If Me.Id > 0 Then
            Return "ok"
        Else
            Return "error en AltaPaciente"
        End If
    End Function
    Public Function actualizaPaciente() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        resp = upd.actualizarPaciente(Me.Id, Me.dni, Me.nombres, Me.apellido, Me.fechaDeNacimiento, Me.direccion, Me.tel, Me.sexo, Me.nroAfiliado, Me.e_mail)
        Return resp
    End Function
    Private Function calcularEdad() As Integer
        If Me.fechaDeNacimiento = Nothing Then
            Return 0
        End If
        Dim años As Integer

     
        Select Case True
            Case Month(Now) < Month(fechaDeNacimiento)
                años = Year(Now) - Year(fechaDeNacimiento) - 1
            Case (Month(fechaDeNacimiento) = Month(Now) And (Now.Day < fechaDeNacimiento.Day))
                años = Year(Now) - Year(fechaDeNacimiento) - 1
            Case Else
                años = Year(Now) - Year(fechaDeNacimiento)
        End Select

        Return años
    End Function


    Public Overrides Function ToString() As String
        Return Me.nombreCompleto
    End Function

End Class
