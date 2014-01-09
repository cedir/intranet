Imports System.Collections.Generic
Imports System
Imports CedirNegocios

Public Class Mensajeria


    Private arrUsers As New List(Of Usuario)
    Private arrDestinatarios As New List(Of Usuario)
    Private arrMensajes As New List(Of Mensaje)
   






    
    Private Sub Mensajeria_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cargamos los usuarios al combo
        Me.cargarComboUsuarios()
        'traemos mensajes no leidos
        Dim c As New CatalogoDeMensajes
        Me.arrMensajes.Clear()
        Me.arrMensajes = c.traerMensajes()
        c = Nothing

        Me.cargarGrilla()
    End Sub
    

    Private Sub cargarGrilla()
        Try
            If Me.arrMensajes.Count > 0 Then

                Me.ListView1.BeginUpdate()
                'limpio la grilla si ya habia algo
                If (Me.ListView1.Items.Count > 0) Then
                    Me.ListView1.Items.Clear()
                End If

                For Each m As Mensaje In arrMensajes
                    Dim item As ListViewItem
                    item = Me.ListView1.Items.Add(m.fecha.ToString().Remove(10) & "  " & m.hora)
                    item.SubItems.Add(m.emisor.nombreUsuario)
                    item.SubItems.Add(m.mensaje)
                    If (m.estado = 0) Then
                        item.SubItems.Add("No Leído")
                        'marcamos en rojo los no leídos
                        item.ForeColor = Color.Red

                    Else
                        item.SubItems.Add("Leído")
                    End If
                Next
                Me.ListView1.EndUpdate()
            Else
                MessageBox.Show("No posee mensajes")
                Me.ListView1.Items.Clear()
            End If
        
        Finally

        End Try


    End Sub

    Private Sub cargarComboUsuarios()
        Me.cmbDestinatarios.Items.Add(" Todos ...")
        Dim cat As New CatalogoDeUsuarios
        Try
            arrUsers = cat.getAll()
            For Each u As Usuario In arrUsers
                Me.cmbDestinatarios.Items.Add(u.nombreUsuario)
            Next
        Catch ex As Exception

        Finally
            cat = Nothing
        End Try


    End Sub

    Private Sub cmbDestinatarios_SelectionChangeCommitted(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDestinatarios.SelectionChangeCommitted

        'si selecciona todos, los agregamos
        If (Me.cmbDestinatarios.SelectedIndex = 0) Then
            Me.btnLimpiar.PerformClick()

            For Each ob As Object In Me.cmbDestinatarios.Items
                Me.lstBoxDestinatarios.Items.Add(ob)
            Next
            'sacamos el item que dice "todos..."
            Me.lstBoxDestinatarios.Items.RemoveAt(0)
            For Each u As Usuario In Me.arrUsers
                Me.arrDestinatarios.Add(u)
            Next
        Else
            If Not Me.contieneItem() Then
                Me.lstBoxDestinatarios.Items.Add(Me.cmbDestinatarios.SelectedItem)
                Me.arrDestinatarios.Add(Me.arrUsers(Me.cmbDestinatarios.SelectedIndex() - 1))
            End If
        End If

    End Sub

    Private Sub btnLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLimpiar.Click
        Me.lstBoxDestinatarios.Items.Clear()
        Me.arrDestinatarios.Clear()
    End Sub

    Private Sub btnQuitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuitar.Click
        If Me.lstBoxDestinatarios.SelectedItem <> Nothing Then
            Try
                Me.arrDestinatarios.RemoveAt(Me.lstBoxDestinatarios.SelectedIndex)
                Me.lstBoxDestinatarios.Items.RemoveAt(Me.lstBoxDestinatarios.SelectedIndices(0))
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Function contieneItem() As Boolean
        If Me.lstBoxDestinatarios.Items.Contains(Me.cmbDestinatarios.SelectedItem) Then
            MessageBox.Show("ya esta seleccionado")
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub btnEnviar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnviar.Click
        Me.enviarMensaje()
    End Sub


    Private Sub enviarMensaje()
        If Me.txtMensaje.Text = "" Or Me.lstBoxDestinatarios.Items.Count = 0 Then
            MessageBox.Show("No ha completado todos los datos para enviar" & vbCrLf & "     el mensaje     ")
        Else

            Dim cat As New CatalogoDeMensajes
            Dim msg As New Mensaje
            Try
                msg.destinatarios = Me.arrDestinatarios
                msg.mensaje = Me.txtMensaje.Text
                Dim fecha As String
                msg.hora = CStr(Now.TimeOfDay.Hours) & ":" & CStr(Now.TimeOfDay.Minutes)
                fecha = Date.Today.Year & "-" & Date.Today.Month & "-" & Date.Today.Day
                msg.fecha = fecha
                'estado ya es seteados por el catalogo
                Dim resp As String = cat.nuevoMensaje(msg)
                If resp = "ok" Then
                    MessageBox.Show("Mensaje enviado con éxito","Atención",MessageBoxButtons.OK)
                End If
            Finally

                Me.lstBoxDestinatarios.Items.Clear()
                Me.arrDestinatarios.Clear()
                txtMensaje.Text = ""
                msg = Nothing
                cat = Nothing
            End Try
        End If
    End Sub
    Private Sub BuscarMensajePorDescripcion()
        If Me.arrMensajes.Count < 1 Then
            Exit Sub
        End If
        Dim arrMensajesCoincidentes As New List(Of Mensaje)
        For Each m As Mensaje In Me.arrMensajes
            If m.mensaje.ToUpper().Contains(Me.txtBuscadorDescripcion.Text.ToUpper()) Then
                arrMensajesCoincidentes.Add(m)
            End If
        Next
        If arrMensajesCoincidentes.Count > 0 Then
            Me.arrMensajes.Clear()
            arrMensajes = arrMensajesCoincidentes
            cargarGrilla()
        Else
            MessageBox.Show("No se encontraron coincidencias")
        End If
        
    End Sub

    Private Sub cmbTipoMensaje_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTipoMensaje.SelectedIndexChanged
        Dim c As New CatalogoDeMensajes
        Me.arrMensajes.Clear()
        Select Case True
            Case Me.cmbTipoMensaje.SelectedItem = "No Leídos"
                Me.arrMensajes = c.traerMensajes(0)
            Case Me.cmbTipoMensaje.SelectedItem = "Leídos"
                Me.arrMensajes = c.traerMensajes(1)
            Case Me.cmbTipoMensaje.SelectedItem = "Todos"
                Dim del As delegadoTraerTodos
                del = New delegadoTraerTodos(AddressOf traerTodos)
                del.Invoke()
                del = Nothing
                ' Me.arrMensajes = c.traerMensajes(0, True)
        End Select
        c = Nothing
        Me.cmbTipoMensaje.SelectedValue = ""
        Me.cargarGrilla()

    End Sub

  

    Private Sub cmbAccion_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbAccion.SelectedIndexChanged

        If Me.ListView1.CheckedItems.Count > 0 Then
            Dim msg As New Mensaje
            Dim i As Integer
            Select Case True
                Case Me.cmbAccion.SelectedItem = "Marcar Leído"

                    For i = 0 To (Me.ListView1.CheckedItems.Count - 1)
                        arrMensajes(Me.ListView1.CheckedIndices(i)).estado = 1
                        msg.update(arrMensajes(Me.ListView1.CheckedIndices(i)))
                    Next
                   
                Case Me.cmbAccion.SelectedItem = "Marcar No Leído"
                    For i = 0 To (Me.ListView1.CheckedItems.Count - 1)
                        arrMensajes(Me.ListView1.CheckedIndices(i)).estado = 0
                        msg.update(arrMensajes(Me.ListView1.CheckedIndices(i)))
                    Next
                Case Me.cmbAccion.SelectedItem = "Eliminar"
                    Dim d As DialogResult
                    d = MessageBox.Show("¿Seguro desea eliminar el mensaje?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Hand, MessageBoxDefaultButton.Button2)
                    If d = Windows.Forms.DialogResult.Yes Then
                        For i = 0 To (Me.ListView1.CheckedItems.Count - 1)
                            msg.eliminar(arrMensajes(Me.ListView1.CheckedIndices(i)))
                        Next

                    End If
            End Select
            Dim del As delegadoTraerTodos
            del = New delegadoTraerTodos(AddressOf traerTodos)
            del.Invoke()
            cargarGrilla()
            del = Nothing
        End If
       


    End Sub


#Region "delegados"
    Public Delegate Sub delegadoTraerTodos()

    Private Sub traerTodos()
        Dim c As New CatalogoDeMensajes
        Me.arrMensajes.Clear()
        Me.arrMensajes = c.traerMensajes(0, True)
        c = Nothing
        Me.cmbTipoMensaje.ResetText()
        Me.cmbAccion.ResetText()
    End Sub
    

#End Region

    Private Sub ListView1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ListView1.MouseDoubleClick

        If Me.ListView1.SelectedItems.Count > 0 Then
            MessageBox.Show(arrMensajes(Me.ListView1.SelectedIndices(0)).mensaje, "Mensaje  :    ")
        End If

    End Sub

    Private Sub btnCopiarPortapapeles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCopiarPortapapeles.Click
        If Me.ListView1.SelectedItems.Count > 0 Then
            Windows.Forms.Clipboard.SetText(arrMensajes(Me.ListView1.SelectedIndices(0)).mensaje)
        Else
            MessageBox.Show("Seleccione un mensaje", "Atención")
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        BuscarMensajePorDescripcion()
    End Sub
End Class