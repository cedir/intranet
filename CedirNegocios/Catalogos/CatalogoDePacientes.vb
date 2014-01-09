Imports CedirDataAccess
Imports Npgsql
Public Class CatalogoDePacientes
    Dim com As String = """"
    Dim da As Consultas
    Dim daNuevo As Nuevo
    Public Sub New()
        da = New Consultas
    End Sub

    Public Function TodosLosPacientes(Optional ByVal dni As String = "", Optional ByVal apellido As String = "", Optional ByVal nombres As String = "") As ArrayList
        Dim drPacientes As NpgsqlDataReader
        Dim vPaciente As Paciente
        TodosLosPacientes = New ArrayList
        Dim condicion As String = " where "
        If dni <> "" Then
            condicion &= com & "dni" & com & " = " & dni & " and "
        Else
            condicion &= " true and "
        End If


        If (apellido <> "" Or nombres <> "") Then
            'condicion &= " where " & com & "apellido" & com & " like " & "'%" & apellido.ToUpper() & "%'" & " and " & "nombres" & " like " & "'" & nombres.ToUpper() & "%'"
            condicion &= "UPPER(" & com & "apellido" & com & ") like " & "'%" & apellido.ToUpper() & "%'" & " and UPPER(" & "nombres" & ") like " & "'%" & nombres.ToUpper() & "%'"

        Else
            condicion &= " true "
        End If

        condicion &= " order by " & com & "nombres" & com

        drPacientes = da.Tabla("tblPacientes", condicion)



        While drPacientes.Read()
            vPaciente = New Paciente '(drPacientes.GetInt32(0), drPacientes.GetString(1), drPacientes.GetString(2), drPacientes.GetInt16(3), drPacientes.GetString(4), drPacientes.GetString(5), drPacientes.GetString(6))
            vPaciente.dni = drPacientes.Item("dni")
            vPaciente.nombres = drPacientes.Item("nombres")
            vPaciente.apellido = drPacientes.Item("apellido")

            If drPacientes.Item("e_mail") Is DBNull.Value Then
                vPaciente.e_mail = Nothing
            Else
                vPaciente.e_mail = drPacientes.Item("e_mail")
            End If

            If drPacientes.Item("fechaNacimiento") IsNot DBNull.Value Then
                vPaciente.fechaDeNacimiento = Convert.ToDateTime(drPacientes.Item("fechaNacimiento"))
            End If
            vPaciente.direccion = drPacientes.Item("direccion")
            vPaciente.tel = drPacientes.Item("tel")
            vPaciente.sexo = drPacientes.Item("sexo")
            vPaciente.nroAfiliado = drPacientes.Item("nroAfiliado")
            vPaciente.Id = drPacientes.Item("id")
            TodosLosPacientes.Add(vPaciente)

        End While

        drPacientes.Close()


    End Function

    Public Function eliminarPaciente(ByVal idAeliminar As Integer, ByVal idReemplazante As Integer) As String
        Dim n As New Nuevo
        Return n.eliminarPaciente(idAeliminar, idReemplazante)

    End Function



    
End Class
