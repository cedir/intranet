Imports CedirDataAccess
Imports Npgsql
Public Class LineaPagoMedico
    Private m_estudio As estudio
    Private m_importe As Single
    Private m_gastosAdministrativos As Decimal
    Private m_porcentajeIVAPagoMedicoActuante As Decimal
    Const descuentoPorPolipectomiaOSDE As Decimal = 70
    Const descuentoPorPolipectomiaMaterialFacturable As Decimal = 0
    Public idMedico As Integer

    Public Sub New()

    End Sub

    Public Property porcentajeIVAPagoMedicoActuante() As Decimal
        Get
            Return m_porcentajeIVAPagoMedicoActuante
        End Get
        Set(ByVal value As Decimal)
            m_porcentajeIVAPagoMedicoActuante = value
        End Set
    End Property
    Public Property estudio() As Estudio
        Get
            estudio = m_estudio
        End Get
        Set(ByVal Value As Estudio)
            m_estudio = Value
        End Set
    End Property

    Public Property gastosAdministrativos() As Single
        Get
            gastosAdministrativos = m_gastosAdministrativos
        End Get
        Set(ByVal Value As Single)
            m_gastosAdministrativos = Value
        End Set
    End Property

    Public Property importe() As Single
        Get
            importe = m_importe
        End Get
        Set(ByVal Value As Single)
            m_importe = Value
        End Set
    End Property

    Public ReadOnly Property getDescuentoPorPolipectomiaOSDE() As Decimal
        Get
            Return descuentoPorPolipectomiaOSDE
        End Get
    End Property
    Public ReadOnly Property getDescuentoPorPolipectomiaMaterialFacturableDirecto() As Decimal
        Get
            Return descuentoPorPolipectomiaMaterialFacturable
        End Get
    End Property

    Public Function getDescuentos() As Decimal

        Dim cEstudio As Estudio = Me.estudio
        Dim descuentoPorPolipectomia As Decimal = Me.getDescuentoPolipectomiaSegunObraSocial()



        Dim descuentoColangios As Decimal = 0
        ' si la practica es alguna de las siguientes, se realiza un dto de 2000 pesos, A PARTIR DEL 09/04/2013
        If cEstudio.practica.idEstudio = 13 Or cEstudio.practica.idEstudio = 14 Or cEstudio.practica.idEstudio = 34 Then
            descuentoColangios = 2000
        End If

        ' si la practica es alguna de las siguientes, se realiza un dto de 900 pesos, A PARTIR DEL 09/04/2013
        Dim descuentoStent As Decimal = 0
        If cEstudio.practica.idEstudio = 48 Or cEstudio.practica.idEstudio = 49 Or cEstudio.practica.idEstudio = 97 Then
            descuentoStent = 900
        End If

        ' si la practica es alguna de las siguientes, se realiza un dto de 900 pesos, A PARTIR DEL 09/04/2013
        Dim descuentoRadiofrecuencia As Decimal = 0
        If cEstudio.practica.idEstudio = 11 Or cEstudio.practica.idEstudio = 17 Or cEstudio.practica.idEstudio = 43 Then
            descuentoRadiofrecuencia = 450
        End If



        Return Format(descuentoPorPolipectomia + descuentoColangios + descuentoStent + descuentoRadiofrecuencia, "#############0.00")
    End Function

    Private Function getDescuentoPolipectomiaSegunObraSocial() As Decimal
        Dim cEstudio As Estudio = Me.estudio
        'Si el estudio no es polipectomia, no se hace descuento
        If cEstudio.practica.Estudio.IndexOf("POLIPECTOMIA") = -1 And cEstudio.practica.Estudio.IndexOf("TERAPEUTICA") = -1 Then
            Return 0.0
        Else

            Select Case True
                Case cEstudio.obraSocial.idObraSocial = 3 Or cEstudio.obraSocial.idObraSocial = 79
                    'OS OSDE Y OS OSDE(CEDIR)
                    Return Me.getDescuentoPorPolipectomiaOSDE
                Case cEstudio.obraSocial.idObraSocial = 25 Or cEstudio.obraSocial.idObraSocial = 5 Or cEstudio.obraSocial.idObraSocial = 46
                    'OS UNR aca y galeno
                    Return Me.getDescuentoPorPolipectomiaMaterialFacturableDirecto
                Case Else
                    Return 200.0
            End Select

        End If

    End Function


    Public Function getPorcentaje() As Single
        Const ID_OBRA_SOCIAL_GALENO As Integer = 46
        Const CONSULTA As Integer = 20
        Const ELECTRO As Integer = 46

        Const PORCENTAJE_CONSULTA As Decimal = 100
        Const PORCENTAJE_ECOGRAFIA_ACTUANTE As Decimal = 70
        Const PORCENTAJE_ECOGRAFIA_SOLICITANTE As Decimal = 15
        Const PORCENTAJE_LABORATORIO_ACTUANTE As Decimal = 70
        Const PORCENTAJE_LABORATORIO_SOLICITANTE As Decimal = 10
        Const PORCENTAJE_LIGADURA_HEMORROIDES As Decimal = 60
        Const PORCENTAJE_PRACTICA_ESPECIAL As Decimal = 75


        If Me.estudio.practica.idEstudio = 20 Then
            'Si el estudio es una consulta, la retencion es del 0%
            Return PORCENTAJE_CONSULTA
        End If

        'if por tipo de estudio
        If Me.estudio.esEcografia Then
            If Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" Or Me.estudio.getCondicionMedico(idMedico) = "actuante" Then
                Return PORCENTAJE_ECOGRAFIA_ACTUANTE
            End If
            Return PORCENTAJE_ECOGRAFIA_SOLICITANTE
        ElseIf Me.estudio.esLaboratorio Then
            If Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" Or Me.estudio.getCondicionMedico(idMedico) = "actuante" Then
                Return PORCENTAJE_LABORATORIO_ACTUANTE
            End If
            Return PORCENTAJE_LABORATORIO_SOLICITANTE
        ElseIf Me.estudio.esLigaduraDeHemorroides() Then
            If Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" Or Me.estudio.getCondicionMedico(idMedico) = "actuante" Then
                Return PORCENTAJE_LIGADURA_HEMORROIDES
            End If
        ElseIf Me.estudio.esPracticaEspecial() Then
            If Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" Or Me.estudio.getCondicionMedico(idMedico) = "actuante" Then
                Return PORCENTAJE_PRACTICA_ESPECIAL
            End If
        Else
            'Caso mas comun - estudios endoscopicos
            Dim porcentajeConNLA As Single = 80 ' 85
            Dim porcentajeSoloSolicitante As Single = 0

            If Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" Or Me.estudio.getCondicionMedico(idMedico) = "actuante" Then
                Return porcentajeConNLA
            ElseIf Me.estudio.getCondicionMedico(idMedico) = "solicitante" Then
                Return porcentajeSoloSolicitante
            End If
        End If

    End Function

    Public Function guardar(ByVal nroPago As Integer) As String
        Dim com As String = """"
        Dim upd As New Nuevo
        Dim resp As String

        Dim uptString1 As String = com & "importePagoMedico" & com & " = " & Me.importe & ", " & com & "porcentajeIVAPagoMedicoActuante" & com & " = " & Me.porcentajeIVAPagoMedicoActuante & " ,  " & com & "nroPagoMedicoAct" & com & " = " & nroPago
        Dim uptString2 As String = com & "importePagoMedicoSol" & com & " = " & "'" & Me.importe & "',  " & com & "nroPagoMedicoSol" & com & " = " & nroPago

        Dim updQuery As String
        If Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" Then
            updQuery = uptString1 & " , " & com & "importePagoMedicoSol" & com & " = 0,  " & com & "nroPagoMedicoSol" & com & " = " & nroPago
        ElseIf Me.estudio.getCondicionMedico(idMedico) = "actuante" Then
            updQuery = uptString1
        ElseIf Me.estudio.getCondicionMedico(idMedico) = "solicitante" Then
            updQuery = uptString2
        End If

        Dim cFecha As String = Today.Year & "-" & Today.Month & "-" & Today.Day

        If Me.estudio.esPagoContraFactura = 1 Then
            'NO VAMOS A modificar la fecha de cobro, ya que es la del momento de
            'hacer el PCF. ESTO HAY que probarlo.
            '  updQuery &= ", " & com & "fechaCobro" & com & " = '" & cFecha & "'"
        End If

        resp = upd.update(com & "public" & com & "." & com & "tblPagoCobroEstudio" & com, updQuery, " where " & com & "nroEstudio" & com & " = " & Me.estudio.nroEstudio)


        Return resp
    End Function

End Class
