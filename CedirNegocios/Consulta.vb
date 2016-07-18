Public Class Consulta
    Public id As Integer
    Public obraSocial As New obraSocial
    Public cantidad As Integer
    Public facturacion As New Presentacion
    Public paciente As New paciente
    Public importe As Single
    Public fecha As Date
    Public nroDeOrden As String


    Public Function crear() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        Dim com As String = """"
        Dim r As New System.Text.RegularExpressions.Regex("(/)")
        Dim partesFecha As String() = r.Split(Me.fecha)
        Dim fechaOptimizada As String = partesFecha(4) & "-" & partesFecha(2) & "-" & partesFecha(0)
        If paciente.dni = 0 Then
            'Cantidad
            resp = upd.insert(com & "public" & com & "." & com & "tblConsultas" & com, com & "idObraSocial" & com & ", " & com & "fecha" & com & ", " & com & "cantidad" & com & ", " & com & "nroDeOrden" & com, Me.obraSocial.idObraSocial & ", '" & fechaOptimizada & "'" & ", " & Me.cantidad & ", '" & Me.nroDeOrden & "'")
        Else
            'Paciente
            resp = upd.insert(com & "public" & com & "." & com & "tblConsultas" & com, com & "idObraSocial" & com & ", " & com & "fecha" & com & ", " & com & "dniPaciente" & com & ", " & com & "nroDeOrden" & com, Me.obraSocial.idObraSocial & ", '" & fechaOptimizada & "', " & Me.paciente.dni & ", '" & Me.nroDeOrden & "'")
        End If

        Return resp
    End Function
End Class
