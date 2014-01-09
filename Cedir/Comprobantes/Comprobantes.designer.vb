<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comprobantes
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPacienteGravado = New System.Windows.Forms.TextBox
        Me.lblPacienteGravado = New System.Windows.Forms.Label
        Me.txtCondicionFiscal = New System.Windows.Forms.TextBox
        Me.txtNroCuit = New System.Windows.Forms.TextBox
        Me.txtDomicilio = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtTipo = New System.Windows.Forms.TextBox
        Me.txtSubtipo = New System.Windows.Forms.TextBox
        Me.txtGravado = New System.Windows.Forms.TextBox
        Me.txtResponsable = New System.Windows.Forms.TextBox
        Me.lblGuion = New System.Windows.Forms.Label
        Me.txtNroTerminal = New System.Windows.Forms.TextBox
        Me.lblSubTipo = New System.Windows.Forms.Label
        Me.txtNroComprobante = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblNroComprobante = New System.Windows.Forms.Label
        Me.grpDataGridView = New System.Windows.Forms.GroupBox
        Me.dgvLineasDeComprobante = New System.Windows.Forms.DataGridView
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnAnular = New System.Windows.Forms.Button
        Me.lblEstadoDelComrobante = New System.Windows.Forms.Label
        Me.lblEstado = New System.Windows.Forms.Label
        Me.lblTotalString = New System.Windows.Forms.Label
        Me.lblTotalDecimal = New System.Windows.Forms.Label
        Me.chkLeyenda = New System.Windows.Forms.CheckBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grpDataGridView.SuspendLayout()
        CType(Me.dgvLineasDeComprobante, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPacienteGravado)
        Me.GroupBox1.Controls.Add(Me.lblPacienteGravado)
        Me.GroupBox1.Controls.Add(Me.txtCondicionFiscal)
        Me.GroupBox1.Controls.Add(Me.txtNroCuit)
        Me.GroupBox1.Controls.Add(Me.txtDomicilio)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(472, 180)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cliente"
        '
        'txtPacienteGravado
        '
        Me.txtPacienteGravado.Location = New System.Drawing.Point(96, 157)
        Me.txtPacienteGravado.Name = "txtPacienteGravado"
        Me.txtPacienteGravado.ReadOnly = True
        Me.txtPacienteGravado.Size = New System.Drawing.Size(198, 20)
        Me.txtPacienteGravado.TabIndex = 34
        '
        'lblPacienteGravado
        '
        Me.lblPacienteGravado.Location = New System.Drawing.Point(0, 159)
        Me.lblPacienteGravado.Name = "lblPacienteGravado"
        Me.lblPacienteGravado.Size = New System.Drawing.Size(99, 18)
        Me.lblPacienteGravado.TabIndex = 33
        Me.lblPacienteGravado.Text = "Paciente Gravado: "
        '
        'txtCondicionFiscal
        '
        Me.txtCondicionFiscal.Location = New System.Drawing.Point(96, 130)
        Me.txtCondicionFiscal.Name = "txtCondicionFiscal"
        Me.txtCondicionFiscal.ReadOnly = True
        Me.txtCondicionFiscal.Size = New System.Drawing.Size(198, 20)
        Me.txtCondicionFiscal.TabIndex = 32
        '
        'txtNroCuit
        '
        Me.txtNroCuit.Location = New System.Drawing.Point(96, 75)
        Me.txtNroCuit.Multiline = True
        Me.txtNroCuit.Name = "txtNroCuit"
        Me.txtNroCuit.ReadOnly = True
        Me.txtNroCuit.Size = New System.Drawing.Size(198, 49)
        Me.txtNroCuit.TabIndex = 8
        '
        'txtDomicilio
        '
        Me.txtDomicilio.Location = New System.Drawing.Point(96, 47)
        Me.txtDomicilio.Name = "txtDomicilio"
        Me.txtDomicilio.ReadOnly = True
        Me.txtDomicilio.Size = New System.Drawing.Size(352, 20)
        Me.txtDomicilio.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(7, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 23)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Condición Fiscal:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(31, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 23)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Nro de Cuit:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(42, 48)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Domicilio:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(48, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(96, 18)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.ReadOnly = True
        Me.txtNombre.Size = New System.Drawing.Size(352, 20)
        Me.txtNombre.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtTipo)
        Me.GroupBox2.Controls.Add(Me.txtSubtipo)
        Me.GroupBox2.Controls.Add(Me.txtGravado)
        Me.GroupBox2.Controls.Add(Me.txtResponsable)
        Me.GroupBox2.Controls.Add(Me.lblGuion)
        Me.GroupBox2.Controls.Add(Me.txtNroTerminal)
        Me.GroupBox2.Controls.Add(Me.lblSubTipo)
        Me.GroupBox2.Controls.Add(Me.txtNroComprobante)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblNroComprobante)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 212)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(472, 121)
        Me.GroupBox2.TabIndex = 23
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Comprobante"
        '
        'txtTipo
        '
        Me.txtTipo.Location = New System.Drawing.Point(315, 19)
        Me.txtTipo.Name = "txtTipo"
        Me.txtTipo.ReadOnly = True
        Me.txtTipo.Size = New System.Drawing.Size(133, 20)
        Me.txtTipo.TabIndex = 36
        Me.txtTipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtSubtipo
        '
        Me.txtSubtipo.Location = New System.Drawing.Point(96, 84)
        Me.txtSubtipo.Name = "txtSubtipo"
        Me.txtSubtipo.ReadOnly = True
        Me.txtSubtipo.Size = New System.Drawing.Size(65, 20)
        Me.txtSubtipo.TabIndex = 35
        Me.txtSubtipo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtGravado
        '
        Me.txtGravado.Location = New System.Drawing.Point(96, 53)
        Me.txtGravado.Name = "txtGravado"
        Me.txtGravado.ReadOnly = True
        Me.txtGravado.Size = New System.Drawing.Size(121, 20)
        Me.txtGravado.TabIndex = 34
        '
        'txtResponsable
        '
        Me.txtResponsable.Location = New System.Drawing.Point(96, 22)
        Me.txtResponsable.Name = "txtResponsable"
        Me.txtResponsable.ReadOnly = True
        Me.txtResponsable.Size = New System.Drawing.Size(121, 20)
        Me.txtResponsable.TabIndex = 33
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Location = New System.Drawing.Point(359, 90)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(10, 13)
        Me.lblGuion.TabIndex = 31
        Me.lblGuion.Text = "-"
        '
        'txtNroTerminal
        '
        Me.txtNroTerminal.Location = New System.Drawing.Point(284, 88)
        Me.txtNroTerminal.Name = "txtNroTerminal"
        Me.txtNroTerminal.ReadOnly = True
        Me.txtNroTerminal.Size = New System.Drawing.Size(68, 20)
        Me.txtNroTerminal.TabIndex = 30
        Me.txtNroTerminal.Text = "0001"
        Me.txtNroTerminal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblSubTipo
        '
        Me.lblSubTipo.AutoSize = True
        Me.lblSubTipo.Location = New System.Drawing.Point(37, 88)
        Me.lblSubTipo.Name = "lblSubTipo"
        Me.lblSubTipo.Size = New System.Drawing.Size(53, 13)
        Me.lblSubTipo.TabIndex = 28
        Me.lblSubTipo.Text = "Sub-Tipo:"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(376, 88)
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.ReadOnly = True
        Me.txtNroComprobante.Size = New System.Drawing.Size(72, 20)
        Me.txtNroComprobante.TabIndex = 27
        Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(20, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Responsable:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(40, 54)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Gravado:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(278, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Tipo:"
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.Location = New System.Drawing.Point(278, 57)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.Size = New System.Drawing.Size(170, 23)
        Me.lblNroComprobante.TabIndex = 21
        Me.lblNroComprobante.Text = "Nro de Cmprobante: "
        '
        'grpDataGridView
        '
        Me.grpDataGridView.Controls.Add(Me.dgvLineasDeComprobante)
        Me.grpDataGridView.Location = New System.Drawing.Point(12, 339)
        Me.grpDataGridView.Name = "grpDataGridView"
        Me.grpDataGridView.Size = New System.Drawing.Size(472, 137)
        Me.grpDataGridView.TabIndex = 24
        Me.grpDataGridView.TabStop = False
        Me.grpDataGridView.Text = "Lineas"
        '
        'dgvLineasDeComprobante
        '
        Me.dgvLineasDeComprobante.AllowUserToAddRows = False
        Me.dgvLineasDeComprobante.AllowUserToDeleteRows = False
        Me.dgvLineasDeComprobante.AllowUserToResizeColumns = False
        Me.dgvLineasDeComprobante.AllowUserToResizeRows = False
        Me.dgvLineasDeComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvLineasDeComprobante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.dgvLineasDeComprobante.CausesValidation = False
        Me.dgvLineasDeComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLineasDeComprobante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLineasDeComprobante.Location = New System.Drawing.Point(3, 16)
        Me.dgvLineasDeComprobante.Name = "dgvLineasDeComprobante"
        Me.dgvLineasDeComprobante.ReadOnly = True
        Me.dgvLineasDeComprobante.Size = New System.Drawing.Size(466, 118)
        Me.dgvLineasDeComprobante.TabIndex = 0
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(326, 533)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 25
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(407, 533)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 26
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(245, 533)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(75, 23)
        Me.btnAnular.TabIndex = 27
        Me.btnAnular.Text = "Anular"
        Me.btnAnular.UseVisualStyleBackColor = True
        Me.btnAnular.Visible = False
        '
        'lblEstadoDelComrobante
        '
        Me.lblEstadoDelComrobante.AutoSize = True
        Me.lblEstadoDelComrobante.Location = New System.Drawing.Point(22, 9)
        Me.lblEstadoDelComrobante.Name = "lblEstadoDelComrobante"
        Me.lblEstadoDelComrobante.Size = New System.Drawing.Size(170, 13)
        Me.lblEstadoDelComrobante.TabIndex = 28
        Me.lblEstadoDelComrobante.Text = "ESTADO DEL COMPROBANTE  :"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Location = New System.Drawing.Point(219, 9)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(51, 13)
        Me.lblEstado.TabIndex = 29
        Me.lblEstado.Text = "ESTADO"
        '
        'lblTotalString
        '
        Me.lblTotalString.AutoSize = True
        Me.lblTotalString.Location = New System.Drawing.Point(327, 479)
        Me.lblTotalString.Name = "lblTotalString"
        Me.lblTotalString.Size = New System.Drawing.Size(45, 13)
        Me.lblTotalString.TabIndex = 30
        Me.lblTotalString.Text = "TOTAL:"
        '
        'lblTotalDecimal
        '
        Me.lblTotalDecimal.AutoSize = True
        Me.lblTotalDecimal.Location = New System.Drawing.Point(403, 479)
        Me.lblTotalDecimal.Name = "lblTotalDecimal"
        Me.lblTotalDecimal.Size = New System.Drawing.Size(42, 13)
        Me.lblTotalDecimal.TabIndex = 31
        Me.lblTotalDecimal.Text = "TOTAL"
        '
        'chkLeyenda
        '
        Me.chkLeyenda.AutoSize = True
        Me.chkLeyenda.Location = New System.Drawing.Point(15, 492)
        Me.chkLeyenda.Name = "chkLeyenda"
        Me.chkLeyenda.Size = New System.Drawing.Size(144, 17)
        Me.chkLeyenda.TabIndex = 32
        Me.chkLeyenda.Text = "* Incluir leyenda opcional"
        Me.chkLeyenda.UseVisualStyleBackColor = True
        '
        'Comprobantes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(513, 568)
        Me.Controls.Add(Me.chkLeyenda)
        Me.Controls.Add(Me.lblTotalDecimal)
        Me.Controls.Add(Me.lblTotalString)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblEstadoDelComrobante)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.grpDataGridView)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Comprobantes"
        Me.Text = "Comprobantes"
        Me.TopMost = True
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grpDataGridView.ResumeLayout(False)
        CType(Me.dgvLineasDeComprobante, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNroCuit As System.Windows.Forms.TextBox
    Friend WithEvents txtDomicilio As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblGuion As System.Windows.Forms.Label
    Friend WithEvents txtNroTerminal As System.Windows.Forms.TextBox
    Friend WithEvents lblSubTipo As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblNroComprobante As System.Windows.Forms.Label
    Friend WithEvents grpDataGridView As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLineasDeComprobante As System.Windows.Forms.DataGridView
    Friend WithEvents txtCondicionFiscal As System.Windows.Forms.TextBox
    Friend WithEvents txtGravado As System.Windows.Forms.TextBox
    Friend WithEvents txtResponsable As System.Windows.Forms.TextBox
    Friend WithEvents txtTipo As System.Windows.Forms.TextBox
    Friend WithEvents txtSubtipo As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents lblEstadoDelComrobante As System.Windows.Forms.Label
    Friend WithEvents lblEstado As System.Windows.Forms.Label
    Friend WithEvents lblTotalString As System.Windows.Forms.Label
    Friend WithEvents lblTotalDecimal As System.Windows.Forms.Label
    Friend WithEvents chkLeyenda As System.Windows.Forms.CheckBox
    Friend WithEvents txtPacienteGravado As System.Windows.Forms.TextBox
    Friend WithEvents lblPacienteGravado As System.Windows.Forms.Label
End Class
