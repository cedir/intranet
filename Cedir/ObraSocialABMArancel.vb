Imports CedirNegocios
Public Class ObraSocialABMArancel
    Inherits System.Windows.Forms.Form
    Dim cObraSocial As ObraSocial
    Dim myTable As DataTable
    'Dim catalogoObraSocial As New CatalogoDeObrasSociales
    Dim arrPracticas As ArrayList
    Dim arrAranceles As ArrayList
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal obraSocial As ObraSocial)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cObraSocial = obraSocial
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
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPracticas As System.Windows.Forms.ComboBox
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtPrecio As System.Windows.Forms.TextBox
    Friend WithEvents txtAnestesia As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbPracticas = New System.Windows.Forms.ComboBox
        Me.txtPrecio = New System.Windows.Forms.TextBox
        Me.txtAnestesia = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 154)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(648, 216)
        Me.DataGrid1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(16, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(688, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'cmbPracticas
        '
        Me.cmbPracticas.Location = New System.Drawing.Point(120, 48)
        Me.cmbPracticas.Name = "cmbPracticas"
        Me.cmbPracticas.Size = New System.Drawing.Size(464, 21)
        Me.cmbPracticas.TabIndex = 2
        Me.cmbPracticas.Text = "ComboBox1"
        '
        'txtPrecio
        '
        Me.txtPrecio.Location = New System.Drawing.Point(120, 80)
        Me.txtPrecio.Name = "txtPrecio"
        Me.txtPrecio.TabIndex = 3
        Me.txtPrecio.Text = ""
        '
        'txtAnestesia
        '
        Me.txtAnestesia.Location = New System.Drawing.Point(320, 80)
        Me.txtAnestesia.Name = "txtAnestesia"
        Me.txtAnestesia.TabIndex = 5
        Me.txtAnestesia.Text = ""
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(64, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Importe:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(248, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Anestesia:"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(120, 112)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.TabIndex = 11
        Me.btnGuardar.Text = "Guardar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(480, 392)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.TabIndex = 12
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(576, 392)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 15
        Me.btnCerrar.Text = "Cerrar"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(63, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 16)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Práctica:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(392, 40)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "*(1) Nota: importe es el arancel para facturar a la obra social. Anestesia es el " & _
        "importe fijado por el ARA para el cobro al anestesista."
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(432, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 23)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "*(1)"
        '
        'ObraSocialABMArancel
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(664, 424)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtAnestesia)
        Me.Controls.Add(Me.txtPrecio)
        Me.Controls.Add(Me.cmbPracticas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "ObraSocialABMArancel"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aranceles"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub ObraSocialABMArancel_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        myTable = New DataTable("myTable")

        Dim clest As New DataColumn("Estudio", Type.GetType("System.String"))
        Dim clprecio As New DataColumn("Precio", Type.GetType("System.Double"))
        Dim clFecha As New DataColumn("Fecha", Type.GetType("System.String"))


        myTable.Columns.Add(clest)
        myTable.Columns.Add(clprecio)
        myTable.Columns.Add(clFecha)

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
        TextCol0.MappingName = "Estudio"
        TextCol0.HeaderText = "Estudio"
        TextCol0.Width = 450
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Precio"
        TextCol3.HeaderText = "Precio"
        TextCol3.Width = 50
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol8 As New DataGridTextBoxColumn
        TextCol8.MappingName = "Fecha"
        TextCol8.HeaderText = "Fecha"
        TextCol8.Width = 65
        ts1.GridColumnStyles.Add(TextCol8)

        DataGrid1.TableStyles.Add(ts1)

        Label1.Text = cObraSocial.ObraSocial
        
        Dim cPractica As Practica
        Dim i As Integer
        Dim catalogoPracticas As New CatalogoDePracticas
        arrPracticas = catalogoPracticas.getPracticas
        cmbPracticas.Items.Add("Seleccione")
        For i = 0 To arrPracticas.Count - 1
            cPractica = arrPracticas(i)
            cmbPracticas.Items.Add(cPractica.Estudio)
        Next
        cmbPracticas.SelectedIndex = 0

        cargarGrilla()
    End Sub
    Private Sub cargarGrilla()
        Dim NewRow As DataRow
        Dim i As Integer

        arrAranceles = cObraSocial.getAranaceles
        myTable.Clear()
        Dim cArancel As Arancel
        For i = 0 To arrAranceles.Count - 1
            cArancel = arrAranceles(i)
            NewRow = myTable.NewRow()
            NewRow("Estudio") = cArancel.practica.Estudio
            NewRow("Fecha") = cArancel.fecha
            NewRow("Precio") = Math.Round(cArancel.precio, 2)
            myTable.Rows.Add(NewRow)
        Next


        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim resp As String
        If txtPrecio.Text <> "" And txtAnestesia.Text <> "" And cmbPracticas.SelectedIndex > 0 Then
            Dim cPractica As Practica = arrPracticas(cmbPracticas.SelectedIndex - 1)
            resp = cObraSocial.createOrUpdateArancel(cPractica, txtPrecio.Text, txtAnestesia.Text)
            If resp = "ok" Then
                MsgBox("Los cambios se han guardado")
                cargarGrilla()
            End If
        Else : MsgBox("Error: ningun dato puede estar sin completar")
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        DataGrid1.imprimirTitle = cObraSocial.ObraSocial
        DataGrid1.imprimirSubTitleSuperior1 = "Dirección: " & cObraSocial.direccion & " (" & cObraSocial.CodigoPostal & " - " & cObraSocial.localidad & ")"
        DataGrid1.imprimirSubTitleSuperior2 = "Teléfono: " & cObraSocial.tel
        DataGrid1.imprimirSubTitleSuperior3 = "Cuit: " & cObraSocial.nroCuit & " Condición fiscal: " & cObraSocial.CondicionFiscal
        DataGrid1.imprimirSubTitleInferior1 = "Fecha de impresión: " & CStr(Today.Now)
        DataGrid1.imprimir(arrAranceles.Count, 4)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


    Private Sub cmbPracticas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbPracticas.SelectedIndexChanged
        txtPrecio.Text = ""
        txtAnestesia.Text = ""

        If cmbPracticas.SelectedIndex = 0 Then
            Exit Sub
        End If


        Dim cPractica As Practica = arrPracticas(cmbPracticas.SelectedIndex - 1)
        Dim cArancel As Arancel
        For i As Integer = 0 To arrAranceles.Count - 1
            cArancel = arrAranceles(i)
            If cArancel.practica.idEstudio = cPractica.idEstudio Then
                txtPrecio.Text = cArancel.precio
                Exit For
            End If
        Next


    End Sub
End Class
