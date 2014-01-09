Imports CedirDataAccess
Imports Npgsql
Public Class CatalogoDeMedicos
    Dim com As String = """"
    Dim capaDatos As Consultas

    Public Sub New()
        capaDatos = New Consultas
    End Sub
    Public Function TodosLosMedicos() As ArrayList
        Dim drMedicos As NpgsqlDataReader

        Dim vMedico As Medico
        drMedicos = capaDatos.getMedicos()

        TodosLosMedicos = New ArrayList
        While drMedicos.Read()
            vMedico = New Medico
            vMedico.idMedico = drMedicos.Item(0)
            vMedico.nombre = drMedicos.Item(1)
            vMedico.apellido = drMedicos.Item(2)
            vMedico.nroMatricula = drMedicos.Item(3)
            vMedico.direccion = drMedicos.Item(4)
            vMedico.localidad = drMedicos.Item(5)
            vMedico.telefono = drMedicos.Item(6)
            vMedico.mail = drMedicos.Item(7)
            'TODO: remover estos IFs cuando el esta version este instalada en todas las PCs
            If (drMedicos.Item("claveFiscal") Is DBNull.Value) Then
                vMedico.claveFiscal = ""
            Else
                vMedico.claveFiscal = drMedicos.Item("claveFiscal")
            End If
            If (drMedicos.Item("responsabilidadFiscal") Is DBNull.Value) Then
                vMedico.responsabilidadFiscal = ""
            Else
                vMedico.responsabilidadFiscal = drMedicos.Item("responsabilidadFiscal")
            End If

            'vMedico.responsabilidadFiscal= new Gravado 
            'vMedico.responsabilidadFrenteAlIVA.id = drMedicos.Item("idGravado")
            'vMedico.responsabilidadFrenteAlIVA.descripcion = drMedicos.Item("descripcionGravado")
            'vMedico.responsabilidadFrenteAlIVA.porcentaje = drMedicos.Item("porcentajeGravado")

            TodosLosMedicos.Add(vMedico)
        End While


        drMedicos.Close()

    End Function
    Public Function TodosLosAnestesistas() As ArrayList
        Dim drMedicos As NpgsqlDataReader
        'Dim drMedicos As SqlDataReader
        Dim vMedico As Medico
        drMedicos = capaDatos.Tabla("tblMedicosAnestesistas", " order by " & com & "apellidoMedicoAn" & com)
        TodosLosAnestesistas = New ArrayList
        While drMedicos.Read()
            vMedico = New Medico
            vMedico.idMedico = drMedicos.Item(0)
            vMedico.nombre = drMedicos.Item(1)
            vMedico.apellido = drMedicos.Item(2)
            vMedico.nroMatricula = drMedicos.Item(3)
            vMedico.direccion = drMedicos.Item(4)
            vMedico.localidad = drMedicos.Item(5)
            vMedico.telefono = drMedicos.Item(6)
            vMedico.mail = drMedicos.Item(7)
            TodosLosAnestesistas.Add(vMedico)
        End While


        drMedicos.Close()

    End Function
End Class
