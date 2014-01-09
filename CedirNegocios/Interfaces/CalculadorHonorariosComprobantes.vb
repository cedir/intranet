Imports System.Collections.Generic
Public Class CalculadorHonorariosComprobantes

    Implements ICalculadorHonorarios

    Dim _dict As Dictionary(Of String, Decimal)

    Public Property Dict() As Dictionary(Of String, Decimal)
        Get
            Return _dict
        End Get
        Set(ByVal value As Dictionary(Of String, Decimal))
            _dict = value
        End Set
    End Property

   
    Public Sub testGetHonorariosPresentacion(ByVal _comprobante As Comprobante)


        Dim honorarios As Decimal = 0
        Dim anestesia As Decimal = 0
        Dim totalMedicacionPresentadaSinMatEspecifico As Decimal = 0.0


        Dict = New Dictionary(Of String, Decimal)
        'Primero, voy a buscar si el comprobante tiene una presentacion asociada.
        Dim catPresentacion As New CatalogoDePresentaciones
        Dim arrPresentaciones As New ArrayList
        'Si el comprobante no es una factura, tenemos que aplicar RN
        If _comprobante.TipoComprobante.Id <> 1 Then
            'esto hay que modificarlo. Comentar a waly, Contadora.
            honorarios = 0
            anestesia = 0
            totalMedicacionPresentadaSinMatEspecifico = 0.0
        Else

            'Si el comprobante es una factura, no tiene que estar anulada para calcular el comprobante
            If _comprobante.Estado.ToUpper() = "ANULADO" Then
                honorarios = 0
                anestesia = 0
                totalMedicacionPresentadaSinMatEspecifico = 0.0
            Else
                'Si el comprobante es una factura, buscamos la presentacion asociada+
                arrPresentaciones = catPresentacion.traerPresentaciones(, , , , , _comprobante.IdComprobante, , )

                If arrPresentaciones.Count = 0 Then
                    'Honorarios de facturas no asociadas a presentaciones
                    honorarios = 0
                    totalMedicacionPresentadaSinMatEspecifico = 0.0
                Else
                    'Buscamos la presentacion asociada a la factura.
                    'Siempre es la primera de la lista
                    Dim _presentacion As Presentacion = arrPresentaciones(0)
                    _presentacion.cargarFacturacion()
                    Dim porcentaje As Decimal = _presentacion.getPorcentajeGtosAdmin()

                    Dim arrLineasPresentacionEstudios As ArrayList
                    arrLineasPresentacionEstudios = _presentacion.getLineasDeFacturacionEstudios()
                    Dim i As Integer = 0
                    For i = 0 To arrLineasPresentacionEstudios.Count() - 1
                        Dim linea As New LineaDeFacturacion
                        Dim estudio As New Estudio
                        linea = arrLineasPresentacionEstudios(i)
                        estudio = linea.objeto
                        Dim lineaPago As New LineaPagoMedico
                        lineaPago.estudio = estudio
                        lineaPago.idMedico = estudio.medicoActuante.idMedico
                        Dim percToMed As Decimal = lineaPago.getPorcentaje()
                        Dim dtoPoliColangio As Decimal = lineaPago.getDescuentos()
                        'NOTA: actualmente se esta aplicando refacturacion a presentaciones, pero hay que analizar como 
                        'lo estan haciendo, ya que quedan monto de estudio =0
                        'ahora lo vamos a saltear para el calculo de honorarios
                        If lineaPago.estudio.ImporteEstudio = 0 Then
                            Continue For
                        End If

                        'calculamos el honorario correspondiente
                        Dim r1 As Decimal = ((estudio.ImporteEstudio - estudio.DiferenciaPaciente) * ((100 - porcentaje) / 100)) - dtoPoliColangio
                        honorarios = honorarios + Format((percToMed * r1 / 100), "###########0.00")
                        'anestesia es el valor cobrado de la presentacion , MENOS EL 10 %
                        anestesia = anestesia + (estudio.ArancelAnestesia * 0.9)


                        'Contemplamos el valor de la medicacion al momento de presentarla. No al momento de cobrar. No consideramos material especifico
                        totalMedicacionPresentadaSinMatEspecifico += getImporteMedicacionSinMaterialEspecifico(estudio)

                    Next
                End If
            End If
        End If
        'cargamos ambos valores al dict. 
        Dict.Add("honorario", honorarios)
        Dict.Add("anestesia", anestesia)
        Dict.Add("importeMedicacion", totalMedicacionPresentadaSinMatEspecifico)


    End Sub

    'Private Function getImporteAnestesia(ByVal estudio As Estudio) As Decimal
    '    Dim i As Integer = 0
    '    For i = 0 To estudio.arrMedicacion.Count() - 1
    '        Dim m As Medicacion
    '        m = estudio.arrMedicacion(i)
    '        'checkeamos si el estudio contiene la medicacion correspondiente a 
    '        'pago de anestesia

    '    Next


    '    Return 0
    'End Function

    Private Function getImporteMedicacionSinMaterialEspecifico(ByVal estudio As Estudio) As Decimal
        Dim arr As New ArrayList
        arr = estudio.arrMedicacion
        Dim totalMedicacionMaterialEspecifico As Decimal = 0.0
        Dim i As Integer = 0
        For i = 0 To arr.Count - 1
            Dim m As Medicacion
            m = arr(i)
            If m.esMaterialEspecifico Then
                totalMedicacionMaterialEspecifico += m.importe
            End If
        Next
        Return (estudio.importeMedicacion - totalMedicacionMaterialEspecifico)
    End Function
End Class
