Imports CedirDataAccess
Public Class Medicacion
    'Seria como una linea de medicamento
    Private m_idMedicacion As Integer
    Public medicamento As New medicamento
    Private m_importe As Single
    Private m_nroEstudio As Integer
    Private m_estado As String


    Public Sub New()

    End Sub
    Public Property idMedicacion() As Integer
        Get
            idMedicacion = m_idMedicacion
        End Get
        Set(ByVal Value As Integer)
            m_idMedicacion = Value
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
    Public Property nroEstudio() As Integer
        Get
            nroEstudio = m_nroEstudio
        End Get
        Set(ByVal Value As Integer)
            m_nroEstudio = Value
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


    Public Function guardar(ByRef upd As nuevo) As String
        Dim resp As String
        Dim com As String = """"
        If Me.estado = "noEstaEnEstudio" Then
            resp = upd.insert(com & "public" & com & "." & com & "tblMedicacion" & com, com & "importe" & com & ", " & com & "idMedicamento" & com & ", " & com & "nroEstudio" & com, "'" & Me.importe & "', '" & Me.medicamento.idMedicamento & "'" & ", '" & Me.nroEstudio & "'")
        ElseIf Me.estado = "estaEnEstudio" Then
            resp = upd.update(com & "public" & com & "." & com & "tblMedicacion" & com, com & "importe" & com & " = '" & Me.importe & "'", " where " & com & "idMedicacion" & com & " = " & Me.idMedicacion)
        End If

        Return resp
    End Function


    Public Function esMaterialEspecifico() As Boolean
        If Me.medicamento.tipo = "Mat Esp" Then
            Return True
        Else : Return False
        End If
    End Function

End Class
