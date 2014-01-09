

Public Class AMRAsociacion

    Private _id As Int32
    Private nro As Int32
    Private _presentacion As Presentacion
    Private _presentacionAMR As PresentacionAMR

#Region "Properties"

    Public Property id() As Int32
        Get
            Return _id
        End Get
        Set(ByVal value As Int32)
            _id = value
        End Set
    End Property
    Public Property nroRemito() As Int32
        Get
            Return nro
        End Get
        Set(ByVal value As Int32)
            nro = value
        End Set
    End Property
    Public Property Presentacion() As Presentacion
        Get
            Return _presentacion
        End Get
        Set(ByVal value As Presentacion)
            _presentacion = value
        End Set
    End Property
    Public Property PresentacionAMR() As PresentacionAMR
        Get
            Return _presentacionAMR
        End Get
        Set(ByVal value As PresentacionAMR)
            _presentacionAMR = value
        End Set
    End Property

#End Region

    Public Sub New()

    End Sub
    Public Sub New(ByVal presentacionAMR As PresentacionAMR, ByVal presentacion As Presentacion)
        Me.Presentacion = presentacion
        Me.PresentacionAMR = presentacionAMR
    End Sub
End Class
