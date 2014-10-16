Imports Npgsql
Namespace My

    ' Los siguientes eventos est�n disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicaci�n, antes de que se cree el formulario de inicio.
    ' Apagado: generado despu�s de cerrar todos los formularios de la aplicaci�n. Este evento no se genera si la aplicaci�n termina de forma an�mala.
    ' UnhandledException: generado si la aplicaci�n detecta una excepci�n no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicaci�n de instancia �nica y la aplicaci�n ya est� activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexi�n de red est� conectada o desconectada.



    Partial Friend Class MyApplication

        Private Sub MyApplication_NetworkAvailabilityChanged( _
            ByVal sender As Object, _
            ByVal e As Microsoft.VisualBasic.Devices.NetworkAvailableEventArgs _
        ) Handles Me.NetworkAvailabilityChanged
            MessageBox.Show("Disponibilidad de red....:" & e.IsNetworkAvailable.ToString() & "   Se ha desconectado la red. Por favor, corrobore la conexion de red. (cable descontectado?)")
            e.IsNetworkAvailable.ToString()
        End Sub

        Private Sub MyApplication_UnhandledException( _
            ByVal sender As Object, _
            ByVal e As Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs _
        ) Handles Me.UnhandledException

            Try

                Dim errorMsg As String = "Contacte al area de sistemas. Ha ocurrido un error en la aplicacion" & _
                    "con la siguiente informacion:" & ControlChars.Lf & ControlChars.Lf

                ' como no podemos manejar el fin de la aplicacion , creamos logs 
                If (Not EventLog.SourceExists("ThreadException")) Then
                    EventLog.CreateEventSource("ThreadException", "Application")
                End If


                Dim myLog As New EventLog()
                myLog.Source = "ThreadException"
                myLog.WriteEntry((errorMsg + e.Exception.Message & ControlChars.Lf & ControlChars.Lf & _
                    "Stack Trace:" & ControlChars.Lf & e.Exception.StackTrace))
            Catch exc As Exception
                Try
                    MessageBox.Show("Fatal Non-UI Error", "Fatal Non-UI Error. NO SE PUDO CREAR LOG. " & _
                        "RAZON: " & exc.Message, MessageBoxButtons.OK, MessageBoxIcon.Stop)
                Finally
                    e.ExitApplication = True
                End Try
            End Try
        End Sub

        Protected Overrides Function OnInitialize( _
    ByVal commandLineArgs As _
    System.Collections.ObjectModel.ReadOnlyCollection(Of String) _
) As Boolean

            Me.MinimumSplashScreenDisplayTime = 3000
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

    End Class


End Namespace

