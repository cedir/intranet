Imports CedirNegocios
Public Class DetalleObraSocial
    Inherits System.Windows.Forms.Form
    Dim cObraSocial As ObraSocial
    Dim myTable As DataTable
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtValorAproxPension As System.Windows.Forms.TextBox
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
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAranceles As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnAranceles = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.txtValorAproxPension = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(30, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(538, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(30, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(458, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(30, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(386, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Label3"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(24, 152)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(544, 80)
        Me.txtObservaciones.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(30, 88)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(386, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(30, 112)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(386, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Label5"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(254, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 16)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Observaciones"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(435, 596)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 20)
        Me.btnImprimir.TabIndex = 9
        Me.btnImprimir.Text = "Imprimir"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGrid1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 256)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(584, 216)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Aranceles"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(523, 596)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 20)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.Text = "Cerrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtObservaciones)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 8)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(584, 240)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Obra Social"
        '
        'btnAranceles
        '
        Me.btnAranceles.Location = New System.Drawing.Point(339, 596)
        Me.btnAranceles.Name = "btnAranceles"
        Me.btnAranceles.Size = New System.Drawing.Size(72, 20)
        Me.btnAranceles.TabIndex = 16
        Me.btnAranceles.Text = "Aranceles"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.txtValorAproxPension)
        Me.GroupBox3.Location = New System.Drawing.Point(16, 478)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(584, 53)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Valor de Pensión de sala"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(552, 184)
        Me.DataGrid1.TabIndex = 0
        '
        'txtValorAproxPension
        '
        Me.txtValorAproxPension.Location = New System.Drawing.Point(155, 16)
        Me.txtValorAproxPension.Name = "txtValorAproxPension"
        Me.txtValorAproxPension.Size = New System.Drawing.Size(124, 20)
        Me.txtValorAproxPension.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(121, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Valor aprox. pension ... :"
        '
        'DetalleObraSocial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(618, 637)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnAranceles)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "DetalleObraSocial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DetalleObraSocial"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim saveChanges As Boolean = False
    Dim defaultObservacionesOS As String
    Private Sub DetalleObraSocial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        myTable = New DataTable("myTable")

        Dim clest As New DataColumn("Estudio", Type.GetType("System.String"))
        Dim clcod As New DataColumn("Código", Type.GetType("System.String"))
        Dim clprecio As New DataColumn("Precio", Type.GetType("System.Double"))
        Dim clFecha As New DataColumn("Fecha", Type.GetType("System.String"))

        myTable.Columns.Add(clest)
        myTable.Columns.Add(clcod)
        myTable.Columns.Add(clFecha)
        myTable.Columns.Add(clprecio)

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
        TextCol0.Width = 335
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Código"
        TextCol.HeaderText = "Código"
        TextCol.Width = 51
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Precio"
        TextCol3.HeaderText = "Precio"
        TextCol3.Width = 45
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Fecha"
        TextCol4.HeaderText = "Fecha"
        TextCol4.Width = 65
        ts1.GridColumnStyles.Add(TextCol4)

        DataGrid1.TableStyles.Add(ts1)

        Label1.Text = cObraSocial.ObraSocial
        Label2.Text = "Dirección: " & cObraSocial.direccion & " - (" & cObraSocial.CodigoPostal & " - " & cObraSocial.localidad & ")"
        Label3.Text = "Teléfono: " & cObraSocial.tel
        Label4.Text = "Nro de cuit: " & cObraSocial.nroCuit
        Label5.Text = "Condición fiscal: " & cObraSocial.CondicionFiscal
        txtObservaciones.Text = cObraSocial.observaciones

        Me.Text = cObraSocial.ObraSocial
        defaultObservacionesOS = cObraSocial.observaciones
        Me.txtValorAproxPension.Text = cObraSocial.valorAproximadoDePension.ToString()
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
            NewRow("Código") = cArancel.practica.codigoMedico
            NewRow("Fecha") = cArancel.fecha
            NewRow("Precio") = Math.Round(cArancel.Precio, 2)
            myTable.Rows.Add(NewRow)
        Next
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub DetalleObraSocial_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If defaultObservacionesOS <> txtObservaciones.Text Or Me.txtValorAproxPension.Text <> "" Then
            Me.actualizarDatosOS()

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

    Private Sub btnAranceles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAranceles.Click
        Dim frm As New ObraSocialABMArancel(cObraSocial)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub
    Private Sub actualizarDatosOS()
        Dim resp As String
        If defaultObservacionesOS <> txtObservaciones.Text Then
            cObraSocial.observaciones = txtObservaciones.Text
            resp = cObraSocial.actualizaDetalle()
            If resp = "ok" Then
                MsgBox("Los cambios de observación han guardado")
            End If
        End If

        If Me.txtValorAproxPension.Text <> cObraSocial.valorAproximadoDePension Then
            cObraSocial.valorAproximadoDePension = txtValorAproxPension.Text
            resp = cObraSocial.actualizaValorAproximadoPension()
            If resp = "ok" Then
                MsgBox("Los cambios de pension aprox. se han guardado")
            End If
        End If


    End Sub
End Class
