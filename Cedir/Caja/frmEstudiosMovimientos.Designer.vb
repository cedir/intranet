<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEstudiosMovimientos
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.dgvListaEstudios = New System.Windows.Forms.DataGridView
        Me.colPaciente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colPractica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMedicoActuante = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFechaMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDescripcionMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTipoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMontoMovimiento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvListaEstudios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvListaEstudios)
        Me.GroupBox2.Location = New System.Drawing.Point(4, 34)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(950, 217)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Listado de estudios"
        '
        'dgvListaEstudios
        '
        Me.dgvListaEstudios.AllowUserToAddRows = False
        Me.dgvListaEstudios.AllowUserToDeleteRows = False
        Me.dgvListaEstudios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvListaEstudios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colPaciente, Me.colPractica, Me.colOS, Me.colMedicoActuante, Me.colFechaMovimiento, Me.colDescripcionMovimiento, Me.colTipoMovimiento, Me.colMontoMovimiento, Me.colEstado})
        Me.dgvListaEstudios.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvListaEstudios.Location = New System.Drawing.Point(3, 16)
        Me.dgvListaEstudios.MultiSelect = False
        Me.dgvListaEstudios.Name = "dgvListaEstudios"
        Me.dgvListaEstudios.ReadOnly = True
        Me.dgvListaEstudios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvListaEstudios.Size = New System.Drawing.Size(944, 198)
        Me.dgvListaEstudios.TabIndex = 0
        '
        'colPaciente
        '
        Me.colPaciente.DataPropertyName = "paciente.nombres"
        Me.colPaciente.HeaderText = "Paciente"
        Me.colPaciente.Name = "colPaciente"
        Me.colPaciente.ReadOnly = True
        Me.colPaciente.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colPractica
        '
        Me.colPractica.HeaderText = "Practica"
        Me.colPractica.Name = "colPractica"
        Me.colPractica.ReadOnly = True
        Me.colPractica.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colOS
        '
        Me.colOS.DataPropertyName = "obraSocial"
        Me.colOS.HeaderText = "ObraSocial"
        Me.colOS.Name = "colOS"
        Me.colOS.ReadOnly = True
        Me.colOS.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colMedicoActuante
        '
        Me.colMedicoActuante.HeaderText = "Medico Actuante"
        Me.colMedicoActuante.Name = "colMedicoActuante"
        Me.colMedicoActuante.ReadOnly = True
        Me.colMedicoActuante.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colFechaMovimiento
        '
        Me.colFechaMovimiento.HeaderText = "Fecha Movimiento"
        Me.colFechaMovimiento.Name = "colFechaMovimiento"
        Me.colFechaMovimiento.ReadOnly = True
        Me.colFechaMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colDescripcionMovimiento
        '
        Me.colDescripcionMovimiento.HeaderText = "Descripcion Movimiento"
        Me.colDescripcionMovimiento.Name = "colDescripcionMovimiento"
        Me.colDescripcionMovimiento.ReadOnly = True
        Me.colDescripcionMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colTipoMovimiento
        '
        Me.colTipoMovimiento.DataPropertyName = "estudio.MovimientoDeCaja.TipoDeMovimientoDeCaja"
        Me.colTipoMovimiento.HeaderText = "Tipo De movimiento"
        Me.colTipoMovimiento.Name = "colTipoMovimiento"
        Me.colTipoMovimiento.ReadOnly = True
        Me.colTipoMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colMontoMovimiento
        '
        Me.colMontoMovimiento.HeaderText = "Monto"
        Me.colMontoMovimiento.Name = "colMontoMovimiento"
        Me.colMontoMovimiento.ReadOnly = True
        Me.colMontoMovimiento.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'colEstado
        '
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(119, 5)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(209, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha del Estudio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Importe Total:    $"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(3, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(110, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Crear Movimiento"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmEstudiosMovimientos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 299)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "frmEstudiosMovimientos"
        Me.Text = "Listado de Estudios con movimientos de caja"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvListaEstudios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvListaEstudios As System.Windows.Forms.DataGridView
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents colPaciente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colPractica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMedicoActuante As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFechaMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTipoMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMontoMovimiento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
