Imports CedirNegocios

Public Class EstudiosDeHoy
    Inherits System.Windows.Forms.Form
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'ma = m
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents btnMedicacion As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnSeleccionar As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents btnAgregarEstudio As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.btnEditar = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnMedicacion = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnAgregarEstudio = New System.Windows.Forms.Button
        Me.btnSeleccionar = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(16, 304)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(56, 24)
        Me.btnEditar.TabIndex = 1
        Me.btnEditar.Text = "Ver"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 40)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(728, 248)
        Me.DataGrid1.TabIndex = 2
        '
        'btnMedicacion
        '
        Me.btnMedicacion.Location = New System.Drawing.Point(80, 304)
        Me.btnMedicacion.Name = "btnMedicacion"
        Me.btnMedicacion.Size = New System.Drawing.Size(120, 23)
        Me.btnMedicacion.TabIndex = 4
        Me.btnMedicacion.Text = "Agregar Medicación"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(688, 304)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(56, 23)
        Me.btnCerrar.TabIndex = 5
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnAgregarEstudio
        '
        Me.btnAgregarEstudio.Location = New System.Drawing.Point(216, 304)
        Me.btnAgregarEstudio.Name = "btnAgregarEstudio"
        Me.btnAgregarEstudio.Size = New System.Drawing.Size(96, 23)
        Me.btnAgregarEstudio.TabIndex = 6
        Me.btnAgregarEstudio.Text = "Agregar Estudio"
        Me.btnAgregarEstudio.Visible = False
        '
        'btnSeleccionar
        '
        Me.btnSeleccionar.Location = New System.Drawing.Point(607, 304)
        Me.btnSeleccionar.Name = "btnSeleccionar"
        Me.btnSeleccionar.Size = New System.Drawing.Size(75, 23)
        Me.btnSeleccionar.TabIndex = 7
        Me.btnSeleccionar.Text = "Seleccionar"
        Me.btnSeleccionar.UseVisualStyleBackColor = True
        Me.btnSeleccionar.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 180000
        '
        'EstudiosDeHoy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(752, 349)
        Me.Controls.Add(Me.btnSeleccionar)
        Me.Controls.Add(Me.btnAgregarEstudio)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnMedicacion)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnEditar)
        Me.Name = "EstudiosDeHoy"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Estudios de Hoy"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region


    Dim arrl As New ArrayList
    Private m_estudio As Estudio
    Dim myTable As DataTable = New DataTable("myTable")


    Public Property currentEstudio() As Estudio
        Get
            Return m_estudio
        End Get
        Set(ByVal value As Estudio)
            m_estudio = value
        End Set
    End Property

    Private Sub EstudiosDeHoy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Timer1.Start()

        'muestro el boton agregar estudio solo para usuarios facturacion
        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser
        If cUsuario IsNot Nothing Then
            If cUsuario.belongToGroup("facturacion") Then
                Me.btnAgregarEstudio.Visible = True
            End If
        End If




        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clEdad As DataColumn = New DataColumn("Edad", Type.GetType("System.Int32"))
        Dim clTipoEstudio As New DataColumn("Tipo de Estudio", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Médico", Type.GetType("System.String"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))

        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clEdad)
        myTable.Columns.Add(clObraSocial)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)

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
        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Paciente"
        TextCol.HeaderText = "Paciente"
        TextCol.Width = 130
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Edad"
        TextCol2.HeaderText = "Edad"
        TextCol2.Width = 35
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Tipo de Estudio"
        TextCol3.HeaderText = "Tipo de Estudio"
        TextCol3.Width = 250
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Médico"
        TextCol4.HeaderText = "Médico"
        TextCol4.Width = 115
        ts1.GridColumnStyles.Add(TextCol4)

        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "Obra Social"
        TextCol5.HeaderText = "Obra Social"
        TextCol5.Width = 160
        ts1.GridColumnStyles.Add(TextCol5)

        DataGrid1.TableStyles.Add(ts1)

        Me.cargarGrilla()

    End Sub

    Private Sub cargarGrilla()
        Dim catalogoEstudios As New CedirNegocios.CatalogoDeEstudios
        Me.arrl.Clear()
        arrl = catalogoEstudios.ObtenerEstudiosDeHoy()

        Dim est As Estudio
        Dim NewRow As DataRow
        Dim i As Integer

        If arrl.Count = 0 Then
            btnMedicacion.Enabled = False
            btnEditar.Enabled = False
            btnAgregarEstudio.Enabled = False
        Else
            myTable.Rows.Clear() '
            btnMedicacion.Enabled = True
            btnEditar.Enabled = True
            btnAgregarEstudio.Enabled = True
            For i = 0 To arrl.Count - 1
                est = arrl(i)
                NewRow = myTable.NewRow()
                NewRow("Paciente") = est.paciente.nombreCompleto
                NewRow("Edad") = est.paciente.edad
                NewRow("Obra Social") = est.obraSocial.ObraSocial
                NewRow("Tipo de Estudio") = est.practica.Estudio
                NewRow("Médico") = est.medicoActuante.nombreCompleto
                myTable.Rows.Add(NewRow)
            Next
        End If
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable

        DataGrid1.CaptionText = "Estudios del " & Today

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim i As Integer
        Dim est As Estudio

        i = DataGrid1.CurrentRowIndex
        est = New Estudio
        est = arrl(i)

        Dim frm As New NuevoEstudio(est)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
        'Me.Close()
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

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Timer1.Stop()
        Me.Close()
    End Sub

    Private Sub btnAgregarEstudio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarEstudio.Click
        Dim i As Integer
        Dim est As Estudio
        i = DataGrid1.CurrentRowIndex
        est = arrl(i)

        Dim frm As New NuevoEstudio(est, True)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        Me.currentEstudio = New Estudio
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        Me.currentEstudio = arrl(i)
        Me.Hide()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.cargarGrilla()
    End Sub

    Private Sub EstudiosDeHoy_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        cargarGrilla()
    End Sub
End Class
