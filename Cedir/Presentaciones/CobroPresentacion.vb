Imports CedirNegocios
Public Class CobroPresentacion
    Inherits System.Windows.Forms.Form
    Dim cIdFacturacion As Integer
    Friend WithEvents lblAlertaAmrChica As System.Windows.Forms.Label
    Friend WithEvents lblSubtipo As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Dim cPresentacion As Presentacion
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal idFacturacion As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cIdFacturacion = idFacturacion
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
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnRefacturar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAplicarPorcentaje As System.Windows.Forms.Button
    Friend WithEvents txtPorcentaje As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalEstudios As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents txtNroRecivo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtGasto As System.Windows.Forms.TextBox
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DataGrid2 As wallyGrid
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblResponsableTipo As System.Windows.Forms.Label
    Friend WithEvents lblNroFactura As System.Windows.Forms.Label
    Friend WithEvents lblIva As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalConsultas As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnCancelar = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnRefacturar = New System.Windows.Forms.Button
        Me.lblTotalEstudios = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnAplicarPorcentaje = New System.Windows.Forms.Button
        Me.txtPorcentaje = New System.Windows.Forms.TextBox
        Me.lblTotal = New System.Windows.Forms.Label
        Me.txtNroRecivo = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblTotalConsultas = New System.Windows.Forms.Label
        Me.txtGasto = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblObraSocial = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.DataGrid2 = New Cedir.wallyGrid
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblSubtipo = New System.Windows.Forms.Label
        Me.lblNroFactura = New System.Windows.Forms.Label
        Me.lblResponsableTipo = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblIva = New System.Windows.Forms.Label
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.lblAlertaAmrChica = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(456, 432)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(72, 24)
        Me.btnCancelar.TabIndex = 16
        Me.btnCancelar.Text = "Cerrar"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(280, 432)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 24)
        Me.btnAceptar.TabIndex = 15
        Me.btnAceptar.Text = "Cobrar"
        '
        'btnRefacturar
        '
        Me.btnRefacturar.Location = New System.Drawing.Point(656, 8)
        Me.btnRefacturar.Name = "btnRefacturar"
        Me.btnRefacturar.Size = New System.Drawing.Size(72, 24)
        Me.btnRefacturar.TabIndex = 20
        Me.btnRefacturar.Text = "Refacturar"
        '
        'lblTotalEstudios
        '
        Me.lblTotalEstudios.Location = New System.Drawing.Point(32, 24)
        Me.lblTotalEstudios.Name = "lblTotalEstudios"
        Me.lblTotalEstudios.Size = New System.Drawing.Size(144, 23)
        Me.lblTotalEstudios.TabIndex = 23
        Me.lblTotalEstudios.Text = "TotalEstudios"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.btnAplicarPorcentaje)
        Me.GroupBox1.Controls.Add(Me.txtPorcentaje)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 280)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(248, 56)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Porcentaje descontado"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(74, 27)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "%"
        '
        'btnAplicarPorcentaje
        '
        Me.btnAplicarPorcentaje.Location = New System.Drawing.Point(104, 24)
        Me.btnAplicarPorcentaje.Name = "btnAplicarPorcentaje"
        Me.btnAplicarPorcentaje.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarPorcentaje.TabIndex = 1
        Me.btnAplicarPorcentaje.Text = "Aplicar"
        '
        'txtPorcentaje
        '
        Me.txtPorcentaje.Location = New System.Drawing.Point(16, 24)
        Me.txtPorcentaje.Name = "txtPorcentaje"
        Me.txtPorcentaje.Size = New System.Drawing.Size(48, 20)
        Me.txtPorcentaje.TabIndex = 0
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
        'txtNroRecivo
        '
        Me.txtNroRecivo.Location = New System.Drawing.Point(128, 24)
        Me.txtNroRecivo.Name = "txtNroRecivo"
        Me.txtNroRecivo.Size = New System.Drawing.Size(100, 20)
        Me.txtNroRecivo.TabIndex = 29
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(51, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Nro de recibo:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Controls.Add(Me.lblTotalConsultas)
        Me.GroupBox3.Controls.Add(Me.lblTotalEstudios)
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Location = New System.Drawing.Point(536, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 152)
        Me.GroupBox3.TabIndex = 31
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
        Me.lblTotalConsultas.Size = New System.Drawing.Size(144, 23)
        Me.lblTotalConsultas.TabIndex = 29
        Me.lblTotalConsultas.Text = "lblTotalConsultas"
        '
        'txtGasto
        '
        Me.txtGasto.Location = New System.Drawing.Point(128, 48)
        Me.txtGasto.Name = "txtGasto"
        Me.txtGasto.Size = New System.Drawing.Size(48, 20)
        Me.txtGasto.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Retención Impositiva:"
        '
        'lblObraSocial
        '
        Me.lblObraSocial.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblObraSocial.Location = New System.Drawing.Point(16, 8)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(448, 23)
        Me.lblObraSocial.TabIndex = 35
        Me.lblObraSocial.Text = "OS"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 232)
        Me.TabControl1.TabIndex = 36
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(720, 206)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudios"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(704, 192)
        Me.DataGrid1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DataGrid1, "Haga Doble-Click con el mouse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para ver el detalle de medicacion")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DataGrid2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(720, 206)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Consultas"
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(16, 8)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(528, 192)
        Me.DataGrid2.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSubtipo)
        Me.GroupBox2.Controls.Add(Me.lblNroFactura)
        Me.GroupBox2.Controls.Add(Me.lblResponsableTipo)
        Me.GroupBox2.Controls.Add(Me.lblFecha)
        Me.GroupBox2.Controls.Add(Me.lblIva)
        Me.GroupBox2.Location = New System.Drawing.Point(296, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 144)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comprobante"
        '
        'lblSubtipo
        '
        Me.lblSubtipo.Location = New System.Drawing.Point(16, 75)
        Me.lblSubtipo.Name = "lblSubtipo"
        Me.lblSubtipo.Size = New System.Drawing.Size(176, 23)
        Me.lblSubtipo.TabIndex = 4
        Me.lblSubtipo.Text = "subtipo"
        '
        'lblNroFactura
        '
        Me.lblNroFactura.Location = New System.Drawing.Point(16, 98)
        Me.lblNroFactura.Name = "lblNroFactura"
        Me.lblNroFactura.Size = New System.Drawing.Size(168, 23)
        Me.lblNroFactura.TabIndex = 2
        Me.lblNroFactura.Text = "NroComprobante"
        '
        'lblResponsableTipo
        '
        Me.lblResponsableTipo.Location = New System.Drawing.Point(16, 50)
        Me.lblResponsableTipo.Name = "lblResponsableTipo"
        Me.lblResponsableTipo.Size = New System.Drawing.Size(176, 23)
        Me.lblResponsableTipo.TabIndex = 1
        Me.lblResponsableTipo.Text = "responsable - tipo"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(16, 24)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(100, 23)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "fecha"
        '
        'lblIva
        '
        Me.lblIva.Location = New System.Drawing.Point(16, 122)
        Me.lblIva.Name = "lblIva"
        Me.lblIva.Size = New System.Drawing.Size(120, 16)
        Me.lblIva.TabIndex = 3
        Me.lblIva.Text = "Iva"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.txtNroRecivo)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtGasto)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Location = New System.Drawing.Point(16, 344)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(248, 80)
        Me.GroupBox4.TabIndex = 38
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Detalle de Pago"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(184, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 16)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "%"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(368, 432)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 39
        Me.btnImprimir.Text = "Imprimir"
        '
        'lblAlertaAmrChica
        '
        Me.lblAlertaAmrChica.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.lblAlertaAmrChica.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAlertaAmrChica.ForeColor = System.Drawing.Color.Black
        Me.lblAlertaAmrChica.Location = New System.Drawing.Point(16, 428)
        Me.lblAlertaAmrChica.Name = "lblAlertaAmrChica"
        Me.lblAlertaAmrChica.Size = New System.Drawing.Size(240, 40)
        Me.lblAlertaAmrChica.TabIndex = 41
        Me.lblAlertaAmrChica.Text = "Descuento amr"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'CobroPresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(750, 472)
        Me.Controls.Add(Me.lblAlertaAmrChica)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.lblObraSocial)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefacturar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "CobroPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cobro de Presentación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim catalogoDeFacturaciones As New CatalogoDePresentaciones
    Dim myTable As DataTable = New DataTable("myTable")
    Dim tableConsultas As DataTable = New DataTable("consultas")

    Private Sub BuscarFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cPresentacion = catalogoDeFacturaciones.find(cIdFacturacion)

        Dim clFecha As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clnroAfiliado As DataColumn = New DataColumn("Nro Afiliado", Type.GetType("System.String"))
        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Actuante", Type.GetType("System.String"))
        Dim clImporteProOS As DataColumn = New DataColumn("Importe", Type.GetType("System.String"))
        Dim clImporteMedicacion As DataColumn = New DataColumn("Medicacion", Type.GetType("System.String"))
        Dim clImportePension As DataColumn = New DataColumn("Pensión", Type.GetType("System.String"))
        Dim clImporteAnestesia As DataColumn = New DataColumn("Anestesia", Type.GetType("System.String"))

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
        TextCol12.Width = 40
        ts1.GridColumnStyles.Add(TextCol12)
        DataGrid1.TableStyles.Add(ts1)

        'Consultas
        Dim clFechaCon As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clCantidadCon As DataColumn = New DataColumn("Cantidad", Type.GetType("System.String"))
        Dim clnroAfiliadoCon As DataColumn = New DataColumn("Nro Afiliado", Type.GetType("System.String"))
        Dim clNombrePacienteCon As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clImporteProOSCon As DataColumn = New DataColumn("Importe", Type.GetType("System.String"))
        tableConsultas.Columns.Add(clFechaCon)
        tableConsultas.Columns.Add(clCantidadCon)
        tableConsultas.Columns.Add(clnroAfiliadoCon)
        tableConsultas.Columns.Add(clNombrePacienteCon)
        tableConsultas.Columns.Add(clImporteProOSCon)
        Dim cTs1 As New DataGridTableStyle
        cTs1.MappingName = "consultas"
        cTs1.BackColor = Color.LightGray
        cTs1.ForeColor = Color.SlateBlue
        cTs1.AlternatingBackColor = Color.White
        cTs1.AllowSorting = False

        cTs1.HeaderForeColor = Color.MediumSlateBlue
        cTs1.HeaderBackColor = Color.WhiteSmoke
        cTs1.GridLineColor = Color.MediumPurple

        Dim cTextCol2 As New DataGridTextBoxColumn
        cTextCol2.MappingName = "Fecha"
        cTextCol2.HeaderText = "Fecha"
        cTextCol2.Width = 65
        cTs1.GridColumnStyles.Add(cTextCol2)
        Dim cTextCol3 As New DataGridTextBoxColumn
        cTextCol3.MappingName = "Cantidad"
        cTextCol3.HeaderText = "Cantidad"
        cTextCol3.Width = 60
        cTs1.GridColumnStyles.Add(cTextCol3)
        Dim cTextCol5 As New DataGridTextBoxColumn
        cTextCol5.MappingName = "Nro Afiliado"
        cTextCol5.HeaderText = "Nro Afiliado"
        cTextCol5.Width = 75
        cTs1.GridColumnStyles.Add(cTextCol5)
        Dim cTextCol6 As New DataGridTextBoxColumn
        cTextCol6.MappingName = "Paciente"
        cTextCol6.HeaderText = "Paciente"
        cTextCol6.Width = 230
        cTs1.GridColumnStyles.Add(cTextCol6)

        Dim cTextCol7 As New DataGridTextBoxColumn
        cTextCol7.MappingName = "Importe"
        cTextCol7.HeaderText = "Importe"
        cTextCol7.Width = 45
        cTs1.GridColumnStyles.Add(cTextCol7)

        Dim TextCol18 As New DataGridTextBoxColumn
        TextCol18.MappingName = "AnestesiaConsulta"
        TextCol18.HeaderText = "AnestesiaConsulta"
        TextCol18.Width = 45
        ts1.GridColumnStyles.Add(TextCol18)
        DataGrid2.TableStyles.Add(cTs1)

        lblObraSocial.Text = cPresentacion.obraSocial.ObraSocial
        lblFecha.Text = "Fecha: " & cPresentacion.fechaFacturacion


        lblResponsableTipo.Text = "Responsable: " & cPresentacion.comprobante.Responsable & " - " & cPresentacion.comprobante.TipoComprobante.Descripcion
        If cPresentacion.comprobante.Gravado IsNot Nothing Then
            lblIva.Text = "Iva: " & cPresentacion.comprobante.Gravado.porcentaje.ToString & "%"
        Else
            lblIva.Text = "Iva:  %"
        End If

        lblNroFactura.Text = "Comprobante nro: " & cPresentacion.comprobante.NroComprobante.ToString()
        Me.lblSubtipo.Text = cPresentacion.comprobante.SubTipo

        btnImprimir.Enabled = False

        txtGasto.Text = cPresentacion.getPorcentajeGtosAdmin().ToString

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
            NewRow("Fecha") = cLineaEstudio.objeto.fechaEstudio
            NewRow("Paciente") = cLineaEstudio.objeto.paciente.apellido & ", " & cLineaEstudio.objeto.paciente.nombres
            NewRow("Práctica") = cLineaEstudio.objeto.practica.Estudio
            NewRow("Actuante") = cLineaEstudio.objeto.medicoActuante.apellido & ", " & cLineaEstudio.objeto.medicoActuante.nombre
            NewRow("Importe") = cLineaEstudio.importe - cLineaEstudio.diferenciaPaciente
            NewRow("Nro Afiliado") = cLineaEstudio.objeto.paciente.nroAfiliado
            NewRow("Pensión") = cLineaEstudio.pension
            Dim totalParcialMedicacion As Single = cLineaEstudio.objeto.getTotalMedicacion
            NewRow("Medicacion") = totalParcialMedicacion
            NewRow("Anestesia") = cLineaEstudio.objeto.ArancelAnestesia
            myTable.Rows.Add(NewRow)
            totEstudios += cLineaEstudio.importe - cLineaEstudio.diferenciaPaciente + cLineaEstudio.pension + totalParcialMedicacion + cLineaEstudio.objeto.ArancelAnestesia
        Next
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable

    

        'Si no hay estudios, sa carga la solapa consultas
        If arrLineasEstudios.Count = 0 Then
            TabControl1.SelectedIndex = 1
        End If
        Dim subTotal As Single = totEstudios '+ totConsultas
        lblTotalEstudios.Text = "Estudios: $ " & Str(totEstudios)
        'lblTotalConsultas.Text = "Consultas: $ " & Str(totConsultas)
        lblSubTotal.Text = "Subtotal: $ " & Str(subTotal)
        lblTotal.Text = "Total: $ " & Str(subTotal)
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim r As Integer
        calcularTotal()
        Dim gastoAdministrativo As Single
        r = MsgBox("¿Desea dar como cobrada la correspondiente facturación?", MsgBoxStyle.YesNo, "Cobro de facturación")
        If r = 6 Then
            Dim i As Integer = 0
            Dim cLinea As LineaDeFacturacion
            'estudios
            While (i < cPresentacion.getLineasDeFacturacionEstudios.Count)
                cLinea = cPresentacion.getLineasDeFacturacionEstudios(i)
                cLinea.objeto.importeEstudioCobrado = CSng(DataGrid1.Item(i, 5))
                cLinea.objeto.importeCobradoPension = CSng(DataGrid1.Item(i, 6))
                cLinea.objeto.ImporteCobradoMedicacion = CSng(DataGrid1.Item(i, 7))
                cLinea.objeto.importeCobradoArancelAnestesia = CSng(DataGrid1.Item(i, 8))
                i += 1
            End While
           

            'Si bien guardamos el porcentaje correspondiente en la presentacion, esto es deditable. Entonces aca
            'vamos a tomar lo que haya puesto el usuario
            If txtGasto.Text = "" Then
                gastoAdministrativo = 0
            Else
                gastoAdministrativo = CSng(txtGasto.Text)
            End If

            cPresentacion.realizarCobro(txtNroRecivo.Text, gastoAdministrativo)
            'cambiamos el estado del comprobante 
            cPresentacion.comprobante.cambiarEstado("COBRADO")
            'uso esta variable para mostrarlo en un msg:
            Dim diferencia As Decimal = cPresentacion.calcularComprobanteTotalCobrado()

            If "ok" = "ok" Then
                MsgBox("Se han guardado los cambios")
                actualizarListadoFacturaciones = True
                btnAceptar.Enabled = False
                btnRefacturar.Enabled = False
                btnImprimir.Enabled = True
                DataGrid1.Enabled = False
                DataGrid2.Enabled = False
            End If

            'Ahora tenemos que crear una nota de debito o credito segun lo cobrado sea
            'menor o mayor al monto del comprobante asignado a la presentacion 
            'Solo creamos nc o nd para las Facturas, no las liquidaciones

            If cPresentacion.total <> cPresentacion.totalFacturado And cPresentacion.comprobante.TipoComprobante.Id = TComprobante.Factura Then
                'mostramos de cuánto debe ser el monto del comprobante(variable diferencia)
                Dim res As DialogResult = MessageBox.Show("Existe una diferencia de montos entre lo facturado y lo cobrado." & vbCrLf & "Deberá crear un comprobante correspondiente" & vbCrLf & "(ND) o (NC)", "Atención" & vbCrLf & "Diferencia de: $" & diferencia.ToString(), MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                If res = Windows.Forms.DialogResult.Yes Then
                    Dim f As New frmComprobanteNuevo
                    Me.AddOwnedForm(f)
                    'el comprobante que pasamos es una factura.
                    f.Comprobante = cPresentacion.comprobante
                    'ahora seteamos el domicilio de manera completa.(esto es para presentaciones que no se hayan seteado de esta manera en NuevaPresentacion)
                    f.Comprobante.DomicilioCliente = Me.cPresentacion.obraSocial.direccion & " - " & Me.cPresentacion.obraSocial.localidad & " - " & "(CP:" & Me.cPresentacion.obraSocial.CodigoPostal.ToString() & ")"
                    f.SetComprobante()
                    f.ShowDialog()
                End If
            End If
        End If
    End Sub

    Private Sub btnRefacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefacturar.Click

        Dim r As Integer = MsgBox("¿Desea quitar el estudio/consulta de la facturación? Si confirma, el estudio pasara a estar en Nueva Facturación.", MsgBoxStyle.YesNo, "Refacturar")
        If r = 6 Then
            Dim i As Integer
            Dim cLinea As LineaDeFacturacion
            Dim success As Boolean
            If TabControl1.SelectedIndex = 0 Then
                'quitar estudio
                i = DataGrid1.CurrentRowIndex
                If i = -1 Then
                    MsgBox("No se ha seleccionado ningún estudio", MsgBoxStyle.Critical)
                Else
                    cLinea = cPresentacion.getLineasDeFacturacionEstudios(i)
                    success = cPresentacion.quitarLineaDeEstudios(i)
                    If success Then
                        myTable.Rows(i).Delete()
                        myTable.AcceptChanges()
                        DataGrid1.DataSource = myTable
                    Else
                        MsgBox("Se ha producido un error al intentar quitar el estudio. Vuelva a intentarlo.")
                    End If
                End If


            End If

            calcularTotal()
        End If

    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.Close()
    End Sub

    Private Sub btnAplicarPorcentaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarPorcentaje.Click
        If txtPorcentaje.Text = "" Then
            MsgBox("Debe completar con un porcentaje numérico")
        Else
            calcularPorcentaje(txtPorcentaje.Text)
        End If
    End Sub
    Function calcularPorcentaje(ByVal porcentaje As String)
        Dim i As Integer = 0
        Dim porc As Single = Math.Round(CSng(porcentaje), 2)

        Dim importeEstudio As Single
        Dim importePension As Single
        Dim importeMedicacion As Single
        Dim importeAnestesia As Decimal
        While i < cPresentacion.getLineasDeFacturacionEstudios.Count
            importeEstudio = CSng(DataGrid1.Item(i, 5))
            importePension = CSng(DataGrid1.Item(i, 6))
            importeMedicacion = CSng(DataGrid1.Item(i, 7))
            importeAnestesia = Convert.ToDecimal(DataGrid1.Item(i, 8))
            DataGrid1.Item(i, 5) = importeEstudio - (importeEstudio * porc / 100)
            DataGrid1.Item(i, 6) = importePension - (importePension * porc / 100)
            DataGrid1.Item(i, 8) = importeAnestesia - (importeAnestesia * porc / 100)
            DataGrid1.Item(i, 7) = importeMedicacion - (importeMedicacion * porc / 100)
            i += 1
        End While

        Dim importeConsulta As Single
        i = 0
        'While i < cPresentacion.getLineasDeFacturacionConsultas.Count
        '    importeConsulta = CSng(DataGrid2.Item(i, 4))
        '    DataGrid2.Item(i, 4) = importeConsulta - (importeConsulta * porc / 100)
        '    i += 1
        'End While


        calcularTotal()

        MsgBox("Se aplicó un " + porcentaje + "% de porcentaje descontado")
        lblAlertaAmrChica.Visible = True
        btnAplicarPorcentaje.Enabled = False
        lblAlertaAmrChica.Text = "Se aplicó un " + porcentaje + "% de porcentaje descontado"

    End Function
    Private Sub calcularTotal()
        Dim i As Integer = 0
        Dim totEstudios As Single = 0
        Dim totMedicacion As Single = 0
        Dim totPension As Single = 0
        Dim totConsultas As Single = 0
        Dim totAnestesia As Decimal = 0

        While i < cPresentacion.getLineasDeFacturacionEstudios.Count
            totEstudios += CSng(DataGrid1.Item(i, 5))
            totMedicacion += CSng(DataGrid1.Item(i, 6))
            totPension += CSng(DataGrid1.Item(i, 7))
            totAnestesia += Convert.ToDecimal(DataGrid1.Item(i, 8))
            i += 1
        End While

        i = 0
        'While i < cPresentacion.getLineasDeFacturacionConsultas.Count
        '    totConsultas += CSng(DataGrid2.Item(i, 4))
        '    i += 1
        'End While

        Dim total As Single
        Dim totalParcialEstudios As Single = totEstudios + totMedicacion + totPension + totAnestesia
        Dim subTotal As Single = totalParcialEstudios + totConsultas
        total = subTotal

        lblTotalEstudios.Text = "Estudios: $ " & Str(totalParcialEstudios)
        lblTotalConsultas.Text = "Consultas: $ " & Str(totConsultas)
        lblSubTotal.Text = "Subtotal: $ " & Str(subTotal)
        lblTotal.Text = "Total: $ " & Str(total)
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        calcularTotal()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If cPresentacion.getLineasDeFacturacionEstudios.Count = 0 Then
            Exit Sub
        Else
            'Imprimir estudios
            Dim arrWidth(7) As Single
            arrWidth(0) = 80
            arrWidth(1) = 80
            arrWidth(2) = 95
            arrWidth(3) = 180
            arrWidth(4) = 95
            arrWidth(5) = 52
            arrWidth(6) = 52
            arrWidth(7) = 50
            DataGrid1.columnsWidth = arrWidth
            DataGrid1.imprimirTitle = "Obra Social: " & cPresentacion.obraSocial.ObraSocial
            DataGrid1.imprimirSubTitleSuperior1 = "Detalle de nuevo Cobro de Facturación, mes de " & cPresentacion.periodo
            DataGrid1.imprimirSubTitleSuperior2 = "Fecha de facturación: " & cPresentacion.fechaFacturacion & " - Fecha de cobro: " & Today
            DataGrid1.imprimirSubTitleSuperior3 = "Estudios"
            DataGrid1.imprimirShowPrintDialog = True
            DataGrid1.imprimirSubTitleInferior1 = "Total: $ " & CStr(cPresentacion.total)
            DataGrid1.imprimirSubTitleInferior2 = "Nro de recibo: " & txtNroRecivo.Text & " - Gastos Administrativos: " & txtGasto.Text & " %"
            DataGrid1.imprimir(cPresentacion.getLineasDeFacturacionEstudios.Count, 8)

          

        End If
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        If i = -1 Then
            MsgBox("No se ha seleccionado ningún estudio", MsgBoxStyle.Critical)
        Else
            Dim est As Estudio
            est = cPresentacion.getLineasDeFacturacionEstudios(i).objeto
            Dim frm As New AgragarMedicacion(est, False)
            'frm.MdiParent = Me.Parent.Parent
            frm.ShowDialog()
            Me.myTable.Rows(i).Item("Medicacion") = est.getTotalMedicacion()
        End If
        calcularTotal()
    End Sub
End Class