Imports Npgsql
Imports CedirDataAccess
Imports System.Collections.Generic
Public Class Presentacion
    Private _obraSocial As ObraSocial
    Private _idPresentacion As Int64
    Private _fechaFacturacion As Date
    Private _pagado As Integer
    Private _periodo As String
    Private _total As Decimal
    Private _totalFacturado As Decimal
    Private com = """"
    Private lineasDeFacturacionDeEstudios As ArrayList
    Private arancelConsulta As Arancel
    Private pagoFacturacion As PagoFacturacion
    Private _comprobante As Comprobante



    Public Sub New()
        lineasDeFacturacionDeEstudios = New ArrayList
        obraSocial = New ObraSocial
        comprobante = New Comprobante
    End Sub

#Region "Propiedades"

    Public ReadOnly Property estado() As String
        'en realidad pagado seria estado
        Get
            If Me.pagado = 1 Then
                'estado = 1 significa que se facturo y se cobro
                estado = "Cobrado"
            ElseIf Me.pagado = 0 Then
                'estado = 0 significa que esta facturado, y no se pueden agregar mas estudios ni modificar nada porque esta cerrado
                estado = "Pendiente"
            ElseIf Me.pagado = 2 Then
                'estado = 2 la facturacion esta abierta a agregar o modificar estudios
                estado = "Abierto"
            End If
        End Get

    End Property

    Public Property idPresentacion() As Int64
        Get
            Return _idPresentacion
        End Get
        Set(ByVal value As Int64)
            _idPresentacion = value
        End Set
    End Property

    Public Property fechaFacturacion() As Date
        Get
            Return _fechaFacturacion
        End Get
        Set(ByVal value As Date)
            _fechaFacturacion = value
        End Set
    End Property

    Public Property pagado() As Integer
        Get
            Return _pagado
        End Get
        Set(ByVal value As Integer)
            _pagado = value
        End Set
    End Property

    Public Property periodo() As String
        Get
            Return _periodo
        End Get
        Set(ByVal value As String)
            _periodo = value
        End Set
    End Property

    Public Property total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property

    Public Property totalFacturado() As Decimal
        Get
            Return _totalFacturado
        End Get
        Set(ByVal value As Decimal)
            _totalFacturado = value
        End Set
    End Property

    Public Property comprobante() As Comprobante
        Get
            Return _comprobante
        End Get
        Set(ByVal value As Comprobante)
            _comprobante = value
        End Set
    End Property

    Public Property obraSocial() As ObraSocial
        Get
            Return _obraSocial
        End Get
        Set(ByVal value As ObraSocial)
            _obraSocial = value
        End Set
    End Property

#End Region
    Public Function inicilizarFacturacion() As String
        'inicializa los arreglos - obtiene estudios disponibles para facturar . la facturacion es temporal todavia.
        total = 0
        loadEstudios("where " & com & "idFacturacion" & com & " = 0 and est." & com & "idObraSocial" & com & " = " & Me.obraSocial.idObraSocial & " and est." & com & "pagoContraFactura" & com & " = " & 0 & " and est." & com & "esPagoContraFactura" & com & " = " & 0, "noEstaEnFacturacion")
        Return "ok"
    End Function

    Public Function cargarFacturacion() As String
        total = 0
        loadEstudios("where " & com & "idFacturacion" & com & " = " & Me.idPresentacion, "estaEnFacturacion")
        Return "ok"
    End Function

    Public Function getLineasDeFacturacionEstudios() As ArrayList
        Return lineasDeFacturacionDeEstudios
    End Function


    Public Function crear() As String

        Dim altas As New Nuevo
        Dim idFacturacion As Int64 = altas.nuevaFacturacion(Me.obraSocial.idObraSocial, Me.fechaFacturacion, Me.pagado, Me.periodo, Me.comprobante.IdComprobante)
        If idFacturacion = 0 Then
            Return "error"
        Else
            Me.idPresentacion = idFacturacion
            _guardarLineas()
            'Acordarse que en tblPresentacion se guarda total=totalFacturado
            'No pasa lo mismo con el comprobante,(totalFacturado en comprobante incluye el iva)
            Dim resp As String = altas.update(com & "public" & com & "." & com & "tblFacturacion" & com, com & "total" & com & " = '" & Me.total & "', " & com & "totalFacturado" & com & " = '" & Me.total & "'", " where " & com & "idFacturacion" & com & " = " & Me.idPresentacion)
            Return "ok"
        End If

    End Function

    Public Function crearComprobante() As Dictionary(Of String, String)
        'CARGAMOS LA LINEA: EN FACTURA ELECTRONICA, SOLAMENTE VAMOS A NECESITAR UNA SOLA
        'YA QUE PODEMOS DISCRIMINAR IVA EN CADA UNA DE LAS LINEAS. 
        Dim result As New Dictionary(Of String, String)
        Dim lineaComprobante As New LineaDeComprobante
        Dim totalImporteNetoLineaDeFacturacion As Decimal = 0.0
        Dim cLinea As LineaDeFacturacion

        For i As Integer = 0 To lineasDeFacturacionDeEstudios.Count - 1
            cLinea = lineasDeFacturacionDeEstudios(i)
            'cLinea.guardar(Me.idPresentacion)
            totalImporteNetoLineaDeFacturacion += cLinea.getImporteNeto
        Next

        'Si el comprobante es una factura, la leyenda cambia
        'Datos comunes tanto a Facturas B como Facturas A
        lineaComprobante.Concepto = "Facturaci�n correspondiente al mes  " & Me.periodo & vbCrLf & "seg�n detalle adjunto"
        lineaComprobante.importeNeto = Format(totalImporteNetoLineaDeFacturacion, "########0.00")
        If Me.comprobante.Gravado IsNot Nothing Then
            lineaComprobante.ImporteIVA = (totalImporteNetoLineaDeFacturacion * Me.comprobante.Gravado.porcentaje) / 100
        End If
        lineaComprobante.Subtotal = Format(lineaComprobante.importeNeto + lineaComprobante.ImporteIVA, "########0.00")


        Me.comprobante.LineasDeComprobante.Add(lineaComprobante)
        Me.comprobante.TotalFacturado = lineaComprobante.Subtotal
        Me.comprobante.IdObraSocial = Me.obraSocial.idObraSocial  ' solo se usa para calcular la fecha de vto
        'se devuelve una lista de objetos con la respuesta de AFIP
        result = Me.comprobante.crear()
        If Not Helper.IsSuccess(result) Then
            Helper.Result(result, False, String.Format("ERROR: {0}. Sacar sceenshot de la pantalla y avisar al administrador.", Helper.GetMessage(result)))
            'TODO: El comprobante debe existir. Ver que hacer aca en caso de error.
            'Una opcion es crear una Liquidacion para que se vuelva a intentar desde "abrir estudio"
        End If

        Return result

    End Function
    Private Sub updateNroComprobante()
        Dim cDatos As New Nuevo
        Dim com As String = """"

        Dim tabla As String = com & "public" & com & "." & com & "tblFacturacion" & com
        Dim campos As String = com & "idComprobante" & com & " = " & Me.comprobante.IdComprobante
        Dim filtro As String = " where idFacturacion = " & Me.idPresentacion
        cDatos.update(tabla, campos, filtro)
    End Sub

    Public Function guardar(ByVal guardarLineas As Boolean, Optional ByVal finalizaPresentacion As Boolean = False) As String
        Dim resp As String
        Dim fecha As String
        Dim altas As New Nuevo

        fecha = Me.fechaFacturacion.Year & "-" & Me.fechaFacturacion.Month & "-" & Me.fechaFacturacion.Day

        'No pasamos idComprobante, ya que solo guarda

        'Tenemos que diferenciar si se finaliza la presentacion, para pasar como parametro el idComprobante.
        If finalizaPresentacion = False Then
            resp = altas.update(com & "public" & com & "." & com & "tblFacturacion" & com, com & "fechaFacturacion" & com & " = '" & fecha & "', " & com & "pagado" & com & " = " & Me.pagado & ", " & com & "periodo" & com & " = '" & Me.periodo & "'", " where " & com & "idFacturacion" & com & " = " & Me.idPresentacion)
        Else
            resp = altas.update(com & "public" & com & "." & com & "tblFacturacion" & com, com & "fechaFacturacion" & com & " = '" & fecha & "', " & com & "pagado" & com & " = " & Me.pagado & ", " & com & "periodo" & com & " = '" & Me.periodo & "', " & com & "idComprobante" & com & " = " & Me.comprobante.IdComprobante, " where " & com & "idFacturacion" & com & " = " & Me.idPresentacion)
        End If


        If resp = "ok" Then
            If guardarLineas Then
                _guardarLineas()
                'Guardar total
                resp = altas.update(com & "public" & com & "." & com & "tblFacturacion" & com, com & "total" & com & " = '" & Me.total & "', " & com & "totalFacturado" & com & " = '" & Me.total & "'", " where " & com & "idFacturacion" & com & " = " & Me.idPresentacion)
            End If
            Return "ok"
        Else
            Return "error"
        End If
    End Function

    Private Sub _guardarLineas()
        total = 0
        Dim cLinea As LineaDeFacturacion
        For i As Integer = 0 To lineasDeFacturacionDeEstudios.Count - 1
            cLinea = lineasDeFacturacionDeEstudios(i)
            cLinea.guardar(Me.idPresentacion)
            total += cLinea.getImporteNeto
        Next

    End Sub

    Public Function quitarLineaDeEstudios(ByVal nroLinea As Integer) As Boolean
        'obtener linea
        Dim cLinea As LineaDeFacturacion = lineasDeFacturacionDeEstudios(nroLinea)
        Dim resp As String = "ok"
        'obtener estado
        If cLinea.estado = "estaEnFacturacion" Then
            'actualizar base de datos
            resp = cLinea.guardar(0)
        End If

        If resp = "ok" Then
            'luego quitar del arreglo
            lineasDeFacturacionDeEstudios.RemoveAt(nroLinea)
            Return True
        End If

        Return False
    End Function
    Public Function addLineaEstudio(ByVal linea As LineaDeFacturacion) As Boolean
        'validar que ya no este en la facturacion
        Dim cLinea As LineaDeFacturacion
        For i As Integer = 0 To lineasDeFacturacionDeEstudios.Count - 1
            cLinea = lineasDeFacturacionDeEstudios(i)
            If cLinea.objeto.nroEstudio = linea.objeto.nroEstudio Then
                Return False
            End If
        Next
        'agregar
        lineasDeFacturacionDeEstudios.Add(linea)
        Return True
    End Function

    Public Function getArancelConsulta() As Arancel
        If arancelConsulta Is Nothing Then
            Dim cArancel As Arancel = Me.obraSocial.getAranacel(20)
            If cArancel Is Nothing Then
                cArancel = New Arancel
                cArancel.precio = 0
            End If
            arancelConsulta = cArancel
        End If

        Return arancelConsulta
    End Function

    Public Function realizarCobro(ByVal nroRecibo As String, ByVal gastoAdministrativo As Single) As Boolean
        'Se llama solo desde cobro de facturacion
        'Se complica su reutilizacion debido a la diferencia paciente y medicacion
        'Para logica de fact. H, quizas habria que crear otro realizarCobro (realizarCobroFacturaH por ej.)
        Dim cFecha As String = Today.Year & "-" & Today.Month & "-" & Today.Day
        Dim upd As New Nuevo
        Dim resp As String
        Dim importeTotal As Double = 0
        Dim cLinea As LineaDeFacturacion
        For i As Integer = 0 To lineasDeFacturacionDeEstudios.Count - 1
            cLinea = lineasDeFacturacionDeEstudios(i)
            Dim importeEstudioCobrado As Single = cLinea.objeto.importeEstudioCobrado
            Dim importeMedicacionCobrado As Single = cLinea.objeto.importeCobradoMedicacion
            resp = upd.update("""tblEstudios""", """fechaCobro"" = '" & cFecha & "', ""importeEstudioCobrado"" = '" & importeEstudioCobrado & "', ""importeMedicacionCobrado"" = '" & importeMedicacionCobrado & "', ""importeCobradoPension"" = '" & cLinea.objeto.importeCobradoPension & "', ""importeCobradoArancelAnestesia"" = '" & cLinea.objeto.importeCobradoArancelAnestesia & "'", " where ""nroEstudio"" = " & cLinea.objeto.nroEstudio)

            importeTotal += importeEstudioCobrado + cLinea.objeto.importeCobradoPension + importeMedicacionCobrado + cLinea.objeto.importeCobradoArancelAnestesia
        Next

        Me.pagado = 1
        Me.total = importeTotal

        Dim cPago As New PagoFacturacion
        cPago.fecha = cFecha
        cPago.nroDeRecibo = nroRecibo
        cPago.gastoAdministrativo = gastoAdministrativo
        cPago.importe = importeTotal
        cPago.guardar(Me.idPresentacion)

        Me.pagoFacturacion = cPago
    End Function
    Public Function getPago() As PagoFacturacion
        If Me.estado <> "Cobrado" Then
            Throw New Exception("Posible error, la presentaci�n NO esta cobrada")
        Else
            If pagoFacturacion Is Nothing Then
                'Obtener pago
                Dim da As New CedirDataAccess.Consultas
                Dim pagosFacturacion As New ArrayList
                Dim drPagos As NpgsqlDataReader
                Dim cPago As PagoFacturacion
                drPagos = da.EjecutarSelect("select " & com & "idPagoFact" & com & ", " & com & "idFacturacion" & com & ", " & com & "fechaPagoFact" & com & ", " & com & "nroRecivo" & com & ", " & com & "importePago" & com & ", " & com & "gastoAdministrativo" & com & " from " & com & "public" & com & "." & com & "tblPagoFacturacion" & com & " where " & com & "idFacturacion" & com & " = " & Me.idPresentacion)
                While drPagos.Read()
                    cPago = New PagoFacturacion
                    cPago.id = drPagos.Item(0)
                    'cPago.idFacturacion = drPagos.Item(1)
                    cPago.fecha = drPagos.Item(2)
                    cPago.nroDeRecibo = drPagos.Item(3)
                    cPago.importe = drPagos.Item(4)
                    cPago.gastoAdministrativo = drPagos.Item(5)
                    pagosFacturacion.Add(cPago)
                End While
                drPagos.Close()

                pagoFacturacion = pagosFacturacion(0)
            End If

            Return pagoFacturacion
        End If

    End Function

    Public Function getImporteIva() As Single
        If Me.comprobante Is Nothing Then
            Return 0
        End If
        Return Math.Round((Me.totalFacturado * Me.comprobante.Gravado.porcentaje) / 100, 2, MidpointRounding.AwayFromZero)
    End Function
    Public Function getTotalFactura() As Single
        Return Me.getTotalFacturado + Me.getImporteIva
    End Function
    Public Function getTotalFacturado() As Single
        'esto se hace por compatibilidad, en facturaciones viejas no esta cargado el valor totalFacturado
        Return Math.Round(Math.Max(Me.totalFacturado, Me.total), 2, MidpointRounding.AwayFromZero)
    End Function
    Public Function getTotalMedicacion() As Single
        Dim totalMedicacion As Single = 0
        Dim cLinea As LineaDeFacturacion
        For i As Integer = 0 To lineasDeFacturacionDeEstudios.Count - 1
            cLinea = lineasDeFacturacionDeEstudios(i)
            totalMedicacion += cLinea.objeto.getTotalMedicacion()
        Next
        Return totalMedicacion
    End Function

    Public Sub anularComprobante(ByVal estado As String) 'este metodo anula el comprobante al abrir la presentacion
        Dim cDatos As New Nuevo
        cDatos.update(com & "public" & com & "." & com & "tblFacturacion" & com, com & "idComprobante" & com & " = " & "NULL, " & com & "pagado" & com & " = " & "2", " where " & com & "idFacturacion" & com & " = " & Me.idPresentacion)
        cDatos.update(com & "public" & com & "." & com & "tblComprobantes" & com, com & "estado" & com & " = " & "'" & estado & "'", " where " & com & "id" & com & " = " & Me.comprobante.IdComprobante)
        cDatos = Nothing
    End Sub

    Public Function GenerarNotaDeCredito() As Dictionary(Of String, String)
        If Me.comprobante IsNot Nothing Then
            Dim nota As Comprobante = Me.comprobante.GenerarNotaDeCredito()
            If nota IsNot Nothing Then
                Return nota.crear()
            End If
        End If
        Return Helper.Result(False, "Error al generar la Nota de Cr�dito que anula la Factura de la Presentaci�n.")
    End Function

    Public Function calcularComprobanteTotalCobrado() As Decimal
        'este metodo lo utilizo cuando hago un cobro de presentacion.
        'calculo la diferencia entre lo facturado en la presentacion - lo modificado
        Dim abs As Decimal = Convert.ToDecimal(Math.Abs(Me.total - Me.totalFacturado))
        'calculo iva sobre esa diferencia
        Dim diferencia As Decimal = (abs * Me.comprobante.Gravado.porcentaje) / 100
        'seteo el total facturado del comprobante
        Me.comprobante.TotalCobrado = Me.comprobante.TotalFacturado - (diferencia + abs)
        Me.comprobante.updateTotalCobrado()
        Return Format((diferencia + abs), "#########0.00")
    End Function


    Public Function getPorcentajeGtosAdmin() As Decimal
        If Me.obraSocial.sePresentaPorAMR Then
            Return 32
        Else
            Return 25
        End If
    End Function

    Private Function loadEstudios(ByVal condicion As String, ByVal estado As String) As String

        Dim catEstudios As New CatalogoDeEstudios
        Dim vEstudio As Estudio
        Dim arrEstudios As ArrayList
        Dim i As Integer = 0

        lineasDeFacturacionDeEstudios.Clear()
        arrEstudios = catEstudios.loadEstudios(condicion)
        For i = 0 To arrEstudios.Count - 1
            vEstudio = arrEstudios(i)
            Dim cLinea As New LineaDeFacturacion
            cLinea.objeto = vEstudio
            If estado = "estaEnFacturacion" Then
                cLinea.importe = vEstudio.ImporteEstudio
            ElseIf estado = "noEstaEnFacturacion" Then
                cLinea.importe = vEstudio.ImportePorObraSocial
            End If
            vEstudio.cargarMedicacion()
            cLinea.pension = vEstudio.pension
            cLinea.diferenciaPaciente = vEstudio.DiferenciaPaciente
            cLinea.estado = estado
            lineasDeFacturacionDeEstudios.Add(cLinea)

            Me.total += cLinea.getImporteNeto
        Next
    End Function

End Class
