Imports CedirNegocios
Public Class AnestesistasNuevoPago
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
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbAnestesistas As System.Windows.Forms.ComboBox
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.cmbMeses = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbAnestesistas = New System.Windows.Forms.ComboBox
        Me.btnEditar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAno = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblTotal = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(328, 48)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 2
        Me.btnFiltrar.Text = "Filtrar"
        '
        'cmbMeses
        '
        Me.cmbMeses.Location = New System.Drawing.Point(132, 16)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(136, 21)
        Me.cmbMeses.TabIndex = 4
        Me.cmbMeses.Text = "ComboBox3"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(8, 54)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 16)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Médico Anestesiólogo:"
        '
        'cmbAnestesistas
        '
        Me.cmbAnestesistas.Location = New System.Drawing.Point(128, 53)
        Me.cmbAnestesistas.Name = "cmbAnestesistas"
        Me.cmbAnestesistas.Size = New System.Drawing.Size(144, 21)
        Me.cmbAnestesistas.TabIndex = 33
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(688, 64)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(56, 24)
        Me.btnEditar.TabIndex = 35
        Me.btnEditar.Text = "Ver"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(288, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Año:"
        '
        'cmbAno
        '
        Me.cmbAno.Items.AddRange(New Object() {"2010", "2011"})
        Me.cmbAno.Location = New System.Drawing.Point(328, 16)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(80, 21)
        Me.cmbAno.TabIndex = 36
        Me.cmbAno.Text = "ComboBox2"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(96, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 23)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Mes:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbMeses)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbAno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbAnestesistas)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(416, 80)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar estudios"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(624, 400)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(120, 23)
        Me.lblTotal.TabIndex = 40
        Me.lblTotal.Text = "Total: $0"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(8, 456)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 41
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(104, 456)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 42
        Me.btnCerrar.Text = "Cerrar"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(8, 400)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(576, 48)
        Me.txtObservaciones.TabIndex = 43
        Me.txtObservaciones.Text = "Observaciones:"
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 96)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(744, 296)
        Me.DataGrid1.TabIndex = 0
        '
        'AnestesistasNuevoPago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(768, 488)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "AnestesistasNuevoPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pago de Anestesistas"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Dim myTable As DataTable = New DataTable("myTable")

    Dim catalogoEstudios As New CatalogoDeEstudios
    Dim arrEstudios As ArrayList
    Dim arrMeses(12) As String
    Dim arrAnestesistas As ArrayList
    Dim com As String = """"

    Private Sub AnestesistasNuevoPago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        'Dim clMedActuante As New DataColumn("Actuante", Type.GetType("System.String"))
        'Dim clMedSolicitante As New DataColumn("Solicitante", Type.GetType("System.String"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.String"))
        'Dim clFechaCobro As New DataColumn("Fecha Cobro", Type.GetType("System.DateTime"))
        Dim clImporte As New DataColumn("Importe", Type.GetType("System.String"))
        'Dim clImporteRealCobrado As New DataColumn("Cobrado", Type.GetType("System.String"))


        myTable.Columns.Add(clFechaEstudio)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clObraSocial)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clImporte)




        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "myTable"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "Fecha"
        TextCol1.HeaderText = "Fecha"
        TextCol1.Width = 65
        ts1.GridColumnStyles.Add(TextCol1)
        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Paciente"
        TextCol2.HeaderText = "Paciente"
        TextCol2.Width = 110
        ts1.GridColumnStyles.Add(TextCol2)
        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Obra Social"
        TextCol3.HeaderText = "Obra Social"
        TextCol3.Width = 135
        ts1.GridColumnStyles.Add(TextCol3)
        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Práctica"
        TextCol4.HeaderText = "Práctica"
        TextCol4.Width = 300
        ts1.GridColumnStyles.Add(TextCol4)
        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "Importe"
        TextCol5.HeaderText = "Importe"
        TextCol5.Width = 65
        ts1.GridColumnStyles.Add(TextCol5)


        DataGrid1.TableStyles.Add(ts1)




        arrMeses(0) = "Enero"
        cmbMeses.Items.Add(arrMeses(0))
        arrMeses(1) = "Febrero"
        cmbMeses.Items.Add(arrMeses(1))
        arrMeses(2) = "Marzo"
        cmbMeses.Items.Add(arrMeses(2))
        arrMeses(3) = "Abril"
        cmbMeses.Items.Add(arrMeses(3))
        arrMeses(4) = "Mayo"
        cmbMeses.Items.Add(arrMeses(4))
        arrMeses(5) = "Junio"
        cmbMeses.Items.Add(arrMeses(5))
        arrMeses(6) = "Julio"
        cmbMeses.Items.Add(arrMeses(6))
        arrMeses(7) = "Agosto"
        cmbMeses.Items.Add(arrMeses(7))
        arrMeses(8) = "Septiembre"
        cmbMeses.Items.Add(arrMeses(8))
        arrMeses(9) = "Octubre"
        cmbMeses.Items.Add(arrMeses(9))
        arrMeses(10) = "Noviembre"
        cmbMeses.Items.Add(arrMeses(10))
        arrMeses(11) = "Diciembre"
        cmbMeses.Items.Add(arrMeses(11))
        cmbMeses.SelectedIndex = 0

        cmbAno.Items.Add("2007")
        cmbAno.Items.Add("2008")
        cmbAno.Items.Add("2009")
        cmbAno.Items.Add("2010")
        cmbAno.Items.Add("2011")
        cmbAno.Items.Add("2012")

        cmbAno.SelectedItem = CStr(Today.Year)


        Dim catalogoMedicos As New CatalogoDeMedicos

        Dim anestesista As Medico
        arrAnestesistas = catalogoMedicos.TodosLosAnestesistas()
        cmbAnestesistas.Items.Clear()
        For i As Integer = 0 To arrAnestesistas.Count - 1
            anestesista = arrAnestesistas(i)
            cmbAnestesistas.Items.Add(anestesista.nombreCompleto)

        Next
        cmbAnestesistas.SelectedIndex = 2
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim mes As String = "01"

        If cmbMeses.Text = "Enero" Then
            mes = ("01")
        ElseIf cmbMeses.Text = "Febrero" Then
            mes = ("02")
        ElseIf cmbMeses.Text = "Marzo" Then
            mes = ("03")
        ElseIf cmbMeses.Text = "Abril" Then
            mes = ("04")
        ElseIf cmbMeses.Text = "Mayo" Then
            mes = ("05")
        ElseIf cmbMeses.Text = "Junio" Then
            mes = ("06")
        ElseIf cmbMeses.Text = "Julio" Then
            mes = ("07")
        ElseIf cmbMeses.Text = "Agosto" Then
            mes = ("08")
        ElseIf cmbMeses.Text = "Septiembre" Then
            mes = ("09")
        ElseIf cmbMeses.Text = "Octubre" Then
            mes = ("10")
        ElseIf cmbMeses.Text = "Noviembre" Then
            mes = ("11")
        ElseIf cmbMeses.Text = "Diciembre" Then
            mes = ("12")
        End If

        Dim ano As String = cmbAno.Text

        Dim sMedicoAnestesista As Medico = arrAnestesistas(cmbAnestesistas.SelectedIndex)
        ' arrEstudios = catalogoEstudios.traerEstudiosArancelados(" where" & com & "sePresentaPorARA" & com & " = 1 and " & com & "idAnestesista" & com & " = " & sMedicoAnestesista.idMedico & " and  date_part('month'," & com & "fechaEstudio" & com & ") = " & mes & " and  date_part('year'," & com & "fechaEstudio" & com & ") = " & ano)
        arrEstudios = catalogoEstudios.getEstudiosPorAnestesista(" where" & com & "idAnestesista" & com & " = " & sMedicoAnestesista.idMedico & " and  date_part('month'," & com & "fechaEstudio" & com & ") = " & mes & " and  date_part('year'," & com & "fechaEstudio" & com & ") = " & Me.cmbAno.SelectedItem)
        If arrEstudios.Count > 0 Then
            Dim calcH As New CalculadorHonorariosAnestesistas
            calcH.getHonorarios(arrEstudios)

            CargarGrilla()
        End If
       
    End Sub
    Private Sub CargarGrilla()
        myTable.Clear()

        Dim total As Decimal

        Dim NewRow As DataRow
        Dim i As Integer

        Dim est As Estudio
        For i = 0 To arrEstudios.Count - 1
            est = arrEstudios(i)
            NewRow = myTable.NewRow()

            Dim importe As Single
            If est.ArancelAnestesia = 0 Then
                importe = 40
            Else
                importe = est.ArancelAnestesia
            End If


            NewRow("Obra Social") = est.obraSocial.ObraSocial
            NewRow("Práctica") = est.practica.Estudio
            NewRow("Paciente") = est.paciente.nombreCompleto
            NewRow("Fecha") = est.fechaEstudio
            NewRow("Importe") = importe

            total += CDec(importe)

            myTable.Rows.Add(NewRow)
        Next

        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable

        lblTotal.Text = "Total: $" & total

    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim i As Integer
        Dim est As Estudio

        i = DataGrid1.CurrentRowIndex
        est = New Estudio
        est = arrEstudios(i)

        Dim frm As New NuevoEstudio(est)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Si se desea usar tamaños seteados, fijar el mismo para cada columna de la grilla
        Dim arrWidth(5) As Single
        arrWidth(0) = 80    'fecha
        arrWidth(1) = 100    'paciente
        arrWidth(2) = 190   'Obra social
        arrWidth(3) = 120   'Estudio
        arrWidth(4) = 95  'Importe
        'Luego setiar el nuevo arreglo de tamaños
        DataGrid1.columnsWidth = arrWidth


        'Titulos
        DataGrid1.imprimirTitle = "Retención de anestesia"
        DataGrid1.imprimirSubTitleSuperior1 = "Médico: " & cmbAnestesistas.Text
        DataGrid1.imprimirSubTitleSuperior2 = "Mes: " & cmbMeses.Text & " del " & cmbAno.Text
        DataGrid1.imprimirSubTitleInferior1 = lblTotal.Text
        DataGrid1.imprimirSubTitleInferior2 = txtObservaciones.Text
        'Finalmente, imprimir
        DataGrid1.imprimir(arrEstudios.Count, 5)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class
