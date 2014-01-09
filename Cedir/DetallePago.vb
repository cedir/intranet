Imports CedirNegocios
Public Class DetallePago
    Inherits System.Windows.Forms.Form
    Dim cPago As CedirNegocios.PagoMedico
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal pago As CedirNegocios.PagoMedico)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cPago = pago
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
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents lblMedico As System.Windows.Forms.Label
    Friend WithEvents lblTotal As System.Windows.Forms.Label
    Friend WithEvents lblIVA As System.Windows.Forms.Label
    Friend WithEvents txtObservaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New Cedir.wallyGrid
        Me.lblMedico = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblTotal = New System.Windows.Forms.Label
        Me.lblIVA = New System.Windows.Forms.Label
        Me.txtObservaciones = New System.Windows.Forms.RichTextBox
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(8, 56)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(864, 208)
        Me.DataGrid1.TabIndex = 0
        '
        'lblMedico
        '
        Me.lblMedico.Location = New System.Drawing.Point(24, 16)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(328, 23)
        Me.lblMedico.TabIndex = 1
        Me.lblMedico.Text = "Label1"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(13, 397)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(64, 23)
        Me.btnImprimir.TabIndex = 2
        Me.btnImprimir.Text = "Imprimir"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(93, 397)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(64, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(520, 16)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(152, 23)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Label1"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(696, 274)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(27, 13)
        Me.lblTotal.TabIndex = 6
        Me.lblTotal.Text = "total"
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Location = New System.Drawing.Point(696, 306)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(21, 13)
        Me.lblIVA.TabIndex = 7
        Me.lblIVA.Text = "iva"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Location = New System.Drawing.Point(13, 271)
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.ReadOnly = True
        Me.txtObservaciones.Size = New System.Drawing.Size(571, 94)
        Me.txtObservaciones.TabIndex = 8
        Me.txtObservaciones.Text = ""
        '
        'DetallePago
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(893, 435)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "DetallePago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle de pago"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region
    Dim arrLineas As ArrayList
    Dim tblEstudiosMedico As DataTable = New DataTable("tblEstudios")

    Private Sub DetallePago_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Grilla de resumen de estudios para un medico
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.DateTime"))
        Dim clObraSocial As New DataColumn("Obra Social", Type.GetType("System.String"))
        Dim clPractica As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clPaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        'Dim clImporteCobrado As New DataColumn("Importe", Type.GetType("System.String"))
        'Dim clFechaCobro As New DataColumn("Cobrado", Type.GetType("System.DateTime"))
        Dim clPagado As New DataColumn("Pago", Type.GetType("System.String"))
        Dim clCondicion As New DataColumn("Condición", Type.GetType("System.String"))
        Dim clMontoDelEstudioIVA21 As New DataColumn("IVA", Type.GetType("System.String"))
        Dim clTotalConIVA As New DataColumn("Total", Type.GetType("System.String"))

        tblEstudiosMedico.Columns.Add(clFechaEstudio)
        tblEstudiosMedico.Columns.Add(clPaciente)
        tblEstudiosMedico.Columns.Add(clObraSocial)
        tblEstudiosMedico.Columns.Add(clPractica)
        tblEstudiosMedico.Columns.Add(clCondicion)
        'tblEstudiosMedico.Columns.Add(clImporteCobrado) Lo saco porque hay que hacer algunas logicas para obtener este valor (polipectomia, porc. de gasto administrativo, etc)
        'tblEstudiosMedico.Columns.Add(clFechaCobro)
        tblEstudiosMedico.Columns.Add(clPagado)
        tblEstudiosMedico.Columns.Add(clMontoDelEstudioIVA21)
        tblEstudiosMedico.Columns.Add(clTotalConIVA)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "tblEstudios"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "Fecha"
        TextCol0.HeaderText = "Fecha"
        TextCol0.Width = 70
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCo3 As New DataGridTextBoxColumn
        TextCo3.MappingName = "Paciente"
        TextCo3.HeaderText = "Paciente"
        TextCo3.Width = 115
        ts1.GridColumnStyles.Add(TextCo3)

        Dim TextCo2 As New DataGridTextBoxColumn
        TextCo2.MappingName = "Obra Social"
        TextCo2.HeaderText = "Obra Social"
        TextCo2.Width = 150
        ts1.GridColumnStyles.Add(TextCo2)

        Dim TextCo4 As New DataGridTextBoxColumn
        TextCo4.MappingName = "Práctica"
        TextCo4.HeaderText = "Práctica"
        TextCo4.Width = 180
        ts1.GridColumnStyles.Add(TextCo4)

        Dim TextCo5 As New DataGridTextBoxColumn
        TextCo5.MappingName = "Condición"
        TextCo5.HeaderText = "Condición"
        TextCo5.Width = 110
        ts1.GridColumnStyles.Add(TextCo5)

        Dim TextCo6 As New DataGridTextBoxColumn
        TextCo6.MappingName = "Pago"
        TextCo6.HeaderText = "Pago"
        TextCo6.Width = 50
        ts1.GridColumnStyles.Add(TextCo6)

        Dim TextCo7 As New DataGridTextBoxColumn
        TextCo7.MappingName = "IVA"
        TextCo7.HeaderText = "IVA"
        TextCo7.Width = 50
        ts1.GridColumnStyles.Add(TextCo7)

        Dim TextCo8 As New DataGridTextBoxColumn
        TextCo8.MappingName = "Total"
        TextCo8.HeaderText = "Total"
        TextCo8.Width = 50
        ts1.GridColumnStyles.Add(TextCo8)

        DataGrid1.TableStyles.Add(ts1)


        lblMedico.Text = cPago.medico.nombreCompleto
        lblFecha.Text = "Fecha de pago: " & cPago.fecha

        arrLineas = cPago.getLineas

        cargarEstudiosDeMedico()
        setLabelsTotal()
        cargarObservaciones()
    End Sub

    Sub cargarObservaciones()
        Me.txtObservaciones.Text = Me.cPago.observacion()
    End Sub


    Private Sub cargarEstudiosDeMedico()
        Dim NewRow As DataRow
        Dim i As Integer
        Dim total As Single = 0

        Dim cLinea As LineaPagoMedico
        If arrLineas.Count > 0 Then
            For i = 0 To arrLineas.Count - 1
                NewRow = tblEstudiosMedico.NewRow()
                cLinea = arrLineas(i)
                NewRow("Fecha") = cLinea.estudio.fechaEstudio
                NewRow("Paciente") = cLinea.estudio.paciente.nombreCompleto
                NewRow("Obra Social") = cLinea.estudio.obraSocial.ObraSocial
                NewRow("Práctica") = cLinea.estudio.practica.Estudio
                If cLinea.estudio.medicoActuante.idMedico = cLinea.estudio.medicoSolicitante.idMedico Then
                    NewRow("Condición") = "Actuante-Solicitante"
                    NewRow("Pago") = cLinea.estudio.importePagoMedicoActuante
                Else
                    If cLinea.estudio.medicoActuante.idMedico = cPago.medico.idMedico Then
                        NewRow("Condición") = "Actuante"
                        NewRow("Pago") = cLinea.importe
                        'NewRow("Total") = cLinea.estudio.importePagoMedicoActuante
                    Else
                        NewRow("Condición") = "Solicitante"
                        NewRow("Pago") = cLinea.estudio.importePagoMedicoSolicitante
                    End If
                End If

                If cLinea.estudio.medicoActuante.esResponsableInscripto() Then
                    NewRow("IVA") = Format((cLinea.importe * cLinea.porcentajeIVAPagoMedicoActuante / 100), "############0.00")
                Else
                    NewRow("IVA") = 0.0
                End If

                NewRow("Total") = Convert.ToDecimal(NewRow("Pago")) + Convert.ToDecimal(NewRow("IVA"))
                tblEstudiosMedico.Rows.Add(NewRow)
            Next
        End If
        tblEstudiosMedico.AcceptChanges()
        DataGrid1.DataSource = tblEstudiosMedico


    End Sub

    Private Sub setLabelsTotal()

        Dim IVA As Decimal
        Dim total As Decimal = 0.0
        Dim i As Integer
        For i = 0 To arrLineas.Count - 1
            If Convert.ToDecimal(Me.tblEstudiosMedico.Rows(i).Item("IVA")) <> 0 Then
                IVA += Convert.ToDecimal(Me.tblEstudiosMedico.Rows(i).Item("IVA"))
            End If

            total += Convert.ToDecimal(Me.tblEstudiosMedico.Rows(i).Item("Total"))
        Next

        Me.lblTotal.Text = "Total : $ " & Math.Round(total, 2)
        Me.lblIVA.Text = "Total IVA : $ " & Format(IVA, "############0.00")

    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        'Si se desea usar tamaños seteados, fijar el mismo para cada columna de la grilla
        Dim arrWidth(7) As Single
        arrWidth(0) = 80    'fecha
        arrWidth(1) = 200    'paciente
        arrWidth(2) = 150  'Obra social
        arrWidth(3) = 180   'Estudio
        arrWidth(4) = 110
        arrWidth(5) = 60
        arrWidth(6) = 60
        arrWidth(7) = 60
        'Luego setiar el nuevo arreglo de tamaños
        DataGrid1.columnsWidth = arrWidth

        'Titulos
        DataGrid1.imprimirTitle = cPago.medico.nombreCompleto
        DataGrid1.imprimirSubTitleSuperior1 = "Fecha de pago: " & CStr(cPago.fecha)

        If cPago.observacion <> "" Then
            DataGrid1.imprimirSubTitleInferior2 = "Observaciones: " & cPago.observacion
        End If

        DataGrid1.apaizada = True
        'Finalmente, imprimir
        DataGrid1.imprimir(arrLineas.Count, 8)
    End Sub
End Class
