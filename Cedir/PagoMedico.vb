Imports CedirNegocios
Imports System.Windows.Forms
Public Class PagoMedico
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
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents cmbMedicoAct As System.Windows.Forms.ComboBox
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents WallyGrid1 As Cedir.wallyGrid
    Friend WithEvents lblTotalHonorariosExentos As System.Windows.Forms.Label
    Friend WithEvents lblTotalHonorarios105 As System.Windows.Forms.Label
    Friend WithEvents lblTotalHonorarios21 As System.Windows.Forms.Label
    Friend WithEvents lblTotalIVA105 As System.Windows.Forms.Label
    Friend WithEvents lblTotalIVA21 As System.Windows.Forms.Label
    Friend WithEvents lblHonorariosExentos As System.Windows.Forms.Label
    Friend WithEvents lblGravadosAl10_5 As System.Windows.Forms.Label
    Friend WithEvents lblGravadosAl_21 As System.Windows.Forms.Label
    Friend WithEvents lblIVA10_5 As System.Windows.Forms.Label
    Friend WithEvents lblIVA21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAgregarObservacion As System.Windows.Forms.Button
    Friend WithEvents dtFecha As System.Windows.Forms.DateTimePicker
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbMedicoAct = New System.Windows.Forms.ComboBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnVer = New System.Windows.Forms.Button
        Me.dtFecha = New System.Windows.Forms.DateTimePicker
        Me.Button1 = New System.Windows.Forms.Button
        Me.lblTotalHonorariosExentos = New System.Windows.Forms.Label
        Me.lblTotalHonorarios105 = New System.Windows.Forms.Label
        Me.lblTotalHonorarios21 = New System.Windows.Forms.Label
        Me.lblTotalIVA105 = New System.Windows.Forms.Label
        Me.lblTotalIVA21 = New System.Windows.Forms.Label
        Me.lblHonorariosExentos = New System.Windows.Forms.Label
        Me.lblGravadosAl10_5 = New System.Windows.Forms.Label
        Me.lblGravadosAl_21 = New System.Windows.Forms.Label
        Me.lblIVA10_5 = New System.Windows.Forms.Label
        Me.lblIVA21 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAgregarObservacion = New System.Windows.Forms.Button
        Me.WallyGrid1 = New Cedir.wallyGrid
        Me.GroupBox1.SuspendLayout()
        CType(Me.WallyGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMedicoAct
        '
        Me.cmbMedicoAct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicoAct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicoAct.Location = New System.Drawing.Point(8, 16)
        Me.cmbMedicoAct.Name = "cmbMedicoAct"
        Me.cmbMedicoAct.Size = New System.Drawing.Size(216, 21)
        Me.cmbMedicoAct.TabIndex = 0
        Me.cmbMedicoAct.Text = "Seleccione un médico.."
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(15, 589)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(56, 23)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(6, 133)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(160, 24)
        Me.lblTotal.TabIndex = 3
        Me.lblTotal.Text = "Total a pagar: $ "
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(159, 589)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 4
        Me.btnCerrar.Text = "Cerrar"
        '
        'btnQuitar
        '
        Me.btnQuitar.Enabled = False
        Me.btnQuitar.Location = New System.Drawing.Point(334, 16)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 5
        Me.btnQuitar.Text = "Quitar Item"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(87, 589)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(56, 23)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.AllowDrop = True
        Me.txtObservaciones.Location = New System.Drawing.Point(12, 443)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(573, 92)
        Me.txtObservaciones.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(12, 426)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Observaciones"
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(264, 16)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(48, 23)
        Me.btnVer.TabIndex = 9
        Me.btnVer.Text = "Ver"
        '
        'dtFecha
        '
        Me.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFecha.Location = New System.Drawing.Point(968, 19)
        Me.dtFecha.Name = "dtFecha"
        Me.dtFecha.Size = New System.Drawing.Size(88, 20)
        Me.dtFecha.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(251, 589)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(96, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Agregar Estudios"
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'lblTotalHonorariosExentos
        '
        Me.lblTotalHonorariosExentos.Location = New System.Drawing.Point(227, 16)
        Me.lblTotalHonorariosExentos.Name = "lblTotalHonorariosExentos"
        Me.lblTotalHonorariosExentos.Size = New System.Drawing.Size(160, 24)
        Me.lblTotalHonorariosExentos.TabIndex = 13
        Me.lblTotalHonorariosExentos.Text = "honorarios exentos"
        Me.lblTotalHonorariosExentos.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalHonorarios105
        '
        Me.lblTotalHonorarios105.Location = New System.Drawing.Point(227, 40)
        Me.lblTotalHonorarios105.Name = "lblTotalHonorarios105"
        Me.lblTotalHonorarios105.Size = New System.Drawing.Size(160, 24)
        Me.lblTotalHonorarios105.TabIndex = 14
        Me.lblTotalHonorarios105.Text = "honorarios 15"
        Me.lblTotalHonorarios105.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalHonorarios21
        '
        Me.lblTotalHonorarios21.Location = New System.Drawing.Point(227, 63)
        Me.lblTotalHonorarios21.Name = "lblTotalHonorarios21"
        Me.lblTotalHonorarios21.Size = New System.Drawing.Size(160, 24)
        Me.lblTotalHonorarios21.TabIndex = 15
        Me.lblTotalHonorarios21.Text = "honorarios 21"
        Me.lblTotalHonorarios21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalIVA105
        '
        Me.lblTotalIVA105.Location = New System.Drawing.Point(227, 87)
        Me.lblTotalIVA105.Name = "lblTotalIVA105"
        Me.lblTotalIVA105.Size = New System.Drawing.Size(160, 24)
        Me.lblTotalIVA105.TabIndex = 16
        Me.lblTotalIVA105.Text = "iva105"
        Me.lblTotalIVA105.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalIVA21
        '
        Me.lblTotalIVA21.Location = New System.Drawing.Point(227, 109)
        Me.lblTotalIVA21.Name = "lblTotalIVA21"
        Me.lblTotalIVA21.Size = New System.Drawing.Size(160, 24)
        Me.lblTotalIVA21.TabIndex = 17
        Me.lblTotalIVA21.Text = "iva21"
        Me.lblTotalIVA21.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblHonorariosExentos
        '
        Me.lblHonorariosExentos.Location = New System.Drawing.Point(6, 16)
        Me.lblHonorariosExentos.Name = "lblHonorariosExentos"
        Me.lblHonorariosExentos.Size = New System.Drawing.Size(160, 24)
        Me.lblHonorariosExentos.TabIndex = 18
        Me.lblHonorariosExentos.Text = "Honorarios exentos  :    "
        '
        'lblGravadosAl10_5
        '
        Me.lblGravadosAl10_5.Location = New System.Drawing.Point(6, 40)
        Me.lblGravadosAl10_5.Name = "lblGravadosAl10_5"
        Me.lblGravadosAl10_5.Size = New System.Drawing.Size(160, 24)
        Me.lblGravadosAl10_5.TabIndex = 19
        Me.lblGravadosAl10_5.Text = "Honorarios Gravados al 10.5  :  "
        '
        'lblGravadosAl_21
        '
        Me.lblGravadosAl_21.Location = New System.Drawing.Point(6, 63)
        Me.lblGravadosAl_21.Name = "lblGravadosAl_21"
        Me.lblGravadosAl_21.Size = New System.Drawing.Size(160, 24)
        Me.lblGravadosAl_21.TabIndex = 20
        Me.lblGravadosAl_21.Text = "Honorarios Gravados al 21  :  "
        '
        'lblIVA10_5
        '
        Me.lblIVA10_5.Location = New System.Drawing.Point(6, 87)
        Me.lblIVA10_5.Name = "lblIVA10_5"
        Me.lblIVA10_5.Size = New System.Drawing.Size(160, 24)
        Me.lblIVA10_5.TabIndex = 21
        Me.lblIVA10_5.Text = "IVA 10.5 %  :  "
        '
        'lblIVA21
        '
        Me.lblIVA21.Location = New System.Drawing.Point(6, 109)
        Me.lblIVA21.Name = "lblIVA21"
        Me.lblIVA21.Size = New System.Drawing.Size(160, 24)
        Me.lblIVA21.TabIndex = 22
        Me.lblIVA21.Text = "IVA 21%  :  "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblHonorariosExentos)
        Me.GroupBox1.Controls.Add(Me.lblIVA21)
        Me.GroupBox1.Controls.Add(Me.lblTotalHonorariosExentos)
        Me.GroupBox1.Controls.Add(Me.lblIVA10_5)
        Me.GroupBox1.Controls.Add(Me.lblTotalHonorarios105)
        Me.GroupBox1.Controls.Add(Me.lblGravadosAl_21)
        Me.GroupBox1.Controls.Add(Me.lblTotalHonorarios21)
        Me.GroupBox1.Controls.Add(Me.lblGravadosAl10_5)
        Me.GroupBox1.Controls.Add(Me.lblTotalIVA105)
        Me.GroupBox1.Controls.Add(Me.lblTotalIVA21)
        Me.GroupBox1.Controls.Add(Me.lblTotal)
        Me.GroupBox1.Location = New System.Drawing.Point(757, 443)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(437, 167)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Totales"
        '
        'btnAgregarObservacion
        '
        Me.btnAgregarObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAgregarObservacion.Location = New System.Drawing.Point(12, 541)
        Me.btnAgregarObservacion.Name = "btnAgregarObservacion"
        Me.btnAgregarObservacion.Size = New System.Drawing.Size(126, 22)
        Me.btnAgregarObservacion.TabIndex = 24
        Me.btnAgregarObservacion.Text = "Agregar Descripcion de totales"
        '
        'WallyGrid1
        '
        Me.WallyGrid1.AllowSorting = False
        Me.WallyGrid1.DataMember = ""
        Me.WallyGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.WallyGrid1.Location = New System.Drawing.Point(12, 66)
        Me.WallyGrid1.Name = "WallyGrid1"
        Me.WallyGrid1.Size = New System.Drawing.Size(1182, 345)
        Me.WallyGrid1.TabIndex = 12
        '
        'PagoMedico
        '
        Me.AllowDrop = True
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1202, 624)
        Me.Controls.Add(Me.btnAgregarObservacion)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.WallyGrid1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtFecha)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.cmbMedicoAct)
        Me.Name = "PagoMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo pago a Médico"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.WallyGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim catalogoEstudios As New CatalogoDeEstudios
    Dim catalogoDeFacturacion As New CatalogoDePresentaciones
    Dim arrMedicos As ArrayList
    Dim myTable As DataTable = New DataTable("myTable")
    Dim total As Double
    Dim cPago As CedirNegocios.PagoMedico
    Private currentMedico As New Medico
    Dim arrl As ArrayList

    'Dim arrFacturaciones As New ArrayList

    Private Sub cargarCombo()
        Dim catalogoMedicos As New CatalogoDeMedicos
        arrMedicos = catalogoMedicos.TodosLosMedicos()
        Dim med As Medico
        Dim i As Integer
        For i = 0 To arrMedicos.Count - 1
            med = arrMedicos(i)
            cmbMedicoAct.Items.Add(med.nombreCompleto)
        Next
    End Sub

    Private Sub PagoMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Actuante", Type.GetType("System.String"))
        Dim clMedSolicitante As New DataColumn("Solicitante", Type.GetType("System.String"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.String"))
        Dim clFechaCobro As New DataColumn("Fecha Cobro", Type.GetType("System.DateTime"))
        Dim clImporteEstudio As New DataColumn("Importe", Type.GetType("System.String"))
        Dim clImporteRealCobrado As New DataColumn("Cobrado", Type.GetType("System.String"))
        Dim clPagoMedAct As New DataColumn("Pago", Type.GetType("System.String"))
        Dim clPorcentajeRetencionCedir As New DataColumn("%RetencionCedir", Type.GetType("System.String"))
        Dim clPorcentajeGastosAd As New DataColumn("G.A.", Type.GetType("System.String"))
        Dim clMontoDelEstudioIVA105 As New DataColumn("MontoIVA10.5Estudio", Type.GetType("System.String"))
        Dim clMontoDelEstudioIVA21 As New DataColumn("MontoIVA21Estudio", Type.GetType("System.String"))
        Dim clTotalConIVA As New DataColumn("Total", Type.GetType("System.String"))


        myTable.Columns.Add(clFechaEstudio)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clObraSocial)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clMedSolicitante)
        myTable.Columns.Add(clImporteRealCobrado)
        myTable.Columns.Add(clFechaCobro)
        myTable.Columns.Add(clPorcentajeGastosAd)
        myTable.Columns.Add(clImporteEstudio)
        myTable.Columns.Add(clPorcentajeRetencionCedir)
        myTable.Columns.Add(clPagoMedAct)
        myTable.Columns.Add(clMontoDelEstudioIVA105)
        myTable.Columns.Add(clMontoDelEstudioIVA21)
        myTable.Columns.Add(clTotalConIVA)



        ''''''
        Dim tbl As New DataGridTableStyle
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Fecha", "Fecha", 65, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Paciente", "Paciente", 100, 50, String.Empty, HorizontalAlignment.Center, True))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Obra Social", "Obra Social", 100, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Práctica", "Práctica", 150, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Actuante", "Actuante", 100, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Solicitante", "Solicitante", 100, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Cobrado", "Cobrado", 50, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Fecha Cobro", "Fecha Cobro", 65, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("G.A.", "G.A.", 50, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Importe", "Importe", 50, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("%RetencionCedir", "%RetencionCedir", 50, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Pago", "Pago", 50, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("MontoIVA10.5Estudio", "MontoIVA10.5Estudio", 70, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("MontoIVA21Estudio", "MontoIVA21Estudio", 70, 50, String.Empty, HorizontalAlignment.Center, False))
        tbl.GridColumnStyles.Add(New dgrDatagridTextBoxColumn("Total", "Total", 60, 50, String.Empty, HorizontalAlignment.Center, False))

        tbl.MappingName = "myTable"
        tbl.BackColor = Color.LightGray
        tbl.ForeColor = Color.SlateBlue
        tbl.AlternatingBackColor = Color.White
        tbl.AllowSorting = False

        tbl.HeaderForeColor = Color.MediumSlateBlue
        tbl.HeaderBackColor = Color.WhiteSmoke
        tbl.GridLineColor = Color.MediumPurple



        WallyGrid1.TableStyles.Clear()
        WallyGrid1.TableStyles.Add(tbl)

        cargarCombo()

        btnAceptar.Enabled = False
        btnImprimir.Enabled = False

        'AddHandler myTable.RowChanged, New DataRowChangeEventHandler(AddressOf Row_Changed)
        AddHandler myTable.ColumnChanged, New DataColumnChangeEventHandler(AddressOf Column_Changed)
    End Sub

    Private Sub cmbMedicoAct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicoAct.SelectedIndexChanged
        myTable.Clear()
        btnAceptar.Enabled = True
        btnImprimir.Enabled = True
        btnQuitar.Enabled = True
        txtObservaciones.Text = ""
        currentMedico = TryCast(Me.arrMedicos(Me.cmbMedicoAct.SelectedIndex), Medico)
        cPago = New CedirNegocios.PagoMedico(currentMedico)
        CargarGrilla()
    End Sub


    Private Sub CargarGrilla()
        Dim NewRow As DataRow
        Dim i As Integer
        total = 0

        'arrFacturaciones.Clear()

        arrl = cPago.getLineas
        Dim banderaPCF As String = ""

        Dim cLinea As LineaPagoMedico
        Dim est As Estudio

        Const PARTICULAR = 2
        Const PARTICULAR_ESPECIAL = 134
        Const ANALISIS_BIOQUIMICOS = 91
        Const OSDE = 3
        Const OSDE_CEDIR = 79
        Const VIDEOENDOSCOPIA_BAJA_TERAPEUTICA = 25
        Const VIDEOENDOSCOPIA_ALTA_TERAPEUTICA = 27
        Const CONSULTA = 20
        Const ELECTROCARDEOGRAMA = 46
        Const DRENJUTO = 558

        Dim cCal As New CalculadorHonorariosPagoMedico()
        Dim catalogoDePresentacion As New CatalogoDePresentaciones

        For i = 0 To arrl.Count - 1
            cLinea = arrl(i)
            est = cLinea.estudio
            NewRow = myTable.NewRow()

            If est.esPagoContraFactura = 0 Then
                cLinea.estudio.presentacion = catalogoDePresentacion.find(cLinea.estudio.idFacturacion)
                arrl(i) = cLinea
            End If

            cLinea.gastosAdministrativos = cCal.getGastosAdministrativos(cLinea.estudio)
            Dim importeEstudio As Decimal = cCal.getImporteLineaPago(cLinea)

            Dim porcentaje As Single
            Dim pagoDelCorrespondiente As Single

            If est.esPagoContraFactura = 1 Then
                banderaPCF = "*" 'Es pago contra factura
                If ((est.getCondicionMedico(currentMedico.idMedico) = "actuante" Or est.getCondicionMedico(currentMedico.idMedico) = "actuante-solicitante") And (est.obraSocial.idObraSocial <> PARTICULAR_ESPECIAL And est.obraSocial.idObraSocial <> PARTICULAR)) Then
                    'Si es actuante y NO es de OS Particular
                    porcentaje = 100 - cLinea.getPorcentaje()
                    If (est.practica.idEstudio = VIDEOENDOSCOPIA_BAJA_TERAPEUTICA Or est.practica.idEstudio = VIDEOENDOSCOPIA_ALTA_TERAPEUTICA Or est.practica.idEstudio = 118 Or est.practica.idEstudio = 121) And (est.obraSocial.idObraSocial = OSDE Or est.obraSocial.idObraSocial = OSDE_CEDIR) Then
                        pagoDelCorrespondiente = ((importeEstudio - cLinea.getDescuentoPorPolipectomiaOSDE) * porcentaje / 100) + cLinea.getDescuentoPorPolipectomiaOSDE
                    Else
                        pagoDelCorrespondiente = importeEstudio * porcentaje / 100
                    End If
                    pagoDelCorrespondiente = pagoDelCorrespondiente * (-1)
                End If

                If ((est.getCondicionMedico(currentMedico.idMedico) = "actuante" Or est.getCondicionMedico(currentMedico.idMedico) = "actuante-solicitante") And (est.obraSocial.idObraSocial = PARTICULAR_ESPECIAL Or est.obraSocial.idObraSocial = PARTICULAR)) Then
                    ' Si el estudio es actuante y particular, y pago contra factura, significa que el medico se llevó el importe del estudio en el dia. No hay que pagarle nada al actuante
                    ' salvo el caso de analisis bioquimicos.
                    porcentaje = 0
                    pagoDelCorrespondiente = 0.0

                    If (est.practica.idEstudio = ANALISIS_BIOQUIMICOS) Then
                        porcentaje = cLinea.getPorcentaje()
                        pagoDelCorrespondiente = importeEstudio * porcentaje / 100
                    End If
                End If

                If (est.getCondicionMedico(currentMedico.idMedico) = "solicitante") Then
                    porcentaje = cLinea.getPorcentaje()
                    pagoDelCorrespondiente = importeEstudio * porcentaje / 100
                End If

                NewRow("Cobrado") = est.PagoContraFactura
            Else
                banderaPCF = "" 'NO es pago contra factura
                porcentaje = cLinea.getPorcentaje() 'obtengo el porcentaje que le corresponde al medico
                pagoDelCorrespondiente = importeEstudio * porcentaje / 100

                'Si es Conuslta, ElectroCardograma y solo para enjuto 
                'If ((est.practica.idEstudio = CONSULTA Or est.practica.idEstudio = ELECTROCARDEOGRAMA) And currentMedico.idMedico = DRENJUTO) Then
                '    pagoDelCorrespondiente = 22.5
                'End If ESTO SE COMENTA YA QUE AHORA ENJUTO COBRA COMO CUALQUIERA

                'tenemos que corroborar que esto sea asi, ya que podriamos tomar el valor
                'guardado en DB tblPagoCobroEstudio -> "importeEstudioCobrado"
                NewRow("Cobrado") = est.importeEstudioCobrado
            End If

            Dim IVASobreImportePagoAlMedico As Decimal = 0
            If currentMedico.esResponsableInscripto And est.esPagoContraFactura = 0 And est.getCondicionMedico(currentMedico.idMedico) <> "solicitante" Then
                Select Case True
                    Case est.presentacion.comprobante.Gravado.id = 2 And pagoDelCorrespondiente > 0.0
                        NewRow("MontoIVA10.5Estudio") = Format(pagoDelCorrespondiente * 0.105, "############0.00")
                        NewRow("MontoIVA21Estudio") = 0
                    Case est.presentacion.comprobante.Gravado.id = 3 And pagoDelCorrespondiente > 0.0
                        NewRow("MontoIVA21Estudio") = Format(pagoDelCorrespondiente * 0.21, "############0.00")
                        NewRow("MontoIVA10.5Estudio") = 0
                    Case Else
                        NewRow("MontoIVA21Estudio") = 0
                        NewRow("MontoIVA10.5Estudio") = 0
                End Select
                IVASobreImportePagoAlMedico = est.presentacion.comprobante.Gravado.porcentaje * pagoDelCorrespondiente / 100
            Else
                NewRow("MontoIVA10.5Estudio") = 0
                NewRow("MontoIVA21Estudio") = 0
            End If

            total += pagoDelCorrespondiente

            NewRow("Paciente") = banderaPCF & est.paciente.nombreCompleto
            NewRow("Fecha") = est.fechaEstudio
            NewRow("Importe") = Math.Round(importeEstudio, 2)
            NewRow("Fecha Cobro") = est.fechaCobro
            NewRow("Obra Social") = est.obraSocial.ObraSocial
            NewRow("Práctica") = est.practica.Estudio
            NewRow("Actuante") = est.medicoActuante.nombreCompleto
            NewRow("Solicitante") = est.medicoSolicitante.nombreCompleto
            NewRow("%RetencionCedir") = CStr(porcentaje) & "%"
            NewRow("G.A.") = CStr(cLinea.gastosAdministrativos) & "%"
            NewRow("Pago") = Math.Round(pagoDelCorrespondiente, 2)
            NewRow("Total") = Math.Round(pagoDelCorrespondiente + IVASobreImportePagoAlMedico, 2)
            myTable.Rows.Add(NewRow)

            If banderaPCF <> "" Then
                txtObservaciones.Text = "* Pago contra factura"
            End If
        Next

        myTable.AcceptChanges()


        WallyGrid1.DataSource = myTable
        setLabelsHonorarios()
    End Sub

    Private Sub Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If cPago.getLineas.Count = 0 Then
            MsgBox("No hay estudios para pagar", MsgBoxStyle.Information)
        Else
            setLabelsHonorarios()
            Dim r As Integer
            r = MsgBox("¿Esta seguro que desea crear un pago a médico?", MsgBoxStyle.YesNo, "Crear Pago a Médico")
            If r = 6 Then
                cPago.observacion = txtObservaciones.Text
                cPago.fecha = dtFecha.Value.Date
                Dim cLinea As LineaPagoMedico
                For i As Integer = 0 To cPago.getLineas.Count - 1
                    cLinea = cPago.getLineas(i)
                    cLinea.importe = CSng(WallyGrid1.Item(i, 11)) 'columna "Pago"
                    Select Case True
                        Case Convert.ToDecimal(myTable.Rows(i).Item("MontoIVA10.5Estudio")) <> 0.0
                            cLinea.porcentajeIVAPagoMedicoActuante = 10.5
                        Case Convert.ToDecimal(myTable.Rows(i).Item("MontoIVA21Estudio")) <> 0.0
                            cLinea.porcentajeIVAPagoMedicoActuante = 21
                        Case Else
                            cLinea.porcentajeIVAPagoMedicoActuante = 0.0
                    End Select
                Next

                Dim resp As String = cPago.crearPago()
                If resp = "ok" Then
                    MsgBox("El pago se ha guardado con éxito")
                    btnAceptar.Enabled = False
                    btnQuitar.Enabled = False
                Else
                    MsgBox("Se ha producido un error al crear el pago. Cierre la ventana y vuelva a intentarlo. Detalle del error: " & resp, MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim r As New rptViewer
        Me.AddOwnedForm(r)
        If currentMedico.esResponsableInscripto Then
            r.printPagoMedicosInscriptos(currentMedico.nombreCompleto, Me.myTable, Me.txtObservaciones.Text, Me.lblTotalHonorariosExentos.Text, Me.lblTotalHonorarios105.Text, Me.lblTotalHonorarios21.Text)
        Else
            r.printPagoMedicosMonotributistas(currentMedico.nombreCompleto, Me.myTable, Me.txtObservaciones.Text)
        End If
        r.Show()

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim i As Integer
        i = WallyGrid1.CurrentRowIndex
        If i = -1 Then
            MsgBox("No se ha seleccionado ningún estudio", MsgBoxStyle.Critical)
        Else
            Dim success As Boolean = cPago.quitarLinea(i)
            If success Then
                myTable.Rows(i).Delete()
                myTable.AcceptChanges()
                WallyGrid1.DataSource = myTable

                arrl.Remove(i)

                setLabelsHonorarios()
            Else
                MsgBox("Se ha producido un error al intentar quitar el estudio. Vuelva a intentarlo.")
            End If
        End If
    End Sub

    Sub setLabelsHonorarios()
        Dim iva10 As Decimal
        Dim iva21 As Decimal
        Dim exento As Decimal
        Dim total As Decimal = 0.0
        Dim honorario21 As Decimal = 0.0
        Dim honorario10 As Decimal = 0.0
        Dim i As Integer
        For i = 0 To arrl.Count - 1
            Select Case True
                Case Convert.ToDecimal(Me.myTable.Rows(i).Item("MontoIVA10.5Estudio")) <> 0
                    honorario10 += Convert.ToDecimal(Me.myTable.Rows(i).Item("Pago"))
                Case Convert.ToDecimal(Me.myTable.Rows(i).Item("MontoIVA21Estudio")) <> 0
                    honorario21 += Convert.ToDecimal(Me.myTable.Rows(i).Item("Pago"))
                Case Else
                    exento += Convert.ToDecimal(Me.myTable.Rows(i).Item("Pago"))
            End Select
            total = total + Convert.ToDecimal(Me.myTable.Rows(i).Item("Total"))
            iva10 = iva10 + Convert.ToDecimal(Me.myTable.Rows(i).Item("MontoIVA10.5Estudio"))
            iva21 = iva21 + Convert.ToDecimal(Me.myTable.Rows(i).Item("MontoIVA21Estudio"))
        Next
        Me.lblTotal.Text = "Total a pagar: $ " & Format(total, "############0.00")
        Me.lblTotalIVA105.Text = Format(iva10, "############0.00")
        Me.lblTotalIVA21.Text = Format(iva21, "############0.00")
        Me.lblTotalHonorarios21.Text = Format(honorario21, "############0.00")
        Me.lblTotalHonorarios105.Text = Format(honorario10, "############0.00")
        Me.lblTotalHonorariosExentos.Text = Format(exento, "############0.00")

    End Sub

    Private Sub WallyGrid1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim cLinea As LineaPagoMedico
        Dim i As Integer = WallyGrid1.CurrentRowIndex
        cLinea = cPago.getLineas(i)

        Dim frm As New DetalleEstudio(cLinea.estudio)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim i As Integer = WallyGrid1.CurrentRowIndex
        If i = -1 Then
            MsgBox("No se ha seleccionado ningún estudio", MsgBoxStyle.Critical)
        Else
            Dim cLinea As LineaPagoMedico
            cLinea = cPago.getLineas(i)
            Dim frm As New DetalleEstudio(cLinea.estudio)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim f As New ConsultaEstudiosPro
        f.MdiParent = Me.MdiParent
        f.Show()
    End Sub

    Private Sub WallyGrid1_DoubleClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WallyGrid1.DoubleClick
        Dim cLinea As LineaPagoMedico
        Dim i As Integer = WallyGrid1.CurrentRowIndex
        cLinea = cPago.getLineas(i)

        Dim frm As New DetalleEstudio(cLinea.estudio)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarObservacion.Click
        Dim recuadroInscriptos As String
        recuadroInscriptos = Me.lblHonorariosExentos.Text & Me.lblTotalHonorariosExentos.Text & ",  " & vbCrLf & Me.lblGravadosAl_21.Text & Me.lblTotalHonorarios21.Text & vbCrLf & _
        Me.lblGravadosAl10_5.Text & Me.lblTotalHonorarios105.Text & ",  " & vbCrLf & Me.lblIVA10_5.Text & Me.lblTotalIVA105.Text & ",  " & vbCrLf & Me.lblIVA21.Text & Me.lblTotalIVA21.Text


        Me.txtObservaciones.Text = Me.txtObservaciones.Text & vbCrLf & recuadroInscriptos
    End Sub

    Private Sub HandleKeydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        Try
            MsgBox(e.KeyCode.ToString)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub calcularImporteDeColumnas()
        ''recalculamo   s las celdas de iva y total a pagar, ya que el evento se dispara cuando cambian la celda de "Pago"
        If Me.WallyGrid1.CurrentCell.ColumnNumber < 11 Or Me.WallyGrid1.CurrentCell.RowNumber > arrl.Count - 1 Then
            Exit Sub
        End If

        Dim fila As Integer = Me.WallyGrid1.CurrentCell.RowNumber
        Dim cLinea As LineaPagoMedico

        cLinea = arrl(fila)
        Dim pago As Decimal = Convert.ToDecimal(myTable.Rows(fila).Item("Pago"))

        If currentMedico.esResponsableInscripto And cLinea.estudio.esPagoContraFactura = 0 Then
            Select Case True
                Case cLinea.estudio.presentacion.comprobante.Gravado.id = 2 And pago > 0.0
                    myTable.Rows(fila).Item("MontoIVA10.5Estudio") = Format(pago * 0.105, "############0.00")
                Case cLinea.estudio.presentacion.comprobante.Gravado.id = 3 And pago > 0.0
                    myTable.Rows(fila).Item("MontoIVA21Estudio") = Format(pago * 0.21, "############0.00")
                Case Else
                    myTable.Rows(fila).Item("MontoIVA21Estudio") = 0
                    myTable.Rows(fila).Item("MontoIVA10.5Estudio") = 0
            End Select
        End If

        myTable.Rows(fila).Item("Total") = pago + Convert.ToDecimal(myTable.Rows(fila).Item("MontoIVA21Estudio")) + Convert.ToDecimal(myTable.Rows(fila).Item("MontoIVA10.5Estudio"))
        'este cambio tiene que suceder cuando el usuario presiona enter
    End Sub

    Private Sub Column_Changed(ByVal sender As Object, ByVal e As DataColumnChangeEventArgs)
        'Como la columna de Total, cambia al cambiar las otras celdas, tenemos que evitar que se tenga en cuenta su cambio
        'para el calculo de valores. Sólo nos interesa detectar el cambio en otras celdas.
        If myTable.Rows.Count > 0 And e.Column.ColumnName = "Pago" And Not e.Row.IsNull("Total") Then
            calcularImporteDeColumnas()
            setLabelsHonorarios()
        End If
    End Sub


End Class
