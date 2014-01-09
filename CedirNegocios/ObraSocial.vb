Imports Npgsql
Public Class ObraSocial
    Private m_idObraSocial As Integer
    Private m_ObraSocial As String
    Private m_direccion As String
    Private m_tel As String
    Public localidad As String
    Public CondicionFiscal As String
    Public CodigoPostal As Integer
    Public nroCuit As String
    Public observaciones As String
    Public sePresentaPorAMR As Int16
    Public sePresentaPorARA As Int16


    Public Sub New()

    End Sub

    Public Property idObraSocial() As Integer
        Get
            idObraSocial = m_idObraSocial
        End Get
        Set(ByVal Value As Integer)
            m_idObraSocial = Value
        End Set
    End Property
    Public Property ObraSocial() As String
        Get
            ObraSocial = m_ObraSocial
        End Get
        Set(ByVal Value As String)
            m_ObraSocial = Value
        End Set
    End Property


    Public Property direccion() As String
        Get
            direccion = m_direccion
        End Get
        Set(ByVal Value As String)
            m_direccion = Value
        End Set
    End Property
    Public Property tel() As String
        Get
            tel = m_tel
        End Get
        Set(ByVal Value As String)
            m_tel = Value
        End Set
    End Property
    Private _valorAproxPension As Decimal = 0.0

    Public Property valorAproximadoDePension() As Decimal
        Get
            Return _valorAproxPension
        End Get
        Set(ByVal value As Decimal)
            _valorAproxPension = value
        End Set
    End Property

    Public Function AltaObraSocial() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        Dim com As String = """"
        resp = upd.insert(com & "cedirData" & com & "." & com & "AlmacenObraSocial" & com, com & "obraSocial" & com & ", " & com & "direccion" & com & ", " & com & "telefono" & com & ", " & com & "localidad" & com & ", " & com & "codigoPostal" & com & ", " & com & "condicionFiscal" & com & ", " & com & "nroCuit" & com & ", " & com & "observaciones" & com & ", " & com & "sePresentaPorAMR" & com & ", " & com & "sePresentaPorARA" & com, "'" & Me.ObraSocial & "', '" & Me.direccion & "', '" & Me.tel & "', '" & Me.localidad & "', " & Me.CodigoPostal & ", '" & Me.CondicionFiscal & "', '" & Me.nroCuit & "'" & ", '', " & Me.sePresentaPorAMR & ", " & Me.sePresentaPorARA)

        Return resp

    End Function
    Public Function actualizar() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        Dim com As String = """"
        resp = upd.update(com & "cedirData" & com & "." & com & "AlmacenObraSocial" & com, com & "obraSocial" & com & " = '" & Me.ObraSocial & "', " & com & "direccion" & com & " = '" & Me.direccion & "', " & com & "telefono" & com & " = '" & Me.tel & "', " & com & "localidad" & com & " = '" & Me.localidad & "', " & com & "codigoPostal" & com & " = " & Me.CodigoPostal & ", " & com & "condicionFiscal" & com & " = '" & Me.CondicionFiscal & "', " & com & "nroCuit" & com & " = '" & Me.nroCuit & "', " & com & "sePresentaPorAMR" & com & " = '" & Me.sePresentaPorAMR & "', " & com & "sePresentaPorARA" & com & " = '" & Me.sePresentaPorARA & "' ", " where " & com & "idObraSocial" & com & " = " & idObraSocial)
        Return resp
    End Function

    Public Function actualizaDetalle() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim com As String = """"
        Dim resp As String

        resp = upd.update(com & "cedirData" & com & "." & com & "AlmacenObraSocial" & com, com & "observaciones" & com & " = '" & Me.observaciones & "'", " where " & com & "idObraSocial" & com & " = " & Me.idObraSocial)
        Return resp
    End Function

    Public Function actualizaValorAproximadoPension() As String
        Dim upd As New CedirDataAccess.Nuevo
        Dim com As String = """"
        Dim resp As String

        resp = upd.update(com & "cedirData" & com & "." & com & "AlmacenObraSocial" & com, com & "valorAproximadoPension" & com & " = " & Me.valorAproximadoDePension, " where " & com & "idObraSocial" & com & " = " & Me.idObraSocial)
        Return resp
    End Function
    Public Function getAranaceles() As ArrayList
        Dim da As New CedirDataAccess.Consultas
        Dim cArancel As Arancel
        getAranaceles = New ArrayList
        Dim drAranceles As NpgsqlDataReader
        drAranceles = da.getArancelesByObraSocial(Me.idObraSocial, 0)
        While drAranceles.Read()
            cArancel = New Arancel
            cArancel.practica.idEstudio = drAranceles.Item(0)
            cArancel.practica.Estudio = drAranceles.Item(1)
            cArancel.practica.codigoMedico = drAranceles.Item(2)
            cArancel.Precio = drAranceles.Item(3)
            cArancel.fecha = drAranceles.Item(4)
            cArancel.precioAnestesia = drAranceles.Item(5)
            getAranaceles.Add(cArancel)
        End While
        drAranceles.Close()
    End Function
    Public Function getAranacel(ByVal idPractica As Integer) As Arancel
        Dim da As New CedirDataAccess.Consultas
        Dim drAranceles As NpgsqlDataReader
        drAranceles = da.getArancelesByObraSocial(Me.idObraSocial, idPractica)
        While drAranceles.Read()
            getAranacel = New Arancel
            getAranacel.practica.idEstudio = drAranceles.Item(0)
            getAranacel.practica.Estudio = drAranceles.Item(1)
            getAranacel.practica.codigoMedico = drAranceles.Item(2)
            getAranacel.precio = drAranceles.Item(3)
            getAranacel.fecha = drAranceles.Item(4)
            getAranacel.precioAnestesia = drAranceles.Item(5)
        End While
        drAranceles.Close()
    End Function

    Public Function createOrUpdateArancel(ByVal cPractica As Practica, ByVal precio As String, ByVal precioAnestesia As String) As String
        Dim resp As String
        Dim cArancel As New Arancel
        cArancel.practica = cPractica
        cArancel.precio = precio
        cArancel.precioAnestesia = precioAnestesia
        cArancel.fecha = Today.Date

        Dim oldArancel As Arancel = Me.getAranacel(cPractica.idEstudio)
        If oldArancel Is Nothing Then
            resp = cArancel.crear(Me)
        Else
            'si no se modifico el arancel de la practicam conservo la fecha de ultima actualizacion
            If cArancel.precio = oldArancel.precio Then
                cArancel.fecha = oldArancel.fecha
            End If
            resp = cArancel.actualizar(Me)
        End If
        Return resp
    End Function
    Public Overrides Function ToString() As String
        Return Me.ObraSocial
    End Function
End Class
