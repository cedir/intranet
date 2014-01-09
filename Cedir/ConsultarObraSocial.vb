Imports CedirNegocios
Public Class ConsultarObraSocial
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
    Friend WithEvents btnDetalles As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents txtObraSocial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnAranceles As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnDetalles = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.txtObraSocial = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.btnModificar = New System.Windows.Forms.Button
        Me.btnAranceles = New System.Windows.Forms.Button
        Me.btnAceptar = New System.Windows.Forms.Button
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnDetalles
        '
        Me.btnDetalles.Location = New System.Drawing.Point(712, 56)
        Me.btnDetalles.Name = "btnDetalles"
        Me.btnDetalles.Size = New System.Drawing.Size(48, 24)
        Me.btnDetalles.TabIndex = 9
        Me.btnDetalles.Text = "Ver"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(680, 368)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cerrar"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 88)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(752, 272)
        Me.DataGrid1.TabIndex = 12
        '
        'txtObraSocial
        '
        Me.txtObraSocial.Location = New System.Drawing.Point(16, 24)
        Me.txtObraSocial.Name = "txtObraSocial"
        Me.txtObraSocial.Size = New System.Drawing.Size(224, 20)
        Me.txtObraSocial.TabIndex = 13
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtObraSocial)
        Me.GroupBox2.Controls.Add(Me.btnFiltrar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(344, 64)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtrar"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(256, 24)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 16
        Me.btnFiltrar.Text = "Filtrar"
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(624, 56)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(72, 23)
        Me.btnModificar.TabIndex = 16
        Me.btnModificar.Text = "Modificar"
        '
        'btnAranceles
        '
        Me.btnAranceles.Location = New System.Drawing.Point(536, 56)
        Me.btnAranceles.Name = "btnAranceles"
        Me.btnAranceles.Size = New System.Drawing.Size(75, 23)
        Me.btnAranceles.TabIndex = 17
        Me.btnAranceles.Text = "Aranceles"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(582, 368)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 19
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        Me.btnAceptar.Visible = False
        '
        'ConsultarObraSocial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 416)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.btnAranceles)
        Me.Controls.Add(Me.btnModificar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDetalles)
        Me.Name = "ConsultarObraSocial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Obra Social"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrObraSocial As ArrayList
    Dim myTable As DataTable
    Dim catalogoObraSocial As New CatalogoDeObrasSociales

    Private Sub ConsultarObraSocial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myTable = New DataTable("myTable")

        Dim clo As DataColumn = New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clDireccion As New DataColumn("Dirección", Type.GetType("System.String"))
        Dim clCondicionFiscal As New DataColumn("Condición Fiscal", Type.GetType("System.String"))
        Dim clNroCuit As New DataColumn("Nro de Cuit", Type.GetType("System.String"))


        myTable.Columns.Add(clo)
        myTable.Columns.Add(clDireccion)
        myTable.Columns.Add(clCondicionFiscal)
        myTable.Columns.Add(clNroCuit)


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
        TextCol0.MappingName = "Obra Social"
        TextCol0.HeaderText = "Obra Social"
        TextCol0.Width = 290
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Dirección"
        TextCol.HeaderText = "Dirección"
        TextCol.Width = 155
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Condición Fiscal"
        TextCol3.HeaderText = "Condición Fiscal"
        TextCol3.Width = 155
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Nro de Cuit"
        TextCol4.HeaderText = "Nro de Cuit"
        TextCol4.Width = 95
        ts1.GridColumnStyles.Add(TextCol4)

        DataGrid1.TableStyles.Add(ts1)
        arrObraSocial = catalogoObraSocial.TodosLasObrasSociales()
        cargarGrilla()

    End Sub

    Private Sub cargarGrilla()
        Dim NewRow As DataRow
        Dim i As Integer

        myTable.Clear()
        Dim cObraSocial As ObraSocial
        For i = 0 To arrObraSocial.Count - 1
            cObraSocial = arrObraSocial(i)
            NewRow = myTable.NewRow()
            NewRow("Obra Social") = cObraSocial.ObraSocial
            NewRow("Dirección") = cObraSocial.direccion & " (" & cObraSocial.localidad & ")"
            NewRow("Condición Fiscal") = cObraSocial.CondicionFiscal
            NewRow("Nro de Cuit") = cObraSocial.nroCuit
            myTable.Rows.Add(NewRow)
        Next

        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable
        DataGrid1.CaptionText = "Cantidad: " & arrObraSocial.Count
        If arrObraSocial.Count = 0 Then
            btnDetalles.Enabled = False
            btnModificar.Enabled = False
        Else
            btnDetalles.Enabled = True
            btnModificar.Enabled = True
        End If
    End Sub

    Private Sub btnDetalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalles.Click
        Dim os As ObraSocial
        os = arrObraSocial(DataGrid1.CurrentRowIndex)

        Dim frm As New DetalleObraSocial(os)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub txtObraSocial_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtObraSocial.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            arrObraSocial = catalogoObraSocial.TodosLasObrasSociales(txtObraSocial.Text)
            cargarGrilla()
        End If

    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        arrObraSocial = catalogoObraSocial.TodosLasObrasSociales(txtObraSocial.Text)
        cargarGrilla()
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        Dim os As ObraSocial
        os = arrObraSocial(DataGrid1.CurrentRowIndex)

        Dim frm As New ABMObraSocial(os)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub


    Private Sub DataGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick
        Dim os As ObraSocial
        os = arrObraSocial(DataGrid1.CurrentRowIndex)

        Dim frm As New DetalleObraSocial(os)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnAranceles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAranceles.Click
        Dim os As ObraSocial
        os = arrObraSocial(DataGrid1.CurrentRowIndex)

        Dim frm As New ObraSocialABMArancel(os)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    'Devolvemos la obra social seleccionada en el datagrid
    Public Sub getOS()
        Try
            Dim os As New ObraSocial
            os = arrObraSocial(DataGrid1.CurrentRowIndex)
            CType(Me.Owner, frmComprobanteNuevo).CargarObjeto(os)
        Catch
            MsgBox("Por favor, primero seleccione una obra social", MsgBoxStyle.OkOnly, "No se ha seleccionado una obra social")
        End Try

    End Sub

    'Solo visible si el formulario fue llamado desde FacturasNueva
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Me.getOS()
        Me.Close()

    End Sub

End Class
