Imports CedirNegocios
Imports System.Collections.Generic
Public Class InformeMensualComprobantes
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents btnFiltrar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalCobrado As System.Windows.Forms.Label
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblTotalFacturado As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblAnestesia As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblMedicacion As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents lblHonorarios As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cmbMeses = New System.Windows.Forms.ComboBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnFiltrar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbAno = New System.Windows.Forms.ComboBox
        Me.lblTotalCobrado = New System.Windows.Forms.Label
        Me.lblTotalFacturado = New System.Windows.Forms.Label
        Me.lblHonorarios = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblAnestesia = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.lblMedicacion = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbMeses
        '
        Me.cmbMeses.Location = New System.Drawing.Point(80, 21)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(136, 21)
        Me.cmbMeses.TabIndex = 3
        Me.cmbMeses.Text = "ComboBox3"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Período:"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(128, 370)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(96, 23)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnFiltrar
        '
        Me.btnFiltrar.Location = New System.Drawing.Point(378, 21)
        Me.btnFiltrar.Name = "btnFiltrar"
        Me.btnFiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnFiltrar.TabIndex = 7
        Me.btnFiltrar.Text = " Filtro"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(8, 370)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(96, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbAno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbMeses)
        Me.GroupBox1.Controls.Add(Me.btnFiltrar)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 8)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(461, 53)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtro"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(232, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "del"
        '
        'cmbAno
        '
        Me.cmbAno.Location = New System.Drawing.Point(272, 21)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(80, 21)
        Me.cmbAno.TabIndex = 11
        Me.cmbAno.Text = "ComboBox1"
        '
        'lblTotalCobrado
        '
        Me.lblTotalCobrado.Location = New System.Drawing.Point(111, 42)
        Me.lblTotalCobrado.Name = "lblTotalCobrado"
        Me.lblTotalCobrado.Size = New System.Drawing.Size(97, 23)
        Me.lblTotalCobrado.TabIndex = 13
        Me.lblTotalCobrado.Text = "Total:"
        Me.lblTotalCobrado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblTotalFacturado
        '
        Me.lblTotalFacturado.Location = New System.Drawing.Point(108, 19)
        Me.lblTotalFacturado.Name = "lblTotalFacturado"
        Me.lblTotalFacturado.Size = New System.Drawing.Size(100, 23)
        Me.lblTotalFacturado.TabIndex = 14
        Me.lblTotalFacturado.Text = "Total Facturado:"
        Me.lblTotalFacturado.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblHonorarios
        '
        Me.lblHonorarios.Location = New System.Drawing.Point(462, 20)
        Me.lblHonorarios.Name = "lblHonorarios"
        Me.lblHonorarios.Size = New System.Drawing.Size(73, 23)
        Me.lblHonorarios.TabIndex = 16
        Me.lblHonorarios.Text = "Honorarios: "
        Me.lblHonorarios.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(364, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 23)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Honorarios: "
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(18, 19)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(87, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Total Facturado:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(18, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 23)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Total Cobrado:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblMedicacion)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblAnestesia)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblTotalFacturado)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblTotalCobrado)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblHonorarios)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(264, 368)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 100)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Totales"
        '
        'lblAnestesia
        '
        Me.lblAnestesia.Location = New System.Drawing.Point(457, 42)
        Me.lblAnestesia.Name = "lblAnestesia"
        Me.lblAnestesia.Size = New System.Drawing.Size(73, 23)
        Me.lblAnestesia.TabIndex = 22
        Me.lblAnestesia.Text = "Anestesia"
        Me.lblAnestesia.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(364, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 23)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Anestesia: "
        '
        'ProgressBar1
        '
        Me.ProgressBar1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.ProgressBar1.Location = New System.Drawing.Point(475, 46)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Maximum = 1000
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(319, 15)
        Me.ProgressBar1.Step = 1
        Me.ProgressBar1.TabIndex = 22
        Me.ProgressBar1.UseWaitCursor = True
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 67)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.Size = New System.Drawing.Size(828, 297)
        Me.DataGrid1.TabIndex = 0
        '
        'lblMedicacion
        '
        Me.lblMedicacion.Location = New System.Drawing.Point(457, 65)
        Me.lblMedicacion.Name = "lblMedicacion"
        Me.lblMedicacion.Size = New System.Drawing.Size(73, 23)
        Me.lblMedicacion.TabIndex = 24
        Me.lblMedicacion.Text = "Medicacion"
        Me.lblMedicacion.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(364, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(94, 23)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Medicación:"
        '
        'InformeMensualComprobantes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(848, 496)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "InformeMensualComprobantes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe Mensual "
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim myTable As DataTable = New DataTable("myTable")
    Dim catComprobantes As New CatalogoDeComprobantes
    Dim arrComprobantes As New List(Of Comprobante)
    Dim arrObraSocial As ArrayList
    Dim arrMeses(12) As String


    Private Sub InformeDeFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim clEstadoComprobante As New DataColumn("Estado", Type.GetType("System.String"))
        Dim clTipoFactura As New DataColumn("Tipo", Type.GetType("System.String"))
        Dim clNroFacturaAfip As DataColumn = New DataColumn("Nro", Type.GetType("System.String"))
        Dim clFecha As DataColumn = New DataColumn("Fecha", Type.GetType("System.String"))
        Dim clCliente As New DataColumn("Cliente", Type.GetType("System.String"))
        Dim clNeto As DataColumn = New DataColumn("Neto", Type.GetType("System.String"))
        Dim clIva As DataColumn = New DataColumn("IVA", Type.GetType("System.String"))
        Dim clTotalCob As DataColumn = New DataColumn("TotalCobrado", Type.GetType("System.String"))
        Dim clTotalFact As DataColumn = New DataColumn("TotalFacturado", Type.GetType("System.String"))
        'Dim clDebitos As DataColumn = New DataColumn("Débitos", Type.GetType("System.String"))
        Dim clHonorarios As DataColumn = New DataColumn("Honorarios", Type.GetType("System.String"))
        Dim clAnestesia As DataColumn = New DataColumn("Anestesia", Type.GetType("System.String"))
        Dim clTotalMedicacion As DataColumn = New DataColumn("TotalMedicacion", Type.GetType("System.String"))

        myTable.Columns.Add(clEstadoComprobante)
        myTable.Columns.Add(clTipoFactura)
        myTable.Columns.Add(clNroFacturaAfip)
        myTable.Columns.Add(clFecha)
        myTable.Columns.Add(clCliente)
        myTable.Columns.Add(clNeto)
        myTable.Columns.Add(clIva)
        myTable.Columns.Add(clTotalFact)
        myTable.Columns.Add(clTotalCob)
        '  myTable.Columns.Add(clDebitos)
        myTable.Columns.Add(clHonorarios)
        myTable.Columns.Add(clAnestesia)
        myTable.Columns.Add(clTotalMedicacion)


        Dim cm As CurrencyManager
        cm = CType(Me.BindingContext(myTable), CurrencyManager)
        Dim s As New DataGridTableStyle(cm)
        s.AllowSorting = False
        s.MappingName = myTable.TableName
        s.GridColumnStyles(0).Width = 50
        s.GridColumnStyles(1).Width = 150
        s.GridColumnStyles(2).Width = 50
        s.GridColumnStyles(3).Width = 80
        s.GridColumnStyles(4).Width = 120
        s.GridColumnStyles(5).Width = 60
        s.GridColumnStyles(6).Width = 60
        DataGrid1.TableStyles.Add(s)


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

        cmbAno.Items.Add("2010")
        cmbAno.Items.Add("2011")
        cmbAno.Items.Add("2012")
        cmbAno.Items.Add("2013")
        cmbAno.Items.Add("2014")
        cmbAno.Items.Add("2015")


        cmbAno.SelectedItem = CStr(Today.Year)

        arrComprobantes = Me.catComprobantes.getComprobantes(, , , "01/" & (Me.cmbMeses.SelectedIndex + 1).ToString() & "/" & Me.cmbAno.SelectedItem.ToString(), Date.DaysInMonth(Convert.ToInt32(Me.cmbAno.SelectedItem).ToString(), Me.cmbMeses.SelectedIndex + 1).ToString() & "/" & (Me.cmbMeses.SelectedIndex + 1).ToString() & "/" & Me.cmbAno.SelectedItem.ToString(), )
        DataGrid1.CaptionText = "Facturas del corriente mes"
        cargarGrilla()

    End Sub

    Sub cargarGrilla()

        Dim c As Comprobante
        Dim _calcHonorarios As New CalculadorHonorariosComprobantes

        Try
            If arrComprobantes.Count = 0 Then
                MsgBox("No hay facturas emitidas en el mes seleccionado")
            Else
                Me.ProgressBar1.Maximum = arrComprobantes.Count - 1
                Me.ProgressBar1.Visible = True
                Me.ProgressBar1.Value = 0
                For Each c In arrComprobantes
                    Me.ProgressBar1.PerformStep()

                    Dim dr As DataRow
                    dr = myTable.NewRow()
                    dr("Tipo") = c.TipoComprobante.Descripcion & " " & c.SubTipo.ToUpper() + "  -   " + c.Responsable.ToUpper()
                    dr("Nro") = c.NroComprobante.ToString()
                    dr("Estado") = c.Estado
                    dr("Fecha") = c.FechaEmision.ToString().Remove(10)
                    dr("Cliente") = c.NombreCliente.ToUpper()
                    dr("TotalFacturado") = c.TotalFacturado

                    'Tenemos que diferenciar que los valores de comprobantes anulados no se muestran
                    If (c.Estado.ToUpper().Trim() <> "ANULADO") Then
                        If c.Gravado IsNot Nothing Then
                            Dim neto As Decimal = Format(c.TotalFacturado / (1 + (c.Gravado.porcentaje / 100)), "#################0.00")
                            dr("Neto") = neto
                            'el iva esta incluido en el total de la factura
                            dr("IVA") = c.TotalFacturado - neto

                        Else
                            'Liquidaciones cobradas
                            dr("Neto") = 0.0
                            dr("IVA") = 0.0

                        End If

                        dr("TotalCobrado") = c.TotalCobrado
                        'si el comprobante es una nota de credito, los valores se muestran negativos
                        If c.TipoComprobante.Id = TComprobante.NotaDeCredito Then
                            dr("TotalFacturado") = -dr("TotalFacturado")
                            dr("TotalCobrado") = -dr("TotalCobrado")
                            dr("Neto") = -dr("Neto")
                            dr("IVA") = -dr("IVA")
                        Else

                        End If

                        _calcHonorarios.getHonorariosPresentacion(c)
                        dr("Honorarios") = _calcHonorarios.Dict("honorario")
                        dr("Anestesia") = _calcHonorarios.Dict("anestesia")
                        If _calcHonorarios.Dict("importeMedicacion") <> 0.0 Then
                            dr("TotalMedicacion") = _calcHonorarios.Dict("importeMedicacion")
                        Else
                            dr("TotalMedicacion") = 0.0
                        End If

                    Else
                        'si el comprobante esta anulado o no cobrado
                        dr("TotalCobrado") = 0
                        dr("Neto") = 0.0
                        dr("IVA") = 0.0
                        dr("Honorarios") = 0.0
                        dr("Anestesia") = 0.0
                        dr("TotalMedicacion") = 0.0
                    End If
                    myTable.Rows.Add(dr)
                    myTable.AcceptChanges()

                Next
                Me.ProgressBar1.Visible = False
            End If
        Catch
            MsgBox("err")
        Finally
            sumaTotales()
            DataGrid1.DataSource = myTable
            _calcHonorarios = Nothing

        End Try

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Si se desea usar tamaños seteados, fijar el mismo para cada columna de la grilla
        Dim arrWidth(12) As Single
        arrWidth(0) = 100   'estado comprobante
        arrWidth(1) = 120    'tipo comprobante
        arrWidth(2) = 50   'nro comprobante
        arrWidth(3) = 80   'fecha
        arrWidth(4) = 160 ' Cliente
        arrWidth(5) = 65 'neto
        arrWidth(6) = 70 'iva
        arrWidth(7) = 75 ' total facturado
        arrWidth(8) = 75 ' total cobrado
        arrWidth(9) = 75 'honorario
        arrWidth(10) = 75 'Anestesia 
        arrWidth(11) = 70 'medicacion
        'arrWidth(11) = 65
        'arrWidth(12) = 75
        'arrWidth(13) = 65
        'arrWidth(14) = 65
        'Luego setiar el nuevo arreglo de tamaños
        DataGrid1.columnsWidth = arrWidth
        DataGrid1.apaizada = True

        'Titulos
        DataGrid1.imprimirTitle = "Comprobantes"
        DataGrid1.imprimirSubTitleSuperior1 = "Fecha de impresión: " & CStr(Date.Now)
        'DataGrid1.imprimirSubTitleSuperior2 = "Subtitulo 2"
        DataGrid1.imprimirSubTitleInferior1 = "Honorarios:      " & Me.lblHonorarios.Text & vbCrLf & "Total Facturado   :    " & Me.lblTotalFacturado.Text & vbCrLf & "Total Cobrado   :    " & Me.lblTotalCobrado.Text & vbCrLf & "Total Anestesia   :    " & Me.lblAnestesia.Text & vbCrLf & "Total Medicación   :    " & Me.lblMedicacion.Text
        'DataGrid1.imprimirSubTitleInferior2 = "Observaciones: sadasda asdasdi asdfa sdfaskjdnh asdfkjal sdfajksdhfa sdfaks dfjaksdfh wwwww jkhw wwlw wlwkjwh lksjdf swjkhw wjkhsn wjkwhw wwbj kdbnfwk wlkjwh wjbsnkbwkj lwjkw wkjwbsnbw wjwb"

        'Finalmente, imprimir
        DataGrid1.imprimir(Me.arrComprobantes.Count, 12)
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        DataGrid1.CaptionText = "Facturas del mes de " & cmbMeses.Text
        arrComprobantes = Me.catComprobantes.getComprobantes(, , , "01/" & (Me.cmbMeses.SelectedIndex + 1).ToString() & "/" & Me.cmbAno.SelectedItem.ToString(), Date.DaysInMonth(Convert.ToInt32(Me.cmbAno.SelectedItem).ToString(), Me.cmbMeses.SelectedIndex + 1).ToString() & "/" & (Me.cmbMeses.SelectedIndex + 1).ToString() & "/" & Me.cmbAno.SelectedItem.ToString(), )
        'arrFacturaciones = mFact.traerFacturaciones(mes, cmbAno.Text, chkSoloCobrados.Checked)
        myTable.Clear()
        cargarGrilla()
    End Sub

    Private Sub DataGrid1_CurrentCellChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DataGrid1.CurrentCellChanged
        sumaTotales()
    End Sub

    Private Sub sumaTotales()
        Dim sum As Decimal
        Dim totalFact As Decimal
        Dim totalCobrado As Decimal
        Dim anestesia As Decimal
        Dim medicacion As Decimal

        For Each d As DataRow In Me.myTable.Rows
            totalFact = totalFact + Format(Convert.ToDecimal(d("TotalFacturado")), "##########0.00")
            totalCobrado = totalCobrado + Format(Convert.ToDecimal(d("TotalCobrado")), "##########0.00")
            sum = sum + Format(Convert.ToDecimal(d("Honorarios")), "##########0.00")
            anestesia = anestesia + Format(Convert.ToDecimal(d("Anestesia")), "##########0.00")
            medicacion += Format(Convert.ToDecimal(d("TotalMedicacion")), "##########0.00")
        Next
        Me.lblHonorarios.Text = sum.ToString()
        Me.lblTotalFacturado.Text = totalFact.ToString()
        Me.lblTotalCobrado.Text = totalCobrado
        Me.lblAnestesia.Text = anestesia.ToString()
        Me.lblMedicacion.Text = medicacion.ToString()
    End Sub

    Private Sub DataGrid1_Navigate(ByVal sender As System.Object, ByVal ne As System.Windows.Forms.NavigateEventArgs) Handles DataGrid1.Navigate

    End Sub
End Class
