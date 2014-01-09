Imports CedirNegocios
Imports System.Drawing.Printing
Imports Singleton
Public Class BuscarPacientes
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
    Friend WithEvents DataGrid1 As wallyGrid
    Friend WithEvents BtnNuevoEstudio As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
	Friend WithEvents btnNuevoPaciente As System.Windows.Forms.Button
	Friend WithEvents lblNombre As System.Windows.Forms.Label
	Friend WithEvents txtNombres As System.Windows.Forms.TextBox
    Friend WithEvents btnSelecPac As System.Windows.Forms.Button
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents SeleccionarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
	Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.BtnNuevoEstudio = New System.Windows.Forms.Button
        Me.txtdni = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnEditar = New System.Windows.Forms.Button
        Me.btnNuevoPaciente = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.txtNombres = New System.Windows.Forms.TextBox
        Me.btnSelecPac = New System.Windows.Forms.Button
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SeleccionarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnNuevoEstudio
        '
        Me.BtnNuevoEstudio.Location = New System.Drawing.Point(16, 376)
        Me.BtnNuevoEstudio.Name = "BtnNuevoEstudio"
        Me.BtnNuevoEstudio.Size = New System.Drawing.Size(96, 24)
        Me.BtnNuevoEstudio.TabIndex = 1
        Me.BtnNuevoEstudio.Text = "Nuevo Estudio"
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(64, 16)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(104, 20)
        Me.txtdni.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(31, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Dni:"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(218, 74)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(80, 24)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(64, 44)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(104, 20)
        Me.txtApellido.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(13, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Apellido:"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(136, 376)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 8
        Me.btnEditar.Text = "Editar"
        '
        'btnNuevoPaciente
        '
        Me.btnNuevoPaciente.Location = New System.Drawing.Point(344, 89)
        Me.btnNuevoPaciente.Name = "btnNuevoPaciente"
        Me.btnNuevoPaciente.Size = New System.Drawing.Size(96, 23)
        Me.btnNuevoPaciente.TabIndex = 4
        Me.btnNuevoPaciente.Text = "Nuevo Paciente"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.txtNombres)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(304, 104)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Condición de búsqueda"
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Location = New System.Drawing.Point(13, 77)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(47, 13)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre:"
        '
        'txtNombres
        '
        Me.txtNombres.Location = New System.Drawing.Point(64, 74)
        Me.txtNombres.Name = "txtNombres"
        Me.txtNombres.Size = New System.Drawing.Size(104, 20)
        Me.txtNombres.TabIndex = 2
        '
        'btnSelecPac
        '
        Me.btnSelecPac.Location = New System.Drawing.Point(344, 12)
        Me.btnSelecPac.Name = "btnSelecPac"
        Me.btnSelecPac.Size = New System.Drawing.Size(121, 23)
        Me.btnSelecPac.TabIndex = 11
        Me.btnSelecPac.Text = "Seleccionar paciente"
        Me.btnSelecPac.UseVisualStyleBackColor = True
        Me.btnSelecPac.Visible = False
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGrid1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 130)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(704, 230)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TabStop = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeleccionarToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(153, 48)
        '
        'SeleccionarToolStripMenuItem
        '
        Me.SeleccionarToolStripMenuItem.Name = "SeleccionarToolStripMenuItem"
        Me.SeleccionarToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SeleccionarToolStripMenuItem.Text = "Seleccionar"
        '
        'BuscarPacientes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(744, 408)
        Me.Controls.Add(Me.btnSelecPac)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnNuevoPaciente)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.BtnNuevoEstudio)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "BuscarPacientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Pacientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
	Dim arrPacientes As ArrayList
	Dim myTable As DataTable = New DataTable("myTable")
	Dim catalogoPacientes As New CatalogoDePacientes
	Dim p As Paciente
    Dim ts1 As New DataGridTableStyle

    Public Property paciente() As Paciente
        Get
            Return p
        End Get
        Set(ByVal value As Paciente)
            p = value
        End Set
    End Property


	Private Sub BuscarPacientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
		arrPacientes = New ArrayList
		Dim clDni As New DataColumn("Dni", Type.GetType("System.Int32"))
		Dim clNombres As New DataColumn("Nombres", Type.GetType("System.String"))
		Dim clApellido As New DataColumn("Apellido", Type.GetType("System.String"))
		Dim clDireccion As New DataColumn("Dirección", Type.GetType("System.String"))
		Dim clTelefono As New DataColumn("Telefono", Type.GetType("System.String"))
		Dim clNroAfiliado As New DataColumn("Nro de Afiliado", Type.GetType("System.String"))
        Dim clFechaNacimiento As New DataColumn("FechaNacimiento", Type.GetType("System.DateTime"))

		myTable.Columns.Add(clDni)
		myTable.Columns.Add(clNombres)
		myTable.Columns.Add(clApellido)
		myTable.Columns.Add(clDireccion)
		myTable.Columns.Add(clTelefono)
        myTable.Columns.Add(clNroAfiliado)
        myTable.Columns.Add(clFechaNacimiento)


		ts1.MappingName = "myTable"
		ts1.BackColor = Color.LightGray
		ts1.ForeColor = Color.SlateBlue
		'ts1.AlternatingBackColor = Color.SteelBlue
		ts1.AlternatingBackColor = Color.White
		ts1.AllowSorting = False

		ts1.HeaderForeColor = Color.MediumSlateBlue
		ts1.HeaderBackColor = Color.WhiteSmoke
		ts1.GridLineColor = Color.MediumPurple

		'DataGrid1.GridLineColor = Color.MediumPurple
		'DataGrid1.HeaderBackColor = Color.MediumPurple
		Dim TextCol As New DataGridTextBoxColumn
		TextCol.MappingName = "Dni"
		TextCol.HeaderText = "Dni"
		TextCol.Width = 70
		ts1.GridColumnStyles.Add(TextCol)

		Dim TextCol2 As New DataGridTextBoxColumn
		TextCol2.MappingName = "Nombres"
		TextCol2.HeaderText = "Nombres"
		TextCol2.Width = 120
		ts1.GridColumnStyles.Add(TextCol2)

		Dim TextCol3 As New DataGridTextBoxColumn
		TextCol3.MappingName = "Apellido"
		TextCol3.HeaderText = "Apellido"
		TextCol3.Width = 90
		ts1.GridColumnStyles.Add(TextCol3)

		Dim TextCol4 As New DataGridTextBoxColumn
		TextCol4.MappingName = "Dirección"
		TextCol4.HeaderText = "Dirección"
		TextCol4.Width = 170
		ts1.GridColumnStyles.Add(TextCol4)

		Dim TextCol5 As New DataGridTextBoxColumn
		TextCol5.MappingName = "Telefono"
		TextCol5.HeaderText = "Telefono"
		TextCol5.Width = 100
		ts1.GridColumnStyles.Add(TextCol5)

		Dim TextCol6 As New DataGridTextBoxColumn
		TextCol6.MappingName = "Nro de Afiliado"
		TextCol6.HeaderText = "Nro de Afiliado"
		TextCol6.Width = 100
		ts1.GridColumnStyles.Add(TextCol6)

        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "FechaNacimiento"
        TextCol7.HeaderText = "Fecha de Nacimiento"
        TextCol7.Width = 100
        ts1.GridColumnStyles.Add(TextCol7)
		DataGrid1.TableStyles.Add(ts1)

		'CargarGrilla()
		btnEditar.Enabled = False
		BtnNuevoEstudio.Enabled = False

	End Sub
	Private Sub CargarGrilla()
		Dim NewRow As DataRow
		Dim i As Integer

		If arrPacientes.Count > 0 Then
			btnEditar.Enabled = True
			BtnNuevoEstudio.Enabled = True
			For i = 0 To arrPacientes.Count - 1
				'p = New Paciente
				p = arrPacientes(i)
				NewRow = myTable.NewRow()
				NewRow("Dni") = p.dni
				NewRow("Nombres") = p.nombres
				NewRow("Apellido") = p.apellido
				NewRow("Dirección") = p.direccion
				NewRow("Telefono") = p.tel
                NewRow("Nro de Afiliado") = p.nroAfiliado
                NewRow("FechaNacimiento") = p.fechaDeNacimiento
				If i = 2 Or i = 3 Then
					NewRow.SetParentRow(NewRow)
				End If

				myTable.Rows.Add(NewRow)


			Next
			myTable.AcceptChanges()
			DataGrid1.DataSource = myTable
		Else
			btnEditar.Enabled = False
			BtnNuevoEstudio.Enabled = False

		End If
	End Sub
	Private Sub BtnNuevoEstudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNuevoEstudio.Click
		Dim i As Integer
		i = DataGrid1.CurrentRowIndex
		Dim est As New Estudio
		est.nroEstudio = 0
		'est.paciente.dni = DataGrid1.Item(i, 0)
		'est.paciente.apellido = DataGrid1.Item(i, 2)
		'est.paciente.nombres = DataGrid1.Item(i, 1)
		est.paciente = arrPacientes(i)
		est.practica.Estudio = ""
		est.motivoEstudio = ""
		est.informe = ""
		est.medicoActuante.idMedico = 0
		est.medicoSolicitante.idMedico = 0
		est.obraSocial.idObraSocial = 0
		Dim frm As New NuevoEstudio(est)
		frm.MdiParent = Me.Parent.Parent
		frm.Show()
		'Me.Close()
	End Sub

	Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click

		If (txtdni.Text = "" And txtApellido.Text = "" And txtNombres.Text = "") Then
			MsgBox("Debe ingresarse una condición de busqueda")
		Else
            arrPacientes = catalogoPacientes.TodosLosPacientes(txtdni.Text.ToUpper.Trim(), txtApellido.Text.ToUpper.Trim(), txtNombres.Text.ToUpper.Trim())
			If arrPacientes.Count = 0 Then
				MsgBox("No se ha encontrado ningún paciente en la búsqueda")
			End If

			myTable.Clear()
			CargarGrilla()
		End If

	End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim p As New Paciente
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        p = arrPacientes(i)
        Dim frm As New AltaPaciente()
        frm.esAltaPaciente = False
        frm.currentPaciente = p
        frm.ShowDialog()
        Me.btnBuscar.PerformClick()
    End Sub

    Private Sub btnNuevoPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevoPaciente.Click
        Dim frm As New AltaPaciente()
        frm.esAltaPaciente = True
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub


    Private Sub txtApellido_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellido.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub txtdni_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtdni.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.PerformClick()
        End If
    End Sub

	Private Sub txtNombres_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombres.KeyDown
		If e.KeyCode = Keys.Enter Then
			btnBuscar.PerformClick()
		End If
	End Sub

	'Boton solo visible si el formulario fue llamado desde ComprobantesNuevo
	Private Sub btnSelecPac_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelecPac.Click
		Me.getPaciente()
        Me.Hide()
	End Sub

    Private Sub getPaciente()
        'ACA VAMOS A PONER codigo PARA seleccionar un obj paciente para llevarlo a ComprobantesNuevo
        Try
            paciente = New Paciente
            paciente = arrPacientes(DataGrid1.CurrentRowIndex)
            'CType(Me.Owner, frmComprobanteNuevo).CargarObjeto(p)
        Catch
            MsgBox("Por favor, primero realice la busqueda del paciente", MsgBoxStyle.OkOnly, "No se ha seleccionado un paciente")
        Finally
        End Try

    End Sub

    Private Sub SeleccionarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeleccionarToolStripMenuItem.Click

    End Sub
End Class
