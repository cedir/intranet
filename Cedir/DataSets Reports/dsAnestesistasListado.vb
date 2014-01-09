

Partial Public Class dsAnestesistasListado
    Partial Class EstudioDataTable

    End Class

    Partial Class tblEstudioSinCompDataTable

        Private Sub tblEstudioSinCompDataTable_tblEstudioSinCompRowChanging(ByVal sender As System.Object, ByVal e As tblEstudioSinCompRowChangeEvent) Handles Me.tblEstudioSinCompRowChanging

        End Sub
    End Class

    Partial Class tblDataTable

        Private Sub tblDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.colRetencionColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

End Class
