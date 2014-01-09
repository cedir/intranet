Imports CedirNegocios
Public Class MiCuenta
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
    Friend WithEvents cmbMedicoAct As System.Windows.Forms.ComboBox
    Friend WithEvents DataGrid2 As wallyGrid
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnFiltrarPagos As System.Windows.Forms.Button
    Friend WithEvents txtFechaHastaPagos As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaDesdePagos As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents txtPaciente As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaDesdeEstudios As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaHastaEstudios As System.Windows.Forms.TextBox
    Friend WithEvents btnRadioPagados As System.Windows.Forms.RadioButton
    Friend WithEvents btnRadioCobrados As System.Windows.Forms.RadioButton
    Friend WithEvents btnRadioTodos As System.Windows.Forms.RadioButton
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.cmbMedicoAct = New System.Windows.Forms.ComboBox
        Me.DataGrid2 = New wallyGrid
        Me.btnVer = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtPaciente = New System.Windows.Forms.TextBox
        Me.txtFechaDesdeEstudios = New System.Windows.Forms.TextBox
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtFechaHastaEstudios = New System.Windows.Forms.TextBox
        Me.btnRadioPagados = New System.Windows.Forms.RadioButton
        Me.btnRadioCobrados = New System.Windows.Forms.RadioButton
        Me.btnRadioTodos = New System.Windows.Forms.RadioButton
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btnFiltrarPagos = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFechaHastaPagos = New System.Windows.Forms.TextBox
        Me.txtFechaDesdePagos = New System.Windows.Forms.TextBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 128)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(488, 128)
        Me.DataGrid1.TabIndex = 0
        '
        'cmbMedicoAct
        '
        Me.cmbMedicoAct.Location = New System.Drawing.Point(8, 16)
        Me.cmbMedicoAct.Name = "cmbMedicoAct"
        Me.cmbMedicoAct.Size = New System.Drawing.Size(256, 21)
        Me.cmbMedicoAct.TabIndex = 1
        Me.cmbMedicoAct.Text = "Seleccione un médico.."
        '
        'DataGrid2
        '
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(8, 120)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.ReadOnly = True
        Me.DataGrid2.Size = New System.Drawing.Size(736, 200)
        Me.DataGrid2.TabIndex = 2
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(16, 272)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(48, 24)
        Me.btnVer.TabIndex = 3
        Me.btnVer.Text = "Ver"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtPaciente)
        Me.GroupBox1.Controls.Add(Me.txtFechaDesdeEstudios)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtFechaHastaEstudios)
        Me.GroupBox1.Controls.Add(Me.btnRadioPagados)
        Me.GroupBox1.Controls.Add(Me.btnRadioCobrados)
        Me.GroupBox1.Controls.Add(Me.btnRadioTodos)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(736, 96)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtros"
        '
        'txtPaciente
        '
        Me.txtPaciente.Location = New System.Drawing.Point(80, 64)
        Me.txtPaciente.Name = "txtPaciente"
        Me.txtPaciente.Size = New System.Drawing.Size(128, 20)
        Me.txtPaciente.TabIndex = 5
        Me.txtPaciente.Text = ""
        '
        'txtFechaDesdeEstudios
        '
        Me.txtFechaDesdeEstudios.Location = New System.Drawing.Point(80, 24)
        Me.txtFechaDesdeEstudios.Name = "txtFechaDesdeEstudios"
        Me.txtFechaDesdeEstudios.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaDesdeEstudios.TabIndex = 3
        Me.txtFechaDesdeEstudios.Text = ""
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(272, 64)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.TabIndex = 11
        Me.btnFiltrar.Text = "Filtrar"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(192, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Fecha hasta:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(28, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 23)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Paciente:"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(8, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Fecha desde:"
        '
        'txtFechaHastaEstudios
        '
        Me.txtFechaHastaEstudios.Location = New System.Drawing.Point(272, 24)
        Me.txtFechaHastaEstudios.Name = "txtFechaHastaEstudios"
        Me.txtFechaHastaEstudios.Size = New System.Drawing.Size(80, 20)
        Me.txtFechaHastaEstudios.TabIndex = 4
        Me.txtFechaHastaEstudios.Text = ""
        '
        'btnRadioPagados
        '
        Me.btnRadioPagados.Location = New System.Drawing.Point(640, 64)
        Me.btnRadioPagados.Name = "btnRadioPagados"
        Me.btnRadioPagados.Size = New System.Drawing.Size(72, 16)
        Me.btnRadioPagados.TabIndex = 2
        Me.btnRadioPagados.Text = "Pagados"
        '
        'btnRadioCobrados
        '
        Me.btnRadioCobrados.Location = New System.Drawing.Point(640, 40)
        Me.btnRadioCobrados.Name = "btnRadioCobrados"
        Me.btnRadioCobrados.Size = New System.Drawing.Size(88, 16)
        Me.btnRadioCobrados.TabIndex = 1
        Me.btnRadioCobrados.Text = "Cobrados"
        '
        'btnRadioTodos
        '
        Me.btnRadioTodos.Checked = True
        Me.btnRadioTodos.Location = New System.Drawing.Point(640, 16)
        Me.btnRadioTodos.Name = "btnRadioTodos"
        Me.btnRadioTodos.Size = New System.Drawing.Size(64, 18)
        Me.btnRadioTodos.TabIndex = 0
        Me.btnRadioTodos.TabStop = True
        Me.btnRadioTodos.Text = "Todos"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(8, 328)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 23)
        Me.btnImprimir.TabIndex = 5
        Me.btnImprimir.Text = "Imprimir"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnFiltrarPagos)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtFechaHastaPagos)
        Me.GroupBox2.Controls.Add(Me.txtFechaDesdePagos)
        Me.GroupBox2.Location = New System.Drawing.Point(16, 16)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(408, 104)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Filtros"
        '
        'btnFiltrarPagos
        '
        Me.btnFiltrarPagos.Location = New System.Drawing.Point(232, 64)
        Me.btnFiltrarPagos.Name = "btnFiltrarPagos"
        Me.btnFiltrarPagos.TabIndex = 8
        Me.btnFiltrarPagos.Text = "Filtrar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(16, 64)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 23)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Fecha hasta:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(8, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha desde:"
        '
        'txtFechaHastaPagos
        '
        Me.txtFechaHastaPagos.Location = New System.Drawing.Point(96, 64)
        Me.txtFechaHastaPagos.Name = "txtFechaHastaPagos"
        Me.txtFechaHastaPagos.TabIndex = 5
        Me.txtFechaHastaPagos.Text = ""
        '
        'txtFechaDesdePagos
        '
        Me.txtFechaDesdePagos.Location = New System.Drawing.Point(96, 32)
        Me.txtFechaDesdePagos.Name = "txtFechaDesdePagos"
        Me.txtFechaDesdePagos.TabIndex = 4
        Me.txtFechaDesdePagos.Text = ""
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(24, 440)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(8, 48)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(760, 384)
        Me.TabControl1.TabIndex = 8
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Controls.Add(Me.DataGrid2)
        Me.TabPage1.Controls.Add(Me.btnImprimir)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(752, 358)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudios"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.DataGrid1)
        Me.TabPage2.Controls.Add(Me.btnVer)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(752, 366)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pagos"
        '
        'MiCuenta
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(776, 472)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.cmbMedicoAct)
        Me.Name = "MiCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mi Cuenta"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim catalogoEstudios As New CatalogoDeEstudios
    Dim arrMedicos As ArrayList
    Dim myTable As DataTable = New DataTable("myTable")
    Dim tblEstudiosMedico As DataTable = New DataTable("tblEstudios")
    Dim arrl As ArrayList
    Dim arrEstudios As ArrayList
    Dim cMedico As Medico

    Private Sub MiCuenta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clFecha As New DataColumn("Fecha de pago", Type.GetType("System.DateTime"))
        Dim clObservaciones As New DataColumn("Observaciones", Type.GetType("System.String"))
        Dim clCodigo As New DataColumn("Código", Type.GetType("System.String"))

        myTable.Columns.Add(clCodigo)
        myTable.Columns.Add(clFecha)
        myTable.Columns.Add(clObservaciones)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "myTable"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Código"
        TextCol2.HeaderText = "Código"
        TextCol2.Width = 50
        ts1.GridColumnStyles.Add(TextCol2)

        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "Fecha de pago"
        TextCol0.HeaderText = "Fecha de pago"
        TextCol0.Width = 90
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Observaciones"
        TextCol.HeaderText = "Observaciones"
        TextCol.Width = 290
        ts1.GridColumnStyles.Add(TextCol)

        DataGrid1.TableStyles.Add(ts1)

        'Grilla de resumen de estudios para un medico
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clPractica As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clPaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clCondicion As New DataColumn("Condición", Type.GetType("System.String"))
        Dim clEstado As New DataColumn("Estado", Type.GetType("System.String"))

        tblEstudiosMedico.Columns.Add(clFechaEstudio)
        tblEstudiosMedico.Columns.Add(clPaciente)
        tblEstudiosMedico.Columns.Add(clObraSocial)
        tblEstudiosMedico.Columns.Add(clPractica)
        tblEstudiosMedico.Columns.Add(clCondicion)
        tblEstudiosMedico.Columns.Add(clEstado)

        Dim ts2 As New DataGridTableStyle
        ts2.MappingName = "tblEstudios"
        ts2.BackColor = Color.LightGray
        ts2.ForeColor = Color.SlateBlue
        ts2.AlternatingBackColor = Color.White
        ts2.AllowSorting = False

        ts2.HeaderForeColor = Color.MediumSlateBlue
        ts2.HeaderBackColor = Color.WhiteSmoke
        ts2.GridLineColor = Color.MediumPurple

        Dim TextCol0m As New DataGridTextBoxColumn
        TextCol0m.MappingName = "Fecha"
        TextCol0m.HeaderText = "Fecha"
        TextCol0m.Width = 70
        ts2.GridColumnStyles.Add(TextCol0m)

        Dim TextColm As New DataGridTextBoxColumn
        TextColm.MappingName = "Paciente"
        TextColm.HeaderText = "Paciente"
        TextColm.Width = 105
        ts2.GridColumnStyles.Add(TextColm)

        Dim TextCol5m As New DataGridTextBoxColumn
        TextCol5m.MappingName = "Obra Social"
        TextCol5m.HeaderText = "Obra Social"
        TextCol5m.Width = 190
        ts2.GridColumnStyles.Add(TextCol5m)

        Dim TextCol3m As New DataGridTextBoxColumn
        TextCol3m.MappingName = "Práctica"
        TextCol3m.HeaderText = "Práctica"
        TextCol3m.Width = 150
        ts2.GridColumnStyles.Add(TextCol3m)

        Dim TextCol4m As New DataGridTextBoxColumn
        TextCol4m.MappingName = "Condición"
        TextCol4m.HeaderText = "Condición"
        TextCol4m.Width = 95
        ts2.GridColumnStyles.Add(TextCol4m)

        Dim TextCol6m As New DataGridTextBoxColumn
        TextCol6m.MappingName = "Estado"
        TextCol6m.HeaderText = "Estado"
        TextCol6m.Width = 70
        ts2.GridColumnStyles.Add(TextCol6m)

        DataGrid2.TableStyles.Add(ts2)

        btnFiltrar.Enabled = False
        btnFiltrarPagos.Enabled = False
        cargarCombo()

        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser

        Dim cGrupo As Grupo = cUsuario.getGroupByName("medico")
        Dim esMedico As Boolean
        If cGrupo Is Nothing Then
            esMedico = False
        Else
            esMedico = True
        End If

        If esMedico And cUsuario.getGrupos.Count = 1 Then
            Dim i As Integer
            Dim cMedico As Medico
            For i = 0 To arrMedicos.Count - 1
                cMedico = arrMedicos(i)
                If cUsuario.idMedico = cMedico.idMedico Then
                    cmbMedicoAct.SelectedItem = cMedico.nombreCompleto
                    Exit For
                End If
            Next

            cmbMedicoAct.Enabled = False
        End If
    End Sub

    Private Sub CargarGrilla()
        Dim NewRow As DataRow
        Dim i As Integer
        Dim pago As CedirNegocios.PagoMedico
        myTable.Clear()
        For i = 0 To arrl.Count - 1
            pago = arrl(i)
            NewRow = myTable.NewRow()
            NewRow("Código") = pago.nroPago
            NewRow("Fecha de pago") = pago.fecha
            NewRow("Observaciones") = pago.observacion

            myTable.Rows.Add(NewRow)
        Next
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable


    End Sub
    Private Sub cargarEstudiosDeMedico()
        Dim NewRow As DataRow
        Dim i As Integer
        Dim est As Estudio
        tblEstudiosMedico.Clear()
        If arrEstudios.Count > 0 Then
            For i = 0 To arrEstudios.Count - 1
                NewRow = tblEstudiosMedico.NewRow()
                est = arrEstudios(i)
                NewRow("Fecha") = est.fechaEstudio
                NewRow("Paciente") = est.paciente.nombreCompleto
                NewRow("Obra Social") = est.obraSocial.ObraSocial
                NewRow("Práctica") = est.practica.Estudio
                NewRow("Condición") = est.getCondicionMedico(cMedico.idMedico)

                Dim estado As String
                If est.fechaCobro <> "0:00:00" Then
                    estado = "Cobrado"
                    Dim condicionMedico As String = est.getCondicionMedico(cMedico.idMedico)
                    If condicionMedico = "actuante" Or condicionMedico = "actuante-solicitante" Then
                        If est.nroPagoMedicoActuante <> 0 Then
                            estado = "Pagado"
                        End If
                    ElseIf condicionMedico = "solicitante" Then
                        If est.nroPagoMedicoSolicitante <> 0 Then
                            estado = "Pagado"
                        End If
                    End If
                ElseIf est.idFacturacion <> 0 Then
                    estado = "Presentado"
                Else
                    estado = "Sin presentar"
                End If

                If est.esPagoContraFactura = 1 Then
                    estado = "Pago contra Fact."
                End If

                NewRow("Estado") = estado

                tblEstudiosMedico.Rows.Add(NewRow)
            Next
        End If
        tblEstudiosMedico.AcceptChanges()
        DataGrid2.DataSource = tblEstudiosMedico

    End Sub

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
    Private Sub cmbMedicoAct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicoAct.SelectedIndexChanged
        btnFiltrar.Enabled = True
        btnFiltrarPagos.Enabled = True
        cMedico = arrMedicos(cmbMedicoAct.SelectedIndex)

        arrl = cMedico.getPagos("", "")
        DataGrid1.CaptionText = "Pagos efectuados en los últimos 45 días"
        CargarGrilla()

        'Cargar estudios pendientes (cobrados) por default
        DataGrid2.CaptionText = "Estudios cobrados y pendientes de pago"
        arrEstudios = catalogoEstudios.traerEstudiosPorMedico(cMedico.idMedico, "", "", "", False, True)
        cargarEstudiosDeMedico()
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        Dim p As CedirNegocios.PagoMedico
        p = arrl(i)

        Dim frm As New DetallePago(p)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()

    End Sub

    Private Sub btnFiltrarPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrarPagos.Click
        DataGrid1.CaptionText = "Resultado de la búsqueda"
        arrl = cMedico.getPagos(txtFechaDesdePagos.Text, txtFechaHastaPagos.Text)
        CargarGrilla()

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        DataGrid2.CaptionText = "Resultado de la búsqueda"
        arrEstudios = catalogoEstudios.traerEstudiosPorMedico(cMedico.idMedico, txtPaciente.Text, txtFechaDesdeEstudios.Text, txtFechaHastaEstudios.Text, btnRadioPagados.Checked, btnRadioCobrados.Checked)
        cargarEstudiosDeMedico()
    End Sub

    Private Sub DataGrid2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.DoubleClick
        Dim i As Integer = DataGrid2.CurrentRowIndex
        Dim cEstudio As Estudio = arrEstudios(i)
        Dim frm As New DetalleEstudio(cEstudio)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim arrWidth(5) As Single
        arrWidth(0) = 80    'fecha
        arrWidth(1) = 115    'paciente
        arrWidth(2) = 150  'Obra social
        arrWidth(3) = 150   'Estudio
        arrWidth(4) = 110
        arrWidth(5) = 100
        'Luego setiar el nuevo arreglo de tamaños
        DataGrid2.columnsWidth = arrWidth

        'Titulos
        DataGrid2.imprimirTitle = cMedico.nombreCompleto
        DataGrid2.imprimirSubTitleSuperior1 = "Fecha de impresión: " & CStr(Today.Now)

        'Finalmente, imprimir
        DataGrid2.imprimir(arrEstudios.Count, 6)
    End Sub
End Class
