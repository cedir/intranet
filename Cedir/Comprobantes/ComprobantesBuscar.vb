Imports Cedir
Imports System.Data
Imports CedirNegocios
Imports System.Collections.Generic



Public Class ComprobantesBuscar

    Dim tabla As DataTable = New DataTable("tabla")
    Dim catalogoComprobantes As New CatalogoDeComprobantes
    Dim comprobantes As List(Of Comprobante)


    Private Sub ComprobantesBuscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.btnVer.Visible = False
        'creamos las columnas de la tabla
        Dim clNro As New DataColumn("NRO")
        Dim clNroTerminal As New DataColumn("TERMINAL")
        Dim clCliente As New DataColumn("CLIENTE")
        Dim clTipoComp As New DataColumn("TIPO COMPROBANTE")
        Dim clSubTipoComp As New DataColumn("SUBTIPO")
        Dim clResponsable As New DataColumn("RESPONSABLE")
        Dim clFechaEmi As New DataColumn("FECHA EMISION")
        Dim clEstado As New DataColumn("ESTADO")
        Dim clFactura As New DataColumn("FACTURA")
        'las agregamos a la tabla
        tabla.Columns.Add(clNroTerminal)
        tabla.Columns.Add(clNro)
        tabla.Columns.Add(clCliente)
        tabla.Columns.Add(clTipoComp)
        tabla.Columns.Add(clSubTipoComp)
        tabla.Columns.Add(clResponsable)
        tabla.Columns.Add(clFechaEmi)
        tabla.Columns.Add(clEstado)
        tabla.Columns.Add(clFactura)
        Me.cmbResponsable.SelectedIndex = 0
        Me.cmbTipoComprobante.SelectedIndex = 0


    End Sub

    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub Buscar()

        Dim help As New Helper
        Dim fechaInicial As Date
        Dim fechaFinal As Date
        Dim fechaIni As String = ""
        Dim fechaFin As String = ""

        Try

            Select Case True

                Case Me.txtFechaDesde.Text <> "" And Me.txtFechaHasta.Text <> ""

                    fechaInicial = CDate(Me.txtFechaDesde.Text)
                    fechaFinal = CDate(Me.txtFechaHasta.Text)


                    'validamos que las fechas sean validas
                    Select Case Date.Compare(fechaInicial, fechaFinal)

                        Case Is < 0
                            'la fechaInicial es menor que la fechaFinal
                            fechaInicial = New Date(fechaInicial.Year, fechaInicial.Month, fechaInicial.Day, 0, 0, 0)
                            fechaFinal = New Date(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 23, 59, 59)
                        Case 0
                            'las dos fechas son iguales
                            fechaInicial = New Date(fechaInicial.Year, fechaInicial.Month, fechaInicial.Day, 0, 0, 0)
                            fechaFinal = New Date(fechaFinal.Year, fechaFinal.Month, fechaFinal.Day, 23, 59, 59)
                        Case Is > 0
                            'las fechaInicial es mayor que la fechaFinal
                            'invierto valores de las fechas
                            fechaFinal = CDate(Me.txtFechaDesde.Text)
                            fechaInicial = CDate(Me.txtFechaHasta.Text)

                    End Select

                    'Utilizo regular expression para convertir la fecha
                    fechaIni = fechaInicial.Date.ToString.Substring(0, 10).Trim
                    fechaFin = fechaFinal.Date.ToString.Substring(0, 10).Trim

                    fechaIni = help.convertDate(fechaIni)
                    fechaFin = help.convertDate(fechaFin)
                Case Me.txtFechaDesde.Text = "" And Me.txtFechaHasta.Text <> ""
                    fechaFinal = CDate(Me.txtFechaHasta.Text)
                    fechaFin = fechaFinal.Date.ToString.Substring(0, 10).Trim
                    fechaFin = help.convertDate(fechaFin)
                Case Me.txtFechaDesde.Text <> "" And Me.txtFechaHasta.Text = ""
                    fechaInicial = CDate(Me.txtFechaDesde.Text)
                    fechaIni = fechaInicial.Date.ToString.Substring(0, 10).Trim
                    fechaIni = help.convertDate(fechaIni)

            End Select
            If (Me.txtNroComprobante.Text = "" And (Me.txtFechaDesde.Text = "" And Me.txtFechaHasta.Text = "")) Then
                MessageBox.Show("Ingrese un período valido", "Atención", MessageBoxButtons.OK)
            Else
                comprobantes = catalogoComprobantes.getComprobantes(Me.txtNroComprobante.Text, Me.cmbTipoComprobante.Text, Me.cmbResponsable.Text(), fechaIni, fechaFin, Me.txtNombreCliente.Text.ToUpper())
                'cargamos los comprobantes encontrados
                Me.cargarGrilla()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Information)

        Finally
            Me.MonthCalendar1.Visible = False
            Me.btnSelFechaDesde.Visible = True
            Me.btnSelFechaHasta.Visible = True
        End Try

    End Sub

    Private Sub cargarGrilla()
        Me.tabla.Clear()
        Me.datagridComprobantes.DataSource = Nothing

        Dim NewRow As DataRow
        Dim i As Integer
        If comprobantes.Count > 0 Then
            'Habilitamos el control 
            Me.btnVer.Visible = True

            For i = 0 To comprobantes.Count - 1
                Dim c As New Comprobante
                c = comprobantes(i)
                NewRow = tabla.NewRow()
                NewRow("TERMINAL") = c.NroTerminal
                NewRow("NRO") = c.NroComprobante
                NewRow("CLIENTE") = c.NombreCliente
                NewRow("TIPO COMPROBANTE") = c.TipoComprobante.Descripcion
                NewRow("SUBTIPO") = c.SubTipo
                NewRow("TIPO COMPROBANTE") = c.TipoComprobante.Descripcion
                NewRow("FECHA EMISION") = c.FechaEmision
                NewRow("ESTADO") = c.Estado
                If (c.Factura IsNot Nothing) Then
                    NewRow("FACTURA") = c.Factura.NroComprobante
                Else
                    NewRow("FACTURA") = ""
                End If

                NewRow("RESPONSABLE") = c.Responsable
                tabla.Rows.Add(NewRow)
            Next
            tabla.AcceptChanges()
            Me.datagridComprobantes.DataSource = tabla

            'deshabilitamos la opcion de ordenacion
            For Each dc As DataGridViewColumn In Me.datagridComprobantes.Columns
                dc.SortMode = DataGridViewColumnSortMode.NotSortable
            Next

        Else
            MessageBox.Show("No hay comprobantes", " Comprobantes ", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1)
        End If

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnVer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVer.Click
        'Seleccionamos el comprobante de la grilla
        Dim frm As New Comprobantes()
        Me.AddOwnedForm(frm)
        frm.Comprobante = Me.GetComprobanteActualGrilla()
        frm.ShowDialog()
    End Sub

    Private Sub btnAgregarComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarComprobante.Click
        Dim c As Comprobante
        Dim i As Integer
        i = Me.datagridComprobantes.CurrentRow.Index
        c = comprobantes(i)
        If (c.TipoComprobante.Descripcion = "FACTURA") Then
            Dim f As New frmComprobanteNuevo
        End If
    End Sub

    Public Function GetComprobanteActualGrilla() As Comprobante
        Dim c As Comprobante
        Dim i As Integer
        i = Me.datagridComprobantes.CurrentRow.Index
        c = comprobantes(i)
        Return c
    End Function 'la llamamos del frm "Comprobantes"

    'Public Sub Reload()
    '   Controls.Clear()
    '  InitializeComponent()
    ' Me.cargarGrilla()
    'End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click

    End Sub

    Private Sub txtNroComprobante_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNroComprobante.KeyDown
        teclaPresionada(e)

    End Sub

    Private Sub txtFechaDesde_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFechaDesde.KeyDown
        teclaPresionada(e)

    End Sub
    Private Sub teclaPresionada(ByVal e As System.Windows.Forms.KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            Me.Buscar()
        End If
    End Sub

    Private Sub txtFechaHasta_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFechaHasta.KeyDown
        teclaPresionada(e)
    End Sub

    Private Sub ComprobantesBuscar_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        teclaPresionada(e)
    End Sub

    Private Sub btnSelFechaDesde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelFechaDesde.Click
        Me.MonthCalendar1.Visible = True
        Me.btnSelFechaDesde.Visible = False
        Me.txtFechaDesde.Text = ""
    End Sub

    Private Sub btnSelFechaHasta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelFechaHasta.Click
        Me.MonthCalendar1.Visible = True
        Me.btnSelFechaHasta.Visible = False
        Me.txtFechaHasta.Text = Date.Today.ToString().Remove(11)
    End Sub

    Private Sub MonthCalendar1_DateSelected(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar1.DateSelected
        If (Me.txtFechaDesde.Text <> "") Then
            Me.txtFechaHasta.Text = Me.MonthCalendar1.SelectionRange().Start.Date.ToString().Remove(11)
        Else
            Me.txtFechaDesde.Text = Me.MonthCalendar1.SelectionRange().Start.Date.ToString().Remove(11)
        End If
        Me.MonthCalendar1.Visible = False
        Me.btnSelFechaDesde.Visible = True
        Me.btnSelFechaHasta.Visible = True
    End Sub
End Class