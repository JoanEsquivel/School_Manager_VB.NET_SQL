<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class USUARIOS
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(USUARIOS))
		Me.Info_usuario = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.contrasena = New Guna.UI2.WinForms.Guna2TextBox()
		Me.usuario = New Guna.UI2.WinForms.Guna2TextBox()
		Me.paisResidencia = New Guna.UI2.WinForms.Guna2TextBox()
		Me.email = New Guna.UI2.WinForms.Guna2TextBox()
		Me.numeroTelefono = New Guna.UI2.WinForms.Guna2TextBox()
		Me.CodigoPais = New Guna.UI2.WinForms.Guna2TextBox()
		Me.UsuarioDesde = New Guna.UI2.WinForms.Guna2TextBox()
		Me.fechaNacimiento = New Guna.UI2.WinForms.Guna2TextBox()
		Me.apellido = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.paislabel = New System.Windows.Forms.Label()
		Me.nombre = New Guna.UI2.WinForms.Guna2TextBox()
		Me.identificacion = New System.Windows.Forms.MaskedTextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.BotonGuardar = New Guna.UI2.WinForms.Guna2Button()
		Me.BotonSalir = New Guna.UI2.WinForms.Guna2Button()
		Me.L = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Label11 = New System.Windows.Forms.Label()
		Me.buscando = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Info_usuario.SuspendLayout()
		Me.SuspendLayout()
		'
		'Info_usuario
		'
		Me.Info_usuario.Controls.Add(Me.contrasena)
		Me.Info_usuario.Controls.Add(Me.usuario)
		Me.Info_usuario.Controls.Add(Me.paisResidencia)
		Me.Info_usuario.Controls.Add(Me.email)
		Me.Info_usuario.Controls.Add(Me.numeroTelefono)
		Me.Info_usuario.Controls.Add(Me.CodigoPais)
		Me.Info_usuario.Controls.Add(Me.UsuarioDesde)
		Me.Info_usuario.Controls.Add(Me.fechaNacimiento)
		Me.Info_usuario.Controls.Add(Me.apellido)
		Me.Info_usuario.Controls.Add(Me.Label9)
		Me.Info_usuario.Controls.Add(Me.Label10)
		Me.Info_usuario.Controls.Add(Me.paislabel)
		Me.Info_usuario.Controls.Add(Me.nombre)
		Me.Info_usuario.Controls.Add(Me.identificacion)
		Me.Info_usuario.Controls.Add(Me.Label5)
		Me.Info_usuario.Controls.Add(Me.Label6)
		Me.Info_usuario.Controls.Add(Me.Label7)
		Me.Info_usuario.Controls.Add(Me.Label8)
		Me.Info_usuario.Controls.Add(Me.Label3)
		Me.Info_usuario.Controls.Add(Me.Label4)
		Me.Info_usuario.Controls.Add(Me.Label2)
		Me.Info_usuario.Controls.Add(Me.Label1)
		Me.Info_usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Info_usuario.ForeColor = System.Drawing.Color.Black
		Me.Info_usuario.Location = New System.Drawing.Point(12, 12)
		Me.Info_usuario.Name = "Info_usuario"
		Me.Info_usuario.Size = New System.Drawing.Size(468, 495)
		Me.Info_usuario.TabIndex = 0
		Me.Info_usuario.Text = "Información del usuario"
		'
		'contrasena
		'
		Me.contrasena.BorderRadius = 10
		Me.contrasena.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.contrasena.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.contrasena.DefaultText = ""
		Me.contrasena.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.contrasena.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.contrasena.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.contrasena.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.contrasena.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.contrasena.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.contrasena.ForeColor = System.Drawing.Color.Black
		Me.contrasena.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.contrasena.Location = New System.Drawing.Point(157, 441)
		Me.contrasena.Name = "contrasena"
		Me.contrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
		Me.contrasena.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.contrasena.PlaceholderText = "Contraseña"
		Me.contrasena.SelectedText = ""
		Me.contrasena.Size = New System.Drawing.Size(257, 32)
		Me.contrasena.TabIndex = 27
		'
		'usuario
		'
		Me.usuario.BorderRadius = 10
		Me.usuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.usuario.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.usuario.DefaultText = ""
		Me.usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.usuario.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.usuario.ForeColor = System.Drawing.Color.Black
		Me.usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.usuario.Location = New System.Drawing.Point(157, 403)
		Me.usuario.Name = "usuario"
		Me.usuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.usuario.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.usuario.PlaceholderText = "Usuario"
		Me.usuario.SelectedText = ""
		Me.usuario.Size = New System.Drawing.Size(257, 32)
		Me.usuario.TabIndex = 26
		'
		'paisResidencia
		'
		Me.paisResidencia.BorderRadius = 10
		Me.paisResidencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.paisResidencia.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.paisResidencia.DefaultText = ""
		Me.paisResidencia.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.paisResidencia.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.paisResidencia.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.paisResidencia.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.paisResidencia.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.paisResidencia.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.paisResidencia.ForeColor = System.Drawing.Color.Black
		Me.paisResidencia.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.paisResidencia.Location = New System.Drawing.Point(157, 365)
		Me.paisResidencia.Name = "paisResidencia"
		Me.paisResidencia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.paisResidencia.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.paisResidencia.PlaceholderText = "País de residencia"
		Me.paisResidencia.SelectedText = ""
		Me.paisResidencia.Size = New System.Drawing.Size(257, 32)
		Me.paisResidencia.TabIndex = 25
		'
		'email
		'
		Me.email.BorderRadius = 10
		Me.email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.email.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.email.DefaultText = ""
		Me.email.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.email.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.email.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.email.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.email.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.email.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.email.ForeColor = System.Drawing.Color.Black
		Me.email.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.email.Location = New System.Drawing.Point(157, 327)
		Me.email.Name = "email"
		Me.email.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.email.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.email.PlaceholderText = "Correo electrónico"
		Me.email.SelectedText = ""
		Me.email.Size = New System.Drawing.Size(257, 32)
		Me.email.TabIndex = 24
		'
		'numeroTelefono
		'
		Me.numeroTelefono.BorderRadius = 10
		Me.numeroTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.numeroTelefono.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.numeroTelefono.DefaultText = ""
		Me.numeroTelefono.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.numeroTelefono.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.numeroTelefono.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.numeroTelefono.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.numeroTelefono.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.numeroTelefono.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.numeroTelefono.ForeColor = System.Drawing.Color.Black
		Me.numeroTelefono.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.numeroTelefono.Location = New System.Drawing.Point(157, 289)
		Me.numeroTelefono.Name = "numeroTelefono"
		Me.numeroTelefono.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.numeroTelefono.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.numeroTelefono.PlaceholderText = "Número de teléfono"
		Me.numeroTelefono.SelectedText = ""
		Me.numeroTelefono.Size = New System.Drawing.Size(257, 32)
		Me.numeroTelefono.TabIndex = 23
		'
		'CodigoPais
		'
		Me.CodigoPais.BorderRadius = 10
		Me.CodigoPais.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.CodigoPais.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.CodigoPais.DefaultText = ""
		Me.CodigoPais.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.CodigoPais.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.CodigoPais.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.CodigoPais.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.CodigoPais.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CodigoPais.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.CodigoPais.ForeColor = System.Drawing.Color.Black
		Me.CodigoPais.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CodigoPais.Location = New System.Drawing.Point(157, 251)
		Me.CodigoPais.Name = "CodigoPais"
		Me.CodigoPais.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.CodigoPais.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.CodigoPais.PlaceholderText = "Código del país"
		Me.CodigoPais.SelectedText = ""
		Me.CodigoPais.Size = New System.Drawing.Size(257, 32)
		Me.CodigoPais.TabIndex = 22
		'
		'UsuarioDesde
		'
		Me.UsuarioDesde.BorderRadius = 10
		Me.UsuarioDesde.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.UsuarioDesde.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.UsuarioDesde.DefaultText = ""
		Me.UsuarioDesde.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.UsuarioDesde.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.UsuarioDesde.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.UsuarioDesde.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.UsuarioDesde.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.UsuarioDesde.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.UsuarioDesde.ForeColor = System.Drawing.Color.Black
		Me.UsuarioDesde.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.UsuarioDesde.Location = New System.Drawing.Point(157, 212)
		Me.UsuarioDesde.Name = "UsuarioDesde"
		Me.UsuarioDesde.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.UsuarioDesde.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.UsuarioDesde.PlaceholderText = "Usuario desde"
		Me.UsuarioDesde.SelectedText = ""
		Me.UsuarioDesde.Size = New System.Drawing.Size(257, 32)
		Me.UsuarioDesde.TabIndex = 21
		'
		'fechaNacimiento
		'
		Me.fechaNacimiento.BorderRadius = 10
		Me.fechaNacimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.fechaNacimiento.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.fechaNacimiento.DefaultText = ""
		Me.fechaNacimiento.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.fechaNacimiento.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.fechaNacimiento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.fechaNacimiento.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.fechaNacimiento.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.fechaNacimiento.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.fechaNacimiento.ForeColor = System.Drawing.Color.Black
		Me.fechaNacimiento.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.fechaNacimiento.Location = New System.Drawing.Point(157, 174)
		Me.fechaNacimiento.Name = "fechaNacimiento"
		Me.fechaNacimiento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.fechaNacimiento.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.fechaNacimiento.PlaceholderText = "Fecha de nacimiento"
		Me.fechaNacimiento.SelectedText = ""
		Me.fechaNacimiento.Size = New System.Drawing.Size(257, 32)
		Me.fechaNacimiento.TabIndex = 20
		'
		'apellido
		'
		Me.apellido.BorderRadius = 10
		Me.apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.apellido.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.apellido.DefaultText = ""
		Me.apellido.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.apellido.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.apellido.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.apellido.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.apellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.apellido.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.apellido.ForeColor = System.Drawing.Color.Black
		Me.apellido.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.apellido.Location = New System.Drawing.Point(157, 136)
		Me.apellido.Name = "apellido"
		Me.apellido.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.apellido.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.apellido.PlaceholderText = "Digite sus apellidos"
		Me.apellido.SelectedText = ""
		Me.apellido.Size = New System.Drawing.Size(257, 32)
		Me.apellido.TabIndex = 19
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.Location = New System.Drawing.Point(12, 458)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(67, 15)
		Me.Label9.TabIndex = 18
		Me.Label9.Text = "Contraseña"
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.Location = New System.Drawing.Point(12, 420)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(47, 15)
		Me.Label10.TabIndex = 17
		Me.Label10.Text = "Usuario"
		'
		'paislabel
		'
		Me.paislabel.AutoSize = True
		Me.paislabel.Location = New System.Drawing.Point(12, 382)
		Me.paislabel.Name = "paislabel"
		Me.paislabel.Size = New System.Drawing.Size(100, 15)
		Me.paislabel.TabIndex = 16
		Me.paislabel.Text = "País de residencia"
		'
		'nombre
		'
		Me.nombre.BorderRadius = 10
		Me.nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.nombre.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.nombre.DefaultText = ""
		Me.nombre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.nombre.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.nombre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.nombre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.nombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.nombre.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.nombre.ForeColor = System.Drawing.Color.Black
		Me.nombre.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.nombre.Location = New System.Drawing.Point(157, 98)
		Me.nombre.Name = "nombre"
		Me.nombre.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.nombre.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.nombre.PlaceholderText = "NOMBRE COMPLETO"
		Me.nombre.SelectedText = ""
		Me.nombre.Size = New System.Drawing.Size(257, 32)
		Me.nombre.TabIndex = 9
		'
		'identificacion
		'
		Me.identificacion.Location = New System.Drawing.Point(157, 61)
		Me.identificacion.Mask = "99-9999-9999"
		Me.identificacion.Name = "identificacion"
		Me.identificacion.Size = New System.Drawing.Size(110, 23)
		Me.identificacion.TabIndex = 8
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.Location = New System.Drawing.Point(12, 344)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(36, 15)
		Me.Label5.TabIndex = 7
		Me.Label5.Text = "Email"
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(12, 268)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(70, 15)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Código país"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.Location = New System.Drawing.Point(12, 306)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(114, 15)
		Me.Label7.TabIndex = 5
		Me.Label7.Text = "Número de telefono"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(12, 229)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(81, 15)
		Me.Label8.TabIndex = 4
		Me.Label8.Text = "Usuario desde"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 191)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(117, 15)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Fecha de nacimiento"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 153)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(51, 15)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Apellido"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 115)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(51, 15)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Nombre"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 67)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(79, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Identificación"
		'
		'BotonGuardar
		'
		Me.BotonGuardar.BorderRadius = 10
		Me.BotonGuardar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BotonGuardar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BotonGuardar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BotonGuardar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BotonGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BotonGuardar.ForeColor = System.Drawing.Color.White
		Me.BotonGuardar.Image = CType(resources.GetObject("BotonGuardar.Image"), System.Drawing.Image)
		Me.BotonGuardar.Location = New System.Drawing.Point(524, 12)
		Me.BotonGuardar.Name = "BotonGuardar"
		Me.BotonGuardar.Size = New System.Drawing.Size(139, 31)
		Me.BotonGuardar.TabIndex = 1
		Me.BotonGuardar.Text = "Guardar"
		'
		'BotonSalir
		'
		Me.BotonSalir.BorderRadius = 10
		Me.BotonSalir.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BotonSalir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BotonSalir.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BotonSalir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BotonSalir.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BotonSalir.ForeColor = System.Drawing.Color.White
		Me.BotonSalir.Image = CType(resources.GetObject("BotonSalir.Image"), System.Drawing.Image)
		Me.BotonSalir.Location = New System.Drawing.Point(711, 12)
		Me.BotonSalir.Name = "BotonSalir"
		Me.BotonSalir.Size = New System.Drawing.Size(136, 31)
		Me.BotonSalir.TabIndex = 2
		Me.BotonSalir.Text = "Salir"
		'
		'L
		'
		Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11, Me.ColumnHeader12})
		Me.L.FullRowSelect = True
		Me.L.GridLines = True
		Me.L.HideSelection = False
		Me.L.Location = New System.Drawing.Point(505, 110)
		Me.L.Name = "L"
		Me.L.Size = New System.Drawing.Size(342, 397)
		Me.L.TabIndex = 3
		Me.L.UseCompatibleStateImageBehavior = False
		Me.L.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "id"
		Me.ColumnHeader1.Width = 0
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Identificacion"
		Me.ColumnHeader2.Width = 157
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "Nombre"
		Me.ColumnHeader3.Width = 180
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "Apellido"
		Me.ColumnHeader4.Width = 0
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = "Fecha Nacimiento"
		Me.ColumnHeader5.Width = 0
		'
		'ColumnHeader6
		'
		Me.ColumnHeader6.Text = "Usuario desde"
		Me.ColumnHeader6.Width = 0
		'
		'ColumnHeader7
		'
		Me.ColumnHeader7.Text = "Codigo pais"
		Me.ColumnHeader7.Width = 0
		'
		'ColumnHeader8
		'
		Me.ColumnHeader8.Text = "Numero telefono"
		Me.ColumnHeader8.Width = 0
		'
		'ColumnHeader9
		'
		Me.ColumnHeader9.Text = "Email"
		Me.ColumnHeader9.Width = 0
		'
		'ColumnHeader10
		'
		Me.ColumnHeader10.Text = "Pais Residencia"
		Me.ColumnHeader10.Width = 0
		'
		'ColumnHeader11
		'
		Me.ColumnHeader11.Text = "Usuario"
		Me.ColumnHeader11.Width = 0
		'
		'ColumnHeader12
		'
		Me.ColumnHeader12.Text = "Contrasena"
		Me.ColumnHeader12.Width = 0
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Location = New System.Drawing.Point(502, 79)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(40, 13)
		Me.Label11.TabIndex = 28
		Me.Label11.Text = "Buscar"
		'
		'buscando
		'
		Me.buscando.BorderRadius = 10
		Me.buscando.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.buscando.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.buscando.DefaultText = ""
		Me.buscando.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.buscando.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.buscando.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.buscando.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.buscando.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.buscando.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.buscando.ForeColor = System.Drawing.Color.Black
		Me.buscando.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.buscando.Location = New System.Drawing.Point(548, 72)
		Me.buscando.Name = "buscando"
		Me.buscando.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.buscando.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.buscando.PlaceholderText = "NOMBRE "
		Me.buscando.SelectedText = ""
		Me.buscando.Size = New System.Drawing.Size(299, 32)
		Me.buscando.TabIndex = 28
		'
		'USUARIOS
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(867, 524)
		Me.Controls.Add(Me.buscando)
		Me.Controls.Add(Me.Label11)
		Me.Controls.Add(Me.L)
		Me.Controls.Add(Me.BotonSalir)
		Me.Controls.Add(Me.BotonGuardar)
		Me.Controls.Add(Me.Info_usuario)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "USUARIOS"
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Creación de usuarios"
		Me.Info_usuario.ResumeLayout(False)
		Me.Info_usuario.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Info_usuario As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents paislabel As Label
    Friend WithEvents nombre As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents identificacion As MaskedTextBox
    Friend WithEvents contrasena As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents usuario As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents paisResidencia As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents email As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents numeroTelefono As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CodigoPais As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents UsuarioDesde As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fechaNacimiento As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents apellido As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents BotonGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BotonSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents Label11 As Label
    Friend WithEvents buscando As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents ColumnHeader12 As ColumnHeader
End Class
