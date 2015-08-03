Imports System
Imports System.Collections.Generic
Imports System.Text

Imports System.Xml
Imports System.Net
Imports System.Security.Cryptography

Imports System.Security.Cryptography.Pkcs
Imports System.Security.Cryptography.X509Certificates
Imports System.IO
Imports Microsoft.VisualBasic



Public Module CertificadosX509Lib

    Public VerboseMode As Boolean = False

    ''' <summary> 
    ''' Firma mensaje 
    ''' </summary> 
    ''' <param name="argBytesMsg">Bytes del mensaje</param> 
    ''' <param name="argCertFirmante">Certificado usado para firmar</param> 
    ''' <returns>Bytes del mensaje firmado</returns> 
    ''' <remarks></remarks> 
    Public Function FirmaBytesMensaje(ByVal argBytesMsg As Byte(), ByVal argCertFirmante As X509Certificate2) As Byte()

        Try

            ' Pongo el mensaje en un objeto ContentInfo (requerido para construir el obj SignedCms) 
            Dim infoContenido As ContentInfo = New ContentInfo(argBytesMsg)
            Dim cmsFirmado As SignedCms = New SignedCms(infoContenido)

            ' Creo objeto CmsSigner que tiene las caracteristicas del firmante 
            Dim cmsFirmante As CmsSigner = New CmsSigner(argCertFirmante)
            cmsFirmante.IncludeOption = X509IncludeOption.EndCertOnly

            If (VerboseMode) Then
                Console.WriteLine("***Firmando bytes del mensaje...")
            End If

            ' Firmo el mensaje PKCS #7 
            cmsFirmado.ComputeSignature(cmsFirmante)

            If (VerboseMode) Then
                Console.WriteLine("***OK mensaje firmado")
            End If
            ' Encodeo el mensaje PKCS #7. 
            Return cmsFirmado.Encode()

        Catch excepcionAlFirmar As Exception
            Throw New Exception("***Error al firmar: " + excepcionAlFirmar.Message)
        End Try
    End Function

    ''' <summary> 
    ''' Lee certificado de disco 
    '''</summary> 
    ''' <param name="argArchivo">Ruta del certificado a leer.</param> 
    '''<returns>Un objeto certificado X509</returns> 
    ''' <remarks></remarks> 
    Public Function ObtieneCertificadoDesdeArchivo(ByVal argArchivo As String) As X509Certificate2

        Dim objCert As X509Certificate2 = New X509Certificate2()
        Try
            objCert.Import(Microsoft.VisualBasic.FileIO.FileSystem.ReadAllBytes(argArchivo))
            Return objCert
        Catch excepcionAlImportarCertificado As Exception
            Throw New Exception("argArchivo=" + argArchivo + " excepcion=" + excepcionAlImportarCertificado.Message + " " + excepcionAlImportarCertificado.StackTrace)
        End Try


    End Function















End Module
