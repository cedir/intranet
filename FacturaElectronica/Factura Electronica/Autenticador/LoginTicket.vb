Imports System
Imports System.Collections.Generic
Imports System.Text

Imports System.Xml
Imports System.Net
Imports System.Security.Cryptography
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports Microsoft.VisualBasic

    Public Class LoginTicket

    ' Entero de 32 bits sin signo que identifica el requerimiento 
    Public UniqueId As UInt32
    ' Momento en que fue generado el requerimiento 
    Public GenerationTime As DateTime
    ' Momento en el que exoira la solicitud 
    Public ExpirationTime As DateTime
    ' Identificacion del WSN para el cual se solicita el TA 
    Public Service As String
    ' Firma de seguridad recibida en la respuesta 
    Public Sign As String
    ' Token de seguridad recibido en la respuesta 
    Public Token As String

    Public XmlLoginTicketRequest As XmlDocument = Nothing
    Public XmlLoginTicketResponse As XmlDocument = Nothing
    Public XmlStrLoginTicketRequestTemplate As String = "<loginTicketRequest><header><uniqueId></uniqueId><generationTime></generationTime><expirationTime></expirationTime></header><service></service></loginTicketRequest>"



    ' OJO! NO ES THREAD-SAFE 
    Private _globalUniqueID As UInt32 = 0

    '''<summary> 
    ''' Construye un Login Ticket obtenido del WSAA 
    '''</summary> 
    '''<param name="argServicio">Servicio al que se desea acceder</param> 
    '''<param name="argUrlWsaa">URL del WSAA</param> 
    '''<param name="argRutaCertX509Firmante">Ruta del certificado X509 (con clave privada) usado para firmar</param> 
    '''<remarks></remarks> 
    Public Function ObtenerLoginTicketResponse(ByVal argServicio As String, ByVal argUrlWsaa As String, ByVal argRutaCertX509Firmante As String) As String
        Dim cmsFirmadoBase64 As String
        Dim loginTicketResponse As String

        Dim xmlNodoUniqueId As XmlNode
        Dim xmlNodoGenerationTime As XmlNode
        Dim xmlNodoExpirationTime As XmlNode
        Dim xmlNodoService As XmlNode



        ' PASO 1: Genero el Login Ticket Request 
        Try


            XmlLoginTicketRequest = New XmlDocument()
            XmlLoginTicketRequest.LoadXml(XmlStrLoginTicketRequestTemplate)

            xmlNodoUniqueId = XmlLoginTicketRequest.SelectSingleNode("//uniqueId")
            xmlNodoGenerationTime = XmlLoginTicketRequest.SelectSingleNode("//generationTime")
            xmlNodoExpirationTime = XmlLoginTicketRequest.SelectSingleNode("//expirationTime")
            xmlNodoService = XmlLoginTicketRequest.SelectSingleNode("//service")

            xmlNodoGenerationTime.InnerText = DateTime.Now.AddMinutes(-10).ToString("s")
            xmlNodoExpirationTime.InnerText = DateTime.Now.AddMinutes(+10).ToString("s")
            xmlNodoUniqueId.InnerText = CStr(_globalUniqueID)
            xmlNodoService.InnerText = argServicio
            Me.Service = argServicio



        Catch excepcionAlGenerarLoginTicketRequest As Exception

            Throw New Exception("***Error GENERANDO el LoginTicketRequest : " + excepcionAlGenerarLoginTicketRequest.Message)

        End Try
        ' PASO 2: Firmo el Login Ticket Request 
        Try

            Dim certFirmante As X509Certificate = CertificadosX509Lib.ObtieneCertificadoDesdeArchivo(argRutaCertX509Firmante)
            ' Convierto el login ticket request a bytes, para firmar 
            Dim EncodedMsg As Encoding = Encoding.UTF8
            Dim msgBytes As Byte() = EncodedMsg.GetBytes(XmlLoginTicketRequest.OuterXml)

            ' Firmo el msg y paso a Base64 
            Dim encodedSignedCms As Byte() = CertificadosX509Lib.FirmaBytesMensaje(msgBytes, certFirmante)
            cmsFirmadoBase64 = Convert.ToBase64String(encodedSignedCms)


        Catch excepcionAlFirmar As Exception

            Throw New Exception("***Error FIRMANDO el LoginTicketRequest : " + excepcionAlFirmar.Message)
        End Try

        ' PASO 3: Invoco al WSAA para obtener el Login Ticket Response 
        Try


            Dim servicioWsaa As FacturaElectronica.ar.gov.afip.wsaahomo.LoginCMSService = New FacturaElectronica.ar.gov.afip.wsaahomo.LoginCMSService()

            loginTicketResponse = servicioWsaa.loginCms(cmsFirmadoBase64)

        Catch excepcionAlInvocarWsaa As Exception
            Throw New Exception("***Error INVOCANDO al servicio WSAA : " + excepcionAlInvocarWsaa.Message)
        End Try


        ' PASO 4: Analizo el Login Ticket Response recibido del WSAA 
        Try

            XmlLoginTicketResponse = New XmlDocument()
            XmlLoginTicketResponse.LoadXml(loginTicketResponse)

            Me.UniqueId = UInt32.Parse(XmlLoginTicketResponse.SelectSingleNode("//uniqueId").InnerText)
            Me.GenerationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//generationTime").InnerText)
            Me.ExpirationTime = DateTime.Parse(XmlLoginTicketResponse.SelectSingleNode("//expirationTime").InnerText)
            Me.Sign = XmlLoginTicketResponse.SelectSingleNode("//sign").InnerText
            Me.Token = XmlLoginTicketResponse.SelectSingleNode("//token").InnerText

        Catch excepcionAlAnalizarLoginTicketResponse As Exception

            Throw New Exception("***Error ANALIZANDO el LoginTicketResponse : " + excepcionAlAnalizarLoginTicketResponse.Message)


        End Try

        Return loginTicketResponse


    End Function

 
End Class