Namespace My

    ' Los siguientes eventos est�n disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicaci�n, antes de que se cree el formulario de inicio.
    ' Apagado: generado despu�s de cerrar todos los formularios de la aplicaci�n. Este evento no se genera si la aplicaci�n termina de forma an�mala.
    ' UnhandledException: generado si la aplicaci�n detecta una excepci�n no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicaci�n de instancia �nica y la aplicaci�n ya est� activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexi�n de red est� conectada o desconectada.
    Partial Friend Class MyApplication


        Private Sub MyApplication_NetworkAvailabilityChanged(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs) Handles Me.NetworkAvailabilityChanged
            If Not e.IsNetworkAvailable Then
                MessageBox.Show("Ha ocurrido un error de conexi�n de red. Por favor, corrobore su conexi�n de red ." & vbCrLf & _
                "Se cerrar� la aplicaci�n", "Error de red", MessageBoxButtons.OK, MessageBoxIcon.Error)
                My.Application.MainForm.Close()
            End If
        End Sub


        Private Sub MyApplication_UnhandledException(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs _
        ) Handles Me.UnhandledException
            MessageBox.Show("Ha ocurrido un error en la aplicaci�n. Por favor, comuniquese con el administrador de Cedir 2.0 ." & vbCrLf & _
                "Se cerrar� la aplicaci�n", "Error de aplicaci�n", MessageBoxButtons.OK, MessageBoxIcon.Error)
            My.Application.MainForm.Close()

            'walter : aca podemos tener el error y mandarlo a log de base de datos, mas los datos de hora, fecha, 
            'y demas 
            'e.Exception.Message 
            'My.Computer.Clock.LocalTime


        End Sub


    End Class

End Namespace

