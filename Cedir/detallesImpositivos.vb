Imports CedirNegocios
Imports System.Collections.Generic
Public Class detallesImpositivos
    Inherits System.Windows.Forms.Form
    Dim currentEstudio As Estudio
#Region " Código generado por el Diseñador de Windows Forms "

    Public Sub New(Optional ByVal est As Estudio = Nothing)
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
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents txtPorEstudio As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtPension As System.Windows.Forms.TextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lblInfo As System.Windows.Forms.Label
    Friend WithEvents btnAnularPago As System.Windows.Forms.Button
    Friend WithEvents btnAplicarPCF As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtImportePagoCF As System.Windows.Forms.TextBox
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents btnAplicarArancelAnestesia As System.Windows.Forms.Button
    Friend WithEvents txtImporteArancelAnestesia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblValorPenisionAprox As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtPorEstudio = New System.Windows.Forms.TextBox
        Me.btnGuardar = New System.Windows.Forms.Button
        Me.btnCerrar = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPension = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtImportePagoCF = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnAnularPago = New System.Windows.Forms.Button
        Me.btnAplicarPCF = New System.Windows.Forms.Button
        Me.TabPage3 = New System.Windows.Forms.TabPage
        Me.btnAplicarArancelAnestesia = New System.Windows.Forms.Button
        Me.txtImporteArancelAnestesia = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lblInfo = New System.Windows.Forms.Label
        Me.lblValorPenisionAprox = New System.Windows.Forms.Label
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPorEstudio
        '
        Me.txtPorEstudio.Location = New System.Drawing.Point(128, 48)
        Me.txtPorEstudio.Name = "txtPorEstudio"
        Me.txtPorEstudio.Size = New System.Drawing.Size(56, 20)
        Me.txtPorEstudio.TabIndex = 1
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(112, 88)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 2
        Me.btnGuardar.Text = "Guardar"
        '
        'btnCerrar
        '
        Me.btnCerrar.Location = New System.Drawing.Point(400, 232)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(75, 23)
        Me.btnCerrar.TabIndex = 3
        Me.btnCerrar.Text = "Cerrar"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 23)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Diferrencia Paciente: $"
        '
        'txtPension
        '
        Me.txtPension.Location = New System.Drawing.Point(128, 16)
        Me.txtPension.Name = "txtPension"
        Me.txtPension.Size = New System.Drawing.Size(56, 20)
        Me.txtPension.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(64, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Pensión: $"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(32, 24)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(448, 192)
        Me.TabControl1.TabIndex = 11
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblValorPenisionAprox)
        Me.TabPage1.Controls.Add(Me.txtPension)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.btnGuardar)
        Me.TabPage1.Controls.Add(Me.txtPorEstudio)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(440, 166)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Actualizar Importes"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.txtImportePagoCF)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Controls.Add(Me.btnAnularPago)
        Me.TabPage2.Controls.Add(Me.btnAplicarPCF)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Size = New System.Drawing.Size(440, 166)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Pago Contra Factura"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(32, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Importe:"
        '
        'txtImportePagoCF
        '
        Me.txtImportePagoCF.Location = New System.Drawing.Point(112, 56)
        Me.txtImportePagoCF.Name = "txtImportePagoCF"
        Me.txtImportePagoCF.Size = New System.Drawing.Size(100, 20)
        Me.txtImportePagoCF.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(40, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 23)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Label1"
        '
        'btnAnularPago
        '
        Me.btnAnularPago.Location = New System.Drawing.Point(128, 104)
        Me.btnAnularPago.Name = "btnAnularPago"
        Me.btnAnularPago.Size = New System.Drawing.Size(75, 23)
        Me.btnAnularPago.TabIndex = 8
        Me.btnAnularPago.Text = "Anular"
        '
        'btnAplicarPCF
        '
        Me.btnAplicarPCF.Location = New System.Drawing.Point(32, 104)
        Me.btnAplicarPCF.Name = "btnAplicarPCF"
        Me.btnAplicarPCF.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarPCF.TabIndex = 5
        Me.btnAplicarPCF.Text = "Aplicar"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.btnAplicarArancelAnestesia)
        Me.TabPage3.Controls.Add(Me.txtImporteArancelAnestesia)
        Me.TabPage3.Controls.Add(Me.Label5)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(440, 166)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Arancel Anestesia"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'btnAplicarArancelAnestesia
        '
        Me.btnAplicarArancelAnestesia.Location = New System.Drawing.Point(24, 65)
        Me.btnAplicarArancelAnestesia.Name = "btnAplicarArancelAnestesia"
        Me.btnAplicarArancelAnestesia.Size = New System.Drawing.Size(75, 23)
        Me.btnAplicarArancelAnestesia.TabIndex = 2
        Me.btnAplicarArancelAnestesia.Text = "Aplicar"
        Me.btnAplicarArancelAnestesia.UseVisualStyleBackColor = True
        '
        'txtImporteArancelAnestesia
        '
        Me.txtImporteArancelAnestesia.Location = New System.Drawing.Point(137, 7)
        Me.txtImporteArancelAnestesia.Name = "txtImporteArancelAnestesia"
        Me.txtImporteArancelAnestesia.Size = New System.Drawing.Size(174, 20)
        Me.txtImporteArancelAnestesia.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Importe ..........:    $"
        '
        'lblInfo
        '
        Me.lblInfo.Location = New System.Drawing.Point(40, 224)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(344, 32)
        Me.lblInfo.TabIndex = 8
        Me.lblInfo.Text = "Label5"
        '
        'lblValorPenisionAprox
        '
        Me.lblValorPenisionAprox.AutoSize = True
        Me.lblValorPenisionAprox.Location = New System.Drawing.Point(206, 19)
        Me.lblValorPenisionAprox.Name = "lblValorPenisionAprox"
        Me.lblValorPenisionAprox.Size = New System.Drawing.Size(96, 13)
        Me.lblValorPenisionAprox.TabIndex = 11
        Me.lblValorPenisionAprox.Text = "Pensión Aprox...: $"
        '
        'detallesImpositivos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(504, 272)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.lblInfo)
        Me.Name = "detallesImpositivos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Importes"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private listEstudio As New List(Of Estudio)

    Public Property ListaEstudios() As List(Of Estudio)
        Get
            Return listEstudio
        End Get
        Set(ByVal value As List(Of Estudio))
            listEstudio = value
        End Set
    End Property

    Private Sub btnCerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub btnGuardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGuardar.Click
        Dim resp As String
        If txtPorEstudio.Text = "" Or txtPension.Text = "" Then
            MsgBox("Los importes no pueden estar vacios. En caso de que no tengan un importe definido, completar con el valor 0 (cero)")
        Else
            For Each currentestudio As Estudio In Me.ListaEstudios
                currentestudio.DiferenciaPaciente = CSng(txtPorEstudio.Text)
                currentestudio.pension = CSng(txtPension.Text)
                resp = currentestudio.actualizarImportes()
                If resp <> "ok" Then
                    MsgBox("Error al guardar los datos")
                End If
            Next
        End If

    End Sub

    Private Sub detallesImpositivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.ListaEstudios.Count > 1 Then
            MessageBox.Show("Hay mas de un estudio. Sólo se permitirá realizar pagos contra factura.")
            Me.TabPage1.Hide()
        Else
            currentEstudio = Me.ListaEstudios(0)
            txtPorEstudio.Text = currentEstudio.DiferenciaPaciente
            txtPension.Text = currentEstudio.pension
            Me.lblValorPenisionAprox.Text = Me.lblValorPenisionAprox.Text + currentEstudio.obraSocial.valorAproximadoDePension.ToString()
            If currentEstudio.idFacturacion <> 0 Then
                lblInfo.Text = "Los datos no pueden ser modificados debido a que el estudio se encuentra facturado"
                btnGuardar.Enabled = False
                btnAplicarPCF.Enabled = False
                btnAnularPago.Enabled = False
            Else
                lblInfo.Visible = False
            End If


            'Pago contra factura
            If currentEstudio.esPagoContraFactura = 1 Then
                Label1.Text = "Click en Anular para anular el pago contra factura"
                btnAplicarPCF.Enabled = False
            Else
                Label1.Text = "Click en aplicar para dar de pago contra factura"
                btnAnularPago.Enabled = False
            End If

        End If

    End Sub

    Private Sub btnAplicarPCF_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarPCF.Click
        'Una vez terminado pagoContraFactura, revisar la condicion de loadEstudios en facturacion, ya que debe validar tambien que no este pagoContraFactura
        Dim resp As String
        Dim r As Integer
        r = MsgBox("¿Esta seguro que desea guardar los cambios ?", MsgBoxStyle.YesNo, "¿Guardar como Pagado contra Facturación?")
        If Me.validatePCF() Then
            If r = 6 Then
                For Each currentestudio As Estudio In Me.ListaEstudios
                    currentestudio.esPagoContraFactura = 1
                    currentestudio.PagoContraFactura = Convert.ToDecimal(Me.txtImportePagoCF.Text)
                    currentestudio.fechaCobro = Date.Today
                    resp = currentestudio.setPagoContraFactura()

                    btnAnularPago.Enabled = True
                    btnAplicarPCF.Enabled = False
                Next
            End If
        End If 'fin validarPCF
    End Sub

    Private Sub btnAnularPago_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnularPago.Click
        Dim resp As String
        Dim r As Integer
        r = MsgBox("¿Esta seguro que desea anular el pago contra factura ?", MsgBoxStyle.YesNo, "Anular pago contra factura")
        If Me.validatePCF() = True Then
            If r = 6 Then
                For Each currentestudio As Estudio In Me.ListaEstudios
                    currentestudio.esPagoContraFactura = 0
                    'cancelo el importe de pago contra factura
                    currentestudio.PagoContraFactura = 0.0
                    currentestudio.fechaCobro = Nothing
                    resp = currentestudio.setPagoContraFactura()
                Next
                btnAnularPago.Enabled = False
                btnAplicarPCF.Enabled = True
            End If

        End If
    End Sub



    Private Function validatePCF() As Boolean

        For Each est As Estudio In Me.ListaEstudios
            If est.idFacturacion <> 0 Then
                MessageBox.Show("Hay estudios que pertenecen a una presentación" & vbLf & "No se podrá realizar un pago contra factura", "Pago no válido", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
                Exit Function
            End If
            If est.nroPagoMedicoActuante > 0 Or est.nroPagoMedicoSolicitante > 0 Then
                MessageBox.Show("El estudio ya fue pagado desde pago a medico" & vbLf & "No se podrá realizar anulacion de pago Contra factura", "Pago No Anulado", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
                Exit Function
            End If
        Next

        Return True


    End Function

    Private Sub btnAplicarArancelAnestesia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAplicarArancelAnestesia.Click
        If (Helper.ValidaNumero(Me.txtImporteArancelAnestesia.Text)) Then
            Me.currentEstudio.ArancelAnestesia = Convert.ToDecimal(Me.txtImporteArancelAnestesia.Text)
            Dim resp As String = Me.currentEstudio.guardarArancelAnestesia()
            If resp = "ok" Then
                MessageBox.Show("Arancel anestesia actualizado con éxito")
            Else
                MessageBox.Show("Arancel anestesia no ha podido ser actualizado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Else
            MessageBox.Show("Ingrese un monto válido")
        End If

    End Sub
End Class
