<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_CORREO
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
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FRM_CORREO))
		Me.LBL_FROM = New System.Windows.Forms.Label()
		Me.BTN_EDITAR_DE = New Guna.UI2.WinForms.Guna2Button()
		Me.BTN_ADJUNTAR = New Guna.UI2.WinForms.Guna2Button()
		Me.BTN_EDITAR_PARA = New Guna.UI2.WinForms.Guna2Button()
		Me.BTN_ENVIAR = New Guna.UI2.WinForms.Guna2Button()
		Me.TXT_MENSAJE = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXT_ASUNTO = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXTPARA = New Guna.UI2.WinForms.Guna2TextBox()
		Me.TXTADJUNTAR = New Guna.UI2.WinForms.Guna2TextBox()
		Me.L = New System.Windows.Forms.ListView()
		Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.SuspendLayout()
		'
		'LBL_FROM
		'
		Me.LBL_FROM.Location = New System.Drawing.Point(89, 15)
		Me.LBL_FROM.Name = "LBL_FROM"
		Me.LBL_FROM.Size = New System.Drawing.Size(398, 23)
		Me.LBL_FROM.TabIndex = 19
		Me.LBL_FROM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		'
		'BTN_EDITAR_DE
		'
		Me.BTN_EDITAR_DE.BorderRadius = 20
		Me.BTN_EDITAR_DE.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BTN_EDITAR_DE.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BTN_EDITAR_DE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BTN_EDITAR_DE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BTN_EDITAR_DE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTN_EDITAR_DE.ForeColor = System.Drawing.Color.White
		Me.BTN_EDITAR_DE.Location = New System.Drawing.Point(6, 7)
		Me.BTN_EDITAR_DE.Name = "BTN_EDITAR_DE"
		Me.BTN_EDITAR_DE.Size = New System.Drawing.Size(62, 30)
		Me.BTN_EDITAR_DE.TabIndex = 18
		Me.BTN_EDITAR_DE.Text = "De:"
		'
		'BTN_ADJUNTAR
		'
		Me.BTN_ADJUNTAR.BorderRadius = 20
		Me.BTN_ADJUNTAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BTN_ADJUNTAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BTN_ADJUNTAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BTN_ADJUNTAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BTN_ADJUNTAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTN_ADJUNTAR.ForeColor = System.Drawing.Color.White
		Me.BTN_ADJUNTAR.Image = CType(resources.GetObject("BTN_ADJUNTAR.Image"), System.Drawing.Image)
		Me.BTN_ADJUNTAR.Location = New System.Drawing.Point(10, 193)
		Me.BTN_ADJUNTAR.Name = "BTN_ADJUNTAR"
		Me.BTN_ADJUNTAR.Size = New System.Drawing.Size(76, 36)
		Me.BTN_ADJUNTAR.TabIndex = 16
		Me.BTN_ADJUNTAR.Text = "Adjuntar"
		'
		'BTN_EDITAR_PARA
		'
		Me.BTN_EDITAR_PARA.BorderRadius = 20
		Me.BTN_EDITAR_PARA.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BTN_EDITAR_PARA.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BTN_EDITAR_PARA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BTN_EDITAR_PARA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BTN_EDITAR_PARA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTN_EDITAR_PARA.ForeColor = System.Drawing.Color.White
		Me.BTN_EDITAR_PARA.Location = New System.Drawing.Point(6, 82)
		Me.BTN_EDITAR_PARA.Name = "BTN_EDITAR_PARA"
		Me.BTN_EDITAR_PARA.Size = New System.Drawing.Size(62, 30)
		Me.BTN_EDITAR_PARA.TabIndex = 15
		Me.BTN_EDITAR_PARA.Text = "Para:"
		'
		'BTN_ENVIAR
		'
		Me.BTN_ENVIAR.BorderRadius = 20
		Me.BTN_ENVIAR.DisabledState.BorderColor = System.Drawing.Color.DarkGray
		Me.BTN_ENVIAR.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray
		Me.BTN_ENVIAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(169, Byte), Integer))
		Me.BTN_ENVIAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer), CType(CType(141, Byte), Integer))
		Me.BTN_ENVIAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.BTN_ENVIAR.ForeColor = System.Drawing.Color.White
		Me.BTN_ENVIAR.Image = CType(resources.GetObject("BTN_ENVIAR.Image"), System.Drawing.Image)
		Me.BTN_ENVIAR.Location = New System.Drawing.Point(528, 496)
		Me.BTN_ENVIAR.Name = "BTN_ENVIAR"
		Me.BTN_ENVIAR.Size = New System.Drawing.Size(148, 34)
		Me.BTN_ENVIAR.TabIndex = 13
		Me.BTN_ENVIAR.Text = "Enviar"
		'
		'TXT_MENSAJE
		'
		Me.TXT_MENSAJE.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXT_MENSAJE.DefaultText = ""
		Me.TXT_MENSAJE.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXT_MENSAJE.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXT_MENSAJE.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_MENSAJE.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_MENSAJE.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_MENSAJE.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.TXT_MENSAJE.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_MENSAJE.Location = New System.Drawing.Point(10, 359)
		Me.TXT_MENSAJE.Name = "TXT_MENSAJE"
		Me.TXT_MENSAJE.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXT_MENSAJE.PlaceholderText = "Digíte su mensaje"
		Me.TXT_MENSAJE.SelectedText = ""
		Me.TXT_MENSAJE.Size = New System.Drawing.Size(688, 130)
		Me.TXT_MENSAJE.TabIndex = 12
		'
		'TXT_ASUNTO
		'
		Me.TXT_ASUNTO.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXT_ASUNTO.DefaultText = ""
		Me.TXT_ASUNTO.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXT_ASUNTO.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXT_ASUNTO.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_ASUNTO.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXT_ASUNTO.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_ASUNTO.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.TXT_ASUNTO.ForeColor = System.Drawing.Color.Black
		Me.TXT_ASUNTO.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXT_ASUNTO.Location = New System.Drawing.Point(10, 153)
		Me.TXT_ASUNTO.Name = "TXT_ASUNTO"
		Me.TXT_ASUNTO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXT_ASUNTO.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
		Me.TXT_ASUNTO.PlaceholderText = "Digíte el asunto"
		Me.TXT_ASUNTO.SelectedText = ""
		Me.TXT_ASUNTO.Size = New System.Drawing.Size(688, 34)
		Me.TXT_ASUNTO.TabIndex = 11
		'
		'TXTPARA
		'
		Me.TXTPARA.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTPARA.DefaultText = ""
		Me.TXTPARA.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTPARA.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTPARA.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTPARA.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTPARA.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTPARA.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.TXTPARA.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTPARA.Location = New System.Drawing.Point(92, 82)
		Me.TXTPARA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TXTPARA.Name = "TXTPARA"
		Me.TXTPARA.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTPARA.PlaceholderText = ""
		Me.TXTPARA.SelectedText = ""
		Me.TXTPARA.Size = New System.Drawing.Size(396, 29)
		Me.TXTPARA.TabIndex = 21
		'
		'TXTADJUNTAR
		'
		Me.TXTADJUNTAR.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TXTADJUNTAR.DefaultText = ""
		Me.TXTADJUNTAR.DisabledState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer), CType(CType(208, Byte), Integer))
		Me.TXTADJUNTAR.DisabledState.FillColor = System.Drawing.Color.FromArgb(CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(226, Byte), Integer))
		Me.TXTADJUNTAR.DisabledState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTADJUNTAR.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer), CType(CType(138, Byte), Integer))
		Me.TXTADJUNTAR.FocusedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTADJUNTAR.Font = New System.Drawing.Font("Segoe UI", 9.0!)
		Me.TXTADJUNTAR.HoverState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
		Me.TXTADJUNTAR.Location = New System.Drawing.Point(92, 193)
		Me.TXTADJUNTAR.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.TXTADJUNTAR.Name = "TXTADJUNTAR"
		Me.TXTADJUNTAR.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
		Me.TXTADJUNTAR.PlaceholderText = ""
		Me.TXTADJUNTAR.SelectedText = ""
		Me.TXTADJUNTAR.Size = New System.Drawing.Size(396, 37)
		Me.TXTADJUNTAR.TabIndex = 22
		'
		'L
		'
		Me.L.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2})
		Me.L.FullRowSelect = True
		Me.L.GridLines = True
		Me.L.HideSelection = False
		Me.L.Location = New System.Drawing.Point(91, 234)
		Me.L.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.L.Name = "L"
		Me.L.Size = New System.Drawing.Size(398, 119)
		Me.L.TabIndex = 23
		Me.L.UseCompatibleStateImageBehavior = False
		Me.L.View = System.Windows.Forms.View.Details
		'
		'ColumnHeader1
		'
		Me.ColumnHeader1.Width = 0
		'
		'ColumnHeader2
		'
		Me.ColumnHeader2.Text = "DOCUMENTOS"
		Me.ColumnHeader2.Width = 700
		'
		'FRM_CORREO
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.Color.White
		Me.ClientSize = New System.Drawing.Size(753, 532)
		Me.Controls.Add(Me.L)
		Me.Controls.Add(Me.TXTADJUNTAR)
		Me.Controls.Add(Me.TXTPARA)
		Me.Controls.Add(Me.LBL_FROM)
		Me.Controls.Add(Me.BTN_EDITAR_DE)
		Me.Controls.Add(Me.BTN_ADJUNTAR)
		Me.Controls.Add(Me.BTN_EDITAR_PARA)
		Me.Controls.Add(Me.BTN_ENVIAR)
		Me.Controls.Add(Me.TXT_MENSAJE)
		Me.Controls.Add(Me.TXT_ASUNTO)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
		Me.Name = "FRM_CORREO"
		Me.Text = "CORREO"
		Me.ResumeLayout(False)

	End Sub
	Friend WithEvents LBL_FROM As Label
    Friend WithEvents BTN_EDITAR_DE As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ADJUNTAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_EDITAR_PARA As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents BTN_ENVIAR As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents TXT_MENSAJE As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXT_ASUNTO As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTPARA As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents TXTADJUNTAR As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents L As ListView
End Class
