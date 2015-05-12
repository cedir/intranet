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
        Dim importeCobrado As Decimal = lp.estudio.importeEstudioCobrado
        Return importeCobrado
    End Function


    


End Class



