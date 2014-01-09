Imports CedirNegocios
Imports System.Collections.Generic
Public Class MedicamentoListadoMovimientos
#Region "Variables"
    Private m_lista As New List(Of MovimientoStockMedicamento)
#End Region


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Buscar()
    End Sub
    Private Sub Buscar()
        Dim oCat As New CatalogoDeMovimientosStock
        m_lista = oCat.getMovimientosStockMedicacion(Me.dtpDesde.Value.ToString().Remove(10), Me.dtpHasta.Value.ToString().Remove(10))
        cargarGrilla()
    End Sub
    Private Sub cargarGrilla()
        If m_lista.Count = 0 Then
            MsgBox("La búsqueda no dio resultados")
            Me.lstMovimientos.Items.Clear()
        Else
            Dim i As Integer
            Me.lstMovimientos.BeginUpdate()
            If (Me.lstMovimientos.Items.Count > 0) Then
                Me.lstMovimientos.Items.Clear()
            End If

            For i = 0 To m_lista.Count - 1
                'limpio la grilla si ya habia algo
                Dim item As ListViewItem
                item = Me.lstMovimientos.Items.Add(Me.m_lista(i).Fecha.ToString.Remove(10))
                item.SubItems.Add(Me.m_lista(i).medicamento.descripcion)
                item.SubItems.Add(Me.m_lista(i).cantidad.ToString())
                item.SubItems.Add(Me.m_lista(i).Usuario.nombreUsuario)
                item.SubItems.Add(Me.m_lista(i).descripcion)



            Next

            Me.lstMovimientos.EndUpdate()

        End If



    End Sub

    Private Sub imprimir()
        Dim f As New rptViewer
        Me.AddOwnedForm(f)
        f.cargarDsMovimientosStock(Me.m_lista)
        f.ShowDialog()

    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        imprimir()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        m_lista = Nothing
        Me.Close()

    End Sub
End Class