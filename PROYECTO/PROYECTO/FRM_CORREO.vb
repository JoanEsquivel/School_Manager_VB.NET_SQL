Public Class FRM_CORREO

    Public documentos As List(Of String) = New List(Of String)
    Private Sub BTN_ENVIAR_Click(sender As Object, e As EventArgs) Handles BTN_ENVIAR.Click
        Dim CORREOS As String = TXTPARA.Text
        ENVIAR_CORREO_OUTLOOK_ADJUNTO(TXT_ASUNTO.Text, TXT_MENSAJE.Text, CORREOS, documentos, CORREO1)
        MsgBox("Correo enviado correctamente")
        Me.Close()
    End Sub

    'Selecciona el list view y lo agrega a la lista de documentos
    Private Sub docList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then
            documentos.Add(L.SelectedItems(0).SubItems(1).Text)
            MsgBox("Documento agregado a la lista de documentos adjuntos: " + L.SelectedItems(0).SubItems(1).Text, vbInformation + vbOKOnly, "Guardando")

        End If
    End Sub

    Private Sub TXTADJUNTAR_TextChanged(sender As Object, e As EventArgs) Handles TXTADJUNTAR.TextChanged
        REFRESCAR(L, "SELECT * FROM ADJUNTO WHERE pdf LIKE '%" & TXTADJUNTAR.Text & "%' ", 2)
    End Sub
End Class