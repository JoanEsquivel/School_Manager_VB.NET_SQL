Public Class FRM_FACTURA_PROVEDORES

    Dim ID As Integer = 0
    Private Sub BotonSalir_Click(sender As Object, e As EventArgs) Handles BotonSalir.Click
        Me.Close()
    End Sub

    Friend Sub validar_lleno()
        If identificacion.Text <> "  -    -    " And fecha.Text <> "" And proveedor.Text <> "" And descripcion.Text <> "" And monto.Text <> "" Then
            BotonGuardar.Enabled = True
        Else
            BotonGuardar.Enabled = False
        End If
    End Sub

    Friend Sub limpiar()

        REFRESCAR(L, "SELECT * FROM FACTURAS_PROVEEDORES", 6)

        identificacion.Clear()
        identificacion.Tag = 0
        fecha.Clear()
        proveedor.Clear()
        descripcion.Clear()
        monto.Clear()

        validar_lleno()

    End Sub

    Private Sub BotonGuardar_Click(sender As Object, e As EventArgs) Handles BotonGuardar.Click


        If identificacion.Tag = 0 Then

            SQL = "INSERT INTO FACTURAS_PROVEEDORES (ID, ID_EMPLEADO, FECHA_HORA_CANCELACION, ID_PROVEEDOR, DESCRIPCION, MONTO_CANCELADO) VALUES (" & PK("FACTURAS_PROVEEDORES", "ID") & ", '" & identificacion.Text & "', '" & fecha.Text & "', '" & proveedor.Text & "',  '" & descripcion.Text & "',  '" & monto.Text & "')"


        Else

            SQL = "UPDATE FACTURAS_PROVEEDORES SET ID_EMPLEADO = '" & identificacion.Text & "', FECHA_HORA_CANCELACION = '" & fecha.Text & "', ID_PROVEEDOR ='" & proveedor.Text & "', DESCRIPCION= '" & descripcion.Text & "', MONTO_CANCELADO'" & monto.Text & "' WHERE ID = " & identificacion.Tag & " "


        End If

        EJECUTAR(SQL)
        REFRESCAR(L, "SELECT ID, ID_EMPLEADO, FECHA_HORA_CANCELACION, ID_PROVEEDOR, DESCRIPCION, MONTO_CANCELADO FROM FACTURAS_PROVEEDORES WHERE ID LIKE '" & buscar.Text & "%'", 5)
        MsgBox("Los datos se han almacenado satisfactoraimente. ", vbInformation + vbOKOnly, "Guardando")
        limpiar()
    End Sub

    Private Sub fecha_TextChanged(sender As Object, e As EventArgs) Handles fecha.TextChanged
        validar_lleno()
    End Sub

    Private Sub identificacion_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles identificacion.MaskInputRejected
        validar_lleno()
    End Sub

    Private Sub proveedor_TextChanged(sender As Object, e As EventArgs) Handles proveedor.TextChanged
        validar_lleno()
    End Sub

    Private Sub descripcion_TextChanged(sender As Object, e As EventArgs) Handles descripcion.TextChanged
        validar_lleno()
    End Sub

    Private Sub monto_TextChanged(sender As Object, e As EventArgs) Handles monto.TextChanged
        validar_lleno()
    End Sub

    Private Sub FRM_FACTURA_PROVEDORES_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = FRM_Padre

    End Sub

    Private Sub Eliminar_Click(sender As Object, e As EventArgs) Handles Eliminar.Click
        If MsgBox("Desea eliminar", vbQuestion + vbYesNo, "verifique") = vbYes Then
            SQL = "DELETE FROM FACTURAS_PROVEEDORES WHERE ID = " & identificacion.Tag & ""
            EJECUTAR(SQL)
            limpiar()
            MsgBox("Los datos se han eliminado.", vbInformation + vbOKOnly, "Eliminando")
            REFRESCAR(L, "SELECT ID_EMPLEADO, FECHA_HORA_CANCELACION, ID_PROVEEDOR, DESCRIPCION, MONTO_CANCELADO FROM FACTURAS_PROVEEDORES", 5)
        End If






    End Sub

    Private Sub buscar_TextChanged(sender As Object, e As EventArgs) Handles buscar.TextChanged
        REFRESCAR(L, "SELECT ID, ID_EMPLEADO, FECHA_HORA_CANCELACION, ID_PROVEEDOR, DESCRIPCION, MONTO_CANCELADO FROM FACTURAS_PROVEEDORES WHERE ID_EMPLEADO LIKE '" & buscar.Text & "%'", 6)
    End Sub

    Private Sub L_SelectedIndexChanged(sender As Object, e As EventArgs) Handles L.SelectedIndexChanged
        If L.SelectedItems.Count > 0 Then

            identificacion.Tag = L.SelectedItems(0).SubItems(0).Text
            identificacion.Text = L.SelectedItems(0).SubItems(1).Text
            fecha.Text = L.SelectedItems(0).SubItems(2).Text
            proveedor.Text = L.SelectedItems(0).SubItems(3).Text
            descripcion.Text = L.SelectedItems(0).SubItems(4).Text
            monto.Text = L.SelectedItems(0).SubItems(5).Text

        End If
    End Sub



    Private Sub FRM_FACTURA_PROVEDORES_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter And identificacion.Tag <> 0 Then
            If MsgBox("Desea eliminar", vbQuestion + vbYesNo, "verifique") = vbYes Then
                SQL = "DELETE FROM FACTURAS_PROVEEDORES WHERE ID = " & identificacion.Tag & ""
                EJECUTAR(SQL)
                limpiar()
                MsgBox("Los datos se han eliminado.", vbInformation + vbOKOnly, "Eliminando")
            End If

        End If
    End Sub



    Private Sub botonActualizar_Click(sender As Object, e As EventArgs) Handles botonActualizar.Click
        If identificacion.Tag <> 0 Then
            SQL = "UPDATE FACTURAS_PROVEEDORES SET ID_EMPLEADO = '" & identificacion.Text & "', FECHA_HORA_CANCELACION = '" & fecha.Text & "', ID_PROVEEDOR ='" & proveedor.Text & "', DESCRIPCION = '" & descripcion.Text & "', MONTO_CANCELADO = '" & monto.Text & "' WHERE ID = " & identificacion.Tag & " "

        End If
        EJECUTAR(SQL)
        limpiar()
        MsgBox("Los datos se han almacenado satisfactoraimente. ", vbInformation + vbOKOnly, "Guardando")
    End Sub
End Class