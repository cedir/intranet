<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComplejidadABM
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
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grpComprobantes = New System.Windows.Forms.GroupBox
        Me.dtgvComplejidades = New System.Windows.Forms.DataGridView
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.importe = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPracticas = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFormula = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.grpComprobantes.SuspendLayout()
        CType(Me.dtgvComplejidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grpComprobantes
        '
        Me.grpComprobantes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpComprobantes.Controls.Add(Me.dtgvComplejidades)
        Me.grpComprobantes.Location = New System.Drawing.Point(12, 12)
        Me.grpComprobantes.Name = "grpComprobantes"
        Me.grpComprobantes.Size = New System.Drawing.Size(647, 198)
        Me.grpComprobantes.TabIndex = 11
        Me.grpComprobantes.TabStop = False
        Me.grpComprobantes.Text = "Complejidades"
        '
        'dtgvComplejidades
        '
        Me.dtgvComplejidades.AllowUserToAddRows = False
        Me.dtgvComplejidades.AllowUserToDeleteRows = False
        Me.dtgvComplejidades.AllowUserToOrderColumns = True
        Me.dtgvComplejidades.AllowUserToResizeColumns = False
        Me.dtgvComplejidades.AllowUserToResizeRows = False
        Me.dtgvComplejidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dtgvComplejidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.dtgvComplejidades.CausesValidation = False
        Me.dtgvComplejidades.ColumnHeadersHeight = 20
        Me.dtgvComplejidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dtgvComplejidades.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.importe, Me.colPracticas, Me.colFormula, Me.id})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dtgvComplejidades.DefaultCellStyle = DataGridViewCellStyle3
        Me.dtgvComplejidades.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtgvComplejidades.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dtgvComplejidades.Location = New System.Drawing.Point(3, 16)
        Me.dtgvComplejidades.MultiSelect = False
        Me.dtgvComplejidades.Name = "dtgvComplejidades"
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dtgvComplejidades.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.dtgvComplejidades.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.dtgvComplejidades.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dtgvComplejidades.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dtgvComplejidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgvComplejidades.ShowCellErrors = False
        Me.dtgvComplejidades.ShowCellToolTips = False
        Me.dtgvComplejidades.ShowEditingIcon = False
        Me.dtgvComplejidades.ShowRowErrors = False
        Me.dtgvComplejidades.Size = New System.Drawing.Size(641, 179)
        Me.dtgvComplejidades.TabIndex = 10
        Me.dtgvComplejidades.TabStop = False
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(273, 216)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'importe
        '
        Me.importe.DataPropertyName = "id"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.importe.DefaultCellStyle = DataGridViewCellStyle1
        Me.importe.FillWeight = 50.76142!
        Me.importe.HeaderText = "Id"
        Me.importe.Name = "importe"
        Me.importe.ReadOnly = True
        '
        'colPracticas
        '
        Me.colPracticas.DataPropertyName = "colPracticas"
        Me.colPracticas.HeaderText = "Practicas"
        Me.colPracticas.Name = "colPracticas"
        Me.colPracticas.Visible = False
        '
        'colFormula
        '
        Me.colFormula.DataPropertyName = "colFormula"
        Me.colFormula.HeaderText = "Formula"
        Me.colFormula.Name = "colFormula"
        Me.colFormula.Visible = False
        '
        'id
        '
        Me.id.DataPropertyName = "importe"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "C2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.id.DefaultCellStyle = DataGridViewCellStyle2
        Me.id.FillWeight = 149.2386!
        Me.id.HeaderText = "Importe"
        Me.id.Name = "id"
        '
        'ComplejidadABM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(671, 250)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.grpComprobantes)
        Me.Name = "ComplejidadABM"
        Me.Text = "ComplejidadABM"
        Me.grpComprobantes.ResumeLayout(False)
        CType(Me.dtgvComplejidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpComprobantes As System.Windows.Forms.GroupBox
    Friend WithEvents dtgvComplejidades As System.Windows.Forms.DataGridView
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPracticas As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFormula As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
