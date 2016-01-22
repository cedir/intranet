Imports CedirNegocios
Public Class BuscarPresentacion
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
    Friend WithEvents btnFacturar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnEliminar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnCobro As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents grpComprobante As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNroRemito As System.Windows.Forms.TextBox
    Friend WithEvents lblNroComprobante As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkEstado As System.Windows.Forms.CheckBox
    Friend WithEvents lblTotalPresentaciones As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbAnio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTipoPresentacion As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnFacturar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbAnio = New System.Windows.Forms.ComboBox
        Me.chkEstado = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnCobro = New System.Windows.Forms.Button
        Me.btnEliminar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.cmbTipoPresentacion = New System.Windows.Forms.ComboBox
        Me.grpComprobante = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtNroRemito = New System.Windows.Forms.TextBox
        Me.lblNroComprobante = New System.Windows.Forms.Label
        Me.txtNroComprobante = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox
        Me.lblTotalPresentaciones = New System.Windows.Forms.Label
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grpComprobante.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnFacturar
        '
        Me.btnFacturar.Location = New System.Drawing.Point(16, 32)
        Me.btnFacturar.Name = "btnFacturar"
        Me.btnFacturar.Size = New System.Drawing.Size(56, 24)
        Me.btnFacturar.TabIndex = 1
        Me.btnFacturar.Text = "Ver"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbAnio)
        Me.GroupBox3.Controls.Add(Me.chkEstado)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cmbObraSocial)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 99)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(749, 106)
        Me.GroupBox3.TabIndex = 15
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Presentación"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Año :"
        '
        'cmbAnio
        '
        Me.cmbAnio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAnio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAnio.FormattingEnabled = True
        Me.cmbAnio.Location = New System.Drawing.Point(95, 52)
        Me.cmbAnio.Name = "cmbAnio"
        Me.cmbAnio.Size = New System.Drawing.Size(107, 21)
        Me.cmbAnio.TabIndex = 11
        '
        'chkEstado
        '
        Me.chkEstado.AutoSize = True
        Me.chkEstado.Checked = True
        Me.chkEstado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkEstado.Location = New System.Drawing.Point(122, 85)
        Me.chkEstado.Name = "chkEstado"
        Me.chkEstado.Size = New System.Drawing.Size(122, 17)
        Me.chkEstado.TabIndex = 9
        Me.chkEstado.Text = "Pendientes/Abiertas"
        Me.chkEstado.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Estado presentacion:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(8, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Obra Social:"
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.Location = New System.Drawing.Point(95, 20)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(596, 21)
        Me.cmbObraSocial.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(7, 211)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 24)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnCobro)
        Me.GroupBox2.Controls.Add(Me.btnEliminar)
        Me.GroupBox2.Controls.Add(Me.btnFacturar)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 556)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(232, 64)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Con la presentación seleccionada"
        '
        'btnCobro
        '
        Me.btnCobro.Location = New System.Drawing.Point(85, 32)
        Me.btnCobro.Name = "btnCobro"
        Me.btnCobro.Size = New System.Drawing.Size(56, 23)
        Me.btnCobro.TabIndex = 3
        Me.btnCobro.Text = "Cobro"
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(153, 32)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(60, 23)
        Me.btnEliminar.TabIndex = 2
        Me.btnEliminar.Text = "Eliminar"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(590, 588)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(56, 23)
        Me.btnImprimir.TabIndex = 4
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(662, 588)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(48, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmbTipoPresentacion)
        Me.GroupBox4.Location = New System.Drawing.Point(7, 12)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(225, 81)
        Me.GroupBox4.TabIndex = 19
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Tipo de Presentacion"
        '
        'cmbTipoPresentacion
        '
        Me.cmbTipoPresentacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipoPresentacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoPresentacion.FormattingEnabled = True
        Me.cmbTipoPresentacion.Items.AddRange(New Object() {"Directa", "AMR", "Sin Definir"})
        Me.cmbTipoPresentacion.Location = New System.Drawing.Point(11, 21)
        Me.cmbTipoPresentacion.Name = "cmbTipoPresentacion"
        Me.cmbTipoPresentacion.Size = New System.Drawing.Size(202, 21)
        Me.cmbTipoPresentacion.TabIndex = 10
        '
        'grpComprobante
        '
        Me.grpComprobante.Controls.Add(Me.Label1)
        Me.grpComprobante.Controls.Add(Me.txtNroRemito)
        Me.grpComprobante.Controls.Add(Me.lblNroComprobante)
        Me.grpComprobante.Controls.Add(Me.txtNroComprobante)
        Me.grpComprobante.Controls.Add(Me.Label4)
        Me.grpComprobante.Controls.Add(Me.cmbTipoComprobante)
        Me.grpComprobante.Location = New System.Drawing.Point(239, 12)
        Me.grpComprobante.Name = "grpComprobante"
        Me.grpComprobante.Size = New System.Drawing.Size(517, 81)
        Me.grpComprobante.TabIndex = 18
        Me.grpComprobante.TabStop = False
        Me.grpComprobante.Text = "Comprobante"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(268, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Número  de remito :"
        '
        'txtNroRemito
        '
        Me.txtNroRemito.Location = New System.Drawing.Point(373, 18)
        Me.txtNroRemito.Name = "txtNroRemito"
        Me.txtNroRemito.Size = New System.Drawing.Size(130, 20)
        Me.txtNroRemito.TabIndex = 8
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.AutoSize = True
        Me.lblNroComprobante.Location = New System.Drawing.Point(6, 55)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.Size = New System.Drawing.Size(53, 13)
        Me.lblNroComprobante.TabIndex = 4
        Me.lblNroComprobante.Text = "Número  :"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(61, 52)
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(180, 20)
        Me.txtNroComprobante.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Tipo  :"
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipoComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoComprobante.FormattingEnabled = True
        Me.cmbTipoComprobante.Items.AddRange(New Object() {"", "Factura", "Liquidacion"})
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(61, 19)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(180, 21)
        Me.cmbTipoComprobante.TabIndex = 7
        '
        'lblTotalPresentaciones
        '
        Me.lblTotalPresentaciones.AutoSize = True
        Me.lblTotalPresentaciones.Location = New System.Drawing.Point(587, 544)
        Me.lblTotalPresentaciones.Name = "lblTotalPresentaciones"
        Me.lblTotalPresentaciones.Size = New System.Drawing.Size(109, 13)
        Me.lblTotalPresentaciones.TabIndex = 20
        Me.lblTotalPresentaciones.Text = "TotalPResentaciones"
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(7, 241)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(752, 300)
        Me.DataGrid1.TabIndex = 0
        '
        'BuscarPresentacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(773, 632)
        Me.Controls.Add(Me.lblTotalPresentaciones)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grpComprobante)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.DataGrid1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnImprimir)
        Me.Name = "BuscarPresentacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Presentación"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.grpComprobante.ResumeLayout(False)
        Me.grpComprobante.PerformLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim myTable As DataTable = New DataTable("myTable")
    Dim catalogoPresentaciones As New CatalogoDePresentaciones
    Dim arrPresentaciones As ArrayList
    Dim arrObraSocial As ArrayList

    Private Sub BuscarPresentacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        actualizarListadoFacturaciones = False

        Dim clId As DataColumn = New DataColumn("ID", Type.GetType("System.Int64"))
        Dim clFecha As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clNombreOS As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clNroComprobante As DataColumn = New DataColumn("Nro Comprobante", Type.GetType("System.String"))
        Dim clTipoComprobante As DataColumn = New DataColumn("Tipo Comprobante", Type.GetType("System.String"))
        Dim clSubTipo As DataColumn = New DataColumn("SubTipo", Type.GetType("System.String"))
        Dim clCobrado As DataColumn = New DataColumn("Estado", Type.GetType("System.String"))
        Dim clTotal As DataColumn = New DataColumn("Total", Type.GetType("System.Single"))

        myTable.Columns.Add(clId)
        myTable.Columns.Add(clFecha)
        myTable.Columns.Add(clNombreOS)
        myTable.Columns.Add(clNroComprobante)
        myTable.Columns.Add(clTipoComprobante)
        myTable.Columns.Add(clSubTipo)
        myTable.Columns.Add(clCobrado)
        myTable.Columns.Add(clTotal)

        Dim cTs1 As New DataGridTableStyle
        cTs1.MappingName = "myTable"
        cTs1.BackColor = Color.LightGray
        cTs1.ForeColor = Color.SlateBlue
        cTs1.AlternatingBackColor = Color.White
        cTs1.AllowSorting = False

        cTs1.HeaderForeColor = Color.MediumSlateBlue
        cTs1.HeaderBackColor = Color.WhiteSmoke
        cTs1.GridLineColor = Color.MediumPurple

        Dim cTextCol2 As New DataGridTextBoxColumn
        cTextCol2.MappingName = "ID"
        cTextCol2.HeaderText = "ID"
        cTextCol2.Width = 40
        cTs1.GridColumnStyles.Add(cTextCol2)
        Dim cTextCol3 As New DataGridTextBoxColumn
        cTextCol3.MappingName = "Fecha"
        cTextCol3.HeaderText = "Fecha"
        cTextCol3.Width = 65
        cTs1.GridColumnStyles.Add(cTextCol3)
        Dim cTextCol4 As New DataGridTextBoxColumn
        cTextCol4.MappingName = "Obra Social"
        cTextCol4.HeaderText = "Obra Social"
        cTextCol4.Width = 310
        cTs1.GridColumnStyles.Add(cTextCol4)
        Dim cTextCol5 As New DataGridTextBoxColumn
        cTextCol5.MappingName = "Nro Comprobante"
        cTextCol5.HeaderText = "Nro Comprobante"
        cTextCol5.Width = 55
        cTs1.GridColumnStyles.Add(cTextCol5)
        Dim cTextCol6 As New DataGridTextBoxColumn
        cTextCol6.MappingName = "Tipo Comprobante"
        cTextCol6.HeaderText = "Tipo Comprobante"
        cTextCol6.Width = 68
        cTs1.GridColumnStyles.Add(cTextCol6)
        Dim cTextCol7 As New DataGridTextBoxColumn
        cTextCol7.MappingName = "SubTipo"
        cTextCol7.HeaderText = "SubTipo"
        cTextCol7.Width = 30
        cTs1.GridColumnStyles.Add(cTextCol7)
        Dim cTextCol8 As New DataGridTextBoxColumn
        cTextCol8.MappingName = "Estado"
        cTextCol8.HeaderText = "Estado"
        cTextCol8.Width = 70
        cTs1.GridColumnStyles.Add(cTextCol8)
        Dim cTextCol9 As New DataGridTextBoxColumn
        cTextCol9.MappingName = "Total"
        cTextCol9.HeaderText = "Total Fact"
        cTextCol9.Width = 80
        cTs1.GridColumnStyles.Add(cTextCol9)

        DataGrid1.TableStyles.Add(cTs1)


        cargarCombos()
        Me.chkEstado.Checked = True
        Me.cmbTipoPresentacion.SelectedIndex = 2

        arrPresentaciones = catalogoPresentaciones.traerPresentacionesPendientes()
        cargarGrilla()
        DataGrid1.CaptionText = "Presentaciones sin cobrar ( " & CStr(arrPresentaciones.Count) & " )"
        cargarComboAño()
    End Sub

    Private Sub cargarCombos()
        Dim os As ObraSocial
        Dim catalogoObraSocial As New CatalogoDeObrasSociales
        Dim i As Integer

        If Me.cmbTipoPresentacion.SelectedItem = "Directa" Then
            'las que no van por amr
            arrObraSocial = catalogoObraSocial.GetOS()
        Else
            'las que van por amr
            arrObraSocial = catalogoObraSocial.GetOS(1)
        End If

        cmbObraSocial.Items.Clear()
        cmbObraSocial.Items.Add("Seleccione una Obra Social..")
        For i = 0 To arrObraSocial.Count - 1
            os = arrObraSocial(i)
            cmbObraSocial.Items.Add(os.ObraSocial)
        Next
        cmbObraSocial.SelectedIndex = 0


    End Sub

    Private Sub cargarComboAño()
        cmbAnio.Items.Insert(0, "Seleccione año...")
        For index As Integer = 0 To 10
            cmbAnio.Items.Add(CStr(Today.Year - index))
        Next
        cmbAnio.SelectedIndex = 0
    End Sub

    Private Sub cargarGrilla()
        Dim sumTotal As Decimal = 0
        myTable.Clear()
        If arrPresentaciones.Count = 0 Then
            MsgBox("No hay presentaciones para mostrar")
            DataGrid1.DataSource = Nothing
        Else
            Dim NewRow As DataRow
            Dim i As Integer
            Dim cPresentacion As Presentacion

            For i = 0 To arrPresentaciones.Count - 1
                cPresentacion = arrPresentaciones(i)
                NewRow = myTable.NewRow()
                NewRow("ID") = cPresentacion.idPresentacion
                NewRow("Fecha") = cPresentacion.fechaFacturacion
                NewRow("Obra Social") = cPresentacion.obraSocial.ObraSocial
                If (cPresentacion.comprobante IsNot Nothing) Then
                    NewRow("Nro Comprobante") = cPresentacion.comprobante.NroComprobante
                    NewRow("Tipo Comprobante") = cPresentacion.comprobante.TipoComprobante.Descripcion
                    NewRow("SubTipo") = cPresentacion.comprobante.SubTipo
                End If
                NewRow("Estado") = cPresentacion.estado
                NewRow("Total") = Format(cPresentacion.getTotalFactura(), "###########0.00")
                sumTotal = sumTotal + Format(cPresentacion.getTotalFactura(), "###########0.00")
                myTable.Rows.Add(NewRow)
            Next

        End If
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable
        Me.lblTotalPresentaciones.Text = "Total Facturado: $ " & sumTotal.ToString()
    End Sub
    Private Sub btnFacturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFacturar.Click
        'Leer documentacion sobre el paso de una facturacion entre formularios
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        Dim currentFact As Presentacion
        currentFact = arrPresentaciones(i)
        If currentFact.pagado = 0 Then
            Dim frm As New FacturacionDetalle(currentFact.idPresentacion)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        ElseIf currentFact.pagado = 1 Then
            'Cobrado
            Dim frm As New FacturacionCobradaDetalle(currentFact)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        ElseIf currentFact.pagado = 2 Then
            'Abierta
            If hayUnaFacturacionInstanciada Then
                MsgBox("Ya hay una ventana Nueva Facturación abierta. Ciérrela y vuelva a intentarlo.", MsgBoxStyle.Information, "No se puede abrir la ventana Nueva Facturación")
            Else
                Dim frm As New NuevaPresentacion(currentFact.idPresentacion)
                frm.MdiParent = Me.Parent.Parent
                frm.Show()
            End If

        End If
    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cIdObraSocial As Integer = 0
        If cmbObraSocial.SelectedIndex > 0 Then
            Dim cObraSocial As ObraSocial = arrObraSocial(cmbObraSocial.SelectedIndex - 1)
            cIdObraSocial = cObraSocial.idObraSocial
        End If
        Dim fecha As Date
        If cmbAnio.SelectedIndex > 0 Then
            fecha = New Date(Convert.ToInt16(cmbAnio.SelectedItem), 1, 1)
        Else
            fecha = Nothing
        End If
        If Me.chkEstado.Checked = False And Me.cmbAnio.SelectedIndex < 1 Then
            MessageBox.Show("Por razones de rendimiento, debe seleccionar un año para buscar presentaciones cobradas")
            Exit Sub
        End If
        arrPresentaciones = catalogoPresentaciones.traerPresentaciones(cIdObraSocial, Me.txtNroComprobante.Text, Me.cmbTipoComprobante.SelectedItem, fecha, Me.chkEstado.Checked, , Me.txtNroRemito.Text, Me.cmbTipoPresentacion.SelectedItem)

        cargarGrilla()

        DataGrid1.CaptionText = "Resultado de la búsqueda : " & CStr(arrPresentaciones.Count) & "           --- ATENCIÓN:   RESULTADOS SÓLO PARA EL AÑO " & Me.cmbAnio.SelectedItem.ToString() & "   --- "
        DataGrid1.CaptionForeColor = Color.Aqua
    End Sub

    Private Sub btnCobro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobro.Click
        Dim i As Integer = DataGrid1.CurrentRowIndex
        Dim currentFact As Presentacion
        currentFact = arrPresentaciones(i)
        If currentFact.pagado = 0 Then
            Dim frm As New CobroPresentacion(currentFact.idPresentacion)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        ElseIf currentFact.pagado = 1 Then
            MsgBox("La presentación ya esta cobrada. Presione Ver para visualizar el detalle del pago.", MsgBoxStyle.Exclamation)
        ElseIf currentFact.pagado = 2 Then
            MsgBox("Debe finalizar la presentación para poder generar un cobro", MsgBoxStyle.Exclamation)
        End If


    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEliminar.Click
        Dim r As Integer
        r = MsgBox("¿Esta seguro que desea eliminar la presentación seleccionada?", MsgBoxStyle.YesNo, "Eliminar Facturación")
        If r = 6 Then
            Dim i As Integer
            i = DataGrid1.CurrentRowIndex
            Dim currentFact As Presentacion
            currentFact = arrPresentaciones(i)
            If currentFact.pagado = 0 Or currentFact.pagado = 2 Then
                Dim resp As String = catalogoPresentaciones.delete(currentFact.idPresentacion)
                If resp = "ok" Then
                    MsgBox("La presentación se ha eliminado con éxito", MsgBoxStyle.OkOnly)
                    btnBuscar.PerformClick()
                Else
                    MsgBox("Se ha produciodo el siguiente error al intentar borrar: " & resp, MsgBoxStyle.Critical)
                End If
            Else
                MsgBox("La presentación esta cobrada, no puede borrarse", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        Dim arrWidth(8) As Single
        arrWidth(0) = 60
        arrWidth(1) = 85
        arrWidth(2) = 250
        arrWidth(3) = 60
        arrWidth(4) = 40
        arrWidth(5) = 30
        arrWidth(6) = 80
        arrWidth(7) = 90

        'Luego setiar el nuevo arreglo de tamaños
        DataGrid1.columnsWidth = arrWidth

        DataGrid1.imprimirTitle = "Listado de presentaciones"
        DataGrid1.imprimirSubTitleSuperior1 = "Fecha: " & CStr(Today.Now)
        DataGrid1.imprimirSubTitleInferior1 = Me.lblTotalPresentaciones.Text
        DataGrid1.imprimir(arrPresentaciones.Count, 8)
    End Sub

    Private Sub TabControl2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'dependiendo de que tab toco, vamos a mostrar la lista de obras sociales
        cargarCombos()
    End Sub


    Private Sub rbtDirecta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargarCombos()
        Me.txtNroRemito.Enabled = False
    End Sub

    Private Sub rbtAMR_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargarCombos()
        Me.txtNroRemito.Enabled = True
    End Sub

    Private Sub rbtDirecta_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargarCombos()
        Me.txtNroRemito.Enabled = False
        Me.txtNroRemito.Text = ""
    End Sub

    Private Sub rbtAMR_CheckedChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cargarCombos()
        Me.txtNroRemito.Enabled = True
    End Sub

    Private Sub BuscarPresentacion_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        If actualizarListadoFacturaciones Then
            Me.btnBuscar.PerformClick()
        End If
        actualizarListadoFacturaciones = False
    End Sub

    Private Sub cmbTipoPresentacion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoPresentacion.SelectedIndexChanged
        If Me.cmbTipoPresentacion.SelectedItem = "Directa" Then
            'las que no van por amr
            Me.txtNroRemito.Enabled = False
            Me.txtNroRemito.Text = ""
        Else
            'las que van por amr
            Me.txtNroRemito.Enabled = True
        End If

        cargarCombos()


    End Sub
End Class