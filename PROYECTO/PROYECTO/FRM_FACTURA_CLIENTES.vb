Imports Microsoft.Office.Interop
Imports Microsoft.Office.Interop.Word
Imports System.IO

Imports System.Web.Mail
Imports System.Runtime.InteropServices
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports Microsoft.Office.Core
Imports System.Reflection
Imports Microsoft.Win32
Public Class FRM_FACTURA_CLIENTES
	Dim CONTADOR As Integer = 1
	Dim ID As Integer = 0
	Dim PARAGRAPH_ID_EMPLEADO, PARAGRAPH_FECHA_CANCELACION, PARAGRAPH_ID_CLIENTE, PARAGRAPH_ID_HABITACION, PARAGRAPH_MONTO As Word.Paragraph
	Dim pID_EMPLEADO, pFECHA_CANCELACION, pID_CLIENTE, pID_HABITACION, pMONTO As String

	Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

	End Sub
	'Validar Lleno
	Friend Sub validar_lleno()
		If identificacion.Text <> "    -    -" And FECHA_HORA_CANCELACION.Text <> "" And ID_CLIENTE.Text <> "" And ID_HABITACION.Text <> "" And MONTOCANCELADO.Text <> "" Then
			BotonGuardar.Enabled = True
		Else
			BotonGuardar.Enabled = False
		End If
	End Sub



	'Limpiar
	Friend Sub limpiar()

		REFRESCAR(L, "SELECT * FROM FACTURA_CLIENTES", 6)

		identificacion.Clear()
		identificacion.Tag = 0
		FECHA_HORA_CANCELACION.Clear()
		ID_CLIENTE.Clear()
		ID_HABITACION.Clear()
		MONTOCANCELADO.Clear()


		validar_lleno()

	End Sub


	Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click


		If identificacion.Tag = 0 Then

			SQL = "INSERT INTO FACTURA_CLIENTES (ID, ID_EMPLEADO, FECHA_HORA_CANCELACION, ID_CLIENTE, ID_HABITACION, MONTO_CANCELADO) VALUES (" & PK("FACTURA_CLIENTES", "ID") & ", '" & identificacion.Text & "', '" & FECHA_HORA_CANCELACION.Text & "', '" & ID_CLIENTE.Text & "',  '" & ID_HABITACION.Text & "',  '" & MONTOCANCELADO.Text & "')"



		End If

		EJECUTAR(SQL)
		limpiar()
		MsgBox("Los datos se han almacenado satisfactoraimente. ", vbInformation + vbOKOnly, "Guardando")


	End Sub

	Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
		If MsgBox("Desea eliminar?", vbQuestion + vbYesNo, "Verificando") = vbYes Then
			SQL = "DELETE FROM FACTURA_CLIENTES WHERE ID = " & identificacion.Tag & ""
			EJECUTAR(SQL)
			limpiar()
			MsgBox("Los datos se han eliminado.", vbInformation + vbOKOnly, "Eliminando")
			REFRESCAR(L, "SELECT ID, ID_EMPLEADO, FECHA_HORA_CANCELACION, ID_CLIENTE, ID_HABITACION, MONTO_CANCELADO FROM FACTURA_CLIENTES WHERE ID LIKE '" & buscando.Text & "%'", 6)

		End If
	End Sub


	Private Sub buscando_TextChanged(sender As Object, e As EventArgs) Handles buscando.TextChanged
		REFRESCAR(L, "SELECT ID, ID_EMPLEADO, FECHA_HORA_CANCELACION, ID_CLIENTE, ID_HABITACION, MONTO_CANCELADO FROM FACTURA_CLIENTES WHERE ID_CLIENTE LIKE '" & buscando.Text & "%'", 6)

	End Sub



	Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
		Me.Close()
	End Sub

	Private Sub identificacion_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles identificacion.MaskInputRejected
		validar_lleno()
	End Sub

	Private Sub FECHA_HORA_CANCELACION_TextChanged(sender As Object, e As EventArgs) Handles FECHA_HORA_CANCELACION.TextChanged
		validar_lleno()
	End Sub

	Private Sub ID_CLIENTE_TextChanged(sender As Object, e As EventArgs) Handles ID_CLIENTE.TextChanged
		validar_lleno()
	End Sub

	Private Sub ID_HABITACION_TextChanged(sender As Object, e As EventArgs) Handles ID_HABITACION.TextChanged
		validar_lleno()
	End Sub

	Private Sub MONTOCANCELADO_TextChanged(sender As Object, e As EventArgs) Handles MONTOCANCELADO.TextChanged
		validar_lleno()
	End Sub



	Private Sub FRM_FACTURA_CLIENTES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Me.MdiParent = FRM_Padre
	End Sub

	Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
		If L.SelectedItems.Count > 0 Then
			identificacion.Tag = L.SelectedItems(0).SubItems(0).Text
			identificacion.Text = L.SelectedItems(0).SubItems(1).Text
			FECHA_HORA_CANCELACION.Text = L.SelectedItems(0).SubItems(2).Text
			ID_CLIENTE.Text = L.SelectedItems(0).SubItems(3).Text
			ID_HABITACION.Text = L.SelectedItems(0).SubItems(4).Text
			MONTOCANCELADO.Text = L.SelectedItems(0).SubItems(5).Text
		End If
	End Sub

	Private Sub ACTUALIZAR_Click(sender As Object, e As EventArgs) Handles ACTUALIZAR.Click
		If identificacion.Tag <> 0 Then
			SQL = "UPDATE FACTURA_CLIENTES SET ID_EMPLEADO = '" & identificacion.Text & "', FECHA_HORA_CANCELACION = '" & FECHA_HORA_CANCELACION.Text & "', ID_CLIENTE ='" & ID_CLIENTE.Text & "', ID_HABITACION = '" & ID_HABITACION.Text & "', MONTO_CANCELADO = '" & MONTOCANCELADO.Text & "' WHERE ID = " & identificacion.Tag & " "

		End If
		EJECUTAR(SQL)
		limpiar()
		MsgBox("Los datos se han almacenado satisfactoraimente. ", vbInformation + vbOKOnly, "Guardando")

	End Sub

	Friend Sub DATOS()
		T.Tables.Clear()
		SQL = "SELECT * FROM FACTURA_CLIENTES"
		CARGAR_TABLA(T, SQL)
	End Sub




	Friend Sub CREARDOCUMENTO()

        CREAR_DIRECTORIO()
        DATOS()
		Dim First_Paragraph As Word.Paragraph
		Dim Second_Paragraph As Word.Paragraph
		INSERTAR_REGLON(True, First_Paragraph, "Facturas Clientes", True, False, 18, "Comic Sans MS", "C", False)
		INSERTAR_REGLON(False, Second_Paragraph, "A continuacion se presentan las facturas de todos clientes", False, False, 14, "Comic Sans MS", "I", False)
		INSERTAR_LINEA_BLANCO(Second_Paragraph, 1)
		For x As Integer = 0 To T.Tables(0).Rows.Count - 1
			pID_EMPLEADO = T.Tables(0).Rows(x).ItemArray(1)
			pFECHA_CANCELACION = T.Tables(0).Rows(x).ItemArray(2)
			pID_CLIENTE = T.Tables(0).Rows(x).ItemArray(3)
			pID_HABITACION = T.Tables(0).Rows(x).ItemArray(4)
			pMONTO = T.Tables(0).Rows(x).ItemArray(5)

			INSERTAR_REGLON(False, PARAGRAPH_ID_EMPLEADO, "Identificación empleado: " & pID_EMPLEADO, False, False, 14, "Comic Sans MS", "I", False)
			INSERTAR_REGLON(False, PARAGRAPH_FECHA_CANCELACION, "Fecha de cancelación del cliente: " & pFECHA_CANCELACION, False, False, 14, "Comic Sans MS", "I", False)
			INSERTAR_REGLON(False, PARAGRAPH_ID_CLIENTE, "Identificación del cliente que canceló: " & pID_CLIENTE, False, False, 14, "Comic Sans MS", "I", False)
			INSERTAR_REGLON(False, PARAGRAPH_ID_HABITACION, "Identificación de la habitación: " & pID_HABITACION, False, False, 14, "Comic Sans MS", "I", False)
			INSERTAR_REGLON(False, PARAGRAPH_MONTO, "Monto que se canceló: $" & pMONTO, False, False, 14, "Comic Sans MS", "I", False)
			INSERTAR_LINEA_BLANCO(First_Paragraph, 2)
		Next

	End Sub
	Private Sub BTNREPORTE_Click(sender As Object, e As EventArgs) Handles BTNREPORTE.Click
		CREARDOCUMENTO()
		IMPRIMIR(1)
		MsgBox("Reporte ha sido generado exitosamente. ", vbInformation + vbOKOnly, "Reporte de factura clientes")

	End Sub
End Class