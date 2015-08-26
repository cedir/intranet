Imports CedirDataAccess
Public Class LineaDeComprobante

    Private m_concepto As String
    Private m_subtotal As Decimal
    Private m_importeIVA As Decimal
    Private m_neto As Decimal

    Private m_comprobante As Comprobante ' guardo un objeto comprobante en cada linea(y a su vez una coleccion en comprobante)
    Private m_gravado As Gravado




    Public Property Concepto() As String
        Get
            Return m_concepto.ToUpper()
        End Get
        Set(ByVal value As String)
            m_concepto = value.ToUpper()
        End Set
    End Property

    ''' <summary>
    ''' El subtotal de la linea es el importe de iva + neto
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property Subtotal() As Decimal
        Get
            Return m_subtotal
        End Get
        Set(ByVal value As Decimal)
            m_subtotal = value
        End Set
    End Property

    ''' <summary>
    ''' El subtotal de la linea es el importe de iva + neto
    ''' 
    ''' </summary>
    ''' <value></value>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Property importeNeto() As Decimal
        Get
            Return m_neto
        End Get
        Set(ByVal value As Decimal)
            m_neto = value
        End Set
    End Property
    Public Property ImporteIVA() As Decimal
        Get
            Return m_importeIVA
        End Get
        Set(ByVal value As Decimal)
            m_importeIVA = value
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
    Public Property Comprobante() As Comprobante
        Get
            Return m_comprobante
        End Get
        Set(ByVal value As Comprobante)
            m_comprobante = value
        End Set
    End Property

    Public Sub New()
        Concepto = ""
        Subtotal = 0.0
        Comprobante = Nothing
    End Sub

    Public Sub insertar()
        Dim arr As New ArrayList
        Const c As String = "__*"

        arr.Add("concepto" & c & Me.Concepto)
        arr.Add("subtotal" & c & Me.Subtotal)
        arr.Add("idComprobante" & c & Me.Comprobante.IdComprobante)
        arr.Add("idGravado" & c & Me.Comprobante.Gravado.id)
        arr.Add("importeIVA" & c & ImporteIVA)
        arr.Add("importeNeto" & c & Me.importeNeto)

        'arr.Add("tipoComprobante" & c & Me.Comprobante.TipoComprobante.Descripcion)
        'arr.Add("nroComprobante" & c & Me.Comprobante.NroComprobante)

        Dim cDatos As New Nuevo
        cDatos.ExecuteStoreProcedure(arr, "sp_comprobanteslineainsertar")

    End Sub

End Class
