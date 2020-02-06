Imports System.Text.RegularExpressions
Imports CedirDataAccess
Imports System.Collections.Generic
Imports Npgsql
Public Class CatalogoDeEstudios

    Dim com As String = """"
    Dim da As Consultas
    Dim daNuevo As Nuevo

    Public Sub New()
        da = New Consultas
        daNuevo = New Nuevo
    End Sub

    Public Function ObtenerEstudiosDeHoy() As ArrayList
        Return loadEstudios("where " & com & "fechaEstudio" & com & " = ' " & Today.Month & "/" & Today.Day & "/" & Today.Year & " '")
        'Return loadEstudios("where " & com & "fechaEstudio" & com & " = ' " & Today.Day & "/" & Today.Month & "/" & Today.Year & " '", "paciente")
    End Function

    Public Function TraerEstudios(Optional ByVal apePaciente As String = "", Optional ByVal nomPaciente As String = "", Optional ByVal idMedico As Integer = 0, Optional ByVal radioState As Int16 = 1, Optional ByVal fechaDesde As String = "", Optional ByVal fechaHasta As String = "", Optional ByVal practica As Practica = Nothing, Optional ByVal dni As String = "", Optional ByVal idObraSocial As Integer = 0, Optional ByVal filtro As String = "") As ArrayList



        Dim consulta As String = ""
        Dim consMedicos As String = ""
        Dim consNomPaciente As String = ""
        Dim consApePaciente As String = ""
        Dim consDni As String = ""
        Dim consFecha As String = ""
        Dim consOS As String = ""

        If idMedico = 0 Then
            ' no se eligio ningun medico
            consMedicos = ""
        Else

            Select Case radioState
                Case 1 : consMedicos = "(" & com & "idMedicoActuante" & com & " = " & idMedico & ")"
                Case 2 : consMedicos = "(" & com & "idMedicoSolicitante" & com & " = " & idMedico & ")"
                Case 3 : consMedicos = "(" & com & "idMedicoActuante" & com & " = " & idMedico & " and " & com & "idMedicoSolicitante" & com & " = " & idMedico & ")"
            End Select
        End If

        'If nomPaciente <> "" Then
        '    consNomPaciente = "(p." & com & "nombres" & com & " like '%" & nomPaciente.ToUpper() & "%' or p." & com & "apellido" & com & " like '%" & nomPaciente.ToUpper() & "%')"
        'End If
        If nomPaciente <> "" Then
            consNomPaciente = "UPPER(p." & com & "nombres" & com & ") like '%" & nomPaciente.ToUpper() & "%'"
        End If

        If apePaciente <> "" Then
            consApePaciente = "UPPER(p." & com & "apellido" & com & ") like '%" & apePaciente.ToUpper() & "%'"
        End If

        If dni <> "" Then
            consDni = " p." & com & "dni" & com & " = " & dni
        End If


        If fechaDesde <> "" And fechaHasta <> "" Then

            consFecha = "(" & com & "fechaEstudio" & com & " between '" & fechaDesde & "' and '" & fechaHasta & "')"

        ElseIf fechaDesde <> "" And fechaHasta = "" Then
            'Por default, traigo los estudios de UNA fecha particular, no DESDE una fecha particular
            consFecha = "(" & com & "fechaEstudio" & com & " = '" & fechaDesde & "')"

        ElseIf fechaDesde = "" And fechaHasta <> "" Then

            consFecha = "(" & com & "fechaEstudio" & com & " <= '" & fechaHasta & "')"

            'ElseIf fechaDesde = "" And fechaHasta = "" Then

            '    consFecha = "(" & com & "fechaEstudio" & com & " = '" & Date.Today.ToString.Remove(10) & "')"


        End If

        If idObraSocial <> 0 Then
            consOS = " alos. " & com & "idObraSocial" & com & " = " & idObraSocial
        End If

        If consulta <> "" Then
            If consMedicos <> "" Then
                consulta = consulta & " and " & consMedicos
            End If
        Else
            consulta = consMedicos
        End If

        If consulta <> "" Then
            If consOS <> "" Then
                consulta = consulta & " and " & consOS
            End If
        Else
            consulta = consulta & consOS
        End If

        If consulta <> "" Then
            If consNomPaciente <> "" Then
                consulta = consulta & " and " & consNomPaciente
            End If

        Else
            consulta = consNomPaciente
        End If

        If consulta <> "" Then
            If consApePaciente <> "" Then
                consulta = consulta & " and " & consApePaciente
            End If

        Else
            consulta = consApePaciente
        End If


        If consulta <> "" Then
            If consDni <> "" Then
                consulta = consulta & " and " & consDni
            End If
        Else
            consulta = consulta & consDni

        End If

        If consulta <> "" Then
            If consFecha <> "" Then
                consulta = consulta & " and " & consFecha
            End If
        Else
            consulta = consulta & consFecha
        End If



        If consulta <> "" Then
            consulta = " where " & consulta
        End If

        If practica IsNot Nothing Then
            consulta = consulta & " and ale." & com & "idEstudio" & com & " = " & practica.idEstudio
        End If


        Return loadEstudios(consulta, filtro)

    End Function
    Public Function traerEstudiosPagados(Optional ByVal idMedico As Integer = 0, Optional ByVal fechaDesde As String = "", Optional ByVal fechaHasta As String = "", Optional ByVal practica As Practica = Nothing) As ArrayList


        Dim consulta As String = ""
        Dim consMedicos As String = ""
        Dim consNomPaciente As String = ""

        Dim consFecha As String = ""


        If idMedico = 0 Then
            ' no se eligio ningun medico
            consMedicos = ""
        Else
            consMedicos = "(" & com & "idMedicoActuante" & com & " = " & idMedico & ")"
        End If

      

        If fechaDesde <> "" And fechaHasta <> "" Then

            consFecha = "(" & com & "fechaEstudio" & com & " between '" & fechaDesde & "' and '" & fechaHasta & "')"

        ElseIf fechaDesde <> "" And fechaHasta = "" Then
            'Por default, traigo los estudios de UNA fecha particular, no DESDE una fecha particular
            consFecha = "(" & com & "fechaEstudio" & com & " = '" & fechaDesde & "')"

        ElseIf fechaDesde = "" And fechaHasta <> "" Then

            consFecha = "(" & com & "fechaEstudio" & com & " <= '" & fechaHasta & "')"

        End If


        consulta = consMedicos

        If consulta <> "" Then
            If consFecha <> "" Then
                consulta = consulta & " and " & consFecha
            End If
        Else
            consulta = consulta & consFecha
        End If

        If consulta <> "" Then
            consulta = " where " & consulta
        End If

        If practica IsNot Nothing Then
            consulta = consulta & " and ale." & com & "idEstudio" & com & " = " & practica.idEstudio
        End If

        If consulta <> "" Then
            consulta = consulta & " and  est." & com & "fechaCobro" & com & " <> null "
        End If



        Return loadEstudios(consulta)

    End Function
    Public Function traerEstudiosPendientesPagoMedico(ByVal idMedico As Integer) As ArrayList
        'Esta funcion se usa solo desde pago a los medicos
        'Dim consulta As String = " where (" & com & "idMedicoActuante" & com & " = " & idMedico & " or " & com & "idMedicoSolicitante" & com & " = " & idMedico & ") and (" & com & "fechaCobro" & com & " is not null) and (" & com & "nroPagoMedicoAct" & com & " is null or " & com & "nroPagoMedicoSol" & com & " is null)"
        'Dim consulta As String = " where (" & com & "idMedicoActuante" & com & " = " & idMedico & ") and (" & com & "fechaCobro" & com & " is not null) and (" & com & "nroPagoMedicoAct" & com & " is null )"
        Dim consulta As String = "where (  (( (" & com & "fechaCobro" & com & "is not null) or (" & com & "esPagoContraFactura" & com & " = 1) ) and  (" & com & "idMedicoActuante" & com & " = " & idMedico & " ) and (" & com & "nroPagoMedicoAct" & com & " is null)) or  (( (" & com & "fechaCobro" & com & " is not null) or (" & com & "esPagoContraFactura" & com & " = 1) ) and  (" & com & "idMedicoSolicitante" & com & "= " & idMedico & " ) and (" & com & "nroPagoMedicoSol" & com & "is null))) "
        Return loadEstudios(consulta)
    End Function
    Public Function traerEstudiosPorMedico(ByVal idMedico As Integer, ByVal descPaciente As String, ByVal fechaDesde As String, ByVal fechaHasta As String, ByVal pagados As Boolean, ByVal cobrados As Boolean) As ArrayList
        'Esta funcion se usa solo desde mi cuenta, y trae el resumen de un medico
        Dim consulta As String

        If cobrados Then
            consulta = "where (  (( " & com & "fechaCobro" & com & "is not null) and  (" & com & "idMedicoActuante" & com & " = " & idMedico & " ) and (" & com & "nroPagoMedicoAct" & com & " is null)) or  ((" & com & "fechaCobro" & com & " is not null) and  (" & com & "idMedicoSolicitante" & com & "= " & idMedico & " ) and (" & com & "nroPagoMedicoSol" & com & "is null))) "
        ElseIf pagados Then
            consulta = "where (  ((" & com & "idMedicoActuante" & com & " = " & idMedico & " ) and (" & com & "nroPagoMedicoAct" & com & " is not null)) or  ((" & com & "idMedicoSolicitante" & com & "= " & idMedico & " ) and (" & com & "nroPagoMedicoSol" & com & "is not null))) "
        Else
            consulta = "where (  ((" & com & "idMedicoActuante" & com & " = " & idMedico & " )) or  ((" & com & "idMedicoSolicitante" & com & "= " & idMedico & " ))) "
        End If

        If descPaciente <> "" Then
            consulta &= " and (UPPER(p." & com & "nombres" & com & ") like '%" & descPaciente.ToUpper() & "%' or UPPER(p." & com & "apellido" & com & ") like '%" & descPaciente.ToUpper() & "%')"
        End If

        Dim r As New System.Text.RegularExpressions.Regex("(/)")
        Dim arrR As String()
        If fechaDesde <> "" And fechaHasta <> "" Then
            arrR = r.Split(fechaDesde)
            fechaDesde = arrR(0) & "/" & arrR(2) & "/" & arrR(4)
            arrR = r.Split(fechaHasta)
            fechaHasta = arrR(0) & "/" & arrR(2) & "/" & arrR(4)
            consulta &= " and " & com & "fechaEstudio" & com & " between '" & fechaDesde & "' and '" & fechaHasta & "'"
        ElseIf fechaDesde <> "" Then
            arrR = r.Split(fechaDesde)
            fechaDesde = arrR(0) & "/" & arrR(2) & "/" & arrR(4)
            consulta &= " and " & com & "fechaEstudio" & com & " = '" & fechaDesde & "'"
        Else
            'trae todos
        End If

        Return loadEstudios(consulta)
    End Function
    Public Function traerDetallePagoMedico(ByVal nroPago As Integer) As ArrayList
        'Esta funcion se usa solo desde detallePago, para traer los estudios de un pago
        Dim consulta As String = " where (" & com & "nroPagoMedicoAct" & com & " = " & nroPago & " or " & com & "nroPagoMedicoSol" & com & " = " & nroPago & ") "
        Return loadEstudios(consulta)
    End Function
    Public Function traerEstudioConArancel(ByVal nroDeEstudio As Int64) As Estudio
        Dim arrEstudios As ArrayList = loadEstudios(" where est." & com & "nroEstudio" & com & " = " & nroDeEstudio)
        If arrEstudios.Count <> 0 Then
            Return arrEstudios(0)
        End If
    End Function
    Public Function traerEstudiosArancelados(ByVal condicion As String) As ArrayList
        Return loadEstudios(condicion)
    End Function
    Public Function obtenerUltimoNroEstudio() As Integer
        Dim da As New Consultas
        Dim dr As NpgsqlDataReader
        Try
            dr = da.EjecutarSelect("select max(" & com & "nroEstudio" & com & ") from " & com & "public" & com & "." & com & "tblEstudios" & com)
            dr.Read()
            Return dr.Item(0)
        Finally
            da = Nothing
            dr = Nothing

        End Try

    End Function
    Public Function borrarEstudio(ByVal estudio As Estudio) As String
        Dim resp As String
        Dim condicion As String
        condicion = " where  est." & com & "nroEstudio" & com & " = " & estudio.nroEstudio & ""

        Dim lista As New List(Of MovimientoDeCaja)
        Dim catMov As New CatalogoDeMovimientosDeCaja
        lista = catMov.traerMovimientos(condicion)
        If lista.Count > 0 Then
            For Each m As MovimientoDeCaja In lista
                m.Concepto = m.Concepto & "           ESTE MOVIMIENTO POSEÍA UN ESTUDIO ASOCIADO. Paciente....: " & estudio.paciente.nombreCompleto() & " , Nro de Estudio:..." & estudio.nroEstudio
                m.modificar()
            Next

        End If

        estudio.borrarMedicacion()
        resp = daNuevo.borrarEstudio(estudio.nroEstudio)

        Return resp
    End Function
    Public Function borrarConsulta(ByVal idConsulta As Int64) As String
        Dim resp As String
        Dim upd As New CedirDataAccess.Nuevo
        resp = upd.delete("tblConsultas", com & "id" & com & " = " & idConsulta)
        Return resp
    End Function

    Public Function obtenerUltimoNroConsulta() As Integer
        Dim dr As NpgsqlDataReader
        dr = da.EjecutarSelect("select max(" & com & "id" & com & ") from " & com & "public" & com & "." & com & "tblConsultas" & com)
        dr.Read()
        Return dr.Item(0)
    End Function
    Public Function getEstudiosPorAnestesista(ByVal filtro As String) As ArrayList
        Return loadEstudios(filtro)
    End Function
    Public Function loadEstudios(ByVal condicion As String, Optional ByVal filtro As String = "") As ArrayList
        loadEstudios = New ArrayList
        Dim drEstudios As NpgsqlDataReader
        drEstudios = da.traerEstudios(condicion, filtro)
        Dim vEstudio As Estudio
        While drEstudios.Read()
            vEstudio = New Estudio
            vEstudio.publicID = drEstudios.Item("publicID")
            vEstudio.nroEstudio = drEstudios.Item("nroEstudio")
            vEstudio.fechaEstudio = drEstudios.Item("fechaEstudio")
            vEstudio.motivoEstudio = drEstudios.Item("motivoEstudio")
            vEstudio.informe = drEstudios.Item("informe")
            vEstudio.obraSocial.idObraSocial = drEstudios.Item("idObraSocial")
            vEstudio.medicoActuante.idMedico = drEstudios.Item("idMedicoActuante")
            vEstudio.medicoSolicitante.idMedico = drEstudios.Item("idMedicoSolicitante")
            vEstudio.nroOrden = drEstudios.Item("nroDeOrden")

            If drEstudios.Item("enlaceVideo") IsNot DBNull.Value Then
                vEstudio.VideoEstudio.enlaceMega = drEstudios.Item("enlaceVideo")
            End If

            vEstudio.idFacturacion = drEstudios.Item("idFacturacion")

            'ESTA ES LA FECHA DE tblPagoCobroEstudio
            If drEstudios.Item("fechaCobro") Is DBNull.Value Then
                'vEstudio.fechaCobro = Today
            Else : vEstudio.fechaCobro = CDate(drEstudios.Item("fechaCobro"))
            End If
            vEstudio.ImporteEstudio = drEstudios.Item("importeEstudio")
            vEstudio.importeMedicacion = drEstudios.Item("importeMedicacion")
            vEstudio.PagoContraFactura = drEstudios.Item("pagoContraFactura")
            vEstudio.DiferenciaPaciente = drEstudios.Item("diferenciaPaciente")
            If Not (drEstudios.Item("nroPagoMedicoAct") Is DBNull.Value) Then
                vEstudio.nroPagoMedicoActuante = drEstudios.Item("nroPagoMedicoAct")
            End If
            vEstudio.pension = drEstudios.Item("pension")
            vEstudio.importePagoMedicoActuante = drEstudios.Item("importePagoMedico")
            vEstudio.porcentajeIVAPagoMedicoActuante = drEstudios.Item("porcentajeIVAPagoMedicoActuante")
            If Not (drEstudios.Item("nroPagoMedicoSol") Is DBNull.Value) Then
                vEstudio.nroPagoMedicoSolicitante = drEstudios.Item("nroPagoMedicoSol")
            End If
            vEstudio.importePagoMedicoSolicitante = drEstudios.Item("importePagoMedicoSol")
            ' vEstudio.diferenciaPacienteMedicacion = drEstudios.Item("diferenciaPacienteMedicacion")
            vEstudio.practica.idEstudio = drEstudios.Item("idEstudio")
            vEstudio.practica.Estudio = drEstudios.Item("estudio")
            vEstudio.practica.codigoMedico = drEstudios.Item("codigoMedico")
            vEstudio.practica.abreviatura = drEstudios.Item("abreviatura")
            vEstudio.practica.codigoMedicoOSDE = drEstudios.Item("codigoMedicoOSDE")
            vEstudio.paciente.Id = drEstudios.Item("idPaciente")
            vEstudio.paciente.dni = drEstudios.Item("dni")
            vEstudio.paciente.nombres = drEstudios.Item("nombres")
            vEstudio.paciente.apellido = drEstudios.Item("apellido")

            If drEstudios.Item("e_mail") IsNot DBNull.Value Then
                vEstudio.paciente.e_mail = drEstudios.Item("e_mail")
            End If

            If drEstudios.Item("fechaNacimiento") IsNot DBNull.Value Then
                vEstudio.paciente.fechaDeNacimiento = drEstudios.Item("fechaNacimiento")
            End If

            vEstudio.paciente.sexo = drEstudios.Item("sexo")
            vEstudio.paciente.nroAfiliado = drEstudios.Item("nroAfiliado")
            vEstudio.paciente.direccion = drEstudios.Item("direPaciente")
            vEstudio.paciente.tel = drEstudios.Item("tel")
            '-----
            vEstudio.Anestesista.idMedico = drEstudios.Item("idAnestesista")
            vEstudio.Anestesista.nombre = drEstudios.Item("nombreMedicoAn")
            vEstudio.Anestesista.nombre = drEstudios.Item("apellidoMedicoAn")

            '-----

            vEstudio.medicoActuante.nombre = drEstudios.Item("nombreMedicoAct")
            vEstudio.medicoActuante.apellido = drEstudios.Item("apellidoMedicoAct")
            vEstudio.medicoActuante.nroMatricula = drEstudios.Item("nroMatricula")
            vEstudio.medicoSolicitante.nombre = drEstudios.Item("nombreMedicoSol")
            vEstudio.medicoSolicitante.apellido = drEstudios.Item("apellidoMedicoSol")
            vEstudio.obraSocial.ObraSocial = drEstudios.Item("obraSocial")
            vEstudio.obraSocial.sePresentaPorARA = drEstudios.Item("sePresentaPorARA")
            vEstudio.obraSocial.sePresentaPorAMR = drEstudios.Item("sePresentaPorAMR")
            vEstudio.obraSocial.valorAproximadoDePension = drEstudios.Item("valorAproximadoPension")
            vEstudio.esPagoContraFactura = drEstudios.Item("esPagoContraFactura")

            If (drEstudios.Item("Precio") Is DBNull.Value) Then
                vEstudio.ImportePorObraSocial = 0
            Else
                vEstudio.ImportePorObraSocial = drEstudios.Item("Precio")
            End If

            vEstudio.ArancelAnestesia = drEstudios.Item("arancelAnestesia")
            vEstudio.importeCobradoPension = drEstudios.Item("importeCobradoPension")
            vEstudio.importeCobradoArancelAnestesia = drEstudios.Item("importeCobradoArancelAnestesia")
            vEstudio.importeEstudioCobrado = drEstudios.Item("importeEstudioCobrado")
            vEstudio.ImporteCobradoMedicacion = drEstudios.Item("importeMedicacionCobrado")
            loadEstudios.Add(vEstudio)
        End While

        drEstudios.Close()
    End Function


End Class
