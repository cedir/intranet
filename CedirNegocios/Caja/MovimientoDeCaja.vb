Imports CedirDataAccess
Imports Npgsql

Public Class MovimientoDeCaja
    Inherits Movimiento

#Region "Variables de instancia"
    Private m_desc As String
    Private m_monto As Decimal
    Private m_montoAcumulado As Decimal
    Private m_medico As Medico
    Private m_tipoDeMovimiento As TipoDeMovimientoDeCaja
    Private m_estado As Boolean
    Private m_fecha As DateTime
    Private m_estudio As Estudio

#End Region


#Region "PROPIEDADES"

    ''' <summary>
    ''' estado= true : el movimiento esta pago
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    ''' 
    Public Property Estado() As Boolean
        Get
            Return m_estado
        End Get
        Set(ByVal value As Boolean)
            m_estado = value
        End Set
    End Property

    Public Property TipoDeMovimiento() As TipoDeMovimientoDeCaja
        Get
            Return m_tipoDeMovimiento
        End Get
        Set(ByVal value As TipoDeMovimientoDeCaja)
            m_tipoDeMovimiento = value
        End Set
    End Property

    Public Property Medico() As Medico
        Get
            Return m_medico
        End Get
        Set(ByVal value As Medico)
            m_medico = value
        End Set
    End Property

    Public Property Concepto() As String
        Get
            Return m_desc
        End Get
        Set(ByVal value As String)
            m_desc = value
        End Set
    End Property

    Public Property Monto() As Decimal
        Get
            Return m_monto
        End Get
        Set(ByVal value As Decimal)
            m_monto = value
        End Set
    End Property

    Public Property MontoAcumulado() As Decimal
        Get
            Return m_montoAcumulado
        End Get
        Set(ByVal value As Decimal)
            m_montoAcumulado = value
        End Set
    End Property

    Public Property Fecha() As DateTime
        Get
            Return m_fecha
        End Get
        Set(ByVal value As DateTime)
            m_fecha = value
        End Set
    End Property

    Public Property Estudio() As Estudio
        Get
            Return m_estudio
        End Get
        Set(ByVal value As Estudio)
            m_estudio = value
        End Set
    End Property

#End Region

#Region "CONSTRUCTOR"
    Public Sub New()
        Concepto = ""
        Fecha = DateTime.Now
        Estudio = Nothing
        Monto = 0.0
        MontoAcumulado = 0.0
    End Sub
#End Region

    Public Function estadoMovimiento() As String
        If Estado Then
            Return "Pago"
        Else
            Return "No Pago"
        End If
    End Function

    Public Sub crear()
        Dim com As String = """"
        Dim cDatos As New Nuevo

        Dim help As New Helper

        'estado del movimiento, por default = no pago
        Me.Estado = False
        'Convertimos las fechas a string y al formato YYYY MM DD
        Dim f1 As String
        f1 = help.convertDate(Me.Fecha)

        'insertamos el movimiento
        Dim resp As String = cDatos.insert(com & "cedirData" & com & "." & com & "tblCajaMovimientos" & com, com & "concepto" & com & ", " & com & _
                                           "monto" & com & ", " & com & "fecha" & com & ", " & com & "hora" & com & ", " & com & "idTipoDeMovimiento" & com & _
                                           ", " & com & "estado" & com & ", " & com & "montoAcumulado" & com, " E'" & Me.Concepto & "', '" & Me.Monto & "', '" & f1 & "' , '" & Me.Hora & "' , " & _
                                           Me.TipoDeMovimiento.id & " , " & Me.Estado & " , " & Me.MontoAcumulado)


        'seleccionamos el nro generado en base de datos
        Dim maxId As Integer = cDatos.selectMAX("tblCajaMovimientos", "id")
        Me.Id = maxId

        'insertamos, si corresponde, el id Del medico 
        If Me.Medico IsNot Nothing Then
            cDatos.update(com & "cedirData" & com & "." & com & "tblCajaMovimientos" & com, com & "idMedico" & com & _
                          " = " & Me.Medico.idMedico, " where " & com & "id" & com & " = " & Id)
        End If
        'insertamos, si corresponde, el id del estudio asociado
        If Me.Estudio IsNot Nothing Then
            cDatos.update(com & "cedirData" & com & "." & com & "tblCajaMovimientos" & com, com & "nroEstudio" & com & " = " & _
                          Me.Estudio.nroEstudio, " where " & com & "id" & com & " = " & Id)
        End If


    End Sub
    Public Function modificar() As String
        Dim com As String = """"
        Dim cDatos As New Nuevo
        Dim resp As String
        If Me.Medico IsNot Nothing Then
            resp = cDatos.update(com & "cedirData" & com & "." & com & "tblCajaMovimientos" & com, com & "concepto" & com & " = " & " E'" & Me.Concepto & "' ," & _
                                                    com & "idTipoDeMovimiento" & com & " = " & Me.TipoDeMovimiento.id & ", " & com & "estado" & com & " = " & Me.Estado & " ," & com & "idMedico" & com & _
                                     " = " & Me.Medico.idMedico, " where " & com & "id" & com & " = " & Id)
        Else
            'resp = cDatos.update(com & "cedirData" & com & "." & com & "tblCajaMovimientos" & com, com & "concepto" & com & " = " & " E'" & Me.Concepto & "' ," & _
            '                                                    com & "idTipoDeMovimiento" & com & " = " & Me.TipoDeMovimiento.id & ", " & com & "estado" & com & " = " & Me.Estado, " where " & com & "id" & com & " = " & Id)
            resp = cDatos.update(com & "cedirData" & com & "." & com & "tblCajaMovimientos" & com, com & "concepto" & com & " = " & " E'" & Me.Concepto & "' ," & _
                                                              com & "idTipoDeMovimiento" & com & " = " & Me.TipoDeMovimiento.id & ", " & com & "estado" & com & " = " & Me.Estado & " ," & com & "idMedico" & com & _
                                               " = NULL", " where " & com & "id" & com & " = " & Id)
        End If
        'modificamos el movimiento
       
        Return resp
    End Function
End Class
