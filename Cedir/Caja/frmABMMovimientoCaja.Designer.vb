<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmABMMovimientoCaja
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
        Me.lblConcepto = New System.Windows.Forms.Label
        Me.lblMonto = New System.Windows.Forms.Label
        Me.txtConcepto = New System.Windows.Forms.RichTextBox
        Me.txtMonto = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.grpMovimiento = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMedicos = New System.Windows.Forms.ComboBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbTipoDeMovimientos = New System.Windows.Forms.ComboBox
        Me.lblAsterisk = New System.Windows.Forms.Label
        Me.btnPCF = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.grpDatosEstudio = New System.Windows.Forms.GroupBox
        Me.lblMedicoActuante = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lblObraSocial = New System.Windows.Forms.Label
        Me.lblPractica = New System.Windows.Forms.Label
        Me.lblPaciente = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView
        Me.Label2 = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.grpTotal = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.lblUltimoMontoAcumulado = New System.Windows.Forms.Label
        Me.grpMovimiento.SuspendLayout()
        Me.grpDatosEstudio.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTotal.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblConcepto
        '
        Me.lblConcepto.AutoSize = True
        Me.lblConcepto.Location = New System.Drawing.Point(11, 64)
        Me.lblConcepto.Name = "lblConcepto"
        Me.lblConcepto.Size = New System.Drawing.Size(59, 13)
        Me.lblConcepto.TabIndex = 3
        Me.lblConcepto.Text = "Concepto :"
        '
        'lblMonto
        '
        Me.lblMonto.AutoSize = True
        Me.lblMonto.Location = New System.Drawing.Point(11, 123)
        Me.lblMonto.Name = "lblMonto"
        Me.lblMonto.Size = New System.Drawing.Size(76, 13)
        Me.lblMonto.TabIndex = 5
        Me.lblMonto.Text = "Monto :         $"
        '
        'txtConcepto
        '
        Me.txtConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConcepto.Location = New System.Drawing.Point(124, 64)
        Me.txtConcepto.Name = "txtConcepto"
        Me.txtConcepto.Size = New System.Drawing.Size(624, 53)
        Me.txtConcepto.TabIndex = 2
        Me.txtConcepto.Text = ""
        '
        'txtMonto
        '
        Me.txtMonto.Location = New System.Drawing.Point(124, 123)
        Me.txtMonto.Name = "txtMonto"
        Me.txtMonto.Size = New System.Drawing.Size(161, 20)
        Me.txtMonto.TabIndex = 4
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(350, 374)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 5
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(446, 374)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'grpMovimiento
        '
        Me.grpMovimiento.Controls.Add(Me.Label1)
        Me.grpMovimiento.Controls.Add(Me.cmbMedicos)
        Me.grpMovimiento.Controls.Add(Me.Label8)
        Me.grpMovimiento.Controls.Add(Me.cmbTipoDeMovimientos)
        Me.grpMovimiento.Controls.Add(Me.lblAsterisk)
        Me.grpMovimiento.Controls.Add(Me.lblConcepto)
        Me.grpMovimiento.Controls.Add(Me.txtMonto)
        Me.grpMovimiento.Controls.Add(Me.lblMonto)
        Me.grpMovimiento.Controls.Add(Me.txtConcepto)
        Me.grpMovimiento.Location = New System.Drawing.Point(9, 6)
        Me.grpMovimiento.Name = "grpMovimiento"
        Me.grpMovimiento.Size = New System.Drawing.Size(814, 159)
        Me.grpMovimiento.TabIndex = 12
        Me.grpMovimiento.TabStop = False
        Me.grpMovimiento.Text = "Detalle"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Medico:"
        '
        'cmbMedicos
        '
        Me.cmbMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbMedicos.FormattingEnabled = True
        Me.cmbMedicos.Location = New System.Drawing.Point(124, 37)
        Me.cmbMedicos.Name = "cmbMedicos"
        Me.cmbMedicos.Size = New System.Drawing.Size(412, 21)
        Me.cmbMedicos.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Tipo De Movimiento"
        '
        'cmbTipoDeMovimientos
        '
        Me.cmbTipoDeMovimientos.DisplayMember = "descripcion"
        Me.cmbTipoDeMovimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTipoDeMovimientos.FormattingEnabled = True
        Me.cmbTipoDeMovimientos.Location = New System.Drawing.Point(124, 11)
        Me.cmbTipoDeMovimientos.Name = "cmbTipoDeMovimientos"
        Me.cmbTipoDeMovimientos.Size = New System.Drawing.Size(412, 21)
        Me.cmbTipoDeMovimientos.TabIndex = 0
        Me.cmbTipoDeMovimientos.ValueMember = "TipoDeMovimientoDeCaja"
        '
        'lblAsterisk
        '
        Me.lblAsterisk.AutoSize = True
        Me.lblAsterisk.Location = New System.Drawing.Point(291, 126)
        Me.lblAsterisk.Name = "lblAsterisk"
        Me.lblAsterisk.Size = New System.Drawing.Size(11, 13)
        Me.lblAsterisk.TabIndex = 10
        Me.lblAsterisk.Text = "*"
        '
        'btnPCF
        '
        Me.btnPCF.Location = New System.Drawing.Point(10, 104)
        Me.btnPCF.Name = "btnPCF"
        Me.btnPCF.Size = New System.Drawing.Size(103, 23)
        Me.btnPCF.TabIndex = 15
        Me.btnPCF.Text = "Realizar PCF"
        Me.btnPCF.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha: "
        '
        'grpDatosEstudio
        '
        Me.grpDatosEstudio.Controls.Add(Me.lblMedicoActuante)
        Me.grpDatosEstudio.Controls.Add(Me.Label9)
        Me.grpDatosEstudio.Controls.Add(Me.lblObraSocial)
        Me.grpDatosEstudio.Controls.Add(Me.lblPractica)
        Me.grpDatosEstudio.Controls.Add(Me.lblPaciente)
        Me.grpDatosEstudio.Controls.Add(Me.lblFecha)
        Me.grpDatosEstudio.Controls.Add(Me.Label6)
        Me.grpDatosEstudio.Controls.Add(Me.btnPCF)
        Me.grpDatosEstudio.Controls.Add(Me.Label5)
        Me.grpDatosEstudio.Controls.Add(Me.Label4)
        Me.grpDatosEstudio.Controls.Add(Me.Label3)
        Me.grpDatosEstudio.Location = New System.Drawing.Point(8, 0)
        Me.grpDatosEstudio.Name = "grpDatosEstudio"
        Me.grpDatosEstudio.Size = New System.Drawing.Size(583, 132)
        Me.grpDatosEstudio.TabIndex = 14
        Me.grpDatosEstudio.TabStop = False
        Me.grpDatosEstudio.Text = "Datos del Estudio"
        '
        'lblMedicoActuante
        '
        Me.lblMedicoActuante.AutoSize = True
        Me.lblMedicoActuante.Location = New System.Drawing.Point(295, 19)
        Me.lblMedicoActuante.Name = "lblMedicoActuante"
        Me.lblMedicoActuante.Size = New System.Drawing.Size(42, 13)
        Me.lblMedicoActuante.TabIndex = 22
        Me.lblMedicoActuante.Text = "nombre"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(198, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Médico Actuante:"
        '
        'lblObraSocial
        '
        Me.lblObraSocial.AutoSize = True
        Me.lblObraSocial.Location = New System.Drawing.Point(73, 87)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(43, 13)
        Me.lblObraSocial.TabIndex = 20
        Me.lblObraSocial.Text = "Fecha: "
        '
        'lblPractica
        '
        Me.lblPractica.AutoSize = True
        Me.lblPractica.Location = New System.Drawing.Point(59, 63)
        Me.lblPractica.Name = "lblPractica"
        Me.lblPractica.Size = New System.Drawing.Size(43, 13)
        Me.lblPractica.TabIndex = 19
        Me.lblPractica.Text = "Fecha: "
        '
        'lblPaciente
        '
        Me.lblPaciente.AutoSize = True
        Me.lblPaciente.Location = New System.Drawing.Point(59, 41)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(43, 13)
        Me.lblPaciente.TabIndex = 18
        Me.lblPaciente.Text = "Fecha: "
        '
        'lblFecha
        '
        Me.lblFecha.AutoSize = True
        Me.lblFecha.Location = New System.Drawing.Point(59, 19)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(43, 13)
        Me.lblFecha.TabIndex = 17
        Me.lblFecha.Text = "Fecha: "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 87)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Obra Social:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Práctica: "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 41)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Paciente:"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 138)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(834, 193)
        Me.TabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.grpMovimiento)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(826, 167)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Un Movimiento"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvMovimientos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(826, 167)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Varios Movimientos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvMovimientos.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientos.Location = New System.Drawing.Point(3, 3)
        Me.dgvMovimientos.MultiSelect = False
        Me.dgvMovimientos.Name = "dgvMovimientos"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvMovimientos.RowHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientos.Size = New System.Drawing.Size(820, 161)
        Me.dgvMovimientos.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Total Grilla....... $:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(96, 16)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(64, 13)
        Me.lblTotal.TabIndex = 17
        Me.lblTotal.Text = "Total....... $:"
        '
        'grpTotal
        '
        Me.grpTotal.Controls.Add(Me.Label2)
        Me.grpTotal.Controls.Add(Me.lblTotal)
        Me.grpTotal.Location = New System.Drawing.Point(668, 337)
        Me.grpTotal.Name = "grpTotal"
        Me.grpTotal.Size = New System.Drawing.Size(174, 41)
        Me.grpTotal.TabIndex = 18
        Me.grpTotal.TabStop = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(597, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(137, 13)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Último Monto Acumulado: $"
        '
        'lblUltimoMontoAcumulado
        '
        Me.lblUltimoMontoAcumulado.AutoSize = True
        Me.lblUltimoMontoAcumulado.Location = New System.Drawing.Point(740, 9)
        Me.lblUltimoMontoAcumulado.Name = "lblUltimoMontoAcumulado"
        Me.lblUltimoMontoAcumulado.Size = New System.Drawing.Size(39, 13)
        Me.lblUltimoMontoAcumulado.TabIndex = 24
        Me.lblUltimoMontoAcumulado.Text = "Último "
        '
        'frmABMMovimientoCaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(864, 406)
        Me.Controls.Add(Me.lblUltimoMontoAcumulado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.grpTotal)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.grpDatosEstudio)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "frmABMMovimientoCaja"
        Me.Text = "Crear Movimiento de caja"
        Me.grpMovimiento.ResumeLayout(False)
        Me.grpMovimiento.PerformLayout()
        Me.grpDatosEstudio.ResumeLayout(False)
        Me.grpDatosEstudio.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTotal.ResumeLayout(False)
        Me.grpTotal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblConcepto As System.Windows.Forms.Label
    Friend WithEvents lblMonto As System.Windows.Forms.Label
    Friend WithEvents txtConcepto As System.Windows.Forms.RichTextBox
    Friend WithEvents txtMonto As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
    Friend WithEvents lblAsterisk As System.Windows.Forms.Label
    Friend WithEvents btnPCF As System.Windows.Forms.Button
    Friend WithEvents grpDatosEstudio As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoDeMovimientos As System.Windows.Forms.ComboBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbMedicos As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents lblPractica As System.Windows.Forms.Label
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents grpTotal As System.Windows.Forms.GroupBox
    Friend WithEvents lblMedicoActuante As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lblUltimoMontoAcumulado As System.Windows.Forms.Label

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class
