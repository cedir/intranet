Imports CedirDataAccess
Public Class LogComprobanteElectronico

    Dim _id As Integer
    Dim _detalle As String
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Public Property detalle() As String
        Get
            Return _detalle
        End Get
        Set(ByVal value As String)
            _detalle = value
        End Set
    End Property
    Public Sub insert()
        Dim cDatos As New Nuevo
        Dim arr As New ArrayList
        Const c As String = "__*"

        arr.Add("detalle" & c & Me.detalle)
        cDatos.ExecuteStoreProcedure(arr, "sp_comprobanteselectonicosloginsert")
    End Sub
End Class
