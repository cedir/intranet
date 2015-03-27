Imports CedirNegocios
Public Class NuevoEstudioRapidoPaso2
    Inherits System.Windows.Forms.Form
    Dim currentPaciente As Paciente
    Dim agregarPac As Boolean
    Friend WithEvents dtpDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbMedicoAnestesista As System.Windows.Forms.ComboBox
    Dim currentOS As String
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal p As Paciente, ByVal agregarPaciente As Boolean, ByVal obraSocial As String)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        currentPaciente = p
        agregarPac = agregarPaciente
        currentOS = obraSocial
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
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnFinalizar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbEstudio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMedicoAct As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMedicoSol As System.Windows.Forms.ComboBox
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.cmbMedicoAnestesista = New System.Windows.Forms.ComboBox
        Me.dtpDate = New System.Windows.Forms.DateTimePicker
        Me.Label11 = New System.Windows.Forms.Label
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.txtCodigo = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtNroOrden = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.cmbMedicoSol = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbMedicoAct = New System.Windows.Forms.ComboBox
        Me.cmbEstudio = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnFinalizar = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.cmbMedicoAnestesista)
        Me.GroupBox2.Controls.Add(Me.dtpDate)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.cmbObraSocial)
        Me.GroupBox2.Controls.Add(Me.txtCodigo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtNroOrden)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.cmbMedicoSol)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbMedicoAct)
        Me.GroupBox2.Controls.Add(Me.cmbEstudio)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 128)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(479, 298)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Estudio"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(6, 199)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(120, 18)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Médico Anestesista:"
        '
        'cmbMedicoAnestesista
        '
        Me.cmbMedicoAnestesista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicoAnestesista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicoAnestesista.Location = New System.Drawing.Point(132, 196)
        Me.cmbMedicoAnestesista.Name = "cmbMedicoAnestesista"
        Me.cmbMedicoAnestesista.Size = New System.Drawing.Size(280, 21)
        Me.cmbMedicoAnestesista.TabIndex = 7
        Me.cmbMedicoAnestesista.Text = "Seleccione..."
        '
        'dtpDate
        '
        Me.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDate.Location = New System.Drawing.Point(132, 24)
        Me.dtpDate.Name = "dtpDate"
        Me.dtpDate.Size = New System.Drawing.Size(84, 20)
        Me.dtpDate.TabIndex = 1
        Me.dtpDate.TabStop = False
        Me.dtpDate.Value = New Date(2011, 12, 6, 0, 0, 0, 0)
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(78, 59)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 16)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "(Código)"
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbObraSocial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbObraSocial.Location = New System.Drawing.Point(132, 91)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(341, 21)
        Me.cmbObraSocial.TabIndex = 4
        Me.cmbObraSocial.Text = "error"
        '
        'txtCodigo
        '
        Me.txtCodigo.Location = New System.Drawing.Point(132, 56)
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(72, 20)
        Me.txtCodigo.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(6, 232)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(72, 23)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Nº de orden:"
        '
        'txtNroOrden
        '
        Me.txtNroOrden.Location = New System.Drawing.Point(132, 229)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(104, 20)
        Me.txtNroOrden.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(6, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(100, 16)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Médico Solicitante:"
        '
        'cmbMedicoSol
        '
        Me.cmbMedicoSol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicoSol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicoSol.Location = New System.Drawing.Point(132, 162)
        Me.cmbMedicoSol.Name = "cmbMedicoSol"
        Me.cmbMedicoSol.Size = New System.Drawing.Size(280, 21)
        Me.cmbMedicoSol.TabIndex = 6
        Me.cmbMedicoSol.Text = "Seleccione..."
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha del estudio:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Médico Actuante:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 23)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Práctica :"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "O. Social:"
        '
        'cmbMedicoAct
        '
        Me.cmbMedicoAct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicoAct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicoAct.Location = New System.Drawing.Point(132, 127)
        Me.cmbMedicoAct.Name = "cmbMedicoAct"
        Me.cmbMedicoAct.Size = New System.Drawing.Size(280, 21)
        Me.cmbMedicoAct.TabIndex = 5
        Me.cmbMedicoAct.Text = "Seleccione..."
        '
        'cmbEstudio
        '
        Me.cmbEstudio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbEstudio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstudio.Location = New System.Drawing.Point(217, 56)
        Me.cmbEstudio.Name = "cmbEstudio"
        Me.cmbEstudio.Size = New System.Drawing.Size(256, 21)
        Me.cmbEstudio.TabIndex = 3
        Me.cmbEstudio.Text = "error"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 8)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Paso 2 de 2"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(128, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(224, 16)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Complete los datos del estudio"
        '
        'btnFinalizar
        '
        Me.btnFinalizar.Location = New System.Drawing.Point(162, 432)
        Me.btnFinalizar.Name = "btnFinalizar"
        Me.btnFinalizar.Size = New System.Drawing.Size(72, 23)
        Me.btnFinalizar.TabIndex = 9
        Me.btnFinalizar.Text = "Finalizar"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(258, 432)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Cancelar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 40)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(479, 80)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Paciente"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(232, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Label8"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(232, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Label7"
        '
        'NuevoEstudioRapidoPaso2
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(496, 460)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnFinalizar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "NuevoEstudioRapidoPaso2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Estudio - paso 2"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrMedicos As New ArrayList
    Dim arrObraSocial As New ArrayList
    Dim arrAnestesistas As ArrayList
    Dim arrEstudiosP As New ArrayList
    Private Sub NuevoEstudioRapidoPaso2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label7.Text = "Dni:" & currentPaciente.dni
        Label8.Text = "Nombre: " & currentPaciente.apellido & ", " & currentPaciente.nombres
        Me.dtpDate.Value = Date.Today
        cargarCombos()
    End Sub

    Private Sub btnFinalizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFinalizar.Click
        Dim resp As String
        'validar estudio
        Dim catalogoObraSociales As New CatalogoDeObrasSociales
        Dim catalogoEstudios As New CatalogoDeEstudios
        If cmbObraSocial.SelectedIndex = 0 Or cmbEstudio.SelectedIndex = 0 Or Me.dtpDate.Value = Nothing Then
            MsgBox("No se pueden guardar los cambios ya que no se ha especificado una Obra Social y/o un Estudio y/o la fecha.")
        Else
            Dim sObraSocial As ObraSocial = arrObraSocial(cmbObraSocial.SelectedIndex - 1)
            Dim sMedicoActuante As Medico = arrMedicos(cmbMedicoAct.SelectedIndex)
            Dim sMedicoSolicitante As Medico = arrMedicos(cmbMedicoSol.SelectedIndex)
            Dim sMedicoAnestesista As Medico = Nothing
            sMedicoAnestesista = Me.arrAnestesistas(Me.cmbMedicoAnestesista.SelectedIndex)

            Dim est As New Estudio
            est.motivoEstudio = ""
            est.informe = ""
            est.practica.idEstudio = getPracticaId(cmbEstudio.Text)
            est.medicoActuante = sMedicoActuante
            est.medicoSolicitante = sMedicoSolicitante
            est.Anestesista = sMedicoAnestesista

            est.paciente = currentPaciente
            est.obraSocial = sObraSocial
            est.importeMedicacion = 0
            est.pension = 0
            est.fechaEstudio = Me.dtpDate.Value 'txtFecha.Text
            est.nroOrden = txtNroOrden.Text
            resp = est.AltaEstudio(agregarPac)

            If resp = "ok" Then
                If currentOS <> "" Then
                    'llenar los datos en el form global
                    If hayUnaFacturacionInstanciada Then
                        nroEstudioParaFacturacion = est.nroEstudio 'para llenar este atributo hay que hacer una consulta
                    End If
                Else
                    MsgBox("El estudio ha sido creado")
                    'ahora pregunto si desean cargar un movimiento de caja
                    Dim dr As DialogResult
                    dr = MessageBox.Show("Desea crear un movimiento de caja con este estudio?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
                    If dr = Windows.Forms.DialogResult.Yes Then

                        Me.cargarMovimientoCaja(est)
                    End If
                End If

                Me.RecargarFormulario()
            Else
                'error
                MsgBox(resp)
            End If
        End If
    End Sub

    Private Sub cargarMovimientoCaja(ByVal est As Estudio)
        Dim f As New frmABMMovimientoCaja
        f.estudio = est
        f.esEdicion = False
        f.ShowDialog()

    End Sub

    Private Sub recargarFormulario()
        Dim dr As DialogResult = MessageBox.Show("Desea crear un nuevo estudio", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If dr = Windows.Forms.DialogResult.Yes Then
            cmbEstudio.SelectedIndex = 0
        Else
            Me.Close()
        End If

    End Sub


    Private Sub cargarCombos()

        Dim ep As Practica
        Dim i As Integer
        Dim med As Medico
        Dim os As ObraSocial
        Dim catalogoMedicos As New CatalogoDeMedicos
        Dim catalogoPracticas As New CatalogoDePracticas
        Dim catalogoObraSocial As New CatalogoDeObrasSociales

        arrMedicos = catalogoMedicos.TodosLosMedicos()

        cmbMedicoAct.Items.Clear()
        cmbMedicoSol.Items.Clear()

        For i = 0 To arrMedicos.Count - 1
            'med = New Medico
            med = arrMedicos(i)
            cmbMedicoAct.Items.Add(med.nombreCompleto)

            cmbMedicoSol.Items.Add(med.nombreCompleto)
        Next

        arrAnestesistas = catalogoMedicos.TodosLosAnestesistas()
        cmbMedicoAnestesista.Items.Clear()
        For i = 0 To arrAnestesistas.Count - 1
            med = arrAnestesistas(i)
            cmbMedicoAnestesista.Items.Add(med.nombreCompleto)
        Next

        cmbMedicoAnestesista.SelectedIndex = cmbMedicoAnestesista.FindString("Sin anestesia")

        cmbObraSocial.Items.Clear()
        arrObraSocial = catalogoObraSocial.TodosLasObrasSociales
        cmbObraSocial.Items.Add("Sin definir")
        For i = 0 To arrObraSocial.Count - 1
            os = arrObraSocial(i)
            cmbObraSocial.Items.Add(os.ObraSocial)
        Next

        If currentOS <> "" Then
            cmbObraSocial.SelectedItem = currentOS
            cmbObraSocial.Enabled = False
        Else
            cmbObraSocial.SelectedIndex = 0
        End If
        cmbEstudio.Items.Clear()
        arrEstudiosP = catalogoPracticas.getPracticas
        cmbEstudio.Items.Add("Sin definir")
        For i = 0 To arrEstudiosP.Count - 1
            ep = arrEstudiosP(i)
            cmbEstudio.Items.Add(ep.Estudio)

        Next
        'establecemos como default la practica 'CONSULTA'
        cmbEstudio.SelectedItem = "CONSULTA"
        cmbMedicoAct.SelectedItem = "BRUNETTI, JOSE"
        cmbMedicoSol.SelectedItem = "BRUNETTI, JOSE"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Function getPracticaId(ByVal practica As String) As Integer
        Dim i As Integer
        For i = 0 To arrEstudiosP.Count - 1

            If arrEstudiosP(i).Estudio() = practica Then
                Return arrEstudiosP(i).idEstudio()
            End If

        Next
    End Function


    Private Sub txtCodigo_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCodigo.KeyDown
        If e.KeyCode = Keys.Enter Then

            Dim i As Integer
            Dim cPractica As Practica
            For i = 0 To arrEstudiosP.Count - 1
                cPractica = arrEstudiosP(i)
                If CStr(cPractica.codigoMedico) = txtCodigo.Text Then
                    cmbEstudio.SelectedIndex = i + 1
                End If
            Next
        End If
    End Sub

    Private Sub cmbMedicoAct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicoAct.SelectedIndexChanged
        If cmbEstudio.SelectedItem = "CONSULTA" Then
            Me.cmbMedicoSol.SelectedItem = Me.cmbMedicoAct.SelectedItem
        End If
    End Sub

    Private Sub cmbMedicoSol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicoSol.SelectedIndexChanged
        If cmbEstudio.SelectedItem = "CONSULTA" Then
            Me.cmbMedicoAct.SelectedItem = Me.cmbMedicoSol.SelectedItem
        End If
    End Sub

    Private Sub NuevoEstudioRapidoPaso2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        teclaPresionada(e)
    End Sub
    Private Sub teclaPresionada(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.btnFinalizar.PerformClick()
        End If
    End Sub

    Private Sub cmbMedicoAnestesista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicoAnestesista.SelectedIndexChanged

    End Sub
End Class
