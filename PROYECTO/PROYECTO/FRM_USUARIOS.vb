Public Class USUARIOS
    Private Sub USUARIOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_Padre
    End Sub

    Friend Sub validar_lleno()
        If identificacion.Text <> "    -    -" And nombre.Text <> "" And apellido.Text <> "" And fechaNacimiento.Text <> "" And UsuarioDesde.Text <> "" And CodigoPais.Text <> "" And numeroTelefono.Text <> "" And email.Text <> "" And paisResidencia.Text <> "" And usuario.Text <> "" And contrasena.Text <> "" Then
            BotonGuardar.Enabled = True
        Else
            BotonGuardar.Enabled = False
        End If
    End Sub

    Friend Sub limpiar()

        REFRESCAR(L, "SELECT ID, IDENTIFICACION, NOMBRE_USUARIO, APELLIDO, FECHA_NACIMIENTO, USUARIO_DESDE, CODIGO_PAIS, NUMERO_TELEFONO, EMAIL, PAIS_RESIDENCIA, USUARIO, CONTRASENA FROM USUARIOS", 12)

        identificacion.Clear()
        identificacion.Tag = 0
        nombre.Clear()
        apellido.Clear()
        fechaNacimiento.Clear()
        UsuarioDesde.Clear()
        CodigoPais.Clear()
        numeroTelefono.Clear()
        email.Clear()
        paisResidencia.Clear()
        usuario.Clear()
        contrasena.Clear()

        validar_lleno()

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click

        If identificacion.Tag = 0 Then

            SQL = "INSERT INTO USUARIOS (ID, IDENTIFICACION, NOMBRE_USUARIO, APELLIDO, FECHA_NACIMIENTO, USUARIO_DESDE, CODIGO_PAIS, NUMERO_TELEFONO, EMAIL, PAIS_RESIDENCIA, USUARIO, CONTRASENA) VALUES (" & PK("USUARIOS", "ID") & ", '" & identificacion.Text & "', '" & nombre.Text & "', '" & apellido.Text & "',  '" & fechaNacimiento.Text & "',  '" & UsuarioDesde.Text & "', '" & CodigoPais.Text & "',  '" & numeroTelefono.Text & "', '" & email.Text & "', '" & paisResidencia.Text & "',  '" & usuario.Text & "',  '" & contrasena.Text & "')"


        Else

            SQL = "UPDATE USUARIOS SET IDENTIFICACION = '" & identificacion.Text & "', NOMBRE_USUARIO '" & nombre.Text & "', APELLIDO='" & apellido.Text & "', FECHA_NACIMIENTO= '" & fechaNacimiento.Text & "', USUARIO_DESDE '" & UsuarioDesde.Text & "', CODIGO_PAIS= '" & CodigoPais.Text & "', NUMERO_TELEFONO= '" & numeroTelefono.Text & "',EMAIL= '" & email.Text & "',PAIS_RESIDENCIA= '" & paisResidencia.Text & "', USUARIO= '" & usuario.Text & "', CONTRASENA= '" & contrasena.Text & "' WHERE ID = " & identificacion.Tag & " "


        End If

        EJECUTAR(SQL)
        limpiar()
        MsgBox("Los datos se han almacenado satisfactoraimente. ", vbInformation + vbOKOnly, "Guardando")

    End Sub

    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Private Sub identificacion_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles identificacion.MaskInputRejected
        validar_lleno()
    End Sub

    Private Sub nombre_TextChanged(sender As Object, e As EventArgs) Handles nombre.TextChanged
        validar_lleno()
    End Sub

    Private Sub apellido_TextChanged(sender As Object, e As EventArgs) Handles apellido.TextChanged
        validar_lleno()
    End Sub

    Private Sub fechaNacimiento_TextChanged(sender As Object, e As EventArgs) Handles fechaNacimiento.TextChanged
        validar_lleno()
    End Sub

    Private Sub UsuarioDesde_TextChanged(sender As Object, e As EventArgs) Handles UsuarioDesde.TextChanged
        validar_lleno()
    End Sub

    Private Sub CodigoPais_TextChanged(sender As Object, e As EventArgs) Handles CodigoPais.TextChanged
        validar_lleno()
    End Sub

    Private Sub numeroTelefono_TextChanged(sender As Object, e As EventArgs) Handles numeroTelefono.TextChanged
        validar_lleno()
    End Sub

    Private Sub email_TextChanged(sender As Object, e As EventArgs) Handles email.TextChanged
        validar_lleno()
    End Sub

    Private Sub paisResidencia_TextChanged(sender As Object, e As EventArgs) Handles paisResidencia.TextChanged
        validar_lleno()
    End Sub

    Private Sub usuario_TextChanged(sender As Object, e As EventArgs) Handles usuario.TextChanged
        validar_lleno()
    End Sub

    Private Sub contrasena_TextChanged(sender As Object, e As EventArgs) Handles contrasena.TextChanged
        validar_lleno()
    End Sub

    Private Sub USUARIOS_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Delete And identificacion.Tag <> 0 Then
            If MsgBox("Desea eliminar", vbQuestion + vbYesNo, "verifique") = vbYes Then
                SQL = "DELETE FROM USUARIOS WHERE ID = " & identificacion.Tag & ""
                EJECUTAR(SQL)
                limpiar()
                MsgBox("Los datos se han eliminado.", vbInformation + vbOKOnly, "Eliminando")
            End If

        End If
    End Sub

    Private Sub buscando_TextChanged(sender As Object, e As EventArgs) Handles buscando.TextChanged
        REFRESCAR(L, "SELECT * FROM USUARIOS WHERE NOMBRE_USUARIO LIKE'" & buscando.Text & "%'", 12)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged

        If L.SelectedItems.Count > 0 Then

            identificacion.Tag = L.SelectedItems(0).SubItems(0).Text
            identificacion.Text = L.SelectedItems(0).SubItems(1).Text
            nombre.Text = L.SelectedItems(0).SubItems(2).Text
            apellido.Text = L.SelectedItems(0).SubItems(3).Text
            fechaNacimiento.Text = L.SelectedItems(0).SubItems(4).Text
            UsuarioDesde.Text = L.SelectedItems(0).SubItems(5).Text
            CodigoPais.Text = L.SelectedItems(0).SubItems(6).Text
            numeroTelefono.Text = L.SelectedItems(0).SubItems(7).Text
            email.Text = L.SelectedItems(0).SubItems(8).Text
            paisResidencia.Text = L.SelectedItems(0).SubItems(9).Text
            usuario.Text = L.SelectedItems(0).SubItems(10).Text
            contrasena.Text = L.SelectedItems(0).SubItems(11).Text

        End If

    End Sub
End Class
