Imports System.Collections.Generic
Imports System.IO
Imports System.ComponentModel
Imports CedirNegocios

Public Class AnestesistasListadoHonorarios

    Dim catalogoEstudios As New CatalogoDeEstudios
    Dim cCal As New CalculadorHonorariosAnestesistas
    Dim arrEstudios As New ArrayList
    Dim arrAnestesistas As ArrayList
    Dim arrMeses(12) As String
    Dim sMedicoAnestesista As Medico
    ' Dim estudiosSinComprobante As New ArrayList
    'Dim oBinding As New BindingSource
    'Dim bl As New BindingList(Of Estudio)
    Dim pago As PagoAnestesista
    Dim pagoSinComprobante As PagoAnestesista



#Region "Eventos del formulario"
    Private Sub AnestesistaListado1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbAno.SelectedIndex = 1
        Me.cmbMeses.SelectedIndex = 0
        Me.cargarComboAnestesistas()
        sMedicoAnestesista = arrAnestesistas(cmbAnestesistas.SelectedIndex)
        Me.btnSinComprobante.Enabled = False
        Me.lblAPagarDGV2.Text = "0"
        Me.lblDGV2.Text = "0"
    End Sub
#End Region

#Region "Eventos de Buttons"
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Me.dgvListadoGeneral.Rows.Count > 0 Then
            Dim f As New rptViewer
            Me.AddOwnedForm(f)
            f.imprimirGrillaAnestesistas(Me.pago, pagoSinComprobante, Me.dgvListadoGeneral, Me.dgvListadoSinComprobantes, sMedicoAnestesista.nombreCompleto, Me.txtHonEx.Text, Me.txtHon105.Text, Me.txtHon21.Text, Me.txtIVA21.Text, Me.txtIVA105.Text, Me.cmbMeses.SelectedItem.ToString())
            f.ShowDialog()

        Else
            MsgBox("Debe realizar una busqueda primero, antes de poder imprimir")
        End If
    End Sub

    Private Sub btnBuscarComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscarComprobante.Click

        If Me.dgvListadoGeneral.Rows.Count > 0 Then
            Dim f As New ComprobantesBuscar

            f.txtNombreCliente.Text = Me.dgvListadoGeneral.CurrentRow.Cells("colPaciente").Value.ToString.Split(",")(0)
            f.txtFechaDesde.Text = Me.dgvListadoGeneral.CurrentRow.Cells(0).Value.ToString()
            f.ShowDialog()
            f.btnBuscar.PerformClick()
        End If
    End Sub


    Private Sub btnSinComprobante_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSinComprobante.Click
        Dim indice As Integer = dgvListadoGeneral.CurrentRow.Index
        Me.agregarLineaDePagoSinComprobante()
        cargarGrilla()
        If indice > 0 Then
            Me.dgvListadoGeneral.Rows(indice - 1).Selected = True
            Me.dgvListadoGeneral.FirstDisplayedScrollingRowIndex = indice - 1
        End If

        Me.dgvListadoGeneral.PerformLayout()
        cargarGrillaSinComprobantes()
        Me.calcularHonorarioGravado()
        Me.calcularTotal()
    End Sub

    Private Sub btnFiltrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFiltrar.Click
        Dim mes As String = "01"

        If cmbMeses.Text = "Enero" Then
            mes = ("01")
        ElseIf cmbMeses.Text = "Febrero" Then
            mes = ("02")
        ElseIf cmbMeses.Text = "Marzo" Then
            mes = ("03")
        ElseIf cmbMeses.Text = "Abril" Then
            mes = ("04")
        ElseIf cmbMeses.Text = "Mayo" Then
            mes = ("05")
        ElseIf cmbMeses.Text = "Junio" Then
            mes = ("06")
        ElseIf cmbMeses.Text = "Julio" Then
            mes = ("07")
        ElseIf cmbMeses.Text = "Agosto" Then
            mes = ("08")
        ElseIf cmbMeses.Text = "Septiembre" Then
            mes = ("09")
        ElseIf cmbMeses.Text = "Octubre" Then
            mes = ("10")
        ElseIf cmbMeses.Text = "Noviembre" Then
            mes = ("11")
        ElseIf cmbMeses.Text = "Diciembre" Then
            mes = ("12")
        End If


        Dim com As String = """"
        sMedicoAnestesista = arrAnestesistas(cmbAnestesistas.SelectedIndex)
        arrEstudios = catalogoEstudios.getEstudiosPorAnestesista(" where" & com & "idAnestesista" & com & " = " & sMedicoAnestesista.idMedico & " and  date_part('month'," & com & "fechaEstudio" & com & ") = " & mes & " and  date_part('year'," & com & "fechaEstudio" & com & ") = " & Me.cmbAno.SelectedItem)


        'vaciamos el datagrid de los estudios particualres
        Me.dgvListadoGeneral.Rows.Clear()
        Me.dgvListadoSinComprobantes.Rows.Clear()
        If Me.pagoSinComprobante IsNot Nothing Then
            pagoSinComprobante.lineasDePago.Clear()
        End If
        Me.btnSinComprobante.Enabled = True
        Me.lblAPagarDGV2.Text = "0"
        Me.lblDGV2.Text = "0"

        If arrEstudios.Count > 0 Then
            pago = New PagoAnestesista
            pago.cargarEstudiosALineasDePago(arrEstudios)
            ProgressBar1.Maximum = pago.lineasDePago.Count()
            cargarGrilla()
            'Me.cargarGrilla()
        Else : MsgBox("No hay estudios")
            Exit Sub
        End If


        Me.calcularHonorarioGravado()
        Me.calcularTotal()
    End Sub
#End Region

#Region "Eventos datagrid General"
    Private Sub dgvListado_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvListadoGeneral.CellEndEdit
        If Me.dgvListadoGeneral.CurrentRow.Cells("colIDLinea").Value = Nothing Then
            Exit Sub
        End If

        Dim idLinea As Integer = Me.dgvListadoGeneral.Rows(e.RowIndex).Cells("colIDLinea").Value
        Dim cLinea As LineaPagoAnestesista = Me.pago.lineasDePago(idLinea)
        cLinea.cambiarImportesDeLinea(Me.dgvListadoGeneral.Rows(e.RowIndex).Cells("colIvaPorcentaje").Value, Me.dgvListadoGeneral.Rows(e.RowIndex).Cells("colImporte").Value)

        Me.dgvListadoGeneral.Rows(e.RowIndex).Cells("colIVA").Value = cLinea.ivaImporte
        Me.dgvListadoGeneral.Rows(e.RowIndex).Cells("colIvaPorcentaje").Value = cLinea.ivaPorcentaje
        Me.dgvListadoGeneral.Rows(e.RowIndex).Cells("colRetencion").Value = cLinea.retencion
        Me.dgvListadoGeneral.Rows(e.RowIndex).Cells("colApagar").Value = cLinea.importeApagar

        'sumar totales para los labels de abajo
        Me.calcularTotal()
        calcularHonorarioGravado()
    End Sub
#End Region

    
    Private Sub cargarComboAnestesistas()
        Dim catalogoMedicos As New CatalogoDeMedicos
        arrAnestesistas = catalogoMedicos.TodosLosAnestesistas()
        cmbAnestesistas.Items.Clear()
        For Each anestesista As Medico In arrAnestesistas
            cmbAnestesistas.Items.Add(anestesista.nombreCompleto)
        Next
        cmbAnestesistas.SelectedIndex = 0
    End Sub
    Private Sub cargarGrilla()

        Me.dgvListadoGeneral.Rows.Clear()
        Me.dgvListadoGeneral.AutoGenerateColumns = False
        Me.dgvListadoGeneral.DataSource = Nothing
        Dim idLineaPago As Integer = -1

        Me.ProgressBar1.Visible = True
        For Each linea As LineaPagoAnestesista In pago.lineasDePago
            Me.ProgressBar1.PerformStep()
            idLineaPago = idLineaPago + 1
            For Each _estudio As Estudio In linea.estudios
                Dim row As New DataGridViewRow
                'especificamos el estilo de celdas
                row.CreateCells(Me.dgvListadoGeneral)
                With row.Cells
                    .Item(0).Value = _estudio.fechaEstudio.ToString().Remove(10)
                    .Item(1).Value = _estudio.paciente.nombreCompleto
                    .Item(2).Value = _estudio.obraSocial.ObraSocial
                    .Item(3).Value = _estudio.practica.ToString()
                    .Item(4).Value = ""
                    .Item(5).Value = ""
                    .Item(6).Value = ""
                    .Item(7).Value = ""
                    .Item(8).Value = ""
                    .Item(9).Value = idLineaPago
                    .Item(10).Value = _estudio.nroEstudio
                End With
                row.DefaultCellStyle.BackColor = Color.White
                Me.dgvListadoGeneral.Rows.Add(row)
                row = Nothing
            Next

            'ESTA ES UNA NUEVA FILA, PARA EL GRUPO DE ESTUDIOS. (un subtotal)
            Dim dr As New DataGridViewRow
            'especificamos el estilo de celdas
            dr.CreateCells(Me.dgvListadoGeneral)
            With dr.Cells
                If linea.contieneEstudiosConMovimientosAsociados Then
                    .Item(0).Value = "Este estudio posee movimiento de caja"
                Else
                    .Item(0).Value = ""
                End If
                .Item(0).Style.BackColor = Color.White
                .Item(1).Style.BackColor = Color.White
                .Item(2).Style.BackColor = Color.White
                .Item(3).Style.BackColor = Color.White


                .Item(1).Value = ""
                .Item(2).Value = ""
                .Item(3).Value = ""
                .Item(4).Value = linea.importeComplejidad.ToString()
                .Item(5).Value = linea.ivaPorcentaje.ToString()
                .Item(6).Value = linea.importeComplejidad * linea.ivaPorcentaje / 100
                .Item(7).Value = linea.retencion.ToString()
                .Item(8).Value = linea.importeApagar.ToString()
                .Item(9).Value = idLineaPago

            End With
            dr.DefaultCellStyle.BackColor = Color.AliceBlue
            Me.dgvListadoGeneral.Rows.Add(dr)
            dr = Nothing

        Next

        ProgressBar1.Hide()
        Me.dgvListadoGeneral.ReadOnly = False
        Me.dgvListadoGeneral.EditMode = DataGridViewEditMode.EditOnF2
    End Sub
    Private Sub calcularTotal()
        Dim suma As Decimal
        For Each fila As DataGridViewRow In Me.dgvListadoGeneral.Rows
            If fila.Cells("colApagar").Value <> Nothing Then
                If fila.Cells("colApagar").Value.ToString() = "" Then
                    Continue For
                End If
                suma = suma + fila.Cells("colApagar").Value
            End If
        Next
        Me.lblTotalApagar.Text = "Total a pagar.....:  $ " & Format(suma, "##########0.00").ToString()


        'ahora seteamos los totales del segundo dgv
        Dim aPagarDGV2 As Decimal
        For Each fila As DataGridViewRow In Me.dgvListadoSinComprobantes.Rows
            If fila.Cells(8).Value.ToString() <> "" Then
                aPagarDGV2 = aPagarDGV2 + fila.Cells("cPagar").Value
            End If
        Next
        Me.lblAPagarDGV2.Text = Format(aPagarDGV2, "##########0.00").ToString()
        Me.lblDGV2.Text = Format(suma + aPagarDGV2, "##########0.00").ToString()
    End Sub
    Private Sub calcularHonorarioGravado()
        Dim hg21 As Decimal = 0
        Dim hg105 As Decimal = 0
        Dim he As Decimal = 0

        For Each linea As LineaPagoAnestesista In Me.pago.lineasDePago
            Select Case True
                Case (linea.ivaPorcentaje = 21.0)
                    hg21 = hg21 + (linea.importeComplejidad * 0.9)
                Case (linea.ivaPorcentaje = 10.5)
                    hg105 = hg105 + (linea.importeComplejidad * 0.9)
                Case (linea.ivaPorcentaje = 0.0)
                    he = he + (linea.importeApagar)
            End Select
        Next

        Me.txtHonEx.Text = Format(he, "############0.00")
        Me.txtHon21.Text = hg21.ToString()
        Me.txtHon105.Text = hg105.ToString()
        Me.txtIVA21.Text = Format(hg21 * 0.21, "############0.00")
        Me.txtIVA105.Text = Format(hg105 * 0.105, "###########0.00")

    End Sub

    Private Sub agregarLineaDePagoSinComprobante()
        'If Me.dgvListadoGeneral.CurrentRow.Cells("colIDLinea").Value = Nothing Then
        '    Exit Sub
        'End If
        Dim idLineaPago As Integer = Me.dgvListadoGeneral.CurrentRow.Cells("colIDLinea").Value
        Dim cLinea As LineaPagoAnestesista = Me.pago.lineasDePago(idLineaPago)

        If cLinea.estudios(0).obraSocial.ToString().ToUpper().IndexOf("PARTICULAR") <> -1 Then
            If Me.pagoSinComprobante Is Nothing Then
                Me.pagoSinComprobante = New PagoAnestesista
            End If

            Me.pago.lineasDePago.Remove(cLinea)
            Me.pagoSinComprobante.lineasDePago.Add(cLinea)
        Else : MessageBox.Show("No es un particular", "No se agregó el estudio")
        End If


    End Sub
    Private Sub cargarGrillaSinComprobantes()
        dgvListadoSinComprobantes.Rows.Clear()

        If Me.pagoSinComprobante Is Nothing Then
            Exit Sub
        End If

        For Each clinea As LineaPagoAnestesista In Me.pagoSinComprobante.lineasDePago
            For Each _estudio As Estudio In clinea.estudios
                Dim row As New DataGridViewRow
                'especificamos el estilo de celdas
                row.CreateCells(Me.dgvListadoSinComprobantes)
                With row.Cells
                    .Item(0).Value = _estudio.fechaEstudio.ToString()
                    .Item(1).Value = _estudio.paciente.nombreCompleto
                    .Item(2).Value = _estudio.obraSocial.ObraSocial
                    .Item(3).Value = _estudio.practica.ToString()
                    .Item(4).Value = ""
                    .Item(5).Value = ""
                    .Item(6).Value = ""
                    .Item(7).Value = ""
                    .Item(8).Value = ""
                End With
                row.DefaultCellStyle.BackColor = Color.White
                row.ReadOnly = True
                Me.dgvListadoSinComprobantes.Rows.Add(row)
                row = Nothing
            Next

            'ESTA ES UNA NUEVA FILA, PARA EL GRUPO DE ESTUDIOS. (un subtotal)
            Dim dr As New DataGridViewRow
            'especificamos el estilo de celdas
            dr.CreateCells(Me.dgvListadoSinComprobantes)
            With dr.Cells
                If clinea.contieneEstudiosConMovimientosAsociados Then
                    .Item(0).Value = "Este estudio posee movimiento de caja"
                End If
                .Item(0).Style.BackColor = Color.White
                .Item(1).Style.BackColor = Color.White
                .Item(2).Style.BackColor = Color.White
                .Item(3).Style.BackColor = Color.White
                .Item(4).Value = clinea.importeComplejidad.ToString()
                .Item(5).Value = clinea.ivaPorcentaje.ToString()
                .Item(6).Value = clinea.importeComplejidad * clinea.ivaPorcentaje / 100
                .Item(7).Value = clinea.retencion.ToString()
                .Item(8).Value = clinea.importeApagar.ToString()
            End With
            dr.DefaultCellStyle.BackColor = Color.AliceBlue
            Me.dgvListadoSinComprobantes.Rows.Add(dr)
            dr = Nothing
        Next
    End Sub
    Private Sub PacienteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PacienteToolStripMenuItem.Click
        Dim idLineaPago As Integer = Me.dgvListadoGeneral.CurrentRow.Cells("colIDLinea").Value
        Dim cLinea As LineaPagoAnestesista = Me.pago.lineasDePago(idLineaPago)
        Dim f As New AltaPaciente
        f.esAltaPaciente = False
        f.currentPaciente = (cLinea.estudios(0).paciente)
        f.ShowDialog()
    End Sub
    Private Sub EstudioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstudioToolStripMenuItem.Click
        If Me.dgvListadoGeneral.CurrentRow.Cells("colIDLinea").Value = Nothing Then
            Exit Sub
        End If
        Dim idLineaPago As Integer = Me.dgvListadoGeneral.CurrentRow.Cells("colIDLinea").Value
        Dim cLinea As LineaPagoAnestesista = Me.pago.lineasDePago(idLineaPago)
        Dim f As New frmEstudiosMovimientos
        f.DateTimePicker1.Value = cLinea.estudios(0).fechaEstudio
        f.ShowDialog()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitarEstudio.Click
        Dim nroEstudio As Integer = Me.dgvListadoGeneral.CurrentRow.Cells("colIDEstudio").Value
        Dim idLineaPago As Integer = Me.dgvListadoGeneral.CurrentRow.Cells("colIDLinea").Value
        Dim indice As Integer = dgvListadoGeneral.CurrentRow.Index
        Dim cLinea As LineaPagoAnestesista = Me.pago.lineasDePago(idLineaPago)
        For Each est As Estudio In cLinea.estudios
            If est.nroEstudio = nroEstudio Then
                cLinea.estudios.Remove(est)
                Exit For
            End If
        Next
        If cLinea.estudios.Count = 0 Then
            Me.pago.lineasDePago.Remove(cLinea)
        Else
            cLinea.setImportes()
        End If

        cargarGrilla()
        Me.dgvListadoGeneral.Rows(indice).Selected = True
        Me.dgvListadoGeneral.FirstDisplayedScrollingRowIndex = indice
        Me.dgvListadoGeneral.PerformLayout()
        Me.calcularHonorarioGravado()
        Me.calcularTotal()
    End Sub
End Class