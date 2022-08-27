Imports System.Net
Imports System.Net.Mail
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Core
Imports System.Reflection
Imports Microsoft.Win32

Module ENVIO_CORREOS

    Friend Sub ENVIAR_CORREO_OUTLOOK_ADJUNTO(ByVal ASUNTO As String, ByVal CUERPO As String, ByVal CDESTINO As String, ByRef ADJUNTOS As List(Of String), ByVal CORIGEN As String)



        Try
            Dim POSICION As Integer = 0
            Dim DESTINO As New SmtpClient("smtp.office365.com")
            DESTINO.Port = 587
            DESTINO.EnableSsl = True
            DESTINO.UseDefaultCredentials = False
            DESTINO.Credentials = New NetworkCredential(CORIGEN, PASSWORD)
            Dim cuerpoHTML As String = CUERPO
            Dim CUERPO_CORREO As String
            CUERPO_CORREO = CUERPO


            Dim emisor As New MailMessage
            emisor.To.Clear()
            emisor.From = New MailAddress(CORIGEN)
            emisor.To.Add(CDESTINO)
            emisor.Subject = ASUNTO
            emisor.Body = CUERPO_CORREO

            For Each doc As String In ADJUNTOS
                Dim ARCHIVO_ADJUNTO As New System.Net.Mail.Attachment(doc)
                emisor.Attachments.Add(ARCHIVO_ADJUNTO)
            Next

            'Dim ARCHIVO_ADJUNTO As New System.Net.Mail.Attachment(ADJUNTOS)
            'emisor.Attachments.Add(ARCHIVO_ADJUNTO)
            emisor.Priority = MailPriority.High
            emisor.IsBodyHtml = False
            DESTINO.Send(emisor)
            Exit Try
        Catch ex As Exception
            MsgBox("Ha ocurrido el siguiente inconveniente: " & vbNewLine + vbNewLine & ex.Message, vbCritical + vbOKOnly, "Problemas en el envío")
            Exit Try



            MsgBox("El correo electrónico no pudo ser enviado", vbExclamation + vbOKOnly, "Envío fallido")
        End Try
    End Sub
End Module
