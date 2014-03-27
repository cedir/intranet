Imports CedirDataAccess
Public Class Arancel
    Private m_Practica As New practica
    Private m_precio As Single
    Private m_fecha As Date
    'Public precioAnestesia As Single
    Public Property practica() As practica
        Get
            practica = m_Practica
        End Get
        Set(ByVal Value As practica)
            m_Practica = Value
        End Set
    End Property
    Public Property precio() As Single
        Get
            precio = m_precio
        End Get
        Set(ByVal Value As Single)
            m_precio = Value
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
    Public Function actualizar(ByVal obraSocial As ObraSocial) As String
        Dim resp As String
        Dim com As String = """"
        Dim upd As New Nuevo
        Dim r As New System.Text.RegularExpressions.Regex("(/)")
        Dim partesFecha As String() = r.Split(Me.fecha)
        Dim fechaOptimizada As String = partesFecha(4) & "-" & partesFecha(2) & "-" & partesFecha(0)

        resp = upd.update(com & "cedirData" & com & "." & com & "AlmacenPreciosEstOS" & com, com & "Precio" & com & " = " & "'" & Me.precio & "', " & com & "fecha" & com & " = " & "'" & fechaOptimizada & "' ", " where " & com & "idEstudio" & com & " = " & Me.practica.idEstudio & " and " & com & "idObraSocial" & com & " = " & obraSocial.idObraSocial)
        Return resp
    End Function

    Public Function crear(ByVal obraSocial As ObraSocial) As String
        Dim resp As String
        Dim com As String = """"
        Dim upd As New Nuevo
        Dim r As New System.Text.RegularExpressions.Regex("(/)")
        Dim partesFecha As String() = r.Split(Me.fecha)
        Dim fechaOptimizada As String = partesFecha(4) & "-" & partesFecha(2) & "-" & partesFecha(0)
        resp = upd.insert(com & "cedirData" & com & "." & com & "AlmacenPreciosEstOS" & com, com & "idEstudio" & com & ", " & com & "idObraSocial" & com & ", " & com & "Precio" & com & ", " & com & "fecha" & com & ", " & com & "precioAnestesia" & com, "'" & Me.practica.idEstudio & "', '" & obraSocial.idObraSocial & "', '" & Me.precio & "', '" & fechaOptimizada & "' ")
        Return resp
    End Function
End Class
