Imports CedirNegocios
Public Class ABMConsultas
    Inherits System.Windows.Forms.Form
    Dim cObraSocialName As String = ""
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    Public Sub New(ByVal nombreOSporDefecto As String)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cObraSocialName = nombreOSporDefecto
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
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Apellido As System.Windows.Forms.Label
    Friend WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtnumAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents radioCantidad As System.Windows.Forms.RadioButton
    Friend WithEvents radioPaciente As System.Windows.Forms.RadioButton
    Friend WithEvents txtCantidad As System.Windows.Forms.TextBox
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtCantidad = New System.Windows.Forms.TextBox
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker
        Me.radioCantidad = New System.Windows.Forms.RadioButton
        Me.radioPaciente = New System.Windows.Forms.RadioButton
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.Apellido = New System.Windows.Forms.Label
        Me.txtBusqueda = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.txtnumAfiliado = New System.Windows.Forms.TextBox
        Me.cmbSexo = New System.Windows.Forms.ComboBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.txtNroOrden = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(104, 72)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(32, 20)
        Me.txtCantidad.TabIndex = 0
        Me.txtCantidad.Text = ""
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short
        Me.dtpFecha.Location = New System.Drawing.Point(120, 24)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(96, 20)
        Me.dtpFecha.TabIndex = 1
        '
        'radioCantidad
        '
        Me.radioCantidad.Checked = True
        Me.radioCantidad.Location = New System.Drawing.Point(24, 72)
        Me.radioCantidad.Name = "radioCantidad"
        Me.radioCantidad.Size = New System.Drawing.Size(72, 24)
        Me.radioCantidad.TabIndex = 2
        Me.radioCantidad.TabStop = True
        Me.radioCantidad.Text = "Cantidad"
        '
        'radioPaciente
        '
        Me.radioPaciente.Location = New System.Drawing.Point(24, 112)
        Me.radioPaciente.Name = "radioPaciente"
        Me.radioPaciente.Size = New System.Drawing.Size(72, 24)
        Me.radioPaciente.TabIndex = 3
        Me.radioPaciente.Text = "Paciente"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(104, 120)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(424, 216)
        Me.TabControl1.TabIndex = 7
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Controls.Add(Me.btnBuscar)
        Me.TabPage1.Controls.Add(Me.Apellido)
        Me.TabPage1.Controls.Add(Me.txtBusqueda)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(416, 190)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buscar"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 40)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(360, 136)
        Me.DataGrid1.TabIndex = 16
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(224, 11)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.TabIndex = 14
        Me.btnBuscar.Text = "Buscar"
        '
        'Apellido
        '
        Me.Apellido.Location = New System.Drawing.Point(20, 11)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(56, 23)
        Me.Apellido.TabIndex = 15
        Me.Apellido.Text = "Apellido:"
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Location = New System.Drawing.Point(92, 11)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(116, 20)
        Me.txtBusqueda.TabIndex = 13
        Me.txtBusqueda.Text = ""
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.txtDni)
        Me.TabPage2.Controls.Add(Me.txtnumAfiliado)
        Me.TabPage2.Controls.Add(Me.cmbSexo)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtDireccion)
        Me.TabPage2.Controls.Add(Me.txtNombre)
        Me.TabPage2.Controls.Add(Me.txtApellido)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(416, 190)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nuevo"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(72, 8)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(112, 20)
        Me.txtDni.TabIndex = 35
        Me.txtDni.Text = ""
        '
        'txtnumAfiliado
        '
        Me.txtnumAfiliado.Location = New System.Drawing.Point(72, 160)
        Me.txtnumAfiliado.Name = "txtnumAfiliado"
        Me.txtnumAfiliado.TabIndex = 32
        Me.txtnumAfiliado.Text = ""
        '
        'cmbSexo
        '
        Me.cmbSexo.Location = New System.Drawing.Point(72, 128)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(128, 21)
        Me.cmbSexo.TabIndex = 23
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(170, -29)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(80, 26)
        Me.Label11.TabIndex = 34
        Me.Label11.Text = "(*) Obligatorio"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(16, 160)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 23)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Nº afiliado:"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(32, 128)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 23)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Sexo:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Dirección:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Nombres:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(28, -32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 26)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Dni:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(72, 96)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(152, 20)
        Me.txtDireccion.TabIndex = 22
        Me.txtDireccion.Text = ""
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(72, 64)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 20
        Me.txtNombre.Text = ""
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(72, 32)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(200, 20)
        Me.txtApellido.TabIndex = 19
        Me.txtApellido.Text = ""
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(112, 384)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.TabIndex = 1
        Me.btnGuardar.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(24, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha del Estudio:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(208, 384)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.Location = New System.Drawing.Point(224, 24)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(304, 21)
        Me.cmbObraSocial.TabIndex = 10
        Me.cmbObraSocial.Text = "ComboBox1"
        '
        'txtNroOrden
        '
        Me.txtNroOrden.Location = New System.Drawing.Point(104, 344)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.TabIndex = 11
        Me.txtNroOrden.Text = ""
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 344)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nro de orden:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(40, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Dni:"
        '
        'ABMConsultas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(560, 416)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNroOrden)
        Me.Controls.Add(Me.cmbObraSocial)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.radioPaciente)
        Me.Controls.Add(Me.radioCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.btnGuardar)
        Me.Name = "ABMConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear Consulta"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrPacientes As ArrayList
    Dim arrObraSocial As ArrayList
    Dim myTable As DataTable = New DataTable("myTable")
    Dim catalogoPacientes As New CatalogoDePacientes
    Dim catalogoObraSocial As New CatalogoDeObrasSociales
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    'SOLO CREA CONSULTAS, NO MODIFICA
    Private Sub ABMConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        arrPacientes = New ArrayList
        Dim clDni As New DataColumn("Dni", Type.GetType("System.Int32"))
        Dim clNombres As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clEdad As New DataColumn("Edad", Type.GetType("System.Int32"))
        Dim clDireccion As New DataColumn("Dirección", Type.GetType("System.String"))
        Dim clNroAfiliado As New DataColumn("Nro de Afiliado", Type.GetType("System.String"))

        myTable.Columns.Add(clDni)
        myTable.Columns.Add(clNombres)
        myTable.Columns.Add(clNroAfiliado)
        myTable.Columns.Add(clEdad)
        myTable.Columns.Add(clDireccion)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "myTable"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Dni"
        TextCol.HeaderText = "Dni"
        TextCol.Width = 70
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Paciente"
        TextCol2.HeaderText = "Paciente"
        TextCol2.Width = 120
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol6 As New DataGridTextBoxColumn
        TextCol6.MappingName = "Nro de Afiliado"
        TextCol6.HeaderText = "Nro de Afiliado"
        TextCol6.Width = 100
        ts1.GridColumnStyles.Add(TextCol6)

        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "Edad"
        TextCol7.HeaderText = "Edad"
        TextCol7.Width = 32
        ts1.GridColumnStyles.Add(TextCol7)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Dirección"
        TextCol4.HeaderText = "Dirección"
        TextCol4.Width = 170
        ts1.GridColumnStyles.Add(TextCol4)

        DataGrid1.TableStyles.Add(ts1)

        cmbSexo.Items.Add("Masculino")
        cmbSexo.Items.Add("Femenino")
        cmbSexo.SelectedIndex = 0
        TabControl1.Enabled = False

        cmbObraSocial.Items.Clear()
        arrObraSocial = catalogoObraSocial.TodosLasObrasSociales
        cmbObraSocial.Items.Add("Sin definir")
        Dim i As Integer
        Dim os As ObraSocial
        For i = 0 To arrObraSocial.Count - 1
            os = arrObraSocial(i)
            cmbObraSocial.Items.Add(os.ObraSocial)
        Next
        cmbObraSocial.SelectedIndex = 0

        cargarDatosPorDefecto()
    End Sub

    Private Sub cargarDatosPorDefecto()

        If cObraSocialName <> "" Then
            cmbObraSocial.SelectedItem = cObraSocialName
            cmbObraSocial.Enabled = False
        Else
            cmbObraSocial.SelectedIndex = 0
        End If
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim bandera As Boolean = True
        Dim cConsulta As New Consulta
        If cmbObraSocial.SelectedIndex = 0 Then
            MsgBox("Debe seleccionarse una Obra Social", MsgBoxStyle.Critical)
            Exit Sub
        End If

        If radioCantidad.Checked Then
            If txtCantidad.Text = "" Then
                MsgBox("Cantidad no puede estar vacío", MsgBoxStyle.Critical)
                bandera = False
            Else
                cConsulta.cantidad = CInt(txtCantidad.Text)
            End If

        Else
            Dim cPaciente As Paciente
            If TabControl1.SelectedIndex = 0 Then
                If arrPacientes.Count = 0 Then
                    MsgBox("No se ha seleccionado ningún paciente", MsgBoxStyle.Critical)
                    bandera = False
                Else
                    cPaciente = arrPacientes(DataGrid1.CurrentRowIndex)
                    cConsulta.paciente = cPaciente
                End If

            Else
                ' crear paciente
                If txtDni.Text = "" Or txtApellido.Text = "" Then
                    MsgBox("Dni y Apellido no pueden estar vacíos", MsgBoxStyle.Critical)
                    bandera = False
                Else
                    Dim arrPacientes As ArrayList
                    Dim catalogoPacientes As New CatalogoDePacientes
                    arrPacientes = catalogoPacientes.TodosLosPacientes(CInt(txtDni.Text), "")
                    If arrPacientes.Count = 0 Then
                        cPaciente = New Paciente
                        cPaciente.dni = CInt(txtDni.Text)
                        cPaciente.nombres = txtNombre.Text
                        cPaciente.apellido = txtApellido.Text
                        ' cPaciente.edad = 0
                        cPaciente.direccion = txtDireccion.Text
                        cPaciente.tel = ""
                        cPaciente.sexo = cmbSexo.Text
                        cPaciente.nroAfiliado = txtnumAfiliado.Text
                        ' cPaciente.AltaPaciente()

                        cConsulta.paciente = cPaciente
                    Else
                        MsgBox("Ya existe un paciente con ese dni", MsgBoxStyle.Critical)
                        bandera = False
                    End If
                End If

            End If


        End If

        If bandera Then
            cConsulta.fecha = dtpFecha.Value.Date
            cConsulta.obraSocial = arrObraSocial(cmbObraSocial.SelectedIndex - 1)
            cConsulta.nroDeOrden = txtNroOrden.Text
            cConsulta.crear()

            If cObraSocialName <> "" Then
                'llenar los datos en el form global
                If hayUnaFacturacionInstanciada Then
                    Dim catalogoEstudios As New CatalogoDeEstudios
                    nroConsultaParaFacturacion = catalogoEstudios.obtenerUltimoNroConsulta
                End If
            Else
                MsgBox("La consulta se ha guardado")
            End If

            Me.Close()
        End If
        
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If txtBusqueda.Text = "" Then
            MsgBox("Debe ingresarse una condición de busqueda")
        Else
            arrPacientes = catalogoPacientes.TodosLosPacientes("", txtBusqueda.Text)
            If arrPacientes.Count = 0 Then
                MsgBox("No se ha encontrado ningún paciente en la búsqueda")
            End If

            myTable.Clear()
            CargarGrilla()
        End If
    End Sub
    Private Sub CargarGrilla()
        Dim NewRow As DataRow
        Dim i As Integer
        Dim p As Paciente
        If arrPacientes.Count > 0 Then
            For i = 0 To arrPacientes.Count - 1
                p = arrPacientes(i)
                NewRow = myTable.NewRow()
                NewRow("Dni") = p.dni
                NewRow("Paciente") = p.nombreCompleto
                NewRow("Edad") = p.edad
                NewRow("Dirección") = p.direccion
                NewRow("Nro de Afiliado") = p.nroAfiliado
                myTable.Rows.Add(NewRow)
            Next
            myTable.AcceptChanges()
            DataGrid1.DataSource = myTable
        End If
    End Sub

    Private Sub radioPaciente_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioPaciente.Click
        TabControl1.Enabled = True
        txtCantidad.Enabled = False
    End Sub

    Private Sub radioCantidad_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles radioCantidad.Click
        TabControl1.Enabled = False
        txtCantidad.Enabled = True
    End Sub
End Class
