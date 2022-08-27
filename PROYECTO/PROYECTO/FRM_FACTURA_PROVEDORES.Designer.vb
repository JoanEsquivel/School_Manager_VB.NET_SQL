<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_FACTURA_PROVEDORES
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FACTURA_PROVEDORES))
		Me.Info_proveedor = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.monto = New Guna.UI2.WinForms.Guna2TextBox()
		Me.descripcion = New Guna.UI2.WinForms.Guna2TextBox()
		Me.proveedor = New Guna.UI2.WinForms.Guna2TextBox()
		Me.fecha = New Guna.UI2.WinForms.Guna2TextBox()
		Me.identificacion = New System.Windows.Forms.MaskedTextBox()
		Me.BotonGuardar = New Guna.UI2.WinForms.Guna2Button()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.Eliminar = New Guna.UI2.WinForms.Guna2Button()
		Me.BotonSalir = New Guna.UI2.WinForms.Guna2Button()
		Me.buscar = New Guna.UI2.WinForms.Guna2TextBox()
		Me.L = New System.Windows.Forms.ListView()
		Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader15 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.Guna2BorderlessForm1 = New Guna.UI2.WinForms.Guna2BorderlessForm(Me.components)
		Me.PictureBox1 = New System.Windows.Forms.PictureBox()
		Me.botonActualizar = New Guna.UI2.WinForms.Guna2Button()
		Me.Info_proveedor.SuspendLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'Info_proveedor
		'
		Me.Info_proveedor.Controls.Add(Me.monto)
		Me.Info_proveedor.Controls.Add(Me.descripcion)
		Me.Info_proveedor.Controls.Add(Me.proveedor)
		Me.Info_proveedor.Controls.Add(Me.fecha)
		Me.Info_proveedor.Controls.Add(Me.identificacion)
		Me.Info_proveedor.Controls.Add(Me.BotonGuardar)
		Me.Info_proveedor.Controls.Add(Me.Label8)
		Me.Info_proveedor.Controls.Add(Me.Label3)
		Me.Info_proveedor.Controls.Add(Me.Label4)
		Me.Info_proveedor.Controls.Add(Me.Label2)
		Me.Info_proveedor.Controls.Add(Me.Label1)
		Me.Info_proveedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Info_proveedor.ForeColor = System.Drawing.Color.Black
		Me.Info_proveedor.Location = New System.Drawing.Point(44, 11)
		Me.Info_proveedor.Name = "Info_proveedor"
		Me.Info_proveedor.Size = New System.Drawing.Size(430, 300)
		Me.Info_proveedor.TabIndex = 1
		Me.Info_proveedor.Text = "Informacion de la factura"
		'
		'monto
		'
		Me.monto.BorderRadius = 10
		Me.monto.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.monto.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.monto.DefaultText = ""
		Me.monto.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.monto.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.monto.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.monto.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.monto.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.monto.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.monto.ForeColor = System.Drawing.Color.Black
		Me.monto.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.monto.Location = New System.Drawing.Point(157, 212)
		Me.monto.Name = "monto"
		Me.monto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.monto.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.monto.PlaceholderText = "Monto a Cancelar"
		Me.monto.SelectedText = ""
		Me.monto.Size = New System.Drawing.Size(257, 32)
		Me.monto.TabIndex = 21
		'
		'descripcion
		'
		Me.descripcion.BorderRadius = 10
		Me.descripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.descripcion.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.descripcion.DefaultText = ""
		Me.descripcion.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.descripcion.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.descripcion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.descripcion.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.descripcion.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.descripcion.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.descripcion.ForeColor = System.Drawing.Color.Black
		Me.descripcion.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.descripcion.Location = New System.Drawing.Point(157, 174)
		Me.descripcion.Name = "descripcion"
		Me.descripcion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.descripcion.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.descripcion.PlaceholderText = "Descripción"
		Me.descripcion.SelectedText = ""
		Me.descripcion.Size = New System.Drawing.Size(257, 32)
		Me.descripcion.TabIndex = 20
		'
		'proveedor
		'
		Me.proveedor.BorderRadius = 10
		Me.proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.proveedor.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.proveedor.DefaultText = ""
		Me.proveedor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.proveedor.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.proveedor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.proveedor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.proveedor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.proveedor.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.proveedor.ForeColor = System.Drawing.Color.Black
		Me.proveedor.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.proveedor.Location = New System.Drawing.Point(157, 136)
		Me.proveedor.Name = "proveedor"
		Me.proveedor.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.proveedor.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.proveedor.PlaceholderText = "Digite ID Proveedor"
		Me.proveedor.SelectedText = ""
		Me.proveedor.Size = New System.Drawing.Size(257, 32)
		Me.proveedor.TabIndex = 19
		'
		'fecha
		'
		Me.fecha.BorderRadius = 10
		Me.fecha.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.fecha.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.fecha.DefaultText = ""
		Me.fecha.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.fecha.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.fecha.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.fecha.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.fecha.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.fecha.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.fecha.ForeColor = System.Drawing.Color.Black
		Me.fecha.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.fecha.Location = New System.Drawing.Point(157, 98)
		Me.fecha.Name = "fecha"
		Me.fecha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.fecha.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.fecha.PlaceholderText = "FECHA"
		Me.fecha.SelectedText = ""
		Me.fecha.Size = New System.Drawing.Size(257, 32)
		Me.fecha.TabIndex = 9
		'
		'identificacion
		'
		Me.identificacion.Location = New System.Drawing.Point(157, 61)
		Me.identificacion.Mask = "9-9999-9999"
		Me.identificacion.Name = "identificacion"
		Me.identificacion.Size = New System.Drawing.Size(110, 23)
		Me.identificacion.TabIndex = 8
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
		Me.BotonGuardar.Location = New System.Drawing.Point(318, 258)
		Me.BotonGuardar.Name = "BotonGuardar"
		Me.BotonGuardar.Size = New System.Drawing.Size(82, 31)
		Me.BotonGuardar.TabIndex = 22
		Me.BotonGuardar.Text = "Guardar"
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.Location = New System.Drawing.Point(12, 229)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(105, 15)
		Me.Label8.TabIndex = 4
		Me.Label8.Text = "Monto Cancelado:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(12, 191)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(72, 15)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Descripción:"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(12, 153)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(139, 15)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Identificación Proveedor:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(12, 115)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(109, 15)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "Fecha Cancelación:"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(12, 67)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(138, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "Identificacion empleado:"
		'
		'Eliminar
		'
		Me.Eliminar.BorderRadius = 10
		Me.Eliminar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.Eliminar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.Eliminar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.Eliminar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.Eliminar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Eliminar.ForeColor = System.Drawing.Color.White
		Me.Eliminar.Image = CType(resources.GetObject("Eliminar.Image"), System.Drawing.Image)
		Me.Eliminar.Location = New System.Drawing.Point(950, 146)
		Me.Eliminar.Name = "Eliminar"
		Me.Eliminar.Size = New System.Drawing.Size(82, 31)
		Me.Eliminar.TabIndex = 30
		Me.Eliminar.Text = "Eliminar"
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
		Me.BotonSalir.Location = New System.Drawing.Point(950, 184)
		Me.BotonSalir.Name = "BotonSalir"
		Me.BotonSalir.Size = New System.Drawing.Size(85, 31)
		Me.BotonSalir.TabIndex = 23
		Me.BotonSalir.Text = "Salir"
		'
		'buscar
		'
		Me.buscar.BorderRadius = 10
		Me.buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.buscar.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.buscar.DefaultText = ""
		Me.buscar.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.buscar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.buscar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.buscar.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.buscar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.buscar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.buscar.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.buscar.Location = New System.Drawing.Point(519, 19)
		Me.buscar.Name = "buscar"
		Me.buscar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.buscar.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.buscar.PlaceholderText = "ID EMPLEADO"
		Me.buscar.SelectedText = ""
		Me.buscar.Size = New System.Drawing.Size(425, 32)
		Me.buscar.TabIndex = 29
		'
		'L
		'
		Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14, Me.ColumnHeader15, Me.ColumnHeader16, Me.ColumnHeader17, Me.ColumnHeader1})
		Me.L.FullRowSelect = True
		Me.L.GridLines = True
		Me.L.HideSelection = False
		Me.L.Location = New System.Drawing.Point(489, 57)
		Me.L.Name = "L"
		Me.L.Size = New System.Drawing.Size(456, 254)
		Me.L.TabIndex = 24
		Me.L.UseCompatibleStateImageBehavior = False
		Me.L.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader13
		'
		Me.ColumnHeader13.Text = "ID "
		Me.ColumnHeader13.Width = 0
		'
		'ColumnHeader14
		'
		Me.ColumnHeader14.Text = "ID empleado"
		Me.ColumnHeader14.Width = 140
		'
		'ColumnHeader15
		'
		Me.ColumnHeader15.Text = "Fecha cancelación"
		Me.ColumnHeader15.Width = 113
		'
		'ColumnHeader16
		'
		Me.ColumnHeader16.Text = "ID proveedor"
		Me.ColumnHeader16.Width = 105
		'
		'ColumnHeader17
		'
		Me.ColumnHeader17.Text = "Descripción"
		Me.ColumnHeader17.Width = 129
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "Monto cancelado"
		Me.ColumnHeader1.Width = 117
		'
		'Guna2BorderlessForm1
		'
		Me.Guna2BorderlessForm1.ContainerControl = Me
		Me.Guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6R
		Me.Guna2BorderlessForm1.TransparentWhileDrag = True
		'
		'PictureBox1
		'
		Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
		Me.PictureBox1.Location = New System.Drawing.Point(489, 23)
		Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
		Me.PictureBox1.Name = "PictureBox1"
		Me.PictureBox1.Size = New System.Drawing.Size(25, 23)
		Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.PictureBox1.TabIndex = 31
		Me.PictureBox1.TabStop = False
		'
		'botonActualizar
		'
		Me.botonActualizar.BorderRadius = 10
		Me.botonActualizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.botonActualizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.botonActualizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.botonActualizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.botonActualizar.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.botonActualizar.ForeColor = System.Drawing.Color.White
		Me.botonActualizar.Image = CType(resources.GetObject("botonActualizar.Image"), System.Drawing.Image)
		Me.botonActualizar.Location = New System.Drawing.Point(950, 225)
		Me.botonActualizar.Name = "botonActualizar"
		Me.botonActualizar.Size = New System.Drawing.Size(85, 31)
		Me.botonActualizar.TabIndex = 32
		Me.botonActualizar.Text = "Actualizar"
		'
		'FRM_FACTURA_PROVEDORES
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1040, 372)
		Me.Controls.Add(Me.botonActualizar)
		Me.Controls.Add(Me.PictureBox1)
		Me.Controls.Add(Me.Eliminar)
		Me.Controls.Add(Me.BotonSalir)
		Me.Controls.Add(Me.Info_proveedor)
		Me.Controls.Add(Me.buscar)
		Me.Controls.Add(Me.L)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Margin = New System.Windows.Forms.Padding(2)
		Me.Name = "FRM_FACTURA_PROVEDORES"
		Me.Text = "FRM_FACTURA_PROVEDORES"
		Me.Info_proveedor.ResumeLayout(False)
		Me.Info_proveedor.PerformLayout()
		CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents Info_proveedor As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents monto As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents descripcion As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents proveedor As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents fecha As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents identificacion As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BotonGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BotonSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader13 As ColumnHeader
    Friend WithEvents ColumnHeader14 As ColumnHeader
    Friend WithEvents ColumnHeader15 As ColumnHeader
    Friend WithEvents ColumnHeader16 As ColumnHeader
    Friend WithEvents ColumnHeader17 As ColumnHeader
    Friend WithEvents buscar As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2BorderlessForm1 As Guna.UI2.WinForms.Guna2BorderlessForm
    Friend WithEvents Eliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents botonActualizar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
