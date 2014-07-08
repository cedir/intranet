Imports CedirDataAccess
Public Class LineaDeFacturacion
    Private m_estudio As Object
    Private m_importe As Single
    Private m_pension As Single
    Private m_diferenciaPaciente As Single
    Private m_estado As String
    'estado: indica si el objeto (estudio o consulta) ya esta en base de datos o no.
    'Este dato sirve para luego ejecutar una sentencia update o insert segun corresponda
    'Puede ser: estaEnFacturacion - noEstaEnFacturacion 
    Public Sub New()

    End Sub
    'Public Property objeto() As Object
    '    Get
    '        objeto = m_objecto
    '    End Get
    '    Set(ByVal Value As Object)
    '        m_objecto = Value
    '    End Set
    'End Property

    Public Property estudio() As Estudio
        Get
            Return m_estudio
        End Get
        Set(ByVal Value As Estudio)
            m_estudio = Value
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
        Dim resp As String
        resp = upd.update(com & "cedirData" & com & "." & com & "tblDetalleEstudio" & com, com & "nroDeOrden" & com & " = '" & estudio.nroOrden & "', " & com & "idFacturacion" & com & " = " & idFacturacion, " where " & com & "nroEstudio" & com & " = " & estudio.nroEstudio)
        resp = upd.update(com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com, com & "importeEstudio" & com & " = " & importe & ", " & com & "diferenciaPaciente" & com & " = " & diferenciaPaciente & ", " & com & "pension" & com & " = " & pension & ", " & com & "arancelAnestesia" & com & " = " & estudio.ArancelAnestesia & ", " & com & "importeMedicacion" & com & " = " & estudio.importeMedicacion, " where " & com & "nroEstudio" & com & " = " & estudio.nroEstudio)
        Return resp

    End Function
    Public Function getSubtotal() As Single
        Dim subTotal As Single = 0
        subTotal = Me.importe + Me.pension + Me.estudio.getTotalMedicacion - Me.diferenciaPaciente + Me.estudio.ArancelAnestesia

        Return subTotal
    End Function
End Class
