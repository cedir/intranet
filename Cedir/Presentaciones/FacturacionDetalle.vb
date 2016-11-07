Imports CedirNegocios
Imports System.Drawing.Printing
Imports System.Collections.Generic

Public Class FacturacionDetalle
    Inherits System.Windows.Forms.Form
    'Leer documentacion sobre el paso de una facturacion entre formularios
    Dim cIdFacturacion As Integer
    Friend WithEvents lblGuion As System.Windows.Forms.Label
    Friend WithEvents txtNroTerminal As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Dim cPresentacion As Presentacion
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal idFacturacion As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cIdFacturacion = idFacturacion
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents grpComprobante As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnularFactura As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents txtIva As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbResponsableComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblSubTotal As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblConsultas As System.Windows.Forms.Label
    Friend WithEvents lblva As System.Windows.Forms.Label
    Friend WithEvents lbltotalEstudios As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnImprimirDetalle As System.Windows.Forms.Button
    Friend WithEvents btnAbrirFacturacion As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnImprimirDetalle = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.btnAbrirFacturacion = New System.Windows.Forms.Button
        Me.grpComprobante = New System.Windows.Forms.GroupBox
        Me.lblGuion = New System.Windows.Forms.Label
        Me.txtNroTerminal = New System.Windows.Forms.TextBox
        Me.btnAnularFactura = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtNroComprobante = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox
        Me.txtIva = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmbResponsableComprobante = New System.Windows.Forms.ComboBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblSubTotal = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblConsultas = New System.Windows.Forms.Label
        Me.lblva = New System.Windows.Forms.Label
        Me.lbltotalEstudios = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.grpComprobante.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 16)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(680, 200)
        Me.DataGrid1.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.DataGrid1, "Haga Doble-Click con el mouse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Para ver el detalle de medicacion")
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label1.Location = New System.Drawing.Point(14, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(528, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Obra social"
        '
        'Label2
        '
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(640, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "fecha"
        '
        'btnImprimirDetalle
        '
        Me.btnImprimirDetalle.Location = New System.Drawing.Point(200, 459)
        Me.btnImprimirDetalle.Name = "btnImprimirDetalle"
        Me.btnImprimirDetalle.Size = New System.Drawing.Size(96, 23)
        Me.btnImprimirDetalle.TabIndex = 4
        Me.btnImprimirDetalle.Text = "Imprimir Detalle"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(8, 40)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(712, 248)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(704, 222)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'btnAbrirFacturacion
        '
        Me.btnAbrirFacturacion.Location = New System.Drawing.Point(77, 459)
        Me.btnAbrirFacturacion.Name = "btnAbrirFacturacion"
        Me.btnAbrirFacturacion.Size = New System.Drawing.Size(112, 23)
        Me.btnAbrirFacturacion.TabIndex = 6
        Me.btnAbrirFacturacion.Text = "Abrir Presentación"
        '
        'grpComprobante
        '
        Me.grpComprobante.Controls.Add(Me.lblGuion)
        Me.grpComprobante.Controls.Add(Me.txtNroTerminal)
        Me.grpComprobante.Controls.Add(Me.btnAnularFactura)
        Me.grpComprobante.Controls.Add(Me.Label5)
        Me.grpComprobante.Controls.Add(Me.txtNroComprobante)
        Me.grpComprobante.Controls.Add(Me.Label6)
        Me.grpComprobante.Controls.Add(Me.Label4)
        Me.grpComprobante.Controls.Add(Me.cmbTipoComprobante)
        Me.grpComprobante.Controls.Add(Me.txtIva)
        Me.grpComprobante.Controls.Add(Me.Label7)
        Me.grpComprobante.Controls.Add(Me.Label8)
        Me.grpComprobante.Controls.Add(Me.cmbResponsableComprobante)
        Me.grpComprobante.Enabled = False
        Me.grpComprobante.Location = New System.Drawing.Point(8, 296)
        Me.grpComprobante.Name = "grpComprobante"
        Me.grpComprobante.Size = New System.Drawing.Size(428, 151)
        Me.grpComprobante.TabIndex = 23
        Me.grpComprobante.TabStop = False
        Me.grpComprobante.Text = "Comprobante"
        '
        'lblGuion
        '
        Me.lblGuion.AutoSize = True
        Me.lblGuion.Location = New System.Drawing.Point(214, 86)
        Me.lblGuion.Name = "lblGuion"
        Me.lblGuion.Size = New System.Drawing.Size(10, 13)
        Me.lblGuion.TabIndex = 34
        Me.lblGuion.Text = "-"
        '
        'txtNroTerminal
        '
        Me.txtNroTerminal.Location = New System.Drawing.Point(138, 83)
        Me.txtNroTerminal.Name = "txtNroTerminal"
        Me.txtNroTerminal.ReadOnly = True
        Me.txtNroTerminal.Size = New System.Drawing.Size(71, 20)
        Me.txtNroTerminal.TabIndex = 33
        Me.txtNroTerminal.Text = "0001"
        Me.txtNroTerminal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnAnularFactura
        '
        Me.btnAnularFactura.Location = New System.Drawing.Point(336, 83)
        Me.btnAnularFactura.Name = "btnAnularFactura"
        Me.btnAnularFactura.Size = New System.Drawing.Size(48, 23)
        Me.btnAnularFactura.TabIndex = 28
        Me.btnAnularFactura.Text = "Anular"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(11, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 23)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Nro de Comprobante:"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(230, 85)
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(100, 20)
        Me.txtNroComprobante.TabIndex = 26
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(11, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 23)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Tipo de  Comprobante:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Responsable: "
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbTipoComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(137, 48)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(104, 21)
        Me.cmbTipoComprobante.TabIndex = 12
        '
        'txtIva
        '
        Me.txtIva.Location = New System.Drawing.Point(137, 115)
        Me.txtIva.Name = "txtIva"
        Me.txtIva.Size = New System.Drawing.Size(40, 20)
        Me.txtIva.TabIndex = 9
        Me.txtIva.Text = "0"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(11, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 23)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "% Gravado"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(185, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 23)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "%"
        '
        'cmbResponsableComprobante
        '
        Me.cmbResponsableComprobante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbResponsableComprobante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbResponsableComprobante.Location = New System.Drawing.Point(137, 14)
        Me.cmbResponsableComprobante.Name = "cmbResponsableComprobante"
        Me.cmbResponsableComprobante.Size = New System.Drawing.Size(104, 21)
        Me.cmbResponsableComprobante.TabIndex = 23
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSubTotal)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Controls.Add(Me.lblConsultas)
        Me.GroupBox1.Controls.Add(Me.lblva)
        Me.GroupBox1.Controls.Add(Me.lbltotalEstudios)
        Me.GroupBox1.Location = New System.Drawing.Point(504, 296)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 152)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Importes Totales"
        '
        'lblSubTotal
        '
        Me.lblSubTotal.Location = New System.Drawing.Point(16, 72)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(168, 23)
        Me.lblSubTotal.TabIndex = 16
        Me.lblSubTotal.Text = "SubTotal: $"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(16, 125)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(184, 16)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total: $ "
        '
        'lblConsultas
        '
        Me.lblConsultas.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblConsultas.Location = New System.Drawing.Point(16, 48)
        Me.lblConsultas.Name = "lblConsultas"
        Me.lblConsultas.Size = New System.Drawing.Size(184, 23)
        Me.lblConsultas.TabIndex = 15
        Me.lblConsultas.Text = "Consultas: $"
        '
        'lblva
        '
        Me.lblva.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lblva.Location = New System.Drawing.Point(16, 96)
        Me.lblva.Name = "lblva"
        Me.lblva.Size = New System.Drawing.Size(182, 23)
        Me.lblva.TabIndex = 7
        Me.lblva.Text = "Iva: $"
        '
        'lbltotalEstudios
        '
        Me.lbltotalEstudios.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.lbltotalEstudios.Location = New System.Drawing.Point(16, 24)
        Me.lbltotalEstudios.Name = "lbltotalEstudios"
        Me.lbltotalEstudios.Size = New System.Drawing.Size(184, 23)
        Me.lbltotalEstudios.TabIndex = 8
        Me.lbltotalEstudios.Text = "Estudios: $"
        '
        'btnGuardar
        '
        Me.btnGuardar.Enabled = False
        Me.btnGuardar.Location = New System.Drawing.Point(8, 459)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(56, 23)
        Me.btnGuardar.TabIndex = 24
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(302, 459)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(56, 23)
        Me.btnCerrar.TabIndex = 25
        Me.btnCerrar.Text = "Cerrar"
        '
        'FacturacionDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(728, 488)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.grpComprobante)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAbrirFacturacion)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnImprimirDetalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FacturacionDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de Presentación"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.grpComprobante.ResumeLayout(False)
        Me.grpComprobante.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Dim catalogoDeFacturaciones As New CatalogoDePresentaciones
    Dim myTable As DataTable = New DataTable("myTable")
    Dim tableConsultas As DataTable = New DataTable("consultas")
    Dim tiposComprobante As New List(Of TipoComprobante)

    Dim totalEstudios As Single
    'Dim totalConsultas As Single
    Dim cPrintingEsudioLineIndex As Integer

    Private Sub FacturacionDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cPresentacion = catalogoDeFacturaciones.find(cIdFacturacion)

        Dim clNumeroOrden As DataColumn = New DataColumn("Orden", Type.GetType("System.String"))
        Dim clIdEstudio As DataColumn = New DataColumn("IdEstudio", Type.GetType("System.String"))
        Dim clFecha As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clnroAfiliado As DataColumn = New DataColumn("Nro Afiliado", Type.GetType("System.String"))
        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Actuante", Type.GetType("System.String"))
        Dim clImporteProOS As DataColumn = New DataColumn("Importe", Type.GetType("System.String"))
        Dim clImporteMedicacion As DataColumn = New DataColumn("Medicacion", Type.GetType("System.String"))
        Dim clImportePension As DataColumn = New DataColumn("Pensión", Type.GetType("System.String"))
        Dim clDiferenciaPaciente As DataColumn = New DataColumn("Dif. Paciente", Type.GetType("System.String"))
        Dim clImporteAnestesia As DataColumn = New DataColumn("Anestesia", Type.GetType("System.String"))

        myTable.Columns.Add(clIdEstudio)
        myTable.Columns.Add(clFecha)
        myTable.Columns.Add(clNumeroOrden)
        myTable.Columns.Add(clnroAfiliado)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clImporteProOS)
        myTable.Columns.Add(clImportePension)
        myTable.Columns.Add(clDiferenciaPaciente)
        myTable.Columns.Add(clImporteMedicacion)
        myTable.Columns.Add(clImporteAnestesia)

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
        TextCol0.MappingName = "IdEstudio"
        TextCol0.HeaderText = "IDEstudio"
        TextCol0.Width = 20
        ts1.GridColumnStyles.Add(TextCol0)
        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Fecha"
        TextCol2.HeaderText = "Fecha"
        TextCol2.Width = 65
        ts1.GridColumnStyles.Add(TextCol2)
        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Orden"
        TextCol3.HeaderText = "Orden"
        TextCol3.Width = 63
        ts1.GridColumnStyles.Add(TextCol3)
        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Nro Afiliado"
        TextCol4.HeaderText = "Nro Afiliado"
        TextCol4.Width = 65
        ts1.GridColumnStyles.Add(TextCol4)
        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "Paciente"
        TextCol5.HeaderText = "Paciente"
        TextCol5.Width = 95
        ts1.GridColumnStyles.Add(TextCol5)
        Dim TextCol6 As New DataGridTextBoxColumn
        TextCol6.MappingName = "Práctica"
        TextCol6.HeaderText = "Práctica"
        TextCol6.Width = 180
        ts1.GridColumnStyles.Add(TextCol6)
        Dim TextCol7 As New DataGridTextBoxColumn
        TextCol7.MappingName = "Actuante"
        TextCol7.HeaderText = "Actuante"
        TextCol7.Width = 95
        ts1.GridColumnStyles.Add(TextCol7)
        Dim TextCol8 As New DataGridTextBoxColumn
        TextCol8.MappingName = "Importe"
        TextCol8.HeaderText = "Importe"
        TextCol8.Width = 43
        ts1.GridColumnStyles.Add(TextCol8)
        Dim TextCol9 As New DataGridTextBoxColumn
        TextCol9.MappingName = "Pensión"
        TextCol9.HeaderText = "Pensión"
        TextCol9.Width = 46
        ts1.GridColumnStyles.Add(TextCol9)
        Dim TextCol10 As New DataGridTextBoxColumn
        TextCol10.MappingName = "Dif. Paciente"
        TextCol10.HeaderText = "Dif. Paciente"
        TextCol10.Width = 44
        ts1.GridColumnStyles.Add(TextCol10)
        Dim TextCol11 As New DataGridTextBoxColumn
        TextCol11.MappingName = "Medicacion"
        TextCol11.HeaderText = "Medicacion"
        TextCol11.Width = 40
        ts1.GridColumnStyles.Add(TextCol11)

        Dim TextCol12 As New DataGridTextBoxColumn
        TextCol12.MappingName = "Anestesia"
        TextCol12.HeaderText = "Anestesia"
        TextCol12.Width = 40
        ts1.GridColumnStyles.Add(TextCol12)



        DataGrid1.TableStyles.Add(ts1)



        Label1.Text = cPresentacion.obraSocial.ObraSocial
        Label2.Text = cPresentacion.fechaFacturacion

        Me.cargarComboTipoComprobante()

        cmbResponsableComprobante.Items.Add("Seleccionar..")
        cmbResponsableComprobante.Items.Add("Cedir")
        cmbResponsableComprobante.Items.Add("Brunetti")

        Me.mostrarDatosComprobante()

        btnAnularFactura.Visible = False
        If cPresentacion.comprobante.NroComprobante <> Nothing Then
            btnAnularFactura.Visible = True
        End If
        'sacar esto dp
        btnAnularFactura.Enabled = False


        cargarGrilla()
    End Sub


    Private Sub cargarComboTipoComprobante()
        Dim catTipo As New CatalogoDeTiposComprobante
        Dim cTipos As New List(Of TipoComprobante)
        cTipos = catTipo.getTiposComprobante()
        Me.cmbTipoComprobante.Items.Clear()

        For Each t As TipoComprobante In cTipos
            If t.Descripcion = "Liquidación" Or t.Descripcion = "Factura" Then
                Me.cmbTipoComprobante.Items.Add(t.Descripcion)
                tiposComprobante.Add(t)
            End If
        Next
        catTipo = Nothing
        cTipos = Nothing
    End Sub



    Private Sub cargarGrilla()
        cPresentacion.cargarFacturacion()
        Dim cLineaEstudio As LineaDeFacturacion
        Dim NewRow As DataRow
        Dim i As Integer

        'Estudios
        Dim arrLineasEstudios As ArrayList
        arrLineasEstudios = cPresentacion.getLineasDeFacturacionEstudios()
        myTable.Clear()


        totalEstudios = 0
        For i = 0 To arrLineasEstudios.Count - 1
            cLineaEstudio = arrLineasEstudios(i)
            NewRow = myTable.NewRow()
            NewRow("IdEstudio") = cLineaEstudio.objeto.nroestudio
            NewRow("Fecha") = cLineaEstudio.objeto.fechaEstudio
            NewRow("Orden") = cLineaEstudio.objeto.nroOrden
            NewRow("Paciente") = cLineaEstudio.objeto.paciente.apellido & ", " & cLineaEstudio.objeto.paciente.nombres
            NewRow("Práctica") = cLineaEstudio.objeto.practica.Estudio
            NewRow("Actuante") = cLineaEstudio.objeto.medicoActuante.apellido & ", " & cLineaEstudio.objeto.medicoActuante.nombre
            NewRow("Importe") = cLineaEstudio.objeto.ImporteEstudio
            NewRow("Nro Afiliado") = cLineaEstudio.objeto.paciente.nroAfiliado
            NewRow("Pensión") = cLineaEstudio.objeto.pension
            NewRow("Dif. Paciente") = cLineaEstudio.objeto.DiferenciaPaciente

            Dim totalParcialMedicacion As Single = cLineaEstudio.objeto.getTotalMedicacion()
            NewRow("Medicacion") = totalParcialMedicacion
            NewRow("Anestesia") = cLineaEstudio.objeto.ArancelAnestesia
            myTable.Rows.Add(NewRow)

            totalEstudios += cLineaEstudio.getImporteNeto
        Next


        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable

        'Si no hay estudios, sa carga la solapa consultas
        If arrLineasEstudios.Count = 0 Then
            TabControl1.SelectedIndex = 1
        End If


        lbltotalEstudios.Text = "Estudios: $ " & CStr(totalEstudios)
        lblSubTotal.Text = "Sub Total: $ " & CStr(cPresentacion.total)
        lblva.Text = "Iva: $ " & CStr(cPresentacion.getImporteIva)
        lblTotal.Text = "Total: $ " & CStr(cPresentacion.getTotalFactura)
    End Sub


    Private Sub txtIva_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtIva.TextChanged
        Dim cIva As Single
        If txtIva.Text <> "" Then
            cIva = CSng(txtIva.Text)
        Else
            cIva = 0
        End If
        Dim iva As Single = (totalEstudios) * cIva / 100
        iva = Math.Round(iva, 2)
        lblva.Text = "Iva: $ " & CStr(iva)
        lblTotal.Text = "Total: $ " & CStr(totalEstudios + iva)
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        If validateData() Then
            cPresentacion.guardar(False)

            MsgBox("La facturación se ha modificado con éxito")
        End If

    End Sub
    Private Function validateData() As Boolean

        If cmbResponsableComprobante.SelectedIndex = 0 Then
            MsgBox("Debe seleccionar un responsable de factura", MsgBoxStyle.Critical)
            Return False
        End If

        If cmbTipoComprobante.SelectedIndex = 0 And cmbResponsableComprobante.SelectedItem <> "Sin Factura" Then
            MsgBox("Debe seleccionar un tipo de factura", MsgBoxStyle.Critical)
            Return False
        End If

        Return True
    End Function
    Private Sub btnAbrirFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbrirFacturacion.Click
        'Leer documentacion sobre el paso de una facturacion entre formularios
        If hayUnaFacturacionInstanciada Then
            MsgBox("Ya hay una ventana Nueva Facturación abierta. Ciérrela y vuelva a intentarlo.", MsgBoxStyle.Information, "No se puede abrir la ventana Nueva Facturación")
        Else
            'si el comprobante es una liquidacion, no lo anulamos, lo mantenemos para la misma presentacion
            If cPresentacion.comprobante.TipoComprobante.Id <> TComprobante.Liquidacion Then
                Dim r As DialogResult = MessageBox.Show("Al abrir la presentación se generará una Nota de Crédito que anule la Factura asociada." + vbCrLf + "Esta seguro de continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
                If r = Windows.Forms.DialogResult.Yes Then
                    'generamos una nota de crédito que anule la factura
                    Dim result As Dictionary(Of String, String) = cPresentacion.GenerarNotaDeCredito()
                    If Not Helper.IsSuccess(result) Then
                        MessageBox.Show(Helper.GetMessage(result), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Exit Sub
                    Else
                        MessageBox.Show(Helper.GetMessage(result), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                    'Seteamos en null el campo idComprobante en la tabla facturacion
                    cPresentacion.anularComprobante("COBRADO")
                Else
                    Exit Sub
                End If
            Else
                cPresentacion.anularComprobante("ANULADO")
            End If

            Dim frm As New NuevaPresentacion(cPresentacion.idPresentacion)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
            Me.Close()
        End If ' fin hayUnaFacturacionInstanciada

    End Sub

    Private Sub btnImprimirDetalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirDetalle.Click
        prepareImprimirDetalle()
    End Sub


    Private Sub prepareImprimirDetalle()
        Dim SalesReport As New PrintDocument
        AddHandler SalesReport.PrintPage, AddressOf imprimirDetalleFacturacion

        'Pedir periodo
        Dim mes As String = InputBox("Ingrese el mes correspondiente a la facturación", "Ingresar mes de facturación", cPresentacion.periodo)
        If cPresentacion.periodo <> mes Then
            cPresentacion.periodo = mes
            'Acturalizar
        End If

        'Imprimir
        cPrintingEsudioLineIndex = 0
        Dim pss As New PrintDialog
        Dim bp As DialogResult
        pss.Document = SalesReport
        bp = pss.ShowDialog
        If bp = DialogResult.OK Then
            SalesReport.Print()
        End If


    End Sub
    Sub imprimirDetalleFacturacion(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim tituloFacturacion As New Font("Arial", 12, FontStyle.Bold)
        Dim subTitulo As New Font("Arial", 10, FontStyle.Regular)
        Dim totalFont As New Font("Arial", 10, FontStyle.Bold)
        Dim reportFont As New Font("Arial", 9, FontStyle.Regular)
        Dim reportFontHeight As Integer = reportFont.GetHeight(e.Graphics)

        'default page settings
        Dim leftMarge As Single = 100
        Dim pageMaxHeight As Integer = 1000
        Dim yStart As Integer = 230
        Dim CurrentY As Integer = yStart

        Dim color As New Color
        Dim myPen As New System.Drawing.Pen(color.Black)
        myPen.Alignment = Drawing2D.PenAlignment.Center
        myPen.Width = 1

        'Dim height As Single = 100.0F
        Dim drawRect As New RectangleF
        drawRect.X = leftMarge
        drawRect.Width = 700.0F
        drawRect.Height = reportFontHeight

        Dim rectMedicacion As New RectangleF
        rectMedicacion.X = leftMarge
        rectMedicacion.Width = 300 - leftMarge
        rectMedicacion.Height = reportFontHeight

        'Encabezado de detalle
        If cPrintingEsudioLineIndex = 0 Then
            Dim rectTitulo As New RectangleF
            rectTitulo.X = leftMarge
            rectTitulo.Width = 700.0F
            rectTitulo.Height = 18
            'Obra social
            rectTitulo.Y = CurrentY - reportFontHeight
            e.Graphics.DrawString("Obra Social: " & cPresentacion.obraSocial.ObraSocial, tituloFacturacion, Brushes.Black, rectTitulo)

            'Descripcion
            CurrentY = CurrentY + 30
            drawRect.Y = CurrentY - reportFontHeight
            e.Graphics.DrawString("Detalle de Facturación correspondiente al mes de " & cPresentacion.periodo, subTitulo, Brushes.Black, drawRect)

            'fecha
            CurrentY = CurrentY + 20
            drawRect.Y = CurrentY - reportFontHeight
            e.Graphics.DrawString("Fecha: " & cPresentacion.fechaFacturacion, subTitulo, Brushes.Black, drawRect)

            'Linea horizontal
            CurrentY = CurrentY + 20
            e.Graphics.DrawLine(myPen, 100, CurrentY, 700, CurrentY)

            CurrentY = CurrentY + 15
        End If

        '<----------------------------------------------------------->

        Dim i, j As Integer
        Dim cLinea As LineaDeFacturacion

        'calcular tamaño linea
        cLinea = cPresentacion.getLineasDeFacturacionEstudios(cPrintingEsudioLineIndex)
        Dim cSize As Single = Me.getLineaSize(cLinea)
        Dim estimateY As Single = CurrentY + cSize
        While (estimateY <= pageMaxHeight And cPrintingEsudioLineIndex < cPresentacion.getLineasDeFacturacionEstudios.Count)
            Dim cEstudio As Estudio = cLinea.objeto
            'Fecha
            e.Graphics.DrawString("Fecha: " & cEstudio.fechaEstudio, reportFont, Brushes.Black, leftMarge, CurrentY)
            CurrentY = CurrentY + 20

            'Paciente
            Dim strPaciente As String = "Paciente: " & cLinea.objeto.paciente.nombreCompleto
            If DataGrid1.Item(cPrintingEsudioLineIndex, 3) <> "" Then
                'Si tiene nroAfiliado ponerlo
                strPaciente &= " - Nro de afiliado: " & cLinea.objeto.paciente.nroAfiliado     'DataGrid1.Item(cPrintingEsudioLineIndex, 3)
            End If
            e.Graphics.DrawString(strPaciente, reportFont, Brushes.Black, leftMarge, CurrentY)

            'Nro de orden y nro matricula medico
            If cLinea.objeto.nroOrden <> "" Then
                CurrentY = CurrentY + 20
                e.Graphics.DrawString("Nro de orden: " & cLinea.objeto.nroOrden, reportFont, Brushes.Black, leftMarge, CurrentY)
            End If
            If cEstudio.medicoActuante.nroMatricula <> "" And (cLinea.objeto.obraSocial.idObraSocial = 79 Or cLinea.objeto.obraSocial.idObraSocial = 3) Then
                'tenemos que considerar que baje de renglon si no hay nro orden
                If cLinea.objeto.nroOrden = "" Then
                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("Nro. Mat. Profesional: " & cEstudio.medicoActuante.nroMatricula, reportFont, Brushes.Black, leftMarge, CurrentY)
                Else
                    e.Graphics.DrawString("Nro. Mat. Profesional: " & cEstudio.medicoActuante.nroMatricula, reportFont, Brushes.Black, 350, CurrentY)
                End If

            End If


            'Practica
            CurrentY = CurrentY + 20
            drawRect.Y = CurrentY
            e.Graphics.DrawString("Práctica: " & cEstudio.practica.Estudio, reportFont, Brushes.Black, drawRect)

            Dim startLine As Integer
            'Importe practica
            CurrentY = CurrentY + 28
            startLine = CurrentY
            Dim codigoPractica As String = ""
            If cLinea.objeto.obraSocial.idObraSocial = 79 Or cLinea.objeto.obraSocial.idObraSocial = 3 Then
                codigoPractica = cEstudio.practica.codigoMedicoOSDE & " "
            End If

            e.Graphics.DrawString(codigoPractica & "Práctica  ", reportFont, Brushes.Black, leftMarge, CurrentY)
            e.Graphics.DrawString(" $" & CStr(cLinea.importe), reportFont, Brushes.Black, 460, CurrentY)

            'Diferencia Paciente
            If cLinea.diferenciaPaciente <> 0 Then
                CurrentY = CurrentY + 20
                e.Graphics.DrawString("A cargo del paciente", reportFont, Brushes.Black, leftMarge, CurrentY)
                e.Graphics.DrawString(" $" & cLinea.diferenciaPaciente, reportFont, Brushes.Black, 460, CurrentY)
            End If

            'Pension
            If cLinea.pension <> 0 Then
                CurrentY = CurrentY + 20
                'si es osde u osde cedir
                Dim codigoPension As String

                If cLinea.objeto.obraSocial.idObraSocial = 79 Or cLinea.objeto.obraSocial.idObraSocial = 3 Then
                    codigoPension = "430185  "
                Else
                    codigoPension = ""
                End If
                e.Graphics.DrawString(codigoPension & "Pensión  ", reportFont, Brushes.Black, leftMarge, CurrentY)
                e.Graphics.DrawString(" $" & CStr(cLinea.pension), reportFont, Brushes.Black, 460, CurrentY)
            End If

            'Arancel Anestesia
            If cLinea.objeto.ArancelAnestesia <> 0 Then
                CurrentY = CurrentY + 20
                e.Graphics.DrawString("Anestesia", reportFont, Brushes.Black, leftMarge, CurrentY)
                e.Graphics.DrawString(" $" & CStr(cLinea.objeto.ArancelAnestesia), reportFont, Brushes.Black, 460, CurrentY)
            End If



            'Medicacion y material especifico
            If cEstudio.arrMedicacion.Count > 0 Then


                Dim med As Medicacion
                Dim arrMedicacionSinMaterialEspecifico As New ArrayList
                Dim arrMaterialEspecifico As New ArrayList
                arrMedicacionSinMaterialEspecifico = cEstudio.getMedicacionSinMaterialEspecifico()
                arrMaterialEspecifico = cEstudio.getMaterialEspecifico()
                Dim totalMaterialEspecifico As Decimal = 0.0

                'Material Especifico
                If arrMaterialEspecifico.Count > 0 Then
                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("Material Especifico: ", reportFont, Brushes.Black, leftMarge, CurrentY)
                    For j = 0 To arrMaterialEspecifico.Count - 1
                        CurrentY = CurrentY + 20
                        med = arrMaterialEspecifico(j)
                        totalMaterialEspecifico = totalMaterialEspecifico + med.importe

                        rectMedicacion.Y = CurrentY

                        'si es osde u osde cedir
                        Dim codigoMedicamento As String = ""

                        If cLinea.objeto.obraSocial.idObraSocial = 79 Or cLinea.objeto.obraSocial.idObraSocial = 3 Then
                            codigoMedicamento = med.medicamento.codigoMedicoOSDE & " "
                        End If
                        e.Graphics.DrawString(codigoMedicamento & "•" & med.medicamento.descripcion, reportFont, Brushes.Black, rectMedicacion)
                        e.Graphics.DrawString("  $" & med.importe, reportFont, Brushes.Black, 360, CurrentY)
                    Next

                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("  Total Material especifico*", reportFont, Brushes.Black, leftMarge, CurrentY)
                    e.Graphics.DrawString("  $" & Format(totalMaterialEspecifico, "############0.00").ToString(), reportFont, Brushes.Black, 460, CurrentY)
                End If

                If arrMedicacionSinMaterialEspecifico.Count > 0 Then
                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("Medicación:", reportFont, Brushes.Black, leftMarge, CurrentY)


                    For j = 0 To arrMedicacionSinMaterialEspecifico.Count - 1
                        med = arrMedicacionSinMaterialEspecifico(j)
                        CurrentY = CurrentY + 20
                        rectMedicacion.Y = CurrentY
                        e.Graphics.DrawString("  • " & med.medicamento.descripcion, reportFont, Brushes.Black, rectMedicacion)
                        e.Graphics.DrawString("  $" & med.importe, reportFont, Brushes.Black, 360, CurrentY)

                    Next


                    Dim codigoMedicacion As String = ""
                    If cLinea.objeto.obraSocial.idObraSocial = 79 Or cLinea.objeto.obraSocial.idObraSocial = 3 Then
                        codigoMedicacion = "922501 "
                    End If
                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString(codigoMedicacion & "Total Medicación*", reportFont, Brushes.Black, leftMarge, CurrentY)
                    e.Graphics.DrawString("  $" & CStr(cEstudio.getTotalMedicacion - totalMaterialEspecifico) & "  * Valorizada de acuerdo al Vademecum Kairos", reportFont, Brushes.Black, 460, CurrentY)
                End If

            End If


            'Lineas verticales de los totales
            e.Graphics.DrawLine(myPen, 340, startLine, 340, CurrentY + reportFontHeight)
            e.Graphics.DrawLine(myPen, 440, startLine, 440, CurrentY + reportFontHeight)

            'Total
            CurrentY = CurrentY + 25
            e.Graphics.DrawString("Total del estudio", reportFont, Brushes.Black, leftMarge, CurrentY)
            e.Graphics.DrawString(" $" & CStr(cLinea.getImporteNeto), reportFont, Brushes.Black, 460, CurrentY)

            'Linea horizontal de fin de estudio
            CurrentY = CurrentY + 20
            e.Graphics.DrawLine(myPen, 100, CurrentY, 700, CurrentY)

            'Seteo espacio para el siguiente estudio
            CurrentY = CurrentY + 15

            cPrintingEsudioLineIndex = cPrintingEsudioLineIndex + 1
            If cPrintingEsudioLineIndex < cPresentacion.getLineasDeFacturacionEstudios.Count Then
                cLinea = cPresentacion.getLineasDeFacturacionEstudios(cPrintingEsudioLineIndex)
                cSize = Me.getLineaSize(cLinea)
                estimateY = CurrentY + cSize
            End If

        End While

        'Pregunto si quedan estudios por imprimir
        If cPrintingEsudioLineIndex = cPresentacion.getLineasDeFacturacionEstudios.Count Then
            'No hay mas estudios
            CurrentY = CurrentY + 10
            drawRect.Y = CurrentY
            e.Graphics.DrawString("Total: $ " & CStr(cPresentacion.total), totalFont, Brushes.Black, drawRect)
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If

    End Sub
    Private Function getLineaSize(ByVal linea As LineaDeFacturacion) As Single
        'Dim reportFontHeight As Single = 14 'ojo, cambiar este valor si se cambia el tamaño del font de la letra
        'Dim rowSize As Single = reportFontHeight

        Dim totalSize As Single = 0

        'Fecha
        totalSize += 15 '15 es la separacion de arriba 
        'Paciente
        totalSize += 20
        'Nro de orden: podría no tener
        If linea.objeto.nroOrden <> "" Then
            totalSize += 20
        End If

        'Descripcion practica
        totalSize += 20
        'Valor practica
        totalSize += 28
        'Dif paciente: podría no tener
        If linea.diferenciaPaciente <> 0 Then
            totalSize += 20
        End If
        'Pension: podría no tener
        If linea.pension <> 0 Then
            totalSize += 20
        End If
        'Medicacion (lineas y total): podría no tener
        If linea.objeto.arrMedicacion.Count > 0 Then
            totalSize += (20 * linea.objeto.arrMedicacion.Count)
            'Total neurolepto
            totalSize += 20
        End If
        'Total del estudio
        totalSize += 25
        'Linea final
        totalSize += 20

        Return totalSize
    End Function

    Private Sub prepareImprimirFactura()

        Dim facturaReport As New PrintDocument
        AddHandler facturaReport.PrintPage, AddressOf imprimirFactura
        'Pedir periodo
        If cPresentacion.periodo = "" Then
            Dim mes As String = InputBox("Ingrese el mes correspondiente a la facturación", "Ingresar mes de facturación", cPresentacion.periodo)
            If cPresentacion.periodo <> mes Then
                cPresentacion.periodo = mes
                'Acturalizar
            End If
        End If

        'Imprimir
        Dim pss As New PrintDialog
        Dim bp As DialogResult
        pss.Document = facturaReport
        bp = pss.ShowDialog
        If bp = DialogResult.OK Then
            facturaReport.Print()
        End If
    End Sub
    Sub imprimirFactura(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim x As Single = 100.0F
        Dim y As Single = 150.0F
        Dim width As Single = 700.0F
        Dim height As Single = 100.0F
        Dim drawRect As New RectangleF(x, y, width, height)

        Dim CurrentY As Integer = 130
        Dim CurrentX As Integer = 100
        Dim ReportFont As New Font("Arial", 10, FontStyle.Regular)
        Dim ReportFontHeight As Integer = ReportFont.GetHeight(e.Graphics)
        Dim resaltaText As New Font("Arial", 11, FontStyle.Bold)
        Dim leyendaFont As New Font("Arial", 10, FontStyle.Italic)

        Dim os As ObraSocial
        os = cPresentacion.obraSocial

        drawRect.Y = CurrentY - ReportFontHeight
        CurrentX = 650
        e.Graphics.DrawString("Fecha: " & Today.Date, ReportFont, Brushes.Black, CurrentX, CurrentY)

        CurrentY = CurrentY + 82
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Institución: " & os.ObraSocial, ReportFont, Brushes.Black, drawRect)

        CurrentY = CurrentY + 20
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Domicilio: " & os.direccion & " - " & os.localidad & " (CP: " & os.CodigoPostal & ")", ReportFont, Brushes.Black, drawRect)

        CurrentY = CurrentY + 20
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Cuit: " & os.nroCuit & "     -     I.V.A: " & os.CondicionFiscal, ReportFont, Brushes.Black, 100, CurrentY - ReportFontHeight)

        Dim descTot As String
        descTot = InputBox("Ingrese el total en letras", "Ingrese el total en letras")

        CurrentY = CurrentY + 20
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Concepto", resaltaText, Brushes.Black, 100, CurrentY)
        e.Graphics.DrawString("Total", resaltaText, Brushes.Black, 650, CurrentY)

        CurrentY = CurrentY + 120
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Facturación mes de " & cPresentacion.periodo & " según detalle adjunto", ReportFont, Brushes.Black, drawRect)
        e.Graphics.DrawString(CStr(cPresentacion.total), ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)

        CurrentY = CurrentY + 50
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("I.V.A (" & cPresentacion.comprobante.Gravado.porcentaje & "%)", ReportFont, Brushes.Black, drawRect)
        e.Graphics.DrawString(cPresentacion.getImporteIva, ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)

        CurrentY = CurrentY + 80
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Total", ReportFont, Brushes.Black, drawRect)
        e.Graphics.DrawString(cPresentacion.getTotalFactura, ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)


        CurrentY = CurrentY + 70
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString(descTot, resaltaText, Brushes.Black, drawRect)

        'Leyenda
        CurrentY = CurrentY + 40
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Esta factura contiene honorarios por cuenta y orden de médicos.", leyendaFont, Brushes.Black, drawRect)


        e.HasMorePages = False


    End Sub
    Private Sub mostrarDatosComprobante()

        Me.txtNroComprobante.Text = cPresentacion.comprobante.NroComprobante
        Me.cmbTipoComprobante.SelectedItem = cPresentacion.comprobante.TipoComprobante.Descripcion
        Select Case cPresentacion.comprobante.Responsable.ToUpper
            Case "CEDIR"
                cmbResponsableComprobante.SelectedIndex = 1
            Case "BRUNETTI"
                cmbResponsableComprobante.SelectedIndex = 2
        End Select

        txtIva.Text = cPresentacion.comprobante.Gravado.porcentaje
        txtNroComprobante.Text = cPresentacion.comprobante.NroComprobante.ToString()
        Me.txtNroTerminal.Text = cPresentacion.comprobante.NroTerminal.ToString()

    End Sub

    ''' <summary>
    ''' Este metodo sirve para ver el detalle de la medicacion del estudio
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    ''' <remarks></remarks>
    Private Sub DataGrid1_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.DoubleClick

        Dim i As Integer

        i = DataGrid1.CurrentRowIndex
        If i = -1 Then
            MsgBox("No se ha seleccionado ningún estudio", MsgBoxStyle.Critical)
        Else
            Dim est As Estudio
            est = cPresentacion.getLineasDeFacturacionEstudios(i).objeto
            Dim frm As New AgragarMedicacion(est, False)
            'frm.MdiParent = Me.Parent.Parent
            frm.ShowDialog()
        End If
        Me.cargarGrilla()
    End Sub

    Private Sub btnAnularFactura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularFactura.Click

    End Sub
End Class
