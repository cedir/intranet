Imports CedirDataAccess
Imports System.Linq

Public Class PorcentajeMedico
    Public Sub New(pMedico As Single, pCedir As Single)
        Me.Medico = pMedico
        Me.Cedir = pCedir
    End Sub

    Private pMedico As Single
    Public Property Medico() As Single
        Get
            Return pMedico
        End Get
        Set(ByVal value As Single)
            pMedico = value
        End Set
    End Property

    Private pCedir As Single
    Public Property Cedir() As Single
        Get
            Return pCedir
        End Get
        Set(ByVal value As Single)
            pCedir = value
        End Set
    End Property

    Public Function GetEfectivo() As Single
        If Me.Cedir = 100 Then
            Return 0
        Else
            Return (Me.Medico * 100) / (100 - Me.Cedir)
        End If
    End Function
End Class


Public Class LineaPagoMedico
    Private m_estudio As estudio
    Private m_importe As Single
    Private m_gastosAdministrativos As Decimal
    Private m_porcentajeIVAPagoMedicoActuante As Decimal
    Const descuentoPorPolipectomiaOSDE As Decimal = 0 'pedido Mariana, email 07/05/2016
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
                Case cEstudio.obraSocial.idObraSocial = 3 OrElse cEstudio.obraSocial.idObraSocial = 79
                    'OS OSDE Y OS OSDE(CEDIR)
                    Return Me.getDescuentoPorPolipectomiaOSDE
                Case cEstudio.obraSocial.idObraSocial = 25 OrElse cEstudio.obraSocial.idObraSocial = 5 OrElse cEstudio.obraSocial.idObraSocial = 46 OrElse cEstudio.obraSocial.idObraSocial = 19
                    'OS UNR, ACA Salud, GALENO y OSPAC
                    Return Me.getDescuentoPorPolipectomiaMaterialFacturableDirecto
                Case Else
                    Return 300.0
            End Select

        End If

    End Function


    Public Function getPorcentaje() As PorcentajeMedico
        'Const ID_OBRA_SOCIAL_GALENO As Integer = 46
        'Const CONSULTA As Integer = 20
        'Const ELECTRO As Integer = 46

        Const PORC_CONSULTA As Decimal = 100

        Const PORC_ACTUANTE_ECOGRAFIA As Decimal = 70
        Const PORC_SOLICITANTE_ECOGRAFIA As Decimal = 15
        Const PORC_CEDIR_ECOGRAFIA As Decimal = 15

        Const PORC_ACTUANTE_LABORATORIO As Decimal = 70
        Const PORC_SOLICITANTE_LABORATORIO As Decimal = 10
        Const PORC_CEDIR_LABORATORIO As Decimal = 20

        Const PORC_ACTUANTE_LIGADURA_HEMORROIDES As Decimal = 50
        Const PORC_SOLICITANTE_LIGADURA_HEMORROIDES As Decimal = 0
        Const PORC_CEDIR_LIGADURA_HEMORROIDES As Decimal = 50

        Const PORC_ACTUANTE_PRACTICA_ESPECIAL As Decimal = 75
        Const PORC_SOLICITANTE_PRACTICA_ESPECIAL As Decimal = 0
        Const PORC_CEDIR_PRACTICA_ESPECIAL As Decimal = 25


        Const PORC_ACTUANTE As Decimal = 80
        Const PORC_SOLICITANTE As Decimal = 0
        Const PORC_CEDIR As Decimal = 20

        Const COMB_MED_ACT_BRUNETTI As Integer = 2
        Dim COMB_MED_SOL_AL_50_PORC() As Integer = {578}
        Dim COMB_MED_SOL_AL_40_PORC() As Integer = {585, 529, 78, 89}

        If Me.estudio.practica.idEstudio = 20 Then
            'Si el estudio es una consulta, la retencion es del 0%
            Return New PorcentajeMedico(PORC_CONSULTA, 0)
        End If

        Dim EsActuante As Boolean = Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" OrElse Me.estudio.getCondicionMedico(idMedico) = "actuante"

        'if por tipo de estudio
        If Me.estudio.esEcografia Then
            Return New PorcentajeMedico(IIf(EsActuante, PORC_ACTUANTE_ECOGRAFIA, PORC_SOLICITANTE_ECOGRAFIA), PORC_CEDIR_ECOGRAFIA)
        ElseIf Me.estudio.esLaboratorio Then
            Return New PorcentajeMedico(IIf(EsActuante, PORC_ACTUANTE_LABORATORIO, PORC_SOLICITANTE_LABORATORIO), PORC_CEDIR_LABORATORIO)
        ElseIf Me.estudio.esLigaduraDeHemorroides() Then
            Return New PorcentajeMedico(IIf(EsActuante, PORC_ACTUANTE_LIGADURA_HEMORROIDES, PORC_SOLICITANTE_LIGADURA_HEMORROIDES), PORC_CEDIR_LIGADURA_HEMORROIDES)
        ElseIf Me.estudio.esPracticaEspecial() Then
            Return New PorcentajeMedico(IIf(EsActuante, PORC_ACTUANTE_PRACTICA_ESPECIAL, PORC_SOLICITANTE_PRACTICA_ESPECIAL), PORC_CEDIR_PRACTICA_ESPECIAL)
        Else
            If Me.estudio.medicoActuante.idMedico = COMB_MED_ACT_BRUNETTI Then
                If COMB_MED_SOL_AL_40_PORC.Any(Function(mid) Me.estudio.medicoSolicitante.idMedico = mid) Then
                    Return New PorcentajeMedico(IIf(EsActuante, 0.6 * PORC_ACTUANTE, 0.4 * PORC_ACTUANTE), PORC_CEDIR)
                ElseIf COMB_MED_SOL_AL_50_PORC.Any(Function(mid) Me.estudio.medicoSolicitante.idMedico = mid) Then
                    Return New PorcentajeMedico(IIf(EsActuante, 0.5 * PORC_ACTUANTE, 0.5 * PORC_ACTUANTE), PORC_CEDIR)
                End If
            End If
            Return New PorcentajeMedico(IIf(EsActuante, PORC_ACTUANTE, PORC_SOLICITANTE), PORC_CEDIR)
        End If
    End Function

    Public Function guardar(ByVal nroPago As Integer) As String
        Dim upd As New Nuevo

        Dim uptString1 As String = """importePagoMedico"" = " & Me.importe & ", ""porcentajeIVAPagoMedicoActuante"" = " & Me.porcentajeIVAPagoMedicoActuante & " ,  ""nroPagoMedicoAct"" = " & nroPago
        Dim uptString2 As String = """importePagoMedicoSol"" = " & "'" & Me.importe & "',  ""nroPagoMedicoSol"" = " & nroPago

        Dim updQuery As String = String.Empty

        If Me.estudio.getCondicionMedico(idMedico) = "actuante-solicitante" Then
            updQuery = uptString1 & " , ""importePagoMedicoSol"" = 0,  ""nroPagoMedicoSol"" = " & nroPago
        ElseIf Me.estudio.getCondicionMedico(idMedico) = "actuante" Then
            updQuery = uptString1
        ElseIf Me.estudio.getCondicionMedico(idMedico) = "solicitante" Then
            updQuery = uptString2
        End If

        Dim cFecha As String = Today.Year & "-" & Today.Month & "-" & Today.Day

        If Me.estudio.esPagoContraFactura = 1 Then
            'NO VAMOS A modificar la fecha de cobro, ya que es la del momento de
            'hacer el PCF. ESTO HAY que probarlo.
            '  updQuery &= ", ""fechaCobro"" = '" & cFecha & "'"
        End If

        Return upd.update("""tblEstudios""", updQuery, " where ""nroEstudio"" = " & Me.estudio.nroEstudio)
    End Function

End Class
