Imports System.Collections.Generic
Imports CedirDataAccess
Imports Npgsql

Public Class CatalogoDeComprobantes


    Function getComprobantes(Optional ByVal nroComprobante As String = "", Optional ByVal tipo As String = "Ninguno", Optional ByVal responsable As String = "Ninguno", Optional ByVal fDesde As String = "", Optional ByVal fHasta As String = "", Optional ByVal condCliente As String = " true ", Optional ByVal idComprobante As Integer = 0) As List(Of Comprobante)
        Dim com As String = """"
        Dim condicion0 As String = ""
        Dim condicion1 As String = ""
        Dim condicion2 As String = ""
        Dim condicion3 As String = ""
        Dim condicion4 As String = ""
        Dim condicion5 As String = ""

        Dim concatenacion As String = ""

        getComprobantes = New List(Of Comprobante)
        '------esto es prueba
        If idComprobante <> 0 Then
            condicion5 = " c." & com & "idComprobante" & com & " = " & idComprobante
        Else : condicion5 = "true"
        End If
        '------


        If nroComprobante <> "" Then
            condicion0 = " c." & com & "nroComprobante" & com & " = " & Convert.ToInt32(nroComprobante.Trim)
        Else : condicion0 = "true"
        End If
        If tipo <> "Ninguno" Then
            condicion1 = " t." & com & "tipoComprobante" & com & " = '" & tipo & "'"
        Else : condicion1 = "true"
        End If

        If responsable <> "Ninguno" Then
            condicion2 = " c." & com & "responsable" & com & " = '" & responsable & "'"
        Else : condicion2 = "true"
        End If

        If fDesde <> "" And fHasta <> "" Then
            'busco entre las dos fechas
            condicion3 = " c." & com & "fechaEmision" & com & " between '" & fDesde & "' and '" & fHasta & "'"
        Else : If fDesde = "" And fHasta <> "" Then
                'busco hasta la fecha indicada
                condicion3 = " c." & com & "fechaEmision" & com & " <= '" & fHasta & "'"
            Else : If fDesde <> "" And fHasta = "" Then
                    'busco desde la fecha indicada
                    condicion3 = " c." & com & "fechaEmision" & com & " >= '" & fDesde & "'"
                    'vamos a hacer que por default traiga los comprobantes del mes anterior hasta ahora
                Else : condicion3 = " true " '" c." & com & "fechaEmision" & com & " >= '" & (Date.Today).AddMonths(-1) & "'"
                End If
            End If
        End If

        If condCliente <> " true " Then
            condCliente = " c." & com & "nombreCliente" & com & " like '" & condCliente & "%'"

        End If
        concatenacion = condicion0 & " and " & condicion1 & " and " & condicion2 & " and " & condicion3 & " and " & condCliente

        Dim dr As NpgsqlDataReader
        Try
            Dim cDatos As New Consultas
            'Llamamos a la capa de datos
            dr = cDatos.getComprobantes(concatenacion, "UPPER(" & com & "responsable" & com & "), " & com & "subTipo" & com & ", " & com & "nroComprobante" & com)
            Do While dr.Read

                'creo un comprobante y lo cargo con los datos del datareader
                Dim oComprobante As New Comprobante

                If dr("id") Is DBNull.Value Then
                    oComprobante.IdComprobante = ""
                Else : oComprobante.IdComprobante = dr("id")
                End If

                oComprobante.NroComprobante = Convert.ToInt32(dr("nroComprobante"))
                oComprobante.NroTerminal = Convert.ToInt32(dr("nroTerminal"))
                oComprobante.NombreCliente = Convert.ToString(dr("nombreCliente"))
                oComprobante.DomicilioCliente = Convert.ToString(dr("domicilioCliente"))


                If dr("nroCuit") Is DBNull.Value Then
                    oComprobante.NroCuit = ""
                Else : oComprobante.NroCuit = dr("nroCuit")
                End If

                oComprobante.CondicionFiscal = Convert.ToString(dr("condicionFiscal"))

                oComprobante.Responsable = Convert.ToString(dr("responsable"))

                If dr("gravado") Is DBNull.Value Then
                    oComprobante.Gravado = Nothing
                Else : oComprobante.Gravado.id = dr("gravado")
                    oComprobante.Gravado.descripcion = dr("descripcionGravado")
                    oComprobante.Gravado.porcentaje = Format(Convert.ToDecimal(dr("porcentajeGravado")), "############0.00")
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

                'ahora si es nd o nc buscamos la factura correspondiente
                If dr("idFactura") Is DBNull.Value Then
                    oComprobante.Factura = Nothing
                Else
                    oComprobante.getFactura(Convert.ToInt32(dr("idFactura")))
                End If

                oComprobante.TotalFacturado = Format(Convert.ToDecimal(dr("totalFacturado")), "###############0.00")
                oComprobante.TotalCobrado = Format(Convert.ToDecimal(dr("totalCobrado")), "###############0.00")
                oComprobante.GravadoPaciente = Convert.ToString(dr("gravadoPaciente"))

                'agregamos el comprobante a la colleccion de resultados
                getComprobantes.Add(oComprobante)


            Loop
        Catch ex As Exception

        Finally

        End Try

    End Function

    Public Function getUltimoNro(ByVal idTipo As Int32, Optional ByVal responsable As String = "", Optional ByVal subtipo As String = "", Optional ByVal nroTerminal As Integer = 1) As Int32
        Dim com As String = """"
        Dim cDatos As New Nuevo
        Dim dr As NpgsqlDataReader
        Try

            Dim filtro As String
            filtro = " left join " & com & "cedirData" & com & "." & com & "tblComprobantesTipo" & com & " as t on " & com & "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "idTipoComprobante" & com & " = t.id "
            Dim filtro1 As String
            filtro1 = " WHERE UPPER(" & com & "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "responsable" & com & ") = '" & responsable.ToUpper() & "' and UPPER(" & com & "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "subTipo" & com & ") = '" & subtipo.ToUpper() & "'"
            Dim filtro3 As String
            filtro3 = " AND " & com & "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "idTipoComprobante" & com & " in(1,3)"

            If nroTerminal = 90 Then
                filtro3 = " AND " & com & "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "idTipoComprobante" & com & " in( " & idTipo & " )"
            End If

            Dim filtro4 As String
            filtro4 = " AND " & com & "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "nroTerminal" & com & " = " & nroTerminal
            
            Dim filtroTotal As String

            If idTipo <> 2 Then 'No es liquidacion
                filtroTotal = filtro & filtro1 & filtro3 & filtro4
            Else : filtroTotal = filtro & " where " & com & "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "idTipoComprobante" & com & " in(2)"

            End If

            Return cDatos.selectMAX("tblComprobantes", "cedirData" & com & "." & com & "tblComprobantes" & com & "." & com & "nroComprobante", filtroTotal)


        Catch ex As Exception
        Finally
            cDatos = Nothing
            dr = Nothing
        End Try


    End Function


End Class
