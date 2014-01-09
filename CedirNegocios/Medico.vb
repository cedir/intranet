Imports Npgsql
Public Class Medico
    Dim com As String = """"
    Private m_idMedico As Integer
    Private m_nombre As String
    Private m_apellido As String
    Private m_mail As String
    Public nroMatricula As String
    Public direccion As String
    Public localidad As String
    Public telefono As String
    Private m_responsabilidadFiscal As String
    Private claveFisc As String




    Public Sub New()

    End Sub

    Public Property claveFiscal() As String
        Get
            Return claveFisc
        End Get
        Set(ByVal value As String)
            claveFisc = value
        End Set
    End Property
    Public Property responsabilidadFiscal() As String
        Get
            Return m_responsabilidadFiscal
        End Get
        Set(ByVal value As String)
            m_responsabilidadFiscal = value
        End Set
    End Property

    Public Property idMedico() As Integer
        Get
            idMedico = m_idMedico
        End Get
        Set(ByVal Value As Integer)
            m_idMedico = Value
        End Set
    End Property

    Public Property nombre() As String
        Get
            nombre = m_nombre
        End Get
        Set(ByVal Value As String)
            m_nombre = Value
        End Set
    End Property


    Public Property apellido() As String
        Get
            apellido = m_apellido
        End Get
        Set(ByVal Value As String)
            m_apellido = Value
        End Set
    End Property
    Public Property mail() As String
        Get
            mail = m_mail
        End Get
        Set(ByVal Value As String)
            m_mail = Value
        End Set
    End Property

    Public ReadOnly Property nombreCompleto() As String
        Get
            If Me.nombre <> "" Then
                nombreCompleto = Me.apellido & ", " & Me.nombre
            Else
                nombreCompleto = Me.apellido
            End If

        End Get

    End Property

    'Esto por que??
    Public ReadOnly Property Self() As Medico
        Get
            Return Me
        End Get
    End Property
    Public Function esResponsableInscripto() As Boolean
        Const MONOTRIBUTO As String = "MONOTRIBUTO"
        If Me.responsabilidadFiscal <> MONOTRIBUTO Then
            Return True
        Else : Return False
        End If

    End Function


    Public Function crear() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        resp = upd.insert(com & "cedirData" & com & "." & com & "tblMedicosAct" & com, com & "nombreMedicoAct" & com & ", " & com & "apellidoMedicoAct" & com & ", " & com & "nroMatricula" & com & ", " & com & "direccionMedico" & com & ", " & com & "localidadMedico" & com & ", " & com & "telMedico" & com & ", " & com & "mail" & com & ", " & com & "responsabilidadFiscal" & com & ", " & com & "claveFiscal" & com, "'" & Me.nombre & "', " & "'" & Me.apellido & "', " & "'" & Me.nroMatricula & "', " & "'" & Me.direccion & "', " & "'" & Me.localidad & "', " & "'" & Me.telefono & "', " & "'" & Me.mail & "', '" & Me.responsabilidadFiscal & "', '" & Me.claveFiscal & "' ")
        resp = upd.insert(com & "cedirData" & com & "." & com & "tblMedicosSol" & com, com & "nombreMedicoSol" & com & ", " & com & "apellidoMedicoSol" & com & ", " & com & "nroMatricula" & com & ", " & com & "direccionMedico" & com & ", " & com & "localidadMedico" & com & ", " & com & "telMedico" & com & ", " & com & "mail" & com & ", " & com & "responsabilidadFiscal" & com & ", " & com & "claveFiscal" & com, "'" & Me.nombre & "', " & "'" & Me.apellido & "', " & "'" & Me.nroMatricula & "', " & "'" & Me.direccion & "', " & "'" & Me.localidad & "', " & "'" & Me.telefono & "', " & "'" & Me.mail & "', '" & Me.responsabilidadFiscal & "', '" & Me.claveFiscal & "' ")

        Return resp

    End Function
    Public Function actualizar() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        Dim uptString As String = com & "nombreMedicoAct" & com & " = " & "'" & Me.nombre & "', " & com & "apellidoMedicoAct" & com & " = " & "'" & Me.apellido & "', " & com & "nroMatricula" & com & " = " & "'" & Me.nroMatricula & "'," & com & "direccionMedico" & com & " = " & "'" & Me.direccion & "', " & com & "localidadMedico" & com & " = " & "'" & Me.localidad & "', " & com & "telMedico" & com & " = " & "'" & Me.telefono & "', " & com & "mail" & com & " = " & "'" & Me.mail & "', " & com & "responsabilidadFiscal" & com & " = '" & Me.responsabilidadFiscal & "' , " & com & "claveFiscal" & com & " = '" & Me.claveFiscal & "' "
        Dim uptString1 As String = com & "nombreMedicoSol" & com & " = " & "'" & Me.nombre & "', " & com & "apellidoMedicoSol" & com & " = " & "'" & Me.apellido & "', " & com & "nroMatricula" & com & " = " & "'" & Me.nroMatricula & "'," & com & "direccionMedico" & com & " = " & "'" & Me.direccion & "', " & com & "localidadMedico" & com & " = " & "'" & Me.localidad & "', " & com & "telMedico" & com & " = " & "'" & Me.telefono & "', " & com & "mail" & com & " = " & "'" & Me.mail & "', " & com & "responsabilidadFiscal" & com & " = '" & Me.responsabilidadFiscal & "' , " & com & "claveFiscal" & com & " = '" & Me.claveFiscal & "' "
        resp = upd.update(com & "cedirData" & com & "." & com & "tblMedicosAct" & com, uptString, " where " & com & "idMedicoAct" & com & " = " & Me.idMedico)
        resp = upd.update(com & "cedirData" & com & "." & com & "tblMedicosSol" & com, uptString1, " where " & com & "idMedicoSol" & com & " = " & Me.idMedico)
        Return resp

    End Function

    Public Function getPagos(ByVal fechaDesde As String, ByVal fechaHasta As String) As ArrayList
        Dim da As New CedirDataAccess.Consultas
        getPagos = New ArrayList
        Dim drPagos As NpgsqlDataReader
        Dim currentPago As PagoMedico

        Dim r As New System.Text.RegularExpressions.Regex("(/)")
        Dim arrR As String()

        Dim condicion As String
        If fechaDesde <> "" And fechaHasta <> "" Then
            arrR = r.Split(fechaDesde)
            fechaDesde = arrR(0) & "/" & arrR(2) & "/" & arrR(4)
            arrR = r.Split(fechaHasta)
            fechaHasta = arrR(0) & "/" & arrR(2) & "/" & arrR(4)
            condicion &= " and " & com & "fechaPago" & com & " between '" & fechaDesde & "' and '" & fechaHasta & "'"
        ElseIf fechaDesde <> "" Then
            arrR = r.Split(fechaDesde)
            fechaDesde = arrR(0) & "/" & arrR(2) & "/" & arrR(4)
            condicion &= " and " & com & "fechaPago" & com & " = '" & fechaDesde & "'"
        Else
            'Ultimos pagos
            condicion &= " and " & com & "fechaPago" & com & " >= (current_date - 45)"
        End If
        drPagos = da.EjecutarSelect(" select " & com & "nroPago" & com & ", " & com & "fechaPago" & com & ", " & com & "observacionPago" & com & ", " & com & "idMedico" & com & " from " & com & "cedirData" & com & "." & com & "tblPagosMedicos" & com & " where " & com & "idMedico" & com & " = " & Me.idMedico & condicion)
        While drPagos.Read()
            currentPago = New PagoMedico
            currentPago.nroPago = drPagos.Item(0)
            currentPago.fecha = drPagos.Item(1)
            currentPago.observacion = drPagos.Item(2)
            currentPago.medico = Me

            getPagos.Add(currentPago)
        End While
        drPagos.Close()

    End Function

End Class
