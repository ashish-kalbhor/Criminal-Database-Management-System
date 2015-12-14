<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmSplash
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
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents Shape3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Shape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Image1 As System.Windows.Forms.PictureBox
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmSplash))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.Shape3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.Label1 = New System.Windows.Forms.Label
		Me.Shape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Image1 = New System.Windows.Forms.PictureBox
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.ControlBox = False
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
		Me.ClientSize = New System.Drawing.Size(774, 534)
		Me.Location = New System.Drawing.Point(17, 94)
		Me.KeyPreview = True
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmSplash"
		Me.Frame1.BackColor = System.Drawing.SystemColors.InactiveCaption
		Me.Frame1.Size = New System.Drawing.Size(775, 533)
		Me.Frame1.Location = New System.Drawing.Point(0, 0)
		Me.Frame1.TabIndex = 0
		Me.Frame1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me.Timer1.Interval = 1
		Me.Timer1.Enabled = True
		Me.Shape3.BorderColor = System.Drawing.SystemColors.ActiveBorder
		Me.Shape3.Size = New System.Drawing.Size(313, 217)
		Me.Shape3.Location = New System.Drawing.Point(336, 99)
		Me.Shape3.CornerRadius = 26
		Me.Shape3.BackColor = System.Drawing.SystemColors.Window
		Me.Shape3.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape3.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape3.BorderWidth = 1
		Me.Shape3.FillColor = System.Drawing.Color.Black
		Me.Shape3.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape3.Visible = True
		Me.Shape3.Name = "Shape3"
		Me.Label3.Text = "SYSTEM"
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(137, 33)
		Me.Label3.Location = New System.Drawing.Point(424, 256)
		Me.Label3.TabIndex = 3
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.Color.Transparent
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.Visible = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me.Label2.Text = "MONITORING"
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(217, 41)
		Me.Label2.Location = New System.Drawing.Point(384, 200)
		Me.Label2.TabIndex = 2
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
		Me.Label1.Text = "CRIME"
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 21.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(105, 33)
		Me.Label1.Location = New System.Drawing.Point(432, 152)
		Me.Label1.TabIndex = 1
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
		Me.Shape2.Size = New System.Drawing.Size(657, 57)
		Me.Shape2.Location = New System.Drawing.Point(56, 395)
		Me.Shape2.CornerRadius = 7
		Me.Shape2.BackColor = System.Drawing.SystemColors.Window
		Me.Shape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape2.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape2.BorderWidth = 1
		Me.Shape2.FillColor = System.Drawing.Color.Black
		Me.Shape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape2.Visible = True
		Me.Shape2.Name = "Shape2"
		Me.Image1.Size = New System.Drawing.Size(233, 225)
		Me.Image1.Location = New System.Drawing.Point(32, 104)
		Me.Image1.Image = CType(resources.GetObject("Image1.Image"), System.Drawing.Image)
		Me.Image1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
		Me.Image1.Enabled = True
		Me.Image1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Image1.Visible = True
		Me.Image1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Image1.Name = "Image1"
		Me.Shape1.FillColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid
		Me.Shape1.Size = New System.Drawing.Size(9, 41)
		Me.Shape1.Location = New System.Drawing.Point(64, 403)
		Me.Shape1.CornerRadius = 1
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.BorderWidth = 1
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.Controls.Add(Frame1)
		Me.ShapeContainer1.Shapes.Add(Shape3)
		Me.Frame1.Controls.Add(Label3)
		Me.Frame1.Controls.Add(Label2)
		Me.Frame1.Controls.Add(Label1)
		Me.ShapeContainer1.Shapes.Add(Shape2)
		Me.Frame1.Controls.Add(Image1)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.Frame1.Controls.Add(ShapeContainer1)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class