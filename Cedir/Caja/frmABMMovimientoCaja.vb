Imports CedirNegocios
Imports System.Collections.Generic

Public Class frmABMMovimientoCaja

#Region "VARIABLES DE INSTANCIA"

    Private m_cancelado As Boolean
    Private arrMedicos As ArrayList
    Private tipos As New List(Of TipoDeMovimientoDeCaja)
    Private catalogoDeMovimientos As New CatalogoDeMovimientosDeCaja
    Private m_esEdicion As Boolean = False
    Private m_mov As MovimientoDeCaja = Nothing

    Private m_estudio As Estudio = Nothing
    Public Property estudio() As Estudio
        Get
            Return m_estudio
        End Get
        Set(ByVal value As Estudio)
            m_estudio = value
        End Set
    End Property

    Public Property cancelado() As Boolean
        Get
            Return m_cancelado
        End Get
        Set(ByVal value As Boolean)
            m_cancelado = value
        End Set
    End Property

    Public Property esEdicion() As Boolean
        Get
            Return m_esEdicion
        End Get
        Set(ByVal value As Boolean)
            m_esEdicion = value
        End Set
    End Property

    Public Property movimientoParaEdicion() As MovimientoDeCaja
        Get
            Return m_mov
        End Get
        Set(ByVal value As MovimientoDeCaja)
            m_mov = value
        End Set
    End Property

    Private _tipoDeMovimientoDefault As Boolean = False
    Public Property tipoDeMovimienoConsultorioDefault() As Boolean
        Get
            Return _tipoDeMovimientoDefault
        End Get
        Set(ByVal value As Boolean)
            _tipoDeMovimientoDefault = value
        End Set
    End Property




#End Region

#Region "EVENTOS DE FORMULARIO"

    Private Sub frmCajaMovimiento_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarComboMedicos()
        cargarComboTipoDeMovimientos()
        If esEdicion Then
            Me.estudio = Me.movimientoParaEdicion.Estudio
            habilitarEdicionDeMovimientoDeCaja()
        Else
            setLblUltimoMontoAcumulado()
            Me.lblAsterisk.Visible = False
            txtMonto.Text = ""
            txtConcepto.Text = ""
            setLblSaldoCaja()
            cargarSolapaDos()
        End If
        If Me.tipoDeMovimienoConsultorioDefault Then
            Me.cargarTipoConsultorio()
        End If

        cargarGrpEstudio()
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.cancelado = True
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        If esEdicion Then
            editarMovimiento()
        Else
            crearMovimientos()
        End If

    End Sub

