<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MedicamentosMovimientoStock
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnEncontrar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.lstMedicamentos = New System.Windows.Forms.ListView
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader
        Me.grpMovimiento = New System.Windows.Forms.GroupBox
        Me.btnConfirmar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.rdbtnEgreso = New System.Windows.Forms.RadioButton
        Me.rdbtnIngreso = New System.Windows.Forms.RadioButton
        Me.numCantidad = New System.Windows.Forms.NumericUpDown
        Me.cmbAnestesistas = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDescripcion = New System.Windows.Forms.RichTextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.grpMovimiento.SuspendLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Millimeter, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(404, 37)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Listado de Medicamentos"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(15, 65)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(142, 20)
        Me.txtNombre.TabIndex = 2
        '
        'btnEncontrar
        '
        Me.btnEncontrar.Location = New System.Drawing.Point(164, 65)
        Me.btnEncontrar.Name = "btnEncontrar"
        Me.btnEncontrar.Size = New System.Drawing.Size(75, 19)
        Me.btnEncontrar.TabIndex = 3
        Me.btnEncontrar.Text = "Encontrar"
        Me.btnEncontrar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(15, 263)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 19)
        Me.btnModificar.TabIndex = 4
        Me.btnModificar.Text = "Modificar"
        Me.btnModificar.UseVisualStyleBackColor = True
        '
        'lstMedicamentos
        '
        Me.lstMedicamentos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.lstMedicamentos.FullRowSelect = True
        Me.lstMedicamentos.GridLines = True
        Me.lstMedicamentos.HideSelection = False
        Me.lstMedicamentos.Location = New System.Drawing.Point(15, 107)
        Me.lstMedicamentos.MultiSelect = False
        Me.lstMedicamentos.Name = "lstMedicamentos"
        Me.lstMedicamentos.Size = New System.Drawing.Size(596, 150)
        Me.lstMedicamentos.TabIndex = 5
        Me.lstMedicamentos.UseCompatibleStateImageBehavior = False
        Me.lstMedicamentos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Descripcion"
        Me.ColumnHeader1.Width = 307
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Cantidad en stock"
        Me.ColumnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader2.Width = 145
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Precio unitario"
        Me.ColumnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader3.Width = 138
        '
        'grpMovimiento
        '
        Me.grpMovimiento.Controls.Add(Me.Label5)
        Me.grpMovimiento.Controls.Add(Me.Label4)
        Me.grpMovimiento.Controls.Add(Me.txtDescripcion)
        Me.grpMovimiento.Controls.Add(Me.Label3)
        Me.grpMovimiento.Controls.Add(Me.cmbAnestesistas)
        Me.grpMovimiento.Controls.Add(Me.Label2)
        Me.grpMovimiento.Controls.Add(Me.rdbtnEgreso)
        Me.grpMovimiento.Controls.Add(Me.rdbtnIngreso)
        Me.grpMovimiento.Controls.Add(Me.numCantidad)
        Me.grpMovimiento.Enabled = False
        Me.grpMovimiento.Location = New System.Drawing.Point(19, 288)
        Me.grpMovimiento.Name = "grpMovimiento"
        Me.grpMovimiento.Size = New System.Drawing.Size(592, 149)
        Me.grpMovimiento.TabIndex = 6
        Me.grpMovimiento.TabStop = False
        Me.grpMovimiento.Text = "Movimiento de stock de medicacion"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Location = New System.Drawing.Point(530, 443)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(81, 22)
        Me.btnConfirmar.TabIndex = 7
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Cantidad"
        '
        'rdbtnEgreso
        '
        Me.rdbtnEgreso.AutoSize = True
        Me.rdbtnEgreso.Location = New System.Drawing.Point(220, 19)
        Me.rdbtnEgreso.Name = "rdbtnEgreso"
        Me.rdbtnEgreso.Size = New System.Drawing.Size(58, 17)
        Me.rdbtnEgreso.TabIndex = 2
        Me.rdbtnEgreso.Text = "Egreso"
        Me.rdbtnEgreso.UseVisualStyleBackColor = True
        '
        'rdbtnIngreso
        '
        Me.rdbtnIngreso.AutoSize = True
        Me.rdbtnIngreso.Checked = True
        Me.rdbtnIngreso.Location = New System.Drawing.Point(157, 19)
        Me.rdbtnIngreso.Name = "rdbtnIngreso"
        Me.rdbtnIngreso.Size = New System.Drawing.Size(63, 17)
        Me.rdbtnIngreso.TabIndex = 1
        Me.rdbtnIngreso.TabStop = True
        Me.rdbtnIngreso.Text = " Ingreso"
        Me.rdbtnIngreso.UseVisualStyleBackColor = True
        '
        'numCantidad
        '
        Me.numCantidad.Location = New System.Drawing.Point(157, 42)
        Me.numCantidad.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.numCantidad.Name = "numCantidad"
        Me.numCantidad.Size = New System.Drawing.Size(121, 20)
        Me.numCantidad.TabIndex = 0
        Me.numCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numCantidad.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmbAnestesistas
        '
        Me.cmbAnestesistas.FormattingEnabled = True
        Me.cmbAnestesistas.Location = New System.Drawing.Point(157, 68)
        Me.cmbAnestesistas.Name = "cmbAnestesistas"
        Me.cmbAnestesistas.Size = New System.Drawing.Size(121, 21)
        Me.cmbAnestesistas.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Medico Anestesista"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 95)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(429, 39)
        Me.txtDescripcion.TabIndex = 9
        Me.txtDescripcion.Text = "Se otorga medicacion a medico:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Descripcion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Tipo de Movimiento"
        '
        'MedicamentosMovimientoStock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 469)
        Me.Controls.Add(Me.grpMovimiento)
        Me.Controls.Add(Me.lstMedicamentos)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.btnEncontrar)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MedicamentosMovimientoStock"
        Me.Text = "MedicamentosStock"
        Me.grpMovimiento.ResumeLayout(False)
        Me.grpMovimiento.PerformLayout()
        CType(Me.numCantidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents btnEncontrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents lstMedicamentos As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents grpMovimiento As System.Windows.Forms.GroupBox
    Friend WithEvents rdbtnEgreso As System.Windows.Forms.RadioButton
    Friend WithEvents rdbtnIngreso As System.Windows.Forms.RadioButton
    Friend WithEvents numCantidad As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents cmbAnestesistas As System.Windows.Forms.ComboBox
    Friend WithEvents txtDescripcion As System.Windows.Forms.RichTextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
