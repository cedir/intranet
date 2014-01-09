Imports System
Imports System.Collections.Generic
Imports CedirDataAccess
Imports Npgsql
Public Class CatalogoDeMovimientosStock
    Dim com As String = """"

#Region "PROPIEDADES"
    Private m_lista As List(Of MovimientoStockMedicamento)
#End Region

    Public Sub New()
        Me.m_lista = New List(Of MovimientoStockMedicamento)
        Me.m_lista.Clear()
    End Sub


    Public Function getMovimientosStockMedicacion(ByVal fDesde As Date, ByVal fHasta As Date) As System.Collections.Generic.List(Of MovimientoStockMedicamento)

        'traigo los movimientos entre el rango de fecha ingresado

        Dim dr As NpgsqlDataReader
        Dim cDatos As New Consultas
        dr = cDatos.getMovimientosStockAll(com & "fecha" & com & " between '" & fDesde & "' and '" & fHasta & "'")


        'como los movimientos pueden ser de medicamentos, voy a traer los medicamentos e identificar cual es
        Dim catMed As New CatalogoDeMedicamentos
        Dim arrMed As New ArrayList
        arrMed = catMed.traerMedicamentos()

        Try

            Do While (dr.Read())
                'creo un movimiento nuevo y lo cargo con los datos del dr
                Dim oMov As New MovimientoStockMedicamento

                Dim i As Integer
                For i = 0 To arrMed.Count - 1
                    If CType(arrMed(i), Medicamento).descripcion = Convert.ToString(dr("descripcionMedicamento")) Then
                        oMov.medicamento = CType(arrMed(i), Medicamento)
                    End If
                Next

                'asigno los datos del movimiento
                oMov.Id = Convert.ToInt32(dr("id"))
                oMov.Fecha = (dr("fecha"))
                ' oMov.Hora = CStr(dr("hora"))
                oMov.cantidad = Convert.ToInt32(dr("cantidad"))
                oMov.descripcion = Convert.ToString(dr("descripcion"))
                'asigno el usuario que realizo el movimiento
                If dr("idUsuario") Is DBNull.Value Then
                    oMov.Usuario = Nothing
                Else
                    'si el id no es vacio, significa que los otros datos tampoco
                    'Hacemos esto en caso de que se haya eliminado un usuario
                    oMov.Usuario.id = Convert.ToInt32(dr("idUsuario"))
                    oMov.Usuario.nombreUsuario = Convert.ToString(dr("nombreUsuario"))
                    oMov.Usuario.password = Convert.ToString(dr("password"))
                    oMov.Usuario.idMedico = Convert.ToInt32(dr("idMedico"))
                End If



                'agrego a la lista
                Me.m_lista.Add(oMov)

                oMov = Nothing

            Loop 'fin while

        Finally
            catMed = Nothing
            arrMed = Nothing
        End Try

        Return Me.m_lista

    End Function

    Public Function crearMovimientoStockMedicacion(ByVal mov As MovimientoStockMedicamento) As String

        Dim maxid As Integer
        Try
            mov.medicamento.stock = mov.medicamento.stock + mov.cantidad
            mov.medicamento.actualizarStock()
            maxid = mov.crear()


            Return "ok"
        Catch ex As Exception
            Return ex.Message()
        Finally
            'registramos quien realizó el movimiento
            Dim sSecurity As Security = Security.GetInstance()
            Dim cUsuario As Usuario = sSecurity.getLoggedUser
            Dim vLog As New AuditLog
            vLog.usuario = cUsuario
            vLog.objectId = maxid 'id autoincremental de la db
            vLog.objectTypeId = 4 'Movimiento de Stock
            vLog.userActionId = 1 'create
            vLog.observacion = "FINALIZADO CORRECTAMENTE"
            vLog.create()
        End Try





    End Function


End Class
