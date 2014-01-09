Imports CedirDataAccess
Imports Npgsql
Public Class CatalogoDePracticas
    Dim com As String = """"
    Dim da As Consultas
    Dim daNuevo As Nuevo
    Public Sub New()
        da = New Consultas
    End Sub

    Public Function getPracticas() As ArrayList
        Dim drEP As NpgsqlDataReader
        Dim vPractica As Practica
        drEP = da.Tabla("AlmacenEstudios", " order by " & com & "estudio" & com)

        getPracticas = New ArrayList
        While drEP.Read()

            vPractica = New Practica
            vPractica.idEstudio = drEP.Item("idEstudio")
            vPractica.Estudio = drEP.Item("estudio")
            vPractica.PorcentajeMedAct = drEP.Item("porcentajeMedico")
            vPractica.codigoMedico = drEP.Item("codigoMedico")
            vPractica.abreviatura = drEP.Item("abreviatura")
            vPractica.codigoMedicoOSDE = drEP.Item("codigoMedicoOSDE")
            getPracticas.Add(vPractica)
        End While
        drEP.Close()

    End Function
End Class
