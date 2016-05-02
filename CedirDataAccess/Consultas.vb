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
            Dim myCommand As New NpgsqlCommand("select * from " & com & "public" & com & "." & com & NombreTabla & com, myConnection)
            myCommand.CommandType = CommandType.Text

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function
    Public Function Tabla(ByVal NombreTabla As String, ByVal condicion As String) As NpgsqlDataReader
        Dim com As String = """"
        Dim myCommand As New NpgsqlCommand("select * from " & com & "public" & com & "." & com & NombreTabla & com & condicion, myConnection)
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
            Dim query As String = "select * from " & com & "public" & com & "." & com & tabla & com & " WHERE " & com & columna & com & "= (SELECT max(" & columna & ") FROM" & com & "public" & com & "." & com & tabla & com & ")"
            Dim myCommand As New NpgsqlCommand(query, myConnection)
            myCommand.CommandType = CommandType.Text
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader
        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try
    End Function

    Public Function traerEstudios(ByVal condicion As String, Optional ByVal filtro As String = "") As NpgsqlDataReader
        Dim StringPuto As String = "select est." & com & "nroEstudio" & com & ", alos.*, " & com & "fechaEstudio" & com & "," &
        com & "motivoEstudio" & com & "," & com & "informe" & com & "," & " det." & com & "idObraSocial" & com &
        ",  " & com & "publicID" & com &
        " ,det." & com & "idMedicoActuante" & com & ",det." & com & "idMedicoSolicitante" & com & ", " & com &
        "enlaceVideo" & com & "," & com &
        "nroDeOrden" & com & "," & com & "lugar" & com & "," & com &
        "idFacturacion" & com & ", " & com & "idAnestesista" & com & "," & com & "fechaCobro" & com & "," & com &
        "importeEstudio" & com & "," & com & "importeMedicacion" & com & "," & com & "pagoContraFactura" & com &
        "," & com & "diferenciaPaciente" & com & "," & com & "nroPagoMedicoAct" & com & "," & com &
        "pension" & com & ", " & com & "importePagoMedico" & com & ", " & com & "porcentajeIVAPagoMedicoActuante" &
        com & "," & com & "nroPagoMedicoSol" & com & ", " & com & "importePagoMedicoSol" & com & "," & com &
        "estudio" & com & "," & com & "codigoMedico" & com & "," & com & "dni" & com & "," & com & "idPaciente" & com & "," & com & "e_mail" &
        com & "," & com & "fechaNacimiento" & com & "," & com & "nombres" & com & "," & com & "apellido" & com & "," &
        com & "sexo" & com & "," & com & "nroAfiliado" & com & "," & com & "tel" & com & ", p." & com &
        "direccion" & com & " as " & com & "direPaciente" & com & " , " & com & "nombreMedicoAct" & com & ", med." & com & "nroMatricula" & com & "," & com &
        "medAnestesista" & com & "." & com & "nombreMedicoAn" & com & " , " & com & "medAnestesista" & com & "." & com & "apellidoMedicoAn" & com & ", " & com & "medAnestesista" & com & "." & com & "nroMatricula" & com &
        ", " & com & "apellidoMedicoAct" & com & "," & com & "nombreMedicoSol" & com & "," & com & "apellidoMedicoSol" & com & "," & com & "obraSocial" & com & ", " & com & "Precio" & com & ", " & com & "esPagoContraFactura" & com & ", est." & com & "idEstudio" & com & ", " & com & "sePresentaPorAMR" & com & ", " & com & "sePresentaPorARA" & com & ", pce." & com & "arancelAnestesia" & com & ", pce." & com & "importeCobradoPension" & com & ", pce." & com & "importeEstudioCobrado" & com & ", pce." & com & "importeCobradoArancelAnestesia" & com & ", pce." & com & "importeMedicacionCobrado" & com & ", ale." & com & "abreviatura" & com & ", ale." & com & "codigoMedicoOSDE" & com & " from " & com & "public" & com & "." & com & "tblEstudios" & com & " as est "

        Dim inners As String = " inner join " & com & "public" & com & "." & com & "tblDetalleEstudio" & com &
        " as det on est." & com & "nroEstudio" & com & " = det." & com & "nroEstudio" & com & " inner join " & com &
        "public" & com & "." & com & "tblPagoCobroEstudio" & com & " as pce on est." & com & "nroEstudio" & com &
        " = pce." & com & "nroEstudio" & com & " inner join " & com & "public" & com & "." & com &
        "AlmacenEstudios" & com & " as ale on  est." & com & "idEstudio" & com & " = ale." & com & "idEstudio" & com &
        " inner join " & com & "public" & com & "." & com & "tblPacientes" & com & " as p on est." & com & "idPaciente" &
        com & " = p." & com & "id" & com & " inner join " & com & "public" & com & "." & com & "tblMedicosAct" &
        com & " as med on det." & com & "idMedicoActuante" & com & " = med." & com & "idMedicoAct" & com & " inner join " &
com & "public" & com & "." & com & "tblMedicosAnestesistas" & com & " as " & com & "medAnestesista" & com & " on det." & com & "idAnestesista" & com & " = " & com & "medAnestesista" & com & "." & com & "idMedicoAn" &
com & " inner join " & com & "public" & com & "." & com & "tblMedicosSol" & com & " as meds on det." & com & "idMedicoSolicitante" &
        com & " = meds." & com & "idMedicoSol" & com & " inner join " & com & "public" & com & "." &
        com & "AlmacenObraSocial" & com & " as alos on det." & com & "idObraSocial" & com & " = alos." & com & "idObraSocial" &
        com & " left join " & com & "public" & com & "." & com & "AlmacenPreciosEstOS" & com & " as eo on est." &
        com & "idEstudio" & com & " = eo." & com & "idEstudio" & com & " and det." & com & "idObraSocial" & com & " = eo." &
        com & "idObraSocial" & com

        Dim order As String = ""

        If filtro = "paciente" Then
            order = " order by " & com & "fechaEstudio" & com & ", p." & com & "apellido" & com & ", p." & com & "nombres" & com & " ASC "
        Else
            order = " order by est." & com & "fechaEstudio" & com & ", p." & com & "id" & com & " ASC "
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
        Dim selec As String = "select est.*,det.*, alos.*,cm.*, ctm.*,p.*, cm.id as " & com & "idMov" & com & ", cm." & com & "nroEstudio" & com & " as " & com & "nroEstudioMovimiento" & com & ",ales.*, medAct.*  from " & com & "public" & com & "." & com & "tblEstudios" & com & " as est "
        Dim inner As String = " inner join " & com & "public" & com & "." & com & "tblDetalleEstudio" & com & " as det on est." & com & "nroEstudio" & com & " = det." & com & "nroEstudio" & com
        Dim inner0 As String = " inner join " & com & "public" & com & "." & com & "AlmacenObraSocial" & com & " as alos on det." & com & "idObraSocial" & com & " = alos." & com & "idObraSocial" & com
        Dim inner1 As String = " inner join " & com & "public" & com & "." & com & "tblPacientes" & com & " as p on est." & com & "idPaciente" & com & " = p." & com & "id" & com
        Dim inner2 As String = " inner join " & com & "public" & com & "." & com & "AlmacenEstudios" & com & " as ales on est." & com & "idEstudio" & com & " = ales." & com & "idEstudio" & com
        Dim inner3 As String = " inner join " & com & "public" & com & "." & com & "tblMedicosAct" & com & " as medAct on det." & com & "idMedicoActuante" & com & " = medAct." & com & "idMedicoAct" & com

        Dim left As String = " left join " & com & "public" & com & "." & com & "tblCajaMovimientos" & com & " as cm on est." & com & "nroEstudio" & com & " = cm." & com & "nroEstudio" & com
        Dim left1 As String = " left join " & com & "public" & com & "." & com & "tblCajaTipoDeMovimientos" & com & " as ctm on cm." & com & "idTipoDeMovimiento" & com & " = ctm." & com & "id" & com


        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = selec & inner & inner0 & inner1 & inner2 & inner3 & left & left1 & condicion & " order by " & com & "fechaEstudio" & com & ", p." & com & "apellido" & com
            myCommand.Connection = myConnection
            myCommand.ExecuteNonQuery()
            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Public Function getArancelesByObraSocial(ByVal idObraSocial As Integer, ByVal idPractica As Integer) As NpgsqlDataReader
        Dim stringSelect As String = "select ae." & com & "idEstudio" & com & ", ae." & com & "estudio" & com & ", " & com & "ae" & com & "." & com & "codigoMedico" & com & ", " & com & "ap" & com & "." & com & "Precio" & com & ", ap." & com & "fecha" & com & " from " & com & "public" & com & "." & com & "AlmacenPreciosEstOS" & com & " as " & com & "ap" & com
        Dim inners As String = " inner join " & com & "public" & com & "." & com & "AlmacenEstudios" & com & " as ae on ae." & com & "idEstudio" & com & " = ap." & com & "idEstudio" & com
        Dim condicion As String = " where ap." & com & "idObraSocial" & com & " = " & idObraSocial
        Dim postCondicion As String = " order by " & com & "estudio" & com
        If idPractica <> 0 Then
            condicion &= " and ap." & com & "idEstudio" & com & " = " & idPractica
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
        Dim stringSelect As String = "select f." & com & "idFacturacion" & com & ", os." & com & "obraSocial" & com & ", f." & com &
        "fechaFacturacion" & com & ", c.*, f." & com & "pagado" & com & ", ti." & com & "id" & com &
        " as idComprobanteTipo, ti." &
        com & "tipoComprobante" & com & ", g." & com & "id" & com & " as idGravado, g." & com &
        "descripcionGravado" & com & ", g." & com & "porcentajeGravado" & com & ", os." & com &
        "idObraSocial" & com & ", os." & com & "direccion" & com & ", os." & com & "telefono" &
        com & ", os." & com & "localidad" & com & ", os." & com & "codigoPostal" & com & ", os." & com &
        "condicionFiscal" & com & " as osCondicionFiscal, os." & com & "nroCuit" & com & " as cuitOS, os." &
        com & "observaciones" & com & ", f." & com & "periodo" & com & ", f." & com & "total" & com & ", os." &
        com & "sePresentaPorAMR" & com & ", os." & com & "sePresentaPorARA" & com & ", f." & com & "totalFacturado" &
        com & "as totalFacturadoPresentacion," & com & "idComprobante" & com & " from " & com & "public" &
        com & "." & com & "tblFacturacion" & com & " as f "
        Dim inners As String = " inner join " & com & "public" & com & "." & com &
        "AlmacenObraSocial" & com & " as os on f." & com & "idObraSocial" & com & " = os." & com &
        "idObraSocial" & com & " left join " & com & "public" & com & "." & com & "tblComprobantes" &
        com & " as c on f." & com & "idComprobante" & com & " = c." & com & "id" & com & " left join " &
        com & "public" & com & "." & com & "tblComprobantesTipo" & com & "as ti on c." & com &
        "idTipoComprobante" & com & " = ti." & com & "id" & com & " left join " & com & "public" & com &
        "." & com & "tblGravado" & com & " as g on g." & com & "id" & com & "= c." & com & "gravado" & com &
        " left join " & com & "public" & com & "." & com & "tblPresentacion_PresentacionAMR" & com &
        "as tPresPresAMR on f." & com & "idFacturacion" & com & " = tPresPresAMR." & com & "idFacturacion" & com


        If orderBy = "" Then
            orderBy = " os." & com & "obraSocial" & com & ", " & com & "fechaFacturacion" & com
        End If

        Dim cCondicion As String
        If filtro <> "" Then
            cCondicion = filtro
        Else
            cCondicion = " where " & com & "pagado" & com & " = 0"
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
        Dim stringSelect As String = "select f." & com & "idFacturacion" & com & ", fa." & com & "idPresentacionAMR" & com & ", fa." & com & "nroRemito" & com & " from " & com & "public" & com & "." & com & "tblPresentacion_PresentacionAMR" & com & " as fa "
        inners &= " inner join " & com & "public" & com & "." & com & "tblFacturacion" & com & " as f on fa." & com & "idFacturacion" & com & " = f." & com & "idFacturacion" & com

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
        Dim stringSelect As String = "select  med." & com & "idMedicacion" & com & ", med." & com & "importe" & com & ", med." & com & "nroEstudio" & com & ", medic." & com & "idMedicamento" & com & ", medic." & com & "descripcionMedicamento" & com & ", medic." & com & "importeMedicamento" & com & ", medic." & com & "tipo" & com & ", medic." & com & "codigoMedicoOSDE" & com & " from " & com & "public" & com & "." & com & "tblMedicacion" & com & " as med "
        Dim inners As String = " inner join " & com & "public" & com & "." & com & "tblMedicamentos" & com & " as medic on med." & com & "idMedicamento" & com & " = medic." & com & "idMedicamento" & com

        Dim cCondicion As String = " where " & com & "nroEstudio" & com & " = " & nroEstudio

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
        Dim stringSelect As String = "select  g." & com & "id" & com & ", g." & com & "nombre" & com & " from " & com & "webData" & com & "." & com & "gruposUsuarios" & com & " as g "
        Dim inners As String = " inner join " & com & "webData" & com & "." & com & "usuarios_grupos" & com & " as usr_grp on g." & com & "id" & com & " = usr_grp." & com & "idGrupo" & com & " inner join " & com & "webData" & com & "." & com & "tblUsuarios" & com & " as u on usr_grp." & com & "idGrupo" & com & " = u." & com & "idUsuario" & com

        Dim cCondicion As String = " where usr_grp." & com & "idUsuario" & com & " = " & idUsuario

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

        Dim stringSelect As String = "select ct.* from " & com & "public" & com & "." & com & "tblComprobantesTipo" & com & " as ct "
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
        "public" & com & "." & com & "tblComprobantes" & com & " as c " &
        " left join " & com & "public" & com & "." & com & "tblComprobantesTipo" & com & " as t on c." & com & "idTipoComprobante" & com & " = t." & com & "id" & com &
        " left join " & com & "public" & com & "." & com & "tblGravado" & com & " as g on c." & com & "gravado" & com &
        " = g." & com & "id" & com &
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
        Dim stringSel As String = "select * from " & com & "public" & com & "." & com & tabla & com
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
        Dim left2 As String
        Dim left3 As String
        Dim left4 As String
        Dim left5 As String
        Dim left6 As String
        Dim left7 As String
        Dim left8 As String

        stringSelect = "select cm.*, cm." & com & "id" & com & " as " & com & "idMov" & com & ", u.*, ctm.*,est.*,alos.*, p.*, aes." & com & "estudio" & com & ",  aes." & com & "abreviatura" & com & "  , medAct.* "
        from = " from " & com & "public" & com & "." & com & "tblCajaMovimientos" & com & " as cm "
        inner0 = " inner join " & com & "public" & com & "." & com & "tblCajaTipoDeMovimientos" & com & " as ctm on cm." & com & "idTipoDeMovimiento" & com & " = ctm." & com & "id" & com

        left1 = " left join " & com & "public" & com & "." & com & "tblEstudios" & com & " as est on est." & com & "nroEstudio" & com & " = cm." & com & "nroEstudio" & com
        left2 = " left join " & com & "public" & com & "." & com & "tblDetalleEstudio" & com & " as det on est." & com & "nroEstudio" & com & " = det." & com & "nroEstudio" & com
        left3 = " left join " & com & "public" & com & "." & com & "AlmacenEstudios" & com & " as aes on est." & com & "idEstudio" & com & " = aes." & com & "idEstudio" & com
        left4 = " left join " & com & "public" & com & "." & com & "tblPacientes" & com & " as p on est." & com & "idPaciente" & com & " = p." & com & "id" & com
        left5 = " left join " & com & "public" & com & "." & com & "AlmacenObraSocial" & com & " as alos on det." & com & "idObraSocial" & com & " = alos." & com & "idObraSocial" & com
        left6 = " left join " & com & "public" & com & "." & com & "AuditUserActionsLog" & com & " as aua on cm." & com & "id" & com & " = aua." & com & "objectId" & com & "  and aua." & com & "userActionId" & com & " =1 and aua." & com & "objectTypeId" & com & " =2"
        left7 = " left join " & com & "webData" & com & "." & com & "tblUsuarios" & com & " as u on aua." & com & "userId" & com & " = u." & com & "idUsuario" & com
        left8 = " left join " & com & "public" & com & "." & com & "tblMedicosAct" & com & " as medAct on cm." & com & "idMedico" & com & " = medAct." & com & "idMedicoAct" & com


        'ordeno por fecha
        Dim order As String = " order by cm." & com & "id" & com & ", cm." & com & "fecha" & com & ", cm." & com & "hora" & com

        Try
            myCommand.CommandType = CommandType.Text
            myCommand.CommandText = stringSelect & from & inner0 & left1 & left2 & left3 & left4 & left5 & left6 & left7 & left8 & filtro & order
            myCommand.Connection = myConnection

            Dim myDataReader As NpgsqlDataReader = myCommand.ExecuteReader
            Return myDataReader

        Catch ex As Exception
            Throw New Exception(ex.ToString)
        End Try

    End Function

    Public Function selectMaxMovmiento() As NpgsqlDataReader
        Dim cmd As New NpgsqlCommand("select * from " & com & "public" & com & "." & com & "tblCajaMovimientos" & com &
                                     " where id= (SELECT MAX(id) FROM " & com & "public" & com & "." & com & "tblCajaMovimientos" & com & ")")
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
        inner1 = " from " & com & "public" & com & "." & com & "tblMovimientosDeMedicamentos" & com & " as sm "
        inner2 = " INNER join " & com & "public" & com & "." & com & "tblMedicamentos" & com & " as med on sm." & com & "idMedicamento" & com & " = med." & com & "idMedicamento" & com
        inner3 = " left join " & com & "public" & com & "." & com & "AuditUserActionsLog" & com & " as aua on sm." & com & "id" & com & " = aua." & com & "objectId" & com & "  and aua." & com & "userActionId" & com & " =1 and aua." & com & "objectTypeId" & com & " =4"
        inner4 = " left join " & com & "webData" & com & "." & com & "tblUsuarios" & com & " as u on aua." & com & "userId" & com & " = u." & com & "idUsuario" & com

        Dim cCondicion As String
        If filtro <> "" Then
            cCondicion = " where " & filtro
        Else
            cCondicion = ""
        End If
        'ordeno por fecha
        Dim order As String = " order by sm." & com & "fecha" & com & " ,sm." & com & "id" & com

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


    Public Function getAuditLogs(ByVal filtro As String) As NpgsqlDataReader
        Dim stringSelect As String = " select log.*, a.*, u.* from " & com & "public" & com & "." & com & "AuditUserActionsLog" & com & " as log "
        Dim inners As String = " left join " & com & "public" & com & "." & com & "AuditUserActions" & com & " as a on log." & com & "userActionId" & com & " = a." & com & "id" & com
        Dim inner2 As String = " left join " & com & "webData" & com & "." & com & "tblUsuarios" & com & " as u on log." & com & "userId" & com & " = u." & com & "idUsuario" & com

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
        from = " from " & com & "public" & com & "." & com & "tblMedicosAct" & com & " as medicos "
        'leftJoin = " left join " & com & "public" & com & "." & com & "tblGravado" & com & " as gravado on medicos." & com & "idGravado" & com & " = gravado." & com & "id" & com
        order = " order by medicos." & com & "apellidoMedicoAct" & com & ""
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
        Dim cmd As New NpgsqlCommand("select COUNT(*)  from " & com & "public" & com & "." & com & "tblEstudios" & com &
        " where " & com & "publicID" & com & "  = '" & posiblePublicID & "' ", myConnection)
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

        Dim cmd As New NpgsqlCommand("select sum(" & com & idColumnName & com & ") from " & com & "public" & com & "." & com & tableName & com & filtro, myConnection)
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
