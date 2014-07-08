Imports System.Drawing
Imports System.Drawing.Printing
Imports System.Collections.Generic


Public Class ImprimirDetalle
    Dim cPresentacion As Presentacion
    Dim linea As LineaDeFacturacion
    Dim cPrintingEsudioLineIndex As Integer
    Dim _esFacturacionDetalle As Boolean
    Public Datagrid1 As System.Windows.Forms.DataGrid

    Public Property esFacturacionDetalle() As Boolean
        Get
            Return _esFacturacionDetalle
        End Get
        Set(ByVal value As Boolean)
            _esFacturacionDetalle = value
        End Set
    End Property
    Public Property presentacion() As Presentacion
        Get
            Return cPresentacion
        End Get
        Set(ByVal value As Presentacion)
            cPresentacion = value
        End Set
    End Property


#Region "IMPRIMIR"
  
    Public Sub prepareImprimirDetalle()
        Dim SalesReport As New PrintDocument
        AddHandler SalesReport.PrintPage, AddressOf imprimirDetalleFacturacion

        'Imprimir
        cPrintingEsudioLineIndex = 0
        SalesReport.Print()

    End Sub

    Sub imprimirDetalleFacturacion(ByVal sender As Object, ByVal e As PrintPageEventArgs)

        Dim tituloFacturacion As New Font("Arial", 12, FontStyle.Bold)
        Dim subTitulo As New Font("Arial", 10, FontStyle.Regular)
        Dim totalFont As New Font("Arial", 10, FontStyle.Bold)
        Dim reportFont As New Font("Arial", 9, FontStyle.Regular)
        Dim reportFontHeight As Integer = reportFont.GetHeight(e.Graphics)

        'default page settings
        Dim leftMarge As Single = 100
        Dim pageMaxHeight As Integer = 1000
        Dim yStart As Integer = 230
        Dim CurrentY As Integer = yStart

        Dim color As New Color
        Dim myPen As New System.Drawing.Pen(Drawing.Color.Black)
        myPen.Alignment = Drawing2D.PenAlignment.Center
        myPen.Width = 1

        'Dim height As Single = 100.0F
        Dim drawRect As New RectangleF
        drawRect.X = leftMarge
        drawRect.Width = 700.0F
        drawRect.Height = reportFontHeight

        Dim rectMedicacion As New RectangleF
        rectMedicacion.X = leftMarge
        rectMedicacion.Width = 300 - leftMarge
        rectMedicacion.Height = reportFontHeight

        'Encabezado de detalle
        If cPrintingEsudioLineIndex = 0 Then
            Dim rectTitulo As New RectangleF
            rectTitulo.X = leftMarge
            rectTitulo.Width = 700.0F
            rectTitulo.Height = 18
            'Obra social
            rectTitulo.Y = CurrentY - reportFontHeight
            e.Graphics.DrawString("Obra Social: " & cPresentacion.obraSocial.ObraSocial, tituloFacturacion, Brushes.Black, rectTitulo)

            'Descripcion
            CurrentY = CurrentY + 30
            drawRect.Y = CurrentY - reportFontHeight

            e.Graphics.DrawString("Detalle de Facturación correspondiente al mes de " & cPresentacion.periodo, subTitulo, Brushes.Black, drawRect)

            'fecha
            CurrentY = CurrentY + 20
            drawRect.Y = CurrentY - reportFontHeight
            e.Graphics.DrawString("Fecha: " & cPresentacion.fechaFacturacion, subTitulo, Brushes.Black, drawRect)

            'Linea horizontal
            CurrentY = CurrentY + 20
            e.Graphics.DrawLine(myPen, 100, CurrentY, 700, CurrentY)

            CurrentY = CurrentY + 15
        End If

        '<----------------------------------------------------------->

        Dim i, j As Integer
        Dim cLinea As LineaDeFacturacion

        'calcular tamaño linea
        cLinea = cPresentacion.getLineasDeFacturacionEstudios(cPrintingEsudioLineIndex)
        Dim cSize As Single = Me.getLineaSize(cLinea)
        Dim estimateY As Single = CurrentY + cSize
        While (estimateY <= pageMaxHeight And cPrintingEsudioLineIndex < cPresentacion.getLineasDeFacturacionEstudios.Count)
            Dim cEstudio As Estudio = cLinea.estudio
            'Fecha
            e.Graphics.DrawString("Fecha: " & cEstudio.fechaEstudio, reportFont, Brushes.Black, leftMarge, CurrentY)
            CurrentY = CurrentY + 20

            'Paciente
            Dim strPaciente As String = "Paciente: " & cLinea.estudio.paciente.nombreCompleto
            If DataGrid1.Item(cPrintingEsudioLineIndex, 3) <> "" Then
                'Si tiene nroAfiliado ponerlo
                strPaciente &= " - Nro de afiliado: " & DataGrid1.Item(cPrintingEsudioLineIndex, 3)
            End If
            e.Graphics.DrawString(strPaciente, reportFont, Brushes.Black, leftMarge, CurrentY)

            'Nro de orden y nro matricula medico
            If cLinea.estudio.nroOrden <> "" Then
                CurrentY = CurrentY + 20
                e.Graphics.DrawString("Nro de orden: " & cLinea.estudio.nroOrden, reportFont, Brushes.Black, leftMarge, CurrentY)
            End If
            If (cEstudio.medicoActuante.nroMatricula <> "" And (cEstudio.obraSocial.idObraSocial = 79 Or cEstudio.obraSocial.idObraSocial = 3)) Then
                'tenemos que considerar que baje de renglon si no hay nro orden
                If cLinea.estudio.nroOrden = "" Then
                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("Nro. Mat. Profesional: " & cEstudio.medicoActuante.nroMatricula, reportFont, Brushes.Black, leftMarge, CurrentY)
                Else
                    e.Graphics.DrawString("Nro. Mat. Profesional: " & cEstudio.medicoActuante.nroMatricula, reportFont, Brushes.Black, 350, CurrentY)
                End If

            End If

            'Practica
            CurrentY = CurrentY + 20
            drawRect.Y = CurrentY
            e.Graphics.DrawString("Práctica: " & cEstudio.practica.Estudio, reportFont, Brushes.Black, drawRect)

            Dim startLine As Integer
            'Importe practica
            CurrentY = CurrentY + 28
            startLine = CurrentY

            Dim codigoPractica As String = ""
            If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
                codigoPractica = cEstudio.practica.codigoMedicoOSDE & " "
            End If
            e.Graphics.DrawString(codigoPractica & "Práctica  ", reportFont, Brushes.Black, leftMarge, CurrentY)
            e.Graphics.DrawString(" $" & CStr(cLinea.importe), reportFont, Brushes.Black, 460, CurrentY)

            'Diferencia Paciente
            If cLinea.diferenciaPaciente <> 0 Then
                CurrentY = CurrentY + 20
                e.Graphics.DrawString("A cargo del paciente", reportFont, Brushes.Black, leftMarge, CurrentY)
                e.Graphics.DrawString("  $" & cLinea.diferenciaPaciente, reportFont, Brushes.Black, 460, CurrentY)
            End If

            'Pension
            If cLinea.pension <> 0 Then
                CurrentY = CurrentY + 20

                Dim codigoPension As String
                If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
                    codigoPension = "430185  "
                Else
                    codigoPension = ""
                End If
                e.Graphics.DrawString(codigoPension & "  Pensión  ", reportFont, Brushes.Black, leftMarge, CurrentY)
                e.Graphics.DrawString("  $" & CStr(cLinea.pension), reportFont, Brushes.Black, 460, CurrentY)
            End If

            If cLinea.estudio.ArancelAnestesia <> 0 Then
                CurrentY = CurrentY + 20
                e.Graphics.DrawString("Anestesia valor IAPOS: " & Me.obtenerDescripcionAnestesiaEnImpresion(cLinea.estudio), reportFont, Brushes.Black, leftMarge, CurrentY)
                e.Graphics.DrawString("  $ " & CStr(cLinea.estudio.ArancelAnestesia), reportFont, Brushes.Black, 460, CurrentY)
            End If


            'Medicacion y material especifico
            If cEstudio.arrMedicacion.Count > 0 Then
                Dim med As Medicacion
                Dim arrMedicacionSinMaterialEspecifico As New ArrayList
                Dim arrMaterialEspecifico As New ArrayList
                arrMedicacionSinMaterialEspecifico = cEstudio.getMedicacionSinMaterialEspecifico()
                arrMaterialEspecifico = cEstudio.getMaterialEspecifico()
                Dim totalMaterialEspecifico As Decimal = 0.0

                'Material Especifico
                If arrMaterialEspecifico.Count > 0 Then
                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("Material Especifico: ", reportFont, Brushes.Black, leftMarge, CurrentY)
                    For j = 0 To arrMaterialEspecifico.Count - 1
                        CurrentY = CurrentY + 20
                        med = arrMaterialEspecifico(j)
                        totalMaterialEspecifico = totalMaterialEspecifico + med.importe

                        rectMedicacion.Y = CurrentY

                        'si es osde u osde cedir
                        Dim codigoMedicamento As String = ""
                        If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
                            codigoMedicamento = med.medicamento.codigoMedicoOSDE & " "
                        End If
                        e.Graphics.DrawString(codigoMedicamento & "•" & med.medicamento.descripcion, reportFont, Brushes.Black, rectMedicacion)
                        e.Graphics.DrawString("  $" & med.importe, reportFont, Brushes.Black, 360, CurrentY)
                    Next

                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("  Total Material especifico*", reportFont, Brushes.Black, leftMarge, CurrentY)
                    e.Graphics.DrawString("  $" & Format(totalMaterialEspecifico, "############0.00").ToString(), reportFont, Brushes.Black, 460, CurrentY)
                End If



                If arrMedicacionSinMaterialEspecifico.Count > 0 Then
                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString("Medicación:", reportFont, Brushes.Black, leftMarge, CurrentY)


                    For j = 0 To arrMedicacionSinMaterialEspecifico.Count - 1
                        med = arrMedicacionSinMaterialEspecifico(j)
                        CurrentY = CurrentY + 20
                        rectMedicacion.Y = CurrentY
                        e.Graphics.DrawString("  • " & med.medicamento.descripcion, reportFont, Brushes.Black, rectMedicacion)
                        e.Graphics.DrawString("  $" & med.importe, reportFont, Brushes.Black, 360, CurrentY)

                    Next

                    Dim codigoMedicacion As String = ""
                    If cLinea.estudio.obraSocial.idObraSocial = 79 Or cLinea.estudio.obraSocial.idObraSocial = 3 Then
                        codigoMedicacion = "922501 "
                    End If


                    CurrentY = CurrentY + 20
                    e.Graphics.DrawString(codigoMedicacion & "Total Medicación*", reportFont, Brushes.Black, leftMarge, CurrentY)
                    e.Graphics.DrawString("  $" & CStr(cEstudio.getTotalMedicacion - totalMaterialEspecifico) & "  * Valorizada de acuerdo al Vademecum Kairos", reportFont, Brushes.Black, 460, CurrentY)
                End If

            End If



            'Lineas verticales de los totales
            e.Graphics.DrawLine(myPen, 340, startLine, 340, CurrentY + reportFontHeight)
            e.Graphics.DrawLine(myPen, 440, startLine, 440, CurrentY + reportFontHeight)

            'Total
            CurrentY = CurrentY + 25
            e.Graphics.DrawString("Total del estudio", reportFont, Brushes.Black, leftMarge, CurrentY)
            e.Graphics.DrawString(" $" & Format(Convert.ToDecimal(cLinea.getSubtotal), "############0.00").ToString(), reportFont, Brushes.Black, 460, CurrentY)

            'Linea horizontal de fin de estudio
            CurrentY = CurrentY + 20
            e.Graphics.DrawLine(myPen, 100, CurrentY, 700, CurrentY)

            'Seteo espacio para el siguiente estudio
            CurrentY = CurrentY + 15

            cPrintingEsudioLineIndex = cPrintingEsudioLineIndex + 1
            If cPrintingEsudioLineIndex < cPresentacion.getLineasDeFacturacionEstudios.Count Then
                cLinea = cPresentacion.getLineasDeFacturacionEstudios(cPrintingEsudioLineIndex)
                cSize = Me.getLineaSize(cLinea)
                estimateY = CurrentY + cSize
            End If

        End While

        'Pregunto si quedan estudios por imprimir
        If cPrintingEsudioLineIndex = cPresentacion.getLineasDeFacturacionEstudios.Count Then
            'No hay mas estudios
            CurrentY = CurrentY + 10
            drawRect.Y = CurrentY
            e.Graphics.DrawString("Total: $ " & CStr(cPresentacion.total), totalFont, Brushes.Black, drawRect)
            e.HasMorePages = False
        Else
            e.HasMorePages = True
        End If

    End Sub

    Private Function obtenerDescripcionAnestesiaEnImpresion(ByVal es As Estudio) As String
        'obs.: Como la columna anestesia es <> 0, vamos a ver el total de estudios en el dia 
        'y devolver una concatenacion de strings 
        Dim i As Integer = 0
        Dim cLinea As New LineaDeFacturacion
        Dim arr As ArrayList
        arr = cPresentacion.getLineasDeFacturacionEstudios()
        Dim estudios As New List(Of Estudio)
        'tengo que encontrar todos los estudios que existen en la misma fecha del estudio
        'pasado como parametro
        For i = 0 To arr.Count - 1
            cLinea = arr(i)
            If es.fechaEstudio() = cLinea.estudio.fechaEstudio() And es.paciente.Id = cLinea.estudio.paciente.Id Then
                estudios.Add(cLinea.estudio)
            End If
        Next

        Dim concat As String = ""
        For Each e As Estudio In estudios
            concat = concat + e.practica.abreviatura + ", "
        Next
        'borro la ultima coma
        concat = concat.Remove(concat.Length - 2)

        Return concat

    End Function

    Private Function getLineaSize(ByVal linea As LineaDeFacturacion) As Single
        'Dim reportFontHeight As Single = 14 'ojo, cambiar este valor si se cambia el tamaño del font de la letra
        'Dim rowSize As Single = reportFontHeight

        Dim totalSize As Single = 0

        'Fecha
        totalSize += 15 '15 es la separacion de arriba 
        'Paciente
        totalSize += 20
        'Nro de orden: podría no tener
        If linea.estudio.nroOrden <> "" Then
            totalSize += 20
        End If

        'Descripcion practica
        totalSize += 20
        'Valor practica
        totalSize += 28
        'Dif paciente: podría no tener
        If linea.diferenciaPaciente <> 0 Then
            totalSize += 20
        End If
        'Pension: podría no tener
        If linea.pension <> 0 Then
            totalSize += 20
        End If
        'Medicacion (lineas y total): podría no tener
        If linea.estudio.arrMedicacion.Count > 0 Then
            totalSize += (20 * linea.estudio.arrMedicacion.Count)
            'Total neurolepto
            totalSize += 20
        End If
        'Total del estudio
        totalSize += 25
        'Linea final
        totalSize += 20

        Return totalSize
    End Function
    

    Private Sub prepareImprimirFactura()

        Dim facturaReport As New PrintDocument
        AddHandler facturaReport.PrintPage, AddressOf imprimirFactura
        'Imprimir
        facturaReport.Print()
    End Sub

    Sub imprimirFactura(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim x As Single = 100.0F
        Dim y As Single = 150.0F
        Dim width As Single = 700.0F
        Dim height As Single = 100.0F
        Dim drawRect As New RectangleF(x, y, width, height)

        Dim CurrentY As Integer = 130
        Dim CurrentX As Integer = 100
        Dim ReportFont As New Font("Arial", 10, FontStyle.Regular)
        Dim ReportFontHeight As Integer = ReportFont.GetHeight(e.Graphics)
        Dim resaltaText As New Font("Arial", 11, FontStyle.Bold)
        Dim leyendaFont As New Font("Arial", 10, FontStyle.Italic)

        Dim os As ObraSocial
        os = cPresentacion.obraSocial

        drawRect.Y = CurrentY - ReportFontHeight
        CurrentX = 650
        e.Graphics.DrawString("Fecha: " & Today.Date, ReportFont, Brushes.Black, CurrentX, CurrentY)

        CurrentY = CurrentY + 82
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Institución: " & os.ObraSocial, ReportFont, Brushes.Black, drawRect)

        CurrentY = CurrentY + 20
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Domicilio: " & os.direccion & " - " & os.localidad & " (CP: " & os.CodigoPostal & ")", ReportFont, Brushes.Black, drawRect)

        CurrentY = CurrentY + 20
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Cuit: " & os.nroCuit & "     -     I.V.A: " & os.CondicionFiscal, ReportFont, Brushes.Black, 100, CurrentY - ReportFontHeight)

        Dim descTot As String
        descTot = InputBox("Ingrese el total en letras", "Ingrese el total en letras")

        CurrentY = CurrentY + 20
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Concepto", resaltaText, Brushes.Black, 100, CurrentY)
        e.Graphics.DrawString("Total", resaltaText, Brushes.Black, 650, CurrentY)

        CurrentY = CurrentY + 120
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Facturación mes de " & cPresentacion.periodo & " según detalle adjunto", ReportFont, Brushes.Black, drawRect)
        e.Graphics.DrawString(CStr(cPresentacion.total), ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)

        CurrentY = CurrentY + 50
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("I.V.A (" & cPresentacion.comprobante.Gravado.porcentaje & "%)", ReportFont, Brushes.Black, drawRect)
        e.Graphics.DrawString(cPresentacion.getImporteIva, ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)

        CurrentY = CurrentY + 80
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Total", ReportFont, Brushes.Black, drawRect)
        e.Graphics.DrawString(cPresentacion.getTotalFactura, ReportFont, Brushes.Black, CurrentX, CurrentY - ReportFontHeight)


        CurrentY = CurrentY + 70
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString(descTot, resaltaText, Brushes.Black, drawRect)

        'Leyenda
        CurrentY = CurrentY + 40
        drawRect.Y = CurrentY - ReportFontHeight
        e.Graphics.DrawString("Esta factura contiene honorarios por cuenta y orden de médicos.", leyendaFont, Brushes.Black, drawRect)

        e.HasMorePages = False


    End Sub




#End Region


End Class
