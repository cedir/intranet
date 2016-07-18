
Imports System.Drawing.Printing
Imports System.Math
Public Class wallyGrid
    Inherits DataGrid

    Public leftMarge As Single = 95
    Public apaizada As Boolean = False
    Public columnNotToPrintIndexes() As Integer
    Public columnsWidth() As Single
    Public imprimirShowPrintDialog As Boolean = True

    'Tutulos
    Public imprimirTitle As String
    Public imprimirSubTitleSuperior1 As String
    Public imprimirSubTitleSuperior2 As String
    Public imprimirSubTitleSuperior3 As String
    Public imprimirSubTitleInferior1 As String
    Public imprimirSubTitleInferior2 As String


    Dim cantGridColumns As Integer 'esto es hasta que vea como obtener el nro de columnas
    'Dim maxRightMarge As Integer = 800
    Dim cantodadMaxRegistros As Integer = 39

    Dim currentRow As Integer = 0
    Dim cantidadRegistros As Integer
    Dim cantidadRegistrosRestantes As Integer
    Dim pageCount As Integer = 0
    Dim marginTop As Integer = 230

    Private Sub PrintSalesReport()
        Dim SalesReport As New PrintDocument
        AddHandler SalesReport.PrintPage, AddressOf PrintSalesPage

        If apaizada Then
            SalesReport.DefaultPageSettings.Landscape = True
            'maxRightMarge = 1000
            cantodadMaxRegistros = 24
            marginTop = 130
        End If

        If imprimirShowPrintDialog Then
            Dim pss As New PrintDialog
            Dim bp As DialogResult
            pss.Document = SalesReport
            bp = pss.ShowDialog
            If bp = DialogResult.OK Then
                SalesReport.Print()
            End If
        Else
        SalesReport.Print()
        End If


    End Sub
    Sub PrintSalesPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim rowHeight As Single = 16.0F
        Dim yStart As Integer = marginTop

        Dim drawRect As New RectangleF
        'drawRect.Width = 100.0F
        drawRect.Height = 18.0F

        Dim reportColumnTitleFont As New Font("Arial", 10, FontStyle.Bold)
        Dim ReportFont As New Font("Arial", 10, FontStyle.Regular)
        Dim ReportFontHeight As Integer = ReportFont.GetHeight(e.Graphics)

        'Table lines styles
        Dim tableBorderLineStyle As System.Drawing.Pen
        tableBorderLineStyle = New System.Drawing.Pen(System.Drawing.Color.Black)
        tableBorderLineStyle.DashStyle = Drawing2D.DashStyle.Solid
        Dim tableContentLineStyle As System.Drawing.Pen
        tableContentLineStyle = New System.Drawing.Pen(System.Drawing.Color.Black)
        tableContentLineStyle.DashStyle = Drawing2D.DashStyle.Dot


        'Encabezado de la hoja
        Dim fuenteTitulo As New Font("Times New Roman", 14, FontStyle.Underline)
        Dim fuenteSubtitulos As New Font("Times New Roman", 10, FontStyle.Regular)
        Dim fuenteSubtitulosInferiores As New Font("Times New Roman", 8, FontStyle.Regular)

        If Me.cantidadRegistrosRestantes = Me.cantidadRegistros Then
            'Es la primer hoja

            'Title
            If imprimirTitle <> "" Then
                Dim centroHoja As Single
                If apaizada Then
                    centroHoja = 400
                Else
                    centroHoja = 200
                End If
                e.Graphics.DrawString(imprimirTitle, fuenteTitulo, Brushes.Black, leftMarge, yStart)
                yStart += 30
            End If
            'Subtitulo superior 1
            If imprimirSubTitleSuperior1 <> "" Then
                e.Graphics.DrawString(imprimirSubTitleSuperior1, fuenteSubtitulos, Brushes.Black, leftMarge, yStart)
                yStart += 20
            End If
            'Subtitulo Superior 2
            If imprimirSubTitleSuperior2 <> "" Then
                e.Graphics.DrawString(imprimirSubTitleSuperior2, fuenteSubtitulos, Brushes.Black, leftMarge, yStart)
                yStart += 20
            End If
            'Subtitulo Superior 3
            If imprimirSubTitleSuperior3 <> "" Then
                e.Graphics.DrawString(imprimirSubTitleSuperior3, fuenteSubtitulos, Brushes.Black, leftMarge, yStart)
                yStart += 20
            End If
            yStart += 20
        End If

        '<-----------------IMPRIMIR TABLA---------------------->

        Dim arrColumnToPrintIndexes() As Integer = Me.getCoulmnIndexes
        Dim arrColumnsWidth() As Single = Me.getColumnsWidth(arrColumnToPrintIndexes)
        Dim tableWidth As Single = Me.getTableWidth(arrColumnsWidth)

        'Calcular ancho de la tabla, para esta hoja
        Dim tableHeight As Single
        Dim rowsToPrintInThisPage As Integer
        If Me.cantidadRegistrosRestantes > Me.cantodadMaxRegistros Then
            tableHeight = yStart + (rowHeight * cantodadMaxRegistros)
            rowsToPrintInThisPage = cantodadMaxRegistros
        Else
            tableHeight = yStart + (rowHeight * Me.cantidadRegistrosRestantes)
            rowsToPrintInThisPage = Me.cantidadRegistrosRestantes
        End If

        'Linea superior de la tabla
        e.Graphics.DrawLine(tableBorderLineStyle, leftMarge, yStart - ReportFontHeight, (tableWidth + leftMarge), yStart - ReportFontHeight)
        'Linea lateral derecho de la tabla
        e.Graphics.DrawLine(tableBorderLineStyle, (tableWidth + leftMarge), yStart - ReportFontHeight, (tableWidth + leftMarge), tableHeight)

        'Titulos de columnas de la tabla
        Dim xAcum As Single = leftMarge
        Dim iniRecta As Drawing.Point
        Dim cStyle As DataGridTableStyle = Me.TableStyles(0)
        Dim cColumn As DataGridTextBoxColumn
        For j As Integer = 0 To UBound(arrColumnToPrintIndexes)
            cColumn = cStyle.GridColumnStyles(arrColumnToPrintIndexes(j))
            drawRect.Width = arrColumnsWidth(j)
            drawRect.X = xAcum
            drawRect.Y = yStart - ReportFontHeight
            e.Graphics.DrawString(cColumn.HeaderText, reportColumnTitleFont, Brushes.Black, drawRect)

            'Linea lateral izquierda de cada columna de la tabla
            iniRecta = New Drawing.Point
            iniRecta.X = xAcum
            iniRecta.Y = yStart - ReportFontHeight
            e.Graphics.DrawLine(tableBorderLineStyle, iniRecta.X, iniRecta.Y, iniRecta.X, tableHeight)

            xAcum += arrColumnsWidth(j)
        Next

        'Imprimir datos
        Dim CurrentY As Integer = yStart + rowHeight - ReportFontHeight
        For i As Integer = 0 To rowsToPrintInThisPage - 1
            'Imprimir un registro
            xAcum = leftMarge
            For x As Integer = 0 To UBound(arrColumnToPrintIndexes)
                cColumn = cStyle.GridColumnStyles(arrColumnToPrintIndexes(x))
                drawRect.Width = arrColumnsWidth(x)
                drawRect.X = xAcum
                drawRect.Y = CurrentY
                e.Graphics.DrawString(Me.Item(currentRow, arrColumnToPrintIndexes(x)), ReportFont, Brushes.Black, drawRect)
                xAcum += arrColumnsWidth(x)
            Next
            'Linea superior del registro
            e.Graphics.DrawLine(tableContentLineStyle, leftMarge, CurrentY, (tableWidth + leftMarge), CurrentY)

            CurrentY = CurrentY + ReportFontHeight
            currentRow += 1
        Next
        'Linea de fondo de la tabla
        e.Graphics.DrawLine(tableBorderLineStyle, leftMarge, tableHeight, (tableWidth + leftMarge), tableHeight)

        '<-------------------------------------------------------------------->

        cantidadRegistrosRestantes -= rowsToPrintInThisPage
        If cantidadRegistrosRestantes > 0 Then
            e.HasMorePages = True
            pageCount += 1
        Else
            'Fin de la impresion
            If imprimirSubTitleInferior1 <> "" Then
                CurrentY += 10
                e.Graphics.DrawString(imprimirSubTitleInferior1, fuenteSubtitulosInferiores, Brushes.Black, leftMarge, CurrentY)
            End If
            If imprimirSubTitleInferior2 <> "" Then
                CurrentY += 15
                Dim drawRect2 As New RectangleF
                drawRect2.Width = tableWidth
                drawRect2.Height = rowHeight * 6
                drawRect2.X = leftMarge
                drawRect2.Y = CurrentY
                e.Graphics.DrawString(imprimirSubTitleInferior2, fuenteSubtitulosInferiores, Brushes.Black, drawRect2)
            End If

            currentRow = 0
            pageCount = 0
        End If
    End Sub


    Public Sub imprimir(ByVal rowsCount As Integer, ByVal cantTotalGridColumns As Integer)
        Me.cantGridColumns = cantTotalGridColumns
        Me.cantidadRegistros = rowsCount
        Me.cantidadRegistrosRestantes = Me.cantidadRegistros
        Call PrintSalesReport()
    End Sub

    Private Function getCoulmnIndexes() As Integer()
        'el UBound devuelve el maximo indice del arreglo, que no es la cantidad de elementos
        'ya que el indice empieza de cero

        Dim arrTitlesCantRows As Integer
        Dim cantArrNotToPrint As Integer
        If columnNotToPrintIndexes Is Nothing Then
            cantArrNotToPrint = -1
            arrTitlesCantRows = Me.cantGridColumns
        Else
            cantArrNotToPrint = UBound(columnNotToPrintIndexes)
            arrTitlesCantRows = Me.cantGridColumns - (cantArrNotToPrint + 1)
        End If

        Dim index As Integer = 0
        arrTitlesCantRows -= 1
        Dim arrTitles(arrTitlesCantRows) As Integer
        For i As Integer = 0 To Me.cantGridColumns - 1
            Dim printColumn As Boolean = True
            For j As Integer = 0 To cantArrNotToPrint
                If i = columnNotToPrintIndexes(j) Then
                    'la columna i no debe imprimirse
                    printColumn = False
                End If
            Next

            If printColumn Then
                arrTitles(index) = i
                index += 1
            End If

        Next


        Return arrTitles
    End Function

    Private Function getColumnsWidth(ByVal arrColumnToPrintIndexes() As Integer) As Single()
        Dim arrTemp(UBound(arrColumnToPrintIndexes)) As Single
        If columnsWidth Is Nothing Then
            'Cargar con los width del estilo
            Dim cStyle As DataGridTableStyle = Me.TableStyles(0)
            Dim cColumn As DataGridTextBoxColumn
            For j As Integer = 0 To UBound(arrColumnToPrintIndexes)
                cColumn = cStyle.GridColumnStyles(arrColumnToPrintIndexes(j))
                arrTemp(j) = cColumn.Width + 10
            Next
        Else
            For j As Integer = 0 To UBound(arrColumnToPrintIndexes)
                arrTemp(j) = columnsWidth(arrColumnToPrintIndexes(j))
            Next
        End If

        Return arrTemp
    End Function

    Private Function getTableWidth(ByVal arrColumnsWidth() As Single) As Single
        Dim widthAcum As Single = 0
        For j As Integer = 0 To UBound(arrColumnsWidth)
            widthAcum += arrColumnsWidth(j)
        Next
        Return widthAcum
    End Function


End Class
