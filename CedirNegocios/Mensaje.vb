Imports System.Collections.Generic
Imports CedirDataAccess
Public Class Mensaje

    Private m_idMensaje As Integer
    Private m_mensaje As String
    Private m_estado As Integer
    Private m_fechaMensaje As Date
    Private m_hora As String
    Private m_emisor As Usuario
    Private m_destinatario As List(Of Usuario)

    Public Sub New()
        idMensaje = 0
        emisor = New Usuario
        mensaje = ""
        estado = 0
        destinatarios = New List(Of Usuario)
    End Sub


    Public Property idMensaje() As Integer
        Get
            Return m_idMensaje
        End Get
        Set(ByVal Value As Integer)
            m_idMensaje = Value
        End Set
    End Property
    Public Property emisor() As Usuario
        Get
            Return m_emisor
        End Get
        Set(ByVal value As Usuario)
            m_emisor = value
        End Set
    End Property

    Public Property mensaje() As String
        Get
            Return m_mensaje
        End Get
        Set(ByVal Value As String)
            m_mensaje = Value
        End Set
    End Property
    Public Property estado() As Integer
        Get
            Return m_estado
        End Get
        Set(ByVal Value As Integer)
            m_estado = Value
        End Set
    End Property
    Public Property fecha() As Date
        Get
            Return (m_fechaMensaje)
        End Get
        Set(ByVal Value As Date)
            m_fechaMensaje = Value
        End Set
    End Property

    Public Property destinatarios() As List(Of Usuario)
        Get
            Return m_destinatario
        End Get
        Set(ByVal Value As List(Of Usuario))
            m_destinatario = Value
        End Set
    End Property
    Public Property hora() As String
        Get
            Return m_hora
        End Get
        Set(ByVal Value As String)
            m_hora = Value
        End Set
    End Property


    Public Sub update(ByVal msg As Mensaje)
        Dim com As String = """"
        Dim cDatos As New Nuevo
        Dim tabla As String = com & "public" & com & "." & com & "tblMensajes" & com
        Dim campo As String = com & "estado" & com & " = " & msg.estado
        Dim filtro As String = " where " & com & "idMensaje" & com & " = " & msg.idMensaje

        cDatos.update(tabla, campo, filtro)
        cDatos = Nothing
    End Sub

    Public Sub eliminar(ByVal msg As Mensaje)

        Dim com As String = """"
        Dim cDatos As New Nuevo
        Dim tabla As String = "tblMensajes"
        Dim filtro As String = com & "idMensaje" & com & " = " & msg.idMensaje

        cDatos.delete(tabla, filtro)
        cDatos = Nothing
    End Sub






End Class
