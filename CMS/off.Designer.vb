<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class off
#Region "Windows Form Designer generated code "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'This call is required by the Windows Form Designer.
		InitializeComponent()
		VB6_AddADODataBinding()
	End Sub
	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			VB6_RemoveADODataBinding()
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents MSHFlexGrid1 As AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
	Public WithEvents Adodc1 As VB6.ADODC
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(off))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
		Me.MSHFlexGrid1 = New AxMSHierarchicalFlexGridLib.AxMSHFlexGrid
		Me.Adodc1 = New VB6.ADODC
		Me.Command1 = New System.Windows.Forms.Button
		Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me.MSHFlexGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
		Me.Text = "Form1"
		Me.ClientSize = New System.Drawing.Size(368, 424)
		Me.Location = New System.Drawing.Point(364, 119)
		Me.MaximizeBox = False
		Me.MinimizeBox = False
		Me.ShowInTaskbar = False
		Me.Font = New System.Drawing.Font("Arial", 8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "off"
		MSHFlexGrid1.OcxState = CType(resources.GetObject("MSHFlexGrid1.OcxState"), System.Windows.Forms.AxHost.State)
		Me.MSHFlexGrid1.Size = New System.Drawing.Size(337, 377)
		Me.MSHFlexGrid1.Location = New System.Drawing.Point(16, 32)
		Me.MSHFlexGrid1.TabIndex = 1
		Me.MSHFlexGrid1.Name = "MSHFlexGrid1"
		Me.Adodc1.Size = New System.Drawing.Size(137, 22)
		Me.Adodc1.Location = New System.Drawing.Point(16, 8)
		Me.Adodc1.Visible = 0
		Me.Adodc1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		Me.Adodc1.ConnectionTimeout = 15
		Me.Adodc1.CommandTimeout = 30
		Me.Adodc1.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		Me.Adodc1.LockType = ADODB.LockTypeEnum.adLockOptimistic
		Me.Adodc1.CommandType = ADODB.CommandTypeEnum.adCmdTable
		Me.Adodc1.CacheSize = 50
		Me.Adodc1.MaxRecords = 0
		Me.Adodc1.BOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.BOFActionEnum.adDoMoveFirst
		Me.Adodc1.EOFAction = Microsoft.VisualBasic.Compatibility.VB6.ADODC.EOFActionEnum.adDoMoveLast
		Me.Adodc1.BackColor = System.Drawing.SystemColors.Window
		Me.Adodc1.ForeColor = System.Drawing.SystemColors.WindowText
		Me.Adodc1.Orientation = Microsoft.VisualBasic.Compatibility.VB6.ADODC.OrientationEnum.adHorizontal
		Me.Adodc1.Enabled = True
		Me.Adodc1.UserName = "scott"
		Me.Adodc1.RecordSource = "OFFICER"
		Me.Adodc1.Text = "Adodc1"
		Me.Adodc1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Adodc1.ConnectionString = "Provider=MSDAORA.1;Password=tiger;User ID=scott;Persist Security Info=True"
		Me.Adodc1.Name = "Adodc1"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.Text = "X"
		Me.Command1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(41, 25)
		Me.Command1.Location = New System.Drawing.Point(312, 8)
		Me.Command1.TabIndex = 0
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.Shape1.BorderWidth = 10
		Me.Shape1.Size = New System.Drawing.Size(353, 417)
		Me.Shape1.Location = New System.Drawing.Point(8, 0)
		Me.Shape1.BackColor = System.Drawing.SystemColors.Window
		Me.Shape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Transparent
		Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
		Me.Shape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid
		Me.Shape1.FillColor = System.Drawing.Color.Black
		Me.Shape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Transparent
		Me.Shape1.Visible = True
		Me.Shape1.Name = "Shape1"
		Me.Controls.Add(MSHFlexGrid1)
		Me.Controls.Add(Adodc1)
		Me.Controls.Add(Command1)
		Me.ShapeContainer1.Shapes.Add(Shape1)
		Me.Controls.Add(ShapeContainer1)
		CType(Me.MSHFlexGrid1, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
#Region "Upgrade Support"
	Public Sub VB6_AddADODataBinding()
		MSHFlexGrid1.DataSource = CType(Adodc1, msdatasrc.DataSource)
	End Sub
	Public Sub VB6_RemoveADODataBinding()
		MSHFlexGrid1.DataSource = Nothing
	End Sub
#End Region 
End Class