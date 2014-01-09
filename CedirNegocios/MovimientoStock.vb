Imports CedirDataAccess

Public Class MovimientoStockMedicamento
    Inherits Movimiento

#Region "PROPIEDADES"
    Private m_cantidad As Integer
    Public Property cantidad() As Integer
        Get
            Return m_cantidad
        End Get
        Set(ByVal value As Integer)
            m_cantidad = value
        End Set
    End Property

    Private m_desc As String
    Public Property descripcion() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value
        End Set
    End Property

  

    Private _medicamento As Medicamento
    Public Property medicamento() As Medicamento
        Get
            Return _medicamento
        End Get
        Set(ByVal value As Medicamento)
            _medicamento = value
        End Set
    End Property
#End Region

    Public Sub New()
        Me.cantidad = 0
        Me.medicamento = Nothing
        Me.descripcion = ""
    End Sub

    Public Function crear() As Integer
        Dim com As String = """"
        Dim cDatos As New Nuevo
        Dim help As New Helper


        'insertamos el movimiento
        Dim resp As String = cDatos.insert(com & "cedirData" & com & "." & com & "tblMovimientosDeMedicamentos" & com, com & _
        "fecha" & com & ", " & com & "cantidad" & com & ", " & com & "descripcion" & com & ", " & com & "idMedicamento" & com & ", " & com & "hora" & _
        com, " '" & Me.Fecha & _
        "', " & Me.cantidad & ", '" & Me.descripcion & "', " & Me.medicamento.idMedicamento & " , '" & Me.Hora & "' ")

        'ahora obtenemos el id creado por la DB para luego insertarlo en el log
        Dim maxId As Integer = cDatos.selectMAX("tblMovimientosDeMedicamentos", "id")


        Return maxId
    End Function




End Class
