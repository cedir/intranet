Imports Npgsql
Namespace My

    ' Los siguientes eventos están disponibles para MyApplication:
    ' 
    ' Inicio: se desencadena cuando se inicia la aplicación, antes de que se cree el formulario de inicio.
    ' Apagado: generado después de cerrar todos los formularios de la aplicación. Este evento no se genera si la aplicación termina de forma anómala.
    ' UnhandledException: generado si la aplicación detecta una excepción no controlada.
    ' StartupNextInstance: se desencadena cuando se inicia una aplicación de instancia única y la aplicación ya está activa. 
    ' NetworkAvailabilityChanged: se desencadena cuando la conexión de red está conectada o desconectada.



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

