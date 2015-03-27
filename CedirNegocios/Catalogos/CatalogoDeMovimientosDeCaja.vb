Imports System
Imports System.Collections.Generic
Imports CedirDataAccess
Imports Npgsql



Public Class CatalogoDeMovimientosDeCaja


#Region "Variables de instancia"
    Dim com As String = """"
#End Region

#Region "PROPIEDADES"
    Private m_lista As List(Of Estudio)
#End Region

#Region "Constructor"
    Public Sub New()
        Me.m_lista = New List(Of Estudio)
        Me.m_lista.Clear()
    End Sub
#End Region

#Region "Metodos de instancia"

    Public Function getEstudiosAndMovimientos(ByVal fecha As Date) As List(Of Estudio)

        Dim condicion As String = " where " & com & "fechaEstudio" & com & "='" & fecha.Date & "' "


        Dim da As New Consultas
        getEstudiosAndMovimientos = New List(Of Estudio)
        Dim drEstudios As NpgsqlDataReader
        drEstudios = da.TraerEstudiosYMovimientosDeCaja(condicion)
        Dim vEstudio As Estudio = New Estudio
        While drEstudios.Read()

            If drEstudios.Item("idMov") Is DBNull.Value Or (drEstudios.Item("nroEstudioMovimiento") IsNot DBNull.Value AndAlso drEstudios.Item("nroEstudioMovimiento") <> vEstudio.nroEstudio) Then

                If vEstudio.nroEstudio <> 0 Then
                    m_lista.Add(vEstudio)
                End If

                vEstudio = New Estudio

                vEstudio.nroEstudio = drEstudios.Item("nroEstudio")
                vEstudio.fechaEstudio = drEstudios.Item("fechaEstudio")
                vEstudio.motivoEstudio = drEstudios.Item("motivoEstudio")
                vEstudio.informe = drEstudios.Item("informe")
                vEstudio.medicoActuante.idMedico = drEstudios.Item("idMedicoActuante")
                vEstudio.medicoActuante.nombre = drEstudios.Item("nombreMedicoAct")
                vEstudio.medicoActuante.apellido = drEstudios.Item("apellidoMedicoAct")
                vEstudio.medicoActuante.nroMatricula = drEstudios.Item("nroMatricula")

                vEstudio.medicoSolicitante.idMedico = drEstudios.Item("idMedicoSolicitante")
                vEstudio.nroOrden = drEstudios.Item("nroDeOrden")
                vEstudio.paciente.Id = drEstudios.Item("idPaciente")
                vEstudio.paciente.dni = drEstudios.Item("dni")
                vEstudio.paciente.nombres = drEstudios.Item("nombres")
                vEstudio.paciente.apellido = drEstudios.Item("apellido")
                If drEstudios.Item("fechaNacimiento") IsNot DBNull.Value Then
                    vEstudio.paciente.fechaDeNacimiento = Convert.ToDateTime(drEstudios.Item("fechaNacimiento"))
                End If
                vEstudio.paciente.sexo = drEstudios.Item("sexo")
                vEstudio.paciente.nroAfiliado = drEstudios.Item("nroAfiliado")
                vEstudio.obraSocial.ObraSocial = drEstudios.Item("obraSocial")
                vEstudio.obraSocial.idObraSocial = drEstudios.Item("idObraSocial")
                vEstudio.obraSocial.sePresentaPorARA = drEstudios.Item("sePresentaPorARA")
                vEstudio.obraSocial.sePresentaPorAMR = drEstudios.Item("sePresentaPorAMR")
                vEstudio.practica.Estudio = drEstudios.Item("estudio")
            End If

            'ahora seteamos los movimientos
            If drEstudios.Item("idMov") IsNot DBNull.Value Then
                Dim mov As New MovimientoDeCaja
                mov.Id = drEstudios.Item("idMov")
                mov.Concepto = drEstudios.Item("concepto")
                mov.Monto = drEstudios.Item("monto")
                mov.MontoAcumulado = drEstudios.Item("montoAcumulado")
                mov.Fecha = drEstudios.Item("fecha")
                mov.Estado = drEstudios.Item("estado")
                Dim tipoMov As New TipoDeMovimientoDeCaja
                tipoMov.id = drEstudios.Item("idTipoDeMovimiento")
                tipoMov.descripcion = drEstudios.Item("descripcion")
                mov.TipoDeMovimiento = tipoMov

                vEstudio.MovimientosDeCaja.Add(mov)
                mov.Estudio = vEstudio
            End If
        End While
        m_lista.Add(vEstudio)
        drEstudios.Close()
        Return m_lista
    End Function

    Public Function getAll(ByVal filtro As String) As List(Of MovimientoDeCaja)
        Return traerMovimientos(filtro)
    End Function


    Public Function traerMovimientos(ByVal filtro As String) As List(Of MovimientoDeCaja)
        Dim lista As New List(Of MovimientoDeCaja)

        Dim vEstudio As Estudio
        Dim dr As NpgsqlDataReader
        Dim cDatos As New Consultas

        dr = cDatos.getMovimientosCajaAll(filtro)
        Do While (dr.Read())
            Dim oCajaMov As New MovimientoDeCaja
            oCajaMov.Id = Convert.ToInt32(dr("id"))
            oCajaMov.Monto = Convert.ToSingle(dr("monto"))
            oCajaMov.MontoAcumulado = Convert.ToSingle(dr("montoAcumulado"))
            oCajaMov.Concepto = Convert.ToString(dr("concepto"))
            oCajaMov.Fecha = Convert.ToString(dr("fecha"))
            oCajaMov.Hora = CStr(dr("hora"))
            oCajaMov.Estado = Convert.ToString(dr("estado"))

            Dim tipoMov As New TipoDeMovimientoDeCaja
            tipoMov.id = Convert.ToInt32(dr("idTipoDeMovimiento"))
            tipoMov.descripcion = Convert.ToString(dr("descripcion"))
            oCajaMov.TipoDeMovimiento = tipoMov

            If dr("fechaEstudio") Is DBNull.Value Then
                oCajaMov.Estudio = Nothing
            Else
                vEstudio = New Estudio
                vEstudio.nroEstudio = dr.Item("nroEstudio")
                vEstudio.fechaEstudio = dr.Item("fechaEstudio")
                vEstudio.motivoEstudio = dr.Item("motivoEstudio")
                vEstudio.informe = dr.Item("informe")
                ' vEstudio.medicoActuante.idMedico = dr.Item("idMedicoActuante")
                ' vEstudio.medicoSolicitante.idMedico = dr.Item("idMedicoSolicitante")
                'vEstudio.nroOrden = dr.Item("nroDeOrden")
                vEstudio.paciente.Id = dr.Item("idPaciente")
                vEstudio.paciente.dni = dr.Item("dni")
                vEstudio.paciente.nombres = dr.Item("nombres")
                vEstudio.paciente.apellido = dr.Item("apellido")
                If dr.Item("fechaNacimiento") IsNot DBNull.Value Then
                    vEstudio.paciente.fechaDeNacimiento = Convert.ToDateTime(dr.Item("fechaNacimiento"))
                End If
                vEstudio.paciente.sexo = dr.Item("sexo")
                vEstudio.paciente.nroAfiliado = dr.Item("nroAfiliado")
                vEstudio.obraSocial.ObraSocial = dr.Item("obraSocial")
                vEstudio.obraSocial.idObraSocial = dr.Item("idObraSocial")
                vEstudio.obraSocial.sePresentaPorARA = dr.Item("sePresentaPorARA")
                vEstudio.obraSocial.sePresentaPorAMR = dr.Item("sePresentaPorAMR")
                vEstudio.practica.Estudio = dr.Item("estudio")
                vEstudio.practica.abreviatura = dr.Item("abreviatura")

                oCajaMov.Estudio = vEstudio
            End If

            'falta probar esto, y borrar este comentario
            If dr("nroEstudio") IsNot DBNull.Value And dr("fechaEstudio") Is DBNull.Value Then
                vEstudio = New Estudio
                vEstudio.practica.Estudio = "Este estudio/cunsulta fue eliminado/a"
                oCajaMov.Estudio = vEstudio
            End If

            If dr("idMedicoAct") IsNot DBNull.Value Then
                oCajaMov.Medico = New Medico
                oCajaMov.Medico.idMedico = dr.Item("idMedicoAct")
                oCajaMov.Medico.nombre = dr.Item("nombreMedicoAct")
                oCajaMov.Medico.apellido = dr.Item("apellidoMedicoAct")
                oCajaMov.Medico.nroMatricula = dr.Item("nroMatricula")
            End If

            'asigno el usuario que realizo el movimiento
            If dr("idUsuario") Is DBNull.Value Then
                oCajaMov.Usuario = Nothing
            Else
                oCajaMov.Usuario.id = Convert.ToInt32(dr("idUsuario"))
                oCajaMov.Usuario.nombreUsuario = Convert.ToString(dr("nombreUsuario"))
                oCajaMov.Usuario.password = Convert.ToString(dr("password"))
            End If

            lista.Add(oCajaMov)
            oCajaMov = Nothing
        Loop

        Return lista
    End Function
    


    Public Sub CrearMovimiento(ByVal nuevoMovimiento As MovimientoDeCaja)
        'recuperamos el último movimiento. Traemos todos sus campos, ya que vamos a necesitar
        'el monto acumulado hasta el momento
        Dim ultimoMovimiento As New MovimientoDeCaja
        ultimoMovimiento = getUltimoMovimiento()

        'Calculamos el monto acumulado
        nuevoMovimiento.MontoAcumulado = ultimoMovimiento.MontoAcumulado + nuevoMovimiento.Monto
        nuevoMovimiento.crear()


        'registramos quien realizó el movimiento de caja
        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser
        Dim vLog As New AuditLog
        vLog.usuario = cUsuario
        vLog.objectId = nuevoMovimiento.Id  'id autoincremental de la db
        vLog.objectTypeId = 2 'Movimiento de Caja
        vLog.userActionId = 1 'create
        vLog.create()

        ultimoMovimiento = Nothing
    End Sub
    

    Private Function getUltimoMovimiento() As MovimientoDeCaja
        Dim cConsultas As New Consultas
        Dim dr As NpgsqlDataReader = cConsultas.selectMaxMovmiento()

        Dim mov As New MovimientoDeCaja
        Do While (dr.Read())
            mov.Id = dr.Item("id")
            mov.Concepto = dr.Item("concepto")
            mov.Monto = dr.Item("monto")
            mov.MontoAcumulado = dr.Item("montoAcumulado")
            mov.Fecha = dr.Item("fecha")
            mov.Hora = dr.Item("hora")
            mov.Estado = dr.Item("estado")
            'seteamos el tipo de mov
            Dim tipoMov As New TipoDeMovimientoDeCaja
            tipoMov.id = dr.Item("idTipoDeMovimiento")
            mov.TipoDeMovimiento = tipoMov
        Loop
        Return mov

    End Function


    Function getAll(ByVal p1 As Medico, ByVal p2 As TipoDeMovimientoDeCaja, ByVal p3 As String, ByVal p4 As String, ByVal p5 As String, ByVal p6 As Date, ByVal p7 As Date) As List(Of MovimientoDeCaja)
        Dim lista As New List(Of MovimientoDeCaja)

        'Todo el siguiente codigo esta echo para establecer un filtro, y luego pasarlo al unico metodo que trae movimientos

        Dim com As String = """"
        Dim condicion0 As String = ""
        Dim condicion1 As String = ""
        Dim condicion2 As String = ""
        Dim condicion3 As String = ""
        Dim condicion4 As String = ""
        Dim condicion5 As String = ""

        Dim concatenacion As String = ""
        'medico
        If p1 IsNot Nothing Then
            condicion0 = " and  cm." & com & "idMedico" & com & " = " & p1.idMedico
        Else
            condicion0 = " and  true "
        End If
        'tipo de movimiento
        If p2 IsNot Nothing Then
            condicion1 = " and cm." & com & "idTipoDeMovimiento" & com & " = " & p2.id
        Else
            condicion1 = " and true "
        End If

        'traemos movimientos con estudios
        If p3 = "Unchecked" Then
            condicion2 = " and  cm." & com & "nroEstudio" & com & " is null "
        ElseIf p3 = "Checked" Then
            condicion2 = " and  cm." & com & "nroEstudio" & com & " is  not null "
        Else
            condicion2 = " and true "
        End If

        'traemos movimientos pagados
        If p4 = "Checked" Then
            condicion3 = " and  cm." & com & "estado" & com & " is true "
        ElseIf p4 = "Unchecked" Then
            condicion3 = " and  cm." & com & "estado" & com & " is false "
        Else
            condicion3 = " and  true "
        End If

        'concepto
        If p5 <> "" Then
            condicion4 = " and  upper(cm." & com & "concepto" & com & ") like '%" & p5.ToUpper() & "%'"
        Else
            condicion4 = " and  true "
        End If

        condicion5 = " and  cm." & com & "fecha" & com & " >= '" & p6.Date & "' and cm." & com & "fecha" & com & " <= '" & p7.Date & "'"

        concatenacion = " where true  " & condicion0 & condicion1 & condicion2 & condicion3 & condicion4 & condicion5

        Return traerMovimientos(concatenacion)

    End Function


