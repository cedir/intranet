Imports System.Data.SqlClient
Imports Npgsql
Imports System.Text.RegularExpressions

Public Class Nuevo

    Private cn As NpgsqlConnection
    Dim com As String = """"
    Public Sub New()
        Dim myDbConnection As Singleton.DbConnectionSingleton = Singleton.DbConnectionSingleton.GetInstance()
        cn = myDbConnection.getDbConnection
    End Sub

    'Para ejecutar sp genericos
    Public Sub ExecuteStoreProcedure(ByVal data As ArrayList, ByVal nombreSP As String)
        Dim divisor As String = "__*"
        Using oCmd As New NpgsqlCommand
            oCmd.Connection = cn
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.CommandText = nombreSP
            Dim i As Integer
            'defino regular expresion para dividir del array "parametro"__* "valor"
            Dim r As New Regex(divisor)
            For i = 0 To data.Count - 1
                Dim cadena As String() = r.Split(data(i))
                Dim param As String = cadena(0)
                Dim value As String = cadena(1).TrimStart("*")
                oCmd.Parameters.Add(param, value)
            Next
            oCmd.ExecuteNonQuery()
        End Using
    End Sub


    Public Function nuevoPaciente(ByVal dni As Integer, ByVal nombres As String, ByVal apellido As String, ByVal fechaNacimiento As Date, ByVal direccion As String, ByVal tel As String, ByVal sexo As String, ByVal nroAfiliado As String, Optional ByVal mail As String = Nothing) As Int32

        Dim cmd As New NpgsqlCommand("insert into " & com & "cedirData" & com & "." & com & "tblPacientes" & com & " (" & com & "dni" & com & ", " & com & "nombres" & com & ", " & com & "apellido" & com & "," & com & "fechaNacimiento" & com & "," & com & "direccion" & com & ", " & com & "tel" & com & "," & com & "sexo" & com & "," & com & "nroAfiliado" & com & " ," & com & "e_mail" & com & ") values (@dni, @nombres, @apellido, @fechaNacimiento, @direccion, @tel, @sexo, @nroAfiliado , @mail)", cn)
        Try
            cmd.Parameters.Add(New NpgsqlParameter("@dni", DbType.Int32))
            cmd.Parameters("@dni").Value = dni

            cmd.Parameters.Add(New NpgsqlParameter("@nombres", DbType.String))
            cmd.Parameters("@nombres").Value = nombres

            cmd.Parameters.Add(New NpgsqlParameter("@apellido", DbType.String))
            cmd.Parameters("@apellido").Value = apellido

            cmd.Parameters.Add(New NpgsqlParameter("@fechaNacimiento", DbType.Date))
            If fechaNacimiento = Date.MinValue Then
                cmd.Parameters("@fechaNacimiento").Value = DBNull.Value
            Else
                cmd.Parameters("@fechaNacimiento").Value = fechaNacimiento

            End If

            cmd.Parameters.Add(New NpgsqlParameter("@direccion", DbType.String))
            cmd.Parameters("@direccion").Value = direccion

            cmd.Parameters.Add(New NpgsqlParameter("@tel", DbType.String))
            cmd.Parameters("@tel").Value = tel

            cmd.Parameters.Add(New NpgsqlParameter("@sexo", DbType.String))
            cmd.Parameters("@sexo").Value = sexo

            cmd.Parameters.Add(New NpgsqlParameter("@nroAfiliado", DbType.String))
            cmd.Parameters("@nroAfiliado").Value = nroAfiliado

            cmd.Parameters.Add(New NpgsqlParameter("@mail", DbType.String))
            If mail Is Nothing Then
                cmd.Parameters("@mail").Value = DBNull.Value
            Else
                cmd.Parameters("@mail").Value = mail
            End If


            If cmd.ExecuteNonQuery() Then
                Return Me.selectMAX("tblPacientes", "id")
            Else
                Return -1
            End If
        Catch ex As SqlException
            Return ex.ErrorCode
        End Try
    End Function

   

    Public Function nuevoEstudio(ByVal publicId As String, ByVal idPaciente As Integer, ByVal idPractica As Integer, ByVal motivoEstudio As String, ByVal informe As String, ByVal IdMedicoActuante As Integer, ByVal IdMedicoSolicitante As Integer, ByVal IdObraSocial As Integer, ByVal fecha As Date, ByVal nroDeOrden As String, ByVal idAnestesista As Integer, ByVal enlaceVideo As String) As String


        Dim stringInsert1 As String
        Dim stringInsert2 As String
        Dim stringInsert3 As String

        stringInsert1 = "insert into " & com & "cedirData" & com & "." & com & "tblEstudios" & com & "(" & com & "publicID" & com & ", " & com & "idPaciente" & com & "," & com & "fechaEstudio" & com & "," & com & "idEstudio" & com & "," & com & "motivoEstudio" & com & "," & com & "informe" & com & "," & com & "enlaceVideo" & com & ") values (@publicID,@idPaciente,@fechaEstudio,@idEstudio,@motivoEstudio,@informe, @enlaceVideo) "
        stringInsert2 = "insert into " & com & "cedirData" & com & "." & com & "tblDetalleEstudio" & com & "(" & com & "idMedicoActuante" & com & "," & com & "idObraSocial" & com & "," & com & "idMedicoSolicitante" & com & ", " & com & "idFacturacion" & com & ", " & com & "nroDeOrden" & com & ", " & com & "idAnestesista" & com & ") values (@IdMedicoActuante,@IdObraSocial,@IdMedicoSolicitante,0,@nroDeOrden,@idAnestesista)"
        stringInsert3 = "insert into " & com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com & "(" & com & "importeEstudio" & com & "," & com & "importeMedicacion" & com & ", " & com & "diferenciaPaciente" & com & "," & com & "pagoContraFactura" & com & ", " & com & "pension" & com & ", " & com & "importePagoMedico" & com & ", " & com & "importePagoMedicoSol" & com & ")  values(0, 0, 0, 0, 0, 0, 0)"

        Dim cmd As New NpgsqlCommand(stringInsert1 + ";" + stringInsert2 + ";" + stringInsert3, cn)
        Try
            cmd.CommandType = CommandType.Text

            cmd.Parameters.Add(New NpgsqlParameter("@publicID", DbType.String))
            cmd.Parameters("@publicID").Value = publicId

            cmd.Parameters.Add(New NpgsqlParameter("@idPaciente", DbType.Int32))
            cmd.Parameters("@idPaciente").Value = idPaciente

            cmd.Parameters.Add(New NpgsqlParameter("@fechaEstudio", DbType.Date))
            cmd.Parameters("@fechaEstudio").Value = fecha

            cmd.Parameters.Add(New NpgsqlParameter("@idEstudio", DbType.Int16))
            cmd.Parameters("@idEstudio").Value = idPractica

            cmd.Parameters.Add(New NpgsqlParameter("@motivoEstudio", DbType.String))
            cmd.Parameters("@motivoEstudio").Value = motivoEstudio

            cmd.Parameters.Add(New NpgsqlParameter("@informe", DbType.String))
            cmd.Parameters("@informe").Value = informe

            cmd.Parameters.Add(New NpgsqlParameter("@IdMedicoActuante", DbType.Int16))
            cmd.Parameters("@IdMedicoActuante").Value = IdMedicoActuante

            cmd.Parameters.Add(New NpgsqlParameter("@IdMedicoSolicitante", DbType.Int16))
            cmd.Parameters("@IdMedicoSolicitante").Value = IdMedicoSolicitante

            cmd.Parameters.Add(New NpgsqlParameter("@idAnestesista", DbType.Int16))
            cmd.Parameters("@idAnestesista").Value = idAnestesista

            cmd.Parameters.Add(New NpgsqlParameter("@IdObraSocial", DbType.Int16))
            cmd.Parameters("@IdObraSocial").Value = IdObraSocial

            cmd.Parameters.Add(New NpgsqlParameter("@nroDeOrden", DbType.String))
            cmd.Parameters("@nroDeOrden").Value = nroDeOrden

            cmd.Parameters.Add(New NpgsqlParameter("@enlaceVideo", DbType.String))
            cmd.Parameters("@enlaceVideo").Value = enlaceVideo

            cmd.ExecuteNonQuery() 'Al modificar esto, revisar código btnAnunciar en Turnos

            Return "ok"
        
        Catch ex As Exception
            Throw New Exception
        End Try

    End Function


    Public Function borrarEstudio(ByVal nroEstudio As Int64) As String
        Dim str, str1, str2 As String

        Dim cmd As New NpgsqlCommand
        Try
            cmd.CommandType = CommandType.Text

            str = "delete from " & com & "cedirData" & com & "." & com & "tblEstudios" & com & " where " & com & "nroEstudio" & com & " = " & nroEstudio
            str1 = "delete from " & com & "cedirData" & com & "." & com & "tblDetalleEstudio" & com & " where " & com & "nroEstudio" & com & " = " & nroEstudio
            str2 = "delete from " & com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com & " where " & com & "nroEstudio" & com & " = " & nroEstudio

            cmd.CommandText = str + ";" + str1 + ";" + str2
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            Return "ok"
        Catch ex As SqlException
            Return ex.ToString

        End Try


    End Function

    Public Function nuevaFacturacion(ByVal idObraSocial As Integer, ByVal fechaFacturacion As Date, ByVal estado As Integer, ByVal periodo As String, Optional ByVal idComprobante As Integer = Nothing) As Int64

        Try
            Dim cmd As New NpgsqlCommand


            cmd.Parameters.Add(New NpgsqlParameter("@fechaFacturacion", DbType.Date))
            cmd.Parameters("@fechaFacturacion").Value = fechaFacturacion

            cmd.Parameters.Add(New NpgsqlParameter("@idObraSocial", DbType.Int16))
            cmd.Parameters("@idObraSocial").Value = idObraSocial

            cmd.Parameters.Add(New NpgsqlParameter("@pagado", DbType.Int16))
            cmd.Parameters("@pagado").Value = estado

            cmd.Parameters.Add(New NpgsqlParameter("@periodo", DbType.String))
            cmd.Parameters("@periodo").Value = periodo

            'tengo que diferenciar si trae o no un idComprobante, ya que al crear una
            'presentacion, podria no asignarle un comprobante
            If (idComprobante <> Nothing) Then
                cmd.Parameters.Add(New NpgsqlParameter("@idComprobante", DbType.Int32))
                cmd.Parameters("@idComprobante").Value = idComprobante

                cmd.CommandText = "insert into " & com & "cedirData" & com & "." & com & "tblFacturacion" & com & " (" & com & "idObraSocial" & com & ", " & com & "fechaFacturacion" & com & ", " & com & "idComprobante" & com & ", " & com & "pagado" & com & ", " & com & "periodo" & com & " ) values (@idObraSocial, @fechaFacturacion, @idComprobante, @pagado, @periodo)"

            Else
                'si el campo viene vacio, no agrego el parametro
                cmd.CommandText = "insert into " & com & "cedirData" & com & "." & com & "tblFacturacion" & com & " (" & com & "idObraSocial" & com & ", " & com & "fechaFacturacion" & com & ", " & com & "pagado" & com & ", " & com & "periodo" & com & " ) values (@idObraSocial, @fechaFacturacion, @pagado, @periodo)"
            End If
            'Dim cmd As New NpgsqlCommand("insert into " & com & "cedirData" & com & "." & com & "tblFacturacion" & com & " (" & com & "idObraSocial" & com & ", " & com & "fechaFacturacion" & com & ", " & com & "idComprobante" & com & ", " & com & "pagado" & com & ", " & com & "periodo" & com & " ) values (@idObraSocial, @fechaFacturacion, @idComprobante, @pagado, @periodo)", cn)

            Dim idFacturacion As Int64
            Dim cmd2 As New NpgsqlCommand("select max(" & com & "idFacturacion" & com & ") from " & com & "cedirData" & com & "." & com & "tblFacturacion" & com, cn)
            cmd.Connection = cn
            cmd.ExecuteNonQuery()
            idFacturacion = CInt(cmd2.ExecuteScalar)
            Return idFacturacion
        Catch ex As SqlException
            Return 0
        End Try
    End Function

    Public Function nuevaFacturacionAMR(ByVal ano As Integer, ByVal mes As Integer, ByVal quincena As Integer) As Int64
        Dim cmd As New NpgsqlCommand("insert into " & com & "cedirData" & com & "." & com & "tblPresentacionAMR" & com & " (" & com & "ano" & com & ", " & com & "mes" & com & ", " & com & "quincena" & com & " ) values (@ano, @mes, @quincena)", cn)
        Dim id As Int64
        Dim cmd2 As New NpgsqlCommand("select max(" & com & "id" & com & ") from " & com & "cedirData" & com & "." & com & "tblPresentacionAMR" & com, cn)
        Try
            cmd.Parameters.Add(New NpgsqlParameter("@ano", DbType.Int16))
            cmd.Parameters("@ano").Value = ano
            cmd.Parameters.Add(New NpgsqlParameter("@mes", DbType.Int16))
            cmd.Parameters("@mes").Value = mes
            cmd.Parameters.Add(New NpgsqlParameter("@quincena", DbType.Int16))
            cmd.Parameters("@quincena").Value = quincena
            cmd.ExecuteNonQuery()
            id = CInt(cmd2.ExecuteScalar)
            Return id
        Catch ex As SqlException
            Return 0
        End Try

    End Function

    '------------------------------Genral Functions------------------------
    Public Function update(ByVal tabla As String, ByVal campos As String, ByVal condicion As String) As String
        Dim cmd As New NpgsqlCommand("update " & tabla & " set " & campos & condicion, cn)
        Try
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Return "ok"
        Catch ex As SqlException
            Return ex.ToString

        End Try
    End Function
    Public Function insert(ByVal tabla As String, ByVal campos As String, ByVal valores As String) As String
        Dim sqlQuery As String = "insert into " & tabla & " ( " & campos & " ) " & " values ( " & valores & " )"
        Dim cmd As New NpgsqlCommand(sqlQuery, cn)
        Try
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Return "ok"
        Catch ex As Exception
            Return ex.Message
        End Try
    End Function


    Public Function delete(ByVal tabla As String, ByVal condicion As String) As String
        Dim cmd As New NpgsqlCommand("delete from " & com & "cedirData" & com & "." & com & tabla & com & " where " & condicion, cn)
        Try
            cmd.CommandType = CommandType.Text
            cmd.ExecuteNonQuery()
            Return "ok"
        Catch ex As SqlException
            Return ex.ToString

        End Try
    End Function

    Public Function selectMAX(ByVal tableName As String, ByVal idColumnName As String, Optional ByVal filtro As String = "") As Integer
        Dim cmd As New NpgsqlCommand("select max(" & com & idColumnName & com & ") from " & com & "cedirData" & com & "." & com & tableName & com & filtro, cn)
        Try
            Dim id As Integer
            Dim OBJ As Object = cmd.ExecuteScalar

            If OBJ.Equals(DBNull.Value) Then
                id = 0
            Else
                id = CInt(OBJ)
            End If

            Return id
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function eliminarPaciente(ByVal idAeliminar As Integer, ByVal idReemplazante As Integer) As String
        Dim dr As NpgsqlDataReader
        Using oCmd As New NpgsqlCommand("eliminarpaciente", cn)
            Dim nombre As String = ""
            oCmd.CommandType = CommandType.StoredProcedure
            oCmd.Parameters.Add(New NpgsqlParameter("idPacienteReemplazante", NpgsqlTypes.NpgsqlDbType.Smallint))
            oCmd.Parameters("idPacienteReemplazante").Value = idReemplazante
            oCmd.Parameters.Add(New NpgsqlParameter("idPacienteEliminar", NpgsqlTypes.NpgsqlDbType.Smallint))
            oCmd.Parameters("idPacienteEliminar").Value = idAeliminar
            dr = oCmd.ExecuteReader()
            While dr.Read()
                nombre = dr(0)
            End While

            Return nombre


        End Using
    End Function

    Public Function actualizarPaciente(ByVal idPaciente As Integer, ByVal dni As Integer, ByVal nombres As String, ByVal apellido As String, ByVal fechaNacimiento As Date, ByVal direccion As String, ByVal tel As String, ByVal sexo As String, ByVal nroAfiliado As String, Optional ByVal mail As String = Nothing) As String
        Dim com As String = """"

        'WALTER: OBSERVAR ESTE CODIGO COMO MEJORA LA SINTAXIS, SIN TENER QUE HACER USO ABUSIVO DE LA VARIABLE COMM "" ,
        ' Y SOLO LA USAMOS PARA HACER REFERENCIAS EN LOS NOMBRES DE LAS TABLAS
        Dim cmd As New NpgsqlCommand("update " & com & "cedirData" & com & "." & com & "tblPacientes" & com & " set " & _
        "dni = :dni, nombres = :nombres, direccion = :direccion, tel = :tel, sexo = :sexo, e_mail = :mail, apellido = :apellido, " & _
        com & "fechaNacimiento" & com & " = :fechaNacimiento, " & _
        com & "nroAfiliado" & com & " = :nroAfiliado" & _
        " where id = " & idPaciente & ";", cn)



        Try
            cmd.Parameters.Add(New NpgsqlParameter("@dni", DbType.Int32))
            cmd.Parameters("@dni").Value = dni

            cmd.Parameters.Add(New NpgsqlParameter("@nombres", DbType.String))
            cmd.Parameters("@nombres").Value = nombres

            cmd.Parameters.Add(New NpgsqlParameter("@apellido", DbType.String))
            cmd.Parameters("@apellido").Value = apellido

            cmd.Parameters.Add(New NpgsqlParameter("@fechaNacimiento", DbType.Date))
            If fechaNacimiento = Date.MinValue Then
                cmd.Parameters("@fechaNacimiento").Value = DBNull.Value
            Else
                cmd.Parameters("@fechaNacimiento").Value = fechaNacimiento
            End If

            cmd.Parameters.Add(New NpgsqlParameter("@direccion", DbType.String))
            cmd.Parameters("@direccion").Value = direccion

            cmd.Parameters.Add(New NpgsqlParameter("@tel", DbType.String))
            cmd.Parameters("@tel").Value = tel

            cmd.Parameters.Add(New NpgsqlParameter("@sexo", DbType.String))
            cmd.Parameters("@sexo").Value = sexo

            cmd.Parameters.Add(New NpgsqlParameter("@nroAfiliado", DbType.String))
            cmd.Parameters("@nroAfiliado").Value = nroAfiliado

            cmd.Parameters.Add(New NpgsqlParameter("@mail", DbType.String))
            If mail Is Nothing Then
                cmd.Parameters("@mail").Value = DBNull.Value
            Else
                cmd.Parameters("@mail").Value = mail
            End If


            If cmd.ExecuteNonQuery() Then
                Return "ok"
            Else
                Return -1
            End If
        Catch ex As SqlException
            Return ex.ErrorCode
        End Try
    End Function



End Class
