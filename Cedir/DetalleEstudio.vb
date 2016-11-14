Imports CedirNegocios
Imports System.Collections.Generic
Public Class DetalleEstudio
    Inherits System.Windows.Forms.Form
    Dim cEstudio As Estudio
    Friend WithEvents lblCreateUser As System.Windows.Forms.Label
    Friend WithEvents lblPublicID As System.Windows.Forms.Label
    Dim cFacturacion As Presentacion
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal estudio As estudio)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cEstudio = estudio

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
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnEditar As System.Windows.Forms.Button
    Friend WithEvents lblPractica As System.Windows.Forms.Label
    Friend WithEvents lblFecha As System.Windows.Forms.Label
    Friend WithEvents lblObraSocial As System.Windows.Forms.Label
    Friend WithEvents lblMedicoActuante As System.Windows.Forms.Label
    Friend WithEvents lblMedicoSolicitante As System.Windows.Forms.Label
    Friend WithEvents lblPaciente As System.Windows.Forms.Label
    Friend WithEvents lblMotivoEstudio As System.Windows.Forms.Label
    Friend WithEvents txtInforme As System.Windows.Forms.TextBox
    Friend WithEvents lblFacturacion As System.Windows.Forms.Label
    Friend WithEvents lblPagoMedico As System.Windows.Forms.Label
    Friend WithEvents lblAnestesista As System.Windows.Forms.Label
    Friend WithEvents btnIraFacturacion As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.lblCreateUser = New System.Windows.Forms.Label
        Me.txtInforme = New System.Windows.Forms.TextBox
        Me.lblMotivoEstudio = New System.Windows.Forms.Label
        Me.lblPaciente = New System.Windows.Forms.Label
        Me.lblMedicoSolicitante = New System.Windows.Forms.Label
        Me.lblMedicoActuante = New System.Windows.Forms.Label
        Me.lblObraSocial = New System.Windows.Forms.Label
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.btnIraFacturacion = New System.Windows.Forms.Button
        Me.lblPagoMedico = New System.Windows.Forms.Label
        Me.lblFacturacion = New System.Windows.Forms.Label
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.lblAnestesista = New System.Windows.Forms.Label
        Me.btnEditar = New System.Windows.Forms.Button
        Me.lblPractica = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.lblPublicID = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(133, 435)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(72, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(29, 99)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(480, 330)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCreateUser)
        Me.TabPage1.Controls.Add(Me.txtInforme)
        Me.TabPage1.Controls.Add(Me.lblMotivoEstudio)
        Me.TabPage1.Controls.Add(Me.lblPaciente)
        Me.TabPage1.Controls.Add(Me.lblMedicoSolicitante)
        Me.TabPage1.Controls.Add(Me.lblMedicoActuante)
        Me.TabPage1.Controls.Add(Me.lblObraSocial)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(472, 304)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Estudio"
        '
        'lblCreateUser
        '
        Me.lblCreateUser.AutoSize = True
        Me.lblCreateUser.Location = New System.Drawing.Point(16, 135)
        Me.lblCreateUser.Name = "lblCreateUser"
        Me.lblCreateUser.Size = New System.Drawing.Size(97, 13)
        Me.lblCreateUser.TabIndex = 6
        Me.lblCreateUser.Text = "usuario que lo creo"
        '
        'txtInforme
        '
        Me.txtInforme.Location = New System.Drawing.Point(16, 202)
        Me.txtInforme.Multiline = True
        Me.txtInforme.Name = "txtInforme"
        Me.txtInforme.ReadOnly = True
        Me.txtInforme.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtInforme.Size = New System.Drawing.Size(440, 80)
        Me.txtInforme.TabIndex = 5
        '
        'lblMotivoEstudio
        '
        Me.lblMotivoEstudio.Location = New System.Drawing.Point(16, 162)
        Me.lblMotivoEstudio.Name = "lblMotivoEstudio"
        Me.lblMotivoEstudio.Size = New System.Drawing.Size(440, 32)
        Me.lblMotivoEstudio.TabIndex = 4
        Me.lblMotivoEstudio.Text = "Motivo estudio"
        '
        'lblPaciente
        '
        Me.lblPaciente.Location = New System.Drawing.Point(16, 112)
        Me.lblPaciente.Name = "lblPaciente"
        Me.lblPaciente.Size = New System.Drawing.Size(360, 23)
        Me.lblPaciente.TabIndex = 3
        Me.lblPaciente.Text = "Paciente"
        '
        'lblMedicoSolicitante
        '
        Me.lblMedicoSolicitante.Location = New System.Drawing.Point(16, 80)
        Me.lblMedicoSolicitante.Name = "lblMedicoSolicitante"
        Me.lblMedicoSolicitante.Size = New System.Drawing.Size(360, 23)
        Me.lblMedicoSolicitante.TabIndex = 2
        Me.lblMedicoSolicitante.Text = "medico solicitante"
        '
        'lblMedicoActuante
        '
        Me.lblMedicoActuante.Location = New System.Drawing.Point(16, 48)
        Me.lblMedicoActuante.Name = "lblMedicoActuante"
        Me.lblMedicoActuante.Size = New System.Drawing.Size(368, 23)
        Me.lblMedicoActuante.TabIndex = 1
        Me.lblMedicoActuante.Text = "medico actuante"
        '
        'lblObraSocial
        '
        Me.lblObraSocial.Location = New System.Drawing.Point(16, 13)
        Me.lblObraSocial.Name = "lblObraSocial"
        Me.lblObraSocial.Size = New System.Drawing.Size(440, 32)
        Me.lblObraSocial.TabIndex = 0
        Me.lblObraSocial.Text = "Obra Social"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnIraFacturacion)
        Me.TabPage2.Controls.Add(Me.lblPagoMedico)
        Me.TabPage2.Controls.Add(Me.lblFacturacion)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(472, 295)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Facturación"
        '
        'btnIraFacturacion
        '
        Me.btnIraFacturacion.Enabled = False
        Me.btnIraFacturacion.Location = New System.Drawing.Point(16, 80)
        Me.btnIraFacturacion.Name = "btnIraFacturacion"
        Me.btnIraFacturacion.Size = New System.Drawing.Size(96, 23)
        Me.btnIraFacturacion.TabIndex = 2
        Me.btnIraFacturacion.Text = "Ir a Facturación"
        '
        'lblPagoMedico
        '
        Me.lblPagoMedico.Location = New System.Drawing.Point(16, 120)
        Me.lblPagoMedico.Name = "lblPagoMedico"
        Me.lblPagoMedico.Size = New System.Drawing.Size(424, 72)
        Me.lblPagoMedico.TabIndex = 1
        Me.lblPagoMedico.Text = "medico"
        '
        'lblFacturacion
        '
        Me.lblFacturacion.Location = New System.Drawing.Point(16, 24)
        Me.lblFacturacion.Name = "lblFacturacion"
        Me.lblFacturacion.Size = New System.Drawing.Size(432, 48)
        Me.lblFacturacion.TabIndex = 0
        Me.lblFacturacion.Text = "datos facturacion"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.lblAnestesista)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(472, 295)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Medicación"
        '
        'lblAnestesista
        '
        Me.lblAnestesista.Location = New System.Drawing.Point(24, 24)
        Me.lblAnestesista.Name = "lblAnestesista"
        Me.lblAnestesista.Size = New System.Drawing.Size(344, 23)
        Me.lblAnestesista.TabIndex = 0
        Me.lblAnestesista.Text = "Anestesista"
        '
        'btnEditar
        '
        Me.btnEditar.Location = New System.Drawing.Point(29, 435)
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(75, 23)
        Me.btnEditar.TabIndex = 5
        Me.btnEditar.Text = "Editar"
        '
        'lblPractica
        '
        Me.lblPractica.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPractica.Location = New System.Drawing.Point(32, 36)
        Me.lblPractica.Name = "lblPractica"
        Me.lblPractica.Size = New System.Drawing.Size(480, 36)
        Me.lblPractica.TabIndex = 6
        Me.lblPractica.Text = "Práctica:"
        '
        'lblFecha
        '
        Me.lblFecha.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFecha.Location = New System.Drawing.Point(32, 12)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(384, 16)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "fecha"
        '
        'lblPublicID
        '
        Me.lblPublicID.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPublicID.Location = New System.Drawing.Point(32, 62)
        Me.lblPublicID.Name = "lblPublicID"
        Me.lblPublicID.Size = New System.Drawing.Size(384, 16)
        Me.lblPublicID.TabIndex = 8
        Me.lblPublicID.Text = "Public ID .................:   "
        '
        'DetalleEstudio
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(552, 483)
        Me.Controls.Add(Me.lblPublicID)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblPractica)
        Me.Controls.Add(Me.btnEditar)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Name = "DetalleEstudio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle del Estudio"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub DetalleEstudio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'SI ESTA COBRADO, QUE MUESTRE EL IMPORTE DE MEDICACION (SIRVE PARA PAGO A MEDICO)

        lblFecha.Text = "Fecha del estudio: " & cEstudio.fechaEstudio
        Me.lblPublicID.Text = Me.lblPublicID.Text & cEstudio.publicID
        lblPractica.Text = cEstudio.practica.Estudio
        lblObraSocial.Text = "Obra Social: " & cEstudio.obraSocial.ObraSocial
        lblMedicoActuante.Text = "Médico Actuante: " & cEstudio.medicoActuante.apellido & ", " & cEstudio.medicoActuante.nombre
        lblMedicoSolicitante.Text = "Médico Solicitante: " & cEstudio.medicoSolicitante.apellido & ", " & cEstudio.medicoSolicitante.nombre
        lblPaciente.Text = "Paciente: " & cEstudio.paciente.apellido & ", " & cEstudio.paciente.nombres & "(Nro afilado: " & cEstudio.paciente.nroAfiliado & ")"
        lblMotivoEstudio.Text = "Motivo del estudio: " & cEstudio.motivoEstudio
        txtInforme.Text = "Informe: " & cEstudio.informe

        Dim auditCatalog As New CatalogoDeAuditLogs
        Dim arrLogs As List(Of AuditLog) = auditCatalog.buscar(1, 1, cEstudio.nroEstudio)
        If arrLogs.Count <> 0 Then
            Dim log As AuditLog = arrLogs(0)
            lblCreateUser.Text = "Creado por: " & log.usuario.nombreUsuario
        Else
            arrLogs = auditCatalog.buscarNew(cEstudio.nroEstudio, "estudio", "estudio")
            If arrLogs.Count <> 0 Then
                Dim log As AuditLog = arrLogs(0)
                lblCreateUser.Text = "Creado por: " & log.usuario.nombreUsuario
            Else
                lblCreateUser.Text = "Creado por: desconocido"
            End If
        End If

            If cEstudio.idFacturacion = 0 Then
            lblFacturacion.Text = "El estudio no fue presentado"
        Else
            Dim catalogoDeFacturacion As New CatalogoDePresentaciones
            cFacturacion = catalogoDeFacturacion.find(cEstudio.idFacturacion)
            lblFacturacion.Text = "Presentado el " & cFacturacion.fechaFacturacion
            lblFacturacion.Text &= vbCrLf & "Nro de Factura: " & cFacturacion.comprobante.NroComprobante.ToString()
            lblFacturacion.Text &= vbCrLf & "Estado: " & cFacturacion.estado
            btnIraFacturacion.Enabled = True
            restrictUpdate()
        End If

        If cEstudio.nroPagoMedicoActuante = 0 Then
            lblPagoMedico.Text = "El estudio no fue pagado al correspondiente médico actuante"
        Else
            lblPagoMedico.Text = "Código de pago al médico actuante: " & cEstudio.nroPagoMedicoActuante
        End If

        If cEstudio.medicoActuante.idMedico <> cEstudio.medicoSolicitante.idMedico Then
            If cEstudio.nroPagoMedicoSolicitante = 0 Then
                lblPagoMedico.Text &= vbCrLf & "El estudio no fue pagado al correspondiente médico solicitante"
            Else
                lblPagoMedico.Text &= vbCrLf & "Código de pago al médico solicitante: " & cEstudio.nroPagoMedicoSolicitante
            End If
        End If



        'Medicacion
        Dim cAnestesista As Medico = cEstudio.getAnestesista
        lblAnestesista.Text = "Médico anestesiólogo: " & cAnestesista.nombreCompleto
    End Sub

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnEditar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditar.Click
        Dim frm As New NuevoEstudio(cEstudio)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
        Me.Close()
    End Sub

    Private Sub restrictUpdate()
        btnEditar.Enabled = False
    End Sub

    Private Sub btnIraFacturacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIraFacturacion.Click

        If cFacturacion.pagado = 0 Then
            Dim frm As New FacturacionDetalle(cFacturacion.idPresentacion)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        ElseIf cFacturacion.pagado = 1 Then
            'Cobrado
            Dim frm As New FacturacionCobradaDetalle(cFacturacion)
            frm.MdiParent = Me.Parent.Parent
            frm.Show()
        ElseIf cFacturacion.pagado = 2 Then
            MsgBox("La facturacion no puede visalizarse porque se encuentra en estado Abierto.", MsgBoxStyle.Critical)
        End If

    End Sub

End Class
