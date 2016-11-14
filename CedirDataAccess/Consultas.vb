Imports System.Data.SqlClient
Imports Npgsql
Imports System.Text.RegularExpressions
Imports System.Text
Imports System.Collections.Generic



Public Class Consultas
    Dim myConnection As NpgsqlConnection
    Dim myCommand As NpgsqlCommand

    Dim com As String
    Public Sub New()
        myCommand = New NpgsqlCommand
        com = """"
        Dim myDbConnection As Singleton.DbConnectionSingleton = Singleton.DbConnectionSingleton.GetInstance()
        myConnection = myDbConnection.getDbConnection
    End Sub

    Public Function Tabla(ByVal NombreTabla As String) As NpgsqlDataReader
        Try
            Dim com As String = """"
            Dim myCommand As New NpgsqlCommand("select * from ""public""." & com & NombreTabla & com, myConnection)
            myCommand.CommandType = CommandType.Text

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function
    Public Function Tabla(ByVal NombreTabla As String, ByVal condicion As String) As NpgsqlDataReader
        Dim com As String = """"
        Dim myCommand As New NpgsqlCommand("select * from ""public""." & com & NombreTabla & com & condicion, myConnection)
        myCommand.CommandType = CommandType.Text
        Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
        Return myDataReader
    End Function
    Public Function Tabla(ByVal schema As String, ByVal NombreTabla As String, ByVal condicion As String) As NpgsqlDataReader
        Dim com As String = """"
        Dim myCommand As New NpgsqlCommand("select * from " & com & schema & com & "." & com & NombreTabla & com & condicion, myConnection)
        myCommand.CommandType = CommandType.Text
        Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
        Return myDataReader
    End Function
    Public Function EjecutarSelect(ByVal Sqlquery As String) As NpgsqlDataReader
        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = Sqlquery
            myCommand.Connection = myConnection

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function
    Public Function selectMax(ByVal tabla As String, ByVal columna As String) As NpgsqlDataReader
        Try
            Dim query As String = "select * from ""public""." & com & tabla & com & " WHERE " & com & columna & com & "= (SELECT max(" & columna & ") FROM""public""." & com & tabla & com & ")"
            Dim myCommand As New NpgsqlCommand(query, myConnection)
            myCommand.CommandType = CommandType.Text
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function

    Public Function traerEstudios(ByVal condicion As String, Optional ByVal filtro As String = "") As NpgsqlDataReader
        Dim StringPuto As String = "
            select
                est.""nroEstudio"",
                alos.*,
                ""fechaEstudio"",
                ""motivoEstudio"",
                ""informe"",
                est.""idObraSocial"",
                ""publicID"",
                est.""idMedicoActuante"",
                est.""idMedicoSolicitante"",
                ""enlaceVideo"",
                ""nroDeOrden"",
                ""lugar"",
                ""idFacturacion"",
                ""idAnestesista"",
                ""fechaCobro"",
                ""importeEstudio"",
                ""importeMedicacion"",
                ""pagoContraFactura"",
                ""diferenciaPaciente"",
                ""nroPagoMedicoAct"",
                ""pension"",
                ""importePagoMedico"",
                ""porcentajeIVAPagoMedicoActuante"",
                ""nroPagoMedicoSol"",
                ""importePagoMedicoSol"",
                ""estudio"",
                ""codigoMedico"",
                ""dni"",
                ""idPaciente"",
                ""e_mail"",
                ""fechaNacimiento"",
                ""nombres"",
                ""apellido"",
                ""sexo"",
                ""nroAfiliado"",
                ""tel"",
                p.""direccion"" as ""direPaciente"",
                ""nombreMedicoAct"",
                med.""nroMatricula"",
                meda.""nombreMedicoAn"",
                meda.""apellidoMedicoAn"",
                meda.""nroMatricula"",
                ""apellidoMedicoAct"",
                ""nombreMedicoSol"",
                ""apellidoMedicoSol"",
                ""obraSocial"",
                ""Precio"",
                ""esPagoContraFactura"",
                est.""idEstudio"",
                ""sePresentaPorAMR"",
                ""sePresentaPorARA"",
                est.""arancelAnestesia"",
                est.""importeCobradoPension"",
                est.""importeEstudioCobrado"",
                est.""importeCobradoArancelAnestesia"",
                est.""importeMedicacionCobrado"",
                ale.""abreviatura"",
                ale.""codigoMedicoOSDE""
            from ""public"".""tblEstudios"" as est
        "
        Dim inners As String = "
            inner join ""public"".""AlmacenEstudios"" as ale
                on  est.""idEstudio"" = ale.""idEstudio""
            inner join ""public"".""tblPacientes"" as p
                on est.""idPaciente"" = p.""id""
            inner join ""public"".""tblMedicosAct"" as med
                on est.""idMedicoActuante"" = med.""idMedicoAct""
            inner join ""public"".""tblMedicosAnestesistas"" as meda
                on est.""idAnestesista"" = meda.""idMedicoAn""
            inner join ""public"".""tblMedicosSol"" as meds
                on est.""idMedicoSolicitante"" = meds.""idMedicoSol""
            inner join ""public"".""AlmacenObraSocial"" as alos
                on est.""idObraSocial"" = alos.""idObraSocial""
            left join ""public"".""AlmacenPreciosEstOS"" as eo
                on est.""idEstudio"" = eo.""idEstudio"" 
                and est.""idObraSocial"" = eo.""idObraSocial"""

        Dim order As String = ""

        If filtro = "paciente" Then
            order = " order by ""fechaEstudio"", p.""apellido"", p.""nombres"" ASC "
        Else
            order = " order by est.""fechaEstudio"", p.""id"" ASC "
        End If



        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = StringPuto & inners & condicion & order
            myCommand.Connection = myConnection

            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Public Function TraerEstudiosYMovimientosDeCaja(ByVal condicion As String) As NpgsqlDataReader
        Dim selec As String = "select est.*,est.*, alos.*,cm.*, ctm.*,p.*, cm.id as ""idMov"", cm.""nroEstudio"" as ""nroEstudioMovimiento"",ales.*, medAct.*  from ""public"".""tblEstudios"" as est "
        Dim inner0 As String = " inner join ""public"".""AlmacenObraSocial"" as alos on est.""idObraSocial"" = alos.""idObraSocial" & com
        Dim inner1 As String = " inner join ""public"".""tblPacientes"" as p on est.""idPaciente"" = p.""id" & com
        Dim inner2 As String = " inner join ""public"".""AlmacenEstudios"" as ales on est.""idEstudio"" = ales.""idEstudio" & com
        Dim inner3 As String = " inner join ""public"".""tblMedicosAct"" as medAct on est.""idMedicoActuante"" = medAct.""idMedicoAct" & com

        Dim left As String = " left join ""public"".""tblCajaMovimientos"" as cm on est.""nroEstudio"" = cm.""nroEstudio" & com
        Dim left1 As String = " left join ""public"".""tblCajaTipoDeMovimientos"" as ctm on cm.""idTipoDeMovimiento"" = ctm.""id" & com


        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = selec & inner0 & inner1 & inner2 & inner3 & left & left1 & condicion & " order by ""fechaEstudio"", p.""apellido" & com
            myCommand.Connection = myConnection
            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Public Function getArancelesByObraSocial(ByVal idObraSocial As Integer, ByVal idPractica As Integer) As NpgsqlDataReader
        Dim stringSelect As String = "select ae.""idEstudio"", ae.""estudio"", ""ae"".""codigoMedico"", ""ap"".""Precio"", ap.""fecha"" from ""public"".""AlmacenPreciosEstOS"" as ""ap" & com
        Dim inners As String = " inner join ""public"".""AlmacenEstudios"" as ae on ae.""idEstudio"" = ap.""idEstudio" & com
        Dim condicion As String = " where ap.""idObraSocial"" = " & idObraSocial
        Dim postCondicion As String = " order by ""estudio" & com
        If idPractica <> 0 Then
            condicion &= " and ap.""idEstudio"" = " & idPractica
        End If

        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & inners & condicion & postCondicion
            myCommand.Connection = myConnection

            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)

        End Try
    End Function

    Public Function getPresentaciones(ByVal filtro As String, ByVal orderBy As String) As NpgsqlDataReader
        'ordenar por obra social, dentro de obra social por fecha
        Dim stringSelect As String = "select f.""idFacturacion"", os.""obraSocial"", f." & com &
        "fechaFacturacion"", c.*, f.""pagado"", ti.""id" & com &
        " as idComprobanteTipo, ti." &
        com & "tipoComprobante"", g.""id"" as idGravado, g." & com &
        "descripcionGravado"", g.""porcentajeGravado"", os." & com &
        "idObraSocial"", os.""direccion"", os.""telefono" &
        com & ", os.""localidad"", os.""codigoPostal"", os." & com &
        "condicionFiscal"" as osCondicionFiscal, os.""nroCuit"" as cuitOS, os." &
        com & "observaciones"", f.""periodo"", f.""total"", os." &
        com & "sePresentaPorAMR"", os.""sePresentaPorARA"", f.""totalFacturado" &
        com & "as totalFacturadoPresentacion,""idComprobante"" from ""public" &
        com & ".""tblFacturacion"" as f "
        Dim inners As String = " inner join ""public""." & com &
        "AlmacenObraSocial"" as os on f.""idObraSocial"" = os." & com &
        "idObraSocial"" left join ""public"".""tblComprobantes" &
        com & " as c on f.""idComprobante"" = c.""id"" left join " &
        com & "public"".""tblComprobantesTipo""as ti on c." & com &
        "idTipoComprobante"" = ti.""id"" left join ""public" & com &
        ".""tblGravado"" as g on g.""id""= c.""gravado" & com &
        " left join ""public"".""tblPresentacion_PresentacionAMR" & com &
        "as tPresPresAMR on f.""idFacturacion"" = tPresPresAMR.""idFacturacion" & com


        If orderBy = "" Then
            orderBy = " os.""obraSocial"", ""fechaFacturacion" & com
        End If

        Dim cCondicion As String
        If filtro <> "" Then
            cCondicion = filtro
        Else
            cCondicion = " where ""pagado"" = 0"
        End If
        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & inners & cCondicion & " order by " & orderBy
            myCommand.Connection = myConnection

            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)

        End Try
    End Function


    Public Function getLineasFacturcionAMR(ByVal filtro As String) As NpgsqlDataReader
        Dim inners As String
        Dim stringSelect As String = "select f.""idFacturacion"", fa.""idPresentacionAMR"", fa.""nroRemito"" from ""public"".""tblPresentacion_PresentacionAMR"" as fa "
        inners &= " inner join ""public"".""tblFacturacion"" as f on fa.""idFacturacion"" = f.""idFacturacion" & com

        Dim cCondicion As String = filtro

        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & inners & cCondicion
            myCommand.Connection = myConnection
            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)

        End Try
    End Function

    Public Function getMedicacionEstudio(ByVal nroEstudio As Int64) As NpgsqlDataReader
        Dim stringSelect As String = "select  med.""idMedicacion"", med.""importe"", med.""nroEstudio"", medic.""idMedicamento"", medic.""descripcionMedicamento"", medic.""importeMedicamento"", medic.""tipo"", medic.""codigoMedicoOSDE"" from ""public"".""tblMedicacion"" as med "
        Dim inners As String = " inner join ""public"".""tblMedicamentos"" as medic on med.""idMedicamento"" = medic.""idMedicamento" & com

        Dim cCondicion As String = " where ""nroEstudio"" = " & nroEstudio

        Try
            Dim myCommand2 As New NpgsqlCommand
            myCommand2.CommandType = CommandType.Text
            myCommand2.CommandText = stringSelect & inners & cCondicion
            myCommand2.Connection = myConnection
            Dim myDataReader As NpgsqlDataReader = myCommand2.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        Finally

        End Try


    End Function

    Public Function getGruposUsuario(ByVal idUsuario As Integer) As NpgsqlDataReader
        Dim stringSelect As String = "select  g.""id"", g.""nombre"" from ""webData"".""gruposUsuarios"" as g "
        Dim inners As String = " inner join ""webData"".""usuarios_grupos"" as usr_grp on g.""id"" = usr_grp.""idGrupo"" inner join ""webData"".""tblUsuarios"" as u on usr_grp.""idGrupo"" = u.""idUsuario" & com

        Dim cCondicion As String = " where usr_grp.""idUsuario"" = " & idUsuario

        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & inners & cCondicion
            myCommand.Connection = myConnection

            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)

        End Try
    End Function

    'Traemos todos los tipos de comprobantes 
    Public Function getComprobantesTipos(Optional ByVal filtro As String = "") As NpgsqlDataReader

        Dim stringSelect As String = "select ct.* from ""public"".""tblComprobantesTipo"" as ct "
        Try

            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect
            myCommand.Connection = myConnection
            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)

        End Try

    End Function

    Public Function getComprobantes(ByVal filtro As String, Optional ByVal orderBy As String = "") As NpgsqlDataReader
        'este metodo se invoca desde Comprobantes-buscar

        Dim stringSelect As String = "select c.id, c.""nroComprobante"", c.""nroTerminal"", c.""nombreCliente"", c.""domicilioCliente"", c.""nroCuit"" " &
        " , c.""condicionFiscal"", c.responsable, c.gravado, t.""tipoComprobante"", t.id as idTipo, c.""fechaEmision"", c.""fechaRecepcion"" " &
        ",c.""idFactura"",g.""descripcionGravado"" " &
        " , c.estado, c.""subTipo"", c.""totalFacturado"", c.""totalCobrado"", c.""gravadoPaciente"", c.""CAE"", c.""vencimientoCAE"", g.""porcentajeGravado"" from " & com &
        "public"".""tblComprobantes"" as c " &
        " left join ""public"".""tblComprobantesTipo"" as t on c.""idTipoComprobante"" = t.""id" & com &
        " left join ""public"".""tblGravado"" as g on c.""gravado" & com &
        " = g.""id" & com &
        " "




        Dim concondicion As String = ""
        Dim cCondicion As String
        If filtro <> "" Then
            cCondicion = " where " & filtro
        Else
            cCondicion = concondicion
        End If

        Dim order As String = ""
        If orderBy <> "" Then
            order = " order by " & orderBy
        End If
        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & cCondicion & order
            myCommand.Connection = myConnection
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)

        End Try

    End Function

    Public Function getAll(ByVal tabla As String, Optional ByVal filtro As String = "", Optional ByVal order As String = "") As NpgsqlDataReader
        Dim stringSel As String = "select * from ""public""." & com & tabla & com
        Dim cCondicion As String

        If filtro <> "" Then
            cCondicion = " where " & filtro
        Else
            cCondicion = ""
        End If
        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSel & cCondicion & order
            myCommand.Connection = myConnection

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function

#Region "Caja y Movimientos de caja"
    Public Function getMovimientosCajaAll(ByVal filtro As String) As NpgsqlDataReader
        Dim stringSelect As String
        Dim from As String
        Dim inner0 As String
        Dim left1 As String
        Dim left3 As String
        Dim left4 As String
        Dim left5 As String
        Dim left6 As String
        Dim left7 As String
        Dim left8 As String

        stringSelect = "select cm.*, cm.""id"" as ""idMov"", u.*, ctm.*,est.*,alos.*, p.*, aes.""estudio"",  aes.""abreviatura""  , medAct.* "
        from = " from ""public"".""tblCajaMovimientos"" as cm "
        inner0 = " inner join ""public"".""tblCajaTipoDeMovimientos"" as ctm on cm.""idTipoDeMovimiento"" = ctm.""id" & com

        left1 = " left join ""public"".""tblEstudios"" as est on est.""nroEstudio"" = cm.""nroEstudio" & com
        left3 = " left join ""public"".""AlmacenEstudios"" as aes on est.""idEstudio"" = aes.""idEstudio" & com
        left4 = " left join ""public"".""tblPacientes"" as p on est.""idPaciente"" = p.""id" & com
        left5 = " left join ""public"".""AlmacenObraSocial"" as alos on est.""idObraSocial"" = alos.""idObraSocial" & com
        left6 = " left join ""public"".""AuditUserActionsLog"" as aua on cm.""id"" = aua.""objectId""  and aua.""userActionId"" =1 and aua.""objectTypeId"" =2"
        left7 = " left join ""webData"".""tblUsuarios"" as u on aua.""userId"" = u.""idUsuario" & com
        left8 = " left join ""public"".""tblMedicosAct"" as medAct on cm.""idMedico"" = medAct.""idMedicoAct" & com


        'ordeno por fecha
        Dim order As String = " order by cm.""id"", cm.""fecha"", cm.""hora" & com

        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & from & inner0 & left1 & left3 & left4 & left5 & left6 & left7 & left8 & filtro & order
            myCommand.Connection = myConnection

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Public Function selectMaxMovmiento() As NpgsqlDataReader
        Dim cmd As New NpgsqlCommand("select * from ""public"".""tblCajaMovimientos" & com &
                                     " where id= (SELECT MAX(id) FROM ""public"".""tblCajaMovimientos"")")
        Try
            cmd.Connection = myConnection
            Return cmd.ExecuteReader()
        Catch ex As SqlException

        End Try
    End Function
#End Region



    Public Function getMovimientosStockAll(ByVal filtro As String) As NpgsqlDataReader
        Dim stringSelect As String
        Dim inner1 As String
        Dim inner2 As String
        Dim inner3 As String
        Dim inner4 As String


        stringSelect = "select * "
        inner1 = " from ""public"".""tblMovimientosDeMedicamentos"" as sm "
        inner2 = " INNER join ""public"".""tblMedicamentos"" as med on sm.""idMedicamento"" = med.""idMedicamento" & com
        inner3 = " left join ""public"".""AuditUserActionsLog"" as aua on sm.""id"" = aua.""objectId""  and aua.""userActionId"" =1 and aua.""objectTypeId"" =4"
        inner4 = " left join ""webData"".""tblUsuarios"" as u on aua.""userId"" = u.""idUsuario" & com

        Dim cCondicion As String
        If filtro <> "" Then
            cCondicion = " where " & filtro
        Else
            cCondicion = ""
        End If
        'ordeno por fecha
        Dim order As String = " order by sm.""fecha"" ,sm.""id" & com

        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & inner1 & inner2 & inner3 & inner4 & cCondicion & order
            myCommand.Connection = myConnection

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Public Function getAuditLogsNew(ByVal objectId As String, ByVal app As String, ByVal model As String) As NpgsqlDataReader
        Dim stringSelect As String = "select
                log.id
              , a.id as idUsuario
              , a.username as nombreUsuario
              , log.object_id as objectId
              , log.action_flag as userActionId
              , ct.id as objectTypeId
              , log.action_time as dateTime
              , log.change_message as observacion
            from django_admin_log as log
            join auth_user As a On log.user_id = a.id
            join django_content_type as ct on ct.id = log.content_type_id
            where log.object_id = '{0}'
              and ct.model = '{1}'
              and ct.app_label = '{2}' 
            order by action_time desc
            limit 1
        "

        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = String.Format(stringSelect, objectId, model, app)
            myCommand.Connection = myConnection

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function


    Public Function getAuditLogs(ByVal filtro As String) As NpgsqlDataReader
        Dim stringSelect As String = " select log.*, a.*, u.* from ""public"".""AuditUserActionsLog"" as log "
        Dim inners As String = " left join ""public"".""AuditUserActions"" as a on log.""userActionId"" = a.""id" & com
        Dim inner2 As String = " left join ""webData"".""tblUsuarios"" as u on log.""userId"" = u.""idUsuario" & com

        Dim concondicion As String = ""
        Dim cCondicion As String
        If filtro <> "" Then
            cCondicion = " where " & filtro
        Else
            cCondicion = concondicion
        End If
        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & inners & inner2 & cCondicion
            myCommand.Connection = myConnection
            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader

            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function

    Public Function getMedicos() As NpgsqlDataReader
        Dim com As String = """"
        Dim stringSelect As String = ""
        Dim from As String = ""
        'Dim leftJoin As String = ""
        Dim order As String = ""
        Dim drMedicos As NpgsqlDataReader
        stringSelect = "select medicos.*"
        from = " from ""public"".""tblMedicosAct"" as medicos "
        'leftJoin = " left join ""public"".""tblGravado"" as gravado on medicos.""idGravado"" = gravado.""id" & com
        order = " order by medicos.""apellidoMedicoAct"""
        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & from & order
            myCommand.Connection = myConnection
            myCommand.ExecuteNonQuery()
            drMedicos = myCommand.ExecuteReader

            Return drMedicos
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function

    Public Function existeEstudioNuevoPublicID(ByVal posiblePublicID As String) As Integer

        Dim com As String = """"
        Dim cmd As New NpgsqlCommand("select COUNT(*)  from ""public"".""tblEstudios" & com &
        " where ""publicID""  = '" & posiblePublicID & "' ", myConnection)
        Try
            Return cmd.ExecuteScalar()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            cmd = Nothing
        End Try
    End Function



    '--------------------------------General Function----------------------------------------

    Public Function selectSum(ByVal tableName As String, ByVal idColumnName As String, Optional ByVal filtro As String = "") As Decimal

        Dim cmd As New NpgsqlCommand("select sum(" & com & idColumnName & com & ") from ""public""." & com & tableName & com & filtro, myConnection)
        Try
            Dim o As Object = cmd.ExecuteScalar
            If o IsNot DBNull.Value Then
                Dim sum As Decimal = Convert.ToDecimal(o)
                Return sum
            Else : Return 0
            End If

        Catch ex As SqlException
            Return 0
        End Try
    End Function

End Class
