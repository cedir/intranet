<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListadoDeMovimientos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.checkPagado = New System.Windows.Forms.CheckBox
        Me.checkEstudios = New System.Windows.Forms.CheckBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtHasta = New System.Windows.Forms.DateTimePicker
        Me.dtDesde = New System.Windows.Forms.DateTimePicker
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtConcepto = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbMedicos = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbTipoDeMovimientos = New System.Windows.Forms.ComboBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView
        Me.colFechaMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoDeMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMedico = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMontoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMontoAcumulado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescripcionMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colUser = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaEstudio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPractica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.menuRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblUltimoMontoAcumulado = New System.Windows.Forms.Label
        Me.btnModificarMovimiento = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.menuRightClick.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnImprimir)
        Me.GroupBox1.Controls.Add(Me.checkPagado)
        Me.GroupBox1.Controls.Add(Me.checkEstudios)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.dtHasta)
        Me.GroupBox1.Controls.Add(Me.dtDesde)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtConcepto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbMedicos)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbTipoDeMovimientos)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(842, 166)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro de Busqueda"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(98, 133)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 36
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'checkPagado
        '
        Me.checkPagado.AutoSize = True
        Me.checkPagado.Checked = True
        Me.checkPagado.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.checkPagado.Location = New System.Drawing.Point(119, 76)
        Me.checkPagado.Name = "checkPagado"
        Me.checkPagado.Size = New System.Drawing.Size(15, 14)
        Me.checkPagado.TabIndex = 35
        Me.checkPagado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkPagado.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.checkPagado.ThreeState = True
        Me.checkPagado.UseVisualStyleBackColor = True
        '
        'checkEstudios
        '
        Me.checkEstudios.AutoSize = True
        Me.checkEstudios.Checked = True
        Me.checkEstudios.CheckState = System.Windows.Forms.CheckState.Indeterminate
        Me.checkEstudios.Location = New System.Drawing.Point(119, 103)
        Me.checkEstudios.Name = "checkEstudios"
        Me.checkEstudios.Size = New System.Drawing.Size(15, 14)
        Me.checkEstudios.TabIndex = 34
        Me.checkEstudios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.checkEstudios.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.checkEstudios.UseVisualStyleBackColor = True
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(6, 133)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 33
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(415, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 13)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Fecha Hasta:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(415, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Fecha Desde:"
        '
        'dtHasta
        '
        Me.dtHasta.Location = New System.Drawing.Point(488, 72)
        Me.dtHasta.Name = "dtHasta"
        Me.dtHasta.Size = New System.Drawing.Size(200, 20)
        Me.dtHasta.TabIndex = 30
        '
        'dtDesde
        '
        Me.dtDesde.Location = New System.Drawing.Point(488, 45)
        Me.dtDesde.Name = "dtDesde"
        Me.dtDesde.Size = New System.Drawing.Size(200, 20)
        Me.dtDesde.TabIndex = 29
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Incluir Estudios:"
        '
        'txtConcepto
        '
        Me.txtConcepto.Location = New System.Drawing.Point(488, 20)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(348, 20)
        Me.txtConcepto.TabIndex = 26
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(415, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Concepto:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Pagado"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Médico"
        '
        'cmbMedicos
        '
        Me.cmbMedicos.FormattingEnabled = True
        Me.cmbMedicos.Location = New System.Drawing.Point(119, 46)
        Me.cmbMedicos.Name = "cmbMedicos"
        Me.cmbMedicos.Size = New System.Drawing.Size(269, 21)
        Me.cmbMedicos.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Tipo De Movimiento"
        '
        'cmbTipoDeMovimientos
        '
        Me.cmbTipoDeMovimientos.FormattingEnabled = True
        Me.cmbTipoDeMovimientos.Location = New System.Drawing.Point(119, 20)
        Me.cmbTipoDeMovimientos.Name = "cmbTipoDeMovimientos"
        Me.cmbTipoDeMovimientos.Size = New System.Drawing.Size(269, 21)
        Me.cmbTipoDeMovimientos.TabIndex = 19
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvMovimientos)
        Me.GroupBox2.Controls.Add(Me.DataGridView1)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 184)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(1164, 250)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Movimientos"
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvMovimientos.CausesValidation = False
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFechaMovimiento, Me.colTipoDeMovimiento, Me.colPaciente, Me.colOS, Me.colMedico, Me.colMontoMovimiento, Me.colMontoAcumulado, Me.colDescripcionMovimiento, Me.colUser, Me.colEstado, Me.colFechaEstudio, Me.colPractica})
        Me.dgvMovimientos.ContextMenuStrip = Me.menuRightClick
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvMovimientos.DefaultCellStyle = DataGridViewCellStyle7
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientos.Location = New System.Drawing.Point(3, 16)
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.ReadOnly = True
        Me.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientos.ShowCellErrors = False
        Me.dgvMovimientos.ShowEditingIcon = False
        Me.dgvMovimientos.ShowRowErrors = False
        Me.dgvMovimientos.Size = New System.Drawing.Size(1158, 231)
        Me.dgvMovimientos.TabIndex = 1
        '
        'colFechaMovimiento
        '
        Me.colFechaMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colFechaMovimiento.DefaultCellStyle = DataGridViewCellStyle1
        Me.colFechaMovimiento.HeaderText = "Fecha Movimiento"
        Me.colFechaMovimiento.Name = "colFechaMovimiento"
        Me.colFechaMovimiento.ReadOnly = True
        Me.colFechaMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFechaMovimiento.Width = 90
        '
        'colTipoDeMovimiento
        '
        Me.colTipoDeMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colTipoDeMovimiento.HeaderText = "Tipo De Movimiento"
        Me.colTipoDeMovimiento.Name = "colTipoDeMovimiento"
        Me.colTipoDeMovimiento.ReadOnly = True
        Me.colTipoDeMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colTipoDeMovimiento.Width = 97
        '
        'colPaciente
        '
        Me.colPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPaciente.HeaderText = "Paciente"
        Me.colPaciente.Name = "colPaciente"
        Me.colPaciente.ReadOnly = True
        Me.colPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPaciente.Width = 55
        '
        'colOS
        '
        Me.colOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colOS.HeaderText = "ObraSocial"
        Me.colOS.Name = "colOS"
        Me.colOS.ReadOnly = True
        Me.colOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colOS.Width = 65
        '
        'colMedico
        '
        Me.colMedico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colMedico.HeaderText = "Medico"
        Me.colMedico.Name = "colMedico"
        Me.colMedico.ReadOnly = True
        Me.colMedico.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMedico.Width = 48
        '
        'colMontoMovimiento
        '
        Me.colMontoMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.colMontoMovimiento.DefaultCellStyle = DataGridViewCellStyle2
        Me.colMontoMovimiento.HeaderText = "Monto"
        Me.colMontoMovimiento.Name = "colMontoMovimiento"
        Me.colMontoMovimiento.ReadOnly = True
        Me.colMontoMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMontoMovimiento.Width = 43
        '
        'colMontoAcumulado
        '
        Me.colMontoAcumulado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0.00"
        Me.colMontoAcumulado.DefaultCellStyle = DataGridViewCellStyle3
        Me.colMontoAcumulado.HeaderText = "Monto Acumulado"
        Me.colMontoAcumulado.Name = "colMontoAcumulado"
        Me.colMontoAcumulado.ReadOnly = True
        Me.colMontoAcumulado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMontoAcumulado.Width = 89
        '
        'colDescripcionMovimiento
        '
        Me.colDescripcionMovimiento.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle4.NullValue = Nothing
        Me.colDescripcionMovimiento.DefaultCellStyle = DataGridViewCellStyle4
        Me.colDescripcionMovimiento.HeaderText = "Descripcion Movimiento"
        Me.colDescripcionMovimiento.Name = "colDescripcionMovimiento"
        Me.colDescripcionMovimiento.ReadOnly = True
        Me.colDescripcionMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colDescripcionMovimiento.Width = 114
        '
        'colUser
        '
        Me.colUser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUser.HeaderText = "Usuario"
        Me.colUser.Name = "colUser"
        Me.colUser.ReadOnly = True
        Me.colUser.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colUser.Width = 49
        '
        'colEstado
        '
        Me.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle5.NullValue = "No"
        Me.colEstado.DefaultCellStyle = DataGridViewCellStyle5
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colEstado.Width = 46
        '
        'colFechaEstudio
        '
        Me.colFechaEstudio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.colFechaEstudio.DefaultCellStyle = DataGridViewCellStyle6
        Me.colFechaEstudio.HeaderText = "Fecha estudio"
        Me.colFechaEstudio.Name = "colFechaEstudio"
        Me.colFechaEstudio.ReadOnly = True
        Me.colFechaEstudio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colFechaEstudio.Width = 72
        '
        'colPractica
        '
        Me.colPractica.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.colPractica.HeaderText = "Practica"
        Me.colPractica.Name = "colPractica"
        Me.colPractica.ReadOnly = True
        Me.colPractica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colPractica.Width = 52
        '
        'menuRightClick
        '
        Me.menuRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripTextBox1, Me.ToolStripTextBox2})
        Me.menuRightClick.Name = "menuRightClick"
        Me.menuRightClick.Size = New System.Drawing.Size(161, 50)
        Me.menuRightClick.Text = "Estado del movimiento"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox1.Text = "Pagado"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.ReadOnly = True
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 21)
        Me.ToolStripTextBox2.Text = "No Pagado"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1158, 231)
        Me.DataGridView1.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 479)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Importe Total:    $"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(108, 479)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(28, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "0.00"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(860, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 13)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Saldo del último Monto Acumulado: $"
        '
        'lblUltimoMontoAcumulado
        '
        Me.lblUltimoMontoAcumulado.AutoSize = True
        Me.lblUltimoMontoAcumulado.Location = New System.Drawing.Point(1048, 21)
        Me.lblUltimoMontoAcumulado.Name = "lblUltimoMontoAcumulado"
        Me.lblUltimoMontoAcumulado.Size = New System.Drawing.Size(26, 13)
        Me.lblUltimoMontoAcumulado.TabIndex = 8
        Me.lblUltimoMontoAcumulado.Text = "sald"
        '
        'btnModificarMovimiento
        '
        Me.btnModificarMovimiento.Enabled = False
        Me.btnModificarMovimiento.Location = New System.Drawing.Point(12, 437)
        Me.btnModificarMovimiento.Name = "btnModificarMovimiento"
        Me.btnModificarMovimiento.Size = New System.Drawing.Size(108, 21)
        Me.btnModificarMovimiento.TabIndex = 37
        Me.btnModificarMovimiento.Text = "Modificar"
        Me.btnModificarMovimiento.UseVisualStyleBackColor = True
        '
        'frmListadoDeMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1177, 523)
        Me.Controls.Add(Me.btnModificarMovimiento)
        Me.Controls.Add(Me.lblUltimoMontoAcumulado)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblTotal)
        Me.Name = "frmListadoDeMovimientos"
        Me.Text = "Listado De Movimientos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.menuRightClick.ResumeLayout(False)
        Me.menuRightClick.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents txtConcepto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbMedicos As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoDeMovimientos As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dtHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents checkEstudios As System.Windows.Forms.CheckBox
    Friend WithEvents checkPagado As System.Windows.Forms.CheckBox
    Friend WithEvents menuRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblUltimoMontoAcumulado As System.Windows.Forms.Label
    Friend WithEvents colFechaMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoDeMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMedico As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMontoMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMontoAcumulado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colUser As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaEstudio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPractica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnModificarMovimiento As System.Windows.Forms.Button
End Class
