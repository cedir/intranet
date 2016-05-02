Imports CedirDataAccess
Public Class PagoFacturacion
    Private m_importe As Single
    Private m_gastoAdministrativo As Decimal
    Private m_id As Integer
    Private m_nroDeRecibo As String
    Private m_fecha As Date

    Public Sub New()

    End Sub

    Public Property id() As Integer
        Get
            nroDeRecibo = m_id
        End Get
        Set(ByVal Value As Integer)
            m_id = Value
        End Set
    End Property

    Public Property nroDeRecibo() As String
        Get
            nroDeRecibo = m_nroDeRecibo
        End Get
        Set(ByVal Value As String)
            m_nroDeRecibo = Value
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


    Public Property gastoAdministrativo() As Decimal
        Get
            gastoAdministrativo = m_gastoAdministrativo
        End Get
        Set(ByVal Value As Decimal)
            m_gastoAdministrativo = Value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            fecha = m_fecha
        End Get
        Set(ByVal Value As Date)
            m_fecha = Value
        End Set
    End Property


    Public Function guardar(ByVal idFacturacion As Integer) As String
        Dim com As String = """"
        Dim upd As New Nuevo
        Dim resp As String

        resp = upd.update(com & "public" & com & "." & com & "tblFacturacion" & com, com & "pagado" & com & " = 1, " & com & "total" & com & " = '" & Me.importe & "'", " where " & com & "idFacturacion" & com & " = " & idFacturacion)
        If resp = "ok" Then
            resp = upd.insert(com & "public" & com & "." & com & "tblPagoFacturacion" & com, com & "idFacturacion" & com & ", " & com & "fechaPagoFact" & com & ", " & com & "importePago" & com & ", " & com & "nroRecivo" & com & ", " & com & "gastoAdministrativo" & com, idFacturacion & ", '" & Today.Year & "-" & Today.Month & "-" & Today.Day & "', '" & Me.importe & "', " & "'" & Me.nroDeRecibo & "', '" & Me.gastoAdministrativo & "'")
        End If

        Return resp
    End Function

End Class
