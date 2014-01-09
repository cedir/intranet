<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ListadoHonorariosCedir
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnSelFechaHasta = New System.Windows.Forms.Button
        Me.cmbPracticas = New System.Windows.Forms.ComboBox
        Me.btnSelFechaDesde = New System.Windows.Forms.Button
        Me.btnSeleccionar = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFechaDesde = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtFechaHasta = New System.Windows.Forms.TextBox
        Me.dgv = New System.Windows.Forms.DataGridView
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoEstudio = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMedicoActuante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMedicoSolicitante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colImporte = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblHonorarioCedir = New System.Windows.Forms.Label
        Me.lbl5 = New System.Windows.Forms.Label
        Me.lblImporte = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.lblTotMedAct = New System.Windows.Forms.Label
        Me.lblTotalMedicoSolicitante = New System.Windows.Forms.Label
        Me.lbl3 = New System.Windows.Forms.Label
        Me.lbl2 = New System.Windows.Forms.Label
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSelFechaHasta)
        Me.GroupBox1.Controls.Add(Me.cmbPracticas)
        Me.GroupBox1.Controls.Add(Me.btnSelFechaDesde)
        Me.GroupBox1.Controls.Add(Me.btnSeleccionar)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesde)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtFechaHasta)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(895, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btnSelFechaHasta
        '
        Me.btnSelFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelFechaHasta.Location = New System.Drawing.Point(572, 45)
        Me.btnSelFechaHasta.Name = "btnSelFechaHasta"
        Me.btnSelFechaHasta.Size = New System.Drawing.Size(75, 18)
        Me.btnSelFechaHasta.TabIndex = 30
        Me.btnSelFechaHasta.Text = "Seleccione..."
        Me.btnSelFechaHasta.UseVisualStyleBackColor = True
        '
        'cmbPracticas
        '
        Me.cmbPracticas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbPracticas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbPracticas.FormattingEnabled = True
        Me.cmbPracticas.Items.AddRange(New Object() {"Ecografias", "Analisis Bioquimicos"})
        Me.cmbPracticas.Location = New System.Drawing.Point(6, 20)
        Me.cmbPracticas.Name = "cmbPracticas"
        Me.cmbPracticas.Size = New System.Drawing.Size(313, 21)
        Me.cmbPracticas.TabIndex = 1
        '
        'btnSelFechaDesde
        '
        Me.btnSelFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelFechaDesde.Location = New System.Drawing.Point(572, 22)
        Me.btnSelFechaDesde.Name = "btnSelFechaDesde"
        Me.btnSelFechaDesde.Size = New System.Drawing.Size(75, 18)
        Me.btnSelFechaDesde.TabIndex = 28
        Me.btnSelFechaDesde.Text = "Seleccione..."
        Me.btnSelFechaDesde.UseVisualStyleBackColor = True
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(6, 46)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 0
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(387, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 16)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha Desde:"
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(466, 20)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaDesde.TabIndex = 3
        Me.txtFechaDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(387, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Fecha Hasta:"
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(466, 43)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaHasta.TabIndex = 23
        Me.txtFechaHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colFecha, Me.colPaciente, Me.colTipoEstudio, Me.colOS, Me.colMedicoActuante, Me.colMedicoSolicitante, Me.colImporte, Me.colEstado})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgv.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgv.Location = New System.Drawing.Point(18, 99)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgv.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dgv.Size = New System.Drawing.Size(889, 294)
        Me.dgv.TabIndex = 1
        '
        'colFecha
        '
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        '
        'colPaciente
        '
        Me.colPaciente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colPaciente.HeaderText = "Paciente"
        Me.colPaciente.Name = "colPaciente"
        Me.colPaciente.ReadOnly = True
        '
        'colTipoEstudio
        '
        Me.colTipoEstudio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colTipoEstudio.HeaderText = "Tipo De Estudio"
        Me.colTipoEstudio.Name = "colTipoEstudio"
        Me.colTipoEstudio.ReadOnly = True
        '
        'colOS
        '
        Me.colOS.HeaderText = "Obra Social"
        Me.colOS.Name = "colOS"
        Me.colOS.ReadOnly = True
        '
        'colMedicoActuante
        '
        Me.colMedicoActuante.HeaderText = "Medico Actuante"
        Me.colMedicoActuante.Name = "colMedicoActuante"
        Me.colMedicoActuante.ReadOnly = True
        '
        'colMedicoSolicitante
        '
        Me.colMedicoSolicitante.HeaderText = "Medico Solicitante"
        Me.colMedicoSolicitante.Name = "colMedicoSolicitante"
        Me.colMedicoSolicitante.ReadOnly = True
        '
        'colImporte
        '
        Me.colImporte.HeaderText = "Importe"
        Me.colImporte.Name = "colImporte"
        Me.colImporte.ReadOnly = True
        '
        'colEstado
        '
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblHonorarioCedir)
        Me.GroupBox2.Controls.Add(Me.lbl5)
        Me.GroupBox2.Controls.Add(Me.lblImporte)
        Me.GroupBox2.Controls.Add(Me.lbl4)
        Me.GroupBox2.Controls.Add(Me.lblTotMedAct)
        Me.GroupBox2.Controls.Add(Me.lblTotalMedicoSolicitante)
        Me.GroupBox2.Controls.Add(Me.lbl3)
        Me.GroupBox2.Controls.Add(Me.lbl2)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 399)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(894, 140)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Honorarios"
        '
        'lblHonorarioCedir
        '
        Me.lblHonorarioCedir.AutoSize = True
        Me.lblHonorarioCedir.Location = New System.Drawing.Point(156, 115)
        Me.lblHonorarioCedir.Name = "lblHonorarioCedir"
        Me.lblHonorarioCedir.Size = New System.Drawing.Size(13, 13)
        Me.lblHonorarioCedir.TabIndex = 9
        Me.lblHonorarioCedir.Text = "--"
        '
        'lbl5
        '
        Me.lbl5.AutoSize = True
        Me.lbl5.Location = New System.Drawing.Point(6, 115)
        Me.lbl5.Name = "lbl5"
        Me.lbl5.Size = New System.Drawing.Size(106, 13)
        Me.lbl5.TabIndex = 8
        Me.lbl5.Text = "Honorario Cedir(15%)"
        '
        'lblImporte
        '
        Me.lblImporte.AutoSize = True
        Me.lblImporte.Location = New System.Drawing.Point(790, 16)
        Me.lblImporte.Name = "lblImporte"
        Me.lblImporte.Size = New System.Drawing.Size(13, 13)
        Me.lblImporte.TabIndex = 7
        Me.lblImporte.Text = "--"
        '
        'lbl4
        '
        Me.lbl4.AutoSize = True
        Me.lbl4.Location = New System.Drawing.Point(702, 16)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.Size = New System.Drawing.Size(42, 13)
        Me.lbl4.TabIndex = 6
        Me.lbl4.Text = "Importe"
        '
        'lblTotMedAct
        '
        Me.lblTotMedAct.AutoSize = True
        Me.lblTotMedAct.Location = New System.Drawing.Point(153, 20)
        Me.lblTotMedAct.Name = "lblTotMedAct"
        Me.lblTotMedAct.Size = New System.Drawing.Size(13, 13)
        Me.lblTotMedAct.TabIndex = 4
        Me.lblTotMedAct.Text = "--"
        '
        'lblTotalMedicoSolicitante
        '
        Me.lblTotalMedicoSolicitante.AutoSize = True
        Me.lblTotalMedicoSolicitante.Location = New System.Drawing.Point(153, 72)
        Me.lblTotalMedicoSolicitante.Name = "lblTotalMedicoSolicitante"
        Me.lblTotalMedicoSolicitante.Size = New System.Drawing.Size(13, 13)
        Me.lblTotalMedicoSolicitante.TabIndex = 3
        Me.lblTotalMedicoSolicitante.Text = "--"
        '
        'lbl3
        '
        Me.lbl3.AutoSize = True
        Me.lbl3.Location = New System.Drawing.Point(6, 72)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(147, 13)
        Me.lbl3.TabIndex = 2
        Me.lbl3.Text = "Total Medico Solicitante(15%)"
        '
        'lbl2
        '
        Me.lbl2.AutoSize = True
        Me.lbl2.Location = New System.Drawing.Point(6, 20)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Size = New System.Drawing.Size(141, 13)
        Me.lbl2.TabIndex = 1
        Me.lbl2.Text = "Total Medico Actuante(70%)"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(478, 67)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ScrollChange = 1
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.TabIndex = 31
        Me.MonthCalendar1.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(12, 545)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 32
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'ListadoHonorariosCedir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(919, 569)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ListadoHonorariosCedir"
        Me.Text = "ListadoHonorariosCedir"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents cmbPracticas As System.Windows.Forms.ComboBox
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSelFechaHasta As System.Windows.Forms.Button
    Friend WithEvents btnSelFechaDesde As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents lblTotMedAct As System.Windows.Forms.Label
    Friend WithEvents lblTotalMedicoSolicitante As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents lblImporte As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents lblHonorarioCedir As System.Windows.Forms.Label
    Friend WithEvents lbl5 As System.Windows.Forms.Label
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoEstudio As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMedicoActuante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMedicoSolicitante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colImporte As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
