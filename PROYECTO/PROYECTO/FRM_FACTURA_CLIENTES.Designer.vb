<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_FACTURA_CLIENTES
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_FACTURA_CLIENTES))
		Me.buscando = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.Info_factura = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.ACTUALIZAR = New Guna.UI2.WinForms.Guna2Button()
		Me.BotonGuardar = New Guna.UI2.WinForms.Guna2Button()
		Me.MONTOCANCELADO = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ID_HABITACION = New Guna.UI2.WinForms.Guna2TextBox()
		Me.ID_CLIENTE = New Guna.UI2.WinForms.Guna2TextBox()
		Me.FECHA_HORA_CANCELACION = New Guna.UI2.WinForms.Guna2TextBox()
		Me.identificacion = New System.Windows.Forms.MaskedTextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.BotonSalir = New Guna.UI2.WinForms.Guna2Button()
		Me.Eliminar = New Guna.UI2.WinForms.Guna2Button()
		Me.L = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.BTNREPORTE = New Guna.UI2.WinForms.Guna2Button()
		Me.Info_factura.SuspendLayout()
		Me.SuspendLayout()
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
		Me.buscando.Location = New System.Drawing.Point(606, 52)
		Me.buscando.Name = "buscando"
		Me.buscando.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.buscando.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.buscando.PlaceholderText = "DIGITE IDENTIFICACIÓN DEL CLIENTE"
		Me.buscando.SelectedText = ""
		Me.buscando.Size = New System.Drawing.Size(452, 32)
		Me.buscando.TabIndex = 29
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label11.Location = New System.Drawing.Point(532, 52)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(68, 24)
		Me.Label11.TabIndex = 30
		Me.Label11.Text = "Buscar"
		'
		'Info_factura
		'
		Me.Info_factura.Controls.Add(Me.ACTUALIZAR)
		Me.Info_factura.Controls.Add(Me.BotonGuardar)
		Me.Info_factura.Controls.Add(Me.MONTOCANCELADO)
		Me.Info_factura.Controls.Add(Me.Label3)
		Me.Info_factura.Controls.Add(Me.Label1)
		Me.Info_factura.Controls.Add(Me.ID_HABITACION)
		Me.Info_factura.Controls.Add(Me.ID_CLIENTE)
		Me.Info_factura.Controls.Add(Me.FECHA_HORA_CANCELACION)
		Me.Info_factura.Controls.Add(Me.identificacion)
		Me.Info_factura.Controls.Add(Me.Label6)
		Me.Info_factura.Controls.Add(Me.Label4)
		Me.Info_factura.Controls.Add(Me.Label12)
		Me.Info_factura.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Info_factura.ForeColor = System.Drawing.Color.Black
		Me.Info_factura.Location = New System.Drawing.Point(21, 92)
		Me.Info_factura.Name = "Info_factura"
		Me.Info_factura.Size = New System.Drawing.Size(468, 321)
		Me.Info_factura.TabIndex = 32
		Me.Info_factura.Text = "Información para facturar"
		'
		'ACTUALIZAR
		'
		Me.ACTUALIZAR.BorderRadius = 10
		Me.ACTUALIZAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.ACTUALIZAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.ACTUALIZAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.ACTUALIZAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.ACTUALIZAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.ACTUALIZAR.ForeColor = System.Drawing.Color.White
		Me.ACTUALIZAR.Image = CType(resources.GetObject("ACTUALIZAR.Image"), System.Drawing.Image)
		Me.ACTUALIZAR.Location = New System.Drawing.Point(253, 268)
		Me.ACTUALIZAR.Name = "ACTUALIZAR"
		Me.ACTUALIZAR.Size = New System.Drawing.Size(106, 31)
		Me.ACTUALIZAR.TabIndex = 37
		Me.ACTUALIZAR.Text = "Actualizar"
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
		Me.BotonGuardar.Location = New System.Drawing.Point(365, 268)
		Me.BotonGuardar.Name = "BotonGuardar"
		Me.BotonGuardar.Size = New System.Drawing.Size(82, 31)
		Me.BotonGuardar.TabIndex = 30
		Me.BotonGuardar.Text = "Guardar"
		'
		'MONTOCANCELADO
		'
		Me.MONTOCANCELADO.BackColor = System.Drawing.Color.Transparent
		Me.MONTOCANCELADO.BorderRadius = 10
		Me.MONTOCANCELADO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.MONTOCANCELADO.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.MONTOCANCELADO.DefaultText = ""
		Me.MONTOCANCELADO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.MONTOCANCELADO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.MONTOCANCELADO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.MONTOCANCELADO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.MONTOCANCELADO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MONTOCANCELADO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.MONTOCANCELADO.ForeColor = System.Drawing.Color.Black
		Me.MONTOCANCELADO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.MONTOCANCELADO.Location = New System.Drawing.Point(190, 198)
		Me.MONTOCANCELADO.Name = "MONTOCANCELADO"
		Me.MONTOCANCELADO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.MONTOCANCELADO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.MONTOCANCELADO.PlaceholderText = "Fecha y hora de cancelación"
		Me.MONTOCANCELADO.SelectedText = ""
		Me.MONTOCANCELADO.Size = New System.Drawing.Size(257, 32)
		Me.MONTOCANCELADO.TabIndex = 29
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(12, 215)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 15)
		Me.Label3.TabIndex = 28
		Me.Label3.Text = "Monto cancelado"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Location = New System.Drawing.Point(12, 80)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(120, 15)
		Me.Label1.TabIndex = 26
		Me.Label1.Text = "Fecha de cancelación"
		'
		'ID_HABITACION
		'
		Me.ID_HABITACION.BackColor = System.Drawing.Color.Transparent
		Me.ID_HABITACION.BorderRadius = 10
		Me.ID_HABITACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.ID_HABITACION.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.ID_HABITACION.DefaultText = ""
		Me.ID_HABITACION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.ID_HABITACION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.ID_HABITACION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.ID_HABITACION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.ID_HABITACION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ID_HABITACION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.ID_HABITACION.ForeColor = System.Drawing.Color.Black
		Me.ID_HABITACION.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ID_HABITACION.Location = New System.Drawing.Point(190, 160)
		Me.ID_HABITACION.Name = "ID_HABITACION"
		Me.ID_HABITACION.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.ID_HABITACION.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.ID_HABITACION.PlaceholderText = "Digite la identificación de habitación"
		Me.ID_HABITACION.SelectedText = ""
		Me.ID_HABITACION.Size = New System.Drawing.Size(257, 32)
		Me.ID_HABITACION.TabIndex = 22
		'
		'ID_CLIENTE
		'
		Me.ID_CLIENTE.BackColor = System.Drawing.Color.Transparent
		Me.ID_CLIENTE.BorderRadius = 10
		Me.ID_CLIENTE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.ID_CLIENTE.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.ID_CLIENTE.DefaultText = ""
		Me.ID_CLIENTE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.ID_CLIENTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.ID_CLIENTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.ID_CLIENTE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.ID_CLIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ID_CLIENTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.ID_CLIENTE.ForeColor = System.Drawing.Color.Black
		Me.ID_CLIENTE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.ID_CLIENTE.Location = New System.Drawing.Point(190, 122)
		Me.ID_CLIENTE.Name = "ID_CLIENTE"
		Me.ID_CLIENTE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.ID_CLIENTE.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.ID_CLIENTE.PlaceholderText = "Digite identificación cliente"
		Me.ID_CLIENTE.SelectedText = ""
		Me.ID_CLIENTE.Size = New System.Drawing.Size(257, 32)
		Me.ID_CLIENTE.TabIndex = 19
		'
		'FECHA_HORA_CANCELACION
		'
		Me.FECHA_HORA_CANCELACION.BackColor = System.Drawing.Color.Transparent
		Me.FECHA_HORA_CANCELACION.BorderRadius = 10
		Me.FECHA_HORA_CANCELACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.FECHA_HORA_CANCELACION.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.FECHA_HORA_CANCELACION.DefaultText = ""
		Me.FECHA_HORA_CANCELACION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.FECHA_HORA_CANCELACION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.FECHA_HORA_CANCELACION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.FECHA_HORA_CANCELACION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.FECHA_HORA_CANCELACION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.FECHA_HORA_CANCELACION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.FECHA_HORA_CANCELACION.ForeColor = System.Drawing.Color.Black
		Me.FECHA_HORA_CANCELACION.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.FECHA_HORA_CANCELACION.Location = New System.Drawing.Point(190, 80)
		Me.FECHA_HORA_CANCELACION.Name = "FECHA_HORA_CANCELACION"
		Me.FECHA_HORA_CANCELACION.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.FECHA_HORA_CANCELACION.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.FECHA_HORA_CANCELACION.PlaceholderText = "Fecha de cancelación"
		Me.FECHA_HORA_CANCELACION.SelectedText = ""
		Me.FECHA_HORA_CANCELACION.Size = New System.Drawing.Size(257, 32)
		Me.FECHA_HORA_CANCELACION.TabIndex = 9
		'
		'identificacion
		'
		Me.identificacion.Location = New System.Drawing.Point(190, 51)
		Me.identificacion.Mask = "99-9999-9999"
		Me.identificacion.Name = "identificacion"
		Me.identificacion.Size = New System.Drawing.Size(110, 23)
		Me.identificacion.TabIndex = 8
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(12, 160)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(154, 15)
		Me.Label6.TabIndex = 6
		Me.Label6.Text = "Identificación de habitación"
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(12, 122)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(136, 15)
		Me.Label4.TabIndex = 2
		Me.Label4.Text = "Identificación del cliente"
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Location = New System.Drawing.Point(12, 49)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(135, 15)
		Me.Label12.TabIndex = 0
		Me.Label12.Text = "Identificación empleado"
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
		Me.BotonSalir.Location = New System.Drawing.Point(922, 11)
		Me.BotonSalir.Name = "BotonSalir"
		Me.BotonSalir.Size = New System.Drawing.Size(136, 31)
		Me.BotonSalir.TabIndex = 34
		Me.BotonSalir.Text = "Salir"
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
		Me.Eliminar.Location = New System.Drawing.Point(789, 11)
		Me.Eliminar.Name = "Eliminar"
		Me.Eliminar.Size = New System.Drawing.Size(127, 31)
		Me.Eliminar.TabIndex = 35
		Me.Eliminar.Text = "Eliminar"
		'
		'L
		'
		Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
		Me.L.FullRowSelect = True
		Me.L.GridLines = True
		Me.L.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
		Me.L.HideSelection = False
		Me.L.Location = New System.Drawing.Point(536, 104)
		Me.L.Name = "L"
		Me.L.Size = New System.Drawing.Size(532, 307)
		Me.L.TabIndex = 36
		Me.L.UseCompatibleStateImageBehavior = False
		Me.L.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "ID"
		Me.ColumnHeader1.Width = 0
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "ID EMPLEADO"
		Me.ColumnHeader2.Width = 100
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "FECHA CANCELACIÓN"
		Me.ColumnHeader3.Width = 160
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "ID CLIENTE"
		Me.ColumnHeader4.Width = 100
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = "ID HABITACIÓN"
		Me.ColumnHeader5.Width = 100
		'
		'ColumnHeader6
		'
		Me.ColumnHeader6.Text = "MONTO "
		Me.ColumnHeader6.Width = 100
		'
		'BTNREPORTE
		'
		Me.BTNREPORTE.BorderRadius = 10
		Me.BTNREPORTE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BTNREPORTE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BTNREPORTE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BTNREPORTE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BTNREPORTE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTNREPORTE.ForeColor = System.Drawing.Color.White
		Me.BTNREPORTE.Image = CType(resources.GetObject("BTNREPORTE.Image"), System.Drawing.Image)
		Me.BTNREPORTE.Location = New System.Drawing.Point(624, 11)
		Me.BTNREPORTE.Name = "BTNREPORTE"
		Me.BTNREPORTE.Size = New System.Drawing.Size(136, 31)
		Me.BTNREPORTE.TabIndex = 37
		Me.BTNREPORTE.Text = "Generar reporte"
		'
		'FRM_FACTURA_CLIENTES
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(1099, 511)
		Me.Controls.Add(Me.BTNREPORTE)
		Me.Controls.Add(Me.L)
		Me.Controls.Add(Me.Eliminar)
		Me.Controls.Add(Me.BotonSalir)
		Me.Controls.Add(Me.Info_factura)
		Me.Controls.Add(Me.buscando)
		Me.Controls.Add(Me.Label11)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
		Me.KeyPreview = True
		Me.Name = "FRM_FACTURA_CLIENTES"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FACTURACIÓN"
		Me.Info_factura.ResumeLayout(False)
		Me.Info_factura.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents buscando As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Info_factura As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents ID_HABITACION As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ID_CLIENTE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents FECHA_HORA_CANCELACION As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents identificacion As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents BotonSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents MONTOCANCELADO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents BotonGuardar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Eliminar As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ACTUALIZAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTNREPORTE As Guna.UI2.WinForms.Guna2Button
End Class
