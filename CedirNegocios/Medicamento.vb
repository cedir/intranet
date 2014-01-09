Imports CedirDataAccess
Public Class Medicamento
    Dim m_idMedicamento As Integer
    Dim m_descripcion As String
    Dim m_importe As Single
    Private m_codMedOSDE As String
    Private m_tipoMedicamento As String
    Dim _stock As Integer



    Public Sub New()

    End Sub
    Public Property idMedicamento() As Integer
        Get
            idMedicamento = m_idMedicamento
        End Get
        Set(ByVal Value As Integer)
            m_idMedicamento = Value
        End Set
    End Property
    Public Property descripcion() As String
        Get
            Return m_descripcion
        End Get
        Set(ByVal Value As String)
            m_descripcion = Value
        End Set
    End Property
    Public Property codigoMedicoOSDE() As String
        Get
            Return m_codMedOSDE
        End Get
        Set(ByVal Value As String)
            m_codMedOSDE = Value
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


    Public Property tipo() As String
        Get
            Return (m_tipoMedicamento)
        End Get
        Set(ByVal value As String)
            m_tipoMedicamento = value
        End Set
    End Property
    Public Property stock() As Integer
        Get
            Return _stock
        End Get
        Set(ByVal value As Integer)
            _stock = value
        End Set
    End Property

    Public Function crear() As String
        Dim resp As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim com As String = """"
        If Me.descripcion = "" Then
            resp = "Debe ingresar una descripción"
        Else
            resp = upd.insert(com & "cedirData" & com & "." & com & "tblMedicamentos" & com, com & "descripcionMedicamento" & com & ", " & com & "importeMedicamento" & com & ", " & com & "tipo" & com & ", " & com & "codigoMedicoOSDE" & com, "'" & Me.descripcion & "', '" & Me.importe & "', '" & Me.tipo & "', '" & Me.codigoMedicoOSDE & "'")
        End If
        Return resp

    End Function
    Public Function actualizar() As String
        Dim resp As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim com As String = """"
        If Me.descripcion = "" Then
            resp = "Debe ingresar una descripción"
        Else
            resp = upd.update(com & "cedirData" & com & "." & com & "tblMedicamentos" & com, com & "descripcionMedicamento" & com & " = '" & Me.descripcion & "', " & com & "importeMedicamento" & com & " = '" & Me.importe & "', " & com & "tipo" & com & " = '" & Me.tipo & "', " & com & "codigoMedicoOSDE" & com & " = '" & Me.codigoMedicoOSDE & "'", " where " & com & "idMedicamento" & com & " = " & Me.idMedicamento)
        End If
        Return resp
    End Function

    Public Function actualizarStock() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim com As String = """"
        Try
            upd.update(com & "cedirData" & com & "." & com & "tblMedicamentos" & com, com & "stock" & com & " = " & stock, " where " & com & "idMedicamento" & com & " = " & Me.idMedicamento)
            Return "ok"
        Catch ex As Exception
            Return (ex.Message)
        End Try
    End Function


    Public Function getStock() As Integer
        Return Me.getSumatoriaMovimientos()
    End Function

    Private Function getSumatoriaMovimientos() As Decimal
        Dim com As String = """"
        Dim cDatos As New Consultas
        'hacemos sumatoria de lineas
        Return cDatos.selectSum("tblMovimientosDeMedicamentos", "cantidad", " where " & com & "idMedicamento" & com & " = " & Me.idMedicamento)
    End Function



    Public Overrides Function ToString() As String
        Return Me.descripcion
    End Function

End Class
