Imports CedirNegocios

Public Class ABMUsuario

    Dim sSecurity As Security
    Dim cUsuario As Usuario
    Dim cMdiForm As New Main
    Private Sub cargarUsuarioActual()
        sSecurity = Security.GetInstance()
        cUsuario = sSecurity.getLoggedUser()
        Me.txtNombreUsuario.Text = cUsuario.nombreUsuario

    End Sub
    Private Sub cambiarDatosUsuario()
        If validarDatosIngresados() Then
            cUsuario.password = Me.txtPass.Text
            cUsuario.nombreUsuario = Me.txtNombreUsuario.Text
            cUsuario.update()
            MessageBox.Show("Los datos fueron cambiados con éxito")
        End If
    End Sub
    Private Function validarDatosIngresados() As Boolean
        If (Me.txtPass.Text = "") Then
            MessageBox.Show("El password no puede estar vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (Me.txtPass.Text <> Me.txtConfirmPass.Text) Then
            MessageBox.Show("No coinciden las passwords")
            Return False
        End If


        Dim cCatalogoDeUsuarios As New CatalogoDeUsuarios
        cCatalogoDeUsuarios.usuarioActual = cUsuario

        If (Me.txtNombreUsuario.Text <> Me.cUsuario.nombreUsuario) Then 'el usuario intenta cambiar su nombre
            If cCatalogoDeUsuarios.nameExists(Me.txtNombreUsuario.Text) Then
                MessageBox.Show("El nombre ya fue elegido. Por favor, seleccione otro nombre")
                Return False
            End If
        End If

        Return True

    End Function
    Private Sub cancelar()
        sSecurity = Nothing
        cUsuario = Nothing
        Me.Close()
    End Sub

    Private Sub AMB_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarUsuarioActual()
        cMdiForm = Me.MdiParent
    End Sub

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click
        Me.cancelar()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim db As New DialogResult
        db = MessageBox.Show("Esta seguro de cambiar sus datos?", "Atención", MessageBoxButtons.YesNo)
        If db = Windows.Forms.DialogResult.Yes Then
            cambiarDatosUsuario()
        End If

        Me.cMdiForm.Text = " CEDIR - USUARIO:  " & Me.cUsuario.nombreUsuario
        Me.cUsuario = Nothing
        Me.Close()

    End Sub
End Class