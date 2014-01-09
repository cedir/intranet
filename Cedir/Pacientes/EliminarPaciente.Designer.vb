<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEliminarPaciente
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
        Me.btnBuscarPacienteReemplazante = New System.Windows.Forms.Button
        Me.btnBuscarPaciente = New System.Windows.Forms.Button
        Me.grpPacEliminar = New System.Windows.Forms.GroupBox
        Me.lblPacienteEliminar = New System.Windows.Forms.Label
        Me.grpPacReemp = New System.Windows.Forms.GroupBox
        Me.lblPacienteReemplazante = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.GroupBox1.SuspendLayout()
        Me.grpPacEliminar.SuspendLayout()
        Me.grpPacReemp.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBuscarPacienteReemplazante)
        Me.GroupBox1.Controls.Add(Me.btnBuscarPaciente)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 9)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 0, 3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(720, 94)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'btnBuscarPacienteReemplazante
        '
        Me.btnBuscarPacienteReemplazante.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscarPacienteReemplazante.Location = New System.Drawing.Point(546, 19)
        Me.btnBuscarPacienteReemplazante.Name = "btnBuscarPacienteReemplazante"
        Me.btnBuscarPacienteReemplazante.Size = New System.Drawing.Size(168, 55)
        Me.btnBuscarPacienteReemplazante.TabIndex = 2
        Me.btnBuscarPacienteReemplazante.Text = "Presione el botón para" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "buscar un paciente REEMPLAZANTE"
        Me.btnBuscarPacienteReemplazante.UseVisualStyleBackColor = True
        '
        'btnBuscarPaciente
        '
        Me.btnBuscarPaciente.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.btnBuscarPaciente.Location = New System.Drawing.Point(6, 19)
        Me.btnBuscarPaciente.Name = "btnBuscarPaciente"
        Me.btnBuscarPaciente.Size = New System.Drawing.Size(168, 53)
        Me.btnBuscarPaciente.TabIndex = 0
        Me.btnBuscarPaciente.Text = "Presione el botón para" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "buscar un paciente a ELIMINAR"
        Me.btnBuscarPaciente.UseVisualStyleBackColor = True
        '
        'grpPacEliminar
        '
        Me.grpPacEliminar.Controls.Add(Me.lblPacienteEliminar)
        Me.grpPacEliminar.Location = New System.Drawing.Point(13, 120)
        Me.grpPacEliminar.Name = "grpPacEliminar"
        Me.grpPacEliminar.Size = New System.Drawing.Size(354, 119)
        Me.grpPacEliminar.TabIndex = 2
        Me.grpPacEliminar.TabStop = False
        Me.grpPacEliminar.Text = "Paciente a ELIMINAR"
        '
        'lblPacienteEliminar
        '
        Me.lblPacienteEliminar.AutoSize = True
        Me.lblPacienteEliminar.Location = New System.Drawing.Point(84, 34)
        Me.lblPacienteEliminar.Name = "lblPacienteEliminar"
        Me.lblPacienteEliminar.Size = New System.Drawing.Size(140, 13)
        Me.lblPacienteEliminar.TabIndex = 2
        Me.lblPacienteEliminar.Text = "datos paciente a reemplazar"
        '
        'grpPacReemp
        '
        Me.grpPacReemp.Controls.Add(Me.lblPacienteReemplazante)
        Me.grpPacReemp.Location = New System.Drawing.Point(379, 120)
        Me.grpPacReemp.Name = "grpPacReemp"
        Me.grpPacReemp.Size = New System.Drawing.Size(354, 119)
        Me.grpPacReemp.TabIndex = 3
        Me.grpPacReemp.TabStop = False
        Me.grpPacReemp.Text = "Paciente REEMPLAZANTE"
        '
        'lblPacienteReemplazante
        '
        Me.lblPacienteReemplazante.AutoSize = True
        Me.lblPacienteReemplazante.Location = New System.Drawing.Point(104, 34)
        Me.lblPacienteReemplazante.Name = "lblPacienteReemplazante"
        Me.lblPacienteReemplazante.Size = New System.Drawing.Size(143, 13)
        Me.lblPacienteReemplazante.TabIndex = 3
        Me.lblPacienteReemplazante.Text = "datos paciente reemplazante"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Button1.Location = New System.Drawing.Point(546, 39)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 53)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Reemplazar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Location = New System.Drawing.Point(13, 245)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(720, 123)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(173, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(294, 52)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Si ya decidió realizar la operación, presione el botón" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & """Reemplazar""." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Los estudi" & _
            "os del paciente eliminado, ahora pasarán a ser del " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "paciente reemplazante"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ProgressBar1
        '
        Me.ProgressBar1.BackColor = System.Drawing.Color.Black
        Me.ProgressBar1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ProgressBar1.Location = New System.Drawing.Point(189, 374)
        Me.ProgressBar1.MarqueeAnimationSpeed = 100000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(368, 23)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar1.TabIndex = 4
        Me.ProgressBar1.UseWaitCursor = True
        '
        'frmEliminarPaciente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(751, 439)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpPacReemp)
        Me.Controls.Add(Me.grpPacEliminar)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.SystemColors.Desktop
        Me.IsMdiContainer = True
        Me.Name = "frmEliminarPaciente"
        Me.Text = "Eliminar pacientes duplicados"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpPacEliminar.ResumeLayout(False)
        Me.grpPacEliminar.PerformLayout()
        Me.grpPacReemp.ResumeLayout(False)
        Me.grpPacReemp.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscarPaciente As System.Windows.Forms.Button
    Friend WithEvents grpPacEliminar As System.Windows.Forms.GroupBox
    Friend WithEvents grpPacReemp As System.Windows.Forms.GroupBox
    Friend WithEvents lblPacienteEliminar As System.Windows.Forms.Label
    Friend WithEvents lblPacienteReemplazante As System.Windows.Forms.Label
    Friend WithEvents btnBuscarPacienteReemplazante As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
End Class
