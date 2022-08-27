Imports System.Windows.Forms

Public Class FRM_Padre
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        USUARIOS.Show()
    End Sub

    Private Sub FacturaClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaClientesToolStripMenuItem.Click
        FRM_FACTURA_CLIENTES.Show()
    End Sub

    Private Sub HabitacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HabitacionesToolStripMenuItem.Click
        FRM_HABITACIONES.Show()
    End Sub

    Private Sub AgregarProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarProveedoresToolStripMenuItem.Click
        FRM_AGREGAR_PROVEEDORES.Show()
    End Sub

    Private Sub FacturaProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FacturaProveedoresToolStripMenuItem.Click
        FRM_FACTURA_PROVEDORES.Show()
    End Sub

    Private Sub MantenimientoProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MantenimientoProveedoresToolStripMenuItem.Click
        FRM_MANTENIMIENTO_PROVEEDORES.Show()
    End Sub

    Private Sub ReservacionesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReservacionesToolStripMenuItem.Click
        FRM_RESERVACIONES.Show()
    End Sub

    Private Sub EnviarCorreoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EnviarCorreoToolStripMenuItem.Click
        FRM_CORREO.Show()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub
End Class
