Imports CedirNegocios
Public Class LogIn
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
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtUsuario As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtUsuario = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(96, 64)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(120, 20)
        Me.txtPassword.TabIndex = 1
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(112, 112)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(96, 32)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(120, 20)
        Me.txtUsuario.TabIndex = 0
        '
        'LogIn
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(296, 168)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LogIn"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LogIn"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Dim cCatalogoDeUsuarios As New CatalogoDeUsuarios
    Private Sub LogIn_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load




    End Sub
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim cUsuario As Usuario = cCatalogoDeUsuarios.getUsuario(txtUsuario.Text.ToLower(), txtPassword.Text.ToLower())
        If cUsuario Is Nothing Then
            MsgBox("Usuario o password incorrecto, intentelo nuevamente", MsgBoxStyle.Critical)
        Else

            habilitarAcciones(cUsuario)
            Dim cMdiForm As Main = Me.MdiParent
            cMdiForm.itemUsuariosLogIn.Enabled = False
            cMdiForm.itemUsuariosLogOut.Enabled = True
            cMdiForm.Text = "Cedir - Usuario actual :      " & cUsuario.nombreUsuario.ToUpper()
            cMdiForm.mnuMensajeria.Enabled = True


            Dim sSecurity As Security = Security.GetInstance()
            sSecurity.setLoggedUser(cUsuario)
            cMdiForm.mostrarMensajesNoLeidos()
            cMdiForm.timerMensajeria.Start()
            Me.Close()
        End If

    End Sub
    Private Sub habilitarAcciones(ByVal cUsuario As Usuario)
        Dim arrGrupos As ArrayList = cUsuario.getGrupos()
        Dim cGrupo As Grupo
        For i As Integer = 0 To arrGrupos.Count - 1
            cGrupo = arrGrupos(i)
            If cGrupo.nombre = "administrador" Then
                _habilitarAdministradores()
            ElseIf cGrupo.nombre = "facturacion" Then
                _habilitarFacturacion()
            ElseIf cGrupo.nombre = "recepcion" Then
                _habilitarRecepcion()
            ElseIf cGrupo.nombre = "medico" Then
                _habilitarMedico()
            ElseIf cGrupo.nombre = "tecnicos" Then
                _habilitarTecnicos()
            End If
        Next
    End Sub
    Private Sub _habilitarAdministradores()
        _habilitarTecnicos()
        _habilitarFacturacion()
        _habilitarMedico()
    End Sub
    Private Sub _habilitarFacturacion()

        _habilitarRecepcion()

        Dim cMdiForm As Main = Me.MdiParent
        cMdiForm.itemMedicosNuevoPago.Enabled = True
        cMdiForm.itemMedicosMiCuenta.Enabled = True

        cMdiForm.itemFacturacion.Enabled = True
        cMdiForm.itemPracticas.Enabled = True
        cMdiForm.itemMedicacion.Enabled = True
        cMdiForm.itemObraSocialesNueva.Enabled = True

        cMdiForm.mnuItemListadoAnestesista.Enabled = True
        cMdiForm.mnuComplejidades.Enabled = True
        cMdiForm.mnuReemplazarPaciente.Enabled = True
        cMdiForm.mnuReportes.Enabled = True
    End Sub
    Private Sub _habilitarRecepcion()
        Dim cMdiForm As Main = Me.MdiParent
        cMdiForm.mnuCaja.Enabled = True
        cMdiForm.itemComprobantes.Enabled = True
        cMdiForm.itemEstudiosBuscar.Enabled = True
        cMdiForm.itemEstudiosBuscarAvanzado.Enabled = True
        cMdiForm.itemEstudiosCrearRapido.Enabled = True
        cMdiForm.itemMedicos.Enabled = True
        cMdiForm.itemPacientes.Enabled = True
        cMdiForm.itemObraSociales.Enabled = True
        cMdiForm.itemObraSocialesBuscar.Enabled = True
        cMdiForm.itemObraSocialesNueva.Enabled = False
        cMdiForm.itemPacientesBuscar.Enabled = True
        cMdiForm.itemPacientesNuevo.Enabled = True
        cMdiForm.ToolBar1.Visible = True

        cMdiForm.itemPracticas.Enabled = True
        cMdiForm.mnuReemplazarPaciente.Enabled = False
        _habilitarMedico()
    End Sub
    Private Sub _habilitarMedico()
        Dim cMdiForm As Main = Me.MdiParent
        cMdiForm.itemMedicosMiCuenta.Enabled = True
        cMdiForm.itemEstudiosBuscar.Enabled = True
        cMdiForm.itemMedicosMiCuenta.Enabled = True
    End Sub
    Private Sub _habilitarTecnicos()
        'por ahora, les damos los mismos permisos que a los medicos
        Dim cMdiForm As Main = Me.MdiParent
        _habilitarMedico()
        cMdiForm.itemMedicacion.Enabled = True
        cMdiForm.mnuMedicacion.Enabled = True
    End Sub
    Private Sub txtPassword_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPassword.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub
    Private Sub txtUsuario_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnAceptar.PerformClick()
        End If
    End Sub
End Class
