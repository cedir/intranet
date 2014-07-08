Imports CedirNegocios
Public Class FacturacionCobradaDetalle
    Inherits System.Windows.Forms.Form
    'Leer documentacion sobre el paso de una facturacion entre formularios
    Dim cPresentacion As Presentacion
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByRef facturacion As Presentacion)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cPresentacion = facturacion
    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents DataGrid1 As wallyGrid
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblSubtipo As System.Windows.Forms.GroupBox
    Friend WithEvents lblNroFactura As System.Windows.Forms.Label
    Friend WithEvents lblResponsableTipo As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalConsultas As System.Windows.Forms.Label
    Friend WithEvents lblTotalEstudios As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFechaPago As System.Windows.Forms.Label
    Friend WithEvents lblNroRecibo As System.Windows.Forms.Label
    Friend WithEvents btnAgregarComprobante As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblGastos As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblSubtipo = New System.Windows.Forms.GroupBox
        Me.btnAgregarComprobante = New System.Windows.Forms.Button
        Me.lblNroFactura = New System.Windows.Forms.Label
        Me.lblResponsableTipo = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblIva = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblTotalConsultas = New System.Windows.Forms.Label
        Me.lblTotalEstudios = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblObraSocial = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblGastos = New System.Windows.Forms.Label
        Me.lblNroRecibo = New System.Windows.Forms.Label
        Me.lblFechaPago = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.lblSubtipo.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(24, 464)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(8, 32)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(720, 256)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(712, 230)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(688, 208)
        Me.DataGrid1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DataGrid1, "Haga Doble-Click con el mouse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para ver el detalle de medicacion")
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(128, 464)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cerrar"
        '
        'lblSubtipo
        '
        Me.lblSubtipo.Controls.Add(Me.btnAgregarComprobante)
        Me.lblSubtipo.Controls.Add(Me.lblNroFactura)
        Me.lblSubtipo.Controls.Add(Me.lblResponsableTipo)
        Me.lblSubtipo.Controls.Add(Me.lblFecha)
        Me.lblSubtipo.Controls.Add(Me.lblIva)
        Me.lblSubtipo.Location = New System.Drawing.Point(253, 296)
        Me.lblSubtipo.Name = "lblSubtipo"
        Me.lblSubtipo.Size = New System.Drawing.Size(237, 155)
        Me.lblSubtipo.TabIndex = 39
        Me.lblSubtipo.TabStop = False
        Me.lblSubtipo.Text = "Comprobante"
        '
        'btnAgregarComprobante
        '
        Me.btnAgregarComprobante.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarComprobante.Location = New System.Drawing.Point(65, 130)
        Me.btnAgregarComprobante.Name = "btnAgregarComprobante"
        Me.btnAgregarComprobante.Size = New System.Drawing.Size(91, 19)
        Me.btnAgregarComprobante.TabIndex = 42
        Me.btnAgregarComprobante.Text = "Agregar ND/NC"
        Me.btnAgregarComprobante.UseVisualStyleBackColor = True
        '
        'lblNroFactura
        '
        Me.lblNroFactura.Location = New System.Drawing.Point(16, 71)
        Me.lblNroFactura.Name = "lblNroFactura"
        Me.lblNroFactura.Size = New System.Drawing.Size(215, 23)
        Me.lblNroFactura.TabIndex = 2
        Me.lblNroFactura.Text = "NroFactura"
        '
        'lblResponsableTipo
        '
        Me.lblResponsableTipo.Location = New System.Drawing.Point(16, 45)
        Me.lblResponsableTipo.Name = "lblResponsableTipo"
        Me.lblResponsableTipo.Size = New System.Drawing.Size(215, 23)
        Me.lblResponsableTipo.TabIndex = 1
        Me.lblResponsableTipo.Text = "responsable - tipo"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(16, 17)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(215, 28)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "fecha"
        '
        'lblIva
        '
        Me.lblIva.Location = New System.Drawing.Point(16, 101)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(215, 21)
        Me.lblIva.TabIndex = 3
        Me.lblIva.Text = "Iva"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Controls.Add(Me.lblTotalConsultas)
        Me.GroupBox3.Controls.Add(Me.lblTotalEstudios)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(496, 296)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(228, 155)
        Me.GroupBox3.TabIndex = 38
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Totales"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblSubTotal.Location = New System.Drawing.Point(32, 88)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(144, 16)
        Me.lblSubTotal.TabIndex = 30
        Me.lblSubTotal.Text = "SubTotal"
        '
        'lblTotalConsultas
        '
        Me.lblTotalConsultas.Location = New System.Drawing.Point(32, 56)
        Me.lblTotalConsultas.Name = "lblTotalConsultas"
        Me.lblTotalConsultas.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalConsultas.TabIndex = 29
        Me.lblTotalConsultas.Text = "lblTotalConsultas"
        '
        'lblTotalEstudios
        '
        Me.lblTotalEstudios.Location = New System.Drawing.Point(32, 24)
        Me.lblTotalEstudios.Name = "lblTotalEstudios"
        Me.lblTotalEstudios.Size = New System.Drawing.Size(144, 23)
        Me.lblTotalEstudios.TabIndex = 23
        Me.lblTotalEstudios.Text = "TotalEstudios"
        '
        'lblTotal
        '
        Me.lblTotal.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblTotal.Location = New System.Drawing.Point(32, 120)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(144, 16)
        Me.lblTotal.TabIndex = 28
        Me.lblTotal.Text = "Total"
        '
        'lblObraSocial
        '
        Me.lblObraSocial.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblObraSocial.Location = New System.Drawing.Point(16, 8)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(632, 23)
        Me.lblObraSocial.TabIndex = 40
        Me.lblObraSocial.Text = "lblObraSocial"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblGastos)
        Me.GroupBox1.Controls.Add(Me.lblNroRecibo)
        Me.GroupBox1.Controls.Add(Me.lblFechaPago)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 155)
        Me.GroupBox1.TabIndex = 41
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle de Pago"
        '
        'lblGastos
        '
        Me.lblGastos.Location = New System.Drawing.Point(8, 88)
        Me.lblGastos.Name = "lblGastos"
        Me.lblGastos.Size = New System.Drawing.Size(176, 23)
        Me.lblGastos.TabIndex = 2
        Me.lblGastos.Text = "Gastos Administrativos:"
        '
        'lblNroRecibo
        '
        Me.lblNroRecibo.Location = New System.Drawing.Point(16, 56)
        Me.lblNroRecibo.Name = "lblNroRecibo"
        Me.lblNroRecibo.Size = New System.Drawing.Size(168, 23)
        Me.lblNroRecibo.TabIndex = 1
        Me.lblNroRecibo.Text = "Nro de recibo:"
        '
        'lblFechaPago
        '
        Me.lblFechaPago.Location = New System.Drawing.Point(16, 24)
        Me.lblFechaPago.Name = "lblFechaPago"
        Me.lblFechaPago.Size = New System.Drawing.Size(168, 23)
        Me.lblFechaPago.TabIndex = 0
        Me.lblFechaPago.Text = "Fecha:"
        '
        'FacturacionCobradaDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 496)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblObraSocial)
        Me.Controls.Add(Me.lblSubtipo)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "FacturacionCobradaDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Cobro de Presentación"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.lblSubtipo.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim catalogoFacturaciones As New CatalogoDePresentaciones
    Dim catalogoDeFacturaciones As New CatalogoDePresentaciones
    Dim myTable As DataTable = New DataTable("myTable")
    'Dim tableConsultas As DataTable = New DataTable("consultas")
    Private Sub FacturacionCobradaDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' cFacturacion = catalogoDeFacturaciones.find(cIdFacturacion)
        Dim clIdEstudio As DataColumn = New DataColumn("IdEstudio", Type.GetType("System.String"))
        Dim clFecha As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clnroAfiliado As DataColumn = New DataColumn("Nro Afiliado", Type.GetType("System.String"))
        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Actuante", Type.GetType("System.String"))
        Dim clImporteProOS As DataColumn = New DataColumn("Importe", Type.GetType("System.String"))
        Dim clImporteMedicacion As DataColumn = New DataColumn("Medicacion", Type.GetType("System.String"))
        Dim clImportePension As DataColumn = New DataColumn("Pensión", Type.GetType("System.String"))
        Dim clImporteAnestesia As DataColumn = New DataColumn("Anestesia", Type.GetType("System.String"))
        myTable.Columns.Add(clIdEstudio)
        myTable.Columns.Add(clFecha)
        myTable.Columns.Add(clnroAfiliado)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clImporteProOS)
        myTable.Columns.Add(clImportePension)
        myTable.Columns.Add(clImporteMedicacion)
        myTable.Columns.Add(clImporteAnestesia)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "myTable"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple


        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "IdEstudio"
        TextCol0.HeaderText = "IDEstudio"
        TextCol0.Width = 20
        ts1.GridColumnStyles.Add(TextCol0)
        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Fecha"
        TextCol2.HeaderText = "Fecha"
        TextCol2.Width = 65
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Nro Afiliado"
        TextCol4.HeaderText = "Nro Afiliado"
        TextCol4.Width = 65
        ts1.GridColumnStyles.Add(TextCol4)
        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "Paciente"
        TextCol5.HeaderText = "Paciente"
        TextCol5.Width = 95
        ts1.GridColumnStyles.Add(TextCol5)
        Dim TextCol6 As New DataGridTextBoxColumn
        TextCol6.MappingName = "Práctica"
        TextCol6.HeaderText = "Práctica"
        TextCol6.Width = 180
        ts1.GridColumnStyles.Add(TextCol6)
        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "Actuante"
        TextCol7.HeaderText = "Actuante"
        TextCol7.Width = 95
        ts1.GridColumnStyles.Add(TextCol7)
        Dim TextCol8 As New DataGridTextBoxColumn
        TextCol8.MappingName = "Importe"
        TextCol8.HeaderText = "Importe"
        TextCol8.Width = 43
        ts1.GridColumnStyles.Add(TextCol8)
        Dim TextCol9 As New DataGridTextBoxColumn
        TextCol9.MappingName = "Pensión"
        TextCol9.HeaderText = "Pensión"
        TextCol9.Width = 46
        ts1.GridColumnStyles.Add(TextCol9)
        Dim TextCol11 As New DataGridTextBoxColumn
        TextCol11.MappingName = "Medicacion"
        TextCol11.HeaderText = "Medicacion"
        TextCol11.Width = 40
        ts1.GridColumnStyles.Add(TextCol11)

        Dim TextCol12 As New DataGridTextBoxColumn
        TextCol12.MappingName = "Anestesia"
        TextCol12.HeaderText = "Anestesia"
        TextCol12.Width = 45
        ts1.GridColumnStyles.Add(TextCol12)

        DataGrid1.TableStyles.Add(ts1)



        lblObraSocial.Text = cPresentacion.obraSocial.ObraSocial
        lblFecha.Text = "Fecha: " & cPresentacion.fechaFacturacion & ",     " & cPresentacion.comprobante.TipoComprobante.Descripcion & "  Tipo : " & cPresentacion.comprobante.SubTipo
        lblResponsableTipo.Text = "Responsable: " & cPresentacion.comprobante.Responsable
        lblIva.Text = "Iva: " & cPresentacion.comprobante.Gravado.porcentaje & "%"
        lblNroFactura.Text = "Comprobante nro:     00" & cPresentacion.comprobante.NroTerminal & _
        " -  " & cPresentacion.comprobante.NroComprobante.ToString()


        Dim cPagoFacturacion As PagoFacturacion = cPresentacion.getPago
        lblFechaPago.Text = "Fecha del pago: " & CStr(cPagoFacturacion.fecha)
        lblNroRecibo.Text = "Nro de recibo: " & cPagoFacturacion.nroDeRecibo
        lblGastos.Text = "Gastos Administrativos: " & CStr(cPagoFacturacion.gastoAdministrativo) & " %"
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()

        cPresentacion.cargarFacturacion()

        Dim cLineaEstudio As LineaDeFacturacion
        Dim NewRow As DataRow
        Dim i As Integer

        'Estudios
        Dim totEstudios As Single = 0
        Dim arrLineasEstudios As ArrayList
        arrLineasEstudios = cPresentacion.getLineasDeFacturacionEstudios()
        myTable.Clear()
        For i = 0 To arrLineasEstudios.Count - 1
            cLineaEstudio = arrLineasEstudios(i)
            NewRow = myTable.NewRow()
            NewRow("IdEstudio") = cLineaEstudio.estudio.nroestudio
            NewRow("Fecha") = cLineaEstudio.estudio.fechaEstudio
            NewRow("Paciente") = cLineaEstudio.estudio.paciente.apellido & ", " & cLineaEstudio.estudio.paciente.nombres
            NewRow("Práctica") = cLineaEstudio.estudio.practica.Estudio
            NewRow("Actuante") = cLineaEstudio.estudio.medicoActuante.apellido & ", " & cLineaEstudio.estudio.medicoActuante.nombre
            If cLineaEstudio.estudio.importeEstudioCobrado > 0 Then
                NewRow("Importe") = cLineaEstudio.estudio.importeEstudioCobrado
            Else
                NewRow("Importe") = cLineaEstudio.importe
            End If
            If cLineaEstudio.estudio.importeCobradoPension > 0 Then
                NewRow("Pensión") = cLineaEstudio.estudio.importeCobradoPension
            Else
                NewRow("Pensión") = cLineaEstudio.pension
            End If


            NewRow("Nro Afiliado") = cLineaEstudio.estudio.paciente.nroAfiliado
            If cLineaEstudio.estudio.ImporteCobradoMedicacion > 0 Then
                NewRow("Medicacion") = cLineaEstudio.estudio.ImporteCobradoMedicacion
            Else
                NewRow("Medicacion") = cLineaEstudio.estudio.ImporteMedicacion
            End If

            NewRow("Anestesia") = cLineaEstudio.estudio.importeCobradoArancelAnestesia
            myTable.Rows.Add(NewRow)
            totEstudios += Convert.ToDecimal(NewRow("Importe")) + Convert.ToDecimal(NewRow("Pensión")) + Convert.ToDecimal(NewRow("Medicacion")) + Convert.ToDecimal(NewRow("Anestesia")) - cLineaEstudio.estudio.DiferenciaPaciente

        Next


        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable


        'Si no hay estudios, sa carga la solapa consultas
        If arrLineasEstudios.Count = 0 Then
            TabControl1.SelectedIndex = 1
        End If

        Dim subTotal As Single = totEstudios '+ totConsultas
        lblTotalEstudios.Text = "Estudios: $ " & Str(totEstudios)
        ' lblTotalConsultas.Text = "Consultas: $ " & Str(totConsultas)
        lblSubTotal.Text = "Subtotal: $ " & Str(subTotal)
        lblTotal.Text = "Total: $ " & Str(subTotal)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'Imprimir estudios
        Dim arrWidth(9) As Single
        arrWidth(0) = 80
        arrWidth(1) = 30
        arrWidth(2) = 95
        arrWidth(3) = 140
        arrWidth(4) = 95
        arrWidth(5) = 52
        arrWidth(6) = 52
        arrWidth(7) = 50
        arrWidth(8) = 50
        DataGrid1.columnsWidth = arrWidth
        Dim arrColumnsNotToPrint(0) As Integer
        arrColumnsNotToPrint(0) = 1
        DataGrid1.columnNotToPrintIndexes = arrColumnsNotToPrint
        DataGrid1.imprimirTitle = "Obra Social: " & cPresentacion.obraSocial.ObraSocial
        DataGrid1.imprimirSubTitleSuperior1 = "Detalle de Facturación Cobrada, mes de " & cPresentacion.periodo
        DataGrid1.imprimirSubTitleSuperior2 = "Fecha de facturación: " & cPresentacion.fechaFacturacion & " - " & lblFechaPago.Text
        DataGrid1.imprimirSubTitleSuperior3 = "Estudios"
        DataGrid1.imprimirShowPrintDialog = True

        DataGrid1.imprimirSubTitleInferior1 = "Total: $ " & CStr(cPresentacion.total)
        DataGrid1.imprimirSubTitleInferior2 = lblNroRecibo.Text & " - " & lblGastos.Text

        DataGrid1.imprimir(cPresentacion.getLineasDeFacturacionEstudios.Count, 9)


    End Sub


    Private Sub btnAgregarComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarComprobante.Click
        If cPresentacion.comprobante.Estado.ToUpper() <> "ANULADO" And cPresentacion.comprobante.TipoComprobante.Id = 1 Then
            Dim f As New frmComprobanteNuevo
            Me.AddOwnedForm(f)
            'el comprobante que pasamos es una factura.
            f.Comprobante = cPresentacion.comprobante
            'ahora seteamos el domicilio de manera completa.(esto es para presentaciones que no se hayan seteado de esta manera en NuevaPresentacion)
            f.Comprobante.DomicilioCliente = Me.cPresentacion.obraSocial.direccion & " - " & Me.cPresentacion.obraSocial.localidad & " - " & "(CP:" & Me.cPresentacion.obraSocial.CodigoPostal.ToString() & ")"
            f.setComprobante()
            f.ShowDialog()
        Else
            MessageBox.Show("No se pueden crear nc o nd a " & vbCrLf & "liquidaciones o comprobantes anulados", "Atención")
        End If
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim i As Integer

        i = DataGrid1.CurrentRowIndex
        If i = -1 Then
            MsgBox("No se ha seleccionado ningún estudio", MsgBoxStyle.Critical)
        Else
            Dim est As Estudio
            est = cPresentacion.getLineasDeFacturacionEstudios(i).estudio
            Dim frm As New AgragarMedicacion(est, False)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        End If

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
