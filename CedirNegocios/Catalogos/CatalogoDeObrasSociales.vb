Imports CedirDataAccess
Imports Npgsql
Public Class CatalogoDeObrasSociales
    Dim com As String = """"
    Dim da As Consultas

    Public Sub New()
        da = New Consultas
    End Sub
    Public Function TodosLasObrasSociales() As ArrayList
        Return loadObraSociales("")
    End Function
    Public Function TodosLasObrasSociales(ByVal nombre As String) As ArrayList
        Return loadObraSociales("UPPER(" & com & "obraSocial" & com & ") like '%" & nombre.ToUpper() & "%'")
    End Function
    Public Function GetOS(Optional ByVal porAMR As Int16 = 0) As ArrayList
        Return loadObraSociales(com & "sePresentaPorAMR" & com & " = " & porAMR)
    End Function
    Private Function loadObraSociales(ByVal condicion As String) As ArrayList
        Dim drOS As NpgsqlDataReader
        Dim vObraSocial As ObraSocial
        Dim cCondicion As String
        If condicion <> "" Then
            cCondicion = " where " & condicion
            'Dim arrObj() As String = condicion.Split(",")
            'For j As Integer = 0 To arrObj.Length - 1
            '    Dim arrCondicionPart() As String = arrObj(j).Split("=")
            '    cCondicion &= com & arrCondicionPart(0) & com & " like " & "'%" & arrCondicionPart(1) & "%'"
            'Next

        End If
        drOS = da.Tabla("AlmacenObraSocial", cCondicion & " order by " & com & "obraSocial" & com)
        loadObraSociales = New ArrayList
        While drOS.Read()
            vObraSocial = New ObraSocial
            vObraSocial.idObraSocial = drOS.Item(0)
            vObraSocial.ObraSocial = drOS.Item(1)
            vObraSocial.direccion = drOS.Item(2)
            vObraSocial.tel = drOS.Item(3)
            vObraSocial.localidad = drOS.Item(4)
            vObraSocial.CodigoPostal = drOS.Item(5)
            vObraSocial.CondicionFiscal = drOS.Item(6)
            vObraSocial.nroCuit = drOS.Item(7)
            vObraSocial.observaciones = drOS.Item(8)
            vObraSocial.sePresentaPorAMR = drOS.Item(9)
            vObraSocial.sePresentaPorARA = drOS.Item(10)
            vObraSocial.valorAproximadoDePension = Convert.ToDecimal(drOS.Item("valorAproximadoPension"))
            loadObraSociales.Add(vObraSocial)
        End While
        drOS.Close()
    End Function

End Class
