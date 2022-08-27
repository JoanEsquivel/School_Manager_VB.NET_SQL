<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FRM_RESERVACIONES
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_RESERVACIONES))
		Me.Guna2AnimateWindow1 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
		Me.Guna2AnimateWindow2 = New Guna.UI2.WinForms.Guna2AnimateWindow(Me.components)
		Me.Guna2GroupBox1 = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.FECHA_SALIDA = New System.Windows.Forms.DateTimePicker()
		Me.FECHA_ENTRADA = New System.Windows.Forms.DateTimePicker()
		Me.CMBIDHABITACION = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.CMBIDCLIENTE = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.Label4 = New System.Windows.Forms.Label()
		Me.Label3 = New System.Windows.Forms.Label()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.SALIR = New Guna.UI2.WinForms.Guna2Button()
		Me.GUARDAR = New Guna.UI2.WinForms.Guna2Button()
		Me.L = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.BUSCANDO = New Guna.UI2.WinForms.Guna2TextBox()
		Me.Label6 = New System.Windows.Forms.Label()
		Me.GRESERVACIONES = New Guna.UI2.WinForms.Guna2GroupBox()
		Me.BTNACEPTAR = New Guna.UI2.WinForms.Guna2Button()
		Me.CMBBUSCAR = New Guna.UI2.WinForms.Guna2ComboBox()
		Me.Guna2GroupBox1.SuspendLayout()
		Me.GRESERVACIONES.SuspendLayout()
		Me.SuspendLayout()
		'
		'Guna2GroupBox1
		'
		Me.Guna2GroupBox1.Controls.Add(Me.FECHA_SALIDA)
		Me.Guna2GroupBox1.Controls.Add(Me.FECHA_ENTRADA)
		Me.Guna2GroupBox1.Controls.Add(Me.CMBIDHABITACION)
		Me.Guna2GroupBox1.Controls.Add(Me.CMBIDCLIENTE)
		Me.Guna2GroupBox1.Controls.Add(Me.Label4)
		Me.Guna2GroupBox1.Controls.Add(Me.Label3)
		Me.Guna2GroupBox1.Controls.Add(Me.Label2)
		Me.Guna2GroupBox1.Controls.Add(Me.Label1)
		Me.Guna2GroupBox1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.Guna2GroupBox1.ForeColor = System.Drawing.Color.Black
		Me.Guna2GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.Guna2GroupBox1.Name = "Guna2GroupBox1"
		Me.Guna2GroupBox1.Size = New System.Drawing.Size(468, 387)
		Me.Guna2GroupBox1.TabIndex = 1
		Me.Guna2GroupBox1.Text = "Reservaciones"
		'
		'FECHA_SALIDA
		'
		Me.FECHA_SALIDA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.FECHA_SALIDA.Location = New System.Drawing.Point(137, 229)
		Me.FECHA_SALIDA.Name = "FECHA_SALIDA"
		Me.FECHA_SALIDA.Size = New System.Drawing.Size(99, 23)
		Me.FECHA_SALIDA.TabIndex = 43
		Me.FECHA_SALIDA.Value = New Date(2022, 8, 7, 0, 0, 0, 0)
		'
		'FECHA_ENTRADA
		'
		Me.FECHA_ENTRADA.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
		Me.FECHA_ENTRADA.Location = New System.Drawing.Point(137, 182)
		Me.FECHA_ENTRADA.Name = "FECHA_ENTRADA"
		Me.FECHA_ENTRADA.Size = New System.Drawing.Size(99, 23)
		Me.FECHA_ENTRADA.TabIndex = 42
		Me.FECHA_ENTRADA.Value = New Date(2022, 8, 7, 0, 0, 0, 0)
		'
		'CMBIDHABITACION
		'
		Me.CMBIDHABITACION.BackColor = System.Drawing.Color.Transparent
		Me.CMBIDHABITACION.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.CMBIDHABITACION.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CMBIDHABITACION.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBIDHABITACION.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBIDHABITACION.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.CMBIDHABITACION.ForeColor = System.Drawing.Color.Black
		Me.CMBIDHABITACION.ItemHeight = 30
		Me.CMBIDHABITACION.Items.AddRange(New Object() {"12", "14"})
		Me.CMBIDHABITACION.Location = New System.Drawing.Point(137, 120)
		Me.CMBIDHABITACION.Name = "CMBIDHABITACION"
		Me.CMBIDHABITACION.Size = New System.Drawing.Size(220, 36)
		Me.CMBIDHABITACION.TabIndex = 38
		'
		'CMBIDCLIENTE
		'
		Me.CMBIDCLIENTE.BackColor = System.Drawing.Color.Transparent
		Me.CMBIDCLIENTE.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.CMBIDCLIENTE.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CMBIDCLIENTE.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBIDCLIENTE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBIDCLIENTE.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.CMBIDCLIENTE.ForeColor = System.Drawing.Color.Black
		Me.CMBIDCLIENTE.ItemHeight = 30
		Me.CMBIDCLIENTE.Location = New System.Drawing.Point(137, 53)
		Me.CMBIDCLIENTE.Name = "CMBIDCLIENTE"
		Me.CMBIDCLIENTE.Size = New System.Drawing.Size(220, 36)
		Me.CMBIDCLIENTE.TabIndex = 37
		'
		'Label4
		'
		Me.Label4.AutoSize = True
		Me.Label4.Location = New System.Drawing.Point(3, 229)
		Me.Label4.Name = "Label4"
		Me.Label4.Size = New System.Drawing.Size(90, 15)
		Me.Label4.TabIndex = 3
		Me.Label4.Text = "Fecha de salida:"
		'
		'Label3
		'
		Me.Label3.AutoSize = True
		Me.Label3.Location = New System.Drawing.Point(3, 182)
		Me.Label3.Name = "Label3"
		Me.Label3.Size = New System.Drawing.Size(100, 15)
		Me.Label3.TabIndex = 2
		Me.Label3.Text = "Fecha de entrada:"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(3, 130)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(105, 15)
		Me.Label2.TabIndex = 1
		Me.Label2.Text = "ID de la habitacion"
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(3, 74)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(75, 15)
		Me.Label1.TabIndex = 0
		Me.Label1.Text = "ID del cliente"
		'
		'SALIR
		'
		Me.SALIR.BackColor = System.Drawing.Color.White
		Me.SALIR.BorderRadius = 5
		Me.SALIR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.SALIR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.SALIR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.SALIR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.SALIR.FillColor = System.Drawing.Color.CornflowerBlue
		Me.SALIR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.SALIR.ForeColor = System.Drawing.Color.Black
		Me.SALIR.Image = CType(resources.GetObject("SALIR.Image"), System.Drawing.Image)
		Me.SALIR.Location = New System.Drawing.Point(836, 37)
		Me.SALIR.Name = "SALIR"
		Me.SALIR.Size = New System.Drawing.Size(136, 22)
		Me.SALIR.TabIndex = 13
		Me.SALIR.Text = "Salir"
		'
		'GUARDAR
		'
		Me.GUARDAR.BackColor = System.Drawing.Color.White
		Me.GUARDAR.BorderRadius = 5
		Me.GUARDAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.GUARDAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.GUARDAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.GUARDAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.GUARDAR.Enabled = False
		Me.GUARDAR.FillColor = System.Drawing.Color.CornflowerBlue
		Me.GUARDAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.GUARDAR.ForeColor = System.Drawing.Color.Black
		Me.GUARDAR.Image = CType(resources.GetObject("GUARDAR.Image"), System.Drawing.Image)
		Me.GUARDAR.Location = New System.Drawing.Point(694, 37)
		Me.GUARDAR.Name = "GUARDAR"
		Me.GUARDAR.Size = New System.Drawing.Size(136, 22)
		Me.GUARDAR.TabIndex = 12
		Me.GUARDAR.Text = "Guardar"
		'
		'L
		'
		Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
		Me.L.FullRowSelect = True
		Me.L.GridLines = True
		Me.L.HideSelection = False
		Me.L.Location = New System.Drawing.Point(486, 93)
		Me.L.MultiSelect = False
		Me.L.Name = "L"
		Me.L.Size = New System.Drawing.Size(486, 306)
		Me.L.TabIndex = 11
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
		Me.ColumnHeader2.Text = "ID cliente"
		Me.ColumnHeader2.Width = 167
		'
		'ColumnHeader3
		'
		Me.ColumnHeader3.Text = "ID habitacion"
		Me.ColumnHeader3.Width = 105
		'
		'ColumnHeader4
		'
		Me.ColumnHeader4.Text = "Fecha de entrada"
		Me.ColumnHeader4.Width = 114
		'
		'ColumnHeader5
		'
		Me.ColumnHeader5.Text = "Fecha de salida"
		Me.ColumnHeader5.Width = 96
		'
		'BUSCANDO
		'
		Me.BUSCANDO.BorderRadius = 5
		Me.BUSCANDO.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
		Me.BUSCANDO.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.BUSCANDO.DefaultText = ""
		Me.BUSCANDO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.BUSCANDO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.BUSCANDO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.BUSCANDO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.BUSCANDO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.BUSCANDO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BUSCANDO.ForeColor = System.Drawing.Color.Black
		Me.BUSCANDO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.BUSCANDO.Location = New System.Drawing.Point(598, 65)
		Me.BUSCANDO.Name = "BUSCANDO"
		Me.BUSCANDO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.BUSCANDO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.BUSCANDO.PlaceholderText = "Digite el ID del cliente"
		Me.BUSCANDO.SelectedText = ""
		Me.BUSCANDO.Size = New System.Drawing.Size(374, 22)
		Me.BUSCANDO.TabIndex = 10
		'
		'Label6
		'
		Me.Label6.AutoSize = True
		Me.Label6.Location = New System.Drawing.Point(483, 74)
		Me.Label6.Name = "Label6"
		Me.Label6.Size = New System.Drawing.Size(109, 13)
		Me.Label6.TabIndex = 9
		Me.Label6.Text = "Buscar reservaciones"
		'
		'GRESERVACIONES
		'
		Me.GRESERVACIONES.BorderRadius = 10
		Me.GRESERVACIONES.Controls.Add(Me.BTNACEPTAR)
		Me.GRESERVACIONES.Controls.Add(Me.CMBBUSCAR)
		Me.GRESERVACIONES.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.GRESERVACIONES.ForeColor = System.Drawing.Color.Black
		Me.GRESERVACIONES.Location = New System.Drawing.Point(300, 169)
		Me.GRESERVACIONES.Name = "GRESERVACIONES"
		Me.GRESERVACIONES.Size = New System.Drawing.Size(346, 100)
		Me.GRESERVACIONES.TabIndex = 45
		Me.GRESERVACIONES.Text = "Reservaciones registradas"
		Me.GRESERVACIONES.Visible = False
		'
		'BTNACEPTAR
		'
		Me.BTNACEPTAR.BorderRadius = 5
		Me.BTNACEPTAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BTNACEPTAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BTNACEPTAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BTNACEPTAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BTNACEPTAR.Enabled = False
		Me.BTNACEPTAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTNACEPTAR.ForeColor = System.Drawing.Color.White
		Me.BTNACEPTAR.Image = CType(resources.GetObject("BTNACEPTAR.Image"), System.Drawing.Image)
		Me.BTNACEPTAR.Location = New System.Drawing.Point(248, 54)
		Me.BTNACEPTAR.Name = "BTNACEPTAR"
		Me.BTNACEPTAR.Size = New System.Drawing.Size(91, 31)
		Me.BTNACEPTAR.TabIndex = 7
		Me.BTNACEPTAR.Text = "Aceptar"
		'
		'CMBBUSCAR
		'
		Me.CMBBUSCAR.BackColor = System.Drawing.Color.Transparent
		Me.CMBBUSCAR.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
		Me.CMBBUSCAR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
		Me.CMBBUSCAR.FocusedColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBBUSCAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.CMBBUSCAR.Font = New System.Drawing.Font("Segoe UI", 10.0!)
		Me.CMBBUSCAR.ForeColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(112, Byte), Integer))
		Me.CMBBUSCAR.ItemHeight = 30
		Me.CMBBUSCAR.Location = New System.Drawing.Point(5, 51)
		Me.CMBBUSCAR.Name = "CMBBUSCAR"
		Me.CMBBUSCAR.Size = New System.Drawing.Size(237, 36)
		Me.CMBBUSCAR.TabIndex = 0
		'
		'FRM_RESERVACIONES
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(985, 409)
		Me.Controls.Add(Me.GRESERVACIONES)
		Me.Controls.Add(Me.SALIR)
		Me.Controls.Add(Me.GUARDAR)
		Me.Controls.Add(Me.L)
		Me.Controls.Add(Me.BUSCANDO)
		Me.Controls.Add(Me.Label6)
		Me.Controls.Add(Me.Guna2GroupBox1)
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.Name = "FRM_RESERVACIONES"
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "FRM_RESERVACIONES"
		Me.Guna2GroupBox1.ResumeLayout(False)
		Me.Guna2GroupBox1.PerformLayout()
		Me.GRESERVACIONES.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents Guna2AnimateWindow1 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2AnimateWindow2 As Guna.UI2.WinForms.Guna2AnimateWindow
    Friend WithEvents Guna2GroupBox1 As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CMBIDCLIENTE As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents CMBIDHABITACION As Guna.UI2.WinForms.Guna2ComboBox
    Friend WithEvents SALIR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents GUARDAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents L As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents BUSCANDO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents FECHA_SALIDA As DateTimePicker
    Friend WithEvents FECHA_ENTRADA As DateTimePicker
    Friend WithEvents GRESERVACIONES As Guna.UI2.WinForms.Guna2GroupBox
    Friend WithEvents BTNACEPTAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents CMBBUSCAR As Guna.UI2.WinForms.Guna2ComboBox
End Class
