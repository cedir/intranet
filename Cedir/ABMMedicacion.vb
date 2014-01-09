Imports CedirNegocios
Public Class ABMMedicacion
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Friend WithEvents txtImporte As System.Windows.Forms.TextBox
    Friend WithEvents cmbMedicamentos As System.Windows.Forms.ComboBox
    Friend WithEvents txtImporteModificar As System.Windows.Forms.TextBox
    Friend WithEvents rbtnMaterialEspecifico As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMedicacion As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMaterialEspecificoModificar As System.Windows.Forms.RadioButton
    Friend WithEvents rbtnMedicacionModificar As System.Windows.Forms.RadioButton
    Friend WithEvents txtCodMedOSDEUPdate As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodMedOSDEInsert As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescripcionModificar As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbtnMaterialEspecifico = New System.Windows.Forms.RadioButton
        Me.rbtnMedicacion = New System.Windows.Forms.RadioButton
        Me.txtDescripcion = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtImporte = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbtnMaterialEspecificoModificar = New System.Windows.Forms.RadioButton
        Me.btnModificar = New System.Windows.Forms.Button
        Me.rbtnMedicacionModificar = New System.Windows.Forms.RadioButton
        Me.txtImporteModificar = New System.Windows.Forms.TextBox
        Me.txtDescripcionModificar = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbMedicamentos = New System.Windows.Forms.ComboBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.txtCodMedOSDEUPdate = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodMedOSDEInsert = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCodMedOSDEInsert)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.rbtnMaterialEspecifico)
        Me.GroupBox1.Controls.Add(Me.rbtnMedicacion)
        Me.GroupBox1.Controls.Add(Me.txtDescripcion)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtImporte)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 261)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Crear Nueva"
        '
        'rbtnMaterialEspecifico
        '
        Me.rbtnMaterialEspecifico.AutoSize = True
        Me.rbtnMaterialEspecifico.Location = New System.Drawing.Point(96, 130)
        Me.rbtnMaterialEspecifico.Name = "rbtnMaterialEspecifico"
        Me.rbtnMaterialEspecifico.Size = New System.Drawing.Size(114, 17)
        Me.rbtnMaterialEspecifico.TabIndex = 6
        Me.rbtnMaterialEspecifico.Text = "Material Especifico"
        Me.rbtnMaterialEspecifico.UseVisualStyleBackColor = True
        '
        'rbtnMedicacion
        '
        Me.rbtnMedicacion.AutoSize = True
        Me.rbtnMedicacion.Checked = True
        Me.rbtnMedicacion.Location = New System.Drawing.Point(96, 107)
        Me.rbtnMedicacion.Name = "rbtnMedicacion"
        Me.rbtnMedicacion.Size = New System.Drawing.Size(80, 17)
        Me.rbtnMedicacion.TabIndex = 5
        Me.rbtnMedicacion.TabStop = True
        Me.rbtnMedicacion.Text = "Medicación"
        Me.rbtnMedicacion.UseVisualStyleBackColor = True
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(96, 22)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 20)
        Me.txtDescripcion.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(101, 216)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 45)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Importe: $"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción:"
        '
        'txtImporte
        '
        Me.txtImporte.Location = New System.Drawing.Point(96, 45)
        Me.txtImporte.Name = "txtImporte"
        Me.txtImporte.Size = New System.Drawing.Size(114, 20)
        Me.txtImporte.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCodMedOSDEUPdate)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.rbtnMaterialEspecificoModificar)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.rbtnMedicacionModificar)
        Me.GroupBox2.Controls.Add(Me.txtImporteModificar)
        Me.GroupBox2.Controls.Add(Me.txtDescripcionModificar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbMedicamentos)
        Me.GroupBox2.Location = New System.Drawing.Point(336, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(336, 259)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar Existente"
        '
        'rbtnMaterialEspecificoModificar
        '
        Me.rbtnMaterialEspecificoModificar.AutoSize = True
        Me.rbtnMaterialEspecificoModificar.Location = New System.Drawing.Point(88, 183)
        Me.rbtnMaterialEspecificoModificar.Name = "rbtnMaterialEspecificoModificar"
        Me.rbtnMaterialEspecificoModificar.Size = New System.Drawing.Size(114, 17)
        Me.rbtnMaterialEspecificoModificar.TabIndex = 8
        Me.rbtnMaterialEspecificoModificar.Text = "Material Especifico"
        Me.rbtnMaterialEspecificoModificar.UseVisualStyleBackColor = True
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(111, 216)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 8
        Me.btnModificar.Text = "Modificar"
        '
        'rbtnMedicacionModificar
        '
        Me.rbtnMedicacionModificar.AutoSize = True
        Me.rbtnMedicacionModificar.Checked = True
        Me.rbtnMedicacionModificar.Location = New System.Drawing.Point(88, 160)
        Me.rbtnMedicacionModificar.Name = "rbtnMedicacionModificar"
        Me.rbtnMedicacionModificar.Size = New System.Drawing.Size(80, 17)
        Me.rbtnMedicacionModificar.TabIndex = 7
        Me.rbtnMedicacionModificar.TabStop = True
        Me.rbtnMedicacionModificar.Text = "Medicación"
        Me.rbtnMedicacionModificar.UseVisualStyleBackColor = True
        '
        'txtImporteModificar
        '
        Me.txtImporteModificar.Location = New System.Drawing.Point(165, 104)
        Me.txtImporteModificar.Name = "txtImporteModificar"
        Me.txtImporteModificar.Size = New System.Drawing.Size(67, 20)
        Me.txtImporteModificar.TabIndex = 7
        '
        'txtDescripcionModificar
        '
        Me.txtDescripcionModificar.Location = New System.Drawing.Point(88, 64)
        Me.txtDescripcionModificar.Name = "txtDescripcionModificar"
        Me.txtDescripcionModificar.Size = New System.Drawing.Size(224, 20)
        Me.txtDescripcionModificar.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Importe: $"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(16, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Descripción:"
        '
        'cmbMedicamentos
        '
        Me.cmbMedicamentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicamentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicamentos.Location = New System.Drawing.Point(24, 24)
        Me.cmbMedicamentos.Name = "cmbMedicamentos"
        Me.cmbMedicamentos.Size = New System.Drawing.Size(288, 21)
        Me.cmbMedicamentos.TabIndex = 0
        Me.cmbMedicamentos.Text = "Seleccione un medicamento para modificar.."
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(16, 295)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'txtCodMedOSDEUPdate
        '
        Me.txtCodMedOSDEUPdate.Enabled = False
        Me.txtCodMedOSDEUPdate.Location = New System.Drawing.Point(165, 134)
        Me.txtCodMedOSDEUPdate.Name = "txtCodMedOSDEUPdate"
        Me.txtCodMedOSDEUPdate.Size = New System.Drawing.Size(67, 20)
        Me.txtCodMedOSDEUPdate.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 15)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Código Médico OSDE"
        '
        'txtCodMedOSDEInsert
        '
        Me.txtCodMedOSDEInsert.Enabled = False
        Me.txtCodMedOSDEInsert.Location = New System.Drawing.Point(142, 71)
        Me.txtCodMedOSDEInsert.Name = "txtCodMedOSDEInsert"
        Me.txtCodMedOSDEInsert.Size = New System.Drawing.Size(67, 20)
        Me.txtCodMedOSDEInsert.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 72)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(112, 15)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Código Médico OSDE"
        '
        'ABMMedicacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(688, 330)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ABMMedicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear - Modificar Medicación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrMedicamentos As New ArrayList
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim success As Boolean = validateData(False)
        If success Then
            Dim resp As String
            Dim med As New Medicamento
            med.descripcion = txtDescripcion.Text
            med.importe = CSng(txtImporte.Text)
            med.codigoMedicoOSDE = Me.txtCodMedOSDEInsert.Text
            Select Case True
                Case Me.rbtnMaterialEspecifico.Checked
                    med.tipo = "Mat Esp"
                Case Me.rbtnMedicacion.Checked
                    med.tipo = "Medicación"
            End Select

            resp = med.crear()
            If resp = "ok" Then
                MsgBox("El medicamento se ha agregado con éxito")
                txtDescripcion.Text = ""
                txtImporte.Text = ""
                Me.txtCodMedOSDEInsert.Text = ""
                Me.rbtnMedicacion.Checked = True

                cargarCombo()
            Else
                MsgBox("Error: " & resp)
            End If
        End If

    End Sub

    Private Sub ABMMedicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCombo()
    End Sub
    Private Sub cargarCombo()
        cmbMedicamentos.Items.Clear()
        Dim catalogoMedicamentos As New CatalogoDeMedicamentos
        arrMedicamentos = catalogoMedicamentos.traerMedicamentos()
        Dim i As Integer
        Dim med As Medicamento
        For i = 0 To arrMedicamentos.Count - 1
            med = arrMedicamentos(i)
            cmbMedicamentos.Items.Add(med.descripcion)
        Next

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim success As Boolean = validateData(True)
        If success Then
            Dim resp As String
            Dim med As Medicamento
            med = arrMedicamentos(cmbMedicamentos.SelectedIndex)
            med.descripcion = txtDescripcionModificar.Text
            med.importe = CSng(txtImporteModificar.Text)
            med.codigoMedicoOSDE = Me.txtCodMedOSDEUPdate.Text
            Select Case True
                Case Me.rbtnMedicacionModificar.Checked
                    med.tipo = "Medicación"
                Case Me.rbtnMaterialEspecificoModificar.Checked
                    med.tipo = "Mat Esp"
            End Select

            resp = med.actualizar()
            If resp = "ok" Then
                MsgBox("El medicamento se ha modificado con éxito")
                cmbMedicamentos.Items(cmbMedicamentos.SelectedIndex) = txtDescripcionModificar.Text
            Else
                MsgBox("Error: " & resp)
            End If
        End If
    End Sub
    Private Function validateData(ByVal esActualizar As Boolean) As Boolean
        If esActualizar Then
            If txtDescripcionModificar.Text = "" Then
                MsgBox("Descripción no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
            If txtImporteModificar.Text = "" Then
                MsgBox("Importe no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
        Else
            If txtDescripcion.Text = "" Then
                MsgBox("Descripción no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
            If txtImporte.Text = "" Then
                MsgBox("Importe no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub cmbMedicamentos_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMedicamentos.SelectedIndexChanged
        Dim cMedicamento As Medicamento = arrMedicamentos(cmbMedicamentos.SelectedIndex)
        txtDescripcionModificar.Text = cMedicamento.descripcion
        txtImporteModificar.Text = cMedicamento.importe
        txtCodMedOSDEUPdate.Text = cMedicamento.codigoMedicoOSDE
        Select Case True
            Case cMedicamento.tipo = "Medicación"
                Me.rbtnMedicacionModificar.Checked = True
                Me.rbtnMaterialEspecificoModificar.Checked = False
                Me.txtCodMedOSDEUPdate.Enabled = False
                Me.txtCodMedOSDEUPdate.Text = ""
            Case cMedicamento.tipo = "Mat Esp"
                Me.rbtnMaterialEspecificoModificar.Checked = True
                Me.rbtnMedicacionModificar.Checked = False
                Me.txtCodMedOSDEUPdate.Enabled = True
        End Select
    End Sub

    Private Sub rbtnMaterialEspecificoModificar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnMaterialEspecificoModificar.CheckedChanged

    End Sub

    Private Sub rbtnMaterialEspecifico_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnMaterialEspecifico.CheckedChanged
        Me.txtCodMedOSDEInsert.Enabled = True
    End Sub

    Private Sub rbtnMedicacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbtnMedicacion.CheckedChanged
        Me.txtCodMedOSDEInsert.Enabled = False
    End Sub
End Class
