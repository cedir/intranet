Imports CedirNegocios
imports System.Collections.Generic 
Public Class PresentacionAMRAltaModificacion

    Inherits System.Windows.Forms.Form
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub
    Public Sub New(ByVal idFacturacionAmr As Integer)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        esAltaFacturacion = False
        cFAmrId = idFacturacionAmr
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
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents btnQuitar As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents cmbQuincena As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lstPresentaciones As System.Windows.Forms.ListView
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents fecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents VerDetalleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents remito As System.Windows.Forms.ColumnHeader
    Friend WithEvents dgvPresentacionAMR As System.Windows.Forms.DataGridView
    Friend WithEvents total As System.Windows.Forms.ColumnHeader
    Friend WithEvents colID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colFecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colEstado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colOS As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colRemito As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTotal As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip

    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnQuitar = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dgvPresentacionAMR = New System.Windows.Forms.DataGridView
        Me.colID = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colFecha = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colEstado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colOS = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colRemito = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTotal = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.cmbAno = New System.Windows.Forms.ComboBox
        Me.cmbQuincena = New System.Windows.Forms.ComboBox
        Me.cmbMeses = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.lstPresentaciones = New System.Windows.Forms.ListView
        Me.id = New System.Windows.Forms.ColumnHeader
        Me.fecha = New System.Windows.Forms.ColumnHeader
        Me.estado = New System.Windows.Forms.ColumnHeader
        Me.remito = New System.Windows.Forms.ColumnHeader
        Me.total = New System.Windows.Forms.ColumnHeader
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerDetalleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvPresentacionAMR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnQuitar
        '
        Me.btnQuitar.Location = New System.Drawing.Point(134, 254)
        Me.btnQuitar.Name = "btnQuitar"
        Me.btnQuitar.Size = New System.Drawing.Size(111, 23)
        Me.btnQuitar.TabIndex = 4
        Me.btnQuitar.Text = "Quitar"
        Me.ToolTip1.SetToolTip(Me.btnQuitar, "Saca elemento de la grilla de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Presentacion AMR(abajo)")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvPresentacionAMR)
        Me.GroupBox1.Controls.Add(Me.btnGuardar)
        Me.GroupBox1.Controls.Add(Me.cmbAno)
        Me.GroupBox1.Controls.Add(Me.cmbQuincena)
        Me.GroupBox1.Controls.Add(Me.btnQuitar)
        Me.GroupBox1.Controls.Add(Me.cmbMeses)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 205)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(715, 283)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos de la Presentacion AMR"
        '
        'dgvPresentacionAMR
        '
        Me.dgvPresentacionAMR.AllowUserToAddRows = False
        Me.dgvPresentacionAMR.AllowUserToDeleteRows = False
        Me.dgvPresentacionAMR.AllowUserToResizeRows = False
        Me.dgvPresentacionAMR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPresentacionAMR.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colID, Me.colFecha, Me.colEstado, Me.colOS, Me.colRemito, Me.colTotal})
        Me.dgvPresentacionAMR.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPresentacionAMR.Location = New System.Drawing.Point(18, 48)
        Me.dgvPresentacionAMR.MultiSelect = False
        Me.dgvPresentacionAMR.Name = "dgvPresentacionAMR"
        Me.dgvPresentacionAMR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dgvPresentacionAMR.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPresentacionAMR.Size = New System.Drawing.Size(680, 200)
        Me.dgvPresentacionAMR.TabIndex = 18
        '
        'colID
        '
        Me.colID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colID.HeaderText = "ID"
        Me.colID.Name = "colID"
        Me.colID.ReadOnly = True
        Me.colID.Width = 43
        '
        'colFecha
        '
        Me.colFecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        Me.colFecha.ReadOnly = True
        Me.colFecha.Width = 62
        '
        'colEstado
        '
        Me.colEstado.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.colEstado.HeaderText = "Estado"
        Me.colEstado.Name = "colEstado"
        Me.colEstado.ReadOnly = True
        Me.colEstado.Width = 65
        '
        'colOS
        '
        Me.colOS.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.colOS.HeaderText = "Obra social"
        Me.colOS.Name = "colOS"
        Me.colOS.ReadOnly = True
        '
        'colRemito
        '
        Me.colRemito.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        DataGridViewCellStyle1.NullValue = "0"
        Me.colRemito.DefaultCellStyle = DataGridViewCellStyle1
        Me.colRemito.HeaderText = "Remito"
        Me.colRemito.Name = "colRemito"
        Me.colRemito.Width = 65
        '
        'colTotal
        '
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        Me.colTotal.ReadOnly = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(17, 254)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(111, 23)
        Me.btnGuardar.TabIndex = 8
        Me.btnGuardar.Text = "Guardar"
        '
        'cmbAno
        '
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(210, 21)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(81, 21)
        Me.cmbAno.TabIndex = 8
        Me.cmbAno.Text = "Año"
        '
        'cmbQuincena
        '
        Me.cmbQuincena.FormattingEnabled = True
        Me.cmbQuincena.Location = New System.Drawing.Point(17, 19)
        Me.cmbQuincena.Name = "cmbQuincena"
        Me.cmbQuincena.Size = New System.Drawing.Size(86, 21)
        Me.cmbQuincena.TabIndex = 7
        Me.cmbQuincena.Text = "Quincena"
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Location = New System.Drawing.Point(109, 20)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(95, 21)
        Me.cmbMeses.TabIndex = 6
        Me.cmbMeses.Text = "Mes"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(17, 39)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(72, 24)
        Me.btnBuscar.TabIndex = 4
        Me.btnBuscar.Text = "Buscar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(26, 494)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(110, 23)
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lstPresentaciones)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbObraSocial)
        Me.GroupBox2.Controls.Add(Me.btnBuscar)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(715, 187)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Presentaciones"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(616, 65)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 112)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Doble click con el mouse para agregar " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "la presentacion." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Click boton derecho p" & _
            "ara ver detalle"
        '
        'lstPresentaciones
        '
        Me.lstPresentaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.id, Me.fecha, Me.estado, Me.remito, Me.total})
        Me.lstPresentaciones.ContextMenuStrip = Me.ContextMenuStrip1
        Me.lstPresentaciones.FullRowSelect = True
        Me.lstPresentaciones.GridLines = True
        Me.lstPresentaciones.Location = New System.Drawing.Point(17, 65)
        Me.lstPresentaciones.Name = "lstPresentaciones"
        Me.lstPresentaciones.Size = New System.Drawing.Size(562, 112)
        Me.lstPresentaciones.TabIndex = 16
        Me.lstPresentaciones.UseCompatibleStateImageBehavior = False
        Me.lstPresentaciones.View = System.Windows.Forms.View.Details
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 84
        '
        'fecha
        '
        Me.fecha.Text = "Fecha"
        Me.fecha.Width = 114
        '
        'estado
        '
        Me.estado.Text = "Estado"
        Me.estado.Width = 133
        '
        'remito
        '
        Me.remito.Text = "Remito"
        Me.remito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.remito.Width = 109
        '
        'total
        '
        Me.total.Text = "Total"
        Me.total.Width = 117
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerDetalleToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(138, 26)
        '
        'VerDetalleToolStripMenuItem
        '
        Me.VerDetalleToolStripMenuItem.Name = "VerDetalleToolStripMenuItem"
        Me.VerDetalleToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.VerDetalleToolStripMenuItem.Text = "Ver Detalle"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(14, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 21)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Obra social:"
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.Location = New System.Drawing.Point(93, 12)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(486, 21)
        Me.cmbObraSocial.TabIndex = 8
        Me.cmbObraSocial.Text = "ACA SALUD"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 500000
        Me.ToolTip1.InitialDelay = 200
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ToolTip1.ToolTipTitle = "INFO"
        '
        'PresentacionAMRAltaModificacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(726, 525)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "PresentacionAMRAltaModificacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Presentacion AMR Alta-Modificacion"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvPresentacionAMR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region



