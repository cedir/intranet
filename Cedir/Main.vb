Imports CedirNegocios
Imports System.Collections.Generic


Public Class Main


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
    Friend WithEvents ToolBar1 As System.Windows.Forms.ToolBar
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents MenuItem1 As System.Windows.Forms.MenuItem
    Friend WithEvents AltaPaciente As System.Windows.Forms.ToolBarButton
    Friend WithEvents ToolBarButton2 As System.Windows.Forms.ToolBarButton
    Friend WithEvents BarraEstado As System.Windows.Forms.StatusBar
    Friend WithEvents MenuItem12 As System.Windows.Forms.MenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolBarButton3 As System.Windows.Forms.ToolBarButton
    Friend WithEvents itemObraSociales As System.Windows.Forms.MenuItem
    Friend WithEvents itemTarea As System.Windows.Forms.MenuItem
    Friend WithEvents itemTareaNueva As System.Windows.Forms.MenuItem
    Friend WithEvents itemTareaVer As System.Windows.Forms.MenuItem
    Friend WithEvents itemPracticas As System.Windows.Forms.MenuItem
    Friend WithEvents itemPracticasABM As System.Windows.Forms.MenuItem
    Friend WithEvents itemUsuarios As System.Windows.Forms.MenuItem
    Friend WithEvents itemUsuariosABM As System.Windows.Forms.MenuItem
    Friend WithEvents itemUsuariosLogIn As System.Windows.Forms.MenuItem
    Friend WithEvents itemUsuariosLogOut As System.Windows.Forms.MenuItem
    Friend WithEvents itemSalir As System.Windows.Forms.MenuItem
    Friend WithEvents itemPacientes As System.Windows.Forms.MenuItem
    Friend WithEvents itemPacientesNuevo As System.Windows.Forms.MenuItem
    Friend WithEvents itemPacientesBuscar As System.Windows.Forms.MenuItem
    Friend WithEvents itemEstudios As System.Windows.Forms.MenuItem
    Friend WithEvents itemEstudiosDeHoy As System.Windows.Forms.MenuItem
    Friend WithEvents itemEstudiosBuscar As System.Windows.Forms.MenuItem
    Friend WithEvents itemEstudiosBuscarAvanzado As System.Windows.Forms.MenuItem
    Friend WithEvents itemMedicos As System.Windows.Forms.MenuItem
    Friend WithEvents itemMedicosABM As System.Windows.Forms.MenuItem
    Friend WithEvents itemMedicosNuevoPago As System.Windows.Forms.MenuItem
    Friend WithEvents itemMedicosMiCuenta As System.Windows.Forms.MenuItem
    Friend WithEvents itemObraSocialesNueva As System.Windows.Forms.MenuItem
    Friend WithEvents itemObraSocialesBuscar As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacion As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionNueva As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionBuscar As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionInformes As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionConsultas As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionConsultasNueva As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionConsultasBuscar As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionFacturaNueva As System.Windows.Forms.MenuItem
    Friend WithEvents itemMedicacion As System.Windows.Forms.MenuItem
    Friend WithEvents itemMedicacionABM As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionAMR As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionAMRNueva As System.Windows.Forms.MenuItem
    Friend WithEvents itemFacturacionAMRBuscar As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem2 As System.Windows.Forms.MenuItem
    Friend WithEvents itemComprobantes As System.Windows.Forms.MenuItem
    Friend WithEvents mnuItemComprobantesBuscar As System.Windows.Forms.MenuItem
    Friend WithEvents mnuCaja As System.Windows.Forms.MenuItem
    Friend WithEvents mnuListadoCaja As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMovimientoCaja As System.Windows.Forms.MenuItem
    Friend WithEvents nfyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents mnuMensajeria As System.Windows.Forms.MenuItem
    Friend WithEvents tmrTemporizador As System.Windows.Forms.Timer
    Friend WithEvents mnuItemListadoAnestesista As System.Windows.Forms.MenuItem
    Friend WithEvents mnuComplejidades As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem4 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMedicacion As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMedicMovimientoStock As System.Windows.Forms.MenuItem
    Friend WithEvents mnuMedicListadoMov As System.Windows.Forms.MenuItem
    Friend WithEvents mnuReportes As System.Windows.Forms.MenuItem
    Friend WithEvents itemHonorariosCedir As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem3 As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem5 As System.Windows.Forms.MenuItem
    Friend WithEvents ToolBarButton1 As System.Windows.Forms.ToolBarButton
    Friend WithEvents Consultorio As System.Windows.Forms.ToolBarButton
    Friend WithEvents Coseguro As System.Windows.Forms.ToolBarButton
    Friend WithEvents mnuReemplazarPaciente As System.Windows.Forms.MenuItem
    Friend WithEvents MenuItem6 As System.Windows.Forms.MenuItem
    Friend WithEvents itemEstudiosCrearRapido As System.Windows.Forms.MenuItem
    Friend WithEvents itemAnestesitasPagos As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.ToolBar1 = New System.Windows.Forms.ToolBar
        Me.ToolBarButton1 = New System.Windows.Forms.ToolBarButton
        Me.Coseguro = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton2 = New System.Windows.Forms.ToolBarButton
        Me.ToolBarButton3 = New System.Windows.Forms.ToolBarButton
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.MenuItem1 = New System.Windows.Forms.MenuItem
        Me.mnuMensajeria = New System.Windows.Forms.MenuItem
        Me.itemTarea = New System.Windows.Forms.MenuItem
        Me.itemTareaNueva = New System.Windows.Forms.MenuItem
        Me.itemTareaVer = New System.Windows.Forms.MenuItem
        Me.MenuItem5 = New System.Windows.Forms.MenuItem
        Me.itemMedicacion = New System.Windows.Forms.MenuItem
        Me.itemMedicacionABM = New System.Windows.Forms.MenuItem
        Me.itemPracticas = New System.Windows.Forms.MenuItem
        Me.itemPracticasABM = New System.Windows.Forms.MenuItem
        Me.itemUsuarios = New System.Windows.Forms.MenuItem
        Me.itemUsuariosABM = New System.Windows.Forms.MenuItem
        Me.itemUsuariosLogIn = New System.Windows.Forms.MenuItem
        Me.itemUsuariosLogOut = New System.Windows.Forms.MenuItem
        Me.itemSalir = New System.Windows.Forms.MenuItem
        Me.itemPacientes = New System.Windows.Forms.MenuItem
        Me.itemPacientesNuevo = New System.Windows.Forms.MenuItem
        Me.itemPacientesBuscar = New System.Windows.Forms.MenuItem
        Me.MenuItem12 = New System.Windows.Forms.MenuItem
        Me.mnuReemplazarPaciente = New System.Windows.Forms.MenuItem
        Me.itemEstudios = New System.Windows.Forms.MenuItem
        Me.itemEstudiosDeHoy = New System.Windows.Forms.MenuItem
        Me.itemEstudiosBuscar = New System.Windows.Forms.MenuItem
        Me.itemEstudiosCrearRapido = New System.Windows.Forms.MenuItem
        Me.itemEstudiosBuscarAvanzado = New System.Windows.Forms.MenuItem
        Me.itemMedicos = New System.Windows.Forms.MenuItem
        Me.itemMedicosABM = New System.Windows.Forms.MenuItem
        Me.itemMedicosNuevoPago = New System.Windows.Forms.MenuItem
        Me.itemMedicosMiCuenta = New System.Windows.Forms.MenuItem
        Me.MenuItem2 = New System.Windows.Forms.MenuItem
        Me.itemAnestesitasPagos = New System.Windows.Forms.MenuItem
        Me.mnuItemListadoAnestesista = New System.Windows.Forms.MenuItem
        Me.mnuComplejidades = New System.Windows.Forms.MenuItem
        Me.itemObraSociales = New System.Windows.Forms.MenuItem
        Me.itemObraSocialesNueva = New System.Windows.Forms.MenuItem
        Me.itemObraSocialesBuscar = New System.Windows.Forms.MenuItem
        Me.itemFacturacion = New System.Windows.Forms.MenuItem
        Me.itemFacturacionNueva = New System.Windows.Forms.MenuItem
        Me.itemFacturacionBuscar = New System.Windows.Forms.MenuItem
        Me.itemFacturacionInformes = New System.Windows.Forms.MenuItem
        Me.MenuItem4 = New System.Windows.Forms.MenuItem
        Me.itemFacturacionConsultas = New System.Windows.Forms.MenuItem
        Me.itemFacturacionConsultasNueva = New System.Windows.Forms.MenuItem
        Me.itemFacturacionConsultasBuscar = New System.Windows.Forms.MenuItem
        Me.itemFacturacionAMR = New System.Windows.Forms.MenuItem
        Me.itemFacturacionAMRNueva = New System.Windows.Forms.MenuItem
        Me.itemFacturacionAMRBuscar = New System.Windows.Forms.MenuItem
        Me.itemComprobantes = New System.Windows.Forms.MenuItem
        Me.itemFacturacionFacturaNueva = New System.Windows.Forms.MenuItem
        Me.mnuItemComprobantesBuscar = New System.Windows.Forms.MenuItem
        Me.mnuMedicacion = New System.Windows.Forms.MenuItem
        Me.mnuMedicMovimientoStock = New System.Windows.Forms.MenuItem
        Me.mnuMedicListadoMov = New System.Windows.Forms.MenuItem
        Me.mnuReportes = New System.Windows.Forms.MenuItem
        Me.itemHonorariosCedir = New System.Windows.Forms.MenuItem
        Me.MenuItem6 = New System.Windows.Forms.MenuItem
        Me.mnuCaja = New System.Windows.Forms.MenuItem
        Me.mnuListadoCaja = New System.Windows.Forms.MenuItem
        Me.mnuMovimientoCaja = New System.Windows.Forms.MenuItem
        Me.MenuItem3 = New System.Windows.Forms.MenuItem
        Me.BarraEstado = New System.Windows.Forms.StatusBar
        Me.nfyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.tmrTemporizador = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'ToolBar1
        '
        Me.ToolBar1.AutoSize = False
        Me.ToolBar1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ToolBar1.Buttons.AddRange(New System.Windows.Forms.ToolBarButton() {Me.ToolBarButton1, Me.Coseguro, Me.ToolBarButton2, Me.ToolBarButton3})
        Me.ToolBar1.ButtonSize = New System.Drawing.Size(75, 35)
        Me.ToolBar1.DropDownArrows = True
        Me.ToolBar1.ImageList = Me.ImageList1
        Me.ToolBar1.Location = New System.Drawing.Point(0, 0)
        Me.ToolBar1.Name = "ToolBar1"
        Me.ToolBar1.ShowToolTips = True
        Me.ToolBar1.Size = New System.Drawing.Size(978, 42)
        Me.ToolBar1.TabIndex = 3
        Me.ToolBar1.Visible = False
        '
        'ToolBarButton1
        '
        Me.ToolBarButton1.ImageIndex = 0
        Me.ToolBarButton1.Name = "ToolBarButton1"
        Me.ToolBarButton1.Text = "Alta Paciente"
        '
        'Coseguro
        '
        Me.Coseguro.ImageIndex = 41
        Me.Coseguro.Name = "Coseguro"
        Me.Coseguro.Text = "Consultorio"
        Me.Coseguro.ToolTipText = "Crear Movimiento -  Consultorio"
        '
        'ToolBarButton2
        '
        Me.ToolBarButton2.ImageIndex = 1
        Me.ToolBarButton2.Name = "ToolBarButton2"
        '
        'ToolBarButton3
        '
        Me.ToolBarButton3.ImageIndex = 2
        Me.ToolBarButton3.Name = "ToolBarButton3"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "")
        Me.ImageList1.Images.SetKeyName(1, "")
        Me.ImageList1.Images.SetKeyName(2, "")
        Me.ImageList1.Images.SetKeyName(3, "")
        Me.ImageList1.Images.SetKeyName(4, "")
        Me.ImageList1.Images.SetKeyName(5, "")
        Me.ImageList1.Images.SetKeyName(6, "")
        Me.ImageList1.Images.SetKeyName(7, "")
        Me.ImageList1.Images.SetKeyName(8, "")
        Me.ImageList1.Images.SetKeyName(9, "")
        Me.ImageList1.Images.SetKeyName(10, "")
        Me.ImageList1.Images.SetKeyName(11, "App.ico")
        Me.ImageList1.Images.SetKeyName(12, "book01a.ico")
        Me.ImageList1.Images.SetKeyName(13, "book02.ico")
        Me.ImageList1.Images.SetKeyName(14, "Calender 3.ico")
        Me.ImageList1.Images.SetKeyName(15, "clip01.ico")
        Me.ImageList1.Images.SetKeyName(16, "disks03.ico")
        Me.ImageList1.Images.SetKeyName(17, "exiteml.ico")
        Me.ImageList1.Images.SetKeyName(18, "folder04.ico")
        Me.ImageList1.Images.SetKeyName(19, "font02.ico")
        Me.ImageList1.Images.SetKeyName(20, "info.ico")
        Me.ImageList1.Images.SetKeyName(21, "ipml.ico")
        Me.ImageList1.Images.SetKeyName(22, "Kearone-Comicons-Notebook-with-icons.ico")
        Me.ImageList1.Images.SetKeyName(23, "Knicks Recycle Full.ico")
        Me.ImageList1.Images.SetKeyName(24, "magnify.ico")
        Me.ImageList1.Images.SetKeyName(25, "misc04.ico")
        Me.ImageList1.Images.SetKeyName(26, "misc05.ico")
        Me.ImageList1.Images.SetKeyName(27, "misc11.ico")
        Me.ImageList1.Images.SetKeyName(28, "misc12.ico")
        Me.ImageList1.Images.SetKeyName(29, "misc16b.ico")
        Me.ImageList1.Images.SetKeyName(30, "msgbox01.ico")
        Me.ImageList1.Images.SetKeyName(31, "msgbox02.ico")
        Me.ImageList1.Images.SetKeyName(32, "note.ico")
        Me.ImageList1.Images.SetKeyName(33, "oofl.ico")
        Me.ImageList1.Images.SetKeyName(34, "orders.ico")
        Me.ImageList1.Images.SetKeyName(35, "pen01.ico")
        Me.ImageList1.Images.SetKeyName(36, "portrait.ico")
        Me.ImageList1.Images.SetKeyName(37, "postitl.ico")
        Me.ImageList1.Images.SetKeyName(38, "postl.ico")
        Me.ImageList1.Images.SetKeyName(39, "resendl.ico")
        Me.ImageList1.Images.SetKeyName(40, "signl.ico")
        Me.ImageList1.Images.SetKeyName(41, "taskl.ico")
        Me.ImageList1.Images.SetKeyName(42, "w95mbx01.ico")
        Me.ImageList1.Images.SetKeyName(43, "w95mbx03.ico")
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem1, Me.itemPacientes, Me.itemEstudios, Me.itemMedicos, Me.itemObraSociales, Me.itemFacturacion, Me.itemComprobantes, Me.mnuMedicacion, Me.mnuReportes, Me.mnuCaja})
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMensajeria, Me.itemTarea, Me.MenuItem5, Me.itemMedicacion, Me.itemPracticas, Me.itemUsuarios, Me.itemSalir})
        Me.MenuItem1.Text = "Archivo"
        '
        'mnuMensajeria
        '
        Me.mnuMensajeria.Enabled = False
        Me.mnuMensajeria.Index = 0
        Me.mnuMensajeria.Text = "Mensajería"
        '
        'itemTarea
        '
        Me.itemTarea.Enabled = False
        Me.itemTarea.Index = 1
        Me.itemTarea.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemTareaNueva, Me.itemTareaVer})
        Me.itemTarea.Text = "Tareas"
        '
        'itemTareaNueva
        '
        Me.itemTareaNueva.Index = 0
        Me.itemTareaNueva.Text = "Nueva Tarea"
        '
        'itemTareaVer
        '
        Me.itemTareaVer.Index = 1
        Me.itemTareaVer.Text = "Ver Tareas"
        '
        'MenuItem5
        '
        Me.MenuItem5.Index = 2
        Me.MenuItem5.Text = "-"
        '
        'itemMedicacion
        '
        Me.itemMedicacion.Enabled = False
        Me.itemMedicacion.Index = 3
        Me.itemMedicacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemMedicacionABM})
        Me.itemMedicacion.Text = "Medicación"
        '
        'itemMedicacionABM
        '
        Me.itemMedicacionABM.Index = 0
        Me.itemMedicacionABM.Text = "Crear o Modificar Medicación"
        '
        'itemPracticas
        '
        Me.itemPracticas.Enabled = False
        Me.itemPracticas.Index = 4
        Me.itemPracticas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemPracticasABM})
        Me.itemPracticas.Text = "Prácticas"
        '
        'itemPracticasABM
        '
        Me.itemPracticasABM.Index = 0
        Me.itemPracticasABM.Text = "ABM Practicas"
        '
        'itemUsuarios
        '
        Me.itemUsuarios.Index = 5
        Me.itemUsuarios.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemUsuariosABM, Me.itemUsuariosLogIn, Me.itemUsuariosLogOut})
        Me.itemUsuarios.Text = "Usuarios"
        '
        'itemUsuariosABM
        '
        Me.itemUsuariosABM.Enabled = False
        Me.itemUsuariosABM.Index = 0
        Me.itemUsuariosABM.Text = "ABM Usuarios"
        '
        'itemUsuariosLogIn
        '
        Me.itemUsuariosLogIn.Index = 1
        Me.itemUsuariosLogIn.Text = "Log In"
        '
        'itemUsuariosLogOut
        '
        Me.itemUsuariosLogOut.Enabled = False
        Me.itemUsuariosLogOut.Index = 2
        Me.itemUsuariosLogOut.Text = "Log Out"
        '
        'itemSalir
        '
        Me.itemSalir.Index = 6
        Me.itemSalir.Text = "Salir"
        '
        'itemPacientes
        '
        Me.itemPacientes.Enabled = False
        Me.itemPacientes.Index = 1
        Me.itemPacientes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemPacientesNuevo, Me.itemPacientesBuscar, Me.MenuItem12, Me.mnuReemplazarPaciente})
        Me.itemPacientes.Text = "Pacientes"
        '
        'itemPacientesNuevo
        '
        Me.itemPacientesNuevo.Enabled = False
        Me.itemPacientesNuevo.Index = 0
        Me.itemPacientesNuevo.Text = "Nuevo Paciente"
        '
        'itemPacientesBuscar
        '
        Me.itemPacientesBuscar.Enabled = False
        Me.itemPacientesBuscar.Index = 1
        Me.itemPacientesBuscar.Text = "Buscar Paciente"
        '
        'MenuItem12
        '
        Me.MenuItem12.Enabled = False
        Me.MenuItem12.Index = 2
        Me.MenuItem12.Text = "Historial Clinico"
        '
        'mnuReemplazarPaciente
        '
        Me.mnuReemplazarPaciente.Enabled = False
        Me.mnuReemplazarPaciente.Index = 3
        Me.mnuReemplazarPaciente.Text = "Eliminar Paciente"
        '
        'itemEstudios
        '
        Me.itemEstudios.Index = 2
        Me.itemEstudios.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemEstudiosDeHoy, Me.itemEstudiosBuscar, Me.itemEstudiosCrearRapido, Me.itemEstudiosBuscarAvanzado})
        Me.itemEstudios.Text = "Estudios"
        '
        'itemEstudiosDeHoy
        '
        Me.itemEstudiosDeHoy.Index = 0
        Me.itemEstudiosDeHoy.Shortcut = System.Windows.Forms.Shortcut.CtrlH
        Me.itemEstudiosDeHoy.Text = "Estudios de hoy"
        '
        'itemEstudiosBuscar
        '
        Me.itemEstudiosBuscar.Enabled = False
        Me.itemEstudiosBuscar.Index = 1
        Me.itemEstudiosBuscar.Shortcut = System.Windows.Forms.Shortcut.CtrlB
        Me.itemEstudiosBuscar.Text = "Buscar"
        '
        'itemEstudiosCrearRapido
        '
        Me.itemEstudiosCrearRapido.Enabled = False
        Me.itemEstudiosCrearRapido.Index = 2
        Me.itemEstudiosCrearRapido.Shortcut = System.Windows.Forms.Shortcut.CtrlE
        Me.itemEstudiosCrearRapido.Text = "Crear estudio rápido"
        '
        'itemEstudiosBuscarAvanzado
        '
        Me.itemEstudiosBuscarAvanzado.Enabled = False
        Me.itemEstudiosBuscarAvanzado.Index = 3
        Me.itemEstudiosBuscarAvanzado.Text = "Buscar Estudios (Avanzado)"
        '
        'itemMedicos
        '
        Me.itemMedicos.Enabled = False
        Me.itemMedicos.Index = 3
        Me.itemMedicos.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemMedicosABM, Me.itemMedicosNuevoPago, Me.itemMedicosMiCuenta, Me.MenuItem2})
        Me.itemMedicos.Text = "Médicos"
        '
        'itemMedicosABM
        '
        Me.itemMedicosABM.Index = 0
        Me.itemMedicosABM.Text = "ABM Médicos"
        '
        'itemMedicosNuevoPago
        '
        Me.itemMedicosNuevoPago.Enabled = False
        Me.itemMedicosNuevoPago.Index = 1
        Me.itemMedicosNuevoPago.Text = "Nuevo Pago"
        '
        'itemMedicosMiCuenta
        '
        Me.itemMedicosMiCuenta.Enabled = False
        Me.itemMedicosMiCuenta.Index = 2
        Me.itemMedicosMiCuenta.Text = "Mi cuenta"
        '
        'MenuItem2
        '
        Me.MenuItem2.Index = 3
        Me.MenuItem2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemAnestesitasPagos, Me.mnuItemListadoAnestesista, Me.mnuComplejidades})
        Me.MenuItem2.Text = "Anestesistas"
        '
        'itemAnestesitasPagos
        '
        Me.itemAnestesitasPagos.Enabled = False
        Me.itemAnestesitasPagos.Index = 0
        Me.itemAnestesitasPagos.Text = "Pagos"
        '
        'mnuItemListadoAnestesista
        '
        Me.mnuItemListadoAnestesista.Enabled = False
        Me.mnuItemListadoAnestesista.Index = 1
        Me.mnuItemListadoAnestesista.Text = "Listado"
        '
        'mnuComplejidades
        '
        Me.mnuComplejidades.Enabled = False
        Me.mnuComplejidades.Index = 2
        Me.mnuComplejidades.Text = "Complejidades"
        '
        'itemObraSociales
        '
        Me.itemObraSociales.Enabled = False
        Me.itemObraSociales.Index = 4
        Me.itemObraSociales.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemObraSocialesNueva, Me.itemObraSocialesBuscar})
        Me.itemObraSociales.Text = "Obras Sociales"
        '
        'itemObraSocialesNueva
        '
        Me.itemObraSocialesNueva.Index = 0
        Me.itemObraSocialesNueva.Text = "Nueva Obra Social"
        '
        'itemObraSocialesBuscar
        '
        Me.itemObraSocialesBuscar.Enabled = False
        Me.itemObraSocialesBuscar.Index = 1
        Me.itemObraSocialesBuscar.Text = "Buscar Obra Social"
        '
        'itemFacturacion
        '
        Me.itemFacturacion.Enabled = False
        Me.itemFacturacion.Index = 5
        Me.itemFacturacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemFacturacionNueva, Me.itemFacturacionBuscar, Me.itemFacturacionInformes, Me.itemFacturacionConsultas, Me.itemFacturacionAMR})
        Me.itemFacturacion.Text = "Presentaciones"
        '
        'itemFacturacionNueva
        '
        Me.itemFacturacionNueva.Index = 0
        Me.itemFacturacionNueva.Text = "Nueva Presentación Directa"
        '
        'itemFacturacionBuscar
        '
        Me.itemFacturacionBuscar.Index = 1
        Me.itemFacturacionBuscar.Text = "Buscar Presentación"
        '
        'itemFacturacionInformes
        '
        Me.itemFacturacionInformes.Index = 2
        Me.itemFacturacionInformes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.MenuItem4})
        Me.itemFacturacionInformes.Text = "Informes"
        '
        'MenuItem4
        '
        Me.MenuItem4.Index = 0
        Me.MenuItem4.Text = "Informe mensual "
        '
        'itemFacturacionConsultas
        '
        Me.itemFacturacionConsultas.Index = 3
        Me.itemFacturacionConsultas.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemFacturacionConsultasNueva, Me.itemFacturacionConsultasBuscar})
        Me.itemFacturacionConsultas.Text = "Consultas"
        Me.itemFacturacionConsultas.Visible = False
        '
        'itemFacturacionConsultasNueva
        '
        Me.itemFacturacionConsultasNueva.Index = 0
        Me.itemFacturacionConsultasNueva.Text = "Nueva Consulta"
        '
        'itemFacturacionConsultasBuscar
        '
        Me.itemFacturacionConsultasBuscar.Index = 1
        Me.itemFacturacionConsultasBuscar.Text = "Buscar Consulta"
        '
        'itemFacturacionAMR
        '
        Me.itemFacturacionAMR.Index = 4
        Me.itemFacturacionAMR.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemFacturacionAMRNueva, Me.itemFacturacionAMRBuscar})
        Me.itemFacturacionAMR.Text = "AMR"
        '
        'itemFacturacionAMRNueva
        '
        Me.itemFacturacionAMRNueva.Index = 0
        Me.itemFacturacionAMRNueva.Text = "Nueva Presentación"
        '
        'itemFacturacionAMRBuscar
        '
        Me.itemFacturacionAMRBuscar.Index = 1
        Me.itemFacturacionAMRBuscar.Text = "Buscar"
        '
        'itemComprobantes
        '
        Me.itemComprobantes.Enabled = False
        Me.itemComprobantes.Index = 6
        Me.itemComprobantes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemFacturacionFacturaNueva, Me.mnuItemComprobantesBuscar})
        Me.itemComprobantes.Text = "Comprobantes"
        '
        'itemFacturacionFacturaNueva
        '
        Me.itemFacturacionFacturaNueva.Index = 0
        Me.itemFacturacionFacturaNueva.Text = "Crear nuevo"
        '
        'mnuItemComprobantesBuscar
        '
        Me.mnuItemComprobantesBuscar.Index = 1
        Me.mnuItemComprobantesBuscar.Text = "Buscar"
        '
        'mnuMedicacion
        '
        Me.mnuMedicacion.Enabled = False
        Me.mnuMedicacion.Index = 7
        Me.mnuMedicacion.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuMedicMovimientoStock, Me.mnuMedicListadoMov})
        Me.mnuMedicacion.Text = "Medicacion"
        '
        'mnuMedicMovimientoStock
        '
        Me.mnuMedicMovimientoStock.Index = 0
        Me.mnuMedicMovimientoStock.Text = "Movimiento de Stock"
        '
        'mnuMedicListadoMov
        '
        Me.mnuMedicListadoMov.Index = 1
        Me.mnuMedicListadoMov.Text = "Listado de Movimientos"
        '
        'mnuReportes
        '
        Me.mnuReportes.Enabled = False
        Me.mnuReportes.Index = 8
        Me.mnuReportes.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.itemHonorariosCedir, Me.MenuItem6})
        Me.mnuReportes.Text = "Reportes"
        '
        'itemHonorariosCedir
        '
        Me.itemHonorariosCedir.Index = 0
        Me.itemHonorariosCedir.Text = "Honorarios Cedir"
        '
        'MenuItem6
        '
        Me.MenuItem6.Index = 1
        Me.MenuItem6.Text = "Estadisticas de estudios"
        '
        'mnuCaja
        '
        Me.mnuCaja.Enabled = False
        Me.mnuCaja.Index = 9
        Me.mnuCaja.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuListadoCaja, Me.mnuMovimientoCaja, Me.MenuItem3})
        Me.mnuCaja.Text = "Caja"
        '
        'mnuListadoCaja
        '
        Me.mnuListadoCaja.Index = 0
        Me.mnuListadoCaja.Text = "Ver Listado de caja"
        '
        'mnuMovimientoCaja
        '
        Me.mnuMovimientoCaja.Index = 1
        Me.mnuMovimientoCaja.Text = "Crear Movimiento de caja"
        '
        'MenuItem3
        '
        Me.MenuItem3.Index = 2
        Me.MenuItem3.Text = "Ver Movimientos con Estudios"
        '
        'BarraEstado
        '
        Me.BarraEstado.Location = New System.Drawing.Point(0, 460)
        Me.BarraEstado.Name = "BarraEstado"
        Me.BarraEstado.Size = New System.Drawing.Size(978, 22)
        Me.BarraEstado.TabIndex = 5
        Me.BarraEstado.Text = "Cedir Intranet - Versión 2.8.1.7 - Fecha: 03/08/2016      "
        '
        'nfyIcon
        '
        Me.nfyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning
        Me.nfyIcon.Icon = CType(resources.GetObject("nfyIcon.Icon"), System.Drawing.Icon)
        Me.nfyIcon.Text = "Mensajes pendientes"
        '
        'tmrTemporizador
        '
        Me.tmrTemporizador.Interval = 120000
        '
        'Main
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(978, 482)
        Me.Controls.Add(Me.BarraEstado)
        Me.Controls.Add(Me.ToolBar1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cedir - "
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public Property nti() As NotifyIcon
        Get
            Return Me.nfyIcon
        End Get
        Set(ByVal value As NotifyIcon)

        End Set
    End Property

    Public Property timerMensajeria() As Timer
        Get
            Return Me.tmrTemporizador
        End Get
        Set(ByVal value As Timer)
            tmrTemporizador = value
        End Set
    End Property


    Private Sub MenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemPacientesNuevo.Click
        Dim frm As New AltaPaciente()
        frm.esAltaPaciente = True
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub MenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemPacientesBuscar.Click
        Dim frm As New BuscarPacientes
        frm.MdiParent = Me
        frm.Show()

    End Sub

    Private Sub MenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemEstudiosDeHoy.Click

        If Not Me.isFormOpened("EstudiosDeHoy") Then
            Dim f As New EstudiosDeHoy
            f.MdiParent = Me
            f.Show()

        End If

    End Sub

    Private Sub MenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemEstudiosBuscar.Click
        Dim f As New ConsultaEstudios
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemSalir.Click
        Me.Close()
    End Sub
    Private Sub MenuItem20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemFacturacionBuscar.Click
        Dim f As New BuscarPresentacion
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemFacturacionNueva.Click
        If hayUnaFacturacionInstanciada Then
            MsgBox("Ya hay una ventana Nueva Facturación abierta", MsgBoxStyle.Information, "No se puede abrir la ventana Nueva Facturación")
        Else
            Dim f As New NuevaPresentacion
            f.MdiParent = Me
            f.Show()
        End If

    End Sub

    Private Sub MenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemObraSocialesBuscar.Click
        Dim f As New ConsultarObraSocial
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemObraSocialesNueva.Click
        Dim f As New ABMObraSocial
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemMedicosABM.Click
        Dim f As New ABMMedico
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem23_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemPracticasABM.Click
        Dim f As New ABMPracticas
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem24_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemMedicosNuevoPago.Click
        Dim f As New PagoMedico
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem25_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemMedicosMiCuenta.Click
        Dim f As New MiCuenta
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemMedicacionABM.Click
        Dim f As New ABMMedicacion
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub ToolBar1_ButtonClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolBarButtonClickEventArgs) Handles ToolBar1.ButtonClick
        Select Case ToolBar1.Buttons.IndexOf(e.Button)
            Case 0
                Dim frm As New AltaPaciente()
                frm.esAltaPaciente = True
                frm.MdiParent = Me
                frm.Show()

            Case 1
                Dim f As New frmABMMovimientoCaja
                f.esEdicion = False
                f.tipoDeMovimienoConsultorioDefault = True
                f.ShowDialog()



        End Select
    End Sub

    Private Sub MenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemEstudiosCrearRapido.Click
        Dim f As New NuevoEstudioRapido("")
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem29_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub MenuItem30_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Private Sub MenuItem34_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemFacturacionConsultasNueva.Click
        Dim f As New ABMConsultas
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem44_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim f As New FacturacionesInforme
        'f.MdiParent = Me
        'f.Show()
    End Sub

    Private Sub MenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemUsuariosLogIn.Click
        Dim f As New LogIn
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem43_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemEstudiosBuscarAvanzado.Click
        Dim f As New ConsultaEstudiosPro
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem32_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemFacturacionConsultasBuscar.Click
        Dim f As New BuscarConsultas
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem36_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemFacturacionFacturaNueva.Click
        'Nueva Factura
        Dim f As New frmComprobanteNuevo
        f.MdiParent = Me
        f.Show()
    End Sub
    Private Sub itemUsuariosLogOut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemUsuariosLogOut.Click
        Dim sSecurity As Security = Security.GetInstance()
        sSecurity.logOutUser()
        enableDefaultActions()
        Me.Text = "Cedir"
        Me.timerMensajeria.Stop()
    End Sub

    Private Sub enableDefaultActions()
        Me.itemPracticas.Enabled = False
        Me.itemMedicacion.Enabled = False
        Me.itemUsuariosLogIn.Enabled = True
        Me.itemUsuariosLogOut.Enabled = False
        Me.mnuMensajeria.Enabled = False

        Me.itemEstudiosBuscar.Enabled = False
        Me.itemEstudiosBuscarAvanzado.Enabled = False
        Me.itemEstudiosCrearRapido.Enabled = False
        Me.itemMedicos.Enabled = False
        Me.itemMedicosNuevoPago.Enabled = False
        Me.itemMedicosMiCuenta.Enabled = False

        Me.itemObraSocialesBuscar.Enabled = False
        Me.itemPacientes.Enabled = False
        Me.itemPacientesBuscar.Enabled = False
        Me.itemPacientesNuevo.Enabled = False
        Me.itemObraSociales.Enabled = False

        Me.itemFacturacion.Enabled = False
        Me.mnuItemListadoAnestesista.Enabled = False
        Me.mnuComplejidades.Enabled = False
        Me.mnuMedicacion.Enabled = False
        Me.mnuReportes.Enabled = False
        Me.mnuCaja.Enabled = False
        Me.itemComprobantes.Enabled = False

        Me.itemUsuariosABM.Enabled = False

        Me.ToolBar1.Visible = False
    End Sub

    Private Sub itemFacturacionAMRListar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemFacturacionAMRBuscar.Click
        Dim f As New PresentacionAMRBuscar
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub itemFacturacionAMRNueva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemFacturacionAMRNueva.Click
        Dim f As New PresentacionAMRAltaModificacion
        f.Alta = True
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub itemAnestesitasPagos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemAnestesitasPagos.Click
        Dim f As New AnestesistasNuevoPago
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuComprobantesBuscar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemComprobantesBuscar.Click
        Dim f As New ComprobantesBuscar
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuMovimientoCaja_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMovimientoCaja.Click
        Dim f As New frmABMMovimientoCaja
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub mnuListadoCaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuListadoCaja.Click
        Dim f As New frmListadoDeMovimientos
        f.MdiParent = Me
        f.Show()
    End Sub
    Private Sub mnuItemListadoAnestesista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuItemListadoAnestesista.Click
        Dim f As New AnestesistasListadoHonorarios
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub MenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMensajeria.Click
        Dim f As New Mensajeria
        f.MdiParent = Me
        f.Show()
    End Sub


    Private Sub mnuComplejidades_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuComplejidades.Click
        Dim f As New ComplejidadABM
        f.MdiParent = Me
        f.Show()
    End Sub

