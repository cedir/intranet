Imports System.Collections.Generic

Public Class PagoAnestesista

    Private lineasAnestesista As List(Of LineaPagoAnestesista)

    Public Property lineasDePago() As List(Of LineaPagoAnestesista)
        Get
            Return lineasAnestesista
        End Get
        Set(ByVal value As List(Of LineaPagoAnestesista))
            lineasAnestesista = value
        End Set
    End Property
    Public Sub New()
        Me.LineasDePago = New List(Of LineaPagoAnestesista)
    End Sub

    Public Sub cargarEstudiosALineasDePago(ByVal estudios As ArrayList)
        Dim lineaPago As New LineaPagoAnestesista
        Dim estudio As Estudio
        Dim estudioActual As Estudio = estudios(0)
        Dim i As Integer
        Dim nuevasLineas As List(Of LineaPagoAnestesista)
        For i = 0 To estudios.Count - 1
            estudio = estudios(i)
            If (estudio.paciente.Id = estudioActual.paciente.Id And estudio.obraSocial.idObraSocial = estudioActual.obraSocial.idObraSocial) Then
                lineaPago.estudios.Add(estudio)
            Else
                nuevasLineas = dividirLineasConMovimiento(lineaPago) 'Regla de negocio 1
                Me.addLineasDePago(nuevasLineas)

                estudioActual = estudio
                lineaPago = New LineaPagoAnestesista()
                lineaPago.estudios.Add(estudioActual)
            End If
        Next

        'agregamos la ultima linea, del ultimo paciente coincidente
        nuevasLineas = dividirLineasConMovimiento(lineaPago) 'Regla de negocio 1
        Me.addLineasDePago(nuevasLineas)
    End Sub
    Public Function getTotalAPagar() As Decimal
        Dim suma As Decimal
        For Each l As LineaPagoAnestesista In Me.lineasDePago
            suma = suma + l.importeApagar
        Next
        Return suma
    End Function

    ''' <summary>
    ''' este metodo recibe una linea, y crea nuevas, dependiendo si esta linea posee estudios con movimientos asociados
    ''' o no.
    ''' </summary>
    ''' <param name="lineaDePago"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function dividirLineaPorEsofagoConMovimiento(ByVal lineaDePago As LineaPagoAnestesista) As List(Of LineaPagoAnestesista)
        Dim returnArray As New List(Of LineaPagoAnestesista)
        Dim nuevaLineaParaEsofago As LineaPagoAnestesista = Nothing
        Dim contieneMovimientoDeCaja As Boolean = False

        If (lineaDePago.sePresentaPorARA) Then
            Dim ccaja As New CatalogoDeMovimientosDeCaja
            contieneMovimientoDeCaja = ccaja.contieneAnestesia(lineaDePago.estudios(0))
            If (contieneMovimientoDeCaja) Then
                'si trajo algun movimiento, sacar la esofago de lineaDePago y crear otra linea de pago para la esofago
                For Each e As Estudio In lineaDePago.estudios
                    If e.practica.idEstudio = 1 Then
                        nuevaLineaParaEsofago = New LineaPagoAnestesista
                        nuevaLineaParaEsofago.estudios.Add(e)
                        nuevaLineaParaEsofago.contieneEstudiosConMovimientosAsociados = True
                        returnArray.Add(nuevaLineaParaEsofago)
                        lineaDePago.estudios.Remove(e)
                        Exit For
                    End If
                Next
            End If
        End If

        'Tenemos que checkear que lineaDePago Posea algun estudio, ya que quizá solo tenia una esofago
        If lineaDePago.estudios.Count > 0 Then
            If nuevaLineaParaEsofago Is Nothing And contieneMovimientoDeCaja Then
                'esto afecta el importe, ya que se pone en positivo
                lineaDePago.contieneEstudiosConMovimientosAsociados = True
            Else
                lineaDePago.contieneEstudiosConMovimientosAsociados = False
            End If
            returnArray.Add(lineaDePago)
        End If

        'Calculo de importes de cada nueva linea
        For Each l As LineaPagoAnestesista In returnArray
            l.setImportes()
        Next

        Return returnArray
    End Function

    Private Function dividirLineasConMovimiento(ByVal lineaDePago As LineaPagoAnestesista) As List(Of LineaPagoAnestesista)
        Dim returnArray As New List(Of LineaPagoAnestesista)
        Dim lineaConEstudiosSinMovimientosAsociados As LineaPagoAnestesista = New LineaPagoAnestesista
        Dim lineaConEstudiosConMovimientosAsociados As LineaPagoAnestesista = Nothing

        If (lineaDePago.sePresentaPorARA) Then
            Dim ccaja As New CatalogoDeMovimientosDeCaja
            For Each e As Estudio In lineaDePago.estudios
                If (ccaja.contieneAnestesia(e)) Then
                    lineaConEstudiosConMovimientosAsociados = New LineaPagoAnestesista
                    lineaConEstudiosConMovimientosAsociados.estudios.Add(e)
                    lineaConEstudiosConMovimientosAsociados.contieneEstudiosConMovimientosAsociados = True
                    returnArray.Add(lineaConEstudiosConMovimientosAsociados)
                Else
                    lineaConEstudiosSinMovimientosAsociados.estudios.Add(e)
                End If
            Next
        Else
            lineaConEstudiosSinMovimientosAsociados = lineaDePago
        End If
        If lineaConEstudiosSinMovimientosAsociados.estudios.Count > 0 Then
            returnArray.Add(lineaConEstudiosSinMovimientosAsociados)
        End If

        'Calculo de importes de cada nueva linea
        For Each l As LineaPagoAnestesista In returnArray
            l.setImportes()
        Next

        Return returnArray
    End Function

    Private Sub addLineasDePago(ByVal lineasDePago As List(Of LineaPagoAnestesista))
        For Each linea As LineaPagoAnestesista In lineasDePago
            Me.lineasDePago.Add(linea)
        Next
    End Sub

End Class
