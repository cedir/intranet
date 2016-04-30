Imports System.Drawing.Printing
Imports CedirNegocios
Imports System.Collections.Generic
Imports System.ComponentModel

Public Class frmComprobanteNuevo
    Inherits System.Windows.Forms.Form
    Implements INotifyPropertyChanged

	Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblSubTipo As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvLineas As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotalSuma As System.Windows.Forms.Label
    Friend WithEvents chkLeyenda As System.Windows.Forms.CheckBox
    Friend WithEvents lblPacienteGravado As System.Windows.Forms.Label
    Friend WithEvents cmbGravadoPaciente As System.Windows.Forms.ComboBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents txtNroTerminal As System.Windows.Forms.TextBox
    Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents colConcepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporteNeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPorcIVA As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents colImporteIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FrmComprobanteNuevoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbSubTipo As System.Windows.Forms.ComboBox



#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent() 
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
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtNroIdentificacionCliente As System.Windows.Forms.TextBox
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCondicionFiscal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbResponsable As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents cmbIVA As System.Windows.Forms.ComboBox
    Friend WithEvents btnObraSocial As System.Windows.Forms.Button
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents btnPaciente As System.Windows.Forms.Button
    Friend WithEvents lblNroComprobante As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbTipoDocumento = New System.Windows.Forms.ComboBox
        Me.FrmComprobanteNuevoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPacienteGravado = New System.Windows.Forms.Label
        Me.cmbGravadoPaciente = New System.Windows.Forms.ComboBox
        Me.btnPaciente = New System.Windows.Forms.Button
        Me.txtNroIdentificacionCliente = New System.Windows.Forms.TextBox
        Me.txtDomicilio = New System.Windows.Forms.TextBox
        Me.btnObraSocial = New System.Windows.Forms.Button
        Me.cmbCondicionFiscal = New System.Windows.Forms.ComboBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblNroComprobante = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtNroTerminal = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSubTipo = New System.Windows.Forms.ComboBox
        Me.lblSubTipo = New System.Windows.Forms.Label
        Me.txtNroComprobante = New System.Windows.Forms.TextBox
        Me.cmbResponsable = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbIVA = New System.Windows.Forms.ComboBox
        Me.lblIVA = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvLineas = New System.Windows.Forms.DataGridView
        Me.colConcepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colImporteNeto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPorcIVA = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.colImporteIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSubtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblTotalSuma = New System.Windows.Forms.Label
        Me.chkLeyenda = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.FrmComprobanteNuevoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(946, 695)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 21)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.Visible = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(1108, 695)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(63, 21)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Cerrar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(441, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 21)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tipo:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox1.Controls.Add(Me.cmbTipoDocumento)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lblPacienteGravado)
        Me.GroupBox1.Controls.Add(Me.cmbGravadoPaciente)
        Me.GroupBox1.Controls.Add(Me.btnPaciente)
        Me.GroupBox1.Controls.Add(Me.txtNroIdentificacionCliente)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.btnObraSocial)
        Me.GroupBox1.Controls.Add(Me.cmbCondicionFiscal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 68)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1162, 214)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.DataBindings.Add(New System.Windows.Forms.Binding("Enabled", Me.FrmComprobanteNuevoBindingSource, "EsFacturaElectronica", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(114, 111)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(241, 21)
        Me.cmbTipoDocumento.TabIndex = 13
        '
        'FrmComprobanteNuevoBindingSource
        '
        Me.FrmComprobanteNuevoBindingSource.DataSource = Me
        Me.FrmComprobanteNuevoBindingSource.Position = 0
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(10, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 32)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Tipo de Documento:"
        '
        'lblPacienteGravado
        '
        Me.lblPacienteGravado.Location = New System.Drawing.Point(10, 168)
        Me.lblPacienteGravado.Name = "lblPacienteGravado"
        Me.lblPacienteGravado.Size = New System.Drawing.Size(99, 18)
        Me.lblPacienteGravado.TabIndex = 11
        Me.lblPacienteGravado.Text = "Paciente Gravado: "
        '
        'cmbGravadoPaciente
        '
        Me.cmbGravadoPaciente.FormattingEnabled = True
        Me.cmbGravadoPaciente.Items.AddRange(New Object() {"Gravado", "No Gravado"})
        Me.cmbGravadoPaciente.Location = New System.Drawing.Point(114, 165)
        Me.cmbGravadoPaciente.Name = "cmbGravadoPaciente"
        Me.cmbGravadoPaciente.Size = New System.Drawing.Size(241, 21)
        Me.cmbGravadoPaciente.TabIndex = 10
        '
        'btnPaciente
        '
        Me.btnPaciente.Location = New System.Drawing.Point(512, 67)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(77, 23)
        Me.btnPaciente.TabIndex = 9
        Me.btnPaciente.Text = "Paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'txtNroIdentificacionCliente
        '
        Me.txtNroIdentificacionCliente.Location = New System.Drawing.Point(114, 69)
        Me.txtNroIdentificacionCliente.Multiline = True
        Me.txtNroIdentificacionCliente.Name = "txtNroIdentificacionCliente"
        Me.txtNroIdentificacionCliente.Size = New System.Drawing.Size(392, 20)
        Me.txtNroIdentificacionCliente.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtNroIdentificacionCliente, "Cuando ingrese un paciente, por favor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ingrese:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OBRA SOCIAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Afiliado nro"" + NR" & _
                "O AFILIADO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "----------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cuando ingrese obra social" & _
                ", por favor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ingrese:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NRO CUIT")
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(114, 43)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(556, 20)
        Me.txtDomicilio.TabIndex = 7
        '
        'btnObraSocial
        '
        Me.btnObraSocial.Location = New System.Drawing.Point(595, 68)
        Me.btnObraSocial.Name = "btnObraSocial"
        Me.btnObraSocial.Size = New System.Drawing.Size(77, 23)
        Me.btnObraSocial.TabIndex = 6
        Me.btnObraSocial.Text = "Obra Social"
        '
        'cmbCondicionFiscal
        '
        Me.cmbCondicionFiscal.Location = New System.Drawing.Point(114, 138)
        Me.cmbCondicionFiscal.Name = "cmbCondicionFiscal"
        Me.cmbCondicionFiscal.Size = New System.Drawing.Size(241, 21)
        Me.cmbCondicionFiscal.TabIndex = 5
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(10, 141)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 23)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Condición Fiscal:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 20)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "DNI/CUIT:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(10, 46)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Domicilio:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(10, 17)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(114, 14)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(556, 20)
        Me.txtNombre.TabIndex = 0
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(498, 19)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(200, 21)
        Me.cmbTipoComprobante.TabIndex = 19
        Me.cmbTipoComprobante.Text = "Tipo comprobante"
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFecha.Location = New System.Drawing.Point(1104, 3)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(80, 16)
        Me.lblFecha.TabIndex = 20
        Me.lblFecha.Text = "Fecha"
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.Location = New System.Drawing.Point(353, 47)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.Size = New System.Drawing.Size(139, 20)
        Me.lblNroComprobante.TabIndex = 21
        Me.lblNroComprobante.Text = "Nro de Comprobante: "
        Me.lblNroComprobante.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.txtNroTerminal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbSubTipo)
        Me.GroupBox2.Controls.Add(Me.lblSubTipo)
        Me.GroupBox2.Controls.Add(Me.txtNroComprobante)
        Me.GroupBox2.Controls.Add(Me.cmbResponsable)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbIVA)
        Me.GroupBox2.Controls.Add(Me.lblIVA)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbTipoComprobante)
        Me.GroupBox2.Controls.Add(Me.lblNroComprobante)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 288)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1159, 107)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cabecera del Comprobante:"
        '
        'txtNroTerminal
        '
        Me.txtNroTerminal.Enabled = False
        Me.txtNroTerminal.Location = New System.Drawing.Point(498, 47)
        Me.txtNroTerminal.Name = "txtNroTerminal"
        Me.txtNroTerminal.ReadOnly = True
        Me.txtNroTerminal.Size = New System.Drawing.Size(200, 20)
        Me.txtNroTerminal.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(707, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(10, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "-"
        '
        'cmbSubTipo
        '
        Me.cmbSubTipo.FormattingEnabled = True
        Me.cmbSubTipo.Items.AddRange(New Object() {"A", "B"})
        Me.cmbSubTipo.Location = New System.Drawing.Point(810, 19)
        Me.cmbSubTipo.Name = "cmbSubTipo"
        Me.cmbSubTipo.Size = New System.Drawing.Size(117, 21)
        Me.cmbSubTipo.TabIndex = 29
        Me.cmbSubTipo.Text = "Seleccione sub-tipo"
        '
        'lblSubTipo
        '
        Me.lblSubTipo.AutoSize = True
        Me.lblSubTipo.Location = New System.Drawing.Point(723, 23)
        Me.lblSubTipo.Name = "lblSubTipo"
        Me.lblSubTipo.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTipo.TabIndex = 28
        Me.lblSubTipo.Text = "Sub-Tipo:"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(726, 47)
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.ReadOnly = True
        Me.txtNroComprobante.Size = New System.Drawing.Size(201, 20)
        Me.txtNroComprobante.TabIndex = 27
        Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmbResponsable
        '
        Me.cmbResponsable.Location = New System.Drawing.Point(112, 23)
        Me.cmbResponsable.Name = "cmbResponsable"
        Me.cmbResponsable.Size = New System.Drawing.Size(150, 21)
        Me.cmbResponsable.TabIndex = 26
        Me.cmbResponsable.Text = "Seleccione Empresa"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 18)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Responsable:"
        '
        'cmbIVA
        '
        Me.cmbIVA.Location = New System.Drawing.Point(112, 50)
        Me.cmbIVA.Name = "cmbIVA"
        Me.cmbIVA.Size = New System.Drawing.Size(121, 21)
        Me.cmbIVA.TabIndex = 24
        Me.cmbIVA.Text = "Seleccione IVA:"
        '
        'lblIVA
        '
        Me.lblIVA.Location = New System.Drawing.Point(20, 53)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(56, 23)
        Me.lblIVA.TabIndex = 23
        Me.lblIVA.Text = "IVA:"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.dgvLineas)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 401)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(1159, 169)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conceptos"
        '
        'dgvLineas
        '
        Me.dgvLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colConcepto, Me.colImporteNeto, Me.colPorcIVA, Me.colImporteIVA, Me.colSubtotal})
        Me.dgvLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLineas.Location = New System.Drawing.Point(3, 16)
        Me.dgvLineas.MultiSelect = False
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.RowTemplate.Height = 24
        Me.dgvLineas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLineas.Size = New System.Drawing.Size(1153, 150)
        Me.dgvLineas.TabIndex = 0
        '
        'colConcepto
        '
        Me.colConcepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colConcepto.FillWeight = 369.5432!
        Me.colConcepto.HeaderText = "CONCEPTO"
        Me.colConcepto.Name = "colConcepto"
        '
        'colImporteNeto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colImporteNeto.DefaultCellStyle = DataGridViewCellStyle1
        Me.colImporteNeto.HeaderText = "Importe Neto"
        Me.colImporteNeto.Name = "colImporteNeto"
        '
        'colPorcIVA
        '
        Me.colPorcIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.colPorcIVA.DataPropertyName = "id"
        Me.colPorcIVA.FillWeight = 10.15228!
        Me.colPorcIVA.HeaderText = "% IVA"
        Me.colPorcIVA.Name = "colPorcIVA"
        Me.colPorcIVA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.colPorcIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.colPorcIVA.Visible = False
        '
        'colImporteIVA
        '
        Me.colImporteIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colImporteIVA.FillWeight = 10.15228!
        Me.colImporteIVA.HeaderText = "ImporteIVA"
        Me.colImporteIVA.Name = "colImporteIVA"
        Me.colImporteIVA.ReadOnly = True
        Me.colImporteIVA.Width = 84
        '
        'colSubtotal
        '
        Me.colSubtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colSubtotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSubtotal.FillWeight = 10.15228!
        Me.colSubtotal.HeaderText = "SUBTOTAL"
        Me.colSubtotal.Name = "colSubtotal"
        Me.colSubtotal.Width = 89
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(1027, 695)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 21)
        Me.btnAceptar.TabIndex = 24
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(985, 637)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(114, 13)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "TOTAL ...................  : "
        '
        'lblTotalSuma
        '
        Me.lblTotalSuma.AutoSize = True
        Me.lblTotalSuma.Location = New System.Drawing.Point(1105, 643)
        Me.lblTotalSuma.Name = "lblTotalSuma"
        Me.lblTotalSuma.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalSuma.TabIndex = 26
        Me.lblTotalSuma.Text = "lblTotalSuma"
        '
        'chkLeyenda
        '
        Me.chkLeyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLeyenda.AutoSize = True
        Me.chkLeyenda.Location = New System.Drawing.Point(30, 668)
        Me.chkLeyenda.Name = "chkLeyenda"
        Me.chkLeyenda.Size = New System.Drawing.Size(144, 17)
        Me.chkLeyenda.TabIndex = 27
        Me.chkLeyenda.Text = "* Incluir leyenda opcional"
        Me.chkLeyenda.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'btnQuitar
        '
        Me.btnQuitar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnQuitar.Enabled = False
        Me.btnQuitar.Location = New System.Drawing.Point(30, 695)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(83, 21)
        Me.btnQuitar.TabIndex = 28
        Me.btnQuitar.Text = "Quitar Linea"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'frmComprobanteNuevo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1219, 741)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.chkLeyenda)
        Me.Controls.Add(Me.lblTotalSuma)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "frmComprobanteNuevo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Comprobante"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FrmComprobanteNuevoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Event PropertyChanged As PropertyChangedEventHandler _
    Implements INotifyPropertyChanged.PropertyChanged

    Private Sub NotifyPropertyChanged(ByVal info As String)
        RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(info))
    End Sub

    Private Sub OnPropertyChanged(ByVal sender As Object, ByVal args As PropertyChangedEventArgs) Handles Me.PropertyChanged
        If args.PropertyName = "EsFacturaElectronica" Then
            If Me.EsFacturaElectronica Then
                Me.CargarComboTipoIdentificacionCliente()
            Else
                Me.LimpiarComboTipoIdentificacionCliente()
            End If
        ElseIf args.PropertyName = "ObraSocial" Then
            Me.cmbCondicionFiscal.Enabled = False
            Me.cmbTipoDocumento.SelectedValue = 80 'CUIT
        ElseIf args.PropertyName = "Persona" Then
            Me.cmbCondicionFiscal.Enabled = False
            Me.cmbTipoDocumento.SelectedValue = 4 'DNI
        End If
    End Sub

