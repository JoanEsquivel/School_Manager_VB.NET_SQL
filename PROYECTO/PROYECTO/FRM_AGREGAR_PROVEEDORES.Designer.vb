<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_AGREGAR_PROVEEDORES
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_AGREGAR_PROVEEDORES))
		Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.btnSalir = New Guna.UI2.WinForms.Guna2Button()
		Me.btnGuardar = New Guna.UI2.WinForms.Guna2Button()
		Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtNumeroTelefonico = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtCedulaJuridica = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNombreProveedor = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Guna2GroupBox1.SuspendLayout()
		Me.SuspendLayout()
		'
		'Guna2GroupBox1
		'
		Me.Guna2GroupBox1.Controls.Add(Me.btnSalir)
		Me.Guna2GroupBox1.Controls.Add(Me.btnGuardar)
		Me.Guna2GroupBox1.Controls.Add(Me.txtCorreo)
		Me.Guna2GroupBox1.Controls.Add(Me.Label4)
		Me.Guna2GroupBox1.Controls.Add(Me.txtNumeroTelefonico)
		Me.Guna2GroupBox1.Controls.Add(Me.Label3)
		Me.Guna2GroupBox1.Controls.Add(Me.txtCedulaJuridica)
		Me.Guna2GroupBox1.Controls.Add(Me.Label2)
		Me.Guna2GroupBox1.Controls.Add(Me.txtNombreProveedor)
		Me.Guna2GroupBox1.Controls.Add(Me.Label1)
		Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
		Me.Guna2GroupBox1.Location = New System.Drawing.Point(9, 12)
		Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
		Me.Guna2GroupBox1.Size = New System.Drawing.Size(379, 391)
		Me.Guna2GroupBox1.TabIndex = 0
		Me.Guna2GroupBox1.Text = "Datos del proveedor"
		Me.Guna2GroupBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'btnSalir
		'
		Me.btnSalir.BorderRadius = 10
		Me.btnSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.btnSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.btnSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.btnSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.btnSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.btnSalir.ForeColor = System.Drawing.Color.White
		Me.btnSalir.Image = CType(resources.GetObject("btnSalir.Image"), System.Drawing.Image)
		Me.btnSalir.Location = New System.Drawing.Point(192, 328)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(180, 45)
		Me.btnSalir.TabIndex = 9
		Me.btnSalir.Text = "Salir"
		'
		'btnGuardar
		'
		Me.btnGuardar.BorderRadius = 10
		Me.btnGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.btnGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.btnGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.btnGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.btnGuardar.Enabled = False
		Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.btnGuardar.ForeColor = System.Drawing.Color.White
		Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
		Me.btnGuardar.Location = New System.Drawing.Point(6, 328)
		Me.btnGuardar.Name = "btnGuardar"
		Me.btnGuardar.Size = New System.Drawing.Size(180, 45)
		Me.btnGuardar.TabIndex = 8
		Me.btnGuardar.Text = "Guardar"
		'
		'txtCorreo
		'
		Me.txtCorreo.BorderRadius = 10
		Me.txtCorreo.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCorreo.DefaultText = ""
		Me.txtCorreo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txtCorreo.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txtCorreo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCorreo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCorreo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCorreo.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtCorreo.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCorreo.Location = New System.Drawing.Point(165, 262)
		Me.txtCorreo.Name = "txtCorreo"
		Me.txtCorreo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtCorreo.PlaceholderText = ""
		Me.txtCorreo.SelectedText = ""
		Me.txtCorreo.Size = New System.Drawing.Size(200, 36)
		Me.txtCorreo.TabIndex = 7
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label4.Location = New System.Drawing.Point(5, 273)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(105, 15)
		Me.Label4.TabIndex = 6
		Me.Label4.Text = "Correo electrónico"
		'
		'txtNumeroTelefonico
		'
		Me.txtNumeroTelefonico.BorderRadius = 10
		Me.txtNumeroTelefonico.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNumeroTelefonico.DefaultText = ""
		Me.txtNumeroTelefonico.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txtNumeroTelefonico.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txtNumeroTelefonico.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtNumeroTelefonico.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtNumeroTelefonico.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtNumeroTelefonico.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtNumeroTelefonico.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtNumeroTelefonico.Location = New System.Drawing.Point(165, 192)
		Me.txtNumeroTelefonico.Name = "txtNumeroTelefonico"
		Me.txtNumeroTelefonico.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNumeroTelefonico.PlaceholderText = ""
		Me.txtNumeroTelefonico.SelectedText = ""
		Me.txtNumeroTelefonico.Size = New System.Drawing.Size(200, 36)
		Me.txtNumeroTelefonico.TabIndex = 5
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label3.Location = New System.Drawing.Point(5, 202)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(107, 15)
		Me.Label3.TabIndex = 4
		Me.Label3.Text = "Número telefónico"
		'
		'txtCedulaJuridica
		'
		Me.txtCedulaJuridica.BorderRadius = 10
		Me.txtCedulaJuridica.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCedulaJuridica.DefaultText = ""
		Me.txtCedulaJuridica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txtCedulaJuridica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txtCedulaJuridica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCedulaJuridica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCedulaJuridica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCedulaJuridica.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtCedulaJuridica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCedulaJuridica.Location = New System.Drawing.Point(165, 130)
		Me.txtCedulaJuridica.Name = "txtCedulaJuridica"
		Me.txtCedulaJuridica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtCedulaJuridica.PlaceholderText = ""
		Me.txtCedulaJuridica.SelectedText = ""
		Me.txtCedulaJuridica.Size = New System.Drawing.Size(200, 36)
		Me.txtCedulaJuridica.TabIndex = 3
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label2.Location = New System.Drawing.Point(3, 142)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(86, 15)
		Me.Label2.TabIndex = 2
		Me.Label2.Text = "Cédula jurídica"
		'
		'txtNombreProveedor
		'
		Me.txtNombreProveedor.BorderRadius = 10
		Me.txtNombreProveedor.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtNombreProveedor.DefaultText = ""
		Me.txtNombreProveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txtNombreProveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txtNombreProveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtNombreProveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtNombreProveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtNombreProveedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtNombreProveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtNombreProveedor.Location = New System.Drawing.Point(165, 58)
		Me.txtNombreProveedor.Name = "txtNombreProveedor"
		Me.txtNombreProveedor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtNombreProveedor.PlaceholderText = ""
		Me.txtNombreProveedor.SelectedText = ""
		Me.txtNombreProveedor.Size = New System.Drawing.Size(200, 36)
		Me.txtNombreProveedor.TabIndex = 1
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
		Me.Label1.Location = New System.Drawing.Point(3, 79)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(51, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Nombre"
		'
		'FRM_AGREGAR_PROVEEDORES
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(400, 414)
		Me.Controls.Add(Me.Guna2GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FRM_AGREGAR_PROVEEDORES"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Agregar proveedor"
		Me.Guna2GroupBox1.ResumeLayout(False)
		Me.Guna2GroupBox1.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents txtNombreProveedor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumeroTelefonico As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCedulaJuridica As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
End Class
