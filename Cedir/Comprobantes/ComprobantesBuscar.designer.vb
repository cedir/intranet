<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComprobantesBuscar
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.grpFiltro = New System.Windows.Forms.GroupBox
        Me.grpComprobante = New System.Windows.Forms.GroupBox
        Me.lblNombreCliente = New System.Windows.Forms.Label
        Me.txtNombreCliente = New System.Windows.Forms.TextBox
        Me.lblNroComprobante = New System.Windows.Forms.Label
        Me.txtNroComprobante = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbResponsable = New System.Windows.Forms.ComboBox
        Me.cmbTipoComprobante = New System.Windows.Forms.ComboBox
        Me.lblResponsable = New System.Windows.Forms.Label
        Me.btnBuscar = New System.Windows.Forms.Button
        Me.grpPeriodo = New System.Windows.Forms.GroupBox
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar
        Me.btnSelFechaHasta = New System.Windows.Forms.Button
        Me.btnSelFechaDesde = New System.Windows.Forms.Button
        Me.txtFechaHasta = New System.Windows.Forms.TextBox
        Me.txtFechaDesde = New System.Windows.Forms.TextBox
        Me.lblHasta = New System.Windows.Forms.Label
        Me.lblDesde = New System.Windows.Forms.Label
        Me.datagridComprobantes = New System.Windows.Forms.DataGridView
        Me.grpComprobantes = New System.Windows.Forms.GroupBox
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.btnVer = New System.Windows.Forms.Button
        Me.btnAgregarComprobante = New System.Windows.Forms.Button
        Me.btnImprimir = New System.Windows.Forms.Button
        Me.grpFiltro.SuspendLayout()
        Me.grpComprobante.SuspendLayout()
        Me.grpPeriodo.SuspendLayout()
        CType(Me.datagridComprobantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpComprobantes.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpFiltro
        '
        Me.grpFiltro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpFiltro.Controls.Add(Me.grpComprobante)
        Me.grpFiltro.Controls.Add(Me.btnBuscar)
        Me.grpFiltro.Controls.Add(Me.grpPeriodo)
        Me.grpFiltro.Location = New System.Drawing.Point(12, 0)
        Me.grpFiltro.Name = "grpFiltro"
        Me.grpFiltro.Size = New System.Drawing.Size(718, 198)
        Me.grpFiltro.TabIndex = 0
        Me.grpFiltro.TabStop = False
        Me.grpFiltro.Text = "Buscar comprobante"
        '
        'grpComprobante
        '
        Me.grpComprobante.Controls.Add(Me.lblNombreCliente)
        Me.grpComprobante.Controls.Add(Me.txtNombreCliente)
        Me.grpComprobante.Controls.Add(Me.lblNroComprobante)
        Me.grpComprobante.Controls.Add(Me.txtNroComprobante)
        Me.grpComprobante.Controls.Add(Me.Label2)
        Me.grpComprobante.Controls.Add(Me.cmbResponsable)
        Me.grpComprobante.Controls.Add(Me.cmbTipoComprobante)
        Me.grpComprobante.Controls.Add(Me.lblResponsable)
        Me.grpComprobante.Location = New System.Drawing.Point(6, 19)
        Me.grpComprobante.Name = "grpComprobante"
        Me.grpComprobante.Size = New System.Drawing.Size(325, 138)
        Me.grpComprobante.TabIndex = 13
        Me.grpComprobante.TabStop = False
        Me.grpComprobante.Text = "Comprobante"
        '
        'lblNombreCliente
        '
        Me.lblNombreCliente.AutoSize = True
        Me.lblNombreCliente.Location = New System.Drawing.Point(6, 110)
        Me.lblNombreCliente.Name = "lblNombreCliente"
        Me.lblNombreCliente.Size = New System.Drawing.Size(132, 13)
        Me.lblNombreCliente.TabIndex = 12
        Me.lblNombreCliente.Text = "Nombre del Cliente           :"
        '
        'txtNombreCliente
        '
        Me.txtNombreCliente.Location = New System.Drawing.Point(152, 107)
        Me.txtNombreCliente.Name = "txtNombreCliente"
        Me.txtNombreCliente.Size = New System.Drawing.Size(155, 20)
        Me.txtNombreCliente.TabIndex = 11
        Me.txtNombreCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNroComprobante
        '
        Me.lblNroComprobante.AutoSize = True
        Me.lblNroComprobante.Location = New System.Drawing.Point(6, 27)
        Me.lblNroComprobante.Name = "lblNroComprobante"
        Me.lblNroComprobante.Size = New System.Drawing.Size(133, 13)
        Me.lblNroComprobante.TabIndex = 4
        Me.lblNroComprobante.Text = "Número de comprobante  :"
        '
        'txtNroComprobante
        '
        Me.txtNroComprobante.Location = New System.Drawing.Point(152, 27)
        Me.txtNroComprobante.Name = "txtNroComprobante"
        Me.txtNroComprobante.Size = New System.Drawing.Size(155, 20)
        Me.txtNroComprobante.TabIndex = 1
        Me.txtNroComprobante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Tipo de comprobante       :"
        '
        'cmbResponsable
        '
        Me.cmbResponsable.FormattingEnabled = True
        Me.cmbResponsable.Items.AddRange(New Object() {"Ninguno", "Cedir", "Brunetti"})
        Me.cmbResponsable.Location = New System.Drawing.Point(152, 80)
        Me.cmbResponsable.Name = "cmbResponsable"
        Me.cmbResponsable.Size = New System.Drawing.Size(155, 21)
        Me.cmbResponsable.TabIndex = 3
        '
        'cmbTipoComprobante
        '
        Me.cmbTipoComprobante.FormattingEnabled = True
        Me.cmbTipoComprobante.Items.AddRange(New Object() {"Ninguno", "Factura", "Liquidacion", "Nota De Debito", "Nota De Credito"})
        Me.cmbTipoComprobante.Location = New System.Drawing.Point(152, 53)
        Me.cmbTipoComprobante.Name = "cmbTipoComprobante"
        Me.cmbTipoComprobante.Size = New System.Drawing.Size(155, 21)
        Me.cmbTipoComprobante.TabIndex = 2
        '
        'lblResponsable
        '
        Me.lblResponsable.AutoSize = True
        Me.lblResponsable.Location = New System.Drawing.Point(6, 88)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(132, 13)
        Me.lblResponsable.TabIndex = 10
        Me.lblResponsable.Text = "Responsable                    :"
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(6, 163)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(75, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Buscar"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'grpPeriodo
        '
        Me.grpPeriodo.Controls.Add(Me.MonthCalendar1)
        Me.grpPeriodo.Controls.Add(Me.btnSelFechaHasta)
        Me.grpPeriodo.Controls.Add(Me.btnSelFechaDesde)
        Me.grpPeriodo.Controls.Add(Me.txtFechaHasta)
        Me.grpPeriodo.Controls.Add(Me.txtFechaDesde)
        Me.grpPeriodo.Controls.Add(Me.lblHasta)
        Me.grpPeriodo.Controls.Add(Me.lblDesde)
        Me.grpPeriodo.Location = New System.Drawing.Point(362, 19)
        Me.grpPeriodo.Name = "grpPeriodo"
        Me.grpPeriodo.Size = New System.Drawing.Size(350, 138)
        Me.grpPeriodo.TabIndex = 8
        Me.grpPeriodo.TabStop = False
        Me.grpPeriodo.Text = "Período"
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonthCalendar1.Location = New System.Drawing.Point(180, 17)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.ScrollChange = 1
        Me.MonthCalendar1.ShowToday = False
        Me.MonthCalendar1.TabIndex = 34
        Me.MonthCalendar1.Visible = False
        '
        'btnSelFechaHasta
        '
        Me.btnSelFechaHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelFechaHasta.Location = New System.Drawing.Point(181, 40)
        Me.btnSelFechaHasta.Name = "btnSelFechaHasta"
        Me.btnSelFechaHasta.Size = New System.Drawing.Size(75, 18)
        Me.btnSelFechaHasta.TabIndex = 33
        Me.btnSelFechaHasta.Text = "Seleccione..."
        Me.btnSelFechaHasta.UseVisualStyleBackColor = True
        '
        'btnSelFechaDesde
        '
        Me.btnSelFechaDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelFechaDesde.Location = New System.Drawing.Point(181, 17)
        Me.btnSelFechaDesde.Name = "btnSelFechaDesde"
        Me.btnSelFechaDesde.Size = New System.Drawing.Size(75, 18)
        Me.btnSelFechaDesde.TabIndex = 32
        Me.btnSelFechaDesde.Text = "Seleccione..."
        Me.btnSelFechaDesde.UseVisualStyleBackColor = True
        '
        'txtFechaHasta
        '
        Me.txtFechaHasta.Location = New System.Drawing.Point(71, 45)
        Me.txtFechaHasta.Name = "txtFechaHasta"
        Me.txtFechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaHasta.TabIndex = 5
        Me.txtFechaHasta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaDesde
        '
        Me.txtFechaDesde.Location = New System.Drawing.Point(71, 19)
        Me.txtFechaDesde.Name = "txtFechaDesde"
        Me.txtFechaDesde.Size = New System.Drawing.Size(100, 20)
        Me.txtFechaDesde.TabIndex = 4
        Me.txtFechaDesde.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblHasta
        '
        Me.lblHasta.AutoSize = True
        Me.lblHasta.Location = New System.Drawing.Point(11, 52)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(35, 13)
        Me.lblHasta.TabIndex = 7
        Me.lblHasta.Text = "Hasta"
        '
        'lblDesde
        '
        Me.lblDesde.AutoSize = True
        Me.lblDesde.Location = New System.Drawing.Point(8, 19)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(38, 13)
        Me.lblDesde.TabIndex = 6
        Me.lblDesde.Text = "Desde"
        '
        'datagridComprobantes
        '
        Me.datagridComprobantes.AllowUserToAddRows = False
        Me.datagridComprobantes.AllowUserToDeleteRows = False
        Me.datagridComprobantes.AllowUserToResizeColumns = False
        Me.datagridComprobantes.AllowUserToResizeRows = False
        Me.datagridComprobantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.datagridComprobantes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders
        Me.datagridComprobantes.CausesValidation = False
        Me.datagridComprobantes.ColumnHeadersHeight = 20
        Me.datagridComprobantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.datagridComprobantes.DefaultCellStyle = DataGridViewCellStyle1
        Me.datagridComprobantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.datagridComprobantes.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.datagridComprobantes.Location = New System.Drawing.Point(3, 16)
        Me.datagridComprobantes.MultiSelect = False
        Me.datagridComprobantes.Name = "datagridComprobantes"
        Me.datagridComprobantes.ReadOnly = True
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.datagridComprobantes.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.datagridComprobantes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        Me.datagridComprobantes.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.datagridComprobantes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.datagridComprobantes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datagridComprobantes.ShowCellErrors = False
        Me.datagridComprobantes.ShowCellToolTips = False
        Me.datagridComprobantes.ShowEditingIcon = False
        Me.datagridComprobantes.ShowRowErrors = False
        Me.datagridComprobantes.Size = New System.Drawing.Size(712, 211)
        Me.datagridComprobantes.TabIndex = 10
        Me.datagridComprobantes.TabStop = False
        '
        'grpComprobantes
        '
        Me.grpComprobantes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpComprobantes.Controls.Add(Me.datagridComprobantes)
        Me.grpComprobantes.Location = New System.Drawing.Point(12, 204)
        Me.grpComprobantes.Name = "grpComprobantes"
        Me.grpComprobantes.Size = New System.Drawing.Size(718, 230)
        Me.grpComprobantes.TabIndex = 8
        Me.grpComprobantes.TabStop = False
        Me.grpComprobantes.Text = "Comprobantes"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(652, 480)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 9
        Me.btnCerrar.Text = "Cerrar"
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'btnVer
        '
        Me.btnVer.Location = New System.Drawing.Point(12, 480)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(75, 23)
        Me.btnVer.TabIndex = 10
        Me.btnVer.Text = "Ver"
        Me.btnVer.UseVisualStyleBackColor = True
        '
        'btnAgregarComprobante
        '
        Me.btnAgregarComprobante.Location = New System.Drawing.Point(93, 480)
        Me.btnAgregarComprobante.Name = "btnAgregarComprobante"
        Me.btnAgregarComprobante.Size = New System.Drawing.Size(123, 23)
        Me.btnAgregarComprobante.TabIndex = 11
        Me.btnAgregarComprobante.Text = "Agregar comprobante"
        Me.btnAgregarComprobante.UseVisualStyleBackColor = True
        Me.btnAgregarComprobante.Visible = False
        '
        'btnImprimir
        '
        Me.btnImprimir.Location = New System.Drawing.Point(546, 480)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(75, 23)
        Me.btnImprimir.TabIndex = 12
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.UseVisualStyleBackColor = True
        Me.btnImprimir.Visible = False
        '
        'ComprobantesBuscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(740, 524)
        Me.Controls.Add(Me.btnImprimir)
        Me.Controls.Add(Me.btnAgregarComprobante)
        Me.Controls.Add(Me.btnVer)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.grpComprobantes)
        Me.Controls.Add(Me.grpFiltro)
        Me.Name = "ComprobantesBuscar"
        Me.Text = "Buscar Comprobante"
        Me.grpFiltro.ResumeLayout(False)
        Me.grpComprobante.ResumeLayout(False)
        Me.grpComprobante.PerformLayout()
        Me.grpPeriodo.ResumeLayout(False)
        Me.grpPeriodo.PerformLayout()
        CType(Me.datagridComprobantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpComprobantes.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpFiltro As System.Windows.Forms.GroupBox
    Friend WithEvents datagridComprobantes As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblNroComprobante As System.Windows.Forms.Label
    Friend WithEvents txtNroComprobante As System.Windows.Forms.TextBox
    Friend WithEvents lblDesde As System.Windows.Forms.Label
    Friend WithEvents cmbTipoComprobante As System.Windows.Forms.ComboBox
    Friend WithEvents grpComprobantes As System.Windows.Forms.GroupBox
    Friend WithEvents grpPeriodo As System.Windows.Forms.GroupBox
    Friend WithEvents lblHasta As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents lblResponsable As System.Windows.Forms.Label
    Friend WithEvents cmbResponsable As System.Windows.Forms.ComboBox
    Friend WithEvents grpComprobante As System.Windows.Forms.GroupBox
    Friend WithEvents txtFechaHasta As System.Windows.Forms.TextBox
    Friend WithEvents txtFechaDesde As System.Windows.Forms.TextBox

    Public Sub New()

        ' Llamada necesaria para el Diseñador de Windows Forms.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().

    End Sub

    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Friend WithEvents btnVer As System.Windows.Forms.Button
    Friend WithEvents btnAgregarComprobante As System.Windows.Forms.Button
    Friend WithEvents btnImprimir As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents btnSelFechaHasta As System.Windows.Forms.Button
    Friend WithEvents btnSelFechaDesde As System.Windows.Forms.Button
    Friend WithEvents lblNombreCliente As System.Windows.Forms.Label
    Friend WithEvents txtNombreCliente As System.Windows.Forms.TextBox
End Class
