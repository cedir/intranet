Imports System.Collections.Generic
Public Class LineaPagoAnestesista
    Private _estudios As List(Of Estudio)
    Private _contieneEstudiosConMovimientosAsociados As Boolean
    Private _sePresentaPorARA As Boolean
    Private _importeComplejidad As Decimal = 0.0
    Private _ivaPorcentaje As Decimal = 0.0
    Private _ivaImporte As Decimal = 0.0
    Private _importeAPagar As Decimal = 0.0
    Private _importeRetencion As Decimal = 0.0




    Public Sub New()
        estudios = New List(Of Estudio)
        _contieneEstudiosConMovimientosAsociados = False
        _importeComplejidad = 0.0
        _sePresentaPorARA = False
    End Sub
    Public Sub setImportes()
        setImporteComplejidad()
        setIVAPorcentaje()
        setIVAImporte()
        setImporteRetencion()
        setImporteAPagar()
    End Sub
    Public Property estudios() As List(Of Estudio)
        Get
            Return _estudios
        End Get
        Set(ByVal value As List(Of Estudio))
            _estudios = value
        End Set
    End Property
    Public ReadOnly Property importeComplejidad() As Decimal
        Get
            Return Format(_importeComplejidad, "###############0.00")
        End Get
       
    End Property
    Public ReadOnly Property ivaPorcentaje() As Decimal
        Get
            Return Format(_ivaPorcentaje, "###############0.00")
        End Get
        
    End Property
    Public Property ivaImporte() As Decimal
        Get
            Return Format(_ivaImporte, "###############0.00")
        End Get
        Set(ByVal value As Decimal)
            _ivaImporte = Format(value, "###############0.00")
        End Set
    End Property
    Public Property importeApagar() As Decimal
        Get
            Return Format(_importeAPagar, "###############0.00")
        End Get
        Set(ByVal value As Decimal)
            _importeAPagar = Format(value, "###############0.00")
        End Set
    End Property
    Public Property retencion() As Decimal
        Get
            Return Format(_importeRetencion, "###############0.00")
        End Get
        Set(ByVal value As Decimal)
            _importeRetencion = value
        End Set
    End Property
    Public Property contieneEstudiosConMovimientosAsociados() As Boolean
        Get
            Return _contieneEstudiosConMovimientosAsociados
        End Get
        Set(ByVal value As Boolean)
            _contieneEstudiosConMovimientosAsociados = value
        End Set
    End Property
    Public Property sePresentaPorARA() As Boolean
        Get
            If Me.estudios(0).obraSocial.sePresentaPorARA = 1 Then
                _sePresentaPorARA = True
            End If
            Return _sePresentaPorARA
        End Get
        Set(ByVal value As Boolean)
            _sePresentaPorARA = value
        End Set
    End Property


    Private Sub setImporteComplejidad()
        Const PARTICULAR As Integer = 2

        Dim calculador As New CalculadorHonorariosAnestesistas
        _importeComplejidad = calculador.getImporteComplejidad(estudios)

        If (estudios(0).paciente.edad >= 70 Or estudios(0).paciente.edad < 12) And estudios(0).obraSocial.idObraSocial = PARTICULAR Then
            _importeComplejidad = 1.3 * _importeComplejidad
        End If
        calculador = Nothing

    End Sub
    Private Sub setIVAPorcentaje()
        'para definir esta regla sólo es necesario observar el primer estudio del grupo
        Const SIMARA As Integer = 6
        Const AMECA As Integer = 108
        Const EPE As Integer = 23
        Const PARTICULAR As Integer = 2
        Const PARTICULAR_ESPECIAL As Integer = 134

        Select Case True
            Case estudios(0).obraSocial.sePresentaPorARA = 1 Or estudios(0).obraSocial.idObraSocial = PARTICULAR Or estudios(0).obraSocial.idObraSocial = PARTICULAR_ESPECIAL
                _ivaPorcentaje = 0.0
            Case estudios(0).obraSocial.idObraSocial = SIMARA Or estudios(0).obraSocial.idObraSocial = AMECA
                _ivaPorcentaje = 10.5
            Case estudios(0).obraSocial.idObraSocial = EPE
                _ivaPorcentaje = 21
            Case Else
                _ivaPorcentaje = 0.0
        End Select
    End Sub
    Private Sub setImporteRetencion()
        _importeRetencion = (_ivaImporte + _importeComplejidad) * 0.1
    End Sub
    Private Sub setImporteAPagar()

        If sePresentaPorARA And Me.contieneEstudiosConMovimientosAsociados = False Then
            Me._importeAPagar = Me._importeRetencion * -1
        Else : sePresentaPorARA = False Or (sePresentaPorARA = True And Me.contieneEstudiosConMovimientosAsociados)
            Me._importeAPagar = Me._ivaImporte + Me._importeComplejidad - _importeRetencion
        End If
        If Me.contieneEstudiosConMovimientosAsociados And _importeAPagar <= 0 Then
            Me._importeAPagar = -importeApagar
        End If
    End Sub
    Private Sub setIVAImporte()
        Me.ivaImporte = Me.importeComplejidad * Me.ivaPorcentaje / 100
    End Sub
    Public Sub cambiarImportesDeLinea(ByVal pIVAPorcentaje As Decimal, ByVal pImporte As Decimal)
        _ivaPorcentaje = pIVAPorcentaje
        _importeComplejidad = pImporte

        setIVAImporte()
        setImporteRetencion()
        setImporteAPagar()
    End Sub
End Class
