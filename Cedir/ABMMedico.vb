Imports CedirNegocios
Imports System.Collections.Generic
Imports Singleton
Public Class ABMMedico
    Inherits System.Windows.Forms.Form

#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New()
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

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
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtNombre As System.Windows.Forms.TextBox
    Friend WithEvents txtApellido As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents btnModificar As System.Windows.Forms.Button
    Friend WithEvents cmbMedicoAct As System.Windows.Forms.ComboBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLoc As System.Windows.Forms.TextBox
    Friend WithEvents txtDir As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.TextBox
    Friend WithEvents txtNroMat As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtApellidoModificar As System.Windows.Forms.TextBox
    Friend WithEvents cmbResponsabilidadFiscalNuevo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmbResponsabilidadFiscalUpdate As System.Windows.Forms.ComboBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtClaveFiscalInsert As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtClaveFiscalUpdate As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtNombreModificar As System.Windows.Forms.TextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox
        Me.txtApellido = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtClaveFiscalInsert = New System.Windows.Forms.TextBox
        Me.cmbResponsabilidadFiscalNuevo = New System.Windows.Forms.ComboBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.TextBox11 = New System.Windows.Forms.TextBox
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.txtLoc = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtDir = New System.Windows.Forms.TextBox
        Me.txtTel = New System.Windows.Forms.TextBox
        Me.txtNroMat = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtClaveFiscalUpdate = New System.Windows.Forms.TextBox
        Me.cmbResponsabilidadFiscalUpdate = New System.Windows.Forms.ComboBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.cmbMedicoAct = New System.Windows.Forms.ComboBox
        Me.btnModificar = New System.Windows.Forms.Button
        Me.TextBox10 = New System.Windows.Forms.TextBox
        Me.TextBox9 = New System.Windows.Forms.TextBox
        Me.TextBox8 = New System.Windows.Forms.TextBox
        Me.TextBox7 = New System.Windows.Forms.TextBox
        Me.txtApellidoModificar = New System.Windows.Forms.TextBox
        Me.txtNombreModificar = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(129, 56)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(152, 20)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido
        '
        Me.txtApellido.Location = New System.Drawing.Point(129, 88)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(152, 20)
        Me.txtApellido.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(32, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(32, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Apellido:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txtClaveFiscalInsert)
        Me.GroupBox1.Controls.Add(Me.cmbResponsabilidadFiscalNuevo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.TextBox11)
        Me.GroupBox1.Controls.Add(Me.btnAceptar)
        Me.GroupBox1.Controls.Add(Me.txtLoc)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtDir)
        Me.GroupBox1.Controls.Add(Me.txtTel)
        Me.GroupBox1.Controls.Add(Me.txtNroMat)
        Me.GroupBox1.Controls.Add(Me.txtNombre)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtApellido)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 24)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 407)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo"
        '
        'Label17
        '
        Me.Label17.Location = New System.Drawing.Point(19, 306)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(74, 20)
        Me.Label17.TabIndex = 24
        Me.Label17.Text = "Clave Fiscal:"
        '
        'txtClaveFiscalInsert
        '
        Me.txtClaveFiscalInsert.Location = New System.Drawing.Point(129, 306)
        Me.txtClaveFiscalInsert.Name = "txtClaveFiscalInsert"
        Me.txtClaveFiscalInsert.Size = New System.Drawing.Size(152, 20)
        Me.txtClaveFiscalInsert.TabIndex = 23
        '
        'cmbResponsabilidadFiscalNuevo
        '
        Me.cmbResponsabilidadFiscalNuevo.Location = New System.Drawing.Point(129, 274)
        Me.cmbResponsabilidadFiscalNuevo.Name = "cmbResponsabilidadFiscalNuevo"
        Me.cmbResponsabilidadFiscalNuevo.Size = New System.Drawing.Size(152, 21)
        Me.cmbResponsabilidadFiscalNuevo.TabIndex = 22
        '
        'Label15
        '
        Me.Label15.Location = New System.Drawing.Point(19, 274)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(104, 32)
        Me.Label15.TabIndex = 17
        Me.Label15.Text = "Responsabilidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fiscal"
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(48, 248)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 16)
        Me.Label13.TabIndex = 15
        Me.Label13.Text = "Mail:"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(129, 248)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(152, 20)
        Me.TextBox11.TabIndex = 14
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(90, 345)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 13
        Me.btnAceptar.Text = "Aceptar"
        '
        'txtLoc
        '
        Me.txtLoc.Location = New System.Drawing.Point(129, 216)
        Me.txtLoc.Name = "txtLoc"
        Me.txtLoc.Size = New System.Drawing.Size(152, 20)
        Me.txtLoc.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(24, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Localidad:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(24, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Dirección:"
        '
        'txtDir
        '
        Me.txtDir.Location = New System.Drawing.Point(129, 184)
        Me.txtDir.Name = "txtDir"
        Me.txtDir.Size = New System.Drawing.Size(152, 20)
        Me.txtDir.TabIndex = 7
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(129, 152)
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(120, 20)
        Me.txtTel.TabIndex = 6
        '
        'txtNroMat
        '
        Me.txtNroMat.Location = New System.Drawing.Point(129, 120)
        Me.txtNroMat.Name = "txtNroMat"
        Me.txtNroMat.Size = New System.Drawing.Size(120, 20)
        Me.txtNroMat.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(16, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Nro de Mat. :"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(48, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 23)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Tel:"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(32, 457)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Cerrar"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txtClaveFiscalUpdate)
        Me.GroupBox2.Controls.Add(Me.cmbResponsabilidadFiscalUpdate)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.cmbMedicoAct)
        Me.GroupBox2.Controls.Add(Me.btnModificar)
        Me.GroupBox2.Controls.Add(Me.TextBox10)
        Me.GroupBox2.Controls.Add(Me.TextBox9)
        Me.GroupBox2.Controls.Add(Me.TextBox8)
        Me.GroupBox2.Controls.Add(Me.TextBox7)
        Me.GroupBox2.Controls.Add(Me.txtApellidoModificar)
        Me.GroupBox2.Controls.Add(Me.txtNombreModificar)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Location = New System.Drawing.Point(372, 24)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(382, 407)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Modificar existente"
        '
        'Label19
        '
        Me.Label19.Location = New System.Drawing.Point(6, 309)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(74, 20)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "Clave Fiscal:"
        '
        'txtClaveFiscalUpdate
        '
        Me.txtClaveFiscalUpdate.Location = New System.Drawing.Point(116, 306)
        Me.txtClaveFiscalUpdate.Name = "txtClaveFiscalUpdate"
        Me.txtClaveFiscalUpdate.Size = New System.Drawing.Size(152, 20)
        Me.txtClaveFiscalUpdate.TabIndex = 25
        '
        'cmbResponsabilidadFiscalUpdate
        '
        Me.cmbResponsabilidadFiscalUpdate.Location = New System.Drawing.Point(118, 277)
        Me.cmbResponsabilidadFiscalUpdate.Name = "cmbResponsabilidadFiscalUpdate"
        Me.cmbResponsabilidadFiscalUpdate.Size = New System.Drawing.Size(152, 21)
        Me.cmbResponsabilidadFiscalUpdate.TabIndex = 24
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(118, 248)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 20)
        Me.TextBox1.TabIndex = 21
        '
        'cmbMedicoAct
        '
        Me.cmbMedicoAct.Location = New System.Drawing.Point(118, 19)
        Me.cmbMedicoAct.Name = "cmbMedicoAct"
        Me.cmbMedicoAct.Size = New System.Drawing.Size(257, 21)
        Me.cmbMedicoAct.TabIndex = 20
        '
        'btnModificar
        '
        Me.btnModificar.Location = New System.Drawing.Point(118, 345)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(75, 23)
        Me.btnModificar.TabIndex = 19
        Me.btnModificar.Text = "Modificar"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(118, 216)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(184, 20)
        Me.TextBox10.TabIndex = 5
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(118, 184)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(184, 20)
        Me.TextBox9.TabIndex = 4
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(118, 152)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(136, 20)
        Me.TextBox8.TabIndex = 3
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(118, 120)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(136, 20)
        Me.TextBox7.TabIndex = 2
        '
        'txtApellidoModificar
        '
        Me.txtApellidoModificar.Location = New System.Drawing.Point(118, 88)
        Me.txtApellidoModificar.Name = "txtApellidoModificar"
        Me.txtApellidoModificar.Size = New System.Drawing.Size(184, 20)
        Me.txtApellidoModificar.TabIndex = 1
        '
        'txtNombreModificar
        '
        Me.txtNombreModificar.Location = New System.Drawing.Point(118, 56)
        Me.txtNombreModificar.Name = "txtNombreModificar"
        Me.txtNombreModificar.Size = New System.Drawing.Size(184, 20)
        Me.txtNombreModificar.TabIndex = 0
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(16, 184)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 23)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Dirección:"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(24, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 23)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Nombre:"
        '
        'Label11
        '
        Me.Label11.Location = New System.Drawing.Point(8, 120)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(72, 16)
        Me.Label11.TabIndex = 15
        Me.Label11.Text = "Nro de Mat. :"
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(24, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 23)
        Me.Label10.TabIndex = 14
        Me.Label10.Text = "Apellido:"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(16, 216)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Localidad:"
        '
        'Label12
        '
        Me.Label12.Location = New System.Drawing.Point(40, 152)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(32, 23)
        Me.Label12.TabIndex = 16
        Me.Label12.Text = "Tel:"
        '
        'Label14
        '
        Me.Label14.Location = New System.Drawing.Point(32, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(32, 16)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Mail:"
        '
        'Label16
        '
        Me.Label16.Location = New System.Drawing.Point(6, 274)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(104, 32)
        Me.Label16.TabIndex = 25
        Me.Label16.Text = "Responsabilidad " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Fiscal"
        '
        'ABMMedico
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(766, 505)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ABMMedico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Crear o Modificar Médicos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim catalogoMedicos As New CatalogoDeMedicos
    Dim arrMedicos As ArrayList
    Dim gravados As New List(Of Gravado)


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub
    Private Sub ABMMedico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CargarCombo()
        CargarComboResponsabilidadFiscal()
        Me.cargarDatosMedicoSeleccionado()
    End Sub
    Sub CargarComboResponsabilidadFiscal()
        Me.cmbResponsabilidadFiscalNuevo.Items.Add("MONOTRIBUTO")
        Me.cmbResponsabilidadFiscalNuevo.Items.Add("INSCRIPTO")
        Me.cmbResponsabilidadFiscalNuevo.SelectedIndex = 0

        Me.cmbResponsabilidadFiscalUpdate.Items.Add("MONOTRIBUTO")
        Me.cmbResponsabilidadFiscalUpdate.Items.Add("INSCRIPTO")

    End Sub
    Sub CargarCombo()
        Dim i As Integer
        arrMedicos = catalogoMedicos.TodosLosMedicos()

        cmbMedicoAct.Items.Clear()
        Dim med As Medico
        For i = 0 To arrMedicos.Count - 1
            med = arrMedicos(i)
            cmbMedicoAct.Items.Add(med.apellido + ", " + med.nombre)

        Next
        cmbMedicoAct.SelectedIndex = 0
    End Sub

    Private Sub cmbMedicoAct_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMedicoAct.SelectedIndexChanged
        cargarDatosMedicoSeleccionado()
    End Sub
    Sub cargarDatosMedicoSeleccionado()
        Dim med As Medico = arrMedicos(cmbMedicoAct.SelectedIndex)
        txtApellidoModificar.Text = med.apellido
        txtNombreModificar.Text = med.nombre
        TextBox7.Text = med.nroMatricula
        TextBox8.Text = med.telefono
        TextBox9.Text = med.direccion
        TextBox10.Text = med.localidad
        TextBox1.Text = med.mail
        Me.txtClaveFiscalUpdate.Text = med.claveFiscal
        Me.cmbResponsabilidadFiscalUpdate.SelectedItem = med.responsabilidadFiscal

    End Sub


    Private Sub btnAceptar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click
        Dim resp As String
        If validateData(False) Then
            Dim m As New Medico
            m.nombre = txtNombre.Text
            m.apellido = txtApellido.Text
            m.direccion = txtDir.Text
            m.localidad = txtLoc.Text
            m.nroMatricula = txtNroMat.Text
            m.telefono = txtTel.Text
            m.mail = (TextBox11.Text)
            m.responsabilidadFiscal = Me.cmbResponsabilidadFiscalNuevo.SelectedItem
            m.claveFiscal = Me.txtClaveFiscalInsert.Text
            resp = m.crear()
            If resp = "ok" Then
                MsgBox("El Médico ha sido creado")
                txtNombre.Text = ""
                txtApellido.Text = ""
                txtDir.Text = ""
                txtLoc.Text = ""
                txtNroMat.Text = ""
                txtTel.Text = ""
                TextBox11.Text = ""
                CargarCombo()
            Else
                'error
                MsgBox("Error: " & resp)
            End If
        End If
    End Sub

    Private Sub btnModificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModificar.Click

        If validateData(True) Then
            Dim m As Medico
            Dim resp As String
            m = arrMedicos(cmbMedicoAct.SelectedIndex)
            m.nombre = txtNombreModificar.Text
            m.apellido = txtApellidoModificar.Text
            m.direccion = TextBox9.Text
            m.localidad = TextBox10.Text
            m.nroMatricula = TextBox7.Text
            m.telefono = TextBox8.Text
            m.mail = TextBox1.Text
            m.responsabilidadFiscal = Me.cmbResponsabilidadFiscalUpdate.SelectedItem
            m.claveFiscal = Me.txtClaveFiscalUpdate.Text
            resp = m.actualizar()
            If resp = "ok" Then
                MsgBox("El médico se ha modificado con éxito")
                cmbMedicoAct.Items(cmbMedicoAct.SelectedIndex) = txtApellidoModificar.Text & ", " & txtNombreModificar.Text
            Else
                MsgBox("Se ha produciodo el sig. error: " & resp)
            End If
        End If

    End Sub

    Private Function validateData(ByVal esActualizar As Boolean) As Boolean

        If esActualizar Then
            If txtNombreModificar.Text = "" Then
                MsgBox("El nombre del médico no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
            If txtApellidoModificar.Text = "" Then
                MsgBox("El apellido del médico no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If

        Else
            If txtNombre.Text = "" Then
                MsgBox("El nombre del médico no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
            If txtApellido.Text = "" Then
                MsgBox("El apellido del médico no puede estar vacío", MsgBoxStyle.Critical)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub cmbResponsabilidadIVANuevo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbResponsabilidadFiscalNuevo.SelectedIndexChanged
        ' MessageBox.Show(TryCast(Me.cmbResponsabilidadIVANuevo.SelectedItem, Gravado).descripcion)
    End Sub

    Private Sub cmbResponsabilidadIVAUpdate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbResponsabilidadFiscalUpdate.SelectedIndexChanged
        ' MessageBox.Show(TryCast(Me.cmbResponsabilidadIVAUpdate.SelectedItem, Gravado).descripcion)
    End Sub

    Private Sub cmbResponsabilidadIVAUpdate_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbResponsabilidadFiscalUpdate.SelectedValueChanged
        ' MessageBox.Show(TryCast(Me.cmbResponsabilidadIVAUpdate.SelectedItem, Gravado).descripcion)
    End Sub
End Class
