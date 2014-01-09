Imports CedirNegocios
Public Class ABMPracticas
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtEstudio As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbPracticas As System.Windows.Forms.ComboBox
    Friend WithEvents txtCodigoModificar As System.Windows.Forms.TextBox
    Friend WithEvents txtDescripcionModificar As System.Windows.Forms.TextBox
    Friend WithEvents txtAbreviatura As System.Windows.Forms.TextBox
    Friend WithEvents lblAbreviatura As System.Windows.Forms.Label
    Friend WithEvents lblAbreviaturaModificar As System.Windows.Forms.Label
    Friend WithEvents txtAbreviaturaModificar As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtCodigoMedicoOSDEUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCodMedicoOSDEInsert As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtEstudio = New System.Windows.Forms.TextBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCodMedicoOSDEInsert = New System.Windows.Forms.TextBox
        Me.txtAbreviatura = New System.Windows.Forms.TextBox
        Me.lblAbreviatura = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtCodigoMedicoOSDEUpdate = New System.Windows.Forms.TextBox
        Me.lblAbreviaturaModificar = New System.Windows.Forms.Label
        Me.txtAbreviaturaModificar = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnModificar = New System.Windows.Forms.Button
        Me.cmbPracticas = New System.Windows.Forms.ComboBox
        Me.txtCodigoModificar = New System.Windows.Forms.TextBox
        Me.txtDescripcionModificar = New System.Windows.Forms.TextBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEstudio
        '
        Me.txtEstudio.Location = New System.Drawing.Point(86, 13)
        Me.txtEstudio.Name = "txtEstudio"
        Me.txtEstudio.Size = New System.Drawing.Size(184, 20)
        Me.txtEstudio.TabIndex = 0
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(86, 77)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Descripción:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Codigo Médico:"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(86, 198)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(72, 24)
        Me.btnAceptar.TabIndex = 4
        Me.btnAceptar.Text = "Aceptar"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(16, 258)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(72, 24)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cerrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCodMedicoOSDEInsert)
        Me.GroupBox1.Controls.Add(Me.txtAbreviatura)
        Me.GroupBox1.Controls.Add(Me.lblAbreviatura)
        Me.GroupBox1.Controls.Add(Me.txtEstudio)
        Me.GroupBox1.Controls.Add(Me.txtCodigo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(16, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(280, 228)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 29)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Código Médico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OSDE              :"
        '
        'txtCodMedicoOSDEInsert
        '
        Me.txtCodMedicoOSDEInsert.Location = New System.Drawing.Point(86, 112)
        Me.txtCodMedicoOSDEInsert.Name = "txtCodMedicoOSDEInsert"
        Me.txtCodMedicoOSDEInsert.Size = New System.Drawing.Size(100, 20)
        Me.txtCodMedicoOSDEInsert.TabIndex = 10
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.Location = New System.Drawing.Point(86, 45)
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Size = New System.Drawing.Size(184, 20)
        Me.txtAbreviatura.TabIndex = 6
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.Location = New System.Drawing.Point(6, 48)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(83, 16)
        Me.lblAbreviatura.TabIndex = 5
        Me.lblAbreviatura.Text = "Abreviatura:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtCodigoMedicoOSDEUpdate)
        Me.GroupBox2.Controls.Add(Me.lblAbreviaturaModificar)
        Me.GroupBox2.Controls.Add(Me.txtAbreviaturaModificar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.cmbPracticas)
        Me.GroupBox2.Controls.Add(Me.txtCodigoModificar)
        Me.GroupBox2.Controls.Add(Me.txtDescripcionModificar)
        Me.GroupBox2.Location = New System.Drawing.Point(312, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 228)
        Me.GroupBox2.TabIndex = 8
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar existente"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(8, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 29)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Código Médico" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "OSDE              :"
        '
        'txtCodigoMedicoOSDEUpdate
        '
        Me.txtCodigoMedicoOSDEUpdate.Location = New System.Drawing.Point(97, 156)
        Me.txtCodigoMedicoOSDEUpdate.Name = "txtCodigoMedicoOSDEUpdate"
        Me.txtCodigoMedicoOSDEUpdate.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoMedicoOSDEUpdate.TabIndex = 8
        '
        'lblAbreviaturaModificar
        '
        Me.lblAbreviaturaModificar.Location = New System.Drawing.Point(8, 80)
        Me.lblAbreviaturaModificar.Name = "lblAbreviaturaModificar"
        Me.lblAbreviaturaModificar.Size = New System.Drawing.Size(67, 16)
        Me.lblAbreviaturaModificar.TabIndex = 7
        Me.lblAbreviaturaModificar.Text = "Abreviatura:"
        '
        'txtAbreviaturaModificar
        '
        Me.txtAbreviaturaModificar.Location = New System.Drawing.Point(97, 76)
        Me.txtAbreviaturaModificar.Name = "txtAbreviaturaModificar"
        Me.txtAbreviaturaModificar.Size = New System.Drawing.Size(296, 20)
        Me.txtAbreviaturaModificar.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Código Médico:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 16)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Descripción:"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(97, 199)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 3
        Me.btnModificar.Text = "Modificar"
        '
        'cmbPracticas
        '
        Me.cmbPracticas.Location = New System.Drawing.Point(24, 24)
        Me.cmbPracticas.Name = "cmbPracticas"
        Me.cmbPracticas.Size = New System.Drawing.Size(376, 21)
        Me.cmbPracticas.TabIndex = 2
        Me.cmbPracticas.Text = "Seleccione una práctica para modificar.."
        '
        'txtCodigoModificar
        '
        Me.txtCodigoModificar.Location = New System.Drawing.Point(96, 112)
        Me.txtCodigoModificar.Name = "txtCodigoModificar"
        Me.txtCodigoModificar.Size = New System.Drawing.Size(100, 20)
        Me.txtCodigoModificar.TabIndex = 1
        '
        'txtDescripcionModificar
        '
        Me.txtDescripcionModificar.Location = New System.Drawing.Point(97, 48)
        Me.txtDescripcionModificar.Name = "txtDescripcionModificar"
        Me.txtDescripcionModificar.Size = New System.Drawing.Size(296, 20)
        Me.txtDescripcionModificar.TabIndex = 0
        '
        'ABMPracticas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 304)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button3)
        Me.Name = "ABMPracticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear o Modificar Prácticas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim catalogoDePracticas As New catalogoDePracticas
    Dim arrPracticas As ArrayList
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ABMPracticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        habilitarCargarNuevaPractica()
        cargarCombo()
    End Sub

    Private Sub cargarCombo()
        cmbPracticas.Items.Clear()
        arrPracticas = catalogoDePracticas.getPracticas
        Dim cPractica As Practica
        For i As Integer = 0 To arrPracticas.Count - 1
            cPractica = arrPracticas(i)
            cmbPracticas.Items.Add(cPractica.Estudio)
        Next
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim success As Boolean = validateData(False)
        If success Then
            Dim resp As String
            Dim cPractica As New Practica
            cPractica.Estudio = txtEstudio.Text
            cPractica.codigoMedico = txtCodigo.Text
            cPractica.abreviatura = Me.txtAbreviatura.Text
            cPractica.codigoMedicoOSDE = Me.txtCodMedicoOSDEInsert.Text
            resp = cPractica.crear()
            If resp = "ok" Then
                MsgBox("La práctica se ha agregado con éxito")
                txtEstudio.Text = ""
                txtCodigo.Text = ""
                Me.txtAbreviatura.Text = ""
                cargarCombo()
            Else : MsgBox("Error: " & resp)
            End If
        End If
    End Sub


    Private Sub cmbPracticas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPracticas.SelectedIndexChanged
        Dim cPractica As Practica = arrPracticas(cmbPracticas.SelectedIndex)
        txtDescripcionModificar.Text = cPractica.Estudio
        txtCodigoModificar.Text = cPractica.codigoMedico
        Me.txtAbreviaturaModificar.Text = cPractica.abreviatura
        Me.txtCodigoMedicoOSDEUpdate.Text = cPractica.codigoMedicoOSDE

    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim cPractica As Practica = arrPracticas(cmbPracticas.SelectedIndex)
        Dim success As Boolean = validateData(True)
        If success Then
            Dim resp As String
            cPractica.Estudio = txtDescripcionModificar.Text
            cPractica.codigoMedico = txtCodigoModificar.Text
            cPractica.abreviatura = Me.txtAbreviaturaModificar.Text
            cPractica.codigoMedicoOSDE = Me.txtCodigoMedicoOSDEUpdate.Text
            resp = cPractica.actualizar()
            If resp = "ok" Then
                MsgBox("La práctica se ha modificado con éxito")
                cmbPracticas.Items(cmbPracticas.SelectedIndex) = txtDescripcionModificar.Text
            Else : MsgBox("Error: " & resp)
            End If
        End If

    End Sub

    Private Function validateData(ByVal esActualizar As Boolean) As Boolean
        If esActualizar Then
            If txtCodigoModificar.Text = "" Then
                MsgBox("Código Médico no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
        Else
            If txtEstudio.Text = "" Then
                MsgBox("Descripción no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
        End If

        Return True
    End Function
    Private Sub habilitarCargarNuevaPractica()
        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser
        If IsNothing(cUsuario) = False Then
            If (cUsuario.belongToGroup("administrador") Or cUsuario.belongToGroup("facturacion")) Then
                Me.GroupBox1.Enabled = True
            Else
                Me.GroupBox1.Enabled = False
            End If
        End If



    End Sub
End Class
