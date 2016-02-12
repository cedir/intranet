Imports CedirNegocios
Imports System.Collections.Generic
Public Class Comprobantes


    Dim lineas As List(Of LineaDeComprobante)
    Dim m_comprobante As New Comprobante

    Public Property Comprobante() As Comprobante
        Get
            Return m_comprobante
        End Get
        Set(ByVal value As Comprobante)
            m_comprobante = value
        End Set
    End Property
    
#Region "EVENTOS FORM"

    Private Sub Comprobantes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cargarCabezera()
    End Sub

    Private Sub btnAnular_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnular.Click

        Dim result As DialogResult = MessageBox.Show("¿Está seguro de anular el comprobante?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)
        If result = Windows.Forms.DialogResult.Yes Then
            Dim cPres As New CatalogoDePresentaciones
            Dim arr As New ArrayList
            Try

                arr = cPres.traerPresentaciones(, , , , , Me.Comprobante.IdComprobante, , )
                If arr.Count > 0 Then
                    'existe una presentacion con este comprobante asociado
                    MsgBox("Este comprobante esta asociado a una presentación. Consulte al Administrador")
                Else
                    Comprobante.cambiarEstado("ANULADO")
                    MessageBox.Show("Comprobante anulado", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.None)
                    Me.btnAnular.Visible = False
                    Me.btnImprimir.Visible = False
                    Me.lblEstado.Text = Comprobante.Estado

                End If


            Catch ex As Exception

            Finally
                cPres = Nothing
                arr = Nothing
            End Try

        End If
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Hide()
        'CType(Me.Owner, ComprobantesBuscar).Reload()
        Me.Close()

    End Sub

#End Region

    

    Private Sub cargarCabezera()

        Me.txtDomicilio.Text = Comprobante.DomicilioCliente
        If Comprobante.TipoComprobante.Id = TComprobante.Liquidacion Then
            Me.txtGravado.Text = ""
            Me.txtResponsable.Text = ""
            Me.txtSubtipo.Text = ""
            Me.txtNroTerminal.Visible = False
            Me.lblGuion.Visible = False
            Me.btnImprimir.Visible = True
            Me.btnAnular.Visible = Comprobante.Estado <> "ANULADO"

        Else
            Me.txtGravado.Text = Comprobante.Gravado.descripcion
            Me.txtResponsable.Text = Comprobante.Responsable
            Me.txtSubtipo.Text = Comprobante.SubTipo
            Me.btnImprimir.Visible = False
            Me.btnAnular.Visible = False
        End If

        Me.txtNombre.Text = Comprobante.NombreCliente
        Me.txtNroComprobante.Text = Comprobante.NroComprobante.ToString()
        Me.txtNroTerminal.Text = Comprobante.NroTerminal.ToString()
        Me.txtNroCuit.Text = Comprobante.DocumentoCliente.NroDocumento
        Me.txtTipo.Text = Comprobante.TipoComprobante.Descripcion
        Me.txtCondicionFiscal.Text = Comprobante.CondicionFiscal
        Me.txtPacienteGravado.Text = Comprobante.GravadoPaciente
        Me.lblEstado.Text = Comprobante.Estado

        Me.lblTotalDecimal.Text = Format(Comprobante.TotalFacturado, "#########0.00")
        Me.cargarLineas(Comprobante)

    End Sub

    Private Sub cargarLineas(ByVal c As Comprobante)
        Dim tabla As New DataTable
        tabla.Clear()
        Me.dgvLineasDeComprobante.DataSource = Nothing

        Dim clConcepto As New DataColumn("CONCEPTO")
        Dim clSubtotal As New DataColumn("SUBTOTAL")


        tabla.Columns.Add("CONCEPTO")
        tabla.Columns.Add("SUBTOTAL")


        'traigo las lineas de este comprobante
        lineas = c.getLineas()
        'se las asigno al comprobate
        Me.Comprobante.LineasDeComprobante = lineas
        Try
            Dim i As Integer
            Dim dRow As DataRow
            For i = 0 To lineas.Count - 1
                dRow = tabla.NewRow
                dRow("CONCEPTO") = lineas(i).Concepto
                dRow("SUBTOTAL") = Format(lineas(i).Subtotal, "########0.00")
                tabla.Rows.Add(dRow)
            Next
            tabla.AcceptChanges()
            Me.dgvLineasDeComprobante.DataSource = tabla
            'doy formato a la tabla

        Finally

        End Try

    End Sub
    Private Sub Reload()
        Controls.Clear()
        InitializeComponent()
        Me.Comprobante = Nothing
        Me.Comprobantes_Load(Me, Nothing)
    End Sub


    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        If Comprobante.Estado.ToUpper <> "ANULADO" Then
            Dim f As New rptViewer
            Me.AddOwnedForm(f)
            Dim espac As Boolean = True
            If Me.txtPacienteGravado.Text = "" Then
                espac = False
            End If
            f.cargarDsComprobantes(Comprobante, Me.chkLeyenda.Checked, espac)
            f.ShowDialog()
        Else
            MessageBox.Show("Está intentando imprimir un comprobante anulado." & vbCrLf & "Impresión cancelada", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub


    Private Sub Comprobantes_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        Me.Comprobante = Nothing
    End Sub

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub
End Class