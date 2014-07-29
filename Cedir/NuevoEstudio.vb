Imports CedirNegocios
Imports System.Drawing.Printing
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO
Imports System.Text.RegularExpressions
Imports Microsoft.Office.Core
Imports Microsoft.Office
Imports Microsoft.Office.Interop
'Este formulario da de alta un estudio, pero tambien si el estudio ya ha sido creado, 
'carga los valores con los datos ya ingresados y permite modificarlos
'Pero como saber si se esta por crear un estudio o modificar uno????
'Simple, si un estudio se esta por crear, algunos valores como informe, motivoEstudio,
'idMedico solicitante o actuante, son vacios o nulos (los dos ultimos valores mas que nada).
Public Class NuevoEstudio
    Inherits System.Windows.Forms.Form

    Dim currentEst As Estudio
    Dim saveChanges As Boolean = False
    Dim defaultInforme As String
    Dim defaultMotivo As String
    Friend WithEvents btnOrtografia As System.Windows.Forms.Button
    Friend WithEvents btnGramatica As System.Windows.Forms.Button
    Friend WithEvents TxtInforme As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtLink As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnLink As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Dim pAddFromSelectedEstudio As Boolean = False

#Region " Constructor"

    Public Sub New(ByVal es As Estudio)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        currentEst = es
        defaultInforme = currentEst.informe
        defaultMotivo = currentEst.motivoEstudio
    End Sub
    Public Sub New(ByVal es As Estudio, ByVal addFromSelectedEstudio As Boolean)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        currentEst = es
        defaultInforme = currentEst.informe
        defaultMotivo = currentEst.motivoEstudio
        pAddFromSelectedEstudio = addFromSelectedEstudio

    End Sub


#End Region

