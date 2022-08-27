Public Class FRM_MANTENIMIENTO_PROVEEDORES
    Private Sub txtCedulaJuridica_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaJuridica.TextChanged
        REFRESCAR(L, "SELECT ID, NOMBRE, CEDULA_JURIDICA, NUMERO_TELEFONICO, CORREO_ELECTRONICO FROM PROVEEDORES WHERE CEDULA_JURIDICA LIKE '%" & txtCedulaJuridica.Text & "%'", 5)
    End Sub

    Private Sub FRM_MANTENIMIENTO_PROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_Padre
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        Dim ID As Integer
        Dim NOMBRE, CEDULA_JURIDICA, NUMERO_TELEFONICO, CORREO_ELECTRONICO As String

        If (L.SelectedItems.Count > 0) Then
            ID = L.SelectedItems(0).SubItems(0).Text
            NOMBRE = L.SelectedItems(0).SubItems(1).Text
            CEDULA_JURIDICA = L.SelectedItems(0).SubItems(2).Text
            NUMERO_TELEFONICO = L.SelectedItems(0).SubItems(3).Text
            CORREO_ELECTRONICO = L.SelectedItems(0).SubItems(4).Text

            txtNombreProveedor.Tag = ID
            txtNombreProveedor.Text = NOMBRE
            txtCedulaJuridicaModal.Text = CEDULA_JURIDICA
            txtNumeroTelefonico.Text = NUMERO_TELEFONICO
            txtCorreo.Text = CORREO_ELECTRONICO
        End If


    End Sub
    Friend Sub validar_form_editar_proveedor()
        If txtNombreProveedor.Text <> "" And txtCedulaJuridicaModal.Text <> "" And txtCorreo.Text <> "" And txtNumeroTelefonico.Text <> "" Then
            btnActualizar.Enabled = True
        Else
            btnActualizar.Enabled = False
        End If
    End Sub

    Friend Sub limpiarEditarProveedor()
        txtNombreProveedor.Tag = 0
        txtNombreProveedor.Clear()
        txtCedulaJuridicaModal.Clear()
        txtNumeroTelefonico.Clear()
        txtCorreo.Clear()
        validar_form_editar_proveedor()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        GB_DATOS_PROVEEDOR.Visible = True
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        GB_DATOS_PROVEEDOR.Visible = False
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub

    Private Sub txtNombreProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProveedor.TextChanged
        validar_form_editar_proveedor()
    End Sub

    Private Sub txtCedulaJuridicaModal_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaJuridicaModal.TextChanged
        validar_form_editar_proveedor()
    End Sub

    Private Sub txtNumeroTelefonico_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroTelefonico.TextChanged
        validar_form_editar_proveedor()
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged
        validar_form_editar_proveedor()
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        SQL = "UPDATE PROVEEDORES SET NOMBRE = '" & txtNombreProveedor.Text & "', CEDULA_JURIDICA = '" & txtCedulaJuridicaModal.Text & "', NUMERO_TELEFONICO = '" & txtNumeroTelefonico.Text & "', CORREO_ELECTRONICO = '" & txtCorreo.Text & "' WHERE ID = " & txtNombreProveedor.Tag & ""
        EJECUTAR(SQL)
        MsgBox("El proveedor se agregó correctamente. ", vbInformation + vbOKOnly, "Estado del guardado")
        limpiarEditarProveedor()
        REFRESCAR(L, "SELECT ID, NOMBRE, CEDULA_JURIDICA, NUMERO_TELEFONICO, CORREO_ELECTRONICO FROM PROVEEDORES WHERE CEDULA_JURIDICA LIKE '%" & txtCedulaJuridica.Text & "%'", 5)
        GB_DATOS_PROVEEDOR.Visible = False
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        SQL = "DELETE FROM PROVEEDORES WHERE ID = " & L.SelectedItems(0).SubItems(0).Text & ""
        EJECUTAR(SQL)
        MsgBox("El proveedor se elimino correctamente. ", vbInformation + vbOKOnly, "Estado del eliminación")
        REFRESCAR(L, "SELECT ID, NOMBRE, CEDULA_JURIDICA, NUMERO_TELEFONICO, CORREO_ELECTRONICO FROM PROVEEDORES WHERE CEDULA_JURIDICA LIKE '%" & txtCedulaJuridica.Text & "%'", 5)
    End Sub
End Class