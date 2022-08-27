<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_HABITACIONES
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
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_HABITACIONES))
		Me.INFO_HABITACIONES = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.ESPACIO_LISTA = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.BUSCAR = New Guna.UI2.WinForms.Guna2TextBox()
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
		Me.BotonSalir = New Guna.UI2.WinForms.Guna2Button()
		Me.CMBCLIENTEU = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.Label12 = New System.Windows.Forms.Label()
		Me.Label11 = New System.Windows.Forms.Label()
		Me.CMBCLIENTEA = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.Label10 = New System.Windows.Forms.Label()
		Me.BT_GUARDAR = New Guna.UI2.WinForms.Guna2Button()
		Me.C_NINNOS = New Guna.UI2.WinForms.Guna2NumericUpDown()
		Me.C_ADULTOS = New Guna.UI2.WinForms.Guna2NumericUpDown()
		Me.C_HABITACION = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label9 = New System.Windows.Forms.Label()
		Me.CMBRESERVACION = New System.Windows.Forms.ComboBox()
		Me.Label8 = New System.Windows.Forms.Label()
		Me.Label7 = New System.Windows.Forms.Label()
		Me.AMENIDAD = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.DESCRIPCION = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label5 = New System.Windows.Forms.Label()
		Me.NOMBRE = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.N_HABITACION = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Guna2ContextMenuStrip1 = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
		Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
		Me.INFO_HABITACIONES.SuspendLayout()
		Me.ESPACIO_LISTA.SuspendLayout()
		CType(Me.C_NINNOS, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.C_ADULTOS, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'INFO_HABITACIONES
		'
		Me.INFO_HABITACIONES.Controls.Add(Me.Label1)
		Me.INFO_HABITACIONES.Controls.Add(Me.ESPACIO_LISTA)
		Me.INFO_HABITACIONES.Controls.Add(Me.BotonSalir)
		Me.INFO_HABITACIONES.Controls.Add(Me.CMBCLIENTEU)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label12)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label11)
		Me.INFO_HABITACIONES.Controls.Add(Me.CMBCLIENTEA)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label10)
		Me.INFO_HABITACIONES.Controls.Add(Me.BT_GUARDAR)
		Me.INFO_HABITACIONES.Controls.Add(Me.C_NINNOS)
		Me.INFO_HABITACIONES.Controls.Add(Me.C_ADULTOS)
		Me.INFO_HABITACIONES.Controls.Add(Me.C_HABITACION)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label9)
		Me.INFO_HABITACIONES.Controls.Add(Me.CMBRESERVACION)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label8)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label7)
		Me.INFO_HABITACIONES.Controls.Add(Me.AMENIDAD)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label6)
		Me.INFO_HABITACIONES.Controls.Add(Me.DESCRIPCION)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label5)
		Me.INFO_HABITACIONES.Controls.Add(Me.NOMBRE)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label4)
		Me.INFO_HABITACIONES.Controls.Add(Me.N_HABITACION)
		Me.INFO_HABITACIONES.Controls.Add(Me.Label3)
		Me.INFO_HABITACIONES.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.INFO_HABITACIONES.ForeColor = System.Drawing.Color.Black
		Me.INFO_HABITACIONES.Location = New System.Drawing.Point(12, 12)
		Me.INFO_HABITACIONES.Name = "INFO_HABITACIONES"
		Me.INFO_HABITACIONES.Size = New System.Drawing.Size(671, 346)
		Me.INFO_HABITACIONES.TabIndex = 0
		Me.INFO_HABITACIONES.Text = "Habitaciones"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(236, 331)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(239, 15)
		Me.Label1.TabIndex = 41
		Me.Label1.Text = "Pulse F5 para ver las habitaciones existentes"
		'
		'ESPACIO_LISTA
		'
		Me.ESPACIO_LISTA.BorderRadius = 10
		Me.ESPACIO_LISTA.Controls.Add(Me.BUSCAR)
		Me.ESPACIO_LISTA.Controls.Add(Me.L)
		Me.ESPACIO_LISTA.FillColor = System.Drawing.Color.WhiteSmoke
		Me.ESPACIO_LISTA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.ESPACIO_LISTA.ForeColor = System.Drawing.Color.Black
		Me.ESPACIO_LISTA.Location = New System.Drawing.Point(3, 94)
		Me.ESPACIO_LISTA.Name = "ESPACIO_LISTA"
		Me.ESPACIO_LISTA.Size = New System.Drawing.Size(668, 245)
		Me.ESPACIO_LISTA.TabIndex = 41
		Me.ESPACIO_LISTA.Text = "Habitaciones existentes"
		Me.ESPACIO_LISTA.Visible = False
		'
		'BUSCAR
		'
		Me.BUSCAR.BorderRadius = 10
		Me.BUSCAR.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.BUSCAR.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.BUSCAR.DefaultText = ""
		Me.BUSCAR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.BUSCAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.BUSCAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.BUSCAR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.BUSCAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.BUSCAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BUSCAR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.BUSCAR.Location = New System.Drawing.Point(7, 48)
		Me.BUSCAR.Name = "BUSCAR"
		Me.BUSCAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.BUSCAR.PlaceholderText = "Dijite el numero de la habitacion a buscar"
		Me.BUSCAR.SelectedText = ""
		Me.BUSCAR.Size = New System.Drawing.Size(374, 29)
		Me.BUSCAR.TabIndex = 29
		'
		'L
		'
		Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader10, Me.ColumnHeader11})
		Me.L.HideSelection = False
		Me.L.LabelEdit = True
		Me.L.Location = New System.Drawing.Point(7, 80)
		Me.L.Name = "L"
		Me.L.Size = New System.Drawing.Size(650, 158)
		Me.L.TabIndex = 0
		Me.L.UseCompatibleStateImageBehavior = False
		Me.L.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Text = "Numero de habitación"
		Me.ColumnHeader1.Width = 84
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "Nombre de la habitacion"
		Me.ColumnHeader2.Width = 73
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "Descripcion"
		Me.ColumnHeader3.Width = 65
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "Amenidades"
		Me.ColumnHeader4.Width = 65
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = "Costo de la habitacion"
		'
		'ColumnHeader6
		'
		Me.ColumnHeader6.Text = "Cantidad Adultos"
		Me.ColumnHeader6.Width = 96
		'
		'ColumnHeader7
		'
		Me.ColumnHeader7.Text = "Cantidad niños"
		Me.ColumnHeader7.Width = 97
		'
		'ColumnHeader8
		'
		Me.ColumnHeader8.Text = "Reservada"
		'
		'ColumnHeader9
		'
		Me.ColumnHeader9.Text = "Cliente actual"
		'
		'ColumnHeader10
		'
		Me.ColumnHeader10.Text = "Anterior cliente"
		'
		'ColumnHeader11
		'
		Me.ColumnHeader11.Text = "ID"
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
		Me.BotonSalir.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.BotonSalir.Location = New System.Drawing.Point(527, 57)
		Me.BotonSalir.Name = "BotonSalir"
		Me.BotonSalir.Size = New System.Drawing.Size(136, 31)
		Me.BotonSalir.TabIndex = 40
		Me.BotonSalir.Text = "Salir"
		'
		'CMBCLIENTEU
		'
		Me.CMBCLIENTEU.BackColor = System.Drawing.Color.Transparent
		Me.CMBCLIENTEU.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.CMBCLIENTEU.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CMBCLIENTEU.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBCLIENTEU.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBCLIENTEU.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.CMBCLIENTEU.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.CMBCLIENTEU.ItemHeight = 30
		Me.CMBCLIENTEU.Location = New System.Drawing.Point(471, 262)
		Me.CMBCLIENTEU.Name = "CMBCLIENTEU"
		Me.CMBCLIENTEU.Size = New System.Drawing.Size(184, 36)
		Me.CMBCLIENTEU.TabIndex = 39
		'
		'Label12
		'
		Me.Label12.AutoSize = True
		Me.Label12.BackColor = System.Drawing.Color.Transparent
		Me.Label12.Location = New System.Drawing.Point(381, 271)
		Me.Label12.Name = "Label12"
		Me.Label12.Size = New System.Drawing.Size(84, 15)
		Me.Label12.TabIndex = 38
		Me.Label12.Text = "Último cliente:"
		'
		'Label11
		'
		Me.Label11.AutoSize = True
		Me.Label11.BackColor = System.Drawing.Color.Transparent
		Me.Label11.Location = New System.Drawing.Point(17, 271)
		Me.Label11.Name = "Label11"
		Me.Label11.Size = New System.Drawing.Size(82, 15)
		Me.Label11.TabIndex = 37
		Me.Label11.Text = "Cliente actual:"
		'
		'CMBCLIENTEA
		'
		Me.CMBCLIENTEA.BackColor = System.Drawing.Color.Transparent
		Me.CMBCLIENTEA.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.CMBCLIENTEA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CMBCLIENTEA.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBCLIENTEA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBCLIENTEA.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.CMBCLIENTEA.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.CMBCLIENTEA.ItemHeight = 30
		Me.CMBCLIENTEA.Location = New System.Drawing.Point(164, 262)
		Me.CMBCLIENTEA.Name = "CMBCLIENTEA"
		Me.CMBCLIENTEA.Size = New System.Drawing.Size(196, 36)
		Me.CMBCLIENTEA.TabIndex = 36
		'
		'Label10
		'
		Me.Label10.AutoSize = True
		Me.Label10.BackColor = System.Drawing.Color.Transparent
		Me.Label10.Location = New System.Drawing.Point(381, 225)
		Me.Label10.Name = "Label10"
		Me.Label10.Size = New System.Drawing.Size(73, 15)
		Me.Label10.TabIndex = 35
		Me.Label10.Text = "Reservación:"
		'
		'BT_GUARDAR
		'
		Me.BT_GUARDAR.BorderRadius = 10
		Me.BT_GUARDAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BT_GUARDAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BT_GUARDAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BT_GUARDAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BT_GUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BT_GUARDAR.ForeColor = System.Drawing.Color.White
		Me.BT_GUARDAR.Image = CType(resources.GetObject("BT_GUARDAR.Image"), System.Drawing.Image)
		Me.BT_GUARDAR.Location = New System.Drawing.Point(384, 57)
		Me.BT_GUARDAR.Name = "BT_GUARDAR"
		Me.BT_GUARDAR.Size = New System.Drawing.Size(137, 31)
		Me.BT_GUARDAR.TabIndex = 34
		Me.BT_GUARDAR.Text = "Guardar Habitación"
		'
		'C_NINNOS
		'
		Me.C_NINNOS.BackColor = System.Drawing.Color.Transparent
		Me.C_NINNOS.BorderRadius = 10
		Me.C_NINNOS.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.C_NINNOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.C_NINNOS.Location = New System.Drawing.Point(164, 212)
		Me.C_NINNOS.Name = "C_NINNOS"
		Me.C_NINNOS.Size = New System.Drawing.Size(68, 26)
		Me.C_NINNOS.TabIndex = 25
		'
		'C_ADULTOS
		'
		Me.C_ADULTOS.BackColor = System.Drawing.Color.Transparent
		Me.C_ADULTOS.BorderRadius = 10
		Me.C_ADULTOS.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.C_ADULTOS.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.C_ADULTOS.Location = New System.Drawing.Point(164, 170)
		Me.C_ADULTOS.Name = "C_ADULTOS"
		Me.C_ADULTOS.Size = New System.Drawing.Size(68, 26)
		Me.C_ADULTOS.TabIndex = 24
		'
		'C_HABITACION
		'
		Me.C_HABITACION.BackColor = System.Drawing.Color.Transparent
		Me.C_HABITACION.BorderRadius = 10
		Me.C_HABITACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.C_HABITACION.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.C_HABITACION.DefaultText = ""
		Me.C_HABITACION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.C_HABITACION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.C_HABITACION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.C_HABITACION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.C_HABITACION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.C_HABITACION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.C_HABITACION.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.C_HABITACION.Location = New System.Drawing.Point(164, 126)
		Me.C_HABITACION.Name = "C_HABITACION"
		Me.C_HABITACION.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.C_HABITACION.PlaceholderText = "Digite el costo de la habitacion"
		Me.C_HABITACION.SelectedText = ""
		Me.C_HABITACION.Size = New System.Drawing.Size(196, 26)
		Me.C_HABITACION.TabIndex = 21
		'
		'Label9
		'
		Me.Label9.AutoSize = True
		Me.Label9.BackColor = System.Drawing.Color.Transparent
		Me.Label9.Location = New System.Drawing.Point(17, 218)
		Me.Label9.Name = "Label9"
		Me.Label9.Size = New System.Drawing.Size(106, 15)
		Me.Label9.TabIndex = 20
		Me.Label9.Text = "Cantidad de niños:"
		'
		'CMBRESERVACION
		'
		Me.CMBRESERVACION.FormattingEnabled = True
		Me.CMBRESERVACION.Items.AddRange(New Object() {"Disponible", "No disponible"})
		Me.CMBRESERVACION.Location = New System.Drawing.Point(471, 225)
		Me.CMBRESERVACION.Name = "CMBRESERVACION"
		Me.CMBRESERVACION.Size = New System.Drawing.Size(184, 23)
		Me.CMBRESERVACION.TabIndex = 19
		'
		'Label8
		'
		Me.Label8.AutoSize = True
		Me.Label8.BackColor = System.Drawing.Color.Transparent
		Me.Label8.Location = New System.Drawing.Point(17, 137)
		Me.Label8.Name = "Label8"
		Me.Label8.Size = New System.Drawing.Size(116, 15)
		Me.Label8.TabIndex = 18
		Me.Label8.Text = "Costo de habitación:"
		'
		'Label7
		'
		Me.Label7.AutoSize = True
		Me.Label7.BackColor = System.Drawing.Color.Transparent
		Me.Label7.Location = New System.Drawing.Point(17, 181)
		Me.Label7.Name = "Label7"
		Me.Label7.Size = New System.Drawing.Size(116, 15)
		Me.Label7.TabIndex = 17
		Me.Label7.Text = "Cantidad de adultos:"
		'
		'AMENIDAD
		'
		Me.AMENIDAD.BackColor = System.Drawing.Color.Transparent
		Me.AMENIDAD.BorderRadius = 10
		Me.AMENIDAD.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.AMENIDAD.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.AMENIDAD.DefaultText = ""
		Me.AMENIDAD.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.AMENIDAD.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.AMENIDAD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.AMENIDAD.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.AMENIDAD.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.AMENIDAD.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.AMENIDAD.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.AMENIDAD.Location = New System.Drawing.Point(471, 181)
		Me.AMENIDAD.Name = "AMENIDAD"
		Me.AMENIDAD.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.AMENIDAD.PlaceholderText = "Digite si la habitacion presenta alguna amenidad de la habitacion"
		Me.AMENIDAD.SelectedText = ""
		Me.AMENIDAD.Size = New System.Drawing.Size(184, 26)
		Me.AMENIDAD.TabIndex = 16
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Location = New System.Drawing.Point(381, 181)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(76, 15)
		Me.Label6.TabIndex = 15
		Me.Label6.Text = "Amenidades:"
		'
		'DESCRIPCION
		'
		Me.DESCRIPCION.BackColor = System.Drawing.Color.Transparent
		Me.DESCRIPCION.BorderRadius = 10
		Me.DESCRIPCION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.DESCRIPCION.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.DESCRIPCION.DefaultText = ""
		Me.DESCRIPCION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.DESCRIPCION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.DESCRIPCION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.DESCRIPCION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.DESCRIPCION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.DESCRIPCION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.DESCRIPCION.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.DESCRIPCION.Location = New System.Drawing.Point(471, 94)
		Me.DESCRIPCION.Name = "DESCRIPCION"
		Me.DESCRIPCION.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.DESCRIPCION.PlaceholderText = "Descripción de la habitacion"
		Me.DESCRIPCION.SelectedText = ""
		Me.DESCRIPCION.Size = New System.Drawing.Size(184, 72)
		Me.DESCRIPCION.TabIndex = 14
		'
		'Label5
		'
		Me.Label5.AutoSize = True
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Location = New System.Drawing.Point(382, 105)
		Me.Label5.Name = "Label5"
		Me.Label5.Size = New System.Drawing.Size(72, 15)
		Me.Label5.TabIndex = 13
		Me.Label5.Text = "Descripción:"
		'
		'NOMBRE
		'
		Me.NOMBRE.BackColor = System.Drawing.Color.Transparent
		Me.NOMBRE.BorderRadius = 10
		Me.NOMBRE.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.NOMBRE.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.NOMBRE.DefaultText = ""
		Me.NOMBRE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.NOMBRE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.NOMBRE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.NOMBRE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.NOMBRE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.NOMBRE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.NOMBRE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.NOMBRE.Location = New System.Drawing.Point(164, 94)
		Me.NOMBRE.Name = "NOMBRE"
		Me.NOMBRE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.NOMBRE.PlaceholderText = "Digite el nombre de la habitacion"
		Me.NOMBRE.SelectedText = ""
		Me.NOMBRE.Size = New System.Drawing.Size(196, 26)
		Me.NOMBRE.TabIndex = 12
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Location = New System.Drawing.Point(17, 105)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(141, 15)
		Me.Label4.TabIndex = 11
		Me.Label4.Text = "Nombre de la habitación:"
		'
		'N_HABITACION
		'
		Me.N_HABITACION.BackColor = System.Drawing.Color.Transparent
		Me.N_HABITACION.BorderRadius = 10
		Me.N_HABITACION.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.N_HABITACION.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.N_HABITACION.DefaultText = ""
		Me.N_HABITACION.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.N_HABITACION.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.N_HABITACION.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.N_HABITACION.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.N_HABITACION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.N_HABITACION.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.N_HABITACION.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.N_HABITACION.Location = New System.Drawing.Point(164, 57)
		Me.N_HABITACION.Name = "N_HABITACION"
		Me.N_HABITACION.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.N_HABITACION.PlaceholderText = "Digite el número de la habitacion"
		Me.N_HABITACION.SelectedText = ""
		Me.N_HABITACION.Size = New System.Drawing.Size(196, 26)
		Me.N_HABITACION.TabIndex = 10
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Location = New System.Drawing.Point(17, 64)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(141, 15)
		Me.Label3.TabIndex = 3
		Me.Label3.Text = "Número de la habitación:"
		'
		'Guna2ContextMenuStrip1
		'
		Me.Guna2ContextMenuStrip1.Name = "Guna2ContextMenuStrip1"
		Me.Guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(CType(CType(151, Byte), Integer), CType(CType(143, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro
		Me.Guna2ContextMenuStrip1.RenderStyle.ColorTable = Nothing
		Me.Guna2ContextMenuStrip1.RenderStyle.RoundedEdges = True
		Me.Guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White
		Me.Guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.Guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White
		Me.Guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro
		Me.Guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault
		Me.Guna2ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
		'
		'FRM_HABITACIONES
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(693, 366)
		Me.Controls.Add(Me.INFO_HABITACIONES)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.KeyPreview = True
		Me.Name = "FRM_HABITACIONES"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FRM_HABITACIONES"
		Me.INFO_HABITACIONES.ResumeLayout(False)
		Me.INFO_HABITACIONES.PerformLayout()
		Me.ESPACIO_LISTA.ResumeLayout(False)
		CType(Me.C_NINNOS, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.C_ADULTOS, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents INFO_HABITACIONES As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents N_HABITACION As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2ContextMenuStrip1 As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents NOMBRE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents AMENIDAD As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DESCRIPCION As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents C_NINNOS As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents C_ADULTOS As Guna.UI2.WinForms.Guna2NumericUpDown
    Friend WithEvents C_HABITACION As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents CMBRESERVACION As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents BT_GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents CMBCLIENTEU As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents CMBCLIENTEA As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents BotonSalir As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents ESPACIO_LISTA As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ColumnHeader9 As ColumnHeader
    Friend WithEvents ColumnHeader10 As ColumnHeader
    Friend WithEvents BUSCAR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ColumnHeader11 As ColumnHeader
    Friend WithEvents Label1 As Label
End Class
