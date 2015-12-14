<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class Frmgraph
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
    'Public WithEvents MSChart1 As AxMSChart20Lib.AxMSChart
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Frmgraph))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.Command1 = New System.Windows.Forms.Button
        ' = New AxMSChart20Lib.AxMSChart
		Me.Combo1 = New System.Windows.Forms.ComboBox
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
        'CType(Me.MSChart1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(917, 577)
		Me.Location = New System.Drawing.Point(175, 133)
		Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
		Me.BackgroundImage = CType(resources.GetObject("Frmgraph.BackgroundImage"), System.Drawing.Image)
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
		Me.Name = "Frmgraph"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.BackColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.CancelButton = Me.Command1
		Me.Command1.Text = "X"
		Me.Command1.Font = New System.Drawing.Font("Times New Roman", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(49, 41)
		Me.Command1.Location = New System.Drawing.Point(848, 16)
		Me.Command1.TabIndex = 2
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
        'MSChart1.OcxState = CType(resources.GetObject("MSChart1.OcxState"), System.Windows.Forms.AxHost.State)
        'Me.MSChart1.Size = New System.Drawing.Size(865, 401)
        'Me.MSChart1.Location = New System.Drawing.Point(32, 96)
        'Me.MSChart1.TabIndex = 1
        'Me.MSChart1.Visible = False
        'Me.MSChart1.Name = "MSChart1"
		Me.Combo1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Combo1.Size = New System.Drawing.Size(305, 29)
		Me.Combo1.Location = New System.Drawing.Point(296, 48)
		Me.Combo1.Items.AddRange(New Object(){"MURDER", "ROBBERY", "RAPE", "KIDNAPPING", "EXTORTION", "THEFT", "ILLEGAL POSSESSION", "MOLESTATION", "FRAUD", "OTHERS"})
		Me.Combo1.TabIndex = 0
		Me.Combo1.Text = "SELECT CRIME"
		Me.Combo1.BackColor = System.Drawing.SystemColors.Window
		Me.Combo1.CausesValidation = True
		Me.Combo1.Enabled = True
		Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Combo1.IntegralHeight = True
		Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Combo1.Sorted = False
		Me.Combo1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.Combo1.TabStop = True
		Me.Combo1.Visible = True
		Me.Combo1.Name = "Combo1"
		Me.Shape1.BorderWidth = 10
		Me.Shape1.Size = New System.Drawing.Size(913, 569)
		Me.Shape1.Location = New System.Drawing.Point(0, 0)
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.Controls.Add(Command1)
        'Me.Controls.Add(MSChart1)
		Me.Controls.Add(Combo1)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.Controls.Add(ShapeContainer1)
        '		CType(Me.MSChart1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class