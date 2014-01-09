Imports CedirNegocios
Imports System.Collections.Generic

Public Class frmListadoDeMovimientos


    Private m_movs As List(Of MovimientoDeCaja)
    Dim arrMedicos As New ArrayList
    Dim tipos As New List(Of TipoDeMovimientoDeCaja)


    Private Sub frmListadoDeMovimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComboMedicos()
        cargarComboTipos()
        setLblUltimoMontoAcumulado()
        habilitarEdicionMovimiento()
    End Sub
    Sub setLblUltimoMontoAcumulado()
        Dim cNeg As New CatalogoDeMovimientosDeCaja
        Me.lblUltimoMontoAcumulado.Text = cNeg.GetLastMontoAcumulado().ToString()
        cNeg = Nothing
    End Sub
    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Buscar()
    End Sub

    Private Sub Buscar()
        Dim cNeg As New CatalogoDeMovimientosDeCaja
        m_movs = cNeg.getAll(TryCast(Me.cmbMedicos.SelectedItem, Medico), TryCast(Me.cmbTipoDeMovimientos.SelectedItem, TipoDeMovimientoDeCaja), Me.checkEstudios.CheckState.ToString(), Me.checkPagado.CheckState.ToString(), Me.txtConcepto.Text, Me.dtDesde.Value, Me.dtHasta.Value)
        dgvMovimientos.Rows.Clear()
        If m_movs.Count <= 0 Then
            MessageBox.Show("No hay movimientos")
        Else
            cargarGrilla()
        End If
    End Sub

    Private Sub cargarGrilla()
        Me.dgvMovimientos.AutoGenerateColumns = False
        Me.dgvMovimientos.Rows.Clear()
        Dim total As Decimal = 0.0
        For Each mov As MovimientoDeCaja In m_movs
            Dim dr As New DataGridViewRow
            'especificamos el estilo de celdas. Sino lo hacemos, nos tira error 
            dr.CreateCells(Me.dgvMovimientos)

            With dr.Cells

                .Item(0).Value = mov.Fecha.Date

                .Item(1).Value = mov.TipoDeMovimiento.descripcion

                .Item(7).Value = mov.Concepto
                If mov.Usuario IsNot Nothing Then
                    .Item(8).Value = mov.Usuario.nombreUsuario
                End If

                .Item(5).Value = mov.Monto
                total = total + mov.Monto

                .Item(6).Value = mov.MontoAcumulado

                .Item(9).Value = mov.estadoMovimiento()

                If mov.Estudio IsNot Nothing Then

                    .Item(10).Value = mov.Estudio.fechaEstudio

                    .Item(2).Value = mov.Estudio.paciente.nombreCompleto

                    .Item(11).Value = mov.Estudio.practica.ToString()

                    .Item(3).Value = mov.Estudio.obraSocial.ObraSocial


                End If
                If mov.Medico IsNot Nothing Then
                    .Item(4).Value = mov.Medico.nombreCompleto
                End If

            End With

            Me.dgvMovimientos.Rows.Add(dr)
            dr = Nothing
        Next

        lblTotal.Text = total.ToString()
    End Sub

    Private Sub cargarComboTipos()
        Dim cNeg As New CatalogoDeTipoDeMovimientosDeCaja
        tipos = cNeg.getAll()
        cmbTipoDeMovimientos.Items.Insert(0, "Sin Definir")
        For Each t As TipoDeMovimientoDeCaja In tipos
            cmbTipoDeMovimientos.Items.Add(t)
        Next

        cmbTipoDeMovimientos.DisplayMember = "descripcion"
        cmbTipoDeMovimientos.SelectedIndex = 0
        cNeg = Nothing

    End Sub

    Private Sub cargarComboMedicos()
        Dim catalogoMedicos As New CatalogoDeMedicos
        arrMedicos = catalogoMedicos.TodosLosMedicos()
        cmbMedicos.Items.Insert(0, "Sin Definir")
        For Each m As Medico In arrMedicos
            cmbMedicos.Items.Add(m)
        Next
        cmbMedicos.DisplayMember = "nombreCompleto"
        cmbMedicos.SelectedIndex = 0
    End Sub

    Sub cambiarEstadoLineas(ByVal estado As String)
        Dim msg As New DialogResult
        msg = MessageBox.Show("Desea cambiar el estado de los movimientos seleccionados?", "Atención", MessageBoxButtons.YesNo)

        If msg = Windows.Forms.DialogResult.No Then
            Exit Sub
        Else
            Dim lista As New List(Of MovimientoDeCaja)
            For Each r As DataGridViewRow In dgvMovimientos.SelectedRows
                lista.Add(m_movs(r.Index))
            Next

            Dim cNeg As New CatalogoDeMovimientosDeCaja
            Dim estadoBool As Boolean = False
            If estado = "Pagado" Then
                estadoBool = True
            End If
            cNeg.cambiarEstadoMovimientos(lista, estadoBool)
            Buscar()
        End If

    End Sub

    Private Sub ToolStripTextBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox1.Click
        cambiarEstadoLineas(menuRightClick.Items(0).Text)
    End Sub

    Private Sub ToolStripTextBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripTextBox2.Click
        cambiarEstadoLineas(menuRightClick.Items(1).Text)
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Dim f As New rptViewer
        Me.AddOwnedForm(f)
        f.cargarDsMovimientosDeCaja(Me.m_movs, Me.lblUltimoMontoAcumulado.Text)
        f.Show()
    End Sub
    
    Private Sub cmbTipoDeMovimientos_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoDeMovimientos.SelectedValueChanged

    End Sub

    Private Sub cmbTipoDeMovimientos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoDeMovimientos.SelectedIndexChanged

    End Sub

    Private Sub btnModificarMovimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificarMovimiento.Click
        If Me.dgvMovimientos.SelectedRows.Count < 1 Then
            Exit Sub
        End If
        Dim f As New frmABMMovimientoCaja
        f.movimientoParaEdicion = Me.m_movs(Me.dgvMovimientos.SelectedRows(0).Index)
        f.esEdicion = True
        f.ShowDialog()
        Me.btnBuscar.PerformClick()
    End Sub
    Private Sub habilitarEdicionMovimiento()
        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser
        If cUsuario.belongToGroup("administrador") Then
            Me.btnModificarMovimiento.Enabled = True
        End If
    End Sub

End Class