Public Class PagoMedico
    Private m_observacion As String
    Private m_fecha As Date
    Public medico As New Medico
    Private m_nroPago As Integer

    Private arrLineasDePago As ArrayList

    Public Sub New()

    End Sub
    Public Sub New(ByVal cMedico As medico)
        medico = cMedico
        arrLineasDePago = New ArrayList
        'cargar arreglo con estudios disponibles del pago
        Dim catalogoEstudios As New CatalogoDeEstudios
        Dim arrEstudios As ArrayList = catalogoEstudios.traerEstudiosPendientesPagoMedico(Me.medico.idMedico)
        Dim cLinea As LineaPagoMedico
        Dim cEstudio As Estudio
        For i As Integer = 0 To arrEstudios.Count - 1
            cLinea = New LineaPagoMedico
            cLinea.idMedico = cMedico.idMedico
            cEstudio = arrEstudios(i)
            cLinea.estudio = cEstudio

            arrLineasDePago.Add(cLinea)
        Next

    End Sub
    Public Property observacion() As String
        Get
            observacion = m_observacion
        End Get
        Set(ByVal Value As String)
            m_observacion = Value
        End Set
    End Property

    Public Property fecha() As Date
        Get
            fecha = m_fecha
        End Get
        Set(ByVal Value As Date)
            m_fecha = Value
        End Set
    End Property


    Public Property nroPago() As Integer
        Get
            nroPago = m_nroPago
        End Get
        Set(ByVal Value As Integer)
            m_nroPago = Value
        End Set
    End Property

    Public Function getLineas() As ArrayList
        If arrLineasDePago Is Nothing Then
            arrLineasDePago = New ArrayList
            Dim cCatalogo As New CatalogoDeEstudios
            Dim arrEstudios As ArrayList = cCatalogo.traerDetallePagoMedico(Me.nroPago)
            Dim cLinea As LineaPagoMedico
            Dim cEstudio As Estudio
            For i As Integer = 0 To arrEstudios.Count - 1
                cLinea = New LineaPagoMedico
                cEstudio = arrEstudios(i)
                cLinea.estudio = cEstudio
                cLinea.porcentajeIVAPagoMedicoActuante = cEstudio.porcentajeIVAPagoMedicoActuante
                cLinea.importe = cEstudio.importePagoMedicoActuante
                arrLineasDePago.Add(cLinea)
            Next
        End If

        Return arrLineasDePago
    End Function

    Public Function addLinea(ByVal cLinea As LineaPagoMedico) As Boolean
        If arrLineasDePago Is Nothing Then
            arrLineasDePago = New ArrayList
        End If
        cLinea.idMedico = Me.medico.idMedico
        arrLineasDePago.Add(cLinea)
        Return True
    End Function

    Public Function quitarLinea(ByVal nroLinea As Integer) As Boolean
        Dim cLinea As LineaPagoMedico = arrLineasDePago(nroLinea)
        arrLineasDePago.RemoveAt(nroLinea)
        Return True
    End Function

    Public Function crearPago() As String
        'cear un nuevo pago
        Dim com As String = """"
        Dim fecha As String = Me.fecha.Year & "-" & Me.fecha.Month & "-" & Me.fecha.Day
        Dim upd As New CedirDataAccess.Nuevo

        Dim help As New Helper
        Dim resp As String
        Dim nroPago As Integer = help.obtenerUltimoNro("tblPagosMedicos", "nroPago")
        nroPago += 1
        resp = upd.insert(com & "cedirData" & com & "." & com & "tblPagosMedicos" & com, com & "nroPago" & com & ", " & com & "fechaPago" & com & ", " & com & "idMedico" & com & ", " & com & "observacionPago" & com, nroPago & ", '" & fecha & "', " & Me.medico.idMedico & ", '" & Me.observacion & "'")
        If resp = "ok" Then
            Dim cLinea As LineaPagoMedico
            For i As Integer = 0 To Me.arrLineasDePago.Count - 1
                cLinea = arrLineasDePago(i)
                resp = cLinea.guardar(nroPago)
            Next

        End If

        Return resp
    End Function
End Class
