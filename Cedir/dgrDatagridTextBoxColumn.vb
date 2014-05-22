Public Class dgrDatagridTextBoxColumn
    Inherits System.Windows.Forms.DataGridTextBoxColumn

    Public Sub New(ByVal strMappingName As String, ByVal strHeaderText As String, ByVal intColWidth As Integer, ByVal intMaxLength As Integer, ByVal strFormat As String, ByVal strAlignment As String, ByVal blnIsReadOnly As Boolean)
        MyBase.MappingName = strMappingName
        MyBase.HeaderText = strHeaderText
        MyBase.Width = intColWidth
        MyBase.TextBox.MaxLength = intMaxLength
        MyBase.Format = strFormat
        MyBase.Alignment = HorizontalAlignment.Left
        MyBase.ReadOnly = blnIsReadOnly
        MyBase.TextBox.Enabled = True
        MyBase.NullText = ""
        AddHandler MyBase.TextBox.KeyDown, AddressOf HandleKeydown
    End Sub
    Private Sub HandleKeydown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        'este metodo lo vamos a utilizar para detectar algun error en tipeo. 
        Try

            ' functionCatchError()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function functionCatchError() As Boolean
        Return True
    End Function


End Class


