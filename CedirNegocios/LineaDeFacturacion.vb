Imports CedirDataAccess
Public Class LineaDeFacturacion
    Private m_objecto As Object
    Private m_importe As Single
    Private m_pension As Single
    Private m_diferenciaPaciente As Single
    Private m_estado As String
    'estado: indica si el objeto (estudio o consulta) ya esta en base de datos o no.
    'Este dato sirve para luego ejecutar una sentencia update o insert segun corresponda
    'Puede ser: estaEnFacturacion - noEstaEnFacturacion 
    Public Sub New()

    End Sub
    Public Property objeto() As Object
        Get
            objeto = m_objecto
        End Get
        Set(ByVal Value As Object)
            m_objecto = Value
        End Set
    End Property

    Public Property importe() As Single
        Get
            importe = m_importe
        End Get
        Set(ByVal Value As Single)
            m_importe = Value
        End Set
    End Property
    Public Property pension() As Single
        Get
            pension = m_pension
        End Get
        Set(ByVal Value As Single)
            m_pension = Value
        End Set
    End Property
    Public Property diferenciaPaciente() As Single
        Get
            diferenciaPaciente = m_diferenciaPaciente
        End Get
        Set(ByVal Value As Single)
            m_diferenciaPaciente = Value
        End Set
    End Property
    Public Property estado() As String
        Get
            estado = m_estado
        End Get
        Set(ByVal Value As String)
            m_estado = Value
        End Set
    End Property


    Public Function guardar(ByVal idFacturacion As Integer) As String
        Dim com As String = """"
        Dim upd As New Nuevo
        Select Case objeto.GetType.ToString
            Case "CedirNegocios.Estudio"
                Dim resp As String
                resp = upd.update("""tblEstudios""", """nroDeOrden"" = '" & objeto.nroOrden & "', ""idFacturacion"" = " & idFacturacion, " where ""nroEstudio"" = " & objeto.nroEstudio)
                resp = upd.update("""tblEstudios""", """importeEstudio"" = " & importe & ", ""diferenciaPaciente"" = " & diferenciaPaciente & ", ""pension"" = " & pension & ", ""arancelAnestesia"" = " & objeto.ArancelAnestesia & ", ""importeMedicacion"" = " & objeto.importeMedicacion, " where ""nroEstudio"" = " & objeto.nroEstudio)
                Return resp
            Case "CedirNegocios.Consulta"
                Dim resp As String
                If estado = "estaEnFacturacion" Then
                    'actualizar importe
                    resp = upd.update(com & "public" & com & "." & com & "Facturaciones-Consultas" & com, com & "importe" & com & " = " & Me.importe, " where " & com & "idFacturacion" & com & " = " & idFacturacion & " and " & com & "idConsulta" & com & " = " & objeto.id)
                    Return resp
                ElseIf estado = "noEstaEnFacturacion" Then
                    'insertar linea de consulta
                    resp = upd.insert(com & "public" & com & "." & com & "Facturaciones-Consultas" & com, com & "idFacturacion" & com & ", " & com & "idConsulta" & com & ", " & com & "importe" & com, idFacturacion & ", " & objeto.id & ", " & Me.importe)
                    Return resp
                End If

        End Select

    End Function
    Public Function getImporteNeto() As Single
        Dim importeNeto As Single = 0
        Select Case objeto.GetType.ToString
            Case "CedirNegocios.Estudio"
                importeNeto = Me.importe + Me.pension + Me.objeto.getTotalMedicacion - Me.diferenciaPaciente + Me.objeto.ArancelAnestesia
            Case "CedirNegocios.Consulta"
                importeNeto = Me.importe
        End Select

        Return importeNeto
    End Function
End Class
