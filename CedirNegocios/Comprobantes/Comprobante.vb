Imports CedirDataAccess
Imports System.Collections.Generic
Imports FacturaElectronica
Imports Npgsql
Public Class Comprobante

#Region "VARIABLES DE INSTANCIA"
    Private m_idComprobante As Integer
    Private m_nroComprobante As Integer
    Private m_nroTerminal As Integer
    Private m_nombreCliente As String
    Private m_domicilioCliente As String
    Private m_documentoCliente As DocumentoCliente
    Dim _cae As String = ""

    Private m_condicionFiscal As String
    Private m_responsable As String
    Private m_gravado As Gravado
    Private m_tipoComprobante As TipoComprobante
    Private m_fechaEmision As Date
    Private m_fechaRecepcion As Date
    Private m_estado As String
    Private m_subTipo As String
    Private m_factura As Comprobante 'el comprobante si es nd o nc, tiene asociado una  factura
    Private m_totalFacturado As Decimal
    Private m_totalCobrado As Decimal
    Private m_gravadoPaciente As String
    Private m_lineasDeComprobante As List(Of LineaDeComprobante) 'creo una coleccion de lineas(y a su vez guardo un objeto compro. en lineaComprobante)

    Const c As String = "__*"

#End Region

#Region "PROPIEDADES"
    Public Property CAE() As String
        Get
            Return _cae
        End Get
        Set(ByVal value As String)
            _cae = value
        End Set
    End Property

    Public Property IdComprobante() As Integer
        Get
            Return m_idComprobante
        End Get
        Set(ByVal value As Integer)
            m_idComprobante = value
        End Set
    End Property
    Public Property NroComprobante() As Integer
        Get
            Return m_nroComprobante
        End Get
        Set(ByVal value As Integer)
            m_nroComprobante = value
        End Set
    End Property
    Public Property NroTerminal() As Integer
        Get
            Return m_nroTerminal
        End Get
        Set(ByVal value As Integer)
            m_nroTerminal = value
        End Set
    End Property
    Public Property NombreCliente() As String
        Get
            Return m_nombreCliente.ToUpper
        End Get
        Set(ByVal value As String)
            m_nombreCliente = value.ToUpper
        End Set
    End Property
    Public Property DomicilioCliente() As String
        Get
            Return m_domicilioCliente.ToUpper
        End Get
        Set(ByVal value As String)
            m_domicilioCliente = value.ToUpper
        End Set
    End Property
    Public Property DocumentoCliente() As DocumentoCliente
        Get
            Return Me.m_documentoCliente
        End Get
        Set(ByVal value As DocumentoCliente)
            m_documentoCliente = value
        End Set
    End Property

    Public Property CondicionFiscal() As String
        Get
            Return m_condicionFiscal.ToUpper
        End Get
        Set(ByVal value As String)
            m_condicionFiscal = value.ToUpper
        End Set
    End Property
    Public Property Responsable() As String
        Get
            Return m_responsable
        End Get
        Set(ByVal value As String)
            m_responsable = value
        End Set
    End Property
    Public Property Gravado() As Gravado
        Get
            Return m_gravado
        End Get
        Set(ByVal value As Gravado)
            m_gravado = value
        End Set
    End Property
    Public Property TipoComprobante() As TipoComprobante
        Get
            Return m_tipoComprobante
        End Get
        Set(ByVal value As TipoComprobante)
            m_tipoComprobante = value
        End Set
    End Property
    Public Property FechaEmision() As Date
        Get
            Return m_fechaEmision
        End Get
        Set(ByVal value As Date)
            m_fechaEmision = value
        End Set
    End Property
    Public Property FechaRecepcion() As Date
        Get
            Return m_fechaRecepcion
        End Get
        Set(ByVal value As Date)
            m_fechaRecepcion = value
        End Set
    End Property
    Public Property Estado() As String
        Get
            Return m_estado
        End Get
        Set(ByVal value As String)
            m_estado = value
        End Set
    End Property
    Public Property SubTipo() As String
        Get
            Return m_subTipo
        End Get
        Set(ByVal value As String)
            m_subTipo = value
        End Set
    End Property
    Public Property Factura() As Comprobante
        Get
            Return m_factura
        End Get
        Set(ByVal value As Comprobante)
            m_factura = value
        End Set
    End Property
    Public Property TotalCobrado() As Decimal
        Get
            Return m_totalCobrado
        End Get
        Set(ByVal value As Decimal)
            m_totalCobrado = value
        End Set
    End Property
    ''' <summary>
    ''' totalFacturado  =  sumatoria(lineasdecomprobante.subtotal)
    ''' 
    ''' incluye el importe gravado de las lineas
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property TotalFacturado() As Decimal
        Get
            Return m_totalFacturado
        End Get
        Set(ByVal value As Decimal)
            m_totalFacturado = value
        End Set
    End Property
    Public Property LineasDeComprobante() As List(Of LineaDeComprobante)
        Get
            Return m_lineasDeComprobante
        End Get
        Set(ByVal value As List(Of LineaDeComprobante))
            m_lineasDeComprobante = value
        End Set
    End Property
    Public Property GravadoPaciente() As String
        Get
            Return m_gravadoPaciente.ToUpper
        End Get
        Set(ByVal value As String)
            m_gravadoPaciente = value.ToUpper
        End Set
    End Property


