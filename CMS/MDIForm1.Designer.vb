<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class MDIForm1
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
	Public WithEvents logout As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents info As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents exit_Renamed As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents _StatusBar1_Panel1 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents _StatusBar1_Panel2 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents _StatusBar1_Panel3 As System.Windows.Forms.ToolStripStatusLabel
	Public WithEvents StatusBar1 As System.Windows.Forms.StatusStrip
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(MDIForm1))
		Me.IsMDIContainer = True
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.logout = New System.Windows.Forms.ToolStripMenuItem
		Me.info = New System.Windows.Forms.ToolStripMenuItem
		Me.exit_Renamed = New System.Windows.Forms.ToolStripMenuItem
		Me.StatusBar1 = New System.Windows.Forms.StatusStrip
		Me._StatusBar1_Panel1 = New System.Windows.Forms.ToolStripStatusLabel
		Me._StatusBar1_Panel2 = New System.Windows.Forms.ToolStripStatusLabel
		Me._StatusBar1_Panel3 = New System.Windows.Forms.ToolStripStatusLabel
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me.MainMenu1.SuspendLayout()
		Me.StatusBar1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.SystemColors.AppWorkspace
		Me.Text = "                                                                              CRIME   MONITORING   SYSTEM"
		Me.ClientSize = New System.Drawing.Size(312, 231)
		Me.Location = New System.Drawing.Point(484, 182)
		Me.Icon = CType(resources.GetObject("MDIForm1.Icon"), System.Drawing.Icon)
		Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
		Me.Enabled = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Name = "MDIForm1"
		Me.logout.Name = "logout"
		Me.logout.Text = "&LOGOUT"
		Me.logout.Checked = False
		Me.logout.Enabled = True
		Me.logout.Visible = True
		Me.info.Name = "info"
		Me.info.Text = "&INFO"
		Me.info.Checked = False
		Me.info.Enabled = True
		Me.info.Visible = True
		Me.exit_Renamed.Name = "exit"
		Me.exit_Renamed.Text = "&EXIT"
		Me.exit_Renamed.Checked = False
		Me.exit_Renamed.Enabled = True
		Me.exit_Renamed.Visible = True
		Me.StatusBar1.Dock = System.Windows.Forms.DockStyle.Bottom
		Me.StatusBar1.Size = New System.Drawing.Size(1272, 33)
		Me.StatusBar1.Location = New System.Drawing.Point(0, 738)
		Me.StatusBar1.TabIndex = 0
		Me.StatusBar1.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.StatusBar1.Name = "StatusBar1"
		Me._StatusBar1_Panel1.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._StatusBar1_Panel1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._StatusBar1_Panel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._StatusBar1_Panel1.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._StatusBar1_Panel1.Margin = New System.Windows.Forms.Padding(0)
		Me._StatusBar1_Panel1.Size = New System.Drawing.Size(96, 33)
		Me._StatusBar1_Panel1.AutoSize = False
		Me._StatusBar1_Panel2.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._StatusBar1_Panel2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._StatusBar1_Panel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._StatusBar1_Panel2.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._StatusBar1_Panel2.Margin = New System.Windows.Forms.Padding(0)
		Me._StatusBar1_Panel2.Size = New System.Drawing.Size(96, 33)
		Me._StatusBar1_Panel2.AutoSize = False
		Me._StatusBar1_Panel3.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
		Me._StatusBar1_Panel3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
		Me._StatusBar1_Panel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._StatusBar1_Panel3.BorderSides = CType(System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom, System.Windows.Forms.ToolStripStatusLabelBorderSides)
		Me._StatusBar1_Panel3.Margin = New System.Windows.Forms.Padding(0)
		Me._StatusBar1_Panel3.Size = New System.Drawing.Size(96, 33)
		Me._StatusBar1_Panel3.AutoSize = False
		Me.Timer1.Interval = 800
		Me.Timer1.Enabled = True
		Me.Controls.Add(StatusBar1)
		Me.StatusBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._StatusBar1_Panel1})
		Me.StatusBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._StatusBar1_Panel2})
		Me.StatusBar1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me._StatusBar1_Panel3})
		Me.logout.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.info.MergeAction = System.Windows.Forms.MergeAction.Remove
		Me.exit_Renamed.MergeAction = System.Windows.Forms.MergeAction.Remove
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.logout, Me.info, Me.exit_Renamed})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.StatusBar1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class