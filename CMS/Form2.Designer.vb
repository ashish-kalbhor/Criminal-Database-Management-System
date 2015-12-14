<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmlogin
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents ommand1 As System.Windows.Forms.Button
	Public WithEvents Text2 As System.Windows.Forms.TextBox
	Public WithEvents Text1 As System.Windows.Forms.TextBox
	Public WithEvents Shape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Shape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Image2 As System.Windows.Forms.PictureBox
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmlogin))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.Command1 = New System.Windows.Forms.Button
		Me.ommand1 = New System.Windows.Forms.Button
		Me.Text2 = New System.Windows.Forms.TextBox
		Me.Text1 = New System.Windows.Forms.TextBox
		Me.Shape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Shape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Label3 = New System.Windows.Forms.Label
		Me.Image2 = New System.Windows.Forms.PictureBox
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "LOGIN"
		Me.ClientSize = New System.Drawing.Size(868, 373)
		Me.Location = New System.Drawing.Point(204, 193)
		Me.KeyPreview = True
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("frmlogin.BackgroundImage"), System.Drawing.Image)
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmlogin"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "CANCEL"
		Me.Command1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(153, 33)
		Me.Command1.Location = New System.Drawing.Point(456, 264)
		Me.Command1.TabIndex = 5
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.ommand1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.ommand1.Text = "LOGIN"
		Me.AcceptButton = Me.ommand1
		Me.ommand1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ommand1.Size = New System.Drawing.Size(153, 33)
		Me.ommand1.Location = New System.Drawing.Point(672, 264)
		Me.ommand1.TabIndex = 4
		Me.ommand1.BackColor = System.Drawing.SystemColors.Control
		Me.ommand1.CausesValidation = True
		Me.ommand1.Enabled = True
		Me.ommand1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ommand1.Cursor = System.Windows.Forms.Cursors.Default
		Me.ommand1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ommand1.TabStop = True
		Me.ommand1.Name = "ommand1"
		Me.Text2.AutoSize = False
		Me.Text2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text2.Size = New System.Drawing.Size(185, 41)
		Me.Text2.IMEMode = System.Windows.Forms.ImeMode.Disable
		Me.Text2.Location = New System.Drawing.Point(568, 152)
		Me.Text2.PasswordChar = ChrW(42)
		Me.Text2.TabIndex = 3
		Me.Text2.AcceptsReturn = True
		Me.Text2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text2.BackColor = System.Drawing.SystemColors.Window
		Me.Text2.CausesValidation = True
		Me.Text2.Enabled = True
		Me.Text2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text2.HideSelection = True
		Me.Text2.ReadOnly = False
		Me.Text2.Maxlength = 0
		Me.Text2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text2.MultiLine = False
		Me.Text2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text2.TabStop = True
		Me.Text2.Visible = True
		Me.Text2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text2.Name = "Text2"
		Me.Text1.AutoSize = False
		Me.Text1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Text1.Size = New System.Drawing.Size(185, 41)
		Me.Text1.Location = New System.Drawing.Point(568, 80)
		Me.Text1.TabIndex = 2
		Me.Text1.AcceptsReturn = True
		Me.Text1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.Text1.BackColor = System.Drawing.SystemColors.Window
		Me.Text1.CausesValidation = True
		Me.Text1.Enabled = True
		Me.Text1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Text1.HideSelection = True
		Me.Text1.ReadOnly = False
		Me.Text1.Maxlength = 0
		Me.Text1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.Text1.MultiLine = False
		Me.Text1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Text1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.Text1.TabStop = True
		Me.Text1.Visible = True
		Me.Text1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.Text1.Name = "Text1"
		Me.Shape3.BorderWidth = 3
		Me.Shape3.Size = New System.Drawing.Size(337, 249)
		Me.Shape3.Location = New System.Drawing.Point(24, 64)
		Me.Shape3.CornerRadius = 30
		Me.Shape3.Visible = False
		Me.Shape3.BackColor = System.Drawing.SystemColors.Window
		Me.Shape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape3.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape3.FillColor = System.Drawing.Color.Black
		Me.Shape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape3.Name = "Shape3"
		Me.Shape2.BorderWidth = 3
		Me.Shape2.Size = New System.Drawing.Size(401, 177)
		Me.Shape2.Location = New System.Drawing.Point(400, 56)
		Me.Shape2.CornerRadius = 21
		Me.Shape2.BackColor = System.Drawing.SystemColors.Window
		Me.Shape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape2.FillColor = System.Drawing.Color.Black
		Me.Shape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape2.Visible = True
		Me.Shape2.Name = "Shape2"
		Me.Label3.Text = "IN ORDER TO LOGIN THIS SYTEM PLEASE ENTER THE SPECIFIED USERNAME AND PASSWORD THAT IS PROVIDED TO YOU BY THE SPECIFIED AUTHORITY IN ORDER TO CONTINUE WITH YOUR WORK."
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(281, 193)
		Me.Label3.Location = New System.Drawing.Point(56, 88)
		Me.Label3.TabIndex = 6
		Me.Label3.Visible = False
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Image2.Size = New System.Drawing.Size(57, 49)
		Me.Image2.Location = New System.Drawing.Point(16, 8)
		Me.Image2.Image = CType(resources.GetObject("Image2.Image"), System.Drawing.Image)
		Me.Image2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image2.Enabled = True
		Me.Image2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image2.Visible = True
		Me.Image2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image2.Name = "Image2"
		Me.Shape1.BorderWidth = 10
		Me.Shape1.Size = New System.Drawing.Size(865, 369)
		Me.Shape1.Location = New System.Drawing.Point(0, 0)
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.Line1.BorderColor = System.Drawing.SystemColors.Highlight
		Me.Line1.X1 = 384
		Me.Line1.X2 = 384
		Me.Line1.Y1 = 8
		Me.Line1.Y2 = 360
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.BorderWidth = 1
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.Label2.Text = "PASSWORD"
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(121, 25)
		Me.Label2.Location = New System.Drawing.Point(424, 160)
		Me.Label2.TabIndex = 1
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label2.BackColor = System.Drawing.Color.Transparent
		Me.Label2.Enabled = True
		Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label2.UseMnemonic = True
		Me.Label2.Visible = True
		Me.Label2.AutoSize = False
		Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label2.Name = "Label2"
		Me.Label1.Text = "USERNAME"
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(121, 25)
		Me.Label1.Location = New System.Drawing.Point(424, 88)
		Me.Label1.TabIndex = 0
		Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label1.BackColor = System.Drawing.Color.Transparent
		Me.Label1.Enabled = True
		Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label1.UseMnemonic = True
		Me.Label1.Visible = True
		Me.Label1.AutoSize = False
		Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label1.Name = "Label1"
		Me.Controls.Add(Command1)
		Me.Controls.Add(ommand1)
		Me.Controls.Add(Text2)
		Me.Controls.Add(Text1)
		Me.ShapeContainer1.Shapes.Add(Shape3)
		Me.ShapeContainer1.Shapes.Add(Shape2)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Image2)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.Controls.Add(Label2)
		Me.Controls.Add(Label1)
		Me.Controls.Add(ShapeContainer1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class