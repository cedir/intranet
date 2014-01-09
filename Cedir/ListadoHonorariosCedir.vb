Imports CedirNegocios
Public Class ListadoHonorariosCedir

#Region "Variables de Instancia"
    Dim catalogoEstudios As New CatalogoDeEstudios
    Dim arrl As ArrayList
    Dim myTable As DataTable = New DataTable("myTable")

#End Region

#Region "Eventos"
    Private Sub ListadoHonorariosCedir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Tipo de Estudio", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Medico Actuante", Type.GetType("System.String"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clMedSolicitante As New DataColumn("Medico Solicitante", Type.GetType("System.String"))
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clEstado As New DataColumn("Estado", Type.GetType("System.String"))
        Dim clImporte As New DataColumn("Importe", Type.GetType("System.String"))

        ' Dim clGastoAdm As New DataColumn("GastoAdm", Type.GetType("System.String"))
        'Dim clPagoActuante As New DataColumn("PagoActuante", Type.GetType("System.String"))
        'Dim clPagoSolicitante As New DataColumn("PagoSolicitante", Type.GetType("System.String"))
        Dim clPagoContraFactura As New DataColumn("Es PCF", Type.GetType("System.String"))

        myTable.Columns.Add(clFechaEstudio)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clObraSocial)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clMedSolicitante)
        myTable.Columns.Add(clEstado)
        myTable.Columns.Add(clImporte)

        'myTable.Columns.Add(clGastoAdm)

        'myTable.Columns.Add(clPagoActuante)
        'myTable.Columns.Add(clPagoSolicitante)
        myTable.Columns.Add(clPagoContraFactura)

        'dejamos seleccionado por defecto el primer elemento del comboBox
        Me.cmbPracticas.SelectedIndex = 0

    End Sub
#End Region



    Private Sub cargarGrilla()
        Me.dgv.Rows.Clear()

        Select Case True
            Case Me.cmbPracticas.SelectedIndex = 0
                'en el caso de ecografias tramemos los estudios de los docs Montorfano y Vera
                '(solo ecografias)
                arrl = catalogoEstudios.TraerEstudios(, , 441, , Me.txtFechaDesde.Text, Me.txtFechaHasta.Text, , , )
                arrl.AddRange(catalogoEstudios.TraerEstudios(, , 452, , Me.txtFechaDesde.Text, Me.txtFechaHasta.Text, , , ))
            Case Me.cmbPracticas.SelectedIndex = 1
                'en el caso de analisis bioquimicos, la practica siempre es analisis bioquimicos
                Dim p As New Practica
                p.idEstudio = 91
                arrl = catalogoEstudios.TraerEstudios(, , , , Me.txtFechaDesde.Text, Me.txtFechaHasta.Text, p, , )
                p = Nothing

        End Select

        Dim i As Integer
        If arrl.Count > 0 Then

            Dim est As Estudio
            For i = 0 To arrl.Count - 1
                est = arrl(i)
                Dim dgr As New DataGridViewRow
                dgr.CreateCells(Me.dgv)

                dgr.Cells(0).Value = est.fechaEstudio.ToString().Remove(10)

                dgr.Cells(0).Value = est.fechaEstudio.ToString().Remove(10)
                dgr.Cells(1).Value = est.paciente.nombreCompleto
                dgr.Cells(2).Value = est.practica.Estudio
                dgr.Cells(3).Value = est.obraSocial.ObraSocial
                dgr.Cells(4).Value = est.medicoActuante.apellido
                dgr.Cells(5).Value = est.medicoSolicitante.apellido
                dgr.Cells(6).Value = Me.setImporteEstudio(est)
                Dim estado As String
                If est.nroPagoMedicoActuante <> 0 Then
                    estado = "Cobrado"
                Else
                    estado = "Sin cobrar"
                End If
                dgr.Cells(7).Value = estado
                Me.dgv.Rows.Add(dgr)
            Next
        Else
            MsgBox("No se encontraron resultados")
        End If
        ' myTable.AcceptChanges()
        'DataGrid1.DataSource = myTable
        'dgv.DataSource = myTable
        Me.MostrarSumaLabels()
    End Sub
    Private Function setImporteEstudio(ByVal est As Estudio) As Decimal
        'La regla de negocio(segun mariana)Es: a los pagos CF, GA=0, para los demas 15%
        If est.esPagoContraFactura = 1 Then
            Return Format(est.PagoContraFactura, "#############0.00")
        Else
            Return Format(est.ImporteEstudio * 0.85, "#############0.00")
        End If
    End Function
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
    Private Sub btnSeleccionar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSeleccionar.Click
        If validar() Then
            cargarGrilla()
        End If
    End Sub
    Private Function validar() As Boolean
        Select Case True
            Case (Me.cmbPracticas.SelectedIndex = -1)
                MessageBox.Show("Seleccione una práctiva valida", "Atención", MessageBoxButtons.OK)
                Return False
            Case (Me.txtFechaDesde.Text = "" And Me.txtFechaHasta.Text = "")
                MessageBox.Show("Seleccione un rango de fechas válido", "Atención", MessageBoxButtons.OK)
                Return False

            Case Else
                Return True
        End Select

    End Function
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
    Private Sub MostrarSumaLabels()
        Dim est As New Estudio
        Dim i As Integer
        Dim pagoCF As Decimal = 0
        Dim importe As Decimal = 0

        Dim honorarioCedir As Decimal = 0
        Dim honorarioMedicoSol As Decimal = 0
        Dim honorarioMedicoAct As Decimal = 0

        For i = 0 To arrl.Count - 1
            est = arrl(i)
            importe = Format(importe + Convert.ToDecimal(Me.dgv.Rows(i).Cells("colImporte").Value), "#############0.00")
        Next

        Me.lblTotalMedicoSolicitante.Text = (importe * 0.15).ToString()
        Me.lblTotMedAct.Text = (importe * 0.7).ToString()
        Me.lblHonorarioCedir.Text = (importe * 0.15).ToString()
        Me.lblImporte.Text = importe.ToString()


    End Sub
    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New rptViewer
        Me.AddOwnedForm(f)
        f.printHonorariosCedir(Me.dgv, Me.lblTotMedAct.Text, Me.lblTotalMedicoSolicitante.Text, Me.lblHonorarioCedir.Text)
        f.ShowDialog()

    End Sub
End Class