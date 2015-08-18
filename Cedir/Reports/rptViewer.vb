Imports System
Imports CrystalDecisions
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.Windows.Forms 
Imports CrystalDecisions.ReportSource
Imports CedirNegocios
Imports System.Collections.Generic

Public Class rptViewer
    Private leyenda As String = "Esta factura contiene honorarios por cuenta y orden de médicos"

    Public Sub cargarDsComprobantes(ByVal comp As Comprobante, Optional ByVal conLeyenda As Boolean = False, Optional ByVal esPaciente As Boolean = False)
        Dim reporte As New rptComprobantes
        Dim ds As New dsComprobante
        Try
            'Limpiamos todo el dataset y cargamos los datos del comprobante
            ds.Clear()
            ds.Tables("Comprobante").Columns("id").AllowDBNull = True
            Dim r As DataRow
            r = ds.Tables("Comprobante").NewRow
            r("id") = comp.IdComprobante
            r("nroComprobante") = comp.NroComprobante.ToString()
            r("nombreCliente") = comp.NombreCliente
            r("domicilio") = comp.DomicilioCliente
            r("nroCuit") = comp.NroDocumento
            r("responsable") = comp.Responsable
            r("tipoComprobante") = comp.TipoComprobante.Descripcion
            r("fechaEmision") = comp.FechaEmision.Date.ToString()
            r("estado") = comp.Estado
            r("subtipo") = comp.SubTipo
            r("totalFacturado") = Format(comp.TotalFacturado, "#########0.00")

            If conLeyenda Then
                r("leyendaOpcional") = leyenda
            End If
            If esPaciente Then

                r("gravadoPaciente") = comp.GravadoPaciente
                r("condicionFiscal") = ""
                r("gravado") = ""
            Else
                r("nroCuit") = "Cuit : " & comp.NroDocumento
                r("condicionFiscal") = comp.CondicionFiscal
                ' si el comprobante es liquidacion no posee gravado
                If comp.TipoComprobante.Id = 2 Then
                    r("gravado") = ""
                Else
                    r("gravado") = comp.Gravado.porcentaje.ToString()
                End If
                r("gravadoPaciente") = ""
            End If


            ds.Comprobante.AddComprobanteRow(r)


            'ahora las lineas

            ds.Tables("LineaDeComprobante").Columns("id").AllowDBNull = True
            ds.Tables("LineaDeComprobante").Columns("idComprobante").AllowDBNull = True
            Dim r1 As DataRow
            For Each l As LineaDeComprobante In comp.LineasDeComprobante

                r1 = ds.Tables("LineaDeComprobante").NewRow
                r1("concepto") = l.Concepto
                r1("subtotal") = Format(l.Subtotal, "#########0.00")
                ds.LineaDeComprobante.AddLineaDeComprobanteRow(r1)

            Next

            reporte.SetDataSource(ds)

            Me.CrystalReportViewer1.ReportSource = reporte

        Catch ex As Exception

        Finally

            ds = Nothing
            reporte = Nothing


        End Try



    End Sub

    Public Sub cargarDsMovimientosStock(ByVal mov As List(Of MovimientoStockMedicamento))
        Dim ds As New dsMovimientosStock
        Dim rep As New rptMovimientosStock()
        Try
            ds.Clear()
            ds.Tables("movimientoStock").Columns("id").AllowDBNull = True

            For Each m As MovimientoStockMedicamento In mov
                Dim r As DataRow
                r = ds.Tables("movimientoStock").NewRow
                r("id") = m.Id
                r("descripcion") = m.medicamento.descripcion
                r("cantidad") = m.cantidad
                r("fecha") = Convert.ToString(m.Fecha).Remove(10)
                If m.Usuario Is Nothing Then
                    r("nombreUsuario") = ""
                Else : r("nombreUsuario") = m.Usuario.nombreUsuario
                End If

                ds.movimientoStock.Rows.Add(r)

            Next

            rep.SetDataSource(ds)

            Me.CrystalReportViewer1.ReportSource = rep
            ' Me.CrystalReportViewer1.Refresh()

        Finally
            ds = Nothing
            rep = Nothing
        End Try


    End Sub

    
    Public Sub imprimirGrillaAnestesistas(ByVal p As PagoAnestesista, ByVal pagosincomp As PagoAnestesista, ByVal g As DataGridView, ByVal g2 As DataGridView, ByVal anestesista As String, ByVal honorariosExento As String, ByVal totIVA105 As String, ByVal totIVA21 As String, ByVal iva21 As String, ByVal iva105 As String, ByVal mesLiquidacion As String)
        Dim cr As New rptPagoAnestesistas()

        Dim root As CrystalDecisions.CrystalReports.Engine.TextObject
        root = TryCast(cr.ReportDefinition.ReportObjects("txtAnestesista"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root.Text = anestesista

        Dim root1 As CrystalDecisions.CrystalReports.Engine.TextObject
        root1 = TryCast(cr.ReportDefinition.ReportObjects("txtIva10"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root1.Text = iva105

        Dim root2 As CrystalDecisions.CrystalReports.Engine.TextObject
        root2 = TryCast(cr.ReportDefinition.ReportObjects("txtIva21"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root2.Text = iva21
        Dim root3 As CrystalDecisions.CrystalReports.Engine.TextObject
        root3 = TryCast(cr.ReportDefinition.ReportObjects("txtExentos"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root3.Text = honorariosExento

        Dim root4 As CrystalDecisions.CrystalReports.Engine.TextObject
        root4 = TryCast(cr.ReportDefinition.ReportObjects("txtGravado10"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root4.Text = totIVA105

        Dim root5 As CrystalDecisions.CrystalReports.Engine.TextObject
        root5 = TryCast(cr.ReportDefinition.ReportObjects("txtGravado21"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root5.Text = totIVA21

        Dim root6 As CrystalDecisions.CrystalReports.Engine.TextObject
        root6 = TryCast(cr.ReportDefinition.ReportObjects("txtFecha"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root6.Text = mesLiquidacion


        
        Dim root7 As CrystalDecisions.CrystalReports.Engine.TextObject
        root7 = TryCast(cr.ReportDefinition.ReportObjects("txtTotalAPagar"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root7.Text = p.getTotalAPagar().ToString()

        Dim ds As New dsAnestesistasListado
        Dim dt As New dsAnestesistasListado.tblDataTable()
        Dim i As Integer = 0
        For Each l As LineaPagoAnestesista In p.lineasDePago
            For i = 0 To l.estudios.Count - 1
                If i = l.estudios.Count - 1 Then
                    dt.Rows.Add(l.estudios(i).fechaEstudio.ToString().Remove(10), l.estudios(i).obraSocial.ToString(), l.estudios(i).paciente.ToString(), l.estudios(i).practica.ToString(), l.retencion.ToString(), l.importeComplejidad, l.ivaImporte, l.importeApagar.ToString())
                Else
                    dt.Rows.Add(l.estudios(i).fechaEstudio.ToString().Remove(10), l.estudios(i).obraSocial.ToString(), l.estudios(i).paciente.ToString(), l.estudios(i).practica.ToString(), "", 0, 0, "")
                End If

            Next

        Next

        ds.Tables("tbl").Merge(dt)



        If pagosincomp IsNot Nothing Then

            Dim dt2 As New dsAnestesistasListado.tblEstudioSinCompDataTable
            For Each l As LineaPagoAnestesista In pagosincomp.lineasDePago
                For i = 0 To l.estudios.Count - 1
                    If i = l.estudios.Count - 1 Then
                        dt2.Rows.Add(l.estudios(i).fechaEstudio.ToString().Remove(10), l.estudios(i).obraSocial.ToString(), l.estudios(i).paciente.ToString(), l.estudios(i).practica.ToString(), l.retencion.ToString(), l.importeComplejidad, l.ivaImporte, l.importeApagar)
                    Else
                        dt2.Rows.Add(l.estudios(i).fechaEstudio.ToString().Remove(10), l.estudios(i).obraSocial.ToString(), l.estudios(i).paciente.ToString(), l.estudios(i).practica.ToString(), "", 0, 0, 0)
                    End If

                Next
            Next
            ds.Tables("tblEstudioSinComp").Merge(dt2)

        End If

        cr.SetDataSource(ds)
        Me.CrystalReportViewer1.ReportSource = cr


    End Sub

    Public Sub PrintEstudios(ByVal arr As ArrayList, ByVal fechaDesde As String, ByVal fechaHasta As String)
        Dim ds As New dsEstudios
        Dim rep As New rptEstudios()
        Try
            ds.Clear()
            Dim i As Integer
            Dim r As DataRow
            r = ds.Tables("datosPeriodo").NewRow
            r("fechaDesde") = fechaDesde
            r("fechaHasta") = fechaHasta
            ds.Tables("datosPeriodo").Rows.Add(r)

            Dim est As New Estudio
            Dim r1 As DataRow
            '      Dim r2 As DataRow
            '       ds.Tables("obraSocial").Rows.Clear()
            ds.Tables("estudio").Rows.Clear()
            For i = 0 To arr.Count - 1
                r1 = ds.Tables("estudio").NewRow
                '            r2 = ds.Tables("obraSocial").NewRow

                est = arr(i)
                r1("fecha") = Convert.ToString(est.fechaEstudio).Remove(10)
                r1("nombrePractica") = est.practica.ToString()
                r1("medicoActuante") = est.medicoActuante.nombreCompleto
                r1("paciente") = est.paciente.nombreCompleto
                r1("telefonoPaciente") = est.paciente.tel
                r1("nombreObraSocial") = est.obraSocial.ToString()
                ds.Tables("estudio").Rows.Add(r1)

                '             ds.Tables("obraSocial").Rows.Add(r2)
            Next

            rep.SetDataSource(ds)
            Me.CrystalReportViewer1.ReportSource = rep
            Me.CrystalReportViewer1.Refresh()
        Finally
            ds = Nothing
            rep = Nothing
        End Try

    End Sub

    Public Sub printHonorariosCedir(ByVal dgv As DataGridView, ByVal honMedicoActuante As String, ByVal honMedicoSolicitante As String, ByVal honCedir As String)

        Dim rep As New rptHonorariosCedir

        Dim ds As New dsEstudios
        Dim r As DataRow

        Dim i As Integer
        For i = 0 To dgv.Rows.Count - 1
            r = ds.Tables("estudio").NewRow
            r("nombrePractica") = dgv("colTipoEstudio", i).Value.ToString
            r("medicoActuante") = dgv("colMedicoActuante", i).Value.ToString
            r("fecha") = dgv("colFecha", i).Value.ToString()
            r("paciente") = dgv("colPaciente", i).Value.ToString
            r("importeEstudio") = Format(Convert.ToDecimal(dgv("colImporte", i).Value.ToString), "##########0.00")
            r("medicoSolicitante") = dgv("colMedicoSolicitante", i).Value.ToString

            ds.Tables("estudio").Rows.Add(r)
        Next

        r = ds.Tables("tblHonorarios").NewRow
        r("honorarioMedicoActuante") = honMedicoActuante
        r("honorarioMedicoSolicitante") = honMedicoSolicitante
        r("honorarioCedir") = honCedir
        ds.Tables("tblHonorarios").Rows.Add(r)

        rep.SetDataSource(ds)
        Me.CrystalReportViewer1.ReportSource = rep


    End Sub

    Public Sub printInformeEstudios(ByVal estudio As Estudio)
        Dim rep As New rptInformeEstudio

        Dim ds As New dsEstudios
        Dim r As DataRow
        r = ds.Tables("paciente").NewRow
        r("nombre") = estudio.paciente.nombreCompleto + "(" + estudio.paciente.edad.ToString() + " años)"
        r("nroAfiliado") = estudio.paciente.nroAfiliado
        ds.Tables("paciente").Rows.Add(r)

        Dim r2 As DataRow
        r2 = ds.Tables("obraSocial").NewRow
        r2("nombreObraSocialPrueba") = estudio.obraSocial.ToString()
        ds.Tables("obraSocial").Rows.Add(r2)

        Dim r3 As DataRow
        r3 = ds.Tables("estudio").NewRow
        r3("nombrePractica") = estudio.practica.Estudio
        r3("motivoEstudio") = estudio.motivoEstudio
        r3("informe") = estudio.informe
        r3("fecha") = estudio.fechaEstudio.ToString().Remove(10)
        r3("medicoSolicitante") = estudio.medicoSolicitante.nombreCompleto
        r3("publicID") = "http://www.cedirsalud.com.ar/video/" + estudio.publicID
        r3("enlaceVideo") = estudio.VideoEstudio.enlaceMega
        ds.Tables("estudio").Rows.Add(r3)

        If estudio.VideoEstudio.enlaceMega = "" Then
            rep.Section4.SectionFormat.EnableSuppress = True
            rep.rfEnlaceVideo.SectionFormat.EnableSuppress = True 'sacamos el pie linkMega
            rep.rfPublicID.SectionFormat.EnableSuppress = True 'sacamos el pie public id
        ElseIf estudio.publicID <> "" Then
            rep.rfEnlaceVideo.SectionFormat.EnableSuppress = True
            rep.rfPublicID.SectionFormat.EnableSuppress = False
        End If


        

        rep.SetDataSource(ds)
        Me.CrystalReportViewer1.ReportSource = rep
        Me.CrystalReportViewer1.PrintReport()
        Me.Close()

    End Sub


    Public Sub printListadoMedicamentos(ByVal estudio As Estudio)
        Dim rep As New rptListadoMedicacion

        'datos del paciente
        Dim ds As New dsEstudios
        Dim r As DataRow
        r = ds.Tables("paciente").NewRow
        r("nombre") = estudio.paciente.nombreCompleto
        ds.Tables("paciente").Rows.Add(r)

        'datos de la medicacion.
        'No imprimimos material especifico
        Dim arrMed As New List(Of Medicacion)
        Dim totalMedicacion As Single
        Dim i As Integer
        For i = 0 To estudio.arrMedicacion.Count - 1
            Dim med As Medicacion = estudio.arrMedicacion(i)
            If Not med.esMaterialEspecifico Then
                arrMed.Add(med)
                totalMedicacion = totalMedicacion + med.medicamento.importe
            End If
        Next
        Dim r2 As DataRow
        For Each med As Medicacion In arrMed
            r2 = ds.Tables("medicacion").NewRow
            r2("descripcion") = med.medicamento.descripcion
            r2("precio") = med.importe.ToString()
            ds.Tables("medicacion").Rows.Add(r2)
        Next

        

        'datos de la practica
        Dim r3 As DataRow
        r3 = ds.Tables("estudio").NewRow
        r3("nombrePractica") = estudio.practica.Estudio
        r3("fecha") = estudio.fechaEstudio.ToString().Remove(10)
        ds.Tables("estudio").Rows.Add(r3)



        rep.SetDataSource(ds)
        Me.CrystalReportViewer1.ReportSource = rep
        Me.CrystalReportViewer1.PrintReport()


    End Sub

    Public Sub cargarDsMovimientosDeCaja(ByVal movs As List(Of MovimientoDeCaja), ByVal ultimoMonto As String)
        Dim ds As New dsMovimientosDeCaja
        Dim rep As New rptDetalleMovimientoCaja()
        Try
            Dim r As DataRow
            For Each m As MovimientoDeCaja In movs
                r = ds.Tables("Movimientos").NewRow
                r.Item("concepto") = m.Concepto
                r.Item("monto") = m.Monto.ToString
                r.Item("montoAcumulado") = m.MontoAcumulado.ToString
                r.Item("fecha") = m.Fecha.ToString
                If m.Usuario IsNot Nothing Then
                    r.Item("nombreUsuario") = m.Usuario.nombreUsuario
                END IF
                r("tipoDeMovimiento") = m.TipoDeMovimiento.descripcion
                If m.Medico IsNot Nothing Then
                    r("nombreMedico") = m.Medico.nombreCompleto
                End If

                If m.Estudio IsNot Nothing Then
                    r("paciente") = m.Estudio.paciente.nombreCompleto
                    r("obraSocial") = m.Estudio.obraSocial.ToString()
                    'en la descripcion de la practica pondremos, de tenerla, la abreviatura de la practica
                    If m.Estudio.practica.abreviatura <> "" Then
                        r("practica") = m.Estudio.practica.abreviatura
                    Else
                        r("practica") = m.Estudio.practica.ToString()
                    End If

                End If


                ds.Tables("Movimientos").Rows.Add(r)
            Next


            r = ds.Tables("ultimoMonto").NewRow
            r("montoAcumulado") = ultimoMonto
            ds.Tables("ultimoMonto").Rows.Add(r)









            rep.SetDataSource(ds)
            Me.CrystalReportViewer1.ReportSource = rep
            Me.CrystalReportViewer1.Refresh()

        Finally
            ds = Nothing
            rep = Nothing
        End Try

    End Sub

    Public Sub printPagoMedicosMonotributistas(ByVal medico As String, ByVal dt As DataTable, ByVal txtObservaciones As String)

        Dim rep As New rptPagoAMedicos
        Dim ds As New dsEstudios

        Dim root As CrystalDecisions.CrystalReports.Engine.TextObject

        root = TryCast(rep.ReportDefinition.ReportObjects("txtObservaciones"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root.Text = txtObservaciones


        Dim root4 As CrystalDecisions.CrystalReports.Engine.TextObject
        root4 = TryCast(rep.ReportDefinition.ReportObjects("txtMedicoSeleccionado"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root4.Text = medico


        Dim r As DataRow
        Dim i As Integer

        ds.Tables("tblPagoMedicos").Rows.Clear()


        For i = 0 To dt.Rows.Count - 1
            r = ds.Tables("tblPagoMedicos").NewRow
            r("fecha") = dt.Rows(i).Item("Fecha").ToString()
            r("paciente") = dt.Rows(i).Item("Paciente").ToString()
            r("nombreObraSocial") = dt.Rows(i).Item("Obra Social").ToString()
            r("nombrePractica") = dt.Rows(i).Item("Práctica").ToString()
            r("medicoActuante") = dt.Rows(i).Item("Actuante").ToString()
            r("medicoSolicitante") = dt.Rows(i).Item("Solicitante").ToString()
            r("pagoFechaCobro") = dt.Rows(i).Item("Fecha Cobro").ToString.Remove(10)
            If dt.Rows(i).Item("Importe").ToString() <> "" Then
                r("pagoImporte") = dt.Rows(i).Item("Importe").ToString()
            Else
                r("colImporte") = ""
            End If
            If dt.Rows(i).Item("Pago").ToString().ToString() <> "" Then
                r("pagoPago") = Format(Convert.ToDecimal(dt.Rows(i).Item("Pago").ToString()), "##########0.00")
            End If

            If dt.Rows(i).Item("Total").ToString() <> "" Then
                r("pagoTotal") = Format(Convert.ToDecimal(dt.Rows(i).Item("Total").ToString()), "##########0.00")
            End If
            ds.Tables("tblPagoMedicos").Rows.Add(r)

        Next


        rep.SetDataSource(ds)
        Me.CrystalReportViewer1.ReportSource = rep
        'If dgv("colIva", i).Value.ToString() <> "" Then
        '    r("colIva") = Format(Convert.ToDecimal(dgv("colIva", i).Value), "#########0.00")
        'End If
        'If dgv("colRetencion", i).Value.ToString() <> "" Then
        '    r("colRetencion") = Format(Convert.ToDecimal(dgv("colRetencion", i).Value), "##########0.00")
        'End If

    End Sub

    Public Sub printPagoMedicosInscriptos(ByVal medico As String, ByVal dt As DataTable, ByVal txtObservaciones As String, ByVal exento As String, ByVal honorario10 As String, ByVal honorario21 As String)

        Dim rep As New rptPagoAMedicoInscripto
        Dim ds As New dsEstudios

        Dim root As CrystalDecisions.CrystalReports.Engine.TextObject

        root = TryCast(rep.ReportDefinition.ReportObjects("txtObservaciones"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root.Text = txtObservaciones

        Dim root1 As CrystalDecisions.CrystalReports.Engine.TextObject
        root1 = TryCast(rep.ReportDefinition.ReportObjects("txtExento"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root1.Text = exento

        Dim root2 As CrystalDecisions.CrystalReports.Engine.TextObject
        root2 = TryCast(rep.ReportDefinition.ReportObjects("txtHonorario10"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root2.Text = honorario10
        Dim root3 As CrystalDecisions.CrystalReports.Engine.TextObject
        root3 = TryCast(rep.ReportDefinition.ReportObjects("txtHonorario21"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root3.Text = honorario21

        Dim root4 As CrystalDecisions.CrystalReports.Engine.TextObject
        root4 = TryCast(rep.ReportDefinition.ReportObjects("txtMedicoSeleccionado"), CrystalDecisions.CrystalReports.Engine.TextObject)
        root4.Text = medico


        Dim r As DataRow
        Dim i As Integer

        ds.Tables("tblPagoMedicos").Rows.Clear()


        For i = 0 To dt.Rows.Count - 1
            r = ds.Tables("tblPagoMedicos").NewRow
            r("fecha") = dt.Rows(i).Item("Fecha").ToString()
            r("paciente") = dt.Rows(i).Item("Paciente").ToString()
            r("nombreObraSocial") = dt.Rows(i).Item("Obra Social").ToString()
            r("nombrePractica") = dt.Rows(i).Item("Práctica").ToString()
            r("medicoActuante") = dt.Rows(i).Item("Actuante").ToString()
            r("medicoSolicitante") = dt.Rows(i).Item("Solicitante").ToString()
            r("pagoFechaCobro") = dt.Rows(i).Item("Fecha Cobro").ToString.Remove(10)
            If dt.Rows(i).Item("Importe").ToString() <> "" Then
                r("pagoImporte") = dt.Rows(i).Item("Importe").ToString()
            Else
                r("colImporte") = ""
            End If
            If dt.Rows(i).Item("Pago").ToString().ToString() <> "" Then
                r("pagoPago") = Format(Convert.ToDecimal(dt.Rows(i).Item("Pago").ToString()), "##########0.00")
            End If


            If dt.Rows(i).Item("MontoIVA10.5Estudio").ToString() <> "" Then
                r("pagoMontoIVA10.5Estudio") = Format(Convert.ToDecimal(dt.Rows(i).Item("MontoIVA10.5Estudio").ToString()), "##########0.00")
            End If
            If dt.Rows(i).Item("MontoIVA21Estudio").ToString() <> "" Then
                r("pagoMontoIVA21Estudio") = Format(Convert.ToDecimal(dt.Rows(i).Item("MontoIVA21Estudio").ToString()), "##########0.00")
            End If

            If dt.Rows(i).Item("Total").ToString() <> "" Then
                r("pagoTotal") = Format(Convert.ToDecimal(dt.Rows(i).Item("Total").ToString()), "##########0.00")
            End If
            ds.Tables("tblPagoMedicos").Rows.Add(r)

        Next


        rep.SetDataSource(ds)
        Me.CrystalReportViewer1.ReportSource = rep
        'If dgv("colIva", i).Value.ToString() <> "" Then
        '    r("colIva") = Format(Convert.ToDecimal(dgv("colIva", i).Value), "#########0.00")
        'End If
        'If dgv("colRetencion", i).Value.ToString() <> "" Then
        '    r("colRetencion") = Format(Convert.ToDecimal(dgv("colRetencion", i).Value), "##########0.00")
        'End If

    End Sub

End Class