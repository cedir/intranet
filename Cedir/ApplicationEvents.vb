Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.
    Partial Friend Class MyApplication


        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If Not e.IsNetworkAvailable Then
                MessageBox.Show("Ha ocurrido un error de conexión de red. Por favor, corrobore su conexión de red ." & vbCrLf & _
                "Se cerrará la aplicación", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error)
                My.Application.MainForm.Close()
            End If
        End Sub


        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs _
        ) Handles Me.UnhandledException
            MessageBox.Show("Ha ocurrido un error en la aplicación. Por favor, comuniquese con el administrador de Cedir 2.0 ." & vbCrLf & _
                "Se cerrará la aplicación", "Error de aplicación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Application.MainForm.Close()

            'walter : aca podemos tener el error y mandarlo a log de base de datos, mas los datos de hora, fecha, 
            'y demas 
            'e.Exception.Message 
            'My.Computer.Clock.LocalTime


        End Sub


    End Class

End Namespace

