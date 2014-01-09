
Imports CedirNegocios
Imports System.Drawing.Printing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
'Imports angGoGo.PhotoController
Public Class VisorDeImagenes
    Inherits System.Windows.Forms.Form
    Dim currentEstudio As Estudio
    Dim codigoImagen As String
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByRef est As Estudio)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()
        currentEstudio = est
        'Agregar cualquier inicialización después de la llamada a InitializeComponent()

    End Sub

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms requiere el siguiente procedimiento
    'Puede modificarse utilizando el Diseñador de Windows Forms. 
    'No lo modifique con el editor de código.
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcodigo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCambiar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.PictureBox2 = New System.Windows.Forms.PictureBox
        Me.PictureBox3 = New System.Windows.Forms.PictureBox
        Me.PictureBox4 = New System.Windows.Forms.PictureBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtcodigo = New System.Windows.Forms.TextBox
        Me.btnCambiar = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(24, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(248, 192)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(328, 88)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(248, 192)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Location = New System.Drawing.Point(24, 336)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 192)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Location = New System.Drawing.Point(328, 336)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(248, 192)
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(328, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(248, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(24, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(248, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(328, 304)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(248, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Label4"
        '
        'txtcodigo
        '
        Me.txtcodigo.Location = New System.Drawing.Point(72, 16)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(136, 20)
        Me.txtcodigo.TabIndex = 8
        Me.txtcodigo.Text = ""
        '
        'btnCambiar
        '
        Me.btnCambiar.Location = New System.Drawing.Point(240, 16)
        Me.btnCambiar.Name = "btnCambiar"
        Me.btnCambiar.TabIndex = 9
        Me.btnCambiar.Text = "Cambiar"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Código: "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(24, 544)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Imprimir"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(120, 544)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.TabIndex = 12
        Me.btnCerrar.Text = "Cerrar"
        '
        'VisorDeImagenes
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(640, 574)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnCambiar)
        Me.Controls.Add(Me.txtcodigo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "VisorDeImagenes"
        Me.Text = "VisorDeImagenes"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub VisorDeImagenes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        codigoImagen = currentEstudio.codigoImagen
        txtcodigo.Text = codigoImagen

        cargarImagenes()
    End Sub

    
    Private Sub btnCambiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCambiar.Click
        codigoImagen = txtcodigo.Text
        currentEstudio.codigoImagen = codigoImagen

        cargarImagenes()
    End Sub
    Function ThumbnailCallback() As Boolean
        Return False
    End Function
    Private Sub cargarImagenes()
        Dim myP As Drawing.Image
        Dim currentPath As String = Path.GetPathRoot("\")
        Dim mPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim mAppPath As String = Path.GetFullPath(mPath)

        Dim pbzm As New PictureBoxSizeMode
        'pbzm.StretchImage.StretchImage
        PictureBox1.SizeMode = pbzm.StretchImage
        PictureBox2.SizeMode = pbzm.StretchImage
        PictureBox3.SizeMode = pbzm.StretchImage
        PictureBox4.SizeMode = pbzm.StretchImage

        
        Try
            Label1.Text = "c:\Fotos\" & codigoImagen & "1.jpg"
            PictureBox1.Image = Image.FromFile("c:\Fotos\" & codigoImagen & "1.jpg")

            
        Catch ex As Exception

            PictureBox1.Image = Image.FromFile("c:\Fotos\imagenNoDisponible.jpg")
        End Try

        Try
            Label2.Text = "c:\Fotos\" & codigoImagen & "2.jpg"
            PictureBox2.Image = Image.FromFile("c:\Fotos\" & codigoImagen & "2.jpg")
        Catch ex As Exception
            PictureBox2.Image = Image.FromFile("c:\Fotos\imagenNoDisponible.jpg")
        End Try


        Try
            Label3.Text = "c:\Fotos\" & codigoImagen & "3.jpg"
            PictureBox3.Image = Image.FromFile("c:\Fotos\" & codigoImagen & "3.jpg")
        Catch ex As Exception

            PictureBox3.Image = Image.FromFile("c:\Fotos\imagenNoDisponible.jpg")
        End Try
        Try
            Label4.Text = "c:\Fotos\" & codigoImagen & "4.jpg"
            PictureBox4.Image = Image.FromFile("c:\Fotos\" & codigoImagen & "4.jpg")
        Catch ex As Exception

            PictureBox4.Image = Image.FromFile("c:\Fotos\imagenNoDisponible.jpg")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim imprimirImagenes As New PrintDocument
        AddHandler imprimirImagenes.PrintPage, AddressOf PrintImagenes


        Dim pss As New PrintDialog
        Dim bp As DialogResult
        pss.Document = imprimirImagenes
        bp = pss.ShowDialog

        If bp = DialogResult.OK Then
            'SalesReport.PrinterSettings.Copies = 3

            pss.Document = imprimirImagenes
            imprimirImagenes.Print()
        End If
    End Sub

    Sub PrintImagenes(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        'IMPRIMIR IMAGENES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        Dim width As Single = 500.0F
        Dim height As Single = 150.0F
        Dim drawRect As New RectangleF(100, 100, width, height)

        Dim objImage1 As Image
        Dim objImage2 As Image
        Dim objImage3 As Image
        Dim objImage4 As Image
        Dim units As GraphicsUnit = GraphicsUnit.Pixel

        Dim objCallback As System.Drawing.Image.GetThumbnailImageAbort = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)

        Dim titulo As New Font("Arial", 15, FontStyle.Regular)
        drawRect.Y = 280
        e.Graphics.DrawString("Práctica: " & currentEstudio.practica.Estudio, titulo, Brushes.Black, drawRect)

        drawRect.Y = 310
        e.Graphics.DrawString("Paciente: " & currentEstudio.paciente.apellido & ", " & currentEstudio.paciente.nombres, titulo, Brushes.Black, drawRect)

        'Dim destRect1 As New Rectangle(150, 350, 150, 150)
        Try
            objImage1 = objImage1.FromFile("c:\Fotos\" & currentEstudio.codigoImagen & "1.jpg")
            'objImage1 = objImage1.GetThumbnailImage(100, 100, objCallback, IntPtr.Zero)
            Dim imgTest As Image
            'Dim objPC As New angGoGo.PhotoController.Controller(objImage1)
            'imgTest = objPC.Resize(150, 150)
            'e.Graphics.DrawImage(imgTest, 300, 350)
            'e.Graphics.DrawImage(objImage1, destRect1, 100, 100, 150.0F, 150.0F, units)
        Catch ex As FileNotFoundException
            'MsgBox("caca")
        End Try

        Try
            objImage2 = objImage2.FromFile("c:\Fotos\" & currentEstudio.codigoImagen & "2.jpg")
            objImage2 = objImage2.GetThumbnailImage(100, 100, objCallback, IntPtr.Zero)
            e.Graphics.DrawImageUnscaled(objImage2, 500, 350)
        Catch ex As FileNotFoundException

        End Try

        Try
            objImage3 = objImage3.FromFile("c:\Fotos\" & currentEstudio.codigoImagen & "3.jpg")
            objImage3 = objImage3.GetThumbnailImage(100, 100, objCallback, IntPtr.Zero)
            e.Graphics.DrawImageUnscaled(objImage3, 300, 600)
        Catch ex As FileNotFoundException

        End Try

        Try
            objImage4 = objImage4.FromFile("c:\Fotos\" & currentEstudio.codigoImagen & "4.jpg")
            objImage4 = objImage4.GetThumbnailImage(100, 100, objCallback, IntPtr.Zero)
            e.Graphics.DrawImageUnscaled(objImage4, 500, 600)
        Catch ex As FileNotFoundException

        End Try






    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub


End Class
