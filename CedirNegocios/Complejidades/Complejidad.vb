Imports System.Collections.Generic
Imports CedirDataAccess
Public Class Complejidad

#Region "Propiedades"
    Private m_id As UInt32
    Private m_importe As Decimal

    Private com As String = """"
    Public Property id() As UInt32
        Get
            Return m_id
        End Get
        Set(ByVal value As UInt32)
            m_id = value
        End Set
    End Property
    Public Property importe() As Decimal
        Get
            Return m_importe
        End Get
        Set(ByVal value As Decimal)
            m_importe = value
        End Set
    End Property
 
#End Region

    Public Sub New()

    End Sub


    Overridable Function getImporte() As Decimal

    End Function
    Public Overridable Function isComplejidad(ByVal colEst As Array) As Boolean


    End Function

    Public Function modificar(ByVal c As Complejidad) As String
        Dim cDatos As New CedirDataAccess.Nuevo
        Dim tabla As String = com & "cedirData" & com & "." & com & "tblComplejidades" & com
        Dim campos As String = com & "importe" & com & " = " & c.importe
        Dim condicion As String = " where " & com & "id" & com & " = " & c.id
        Return cDatos.update(tabla, campos, condicion)
    End Function





End Class
