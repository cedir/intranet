Imports CedirNegocios
Public Class NuevoEstudioRapido
    Inherits System.Windows.Forms.Form
    Dim currentOS As String
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal obraSocial As String)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        currentOS = obraSocial
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
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSiguiente As System.Windows.Forms.Button
    Friend WithEvents txtBusquedaApellido As System.Windows.Forms.TextBox
    Friend WithEvents Apellido As System.Windows.Forms.Label
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbSexo As System.Windows.Forms.ComboBox
    Friend WithEvents txtnumAfiliado As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtBusquedaNombre As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtBusquedaDni As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txtFechaNacimiento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnSiguiente = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtBusquedaApellido = New System.Windows.Forms.TextBox
        Me.Apellido = New System.Windows.Forms.Label
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnModificar = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtBusquedaDni = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtBusquedaNombre = New System.Windows.Forms.TextBox
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.txtFechaNacimiento = New System.Windows.Forms.MaskedTextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtnumAfiliado = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbSexo = New System.Windows.Forms.ComboBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(229, 47)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 3
        Me.btnBuscar.Text = "Buscar"
        '
        'btnSiguiente
        '
        Me.btnSiguiente.Location = New System.Drawing.Point(16, 352)
        Me.btnSiguiente.Name = "btnSiguiente"
        Me.btnSiguiente.Size = New System.Drawing.Size(80, 23)
        Me.btnSiguiente.TabIndex = 8
        Me.btnSiguiente.Text = "Siguiente -->"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(120, 352)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Paso 1 de 2"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(128, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(240, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Elija el paciente correspondiente al estudio"
        '
        'txtBusquedaApellido
        '
        Me.txtBusquedaApellido.Location = New System.Drawing.Point(71, 3)
        Me.txtBusquedaApellido.Name = "txtBusquedaApellido"
        Me.txtBusquedaApellido.Size = New System.Drawing.Size(152, 20)
        Me.txtBusquedaApellido.TabIndex = 0
        '
        'Apellido
        '
        Me.Apellido.Location = New System.Drawing.Point(15, 3)
        Me.Apellido.Name = "Apellido"
        Me.Apellido.Size = New System.Drawing.Size(56, 23)
        Me.Apellido.TabIndex = 8
        Me.Apellido.Text = "Apellido:"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 72)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(472, 184)
        Me.DataGrid1.TabIndex = 100
        Me.DataGrid1.TabStop = False
        Me.ToolTip1.SetToolTip(Me.DataGrid1, "Haga doble-click para modificar" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "datos del paciente")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(504, 296)
        Me.TabControl1.TabIndex = 7
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.btnModificar)
        Me.TabPage1.Controls.Add(Me.Label13)
        Me.TabPage1.Controls.Add(Me.txtBusquedaDni)
        Me.TabPage1.Controls.Add(Me.Label12)
        Me.TabPage1.Controls.Add(Me.txtBusquedaNombre)
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Controls.Add(Me.btnBuscar)
        Me.TabPage1.Controls.Add(Me.Apellido)
        Me.TabPage1.Controls.Add(Me.txtBusquedaApellido)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(496, 270)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Buscar Paciente"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(310, 47)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 101
        Me.btnModificar.Text = "Modificar"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(15, 49)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 23)
        Me.Label13.TabIndex = 13
        Me.Label13.Text = "DNI:"
        '
        'txtBusquedaDni
        '
        Me.txtBusquedaDni.Location = New System.Drawing.Point(71, 49)
        Me.txtBusquedaDni.Name = "txtBusquedaDni"
        Me.txtBusquedaDni.Size = New System.Drawing.Size(152, 20)
        Me.txtBusquedaDni.TabIndex = 2
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(15, 26)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 23)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Nombre:"
        '
        'txtBusquedaNombre
        '
        Me.txtBusquedaNombre.Location = New System.Drawing.Point(71, 26)
        Me.txtBusquedaNombre.Name = "txtBusquedaNombre"
        Me.txtBusquedaNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtBusquedaNombre.TabIndex = 1
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtFechaNacimiento)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtnumAfiliado)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtTel)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.Label5)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.cmbSexo)
        Me.TabPage2.Controls.Add(Me.txtDireccion)
        Me.TabPage2.Controls.Add(Me.txtNombre)
        Me.TabPage2.Controls.Add(Me.txtApellido)
        Me.TabPage2.Controls.Add(Me.txtDni)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(496, 270)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Nuevo Paciente"
        '
        'txtFechaNacimiento
        '
        Me.txtFechaNacimiento.Location = New System.Drawing.Point(108, 109)
        Me.txtFechaNacimiento.Mask = "00/00/0000"
        Me.txtFechaNacimiento.Name = "txtFechaNacimiento"
        Me.txtFechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaNacimiento.TabIndex = 17
        Me.ToolTip1.SetToolTip(Me.txtFechaNacimiento, "dd/mm/aaaa")
        Me.txtFechaNacimiento.ValidatingType = GetType(Date)
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(38, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 23)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Nº afiliado:"
        '
        'txtnumAfiliado
        '
        Me.txtnumAfiliado.Location = New System.Drawing.Point(108, 240)
        Me.txtnumAfiliado.Name = "txtnumAfiliado"
        Me.txtnumAfiliado.Size = New System.Drawing.Size(100, 20)
        Me.txtnumAfiliado.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(46, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 16)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Teléfono:"
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(108, 176)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(144, 20)
        Me.txtTel.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(62, 208)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 23)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Sexo:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(46, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Dirección:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 20)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Fecha Nacimiento:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(46, 47)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Nombres:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(54, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(70, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Dni:"
        '
        'cmbSexo
        '
        Me.cmbSexo.Location = New System.Drawing.Point(108, 208)
        Me.cmbSexo.Name = "cmbSexo"
        Me.cmbSexo.Size = New System.Drawing.Size(128, 21)
        Me.cmbSexo.TabIndex = 6
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(108, 144)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(232, 20)
        Me.txtDireccion.TabIndex = 4
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(108, 44)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 20)
        Me.txtNombre.TabIndex = 1
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(108, 76)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(200, 20)
        Me.txtApellido.TabIndex = 2
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(108, 16)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(100, 20)
        Me.txtDni.TabIndex = 0
        '
        'ToolTip1
        '
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ToolTipTitle = "Info:"
        '
        'NuevoEstudioRapido
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(536, 398)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnSiguiente)
        Me.Name = "NuevoEstudioRapido"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear un estudio"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrPacientes As ArrayList
    Dim myTable As DataTable = New DataTable("myTable")
    Dim catalogoPacientes As New CatalogoDePacientes
    Private Sub NuevoEstudioRapido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        arrPacientes = New ArrayList
        'arrPacientes = cn.TodosLosPacientes()
        Dim clDni As New DataColumn("Dni", Type.GetType("System.Int32"))
        Dim clNombres As New DataColumn("Nombres", Type.GetType("System.String"))
        Dim clApellido As New DataColumn("Apellido", Type.GetType("System.String"))
        Dim clEdad As New DataColumn("Edad", Type.GetType("System.Int32"))
        Dim clDireccion As New DataColumn("Dirección", Type.GetType("System.String"))
        Dim clNroAfiliado As New DataColumn("Nro de Afiliado", Type.GetType("System.String"))

        myTable.Columns.Add(clDni)
        myTable.Columns.Add(clNombres)
        myTable.Columns.Add(clApellido)
        myTable.Columns.Add(clNroAfiliado)
        myTable.Columns.Add(clEdad)
        myTable.Columns.Add(clDireccion)

        Dim ts1 As New DataGridTableStyle
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
        Me.btnModificar.Enabled = False

    End Sub
    Private Sub CargarGrilla()
        Dim NewRow As DataRow
        Dim i As Integer
        Dim p As Paciente

        If arrPacientes.Count > 0 Then
            For i = 0 To arrPacientes.Count - 1
                'p = New Paciente
                p = arrPacientes(i)
                NewRow = myTable.NewRow()
                NewRow("Dni") = p.dni
                NewRow("Nombres") = p.nombres
                NewRow("Apellido") = p.apellido
                NewRow("Edad") = p.edad
                NewRow("Dirección") = p.direccion
                NewRow("Nro de Afiliado") = p.nroAfiliado

                myTable.Rows.Add(NewRow)
            Next
            myTable.AcceptChanges()
            DataGrid1.DataSource = myTable

            btnModificar.Enabled = True
        Else
            btnModificar.Enabled = False
        End If

    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub btnSiguiente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSiguiente.Click
        'Pasarle un objeto de tipo paciente, sin que lo agregue a la base de datos
        'Detectar si es un paciente encotrado o creado
        Dim p As Paciente
        Dim validateData As Boolean = False
        Dim agregarPaciente As Boolean
        If TabControl1.SelectedIndex = 0 Then
            'buscar paciente
            If arrPacientes.Count = 0 Then
                MsgBox("No se ha seleccionado ningún paciente")
            Else
                Dim i As Integer
                i = DataGrid1.CurrentRowIndex
                p = arrPacientes(i)
                agregarPaciente = False
                validateData = True
            End If

        Else
            agregarPaciente = True
            p = New Paciente

            Dim arr As ArrayList
            If txtDni.Text <> "" Then
                p.dni = CInt(txtDni.Text)
            Else
                p.dni = 0
            End If

            If txtApellido.Text = "" Then
                MsgBox("El campo apellido no pueden estar vacio")
                Exit Sub
            End If

            If p.dni <> 0 Then
                'validamos que ese paciente no existe.(buscamos su dni)
                arr = catalogoPacientes.TodosLosPacientes(p.dni, , )

                If arr.Count > 0 Then
                    MsgBox("Ya existe un paciente con ese dni. Busque el paciente, por nro de dni" & vbCrLf & " y actualice sus datos ")
                    Exit Sub
                End If
            End If
            p.apellido = txtApellido.Text
            p.nombres = txtNombre.Text
            p.direccion = txtDireccion.Text
            p.nroAfiliado = txtnumAfiliado.Text
            If txtFechaNacimiento.MaskCompleted Then
                p.fechaDeNacimiento = CDate(txtFechaNacimiento.Text)
            Else
                p.fechaDeNacimiento = Nothing
            End If
            p.tel = txtTel.Text
            p.sexo = cmbSexo.SelectedItem

            validateData = True
        End If

        If validateData Then
            Dim frm As New NuevoEstudioRapidoPaso2(p, agregarPaciente, currentOS)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()

            Me.Close()
        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'If txtBusquedaApellido.Text = "" Then
        '    ' MsgBox("Debe ingresarse una condición de busqueda")
        'Else
        arrPacientes = catalogoPacientes.TodosLosPacientes(Me.txtBusquedaDni.Text.ToUpper.Trim, Me.txtBusquedaApellido.Text.ToUpper.Trim, Me.txtBusquedaNombre.Text.ToUpper.Trim())
        If arrPacientes.Count = 0 Then
            MsgBox("No se ha encontrado ningún paciente en la búsqueda")
        End If

        myTable.Clear()
        CargarGrilla()
        '        End If

    End Sub

    Private Sub teclaPresionada(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If txtBusquedaApellido.Text = "" And Me.txtBusquedaNombre.Text = "" And Me.txtBusquedaDni.Text = "" Then
                MsgBox("Debe ingresarse una condición de busqueda")
            Else
                arrPacientes = catalogoPacientes.TodosLosPacientes(Me.txtBusquedaDni.Text, txtBusquedaApellido.Text, Me.txtBusquedaNombre.Text)
                If arrPacientes.Count = 0 Then
                    MsgBox("No se ha encontrado ningún paciente en la búsqueda")
                End If

                myTable.Clear()
                CargarGrilla()
            End If
        End If
    End Sub

    Private Sub txtBusquedaNombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusquedaNombre.KeyDown
        Me.teclaPresionada(e)
    End Sub

    Private Sub txtBusquedaDni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusquedaDni.KeyDown
        Me.teclaPresionada(e)
    End Sub
    Private Sub txtBusquedaApellido_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBusquedaApellido.KeyDown
        Me.teclaPresionada(e)
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim p As New Paciente
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        p = arrPacientes(i)
        Dim frm As New AltaPaciente()
        frm.esAltaPaciente = False
        frm.currentPaciente = p
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Me.btnModificar.PerformClick()
    End Sub
End Class
