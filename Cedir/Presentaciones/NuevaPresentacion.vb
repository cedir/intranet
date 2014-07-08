Imports CedirNegocios
Imports System.Drawing.Printing
Imports System.Collections.Generic
Public Class NuevaPresentacion
    Inherits System.Windows.Forms.Form


#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByVal idFacturacion As Integer)
        'Utilizamos este constructor para abrir una presentacion ya cerrada
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cIdPresentacion = idFacturacion
        esAltaPresentacion = False
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents btnQuitarItem As System.Windows.Forms.Button
    Friend WithEvents btnMedicacion As System.Windows.Forms.Button
    Friend WithEvents lblImporteGravado As System.Windows.Forms.Label
    Friend WithEvents lblGravado As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lbltotalEstudios As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents grpComprobante As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbResponsableComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabEstudios As System.Windows.Forms.TabPage
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents btnVerAranceles As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents lblConsultas As System.Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtOSObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents cmbSubTipo As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPeriodoPresentacion As System.Windows.Forms.TextBox
    Friend WithEvents btnAnest As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstudioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbNroTerminal As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EstudioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnFacturar = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.btnQuitarItem = New System.Windows.Forms.Button
        Me.btnMedicacion = New System.Windows.Forms.Button
        Me.lblImporteGravado = New System.Windows.Forms.Label
        Me.lbltotalEstudios = New System.Windows.Forms.Label
        Me.lblGravado = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.lblConsultas = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.grpComprobante = New System.Windows.Forms.GroupBox
        Me.cmbNroTerminal = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSubTipo = New System.Windows.Forms.ComboBox
        Me.cmbGravado = New System.Windows.Forms.ComboBox
        Me.lblGuion = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNroComprobante = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox
        Me.cmbResponsableComprobante = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabEstudios = New System.Windows.Forms.TabPage
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtOSObservaciones = New System.Windows.Forms.TextBox
        Me.btnVerAranceles = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.btnAnest = New System.Windows.Forms.Button
        Me.lblObraSocial = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPeriodoPresentacion = New System.Windows.Forms.TextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpComprobante.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabEstudios.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.Location = New System.Drawing.Point(16, 16)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(344, 21)
        Me.cmbObraSocial.TabIndex = 0
        Me.cmbObraSocial.Text = "Seleccione una Obra Social.."
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(0, 8)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(828, 200)
        Me.DataGrid1.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.EstudioToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(127, 48)
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'EstudioToolStripMenuItem
        '
        Me.EstudioToolStripMenuItem.Name = "EstudioToolStripMenuItem"
        Me.EstudioToolStripMenuItem.Size = New System.Drawing.Size(126, 22)
        Me.EstudioToolStripMenuItem.Text = "Estudio"
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(24, 464)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(72, 24)
        Me.btnFacturar.TabIndex = 2
        Me.btnFacturar.Text = "Finalizar"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(16, 125)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(152, 24)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total: $ "
        '
        'btnQuitarItem
        '
        Me.btnQuitarItem.Location = New System.Drawing.Point(7, 24)
        Me.btnQuitarItem.Name = "btnQuitarItem"
        Me.btnQuitarItem.Size = New System.Drawing.Size(104, 24)
        Me.btnQuitarItem.TabIndex = 4
        Me.btnQuitarItem.Text = "Quitar"
        '
        'btnMedicacion
        '
        Me.btnMedicacion.Location = New System.Drawing.Point(7, 54)
        Me.btnMedicacion.Name = "btnMedicacion"
        Me.btnMedicacion.Size = New System.Drawing.Size(104, 23)
        Me.btnMedicacion.TabIndex = 5
        Me.btnMedicacion.Text = "Medicación"
        '
        'lblImporteGravado
        '
        Me.lblImporteGravado.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblImporteGravado.Location = New System.Drawing.Point(16, 96)
        Me.lblImporteGravado.Name = "lblImporteGravado"
        Me.lblImporteGravado.Size = New System.Drawing.Size(152, 23)
        Me.lblImporteGravado.TabIndex = 7
        Me.lblImporteGravado.Text = "Gravado: $"
        '
        'lbltotalEstudios
        '
        Me.lbltotalEstudios.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbltotalEstudios.Location = New System.Drawing.Point(16, 24)
        Me.lbltotalEstudios.Name = "lbltotalEstudios"
        Me.lbltotalEstudios.Size = New System.Drawing.Size(144, 23)
        Me.lbltotalEstudios.TabIndex = 8
        Me.lbltotalEstudios.Text = "Estudios: $"
        '
        'lblGravado
        '
        Me.lblGravado.Location = New System.Drawing.Point(11, 110)
        Me.lblGravado.Name = "lblGravado"
        Me.lblGravado.Size = New System.Drawing.Size(79, 13)
        Me.lblGravado.TabIndex = 10
        Me.lblGravado.Text = "% Gravado :"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(200, 464)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 23)
        Me.btnImprimir.TabIndex = 12
        Me.btnImprimir.Text = "Imprimir"
        '
        'lblConsultas
        '
        Me.lblConsultas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblConsultas.Location = New System.Drawing.Point(16, 48)
        Me.lblConsultas.Name = "lblConsultas"
        Me.lblConsultas.Size = New System.Drawing.Size(144, 23)
        Me.lblConsultas.TabIndex = 15
        Me.lblConsultas.Text = "Consultas: $ 0"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblConsultas)
        Me.GroupBox1.Controls.Add(Me.lblImporteGravado)
        Me.GroupBox1.Controls.Add(Me.lbltotalEstudios)
        Me.GroupBox1.Location = New System.Drawing.Point(576, 304)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 152)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Importes Totales"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Location = New System.Drawing.Point(16, 72)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(152, 23)
        Me.lblSubTotal.TabIndex = 16
        Me.lblSubTotal.Text = "SubTotal: $ 0"
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(384, 16)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 17
        Me.btnAgregar.Text = "Agregar"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(112, 464)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 18
        Me.btnGuardar.Text = "Guardar"
        '
        'grpComprobante
        '
        Me.grpComprobante.Controls.Add(Me.cmbNroTerminal)
        Me.grpComprobante.Controls.Add(Me.Label1)
        Me.grpComprobante.Controls.Add(Me.cmbSubTipo)
        Me.grpComprobante.Controls.Add(Me.cmbGravado)
        Me.grpComprobante.Controls.Add(Me.lblGuion)
        Me.grpComprobante.Controls.Add(Me.Label5)
        Me.grpComprobante.Controls.Add(Me.txtNroComprobante)
        Me.grpComprobante.Controls.Add(Me.Label6)
        Me.grpComprobante.Controls.Add(Me.Label4)
        Me.grpComprobante.Controls.Add(Me.cmbTipoComprobante)
        Me.grpComprobante.Controls.Add(Me.lblGravado)
        Me.grpComprobante.Controls.Add(Me.cmbResponsableComprobante)
        Me.grpComprobante.Location = New System.Drawing.Point(254, 304)
        Me.grpComprobante.Name = "grpComprobante"
        Me.grpComprobante.Size = New System.Drawing.Size(316, 151)
        Me.grpComprobante.TabIndex = 21
        Me.grpComprobante.TabStop = False
        Me.grpComprobante.Text = "Comprobante"
        '
        'cmbNroTerminal
        '
        Me.cmbNroTerminal.Items.AddRange(New Object() {"0001", "0090"})
        Me.cmbNroTerminal.Location = New System.Drawing.Point(108, 17)
        Me.cmbNroTerminal.Name = "cmbNroTerminal"
        Me.cmbNroTerminal.Size = New System.Drawing.Size(71, 21)
        Me.cmbNroTerminal.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Sub-tipo"
        '
        'cmbSubTipo
        '
        Me.cmbSubTipo.FormattingEnabled = True
        Me.cmbSubTipo.Items.AddRange(New Object() {"A", "B"})
        Me.cmbSubTipo.Location = New System.Drawing.Point(268, 43)
        Me.cmbSubTipo.Name = "cmbSubTipo"
        Me.cmbSubTipo.Size = New System.Drawing.Size(38, 21)
        Me.cmbSubTipo.TabIndex = 34
        '
        'cmbGravado
        '
        Me.cmbGravado.FormattingEnabled = True
        Me.cmbGravado.Location = New System.Drawing.Point(197, 107)
        Me.cmbGravado.Name = "cmbGravado"
        Me.cmbGravado.Size = New System.Drawing.Size(109, 21)
        Me.cmbGravado.TabIndex = 33
        Me.cmbGravado.Text = "Seleccione..."
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Location = New System.Drawing.Point(185, 20)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(10, 13)
        Me.lblGuion.TabIndex = 32
        Me.lblGuion.Text = "-"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Número :"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(201, 17)
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.ReadOnly = True
        Me.txtNroComprobante.Size = New System.Drawing.Size(105, 20)
        Me.txtNroComprobante.TabIndex = 26
        Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Comprobante:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Responsable: "
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.Items.AddRange(New Object() {""})
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(108, 43)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(109, 21)
        Me.cmbTipoComprobante.TabIndex = 12
        Me.cmbTipoComprobante.Text = "Seleccione.."
        '
        'cmbResponsableComprobante
        '
        Me.cmbResponsableComprobante.Location = New System.Drawing.Point(197, 76)
        Me.cmbResponsableComprobante.Name = "cmbResponsableComprobante"
        Me.cmbResponsableComprobante.Size = New System.Drawing.Size(109, 21)
        Me.cmbResponsableComprobante.TabIndex = 23
        Me.cmbResponsableComprobante.Text = "Seleccione..."
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(609, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 23)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Fecha:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabEstudios)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(8, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(839, 248)
        Me.TabControl1.TabIndex = 24
        '
        'TabEstudios
        '
        Me.TabEstudios.Controls.Add(Me.DataGrid1)
        Me.TabEstudios.Location = New System.Drawing.Point(4, 22)
        Me.TabEstudios.Name = "TabEstudios"
        Me.TabEstudios.Size = New System.Drawing.Size(831, 222)
        Me.TabEstudios.TabIndex = 0
        Me.TabEstudios.Text = "Estudios"
        Me.TabEstudios.UseVisualStyleBackColor = True
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label8)
        Me.TabPage1.Controls.Add(Me.txtOSObservaciones)
        Me.TabPage1.Controls.Add(Me.btnVerAranceles)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(831, 222)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "Ayuda"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(272, 40)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 16)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Observaciones"
        '
        'txtOSObservaciones
        '
        Me.txtOSObservaciones.Location = New System.Drawing.Point(8, 64)
        Me.txtOSObservaciones.Multiline = True
        Me.txtOSObservaciones.Name = "txtOSObservaciones"
        Me.txtOSObservaciones.ReadOnly = True
        Me.txtOSObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtOSObservaciones.Size = New System.Drawing.Size(600, 96)
        Me.txtOSObservaciones.TabIndex = 2
        '
        'btnVerAranceles
        '
        Me.btnVerAranceles.Location = New System.Drawing.Point(16, 24)
        Me.btnVerAranceles.Name = "btnVerAranceles"
        Me.btnVerAranceles.Size = New System.Drawing.Size(75, 23)
        Me.btnVerAranceles.TabIndex = 1
        Me.btnVerAranceles.Text = "Aranceles"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(657, 13)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 20)
        Me.DateTimePicker1.TabIndex = 25
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btnAnest)
        Me.GroupBox3.Controls.Add(Me.btnQuitarItem)
        Me.GroupBox3.Controls.Add(Me.btnMedicacion)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 304)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(121, 110)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Con el item seleccionado"
        '
        'btnAnest
        '
        Me.btnAnest.Location = New System.Drawing.Point(7, 83)
        Me.btnAnest.Name = "btnAnest"
        Me.btnAnest.Size = New System.Drawing.Size(104, 23)
        Me.btnAnest.TabIndex = 6
        Me.btnAnest.Text = "Anestesia" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'lblObraSocial
        '
        Me.lblObraSocial.Location = New System.Drawing.Point(16, 16)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(328, 24)
        Me.lblObraSocial.TabIndex = 27
        Me.lblObraSocial.Text = "nombre de obra social"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(288, 464)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 28
        Me.btnCerrar.Text = "Cerrar"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(56, 417)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 16)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Período de la Presentación"
        '
        'txtPeriodoPresentacion
        '
        Me.txtPeriodoPresentacion.Location = New System.Drawing.Point(32, 433)
        Me.txtPeriodoPresentacion.Name = "txtPeriodoPresentacion"
        Me.txtPeriodoPresentacion.Size = New System.Drawing.Size(184, 20)
        Me.txtPeriodoPresentacion.TabIndex = 37
        '
        'NuevaPresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(859, 506)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPeriodoPresentacion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblObraSocial)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.grpComprobante)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnFacturar)
        Me.Controls.Add(Me.cmbObraSocial)
        Me.Name = "NuevaPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.grpComprobante.ResumeLayout(False)
        Me.grpComprobante.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabEstudios.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

