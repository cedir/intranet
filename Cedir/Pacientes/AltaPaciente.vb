Imports CedirNegocios

Public Class AltaPaciente
    Inherits System.Windows.Forms.Form
    Dim _currentPaciente As New Paciente
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents txtFechaNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents lblEdad As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtMail As System.Windows.Forms.TextBox
    Friend WithEvents lblErrorMail As System.Windows.Forms.Label
    Dim _altaPaciente As Boolean = True
    Dim h As New Helper
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
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents LblDni As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtnumAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.LblDni = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbSexo = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtnumAfiliado = New System.Windows.Forms.TextBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblErrorMail = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtMail = New System.Windows.Forms.TextBox
        Me.lblEdad = New System.Windows.Forms.Label
        Me.txtFechaNacimiento = New System.Windows.Forms.MaskedTextBox
        Me.lblID = New System.Windows.Forms.Label
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(115, 46)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(115, 83)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(115, 120)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(160, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(115, 180)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(280, 20)
        Me.txtDir.TabIndex = 4
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(115, 225)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(160, 20)
        Me.txtTel.TabIndex = 5
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(128, 440)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(64, 24)
        Me.btnAceptar.TabIndex = 8
        Me.btnAceptar.Text = "Aceptar"
        '
        'LblDni
        '
        Me.LblDni.Location = New System.Drawing.Point(65, 49)
        Me.LblDni.Name = "LblDni"
        Me.LblDni.Size = New System.Drawing.Size(24, 23)
        Me.LblDni.TabIndex = 8
        Me.LblDni.Text = "Dni:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(49, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombres:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(56, 123)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Fecha Nacimiento :"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(49, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Dirección:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(49, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(56, 280)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Sexo:"
        '
        'cmbSexo
        '
        Me.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSexo.Location = New System.Drawing.Point(115, 277)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(136, 21)
        Me.cmbSexo.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(38, 307)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(72, 23)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Nº afiliado:"
        '
        'txtnumAfiliado
        '
        Me.txtnumAfiliado.Location = New System.Drawing.Point(115, 304)
        Me.txtnumAfiliado.Name = "txtnumAfiliado"
        Me.txtnumAfiliado.Size = New System.Drawing.Size(100, 20)
        Me.txtnumAfiliado.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(236, 440)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Cerrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblErrorMail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtMail)
        Me.GroupBox1.Controls.Add(Me.lblEdad)
        Me.GroupBox1.Controls.Add(Me.txtFechaNacimiento)
        Me.GroupBox1.Controls.Add(Me.lblID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.LblDni)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbSexo)
        Me.GroupBox1.Controls.Add(Me.txtDir)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtnumAfiliado)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(412, 418)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del Paciente"
        '
        'lblErrorMail
        '
        Me.lblErrorMail.AutoSize = True
        Me.lblErrorMail.ForeColor = System.Drawing.Color.Red
        Me.lblErrorMail.Location = New System.Drawing.Point(281, 251)
        Me.lblErrorMail.Name = "lblErrorMail"
        Me.lblErrorMail.Size = New System.Drawing.Size(82, 13)
        Me.lblErrorMail.TabIndex = 23
        Me.lblErrorMail.Text = "* mail incorrecto"
        Me.lblErrorMail.Visible = False
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(58, 251)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 23)
        Me.Label8.TabIndex = 22
        Me.Label8.Text = "E-Mail :"
        '
        'txtMail
        '
        Me.txtMail.Location = New System.Drawing.Point(115, 251)
        Me.txtMail.Name = "txtMail"
        Me.txtMail.Size = New System.Drawing.Size(160, 20)
        Me.txtMail.TabIndex = 21
        '
        'lblEdad
        '
        Me.lblEdad.Location = New System.Drawing.Point(221, 151)
        Me.lblEdad.Name = "lblEdad"
        Me.lblEdad.Size = New System.Drawing.Size(175, 26)
        Me.lblEdad.TabIndex = 20
        Me.lblEdad.Text = "edad"
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(115, 151)
        Me.txtFechaNacimiento.Mask = "00/00/0000"
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaNacimiento.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtFechaNacimiento, "dd/mm/aaaa")
        Me.txtFechaNacimiento.ValidatingType = GetType(Date)
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(49, 19)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(0, 13)
        Me.lblID.TabIndex = 18
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 150
        Me.ToolTip1.IsBalloon = True
        '
        'AltaPaciente
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(437, 476)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "AltaPaciente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AltaPaciente"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property esAltaPaciente() As Boolean
        Get
            Return _altaPaciente
        End Get
        Set(ByVal value As Boolean)
            _altaPaciente = value
        End Set
    End Property

    Public Property currentPaciente() As Paciente
        Get
            Return _currentPaciente
        End Get
        Set(ByVal value As Paciente)
            _currentPaciente = value
        End Set
    End Property
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim catalogoPacientes As New CatalogoDePacientes
        Dim resp As String
        Dim r As Integer
        Dim cEdad As Integer = 0
        Dim arrPacientes As ArrayList

        currentPaciente.nombres = txtNombre.Text
        currentPaciente.apellido = txtApellido.Text
        If txtFechaNacimiento.MaskCompleted Then
            currentPaciente.fechaDeNacimiento = CDate(txtFechaNacimiento.Text)
        Else
            currentPaciente.fechaDeNacimiento = Nothing
        End If
        currentPaciente.direccion = txtDir.Text
        currentPaciente.tel = txtTel.Text
        currentPaciente.sexo = cmbSexo.Text
        currentPaciente.nroAfiliado = txtnumAfiliado.Text

        If txtDni.Text = "" Or txtDni.Text = "0" Then
            currentPaciente.dni = 0
        Else
            currentPaciente.dni = CInt(txtDni.Text)
        End If
        If txtApellido.Text = "" Then
            MsgBox("El campo apellido no pueden estar vacio")
            Exit Sub
        End If
        currentPaciente.e_mail = txtMail.Text

        If esAltaPaciente Then
            arrPacientes = catalogoPacientes.TodosLosPacientes(currentPaciente.dni, , )

            If arrPacientes.Count > 0 Then
                MsgBox("Ha ocurrido un error al intentar crear el paciente. Puede que el paciente ya exista en la base de datos" & vbCrLf & "(Intente buscarlo por nombre)")
                Exit Sub
            End If

            resp = currentPaciente.AltaPaciente()
            If resp = "ok" Then

                r = MsgBox("El Paciente se ha agregado con exito, ¿ Desea crear un estudio para es paciente ? ", MsgBoxStyle.YesNo, "¿ Crear Estudio ?")

                If r = 6 Then
                    Dim est As New Estudio
                    est.nroEstudio = 0
                    est.paciente = currentPaciente
                    est.practica.Estudio = ""
                    est.motivoEstudio = ""
                    est.informe = ""
                    est.medicoActuante.idMedico = 0
                    est.medicoSolicitante.idMedico = 0
                    est.obraSocial.idObraSocial = 0

                    Dim frm As New NuevoEstudio(est)
                    frm.MdiParent = Me.Parent.Parent
                    frm.Show()

                    Me.Close()
                Else
                    Me.Close()

                End If

            End If
        Else

            'actaulizar paciente
            resp = currentPaciente.actualizaPaciente()
            If resp = "ok" Then
                MsgBox("Los datos del paciente se han modificado con éxito")
            Else
                MsgBox("Ha ocurrido un error al intentar modificar los datos del paciente. Descripción del error" & resp)
            End If


        End If

    End Sub
    Private Sub AltaPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbSexo.Items.Add("Masculino")
        cmbSexo.Items.Add("Femenino")
        cmbSexo.SelectedItem = "Masculino"
        Me.lblEdad.Text = ""
        If esAltaPaciente Then
            'viene de nuevo paciente
            Me.Text = "Nuevo paciente"
        Else
            ' viene de modificar paciente
            Me.Text = "Ver o Modificar datos del paciente " & currentPaciente.apellido
            lblID.Text = "ID : " & currentPaciente.Id.ToString()
            txtDni.Text = currentPaciente.dni
            txtApellido.Text = currentPaciente.apellido
            txtDir.Text = currentPaciente.direccion
            If currentPaciente.fechaDeNacimiento <> Nothing Then
                txtFechaNacimiento.Text = currentPaciente.fechaDeNacimiento
            End If
            Me.txtMail.Text = currentPaciente.e_mail
            setLabelEdad()
            txtNombre.Text = currentPaciente.nombres
            txtTel.Text = currentPaciente.tel
            txtnumAfiliado.Text = currentPaciente.nroAfiliado
            cmbSexo.SelectedItem = currentPaciente.sexo
        End If

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub txtFechaNacimiento_TypeValidationCompleted(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TypeValidationEventArgs) Handles txtFechaNacimiento.TypeValidationCompleted
        If (Not e.IsValidInput) Then
            Me.ToolTip1.ToolTipTitle = "Feha invalida"
            Me.ToolTip1.Show("Fecha de la forma dd/mm/aaaa", Me.txtFechaNacimiento, 0, 20, 5000)
        Else
            ' Now that the type has passed basic type validation, enforce more specific type rules.
            Dim UserDate As DateTime = CDate(e.ReturnValue)
            If (UserDate >= DateTime.Now) Then
                Me.ToolTip1.ToolTipTitle = "Feha invalida"
                Me.ToolTip1.Show("La fecha debe ser menor que la del día de hoy", Me.txtFechaNacimiento, 0, -20, 5000)
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtFechaNacimiento_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFechaNacimiento.KeyDown
        Me.ToolTip1.Hide(Me.txtFechaNacimiento)
    End Sub

    Private Sub setEdadPacienteEnEdicion()
        If txtFechaNacimiento.MaskCompleted Then
            currentPaciente.fechaDeNacimiento = CDate(txtFechaNacimiento.Text)
        Else
            currentPaciente.fechaDeNacimiento = Nothing
        End If
    End Sub
    Private Sub txtFechaNacimiento_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFechaNacimiento.Leave
        setEdadPacienteEnEdicion()
        setLabelEdad()
    End Sub
    Private Sub setLabelEdad()
        If txtFechaNacimiento.MaskCompleted Then

            Me.lblEdad.Text = " Edad...: " & currentPaciente.edad.ToString()
        Else
            Me.lblEdad.Text = ".. Sin completar .."
        End If
    End Sub

    Private Sub txtMail_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMail.Leave
        If Not h.validarDireccionMail(txtMail.Text) Then
            Me.lblErrorMail.Visible = True
        Else
            Me.lblErrorMail.Visible = False
        End If
    End Sub
End Class