#End Region

#Region "CONSTRUCTOR"
    Public Sub New()
        NroComprobante = Nothing
        NroTerminal = Nothing
        NombreCliente = " "
        DomicilioCliente = " "
        Me.documentoCliente = New DocumentoCliente()
        CondicionFiscal = " "
        Responsable = " "
        Gravado = New Gravado
        'Gravado = Nothing
        TipoComprobante = New TipoComprobante
        SubTipo = ""
        FechaEmision = Date.Today
        FechaRecepcion = Date.Today
        Estado = " "
        TotalFacturado = 0
        TotalCobrado = 0
        GravadoPaciente = ""

        Factura = Nothing
        LineasDeComprobante = New List(Of LineaDeComprobante)
    End Sub
#End Region

    Public Overridable Function crear() As Dictionary(Of String, String)
        Dim result As New Dictionary(Of String, String)
        Dim cDatos As New Nuevo
        Dim arr As New ArrayList
        Dim help As New Helper
        'Convertimos las fechas a string y al formato YYYY MM DD
        Dim f1 As String
        Dim f2 As String
        f1 = help.convertDate(Me.FechaEmision)
        f2 = help.convertDate(Me.FechaRecepcion)
        Dim com As String = """"

        Try
            Dim resp As String

            'Obtiene el ultimo número de comprobante
            If Not Me.NroComprobante > 0 Then
                Dim c As New CatalogoDeComprobantes
                Dim ultimoNumero As New Nullable(Of Integer)

                If Me.TipoComprobante.Id = TComprobante.Liquidacion Then
                    ultimoNumero = c.getUltimoNro(Me.TipoComprobante.Id)
                Else
                    ultimoNumero = c.getUltimoNro(Me.TipoComprobante.Id, Me.Responsable, Me.SubTipo, Me.NroTerminal)
                End If

                If ultimoNumero.HasValue Then
                    Me.NroComprobante = ultimoNumero.Value + 1
                Else
                    Return Helper.Result(result, False, "Imposible determinar el número de comprobante")
                End If
            End If

            Dim resultAFIP As Dictionary(Of String, String) = ComprobanteElectronico.Crear(Me)

            If Not Helper.IsSuccess(resultAFIP) Then
                Return resultAFIP
            End If

            'tenemos que diferenciar al momento de insertar una factura o una nd o nc o liquidacion
            If Me.TipoComprobante.Id = TComprobante.Liquidacion Then
                'Si el comprobante es una liquidación vaciamos los campos que no correspondan
                Me.Gravado = Nothing
                Me.Factura = New Comprobante
                Me.Factura = Nothing
                Me.SubTipo = ""
                Me.Responsable = ""
                'insertamos la liquidacion en db
                resp = cDatos.insert(com & "cedirData" & com & "." & com & "tblComprobantes" & com, com & _
                "nroComprobante" & com & ", " & com & "nroTerminal" & com & ", " & com & "nombreCliente" & _
                com & ", " & com & "domicilioCliente" & _
                com & ", " & com & "nroCuit" & com & ", " & com & "condicionFiscal" & com & ", " & com & _
                "idTipoComprobante" & com & ", " & com & "fechaEmision" & com & ", " & com & "fechaRecepcion" & _
                com & ", " & com & "estado" & com & ", " & com & "totalFacturado" & com & ", " & com & _
                "totalCobrado" & com & ", " & com & "gravadoPaciente" & com, "'" & Me.NroComprobante & "', '" & _
                Me.NroTerminal & "', '" & Me.NombreCliente & "', '" & Me.DomicilioCliente & "', '" & Me.DocumentoCliente.NroDocumento & _
                "', '" & Me.CondicionFiscal & "', '" & Me.TipoComprobante.Id & "', '" & f1 & "', '" & f2 & "', '" & _
                Me.Estado & "', '" & Me.TotalFacturado & "', '" & Me.TotalCobrado & "', '" & Me.GravadoPaciente & "'")
            Else
                If ((Me.TipoComprobante.Id = TComprobante.NotaDeCredito Or Me.TipoComprobante.Id = TComprobante.NotaDeDebito) And (Me.Factura IsNot Nothing)) Then
                    'si es asi, insertamos tambien la factura que corresponda, ya que es Nota de Debito, o Credito
                    resp = cDatos.insert(com & "cedirData" & com & "." & com & "tblComprobantes" & com, com & "nroComprobante" & com & " , " & com & "nroTerminal" & com & ", " & com & "nombreCliente" & com & ", " & com & "domicilioCliente" & com & ", " & com & "nroCuit" & com & ", " & com & "condicionFiscal" & com & ", " & com & "responsable" & com & ", " & com & "idTipoComprobante" & com & ", " & com & "fechaEmision" & com & ", " & com & "fechaRecepcion" & com & ", " & com & "estado" & com & ", " & com & "subTipo" & com & ", " & com & "idFactura" & com & ", " & com & "totalFacturado" & com & ", " & com & "totalCobrado" & com & ", " & com & "gravado" & com & ", " & com & "gravadoPaciente" & com, "'" & Me.NroComprobante & "', '" & Me.NroTerminal & "', '" & Me.NombreCliente & "', '" & Me.DomicilioCliente & "', '" & Me.DocumentoCliente.NroDocumento & "', '" & Me.CondicionFiscal & "', '" & Me.Responsable & "', '" & Me.TipoComprobante.Id & "', '" & f1 & "', '" & f2 & "', '" & Me.Estado & "', '" & Me.SubTipo & "', '" & Me.Factura.IdComprobante & "', '" & Me.TotalFacturado & "', '" & Me.TotalCobrado & "', '" & Me.Gravado.id & "', '" & Me.GravadoPaciente & "'")
                Else
                    'de otra manera, insertamos vacio en el campo idFactura de la tabla
                    resp = cDatos.insert(com & "cedirData" & com & "." & com & "tblComprobantes" & com, com & "nroComprobante" & com & " , " & com & "nroTerminal" & com & ", " & com & "nombreCliente" & com & ", " & com & "domicilioCliente" & com & ", " & com & "nroCuit" & com & ", " & com & "condicionFiscal" & com & ", " & com & "responsable" & com & ", " & com & "idTipoComprobante" & com & ", " & com & "fechaEmision" & com & ", " & com & "fechaRecepcion" & com & ", " & com & "estado" & com & ", " & com & "subTipo" & com & ", " & com & "totalFacturado" & com & ", " & com & "totalCobrado" & com & ", " & com & "gravado" & com & ", " & com & "gravadoPaciente" & com & ", " & com & "CAE" & com, "'" & Me.NroComprobante & "', '" & Me.NroTerminal & "', '" & Me.NombreCliente & "', '" & Me.DomicilioCliente & "', '" & Me.DocumentoCliente.NroDocumento & "', '" & Me.CondicionFiscal & "', '" & Me.Responsable & "', '" & Me.TipoComprobante.Id & "', '" & f1 & "', '" & f2 & "', '" & Me.Estado & "', '" & Me.SubTipo & "', '" & Me.TotalFacturado & "', '" & Me.TotalCobrado & "', '" & Me.Gravado.id & "', '" & Me.GravadoPaciente & "'" & ", '" & CAE & "'")
                End If

            End If

            Dim maxId As Integer = cDatos.selectMAX("tblComprobantes", "id")
            If maxId = 0 Then
                Return Helper.Result(result, False, "Error al obtener el id del comprobante, comuniquese con area de sistemas para comunicar el error")
            End If

            'recuperamos el id autoincremental creado por postrge para insertarlo en las lineas
            Me.IdComprobante = maxId

            'Ahora inserto cada linea a la DB
            Me.crearLineas()

            Helper.Result(result, True, "Comprobante creado con éxito")
        Catch ex As Exception
            Helper.Result(result, False, ex.Message)
        Finally
            help = Nothing
            cDatos = Nothing
            arr = Nothing
        End Try
        Return result
    End Function
    ''' <summary>
    ''' Este metodo se ejecuta una vez que la cabecera del comprobante fue insertado en DB. Ya 
    ''' que luego utilizamos el id devuelto por la DB para insertarlo en la linea.
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub crearLineas()
        For Each linea As LineaDeComprobante In Me.LineasDeComprobante
            linea.Comprobante = Me
            linea.insertar()
        Next
    End Sub

    Public Function getLineas() As List(Of LineaDeComprobante)
        Dim dr As NpgsqlDataReader
        Dim cDatos As New Consultas
        Dim arr As New ArrayList
        getLineas = New List(Of LineaDeComprobante)
        Dim com As String = """"
        Dim condicion1 As String = " com." & com & "id" & com & "=" & Me.IdComprobante

        Dim concat As String = condicion1

        Try
            dr = cDatos.getAll("tblComprobanteLineas", com & "idComprobante" & com & " = " & Me.IdComprobante)
            Do While dr.Read
                Dim linea As New LineaDeComprobante
                linea.Concepto = Convert.ToString(dr("concepto"))
                linea.Subtotal = Convert.ToDecimal(dr("subtotal"))
                linea.ImporteIVA = Convert.ToDecimal(dr("importeIVA"))
                linea.importeNeto = Convert.ToDecimal(dr("importeNeto"))
                getLineas.Add(linea)
                linea = Nothing
            Loop

        Catch ex As Exception
            MsgBox(ex)
        Finally
            cDatos = Nothing
            dr = Nothing
            arr = Nothing
        End Try
    End Function
    Public Sub cambiarEstado(ByVal estado As String)
        Dim cDatos As New Nuevo
        Dim arr As New ArrayList
        Try
            arr.Add("id" & c & Me.IdComprobante)
            arr.Add("estado" & c & estado)
            cDatos.ExecuteStoreProcedure(arr, "sp_comprobantescambiarestado")

        Finally
            cDatos = Nothing
            arr = Nothing
            Me.Estado = estado
        End Try
    End Sub
    Public Sub setGravado()
        Dim com As String = """"
        Dim cDatos As New Consultas
        Dim dr As NpgsqlDataReader

        Try
            Dim query As String = "select * from " & com & "cedirData" & com & "." & com & "tblGravado" & com & " as g where g." & com & "id" & com & " = " & Me.Gravado.id
            dr = cDatos.EjecutarSelect(query)
            While (dr.Read)
                Dim g As New Gravado
                g.id = Convert.ToInt32(dr("id"))
                g.descripcion = Convert.ToString(dr("descripcionGravado"))
                g.porcentaje = Convert.ToDecimal(dr("porcentajeGravado"))
                Me.Gravado = g
                g = Nothing
            End While
        Catch ex As Exception
        Finally
            cDatos = Nothing
            dr = Nothing
        End Try
    End Sub
    'Public Function doesExist() As Boolean
    '    Dim com As String = """"
    '    Dim cDatos As New Consultas
    '    Dim dr As NpgsqlDataReader
    '    Dim query As String
    '    Try
    '        If Me.TipoComprobante.Id = 2 Then
    '            query = "select c." & com & "id" & com & " from " & com & "cedirData" & com & "." & com & "tblComprobantes" & com & " as c where c." & com & "nroComprobante" & com & " = " & Me.NroComprobante & " and " & com & "idTipoComprobante" & com & " = " & Me.TipoComprobante.Id
    '        Else
    '            query = "select c." & com & "id" & com & " from " & com & "cedirData" & com & "." & com & "tblComprobantes" & com & " as c where c." & com & "nroComprobante" & com & " = " & Me.NroComprobante & " and " & com & "idTipoComprobante" & com & " = " & Me.TipoComprobante.Id & " and " & com & "responsable" & com & " = '" & Me.Responsable & "' and " & com & "subTipo" & com & " = '" & Me.SubTipo & "'" & "' and " & com & "nroTerminal" & com & " = '" & Me.NroTerminal & "'"
    '        End If

    '        dr = cDatos.EjecutarSelect(query)
    '        If dr.HasRows Then
    '            Return True
    '        Else : Return False
    '        End If
    '    Catch ex As Exception
    '    Finally
    '        cDatos = Nothing
    '        dr = Nothing
    '    End Try

    'End Function
    Public Sub getFactura(ByVal idFactura As Int32)
        Dim com As String = """"
        Dim oComprobante As New Comprobante
        Dim cDatos As New Consultas
        Dim dr As NpgsqlDataReader
        Dim filtro As String
        filtro = " c." & com & "id" & com & " = " & idFactura
        dr = cDatos.getComprobantes(filtro)

        Do While dr.Read
            If dr("id") Is DBNull.Value Then
                oComprobante.IdComprobante = ""
            Else : oComprobante.IdComprobante = dr("id")
            End If

            oComprobante.NroComprobante = Convert.ToInt32(dr("nroComprobante"))
            oComprobante.NombreCliente = Convert.ToString(dr("nombreCliente"))
            oComprobante.DomicilioCliente = Convert.ToString(dr("domicilioCliente"))


            If dr("nroCuit") Is DBNull.Value Then
                oComprobante.DocumentoCliente.NroDocumento = ""
            Else : oComprobante.DocumentoCliente.NroDocumento = dr("nroCuit")
            End If

            oComprobante.CondicionFiscal = Convert.ToString(dr("condicionFiscal"))

            oComprobante.Responsable = Convert.ToString(dr("responsable"))

            If dr("gravado") Is DBNull.Value Then
                oComprobante.Gravado = Nothing
            Else : oComprobante.Gravado.id = dr("gravado")
                oComprobante.Gravado.descripcion = dr("descripcionGravado")
            End If
            oComprobante.TipoComprobante.Id = Convert.ToInt32(dr("idTipo"))
            oComprobante.TipoComprobante.Descripcion = Convert.ToString(dr("tipoComprobante"))

            If dr("fechaEmision") Is DBNull.Value Then
                oComprobante.FechaEmision = Nothing
            Else
                oComprobante.FechaEmision = dr("fechaEmision")
            End If

            If dr("fechaRecepcion") Is DBNull.Value Then
                oComprobante.FechaRecepcion = Nothing
            Else : oComprobante.FechaRecepcion = dr("fechaRecepcion")
            End If

            If dr("estado") Is DBNull.Value Then
                oComprobante.Estado = Nothing
            Else : oComprobante.Estado = dr("estado")
            End If
            If dr("subTipo") Is DBNull.Value Then
                oComprobante.SubTipo = ""
            Else : oComprobante.SubTipo = dr("subTipo")
            End If
            oComprobante.TotalFacturado = Convert.ToDecimal(dr("totalFacturado"))
            oComprobante.TotalCobrado = Convert.ToDecimal(dr("totalCobrado"))

            oComprobante.GravadoPaciente = Convert.ToString(dr("gravadoPaciente"))
        Loop

        Me.Factura = oComprobante

    End Sub
    Public Sub updateTotalCobrado()
        Dim com As String = """"
        Dim oComprobante As New Comprobante
        Dim cDatos As New Nuevo

        Dim tabla As String = com & "cedirData" & com & "." & com & "tblComprobantes" & com
        Dim campos As String = com & "totalCobrado" & com & " = " & Me.TotalCobrado
        Dim filtro As String = " where id = " & Me.IdComprobante
        cDatos.update(tabla, campos, filtro)

        cDatos = Nothing

    End Sub
End Class