#Region "CABEZA"
    Public Sub CargarObjeto(ByVal p_os As ObraSocial)
        If p_os IsNot Nothing Then
            Me.txtNombre.Text = p_os.ObraSocial
            Me.txtNroIdentificacionCliente.Text = p_os.nroCuit
            Me.txtDomicilio.Text = p_os.direccion & " - " & p_os.localidad & " - " & "(CP:" & p_os.CodigoPostal.ToString() & ")"
            Me.cmbCondicionFiscal.Text = p_os.CondicionFiscal
            NotifyPropertyChanged("ObraSocial")
        End If
    End Sub
    'Sobrecargamos el metodo para que pueda ser llamado sin importar el objeto enviado (paciente u obra social)
    Public Sub CargarObjeto(ByVal p_pac As Paciente)
        If p_pac IsNot Nothing Then
            Me.txtNombre.Text = p_pac.nombreCompleto
            Me.txtDomicilio.Text = p_pac.direccion
            Me.txtNroIdentificacionCliente.Text = p_pac.dni
            Me.cmbCondicionFiscal.Text = ""
            Me.cmbCondicionFiscal.SelectedIndex = 0
            NotifyPropertyChanged("Persona")
        End If
    End Sub
#End Region

    Dim todasLineasValidas As Boolean 'Bandera para validar lineas del datagridview
    Dim identificacion As New List(Of TipoIdentificacionClienteAFIP)
    Dim gravados As List(Of Gravado)
    Dim tiposComprobante As List(Of TipoComprobante)
    Dim m_comprobante As Comprobante = Nothing
    Dim contComprobantes As New ControladorDeComprobantes
    Dim catComprobante As New CatalogoDeTiposComprobante
    Dim catGrav As New CedirNegocios.CatalogoDeGravados

    Public ReadOnly Property EsFacturaElectronica() As Boolean
        Get
            Return Me.cmbTipoComprobante.SelectedValue IsNot Nothing AndAlso Me.cmbTipoComprobante.SelectedValue <> TComprobante.Liquidacion
        End Get
    End Property

    Public Property Comprobante() As Comprobante
        Get
            Return m_comprobante
        End Get
        Set(ByVal value As Comprobante)
            m_comprobante = value
        End Set
    End Property

    Private Function Validar() As Boolean
        'Validamos que hayan datos en la cabecera
        If (Me.txtDomicilio.Text = "" Or Me.txtNombre.Text() = "" Or Me.txtNroComprobante.Text() = "" Or Me.dgvLineas.RowCount = 0) Then
            MsgBox("Por favor, llene los campos vacios del formulario", MsgBoxStyle.Exclamation, "Datos faltantes")
            Return False
        End If

        If Me.cmbTipoComprobante.SelectedValue <> TComprobante.Liquidacion Then
            'Validamos que los combos esten seleccionados
            If (Me.cmbCondicionFiscal.Text = "" Or Me.cmbResponsable.SelectedIndex = -1 Or Me.cmbSubTipo.SelectedIndex = -1 Or Me.cmbTipoComprobante.SelectedIndex = -1) Then
                MsgBox("No ha seleccionado detalles del comprobante, por favor hagalo", MsgBoxStyle.Exclamation, "Datos faltantes")
                Return False
            End If
        End If

        'Validamos que entren datos validos en la columna de subtotal
        If Me.EsFacturaElectronica And Me.cmbTipoDocumento.SelectedValue Is Nothing Then
            MsgBox("Es necesario que seleccione un Tipo de Documento.", MsgBoxStyle.OkOnly, "Factura Electrónica")
            Return False
        End If

        'Validamos que el DNI tenga máximo 8 digitos
        If Me.cmbTipoDocumento.SelectedValue IsNot Nothing AndAlso Me.cmbTipoDocumento.SelectedValue = 4 AndAlso Me.txtNroIdentificacionCliente.Text.Length > 8 Then
            MsgBox("Número de DNI inválido.", MsgBoxStyle.OkOnly, "Factura Electrónica")
            Return False
        End If

        'si el comprobante posee una factura, tengo que validar que el tipo de comprobante sea
        'notaCredito o notaDébito
        If Me.Comprobante IsNot Nothing Then
            If Me.Comprobante.Factura IsNot Nothing Then
                If Me.cmbTipoComprobante.SelectedValue <> TComprobante.NotaDeDebito And Me.cmbTipoComprobante.SelectedValue <> TComprobante.NotaDeCredito Then
                    MsgBox("No puede crearse este tipo de comprobante", MsgBoxStyle.OkOnly, "Tipo de comprobante Invalido")
                    Return False
                End If
            End If
        End If

        'Validamos que entren datos validos en la columna de subtotal
        calcularImportesYValidarDataGrid()
        If Not todasLineasValidas Then
            MsgBox("Lineas de comprobante invalidas", MsgBoxStyle.OkOnly, "Linea de comprobante invalida")
            Return False
        End If

        Return True
    End Function
    Private Function CrearComprobante() As Boolean
        If Me.Comprobante Is Nothing Then
            Me.Comprobante = New Comprobante
        End If
        'cargamos los datos de la vista
        Me.CargarComprobante(Me.Comprobante)

        Dim result As Dictionary(Of String, String) = Comprobante.crear()
        Dim success As Boolean = Helper.IsSuccess(result)
        Dim message As String = Helper.GetMessage(result)
        MessageBox.Show(message, "Resultado:", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Return success
    End Function
    Private Function CargarLineas() As List(Of LineaDeComprobante)
        Dim lineas As New List(Of LineaDeComprobante)

        For Each row As DataGridViewRow In Me.dgvLineas.Rows
            If row.IsNewRow Then Continue For
            Dim linea As New LineaDeComprobante
            linea.Concepto = Helper.GetString(row.Cells("colConcepto").Value)
            linea.importeNeto = Helper.GetDecimal(row.Cells("colImporteNeto").Value)
            linea.ImporteIVA = Helper.GetDecimal(row.Cells("colImporteIVA").Value)
            linea.Subtotal = Helper.GetDecimal(row.Cells("colSubtotal").Value)
            If linea.Subtotal >= Constants.MIN_FACT Then
                lineas.Add(linea)
            End If
        Next
        Return lineas
    End Function
    Private Function CalcularSumaLineas(ByVal l As List(Of LineaDeComprobante)) As Decimal
        Dim total As Decimal = 0
        For Each row As LineaDeComprobante In l
            total = total + row.Subtotal
        Next
        Return total
    End Function

    Private Sub CargarComprobante(ByVal p_com As Comprobante)
        'Tenemos que diferenciar que si el tipo de comprobante es una liquidación, 
        'algunos valores se setean vacios
        If Me.cmbTipoComprobante.SelectedValue <> TComprobante.Liquidacion Then
            p_com.Responsable = Me.cmbResponsable.Text
            p_com.Gravado = Me.cmbIVA.SelectedItem
            p_com.SubTipo = Me.cmbSubTipo.SelectedItem.ToString
        End If
        p_com.TipoComprobante = cmbTipoComprobante.SelectedItem
        p_com.NroComprobante = Convert.ToInt32(Me.txtNroComprobante.Text)
        p_com.NombreCliente = Me.txtNombre.Text
        p_com.DomicilioCliente = Me.txtDomicilio.Text
        p_com.DocumentoCliente.NroDocumento = Me.txtNroIdentificacionCliente.Text
        p_com.DocumentoCliente.idTipoDocumento = Me.cmbTipoDocumento.SelectedValue
        p_com.DocumentoCliente.Descripcion = Me.cmbTipoDocumento.DisplayMember
        If Me.cmbGravadoPaciente.Visible Then
            p_com.GravadoPaciente = Me.cmbGravadoPaciente.SelectedItem
        End If
        p_com.CondicionFiscal = Me.cmbCondicionFiscal.Text
        p_com.LineasDeComprobante = Me.CargarLineas()
        p_com.TotalFacturado = Me.CalcularSumaLineas(p_com.LineasDeComprobante)
        p_com.TotalCobrado = p_com.TotalFacturado
        p_com.Estado = "COBRADO"
    End Sub
    Public Sub SetComprobante()
        'indicamos en el text del form que se esta creando un comprobante con referencia a una factura
        Me.Text = "Nuevo Comprobante: ajuste a " & Me.Comprobante.TipoComprobante.Descripcion & " Nro: " & Me.Comprobante.NroTerminal & " - " & Me.Comprobante.NroComprobante

        'este procedimiento lo usamos desde cobroFacturacion
        'lo usamos para mostrar los datos de un comprobante propio de una presentacion
        'se pasa una factura, pero acá se crea nd o nc 
        Me.txtNombre.Text = Me.Comprobante.NombreCliente
        Me.txtDomicilio.Text = Me.Comprobante.DomicilioCliente
        Me.txtNroIdentificacionCliente.Text = Me.Comprobante.DocumentoCliente.NroDocumento
        Me.cmbCondicionFiscal.Text = Me.Comprobante.CondicionFiscal
        Me.Comprobante.FechaEmision = Date.Today
        'deshabilitamos la edicion de los campos del cliente
        Me.txtNombre.ReadOnly = True
        Me.txtDomicilio.ReadOnly = True
        Me.txtNroIdentificacionCliente.ReadOnly = True
        Me.cmbCondicionFiscal.Enabled = True
        Me.btnPaciente.Visible = False
        Me.btnObraSocial.Visible = False
        Me.cmbGravadoPaciente.Visible = False
        Me.lblPacienteGravado.Visible = False
        'seteo como factura de la nc o nd, el mismo comprobante(factura), que proviene de cobroFacturacion
        Me.Comprobante.Factura = Me.Comprobante
    End Sub

    Private Sub cargarComboGravado()
        Me.cmbIVA.DisplayMember = "descripcion"
        Me.cmbIVA.DataSource = gravados
    End Sub

    Private Sub CargarComboTipoIdentificacionCliente()
        Try
            Dim oldValue As Object = cmbTipoDocumento.SelectedValue
            cmbTipoDocumento.ValueMember = "idAFIP"
            cmbTipoDocumento.DisplayMember = "descripcion"
            cmbTipoDocumento.DataSource = New BindingSource(identificacion, Nothing)
            If oldValue IsNot Nothing Then
                cmbTipoDocumento.SelectedValue = oldValue
            End If
        Catch ex As Exception
            MessageBox.Show("No se han cargado los tipos de documento del cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub CargarComboTipoComprobante()
        'tenemos que buscar los tipos en el objeto comprobante, ya que no hay un catalogo para tipos
        Try
            cmbTipoComprobante.ValueMember = "Id"
            cmbTipoComprobante.DisplayMember = "Descripcion"
            cmbTipoComprobante.DataSource = New BindingSource(tiposComprobante, Nothing)
            'For Each tipo As TipoComprobante In tiposComprobante
            '    Me.cmbTipoComprobante.Items.Add(tipo.Descripcion)
            'Next
        Catch ex As Exception
        Finally
        End Try
    End Sub
    Private Sub CargarComboCondicionFiscal()
        'cmbCondicionFiscal.Items.Add("Seleccione..")
        cmbCondicionFiscal.Items.Add("CONSUMIDOR FINAL")
        cmbCondicionFiscal.Items.Add("EXENTO")
        cmbCondicionFiscal.Items.Add("RESPONSABLE INSCRIPTO")
    End Sub
    Private Sub CargarComboResponsable()
        cmbResponsable.Items.Add("Seleccione..")
        cmbResponsable.Items.Add("Cedir")
        cmbResponsable.Items.Add("Brunetti")
        cmbResponsable.SelectedIndex = 0
    End Sub

    Private Sub LimpiarComboTipoIdentificacionCliente()
        cmbTipoDocumento.DataSource = Nothing
    End Sub

    Private Sub teclaPresionada(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If Me.dgvLineas.CurrentRow.Selected Then
                Me.dgvLineas.ClearSelection()
            End If
        End If
    End Sub

    Private Sub calcularUltimoNro()
        Dim c As New CatalogoDeComprobantes

        'A priori borramos
        Me.txtNroComprobante.Text = String.Empty
        'no dejamos cambiar el nro de comprobante, ya que lo traemos del afip
        Me.txtNroComprobante.ReadOnly = Me.EsFacturaElectronica

        Dim ultimoNumero As New Nullable(Of Integer)

        If Me.cmbTipoComprobante.SelectedValue = TComprobante.Liquidacion Then
            ultimoNumero = c.getUltimoNro(Me.cmbTipoComprobante.SelectedValue)
        Else
            If Me.cmbResponsable.SelectedIndex > 0 And Me.cmbSubTipo.SelectedIndex <> -1 And Me.cmbTipoComprobante.SelectedIndex <> -1 Then
                Dim terminal As Integer
                If Int32.TryParse(txtNroTerminal.Text, terminal) Then
                    ultimoNumero = c.getUltimoNro(Me.cmbTipoComprobante.SelectedValue, Me.cmbResponsable.SelectedItem, Me.cmbSubTipo.SelectedItem, terminal)
                End If
            End If
        End If
        If ultimoNumero.HasValue Then
            Me.txtNroComprobante.Text = (ultimoNumero.Value + 1).ToString()
        End If
        c = Nothing
    End Sub

    Private Function calcularImportesEnLinea(ByRef row As DataGridViewRow) As Decimal
        If Helper.ValidaNumero(row.Cells("colImporteNeto").Value) Then
            Dim importeNeto As Decimal = Helper.GetDecimal(row.Cells("colImporteNeto").Value)
            Dim importeIVA As Decimal = (importeNeto * CType(Me.cmbIVA.SelectedItem, Gravado).porcentaje) / 100
            Dim subTotal As Decimal = importeNeto + importeIVA

            row.Cells("colImporteNeto").Value = importeNeto.ToString("F2")
            row.Cells("colImporteIVA").Value = importeIVA.ToString("F2")
            row.Cells("colSubtotal").Value = subTotal.ToString("F2")

            Return subTotal
        Else
            row.Cells("colImporteNeto").Value = String.Empty
            row.Cells("colImporteIVA").Value = String.Empty
            row.Cells("colSubtotal").Value = String.Empty
            Return 0
        End If
    End Function

    Private Function validarLinea(ByRef row As DataGridViewRow) As Boolean
        validarLinea = True
        If Not row.IsNewRow Then
            If Helper.IsNullOrWhitespace(row.Cells("colConcepto").Value) Then
                row.Cells("colConcepto").ErrorText = "Concepto inválido"
                validarLinea = False
            Else
                row.Cells("colConcepto").ErrorText = Nothing
            End If

            If Helper.ValidaNumero(row.Cells("colImporteNeto").Value) Then
                row.Cells("colImporteNeto").ErrorText = Nothing
            Else
                row.Cells("colImporteNeto").ErrorText = "Concepto inválido"
                validarLinea = False
            End If
        End If
    End Function

    Private Sub calcularImportesYValidarDataGrid()
        'Mostramos la suma de los subtotales de las lineas
        Dim suma As Decimal = 0
        todasLineasValidas = Me.dgvLineas.Rows.Count > 1

        For Each row As DataGridViewRow In Me.dgvLineas.Rows
            suma += calcularImportesEnLinea(row)
            If validarLinea(row) Then
                row.ErrorText = Nothing
            Else
                row.ErrorText = "Verifique los valores ingresados"
                todasLineasValidas = False
            End If
        Next

        Me.btnQuitar.Enabled = Me.dgvLineas.Rows.Count > 1 AndAlso Me.dgvLineas.CurrentRow IsNot Nothing AndAlso Not Me.dgvLineas.CurrentRow.IsNewRow
        Me.lblTotalSuma.Text = suma.ToString("C2")
    End Sub

    'Uso Reload para borrar todos los campos, una vez creado un comprobante, permitiendo 
    'cargar otro
    Private Sub Reload()
        Controls.Clear()
        InitializeComponent()
        ComprobantesNuevo_Load(Me, Nothing)
    End Sub

#Region "FORMULARIO EVENTS"

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If Me.Validar() Then
            If Me.CrearComprobante() Then
                Me.dgvLineas.Enabled = False
                Me.btnImprimir.Visible = True
                If Me.btnImprimir.Visible Then
                    Dim resp As DialogResult = MessageBox.Show("¿Desea imprimir el comprobante?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If resp = Windows.Forms.DialogResult.Yes Then
                        Me.btnImprimir.PerformClick()
                    End If
                End If
            End If
            Me.Close()
        End If 'fin validar

    End Sub

    Private Sub ComprobantesNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lblFecha.Text = Today.Date
        gravados = catGrav.getGravadosAll()
        identificacion = contComprobantes.ObtenerTiposDeIdentificacionDeClienteAFIP()
        tiposComprobante = catComprobante.getTiposComprobante()


        Me.CargarComboCondicionFiscal()
        Me.CargarComboResponsable()
        'busco los tipos de comprobante en la base de datos
        Me.CargarComboTipoComprobante()
        Me.cargarComboGravado()


        txtNroTerminal.Text = String.Empty

        Me.cmbGravadoPaciente.Visible = False
        Me.lblPacienteGravado.Visible = False

        Me.dgvLineas.EditMode = DataGridViewEditMode.EditOnEnter
    End Sub

    Private Sub btnPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPaciente.Click
        Dim f As New BuscarPacientes
        Me.AddOwnedForm(f)
        f.btnSelecPac.Visible = True
        f.btnNuevoPaciente.Visible = False
        f.BtnNuevoEstudio.Visible = False
        f.btnEditar.Visible = False
        f.ShowDialog()
        Me.CargarObjeto(f.paciente)
        f.Close()
        Me.cmbGravadoPaciente.Visible = True
        Me.lblPacienteGravado.Visible = True
    End Sub

    Private Sub btnObraSocial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObraSocial.Click
        Dim f As New ConsultarObraSocial
        Me.AddOwnedForm(f)
        f.btnAceptar.Visible = True
        f.btnAranceles.Visible = False
        f.btnModificar.Visible = False
        f.btnDetalles.Visible = False
        f.ShowDialog()
        Me.cmbGravadoPaciente.Visible = False
        Me.lblPacienteGravado.Visible = False

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If (Me.dgvLineas.CurrentRow.Selected = True And Not (Me.dgvLineas.CurrentRow.IsNewRow)) Then
            Me.dgvLineas.Rows.Remove(Me.dgvLineas.CurrentRow)
        End If

        If Me.dgvLineas.Rows.Count > 0 Then
            Me.btnQuitar.Visible = True
        Else
            Me.btnQuitar.Visible = False
        End If

    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Comprobante Is Nothing OrElse Comprobante.TipoComprobante Is Nothing Then
            MessageBox.Show("El comprobante no está generado." & vbCrLf & "Impresión cancelada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Exit Sub
        End If
        If Comprobante.TipoComprobante.Id <> TComprobante.Liquidacion Then
            Helper.ImprimirWeb(Comprobante.CAE)
            Exit Sub
        End If
        Dim f As New rptViewer
        Me.AddOwnedForm(f)
        f.cargarDsComprobantes(Comprobante, Me.chkLeyenda.Checked, Me.cmbGravadoPaciente.Visible)
        f.ShowDialog()
    End Sub

    Private Sub cmbTipoComprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoComprobante.SelectedIndexChanged
        Dim estado As Boolean = Me.EsFacturaElectronica

        If Not estado Then
            Me.cmbIVA.SelectedIndex = 0
            Me.cmbResponsable.SelectedIndex = 0
            Me.cmbSubTipo.SelectedIndex = -1
            Me.cmbSubTipo.Text = "Seleccione sub-tipo"
        End If

        Me.cmbResponsable.Enabled = estado
        Me.cmbIVA.Enabled = estado
        Me.cmbSubTipo.Enabled = estado

        Me.cmbCondicionFiscal.Enabled = estado
        Me.txtNroTerminal.Enabled = estado

        'Ahora traemos el nro de comprobante que tendrían que ingresar en el txtNroComprobante
        Me.calcularUltimoNro()
        NotifyPropertyChanged("EsFacturaElectronica")
    End Sub

    Private Sub cmbResponsable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbResponsable.SelectedIndexChanged
        Dim puntoVenta As Integer = Comprobante.GetPVFromResponsable(Me.cmbResponsable.Text)
        Me.txtNroTerminal.Text = IIf(puntoVenta > 0, puntoVenta.ToString("D4"), String.Empty)
        Me.calcularUltimoNro()
    End Sub

    Private Sub cmbSubTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubTipo.SelectedIndexChanged
        Me.calcularUltimoNro()
        NotifyPropertyChanged("EsFacturaElectronica")
    End Sub

    Private Sub cmbIVA_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbIVA.SelectedIndexChanged
        calcularImportesYValidarDataGrid()
    End Sub

#End Region

#Region "DATAGRID EVENTS"

    Private Sub dgvLineas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvLineas.KeyPress

        ' obtener indice de la columna  
        Dim columna As Integer = Me.dgvLineas.CurrentCell.ColumnIndex

        ' Obtener caracter  
        Dim caracter As Char = e.KeyChar
        If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Delete)) = False Then

        End If

        ' comprobar si el caracter es un número o el retroceso  
        If columna = 2 Then
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar  
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Sub dgvLineas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLineas.CurrentCellChanged
        Me.calcularImportesYValidarDataGrid()
    End Sub

#End Region

End Class

