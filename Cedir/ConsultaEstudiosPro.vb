Imports CedirNegocios
Imports System.Text.RegularExpressions
Public Class ConsultaEstudiosPro
    Inherits System.Windows.Forms.Form

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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnDetalle As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNomPaciente As System.Windows.Forms.TextBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnActualizarImportes As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnMedicacion As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rdbMedAct As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMedSol As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMedAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents cmbMedicos As System.Windows.Forms.ComboBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents grpPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSelFechaHasta As System.Windows.Forms.Button
    Friend WithEvents btnSelFechaDesde As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPracticas As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents txtApePaciente As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents PacienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MovimientoDeCajaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnEliminiar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtApePaciente = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbPracticas = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.grpPeriodo = New System.Windows.Forms.GroupBox
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.btnSelFechaHasta = New System.Windows.Forms.Button
        Me.btnSelFechaDesde = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtFechaDesde = New System.Windows.Forms.TextBox
        Me.txtFechaHasta = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdbMedAct = New System.Windows.Forms.RadioButton
        Me.rdbMedSol = New System.Windows.Forms.RadioButton
        Me.rdbMedAmbos = New System.Windows.Forms.RadioButton
        Me.cmbMedicos = New System.Windows.Forms.ComboBox
        Me.txtNomPaciente = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.btnDetalle = New System.Windows.Forms.Button
        Me.btnActualizarImportes = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnEliminiar = New System.Windows.Forms.Button
        Me.btnMedicacion = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.PacienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MovimientoDeCajaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        Me.grpPeriodo.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApePaciente)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbPracticas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.cmbObraSocial)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.grpPeriodo)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rdbMedAct)
        Me.GroupBox1.Controls.Add(Me.rdbMedSol)
        Me.GroupBox1.Controls.Add(Me.rdbMedAmbos)
        Me.GroupBox1.Controls.Add(Me.cmbMedicos)
        Me.GroupBox1.Controls.Add(Me.txtNomPaciente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(923, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'txtApePaciente
        '
        Me.txtApePaciente.Location = New System.Drawing.Point(123, 66)
        Me.txtApePaciente.Name = "txtApePaciente"
        Me.txtApePaciente.Size = New System.Drawing.Size(208, 20)
        Me.txtApePaciente.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 16)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "Apellido Paciente:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(4, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "Práctica:"
        '
        'cmbPracticas
        '
        Me.cmbPracticas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPracticas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPracticas.Location = New System.Drawing.Point(123, 40)
        Me.cmbPracticas.Name = "cmbPracticas"
        Me.cmbPracticas.Size = New System.Drawing.Size(256, 21)
        Me.cmbPracticas.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(4, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 21)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Obra Social:"
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbObraSocial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbObraSocial.Location = New System.Drawing.Point(123, 13)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(430, 21)
        Me.cmbObraSocial.TabIndex = 1
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(123, 119)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(208, 20)
        Me.txtDni.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(5, 122)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "DNI:"
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.MonthCalendar1)
        Me.grpPeriodo.Controls.Add(Me.btnSelFechaHasta)
        Me.grpPeriodo.Controls.Add(Me.btnSelFechaDesde)
        Me.grpPeriodo.Controls.Add(Me.Label2)
        Me.grpPeriodo.Controls.Add(Me.txtFechaDesde)
        Me.grpPeriodo.Controls.Add(Me.txtFechaHasta)
        Me.grpPeriodo.Controls.Add(Me.Label4)
        Me.grpPeriodo.Location = New System.Drawing.Point(559, 12)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(358, 135)
        Me.grpPeriodo.TabIndex = 28
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(192, 14)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ScrollChange = 1
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.TabIndex = 31
        Me.MonthCalendar1.TabStop = False
        Me.MonthCalendar1.Visible = False
        '
        'btnSelFechaHasta
        '
        Me.btnSelFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelFechaHasta.Location = New System.Drawing.Point(192, 37)
        Me.btnSelFechaHasta.Name = "btnSelFechaHasta"
        Me.btnSelFechaHasta.Size = New System.Drawing.Size(75, 18)
        Me.btnSelFechaHasta.TabIndex = 30
        Me.btnSelFechaHasta.TabStop = False
        Me.btnSelFechaHasta.Text = "Seleccione..."
        Me.btnSelFechaHasta.UseVisualStyleBackColor = True
        '
        'btnSelFechaDesde
        '
        Me.btnSelFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelFechaDesde.Location = New System.Drawing.Point(192, 14)
        Me.btnSelFechaDesde.Name = "btnSelFechaDesde"
        Me.btnSelFechaDesde.Size = New System.Drawing.Size(75, 18)
        Me.btnSelFechaDesde.TabIndex = 28
        Me.btnSelFechaDesde.TabStop = False
        Me.btnSelFechaDesde.Text = "Seleccione..."
        Me.btnSelFechaDesde.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha Desde:"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(85, 15)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaDesde.TabIndex = 7
        Me.txtFechaDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(85, 38)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaHasta.TabIndex = 8
        Me.txtFechaHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 20)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Fecha Hasta:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(347, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Medico :"
        '
        'rdbMedAct
        '
        Me.rdbMedAct.Location = New System.Drawing.Point(396, 96)
        Me.rdbMedAct.Name = "rdbMedAct"
        Me.rdbMedAct.Size = New System.Drawing.Size(112, 16)
        Me.rdbMedAct.TabIndex = 19
        Me.rdbMedAct.Text = "Médico Actuante"
        '
        'rdbMedSol
        '
        Me.rdbMedSol.Location = New System.Drawing.Point(396, 120)
        Me.rdbMedSol.Name = "rdbMedSol"
        Me.rdbMedSol.Size = New System.Drawing.Size(120, 16)
        Me.rdbMedSol.TabIndex = 20
        Me.rdbMedSol.Text = "Médico Solicitante"
        '
        'rdbMedAmbos
        '
        Me.rdbMedAmbos.Checked = True
        Me.rdbMedAmbos.Location = New System.Drawing.Point(396, 142)
        Me.rdbMedAmbos.Name = "rdbMedAmbos"
        Me.rdbMedAmbos.Size = New System.Drawing.Size(96, 16)
        Me.rdbMedAmbos.TabIndex = 21
        Me.rdbMedAmbos.TabStop = True
        Me.rdbMedAmbos.Text = "Ambos"
        '
        'cmbMedicos
        '
        Me.cmbMedicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicos.Location = New System.Drawing.Point(396, 69)
        Me.cmbMedicos.Name = "cmbMedicos"
        Me.cmbMedicos.Size = New System.Drawing.Size(144, 21)
        Me.cmbMedicos.TabIndex = 6
        Me.cmbMedicos.Text = "Seleccione.."
        '
        'txtNomPaciente
        '
        Me.txtNomPaciente.Location = New System.Drawing.Point(123, 93)
        Me.txtNomPaciente.Name = "txtNomPaciente"
        Me.txtNomPaciente.Size = New System.Drawing.Size(208, 20)
        Me.txtNomPaciente.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre Paciente:"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(6, 173)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        '
        'btnDetalle
        '
        Me.btnDetalle.Location = New System.Drawing.Point(8, 32)
        Me.btnDetalle.Name = "btnDetalle"
        Me.btnDetalle.Size = New System.Drawing.Size(75, 23)
        Me.btnDetalle.TabIndex = 10
        Me.btnDetalle.Text = "Detalle"
        '
        'btnActualizarImportes
        '
        Me.btnActualizarImportes.Location = New System.Drawing.Point(192, 32)
        Me.btnActualizarImportes.Name = "btnActualizarImportes"
        Me.btnActualizarImportes.Size = New System.Drawing.Size(112, 23)
        Me.btnActualizarImportes.TabIndex = 12
        Me.btnActualizarImportes.Text = "Actualizar Importes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnEliminiar)
        Me.GroupBox2.Controls.Add(Me.btnMedicacion)
        Me.GroupBox2.Controls.Add(Me.btnActualizarImportes)
        Me.GroupBox2.Controls.Add(Me.btnDetalle)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 472)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(403, 72)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Con el estudio seleccionado"
        '
        'btnEliminiar
        '
        Me.btnEliminiar.Location = New System.Drawing.Point(320, 32)
        Me.btnEliminiar.Name = "btnEliminiar"
        Me.btnEliminiar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminiar.TabIndex = 13
        Me.btnEliminiar.Text = "Eliminar"
        '
        'btnMedicacion
        '
        Me.btnMedicacion.Location = New System.Drawing.Point(96, 32)
        Me.btnMedicacion.Name = "btnMedicacion"
        Me.btnMedicacion.Size = New System.Drawing.Size(88, 23)
        Me.btnMedicacion.TabIndex = 11
        Me.btnMedicacion.Text = "Medicación"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(697, 504)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 70
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(616, 504)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 70
        Me.btnImprimir.TabStop = False
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AllowUserToResizeColumns = False
        Me.dgv.AllowUserToResizeRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgv.Location = New System.Drawing.Point(8, 202)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(923, 264)
        Me.dgv.TabIndex = 8
        Me.dgv.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PacienteToolStripMenuItem, Me.MovimientoDeCajaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(178, 48)
        '
        'PacienteToolStripMenuItem
        '
        Me.PacienteToolStripMenuItem.Name = "PacienteToolStripMenuItem"
        Me.PacienteToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.PacienteToolStripMenuItem.Text = "Paciente"
        '
        'MovimientoDeCajaToolStripMenuItem
        '
        Me.MovimientoDeCajaToolStripMenuItem.Name = "MovimientoDeCajaToolStripMenuItem"
        Me.MovimientoDeCajaToolStripMenuItem.Size = New System.Drawing.Size(177, 22)
        Me.MovimientoDeCajaToolStripMenuItem.Text = "Movimiento de caja"
        '
        'ConsultaEstudiosPro
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 546)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnFiltrar)
        Me.Name = "ConsultaEstudiosPro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Estudios (Avanzado)"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrl As ArrayList
    Dim arrMedicos As ArrayList
    Dim catalogoEstudios As New CatalogoDeEstudios
    Dim arrEstudiosPracticas As New ArrayList
    Dim arrObraSocial As ArrayList
    Dim myTable As DataTable = New DataTable("myTable")



    Private Sub ConsultaEstudiosPro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clIdEstudio As DataColumn = New DataColumn("NroEstudio", Type.GetType("System.String"))
        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTelefonoPaciente As New DataColumn("TelefonoPaciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Tipo de Estudio", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Médico Actuante", Type.GetType("System.String"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))

        Dim clMedSolicitante As New DataColumn("Médico Solicitante", Type.GetType("System.String"))
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clEstado As New DataColumn("Estado", Type.GetType("System.String"))

        myTable.Columns.Add(clIdEstudio)
        myTable.Columns.Add(clFechaEstudio)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clTelefonoPaciente)
        myTable.Columns.Add(clObraSocial)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clMedSolicitante)
        myTable.Columns.Add(clEstado)

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
        TextCol2.MappingName = "NroEstudio"
        TextCol2.HeaderText = "NroEstudio"
        TextCol2.Width = 10
        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "Fecha"
        TextCol0.HeaderText = "Fecha"
        TextCol0.Width = 30
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Paciente"
        TextCol.HeaderText = "Paciente"
        TextCol.Width = 115
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextColTelefonoPaciente As New DataGridTextBoxColumn
        TextColTelefonoPaciente.MappingName = "TelefonoPaciente"
        TextColTelefonoPaciente.HeaderText = "TelefonoPaciente"
        TextColTelefonoPaciente.Width = 50
        ts1.GridColumnStyles.Add(TextColTelefonoPaciente)

        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "Obra Social"
        TextCol5.HeaderText = "Obra Social"
        TextCol5.Width = 200
        ts1.GridColumnStyles.Add(TextCol5)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Tipo de Estudio"
        TextCol3.HeaderText = "Tipo de Estudio"
        TextCol3.Width = 170
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Médico Actuante"
        TextCol4.HeaderText = "Médico Actuante"
        TextCol4.Width = 95
        ts1.GridColumnStyles.Add(TextCol4)

        Dim TextCol6 As New DataGridTextBoxColumn
        TextCol6.MappingName = "Médico Solicitante"
        TextCol6.HeaderText = "Médico Solicitante"
        TextCol6.Width = 95
        ts1.GridColumnStyles.Add(TextCol6)


        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "Estado"
        TextCol7.HeaderText = "Estado"
        TextCol7.Width = 60
        ts1.GridColumnStyles.Add(TextCol7)



        btnEliminiar.Visible = False

        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser
        If IsNothing(cUsuario) = False Then
            If (cUsuario.belongToGroup("administrador") Or cUsuario.belongToGroup("facturacion")) Then
                btnEliminiar.Visible = True
            End If
        End If

        arrl = catalogoEstudios.ObtenerEstudiosDeHoy

        Me.cargarComboOS()
        Me.cargarComboMedicos()
        Me.cargarComboPracticas()
        CargarGrilla()
    End Sub

    Private Sub cargarComboOS()
        Dim os As ObraSocial
        Dim catalogoObraSocial As New CatalogoDeObrasSociales
        Dim i As Integer
        arrObraSocial = catalogoObraSocial.TodosLasObrasSociales()
        cmbObraSocial.Items.Clear()
        cmbObraSocial.Items.Add("Seleccione una Obra Social..")
        For i = 0 To arrObraSocial.Count - 1
            os = arrObraSocial(i)
            cmbObraSocial.Items.Add(os.ObraSocial)
        Next
        cmbObraSocial.SelectedIndex = 0
    End Sub
    Private Sub cargarComboPracticas()
        Dim catalogoPracticas As New CatalogoDePracticas
        arrEstudiosPracticas = catalogoPracticas.getPracticas
        For Each p As Practica In arrEstudiosPracticas
            Me.cmbPracticas.Items.Add(p.Estudio)
        Next
    End Sub
    Private Sub cargarComboMedicos()
        Dim i As Integer
        Dim med As Medico
        Dim catalogoMedicos As New CatalogoDeMedicos
        arrMedicos = catalogoMedicos.TodosLosMedicos()
        cmbMedicos.Items.Add("Ningún médico seleccionado")
        For i = 0 To arrMedicos.Count - 1
            med = arrMedicos(i)
            cmbMedicos.Items.Add(med.nombreCompleto)

        Next
        cmbMedicos.SelectedIndex = 0
    End Sub


    Private Sub CargarGrilla()

        myTable.Clear()
        Dim NewRow As DataRow
        Dim i As Integer

        If arrl.Count > 0 Then

            Dim est As Estudio
            For i = 0 To arrl.Count - 1
                est = arrl(i)
                NewRow = myTable.NewRow()
                NewRow("NroEstudio") = est.nroEstudio
                NewRow("Fecha") = est.fechaEstudio
                NewRow("Obra Social") = est.obraSocial.ObraSocial
                NewRow("Tipo de Estudio") = est.practica.Estudio
                NewRow("Médico Actuante") = est.medicoActuante.apellido
                NewRow("Médico Solicitante") = est.medicoSolicitante.apellido
                NewRow("Paciente") = est.paciente.apellido & ", " & est.paciente.nombres
                NewRow("TelefonoPaciente") = est.paciente.tel
                Dim estado As String
                If est.fechaCobro <> "0:00:00" Then
                    estado = "Cobrado"
                ElseIf est.idFacturacion <> 0 Then
                    estado = "Presentado"
                Else
                    estado = "Sin presentar"
                End If
                NewRow("Estado") = estado
                myTable.Rows.Add(NewRow)
            Next

        Else
            MsgBox("No se encontraron resultados")
        End If
        myTable.AcceptChanges()
        dgv.DataSource = myTable
    End Sub

    Private Sub btnDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalle.Click
        If Me.dgv.SelectedRows.Count > 1 Then
            Exit Sub
        End If
        Dim i As Integer
        Dim est As Estudio

        '  i = DataGrid1.CurrentRowIndex
        i = dgv.SelectedRows(0).Index
        est = arrl(i)

        Dim frm As New DetalleEstudio(est)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim fechaInicial As Date
        Dim fechaFinal As Date
        Dim fechaIni As String = ""
        Dim fechaFin As String = ""

        Try


            'establezco tipo de medico
            Dim rButton As Integer = 1
            Select Case True

                Case Me.rdbMedAct.Checked
                    rButton = 1
                Case Me.rdbMedSol.Checked
                    rButton = 2
                Case Me.rdbMedAmbos.Checked
                    rButton = 3

            End Select

            'establecemos si se elijió practica
            Dim practica As Practica
            Select Case True
                Case Me.cmbPracticas.SelectedIndex = -1
                    practica = Nothing
                Case Else
                    practica = arrEstudiosPracticas(Me.cmbPracticas.SelectedIndex)
            End Select

            'establezco si se elijio una obra social
            Dim cIdObraSocial As Integer = 0
            If cmbObraSocial.SelectedIndex <> 0 Then
                Dim cObraSocial As ObraSocial = arrObraSocial(cmbObraSocial.SelectedIndex - 1)
                cIdObraSocial = cObraSocial.idObraSocial
            End If
            'establezco si hay algun campo fecha vaci
            Select Case True

                Case Me.txtFechaDesde.Text <> "" And Me.txtFechaHasta.Text <> ""

                    fechaInicial = CDate(Me.txtFechaDesde.Text)
                    fechaFinal = CDate(Me.txtFechaHasta.Text)


                    'validamos que las fechas sean validas
                    Select Case Date.Compare(fechaInicial, fechaFinal)

                        Case Is < 0
                            'la fechaInicial es menor que la fechaFinal
                            fechaInicial = New Date(fechaInicial.Year, fechaInicial.Month, fechaInicial.Day, 0, 0, 0)
                            fechaFinal = New Date(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 23, 59, 59)
                        Case 0
                            'las dos fechas son iguales
                            fechaInicial = New Date(fechaInicial.Year, fechaInicial.Month, fechaInicial.Day, 0, 0, 0)
                            fechaFinal = New Date(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 23, 59, 59)
                        Case Is > 0
                            'las fechaInicial es mayor que la fechaFinal
                            'invierto valores de las fechas
                            fechaFinal = CDate(Me.txtFechaDesde.Text)
                            fechaInicial = CDate(Me.txtFechaHasta.Text)

                    End Select

                    'Utilizo regular expression para convertir la fecha
                    fechaIni = fechaInicial.Date.ToString.Substring(0, 10).Trim
                    Dim r As New Regex("(/)")
                    Dim arrR As String()
                    'dividimos la fehca separando por /
                    arrR = r.Split(fechaIni)
                    fechaIni = arrR(4) & "/" & arrR(2) & "/" & arrR(0)



                    fechaFin = fechaFinal.Date.ToString.Substring(0, 10).Trim
                    'dividimos la fehca separando por /
                    arrR = r.Split(fechaFin)
                    fechaFin = arrR(4) & "/" & arrR(2) & "/" & arrR(0)

                    If Me.cmbMedicos.SelectedIndex = -1 Or Me.cmbMedicos.SelectedIndex = 0 Then
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, , rButton, fechaIni, fechaFin, practica, txtDni.Text.Trim(), cIdObraSocial, "paciente")
                    Else
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, arrMedicos(Me.cmbMedicos.SelectedIndex - 1).idMedico, rButton, fechaIni, fechaFin, practica, txtDni.Text.Trim(), cIdObraSocial, "paciente")

                    End If

                Case Me.txtFechaDesde.Text = "" And Me.txtFechaHasta.Text <> ""
                    fechaFinal = CDate(Me.txtFechaHasta.Text)
                    fechaFin = fechaFinal.Date.ToString.Substring(0, 10).Trim
                    Dim arrR As String()
                    Dim r As New Regex("(/)")
                    'dividimos la fehca separando por /
                    arrR = r.Split(fechaFin)
                    fechaFin = arrR(4) & "/" & arrR(2) & "/" & arrR(0)



                    If Me.cmbMedicos.SelectedIndex = -1 Or Me.cmbMedicos.SelectedIndex = 0 Then
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, , rButton, fechaFin, , practica, txtDni.Text.Trim, cIdObraSocial, "paciente")
                    Else
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, arrMedicos(Me.cmbMedicos.SelectedIndex - 1).idMedico, rButton, fechaFin, , practica, txtDni.Text.Trim, cIdObraSocial, "paciente")
                    End If

                Case Me.txtFechaDesde.Text <> "" And Me.txtFechaHasta.Text = ""
                    fechaInicial = CDate(Me.txtFechaDesde.Text)
                    fechaIni = fechaInicial.Date.ToString.Substring(0, 10).Trim
                    Dim r As New Regex("(/)")
                    Dim arrR As String()
                    'dividimos la fehca separando por /
                    arrR = r.Split(fechaIni)
                    fechaIni = arrR(4) & "/" & arrR(2) & "/" & arrR(0)

                    If Me.cmbMedicos.SelectedIndex = -1 Or Me.cmbMedicos.SelectedIndex = 0 Then
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, , rButton, fechaIni, , practica, txtDni.Text.Trim, cIdObraSocial, "paciente")
                    Else
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, arrMedicos(Me.cmbMedicos.SelectedIndex - 1).idMedico, rButton, fechaIni, , practica, txtDni.Text.Trim(), cIdObraSocial, "paciente")
                    End If


                Case Else

                    If Me.cmbMedicos.SelectedIndex = -1 Or Me.cmbMedicos.SelectedIndex = 0 Then
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, , 0, , , , practica, txtDni.Text.Trim, cIdObraSocial, "paciente")
                    Else
                        arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, , arrMedicos(Me.cmbMedicos.SelectedIndex - 1).idMedico, rButton, , , practica, txtDni.Text.Trim, cIdObraSocial, "paciente")
                    End If
                    If Me.txtNomPaciente.Text <> "" Or Me.txtApePaciente.Text <> "" Then

                        If Me.cmbMedicos.SelectedIndex = -1 Or Me.cmbMedicos.SelectedIndex = 0 Then
                            arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, , rButton, , , practica, txtDni.Text.Trim, cIdObraSocial, "paciente")
                        Else
                            arrl = catalogoEstudios.TraerEstudios(txtApePaciente.Text, txtNomPaciente.Text, arrMedicos(Me.cmbMedicos.SelectedIndex - 1).idMedico, rButton, , , practica, txtDni.Text.Trim, cIdObraSocial, "paciente")
                        End If
                    End If

            End Select

            CargarGrilla()
        Finally
            Me.MonthCalendar1.Visible = False
            Me.btnSelFechaDesde.Visible = True
            Me.btnSelFechaHasta.Visible = True
        End Try


    End Sub

    Private Sub btnActualizarImportes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnActualizarImportes.Click
        If Me.dgv.SelectedRows.Count = 0 Then
            Exit Sub
        End If

        Dim i As Integer
        Dim est As Estudio
        Dim frm As detallesImpositivos
        frm = New detallesImpositivos()
        For Each fila As DataGridViewRow In Me.dgv.SelectedRows
            i = fila.Index
            est = arrl(i)
            frm.ListaEstudios.Add(est)
        Next

        frm.MdiParent = Me.Parent.Parent
        frm.Show()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnDetalle2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnDetalle.PerformClick()
    End Sub

    Private Sub btnEliminiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminiar.Click
        If Me.dgv.SelectedRows.Count > 1 Then
            Exit Sub
        End If
        Dim i As Integer = dgv.SelectedRows(0).Index
        Dim est As Estudio = arrl(i)
        If (est.fechaEstudio >= Date.Today.AddDays(-3)) Then
            Dim r As Integer
            r = MsgBox("¿Esta seguro que desea eliminar el estudio?", MsgBoxStyle.YesNo, "Eliminar estudio")
            If r = 6 Then

                If est.idFacturacion <> 0 Then
                    MsgBox("El estudio se encuentra en alguna facturación por lo que no puede ser borrado", MsgBoxStyle.Critical)
                Else
                    'borrar
                    Dim resp As String = catalogoEstudios.borrarEstudio(est)
                    If resp = "ok" Then
                        arrl.RemoveAt(i)
                        MsgBox("El estudio ha sido borrado")
                        'btnFiltrar.PerformClick()
                        Me.CargarGrilla()
                    Else
                        MsgBox("Se ha producido un error al intentar borrar. Descripción del error: " & resp, MsgBoxStyle.Critical)
                    End If
                End If
            End If
        Else
            MsgBox("No esta permitido borrar estudios con más de 3 dias de ingreso ", MsgBoxStyle.OkOnly)
        End If

    End Sub

    Private Sub btnMedicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedicacion.Click
        If Me.dgv.SelectedRows.Count > 1 Then
            Exit Sub
        End If
        Dim i As Integer
        Dim est As Estudio

        ' i = DataGrid1.CurrentRowIndex
        i = Me.dgv.SelectedRows(0).Index
        est = arrl(i)

        Dim frm As New AgragarMedicacion(est)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub txtFecha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFechaDesde.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFiltrar.PerformClick()
        End If
    End Sub

    Private Sub txtPaciente_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNomPaciente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFiltrar.PerformClick()
        End If
    End Sub
    Private Sub btnSelFechaDesde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelFechaDesde.Click
        Me.MonthCalendar1.Visible = True
        Me.btnSelFechaDesde.Visible = False
        Me.txtFechaDesde.Text = ""
    End Sub

    Private Sub btnSelFechaHasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelFechaHasta.Click
        Me.MonthCalendar1.Visible = True
        Me.btnSelFechaHasta.Visible = False
        Me.txtFechaHasta.Text = Date.Today.ToString().Remove(11)
    End Sub



    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If (Me.txtFechaDesde.Text <> "") Then
            Me.txtFechaHasta.Text = Me.MonthCalendar1.SelectionRange().Start.Date.ToString().Remove(11)
        Else
            Me.txtFechaDesde.Text = Me.MonthCalendar1.SelectionRange().Start.Date.ToString().Remove(11)
        End If
        Me.MonthCalendar1.Visible = False
        Me.btnSelFechaDesde.Visible = True
        Me.btnSelFechaHasta.Visible = True
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New rptViewer
        Me.AddOwnedForm(f)
        f.PrintEstudios(Me.arrl, Me.txtFechaDesde.Text, Me.txtFechaHasta.Text)
        f.ShowDialog()
    End Sub

    Private Sub txtApePaciente_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApePaciente.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFiltrar.PerformClick()
        End If
    End Sub

    Private Sub txtDni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDni.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFiltrar.PerformClick()
        End If
    End Sub

    Private Sub cmbPracticas_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPracticas.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnFiltrar.PerformClick()
        End If
    End Sub

    Private Sub btnNuevoMovCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frm As New frmABMMovimientoCaja
        frm.ShowDialog()
    End Sub

    Private Sub dgv_ColumnAdded(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewColumnEventArgs) Handles dgv.ColumnAdded
        e.Column.SortMode = DataGridViewColumnSortMode.NotSortable
    End Sub
    Private Sub PacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteToolStripMenuItem.Click
        Dim est As Estudio
        est = arrl(dgv.CurrentRow.Index)

        Dim f As New AltaPaciente()
        f.currentPaciente = est.paciente
        f.esAltaPaciente = False
        f.Show()

    End Sub

    Private Sub MovimientoDeCajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MovimientoDeCajaToolStripMenuItem.Click
        Dim est As Estudio
        est = arrl(dgv.CurrentRow.Index)
        Dim f As New frmEstudiosMovimientos
        f.DateTimePicker1.Value = est.fechaEstudio
        f.ShowDialog()
    End Sub
End Class
