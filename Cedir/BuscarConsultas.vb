Imports CedirNegocios
Public Class BuscarConsultas
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents txtFecha As System.Windows.Forms.TextBox
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.txtFecha = New System.Windows.Forms.TextBox
        Me.txtPaciente = New System.Windows.Forms.TextBox
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 112)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(627, 200)
        Me.DataGrid1.TabIndex = 0
        '
        'txtFecha
        '
        Me.txtFecha.Location = New System.Drawing.Point(72, 24)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.TabIndex = 1
        Me.txtFecha.Text = ""
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(72, 64)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(160, 20)
        Me.txtPaciente.TabIndex = 2
        Me.txtPaciente.Text = ""
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.Location = New System.Drawing.Point(264, 22)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(296, 21)
        Me.cmbObraSocial.TabIndex = 3
        Me.cmbObraSocial.Text = "ComboBox1"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(264, 64)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnBuscar)
        Me.GroupBox1.Controls.Add(Me.cmbObraSocial)
        Me.GroupBox1.Controls.Add(Me.txtPaciente)
        Me.GroupBox1.Controls.Add(Me.txtFecha)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(632, 96)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Seleccione filtros de búsqueda"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(16, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Paciente:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(24, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 23)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Fecha: "
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(96, 320)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 6
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(16, 320)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(64, 23)
        Me.btnEliminar.TabIndex = 8
        Me.btnEliminar.Text = "Eliminar"
        '
        'BuscarConsultas
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(656, 352)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "BuscarConsultas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Consultas"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim catalogoEstudios As New CatalogoDeEstudios
    Dim myTable As DataTable = New DataTable("myTable")
    Dim arrConsultas As ArrayList
    Dim arrObraSocial As ArrayList
    Dim catalogoObraSocial As New CatalogoDeObrasSociales
    Private Sub BuscarConsultas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clFechaCon As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clCantidadCon As DataColumn = New DataColumn("Cantidad", Type.GetType("System.String"))
        Dim clPaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clNumeroOrdenCon As DataColumn = New DataColumn("Nro de Orden", Type.GetType("System.String"))

        myTable.Columns.Add(clFechaCon)
        myTable.Columns.Add(clCantidadCon)
        myTable.Columns.Add(clObraSocial)
        myTable.Columns.Add(clPaciente)
        myTable.Columns.Add(clNumeroOrdenCon)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "myTable"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "Fecha"
        TextCol0.HeaderText = "Fecha"
        TextCol0.Width = 70
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Cantidad"
        TextCol.HeaderText = "Cantidad"
        TextCol.Width = 60
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCo2 As New DataGridTextBoxColumn
        TextCo2.MappingName = "Obra Social"
        TextCo2.HeaderText = "Obra Social"
        TextCo2.Width = 250
        ts1.GridColumnStyles.Add(TextCo2)

        Dim TextCo3 As New DataGridTextBoxColumn
        TextCo3.MappingName = "Paciente"
        TextCo3.HeaderText = "Paciente"
        TextCo3.Width = 115
        ts1.GridColumnStyles.Add(TextCo3)


        Dim TextCo4 As New DataGridTextBoxColumn
        TextCo4.MappingName = "Nro de Orden"
        TextCo4.HeaderText = "Nro de Orden"
        TextCo4.Width = 74
        ts1.GridColumnStyles.Add(TextCo4)


        DataGrid1.TableStyles.Add(ts1)


        arrObraSocial = catalogoObraSocial.TodosLasObrasSociales
        Dim i As Integer
        Dim os As ObraSocial
        cmbObraSocial.Items.Add("Seleccione una Obra Social..")
        For i = 0 To arrObraSocial.Count - 1
            os = arrObraSocial(i)
            cmbObraSocial.Items.Add(os.ObraSocial)
        Next
        cmbObraSocial.SelectedIndex = 0

        'DataGrid1.CaptionText = "Consultas sin facturar"
        'arrConsultas = catalogoEstudios.traerConsultas("")
        CargarGrilla()
    End Sub

    Private Sub CargarGrilla()
        'Dim NewRow As DataRow
        'Dim i As Integer
        'If arrConsultas.Count > 0 Then
        '    Dim cConsulta As Consulta
        '    For i = 0 To arrConsultas.Count - 1
        '        cConsulta = arrConsultas(i)
        '        NewRow = myTable.NewRow()
        '        NewRow("Fecha") = cConsulta.fecha
        '        NewRow("Cantidad") = cConsulta.cantidad
        '        NewRow("Obra Social") = cConsulta.obraSocial.ObraSocial
        '        NewRow("Paciente") = cConsulta.paciente.nombreCompleto
        '        NewRow("Nro de Orden") = cConsulta.nroDeOrden
        '        myTable.Rows.Add(NewRow)
        '    Next
        'Else

        'End If
        'myTable.AcceptChanges()
        'DataGrid1.DataSource = myTable
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    'Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
    '    'validar que no este facturada, si lo esta, no se puede eliminar
    '    Dim i As Integer = DataGrid1.CurrentRowIndex
    '    Dim cConsulta As Consulta = arrConsultas(i)

    '    If cConsulta.facturacion.idPresentacion = 0 Then
    '        Dim r As Integer
    '        r = MsgBox("¿Esta seguro que desea eliminar la consulta seleccionada?", MsgBoxStyle.YesNo, "Eliminar Consulta")
    '        If r = 6 Then
    '            Dim resp As String = catalogoEstudios.borrarConsulta(cConsulta.id)
    '            If resp = "ok" Then
    '                MsgBox("La consulta se ha eliminado con éxito", MsgBoxStyle.OKOnly)
    '                filtrarConsultas()
    '            Else
    '                MsgBox("Se ha producido un error al intentar borrar. Cierre la ventana y vuelva a intentarlo", MsgBoxStyle.Critical)
    '            End If
    '        End If
    '    Else
    '        MsgBox("La consulta pertenece a una facturación y no puede borrarse. Quitela de la misma y vuelva a intentarlo", MsgBoxStyle.Critical)
    '    End If

    'End Sub

    'Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
    '    DataGrid1.CaptionText = "Resultado de la búsqueda"
    '    filtrarConsultas()
    'End Sub

    'Private Sub filtrarConsultas()
    '    Dim os As Integer
    '    If txtFecha.Text <> "" Then
    '        Dim convFecha As Date = CDate(txtFecha.Text)
    '    End If

    '    myTable.Clear()

    '    If cmbObraSocial.SelectedIndex = 0 Then
    '        os = 0
    '    Else
    '        Dim sObraSocial As ObraSocial = arrObraSocial(cmbObraSocial.SelectedIndex - 1)
    '        os = sObraSocial.idObraSocial
    '    End If

    '    arrConsultas = catalogoEstudios.traerConsultas(txtFecha.Text, txtPaciente.Text, os)

    '    CargarGrilla()
    'End Sub

End Class
