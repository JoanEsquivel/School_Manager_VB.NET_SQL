Public Class FRM_HABITACIONES


    Private Sub Guna2TextBox3_TextChanged(sender As Object, e As EventArgs) Handles AMENIDAD.TextChanged

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Friend Sub LLENAR_NOMBRE()
        CMBCLIENTEU.Items.Clear()
        CMBCLIENTEA.Items.Clear()
        T.Tables.Clear()
        SQL = "SELECT NOMBRE_USUARIO FROM USUARIOS"
        CARGAR_TABLA(T, SQL)
        If T.Tables(0).Rows.Count > 0 Then
            For I = 0 To T.Tables(0).Rows.Count - 1
                CMBCLIENTEA.Items.Add(T.Tables(0).Rows(I).Item(0))
                CMBCLIENTEU.Items.Add(T.Tables(0).Rows(I).Item(0))

            Next
        End If
    End Sub

    Friend Sub VALIDAR_DATOS()
        If N_HABITACION.Text <> "" And NOMBRE.Text <> "" And C_HABITACION.Text <> "" And C_ADULTOS.Value >= 1 And CMBRESERVACION.Text <> "" Then
            BT_GUARDAR.Enabled = True
        Else
            BT_GUARDAR.Enabled = False
        End If

    End Sub

    Friend Sub LIMPIAR()

        N_HABITACION.Clear()
        N_HABITACION.Tag = 0
        C_HABITACION.Clear()
        NOMBRE.Clear()
        DESCRIPCION.Clear()
        AMENIDAD.Clear()
        C_ADULTOS.Value = 0
        C_NINNOS.Value = 0
        CMBRESERVACION.Text = ""
        CMBCLIENTEA.Text = ""
        CMBCLIENTEU.Text = ""
        VALIDAR_DATOS()

    End Sub



    Private Sub FRM_HABITACIONES_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.MdiParent = FRM_Padre
        LLENAR_NOMBRE()


    End Sub

    Private Sub N_HABITACION_TextChanged(sender As Object, e As EventArgs) Handles N_HABITACION.TextChanged
        VALIDAR_DATOS()
    End Sub

    Private Sub NOMBRE_TextChanged(sender As Object, e As EventArgs) Handles NOMBRE.TextChanged
        VALIDAR_DATOS()
    End Sub

    Private Sub C_HABITACION_TextChanged(sender As Object, e As EventArgs) Handles C_HABITACION.TextChanged
        VALIDAR_DATOS()
    End Sub

    Private Sub C_ADULTOS_ValueChanged(sender As Object, e As EventArgs) Handles C_ADULTOS.ValueChanged
        VALIDAR_DATOS()

    End Sub

    Private Sub CMBRESERVACION_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBRESERVACION.SelectedIndexChanged
        VALIDAR_DATOS()

    End Sub

    Private Sub N_HABITACION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles N_HABITACION.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If

    End Sub

    Private Sub C_HABITACION_KeyPress(sender As Object, e As KeyPressEventArgs) Handles C_HABITACION.KeyPress
        Dim Ch As Char = e.KeyChar
        If Not Char.IsDigit(Ch) AndAlso Asc(Ch) <> 8 Then
            e.Handled = True
        End If
    End Sub


    Private Sub BT_GUARDAR_Click(sender As Object, e As EventArgs) Handles BT_GUARDAR.Click
        If N_HABITACION.Tag = 0 Then
            SQL = "INSERT INTO HABITACIONES (ID,NUMERO_HABITACION, NOMBRE_HABITACION, DESCRIPCION_HABITACION,AMENIDADES, COSTO_HABITACION, CANTIDAD_ADULTOS, CANTIDAD_NINOS, ESTA_RESERVADA, CLIENTE_ACTUAL_HOSPEDADO, ULTIMO_CLIENTE_HOSPEDADO) VALUES (" & PK("HABITACIONES", "ID") & ",'" & N_HABITACION.Text & "','" & NOMBRE.Text & "','" & DESCRIPCION.Text & "','" & AMENIDAD.Text & "','" & C_HABITACION.Text & "','" & C_ADULTOS.Text & "','" & C_NINNOS.Text & "','" & CMBRESERVACION.Text & "','" & CMBCLIENTEA.Text & "','" & CMBCLIENTEU.Text & "')"
        Else
            SQL = "UPDATE HABITACIONES SET NUMERO_HABITACION = '" & N_HABITACION.Text & "', NOMBRE_HABITACION'" & NOMBRE.Text & "', DESCRIPCION_HABITACION ='" & DESCRIPCION.Text & "', AMENIDADES= '" & AMENIDAD.Text & "', COSTO_HABITACION= '" & C_HABITACION.Text & "', CANTIDAD_ADULTOS= '" & C_ADULTOS.Text & "', CANTIDAD_NINOS'" & C_NINNOS.Text & "', ESTA_RESERVADA= '" & CMBRESERVACION.Text & "', CLIENTE_ACTUAL_HOSPEDADO= '" & CMBCLIENTEA.Text & "', ULTIMO_CLIENTE_HOSPEDADO= '" & CMBCLIENTEU.Text & "'  WHERE ID= " & N_HABITACION.Tag & " "
        End If
        EJECUTAR(SQL)
        LIMPIAR()
        MsgBox("Los datos se han almacenado satisfactoriamente.", vbInformation + vbOKOnly, "Guardando")
    End Sub

    Private Sub BUSCAR_TextChanged(sender As Object, e As EventArgs) Handles BUSCAR.TextChanged
        REFRESCAR(L, "SELECT ID,NUMERO_HABITACION, NOMBRE_HABITACION, DESCRIPCION_HABITACION,AMENIDADES, COSTO_HABITACION, CANTIDAD_ADULTOS, CANTIDAD_NINOS, ESTA_RESERVADA, CLIENTE_ACTUAL_HOSPEDADO, ULTIMO_CLIENTE_HOSPEDADO FROM HABITACIONES WHERE NUMERO_HABITACION LIKE'" & BUSCAR.Text & "%'", 11)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged

        If L.SelectedItems.Count > 0 Then

            N_HABITACION.Tag = L.SelectedItems(0).SubItems(0).Text
            N_HABITACION.Text = L.SelectedItems(0).SubItems(1).Text
            NOMBRE.Text = L.SelectedItems(0).SubItems(2).Text
            DESCRIPCION.Text = L.SelectedItems(0).SubItems(3).Text
            AMENIDAD.Text = L.SelectedItems(0).SubItems(4).Text
            C_HABITACION.Text = L.SelectedItems(0).SubItems(5).Text
            C_ADULTOS.Text = L.SelectedItems(0).SubItems(6).Text
            C_NINNOS.Text = L.SelectedItems(0).SubItems(7).Text
            CMBRESERVACION.Text = L.SelectedItems(0).SubItems(8).Text
            CMBCLIENTEA.Text = L.SelectedItems(0).SubItems(9).Text
            CMBCLIENTEU.Text = L.SelectedItems(0).SubItems(10).Text

        End If

    End Sub

    Private Sub FRM_HABITACIONES_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.F5 Then
            ESPACIO_LISTA.Visible = True
        End If

        If e.KeyCode = 27 Then
            ESPACIO_LISTA.Visible = False
        End If

        If e.KeyCode = Keys.Delete And N_HABITACION.Tag <> 0 Then
            If MsgBox(“¿Desea eliminar la habitacion?", vbQuestion + vbYesNo, “Verifique") = vbYes Then
                SQL = "DELETE FROM HABITACIONES WHERE ID = " & N_HABITACION.Tag & ""
                EJECUTAR(SQL)
                LIMPIAR()
                MsgBox("La habitacion ha sido eliminada correctamente.", vbInformation + vbOKOnly, "Eliminando")
            End If
        End If
    End Sub


End Class