Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frml3
	Inherits System.Windows.Forms.Form
    'Dim cn1 As ADODB.Connection
	Public running As Boolean
    '	Dim rs1 As ADODB.Recordset
    '	Dim rs2 As Object
    '	Dim rs3 As ADODB.Recordset
    '	Dim r As ADODB.Recordset
	Dim dist As Object
	Dim cr As String
	Dim flag1, flg As Object
	Dim flg1 As Boolean
	Private Const PI As Double = 3.1415926
	Private Const Pi2 As Double = 2 * PI
	Dim id As Object
	Dim m As Short
	Dim ip, fraud, kid, robbery, murder, theft, rape, ext, mol As Object
	Dim others As Short
	
	Private Sub frml3_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 27 Then
			Me.Close()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	'UPGRADE_WARNING: Event Combo1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
        ''UPGRADE_WARNING: Couldn't resolve default property of object dist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dist = Combo1.Text

        ''UPGRADE_WARNING: Couldn't resolve default property of object flg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'flg = True
        'If flg1 = True Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '          'rs1.Open("select ch_no,vname,sname from chargesheet where dname='" & dist & "' and crimetype='" & Combo2.Text & " '", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        'Else
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '          '		rs1.Open("select ch_no,vname,sname from chargesheet where dname='" & dist & "'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        'End If
        '      'Adodc1.Recordset = rs1
        '      'Adodc1.Refresh()
        '      '		rs1.Close()
        DataGridView1.Visible = True
        Dim c As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        sql = "Select ch_no,sname,crimetype from chargesheet where dname='" & Combo1.Text & "'"
        c.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source= D:\C.M.S\cms.mdb"
        da = New OleDb.OleDbDataAdapter(sql, c)
        da.Fill(ds, "chargesheet")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "chargesheet"
	End Sub
	
	'UPGRADE_WARNING: Event Combo2.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Combo2_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo2.SelectedIndexChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object dist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'dist = Combo1.Text
        ''UPGRADE_WARNING: Couldn't resolve default property of object flag1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'flag1 = True

        'MsgBox(cr)
        ''UPGRADE_WARNING: Couldn't resolve default property of object flg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'If flg = True Then
        '	'UPGRADE_WARNING: Couldn't resolve default property of object dist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	'UPGRADE_WARNING: Couldn't resolve default property of object rs2.Open. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '          '			rs2.Open("select ch_no,vname,sname from chargesheet where dname='" & dist & "' and crimetype='" & Combo2.Text & "'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        'Else
        '	'UPGRADE_WARNING: Couldn't resolve default property of object rs2.Open. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '          '			rs2.Open("select ch_no,vname,sname from chargesheet where crimetype='" & cr & "'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        'End If
        '      '		Adodc1.Recordset = rs2
        '      '		Adodc1.Refresh()
        ''UPGRADE_WARNING: Couldn't resolve default property of object rs2.Close. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '      '		rs2.Close()
        DataGridView1.Visible = True
        Dim c As New OleDb.OleDbConnection
        Dim da As OleDb.OleDbDataAdapter
        Dim ds As New DataSet
        Dim sql As String
        sql = "Select CH_NO,SNAME,CRIMETYPE from chargesheet where dname='" & Combo1.Text & "' and crimetype='" & Combo2.Text & "'"
        c.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source= D:\C.M.S\cms.mdb"
        da = New OleDb.OleDbDataAdapter(sql, c)
        da.Fill(ds, "chargesheet")

        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "chargesheet"
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click

        Dim conn As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim cmd As OleDb.OleDbCommand
        Dim sql As String

        sql = "INSERT into dname values ('" & Text1.Text & "'," & Text3.Text & ",'" & Text2.Text & "')"
        conn.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source= D:\C.M.S\cms.mdb"
        conn.Open()

        cmd = New OleDb.OleDbCommand(sql, conn)
        cmd.ExecuteNonQuery()

        MsgBox("REGISTERED SUCCESSFULLY !!!", MsgBoxStyle.Exclamation, "SUCCESS")
        Text1.Text = ""
        Text2.Text = ""
        Text3.Text = ""
        Text4.Text = ""
        Text4.Visible = False
	End Sub

	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
        'Dim i As Object
        'Dim conn As ADODB.Connection
        'Dim rs As ADODB.Recordset

        'conn = New ADODB.Connection
        'rs = New ADODB.Recordset

        'conn.Open("provider=MSDAORA;user id=scott;password=tiger;")
        'conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient

        'rs.Open("select * from district where username='ADMIN'", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)

        'rs.Fields("password").Value = Text5.Text
        ''UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'i = MsgBox("PASSWORD CHANGED SUCCESSFULLY !!! ", MsgBoxStyle.Information) = MsgBoxResult.OK
        'rs.Update()
	End Sub
	
	Private Sub frml3_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim i As Object
		Dim rob As Object
		Dim pcnt As Object
		Dim scnt As Short
		Dim arr(9) As Short

        Dim c As New OleDb.OleDbConnection
        Dim ds As New DataSet
        Dim sql As String

        c.ConnectionString = "PROVIDER=Microsoft.Jet.OLEDB.4.0;Data Source = D:\C.M.S\cms.mdb"
        sql = "SELECT * from dname"
        Dim da As New OleDb.OleDbDataAdapter(sql, c)

        da.Fill(ds, "dname")


        With Combo1
            .DataSource = ds.Tables("dname")
            .DisplayMember = "dname"
            .ValueMember = "dname"
            .SelectedIndex = 0
        End With




        'frml1.running = False
        'frml2.running = False
        'Me.running = True
		
        '		Adodc2.Refresh()
        '		running = True
		'UPGRADE_WARNING: Couldn't resolve default property of object flg. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		flg = False
		flg1 = False
		'UPGRADE_WARNING: Couldn't resolve default property of object flag1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		flag1 = False
		'UPGRADE_WARNING: Couldn't resolve default property of object pcnt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		pcnt = 0
        'cn1 = New ADODB.Connection
        'rs1 = New ADODB.Recordset
        'rs2 = New ADODB.Recordset
        'rs3 = New ADODB.Recordset
		
        '		cn1.Open("Provider=MSDAORA.1;Password=tiger;User ID=SCOTT;Persist Security Info=True")
        '		cn1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		
        '		rs3.Open("select distinct count(firno) from status where stat=0", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object pcnt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		pcnt = rs3.Fields(0).Value
        '		rs3.Close()
		
        'rs3.Open("select distinct count(firno) from status where stat=1 OR stat=2", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        'scnt = rs3.Fields(0).Value
        'rs3.Close()
		'UPGRADE_WARNING: Couldn't resolve default property of object pcnt. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Label24.Text = pcnt
		Label25.Text = CStr(scnt)
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='MURDER'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object murder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		murder = rs3.Fields(0).Value
        '		rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='ROBBERY'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object rob. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		rob = rs3.Fields(0).Value
        '		rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='THEFT'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object theft. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		theft = rs3.Fields(0).Value
        'rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='RAPE'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object rape. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		rape = rs3.Fields(0).Value
        '		rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='KIDNAPPING'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object kid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		kid = rs3.Fields(0).Value
        '		rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='MOLESTATION'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object mol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		mol = rs3.Fields(0).Value
        '		rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='ILLEGAL POSSESSION'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object ip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		ip = rs3.Fields(0).Value
        '		rs3.Close()
		
        'rs3.Open("select count(s_id) from suspect where crimetype='EXTORTION'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object ext. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		ext = rs3.Fields(0).Value
        '		rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='FRAUD'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		'UPGRADE_WARNING: Couldn't resolve default property of object fraud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		fraud = rs3.Fields(0).Value
        '		rs3.Close()
		
        '		rs3.Open("select count(s_id) from suspect where crimetype='OTHERS'", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
        '		others = rs3.Fields(0).Value
        '		rs3.Close()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object murder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l1.Text = murder
		'UPGRADE_WARNING: Couldn't resolve default property of object murder. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(0) = murder
		'UPGRADE_WARNING: Couldn't resolve default property of object rob. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '		l2.Text = rob
		'UPGRADE_WARNING: Couldn't resolve default property of object rob. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(1) = rob
		'UPGRADE_WARNING: Couldn't resolve default property of object rape. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l3.Text = rape
		'UPGRADE_WARNING: Couldn't resolve default property of object rape. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(2) = rape
		'UPGRADE_WARNING: Couldn't resolve default property of object kid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l4.Text = kid
		'UPGRADE_WARNING: Couldn't resolve default property of object kid. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(3) = kid
		'UPGRADE_WARNING: Couldn't resolve default property of object ext. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l5.Text = ext
		'UPGRADE_WARNING: Couldn't resolve default property of object ext. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(4) = ext
		'UPGRADE_WARNING: Couldn't resolve default property of object theft. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l6.Text = theft
		'UPGRADE_WARNING: Couldn't resolve default property of object theft. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(5) = theft
		'UPGRADE_WARNING: Couldn't resolve default property of object ip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l7.Text = ip
		'UPGRADE_WARNING: Couldn't resolve default property of object ip. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(6) = ip
		'UPGRADE_WARNING: Couldn't resolve default property of object mol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l8.Text = mol
		'UPGRADE_WARNING: Couldn't resolve default property of object mol. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(7) = mol
		'UPGRADE_WARNING: Couldn't resolve default property of object fraud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		l9.Text = fraud
		'UPGRADE_WARNING: Couldn't resolve default property of object fraud. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		arr(8) = fraud
		l10.Text = CStr(others)
		arr(9) = others
		
        'MSChart1.RowCount = 1
        'MSChart1.ColumnCount = 10
		
		For i = 1 To 10
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '			MSChart1.Column = i
			'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            '			MSChart1.DataGrid.SetData(1, i, arr(i - 1), False)
		Next i
		
        'For i = 1 To Adodc2.Recordset.RecordCount

        '	Combo1.Items.Add(Adodc2.Recordset.Fields("dname").Value)
        '	Adodc2.Recordset.MoveNext()
        'Next i
	End Sub
	
	Private Sub Label1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label1.Click
		off.Show()
		Me.Close()
	End Sub
	
	Private Sub Label2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label2.Click
		frmcat.Show()
		Me.Close()
	End Sub
	
	
	Private Sub Label3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label3.Click
        'Image4.Visible = False
        '	MSHFlexGrid1.Visible = True
		Combo1.Visible = True
		Combo2.Visible = True
	End Sub
	
	Private Sub Label9_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label9.Click
		Frmgraph.Show()
		Me.Close()
	End Sub
	
    Private Sub MSHFlexGrid1_SelChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim i As Object
        '     m = MSHFlexGrid1.RowSel
        'UPGRADE_WARNING: Couldn't resolve default property of object id. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '    id = MSHFlexGrid1.get_TextMatrix(m, 1)

        '	r = New ADODB.Recordset
        '	r.Open("chargesheet", cn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)

        'For i = 1 To r.RecordCount
        '			If r.Fields("CH_NO").Value = id Then
        frmchrge.Show()
        frmchrge.chno.Enabled = False
        frmchrge.firno.Enabled = False
        frmchrge.cmplnt.Enabled = False
        frmchrge.victim.Enabled = False

        'frmchrge.chno.Text = r.Fields("CH_NO").Value
        'f()rmchrge.firno.Text = r.Fields("FIRNO").Value
        'frmchrge.cmplnt.Text = r.Fields("CPNAME").Value
        'frmchrge.victim.Text = r.Fields("VNAME").Value
        'frmchrge.pstn.Text = r.Fields("RNAME").Value
        'frmchrge.spct.Text = r.Fields("SNAME").Value
        'frmchrge.add_Renamed.Text = r.Fields("CURR_ADD").Value
        'frmchrge.off.Text = r.Fields("OFFNAME").Value
        'frmchrge.crme.Text = r.Fields("CRIMETYPE").Value
        'frmchrge.chrgespec.Text = r.Fields("CRIME_SPEC").Value
        'Else
        'r.MoveNext()
        'End If
        'Next i

        '	r.Close()
    End Sub
	
	'UPGRADE_WARNING: Event Text3.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Text3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text3.TextChanged
		Label26.Visible = True
		Text4.Visible = True
		Command1.Visible = True
	End Sub
	
	'UPGRADE_WARNING: Event Text5.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Text5_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text5.TextChanged
		Label28.Visible = True
		Text6.Visible = True
		Command2.Visible = True
	End Sub

    
    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim n As Integer
        n = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        MsgBox(n)
    End Sub
End Class