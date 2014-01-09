Imports System.Collections.Generic
Imports CedirNegocios

Public Class MedicamentosMovimientoStock


#Region "Variables de instancia"
    Dim medicamentos As ArrayList

#End Region
#Region "Eventos"

    Private Sub MedicamentosMovimientoStock_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cCat As New CatalogoDeMedicamentos
        Try
            medicamentos = cCat.traerMedicamentos()
            cargarGrilla()
            Me.cargarComboAnestesista()
        Catch ex As Exception

        Finally
            cCat = Nothing
        End Try
        

    End Sub
    Private Sub btnEncontrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncontrar.Click
        Buscar()
    End Sub
    Private Sub MedicamentosMovimientoStock_Activated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        cargarGrilla()
    End Sub
    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click
        ModificarMedicamento()
    End Sub
    Private Sub lstMedicamentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstMedicamentos.SelectedIndexChanged
        Me.grpMovimiento.Enabled = False
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        Confirmar()
    End Sub

#End Region

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        'Inicializamos la coleccion de medicamentos
        Me.medicamentos = New ArrayList
    End Sub

    Private Sub cargarGrilla()
        Dim med As New Medicamento
        Try

            Dim i As Integer
            Me.lstMedicamentos.BeginUpdate()
            'limpio la grilla si ya habia algo
            If (Me.lstMedicamentos.Items.Count > 0) Then
                Me.lstMedicamentos.Items.Clear()
            End If

            For i = 0 To medicamentos.Count - 1
                med = medicamentos(i)
                Dim item As ListViewItem
                item = Me.lstMedicamentos.Items.Add(med.descripcion)
                item.SubItems.Add(med.stock.ToString())
                item.SubItems.Add(med.importe.ToString())
            Next
            Me.lstMedicamentos.EndUpdate()

        Catch ex As Exception
        Finally
            med = Nothing
        End Try

    End Sub

    Private Sub Buscar()
        Dim cCat As New CatalogoDeMedicamentos
        Try
            medicamentos = cCat.traerMedicamentos(txtNombre.Text)
            cargarGrilla()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            cCat = Nothing
        End Try


    End Sub

    Private Sub ModificarMedicamento()
        If Me.lstMedicamentos.SelectedItems.Count > 0 Then
            Me.grpMovimiento.Enabled = True
        End If
    End Sub

    Private Sub Confirmar()
        Dim med As New Medicamento
        Dim mov As New MovimientoStockMedicamento
        Try
            med = medicamentos(Me.lstMedicamentos.SelectedIndices(0))
            mov.medicamento = med
            If Me.rdbtnIngreso.Checked = True Then
                mov.cantidad = Me.numCantidad.Value
            Else
                mov.cantidad = -Me.numCantidad.Value

            End If

            mov.descripcion = Me.txtDescripcion.Text

            Dim catMovStock As New CatalogoDeMovimientosStock
            catMovStock.crearMovimientoStockMedicacion(mov)
            
        Catch ex As Exception

        Finally
            med = Nothing
            Me.MedicamentosMovimientoStock_Load(Me, Nothing)
        End Try
    End Sub

    Private Sub cargarComboAnestesista()
        Dim anestesista As Medico
        Dim catalogomedicos As New CatalogoDeMedicos
        'Dim selectedAnes As Integer
        'selectedAnes = cmbAnestesistas.SelectedIndex
        Dim arranestesistas As ArrayList
        Try
            arranestesistas = catalogomedicos.TodosLosAnestesistas()
            cmbAnestesistas.Items.Clear()
            cmbAnestesistas.Items.Add("Sin Definir")
            Dim i As Integer
            For i = 0 To arranestesistas.Count - 1
                anestesista = arranestesistas(i)
                cmbAnestesistas.Items.Add(anestesista.nombreCompleto)
            Next
        Catch ex As Exception
        Finally
            anestesista = Nothing
            catalogomedicos = Nothing
            arranestesistas = Nothing
        End Try

    
    End Sub
  
    Private Sub cmbAnestesistas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAnestesistas.SelectedIndexChanged
        Me.txtDescripcion.Text = Me.txtDescripcion.Text & Me.cmbAnestesistas.SelectedItem
    End Sub
End Class