Imports System.Drawing.Printing
Imports CedirNegocios
Imports System.Collections.Generic
Public Class frmComprobanteNuevo
	Inherits System.Windows.Forms.Form


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
    Friend WithEvents cmbNroTerminal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoDocumento As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents concepto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporteNeto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents porcIVA As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents importeIVA As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents subtotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cmbSubTipo As System.Windows.Forms.ComboBox



#Region " C�digo generado por el Dise�ador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Dise�ador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicializaci�n despu�s de la llamada a InitializeComponent()

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

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Dise�ador de Windows Forms. 
    'No lo modifique con el editor de c�digo.
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
    Friend WithEvents txtNroCuit As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCondicionFiscal As System.Windows.Forms.ComboBox
    Friend WithEvents cmbResponsable As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents cmbGravado As System.Windows.Forms.ComboBox
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.lblPacienteGravado = New System.Windows.Forms.Label
        Me.cmbGravadoPaciente = New System.Windows.Forms.ComboBox
        Me.btnPaciente = New System.Windows.Forms.Button
        Me.txtNroCuit = New System.Windows.Forms.TextBox
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
        Me.cmbNroTerminal = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSubTipo = New System.Windows.Forms.ComboBox
        Me.lblSubTipo = New System.Windows.Forms.Label
        Me.txtNroComprobante = New System.Windows.Forms.TextBox
        Me.cmbResponsable = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbGravado = New System.Windows.Forms.ComboBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.dgvLineas = New System.Windows.Forms.DataGridView
        Me.concepto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colImporteNeto = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.porcIVA = New System.Windows.Forms.DataGridViewComboBoxColumn
        Me.importeIVA = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.subtotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblTotalSuma = New System.Windows.Forms.Label
        Me.chkLeyenda = New System.Windows.Forms.CheckBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Location = New System.Drawing.Point(825, 611)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 10
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Location = New System.Drawing.Point(906, 611)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.Text = "Cerrar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(446, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
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
        Me.GroupBox1.Controls.Add(Me.txtNroCuit)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.btnObraSocial)
        Me.GroupBox1.Controls.Add(Me.cmbCondicionFiscal)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(961, 214)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'cmbTipoDocumento
        '
        Me.cmbTipoDocumento.Location = New System.Drawing.Point(114, 111)
        Me.cmbTipoDocumento.Name = "cmbTipoDocumento"
        Me.cmbTipoDocumento.Size = New System.Drawing.Size(241, 21)
        Me.cmbTipoDocumento.TabIndex = 13
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
        Me.btnPaciente.Location = New System.Drawing.Point(501, 82)
        Me.btnPaciente.Name = "btnPaciente"
        Me.btnPaciente.Size = New System.Drawing.Size(88, 23)
        Me.btnPaciente.TabIndex = 9
        Me.btnPaciente.Text = "Paciente"
        Me.btnPaciente.UseVisualStyleBackColor = True
        '
        'txtNroCuit
        '
        Me.txtNroCuit.Location = New System.Drawing.Point(114, 69)
        Me.txtNroCuit.Multiline = True
        Me.txtNroCuit.Name = "txtNroCuit"
        Me.txtNroCuit.Size = New System.Drawing.Size(381, 36)
        Me.txtNroCuit.TabIndex = 8
        Me.ToolTip1.SetToolTip(Me.txtNroCuit, "Cuando ingrese un paciente, por favor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ingrese:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OBRA SOCIAL" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Afiliado nro"" + NR" & _
                "O AFILIADO" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "----------------------------------------" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Cuando ingrese obra social" & _
                ", por favor" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ingrese:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NRO CUIT")
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(114, 43)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.Size = New System.Drawing.Size(558, 20)
        Me.txtDomicilio.TabIndex = 7
        '
        'btnObraSocial
        '
        Me.btnObraSocial.Location = New System.Drawing.Point(595, 82)
        Me.btnObraSocial.Name = "btnObraSocial"
        Me.btnObraSocial.Size = New System.Drawing.Size(88, 23)
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
        Me.Label10.Text = "Condici�n Fiscal:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(10, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(99, 32)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "[Nro de Cuit | OS+Afiliado nro]:"
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
        Me.lblFecha.Location = New System.Drawing.Point(910, 8)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(80, 16)
        Me.lblFecha.TabIndex = 20
        Me.lblFecha.Text = "Fecha"
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.Location = New System.Drawing.Point(353, 44)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.Size = New System.Drawing.Size(139, 23)
        Me.lblNroComprobante.TabIndex = 21
        Me.lblNroComprobante.Text = "Nro de Comprobante: "
        Me.lblNroComprobante.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox2.Controls.Add(Me.cmbNroTerminal)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbSubTipo)
        Me.GroupBox2.Controls.Add(Me.lblSubTipo)
        Me.GroupBox2.Controls.Add(Me.txtNroComprobante)
        Me.GroupBox2.Controls.Add(Me.cmbResponsable)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbGravado)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbTipoComprobante)
        Me.GroupBox2.Controls.Add(Me.lblNroComprobante)
        Me.GroupBox2.Location = New System.Drawing.Point(27, 245)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(958, 107)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comprobante"
        '
        'cmbNroTerminal
        '
        Me.cmbNroTerminal.Items.AddRange(New Object() {"0001", "0090", "0091"})
        Me.cmbNroTerminal.Location = New System.Drawing.Point(498, 46)
        Me.cmbNroTerminal.Name = "cmbNroTerminal"
        Me.cmbNroTerminal.Size = New System.Drawing.Size(200, 21)
        Me.cmbNroTerminal.TabIndex = 37
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(710, 50)
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
        Me.lblSubTipo.Location = New System.Drawing.Point(723, 22)
        Me.lblSubTipo.Name = "lblSubTipo"
        Me.lblSubTipo.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTipo.TabIndex = 28
        Me.lblSubTipo.Text = "Sub-Tipo:"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(726, 47)
        Me.txtNroComprobante.Name = "txtNroComprobante"
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
        'cmbGravado
        '
        Me.cmbGravado.Location = New System.Drawing.Point(112, 50)
        Me.cmbGravado.Name = "cmbGravado"
        Me.cmbGravado.Size = New System.Drawing.Size(121, 21)
        Me.cmbGravado.TabIndex = 24
        Me.cmbGravado.Text = "Seleccione Gravado"
        Me.cmbGravado.Visible = False
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(20, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Gravado:"
        Me.Label12.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.GroupBox3.Controls.Add(Me.dgvLineas)
        Me.GroupBox3.Location = New System.Drawing.Point(27, 372)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(958, 156)
        Me.GroupBox3.TabIndex = 23
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Conceptos"
        '
        'dgvLineas
        '
        Me.dgvLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLineas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.concepto, Me.colImporteNeto, Me.porcIVA, Me.importeIVA, Me.subtotal})
        Me.dgvLineas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLineas.Location = New System.Drawing.Point(3, 16)
        Me.dgvLineas.MultiSelect = False
        Me.dgvLineas.Name = "dgvLineas"
        Me.dgvLineas.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLineas.Size = New System.Drawing.Size(952, 137)
        Me.dgvLineas.TabIndex = 0
        '
        'concepto
        '
        Me.concepto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.concepto.FillWeight = 369.5432!
        Me.concepto.HeaderText = "CONCEPTO"
        Me.concepto.Name = "concepto"
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
        'porcIVA
        '
        Me.porcIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.porcIVA.DataPropertyName = "id"
        Me.porcIVA.FillWeight = 10.15228!
        Me.porcIVA.HeaderText = "% IVA"
        Me.porcIVA.Items.AddRange(New Object() {"0.0", "10.5", "21"})
        Me.porcIVA.Name = "porcIVA"
        Me.porcIVA.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.porcIVA.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.porcIVA.Width = 60
        '
        'importeIVA
        '
        Me.importeIVA.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.importeIVA.FillWeight = 10.15228!
        Me.importeIVA.HeaderText = "ImporteIVA"
        Me.importeIVA.Name = "importeIVA"
        Me.importeIVA.ReadOnly = True
        Me.importeIVA.Width = 84
        '
        'subtotal
        '
        Me.subtotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.subtotal.DefaultCellStyle = DataGridViewCellStyle2
        Me.subtotal.FillWeight = 10.15228!
        Me.subtotal.HeaderText = "SUBTOTAL"
        Me.subtotal.Name = "subtotal"
        Me.subtotal.Width = 89
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Location = New System.Drawing.Point(744, 611)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 24
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(750, 531)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(114, 13)
        Me.lblTotal.TabIndex = 25
        Me.lblTotal.Text = "TOTAL ...................  : "
        '
        'lblTotalSuma
        '
        Me.lblTotalSuma.AutoSize = True
        Me.lblTotalSuma.Location = New System.Drawing.Point(903, 531)
        Me.lblTotalSuma.Name = "lblTotalSuma"
        Me.lblTotalSuma.Size = New System.Drawing.Size(68, 13)
        Me.lblTotalSuma.TabIndex = 26
        Me.lblTotalSuma.Text = "lblTotalSuma"
        '
        'chkLeyenda
        '
        Me.chkLeyenda.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chkLeyenda.AutoSize = True
        Me.chkLeyenda.Location = New System.Drawing.Point(30, 585)
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
        Me.btnQuitar.Location = New System.Drawing.Point(27, 550)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(83, 23)
        Me.btnQuitar.TabIndex = 28
        Me.btnQuitar.Text = "Quitar Linea"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'frmComprobanteNuevo
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1017, 657)
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
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvLineas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region



