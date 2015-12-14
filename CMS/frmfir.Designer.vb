<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmfir
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
    Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents id As System.Windows.Forms.TextBox
	Public WithEvents sname As System.Windows.Forms.TextBox
	Public WithEvents crdate As System.Windows.Forms.TextBox
	Public WithEvents crspec As System.Windows.Forms.TextBox
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents ctime As System.Windows.Forms.TextBox
	Public WithEvents Combo16 As System.Windows.Forms.ComboBox
	Public WithEvents Combo3 As System.Windows.Forms.ComboBox
	Public WithEvents Combo2 As System.Windows.Forms.ComboBox
	Public WithEvents Combo1 As System.Windows.Forms.ComboBox
	Public WithEvents occ As System.Windows.Forms.TextBox
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents Line3 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Shape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Line2 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents firno As System.Windows.Forms.Label
	Public WithEvents ftime As System.Windows.Forms.Label
	Public WithEvents fdate As System.Windows.Forms.Label
	Public WithEvents Label1 As System.Windows.Forms.Label
	Public WithEvents Line1 As Microsoft.VisualBasic.PowerPacks.LineShape
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents Label2 As System.Windows.Forms.Label
	Public WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmfir))
        Me.ctime = New System.Windows.Forms.TextBox
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.Line3 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.Shape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.Line2 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.Line1 = New Microsoft.VisualBasic.PowerPacks.LineShape
        Me.Command1 = New System.Windows.Forms.Button
        Me.id = New System.Windows.Forms.TextBox
        Me.sname = New System.Windows.Forms.TextBox
        Me.crdate = New System.Windows.Forms.TextBox
        Me.crspec = New System.Windows.Forms.TextBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Combo16 = New System.Windows.Forms.ComboBox
        Me.Combo3 = New System.Windows.Forms.ComboBox
        Me.Combo2 = New System.Windows.Forms.ComboBox
        Me.Combo1 = New System.Windows.Forms.ComboBox
        Me.occ = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.firno = New System.Windows.Forms.Label
        Me.ftime = New System.Windows.Forms.Label
        Me.fdate = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'ctime
        '
        Me.ctime.AcceptsReturn = True
        Me.ctime.BackColor = System.Drawing.SystemColors.Window
        Me.ctime.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.ctime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ctime.ForeColor = System.Drawing.SystemColors.WindowText
        Me.ctime.Location = New System.Drawing.Point(464, 256)
        Me.ctime.MaxLength = 0
        Me.ctime.Name = "ctime"
        Me.ctime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ctime.Size = New System.Drawing.Size(73, 25)
        Me.ctime.TabIndex = 5
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.Line3, Me.Shape1, Me.Line2, Me.Line1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(606, 624)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'Line3
        '
        Me.Line3.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line3.BorderWidth = 2
        Me.Line3.Name = "Line3"
        Me.Line3.X1 = 8
        Me.Line3.X2 = 592
        Me.Line3.Y1 = 48
        Me.Line3.Y2 = 48
        '
        'Shape1
        '
        Me.Shape1.BackColor = System.Drawing.SystemColors.Window
        Me.Shape1.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Shape1.BorderWidth = 10
        Me.Shape1.FillColor = System.Drawing.Color.Black
        Me.Shape1.Location = New System.Drawing.Point(8, 8)
        Me.Shape1.Name = "Shape1"
        Me.Shape1.Size = New System.Drawing.Size(592, 609)
        '
        'Line2
        '
        Me.Line2.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line2.Name = "Line2"
        Me.Line2.X1 = 0
        Me.Line2.X2 = 592
        Me.Line2.Y1 = 96
        Me.Line2.Y2 = 96
        '
        'Line1
        '
        Me.Line1.BorderColor = System.Drawing.SystemColors.WindowText
        Me.Line1.Name = "Line1"
        Me.Line1.X1 = 8
        Me.Line1.X2 = 608
        Me.Line1.Y1 = 400
        Me.Line1.Y2 = 400
        '
        'Command1
        '
        Me.Command1.BackColor = System.Drawing.SystemColors.Control
        Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command1.Location = New System.Drawing.Point(560, 16)
        Me.Command1.Name = "Command1"
        Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command1.Size = New System.Drawing.Size(25, 25)
        Me.Command1.TabIndex = 25
        Me.Command1.Text = "X"
        Me.Command1.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.AcceptsReturn = True
        Me.id.BackColor = System.Drawing.SystemColors.Window
        Me.id.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.id.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.id.ForeColor = System.Drawing.SystemColors.WindowText
        Me.id.Location = New System.Drawing.Point(176, 504)
        Me.id.MaxLength = 50
        Me.id.Multiline = True
        Me.id.Name = "id"
        Me.id.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.id.Size = New System.Drawing.Size(361, 65)
        Me.id.TabIndex = 8
        '
        'sname
        '
        Me.sname.AcceptsReturn = True
        Me.sname.BackColor = System.Drawing.SystemColors.Window
        Me.sname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.sname.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sname.ForeColor = System.Drawing.SystemColors.WindowText
        Me.sname.Location = New System.Drawing.Point(176, 456)
        Me.sname.MaxLength = 20
        Me.sname.Name = "sname"
        Me.sname.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.sname.Size = New System.Drawing.Size(361, 33)
        Me.sname.TabIndex = 7
        '
        'crdate
        '
        Me.crdate.AcceptsReturn = True
        Me.crdate.BackColor = System.Drawing.SystemColors.Window
        Me.crdate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.crdate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crdate.ForeColor = System.Drawing.SystemColors.WindowText
        Me.crdate.Location = New System.Drawing.Point(176, 256)
        Me.crdate.MaxLength = 0
        Me.crdate.Name = "crdate"
        Me.crdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.crdate.Size = New System.Drawing.Size(113, 27)
        Me.crdate.TabIndex = 21
        Me.crdate.Visible = False
        '
        'crspec
        '
        Me.crspec.AcceptsReturn = True
        Me.crspec.BackColor = System.Drawing.SystemColors.Window
        Me.crspec.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.crspec.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.crspec.ForeColor = System.Drawing.SystemColors.WindowText
        Me.crspec.Location = New System.Drawing.Point(176, 152)
        Me.crspec.MaxLength = 100
        Me.crspec.Multiline = True
        Me.crspec.Name = "crspec"
        Me.crspec.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.crspec.Size = New System.Drawing.Size(361, 65)
        Me.crspec.TabIndex = 1
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1000
        '
        'Combo16
        '
        Me.Combo16.BackColor = System.Drawing.SystemColors.Window
        Me.Combo16.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo16.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo16.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo16.Items.AddRange(New Object() {"MURDER", "ROBBERY", "RAPE", "KIDNAPPING", "THEFT", "FRAUD", "EXTORTION", "MOLESTATION", "ILLEGAL POSSESSION", "OTHERS"})
        Me.Combo16.Location = New System.Drawing.Point(176, 112)
        Me.Combo16.Name = "Combo16"
        Me.Combo16.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo16.Size = New System.Drawing.Size(169, 22)
        Me.Combo16.TabIndex = 0
        '
        'Combo3
        '
        Me.Combo3.BackColor = System.Drawing.SystemColors.Window
        Me.Combo3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo3.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo3.Items.AddRange(New Object() {"2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2009", "2010", "2011"})
        Me.Combo3.Location = New System.Drawing.Point(296, 256)
        Me.Combo3.Name = "Combo3"
        Me.Combo3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo3.Size = New System.Drawing.Size(65, 22)
        Me.Combo3.TabIndex = 4
        Me.Combo3.Text = "YYYY"
        '
        'Combo2
        '
        Me.Combo2.BackColor = System.Drawing.SystemColors.Window
        Me.Combo2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo2.Items.AddRange(New Object() {"JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC"})
        Me.Combo2.Location = New System.Drawing.Point(224, 256)
        Me.Combo2.Name = "Combo2"
        Me.Combo2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo2.Size = New System.Drawing.Size(65, 22)
        Me.Combo2.TabIndex = 3
        Me.Combo2.Text = "MM"
        '
        'Combo1
        '
        Me.Combo1.BackColor = System.Drawing.SystemColors.Window
        Me.Combo1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Combo1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Combo1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.Combo1.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.Combo1.Location = New System.Drawing.Point(176, 256)
        Me.Combo1.Name = "Combo1"
        Me.Combo1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Combo1.Size = New System.Drawing.Size(41, 22)
        Me.Combo1.TabIndex = 2
        Me.Combo1.Text = "DD"
        '
        'occ
        '
        Me.occ.AcceptsReturn = True
        Me.occ.BackColor = System.Drawing.SystemColors.Window
        Me.occ.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.occ.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.occ.ForeColor = System.Drawing.SystemColors.WindowText
        Me.occ.Location = New System.Drawing.Point(176, 296)
        Me.occ.MaxLength = 100
        Me.occ.Multiline = True
        Me.occ.Name = "occ"
        Me.occ.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.occ.Size = New System.Drawing.Size(361, 73)
        Me.occ.TabIndex = 6
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label8.Location = New System.Drawing.Point(160, 16)
        Me.Label8.Name = "Label8"
        Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label8.Size = New System.Drawing.Size(265, 17)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "FIRST INFORMATION REPORT"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label7.Location = New System.Drawing.Point(512, 584)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(49, 25)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "NEXT"
        '
        'Label13
        '
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label13.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label13.Location = New System.Drawing.Point(48, 512)
        Me.Label13.Name = "Label13"
        Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label13.Size = New System.Drawing.Size(137, 41)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "IDENTITY MARKS          (if any):"
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label12.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label12.Location = New System.Drawing.Point(64, 456)
        Me.Label12.Name = "Label12"
        Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label12.Size = New System.Drawing.Size(73, 25)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "NAME:"
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label11.Location = New System.Drawing.Point(176, 416)
        Me.Label11.Name = "Label11"
        Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label11.Size = New System.Drawing.Size(209, 25)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "SUSPECT"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label17
        '
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label17.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label17.Location = New System.Drawing.Point(24, 152)
        Me.Label17.Name = "Label17"
        Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label17.Size = New System.Drawing.Size(153, 25)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "CRIME SPECIFICATION : "
        '
        'firno
        '
        Me.firno.BackColor = System.Drawing.Color.White
        Me.firno.Cursor = System.Windows.Forms.Cursors.Default
        Me.firno.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.firno.ForeColor = System.Drawing.SystemColors.ControlText
        Me.firno.Location = New System.Drawing.Point(144, 56)
        Me.firno.Name = "firno"
        Me.firno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.firno.Size = New System.Drawing.Size(81, 25)
        Me.firno.TabIndex = 19
        '
        'ftime
        '
        Me.ftime.BackColor = System.Drawing.SystemColors.Control
        Me.ftime.Cursor = System.Windows.Forms.Cursors.Default
        Me.ftime.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ftime.ForeColor = System.Drawing.SystemColors.ControlText
        Me.ftime.Location = New System.Drawing.Point(472, 56)
        Me.ftime.Name = "ftime"
        Me.ftime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ftime.Size = New System.Drawing.Size(89, 25)
        Me.ftime.TabIndex = 18
        '
        'fdate
        '
        Me.fdate.BackColor = System.Drawing.SystemColors.Control
        Me.fdate.Cursor = System.Windows.Forms.Cursors.Default
        Me.fdate.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fdate.ForeColor = System.Drawing.SystemColors.ControlText
        Me.fdate.Location = New System.Drawing.Point(304, 56)
        Me.fdate.Name = "fdate"
        Me.fdate.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.fdate.Size = New System.Drawing.Size(105, 25)
        Me.fdate.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(40, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label1.Size = New System.Drawing.Size(81, 25)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "FIR NO:"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label10.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label10.Location = New System.Drawing.Point(24, 296)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label10.Size = New System.Drawing.Size(153, 33)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "PLACE OF OCCURANCE:         (Mention full address)"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label9.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label9.Location = New System.Drawing.Point(416, 56)
        Me.Label9.Name = "Label9"
        Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label9.Size = New System.Drawing.Size(49, 25)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "TIME:"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label6.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label6.Location = New System.Drawing.Point(408, 256)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "TIME:"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label5.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label5.Location = New System.Drawing.Point(128, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label5.Size = New System.Drawing.Size(41, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "DATE:"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label4.Location = New System.Drawing.Point(16, 232)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(177, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "OCCURANCE OF OFFENSE:"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(88, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(73, 17)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "CRIME:"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label2.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label2.Location = New System.Drawing.Point(256, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label2.Size = New System.Drawing.Size(41, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "DATE:"
        '
        'frmfir
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(606, 624)
        Me.Controls.Add(Me.Command1)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.sname)
        Me.Controls.Add(Me.crdate)
        Me.Controls.Add(Me.crspec)
        Me.Controls.Add(Me.ctime)
        Me.Controls.Add(Me.Combo16)
        Me.Controls.Add(Me.Combo3)
        Me.Controls.Add(Me.Combo2)
        Me.Controls.Add(Me.Combo1)
        Me.Controls.Add(Me.occ)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.firno)
        Me.Controls.Add(Me.ftime)
        Me.Controls.Add(Me.fdate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Location = New System.Drawing.Point(291, 74)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmfir"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.ResumeLayout(False)

    End Sub
#End Region 
End Class