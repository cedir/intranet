Imports CedirNegocios




Imports System.Drawing.Printing
Public Class AgragarMedicacion
    Inherits System.Windows.Forms.Form
    Dim est As Estudio
    Dim vieneDeFacturacionAbierta As Boolean = False
    Dim arrMedicamentos As New ArrayList
    Dim arrMedicamentosDeEstudio As New ArrayList
    Dim tablaMedicamentos As DataTable = New DataTable("medicamentos")
    Dim tablaMedicacionEstudios As DataTable = New DataTable("medicacionEst")
    Dim total As Single = 0
    Dim m_totalAnestesia As Decimal = 0.0

    Friend WithEvents btnDefault As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Dim saveChanges As Boolean = False
    Public Sub New(ByVal estudio As Estudio)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'estudio = New Estudio
        est = estudio
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByVal estudio As Estudio, ByVal vieneDeFacturacion As Boolean)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        'estudio = New Estudio
        est = estudio
        vieneDeFacturacionAbierta = vieneDeFacturacion
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
#Region " Código generado por el Diseñador de Windows Forms "



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
    Friend WithEvents DataGrid2 As wallyGrid
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnAgregar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnAnular As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnAgregar = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.lblTotal = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAnular = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnDefault = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.DataGrid2 = New Cedir.wallyGrid
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.CaptionText = "Medicación disponible"
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 94)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(272, 248)
        Me.DataGrid1.TabIndex = 0
        '
        'btnAgregar
        '
        Me.btnAgregar.Location = New System.Drawing.Point(294, 94)
        Me.btnAgregar.Name = "btnAgregar"
        Me.btnAgregar.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregar.TabIndex = 2
        Me.btnAgregar.Text = "Agregar -->"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(416, 16)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(24, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(472, 23)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Label4"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(413, 376)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 7
        Me.btnGuardar.Text = "Guardar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 62)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(608, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Label5"
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(294, 123)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(75, 23)
        Me.btnQuitar.TabIndex = 9
        Me.btnQuitar.Text = "Quitar"
        '
        'lblTotal
        '
        Me.lblTotal.Location = New System.Drawing.Point(568, 298)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(88, 23)
        Me.lblTotal.TabIndex = 10
        Me.lblTotal.Text = "lblTotal"
        Me.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(16, 376)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Cerrar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(584, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Label1"
        '
        'btnAnular
        '
        Me.btnAnular.Location = New System.Drawing.Point(589, 376)
        Me.btnAnular.Name = "btnAnular"
        Me.btnAnular.Size = New System.Drawing.Size(64, 23)
        Me.btnAnular.TabIndex = 13
        Me.btnAnular.Text = "Anular"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(501, 376)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 15
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnDefault
        '
        Me.btnDefault.Location = New System.Drawing.Point(294, 319)
        Me.btnDefault.Name = "btnDefault"
        Me.btnDefault.Size = New System.Drawing.Size(75, 23)
        Me.btnDefault.TabIndex = 16
        Me.btnDefault.Text = "Default"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(381, 298)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Total Medicacion....:"
        '
        'DataGrid2
        '
        Me.DataGrid2.CaptionText = "Medicación del estudio"
        Me.DataGrid2.DataMember = ""
        Me.DataGrid2.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid2.Location = New System.Drawing.Point(384, 92)
        Me.DataGrid2.Name = "DataGrid2"
        Me.DataGrid2.Size = New System.Drawing.Size(272, 203)
        Me.DataGrid2.TabIndex = 1
        '
        'AgragarMedicacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(666, 416)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnDefault)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnAnular)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.btnQuitar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnAgregar)
        Me.Controls.Add(Me.DataGrid2)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "AgragarMedicacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agragar Medicación a estudio"
        Me.TopMost = True
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region


    Public Property totalAnestesia() As Decimal
        Get
            Return m_totalAnestesia
        End Get
        Set(ByVal value As Decimal)
            m_totalAnestesia = value
        End Set
    End Property

    Private Sub AgragarMedicacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim clMedicamento As New DataColumn("Medicamento", Type.GetType("System.String"))
        Dim clImporte As New DataColumn("Importe", Type.GetType("System.Single"))
        tablaMedicamentos.Columns.Add(clMedicamento)
        tablaMedicamentos.Columns.Add(clImporte)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "medicamentos"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        Dim TextCol5 As New DataGridTextBoxColumn
        TextCol5.MappingName = "Medicamento"
        TextCol5.HeaderText = "Medicamento"
        TextCol5.Width = 172
        ts1.GridColumnStyles.Add(TextCol5)

        Dim TextCol8 As New DataGridTextBoxColumn
        TextCol8.MappingName = "Importe"
        TextCol8.HeaderText = "Importe"
        TextCol8.Width = 43
        ts1.GridColumnStyles.Add(TextCol8)
        DataGrid1.TableStyles.Add(ts1)



        Dim clMedicamentoEst As New DataColumn("Medicamento", Type.GetType("System.String"))
        Dim clImporteEst As New DataColumn("Importe", Type.GetType("System.Single"))
        tablaMedicacionEstudios.Columns.Add(clMedicamentoEst)
        tablaMedicacionEstudios.Columns.Add(clImporteEst)
        Dim ts2 As New DataGridTableStyle
        ts2.MappingName = "medicacionEst"
        ts2.BackColor = Color.LightGray
        ts2.ForeColor = Color.SlateBlue
        ts2.AlternatingBackColor = Color.White
        ts2.AllowSorting = False

        ts2.HeaderForeColor = Color.MediumSlateBlue
        ts2.HeaderBackColor = Color.WhiteSmoke
        ts2.GridLineColor = Color.MediumPurple

        Dim TextCol1 As New DataGridTextBoxColumn
        TextCol1.MappingName = "Medicamento"
        TextCol1.HeaderText = "Medicamento"
        TextCol1.Width = 172
        ts2.GridColumnStyles.Add(TextCol1)

        Dim TextCol2 As New DataGridTextBoxColumn
        TextCol2.MappingName = "Importe"
        TextCol2.HeaderText = "Importe"
        TextCol2.Width = 43
        ts2.GridColumnStyles.Add(TextCol2)
        DataGrid2.TableStyles.Add(ts2)

        CargarGrillaMedicamentosDeEstudio()

        Label3.Text = "Paciente: " & est.paciente.apellido & ", " & est.paciente.nombres
        Label4.Text = "Fecha del estudio: " & est.fechaEstudio
        Label5.Text = "Estudio: " & est.practica.Estudio
        Label1.Text = "Nro: " & est.nroEstudio
        cargrarGrillaMedicamentos()


        restrictUpdate()

    End Sub

    Private Sub cargrarGrillaMedicamentos()
        Dim NewRow As DataRow
        Dim catalogoMedicamentos As New CatalogoDeMedicamentos
        arrMedicamentos = catalogoMedicamentos.traerMedicamentos()
        Dim i As Integer
        Dim med As Medicamento

        For i = 0 To arrMedicamentos.Count - 1
            med = arrMedicamentos(i)
            NewRow = tablaMedicamentos.NewRow()
            NewRow("Medicamento") = med.descripcion
            NewRow("Importe") = med.importe
            tablaMedicamentos.Rows.Add(NewRow)
        Next
        tablaMedicamentos.AcceptChanges()
        DataGrid1.DataSource = tablaMedicamentos
    End Sub

    Private Sub CargarGrillaMedicamentosDeEstudio()
        Dim NewRow As DataRow
        est.cargarMedicacion()
        arrMedicamentosDeEstudio = est.arrMedicacion
        Dim i As Integer
        Dim med As Medicacion

        For i = 0 To arrMedicamentosDeEstudio.Count - 1
            med = arrMedicamentosDeEstudio(i)
            NewRow = tablaMedicacionEstudios.NewRow()
            NewRow("Medicamento") = med.medicamento.descripcion
            NewRow("Importe") = Math.Round(med.importe, 2)
            total = total + Math.Round(med.importe, 2)
            tablaMedicacionEstudios.Rows.Add(NewRow)
        Next
        lblTotal.Text = "Total: $" & Math.Round(total, 2)
        tablaMedicacionEstudios.AcceptChanges()
        DataGrid2.DataSource = tablaMedicacionEstudios

    End Sub


    Private Sub btnAgregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregar.Click
        Dim NewRow As DataRow
        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        Dim m As Medicamento
        m = arrMedicamentos(i)
        'si el item seleccionado es anestesia, 
        'no lo agregamos como medicacion del estudio
        If m.descripcion.ToUpper().Contains("ANEST") = True Then
            MessageBox.Show("No es posible agregar anestesia como medicacion.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            ' Me.calcularTotalAnestesia(m.importe)
        Else
            Dim cLineaMedicacion As New Medicacion
            cLineaMedicacion.medicamento = m
            cLineaMedicacion.importe = m.importe

            Dim success As Boolean = est.addLineaMedicacion(cLineaMedicacion)
            If success Then
                NewRow = tablaMedicacionEstudios.NewRow()
                NewRow("Medicamento") = m.descripcion
                NewRow("Importe") = m.importe
                tablaMedicacionEstudios.Rows.Add(NewRow)
                tablaMedicacionEstudios.AcceptChanges()
                DataGrid2.DataSource = tablaMedicacionEstudios

                calcularTotal()
                saveChanges = True
            Else
                MsgBox("La medicación ya pertenece al estudio", MsgBoxStyle.Critical)

            End If

        End If


    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click

        calcularTotal()
        Dim resp As String
        Dim i As Integer
        Dim cLineaMedicacion As Medicacion
        For i = 0 To est.arrMedicacion.Count - 1
            Dim importeMedicacion As Single = CSng(DataGrid2.Item(i, 1))
            cLineaMedicacion = est.arrMedicacion(i)
            cLineaMedicacion.importe = importeMedicacion
        Next
        
        resp = est.guardarMedicacion()
        If resp = "ok" Then
            MsgBox("La medicación ha sido guardada")

            saveChanges = False
            'Datos Globales
            agregarAFacturacion()
        Else
            MsgBox("Se ha producido un error al intentar guardar. Cierre la ventana y vuelva a intentarlo. Error: " & resp)
        End If

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If DataGrid2.CurrentRowIndex <> -1 Then
            Dim resp As String = est.quitarLineaMedicacion(DataGrid2.CurrentRowIndex)
            If resp = "ok" Then
                tablaMedicacionEstudios.Rows.Remove(tablaMedicacionEstudios.Rows.Item(DataGrid2.CurrentRowIndex))
                tablaMedicacionEstudios.AcceptChanges()
                DataGrid2.DataSource = tablaMedicacionEstudios
                calcularTotal()
            End If
        Else
            MsgBox("No se ha seleccionado ninguna medicación", MsgBoxStyle.Critical)
        End If

    End Sub


    Private Sub DataGrid2_CurrentCellChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles DataGrid2.CurrentCellChanged
        calcularTotal()

        saveChanges = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub


    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

        If est.arrMedicacion.Count = 0 Then
            MsgBox("No hay medicación para borrar", MsgBoxStyle.Critical)
        Else
            Dim r As Integer
            Dim resp As String
            r = MsgBox("¿Esta seguro que desea anular la medicación?", MsgBoxStyle.YesNo, "Crear Facturación")
            If r = 6 Then
                resp = est.borrarMedicacion()
                If resp = "ok" Then
                    MsgBox("Se ha eliminado la medicacion del estudio")
                    tablaMedicacionEstudios.Clear()
                    tablaMedicacionEstudios.AcceptChanges()
                    DataGrid2.DataSource = tablaMedicacionEstudios
                    total = 0
                    lblTotal.Text = "Total: $" & total

                    saveChanges = False
                Else
                    MsgBox("Error: " & resp)
                End If
            End If
        End If

    End Sub

    Private Sub calcularTotal()
        Dim i As Integer
        total = 0
        For i = 0 To est.arrMedicacion.Count - 1
            total = total + CSng(DataGrid2.Item(i, 1))
        Next
        'total = Math.Round(total, 2)
        lblTotal.Text = "Total: $" & CStr(total)
    End Sub

    Private Sub agregarAFacturacion()
        If hayUnaFacturacionInstanciada Then
            'If idObraSocialDeFacturacion = est.obraSocial.idObraSocial Then
            If nroEstudioParaCargarMedicacion <> 0 And nroEstudioParaCargarMedicacion <> est.nroEstudio Then
                posibleErrorEnMedicacion = True
            End If
            nroEstudioParaCargarMedicacion = est.nroEstudio
            'End If
        End If
    End Sub

    Public Function restrictUpdate() As Boolean
        If est.idFacturacion <> 0 Then
            If vieneDeFacturacionAbierta = False Then
                btnAgregar.Enabled = True
                btnQuitar.Enabled = True
                btnAnular.Enabled = False
                btnGuardar.Enabled = True
                Me.btnDefault.Enabled = False
                Return False
            End If
        End If

        Return True

    End Function



    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

        If est.arrMedicacion.Count = 0 Then
            MsgBox("No hay medicación para imprimir", MsgBoxStyle.Critical)
        Else
            est.cargarMedicacion()
            Dim f As New rptViewer
            Me.AddOwnedForm(f)

            f.printListadoMedicamentos(est)
            ' f.ShowDialog()
        End If

        'calcularTotal()
        '    'vamos a sacar el material especifico, y calculamos el total de solamente medicacion
        '    Dim arrMed As New ArrayList
        '    Dim totalMedicacion As Single
        '    Dim i As Integer
        '    For i = 0 To est.arrMedicacion.Count - 1
        '        Dim med As Medicacion = est.arrMedicacion(i)
        '        If Not med.esMaterialEspecifico Then
        '            arrMed.Add(med.medicamento)
        '            totalMedicacion = totalMedicacion + med.medicamento.importe
        '        End If
        '    Next


        'Dim arrWidth(1) As Single
        'arrWidth(0) = 210
        'arrWidth(1) = 75

        'DataGrid2.columnsWidth = arrWidth

        'DataGrid2.imprimirTitle = "Medicación por neurolepto analgesia"
        'DataGrid2.imprimirSubTitleSuperior1 = "Paciente: " & est.paciente.nombreCompleto
        'DataGrid2.imprimirSubTitleSuperior2 = "Práctica: " & est.practica.Estudio
        'DataGrid2.imprimirSubTitleSuperior3 = "Fecha: " & est.fechaEstudio
        'DataGrid2.imprimirSubTitleInferior1 = "Total: $ " & CStr(totalMedicacion)
        'DataGrid2.imprimir(arrMed.Count, 2)
    End Sub

    Private Sub AgragarMedicacion_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        If saveChanges Then
            Dim r As Integer = MsgBox("Puede que la medicación del estudio haya cambiado, ¿Desea guardar los cambios?", MsgBoxStyle.YesNo, "Guardar cambios")
            If r = 6 Then
                btnGuardar.PerformClick()
            End If
        End If
    End Sub

    Private Sub cargarMedicacionDefault()
        Dim NewRow As DataRow
        Dim i As Integer

        Dim m As Medicamento
        'Id's de los medicamentos que se cargan por default.
        Dim arrMedDef() As Integer = {2, 3, 4, 5, 6, 7, 8, 22, 35, 36, 37, 42, 48, 109, 128, 144, 167, 169}
        Dim list As New ArrayList
        list.AddRange(arrMedDef)

        For i = 0 To arrMedicamentos.Count - 1

            m = arrMedicamentos(i)

            If list.Contains(m.idMedicamento) Then

                Dim cLineaMedicacion As New Medicacion
                cLineaMedicacion.medicamento = m
                cLineaMedicacion.importe = m.importe

                Dim success As Boolean = est.addLineaMedicacion(cLineaMedicacion)
                If success Then
                    NewRow = tablaMedicacionEstudios.NewRow()
                    NewRow("Medicamento") = m.descripcion
                    NewRow("Importe") = m.importe
                    tablaMedicacionEstudios.Rows.Add(NewRow)
                    tablaMedicacionEstudios.AcceptChanges()
                    DataGrid2.DataSource = tablaMedicacionEstudios

                    calcularTotal()
                    saveChanges = True
                End If

            End If
        Next
    End Sub

    Private Sub btnDefault_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDefault.Click
        Me.cargarMedicacionDefault()
    End Sub
End Class
