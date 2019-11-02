Public Enum TComprobante As Integer
    Factura = 1
    Liquidacion = 2
    NotaDeDebito = 3
    NotaDeCredito = 4
    FacturaElectronica = 5
End Enum

Public Class Constants
    Public Const SUCCESS As String = "success"
    Public Const MESSAGE As String = "message"
    Public Const MIN_FACT As Decimal = 0.01D
End Class
