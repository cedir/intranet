Imports CedirNegocios
Imports System.Drawing.Printing
Public Class PresentacionAMRDetalle
    Inherits System.Windows.Forms.Form
    Dim idAmrFact As Integer
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal idFacturacionAmr As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        idAmrFact = idFacturacionAmr
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
    Friend WithEvents grdPresentacion As System.Windows.Forms.DataGrid
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblPresentaion As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Friend WithEvents lblFechas As System.Windows.Forms.Label
    Friend WithEvents btnCobrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PresentacionAMRDetalle))
        Me.grdPresentacion = New System.Windows.Forms.DataGrid
        Me.btnVer = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.lblPresentaion = New System.Windows.Forms.Label
        Me.lblFechas = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.TextBox
        Me.btnCobrar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        CType(Me.grdPresentacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdPresentacion
        '
        Me.grdPresentacion.DataMember = ""
        Me.grdPresentacion.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.grdPresentacion.Location = New System.Drawing.Point(16, 51)
        Me.grdPresentacion.Name = "grdPresentacion"
        Me.grdPresentacion.ReadOnly = True
        Me.grdPresentacion.Size = New System.Drawing.Size(704, 227)
        Me.grdPresentacion.TabIndex = 0
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(24, 24)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(56, 23)
        Me.btnVer.TabIndex = 1
        Me.btnVer.Text = "Ver"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(656, 288)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 2
        Me.btnCerrar.Text = "Cerrar"
        '
        'lblPresentaion
        '
        Me.lblPresentaion.Location = New System.Drawing.Point(24, 16)
        Me.lblPresentaion.Name = "lblPresentaion"
        Me.lblPresentaion.Size = New System.Drawing.Size(320, 16)
        Me.lblPresentaion.TabIndex = 3
        Me.lblPresentaion.Text = "Datos de la presentacion AMR (periodo)"
        '
        'lblFechas
        '
        Me.lblFechas.Location = New System.Drawing.Point(24, 32)
        Me.lblFechas.Name = "lblFechas"
        Me.lblFechas.Size = New System.Drawing.Size(496, 16)
        Me.lblFechas.TabIndex = 6
        Me.lblFechas.Text = "Fecha de Creacion"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(236, 290)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObservaciones.Size = New System.Drawing.Size(395, 58)
        Me.txtObservaciones.TabIndex = 7
        Me.txtObservaciones.Text = resources.GetString("txtObservaciones.Text")
        '
        'btnCobrar
        '
        Me.btnCobrar.Location = New System.Drawing.Point(88, 24)
        Me.btnCobrar.Name = "btnCobrar"
        Me.btnCobrar.Size = New System.Drawing.Size(56, 23)
        Me.btnCobrar.TabIndex = 9
        Me.btnCobrar.Text = "Cobrar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnCobrar)
        Me.GroupBox1.Controls.Add(Me.btnVer)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 284)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(176, 64)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Presentación seleccionada"
        '
        'PresentacionAMRDetalle
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(736, 376)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblFechas)
        Me.Controls.Add(Me.lblPresentaion)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grdPresentacion)
        Me.Name = "PresentacionAMRDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Presentacion AMR - Listado"
        CType(Me.grdPresentacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim tablePresentacion As DataTable = New DataTable("presentacion")
    Dim cFacturacionAMR As PresentacionAMR
    Dim arrFacturacionesPresentacion As ArrayList

    'print data
    Dim cFacturacionToprint As Presentacion
    Dim arrEstudiosToprint As ArrayList
    Dim currentPrintingFacturacionIndex As Integer = 0
    Dim facruracionesAmrCount As Integer
    Dim pageCount As Integer = 0
    Dim marginTop As Integer = 230
    Private Sub FacturacionAMRDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '--------------------Presentacion--------------------------
        Dim clpidPresentacion As DataColumn = New DataColumn("ID", Type.GetType("System.Int32"))
        Dim clpFecha As DataColumn = New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clpNombreOS As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clpNroFacturaAfip As DataColumn = New DataColumn("Nro Factura", Type.GetType("System.String"))
        Dim clpTipoFactura As DataColumn = New DataColumn("Tipo", Type.GetType("System.String"))
        Dim clpResponsable As DataColumn = New DataColumn("Responsable", Type.GetType("System.String"))
        Dim clpCobrado As DataColumn = New DataColumn("Estado", Type.GetType("System.String"))
        Dim clpTotal As DataColumn = New DataColumn("Total", Type.GetType("System.Single"))

        'myTable.Columns.Add(clId)
        tablePresentacion.Columns.Add(clpidPresentacion)
        tablePresentacion.Columns.Add(clpFecha)
        tablePresentacion.Columns.Add(clpNombreOS)
        tablePresentacion.Columns.Add(clpNroFacturaAfip)
        tablePresentacion.Columns.Add(clpTipoFactura)
        tablePresentacion.Columns.Add(clpResponsable)
        tablePresentacion.Columns.Add(clpCobrado)
        tablePresentacion.Columns.Add(clpTotal)


        Dim cmp As CurrencyManager
        cmp = CType(Me.BindingContext(tablePresentacion), CurrencyManager)
        Dim sp As New DataGridTableStyle(cmp)
        sp.AllowSorting = False
        sp.MappingName = tablePresentacion.TableName
        sp.GridColumnStyles(0).Width = 70
        sp.GridColumnStyles(1).Width = 250
        sp.GridColumnStyles(2).Width = 80
        sp.GridColumnStyles(3).Width = 50
        sp.GridColumnStyles(4).Width = 70
        sp.GridColumnStyles(5).Width = 70
        sp.GridColumnStyles(6).Width = 50
        grdPresentacion.TableStyles.Add(sp)

        '--------------------------------------------------
        Dim cHelp As New Helper

        Dim cCatalogo As New CatalogoDePresentaciones
        cFacturacionAMR = cCatalogo.amrFind(idAmrFact)
        cFacturacionAMR.cargarPresentacion()
        lblPresentaion.Text = "Presentación: " & cFacturacionAMR.quincena & " quincena de " & cHelp.getMonthString(cFacturacionAMR.mes) & " del " & cFacturacionAMR.ano
        'txtObservaciones.Visible = False
        'If cFacturacionAMR.observaciones <> "" Then
        '    txtObservaciones.Visible = True
        '    txtObservaciones.Text = "Observaciones: " & cFacturacionAMR.observaciones
        'End If

        cargarGrillaPresentacion()
    End Sub

    Private Sub cargarGrillaPresentacion()
        'Dim NewRow As DataRow
        'Dim i As Integer
        'tablePresentacion.Clear()

        'arrFacturacionesPresentacion = cFacturacionAMR.getLineasDeFacturacion()
        'Dim cFacturacion As Presentacion
        'For i = 0 To arrFacturacionesPresentacion.Count - 1
        '    cFacturacion = arrFacturacionesPresentacion(i)
        '    NewRow = tablePresentacion.NewRow()
        '    NewRow("ID") = cFacturacion.idPresentacion
        '    NewRow("Fecha") = cFacturacion.fechaFacturacion
        '    NewRow("Obra Social") = cFacturacion.obraSocial.ObraSocial
        '    NewRow("Nro Factura") = cFacturacion.comprobante.NroComprobante
        '    NewRow("Tipo") = cFacturacion.comprobante.TipoComprobante.Descripcion
        '    NewRow("Responsable") = cFacturacion.comprobante.TipoComprobante
        '    NewRow("Estado") = cFacturacion.estado
        '    NewRow("Total") = cFacturacion.total
        '    tablePresentacion.Rows.Add(NewRow)
        'Next

        'tablePresentacion.AcceptChanges()
        'grdPresentacion.DataSource = tablePresentacion
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        'Dim i As Integer
        'i = grdPresentacion.CurrentRowIndex
        'Dim currentFact As Presentacion
        'currentFact = cFacturacionAMR.getLineasDeFacturacion(i)
        'If currentFact.pagado = 0 Then
        '    Dim frm As New FacturacionDetalle(currentFact.idPresentacion)
        '    frm.MdiParent = Me.Parent.Parent
        '    frm.Show()
        'ElseIf currentFact.pagado = 1 Then
        '    'Cobrado
        '    Dim frm As New FacturacionCobradaDetalle(currentFact)
        '    frm.MdiParent = Me.Parent.Parent
        '    frm.Show()
        'ElseIf currentFact.pagado = 2 Then
        '    'Abierta
        '    If hayUnaFacturacionInstanciada Then
        '        MsgBox("Ya hay una ventana Nueva Facturación abierta. Ciérrela y vuelva a intentarlo.", MsgBoxStyle.Information, "No se puede abrir la ventana Nueva Facturación")
        '    Else
        '        Dim frm As New NuevaPresentacion(currentFact.idPresentacion)
        '        frm.MdiParent = Me.Parent.Parent
        '        frm.Show()
        '    End If

        'End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        currentPrintingFacturacionIndex = 0

        cFacturacionToprint = arrFacturacionesPresentacion(currentPrintingFacturacionIndex)
        cFacturacionToprint.cargarFacturacion()
        arrEstudiosToprint = cFacturacionToprint.getLineasDeFacturacionEstudios()
        facruracionesAmrCount = arrFacturacionesPresentacion.Count

        Dim SalesReport As New PrintDocument
        AddHandler SalesReport.PrintPage, AddressOf PrintSalesPage
        Dim pss As New PrintDialog
        Dim bp As DialogResult
        pss.Document = SalesReport
        bp = pss.ShowDialog
        If bp = DialogResult.OK Then
            SalesReport.Print()
        End If

    End Sub

    Sub PrintSalesPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim columnsTitles(2) As String
        Dim columnsWidth(2) As Single
        columnsTitles(0) = "Nro. de Afiliado"
        columnsWidth(0) = 100
        columnsTitles(1) = "Paciente"
        columnsWidth(1) = 160
        columnsTitles(2) = "Práctica"
        columnsWidth(2) = 400

        Dim leftMarge As Single = 95
        'Dim rowHeight As Single = 16.0F
        Dim yStart As Integer = marginTop
        Dim drawRect As New RectangleF
        drawRect.Height = 16.0F

        Dim tableWidth As Single = Me._getTableWidth(columnsWidth)

        Dim reportColumnTitleFont As New Font("Arial", 9, FontStyle.Bold)
        Dim ReportFont As New Font("Arial", 9, FontStyle.Regular)
        Dim ReportFontHeight As Integer = ReportFont.GetHeight(e.Graphics)
        Dim fuenteTitulo As New Font("Times New Roman", 14, FontStyle.Underline)
        'ReportFontHeight es = a 14

        'Table lines styles
        Dim tableBorderLineStyle As System.Drawing.Pen
        tableBorderLineStyle = New System.Drawing.Pen(System.Drawing.Color.Black)
        tableBorderLineStyle.DashStyle = Drawing2D.DashStyle.Solid
        Dim tableContentLineStyle As System.Drawing.Pen
        tableContentLineStyle = New System.Drawing.Pen(System.Drawing.Color.Black)
        tableContentLineStyle.DashStyle = Drawing2D.DashStyle.Dot

        If currentPrintingFacturacionIndex = 0 Then
            'Es la primera hoja
            e.Graphics.DrawString("Presentación a AMR", fuenteTitulo, Brushes.Black, leftMarge, yStart)
            yStart += 20
        End If


        'verificar que entra en la hoja
        Dim doPrintFacturacion As Boolean = _entraFacturacion(yStart, arrEstudiosToprint.Count)

        Dim CurrentY As Integer = yStart
        Dim xAcum As Single = leftMarge
        While (currentPrintingFacturacionIndex < facruracionesAmrCount And doPrintFacturacion)
            CurrentY = CurrentY + 22
            xAcum = leftMarge
            drawRect.Width = 200
            drawRect.X = xAcum
            drawRect.Y = CurrentY
            e.Graphics.DrawString(cFacturacionToprint.obraSocial.ObraSocial, ReportFont, Brushes.Black, drawRect)

            CurrentY += 15

            'Imprimir encabezado de tabla de estudios estudios
            For x As Integer = 0 To UBound(columnsTitles)
                drawRect.Width = columnsWidth(x)
                drawRect.X = xAcum
                drawRect.Y = CurrentY
                e.Graphics.DrawString(columnsTitles(x), reportColumnTitleFont, Brushes.Black, drawRect)
                xAcum += columnsWidth(x)
            Next

            Dim cEstudio As Estudio
            For j As Integer = 0 To arrEstudiosToprint.Count - 1

                CurrentY = CurrentY + 14
                xAcum = leftMarge

                Dim cLinea As LineaDeFacturacion = arrEstudiosToprint(j)
                cEstudio = cLinea.objeto

                'nro afiliado
                drawRect.Width = columnsWidth(0)
                drawRect.X = xAcum
                drawRect.Y = CurrentY
                e.Graphics.DrawString(cEstudio.paciente.nroAfiliado, ReportFont, Brushes.Black, drawRect)
                xAcum += columnsWidth(0)

                'paciente
                drawRect.Width = columnsWidth(1)
                drawRect.X = xAcum
                e.Graphics.DrawString(cEstudio.paciente.nombreCompleto, ReportFont, Brushes.Black, drawRect)
                xAcum += columnsWidth(1)

                'practica
                drawRect.Width = columnsWidth(2)
                drawRect.X = xAcum
                e.Graphics.DrawString(cEstudio.practica.Estudio, ReportFont, Brushes.Black, drawRect)

                'Linea superior del registro
                'e.Graphics.DrawLine(tableContentLineStyle, leftMarge, CurrentY, (tableWidth + leftMarge), CurrentY)
            Next

            currentPrintingFacturacionIndex += 1
            If currentPrintingFacturacionIndex < facruracionesAmrCount Then
                cFacturacionToprint = arrFacturacionesPresentacion(currentPrintingFacturacionIndex)
                cFacturacionToprint.cargarFacturacion()
                arrEstudiosToprint = cFacturacionToprint.getLineasDeFacturacionEstudios()
                doPrintFacturacion = _entraFacturacion(CurrentY, arrEstudiosToprint.Count)

            Else
                doPrintFacturacion = False
            End If



        End While

        If currentPrintingFacturacionIndex = facruracionesAmrCount Then
            'termino impresion
        Else
            e.HasMorePages = True
            pageCount += 1
        End If


    End Sub

    Private Function _entraFacturacion(ByVal yAcum As Single, ByVal estudiosCount As Integer) As Boolean
        yAcum += 22 'ahi es donde realmente empieza a imprimirse la presentacion
        Dim estudioHeight As Single = 14
        Dim totalHeight As Single = (estudioHeight * estudiosCount) + 15 '(15 es lo que ocupa el encabezado)
        Dim yMax As Single = 1050

        If (totalHeight + yAcum) <= yMax Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function _getTableWidth(ByVal arrColumnsWidth() As Single) As Single
        Dim widthAcum As Single = 0
        For j As Integer = 0 To UBound(arrColumnsWidth)
            widthAcum += arrColumnsWidth(j)
        Next
        Return widthAcum
    End Function

    Private Sub btnCobrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCobrar.Click
        '    Dim i As Integer = grdPresentacion.CurrentRowIndex
        '    Dim currentFact As Presentacion
        '    currentFact = cFacturacionAMR.getLineasDeFacturacion(i)
        '    If currentFact.pagado = 0 Then
        '        Dim frm As New CobroFacturacion(currentFact.idPresentacion)
        '        frm.MdiParent = Me.Parent.Parent
        '        frm.Show()
        '    ElseIf currentFact.pagado = 1 Then
        '        MsgBox("La presentación ya esta cobrada. Presione Ver para visualizar el detalle del pago.", MsgBoxStyle.Exclamation)
        '    ElseIf currentFact.pagado = 2 Then
        '        MsgBox("Debe finalizar la presentación para poder generar un cobro", MsgBoxStyle.Exclamation)
        '    End If
    End Sub
End Class