#End Region

    Sub cambiarEstadoMovimientos(ByVal movimientosAActualizarEstado As List(Of MovimientoDeCaja), ByVal estado As Boolean)
        'realizamos update
        Dim n As New Nuevo
        For Each m As MovimientoDeCaja In movimientosAActualizarEstado
            m.Estado = estado
            m.modificar()
        Next
        n = Nothing
    End Sub


    Public Function contieneAnestesia(ByVal estudio As Estudio) As Boolean
        Dim lista As New List(Of MovimientoDeCaja)
        Try
            lista = Me.getMovimientosPorTipoHonorarioAnestesista(estudio)
            If lista.Count > 0 Then
                Return True
            End If
            Return False
        Catch ex As Exception
            Return False
        Finally
            lista = Nothing
        End Try

    End Function

    ''' <summary>
    ''' ELIMINAR Funcion para traer los movimientos de la fecha del estudio del tipo "Honorario Anestesista"
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetMovimientosDeEstudiosConAnestesiaParticular(ByVal est As Estudio) As List(Of MovimientoDeCaja)
        Dim lista As New List(Of MovimientoDeCaja)
        'Todo el siguiente codigo esta echo para establecer un filtro, y luego pasarlo al unico metodo que trae movimientos

        Dim com As String = """"
        Dim condicion As String = ""

        '(el idTipoMov=3 concuerda con HonorarioAnestesista)
        condicion = " where  est." & com & "nroEstudio" & com & " = " & est.nroEstudio & " and ctm." & com & "id" & com & " = 3"
        Return traerMovimientos(condicion)
    End Function
   
    Private Function getMovimientosPorTipoHonorarioAnestesista(ByVal est As Estudio) As List(Of MovimientoDeCaja)
        Dim h As New Helper
        Dim fecha As String
        fecha = h.convertDate(est.fechaEstudio)
        h = Nothing


        Const TIPO_MOVIMIENTO_HONORARIO_ANESTESISTA As Integer = 3
        Const TIPO_MOVIMIENTO_COSEGURO As Integer = 10
        'Todo el siguiente codigo esta echo para establecer un filtro, y luego pasarlo al unico metodo que trae movimientos
        Dim com As String = """"
        Dim condicion As String = ""
        condicion = " where  cm." & com & "nroEstudio" & com & " = " & est.nroEstudio & " and ctm." & _
        com & "id" & com & " IN(" & TIPO_MOVIMIENTO_HONORARIO_ANESTESISTA & ", " & TIPO_MOVIMIENTO_COSEGURO & ") " & _
        " and cm." & com & "monto" & com & " > 40 "
        Return traerMovimientos(condicion)
    End Function
    Public Function GetLastMontoAcumulado() As Decimal
        Dim ultimoMovimiento As New MovimientoDeCaja
        ultimoMovimiento = getUltimoMovimiento()
        Return ultimoMovimiento.MontoAcumulado
    End Function

End Class
