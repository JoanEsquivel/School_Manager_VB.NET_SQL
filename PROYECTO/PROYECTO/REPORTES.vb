Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO

Imports System.Web.Mail
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Core
Imports System.Reflection
Imports Microsoft.Win32

Module REPORTES
    Dim OWORD As New Word.Application
    Dim DOCUMENTO As New Word.Document
    Dim DIRECTORIO As String
    Dim REPORTE_DIRECCION_PDF As String = ""
    Dim REPORTE_DIRECCION_WORD As String = ""
    Dim NOMBRE_REPORTE As String


    Friend Sub INSERTAR_REGLON(ByVal ES_EL_PRIMER_PARRAFO As Boolean, ByRef PARRAFO As Word.Paragraph, ByVal TEXTO As String, ByVal NEGRITA As Boolean, ByVal CURSIVA As Boolean, ByVal TAMANO As Byte, ByVal NOMBRE_FUENTE As String, ByVal ALINEACION As Char, ByVal ESPACIADO_ANTERIOR As Byte)

        If ES_EL_PRIMER_PARRAFO = True Then
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add
        Else
            PARRAFO = DOCUMENTO.Content.Paragraphs.Add(DOCUMENTO.Bookmarks.Item("\endofdoc").Range)
        End If
        PARRAFO.Range.Text = TEXTO
        If NEGRITA = True Then
            PARRAFO.Range.Font.Bold = True
        Else
            PARRAFO.Range.Font.Bold = False
        End If

        If CURSIVA = True Then
            PARRAFO.Range.Font.Italic = True
        Else
            PARRAFO.Range.Font.Italic = False
        End If

        PARRAFO.Range.Font.Size = TAMANO
        PARRAFO.Range.Font.Name = NOMBRE_FUENTE

        Select Case ALINEACION
            Case "I" 'IZQUIERDA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphLeft
            Case "D" 'DERECHA
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
            Case "J" 'JUSTIFICADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphJustify
            Case "C" 'CENTRADO
                PARRAFO.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
        End Select
        PARRAFO.Format.SpaceAfter = ESPACIADO_ANTERIOR
        PARRAFO.Range.InsertParagraphAfter()
    End Sub

    Friend Sub INSERTAR_LINEA_BLANCO(ByRef PARRAFO_ANTERIOR As Word.Paragraph, ByVal CANTIDAD_LINEAS_EN_BLANCO As Byte)
        Dim I As Byte
        For I = 1 To CANTIDAD_LINEAS_EN_BLANCO
            PARRAFO_ANTERIOR.Range.InsertParagraphBefore()
        Next
    End Sub


    Friend Sub CREAR_DIRECTORIO()
        DIRECTORIO = "C:\REPORTES"
        Directory.CreateDirectory(DIRECTORIO)
    End Sub

    Friend Sub GUARDAR_DOCUMENTO_PDF()
        Dim DIRECCION As String = DIRECTORIO & "\" & NOMBRE_REPORTE
        DOCUMENTO.SaveAs2(DIRECCION & ".DOCX")
        REPORTE_DIRECCION_WORD = DIRECCION & ".DOCX"
        DOCUMENTO.ExportAsFixedFormat(DIRECCION, WdExportFormat.wdExportFormatPDF, False)
        REPORTE_DIRECCION_PDF = DIRECCION & ".pdf"

        'If MsgBox("¿Desea enviar el documento a la impresora?", vbQuestion + vbYesNo, "Impresora") = vbYes Then
        'DOCUMENTO.PrintOut()
        'End If
    End Sub

    Friend Sub CERRAR_DOCUMENTO_WORD()
        'OWORD.Documents.Close()
        OWORD.Application.Quit()
        OWORD = Nothing
        DOCUMENTO = Nothing
    End Sub


    Friend Sub IMPRIMIR(ByVal NR As Integer)
        OWORD.Visible = False
        'DOCUMENTO = OWORD.Documents.Add

        NOMBRE_REPORTE = "Reporte " & NR & " - " & "Factura Cliente"

        GUARDAR_DOCUMENTO_PDF()
        CERRAR_DOCUMENTO_WORD()

    End Sub


End Module
