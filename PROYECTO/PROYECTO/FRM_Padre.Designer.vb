<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Padre
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_Padre))
		Me.MenuStrip = New System.Windows.Forms.MenuStrip()
		Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
		Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
		Me.FacturaClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripSeparator()
		Me.HabitacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripSeparator()
		Me.ReservacionesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripSeparator()
		Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.AgregarProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
		Me.FacturaProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripSeparator()
		Me.MantenimientoProveedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
		Me.EnviarCorreoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.StatusStrip = New System.Windows.Forms.StatusStrip()
		Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
		Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
		Me.MenuStrip.SuspendLayout()
		Me.StatusStrip.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip
		'
		Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.ProveedoresToolStripMenuItem, Me.EnviarCorreoToolStripMenuItem})
		Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip.Name = "MenuStrip"
		Me.MenuStrip.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
		Me.MenuStrip.Size = New System.Drawing.Size(632, 24)
		Me.MenuStrip.TabIndex = 5
		Me.MenuStrip.Text = "MenuStrip"
		'
		'FileMenu
		'
		Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.ToolStripSeparator3, Me.FacturaClientesToolStripMenuItem, Me.ToolStripMenuItem4, Me.HabitacionesToolStripMenuItem, Me.ToolStripMenuItem5, Me.ReservacionesToolStripMenuItem, Me.ToolStripMenuItem6, Me.ExitToolStripMenuItem})
		Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
		Me.FileMenu.Name = "FileMenu"
		Me.FileMenu.Size = New System.Drawing.Size(62, 20)
		Me.FileMenu.Text = "Registro"
		'
		'NewToolStripMenuItem
		'
		Me.NewToolStripMenuItem.Image = CType(resources.GetObject("NewToolStripMenuItem.Image"), System.Drawing.Image)
		Me.NewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black
		Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
		Me.NewToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
		Me.NewToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
		Me.NewToolStripMenuItem.Text = "Usuarios"
		'
		'ToolStripSeparator3
		'
		Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
		Me.ToolStripSeparator3.Size = New System.Drawing.Size(181, 6)
		'
		'FacturaClientesToolStripMenuItem
		'
		Me.FacturaClientesToolStripMenuItem.Image = CType(resources.GetObject("FacturaClientesToolStripMenuItem.Image"), System.Drawing.Image)
		Me.FacturaClientesToolStripMenuItem.Name = "FacturaClientesToolStripMenuItem"
		Me.FacturaClientesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
		Me.FacturaClientesToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
		Me.FacturaClientesToolStripMenuItem.Text = "Factura Clientes"
		'
		'ToolStripMenuItem4
		'
		Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
		Me.ToolStripMenuItem4.Size = New System.Drawing.Size(181, 6)
		'
		'HabitacionesToolStripMenuItem
		'
		Me.HabitacionesToolStripMenuItem.Image = CType(resources.GetObject("HabitacionesToolStripMenuItem.Image"), System.Drawing.Image)
		Me.HabitacionesToolStripMenuItem.Name = "HabitacionesToolStripMenuItem"
		Me.HabitacionesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.H), System.Windows.Forms.Keys)
		Me.HabitacionesToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
		Me.HabitacionesToolStripMenuItem.Text = "Habitaciones"
		'
		'ToolStripMenuItem5
		'
		Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
		Me.ToolStripMenuItem5.Size = New System.Drawing.Size(181, 6)
		'
		'ReservacionesToolStripMenuItem
		'
		Me.ReservacionesToolStripMenuItem.Image = CType(resources.GetObject("ReservacionesToolStripMenuItem.Image"), System.Drawing.Image)
		Me.ReservacionesToolStripMenuItem.Name = "ReservacionesToolStripMenuItem"
		Me.ReservacionesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.R), System.Windows.Forms.Keys)
		Me.ReservacionesToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
		Me.ReservacionesToolStripMenuItem.Text = "Reservaciones"
		'
		'ToolStripMenuItem6
		'
		Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
		Me.ToolStripMenuItem6.Size = New System.Drawing.Size(181, 6)
		'
		'ExitToolStripMenuItem
		'
		Me.ExitToolStripMenuItem.Image = CType(resources.GetObject("ExitToolStripMenuItem.Image"), System.Drawing.Image)
		Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
		Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
		Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(202, 26)
		Me.ExitToolStripMenuItem.Text = "&Salir"
		'
		'ProveedoresToolStripMenuItem
		'
		Me.ProveedoresToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AgregarProveedoresToolStripMenuItem, Me.ToolStripMenuItem1, Me.FacturaProveedoresToolStripMenuItem, Me.ToolStripMenuItem2, Me.MantenimientoProveedoresToolStripMenuItem, Me.ToolStripMenuItem3})
		Me.ProveedoresToolStripMenuItem.Name = "ProveedoresToolStripMenuItem"
		Me.ProveedoresToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
		Me.ProveedoresToolStripMenuItem.Text = "Proveedores"
		'
		'AgregarProveedoresToolStripMenuItem
		'
		Me.AgregarProveedoresToolStripMenuItem.Image = CType(resources.GetObject("AgregarProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
		Me.AgregarProveedoresToolStripMenuItem.Name = "AgregarProveedoresToolStripMenuItem"
		Me.AgregarProveedoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
		Me.AgregarProveedoresToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
		Me.AgregarProveedoresToolStripMenuItem.Text = "Agregar proveedores"
		'
		'ToolStripMenuItem1
		'
		Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
		Me.ToolStripMenuItem1.Size = New System.Drawing.Size(225, 6)
		'
		'FacturaProveedoresToolStripMenuItem
		'
		Me.FacturaProveedoresToolStripMenuItem.Image = CType(resources.GetObject("FacturaProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
		Me.FacturaProveedoresToolStripMenuItem.Name = "FacturaProveedoresToolStripMenuItem"
		Me.FacturaProveedoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
		Me.FacturaProveedoresToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
		Me.FacturaProveedoresToolStripMenuItem.Text = "Factura proveedores"
		'
		'ToolStripMenuItem2
		'
		Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
		Me.ToolStripMenuItem2.Size = New System.Drawing.Size(225, 6)
		'
		'MantenimientoProveedoresToolStripMenuItem
		'
		Me.MantenimientoProveedoresToolStripMenuItem.Image = CType(resources.GetObject("MantenimientoProveedoresToolStripMenuItem.Image"), System.Drawing.Image)
		Me.MantenimientoProveedoresToolStripMenuItem.Name = "MantenimientoProveedoresToolStripMenuItem"
		Me.MantenimientoProveedoresToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.M), System.Windows.Forms.Keys)
		Me.MantenimientoProveedoresToolStripMenuItem.Size = New System.Drawing.Size(273, 26)
		Me.MantenimientoProveedoresToolStripMenuItem.Text = "Mantenimiento proveedores"
		'
		'ToolStripMenuItem3
		'
		Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
		Me.ToolStripMenuItem3.Size = New System.Drawing.Size(225, 6)
		'
		'EnviarCorreoToolStripMenuItem
		'
		Me.EnviarCorreoToolStripMenuItem.Name = "EnviarCorreoToolStripMenuItem"
		Me.EnviarCorreoToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
		Me.EnviarCorreoToolStripMenuItem.Text = "Enviar Correo"
		'
		'StatusStrip
		'
		Me.StatusStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
		Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
		Me.StatusStrip.Location = New System.Drawing.Point(0, 431)
		Me.StatusStrip.Name = "StatusStrip"
		Me.StatusStrip.Size = New System.Drawing.Size(632, 22)
		Me.StatusStrip.TabIndex = 7
		Me.StatusStrip.Text = "StatusStrip"
		'
		'ToolStripStatusLabel
		'
		Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
		Me.ToolStripStatusLabel.Size = New System.Drawing.Size(42, 17)
		Me.ToolStripStatusLabel.Text = "Estado"
		'
		'FRM_Padre
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
		Me.ClientSize = New System.Drawing.Size(632, 453)
		Me.Controls.Add(Me.MenuStrip)
		Me.Controls.Add(Me.StatusStrip)
		Me.DoubleBuffered = True
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.IsMdiContainer = True
		Me.MainMenuStrip = Me.MenuStrip
		Me.Name = "FRM_Padre"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FRM_Padre"
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.MenuStrip.ResumeLayout(False)
		Me.MenuStrip.PerformLayout()
		Me.StatusStrip.ResumeLayout(False)
		Me.StatusStrip.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FacturaClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripSeparator
    Friend WithEvents HabitacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripSeparator
    Friend WithEvents ProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents FacturaProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripSeparator
    Friend WithEvents MantenimientoProveedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripSeparator
    Friend WithEvents ReservacionesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripSeparator
    Friend WithEvents EnviarCorreoToolStripMenuItem As ToolStripMenuItem
End Class
