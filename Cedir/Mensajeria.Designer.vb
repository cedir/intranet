<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mensajeria
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
        Me.Label3 = New System.Windows.Forms.Label
        Me.lstBoxDestinatarios = New System.Windows.Forms.ListBox
        Me.btnLimpiar = New System.Windows.Forms.Button
        Me.cmbDestinatarios = New System.Windows.Forms.ComboBox
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnEnviar = New System.Windows.Forms.Button
        Me.txtMensaje = New System.Windows.Forms.RichTextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCopiarPortapapeles = New System.Windows.Forms.Button
        Me.ListView1 = New System.Windows.Forms.ListView
        Me.colFecha = New System.Windows.Forms.ColumnHeader
        Me.colRemitente = New System.Windows.Forms.ColumnHeader
        Me.colMensaje = New System.Windows.Forms.ColumnHeader
        Me.colEstado = New System.Windows.Forms.ColumnHeader
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbAccion = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTipoMensaje = New System.Windows.Forms.ComboBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtBuscadorDescripcion = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lstBoxDestinatarios)
        Me.GroupBox1.Controls.Add(Me.btnLimpiar)
        Me.GroupBox1.Controls.Add(Me.cmbDestinatarios)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.btnEnviar)
        Me.GroupBox1.Controls.Add(Me.txtMensaje)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(674, 185)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Mensaje"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(234, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 26)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Destinatarios " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Seleccionados  :"
        '
        'lstBoxDestinatarios
        '
        Me.lstBoxDestinatarios.FormattingEnabled = True
        Me.lstBoxDestinatarios.Location = New System.Drawing.Point(331, 12)
        Me.lstBoxDestinatarios.MultiColumn = True
        Me.lstBoxDestinatarios.Name = "lstBoxDestinatarios"
        Me.lstBoxDestinatarios.Size = New System.Drawing.Size(232, 69)
        Me.lstBoxDestinatarios.TabIndex = 14
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiar.Location = New System.Drawing.Point(570, 43)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(76, 24)
        Me.btnLimpiar.TabIndex = 13
        Me.btnLimpiar.Text = "Limpiar"
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'cmbDestinatarios
        '
        Me.cmbDestinatarios.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbDestinatarios.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbDestinatarios.FormattingEnabled = True
        Me.cmbDestinatarios.Location = New System.Drawing.Point(75, 16)
        Me.cmbDestinatarios.Name = "cmbDestinatarios"
        Me.cmbDestinatarios.Size = New System.Drawing.Size(157, 21)
        Me.cmbDestinatarios.TabIndex = 11
        '
        'btnQuitar
        '
        Me.btnQuitar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuitar.Location = New System.Drawing.Point(571, 12)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 25)
        Me.btnQuitar.TabIndex = 10
        Me.btnQuitar.Text = "Quitar"
        Me.btnQuitar.UseVisualStyleBackColor = True
        '
        'btnEnviar
        '
        Me.btnEnviar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnviar.Location = New System.Drawing.Point(571, 153)
        Me.btnEnviar.Name = "btnEnviar"
        Me.btnEnviar.Size = New System.Drawing.Size(75, 23)
        Me.btnEnviar.TabIndex = 6
        Me.btnEnviar.Text = "Enviar"
        Me.btnEnviar.UseVisualStyleBackColor = True
        '
        'txtMensaje
        '
        Me.txtMensaje.DetectUrls = False
        Me.txtMensaje.Location = New System.Drawing.Point(75, 81)
        Me.txtMensaje.Name = "txtMensaje"
        Me.txtMensaje.Size = New System.Drawing.Size(488, 95)
        Me.txtMensaje.TabIndex = 5
        Me.txtMensaje.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mensaje"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Elija un " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "destinatario:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.txtBuscadorDescripcion)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btnCopiarPortapapeles)
        Me.GroupBox2.Controls.Add(Me.ListView1)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbAccion)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbTipoMensaje)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 191)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(674, 346)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Bandeja de Mensajes"
        '
        'btnCopiarPortapapeles
        '
        Me.btnCopiarPortapapeles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCopiarPortapapeles.Location = New System.Drawing.Point(519, 11)
        Me.btnCopiarPortapapeles.Name = "btnCopiarPortapapeles"
        Me.btnCopiarPortapapeles.Size = New System.Drawing.Size(127, 23)
        Me.btnCopiarPortapapeles.TabIndex = 15
        Me.btnCopiarPortapapeles.Text = "Copiar a Portapapeles"
        Me.btnCopiarPortapapeles.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.CheckBoxes = True
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFecha, Me.colRemitente, Me.colMensaje, Me.colEstado})
        Me.ListView1.FullRowSelect = True
        Me.ListView1.GridLines = True
        Me.ListView1.Location = New System.Drawing.Point(5, 74)
        Me.ListView1.MultiSelect = False
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(659, 262)
        Me.ListView1.TabIndex = 14
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'colFecha
        '
        Me.colFecha.Text = "Fecha"
        Me.colFecha.Width = 131
        '
        'colRemitente
        '
        Me.colRemitente.Text = "Remitente"
        Me.colRemitente.Width = 80
        '
        'colMensaje
        '
        Me.colMensaje.Text = "Mensaje"
        Me.colMensaje.Width = 380
        '
        'colEstado
        '
        Me.colEstado.Text = "Estado"
        Me.colEstado.Width = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(249, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Accion..."
        '
        'cmbAccion
        '
        Me.cmbAccion.FormattingEnabled = True
        Me.cmbAccion.Items.AddRange(New Object() {"Marcar Leído", "Marcar No Leído", "Eliminar"})
        Me.cmbAccion.Location = New System.Drawing.Point(304, 13)
        Me.cmbAccion.Name = "cmbAccion"
        Me.cmbAccion.Size = New System.Drawing.Size(121, 21)
        Me.cmbAccion.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Ver mensajes..."
        '
        'cmbTipoMensaje
        '
        Me.cmbTipoMensaje.FormattingEnabled = True
        Me.cmbTipoMensaje.Items.AddRange(New Object() {"Leídos", "No Leídos", "Todos"})
        Me.cmbTipoMensaje.Location = New System.Drawing.Point(122, 13)
        Me.cmbTipoMensaje.Name = "cmbTipoMensaje"
        Me.cmbTipoMensaje.Size = New System.Drawing.Size(121, 21)
        Me.cmbTipoMensaje.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Buscar descripción..:"
        '
        'txtBuscadorDescripcion
        '
        Me.txtBuscadorDescripcion.Location = New System.Drawing.Point(122, 43)
        Me.txtBuscadorDescripcion.Name = "txtBuscadorDescripcion"
        Me.txtBuscadorDescripcion.Size = New System.Drawing.Size(303, 20)
        Me.txtBuscadorDescripcion.TabIndex = 17
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(519, 46)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 22)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Mensajeria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(676, 542)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Mensajeria"
        Me.Text = "Mensajeria"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEnviar As System.Windows.Forms.Button
    Friend WithEvents txtMensaje As System.Windows.Forms.RichTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoMensaje As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAccion As System.Windows.Forms.ComboBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents colFecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents colRemitente As System.Windows.Forms.ColumnHeader
    Friend WithEvents colMensaje As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnLimpiar As System.Windows.Forms.Button
    Friend WithEvents cmbDestinatarios As System.Windows.Forms.ComboBox
    Friend WithEvents lstBoxDestinatarios As System.Windows.Forms.ListBox
    Friend WithEvents colEstado As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCopiarPortapapeles As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtBuscadorDescripcion As System.Windows.Forms.TextBox
End Class
