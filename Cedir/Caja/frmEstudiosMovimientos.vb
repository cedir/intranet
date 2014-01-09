Imports CedirNegocios
Imports System.Collections.Generic

Public Class frmEstudiosMovimientos

    Private m_estudios As List(Of Estudio)


    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        BuscarEstudiosPorFecha(Me.DateTimePicker1.Value)
    End Sub

    Private Sub BuscarEstudiosPorFecha(ByVal fecha As Date)
        Dim cNeg As New CatalogoDeMovimientosDeCaja
        m_estudios = cNeg.getEstudiosAndMovimientos(fecha)
        If m_estudios.Count <= 0 Then
            MessageBox.Show("No hay estudios")
        Else
            cargarGrilla()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If dgvListaEstudios.SelectedRows.Count > 0 Then
            Dim n As Integer = 0
            Dim indice As Integer = dgvListaEstudios.SelectedRows(0).Index
            Dim j As Integer = 0

            For Each est As Estudio In Me.m_estudios
                If n = indice Then
                    crearMovimiento(est)
                End If
                For j = 1 To est.MovimientosDeCaja.Count - 1
                    n = n + 1
                    If n = indice Then
                        crearMovimiento(est)
                    End If
                Next
                n = n + 1
            Next

        End If
    End Sub
    Sub crearMovimiento(ByVal est As Estudio)
        Dim f As New frmABMMovimientoCaja

        f.estudio = New Estudio
        f.estudio = est
        f.Show()
        Me.Close()
    End Sub

    Private Sub frmEstudiosMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvListaEstudios.AutoGenerateColumns = False
        Me.BuscarEstudiosPorFecha(Me.DateTimePicker1.Value)
    End Sub
    Private Sub cargarGrilla()
        Me.dgvListaEstudios.AutoGenerateColumns = False
        Me.dgvListaEstudios.Rows.Clear()

        For Each est As Estudio In Me.m_estudios
            Dim dr As New DataGridViewRow
            'especificamos el estilo de celdas. Sino lo hacemos, nos tira error 
            dr.CreateCells(Me.dgvListaEstudios)

            With dr.Cells
                .Item(0).Value = est.paciente.nombreCompleto
                .Item(1).Value = est.practica.Estudio
                .Item(2).Value = est.obraSocial.ObraSocial
                .Item(3).Value = est.medicoActuante.nombreCompleto

                'check si existen mas de un movimiento por estudio
                If est.MovimientosDeCaja.Count >= 2 Then
                    'llenamos la primer fila
                    .Item(4).Value = est.MovimientosDeCaja(0).Fecha
                    .Item(5).Value = est.MovimientosDeCaja(0).Concepto
                    .Item(6).Value = est.MovimientosDeCaja(0).TipoDeMovimiento.descripcion
                    .Item(7).Value = est.MovimientosDeCaja(0).Monto
                    .Item(8).Value = est.MovimientosDeCaja(0).estadoMovimiento
                    dr.Cells(0).Style.BackColor = Color.Red
                    Me.dgvListaEstudios.Rows.Add(dr)
                    dr = Nothing

                    Dim i As Integer
                    For i = 1 To est.MovimientosDeCaja.Count - 1
                        'cargamos tantas filas, como movimientos falten, para
                        'un mismo estudio
                        Dim dr1 As New DataGridViewRow
                        dr1.CreateCells(Me.dgvListaEstudios)
                        With dr1.Cells
                            .Item(4).Value = est.MovimientosDeCaja(i).Fecha
                            .Item(5).Value = est.MovimientosDeCaja(i).Concepto
                            .Item(6).Value = est.MovimientosDeCaja(i).TipoDeMovimiento.descripcion
                            .Item(7).Value = est.MovimientosDeCaja(i).Monto
                            .Item(8).Value = est.MovimientosDeCaja(i).estadoMovimiento

                        End With
                        Me.dgvListaEstudios.Rows.Add(dr1)
                        dr1 = Nothing
                    Next
                Else

                    For Each m As MovimientoDeCaja In est.MovimientosDeCaja
                        .Item(4).Value = m.Fecha
                        .Item(5).Value = m.Concepto
                        .Item(6).Value = m.TipoDeMovimiento.descripcion
                        .Item(7).Value = m.Monto
                        .Item(8).Value = m.estadoMovimiento
                    Next

                    Me.dgvListaEstudios.Rows.Add(dr)
                    dr = Nothing

                End If

            End With
        Next

    End Sub

End Class