#Region "Eventos"

    Public Sub mostrarMensajesNoLeidos()

        Dim c As New CatalogoDeMensajes
        Dim arrMensajes As New List(Of Mensaje)
        arrMensajes.Clear()
        arrMensajes = c.traerMensajes()
        If arrMensajes.Count > 0 Then
            Me.nti.Visible = True
            Me.nti.BalloonTipText = "Tiene " & arrMensajes.Count & " Mensajes Sin Leer"
            Me.nfyIcon.ShowBalloonTip(10000)
        End If
        c = Nothing
    End Sub



    Private Sub tmrTemporizador_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrTemporizador.Tick
        Me.mostrarMensajesNoLeidos()
    End Sub

    Private Sub nfyIcon_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles nfyIcon.MouseDoubleClick
        Me.nti.Visible = False
        Me.mnuMensajeria.PerformClick()
    End Sub



    


#End Region


    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim procesos() As Process
        procesos = Process.GetProcessesByName(Application.ProductName.ToString)
        If (procesos.Length <= 1) Then
            ' Continuamos.
        Else 'Hay más de un proceso ejecutandose
            MessageBox.Show("Ya se está ejecutando el programa en otra ventana.La aplicacion se cerrará")
            Application.Exit()
        End If
    End Sub

    Private Sub MenuItem4_Click_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem4.Click
        Dim f As New InformeMensualComprobantes
        f.MdiParent = Me
        f.Show()
    End Sub

    ''' <summary>
    ''' Este metodo nos sirve para saber si existe algun formulario ya abierto.
    ''' Como parametros le pasamos el nombre del form
    ''' </summary>
    ''' <param name="nombreFrm"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function isFormOpened(ByVal nombreFrm As String) As Boolean
        For Each formulario As Form In Application.OpenForms
            If formulario.Name = nombreFrm Then
                formulario.BringToFront()
                Return True
                Exit Function
            End If
        Next
    End Function




    Private Sub mnuMedicMovimientoStock_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedicMovimientoStock.Click
        If Not Me.isFormOpened("MedicamentosMovimientoStock") Then
            Dim f As New MedicamentosMovimientoStock
            f.MdiParent = Me
            f.Show()
        End If
    End Sub

    Private Sub mnuMedicListadoMov_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuMedicListadoMov.Click
        If Not Me.isFormOpened("MedicamentoListadoMovimientos") Then
            Dim f As New MedicamentoListadoMovimientos
            f.MdiParent = Me
            f.Show()
        End If
    End Sub

    Private Sub itemHonorariosCedir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemHonorariosCedir.Click
        Dim f As New ListadoHonorariosCedir
        f.MdiParent = Me
        f.Show()
    End Sub

    Private Sub BarraEstado_PanelClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.StatusBarPanelClickEventArgs) Handles BarraEstado.PanelClick

    End Sub


    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenuItem3.Click
        Dim f As New frmEstudiosMovimientos
        f.Show()
    End Sub

    Private Sub MenuItem5_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub



    Private Sub mnuReemplazarPaciente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuReemplazarPaciente.Click
        Dim f As New frmEliminarPaciente
        f.Show()
    End Sub

    Private Sub itemUsuariosABM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles itemUsuariosABM.Click
        Dim f As New ABMUsuario
        f.MdiParent = Me
        f.Show()
    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub



End Class
