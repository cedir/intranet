Imports CedirNegocios

Public Class ConsultaEstudios
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMedicos As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents rdbMedAct As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMedSol As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMedAmbos As System.Windows.Forms.RadioButton
    Friend WithEvents btnMedicacion As System.Windows.Forms.Button
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtDni As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoPac As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbMedicos = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.rdbMedAct = New System.Windows.Forms.RadioButton
        Me.rdbMedSol = New System.Windows.Forms.RadioButton
        Me.rdbMedAmbos = New System.Windows.Forms.RadioButton
        Me.btnMedicacion = New System.Windows.Forms.Button
        Me.btnVer = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtApellidoPac = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtDni = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMedicos
        '
        Me.cmbMedicos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicos.Location = New System.Drawing.Point(40, 16)
        Me.cmbMedicos.Name = "cmbMedicos"
        Me.cmbMedicos.Size = New System.Drawing.Size(144, 21)
        Me.cmbMedicos.TabIndex = 1
        Me.cmbMedicos.Text = "Seleccione.."
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(16, 145)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 24)
        Me.btnBuscar.TabIndex = 9
        Me.btnBuscar.Text = "Buscar"
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(290, 19)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(104, 20)
        Me.txtFecha.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(243, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 24)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(242, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Nombre del Paciente:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(368, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(104, 20)
        Me.txtNombre.TabIndex = 7
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(608, 507)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(72, 24)
        Me.btnImprimir.TabIndex = 11
        Me.btnImprimir.Text = "Imprimir"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-64, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 16)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Médico:"
        '
        'rdbMedAct
        '
        Me.rdbMedAct.Location = New System.Drawing.Point(40, 40)
        Me.rdbMedAct.Name = "rdbMedAct"
        Me.rdbMedAct.Size = New System.Drawing.Size(112, 16)
        Me.rdbMedAct.TabIndex = 2
        Me.rdbMedAct.Text = "Médico Actuante"
        '
        'rdbMedSol
        '
        Me.rdbMedSol.Location = New System.Drawing.Point(40, 64)
        Me.rdbMedSol.Name = "rdbMedSol"
        Me.rdbMedSol.Size = New System.Drawing.Size(120, 16)
        Me.rdbMedSol.TabIndex = 3
        Me.rdbMedSol.Text = "Médico Solicitante"
        '
        'rdbMedAmbos
        '
        Me.rdbMedAmbos.Checked = True
        Me.rdbMedAmbos.Location = New System.Drawing.Point(40, 88)
        Me.rdbMedAmbos.Name = "rdbMedAmbos"
        Me.rdbMedAmbos.Size = New System.Drawing.Size(96, 16)
        Me.rdbMedAmbos.TabIndex = 4
        Me.rdbMedAmbos.TabStop = True
        Me.rdbMedAmbos.Text = "Ambos"
        '
        'btnMedicacion
        '
        Me.btnMedicacion.Location = New System.Drawing.Point(128, 24)
        Me.btnMedicacion.Name = "btnMedicacion"
        Me.btnMedicacion.Size = New System.Drawing.Size(75, 23)
        Me.btnMedicacion.TabIndex = 11
        Me.btnMedicacion.Text = "Medicacion"
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(48, 24)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(40, 23)
        Me.btnVer.TabIndex = 10
        Me.btnVer.Text = "Ver"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtApellidoPac)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtDni)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.rdbMedAct)
        Me.GroupBox1.Controls.Add(Me.rdbMedSol)
        Me.GroupBox1.Controls.Add(Me.rdbMedAmbos)
        Me.GroupBox1.Controls.Add(Me.cmbMedicos)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(480, 131)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar"
        '
        'txtApellidoPac
        '
        Me.txtApellidoPac.Location = New System.Drawing.Point(368, 46)
        Me.txtApellidoPac.Name = "txtApellidoPac"
        Me.txtApellidoPac.Size = New System.Drawing.Size(104, 20)
        Me.txtApellidoPac.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(242, 46)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 24)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Apellido del Paciente:"
        '
        'txtDni
        '
        Me.txtDni.Location = New System.Drawing.Point(368, 94)
        Me.txtDni.Name = "txtDni"
        Me.txtDni.Size = New System.Drawing.Size(104, 20)
        Me.txtDni.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(256, 94)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 24)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "Dni Paciente"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(400, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 23)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "dd/mm/aaaa"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(704, 507)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMedicacion)
        Me.GroupBox2.Controls.Add(Me.btnVer)
        Me.GroupBox2.Location = New System.Drawing.Point(560, 88)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(224, 56)
        Me.GroupBox2.TabIndex = 22
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Con el estudio seleccionado"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowNavigation = False
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.CaptionText = "Resultado de la Búsqueda"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 175)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(768, 326)
        Me.DataGrid1.TabIndex = 0
        Me.DataGrid1.TabStop = False
        '
        'ConsultaEstudios
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 534)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "ConsultaEstudios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Estudios"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrl As ArrayList
    Dim arrMedicos As ArrayList
    Dim catalogoEstudios As New CatalogoDeEstudios

    Dim myTable As DataTable = New DataTable("myTable")

    Private Sub ConsultaEstudios_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        arrl = catalogoEstudios.ObtenerEstudiosDeHoy

        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Médico Actuante", Type.GetType("System.String"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))

        Dim clMedSolicitante As New DataColumn("Médico Solicitante", Type.GetType("System.String"))
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.DateTime"))

        myTable.Columns.Add(clFechaEstudio)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clObraSocial)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clMedSolicitante)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "myTable"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        'DataGrid1.GridLineColor = Color.MediumPurple
        'DataGrid1.HeaderBackColor = Color.MediumPurple

        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "Fecha"
        TextCol0.HeaderText = "Fecha"
        TextCol0.Width = 70
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Paciente"
        TextCol.HeaderText = "Paciente"
        TextCol.Width = 115
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "Obra Social"
        TextCol5.HeaderText = "Obra Social"
        TextCol5.Width = 200
        ts1.GridColumnStyles.Add(TextCol5)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Práctica"
        TextCol3.HeaderText = "Práctica"
        TextCol3.Width = 150
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Médico Actuante"
        TextCol4.HeaderText = "Médico Actuante"
        TextCol4.Width = 95
        ts1.GridColumnStyles.Add(TextCol4)

        Dim TextCol6 As New DataGridTextBoxColumn
        TextCol6.MappingName = "Médico Solicitante"
        TextCol6.HeaderText = "Médico Solicitante"
        TextCol6.Width = 95
        ts1.GridColumnStyles.Add(TextCol6)

        DataGrid1.TableStyles.Add(ts1)

        btnImprimir.Enabled = False
        btnMedicacion.Enabled = False
        btnVer.Enabled = False

        CargarGrilla()
        CargarOtrosDatos()
    End Sub
    Private Sub CargarGrilla()
        Dim NewRow As DataRow
        Dim i As Integer
        If arrl.Count > 0 Then
            btnImprimir.Enabled = True
            btnMedicacion.Enabled = True
            btnVer.Enabled = True

            Dim est As Estudio
            For i = 0 To arrl.Count - 1
                'est = New Estudio
                est = arrl(i)
                NewRow = myTable.NewRow()
                NewRow("Paciente") = est.paciente.nombreCompleto
                NewRow("Fecha") = est.fechaEstudio
                NewRow("Obra Social") = est.obraSocial.ObraSocial
                NewRow("Práctica") = est.practica.Estudio
                NewRow("Médico Actuante") = est.medicoActuante.nombreCompleto
                NewRow("Médico Solicitante") = est.medicoSolicitante.nombreCompleto
                myTable.Rows.Add(NewRow)
            Next
        Else
            btnImprimir.Enabled = False
            btnMedicacion.Enabled = False
            btnVer.Enabled = False
        End If
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        'arrl = New ArrayList
        If validar() Then
            CargarArreglo()
        End If

    End Sub

    Private Function validar() As Boolean
        If Me.txtFecha.Text = "" And Me.txtNombre.Text = "" And Me.cmbMedicos.SelectedIndex = 0 And Me.txtDni.Text = "" And Me.txtApellidoPac.Text = "" Then
            MsgBox("Ingrese datos validos para efectuar la busqueda")
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub CargarOtrosDatos()
        Dim i As Integer
        Dim med As Medico
        Dim catalogoMedicos As New CatalogoDeMedicos
        arrMedicos = catalogoMedicos.TodosLosMedicos()
        cmbMedicos.Items.Add("Ningún médico seleccionado")
        For i = 0 To arrMedicos.Count - 1
            med = arrMedicos(i)
            cmbMedicos.Items.Add(med.nombreCompleto)

        Next
        cmbMedicos.SelectedIndex = 0
    End Sub

    Private Sub CargarArreglo()
        Dim bandera As Integer
        Dim cmbValor As Integer
        myTable.Clear()

        If cmbMedicos.SelectedIndex() = 0 Then
            bandera = 0
            cmbValor = 0
        Else
            If rdbMedAct.Checked = True Then
                bandera = 1
            End If
            If rdbMedSol.Checked = True Then
                bandera = 2
            End If
            If rdbMedAmbos.Checked = True Then
                bandera = 3
            End If
            cmbValor = arrMedicos(cmbMedicos.SelectedIndex - 1).idMedico
        End If

 

        arrl = catalogoEstudios.TraerEstudios(Me.txtApellidoPac.Text, txtNombre.Text, cmbValor, bandera, txtFecha.Text, , , txtDni.Text.Trim(), , "paciente")
        CargarGrilla()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        'Si se desea usar tamaños seteados, fijar el mismo para cada columna de la grilla
        Dim arrWidth(5) As Single
        arrWidth(0) = 80    'fecha
        arrWidth(1) = 100    'paciente
        arrWidth(2) = 190   'Obra social
        arrWidth(3) = 120   'Estudio
        arrWidth(4) = 95  'Med Act
        arrWidth(5) = 95  'Med Sol
        'Luego setiar el nuevo arreglo de tamaños
        DataGrid1.columnsWidth = arrWidth

        'Luego, se puede elegir que columnas no se desea imprimir
        Dim arrColumnsNotToPrint(1) As Integer
        arrColumnsNotToPrint(0) = 4
        arrColumnsNotToPrint(1) = 0
        'DataGrid1.columnNotToPrintIndexes = arrColumnsNotToPrint

        'Titulos
        DataGrid1.imprimirTitle = "Estudios"
        DataGrid1.imprimirSubTitleSuperior1 = "Fecha de impresión: " & CStr(Today.Now)
        'DataGrid1.imprimirSubTitleSuperior2 = "Subtitulo 2"
        'DataGrid1.imprimirSubTitleInferior1 = "Inferior 1"
        'DataGrid1.imprimirSubTitleInferior2 = "Observaciones: sadasda asdasdi asdfa sdfaskjdnh asdfkjal sdfajksdhfa sdfaks dfjaksdfh wwwww jkhw wwlw wlwkjwh lksjdf swjkhw wjkhsn wjkwhw wwbj kdbnfwk wlkjwh wjbsnkbwkj lwjkw wkjwbsnbw wjwb"

        'Finalmente, imprimir
        DataGrid1.imprimir(arrl.Count, 6)


    End Sub

    Private Sub btnMedicacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMedicacion.Click
        Dim i As Integer
        Dim est As Estudio

        i = DataGrid1.CurrentRowIndex
        est = arrl(i)

        Dim frm As New AgragarMedicacion(est)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim i As Integer
        Dim est As Estudio

        i = DataGrid1.CurrentRowIndex
        est = arrl(i)

        Dim frm As New NuevoEstudio(est)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txtFecha_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFecha.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub txtNombre_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNombre.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub txtDni_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDni.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.PerformClick()
        End If
    End Sub

    Private Sub txtApellidoPac_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtApellidoPac.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnBuscar.PerformClick()
        End If
    End Sub
End Class
