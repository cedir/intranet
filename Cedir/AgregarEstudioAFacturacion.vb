Imports CedirNegocios
Imports System.Collections.Generic
Public Class AgregarEstudioAFacturacion
    Inherits System.Windows.Forms.Form
    Dim cObraSocial As ObraSocial
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(ByVal obraSocial As ObraSocial)
        MyBase.New()

        'El Diseñador de Windows Forms requiere esta llamada.
        InitializeComponent()

        'Agregar cualquier inicialización después de la llamada a InitializeComponent()
        cObraSocial = obraSocial
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
    Friend WithEvents DataGrid1 As System.Windows.Forms.DataGrid
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnNuevo As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.DataGrid1 = New System.Windows.Forms.DataGrid
        Me.btnAceptar = New System.Windows.Forms.Button
        Me.btnNuevo = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGrid1
        '
        Me.DataGrid1.AllowSorting = False
        Me.DataGrid1.DataMember = ""
        Me.DataGrid1.HeaderForeColor = System.Drawing.SystemColors.ControlText
        Me.DataGrid1.Location = New System.Drawing.Point(16, 72)
        Me.DataGrid1.Name = "DataGrid1"
        Me.DataGrid1.ReadOnly = True
        Me.DataGrid1.Size = New System.Drawing.Size(648, 192)
        Me.DataGrid1.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(24, 280)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Agregar"
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(568, 40)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(88, 23)
        Me.btnNuevo.TabIndex = 2
        Me.btnNuevo.Text = "Crear nuevo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(120, 280)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Cerrar"
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.Label1.Location = New System.Drawing.Point(16, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(512, 23)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Label1"
        '
        'AgregarEstudioAFacturacion
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(680, 320)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.DataGrid1)
        Me.Name = "AgregarEstudioAFacturacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "AgregarEstudioAFacturacion"
        CType(Me.DataGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim arrObjects As ArrayList
    'ojo, esta vista sirve tanto para estudios como para consultas
    Dim myTable As DataTable = New DataTable("myTable")
    Dim cCatalogoDeEstudios As New CatalogoDeEstudios
    Dim listaEstudiosYaPresentados As ArrayList
    Public Property listaEstudiosPresentados() As ArrayList
        Get
            Return listaEstudiosYaPresentados
        End Get
        Set(ByVal value As ArrayList)
            listaEstudiosYaPresentados = value
        End Set
    End Property
    Dim com As String = """"
    Private Sub AgregarEstudioAFacturacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Label1.Text = "Obra Social: " & cObraSocial.ObraSocial

        Dim clNombrePaciente As New DataColumn("Paciente", Type.GetType("System.String"))
        Dim clTipoEstudio As New DataColumn("Práctica", Type.GetType("System.String"))
        Dim clMedActuante As New DataColumn("Médico Actuante", Type.GetType("System.String"))
        Dim clMedSolicitante As New DataColumn("Médico Solicitante", Type.GetType("System.String"))
        Dim clFechaEstudio As New DataColumn("Fecha", Type.GetType("System.DateTime"))

        myTable.Columns.Add(clFechaEstudio)
        myTable.Columns.Add(clNombrePaciente)
        myTable.Columns.Add(clTipoEstudio)
        myTable.Columns.Add(clMedActuante)
        myTable.Columns.Add(clMedSolicitante)

        Dim ts1 As New DataGridTableStyle
        ts1.MappingName = "myTable"
        ts1.BackColor = Color.LightGray
        ts1.ForeColor = Color.SlateBlue
        ts1.AlternatingBackColor = Color.White
        ts1.AllowSorting = False

        ts1.HeaderForeColor = Color.MediumSlateBlue
        ts1.HeaderBackColor = Color.WhiteSmoke
        ts1.GridLineColor = Color.MediumPurple

        Dim TextCol0 As New DataGridTextBoxColumn
        TextCol0.MappingName = "Fecha"
        TextCol0.HeaderText = "Fecha"
        TextCol0.Width = 70
        ts1.GridColumnStyles.Add(TextCol0)

        Dim TextCol As New DataGridTextBoxColumn
        TextCol.MappingName = "Paciente"
        TextCol.HeaderText = "Paciente"
        TextCol.Width = 105
        ts1.GridColumnStyles.Add(TextCol)

        Dim TextCol3 As New DataGridTextBoxColumn
        TextCol3.MappingName = "Práctica"
        TextCol3.HeaderText = "Práctica"
        TextCol3.Width = 250
        ts1.GridColumnStyles.Add(TextCol3)

        Dim TextCol4 As New DataGridTextBoxColumn
        TextCol4.MappingName = "Médico Actuante"
        TextCol4.HeaderText = "Médico Actuante"
        TextCol4.Width = 95
        ts1.GridColumnStyles.Add(TextCol4)

        Dim TextCol6 As New DataGridTextBoxColumn
        TextCol6.MappingName = "Médico Solicitante"
        TextCol6.HeaderText = "Médico Solicitante"
        TextCol6.Width = 100
        ts1.GridColumnStyles.Add(TextCol6)

        DataGrid1.TableStyles.Add(ts1)

        Me.Text = "Agregar estudio a facturación"
        cargarEstudios()
    End Sub
    Sub cargarEstudios()



        Dim cEstudio As Estudio
        arrObjects = cCatalogoDeEstudios.traerEstudiosArancelados("where " & com & "idFacturacion" & com & " = 0 and det." & com & "idObraSocial" & com & " = " & cObraSocial.idObraSocial & " and det." & com & "esPagoContraFactura" & com & " = " & 0)
        myTable.Clear()

        If arrObjects.Count = 0 Then
            btnAceptar.Enabled = False
        Else
            Dim NewRow As DataRow
            For i As Integer = 0 To arrObjects.Count - 1
                cEstudio = arrObjects(i)
                NewRow = myTable.NewRow()
                NewRow("Fecha") = cEstudio.fechaEstudio
                NewRow("Práctica") = cEstudio.practica.Estudio
                NewRow("Paciente") = cEstudio.paciente.apellido & ", " & cEstudio.paciente.nombres
                NewRow("Médico Actuante") = cEstudio.medicoActuante.apellido & ", " & cEstudio.medicoActuante.nombre
                NewRow("Médico Solicitante") = cEstudio.medicoSolicitante.apellido & ", " & cEstudio.medicoSolicitante.nombre

                myTable.Rows.Add(NewRow)

            Next
        End If
        myTable.AcceptChanges()
        DataGrid1.DataSource = myTable
    End Sub

    
    Private Sub btnNuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuevo.Click
        'If esAgregarConsulta Then
        '    Dim frm As New ABMConsultas(cObraSocial.ObraSocial)
        '    frm.MdiParent = Me.Parent.Parent
        '    frm.Show()
        'Else
        Dim frm As New NuevoEstudioRapido(cObraSocial.ObraSocial)
        frm.MdiParent = Me.Parent.Parent
        frm.Show()
        ' End If

        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAceptar.Click

        Dim i As Integer
        i = DataGrid1.CurrentRowIndex
        Dim est As Estudio
        est = arrObjects(i)
        nroEstudioParaFacturacion = est.nroEstudio
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub eliminarEstudiosYaPresentados()

    End Sub



End Class
