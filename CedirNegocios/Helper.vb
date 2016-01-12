Imports CedirDataAccess
Imports Npgsql
Imports System.Text.RegularExpressions
Imports System.Guid
Imports Microsoft.VisualBasic
Imports System.Text
Imports System.Collections.Generic


Public Class Helper

    Dim com As String = """"

    Shared Function IsSuccess(ByVal result As Dictionary(Of String, String)) As Boolean
        Return result.ContainsKey(Constants.SUCCESS) And Boolean.Parse(result.Item(Constants.SUCCESS))
    End Function

    Shared Function GetMessage(ByVal result As Dictionary(Of String, String)) As String
        Return IIf(result.ContainsKey(Constants.MESSAGE), result.Item(Constants.MESSAGE), String.Empty)
    End Function

    Shared Sub SetSuccess(ByVal result As Dictionary(Of String, String), ByVal value As Boolean)
        result.Item(Constants.SUCCESS) = value.ToString
    End Sub

    Shared Sub SetMessage(ByVal result As Dictionary(Of String, String), ByVal message As String)
        result.Item(Constants.MESSAGE) = message
    End Sub

    Shared Function Result(ByVal r As Dictionary(Of String, String), ByVal value As Boolean, ByVal message As String) As Dictionary(Of String, String)
        r.Item(Constants.SUCCESS) = value.ToString
        r.Item(Constants.MESSAGE) = message
        Return r
    End Function

    Public Function obtenerUltimoNro(ByVal tabla As String, ByVal campo As String) As Integer
        Dim da As New Consultas
        Dim dr As NpgsqlDataReader
        dr = da.EjecutarSelect("select max(" & com & campo & com & ") from " & com & "cedirData" & com & "." & com & tabla & com)
        dr.Read()
        Return dr.Item(0)
    End Function

    Public Shared Function EsComprobanteElectronico(ByVal tipoComprobanteId As Int32) As Boolean
        'TODO: quitar la constante
        Return tipoComprobanteId <> TComprobante.Liquidacion
    End Function

    Public Function existeId(ByVal nombreTabla As String, ByVal condicion As String) As Boolean
        Dim da As New Consultas
        'Se utiliza solo para saber si esxiste un arancel en obraSocial
        Dim drOS As NpgsqlDataReader
        drOS = da.Tabla(nombreTabla, condicion)
        If drOS.Read Then
            Return True
        Else : Return False
        End If
    End Function

    Public Function getMonthString(ByVal number As Integer) As String
        Dim arrMonths As String() = Me._getMonthsArr
        Return arrMonths(number - 1)
    End Function
    Public Function getMonthNumber(ByVal name As String) As Integer
        Dim arrMonths As String() = Me._getMonthsArr
        For i As Integer = 0 To UBound(arrMonths)
            If arrMonths(i) = name Then
                Return (i + 1)
            End If
        Next
    End Function
    Public Function _getMonthsArr() As String()
        Dim arrMeses(11) As String
        arrMeses(0) = "Enero"
        arrMeses(1) = "Febrero"
        arrMeses(2) = "Marzo"
        arrMeses(3) = "Abril"
        arrMeses(4) = "Mayo"
        arrMeses(5) = "Junio"
        arrMeses(6) = "Julio"
        arrMeses(7) = "Agosto"
        arrMeses(8) = "Septiembre"
        arrMeses(9) = "Octubre"
        arrMeses(10) = "Noviembre"
        arrMeses(11) = "Diciembre"

        Return arrMeses
    End Function


    'VALIDA numeros ingresados, pudiendo contener decimales
    Public Function validaNumero(ByVal exp As String) As Boolean
        Dim objRegExp As New Regex("(^-?\d\d*\.\d*$)|(^-?\d\d*$)|(^-?\.\d\d*$)")
        Return objRegExp.IsMatch(exp)
    End Function


    'FUNCION PARA CHECKEAR VALORES NULOS DE UN DATAREADER
    Private Function CheckNullDR(Of T)(ByVal checkValue As Object) As T
        Dim outValue As T
        If checkValue Is DBNull.Value Then
            'si es dbnull, llenamos el objeto con nothing
            outValue = Nothing
        Else : outValue = CType(checkValue, T)
        End If
        Return outValue
    End Function

    'FUNCION CONVERTIDOR DE DATE A FORMATO YYYY-MM-DD
    Public Function convertDate(ByVal d As Date) As String
        'fecha que devolvemos, corregida
        Dim fecha As String
        'le asignamos el parametro, pero sin la hora 
        fecha = d.Date.ToString.Substring(0, 10).Trim
        Dim r As New Regex("(/)")
        Dim arrR As String()
        'dividimos la fehca separando por /
        arrR = r.Split(fecha)
        fecha = arrR(4) & "/" & arrR(2) & "/" & arrR(0)

        Return fecha
    End Function


    Public Function validarDireccionMail(ByVal mailAValidar As String) As Boolean
        Return Regex.IsMatch(mailAValidar, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Public Function generarPublicID() As String
        Dim caracteresValidos As String = "_ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789abcddefghijklmnopqrstuvwxyz"
        Dim r As New Random
        Dim sb As New StringBuilder


        'Dim sGUID As String
        Dim arr As New List(Of String)
        For i As Integer = 1 To 6
            Dim idx As Integer = r.Next(0, caracteresValidos.Length() - 1) 'el largo de caracteresValidos
            sb.Append(caracteresValidos.Substring(idx, 1))
        Next

        Return sb.ToString()


    End Function

End Class