#Region "VARIABLES DE INSTANCIA"

    Dim cIdPresentacion As Integer
    Dim cPresentacion As Presentacion
    Friend WithEvents lblGuion As System.Windows.Forms.Label
    Friend WithEvents cmbGravado As System.Windows.Forms.ComboBox
    Dim esAltaPresentacion As Boolean = True

    Dim arrObraSocial As ArrayList
    Dim catalogoFacturaciones As New CatalogoDePresentaciones

    Dim myTable As DataTable = New DataTable("myTable")
    Dim tableConsultas As DataTable = New DataTable("consultas")

    Dim totalMedicacion As Single = 0
    Dim totalEstudios As Single = 0
    Dim totalPension As Single = 0
    Dim iva As Single
    'Dim totalConsultas As Single = 0
    Dim totalArancelAnestesia As Decimal = 0

    'Numero de linea visual (grilla)
    Dim nroRefEstudio As Integer = 0
    Dim nroRefConsultas As Integer = 0

    Dim cPrintingEsudioLineIndex As Integer
    Dim cCatalogoDeEstudios As New CatalogoDeEstudios

    Dim gravados As New List(Of Gravado)
    Dim tiposComprobante As New List(Of TipoComprobante)

#End Region

    Private Sub NuevaPresentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        hayUnaFacturacionInstanciada = True

        Dim clNumero As DataColumn = New DataColumn("Nro", Type.GetType("System.String"))
        Dim clNumeroOrden As DataColumn = New DataColumn("Orden", Type.GetType("System.String"))
        Dim clFecha As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clnroAfiliado As DataColumn = New DataColumn("Nro Afiliado", Type.GetType("System.String"))
        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Actuante", Type.GetType("System.String"))
        Dim clImporteProOS As DataColumn = New DataColumn("Importe", Type.GetType("System.String"))
        Dim clImportePension As DataColumn = New DataColumn("Pensión", Type.GetType("System.String"))
        Dim clDiferenciaPaciente As DataColumn = New DataColumn("Dif. Paciente", Type.GetType("System.String"))
        Dim clImporteMedicacion As DataColumn = New DataColumn("Medicacion", Type.GetType("System.String"))
        Dim clImporteAnestesia As DataColumn = New DataColumn("Anestesia", Type.GetType("System.String"))

        myTable.Columns.Add(clNumero)
        myTable.Columns.Add(clFecha)
        myTable.Columns.Add(clNumeroOrden)
        myTable.Columns.Add(clnroAfiliado)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clImporteProOS)
        myTable.Columns.Add(clImportePension)
        myTable.Columns.Add(clDiferenciaPaciente)
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

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "Nro"
        TextCol1.HeaderText = "Nro"
        TextCol1.Width = 25
        ts1.GridColumnStyles.Add(TextCol1)

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Fecha"
        TextCol2.HeaderText = "Fecha"
        TextCol2.Width = 65
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Orden"
        TextCol3.HeaderText = "Orden"
        TextCol3.Width = 63
        ts1.GridColumnStyles.Add(TextCol3)

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

        Dim TextCol10 As New DataGridTextBoxColumn
        TextCol10.MappingName = "Dif. Paciente"
        TextCol10.HeaderText = "Dif. Paciente"
        TextCol10.Width = 44
        ts1.GridColumnStyles.Add(TextCol10)

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




        'cargamos el combo gravados
        Me.cargarComboGravado()
        'cargamos el combo tipo de comprobante
        Me.cargarComboTipoComprobante()

        '<---------------------------LOAD DATA--------------------------------->
        cmbResponsableComprobante.Items.Add("Seleccionar..")
        cmbResponsableComprobante.Items.Add("Cedir")
        cmbResponsableComprobante.Items.Add("Brunetti")
        lblObraSocial.Visible = False
        cmbObraSocial.Visible = False

        cmbNroTerminal.SelectedIndex = 0

        If esAltaPresentacion Then
            Me.Text = "Nueva Presentación"

            Dim os As ObraSocial
            Dim catalogoObraSocial As New CatalogoDeObrasSociales
            Dim i As Integer
            arrObraSocial = catalogoObraSocial.TodosLasObrasSociales
            For i = 0 To arrObraSocial.Count - 1
                os = New ObraSocial
                os = arrObraSocial(i)
                cmbObraSocial.Items.Add(os.ObraSocial)
            Next

            cmbObraSocial.Visible = True
            'btnAnularFactura.Visible = False
            cmbResponsableComprobante.SelectedIndex = 0

            cmbTipoComprobante.Enabled = True
            btnMedicacion.Enabled = False
            btnQuitarItem.Enabled = False
            btnAgregar.Enabled = False

            btnFacturar.Enabled = False
            btnGuardar.Enabled = False
            TabControl1.Enabled = False
        Else
            'Al pasar como parametro al constructor un idPresentacion, 
            'significa que se abrió la presentacion
            Me.Text = "Modificar presentación abierta"

            'cargar facturacion
            Dim catalogoDeFacturaciones As New CatalogoDePresentaciones
            cPresentacion = catalogoDeFacturaciones.find(cIdPresentacion)

            lblObraSocial.Visible = True
            lblObraSocial.Text = cPresentacion.obraSocial.ObraSocial

            DateTimePicker1.Text = cPresentacion.fechaFacturacion
            '  Me.cargarNroTerminalSegunObraSocial(cPresentacion.obraSocial)
            'cargo los datos del comprobante que tiene asignado la presentacion
            Me.mostrarDatosComprobante()
            txtOSObservaciones.Text = cPresentacion.obraSocial.observaciones
            cargarGrilla()
        End If

    End Sub

    Private Sub cargarComboGravado()
        Dim catGrav As New CedirNegocios.CatalogoDeGravados
        gravados = catGrav.getGravadosAll()
        For Each grav As Gravado In gravados
            cmbGravado.Items.Add(grav.porcentaje)
        Next
        catGrav = Nothing
    End Sub

    Private Sub cargarComboTipoComprobante()
        Dim catTipo As New CatalogoDeTiposComprobante
        Dim cTipos As New List(Of TipoComprobante)
        cTipos = catTipo.getTiposComprobante()
        Me.cmbTipoComprobante.Items.Clear()

        For Each t As TipoComprobante In cTipos
            If t.Id = 1 Or t.Id = 2 Then
                Me.cmbTipoComprobante.Items.Add(t.Descripcion)
                tiposComprobante.Add(t)
            End If
        Next
        catTipo = Nothing
        cTipos = Nothing
    End Sub

    Private Sub cmbObraSocial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbObraSocial.SelectedIndexChanged
        hayUnaFacturacionInstanciada = True
        Me.cmbGravado.Enabled = False
        txtNroComprobante.Enabled = False
        DataGrid1.ReadOnly = False
        'DataGrid2.ReadOnly = False
        Dim cOs As ObraSocial = arrObraSocial(cmbObraSocial.SelectedIndex)
        txtOSObservaciones.Text = cOs.observaciones
        cmbResponsableComprobante.Enabled = True
        cmbResponsableComprobante.SelectedIndex = 0
        cargarGrilla()
    End Sub

    Private Sub cargarGrilla()
        totalEstudios = 0
        totalMedicacion = 0
        iva = 0
        totalPension = 0
        ' totalConsultas = 0
        Me.totalArancelAnestesia = 0
        TabControl1.SelectedIndex = 0
        btnAgregar.Enabled = True
        TabControl1.Enabled = True
        btnMedicacion.Enabled = True
        Me.btnAnest.Enabled = True
        btnQuitarItem.Enabled = True
        btnFacturar.Enabled = True
        btnGuardar.Enabled = True
        txtNroComprobante.Enabled = True
        cmbGravado.Enabled = True
        nroRefEstudio = 0
        nroRefConsultas = 0

        If esAltaPresentacion Then
            Dim cOs As ObraSocial = arrObraSocial(cmbObraSocial.SelectedIndex)
            cPresentacion = New Presentacion
            cPresentacion.obraSocial = cOs
            cPresentacion.inicilizarFacturacion()
        Else
            cPresentacion.cargarFacturacion()
        End If

        Dim cLineaEstudio As LineaDeFacturacion
        Dim NewRow As DataRow
        Dim i As Integer

        'Estudios
        Dim arrLineasEstudios As ArrayList
        arrLineasEstudios = cPresentacion.getLineasDeFacturacionEstudios()

        myTable.Clear()
        For i = 0 To arrLineasEstudios.Count - 1
            cLineaEstudio = arrLineasEstudios(i)
            Dim totalParcialEstudio As Single = cLineaEstudio.importe
            Dim totalParcialPension As Single = cLineaEstudio.pension

            NewRow = myTable.NewRow()
            nroRefEstudio += 1
            NewRow("Nro") = nroRefEstudio
            NewRow("Fecha") = cLineaEstudio.estudio.fechaEstudio
            NewRow("Orden") = cLineaEstudio.estudio.nroOrden
            NewRow("Paciente") = cLineaEstudio.estudio.paciente.apellido & ", " & cLineaEstudio.estudio.paciente.nombres
            NewRow("Práctica") = cLineaEstudio.estudio.practica.Estudio
            NewRow("Actuante") = cLineaEstudio.estudio.medicoActuante.apellido & ", " & cLineaEstudio.estudio.medicoActuante.nombre
            NewRow("Importe") = totalParcialEstudio
            NewRow("Nro Afiliado") = cLineaEstudio.estudio.paciente.nroAfiliado
            NewRow("Pensión") = totalParcialPension
            NewRow("Dif. Paciente") = cLineaEstudio.diferenciaPaciente

            Dim totalParcialMedicacion As Single = cLineaEstudio.estudio.getTotalMedicacion
            NewRow("Medicacion") = totalParcialMedicacion

            NewRow("Anestesia") = cLineaEstudio.estudio.ArancelAnestesia

            myTable.Rows.Add(NewRow)


            'Totales
            totalEstudios = totalEstudios + totalParcialEstudio - cLineaEstudio.diferenciaPaciente
            totalPension = totalPension + totalParcialPension
            totalMedicacion += cLineaEstudio.estudio.getTotalMedicacion
            Me.totalArancelAnestesia += cLineaEstudio.estudio.ArancelAnestesia

        Next
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable


        calcularIva()
        setTotalesLabels()
    End Sub

    Private Sub btnQuitarItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarItem.Click
        'quitar item de la grilla
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
                Dim totalParcialMedicacion As Single = cLinea.estudio.getTotalMedicacion()

                success = cPresentacion.quitarLineaDeEstudios(i)
                If success Then
                    myTable.Rows(i).Delete()
                    myTable.AcceptChanges()
                    DataGrid1.DataSource = myTable
                    totalMedicacion -= totalParcialMedicacion

                    calcularTotalEstudios()
                Else
                    MsgBox("Se ha producido un error al intentar quitar el estudio. Vuelva a intentarlo.")
                End If
            End If



        End If


    End Sub

    Private Sub btnMedicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedicacion.Click
        Dim i As Integer

        i = DataGrid1.CurrentRowIndex
        If i = -1 Then
            MsgBox("No se ha seleccionado ningún estudio", MsgBoxStyle.Critical)
        Else
            Dim est As Estudio
            est = cPresentacion.getLineasDeFacturacionEstudios(i).estudio
            Dim frm As New AgragarMedicacion(est, True)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        End If

    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        calcularTotalEstudios()
    End Sub

    Private Sub DataGrid2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        ' calcularTotalConsultas()
    End Sub

    Private Sub NuevaFacturacion_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LostFocus
        'cada vez que se recupera el foco, verificar si se necesita cargar la medicacion o
        'añadir algun estudio a la facturacion.
        If hayUnaFacturacionInstanciada Then
            If nroEstudioParaFacturacion <> 0 Then
                'añadir estudio
                Dim ok As Boolean = agregarLineaDeEstudio(nroEstudioParaFacturacion)
                nroEstudioParaFacturacion = 0

                If Not ok Then
                    MsgBox("El estudio ya forma parte de la facturación", MsgBoxStyle.Critical, "Error")
                End If

            End If

            If nroEstudioParaCargarMedicacion <> 0 Then
                'Leer archivo politicas internas para ver este tema
                cargarMedicacion(nroEstudioParaCargarMedicacion)
                If posibleErrorEnMedicacion Then
                    'Si esto ocurre demasiado y confunde, hacer que se concatenen es un str los nros de estudios que se modifican, luego que se parseen y se cargue la med. de aquellos estudios que estan en la fact.
                    MsgBox("Es posible que la medicación de uno o más estudios haya sido modificada y la facturación se encuntre desactualizada. Compruebe que la medicación de cada estudio este cargada correctamente. ", MsgBoxStyle.Exclamation, "Posible error")
                    posibleErrorEnMedicacion = False
                End If
                nroEstudioParaCargarMedicacion = 0
            End If

        End If
    End Sub



    Private Sub btnVerAranceles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerAranceles.Click
        Dim frm As New DetalleObraSocial(cPresentacion.obraSocial)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim frm As New AgregarEstudioAFacturacion(cPresentacion.obraSocial)
        frm.MdiParent = Me.Parent.Parent
        frm.listaEstudiosPresentados = Me.cPresentacion.getLineasDeFacturacionEstudios()
        frm.Show()
    End Sub
    Private Function agregarLineaDeEstudio(ByVal nro As Int64) As Boolean

        Dim cLinea As New LineaDeFacturacion
        Dim nuevoEstudio As Estudio
        nuevoEstudio = cCatalogoDeEstudios.traerEstudioConArancel(nro)
        cLinea.estudio = nuevoEstudio
        cLinea.estado = "noEstaEnFacturacion"
        cLinea.importe = nuevoEstudio.ImportePorObraSocial
        Dim resp As Boolean = cPresentacion.addLineaEstudio(cLinea)
        If resp Then
            'cargar estudio en la grilla
            nroRefEstudio += 1
            Dim NewRow As DataRow = myTable.NewRow()
            NewRow("Nro") = nroRefEstudio
            NewRow("Fecha") = nuevoEstudio.fechaEstudio
            NewRow("Pensión") = nuevoEstudio.pension
            NewRow("Paciente") = nuevoEstudio.paciente.apellido & ", " & nuevoEstudio.paciente.nombres
            NewRow("Práctica") = nuevoEstudio.practica.Estudio
            NewRow("Actuante") = nuevoEstudio.medicoActuante.apellido & ", " & nuevoEstudio.medicoActuante.nombre
            NewRow("Importe") = nuevoEstudio.ImportePorObraSocial
            NewRow("Dif. Paciente") = nuevoEstudio.DiferenciaPaciente
            NewRow("Nro Afiliado") = nuevoEstudio.paciente.nroAfiliado
            NewRow("Orden") = nuevoEstudio.nroOrden

            cLinea.estudio.cargarMedicacion()
            Dim totalParcialMedicacion As Single = cLinea.estudio.getTotalMedicacion()
            NewRow("Medicacion") = totalParcialMedicacion
            NewRow("Anestesia") = cLinea.estudio.ArancelAnestesia

            myTable.Rows.Add(NewRow)
            myTable.AcceptChanges()
            DataGrid1.DataSource = myTable

            totalMedicacion += totalParcialMedicacion
            calcularTotalEstudios()
            Return True
        Else


            Return False
        End If


    End Function

    Private Sub cargarMedicacion(ByVal nro As Integer)
        'Detecta si corresponde cargar la medicacion nuevamente de algun estudio de la facturacion
        Dim i As Integer
        Dim cLinea As LineaDeFacturacion
        While (i < cPresentacion.getLineasDeFacturacionEstudios.Count)
            cLinea = cPresentacion.getLineasDeFacturacionEstudios(i)
            If cLinea.estudio.nroEstudio = nro Then
                cLinea.estudio.cargarMedicacion()
                Dim nuevoTotal As Single = cLinea.estudio.getTotalMedicacion
                DataGrid1.Item(i, 10) = nuevoTotal

                totalMedicacion = cPresentacion.getTotalMedicacion
                Exit While
            End If
            i += 1
        End While

        setTotalesLabels()
    End Sub
    Private Sub NuevaFacturacion_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        'vaciar datos globales
        hayUnaFacturacionInstanciada = False
        nroEstudioParaFacturacion = 0
        nroConsultaParaFacturacion = 0
        nroEstudioParaCargarMedicacion = 0
        posibleErrorEnMedicacion = False
    End Sub
    Private Sub calcularTotalEstudios()
        'Calcular total por estudios y pension - dif. pac.
        Dim i As Integer
        totalEstudios = 0
        totalPension = 0
        Me.totalArancelAnestesia = 0

        For i = 0 To cPresentacion.getLineasDeFacturacionEstudios.Count - 1
            totalEstudios += (CSng(DataGrid1.Item(i, 7)) - CSng(DataGrid1.Item(i, 9)))
            totalPension += CSng(DataGrid1.Item(i, 8))
            Me.totalArancelAnestesia += Convert.ToDecimal(DataGrid1.Item(i, 11))
        Next

        setTotalesLabels()
    End Sub

    Private Sub calcularIva()
        Dim totalParcialEstudios As Single = totalEstudios + totalMedicacion + totalPension
        Dim cIva As Single
        If cmbGravado.SelectedIndex = -1 Then
            cIva = 0
        Else
            cIva = CSng(cmbGravado.SelectedItem.ToString)
        End If
        iva = (totalParcialEstudios) * cIva / 100

        iva = Math.Round(iva, 2)
    End Sub

    Private Sub setTotalesLabels()
        Dim total As Single
        Dim totalParcialEstudios As Single = totalEstudios + Math.Round(totalMedicacion, 2) + totalPension + Me.totalArancelAnestesia
        Dim subTotal As Single = totalParcialEstudios '+ totalConsultas
        calcularIva()

        'MsgBox("Est: " & CStr(totalEstudios) & " Pen: " & CStr(totalPension) & " Med: " & CStr(totalMedicacion))
        total = subTotal + iva
        lbltotalEstudios.Text = "Estudios: $ " & Str(totalParcialEstudios)
        '  lblConsultas.Text = "Consultas: $ " & Str(totalConsultas)
        lblSubTotal.Text = "Subtotal: $ " & Str(Math.Round(subTotal, 2))
        lblImporteGravado.Text = "Gravado: $ " & Str(iva)
        lblTotal.Text = "Total: $ " & Str(Math.Round(total, 2))
    End Sub

    Private Sub txtIva_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        setTotalesLabels()
    End Sub

    Private Sub cmbResponsableFactura_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbResponsableComprobante.SelectedIndexChanged

        calcularUltimoNro()

    End Sub

    Private Function validateData() As Boolean


        If cPresentacion.getLineasDeFacturacionEstudios.Count = 0 Then
            MsgBox("No hay estudios ni consultas para facturar", MsgBoxStyle.Critical)
            Return False
        Else

            If (Me.txtPeriodoPresentacion.Text = "") Then
                MsgBox("Ingrese período", MsgBoxStyle.Critical)
                Return False
            Else
                Return True
            End If
        End If
    End Function

    Private Function cargaComprobante() As Boolean
        Dim res As DialogResult = MessageBox.Show("¿No desea asignar un comprobante" + vbCrLf + "a la presentacion?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If res = Windows.Forms.DialogResult.Yes Then
            Return True
        Else : Return False
        End If
    End Function

    Private Function validarDatosComprobante() As Boolean
        validarDatosComprobante = True

        If Me.cmbTipoComprobante.SelectedIndex = -1 Then
            MsgBox("No se seleccionó un tipo de comprobante", MsgBoxStyle.Critical)
            Return False
        Else

            'Validamos que entre nro de comprobante
            If Me.txtNroComprobante.Text = "" Then
                MsgBox("Debe ingresar un número de comprobante", MsgBoxStyle.Critical)
                Return False
            End If

            'Si el comprobante no es una liquidación no hay que validar que haya completado los demas
            'campos
            If Me.cmbTipoComprobante.SelectedItem.ToString.ToUpper() <> "LIQUIDACION" Then

                'el combo fue seteado en selected=0 ("seleccione...")
                If Me.cmbResponsableComprobante.SelectedIndex = 0 Then
                    MsgBox("Debe seleccionar un responsable de comprobante", MsgBoxStyle.Critical)
                    Return False
                End If
                If Me.cmbGravado.SelectedIndex = -1 Then
                    MsgBox("Debe seleccionar el porcentaje de gravado a aplicar", MsgBoxStyle.Critical)
                    Return False
                End If
                'Validamos que si se selecciona una factura, ésta debe ser tipo A ó B
                If Me.cmbSubTipo.SelectedIndex = -1 Then
                    MsgBox("Debe seleccionar el subtipo de gravado a aplicar", MsgBoxStyle.Critical)
                    Return False
                End If

            Else : Return True

            End If




        End If
    End Function

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click

        If btnFacturar.Enabled Then
            'Me da la pauta que todavia no se guardo la facturacion
            If TabControl1.SelectedIndex = 0 Then
                'Estudios
                btnMedicacion.Enabled = True
                Me.btnAnest.Enabled = True
                btnQuitarItem.Enabled = True
            ElseIf TabControl1.SelectedIndex = 1 Then
                'Consultas
                btnMedicacion.Enabled = False

                btnQuitarItem.Enabled = True
            ElseIf TabControl1.SelectedIndex = 2 Then
                'Ayuda
                btnMedicacion.Enabled = False
                btnQuitarItem.Enabled = False
            End If
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub cmbGravado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbGravado.SelectedIndexChanged
        Me.iva = CSng(Me.cmbGravado.SelectedItem.ToString)
        Me.setTotalesLabels()
    End Sub

    Private Sub cmbTipoComprobante_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoComprobante.SelectedIndexChanged
        If Me.cmbTipoComprobante.SelectedItem.ToString.ToUpper = "LIQUIDACION" Then
            Me.cmbSubTipo.Enabled = False
            Me.cmbGravado.Enabled = False
            Me.cmbResponsableComprobante.Enabled = False
            Me.cmbNroTerminal.Visible = False
            'Me.txtNroTerminal.Visible = False
            Me.lblGuion.Visible = False
            Me.txtNroComprobante.Location = New Point(108, 17)
            Me.txtNroComprobante.Width = 200
            Me.cmbGravado.SelectedIndex = 0 'iva 0%
            Me.setTotalesLabels()

        Else
            Me.cmbResponsableComprobante.Enabled = True
            Me.cmbSubTipo.Enabled = True
            Me.cmbGravado.Enabled = True
            ' Me.txtNroTerminal.Visible = True
            Me.cmbNroTerminal.Visible = True
            Me.lblGuion.Visible = True
            Me.txtNroComprobante.Location = New Point(201, 17)
            Me.txtNroComprobante.Width = 105
        End If
        'Ahora traemos el nro de comprobante que tendrían que ingresar en el txtNroComprobante
        Dim c As New CatalogoDeComprobantes
        Me.txtNroComprobante.Text = (c.getUltimoNro(Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id, , , Convert.ToInt16(Me.cmbNroTerminal.SelectedItem)) + 1.ToString())
        c = Nothing

        Me.setTotalesLabels()
        Me.calcularUltimoNro()
    End Sub


    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        Dim respValidador As Boolean = validateData()

        If respValidador Then
            'Actualizar los arreglos lineas y guardar
            calcularTotalEstudios()
            '  calcularTotalConsultas()
            Dim r As Integer
            r = MsgBox("¿Esta seguro que desea crear la presentación?", MsgBoxStyle.YesNo, "Crear Presentación")
            If r = 6 Then

                cPresentacion.fechaFacturacion = DateTimePicker1.Value.Date
                cPresentacion.pagado = 0
                cPresentacion.periodo = Me.txtPeriodoPresentacion.Text


                Dim i As Integer = 0
                Dim resp As String
                Dim cLinea As LineaDeFacturacion
                'estudios
                While (i < cPresentacion.getLineasDeFacturacionEstudios.Count)
                    cLinea = cPresentacion.getLineasDeFacturacionEstudios(i)
                    cLinea.importe = CSng(DataGrid1.Item(i, 7))
                    cLinea.pension = CSng(DataGrid1.Item(i, 8))
                    cLinea.diferenciaPaciente = CSng(DataGrid1.Item(i, 9))
                    cLinea.estudio.nroOrden = DataGrid1.Item(i, 2)
                    cLinea.estudio.importeMedicacion = Convert.ToDecimal(Me.DataGrid1.Item(i, 10))
                    cLinea.estudio.ArancelAnestesia = Convert.ToDecimal(Me.DataGrid1.Item(i, 11))
                    i += 1
                End While
                'consultas
                i = 0


                If Me.validarDatosComprobante Then
                    cPresentacion.comprobante.NroComprobante = Convert.ToInt32(Me.txtNroComprobante.Text)
                    cPresentacion.comprobante.NroTerminal = Convert.ToInt32(Me.cmbNroTerminal.SelectedItem)

                    cPresentacion.comprobante.TipoComprobante = Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex)
                    'tenemos que vaciar los campos que no correspondan si es una liquidacion
                    'Tenemos en cuenta que si no es un alta, la liquidacion ya existe y mantenemos la misma

                    If cPresentacion.comprobante.TipoComprobante.Id = 2 Then
                        cPresentacion.comprobante.Responsable = ""
                        cPresentacion.comprobante.SubTipo = ""
                        cPresentacion.comprobante.Gravado = Nothing
                    Else
                        'Si no es liquidación, dejo los datos que ya estaban seteados 
                        cPresentacion.comprobante.Gravado = Me.gravados(Me.cmbGravado.SelectedIndex)
                        cPresentacion.comprobante.Responsable = Me.cmbResponsableComprobante.SelectedItem.ToString
                        cPresentacion.comprobante.SubTipo = Me.cmbSubTipo.SelectedItem
                    End If


                    'checkeamos que el compronante no exista
                    If Not cPresentacion.comprobante.doesExist Then

                        'cargamos los datos comunes para todos los tipos de comprobantes
                        cPresentacion.comprobante.FechaEmision = Date.Today
                        cPresentacion.comprobante.NombreCliente = Me.cPresentacion.obraSocial.ObraSocial
                        cPresentacion.comprobante.CondicionFiscal = Me.cPresentacion.obraSocial.CondicionFiscal
                        cPresentacion.comprobante.DomicilioCliente = Me.cPresentacion.obraSocial.direccion & " - " & Me.cPresentacion.obraSocial.localidad & " - " & "(CP:" & Me.cPresentacion.obraSocial.CodigoPostal.ToString() & ")"
                        cPresentacion.comprobante.NroCuit = Me.cPresentacion.obraSocial.nroCuit
                        'El comprobante creado no es cobrado hasta que vuelve de la OS
                        cPresentacion.comprobante.Estado = "NO COBRADO"
                        cPresentacion.comprobante.Factura = Nothing
                        'calculamos comprobante.totalFacturado como el presentacion.total+iva 

                        cPresentacion.crearComprobante()


                    ElseIf cPresentacion.comprobante.TipoComprobante.Id <> 2 Then
                        MessageBox.Show("El comprobante ya existe." + vbCrLf + "No es posible", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'salimos del metodo y no guardamos nada
                        Exit Sub
                    End If

                    If esAltaPresentacion Then
                        resp = cPresentacion.crear()
                    Else
                        resp = cPresentacion.guardar(True, True)
                    End If

                    If resp = "ok" Then
                        'Imprimir detalle
                        r = MsgBox("Se va a imprimir el detalle de la presentación, presione Aceptar cuando este listo.", MsgBoxStyle.YesNo, "Imprimir detalle")
                        If r = 6 Then
                            imprimir()
                        End If
                        'Imprimir Comprobante si es una factura
                        If cPresentacion.comprobante.TipoComprobante.Id = 1 Then
                            r = MsgBox("Se va a imprimir el comprobante " & cPresentacion.comprobante.TipoComprobante.Descripcion & " de Cedir, presione Aceptar cuando este listo.", MsgBoxStyle.YesNo, "Imprimir Comprobante")
                            If r = 6 Then
                                'prepareImprimirFactura()
                                Me.imprimirComprobante()
                            End If
                        End If

                        MsgBox("La presentación se ha creado con éxito")
                        btnFacturar.Enabled = False
                        btnGuardar.Enabled = False
                        Me.btnAnest.Enabled = False
                        btnAgregar.Enabled = False
                        btnMedicacion.Enabled = False
                        btnQuitarItem.Enabled = False
                        Me.cmbSubTipo.Enabled = False
                        cmbResponsableComprobante.Enabled = False
                        cmbTipoComprobante.Enabled = False
                        btnImprimir.Enabled = True
                        cmbGravado.Enabled = False
                        txtNroComprobante.Enabled = False

                        'Esto es para que no se modifique la facturacion y se imprima otra cosa, una vez que se guardo
                        DataGrid1.ReadOnly = True
                        '   DataGrid2.ReadOnly = True

                        'global
                        hayUnaFacturacionInstanciada = False
                        actualizarListadoFacturaciones = True
                    Else
                        MsgBox("Se ha prudicido un error al intentar guardar: " & resp)
                    End If


                End If
            End If
        Else
            MessageBox.Show("Los datos no fueron cargados correctamente", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        Dim respValidador As Boolean = validateData()

        If respValidador Then
            'Actualizar los arreglos lineas y guardar
            calcularTotalEstudios()
            ' calcularTotalConsultas()
            Dim r As Integer
            r = MsgBox("¿Esta seguro que desea guardar la presentación?", MsgBoxStyle.YesNo, "Guardar Presentación")



            If r = 6 Then

                cPresentacion.fechaFacturacion = DateTimePicker1.Value.Date

                cPresentacion.pagado = 2

                Dim i As Integer = 0
                Dim resp As String
                Dim cLinea As LineaDeFacturacion
                'estudios
                While (i < cPresentacion.getLineasDeFacturacionEstudios.Count)
                    cLinea = cPresentacion.getLineasDeFacturacionEstudios(i)
                    cLinea.importe = CSng(DataGrid1.Item(i, 7))
                    cLinea.pension = CSng(DataGrid1.Item(i, 8))
                    cLinea.diferenciaPaciente = CSng(DataGrid1.Item(i, 9))
                    cLinea.estudio.nroOrden = DataGrid1.Item(i, 2)
                    cLinea.estudio.ArancelAnestesia = Convert.ToDecimal(Me.DataGrid1.Item(i, 11))

                    i += 1
                End While


                'NO GUARDAMOS NADA DE COMPROBANTES, ya que no es finalizar.


                If esAltaPresentacion Then
                    resp = cPresentacion.crear()
                Else
                    resp = cPresentacion.guardar(True)
                End If

                If resp = "ok" Then
                    btnFacturar.Enabled = False
                    btnGuardar.Enabled = False
                    btnAgregar.Enabled = False
                    btnMedicacion.Enabled = False
                    Me.btnAnest.Enabled = False
                    btnQuitarItem.Enabled = False
                    cmbGravado.Enabled = False
                    txtNroComprobante.Enabled = False
                    cmbResponsableComprobante.Enabled = False
                    cmbTipoComprobante.Enabled = False
                    Me.cmbSubTipo.Enabled = False

                    'Global
                    hayUnaFacturacionInstanciada = False
                    actualizarListadoFacturaciones = True

                    MsgBox("La presentación se ha guardado con éxito")
                Else
                    MsgBox("Se ha prudicido un error al intentar guardar: " & resp)
                End If

            End If
        End If

    End Sub

    Private Sub mostrarDatosComprobante()

        Me.cmbTipoComprobante.SelectedItem = cPresentacion.comprobante.TipoComprobante.Descripcion
        Me.cmbResponsableComprobante.SelectedText = cPresentacion.comprobante.Responsable
        If cPresentacion.comprobante.TipoComprobante.Descripcion.ToUpper() = "FACTURA" Then

            Me.cmbSubTipo.SelectedText = cPresentacion.comprobante.SubTipo
            Me.cmbGravado.SelectedItem = cPresentacion.comprobante.Gravado.porcentaje

        End If
        Me.txtNroComprobante.Text = cPresentacion.comprobante.NroComprobante


    End Sub

    Private Sub calcularUltimoNro()
        Dim c As New CatalogoDeComprobantes

        If ((Me.cmbResponsableComprobante.SelectedItem <> Nothing) And (Me.cmbSubTipo.SelectedItem <> Nothing) Or (Me.cmbTipoComprobante.SelectedItem <> Nothing)) Then
            If Me.cmbTipoComprobante.SelectedItem <> Nothing Then
                If Me.cmbTipoComprobante.SelectedItem.ToString.ToUpper() = "LIQUIDACION" Then
                    Me.txtNroComprobante.Text = (c.getUltimoNro(Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id) + 1).ToString()
                ElseIf ((Me.cmbResponsableComprobante.SelectedItem <> Nothing) And (Me.cmbSubTipo.SelectedItem <> Nothing)) Then

                    Me.txtNroComprobante.Text = (c.getUltimoNro(Me.tiposComprobante(Me.cmbTipoComprobante.SelectedIndex).Id, Me.cmbResponsableComprobante.SelectedItem.ToString(), Me.cmbSubTipo.SelectedItem, Convert.ToInt16(Me.cmbNroTerminal.SelectedItem)) + 1).ToString()
                End If
            End If
        End If
        c = Nothing
    End Sub

    Private Sub DescripcionAnestesia()

    End Sub


#Region "IMPRIMIR"
    '<-------------------------------------Fackin Imprimir-------------------------------->
    'Imprimimos el comprobante con CrystalReport
    Private Sub imprimirComprobante()
        Dim f As New rptViewer
        Me.AddOwnedForm(f)
        f.cargarDsComprobantes(cPresentacion.comprobante, True)
        f.ShowDialog()
    End Sub

    Private Sub imprimir()
        Dim imprimir As New ImprimirDetalle
        imprimir.esFacturacionDetalle = False
        imprimir.presentacion = cPresentacion
        imprimir.Datagrid1 = Me.DataGrid1
        imprimir.prepareImprimirDetalle()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        imprimir()

        '  prepareImprimirDetalle()
    End Sub
    'Private Sub prepareImprimirDetalle()
    '    Dim SalesReport As New PrintDocument
    '    AddHandler SalesReport.PrintPage, AddressOf imprimirDetalleFacturacion

    '    'Imprimir
    '    cPrintingEsudioLineIndex = 0
    '    Dim pss As New PrintDialog
    '    Dim bp As DialogResult
    '    pss.Document = SalesReport
    '    bp = pss.ShowDialog
    '    If bp = DialogResult.OK Then
    '        SalesReport.Print()
    '    End If

    'End Sub
    'Sub imprimirDetalleFacturacion(ByVal sender As Object, ByVal e As PrintPageEventArgs)

    '    Dim tituloFacturacion As New Font("Arial", 12, FontStyle.Bold)
    '    Dim subTitulo As New Font("Arial", 10, FontStyle.Regular)
    '    Dim totalFont As New Font("Arial", 10, FontStyle.Bold)
    '    Dim reportFont As New Font("Arial", 9, FontStyle.Regular)
    '    Dim reportFontHeight As Integer = reportFont.GetHeight(e.Graphics)

    '    'default page settings
    '    Dim leftMarge As Single = 100
    '    Dim pageMaxHeight As Integer = 1000
    '    Dim yStart As Integer = 230
    '    Dim CurrentY As Integer = yStart

    '    Dim color As New Color
    '    Dim myPen As New System.Drawing.Pen(color.Black)
    '    myPen.Alignment = Drawing2D.PenAlignment.Center
    '    myPen.Width = 1

    '    'Dim height As Single = 100.0F
    '    Dim drawRect As New RectangleF
    '    drawRect.X = leftMarge
    '    drawRect.Width = 700.0F
    '    drawRect.Height = reportFontHeight

    '    Dim rectMedicacion As New RectangleF
    '    rectMedicacion.X = leftMarge
    '    rectMedicacion.Width = 300 - leftMarge
    '    rectMedicacion.Height = reportFontHeight

    '    'Encabezado de detalle
    '    If cPrintingEsudioLineIndex = 0 Then
    '        Dim rectTitulo As New RectangleF
    '        rectTitulo.X = leftMarge
    '        rectTitulo.Width = 700.0F
    '        rectTitulo.Height = 18
    '        'Obra social
    '        rectTitulo.Y = CurrentY - reportFontHeight
    '        e.Graphics.DrawString("Obra Social: " & cPresentacion.obraSocial.ObraSocial, tituloFacturacion, Brushes.Black, rectTitulo)

    '        'Descripcion
    '        CurrentY = CurrentY + 30
    '        drawRect.Y = CurrentY - reportFontHeight

    '        e.Graphics.DrawString("Detalle de Facturación correspondiente al mes de " & cPresentacion.periodo, subTitulo, Brushes.Black, drawRect)

    '        'fecha
    '        CurrentY = CurrentY + 20
    '        drawRect.Y = CurrentY - reportFontHeight
    '        e.Graphics.DrawString("Fecha: " & cPresentacion.fechaFacturacion, subTitulo, Brushes.Black, drawRect)

    '        'Linea horizontal
    '        CurrentY = CurrentY + 20
    '        e.Graphics.DrawLine(myPen, 100, CurrentY, 700, CurrentY)

    '        CurrentY = CurrentY + 15
    '    End If

    '    '<----------------------------------------------------------->

    '    Dim i, j As Integer
    '    Dim cLinea As LineaDeFacturacion

    '    'calcular tamaño linea
    '    cLinea = cPresentacion.getLineasDeFacturacionEstudios(cPrintingEsudioLineIndex)
    '    Dim cSize As Single = Me.getLineaSize(cLinea)
    '    Dim estimateY As Single = CurrentY + cSize
    '    While (estimateY <= pageMaxHeight And cPrintingEsudioLineIndex < cPresentacion.getLineasDeFacturacionEstudios.Count)
    '        Dim cEstudio As Estudio = cLinea.estudio
    '        'Fecha
    '        e.Graphics.DrawString("Fecha: " & cEstudio.fechaEstudio, reportFont, Brushes.Black, leftMarge, CurrentY)
    '        CurrentY = CurrentY + 20

    '        'Paciente
    '        Dim strPaciente As String = "Paciente: " & cLinea.estudio.paciente.nombreCompleto
    '        If DataGrid1.Item(cPrintingEsudioLineIndex, 3) <> "" Then
    '            'Si tiene nroAfiliado ponerlo
    '            strPaciente &= " - Nro de afiliado: " & DataGrid1.Item(cPrintingEsudioLineIndex, 3)
    '        End If
    '        e.Graphics.DrawString(strPaciente, reportFont, Brushes.Black, leftMarge, CurrentY)

    '        'Nro de orden y nro matricula medico
    '        If cLinea.estudio.nroOrden <> "" Then
    '            CurrentY = CurrentY + 20
    '            e.Graphics.DrawString("Nro de orden: " & cLinea.estudio.nroOrden, reportFont, Brushes.Black, leftMarge, CurrentY)
    '        End If
    '        If (cEstudio.medicoActuante.nroMatricula <> "" And (cEstudio.obraSocial.idObraSocial = 79 Or cEstudio.obraSocial.idObraSocial = 3)) Then
    '            'tenemos que considerar que baje de renglon si no hay nro orden
    '            If cLinea.estudio.nroOrden = "" Then
    '                CurrentY = CurrentY + 20
    '                e.Graphics.DrawString("Nro. Mat. Profesional: " & cEstudio.medicoActuante.nroMatricula, reportFont, Brushes.Black, leftMarge, CurrentY)
    '            Else
    '                e.Graphics.DrawString("Nro. Mat. Profesional: " & cEstudio.medicoActuante.nroMatricula, reportFont, Brushes.Black, 350, CurrentY)
    '            End If

    '        End If

    '        'Practica
    '        CurrentY = CurrentY + 20
    '        drawRect.Y = CurrentY
    '        e.Graphics.DrawString("Práctica: " & cEstudio.practica.Estudio, reportFont, Brushes.Black, drawRect)

    '        Dim startLine As Integer
    '        'Importe practica
    '        CurrentY = CurrentY + 28
    '        startLine = CurrentY

    '        Dim codigoPractica As String = ""
    '        If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
    '            codigoPractica = cEstudio.practica.codigoMedicoOSDE & " "
    '        End If
    '        e.Graphics.DrawString(codigoPractica & "Práctica  ", reportFont, Brushes.Black, leftMarge, CurrentY)
    '        e.Graphics.DrawString(" $" & CStr(cLinea.importe), reportFont, Brushes.Black, 460, CurrentY)

    '        'Diferencia Paciente
    '        If cLinea.diferenciaPaciente <> 0 Then
    '            CurrentY = CurrentY + 20
    '            e.Graphics.DrawString("A cargo del paciente", reportFont, Brushes.Black, leftMarge, CurrentY)
    '            e.Graphics.DrawString("  $" & cLinea.diferenciaPaciente, reportFont, Brushes.Black, 460, CurrentY)
    '        End If

    '        'Pension
    '        If cLinea.pension <> 0 Then
    '            CurrentY = CurrentY + 20

    '            Dim codigoPension As String
    '            If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
    '                codigoPension = "430185  "
    '            Else
    '                codigoPension = ""
    '            End If
    '            e.Graphics.DrawString(codigoPension & "  Pensión  ", reportFont, Brushes.Black, leftMarge, CurrentY)
    '            e.Graphics.DrawString("  $" & CStr(cLinea.pension), reportFont, Brushes.Black, 460, CurrentY)
    '        End If

    '        'Arancel Anestesia
    '        If cLinea.estudio.ArancelAnestesia <> 0 Then
    '            CurrentY = CurrentY + 20
    '            e.Graphics.DrawString("Anestesia valor IAPOS: " & Me.obtenerDescripcionAnestesiaEnImpresion(cLinea.estudio), reportFont, Brushes.Black, leftMarge, CurrentY)
    '            e.Graphics.DrawString("  $ " & CStr(cLinea.estudio.ArancelAnestesia), reportFont, Brushes.Black, 460, CurrentY)
    '        End If

    '        'Medicacion y material especifico
    '        If cEstudio.arrMedicacion.Count > 0 Then
    '            Dim med As Medicacion
    '            Dim arrMedicacionSinMaterialEspecifico As New ArrayList
    '            Dim arrMaterialEspecifico As New ArrayList
    '            arrMedicacionSinMaterialEspecifico = cEstudio.getMedicacionSinMaterialEspecifico()
    '            arrMaterialEspecifico = cEstudio.getMaterialEspecifico()
    '            Dim totalMaterialEspecifico As Decimal = 0.0

    '            'Material Especifico
    '            If arrMaterialEspecifico.Count > 0 Then
    '                CurrentY = CurrentY + 20
    '                e.Graphics.DrawString("Material Especifico: ", reportFont, Brushes.Black, leftMarge, CurrentY)
    '                For j = 0 To arrMaterialEspecifico.Count - 1
    '                    CurrentY = CurrentY + 20
    '                    med = arrMaterialEspecifico(j)
    '                    totalMaterialEspecifico = totalMaterialEspecifico + med.importe

    '                    rectMedicacion.Y = CurrentY

    '                    'si es osde u osde cedir
    '                    Dim codigoMedicamento As String = ""
    '                    If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
    '                        codigoMedicamento = med.medicamento.codigoMedicoOSDE & " "
    '                    End If
    '                    e.Graphics.DrawString(codigoMedicamento & "•" & med.medicamento.descripcion, reportFont, Brushes.Black, rectMedicacion)
    '                    e.Graphics.DrawString("  $" & med.importe, reportFont, Brushes.Black, 360, CurrentY)
    '                Next

    '                CurrentY = CurrentY + 20
    '                e.Graphics.DrawString("  Total Material especifico*", reportFont, Brushes.Black, leftMarge, CurrentY)
    '                e.Graphics.DrawString("  $" & Format(totalMaterialEspecifico, "############0.00").ToString(), reportFont, Brushes.Black, 460, CurrentY)
    '            End If



    '            If arrMedicacionSinMaterialEspecifico.Count > 0 Then
    '                CurrentY = CurrentY + 20
    '                e.Graphics.DrawString("Medicación:", reportFont, Brushes.Black, leftMarge, CurrentY)


    '                For j = 0 To arrMedicacionSinMaterialEspecifico.Count - 1
    '                    med = arrMedicacionSinMaterialEspecifico(j)
    '                    CurrentY = CurrentY + 20
    '                    rectMedicacion.Y = CurrentY
    '                    e.Graphics.DrawString("  • " & med.medicamento.descripcion, reportFont, Brushes.Black, rectMedicacion)
    '                    e.Graphics.DrawString("  $" & med.importe, reportFont, Brushes.Black, 360, CurrentY)

    '                Next

    '                Dim codigoMedicacion As String = ""
    '                If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
    '                    codigoMedicacion = "922501 "
    '                End If


    '                CurrentY = CurrentY + 20
    '                e.Graphics.DrawString(codigoMedicacion & "Total Medicación*", reportFont, Brushes.Black, leftMarge, CurrentY)
    '                e.Graphics.DrawString("  $" & CStr(cEstudio.getTotalMedicacion - totalMaterialEspecifico) & "  * Valorizada de acuerdo al Vademecum Kairos", reportFont, Brushes.Black, 460, CurrentY)
    '            End If

    '        End If



    '        'Lineas verticales de los totales
    '        e.Graphics.DrawLine(myPen, 340, startLine, 340, CurrentY + reportFontHeight)
    '        e.Graphics.DrawLine(myPen, 440, startLine, 440, CurrentY + reportFontHeight)

    '        'Total
    '        CurrentY = CurrentY + 25
    '        e.Graphics.DrawString("Total del estudio", reportFont, Brushes.Black, leftMarge, CurrentY)
    '        e.Graphics.DrawString(" $" & Format(Convert.ToDecimal(cLinea.getSubtotal), "############0.00").ToString(), reportFont, Brushes.Black, 460, CurrentY)

    '        'Linea horizontal de fin de estudio
    '        CurrentY = CurrentY + 20
    '        e.Graphics.DrawLine(myPen, 100, CurrentY, 700, CurrentY)

    '        'Seteo espacio para el siguiente estudio
    '        CurrentY = CurrentY + 15

    '        cPrintingEsudioLineIndex = cPrintingEsudioLineIndex + 1
    '        If cPrintingEsudioLineIndex < cPresentacion.getLineasDeFacturacionEstudios.Count Then
    '            cLinea = cPresentacion.getLineasDeFacturacionEstudios(cPrintingEsudioLineIndex)
    '            cSize = Me.getLineaSize(cLinea)
    '            estimateY = CurrentY + cSize
    '        End If

    '    End While

    '    'Pregunto si quedan estudios por imprimir
    '    If cPrintingEsudioLineIndex = cPresentacion.getLineasDeFacturacionEstudios.Count Then
    '        'No hay mas estudios
    '        CurrentY = CurrentY + 10
    '        drawRect.Y = CurrentY
    '        e.Graphics.DrawString("Total: $ " & CStr(cPresentacion.total), totalFont, Brushes.Black, drawRect)
    '        e.HasMorePages = False
    '    Else
    '        e.HasMorePages = True
    '    End If

    'End Sub
    'Private Function getLineaSize(ByVal linea As LineaDeFacturacion) As Single
    '    'Dim reportFontHeight As Single = 14 'ojo, cambiar este valor si se cambia el tamaño del font de la letra
    '    'Dim rowSize As Single = reportFontHeight

    '    Dim totalSize As Single = 0

    '    'Fecha
    '    totalSize += 15 '15 es la separacion de arriba 
    '    'Paciente
    '    totalSize += 20
    '    'Nro de orden: podría no tener
    '    If linea.estudio.nroOrden <> "" Then
    '        totalSize += 20
    '    End If

    '    'Descripcion practica
    '    totalSize += 20
    '    'Valor practica
    '    totalSize += 28
    '    'Dif paciente: podría no tener
    '    If linea.diferenciaPaciente <> 0 Then
    '        totalSize += 20
    '    End If
    '    'Pension: podría no tener
    '    If linea.pension <> 0 Then
    '        totalSize += 20
    '    End If
    '    'Medicacion (lineas y total): podría no tener
    '    If linea.estudio.arrMedicacion.Count > 0 Then
    '        totalSize += (20 * linea.estudio.arrMedicacion.Count)
    '        'Total neurolepto
    '        totalSize += 20
    '    End If
    '    'Total del estudio
    '    totalSize += 25
    '    'Linea final
    '    totalSize += 20

    '    Return totalSize
    'End Function

    'Private Sub prepareImprimirFactura()

    '    Dim facturaReport As New PrintDocument
    '    AddHandler facturaReport.PrintPage, AddressOf imprimirFactura

    '    'Imprimir
    '    Dim pss As New PrintDialog
    '    Dim bp As DialogResult
    '    pss.Document = facturaReport
    '    bp = pss.ShowDialog
    '    If bp = DialogResult.OK Then
    '        facturaReport.Print()
    '    End If
    'End Sub

    'Sub imprimirFactura(ByVal sender As Object, ByVal e As PrintPageEventArgs)
    '    Dim x As Single = 100.0F
    '    Dim y As Single = 150.0F
    '    Dim width As Single = 700.0F
    '    Dim height As Single = 100.0F
    '    Dim drawRect As New RectangleF(x, y, width, height)

    '    Dim CurrentY As Integer = 130
    '    Dim CurrentX As Integer = 100
    '    Dim ReportFont As New Font("Arial", 10, FontStyle.Regular)
    '    Dim ReportFontHeight As Integer = ReportFont.GetHeight(e.Graphics)
    '    Dim resaltaText As New Font("Arial", 11, FontStyle.Bold)
    '    Dim leyendaFont As New Font("Arial", 10, FontStyle.Italic)

    '    Dim os As ObraSocial
    '    os = cPresentacion.obraSocial

    '    drawRect.Y = CurrentY - ReportFontHeight
    '    CurrentX = 650
    '    e.Graphics.DrawString("Fecha: " & Today.Date, ReportFont, Brushes.Black, CurrentX, CurrentY)

    '    CurrentY = CurrentY + 82
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("Institución: " & os.ObraSocial, ReportFont, Brushes.Black, drawRect)

    '    CurrentY = CurrentY + 20
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("Domicilio: " & os.direccion & " - " & os.localidad & " (CP: " & os.CodigoPostal & ")", ReportFont, Brushes.Black, drawRect)

    '    CurrentY = CurrentY + 20
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("Cuit: " & os.nroCuit & "     -     I.V.A: " & os.CondicionFiscal, ReportFont, Brushes.Black, 100, CurrentY - ReportFontHeight)

    '    Dim descTot As String
    '    descTot = InputBox("Ingrese el total en letras", "Ingrese el total en letras")

    '    CurrentY = CurrentY + 20
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("Concepto", resaltaText, Brushes.Black, 100, CurrentY)
    '    e.Graphics.DrawString("Total", resaltaText, Brushes.Black, 650, CurrentY)

    '    CurrentY = CurrentY + 120
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("Facturación mes de " & cPresentacion.periodo & " según detalle adjunto", ReportFont, Brushes.Black, drawRect)
    '    e.Graphics.DrawString(CStr(cPresentacion.total), ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)

    '    CurrentY = CurrentY + 50
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("I.V.A (" & cPresentacion.comprobante.Gravado.porcentaje & "%)", ReportFont, Brushes.Black, drawRect)
    '    e.Graphics.DrawString(cPresentacion.getImporteIva, ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)

    '    CurrentY = CurrentY + 80
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("Total", ReportFont, Brushes.Black, drawRect)
    '    e.Graphics.DrawString(cPresentacion.getTotalFactura, ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)


    '    CurrentY = CurrentY + 70
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString(descTot, resaltaText, Brushes.Black, drawRect)

    '    'Leyenda
    '    CurrentY = CurrentY + 40
    '    drawRect.Y = CurrentY - ReportFontHeight
    '    e.Graphics.DrawString("Esta factura contiene honorarios por cuenta y orden de médicos.", leyendaFont, Brushes.Black, drawRect)

    '    e.HasMorePages = False


    'End Sub
#End Region



    Private Sub cmbSubTipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSubTipo.SelectedIndexChanged
        calcularUltimoNro()
    End Sub
    Private Function obtenerDescripcionAnestesiaEnImpresion(ByVal es As Estudio) As String
        'obs.: Como la columna anestesia es <> 0, vamos a ver el total de estudios en el dia 
        'y devolver una concatenacion de strings 
        Dim i As Integer = 0
        Dim cLinea As New LineaDeFacturacion
        Dim arr As ArrayList
        arr = cPresentacion.getLineasDeFacturacionEstudios()
        Dim estudios As New List(Of Estudio)
        'tengo que encontrar todos los estudios que existen en la misma fecha del estudio
        'pasado como parametro
        For i = 0 To arr.Count - 1
            cLinea = arr(i)
            If es.fechaEstudio() = cLinea.estudio.fechaEstudio() And es.paciente.Id = cLinea.estudio.paciente.id Then
                estudios.Add(cLinea.estudio)
            End If
        Next

        Dim concat As String = ""
        For Each e As Estudio In estudios
            concat = concat + e.practica.abreviatura + ", "
        Next
        'borro la ultima coma
        concat = concat.Remove(concat.Length - 2)

        Return concat

    End Function
    Private Function obtenerDescripcionMaterialEspecifico() As String

    End Function

    Private Sub btnAnest_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnest.Click
        'si la obra social no va por ara , no calculamos anestesia, y salimos
        If cPresentacion.obraSocial.sePresentaPorARA = 1 Then
            MessageBox.Show("No se calculan valores de anestesia para obras sociales" & vbCrLf & "que se presentan por ARA")
            Exit Sub
        End If

        Dim arr As ArrayList
        Dim estudios As New ArrayList
        Dim calcu As New CalculadorHonorariosAnestesistas

        Dim clinea As New LineaDeFacturacion

        Try
            arr = cPresentacion.getLineasDeFacturacionEstudios()
            Dim i As Integer
            For i = 0 To arr.Count - 1
                clinea = arr(i)
                estudios.Add(clinea.estudio)
            Next

            Dim total() As Decimal
            total = calcu.getHonorarios(estudios)
            'cargamos la grilla con los valores <>0 en las respectivas posiciones
            For i = 0 To total.Length() - 1
                If total(i) <> 0 Then
                    clinea = arr(i)
                    clinea.estudio.ArancelAnestesia = total(i)
                    clinea.estudio.guardarArancelAnestesia()
                    Me.DataGrid1.Item(i, 11) = total(i)
                End If
            Next

        Catch ex As Exception
        Finally
            arr = Nothing
            estudios = Nothing
            calcu = Nothing
            MessageBox.Show("Los valores de la columna de anestesia son sugeridos." + vbCrLf + "Se sugiere realizar una comprobación.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End Try


    End Sub

    Private Sub PacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteToolStripMenuItem.Click
        Dim est As Estudio
        est = cPresentacion.getLineasDeFacturacionEstudios(Me.DataGrid1.CurrentRowIndex).estudio
        Dim f As New AltaPaciente()
        f.currentPaciente = est.paciente
        f.esAltaPaciente = False
        f.Show()


    End Sub

    Private Sub EstudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstudioToolStripMenuItem.Click
        Dim est As Estudio
        est = cPresentacion.getLineasDeFacturacionEstudios(Me.DataGrid1.CurrentRowIndex).estudio
        Dim f As New NuevoEstudio(est)
        '  f.Parent = Me.Parent
        f.Show()

    End Sub

    Private Sub cmbNroTerminal_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbNroTerminal.SelectedIndexChanged
        Me.calcularUltimoNro()
    End Sub

    Private Sub NuevaPresentacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Then
            Me.Close()
        End If
    End Sub
End Class
