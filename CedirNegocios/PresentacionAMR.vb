Imports Npgsql
Imports CedirDataAccess
Imports System.Collections.Generic
Public Class PresentacionAMR
    Private _id As Int64
  
    Private _ano As Int16
    Private _mes As Int16
    Private _quincena As Int16
    Private _lineasPresentacion As List(Of Presentacion)
    Private _amrAsoc As List(Of AMRAsociacion)
    Dim com As String = """"


#Region "Propiedades"
    Public Property asociacion() As List(Of AMRAsociacion)
        Get
            Return _amrAsoc
        End Get
        Set(ByVal value As List(Of AMRAsociacion))
            _amrAsoc = value
        End Set
    End Property

    Public Property lineasPresentacion() As List(Of Presentacion)
        Get
            Return _lineasPresentacion
        End Get
        Set(ByVal value As List(Of Presentacion))
            _lineasPresentacion = value
        End Set
    End Property

    Public Property id() As Int64
        Get
            Return _id
        End Get
        Set(ByVal value As Int64)
            _id = value
        End Set
    End Property

    Public Property ano() As Int32
        Get
            Return _ano
        End Get
        Set(ByVal value As Int32)
            _ano = value
        End Set
    End Property

    Public Property mes() As Int32
        Get
            Return _mes
        End Get
        Set(ByVal value As Int32)
            _mes = value
        End Set
    End Property

    Public Property quincena() As Int16
        Get
            Return _quincena
        End Get
        Set(ByVal value As Int16)
            _quincena = value
        End Set
    End Property


#End Region


    Public Sub New()
        '  lineasDeFacturacion = New ArrayList
        lineasPresentacion = New List(Of Presentacion)
        asociacion = New List(Of AMRAsociacion)
        Me.ano = Date.Today.Year
        If Date.Today.Day > 15 Then
            Me.quincena = 2
        Else
            quincena = 1
        End If
        Me.mes = Date.Today.Month

    End Sub

    Public Function addPresentacion(ByVal p As Presentacion) As Boolean
        'validar que ya no este en la facturacion
        If (p IsNot Nothing) Then
            For Each a As AMRAsociacion In Me.asociacion
                If p.idPresentacion = a.Presentacion.idPresentacion Then
                    Return False
                End If
            Next
        End If
        'agregar
        Dim item As AMRAsociacion
        item = New AMRAsociacion(Me, p)
        'agregamos el obj a la coleccion
        Me.asociacion.Add(item)
        'insertamos en base de datos la linea
        Me._insertarLinea(item)
        ' Me._insertarLineas()
        item = Nothing

        Return True

    End Function
    Private Function _insertarLinea(ByVal item As AMRAsociacion) As Boolean
        Dim altas As New Nuevo
        Dim resp As String
        resp = altas.insert(com & "cedirData" & com & "." & com & "tblPresentacion_PresentacionAMR" & com, com & "idFacturacion" & com & ", " & com & "idPresentacionAMR" & com & ", " & com & "nroRemito" & com, item.Presentacion.idPresentacion & ", " & item.PresentacionAMR.id & ", " & item.nroRemito)
        'si hay algun error al cargar las presentaciones, no hago el update
        If resp <> "ok" Then
            Return False
            Exit Function
        End If
        Return True
    End Function
    'Private Function _insertarLineas() As Boolean
    '    'total = 0
    '    Dim altas As New Nuevo
    '    Dim resp As String
    '    'si no hay error al guardar las lineas, guardamos la asociaicon
    '    For Each a As AMRAsociacion In Me.asociacion
    '        resp = altas.insert(com & "cedirData" & com & "." & com & "tblPresentacion_PresentacionAMR" & com, com & "idFacturacion" & com & ", " & com & "idPresentacionAMR" & com & ", " & com & "nroRemito" & com, a.Presentacion.idPresentacion & ", " & a.PresentacionAMR.id & ", " & a.nroRemito)
    '        'si hay algun error al cargar las presentaciones, no hago el update
    '        If resp <> "ok" Then
    '            Return False
    '            Exit For
    '        End If
    '    Next
    '    Return True
    'End Function

    Public Sub removePresentacion(ByVal p As Presentacion)
        If (p IsNot Nothing) Then
            Dim i As Integer
            For i = 0 To Me.asociacion.Count - 1
                If Me.asociacion(i).Presentacion.idPresentacion = p.idPresentacion Then
                    'eliminamos de base de datos la asociacion
                    Me._borrarLinea(Me.asociacion(i))
                    Me.asociacion.RemoveAt(i)
                    'salimos del bucle
                    Exit For
                End If
            Next

            'ahora voy a checkear que si eliminó la ultima linea, eliminemos la presentacionAMR
            If Me.asociacion.Count = 0 Then
                Me.delete()
            End If

        End If

    End Sub
    ''' <summary>
    ''' Esta funcion solo crea la presentaicon amr, no las lineas
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function crear() As String
        'primero checkeamos que no exista ya la presentacion
        Dim catPresentacion As New CatalogoDePresentaciones
        Try
            'buscamos primero la presentacion AMR

            If catPresentacion.amrFind(Me.id) IsNot Nothing Then
                'existe ya la presentacion
                Return "Existe presentacion"
            Else

                Dim altas As New Nuevo
                Dim id As Int64

                id = altas.nuevaFacturacionAMR(Me.ano, Me.mes, Me.quincena)

                If id = 0 Then
                    Return "Se ha producido un error al intentar guardar. Verifique que los datos sean correctos y vuelva a intentarlo."
                Else
                    Me.id = id
                    Return "ok"
                End If

            End If


        Catch ex As Exception
            Return ex.ToString()
        Finally
            catPresentacion = Nothing
        End Try
    End Function


    'Public Function crear() As String
    '    Dim altas As New Nuevo
    '    Dim id As Int64

    '    id = altas.nuevaFacturacionAMR(Me.ano, Me.mes, Me.quincena)

    '    If id = 0 Then
    '        Return "Se ha producido un error al intentar guardar. Verifique que los datos sean correctos y vuelva a intentarlo."
    '    Else
    '        'si no hay error al crear la preaentacion amr, creamos las lineas
    '        Me.id = id
    '        '  Dim respGuardar As Boolean = _insertarLineas()
    '        ' If respGuardar = False Then
    '        'Return "Error al intentar guardar. Algunas facturaciones ya se encuentran en alguna facturación AMR existente. Quitela de la facturacion AMR actual, guarde y verifique la situación."
    '        '  End If
    '        Return "ok"
    '    End If

    'End Function


    'Public Function guardar() As String
    '    Dim resp As String
    '    Dim altas As New Nuevo

    '    Dim fechaModificacion As String = Today.Year & "-" & Today.Month & "-" & Today.Day
    '    resp = altas.update(com & "cedirData" & com & "." & com & "tblPresentacionAMR" & com, com & "ano" & com & " = " & Me.ano & ", " & com & "mes" & com & " = " & Me.mes & ", " & com & "quincena" & com & " = " & Me.quincena, " where " & com & "id" & com & " = " & Me.id)

    '    If resp = "ok" Then
    '        'Ahora vamos a limpiar la tabla y despues agregamos las lineas 
    '        Dim respBorrar As Boolean = _borrarLineas()
    '        If respBorrar Then
    '            'si esta todo ok, guardamos las lineas nuevas
    '            Dim respGuardar As Boolean = _insertarLineas()
    '            If respGuardar Then
    '                Return "ok"
    '            Else
    '                Return "Error al intentar guardar. Algunas facturaciones ya se encuentran en alguna facturación AMR existente. Quitela de la facturacion AMR actual, guarde y verifique la situación."
    '            End If

    '        Else
    '            Return "Error al guardar las facturaciones (accion borrar), cierre la ventana y vuelva a abrirla."
    '        End If
    '        Return "ok"
    '    Else
    '        Return "Error al intentar guardar, pruebelo nuevamente.De persistir el problema cierre la ventana y vuelva abrirla."
    '    End If


    'End Function

    Private Function _borrarLinea(ByVal item As AMRAsociacion) As Boolean
        Dim upd As New CedirDataAccess.Nuevo
        Dim resp As String
        resp = upd.delete("tblPresentacion_PresentacionAMR", com & "idFacturacion" & com & " = " & item.Presentacion.idPresentacion)

        upd = Nothing

        If resp = "ok" Then
            Return True
        Else
            Return False
        End If

    End Function




    'Private Function _borrarLineas() As Boolean
    '    Dim upd As New CedirDataAccess.Nuevo
    '    Dim resp As String
    '    resp = upd.delete("tblPresentacion_PresentacionAMR", com & "idPresentacionAMR" & com & " = " & Me.id)

    '    upd = Nothing

    '    If resp = "ok" Then
    '        Return True
    '    Else
    '        Return False
    '    End If

    'End Function

    Public Function cargarPresentacion() As String
        'total = 0
        loadFacturaciones(" where fa." & com & "idPresentacionAMR" & com & " = " & Me.id)
        Return "ok"
    End Function

    Private Function loadFacturaciones(ByVal condicion As String) As String
        Me.lineasPresentacion.Clear()
        Dim da As New Consultas
        Dim drFacturaciones As NpgsqlDataReader
        Dim _presentacion As Presentacion
        Dim catPres As New CatalogoDePresentaciones
        Try
            drFacturaciones = da.getLineasFacturcionAMR(condicion)
            While drFacturaciones.Read()
                'Buscamos la presentacion asociada
                _presentacion = New Presentacion
                _presentacion = catPres.find(drFacturaciones.Item("idFacturacion"))

                'cargamos el objeto asociacion 
                Dim oa As New AMRAsociacion(Me, _presentacion)
                oa.nroRemito = Convert.ToUInt32(drFacturaciones.Item("nroRemito"))
                Me.asociacion.Add(oa)
                oa = Nothing
            End While
            drFacturaciones.Close()
            Return "ok"
        Catch ex As Exception
            Return ex.ToString()
        Finally
            _presentacion = Nothing
            catPres = Nothing
            da = Nothing
        End Try

    End Function

    ''' <summary>
    ''' Esta funcion elimina la presentacionAMR de DB
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function delete() As String
        Dim daNuevo As New Nuevo
        Dim resp As String = daNuevo.delete("tblPresentacionAMR", com & "id" & com & " = " & Me.id)
        Return resp
    End Function

    ''' <summary>
    ''' Hacemos update de nro remito y datos de la presentacionAMR
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function update() As String
        Dim resp As String
        Dim altas As New Nuevo
        Try
            resp = altas.update(com & "cedirData" & com & "." & com & "tblPresentacionAMR" & com, com & "ano" & com & " = " & Me.ano & ", " & com & "mes" & com & " = " & Me.mes & ", " & com & "quincena" & com & " = " & Me.quincena, " where " & com & "id" & com & " = " & Me.id)
            For Each item As AMRAsociacion In Me.asociacion
                resp = altas.update(com & "cedirData" & com & "." & com & "tblPresentacion_PresentacionAMR" & com, com & "nroRemito" & com & " = " & item.nroRemito, " where " & com & "idPresentacionAMR" & com & " = " & item.PresentacionAMR.id & " and " & com & "idFacturacion" & com & " = " & item.Presentacion.idPresentacion)
            Next
            Return "ok"
        Catch ex As Exception
            Return ex.ToString
        Finally
            altas = Nothing
        End Try
    End Function



End Class
