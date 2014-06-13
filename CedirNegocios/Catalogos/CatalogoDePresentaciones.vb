Imports System.Text.RegularExpressions
Imports CedirDataAccess
Imports Npgsql
Public Class CatalogoDePresentaciones
    Dim com As String = """"
    Dim da As Consultas
    Dim daNuevo As Nuevo
    Public Sub New()
        da = New Consultas
        daNuevo = New Nuevo
    End Sub

    Public Function traerFacturaciones(ByVal mes As String, ByVal ano As String, ByVal soloCobrados As Boolean) As ArrayList
        If mes = "" Then
            mes = Today.Month
        End If
        If ano = "" Then
            ano = Today.Year
        End If

        Dim soloCobradosCondicion As String
        If soloCobrados Then
            soloCobradosCondicion = " and " & com & "pagado" & com & " = 1"
        End If

        Dim cMonthDate As String = ano & "-" & mes & "-" & "01"

        Return loadPresentaciones(" where c." & com & "fechaEmision" & com & " >= date_trunc('month', DATE '" & cMonthDate & "') and c." & com & "fechaEmision" & com & " < (date_trunc('month', DATE '" & cMonthDate & "') + INTERVAL '1 month') and c." & com & "idTipoComprobante" & com & " = 1 and upper(c." & com & "estado" & com & ") <> 'ANULADO' " & soloCobradosCondicion, "UPPER(" & com & "responsable" & com & "), " & com & "subTipo" & com & ", " & com & "nroComprobante" & com)
    End Function
    Public Function traerPresentacionesPendientes() As ArrayList
        'com & "pagado" & com & " = 0"
        Return loadPresentaciones("", "")
    End Function
    Public Function traerPresentaciones(Optional ByVal idObraSocial As Integer = Nothing, Optional ByVal nroComprobante As String = "", Optional ByVal tipoComp As String = "", Optional ByVal fecha As Date = Nothing, Optional ByVal pendiente As Object = Nothing, Optional ByVal idComprobante As Integer = 0, Optional ByVal nroRemito As String = "", Optional ByVal tipoDePresentacion As String = "Sin Definir") As ArrayList
        Dim condicion As String = ""
        If idObraSocial <> 0 Then
            condicion &= "f." & com & "idObraSocial" & com & " = " & idObraSocial
        End If
        If nroComprobante <> "" Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            'agrego referencia a la tabla "comprobante"
            condicion &= "c." & com & "nroComprobante" & com & " = " & nroComprobante
        End If

        If nroRemito <> "" Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            'agrego referencia a la tabla "tblPresentacion_PresentacionAMR"
            condicion &= "tPresPresAMR." & com & "nroRemito" & com & " = " & Convert.ToUInt32(nroRemito)
        End If


        If tipoComp <> "" Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            'agrego referencia a la tabla "comprobante"
            condicion &= "ti." & com & "tipoComprobante" & com & " = " & "'" & tipoComp & "'"
        End If

        If idComprobante <> 0 Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            'agrego referencia a la tabla "comprobante"
            condicion &= "f." & com & "idComprobante" & com & " = " & idComprobante
        End If

        If fecha <> Nothing Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            condicion &= com & "fechaFacturacion" & com & " >= ('" & fecha & "') AND " & com & "fechaFacturacion" & com & " <=(date '" & fecha & "' + INTERVAL '1 year') "
           
        End If

        If tipoDePresentacion = "Directa" Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            condicion &= com & "sePresentaPorAMR" & com & " = " & 0
        ElseIf tipoDePresentacion = "AMR" Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            condicion &= com & "sePresentaPorAMR" & com & " = " & 1
        End If

        If pendiente = True And pendiente IsNot Nothing Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            condicion &= com & "pagado" & com & " IN(0,2)"
        ElseIf pendiente = False And pendiente IsNot Nothing Then
            If condicion <> "" Then
                condicion &= " and "
            End If
            condicion &= com & "pagado" & com & " = 1"
        End If

        If condicion = "" Then
            Return loadPresentaciones("", "")
        End If

        Return loadPresentaciones(" where " & condicion, "")
    End Function
    
    Public Function find(ByVal id As Integer) As Presentacion
        Dim arrTemp As ArrayList = loadPresentaciones(" where f." & com & "idFacturacion" & com & " = " & id, "")
        Return arrTemp(0)
    End Function
    Public Function delete(ByVal id As Integer) As String
        Dim resp As String
        'Antes de eliminar esta presentacion vamos a checkear que no esté en ninguna PresentacionAMR
        If Me.contienePresentacion(id) = id Then
            resp = "Quite la presentacion de PresentacionAMR primero"
            Return resp
        End If

        'quitar estudios de la facturacion
        resp = daNuevo.update(com & "cedirData" & com & "." & com & "tblDetalleEstudio" & com, com & "idFacturacion" & com & " = 0 ", " where " & com & "idFacturacion" & com & " = " & id)

        'quitar consultas
        If resp = "ok" Then
            resp = daNuevo.delete("Facturaciones-Consultas", com & "idFacturacion" & com & " = " & id)
        End If

        'eliminar facturacion
        If resp = "ok" Then
            resp = daNuevo.delete("tblFacturacion", com & "idFacturacion" & com & " = " & id)
        End If

        Return resp

    End Function

    Private Function loadPresentaciones(ByVal condicion As String, ByVal order As String) As ArrayList
        Dim drPresentacion As NpgsqlDataReader
        loadPresentaciones = New ArrayList
        Dim vPresentacion As Presentacion

        drPresentacion = da.getPresentaciones(condicion, order)
        'Try
        While drPresentacion.Read()
            vPresentacion = New Presentacion

            vPresentacion.idPresentacion = drPresentacion.Item("idFacturacion")
            vPresentacion.obraSocial.idObraSocial = Convert.ToInt32(drPresentacion.Item("idObraSocial"))
            vPresentacion.obraSocial.ObraSocial = Convert.ToString(drPresentacion.Item("obraSocial"))
            vPresentacion.obraSocial.direccion = Convert.ToString(drPresentacion.Item("direccion"))
            vPresentacion.obraSocial.tel = Convert.ToString(drPresentacion.Item("telefono"))
            vPresentacion.obraSocial.localidad = Convert.ToString(drPresentacion.Item("localidad"))
            vPresentacion.obraSocial.CodigoPostal = Convert.ToInt32(drPresentacion.Item("codigoPostal"))
            vPresentacion.obraSocial.CondicionFiscal = Convert.ToString(drPresentacion.Item("osCondicionFiscal"))
            vPresentacion.obraSocial.nroCuit = Convert.ToString(drPresentacion.Item("cuitOS"))
            vPresentacion.obraSocial.observaciones = Convert.ToString(drPresentacion.Item("observaciones"))
            vPresentacion.obraSocial.sePresentaPorAMR = Convert.ToInt32(drPresentacion.Item("sePresentaPorAMR"))
            vPresentacion.obraSocial.sePresentaPorARA = Convert.ToInt32(drPresentacion.Item("sePresentaPorARA"))

            vPresentacion.fechaFacturacion = drPresentacion.Item("fechaFacturacion")

            'aca tenemos que controlar si la presentacion fue guardada o si fue ya facturada
            If (drPresentacion.Item("idComprobante") IsNot DBNull.Value) Then


                vPresentacion.comprobante.IdComprobante = Convert.ToInt32(drPresentacion.Item("id"))
                vPresentacion.comprobante.NroTerminal = Convert.ToInt32(drPresentacion.Item("nroTerminal"))

                vPresentacion.comprobante.NroComprobante = Convert.ToInt32(drPresentacion.Item("nroComprobante"))
                vPresentacion.comprobante.NombreCliente = Convert.ToString(drPresentacion.Item("nombreCliente"))
                vPresentacion.comprobante.DomicilioCliente = Convert.ToString(drPresentacion.Item("domicilioCliente"))
                vPresentacion.comprobante.NroCuit = Convert.ToString(drPresentacion.Item("nroCuit"))
                vPresentacion.comprobante.CondicionFiscal = Convert.ToString(drPresentacion.Item("condicionFiscal"))
                vPresentacion.comprobante.TipoComprobante.Id = Convert.ToInt32(drPresentacion.Item("idTipoComprobante"))
                vPresentacion.comprobante.TipoComprobante.Descripcion = Convert.ToString(drPresentacion.Item("tipoComprobante"))
                vPresentacion.comprobante.FechaEmision = Convert.ToDateTime(drPresentacion.Item("fechaEmision"))
                vPresentacion.comprobante.FechaRecepcion = Convert.ToDateTime(drPresentacion.Item("fechaRecepcion"))
                vPresentacion.comprobante.Estado = Convert.ToString(drPresentacion.Item("estado"))
                vPresentacion.comprobante.TotalFacturado = Convert.ToDecimal(drPresentacion.Item("totalFacturado"))
                vPresentacion.comprobante.TotalCobrado = Convert.ToDecimal(drPresentacion.Item("totalCobrado"))

                'tambien tenemos que discriminar datos si el comprobante es una liquidacion
                If (Convert.ToString(drPresentacion.Item("tipoComprobante")).ToUpper() <> "LIQUIDACION") Then

                    vPresentacion.comprobante.Responsable = Convert.ToString(drPresentacion.Item("responsable"))
                    vPresentacion.comprobante.SubTipo = Convert.ToString(drPresentacion.Item("subTipo"))
                    If drPresentacion.Item("idFactura") IsNot DBNull.Value And vPresentacion.comprobante.Factura IsNot Nothing Then
                        vPresentacion.comprobante.Factura.IdComprobante = Convert.ToInt32(drPresentacion.Item("idFactura"))
                    End If
                    vPresentacion.comprobante.Gravado.id = Convert.ToInt32(drPresentacion.Item("idGravado"))
                    vPresentacion.comprobante.Gravado.descripcion = Convert.ToString(drPresentacion.Item("descripcionGravado"))
                    vPresentacion.comprobante.Gravado.porcentaje = Convert.ToDecimal(drPresentacion.Item("porcentajeGravado"))

                End If
            End If

            vPresentacion.pagado = Convert.ToInt32(drPresentacion.Item("pagado"))
            vPresentacion.periodo = Convert.ToString(drPresentacion.Item("periodo"))
            vPresentacion.total = Convert.ToSingle(drPresentacion.Item("total"))
            vPresentacion.totalFacturado = Convert.ToSingle(drPresentacion.Item("totalFacturadoPresentacion"))
            loadPresentaciones.Add(vPresentacion)


        End While
        'Catch ex As Exception
        '    Return ex.Message
        '  Finally

        'End Try

        drPresentacion.Close()
    End Function




    '--------------------------------AMR--------------------------------------

    Public Function amrTraerFacturacionesPendientes() As ArrayList
        Return loadFacturacionesAMR("", "")
    End Function
    Public Function amrGetPresentaciones(Optional ByVal quincena As Integer = 0, Optional ByVal mes As Integer = 0, Optional ByVal anio As String = "", Optional ByVal remito As String = "") As ArrayList
        'Return loadPresentaciones(" where " & condicion, "")
        Dim condicion As String = " true "
        If quincena <> 0 Then
            condicion &= " and " & com & "tblPresentacionAMR" & com & "." & com & "quincena" & com & " = " & quincena
        End If

        If mes > 0 Then
            condicion &= " and " & com & "mes" & com & " = " & mes
        End If

        If anio <> "" Then
            condicion &= " and " & com & "ano" & com & " = " & anio
        End If

        If remito <> "" Then
            condicion &= " and " & com & "remito" & com & " = " & remito
        End If

        Return Me.loadFacturacionesAMR(" where " & condicion, "")


    End Function

    Public Function amrFind(ByVal id As Integer) As PresentacionAMR
        Dim arr As ArrayList = loadFacturacionesAMR(" where " & com & "id" & com & " = " & id, "")
        If arr.Count = 0 Then
            Return Nothing
        Else : Return arr(0)
        End If
    End Function
    Private Function loadFacturacionesAMR(ByVal condicion As String, ByVal order As String) As ArrayList
        Dim drFacturacion As NpgsqlDataReader
        loadFacturacionesAMR = New ArrayList
        Dim vFacturacion As PresentacionAMR

        drFacturacion = da.Tabla("tblPresentacionAMR", condicion & " order by " & com & "ano" & com & ", " & com & "mes" & com & ", " & com & "quincena" & com)
        While drFacturacion.Read()
            vFacturacion = New PresentacionAMR

            vFacturacion.id = drFacturacion.Item("id")
            vFacturacion.ano = drFacturacion.Item("ano")
            vFacturacion.mes = drFacturacion.Item("mes")
            vFacturacion.quincena = drFacturacion.Item("quincena")
            loadFacturacionesAMR.Add(vFacturacion)
        End While

        drFacturacion.Close()
    End Function

    ''' <summary>
    ''' Esta funcion sirve para encontrar una facturacion en presentacionAMR
    ''' </summary>
    ''' <param name="idPresentacion"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function contienePresentacion(ByVal idPresentacion As Integer) As Int32
        Dim drFacturacion As NpgsqlDataReader
        drFacturacion = da.Tabla("tblPresentacion_PresentacionAMR", " where " & com & "idFacturacion" & com & " = " & idPresentacion)
        If drFacturacion.HasRows Then
            Return idPresentacion
        End If

    End Function

End Class
