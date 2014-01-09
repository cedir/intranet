Imports System.Collections.Generic

Public Class CalculadorHonorariosPagoMedico
    Implements ICalculadorHonorarios

    Public Function getImporteLineaPago(ByVal lp As LineaPagoMedico) As Decimal
        Dim importe As Decimal = 0
        Select Case True
            Case lp.estudio.esPagoContraFactura = 1
                importe = lp.estudio.PagoContraFactura
            Case Else
                Dim importeCobradoActualizado As Decimal = Me.aplicarReglasDeNegocioEnImporteCobrado(lp)

                'aplicar gastos administrativos
                importe = importeCobradoActualizado - (importeCobradoActualizado * lp.gastosAdministrativos / 100)

                'ahora calculamos el descuento
                importe = importe - lp.getDescuentos()
        End Select
        Return importe
    End Function


    Public Function getGastosAdministrativos(ByVal estudio As Estudio) As Decimal
        If estudio.esPagoContraFactura = 1 Then
            Return 0
        End If
        Dim cPresentacion As Presentacion
        Try
            Dim cPagoFacturacion As PagoFacturacion = estudio.presentacion.getPago
            Return cPagoFacturacion.gastoAdministrativo()
        Catch ex As Exception

        Finally
            cPresentacion = Nothing
        End Try
    End Function


    Private Function aplicarReglasDeNegocioEnImporteCobrado(ByVal lp As LineaPagoMedico) As Decimal
        Const ID_OBRA_SOCIAL_GALENO As Integer = 46

        Dim importeCobrado As Decimal = lp.estudio.importeEstudioCobrado
        If lp.estudio.obraSocial.idObraSocial = ID_OBRA_SOCIAL_GALENO Then
            importeCobrado = importeCobrado - getDescuentoOSGalenoPracticas(lp)
        End If

        Return importeCobrado
    End Function


    Private Function getDescuentoOSGalenoPracticas(ByVal lp As LineaPagoMedico) As Decimal
        Const DESCUENTO_DE_MEDICACION As Decimal = 240
        Dim arrayIdPracticasConDescuento As Integer() = {1, 2, 7, 13, 18, 19, 34, 35, 49}
        Array.Sort(arrayIdPracticasConDescuento)

        Dim descuento As Decimal = 0.0
        If (Array.BinarySearch(arrayIdPracticasConDescuento, lp.estudio.practica.idEstudio) >= 0) Then
            descuento = descuento + DESCUENTO_DE_MEDICACION ' siempre se hace el dto por medicacion
        End If
        Return descuento
    End Function


End Class



