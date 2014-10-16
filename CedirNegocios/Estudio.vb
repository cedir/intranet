Imports Npgsql
Imports System.Collections.Generic
Imports CedirDataAccess
Public Class Estudio
    Private m_nroEstudio As Integer
    Public idFacturacion As Integer
    Private m_motivoEstudio As String
    Private m_informe As String
    Public nroOrden As String
    Private m_FechaCobro As Date
    Private m_FechaEstudio As Date
    Private m_ImporteEstudio As Single
    Private m_ImporteMedicacion As Decimal
    Public ImportePorObraSocial As Single
    Private m_PagoContraFactura As Single
    Private m_DiferenciaPaciente As Single
    Public pension As Single
    Private n_arancelAnestesia As Single
    Private n_importeCobradoPension As Decimal
    Private n_importeCobradoArancelAnestesia As Decimal
    Private n_importeEstudioCobrado As Decimal
    Public importePagoMedicoActuante As Single
    Public importePagoMedicoSolicitante As Single
    Public nroPagoMedicoActuante As Integer
    Public nroPagoMedicoSolicitante As Integer
    Public codigoImagen As String
    Public esPagoContraFactura As Integer
    Private m_paciente As New Paciente
    Private m_medicoActuante As New Medico
    Private m_medicoSolicitante As New Medico
    Private m_obraSocial As New ObraSocial
    Private m_practica As New practica
    Public Anestesista As New Medico
    Public arrMedicacion As New ArrayList
    Private m_importeCobradoMedicacion As Decimal
    Private m_porcentajeIVAPagoMedicoActuante As Decimal
    Private m_publicID As String

    'implementamos caja
    Private m_movCaja As List(Of MovimientoDeCaja)
    Private m_presentacion As Presentacion

    Private m_videoEstudio As VideoEstudio



    Dim com As String = """"

    Public Sub New()
        Me.ArancelAnestesia = 0
        Me.importeCobradoArancelAnestesia = 0
        Me.importeCobradoPension = 0
        MovimientosDeCaja = New List(Of MovimientoDeCaja)
        Me.VideoEstudio = New VideoEstudio
    End Sub

#Region "Propiedades"
    Public Property publicID() As String
        Get
            Return Me.m_publicID
        End Get
        Set(ByVal value As String)
            Me.m_publicID = value
        End Set
    End Property
    Public Property fechaCobro() As Date
        Get
            fechaCobro = m_FechaCobro
        End Get
        Set(ByVal Value As Date)
            m_FechaCobro = Value
        End Set
    End Property
    Public Property fechaEstudio() As Date
        Get
            fechaEstudio = m_FechaEstudio
        End Get
        Set(ByVal Value As Date)
            m_FechaEstudio = Value
        End Set
    End Property
    Public Property ImporteEstudio() As Single
        Get
            ImporteEstudio = m_ImporteEstudio
        End Get
        Set(ByVal Value As Single)
            m_ImporteEstudio = Value
        End Set
    End Property
    Public Property importeMedicacion() As Decimal
        Get
            Return m_ImporteMedicacion
        End Get
        Set(ByVal value As Decimal)
            m_ImporteMedicacion = value
        End Set
    End Property
    Public Property PagoContraFactura() As Decimal
        Get
            PagoContraFactura = m_PagoContraFactura
        End Get
        Set(ByVal Value As Decimal)
            m_PagoContraFactura = Value
        End Set
    End Property
    Public Property DiferenciaPaciente() As Single
        Get
            DiferenciaPaciente = m_DiferenciaPaciente
        End Get
        Set(ByVal Value As Single)
            m_DiferenciaPaciente = Value
        End Set
    End Property
    Public Property paciente() As Paciente
        Get
            paciente = m_paciente
        End Get
        Set(ByVal Value As Paciente)
            m_paciente = Value
        End Set
    End Property
    Public Property medicoActuante() As Medico
        Get
            medicoActuante = m_medicoActuante
        End Get
        Set(ByVal Value As Medico)
            m_medicoActuante = Value
        End Set
    End Property
    Public Property medicoSolicitante() As Medico
        Get
            medicoSolicitante = m_medicoSolicitante
        End Get
        Set(ByVal Value As Medico)
            m_medicoSolicitante = Value
        End Set
    End Property
    Public Property obraSocial() As ObraSocial
        Get
            obraSocial = m_obraSocial
        End Get
        Set(ByVal Value As ObraSocial)
            m_obraSocial = Value
        End Set
    End Property
    Public Property practica() As Practica
        Get
            practica = m_practica
        End Get
        Set(ByVal Value As Practica)
            m_practica = Value
        End Set
    End Property
    Public Property nroEstudio() As Integer
        Get
            nroEstudio = m_nroEstudio
        End Get
        Set(ByVal Value As Integer)
            m_nroEstudio = Value
        End Set
    End Property
    Public Property motivoEstudio() As String
        Get
            motivoEstudio = m_motivoEstudio
        End Get
        Set(ByVal Value As String)
            m_motivoEstudio = Value
        End Set
    End Property
    Public Property informe() As String
        Get
            informe = m_informe
        End Get
        Set(ByVal Value As String)
            m_informe = Value
        End Set
    End Property
    Public Property ArancelAnestesia() As Decimal
        Get
            Return n_arancelAnestesia
        End Get
        Set(ByVal value As Decimal)
            n_arancelAnestesia = value
        End Set
    End Property
    Public Property importeCobradoPension() As Decimal
        Get
            Return n_importeCobradoPension
        End Get
        Set(ByVal value As Decimal)
            n_importeCobradoPension = value
        End Set
    End Property
    Public Property importeEstudioCobrado() As Decimal
        Get
            If n_importeEstudioCobrado <= 0 Then
                'ahora se cambia. el importe cobrado esta en una nueva columna. Pero para mantener 
                'compatibilidad, debo checkear importe > 0
                Return Me.ImporteEstudio
            Else
                Return n_importeEstudioCobrado
            End If

        End Get
        Set(ByVal value As Decimal)
            n_importeEstudioCobrado = value
        End Set
    End Property
    Public Property importeCobradoArancelAnestesia() As Decimal
        Get
            Return n_importeCobradoArancelAnestesia
        End Get
        Set(ByVal value As Decimal)
            n_importeCobradoArancelAnestesia = value
        End Set
    End Property
    Public Property ImporteCobradoMedicacion() As Decimal
        Get
            Return m_importeCobradoMedicacion
        End Get
        Set(ByVal value As Decimal)
            m_importeCobradoMedicacion = value
        End Set
    End Property
    Public Property presentacion() As Presentacion
        Get
            Return m_presentacion
        End Get
        Set(ByVal value As Presentacion)
            m_presentacion = value
        End Set
    End Property

    'implementamos caja
    Public Property MovimientosDeCaja() As List(Of MovimientoDeCaja)
        Get
            Return m_movCaja
        End Get
        Set(ByVal value As List(Of MovimientoDeCaja))
            m_movCaja = value
        End Set
    End Property

    Public Property porcentajeIVAPagoMedicoActuante() As Decimal

        Get
            Return m_porcentajeIVAPagoMedicoActuante
        End Get
        Set(ByVal value As Decimal)
            m_porcentajeIVAPagoMedicoActuante = value
        End Set
    End Property

    Public Property VideoEstudio() As VideoEstudio
        Get
            Return Me.m_videoEstudio
        End Get
        Set(ByVal value As VideoEstudio)
            m_videoEstudio = value
        End Set
    End Property




#End Region

    Public Function AltaEstudio(Optional ByVal insertarPaciente As Boolean = False) As String

        Dim resp As String = "ok"

        If insertarPaciente Then
            resp = Me.paciente.AltaPaciente()
        End If

        If resp = "ok" Then
            Return crearEstudio()
        End If


        Return "Error"



    End Function
 
    Private Function obtenerNuevoPublicID() As String

        'generamos un nuevo publicID y vemos si no existe
        Dim consultar As New Consultas

        Dim help As New Helper
        Dim bandera As Boolean = False
        Dim posibleID As String = help.generarPublicID()

        Do While (consultar.ExisteEstudioNuevoPublicID(posibleID))


            posibleID = help.generarPublicID()


        Loop

        Return posibleID







    End Function

    Private Function crearEstudio() As String
        Dim resp As String = ""

        Dim upd As New CedirDataAccess.Nuevo
        Try

            Dim publicId As String = Me.obtenerNuevoPublicID()

            'Al modificar esto, revisar código btnAnunciar en Turnos
            resp = upd.nuevoEstudio(publicId, Me.paciente.Id, Me.practica.idEstudio, Me.motivoEstudio, Me.informe, Me.medicoActuante.idMedico, Me.medicoSolicitante.idMedico, Me.obraSocial.idObraSocial, Me.fechaEstudio, Me.nroOrden, Me.Anestesista.idMedico, Me.VideoEstudio.enlaceMega.Trim())



            'Log the action
            Dim sSecurity As Security = Security.GetInstance()
            Dim cUsuario As Usuario = sSecurity.getLoggedUser()
            Dim vLog As New AuditLog
            vLog.usuario = cUsuario
            vLog.objectId = Me.nroEstudio
            vLog.objectTypeId = 1
            vLog.userActionId = 1
            vLog.create()
        Catch ex As IO.IOException
            Return "error conexion base de datos" & ex.Message
        Catch ex As Npgsql.NpgsqlException
            Return "error en la consulta SQL" & ex.ErrorSql
        Catch ex As Exception
            Return ex.Message
        




           


        End Try


        Return resp
    End Function



    Public Function actualizaEstudio() As String

        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        Dim fechaOptimizada As String
        Dim i As Integer
        Dim r As New System.Text.RegularExpressions.Regex("(/)")
        Dim partesFecha As String() = r.Split(Me.fechaEstudio)
        fechaOptimizada = partesFecha(4) & "-" & partesFecha(2) & "-" & partesFecha(0)
        resp = upd.update(com & "cedirData" & com & "." & com & "tblEstudios" & com, com & "idEstudio" & com & " = " & Me.practica.idEstudio & " , " & com & "motivoEstudio" & com & " = " & "'" & Me.motivoEstudio & "'" & " , " & com & "informe" & com & " = " & "'" & Me.informe & "'" & " , " & com & "fechaEstudio" & com & " = " & "'" & fechaOptimizada & "'" & " , " & com & "enlaceVideo" & com & " = " & "'" & Me.VideoEstudio.enlaceMega.Trim() & "'", " where" & com & "nroEstudio" & com & " = " & Me.nroEstudio)
        resp = upd.update(com & "cedirData" & com & "." & com & "tblDetalleEstudio" & com, com & "idMedicoActuante" & com & " = " & Me.medicoActuante.idMedico & " , " & com & "idMedicoSolicitante" & com & " = " & Me.medicoSolicitante.idMedico & " , " & com & "idObraSocial" & com & " = " & Me.obraSocial.idObraSocial & " , " & com & "nroDeOrden" & com & " = " & "'" & Me.nroOrden & "', " & com & "idAnestesista" & com & " = " & Me.Anestesista.idMedico, " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)

        Return resp

    End Function
    Public Function actualizarImportes() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        resp = upd.update(com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com, com & "diferenciaPaciente" & com & " = " & "'" & Me.DiferenciaPaciente & "'" & ", " & com & "pension" & com & " = '" & Me.pension & "'", " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)
        Return resp
    End Function
    Public Function setPagoContraFactura() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String


        resp = upd.update(com & "cedirData" & com & "." & com & "tblDetalleEstudio" & com, com & "esPagoContraFactura" & com & " = " & "'" & Me.esPagoContraFactura & "'", " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)
        'ahora seteo el importe del pago contra factura  y  la fecha de cobro
        If Me.fechaCobro = Nothing Then
            resp = upd.update(com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com, com & "pagoContraFactura" & com & " = " & Me.PagoContraFactura & ", " & com & "fechaCobro" & com & " = null ", " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)
        Else
            'seteamos la fecha del pago a hoy. El importe cobrado coincide con 
            'el importe de PCF
            resp = upd.update(com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com, com & "pagoContraFactura" & com & " = " & Me.PagoContraFactura & ", " & com & "fechaCobro" & com & " = '" & Me.fechaCobro.ToString.Remove(10) & "'" & ", " & com & "importeEstudioCobrado" & com & " =  " & Me.PagoContraFactura, " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)
        End If

        Return resp
    End Function
    Public Sub cargarMedicacion()
        arrMedicacion.Clear()
        Dim da As New Consultas

        Dim drMed As NpgsqlDataReader
        drMed = da.getMedicacionEstudio(nroEstudio)
        Dim med As Medicacion
        While drMed.Read()
            med = New Medicacion
            med.idMedicacion = drMed.Item("idMedicacion")
            med.importe = drMed.Item("importe")
            med.nroEstudio = drMed.Item("nroEstudio")
            med.medicamento.idMedicamento = drMed.Item("idMedicamento")
            med.medicamento.descripcion = drMed.Item("descripcionMedicamento")
            med.medicamento.importe = drMed.Item("importeMedicamento")
            med.medicamento.tipo = drMed.Item("tipo")
            med.medicamento.codigoMedicoOSDE = drMed.Item("codigoMedicoOSDE")
            med.estado = "estaEnEstudio"
            arrMedicacion.Add(med)

        End While
        drMed.Close()

    End Sub
    Public Function getTotalMedicacion() As Single
        'recorre el arreglo arrMedicacion, suma el total y lo devuelve
        Dim total As Single = 0
        Dim cMedicacion As Medicacion
        For i As Integer = 0 To arrMedicacion.Count - 1
            cMedicacion = arrMedicacion(i)
            total = total + cMedicacion.importe
        Next
        'total = Math.Round(total, 2)
        Return total
    End Function
    Public Function guardarMedicacion() As String
        Dim med As Medicacion
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String = "ok"
        Dim i As Integer
        For i = 0 To Me.arrMedicacion.Count - 1
            med = arrMedicacion(i)
            resp = med.guardar(upd)
            med.estado = "estaEnEstudio"
        Next

        Return resp

    End Function
    Public Function guardarArancelAnestesia() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String = "ok"
        resp = upd.update(com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com, com & "arancelAnestesia" & com & " = " & "'" & Me.ArancelAnestesia & "'", " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)
        Return resp
    End Function
    Public Function borrarMedicacion() As String
        'Elina toda la medicacion de un estudio
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        resp = upd.delete("tblMedicacion", com & "nroEstudio" & com & " = " & Me.nroEstudio)
        'Actualizar importeMedicacion del estudio
        If resp = "ok" Then
            Me.arrMedicacion.Clear()
            'upd.update(com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com, com & "importeMedicacion" & com & " = 0", " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)
        End If
        Return resp
    End Function
    Public Function addLineaMedicacion(ByVal cMedicacion As Medicacion) As Boolean
        'chequiar que no este el medicamento en el estudio
        Dim cLinea As Medicacion
        For i As Integer = 0 To arrMedicacion.Count - 1
            cLinea = arrMedicacion(i)
            If cMedicacion.medicamento.idMedicamento = cLinea.medicamento.idMedicamento Then
                Return False
            End If
        Next
        'agregar
        cMedicacion.estado = "noEstaEnEstudio"
        cMedicacion.nroEstudio = Me.nroEstudio
        Me.arrMedicacion.Add(cMedicacion)
        Return True
    End Function
    Public Function quitarLineaMedicacion(ByVal nroLinea As Integer) As String
        Dim cLineaMedicamento As Medicacion = arrMedicacion(nroLinea)
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String = "ok"

        If cLineaMedicamento.estado = "estaEnEstudio" Then
            resp = upd.delete("tblMedicacion", com & "nroEstudio" & com & " = " & Me.nroEstudio & " and " & com & "idMedicamento" & com & " = " & cLineaMedicamento.medicamento.idMedicamento)
            If resp = "ok" Then
                'guardar total?? NO
                arrMedicacion.RemoveAt(nroLinea)
                'Dim importeMed As Single = Me.getTotalMedicacion
                'resp = upd.update(com & "cedirData" & com & "." & com & "tblPagoCobroEstudio" & com, com & "importeMedicacion" & com & " = " & "'" & importeMed & "'", " where " & com & "nroEstudio" & com & " = " & Me.nroEstudio)
            End If

        ElseIf cLineaMedicamento.estado = "noEstaEnEstudio" Then
            arrMedicacion.RemoveAt(nroLinea)
        End If

        Return resp
    End Function
    Public Function getAnestesista() As Medico
        If Me.Anestesista.apellido = "" Then
            'obtener datos anestesista

        End If

        Return Me.Anestesista
    End Function
    Public Function getCondicionMedico(ByVal idMedico As Integer) As String
        If Me.medicoActuante.idMedico = Me.medicoSolicitante.idMedico Then
            Return "actuante-solicitante"
        Else
            If Me.medicoActuante.idMedico = idMedico Then
                Return "actuante"
            ElseIf Me.medicoSolicitante.idMedico = idMedico Then
                Return "solicitante"
            Else
                Return "error"
            End If
        End If
    End Function
    Public Function esEcografia() As Boolean
        'id de las practicas ecograficas
        Dim arr() As Integer = {55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 82, 83, 84, 89, 90, 99, 100, 101, 103, 108, 109, 114, 115, 117, 123, 126, 127}
        If Array.BinarySearch(arr, Me.practica.idEstudio) < 0 Then
            Return False
        End If
        Return True
    End Function
    Public Function esLaboratorio() As Boolean
        'Siempre se carga como practica "Analisis Bioquimicos"
        If Me.practica.idEstudio = 91 Then
            Return True
        End If
        Return False
    End Function
    Public Function esLigaduraDeHemorroides() As Boolean
        If Me.practica.idEstudio = 3 Then
            Return True
        End If
        Return False
    End Function

    Public Function esPracticaEspecial() As Boolean
        Dim arr As Integer() = {33, 38, 37, 88, 102, 110, 111, 112, 113, 114, 133, 119}
        If Array.BinarySearch(arr, Me.practica.idEstudio) < 0 Then
            Return False
        End If
        Return True
    End Function


    Private Function validarMedicos() As Boolean
        'todos los estudios deben tener medico s    
        'salvo en caso de Actuante = brunetti
        'Practica = Ecografica o laboratorio, donde pueden ser distintos .
        '------------------------------------------------------------------------
        '10/11/2011 - se cambia regla de negocio
        '

        If (esEcografia() Or esLaboratorio() Or Me.medicoActuante.idMedico = 2) Then
            Return True
        Else
            If Me.medicoActuante.idMedico = Me.medicoSolicitante.idMedico Then
                Return True
            End If
            Return False
        End If
    End Function

    ''' <summary>
    ''' Retorna medicacion que  incluye material especifico
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getMaterialEspecifico() As ArrayList
        Dim arr As New ArrayList
        Dim i As Integer = 0
        For i = 0 To Me.arrMedicacion.Count - 1
            Dim m As Medicacion
            m = arrMedicacion(i)
            If m.esMaterialEspecifico Then
                arr.Add(m)
            End If
        Next
        Return arr
    End Function
    ''' <summary>
    ''' Retorna medicacion que no incluye material especifico
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function getMedicacionSinMaterialEspecifico() As ArrayList
        Dim arr As New ArrayList
        Dim i As Integer = 0
        For i = 0 To Me.arrMedicacion.Count - 1
            Dim m As Medicacion
            m = arrMedicacion(i)
            If Not m.esMaterialEspecifico Then
                arr.Add(m)
            End If
        Next
        Return arr
    End Function
End Class
