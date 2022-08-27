Public Class FRM_RESERVACIONES
    Dim RESERVACION_ELEGIDA As String = ""

    Friend Sub LLENAR_RESERVACION()
        CMBBUSCAR.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT ID_CLIENTE FROM RESERVACIONES"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CMBBUSCAR.Items.Add(T.Tables(0).Rows(I).Item(0))
            Next
        End If

    End Sub

    Friend Sub LLENAR_IDCLIENTE()
        CMBIDCLIENTE.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT IDENTIFICACION FROM USUARIOS"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CMBIDCLIENTE.Items.Add(T.Tables(0).Rows(I).Item(0))
            Next
        End If
    End Sub

    'Friend Sub LLENAR_IDHABITACION()
    '    CMBIDCLIENTE.Items.Clear()
    '    T.Tables.Clear()
    '    SQL = "SELECT ID FROM HABITACIONES"
    '    CARGAR_TABLA(T, SQL)
    '    If T.Tables(0).Rows.Count > 0 Then
    '        For I = 0 To T.Tables(0).Rows.Count - 1
    '            CMBIDCLIENTE.Items.Add(T.Tables(0).Rows(I).Item(0))    
    '        Next
    '    End If
    'End Sub

    Friend Sub VALIDAR_LLENO()
        If CMBIDCLIENTE.Text <> "" And CMBIDHABITACION.Text <> "" And FECHA_ENTRADA.Text <> "" And FECHA_SALIDA.Text <> "" Then
            GUARDAR.Enabled = True
        Else
            GUARDAR.Enabled = False
        End If
    End Sub

    Friend Sub LIMPIAR()
        REFRESCAR(L, "SELECT ID, ID_CLIENTE, ID_HABITACION, FECHA_ENTRADA, FECHA_SALIDA FROM RESERVACIONES", 5)
        CMBIDCLIENTE.Tag = 0
        VALIDAR_LLENO()
    End Sub

    Private Sub SALIR_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Close()
    End Sub

    Private Sub CMBIDCLIENTE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBIDCLIENTE.SelectedIndexChanged
        VALIDAR_LLENO()
    End Sub

    Private Sub CMBIDHABITACION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBIDHABITACION.SelectedIndexChanged
        VALIDAR_LLENO()
    End Sub

    Private Sub GUARDAR_Click(sender As Object, e As EventArgs) Handles GUARDAR.Click
        If CMBIDCLIENTE.Tag = 0 Then
            SQL = "INSERT INTO RESERVACIONES (ID, ID_CLIENTE, ID_HABITACION, FECHA_ENTRADA, FECHA_SALIDA) VALUES (" & PK("RESERVACIONES", "ID") & ", '" & CMBIDCLIENTE.Text & "', '" & CMBIDHABITACION.Text & "', '" & FECHA_ENTRADA.Text & "', '" & FECHA_SALIDA.Text & "')"
        Else
            SQL = "UPDATE RESERVACIONES SET ID_CLIENTE = '" & CMBIDCLIENTE.Text & "', ID_HABITACION = '" & CMBIDHABITACION.Text & "', FECHA_ENTRADA = '" & FECHA_ENTRADA.Text & "', FECHA_SALIDA = '" & FECHA_SALIDA.Text & "' WHERE ID = " & CMBIDCLIENTE.Tag & ""
        End If
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Los datos se han almacenado satisfactoriamente.", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub FRM_RESERVACIONES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_Padre
        LLENAR_IDCLIENTE()
        'LLENAR_IDHABITACION()
        LIMPIAR()
    End Sub

    Private Sub FRM_RESERVACIONES_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            LLENAR_RESERVACION()
            GRESERVACIONES.Visible = True
        End If

        If e.KeyCode = Keys.Escape Then
            GRESERVACIONES.Visible = False
        End If

        If e.KeyCode = Keys.Delete And CMBIDCLIENTE.Tag <> 0 Then
            If MsgBox("¿Desea eliminar la reservacion?", vbQuestion + vbYesNo, "Verifique") = vbYes Then
                SQL = "DELETE FROM RESERVACIONES WHERE ID = " & CMBIDCLIENTE.Tag & ""
                EJECUTAR(SQL)
                LIMPIAR()
                MsgBox("La reservacion ha sido eliminada correctamente.", vbInformation + vbOKOnly, "Eliminado")
            End If
        End If
    End Sub

    Private Sub CMBBUSCAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBBUSCAR.SelectedIndexChanged
        If CMBBUSCAR.Text <> "" Then
            RESERVACION_ELEGIDA = CMBBUSCAR.Text
            BTNACEPTAR.Enabled = True
        Else
            BTNACEPTAR.Enabled = False
        End If
    End Sub

    Private Sub BTNACEPTAR_Click(sender As Object, e As EventArgs) Handles BTNACEPTAR.Click
        T.Tables.Clear()
        SQL = "Select ID, ID_HABITACION, FECHA_ENTRADA,  FROM RESERVACIONES WHERE ID_CLIENTE = '" & RESERVACION_ELEGIDA & "'"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            CMBIDCLIENTE.Tag = T.Tables(0).Rows(0).ItemArray(0)
            CMBIDCLIENTE.Text = RESERVACION_ELEGIDA
            CMBIDHABITACION.Text = T.Tables(0).Rows(0).ItemArray(1)
            FECHA_ENTRADA.Text = T.Tables(0).Rows(0).ItemArray(2)
            FECHA_SALIDA.Text = T.Tables(0).Rows(0).ItemArray(3)
            GRESERVACIONES.Visible = False
        End If
    End Sub

    Private Sub BUSCANDO_TextChanged(sender As Object, e As EventArgs) Handles BUSCANDO.TextChanged
        REFRESCAR(L, "SELECT ID, ID_CLIENTE, ID_HABITACION, FECHA_ENTRADA, FECHA_SALIDA FROM RESERVACIONES WHERE ID_CLIENTE LIKE '" & BUSCANDO.Text & "%'", 5)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then

            CMBIDCLIENTE.Tag = L.SelectedItems(0).SubItems(0).Text
            CMBIDCLIENTE.Text = L.SelectedItems(0).SubItems(1).Text
            CMBIDHABITACION.Text = L.SelectedItems(0).SubItems(2).Text
            FECHA_ENTRADA.Text = T.Tables(0).Rows(0).ItemArray(3)
            FECHA_SALIDA.Text = T.Tables(0).Rows(0).ItemArray(4)

        End If
    End Sub

    Private Sub FECHA_ENTRADA_ValueChanged(sender As Object, e As EventArgs) Handles FECHA_ENTRADA.ValueChanged
    End Sub

    Private Sub FECHA_SALIDA_ValueChanged(sender As Object, e As EventArgs) Handles FECHA_SALIDA.ValueChanged
    End Sub
End Class