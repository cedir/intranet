Imports System.Collections.Generic
Imports CedirNegocios

Public Class ComplejidadABM


#Region "Propiedades"
    Dim complejidades As List(Of Complejidad)
#End Region


    Private Sub ComplejidadABM_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarGrilla()
    End Sub
    Private Sub cargarGrilla()
        Dim c As New CatalogoDeComplejidades
        complejidades = c.getAll()
        c = Nothing
        Dim oBinding As New BindingSource
        oBinding.DataSource = complejidades

        Me.dtgvComplejidades.AutoGenerateColumns = False
        Me.dtgvComplejidades.DataSource = oBinding

        oBinding.Sort = "id ASC"
    End Sub



    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Modificar()
        MsgBox("Operacion realizada con éxito")
    End Sub

    Private Sub Modificar()

        For Each c As Complejidad In Me.complejidades
            Dim cNeg As New Complejidad
            cNeg.modificar(c)
        Next
        Me.cargarGrilla()



    End Sub

 


End Class