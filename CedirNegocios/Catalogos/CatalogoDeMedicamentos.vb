
Imports CedirDataAccess
Imports Npgsql

Public Class CatalogoDeMedicamentos

    Dim com As String = """"
    Dim da As Consultas

    Public Sub New()
        da = New Consultas
    End Sub
    Public Function traerMedicamentos(Optional ByVal nombre As String = "") As ArrayList
        Dim med As Medicamento
        traerMedicamentos = New ArrayList
        Dim drMed As NpgsqlDataReader

        If nombre <> "" Then
            drMed = da.Tabla("tblMedicamentos", " where UPPER(" & com & "descripcionMedicamento" & com & ") like '%" & nombre.ToUpper() & "%' ORDER BY " & com & "descripcionMedicamento" & com)
        Else
            drMed = da.Tabla("tblMedicamentos", " ORDER BY " & com & "descripcionMedicamento" & com)
        End If


        While drMed.Read()
            med = New Medicamento
            med.idMedicamento = drMed("idMedicamento")
            med.descripcion = drMed("descripcionMedicamento")
            med.importe = drMed("importeMedicamento")
            med.tipo = drMed("tipo")
            med.codigoMedicoOSDE = drMed("codigoMedicoOSDE")
            med.stock = drMed("stock")
            traerMedicamentos.Add(med)
        End While
        drMed.Close()
    End Function

    



End Class