#Region "Variables de instancia"

    Private esAltaFacturacion As Boolean = True
    Dim oPresentacionAMR As PresentacionAMR
    Dim cFAmrId As Integer
    Dim arrObraSocial As New List(Of ObraSocial)
    Dim arrPresentaciones As New List(Of Presentacion)

    Dim cHelp As New Helper
#End Region

#Region "Propiedades"
    Public Property Alta() As Boolean
        Get
            Return esAltaFacturacion
        End Get
        Set(ByVal value As Boolean)
            esAltaFacturacion = value
        End Set
    End Property
#End Region


    Private Sub FacturacionAMREditar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos las os del combo
        Me.cargarCombo()
        If Alta Then
            oPresentacionAMR = New PresentacionAMR
        Else
            'si es una modificacion, cargamos la grilla de abajo
            facturacionAMRCargar()

        End If
    End Sub

    Private Sub facturacionAMRCargar()
        Dim catPresentacion As New CatalogoDePresentaciones
        Try
            'buscamos primero la presentacion AMR
            oPresentacionAMR = catPresentacion.amrFind(cFAmrId)
            'Una vez encontrada, cargamos los datos correspondientes a sus lineas
            oPresentacionAMR.cargarPresentacion()
            cmbQuincena.SelectedItem = CStr(oPresentacionAMR.quincena)
            cmbAno.SelectedItem = CStr(oPresentacionAMR.ano)

            cmbMeses.SelectedItem = cHelp.getMonthString(oPresentacionAMR.mes)

        Catch ex As Exception

        Finally

            catPresentacion = Nothing
            Me.cargarGrillaPresentacionAMR()

        End Try


    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cIdObraSocial As Integer = 0
        If cmbObraSocial.SelectedIndex = 0 Then
            MsgBox("Seleccione una obra social")
        Else
            'Como el metodo me devuelve un arraylist, voy a modificar el metodo para
            'transformarlo en una lista de presentaciones
            Dim arr As New ArrayList
            Dim catPresentacion As New CatalogoDePresentaciones

            Try
                Me.arrPresentaciones.Clear()
                arr = catPresentacion.traerPresentaciones(Me.arrObraSocial(Me.cmbObraSocial.SelectedIndex - 1).idObraSocial, , , , True, , , )
                If arr.Count > 0 Then
                    Dim i As Integer = 0
                    For i = 0 To arr.Count - 1
                        Dim p As New Presentacion
                        p = arr(i)
                        If p.estado.ToUpper() <> "COBRADO" Then
                            Me.arrPresentaciones.Add(p)
                        End If

                    Next
                Else
                    MsgBox("No se encontraron presentaciones")
                End If


            Finally
                catPresentacion = Nothing
            End Try

            cargarGrillaPresentaciones()
        End If

    End Sub

    Private Sub cargarGrillaPresentacionAMR()
        'limpio la grilla si ya habia algo
        If (Me.dgvPresentacionAMR.Rows.Count > 0) Then
            Me.dgvPresentacionAMR.Rows.Clear()
        End If

        For Each p As AMRAsociacion In Me.oPresentacionAMR.asociacion

            Dim r As New DataGridViewRow
            Me.dgvPresentacionAMR.Rows.Add(p.Presentacion.idPresentacion, p.Presentacion.fechaFacturacion.ToString().Remove(10), p.Presentacion.estado, p.Presentacion.obraSocial, p.nroRemito, p.Presentacion.total)

        Next

    End Sub
    Private Sub cargarGrillaPresentaciones()

        Me.lstPresentaciones.BeginUpdate()
        'limpio la grilla si ya habia algo
        If (Me.lstPresentaciones.Items.Count > 0) Then
            Me.lstPresentaciones.Items.Clear()
        End If

        For Each p As Presentacion In Me.arrPresentaciones
            Dim item As ListViewItem
            item = Me.lstPresentaciones.Items.Add(p.idPresentacion.ToString())
            item.SubItems.Add(p.fechaFacturacion.ToString().Remove(10))
            item.SubItems.Add(p.estado)
            item.SubItems.Add(p.comprobante.NroComprobante.ToString())
            item.SubItems.Add(p.total.ToString())
        Next
        Me.lstPresentaciones.EndUpdate()

    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        Dim resp As DialogResult = MessageBox.Show("Esta segura de sacar la presentacion actual?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

        If resp = Windows.Forms.DialogResult.Yes Then
            If Me.dgvPresentacionAMR.SelectedRows.Count > 0 Then
                Me.oPresentacionAMR.removePresentacion(oPresentacionAMR.asociacion(Me.dgvPresentacionAMR.CurrentRow.Index).Presentacion)
                Me.cargarGrillaPresentacionAMR()
            Else
                MessageBox.Show("No hay presentaciones seleccionadas")
            End If
        End If 'fin resp
        
    End Sub

    'Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
    '    Dim d As DialogResult = MessageBox.Show("Desea guardar la presentacion a AMR?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
    '    If d = Windows.Forms.DialogResult.Yes Then
    '        If validateData() Then
    '            oPresentacionAMR.mes = cHelp.getMonthNumber(cmbMeses.Text)
    '            oPresentacionAMR.ano = CInt(cmbAno.Text)
    '            oPresentacionAMR.quincena = CInt(cmbQuincena.Text)

    '            'como las celdas de remito son editables, tenemos que recorrer las filas y guardarlas
    '            Me.cargarLineasDatagrid()

    '            If Alta Then
    '                Dim resp As String = oPresentacionAMR.crear()
    '                If resp = "ok" Then
    '                    MsgBox("La presentación se ha creado con éxito")
    '                Else
    '                    MsgBox(resp, MsgBoxStyle.Critical)
    '                End If
    '                'asumo que si hay error, se produo cuando se insertan las facturaciones (facturaciones_factAMR)
    '                'talvez sea necesario manejar mejor el error.
    '                Alta = False
    '            Else
    '                'Dim resp As String = oPresentacionAMR.guardar()
    '                'If resp = "ok" Then
    '                '    MsgBox("La presentación a AMR se ha modificado con éxito")
    '                'Else
    '                '    MsgBox(resp, MsgBoxStyle.Critical)
    '                'End If
    '            End If 'Alta
    '        End If 'fin if validate data
    '    End If 'fin if del dialog result

    'End Sub


    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim d As DialogResult = MessageBox.Show("Desea guardar la presentacion a AMR?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
        If d = Windows.Forms.DialogResult.Yes Then
            If validateData() Then
                oPresentacionAMR.mes = cHelp.getMonthNumber(cmbMeses.Text)
                oPresentacionAMR.ano = CInt(cmbAno.Text)
                oPresentacionAMR.quincena = CInt(cmbQuincena.Text)

                'como las celdas de remito son editables, tenemos que recorrer las filas y guardarlas
                Me.cargarLineasDatagrid()
                Dim resp As String = oPresentacionAMR.update()
            End If 'fin if validate data
        End If 'fin if del dialog result

    End Sub

    Private Sub cargarCombo()

        Dim os As New ObraSocial
        Dim catalogoObraSocial As New CatalogoDeObrasSociales
        Dim i As Integer
        Dim arr As New ArrayList
        arr = catalogoObraSocial.GetOS(1)
        cmbObraSocial.Items.Add("Seleccione una Obra Social..")
        For i = 0 To arr.Count - 1
            os = arr(i)
            arrObraSocial.Add(os)
            cmbObraSocial.Items.Add(os)
        Next
        cmbObraSocial.SelectedIndex = 0

        'cargamos el combo de meses
        Dim arrMonths As String() = cHelp._getMonthsArr()
        cmbMeses.Items.Add("Mes")
        For j As Integer = 0 To UBound(arrMonths)
            cmbMeses.Items.Add(arrMonths(j))
        Next

        cmbMeses.SelectedIndex = 0

        'cargamos el combo quincena
        cmbQuincena.Items.Add("Quincena")
        cmbQuincena.Items.Add("1")
        cmbQuincena.Items.Add("2")
        cmbQuincena.SelectedIndex = 0

        'cargamos el combo año
        cmbAno.Items.Add("Año")
        cmbAno.Items.Add("2007")
        cmbAno.Items.Add("2008")
        cmbAno.Items.Add("2009")
        cmbAno.Items.Add("2010")
        cmbAno.Items.Add("2011")
        cmbAno.Items.Add("2012")
        cmbAno.Items.Add("2013")
        cmbAno.Items.Add("2014")
        cmbAno.Items.Add("2015")
        cmbAno.Items.Add("2016")
        cmbAno.SelectedItem = CStr(Today.Year)




    End Sub

    Private Function validateData() As Boolean
        If cmbQuincena.SelectedIndex = 0 Then
            MsgBox("Debe elegirse la quincena de la presentación.", MsgBoxStyle.Critical)
            Return False
        End If
        If cmbMeses.SelectedIndex = 0 Then
            MsgBox("Debe elegirse el mes de la presentación.", MsgBoxStyle.Critical)
            Return False
        End If

        If cmbAno.SelectedIndex = 0 Then
            MsgBox("Debe elegirse el año de la presentación", MsgBoxStyle.Critical)
            Return False
        End If

        If Me.oPresentacionAMR.asociacion.Count = 0 Then
            MsgBox("La presentación no contiene facturaciones. Debe tener al menos una para poder guardar.", MsgBoxStyle.Critical)
            Return False
        End If

        Return True
    End Function

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub verDetallePresentacion()
        Dim p As New Presentacion
        'tenemos que ver si es el detalle de una presentacion o una presentacionAMR
        If Me.dgvPresentacionAMR.SelectedRows.Count > 0 Then
            p = Me.oPresentacionAMR.asociacion(Me.dgvPresentacionAMR.CurrentRow.Index).Presentacion
        ElseIf Me.lstPresentaciones.SelectedItems.Count > 0 Then
            p = Me.arrPresentaciones(lstPresentaciones.SelectedIndices(0))
        End If

        If p.pagado = 0 Then
            Dim frm As New FacturacionDetalle(p.idPresentacion)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        ElseIf p.pagado = 1 Then
            'Cobrado
            Dim frm As New FacturacionCobradaDetalle(p)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        ElseIf p.pagado = 2 Then
            'Abierta
            If hayUnaFacturacionInstanciada Then
                MsgBox("Ya hay una ventana Nueva Facturación abierta. Ciérrela y vuelva a intentarlo.", MsgBoxStyle.Information, "No se puede abrir la ventana Nueva Facturación")
            Else
                Dim frm As New NuevaPresentacion(p.idPresentacion)
                frm.MdiParent = Me.Parent.Parent
                frm.Show()
            End If

        End If
    End Sub


    Private Sub lstPresentaciones_MouseDoubleClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lstPresentaciones.MouseDoubleClick
        If Me.lstPresentaciones.SelectedItems.Count = 0 Then
            MsgBox("Seleccione una presentacion primero")
        Else
            'como vamos a crear la presentacion directamente, checkeo si existen presentaciones en lista
            If Me.oPresentacionAMR.asociacion.Count = 0 Then
                'creo la presentacion
                Me.oPresentacionAMR.crear()
            End If

            'si entonces ya fue creada, ahora cargo la linea
            If Me.oPresentacionAMR.addPresentacion(Me.arrPresentaciones(Me.lstPresentaciones.SelectedIndices(0))) Then
                Me.cargarGrillaPresentacionAMR()
                'Ahora sacamos de la lista la seleccionada y refrescamos
                Me.cargarGrillaPresentaciones()
            Else
                MsgBox("Ya se agregó esta presentación. Seleccione otra por favor")
            End If
        End If
    End Sub
    Private Sub VerDetalleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerDetalleToolStripMenuItem.Click
        If Me.lstPresentaciones.SelectedItems.Count > 0 Then
            Me.verDetallePresentacion()
        End If
    End Sub

    Private Sub cargarLineasDatagrid()
        For Each row As DataGridViewRow In Me.dgvPresentacionAMR.Rows
            If row.Cells("colRemito").Value >= 0 Then
                Me.oPresentacionAMR.asociacion(row.Index).nroRemito = Convert.ToInt32(row.Cells("colRemito").Value)
            Else
                MessageBox.Show("Columna remito: revisar valores!!")
            End If
        Next
    End Sub




    Private Sub dgvPresentacionAMR_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPresentacionAMR.CellDoubleClick
        verDetallePresentacion()
    End Sub

    Private Sub ContextMenuStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ContextMenuStrip1.ItemClicked

    End Sub
End Class

