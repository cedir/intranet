Imports CedirNegocios
Imports System.Collections.Generic
Public Class PresentacionAMRBuscar
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
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lstPresentaciones As System.Windows.Forms.ListView
    Friend WithEvents Periodo As System.Windows.Forms.ColumnHeader
    Friend WithEvents cmbAno As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMeses As System.Windows.Forms.ComboBox
    Friend WithEvents cmbQuincena As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents estado As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnVer = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbAno = New System.Windows.Forms.ComboBox
        Me.cmbMeses = New System.Windows.Forms.ComboBox
        Me.cmbQuincena = New System.Windows.Forms.ComboBox
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.lstPresentaciones = New System.Windows.Forms.ListView
        Me.Periodo = New System.Windows.Forms.ColumnHeader
        Me.estado = New System.Windows.Forms.ColumnHeader
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(8, 326)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(48, 23)
        Me.btnVer.TabIndex = 4
        Me.btnVer.Text = "Ver"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(71, 326)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.Text = "Cerrar"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbAno)
        Me.GroupBox3.Controls.Add(Me.cmbMeses)
        Me.GroupBox3.Controls.Add(Me.cmbQuincena)
        Me.GroupBox3.Location = New System.Drawing.Point(8, 1)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(402, 46)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones de busqueda:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(263, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Año:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(147, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Mes:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Quincena"
        '
        'cmbAno
        '
        Me.cmbAno.FormattingEnabled = True
        Me.cmbAno.Location = New System.Drawing.Point(298, 19)
        Me.cmbAno.Name = "cmbAno"
        Me.cmbAno.Size = New System.Drawing.Size(76, 21)
        Me.cmbAno.TabIndex = 20
        Me.cmbAno.Text = "Año"
        '
        'cmbMeses
        '
        Me.cmbMeses.FormattingEnabled = True
        Me.cmbMeses.Items.AddRange(New Object() {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"})
        Me.cmbMeses.Location = New System.Drawing.Point(183, 19)
        Me.cmbMeses.Name = "cmbMeses"
        Me.cmbMeses.Size = New System.Drawing.Size(74, 21)
        Me.cmbMeses.TabIndex = 22
        Me.cmbMeses.Text = "Mes"
        '
        'cmbQuincena
        '
        Me.cmbQuincena.FormattingEnabled = True
        Me.cmbQuincena.Items.AddRange(New Object() {"1", "2"})
        Me.cmbQuincena.Location = New System.Drawing.Point(62, 19)
        Me.cmbQuincena.Name = "cmbQuincena"
        Me.cmbQuincena.Size = New System.Drawing.Size(77, 21)
        Me.cmbQuincena.TabIndex = 21
        Me.cmbQuincena.Text = "Quincena"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(416, 12)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(83, 20)
        Me.btnBuscar.TabIndex = 18
        Me.btnBuscar.Text = "Buscar"
        '
        'lstPresentaciones
        '
        Me.lstPresentaciones.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Periodo, Me.estado})
        Me.lstPresentaciones.FullRowSelect = True
        Me.lstPresentaciones.GridLines = True
        Me.lstPresentaciones.HoverSelection = True
        Me.lstPresentaciones.Location = New System.Drawing.Point(8, 53)
        Me.lstPresentaciones.Name = "lstPresentaciones"
        Me.lstPresentaciones.Size = New System.Drawing.Size(637, 267)
        Me.lstPresentaciones.TabIndex = 18
        Me.lstPresentaciones.UseCompatibleStateImageBehavior = False
        Me.lstPresentaciones.View = System.Windows.Forms.View.Details
        '
        'Periodo
        '
        Me.Periodo.Text = "Periodo"
        Me.Periodo.Width = 203
        '
        'estado
        '
        Me.estado.Text = "Estado"
        Me.estado.Width = 429
        '
        'PresentacionAMRBuscar
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(657, 357)
        Me.Controls.Add(Me.lstPresentaciones)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnBuscar)
        Me.Name = "PresentacionAMRBuscar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PresentacionesAMR Buscar"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrFacturaciones As ArrayList
    Dim cHelp As New Helper
    Dim arrObrasSociales As New ArrayList
    Private Sub FacturacionAMRListar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For index As Integer = 0 To 10
            cmbAno.Items.Add(CStr(Today.Year - index))
        Next
    End Sub
    Private Sub cargar()
        Dim catPresentaciones As New CatalogoDePresentaciones
        Try
            arrFacturaciones = catPresentaciones.amrGetPresentaciones(, Date.Today.Month, Date.Today.Year.ToString(), )
            catPresentaciones = Nothing
            cargarGrilla()
        Catch ex As Exception

        Finally
            catPresentaciones = Nothing
        End Try
        
    End Sub
    Private Sub cargarGrilla()
        If arrFacturaciones.Count = 0 Then
            MsgBox("La búsqueda no dio resultados")
            Me.lstPresentaciones.Items.Clear()
        Else
            Dim i As Integer
            Dim oPres As New PresentacionAMR
            Me.lstPresentaciones.BeginUpdate()
            If (Me.lstPresentaciones.Items.Count > 0) Then
                Me.lstPresentaciones.Items.Clear()
            End If

            For i = 0 To arrFacturaciones.Count - 1
                oPres = arrFacturaciones(i)
                'limpio la grilla si ya habia algo
                Dim item As ListViewItem
                item = Me.lstPresentaciones.Items.Add("Quincena:" & oPres.quincena.ToString() & ",  Mes: " & oPres.mes.ToString() & ", Año: " & oPres.ano.ToString())
                item.SubItems.Add("Pendiente")

            Next

            Me.lstPresentaciones.EndUpdate()
            oPres = Nothing

        End If



    End Sub
    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        If Me.lstPresentaciones.SelectedItems.Count = 0 Then
            MsgBox("Seleccione una presentacion primero")
        Else
            Dim oPres As PresentacionAMR
            oPres = arrFacturaciones(Me.lstPresentaciones.SelectedIndices(0))

            Dim frm As New PresentacionAMRAltaModificacion(oPres.id)
            frm.MdiParent = Me.Parent.Parent

            frm.Alta = False
            frm.Text = "Modificacion de la presentacion AMR"
            frm.Show()
        End If

    End Sub
    Private Sub Buscar()
        Dim catPresentaciones As New CatalogoDePresentaciones
        Dim o As New ObraSocial
        arrFacturaciones = catPresentaciones.amrGetPresentaciones(Me.cmbQuincena.SelectedItem, Me.cmbMeses.SelectedIndex + 1, Me.cmbAno.SelectedItem, )
        Me.cargarGrilla()

    End Sub
    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        If Me.validar Then
            Buscar()
        Else
            MsgBox("No hay criterio de busqueda. Establezca uno por favor.")
        End If

    End Sub
    Private Function validar() As Boolean
        If Me.cmbQuincena.SelectedIndex = -1 And Me.cmbMeses.SelectedIndex = -1 And Me.cmbAno.SelectedIndex = -1 Then
            Return False
        Else : Return True
        End If
    End Function
    Private Sub teclaPresionada(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.Buscar()
        End If
    End Sub
    Private Sub PresentacionAMRBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Me.teclaPresionada(e)
    End Sub

    Private Sub cmbObraSocial_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    End Sub

  

    Private Sub PresentacionAMRBuscar_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated

        cargar()

    End Sub
End Class