#Region " Código generado por el Diseñador de Windows Forms "

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
    Friend WithEvents TxtMotivo As System.Windows.Forms.TextBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents lblDni As System.Windows.Forms.Label
    Friend WithEvents lblNombre As System.Windows.Forms.Label
    Friend WithEvents cmbEstudio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbObraSocial As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbMedicoAct As System.Windows.Forms.ComboBox
    Friend WithEvents cmbMedicoSol As System.Windows.Forms.ComboBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnFotos As System.Windows.Forms.Button
    Friend WithEvents txtNroOrden As System.Windows.Forms.TextBox
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbAnestesistas As System.Windows.Forms.ComboBox
    Friend WithEvents dtpFechaEstudio As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnAltaNormal As System.Windows.Forms.Button
    Friend WithEvents btnGastritis As System.Windows.Forms.Button
    Friend WithEvents btnColonoNormal As System.Windows.Forms.Button
    Friend WithEvents btnAgregarPolipectomia As System.Windows.Forms.Button
    Friend WithEvents btnColangioNormal As System.Windows.Forms.Button
    Friend WithEvents btnColangioConCalclulo As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.lblDni = New System.Windows.Forms.Label
        Me.TxtMotivo = New System.Windows.Forms.TextBox
        Me.cmbEstudio = New System.Windows.Forms.ComboBox
        Me.cmbObraSocial = New System.Windows.Forms.ComboBox
        Me.cmbMedicoAct = New System.Windows.Forms.ComboBox
        Me.cmbMedicoSol = New System.Windows.Forms.ComboBox
        Me.lblNombre = New System.Windows.Forms.Label
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.Label8 = New System.Windows.Forms.Label
        Me.btnFotos = New System.Windows.Forms.Button
        Me.txtNroOrden = New System.Windows.Forms.TextBox
        Me.lblFecha = New System.Windows.Forms.Label
        Me.cmbAnestesistas = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.dtpFechaEstudio = New System.Windows.Forms.DateTimePicker
        Me.btnAltaNormal = New System.Windows.Forms.Button
        Me.btnGastritis = New System.Windows.Forms.Button
        Me.btnColonoNormal = New System.Windows.Forms.Button
        Me.btnAgregarPolipectomia = New System.Windows.Forms.Button
        Me.btnColangioNormal = New System.Windows.Forms.Button
        Me.btnColangioConCalclulo = New System.Windows.Forms.Button
        Me.btnOrtografia = New System.Windows.Forms.Button
        Me.btnGramatica = New System.Windows.Forms.Button
        Me.TxtInforme = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtLink = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btnLink = New System.Windows.Forms.Button
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblDni
        '
        Me.lblDni.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDni.Location = New System.Drawing.Point(10, 20)
        Me.lblDni.Name = "lblDni"
        Me.lblDni.Size = New System.Drawing.Size(272, 16)
        Me.lblDni.TabIndex = 0
        Me.lblDni.Text = "Dni"
        '
        'TxtMotivo
        '
        Me.TxtMotivo.Location = New System.Drawing.Point(144, 29)
        Me.TxtMotivo.Multiline = True
        Me.TxtMotivo.Name = "TxtMotivo"
        Me.TxtMotivo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtMotivo.Size = New System.Drawing.Size(496, 40)
        Me.TxtMotivo.TabIndex = 5
        '
        'cmbEstudio
        '
        Me.cmbEstudio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbEstudio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbEstudio.Location = New System.Drawing.Point(93, 16)
        Me.cmbEstudio.Name = "cmbEstudio"
        Me.cmbEstudio.Size = New System.Drawing.Size(378, 21)
        Me.cmbEstudio.TabIndex = 0
        '
        'cmbObraSocial
        '
        Me.cmbObraSocial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbObraSocial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbObraSocial.Location = New System.Drawing.Point(93, 56)
        Me.cmbObraSocial.Name = "cmbObraSocial"
        Me.cmbObraSocial.Size = New System.Drawing.Size(378, 21)
        Me.cmbObraSocial.TabIndex = 1
        '
        'cmbMedicoAct
        '
        Me.cmbMedicoAct.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicoAct.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicoAct.Location = New System.Drawing.Point(599, 16)
        Me.cmbMedicoAct.Name = "cmbMedicoAct"
        Me.cmbMedicoAct.Size = New System.Drawing.Size(168, 21)
        Me.cmbMedicoAct.TabIndex = 2
        '
        'cmbMedicoSol
        '
        Me.cmbMedicoSol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbMedicoSol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbMedicoSol.Location = New System.Drawing.Point(599, 56)
        Me.cmbMedicoSol.Name = "cmbMedicoSol"
        Me.cmbMedicoSol.Size = New System.Drawing.Size(168, 21)
        Me.cmbMedicoSol.TabIndex = 3
        '
        'lblNombre
        '
        Me.lblNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNombre.Location = New System.Drawing.Point(10, 44)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(440, 16)
        Me.lblNombre.TabIndex = 9
        Me.lblNombre.Text = "Nombre"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(6, 19)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 7
        Me.btnAceptar.Text = "Guardar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(15, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Estudio:"
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(15, 59)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Obra Social:"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(263, 19)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 24)
        Me.btnCerrar.TabIndex = 14
        Me.btnCerrar.TabStop = False
        Me.btnCerrar.Text = "Cerrar"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(479, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Médico Actuante:"
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(479, 56)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 24)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Médico Solicitante:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(336, 13)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Motivo del Estudio"
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(360, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Informe"
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(94, 19)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(72, 24)
        Me.btnImprimir.TabIndex = 8
        Me.btnImprimir.Text = "Imprimir"
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(141, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(76, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Nro de Orden:"
        '
        'btnFotos
        '
        Me.btnFotos.Location = New System.Drawing.Point(182, 19)
        Me.btnFotos.Name = "btnFotos"
        Me.btnFotos.Size = New System.Drawing.Size(75, 23)
        Me.btnFotos.TabIndex = 9
        Me.btnFotos.Text = "Fotos"
        '
        'txtNroOrden
        '
        Me.txtNroOrden.Location = New System.Drawing.Point(232, 13)
        Me.txtNroOrden.Name = "txtNroOrden"
        Me.txtNroOrden.Size = New System.Drawing.Size(100, 20)
        Me.txtNroOrden.TabIndex = 29
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(624, 22)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(40, 14)
        Me.lblFecha.TabIndex = 30
        Me.lblFecha.Text = "Fecha:"
        '
        'cmbAnestesistas
        '
        Me.cmbAnestesistas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cmbAnestesistas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbAnestesistas.Location = New System.Drawing.Point(599, 94)
        Me.cmbAnestesistas.Name = "cmbAnestesistas"
        Me.cmbAnestesistas.Size = New System.Drawing.Size(168, 21)
        Me.cmbAnestesistas.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(479, 94)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(120, 16)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Médico Anestesiólogo:"
        '
        'dtpFechaEstudio
        '
        Me.dtpFechaEstudio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEstudio.Location = New System.Drawing.Point(670, 20)
        Me.dtpFechaEstudio.Name = "dtpFechaEstudio"
        Me.dtpFechaEstudio.Size = New System.Drawing.Size(96, 20)
        Me.dtpFechaEstudio.TabIndex = 33
        Me.dtpFechaEstudio.TabStop = False
        '
        'btnAltaNormal
        '
        Me.btnAltaNormal.Location = New System.Drawing.Point(6, 93)
        Me.btnAltaNormal.Name = "btnAltaNormal"
        Me.btnAltaNormal.Size = New System.Drawing.Size(128, 24)
        Me.btnAltaNormal.TabIndex = 34
        Me.btnAltaNormal.Text = "Alta Normal -->"
        '
        'btnGastritis
        '
        Me.btnGastritis.Location = New System.Drawing.Point(6, 125)
        Me.btnGastritis.Name = "btnGastritis"
        Me.btnGastritis.Size = New System.Drawing.Size(128, 24)
        Me.btnGastritis.TabIndex = 35
        Me.btnGastritis.Text = "Gastritis no erosiva -->"
        '
        'btnColonoNormal
        '
        Me.btnColonoNormal.Location = New System.Drawing.Point(6, 157)
        Me.btnColonoNormal.Name = "btnColonoNormal"
        Me.btnColonoNormal.Size = New System.Drawing.Size(128, 24)
        Me.btnColonoNormal.TabIndex = 36
        Me.btnColonoNormal.TabStop = False
        Me.btnColonoNormal.Text = "Colono Normal -->"
        '
        'btnAgregarPolipectomia
        '
        Me.btnAgregarPolipectomia.Location = New System.Drawing.Point(654, 93)
        Me.btnAgregarPolipectomia.Name = "btnAgregarPolipectomia"
        Me.btnAgregarPolipectomia.Size = New System.Drawing.Size(112, 23)
        Me.btnAgregarPolipectomia.TabIndex = 37
        Me.btnAgregarPolipectomia.TabStop = False
        Me.btnAgregarPolipectomia.Text = "Añadir polipectomia"
        '
        'btnColangioNormal
        '
        Me.btnColangioNormal.Location = New System.Drawing.Point(14, 93)
        Me.btnColangioNormal.Name = "btnColangioNormal"
        Me.btnColangioNormal.Size = New System.Drawing.Size(120, 23)
        Me.btnColangioNormal.TabIndex = 38
        Me.btnColangioNormal.TabStop = False
        Me.btnColangioNormal.Text = "Colangio Normal"
        '
        'btnColangioConCalclulo
        '
        Me.btnColangioConCalclulo.Location = New System.Drawing.Point(14, 125)
        Me.btnColangioConCalclulo.Name = "btnColangioConCalclulo"
        Me.btnColangioConCalclulo.Size = New System.Drawing.Size(120, 23)
        Me.btnColangioConCalclulo.TabIndex = 39
        Me.btnColangioConCalclulo.TabStop = False
        Me.btnColangioConCalclulo.Text = "Colangio con Cálculo"
        '
        'btnOrtografia
        '
        Me.btnOrtografia.Location = New System.Drawing.Point(654, 126)
        Me.btnOrtografia.Name = "btnOrtografia"
        Me.btnOrtografia.Size = New System.Drawing.Size(112, 23)
        Me.btnOrtografia.TabIndex = 40
        Me.btnOrtografia.TabStop = False
        Me.btnOrtografia.Text = "Revisar ortografía"
        Me.btnOrtografia.UseVisualStyleBackColor = True
        Me.btnOrtografia.Visible = False
        '
        'btnGramatica
        '
        Me.btnGramatica.Location = New System.Drawing.Point(654, 155)
        Me.btnGramatica.Name = "btnGramatica"
        Me.btnGramatica.Size = New System.Drawing.Size(112, 23)
        Me.btnGramatica.TabIndex = 41
        Me.btnGramatica.TabStop = False
        Me.btnGramatica.Text = "Revisar gramatica"
        Me.btnGramatica.UseVisualStyleBackColor = True
        Me.btnGramatica.Visible = False
        '
        'TxtInforme
        '
        Me.TxtInforme.Location = New System.Drawing.Point(144, 93)
        Me.TxtInforme.Multiline = True
        Me.TxtInforme.Name = "TxtInforme"
        Me.TxtInforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TxtInforme.Size = New System.Drawing.Size(496, 110)
        Me.TxtInforme.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblDni)
        Me.GroupBox1.Controls.Add(Me.lblNombre)
        Me.GroupBox1.Controls.Add(Me.lblFecha)
        Me.GroupBox1.Controls.Add(Me.dtpFechaEstudio)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(776, 83)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos del paciente"
        '
        'txtLink
        '
        Me.txtLink.Location = New System.Drawing.Point(232, 39)
        Me.txtLink.MaxLength = 256
        Me.txtLink.Name = "txtLink"
        Me.txtLink.Size = New System.Drawing.Size(288, 20)
        Me.txtLink.TabIndex = 43
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbEstudio)
        Me.GroupBox2.Controls.Add(Me.cmbMedicoAct)
        Me.GroupBox2.Controls.Add(Me.cmbMedicoSol)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbObraSocial)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmbAnestesistas)
        Me.GroupBox2.Location = New System.Drawing.Point(9, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(776, 128)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos generales"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.btnColonoNormal)
        Me.GroupBox3.Controls.Add(Me.btnGastritis)
        Me.GroupBox3.Controls.Add(Me.btnAltaNormal)
        Me.GroupBox3.Controls.Add(Me.btnGramatica)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.btnOrtografia)
        Me.GroupBox3.Controls.Add(Me.TxtMotivo)
        Me.GroupBox3.Controls.Add(Me.btnColangioConCalclulo)
        Me.GroupBox3.Controls.Add(Me.TxtInforme)
        Me.GroupBox3.Controls.Add(Me.btnColangioNormal)
        Me.GroupBox3.Controls.Add(Me.btnAgregarPolipectomia)
        Me.GroupBox3.Location = New System.Drawing.Point(9, 225)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(776, 209)
        Me.GroupBox3.TabIndex = 45
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btnLink)
        Me.GroupBox4.Controls.Add(Me.Label8)
        Me.GroupBox4.Controls.Add(Me.txtNroOrden)
        Me.GroupBox4.Controls.Add(Me.txtLink)
        Me.GroupBox4.Location = New System.Drawing.Point(9, 440)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(776, 74)
        Me.GroupBox4.TabIndex = 46
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        '
        'btnLink
        '
        Me.btnLink.Location = New System.Drawing.Point(142, 36)
        Me.btnLink.Name = "btnLink"
        Me.btnLink.Size = New System.Drawing.Size(86, 23)
        Me.btnLink.TabIndex = 47
        Me.btnLink.Text = "Pegar enlace"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btnAceptar)
        Me.GroupBox5.Controls.Add(Me.btnCerrar)
        Me.GroupBox5.Controls.Add(Me.btnImprimir)
        Me.GroupBox5.Controls.Add(Me.btnFotos)
        Me.GroupBox5.Location = New System.Drawing.Point(221, 520)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(343, 53)
        Me.GroupBox5.TabIndex = 47
        Me.GroupBox5.TabStop = False
        '
        'NuevoEstudio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(792, 582)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NuevoEstudio"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrMedicos As New ArrayList
    Dim arrObraSocial As New ArrayList
    Dim arrAnestesistas As ArrayList
    Dim arrPracticas As New ArrayList
    Private Sub NuevoEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cargarCombos()
        cargarDatos()
        Dim arr As String()
        'Dim r As New Regex("(,)")
        'aca va a ver que aplicar regulars
        'arr = r.Split(currentEst.NombrePaciente.ToLower)
        currentEst.codigoImagen = currentEst.paciente.apellido
        btnFotos.Visible = False
        restrictUpdate()

        btnAgregarPolipectomia.Visible = False

        Dim sSecurity As Security = Security.GetInstance()
        Dim cUsuario As Usuario = sSecurity.getLoggedUser
        If IsNothing(cUsuario) = False Then
            If (cUsuario.belongToGroup("administrador") Or cUsuario.belongToGroup("facturacion")) And currentEst.practica.Estudio <> "" Then  'solo en modificar
                If currentEst.practica.idEstudio = 1 Then
                    btnAgregarPolipectomia.Visible = True
                    btnAgregarPolipectomia.Text = "Añadir polipectomia gastrica"
                ElseIf currentEst.practica.idEstudio = 2 Then
                    btnAgregarPolipectomia.Visible = True
                    btnAgregarPolipectomia.Text = "Añadir polipectomia colónica"
                Else
                    btnAgregarPolipectomia.Visible = False
                End If
            End If
        End If

        btnAgregarPolipectomia.Visible = False
        btnColangioNormal.Visible = False
        btnColangioConCalclulo.Visible = False
        btnGastritis.Visible = False
        btnAltaNormal.Visible = False
        btnColonoNormal.Visible = False

        showInformeButtons()

    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        If Me.validarCargaDeDatos() Then
            Dim sObraSocial As ObraSocial = arrObraSocial(cmbObraSocial.SelectedIndex - 1)
            Dim sPractica As Practica = arrPracticas(cmbEstudio.SelectedIndex - 1)
            Dim sMedicoActuante As Medico = arrMedicos(cmbMedicoAct.SelectedIndex)
            Dim sMedicoSolicitante As Medico = arrMedicos(cmbMedicoSol.SelectedIndex)
            Dim sMedicoAnestesista As Medico = arrAnestesistas(cmbAnestesistas.SelectedIndex - 1)

            currentEst.medicoActuante = sMedicoActuante
            currentEst.medicoSolicitante = sMedicoSolicitante
            currentEst.Anestesista = sMedicoAnestesista
            currentEst.practica = sPractica
            currentEst.obraSocial = sObraSocial
            currentEst.motivoEstudio = TxtMotivo.Text
            currentEst.informe = TxtInforme.Text
            currentEst.nroOrden = txtNroOrden.Text
            currentEst.fechaEstudio = dtpFechaEstudio.Value
            currentEst.VideoEstudio.enlaceMega = Me.txtLink.Text




            If currentEst.nroEstudio = 0 Then
                altaEstudio()
            Else
                actualizarEstudio()
            End If
        End If

               
              
    End Sub

    Private Function validarCargaDeDatos() As Boolean
        Select Case True
            Case cmbObraSocial.SelectedItem = "Sin Definir" Or cmbEstudio.SelectedItem = "Sin Definir"
                MsgBox("No se pueden guardar los cambios ya que no se ha especificado una Obra Social y/o un Estudio.", MsgBoxStyle.Critical, "No se pudo guardar el estudio")
                Return False
            Case cmbAnestesistas.SelectedItem = "Sin Definir"
                MsgBox("Debe seleccionar una opción en la lista Anestesia", MsgBoxStyle.Critical, "No se pudo guardar el estudio")
                Return False
            Case Me.cmbMedicoAct.SelectedItem = "Sin Definir" Or Me.cmbMedicoSol.SelectedItem = "Sin Definir"
                MsgBox("Debe seleccionar una opción válida en la lista de medicos actuantes o solicitantes", MsgBoxStyle.Critical, "No se pudo guardar el estudio")
                Return False
            Case Else
                Return True
        End Select
    End Function

    Private Sub altaEstudio()
       

        'dar de alta
        Dim resp As String
        resp = currentEst.AltaEstudio()
        If resp = "ok" Then
            saveChanges = False
            defaultInforme = currentEst.informe
            defaultMotivo = currentEst.motivoEstudio
            Dim r As Integer
            r = MsgBox("El estudio se ha creado, ¿Desea agregar otro?", MsgBoxStyle.YesNo, "Agregar Estudio")
            If r = 6 Then 'Agregamos otro estudio
                Dim frm As New NuevoEstudio(currentEst, True)
                frm.MdiParent = Me.Parent.Parent
                frm.Show()
            End If
            Me.Close()
        End If
    End Sub


    Private Sub actualizarEstudio()
      
        'Guardar cambios
        Dim resp As String
        resp = currentEst.actualizaEstudio()
        If resp = "ok" Then
            saveChanges = False
            defaultInforme = currentEst.informe
            defaultMotivo = currentEst.motivoEstudio
            MsgBox("El estudio se ha actualizado", MsgBoxStyle.OkOnly, " ")
        Else
            MsgBox(resp)
        End If
    End Sub
    Private Sub cargarCombos()

        Dim ep As Practica
        Dim i As Integer
        Dim med As Medico
        Dim os As ObraSocial
        Dim catalogoMedicos As New CatalogoDeMedicos
        Dim catalogoPracticas As New CatalogoDePracticas
        Dim catalogoObraSocial As New CatalogoDeObrasSociales
        'Dim selectedMedAct, selectedMedsol, selectedOs, selectedEst As Integer
        'selectedMedAct = cmbMedicoAct.SelectedIndex
        'selectedMedsol = cmbMedicoSol.SelectedIndex

        arrMedicos = catalogoMedicos.TodosLosMedicos()
        cmbMedicoAct.Items.Clear()
        cmbMedicoSol.Items.Clear()
        For i = 0 To arrMedicos.Count - 1
            med = arrMedicos(i)
            cmbMedicoAct.Items.Add(med.nombreCompleto)
            cmbMedicoSol.Items.Add(med.nombreCompleto)
        Next
        'cmbMedicoAct.SelectedIndex = selectedMedAct
        'cmbMedicoSol.SelectedIndex = selectedMedsol

        'selectedOs = cmbObraSocial.SelectedIndex
        cmbObraSocial.Items.Clear()
        arrObraSocial = catalogoObraSocial.TodosLasObrasSociales
        cmbObraSocial.Items.Add("Sin Definir")
        For i = 0 To arrObraSocial.Count - 1
            os = arrObraSocial(i)
            cmbObraSocial.Items.Add(os.ObraSocial)
        Next
        ' cmbObraSocial.SelectedIndex = selectedOs

        'selectedEst = cmbEstudio.SelectedIndex
        cmbEstudio.Items.Clear()
        arrPracticas = catalogoPracticas.getPracticas
        cmbEstudio.Items.Add("Sin Definir")
        For i = 0 To arrPracticas.Count - 1
            ep = arrPracticas(i)
            cmbEstudio.Items.Add(ep.Estudio)

        Next
        'cmbEstudio.SelectedIndex = selectedEst

        Dim anestesista As Medico
        'Dim selectedAnes As Integer
        'selectedAnes = cmbAnestesistas.SelectedIndex
        arrAnestesistas = catalogoMedicos.TodosLosAnestesistas()
        cmbAnestesistas.Items.Clear()
        cmbAnestesistas.Items.Add("Sin Definir")
        For i = 0 To arrAnestesistas.Count - 1
            anestesista = arrAnestesistas(i)
            cmbAnestesistas.Items.Add(anestesista.nombreCompleto)

        Next
        'cmbAnestesistas.SelectedIndex = selectedAnes
    End Sub


    Private Sub btnFotos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFotos.Click
        Dim myP As Drawing.Image
        Dim currentPath As String = Path.GetPathRoot("\")
        Dim mPath As String = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim mAppPath As String = Path.GetFullPath(mPath)

        Dim frm As New VisorDeImagenes(currentEst)


        frm.MdiParent = Me.Parent.Parent
        frm.Show()
    End Sub
    Private Sub cargarDatos()

        If currentEst.paciente.nroAfiliado = "" Then
            lblDni.Text = "Dni:" & currentEst.paciente.dni
        Else
            lblDni.Text = "Nro de afiliado:" & currentEst.paciente.nroAfiliado
        End If

        lblNombre.Text = "Paciente: " & currentEst.paciente.apellido & ", " & currentEst.paciente.nombres

        If currentEst.nroEstudio = 0 Then
            'Viene desde AltaPaciente
            cmbObraSocial.SelectedItem = "Sin Definir"
            cmbMedicoAct.SelectedItem = "Sin Definir"
            cmbMedicoSol.SelectedItem = "Sin Definir"
            cmbEstudio.SelectedItem = "Sin Definir"
            cmbAnestesistas.SelectedItem = "Sin Definir"
            dtpFechaEstudio.Value = Today.Date
            defaultInforme = ""
            defaultMotivo = ""
            btnAgregarPolipectomia.Visible = False
        Else

            cmbObraSocial.SelectedItem = currentEst.obraSocial.ObraSocial
            cmbMedicoAct.SelectedItem = currentEst.medicoActuante.nombreCompleto
            cmbMedicoSol.SelectedItem = currentEst.medicoSolicitante.nombreCompleto
            Me.cmbAnestesistas.SelectedItem = currentEst.Anestesista.nombreCompleto
            cmbEstudio.SelectedItem = currentEst.practica.Estudio


            If pAddFromSelectedEstudio Then
                Me.Text = "Agregar estudio"
                currentEst.nroEstudio = 0
                cmbEstudio.SelectedItem = "Sin Definir"
            Else
                Me.Text = "Modificar estudio"
                TxtMotivo.Text = currentEst.motivoEstudio
                TxtInforme.Text = currentEst.informe
            End If





            'Cargar anestesista seleccionado
            Dim i As Integer
            Dim cAnestesista As Medico
            For i = 0 To arrAnestesistas.Count - 1
                cAnestesista = arrAnestesistas(i)
                If cAnestesista.idMedico = currentEst.Anestesista.idMedico Then
                    cmbAnestesistas.SelectedItem = cAnestesista.nombreCompleto
                End If
            Next

            dtpFechaEstudio.Value = currentEst.fechaEstudio
            txtNroOrden.Text = currentEst.nroOrden
            defaultInforme = currentEst.informe
            defaultMotivo = currentEst.motivoEstudio
            Me.txtLink.Text = currentEst.VideoEstudio.enlaceMega

        End If

        saveChanges = False

    End Sub


    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnImprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimir.Click
        Me.btnAceptar.PerformClick()
        Dim f As New rptViewer
        f.printInformeEstudios(Me.currentEst)

    End Sub

    Sub PrintSalesPage(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        Dim x As Single = 100.0F
        Dim y As Single = 150.0F
        Dim width As Single = 700.0F
        Dim height As Single = 150.0F
        Dim drawRect As New RectangleF(x, y, width, height)

        Const CurrentX As Integer = 50

        Dim color As New Color
        Dim myPen As New System.Drawing.Pen(color.Black)
        myPen.Alignment = Drawing2D.PenAlignment.Center
        myPen.Width = 1

        Dim RecordsPerPage As Integer = 20
        Dim CurrentRecord As Integer = 0

        Dim CurrentY As Integer = 235
        Dim ReportFont As New Font("Arial", 10, FontStyle.Regular)
        Dim ReportFontHeight As Integer = ReportFont.GetHeight(e.Graphics)

        Dim cuerpo As New Font("Arial", 11, FontStyle.Regular)
        Dim tituloCuerpo As New Font("Arial", 13, FontStyle.Bold)

        Dim titulo As New Font("Arial", 15, FontStyle.Underline)

        '<--------------------------PRINT---------------------------->
        drawRect.Y = CurrentY - ReportFontHeight
        Dim titEst As String = currentEst.practica.Estudio.ToLower()
        Dim tit As String = currentEst.practica.Estudio.ToLower()
        titEst = (UCase(Microsoft.VisualBasic.Left(tit, 1))) & tit.Remove(0, 1)

        e.Graphics.DrawString(titEst, titulo, Brushes.Black, drawRect)

        Dim lineaPaciente As String = "Paciente: " & currentEst.paciente.nombreCompleto

        If currentEst.paciente.edad <> 0 Then
            lineaPaciente &= " (" & CStr(currentEst.paciente.edad) & " años ) "
        End If



        CurrentY = CurrentY + 45
        drawRect.Y = CurrentY
        e.Graphics.DrawString(lineaPaciente, cuerpo, Brushes.Black, drawRect)

        If currentEst.paciente.nroAfiliado <> "" Then
            CurrentY = CurrentY + 30
            drawRect.Y = CurrentY
            e.Graphics.DrawString("Nro de afiliado: " & currentEst.paciente.nroAfiliado, cuerpo, Brushes.Black, drawRect)
        End If


        CurrentY = CurrentY + 30
        drawRect.Y = CurrentY
        e.Graphics.DrawString("Obra Social: " & currentEst.obraSocial.ObraSocial, cuerpo, Brushes.Black, drawRect)

        CurrentY = CurrentY + 30
        drawRect.Y = CurrentY
        e.Graphics.DrawString("Fecha del Estudio: " & currentEst.fechaEstudio, cuerpo, Brushes.Black, drawRect)

        CurrentY = CurrentY + 30
        drawRect.Y = CurrentY
        e.Graphics.DrawString("Medico Solicitante: " & currentEst.medicoSolicitante.nombreCompleto, cuerpo, Brushes.Black, drawRect)

        CurrentY = CurrentY + 40
        drawRect.Y = CurrentY
        drawRect.X = 300
        e.Graphics.DrawString("Motivo del Estudio", tituloCuerpo, Brushes.Black, drawRect)

        CurrentY = CurrentY + 30
        drawRect.Y = CurrentY
        drawRect.X = 100
        e.Graphics.DrawString(currentEst.motivoEstudio, cuerpo, Brushes.Black, drawRect)

        'Linea
        CurrentY = CurrentY + 50
        e.Graphics.DrawLine(myPen, 100, CurrentY, 700, CurrentY)

        CurrentY = CurrentY + 30
        drawRect.Y = CurrentY
        drawRect.X = 100
        drawRect.Height = 1000
        e.Graphics.DrawString(currentEst.informe, cuerpo, Brushes.Black, drawRect)


    End Sub

    Sub PrintImagenes(ByVal sender As Object, ByVal e As PrintPageEventArgs)
        'IMPRIMIR IMAGENES!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

        Dim width As Single = 150.0F
        Dim height As Single = 150.0F
        Dim drawRect As New Rectangle(100, 100, width, height)

        Dim objImage As Image
        Dim objCallback As System.Drawing.Image.GetThumbnailImageAbort = New System.Drawing.Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
        objImage = objImage.FromFile("c:\Fotos\" & currentEst.codigoImagen & "1.jpg")
        objImage = objImage.GetThumbnailImage(100, 100, objCallback, IntPtr.Zero)


        e.Graphics.DrawImageUnscaled(objImage, drawRect)

    End Sub

    Function ThumbnailCallback() As Boolean
        Return False
    End Function

    Private Sub NuevoEstudio_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If checkSaved() Then
            Dim r As Integer = MsgBox("Los datos del estudio han cambiado ¿Desea guardarlos?", MsgBoxStyle.YesNoCancel, "Guardar cambios")
            If r = 6 Then
                btnAceptar.PerformClick()

                If saveChanges Then
                    e.Cancel = True
                End If

            ElseIf r = 2 Then
                e.Cancel = True
            End If

        End If

    End Sub

    Private Function checkSaved() As Boolean
        If saveChanges Then
            Return True
        Else
            If defaultInforme <> TxtInforme.Text Or defaultMotivo <> TxtMotivo.Text Then
                Return True
            End If
        End If

        Return False
    End Function
    Private Sub cmbMedicoAct_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMedicoAct.SelectedIndexChanged
        saveChanges = True
    End Sub

    Private Sub cmbMedicoSol_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbMedicoSol.SelectedIndexChanged
        saveChanges = True
    End Sub

    Private Sub cmbAnestesistas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbAnestesistas.SelectedIndexChanged
        saveChanges = True
    End Sub

    Private Sub cmbEstudio_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbEstudio.SelectedIndexChanged
        saveChanges = True

        showInformeButtons()
    End Sub
    Private Function showInformeButtons() As Boolean
        If (cmbEstudio.SelectedIndex <= 0) Then
            Return False
        End If

        btnColangioNormal.Visible = False
        btnColangioConCalclulo.Visible = False
        btnGastritis.Visible = False
        btnAltaNormal.Visible = False
        btnColonoNormal.Visible = False


        Dim sPractica As Practica = arrPracticas(cmbEstudio.SelectedIndex - 1)
        If sPractica.idEstudio = 1 Or sPractica.idEstudio = 18 Or sPractica.idEstudio = 10 Or sPractica.idEstudio = 24 Then
            btnGastritis.Visible = True
            btnAltaNormal.Visible = True
        ElseIf sPractica.idEstudio = 2 Or sPractica.idEstudio = 19 Or sPractica.idEstudio = 23 Then
            btnColonoNormal.Visible = True
        ElseIf sPractica.idEstudio = 13 Or sPractica.idEstudio = 34 Then
            btnColangioNormal.Visible = True
            btnColangioConCalclulo.Visible = True
        End If

        Return True
    End Function


    Private Sub cmbObraSocial_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbObraSocial.SelectedIndexChanged
        saveChanges = True
    End Sub

    Private Sub restrictUpdate()
        'Restringir combo medico (o todo) de acurdo al perfil del logueado

        If currentEst.idFacturacion <> 0 Or currentEst.fechaCobro <> "0:00:00" Then
            cmbObraSocial.Enabled = False
            cmbEstudio.Enabled = False
            dtpFechaEstudio.Enabled = False
            txtNroOrden.Enabled = False
            Me.TxtInforme.Enabled = True
            Me.TxtMotivo.Enabled = True
        End If

    End Sub

    Private Sub btnAltaNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAltaNormal.Click
        Dim informe As String = "ESOFAGO. Normal , cardias a 37 cm de la arcada dentaria superior, No se evidencia reflujo gastro esofágico , hernia hiatal , ni esofagitis por reflujo." & vbCrLf & _
        "ESTOMAGO: Mucosa de características normales. Por retroflexión se observa el techo gástrico con un buen cierre cardial." & vbCrLf & _
        "PILORO: Permeable" & vbCrLf & _
        "BULBO DUODENAL Y SEGUNDA PORCION DUODENAL . Normales." & vbCrLf & _
        "CONCLUSION DIAGNOSTICA: ESOFAGO GASTRO DUODENO DE CARACTERISTICAS NORMALES." & vbCrLf & _
        "Las principales imágenes se registran en formato de DVD que acompañan el presente informe"
        If TxtInforme.Text <> "" Then
            Dim r As Integer = MsgBox("El informe no esta vacío, ¿ desea reemplazarlo ?", MsgBoxStyle.YesNo, "Completar informe simil")
            If r = 6 Then
                TxtInforme.Text = informe
            End If
        Else
            TxtInforme.Text = informe
        End If
    End Sub

    Private Sub btnGastritis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGastritis.Click
        Dim informe As String = "ESOFAGO. Normal , cardias a 37 cm de la arcada dentaria superior," & vbCrLf & _
        "ESTOMAGO: Mucosa antral difusamente congestiva eritematosa a predominio pre pilórico." & vbCrLf & _
        "PILORO: Permeable" & vbCrLf & _
        "BULBO DUODENAL Y SEGUNDA PORCION DUODENAL . Normales." & vbCrLf & _
        "CONCLUSION DIAGNOSTICA: GASTRITIS SUPERFICIAL NO EROSIVA DE ANTRO GASTRICO." & vbCrLf & _
        "Las principales imágenes se registran en formato de DVD que acompañan el presente informe"


        If TxtInforme.Text <> "" Then
            Dim r As Integer = MsgBox("El informe no esta vacío, ¿ desea reemplazarlo ?", MsgBoxStyle.YesNo, "Completar informe simil")
            If r = 6 Then
                TxtInforme.Text = informe
            End If
        Else
            TxtInforme.Text = informe
        End If
    End Sub

    Private Sub btnColonoNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColonoNormal.Click
        Dim informe As String = "Ampolla rectal sin lesión mucosa." & vbCrLf & _
        "Se franquea el ángulo recto sigmoides observando el colon sigmoides de características normales ." & vbCrLf & _
        "Se progresa por el colon descendente hasta franquear el ángulo esplénico observando el colon transverso , ángulo hepático y colon ascendente sin evidenciar lesión mucosa." & vbCrLf & _
        "CONCLUSION DIAGNOSTICA: AMPOLLA RECTAL Y MARCO COLONICO VISUALIZADO HASTA CIEGO  DE CARACTERISTICAS NORMALES." & vbCrLf & _
        "Las principales imágenes se registran en formato de DVD que acompañan el presente informe"

        If TxtInforme.Text <> "" Then
            Dim r As Integer = MsgBox("El informe no esta vacío, ¿ desea reemplazarlo ?", MsgBoxStyle.YesNo, "Completar informe simil")
            If r = 6 Then
                TxtInforme.Text = informe
            End If
        Else
            TxtInforme.Text = informe
        End If
    End Sub

    Private Sub btnAgregarPolipectomia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAgregarPolipectomia.Click
        If currentEst.obraSocial.idObraSocial = 1 Then
            MsgBox("La obra social OSDE, debe modificar el estudio a Terapeutica ")
            Exit Sub
        End If

        Dim r As Integer
        r = MsgBox("¿Esta seguro que desea crear una polipectomía?", MsgBoxStyle.YesNo, "Crear Polipectomía?")
        If r = 6 Then
            Dim idPractica As Integer
            If currentEst.practica.idEstudio = 1 Then
                idPractica = 24 'polipectomia gastrica
            ElseIf currentEst.practica.idEstudio = 2 Then
                idPractica = 23 'polipectomia colonoca
            End If


            Dim cloneEstudio As New Estudio
            cloneEstudio.fechaEstudio = currentEst.fechaEstudio
            cloneEstudio.practica.idEstudio = idPractica
            cloneEstudio.obraSocial = currentEst.obraSocial
            cloneEstudio.medicoActuante = currentEst.medicoActuante
            cloneEstudio.medicoSolicitante = currentEst.medicoSolicitante
            cloneEstudio.Anestesista = currentEst.Anestesista
            cloneEstudio.paciente = currentEst.paciente
            cloneEstudio.motivoEstudio = currentEst.motivoEstudio
            cloneEstudio.informe = currentEst.informe
            cloneEstudio.nroOrden = ""
            cloneEstudio.AltaEstudio(False)

            MsgBox("El estudio de polipectomía se ha creado con éxito")

        End If

    End Sub

    Private Sub btnColangioNormal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColangioNormal.Click
        Dim informe As String = "En segunda porción duodenal , se visualiza la Ampolla de Vater de características normales." & vbCrLf & _
        "Se canula sin dificultad observando la vía bilair intra hepática de calibre normal." & vbCrLf & _
        "La vía biliar extra hepática presenta tanto el conducto hepático como el colédoco de aspecto y calibre normal." & vbCrLf & _
        "No se observan imágenes radiolucidas en su interior y el drenaje de la sustancia de contraste se realiza en tiempo aceptable. " & vbCrLf & _
        "Buena tolerancia al procedimiento." & vbCrLf & _
        "Las imágenes endoscópicas son grabadas en formato de D.V.D." & vbCrLf & _
        "Las imágenes radioscópicas son digitalizadas e impresas en papel , acompañando el presente informe." & vbCrLf

        If TxtInforme.Text <> "" Then
            Dim r As Integer = MsgBox("El informe no esta vacío, ¿ desea reemplazarlo ?", MsgBoxStyle.YesNo, "Completar informe simil")
            If r = 6 Then
                TxtInforme.Text = informe
            End If
        Else
            TxtInforme.Text = informe
        End If
    End Sub

    Private Sub btnColangioConCalclulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColangioConCalclulo.Click
        Dim informe As String = "En segunda porción duodenal se visualiza la Ampolla de Vater de características normales." & vbCrLf & _
        "Se canula sin dificultad observando la vía bilar intra hepática de calibre conservado." & vbCrLf & _
        "La vía biiliar extra hepática se observa dilatada de aproximadamente 20 mm en promedio con una imagen radiolúcida en su interior con limites netos que podría corresponder a un lito coledociano." & vbCrLf & _
        "Se realiza papilotomía ámplia y con canastilla de dormia se extrae un lito con las características descriptas en al imagen radiológica." & vbCrLf & _
        "Buena tolerancia al procedimiento." & vbCrLf & _
        "Las imágenes endocópicas son grabadas en formato de D.V.D." & vbCrLf & _
        "Las imágenes radioscópicas son digitalizadas e impresas en papel que acompañan al presente informe. " & vbCrLf

        If TxtInforme.Text <> "" Then
            Dim r As Integer = MsgBox("El informe no esta vacío, ¿ desea reemplazarlo ?", MsgBoxStyle.YesNo, "Completar informe simil")
            If r = 6 Then
                TxtInforme.Text = informe
            End If
        Else
            TxtInforme.Text = informe
        End If
    End Sub

    Private Sub TxtInforme_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtInforme.KeyPress
        Me.btnOrtografia.Visible = True
        Me.btnGramatica.Visible = True
    End Sub

    Private Sub TxtInforme_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtInforme.Leave
        If Me.TxtInforme.Text = "" Then
            Me.btnOrtografia.Visible = False
            Me.btnGramatica.Visible = False
        Else
            Me.btnOrtografia.Visible = True
            Me.btnGramatica.Visible = True
        End If
    End Sub

    Private Sub btnOrtografia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOrtografia.Click
        SpellOrGrammarCheck(True)
    End Sub
    Private Sub SpellOrGrammarCheck(ByVal blnSpellOnly As Boolean)

        Try
            ' Create Word and temporary document objects.
            Dim objWord As Object
            Dim objTempDoc As Object
            ' Declare an IDataObject to hold the data returned from the 
            ' clipboard.
            Dim iData As IDataObject
            Dim shell As New Shell32.Shell
            shell.MinimizeAll()

            ' If there is no data to spell check, then exit sub here.
            If Me.TxtInforme.Text = "" Then
                Exit Sub
            End If

            objWord = New Word.Application()
            objTempDoc = objWord.Documents.Add
            objWord.Visible = False

            ' Position Word off the screen...this keeps Word invisible 
            ' throughout.
            objWord.WindowState = 0
            objWord.Top = -10


            ' Copy the contents of the textbox to the clipboard
            Clipboard.SetDataObject(TxtInforme.Text)

            ' With the temporary document, perform either a spell check or a 
            ' complete
            ' grammar check, based on user selection.
            With objTempDoc
                .Content.Paste()
                .Activate()
                If blnSpellOnly Then
                    .CheckSpelling()
                Else
                    .CheckGrammar()
                End If
                ' After user has made changes, use the clipboard to
                ' transfer the contents back to the text box
                .Content.Copy()
                iData = Clipboard.GetDataObject
                If iData.GetDataPresent(DataFormats.Text) Then
                    TxtInforme.Text = CType(iData.GetData(DataFormats.Text), _
                        String)
                End If
                .Saved = True
                .Close()
            End With

            objWord.Quit()
            objWord = Nothing
            MessageBox.Show("Control ortográfico completo.", _
                "Corrector ortográfico", MessageBoxButtons.OK, _
                MessageBoxIcon.Information)

            shell.UndoMinimizeALL()
            Me.Focus()
            Me.WindowState = FormWindowState.Normal


        Catch Excep As Exception
            MessageBox.Show("Ha ocurrido un error.", "Corrector ortográfico")

        End Try

    End Sub

    Private Sub btnGramatica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGramatica.Click
        SpellOrGrammarCheck(False)
    End Sub

    Private Sub btnPrueba_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim linecount As Integer = 0
        linecount = Len(TxtInforme.Text) - Len(Replace(TxtInforme.Text, vbCrLf, vbCr))
        MessageBox.Show(linecount.ToString())
    End Sub

    Private Sub TxtInforme_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtInforme.TextChanged

    End Sub



    Private Sub NuevoEstudio_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        'Me.btnAceptar.PerformClick()
    End Sub

    Private Sub btnLink_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLink.Click
        If Clipboard.ContainsText() Then
            Me.txtLink.Text = Clipboard.GetText()
        End If
    End Sub
End Class
