<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_MANTENIMIENTO_PROVEEDORES
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_MANTENIMIENTO_PROVEEDORES))
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.txtCedulaJuridica = New Guna.UI2.WinForms.Guna2TextBox()
		Me.L = New System.Windows.Forms.ListView()
		Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.GB_DATOS_PROVEEDOR = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.Guna2Button1 = New Guna.UI2.WinForms.Guna2Button()
		Me.btnActualizar = New Guna.UI2.WinForms.Guna2Button()
		Me.txtCorreo = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.txtNumeroTelefonico = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.txtCedulaJuridicaModal = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.txtNombreProveedor = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.btnSalir = New Guna.UI2.WinForms.Guna2Button()
		Me.btnBorrar = New Guna.UI2.WinForms.Guna2Button()
		Me.btnEditar = New Guna.UI2.WinForms.Guna2Button()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.Guna2GroupBox1.SuspendLayout()
		Me.GB_DATOS_PROVEEDOR.SuspendLayout()
		Me.SuspendLayout()
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(28, 69)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(25, 23)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 32
		Me.PictureBox1.TabStop = False
		'
		'txtCedulaJuridica
		'
		Me.txtCedulaJuridica.BorderRadius = 10
		Me.txtCedulaJuridica.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.txtCedulaJuridica.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCedulaJuridica.DefaultText = ""
		Me.txtCedulaJuridica.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txtCedulaJuridica.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txtCedulaJuridica.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCedulaJuridica.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCedulaJuridica.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCedulaJuridica.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtCedulaJuridica.ForeColor = System.Drawing.Color.Black
		Me.txtCedulaJuridica.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCedulaJuridica.Location = New System.Drawing.Point(71, 67)
		Me.txtCedulaJuridica.Name = "txtCedulaJuridica"
		Me.txtCedulaJuridica.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtCedulaJuridica.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.txtCedulaJuridica.PlaceholderText = "Cédula jurídica"
		Me.txtCedulaJuridica.SelectedText = ""
		Me.txtCedulaJuridica.Size = New System.Drawing.Size(479, 32)
		Me.txtCedulaJuridica.TabIndex = 33
		Me.txtCedulaJuridica.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		'
		'L
		'
		Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17})
		Me.L.FullRowSelect = True
		Me.L.GridLines = True
		Me.L.HideSelection = False
		Me.L.Location = New System.Drawing.Point(28, 119)
		Me.L.Name = "L"
		Me.L.Size = New System.Drawing.Size(522, 234)
		Me.L.TabIndex = 34
		Me.L.UseCompatibleStateImageBehavior = False
		Me.L.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader13
		'
		Me.ColumnHeader13.Text = "ID"
		Me.ColumnHeader13.Width = 0
		'
		'ColumnHeader14
		'
		Me.ColumnHeader14.Text = "Nombre"
		Me.ColumnHeader14.Width = 140
		'
		'ColumnHeader15
		'
		Me.ColumnHeader15.Text = "Cédula jurídica"
		Me.ColumnHeader15.Width = 113
		'
		'ColumnHeader16
		'
		Me.ColumnHeader16.Text = "Número Telefónico"
		Me.ColumnHeader16.Width = 105
		'
		'ColumnHeader17
		'
		Me.ColumnHeader17.Text = "Correo electrónico"
		Me.ColumnHeader17.Width = 160
		'
		'Guna2GroupBox1
		'
		Me.Guna2GroupBox1.Controls.Add(Me.GB_DATOS_PROVEEDOR)
		Me.Guna2GroupBox1.Controls.Add(Me.btnSalir)
		Me.Guna2GroupBox1.Controls.Add(Me.btnBorrar)
		Me.Guna2GroupBox1.Controls.Add(Me.btnEditar)
		Me.Guna2GroupBox1.Controls.Add(Me.L)
		Me.Guna2GroupBox1.Controls.Add(Me.txtCedulaJuridica)
		Me.Guna2GroupBox1.Controls.Add(Me.PictureBox1)
		Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
		Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
		Me.Guna2GroupBox1.Size = New System.Drawing.Size(776, 387)
		Me.Guna2GroupBox1.TabIndex = 35
		Me.Guna2GroupBox1.Text = "Consulta y edición de proveedores"
		'
		'GB_DATOS_PROVEEDOR
		'
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.Guna2Button1)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.btnActualizar)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.txtCorreo)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.Label4)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.txtNumeroTelefonico)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.Label3)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.txtCedulaJuridicaModal)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.Label2)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.txtNombreProveedor)
		Me.GB_DATOS_PROVEEDOR.Controls.Add(Me.Label1)
		Me.GB_DATOS_PROVEEDOR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.GB_DATOS_PROVEEDOR.ForeColor = System.Drawing.Color.Black
		Me.GB_DATOS_PROVEEDOR.Location = New System.Drawing.Point(171, 3)
		Me.GB_DATOS_PROVEEDOR.Name = "GB_DATOS_PROVEEDOR"
		Me.GB_DATOS_PROVEEDOR.Size = New System.Drawing.Size(379, 391)
		Me.GB_DATOS_PROVEEDOR.TabIndex = 38
		Me.GB_DATOS_PROVEEDOR.Text = "Datos del proveedor"
		Me.GB_DATOS_PROVEEDOR.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.GB_DATOS_PROVEEDOR.Visible = False
		'
		'Guna2Button1
		'
		Me.Guna2Button1.BorderRadius = 10
		Me.Guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.Guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.Guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.Guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.Guna2Button1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Guna2Button1.ForeColor = System.Drawing.Color.White
		Me.Guna2Button1.Image = CType(resources.GetObject("Guna2Button1.Image"), System.Drawing.Image)
		Me.Guna2Button1.Location = New System.Drawing.Point(192, 328)
		Me.Guna2Button1.Name = "Guna2Button1"
		Me.Guna2Button1.Size = New System.Drawing.Size(180, 45)
		Me.Guna2Button1.TabIndex = 9
		Me.Guna2Button1.Text = "Salir"
		'
		'btnActualizar
		'
		Me.btnActualizar.BorderRadius = 10
		Me.btnActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.btnActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.btnActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.btnActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.btnActualizar.Enabled = False
		Me.btnActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.btnActualizar.ForeColor = System.Drawing.Color.White
		Me.btnActualizar.Image = CType(resources.GetObject("btnActualizar.Image"), System.Drawing.Image)
		Me.btnActualizar.Location = New System.Drawing.Point(6, 328)
		Me.btnActualizar.Name = "btnActualizar"
		Me.btnActualizar.Size = New System.Drawing.Size(180, 45)
		Me.btnActualizar.TabIndex = 8
		Me.btnActualizar.Text = "Actualizar"
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
		Me.txtCorreo.ForeColor = System.Drawing.Color.Black
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
		Me.txtNumeroTelefonico.ForeColor = System.Drawing.Color.Black
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
		'txtCedulaJuridicaModal
		'
		Me.txtCedulaJuridicaModal.BorderRadius = 10
		Me.txtCedulaJuridicaModal.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtCedulaJuridicaModal.DefaultText = ""
		Me.txtCedulaJuridicaModal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.txtCedulaJuridicaModal.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.txtCedulaJuridicaModal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCedulaJuridicaModal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.txtCedulaJuridicaModal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCedulaJuridicaModal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.txtCedulaJuridicaModal.ForeColor = System.Drawing.Color.Black
		Me.txtCedulaJuridicaModal.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.txtCedulaJuridicaModal.Location = New System.Drawing.Point(165, 130)
		Me.txtCedulaJuridicaModal.Name = "txtCedulaJuridicaModal"
		Me.txtCedulaJuridicaModal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.txtCedulaJuridicaModal.PlaceholderText = ""
		Me.txtCedulaJuridicaModal.SelectedText = ""
		Me.txtCedulaJuridicaModal.Size = New System.Drawing.Size(200, 36)
		Me.txtCedulaJuridicaModal.TabIndex = 3
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
		Me.txtNombreProveedor.ForeColor = System.Drawing.Color.Black
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
		Me.btnSalir.Location = New System.Drawing.Point(575, 285)
		Me.btnSalir.Name = "btnSalir"
		Me.btnSalir.Size = New System.Drawing.Size(180, 45)
		Me.btnSalir.TabIndex = 37
		Me.btnSalir.Text = "Salir"
		'
		'btnBorrar
		'
		Me.btnBorrar.BorderRadius = 10
		Me.btnBorrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.btnBorrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.btnBorrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.btnBorrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.btnBorrar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.btnBorrar.ForeColor = System.Drawing.Color.White
		Me.btnBorrar.Image = CType(resources.GetObject("btnBorrar.Image"), System.Drawing.Image)
		Me.btnBorrar.Location = New System.Drawing.Point(575, 222)
		Me.btnBorrar.Name = "btnBorrar"
		Me.btnBorrar.Size = New System.Drawing.Size(180, 45)
		Me.btnBorrar.TabIndex = 36
		Me.btnBorrar.Text = "Borrar"
		'
		'btnEditar
		'
		Me.btnEditar.BorderRadius = 10
		Me.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.btnEditar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.btnEditar.ForeColor = System.Drawing.Color.White
		Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
		Me.btnEditar.Location = New System.Drawing.Point(575, 160)
		Me.btnEditar.Name = "btnEditar"
		Me.btnEditar.Size = New System.Drawing.Size(180, 45)
		Me.btnEditar.TabIndex = 35
		Me.btnEditar.Text = "Editar"
		'
		'FRM_MANTENIMIENTO_PROVEEDORES
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(796, 417)
		Me.Controls.Add(Me.Guna2GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Name = "FRM_MANTENIMIENTO_PROVEEDORES"
		Me.ShowIcon = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FRM_MANTENIMIENTO_PROVEEDORES"
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.Guna2GroupBox1.ResumeLayout(False)
		Me.GB_DATOS_PROVEEDOR.ResumeLayout(False)
		Me.GB_DATOS_PROVEEDOR.PerformLayout()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtCedulaJuridica As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents btnSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnBorrar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnEditar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GB_DATOS_PROVEEDOR As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Guna2Button1 As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents btnActualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents txtCorreo As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNumeroTelefonico As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCedulaJuridicaModal As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNombreProveedor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label1 As Label
End Class