#End Region

    Sub habilitarEdicionDeMovimientoDeCaja()


        Me.txtConcepto.Enabled = False
        Me.cmbMedicos.Enabled = True
        Me.txtMonto.Enabled = False
        Me.grpTotal.Visible = False

        txtMonto.Text = Me.movimientoParaEdicion.Monto.ToString()
        txtConcepto.Text = Me.movimientoParaEdicion.Concepto()

        If estudio IsNot Nothing And Me.movimientoParaEdicion.Medico IsNot Nothing Then
            cmbMedicos.SelectedIndex = cmbMedicos.FindStringExact(Me.movimientoParaEdicion.Medico.nombreCompleto)
            'cmbMedicos.Items.Insert(0, Me.movimientoParaEdicion.Medico.nombreCompleto)
            'cmbMedicos.SelectedIndex = 0
        End If

        For Each t As TipoDeMovimientoDeCaja In Me.cmbTipoDeMovimientos.Items
            If t.id = Me.movimientoParaEdicion.TipoDeMovimiento.id Then
                Me.cmbTipoDeMovimientos.SelectedItem = t
                Me.cmbTipoDeMovimientos.DisplayMember = t.descripcion
            End If
        Next


    End Sub

    Sub setLblUltimoMontoAcumulado()
        Dim cNeg As New CatalogoDeMovimientosDeCaja
        Me.lblUltimoMontoAcumulado.Text = cNeg.GetLastMontoAcumulado().ToString()
        cNeg = Nothing
    End Sub

    Sub editarMovimiento()
        Dim msg As New DialogResult
        msg = MessageBox.Show("Desea editar el movimiento de caja?", "Atención", MessageBoxButtons.YesNo)

        If msg = Windows.Forms.DialogResult.No Then
            MessageBox.Show("Edicion cancelada")
            Me.cancelado = True
            Exit Sub
        End If
        movimientoParaEdicion.TipoDeMovimiento = TryCast(Me.cmbTipoDeMovimientos.SelectedItem, TipoDeMovimientoDeCaja)
        movimientoParaEdicion.Medico = TryCast(Me.cmbMedicos.SelectedItem, Medico)
        Dim resp As String = Me.movimientoParaEdicion.modificar()
        If resp = "ok" Then
            MessageBox.Show("Movimiento editado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cancelado = False
        Else
            MessageBox.Show(resp)
        End If


        Me.reload()
    End Sub

    Private Sub crearMovimientos()
        Dim msg As New DialogResult
        msg = MessageBox.Show("Desea crear movimiento(s) de caja?", "Atención", MessageBoxButtons.YesNo)

        If msg = Windows.Forms.DialogResult.No Then
            MessageBox.Show("Creación de movimiento cancelada")
            Me.cancelado = True
            Exit Sub
        End If

        crearMovimientoSolapa1()

        crearMovimientoSolapa2()

        MessageBox.Show("Movimiento creado con éxito", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Me.cancelado = False

        Me.reload()

    End Sub

    Private Sub cargarGrpEstudio()
        If Me.estudio Is Nothing Then
            Me.grpDatosEstudio.Visible = False
            Me.grpTotal.Visible = False

        Else
            Me.grpTotal.Visible = True
            Me.grpDatosEstudio.Visible = True
            Me.lblFecha.Text = estudio.fechaEstudio.ToString()
            Me.lblObraSocial.Text = estudio.obraSocial.ToString()
            Me.lblPaciente.Text = estudio.paciente.nombreCompleto
            Me.lblPractica.Text = estudio.practica.Estudio
            lblMedicoActuante.Text = estudio.medicoActuante.nombreCompleto
        End If
    End Sub

    Private Sub cargarSolapaDos()

        If Me.estudio Is Nothing Then
            Me.TabPage2.Hide()
        Else
            Me.TabPage2.Show()
            Me.TabPage2.Focus()
            cargarGrillaMovimientos()
            setLblTotal()
        End If
    End Sub

    Private Sub cargarComboMedicos()

        Dim catalogoMedicos As New CatalogoDeMedicos
        arrMedicos = catalogoMedicos.TodosLosMedicos()
        cmbMedicos.Items.Insert(0, "Sin Definir")
        For Each m As Medico In arrMedicos
            cmbMedicos.Items.Add(m)
        Next
        cmbMedicos.SelectedIndex = 0
        cmbMedicos.DisplayMember = "nombreCompleto"

        If estudio IsNot Nothing Then ' si se esta cargando un estudio, dejamos el medio act por default
            cmbMedicos.SelectedIndex = cmbMedicos.FindStringExact(estudio.medicoActuante.nombreCompleto)
        End If

        If Me.movimientoParaEdicion IsNot Nothing AndAlso Me.movimientoParaEdicion.Medico IsNot Nothing Then  ' si se esta cargando un estudio, dejamos el medio act por default
            cmbMedicos.SelectedIndex = cmbMedicos.FindStringExact(movimientoParaEdicion.Medico.nombreCompleto)
        End If

    End Sub

    Private Sub cargarComboTipoDeMovimientos()
        Dim cNeg As New CatalogoDeTipoDeMovimientosDeCaja
        tipos = cNeg.getAll()
        'cargamos el combo de la solapa uno
        cmbTipoDeMovimientos.DataSource = tipos
        'los tipos de la grilla van a ser cargados pre-seteados en otro metodo
        cNeg = Nothing
    End Sub

    Private Sub cargarGrillaMovimientos()
        Me.dgvMovimientos.Columns.Clear()
        Me.dgvMovimientos.Rows.Clear()
        Me.dgvMovimientos.AutoGenerateColumns = False
        dgvMovimientos.AllowUserToAddRows = False
        dgvMovimientos.AllowUserToDeleteRows = False
        dgvMovimientos.DefaultCellStyle.BackColor = Color.LightYellow
        dgvMovimientos.DefaultCellStyle.Font = New Font("Calibri", 9)



        'COLUMNA MEDICOS
        Dim medicoColumna As New DataGridViewComboBoxColumn()
        medicoColumna.Name = "colMedicos"
        medicoColumna.HeaderText = "Médico"
        'Por default, el combo de la grilla, tiene un objeto Null
        medicoColumna.Items.Add("Sin Definir")
        medicoColumna.DefaultCellStyle.NullValue = "Sin Definir"
        For Each m As Medico In arrMedicos
            medicoColumna.Items.Add(m)
        Next
        'seteamos el binding con la lista de medicos
        medicoColumna.DisplayMember = "nombreCompleto"
        medicoColumna.ValueMember = "Self"
        Me.dgvMovimientos.Columns.Add(medicoColumna)


        'COLUMNA CONCEPTO
        Dim colConcepto As New DataGridViewTextBoxColumn()
        colConcepto.Name = "colConcepto"
        colConcepto.HeaderText = " Concepto "
        dgvMovimientos.Columns.Add(colConcepto)


        'COLUMNA TIPO DE MOVIMIENTO
        Dim tipoMov As New DataGridViewComboBoxColumn()
        tipoMov.Name = "colTipo"
        tipoMov.HeaderText = "Tipo de Mov"
        tipoMov.AutoComplete = True
        tipoMov.ReadOnly = True
        tipoMov.DataPropertyName = "TipoDeMovimientoDeCaja"
        tipoMov.DisplayMember = "descripcion"
        tipoMov.ValueMember = "Self"
        For Each r As TipoDeMovimientoDeCaja In tipos
            tipoMov.Items.Add(r)
        Next
        Me.dgvMovimientos.Columns.Add(tipoMov)

        'COLUMNA MONTO
        Dim colMonto As New DataGridViewTextBoxColumn()
        colMonto.Name = "colMonto"
        colMonto.HeaderText = "Monto"
        colMonto.DefaultCellStyle.Format = "C2"
        colMonto.DefaultCellStyle.NullValue = "0.00"
        dgvMovimientos.Columns.Add(colMonto)

        'La cantidad de filas las determinan los tipos de movimiento
        Dim i As Integer
        For i = 0 To tipos.Count - 1
            dgvMovimientos.Rows.Add(medicoColumna.Items(0), "", tipoMov.Items(i), "0.00")
        Next

    End Sub

    Private Sub setLblSaldoCaja()

    End Sub

    Private Function validarMonto(ByVal text As String) As Boolean
        Dim h As New Helper
        validarMonto = h.validaNumero(text)
    End Function

    Public Sub reload()
        Controls.Clear()
        InitializeComponent()
        Me.frmCajaMovimiento_Load(Me, Nothing)
    End Sub

    Private Sub btnPCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPCF.Click
        Dim frmPCF As New detallesImpositivos
        Try
            If estudio.obraSocial.idObraSocial <> 134 And estudio.obraSocial.idObraSocial <> 2 Then
                MessageBox.Show("No se puede realizar un pago contra factura de un estudio que" & vbLf & "no sea particular, desde Movimiento de caja.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If

            frmPCF.ListaEstudios.Add(Me.estudio)
            frmPCF.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            frmPCF = Nothing
        End Try

    End Sub

    Private Sub dgvMovimientos_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvMovimientos.CellValueChanged
        If e.ColumnIndex = 3 AndAlso Convert.ToDecimal(dgvMovimientos.CurrentCell.Value) <> 0.0 Then
            dgvMovimientos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.SkyBlue
        ElseIf e.ColumnIndex = 3 AndAlso Convert.ToDecimal(dgvMovimientos.CurrentCell.Value) = 0.0 Then
            dgvMovimientos.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.LightYellow
        End If
        setLblTotal()
    End Sub

    Private Sub setLblTotal()
        Dim total As Decimal
        For Each r As DataGridViewRow In dgvMovimientos.Rows
            total = total + Convert.ToDecimal(r.Cells("colMonto").Value)
        Next
        lblTotal.Text = total.ToString()
    End Sub

    Private Sub crearMovimientoSolapa1()
        If Me.txtMonto.Text = "" Then
            Exit Sub
        End If
        If Not (Me.validarMonto(Me.txtMonto.Text)) Then
            MessageBox.Show("Error en el monto. Controle que es un valor numerico valido. Utilice . (punto) en lugar de , (comas) para la parte decimal.", "Error de Monto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
            Me.lblAsterisk.Visible = True
            Exit Sub
        End If

        Dim movCaja As New MovimientoDeCaja
        movCaja.Monto = Format(Convert.ToDecimal(Me.txtMonto.Text), "########0.00")
        movCaja.Concepto = Me.txtConcepto.Text
        movCaja.Medico = TryCast(Me.cmbMedicos.SelectedItem, Medico)
        movCaja.TipoDeMovimiento = TryCast(Me.cmbTipoDeMovimientos.SelectedItem, TipoDeMovimientoDeCaja)
        movCaja.Estudio = Me.estudio
        'la fecha la toma el constructor del objeto movcaja, por eso no lo ponemos
        Me.catalogoDeMovimientos.CrearMovimiento(movCaja)




    End Sub

    Private Sub crearMovimientoSolapa2()
        Dim monto As Decimal
        For Each r As DataGridViewRow In dgvMovimientos.Rows
            monto = Convert.ToDecimal(r.Cells("colMonto").Value)
            If monto = 0.0 Then
                Continue For
            End If
            If Not (Me.validarMonto(monto.ToString)) Then
                MessageBox.Show("Error en el monto. Controle que es un valor numerico valido. Utilice . (punto) en lugar de , (comas) para la parte decimal.", "Error de Monto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1)
                Exit Sub
            End If
            Dim movCaja As New MovimientoDeCaja
            movCaja.Monto = Format(Convert.ToDecimal(monto), "########0.00")
            movCaja.Concepto = r.Cells("colConcepto").Value
            movCaja.Medico = TryCast(r.Cells("colMedicos").Value, Medico)
            movCaja.TipoDeMovimiento = TryCast(r.Cells("colTipo").Value, TipoDeMovimientoDeCaja)
            movCaja.Estudio = Me.estudio
            'la fecha la toma el constructor del objeto movcaja, por eso no lo ponemos
            Me.catalogoDeMovimientos.CrearMovimiento(movCaja)

        Next
    End Sub

    Private Sub cargarTipoConsultorio()
        Me.cmbTipoDeMovimientos.SelectedIndex = Me.cmbTipoDeMovimientos.FindString("Consultorio")
    End Sub

End Class