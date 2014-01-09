Imports CedirNegocios
Imports System.Drawing.Printing
Imports Singleton


Public Class frmEliminarPaciente

    Private pacienteAEliminar As Paciente
    Private pacienteReemlazante As Paciente





    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.lblPacienteEliminar.Text = ""
        Me.lblPacienteReemplazante.Text = ""

        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 11
        ProgressBar1.Step = 1


    End Sub

    Private Sub btnBuscarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPaciente.Click



        Dim bp As New BuscarPacientes
        bp.btnSelecPac.Visible = True
        bp.TopLevel = True
        bp.Location = New Point(0, 10)
        bp.ShowDialog()


        Me.pacienteAEliminar = New Paciente
        Me.pacienteAEliminar = bp.paciente
        bp.Close()



        

        Me.cargarDatosPacienteAEliminar()

    End Sub


    Private Sub cargarDatosPacienteAEliminar()


     

        If pacienteAEliminar IsNot Nothing Then
            Me.lblPacienteEliminar.Text = "NOMBRE: " & Me.pacienteAEliminar.nombreCompleto & vbCrLf & "F.NAC. :" & pacienteAEliminar.fechaDeNacimiento.ToString() & _
                                          "DIREC : " & vbCrLf & pacienteAEliminar.direccion.ToString() & _
                                          "AFILIADO NRO : " & vbCrLf & pacienteAEliminar.nroAfiliado.ToString()
        End If
    End Sub
    Private Sub cargarDatosPacienteReemplazante()
        
        If pacienteReemlazante IsNot Nothing Then
            Me.lblPacienteReemplazante.Text = "NOMBRE: " & Me.pacienteReemlazante.nombreCompleto & vbCrLf & "F.NAC. :" & pacienteReemlazante.fechaDeNacimiento.ToString() & _
                                              "DIREC : " & vbCrLf & pacienteReemlazante.direccion.ToString() & _
                                              "AFILIADO NRO : " & vbCrLf & pacienteReemlazante.nroAfiliado.ToString()
        End If
    End Sub



    Private Sub btnBuscarPacienteReemplazante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarPacienteReemplazante.Click
        Dim bp As New BuscarPacientes
        bp.btnSelecPac.Visible = True
        bp.TopLevel = True
        bp.Location = New Point(0, 10)
        bp.ShowDialog()


        Me.pacienteReemlazante = New Paciente
        Me.pacienteReemlazante = bp.paciente

        bp.Close()

        Me.cargarDatosPacienteReemplazante()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Not validarEliminacion() Then
            Exit Sub
        End If

       


        Dim catalogoPacientes As New CatalogoDePacientes
        Dim nombres As String = catalogoPacientes.eliminarPaciente(Me.pacienteAEliminar.Id, Me.pacienteReemlazante.Id)

        Do
            Threading.Thread.Sleep(100)
            ProgressBar1.PerformStep()

        Loop Until ProgressBar1.Value >= ProgressBar1.Maximum



        If nombres <> Me.pacienteReemlazante.nombres Then
            MessageBox.Show("Ha ocurrido un error. Por favor, anote el ID de los pacientes  a los cuales quizo reemplazar")
        Else
            MessageBox.Show("Pacientes reemplazados")
        End If

        defaultSettings()
    End Sub
    Private Function validarEliminacion() As Boolean
        If Me.pacienteAEliminar Is Nothing Or Me.pacienteReemlazante Is Nothing Then
            MessageBox.Show("Debe seleccionar ambos pacientes")
            Return False
        End If

        If Me.pacienteReemlazante.Id = pacienteAEliminar.Id Then
            MessageBox.Show("Ha seleccionado pacientes iguales. Por favor, elija otro.")
            Me.defaultSettings()
            Return False
        End If

        Return True

    End Function


    Private Sub defaultSettings()
        Me.pacienteReemlazante = Nothing
        Me.pacienteAEliminar = Nothing

        Me.lblPacienteEliminar.Text = ""
        Me.lblPacienteReemplazante.Text = ""

        ProgressBar1.Value = ProgressBar1.Minimum

    End Sub


End Class

