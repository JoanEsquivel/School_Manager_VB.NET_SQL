Public Class FRM_AGREGAR_PROVEEDORES
    Private Sub FRM_AGREGAR_PROVEEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_Padre
    End Sub

    Friend Sub validar_form_agregar_proveedor()
        If txtNombreProveedor.Text <> "" And txtCedulaJuridica.Text <> "" And txtCorreo.Text <> "" And txtNumeroTelefonico.Text <> "" Then
            btnGuardar.Enabled = True
        Else
            btnGuardar.Enabled = False
        End If
    End Sub

    Friend Sub limpiarAgregarProveedor()
        txtNombreProveedor.Clear()
        txtCedulaJuridica.Clear()
        txtNumeroTelefonico.Clear()
        txtCorreo.Clear()
        validar_form_agregar_proveedor()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        SQL = "INSERT INTO PROVEEDORES (ID, NOMBRE, CEDULA_JURIDICA, NUMERO_TELEFONICO, CORREO_ELECTRONICO) VALUES (" & PK("PROVEEDORES", "ID") & ", '" & txtNombreProveedor.Text & "', '" & txtCedulaJuridica.Text & "', '" & txtNumeroTelefonico.Text & "',  '" & txtCorreo.Text & "')"
        EJECUTAR(SQL)
        MsgBox("El proveedor se agregó correctamente. ", vbInformation + vbOKOnly, "Estado del guardado")
        limpiarAgregarProveedor()
    End Sub

    Private Sub txtNombreProveedor_TextChanged(sender As Object, e As EventArgs) Handles txtNombreProveedor.TextChanged
        validar_form_agregar_proveedor()
    End Sub

    Private Sub txtCedulaJuridica_TextChanged(sender As Object, e As EventArgs) Handles txtCedulaJuridica.TextChanged
        validar_form_agregar_proveedor()
    End Sub

    Private Sub txtNumeroTelefonico_TextChanged(sender As Object, e As EventArgs) Handles txtNumeroTelefonico.TextChanged
        validar_form_agregar_proveedor()
    End Sub

    Private Sub txtCorreo_TextChanged(sender As Object, e As EventArgs) Handles txtCorreo.TextChanged
        validar_form_agregar_proveedor()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        Me.Close()
    End Sub
End Class