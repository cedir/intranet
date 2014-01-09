Imports CedirNegocios
Public Class ABMObraSocial
    Inherits System.Windows.Forms.Form
    Dim justUpdateObraSocial As Boolean = False
    Friend WithEvents cmbCondicionFiscal As System.Windows.Forms.ComboBox
    Dim cObraSocial As ObraSocial
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cObraSocial = New ObraSocial
    End Sub
    Public Sub New(ByVal obraSocial As ObraSocial)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cObraSocial = obraSocial
        justUpdateObraSocial = True
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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents txtObraSocial As System.Windows.Forms.TextBox
    Friend WithEvents txtDireccion As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtLocalidad As System.Windows.Forms.TextBox
    Friend WithEvents TxtCodigo As System.Windows.Forms.TextBox
    Friend WithEvents txtNroCuit As System.Windows.Forms.TextBox
    Friend WithEvents Nuevo As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents chkPresentaARA As System.Windows.Forms.CheckBox
    Friend WithEvents chkPresentaAMR As System.Windows.Forms.CheckBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtObraSocial = New System.Windows.Forms.TextBox
        Me.txtDireccion = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.txtLocalidad = New System.Windows.Forms.TextBox
        Me.TxtCodigo = New System.Windows.Forms.TextBox
        Me.txtNroCuit = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Nuevo = New System.Windows.Forms.GroupBox
        Me.chkPresentaARA = New System.Windows.Forms.CheckBox
        Me.chkPresentaAMR = New System.Windows.Forms.CheckBox
        Me.Button1 = New System.Windows.Forms.Button
        Me.cmbCondicionFiscal = New System.Windows.Forms.ComboBox
        Me.Nuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtObraSocial
        '
        Me.txtObraSocial.Location = New System.Drawing.Point(104, 40)
        Me.txtObraSocial.Name = "txtObraSocial"
        Me.txtObraSocial.Size = New System.Drawing.Size(248, 20)
        Me.txtObraSocial.TabIndex = 0
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(104, 72)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(160, 20)
        Me.txtDireccion.TabIndex = 1
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(104, 104)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(160, 20)
        Me.txtTel.TabIndex = 2
        '
        'txtLocalidad
        '
        Me.txtLocalidad.Location = New System.Drawing.Point(104, 136)
        Me.txtLocalidad.Name = "txtLocalidad"
        Me.txtLocalidad.Size = New System.Drawing.Size(100, 20)
        Me.txtLocalidad.TabIndex = 3
        '
        'TxtCodigo
        '
        Me.TxtCodigo.Location = New System.Drawing.Point(104, 168)
        Me.TxtCodigo.Name = "TxtCodigo"
        Me.TxtCodigo.Size = New System.Drawing.Size(100, 20)
        Me.TxtCodigo.TabIndex = 4
        '
        'txtNroCuit
        '
        Me.txtNroCuit.Location = New System.Drawing.Point(104, 232)
        Me.txtNroCuit.Name = "txtNroCuit"
        Me.txtNroCuit.Size = New System.Drawing.Size(100, 20)
        Me.txtNroCuit.TabIndex = 6
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(136, 344)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(64, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Aceptar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(48, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 24)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(40, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 24)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Direccion:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(40, 104)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 24)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Telefono:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(40, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 23)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Localidad:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 23)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Código Postal:"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(8, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Condicion Fiscal:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(48, 232)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 23)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Nro. Cuit:"
        '
        'Nuevo
        '
        Me.Nuevo.Controls.Add(Me.cmbCondicionFiscal)
        Me.Nuevo.Controls.Add(Me.chkPresentaARA)
        Me.Nuevo.Controls.Add(Me.chkPresentaAMR)
        Me.Nuevo.Controls.Add(Me.txtDireccion)
        Me.Nuevo.Controls.Add(Me.txtTel)
        Me.Nuevo.Controls.Add(Me.txtLocalidad)
        Me.Nuevo.Controls.Add(Me.TxtCodigo)
        Me.Nuevo.Controls.Add(Me.txtNroCuit)
        Me.Nuevo.Controls.Add(Me.Label1)
        Me.Nuevo.Controls.Add(Me.Label2)
        Me.Nuevo.Controls.Add(Me.Label3)
        Me.Nuevo.Controls.Add(Me.Label4)
        Me.Nuevo.Controls.Add(Me.Label5)
        Me.Nuevo.Controls.Add(Me.Label6)
        Me.Nuevo.Controls.Add(Me.Label7)
        Me.Nuevo.Controls.Add(Me.txtObraSocial)
        Me.Nuevo.Location = New System.Drawing.Point(24, 8)
        Me.Nuevo.Name = "Nuevo"
        Me.Nuevo.Size = New System.Drawing.Size(376, 328)
        Me.Nuevo.TabIndex = 15
        Me.Nuevo.TabStop = False
        Me.Nuevo.Text = "Nuevo"
        '
        'chkPresentaARA
        '
        Me.chkPresentaARA.Location = New System.Drawing.Point(104, 288)
        Me.chkPresentaARA.Name = "chkPresentaARA"
        Me.chkPresentaARA.Size = New System.Drawing.Size(256, 24)
        Me.chkPresentaARA.TabIndex = 16
        Me.chkPresentaARA.Text = "Ordenes de anestesia se presentan por ARA"
        '
        'chkPresentaAMR
        '
        Me.chkPresentaAMR.Location = New System.Drawing.Point(104, 264)
        Me.chkPresentaAMR.Name = "chkPresentaAMR"
        Me.chkPresentaAMR.Size = New System.Drawing.Size(248, 24)
        Me.chkPresentaAMR.TabIndex = 15
        Me.chkPresentaAMR.Text = "Ordenes de estudio se presentan por AMR"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(232, 344)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Cerrar"
        '
        'cmbCondicionFiscal
        '
        Me.cmbCondicionFiscal.FormattingEnabled = True
        Me.cmbCondicionFiscal.Items.AddRange(New Object() {"CONSUMIDOR FINAL", "RESPONSABLE INSCRIPTO", "EXENTO"})
        Me.cmbCondicionFiscal.Location = New System.Drawing.Point(104, 197)
        Me.cmbCondicionFiscal.Name = "cmbCondicionFiscal"
        Me.cmbCondicionFiscal.Size = New System.Drawing.Size(168, 21)
        Me.cmbCondicionFiscal.TabIndex = 17
        '
        'ABMObraSocial
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(424, 384)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Nuevo)
        Me.Controls.Add(Me.btnAceptar)
        Me.Name = "ABMObraSocial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear nueva Obra Social"
        Me.Nuevo.ResumeLayout(False)
        Me.Nuevo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim resp As String

        If txtObraSocial.Text <> "" Then
            cObraSocial.ObraSocial = txtObraSocial.Text
            cObraSocial.direccion = txtDireccion.Text
            cObraSocial.tel = txtTel.Text
            cObraSocial.localidad = txtLocalidad.Text
            cObraSocial.sePresentaPorAMR = chkPresentaAMR.CheckState
            cObraSocial.sePresentaPorARA = chkPresentaARA.CheckState

            Try
                cObraSocial.CodigoPostal = CInt(TxtCodigo.Text)
            Catch ex As Exception
                MsgBox("Código Postal debe ser un dato numérico.", MsgBoxStyle.Critical)
                Exit Sub
            End Try
            cObraSocial.CondicionFiscal = Me.cmbCondicionFiscal.Text
            cObraSocial.nroCuit = txtNroCuit.Text

            If justUpdateObraSocial = False Then
                resp = cObraSocial.AltaObraSocial()
            Else
                resp = cObraSocial.actualizar()
            End If

            If resp = "ok" Then
                MsgBox("La Obra Social se ha agregado con éxito.")
                Me.Close()
            Else : MsgBox("Error: " & resp)
            End If
        Else
            MsgBox("Debe ingresarse un nombre a la Obra Social.", MsgBoxStyle.Critical)
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ABMObraSocial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If justUpdateObraSocial = True Then
            txtObraSocial.Text = cObraSocial.ObraSocial
            txtDireccion.Text = cObraSocial.direccion
            txtTel.Text = cObraSocial.tel
            txtLocalidad.Text = cObraSocial.localidad
            TxtCodigo.Text = cObraSocial.CodigoPostal
            Me.cmbCondicionFiscal.Text = cObraSocial.CondicionFiscal
            txtNroCuit.Text = cObraSocial.nroCuit
            chkPresentaAMR.CheckState = cObraSocial.sePresentaPorAMR
            chkPresentaARA.CheckState = cObraSocial.sePresentaPorARA
            Me.Text = "Modificar Obra Social"
            Nuevo.Text = "Modificar"
        End If

    End Sub
End Class
