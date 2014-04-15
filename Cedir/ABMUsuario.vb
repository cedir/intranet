Imports CedirNegocios
Public Class ABMUsuario
    Dim sSecurity As Security
    Dim usuarioLogged As Usuario
    Dim cMdiForm As New Main
    Private Sub cargarUsuarioActual()

        sSecurity = Security.GetInstance()
        usuarioLogged = sSecurity.getLoggedUser()
        Me.txtNombreUsuario.Text = usuarioLogged.nombreUsuario

    End Sub
    Private Sub cambiarDatosUsuario()
        If Me.validarDatosIngresados() Then
            usuarioLogged.password = Me.txtPass.Text.ToLower().Trim()
            usuarioLogged.nombreUsuario = Me.txtNombreUsuario.Text.ToLower().Trim()
            usuarioLogged.update()
            MessageBox.Show("Datos cambiados con éxito")

        Else
            MessageBox.Show("Por favor, valide los datos ingresados", "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Function validarDatosIngresados() As Boolean
        If (Me.txtPass.Text = "") Then
            MessageBox.Show("El password no puede estar vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (Me.txtPass.Text.ToLower() <> Me.txtConfirmPass.Text.ToLower()) Then
            MessageBox.Show("No coinciden las passwords")
            Return False
        End If
        Dim cCatalogoDeUsuarios As New CatalogoDeUsuarios

        If (Me.txtNombreUsuario.Text.ToLower() <> usuarioLogged.nombreUsuario.ToLower()) Then
            'el usuario intenta cambiar su nombre.
            'tenemos que averiguar si existe algun usuario utilizando ese nombre 
            If cCatalogoDeUsuarios.nameExists(Me.usuarioLogged, Me.txtNombreUsuario.Text) Then
                MessageBox.Show("El nombre de usuario ya ha sido elejido", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        End If
        Return True
    End Function
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.cambiarDatosUsuario()
        Me.MdiParent.Text = "Usuario actual : " & usuarioLogged.nombreUsuario

        Cerrar()
    End Sub

    Private Sub Cerrar()
        sSecurity = Nothing
        usuarioLogged = Nothing
        Me.Close()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Cerrar()
    End Sub
    Private Sub ABMUsuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarUsuarioActual()
    End Sub


End Class