#Region "CABEZA"
    Public Sub CargarObjeto(ByVal p_os As ObraSocial)
        Me.txtNombre.Text = p_os.ObraSocial
        Me.txtNroCuit.Text = p_os.nroCuit
        Me.txtDomicilio.Text = p_os.direccion & " - " & p_os.localidad & " - " & "(CP:" & p_os.CodigoPostal.ToString() & ")"
        Me.cmbCondicionFiscal.Text = p_os.CondicionFiscal
        Me.cmbCondicionFiscal.Enabled = False

    End Sub
    'Sobrecargamos el metodo para que pueda ser llamado sin importar el objeto enviado (paciente u obra social)
    Public Sub CargarObjeto(ByVal p_pac As Paciente)
        Me.txtNombre.Text = p_pac.nombreCompleto
        Me.txtDomicilio.Text = p_pac.direccion
        Me.cmbCondicionFiscal.Text = ""
        cmbCondicionFiscal.SelectedIndex = 0
        Me.cmbCondicionFiscal.Enabled = False
    End Sub
#End Region

    Dim lineaValida As Boolean 'Bandera para validar lineas del datagridview
    Dim gravados As List(Of Gravado)
    Dim tiposComprobante As List(Of TipoComprobante)
    Dim m_comprobante As Comprobante = Nothing
    Dim controladorFE As New ControladorFacturaElectronica

    Public Property Comprobante() As Comprobante
        Get
            Return m_comprobante
        End Get
        Set(ByVal value As Comprobante)
            m_comprobante = value
        End Set
    End Property


    Private Function Validar() As Boolean

        Validar = True
        'Validamos que hayan datos en la cabecera
        If (Me.txtDomicilio.Text = "" Or Me.txtNombre.Text() = "" Or Me.txtNroComprobante.Text() = "" Or Me.dgvLineas.RowCount = 0) Then
            MsgBox("Por favor, llene los campos vacios del formulario", MsgBoxStyle.Exclamation, "Datos faltantes")
            Validar = False
        End If

        If (Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id) <> 2 Then
            'Validamos que los combos esten seleccionados
            If (Me.cmbCondicionFiscal.Text = "" Or Me.cmbResponsable.SelectedIndex = -1 Or Me.cmbSubTipo.SelectedIndex = -1 Or Me.cmbTipoComprobante.SelectedIndex = -1) Then
                MsgBox("No ha seleccionado detalles del comprobante, por favor hagalo", MsgBoxStyle.Exclamation, "Datos faltantes")
                Validar = False
            End If
        End If

        'Validamos que entren datos validos en la columna de subtotal
        If (lineaValida = False) Then
            MsgBox("Lineas de comprobante invalidas", MsgBoxStyle.OkOnly, "Linea de comprobante invalida")
            Validar = False
        End If


        'si el comprobante posee una factura,tengo que validar que el tipo de comprobante sea
        'notaCredito o notaD�bito
        If Me.Comprobante IsNot Nothing Then
            If Me.Comprobante.Factura IsNot Nothing Then
                If ((Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id <> 3) And (Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id <> 4)) Then
                    MsgBox("No puede crearse este tipo de comprobante", MsgBoxStyle.OkOnly, "Tipo de comprobante Invalido")
                    Validar = False
                End If
            End If
        End If




    End Function

    Private Function CrearComprobante() As Boolean
        If Me.Comprobante Is Nothing Then
            Me.Comprobante = Me.controladorFE.crearComprobante(cmbNroTerminal.SelectedItem.ToString(), Me.cmbSubTipo.SelectedItem.ToString(), Me.cmbResponsable.SelectedItem.ToString().ToUpper())
        End If

        Me.cargarComprobante(Me.Comprobante)

        If Comprobante.doesExist() Then
            MessageBox.Show("Ya se ha cargado el comprobante anteriormente", "Atenci�n")
            Return False
        Else
            Comprobante.crear()
            MessageBox.Show("Comprobante creado con �xito", "Atenci�n")
            Return True
        End If
    End Function

    Private Sub cargarComprobante(ByVal p_com As Comprobante)
        'Tenemos que diferenciar que si el tipo de comprobante es una liquidaci�n, 
        'algunos valores se setean vacios
        If Me.cmbTipoComprobante.SelectedItem.ToString.ToUpper() <> "LIQUIDACION" Then
            p_com.Responsable = Me.cmbResponsable.Text
            p_com.Gravado = Me.cmbGravado.SelectedItem ' ESTE CAMPO TENDRIA QUE ELIMINARSE DEL COMPROBANTE
            p_com.SubTipo = Me.cmbSubTipo.SelectedItem.ToString
        End If

        p_com.TipoComprobante = tiposComprobante(Me.cmbTipoComprobante.SelectedIndex)
        p_com.NroComprobante = Convert.ToInt32(Me.txtNroComprobante.Text)
        p_com.NroTerminal = Convert.ToInt32(Me.cmbNroTerminal.SelectedItem)

        p_com.NombreCliente = Me.txtNombre.Text
        p_com.DomicilioCliente = Me.txtDomicilio.Text
        p_com.DocumentoCliente.NroDocumento = Me.txtNroCuit.Text
        p_com.DocumentoCliente.idTipoDocumento = Me.cmbTipoDocumento.SelectedValue
        If (Me.cmbGravadoPaciente.Visible = True) Then
            p_com.GravadoPaciente = Me.cmbGravadoPaciente.SelectedItem
        End If
        p_com.CondicionFiscal = Me.cmbCondicionFiscal.Text
        p_com.LineasDeComprobante = Me.cargarLineas()
        p_com.TotalFacturado = Me.CalcularSumaLineas(p_com.LineasDeComprobante)
        p_com.TotalCobrado = p_com.TotalFacturado
        p_com.Estado = "COBRADO"

    End Sub

    Public Sub setComprobante()
        'indicamos en el text del form que se esta creando un comprobante con referencia a una factura
        Me.Text = "Nuevo Comprobante: ajuste a " & Me.Comprobante.TipoComprobante.Descripcion & " Nro: " & Me.Comprobante.NroTerminal & " - " & Me.Comprobante.NroComprobante

        'este procedimiento lo usamos desde cobroFacturacion
        'lo usamos para mostrar los datos de un comprobante propio de una presentacion
        'se pasa una factura, pero ac� se crea nd o nc 
        Me.txtNombre.Text = Me.Comprobante.NombreCliente
        Me.txtDomicilio.Text = Me.Comprobante.DomicilioCliente
        Me.txtNroCuit.Text = Me.Comprobante.DocumentoCliente.NroDocumento
        Me.cmbCondicionFiscal.Text = Me.Comprobante.CondicionFiscal
        Me.Comprobante.FechaEmision = Date.Today
        'deshabilitamos la edicion de los campos del cliente
        Me.txtNombre.ReadOnly = True
        Me.txtDomicilio.ReadOnly = True
        Me.txtNroCuit.ReadOnly = True
        Me.cmbCondicionFiscal.Enabled = True
        Me.btnPaciente.Visible = False
        Me.btnObraSocial.Visible = False
        Me.cmbGravadoPaciente.Visible = False
        Me.lblPacienteGravado.Visible = False
        'seteo como factura de la nc o nd, el mismo comprobante(factura), que proviene de cobroFacturacion
        Me.Comprobante.Factura = Me.Comprobante
    End Sub

    Private Function cargarLineas() As List(Of LineaDeComprobante)

        Dim lineas As New List(Of LineaDeComprobante)

        For Each row As DataGridViewRow In Me.dgvLineas.Rows
            If row.IsNewRow Then Continue For
            Dim linea As New LineaDeComprobante
            linea.Concepto = row.Cells("concepto").Value.ToString
            Dim subtotal As Decimal = Convert.ToDecimal((row.Cells("subtotal").Value.ToString.Trim))
            linea.Subtotal = Format(subtotal, "#########0.00")
            lineas.Add(linea)
        Next

        Return lineas
    End Function

    Private Sub cargarComboGravadoEnDataGrid()

        Dim catGrav As New CedirNegocios.CatalogoDeGravados
        gravados = catGrav.getGravadosAll()
        'For Each grav As Gravado In gravados
        '    cmbGravado.Items.Add(grav)
        'Next
        'cmbGravado.DataSource = gravados
        'cmbGravado.ValueMember = "id"
        'cmbGravado.DisplayMember = "descripcion"
        CType(Me.dgvLineas.Columns("porcIVA"), DataGridViewComboBoxColumn).DataSource = gravados
        CType(Me.dgvLineas.Columns("porcIVA"), DataGridViewComboBoxColumn).DisplayMember = "descripcion"
        CType(Me.dgvLineas.Columns("porcIVA"), DataGridViewComboBoxColumn).ValueMember = "porcentaje"
        ' catGrav = Nothing

    End Sub

    Private Sub cargarComboTipoDocumentoCliente()
        Dim dic As New Dictionary(Of Integer, String)
        Try
            dic = Me.controladorFE.ObtenerTiposDeDocumentoCliente()
            cmbTipoDocumento.DataSource = New BindingSource(dic, Nothing)
            cmbTipoDocumento.ValueMember = "Key"
            cmbTipoDocumento.DisplayMember = "Value"
        Catch ex As Exception
            MessageBox.Show("No se han cargado los tipos de documento del cliente", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cargarComboTipoComprobante()
        'tenemos que buscar los tipos en el objeto comprobante, ya que no hay un catalogo para tipos
        Try
            Dim c As New CatalogoDeTiposComprobante
            Dim tipos As New List(Of TipoComprobante)
            tiposComprobante = c.getTiposComprobante()
            For Each tipo As TipoComprobante In tiposComprobante
                Me.cmbTipoComprobante.Items.Add(tipo.Descripcion)
            Next
        Catch ex As Exception
        Finally

        End Try



    End Sub

    Private Function CalcularSumaLineas(ByVal l As List(Of LineaDeComprobante)) As Decimal
        Dim total As Decimal = 0
        For Each row As LineaDeComprobante In l
            total = total + row.Subtotal
        Next
        Return total
    End Function

    Private Sub teclaPresionada(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Delete Then
            If (Me.dgvLineas.CurrentRow.Selected = True) Then
                Me.dgvLineas.ClearSelection()
            End If
        End If
    End Sub

    Private Sub calcularUltimoNro()
        If (cmbNroTerminal.SelectedItem = "0091" And Me.cmbTipoComprobante.SelectedItem <> Nothing And Me.cmbSubTipo.SelectedItem <> Nothing) Then
            ultimoNroAfip()
        Else
            ultimoNroCedir()
        End If
    End Sub

    Private Sub ultimoNroAfip()
        Try
            'no dejamos cambiar el nro de comprobante, ya que lo traemos del afip
            Me.txtNroComprobante.ReadOnly = True
            Me.calcularUltimoNroAFIP()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Ud NO SE HA PODIDO CONECTAR al servicio de afip....", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End Try

        'vamos a seleccionar el cmbResponsable, a "cedir", ya que es este el unico habilitado para factura electronica.
        Me.cmbResponsable.SelectedIndex = Me.cmbResponsable.FindString("Cedir")

    End Sub
    Private Sub ultimoNroCedir()
        Dim c As New CatalogoDeComprobantes
        If ((Me.cmbResponsable.SelectedItem <> "Seleccione..") And (Me.cmbSubTipo.SelectedIndex <> -1) Or (Me.cmbTipoComprobante.SelectedItem <> Nothing)) Then
            If Me.cmbTipoComprobante.SelectedItem <> Nothing Then
                If Me.cmbTipoComprobante.SelectedItem.ToString.ToUpper() = "LIQUIDACION" Then
                    Me.txtNroComprobante.Text = (c.getUltimoNro(Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id) + 1).ToString()
                Else
                    Me.txtNroComprobante.Text = (c.getUltimoNro(Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id, Me.cmbResponsable.SelectedItem.ToString(), Me.cmbSubTipo.SelectedItem, Convert.ToInt32(cmbNroTerminal.SelectedItem)) + 1).ToString()
                End If
            End If
        End If
        c = Nothing

    End Sub
    Private Sub calcularUltimoNroAFIP()
        Me.txtNroComprobante.Text = (Me.controladorFE.ObtenerUltimoNro(Me.cmbTipoComprobante.SelectedItem.ToString(), Convert.ToInt16(Me.cmbNroTerminal.SelectedItem), cmbSubTipo.SelectedItem.ToString()) + 1).ToString()
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
        If (Me.Validar() = True) Then
            If (Me.CrearComprobante()) Then
                Me.dgvLineas.Enabled = False
                Dim resp As DialogResult
                resp = MessageBox.Show("�Desea imprimir el comprobante?", "Atenci�n", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp = Windows.Forms.DialogResult.Yes Then
                    Me.btnImprimir.PerformClick()
                End If
            End If
            Me.Close()

        Else : MsgBox("El comprobante no ha sido cargado", MsgBoxStyle.Exclamation, " Atenci�n ")

        End If 'fin validar

    End Sub

    Private Sub ComprobantesNuevo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lblFecha.Text = Today.Date

        'cmbCondicionFiscal.Items.Add("Seleccione..")
        cmbCondicionFiscal.Items.Add("CONSUMIDOR FINAL")
        cmbCondicionFiscal.Items.Add("EXENTO")
        cmbCondicionFiscal.Items.Add("RESPONSABLE INSCRIPTO")
        '   cmbCondicionFiscal.SelectedIndex = 0


        cmbResponsable.Items.Add("Seleccione..")
        cmbResponsable.Items.Add("Cedir")
        cmbResponsable.Items.Add("Brunetti")
        cmbResponsable.SelectedIndex = 0



        cmbNroTerminal.SelectedIndex = 0

        'busco los tipos de comprobante en la base de datos
        Me.cargarComboTipoComprobante()

        'busco los gravados en la base de datos
        Me.cargarComboGravadoEnDataGrid()

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
        Dim f As New rptViewer
        Me.AddOwnedForm(f)
        f.cargarDsComprobantes(Comprobante, Me.chkLeyenda.Checked, Me.cmbGravadoPaciente.Visible)
        f.ShowDialog()
    End Sub

    Private Sub cmbTipoComprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoComprobante.SelectedIndexChanged
        If Me.cmbTipoComprobante.SelectedItem.ToString.ToUpper() = "LIQUIDACION" Then
            Me.cmbCondicionFiscal.Enabled = False
            Me.cmbGravado.Enabled = False
            Me.cmbResponsable.Enabled = False
            Me.cmbSubTipo.Enabled = False
            Me.cmbNroTerminal.Enabled = False
        Else
            Me.cmbCondicionFiscal.Enabled = True
            Me.cmbGravado.Enabled = True
            Me.cmbResponsable.Enabled = True
            Me.cmbNroTerminal.Enabled = True
            Me.cmbSubTipo.Enabled = True
        End If
        'Ahora traemos el nro de comprobante que tendr�an que ingresar en el txtNroComprobante
        Me.calcularUltimoNro()
    End Sub
    Private Sub cmbResponsable_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbResponsable.SelectedIndexChanged
        Me.calcularUltimoNro()
    End Sub
    Private Sub cmbSubTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubTipo.SelectedIndexChanged
        Me.calcularUltimoNro()
    End Sub
    Private Sub cmbGravado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGravado.SelectedIndexChanged

        ' Me.dgvLineas.Rows.Add(gravados(Me.cmbGravado.SelectedIndex).descripcion)
    End Sub
#End Region

#Region "DATAGRID EVENTS"
    Private Sub dgvLineas_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLineas.CellEndEdit
        Me.dgvLineas.Rows(e.RowIndex).ErrorText = String.Empty
    End Sub

    Private Sub dgvLineas_CellFormatting(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellFormattingEventArgs) Handles dgvLineas.CellFormatting
        If Me.dgvLineas.Rows.Count > 0 Then
            Me.btnQuitar.Visible = True
        Else
            Me.btnQuitar.Visible = False
        End If
        Dim h As New Helper
        If e.ColumnIndex = Me.dgvLineas.Columns("subtotal").Index AndAlso Not (e.Value Is Nothing) Then
            With Me.dgvLineas.Rows(e.RowIndex).Cells("subtotal")
                If Not h.validaNumero(e.Value.ToString) Then
                    .ToolTipText = "ingrese n�meros v�lidos por favor"
                    Me.dgvLineas.Rows(e.RowIndex).Cells("subtotal").ErrorText = "Los caracteres ingresados no son numeros validos"
                    lineaValida = False
                Else : Me.dgvLineas.Rows(e.RowIndex).Cells("subtotal").ErrorText = Nothing
                    .ToolTipText = Nothing
                End If
            End With
        End If

        h = Nothing
    End Sub

    Private Sub dgvLineas_CellValidated(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLineas.CellValidated
        Me.dgvLineas.Rows(e.RowIndex).ErrorText = String.Empty
        lineaValida = True
    End Sub

    Private Sub dgvLineas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dgvLineas.KeyPress



        ' obtener indice de la columna  
        Dim columna As Integer = Me.dgvLineas.CurrentCell.ColumnIndex

        ' Obtener caracter  
        Dim caracter As Char = e.KeyChar
        If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Delete)) = False Then

        End If

        ' comprobar si el caracter es un n�mero o el retroceso  
        If columna = 2 Then
            If Not Char.IsNumber(caracter) And (caracter = ChrW(Keys.Back)) = False Then
                'Me.Text = e.KeyChar  
                e.KeyChar = Chr(0)
            End If
        End If
    End Sub

    Private Sub dgvLineas_RowEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLineas.RowEnter
        Me.dgvLineas.Rows(e.RowIndex).ErrorText = "Complete todos los datos requeridos"
    End Sub

    Private Sub dgvLineas_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvLineas.CurrentCellChanged
        'Mostramos la suma de los subtotales de las lineas
        Dim suma As Decimal = 0
        For Each row As DataGridViewRow In Me.dgvLineas.Rows
            If row.Cells("colImporteNeto").Value <> "" Then
                Dim h As New Helper
                If h.validaNumero(row.Cells("colImporteNeto").Value.ToString) Then
                    row.Cells("importeIVA").Value = (Convert.ToDecimal(row.Cells("colImporteNeto").Value * Convert.ToDecimal(row.Cells("porcIVA").Value) / 100)).ToString()
                    row.Cells("subtotal").Value = Convert.ToDecimal(row.Cells("importeIVA").Value) + Convert.ToDecimal(row.Cells("colImporteNeto").Value)
                    suma = suma + Convert.ToDecimal(row.Cells("subtotal").Value)
                Else : lineaValida = False
                End If
                h = Nothing
            End If
        Next
        Me.lblTotalSuma.Text = suma.ToString("C2")

    End Sub

#End Region

    Private Sub cmbNroTerminal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNroTerminal.SelectedIndexChanged
        Me.calcularUltimoNro()
        If (cmbNroTerminal.SelectedItem = "0091" And Me.cmbTipoComprobante.SelectedItem <> Nothing And Me.cmbSubTipo.SelectedItem <> Nothing) Then
            Me.cmbTipoDocumento.Enabled = True
            Me.cargarComboTipoDocumentoCliente()
        Else
            Me.cmbTipoDocumento.Enabled = False
        End If
    End Sub

    Private Sub cmbTipoDocumento_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoDocumento.SelectedIndexChanged
        MessageBox.Show(Me.cmbTipoDocumento.SelectedValue.ToString())
    End Sub

    Private Sub dgvLineas_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLineas.CellContentClick

    End Sub

    Private Sub dgvLineas_CellLeave(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLineas.CellLeave

        If Me.dgvLineas.Rows(e.RowIndex).Cells("concepto").Value Is Nothing AndAlso Me.dgvLineas.Rows(e.RowIndex).Cells("subtotal").Value IsNot Nothing Then
            With Me.dgvLineas.Rows(e.RowIndex).Cells("concepto")
                .ToolTipText = "INGRESE UN CONCEPTO"
                Me.dgvLineas.Rows(e.RowIndex).Cells("concepto").ErrorText = "Concepto invalido"
                lineaValida = False
            End With
        Else : Me.dgvLineas.Rows(e.RowIndex).Cells("concepto").ErrorText = Nothing
            Me.dgvLineas.Rows(e.RowIndex).Cells("concepto").ToolTipText = Nothing
        End If

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub lblSubTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSubTipo.Click

    End Sub
End Class

