<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmfir3
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
	Public WithEvents nat As System.Windows.Forms.ComboBox
	Public WithEvents uid As System.Windows.Forms.TextBox
	Public WithEvents victim As System.Windows.Forms.TextBox
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents comp As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmfir3))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.Command1 = New System.Windows.Forms.Button
		Me.nat = New System.Windows.Forms.ComboBox
		Me.uid = New System.Windows.Forms.TextBox
		Me.victim = New System.Windows.Forms.TextBox
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me.comp = New System.Windows.Forms.Label
		Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
		Me.Label1 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me.Label2 = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.ClientSize = New System.Drawing.Size(594, 624)
		Me.Location = New System.Drawing.Point(276, 74)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("frmfir3.BackgroundImage"), System.Drawing.Image)
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmfir3"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "X"
		Me.Command1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(25, 25)
		Me.Command1.Location = New System.Drawing.Point(552, 16)
		Me.Command1.TabIndex = 10
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.nat.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.nat.Size = New System.Drawing.Size(273, 25)
		Me.nat.Location = New System.Drawing.Point(224, 136)
		Me.nat.Items.AddRange(New Object(){"INDIAN", "NRI"})
		Me.nat.TabIndex = 1
		Me.nat.Text = "SELECT NATIONALITY"
		Me.nat.BackColor = System.Drawing.SystemColors.Window
		Me.nat.CausesValidation = True
		Me.nat.Enabled = True
		Me.nat.ForeColor = System.Drawing.SystemColors.WindowText
		Me.nat.IntegralHeight = True
		Me.nat.Cursor = System.Windows.Forms.Cursors.Default
		Me.nat.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.nat.Sorted = False
		Me.nat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.nat.TabStop = True
		Me.nat.Visible = True
		Me.nat.Name = "nat"
		Me.uid.AutoSize = False
		Me.uid.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.uid.Size = New System.Drawing.Size(273, 33)
		Me.uid.Location = New System.Drawing.Point(224, 176)
		Me.uid.Maxlength = 8
		Me.uid.TabIndex = 2
		Me.uid.AcceptsReturn = True
		Me.uid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.uid.BackColor = System.Drawing.SystemColors.Window
		Me.uid.CausesValidation = True
		Me.uid.Enabled = True
		Me.uid.ForeColor = System.Drawing.SystemColors.WindowText
		Me.uid.HideSelection = True
		Me.uid.ReadOnly = False
		Me.uid.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.uid.MultiLine = False
		Me.uid.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.uid.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.uid.TabStop = True
		Me.uid.Visible = True
		Me.uid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.uid.Name = "uid"
		Me.victim.AutoSize = False
		Me.victim.CausesValidation = False
		Me.victim.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.victim.Size = New System.Drawing.Size(273, 33)
		Me.victim.HideSelection = False
		Me.victim.Location = New System.Drawing.Point(224, 96)
		Me.victim.Maxlength = 25
		Me.victim.TabIndex = 0
		Me.victim.AcceptsReturn = True
		Me.victim.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.victim.BackColor = System.Drawing.SystemColors.Window
		Me.victim.Enabled = True
		Me.victim.ForeColor = System.Drawing.SystemColors.WindowText
		Me.victim.ReadOnly = False
		Me.victim.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.victim.MultiLine = False
		Me.victim.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.victim.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.victim.TabStop = True
		Me.victim.Visible = True
		Me.victim.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.victim.Name = "victim"
		Me.Shape1.BorderWidth = 10
		Me.Shape1.Size = New System.Drawing.Size(577, 609)
		Me.Shape1.Location = New System.Drawing.Point(8, 8)
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.Label5.Text = "DONE"
		Me.Label5.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Size = New System.Drawing.Size(65, 25)
		Me.Label5.Location = New System.Drawing.Point(384, 248)
		Me.Label5.TabIndex = 9
		Me.Label5.Visible = False
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.Color.Transparent
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label6.Text = "PREVIOUS"
		Me.Label6.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label6.Size = New System.Drawing.Size(105, 25)
		Me.Label6.Location = New System.Drawing.Point(32, 248)
		Me.Label6.TabIndex = 8
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.Color.Transparent
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me.comp.Text = "SUBMIT"
		Me.comp.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.comp.Size = New System.Drawing.Size(81, 25)
		Me.comp.Location = New System.Drawing.Point(456, 248)
		Me.comp.TabIndex = 3
		Me.comp.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.comp.BackColor = System.Drawing.Color.Transparent
		Me.comp.Enabled = True
		Me.comp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.comp.Cursor = System.Windows.Forms.Cursors.Default
		Me.comp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.comp.UseMnemonic = True
		Me.comp.Visible = True
		Me.comp.AutoSize = False
		Me.comp.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.comp.Name = "comp"
		Me.Line1.X1 = 16
		Me.Line1.X2 = 560
		Me.Line1.Y1 = 288
		Me.Line1.Y2 = 288
		Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Line1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Line1.BorderWidth = 1
		Me.Line1.Visible = True
		Me.Line1.Name = "Line1"
		Me.Label1.Text = "UID :"
		Me.Label1.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Size = New System.Drawing.Size(81, 17)
		Me.Label1.Location = New System.Drawing.Point(56, 184)
		Me.Label1.TabIndex = 7
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
		Me.Label4.Text = "NATIONALITY:"
		Me.Label4.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label4.Size = New System.Drawing.Size(113, 17)
		Me.Label4.Location = New System.Drawing.Point(56, 144)
		Me.Label4.TabIndex = 6
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.Color.Transparent
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.Visible = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "NAME:"
		Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label3.Size = New System.Drawing.Size(81, 25)
		Me.Label3.Location = New System.Drawing.Point(56, 104)
		Me.Label3.TabIndex = 5
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
		Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.Label2.Text = "VICTIM"
		Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label2.Size = New System.Drawing.Size(177, 33)
		Me.Label2.Location = New System.Drawing.Point(192, 32)
		Me.Label2.TabIndex = 4
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
		Me.Controls.Add(Command1)
		Me.Controls.Add(nat)
		Me.Controls.Add(uid)
		Me.Controls.Add(victim)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label6)
		Me.Controls.Add(comp)
		Me.ShapeContainer1.Shapes.Add(Line1)
		Me.Controls.Add(Label1)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(Label2)
		Me.Controls.Add(ShapeContainer1)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class