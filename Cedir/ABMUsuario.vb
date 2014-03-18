Imports CedirNegocios

Public Class ABMUsuario

    Dim sSecurity As Security
    Dim cUsuario As Usuario
    Private Sub cargarUsuarioActual()
        sSecurity = Security.GetInstance()
        cUsuario = sSecurity.getLoggedUser()
        Me.txtNombreUsuario.Text = cUsuario.nombreUsuario

    End Sub
    Private Sub cambiarDatosUsuario()
        If validarPass() Then
            cUsuario.password = Me.txtPass.Text
            cUsuario.nombreUsuario = Me.txtNombreUsuario.Text
            cUsuario.update()
            MessageBox.Show("Datos cambiados con éxito")
        Else
            MessageBox.Show("Por favor, valide los datos ingresados", "Error : ", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub
    Private Function validarPass() As Boolean
        If (Me.txtPass.Text = "") Then
            MessageBox.Show("El password no puede estar vacío", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If

        If (Me.txtPass.Text = Me.txtConfirmPass.Text) Then
            Dim cCatalogoDeUsuarios As New CatalogoDeUsuarios
            Dim usuarioAValidar As Usuario = cCatalogoDeUsuarios.getUsuario(Me.txtNombreUsuario.Text.ToLower(), Me.txtPass.Text.ToLower())

            If usuarioAValidar IsNot Nothing Then 'si el objeto usuario esta vacío, es porque el catalogo no hayó ninguna coincidencia
                MessageBox.Show("El usuario y la contraseña ya existen. Ingrese nuevamente los datos")
                Return False
            End If
            Return True
        Else
            MessageBox.Show("No coinciden las passwords")
            Return False
        End If
    End Function
    Private Sub cancelar()
        sSecurity = Nothing
        cUsuario = Nothing
        Me.Close()
    End Sub

    Private Sub AMB_Usuario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarUsuarioActual()
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

        Me.Close()

    End Sub
End Class