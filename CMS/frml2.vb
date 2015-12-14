Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frml2
	Inherits System.Windows.Forms.Form
	Public running As Boolean
	Private Sub Command4_Click()
	End Sub
	
	Private Sub frml2_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 27 Then
			Me.Close()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Dim flag As Object
		Dim i As Object
		Dim f As Short
		Dim conn1 As ADODB.Connection
		Dim rs1 As ADODB.Recordset
		
		conn1 = New ADODB.Connection
		conn1.ConnectionString = "Provider = MSDAORA;user id=scott; password=tiger;"
		conn1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		conn1.Open()
		rs1 = New ADODB.Recordset
		rs1.Open("chargesheet", conn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		
		frmchrge.chno.Enabled = False
		frmchrge.firno.Enabled = False
		frmchrge.cmplnt.Enabled = False
		frmchrge.victim.Enabled = False
		
		f = Val(Text2.Text)
		For i = 1 To rs1.RecordCount
			If (rs1.Fields("CH_NO").Value = f) Then
				frmchrge.Show()
				frmchrge.chno.Text = rs1.Fields("CH_NO").Value
				frmchrge.firno.Text = rs1.Fields("FIRNO").Value
				frmchrge.cmplnt.Text = rs1.Fields("CPNAME").Value
				frmchrge.victim.Text = rs1.Fields("VNAME").Value
				frmchrge.pstn.Text = rs1.Fields("RNAME").Value
				frmchrge.spct.Text = rs1.Fields("SNAME").Value
				frmchrge.add_Renamed.Text = rs1.Fields("CURR_ADD").Value
				frmchrge.off.Text = rs1.Fields("OFFNAME").Value
				frmchrge.crme.Text = rs1.Fields("CRIMETYPE").Value
				frmchrge.chrgespec.Text = rs1.Fields("CRIME_SPEC").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object flag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flag = True
				Me.Close()
			Else
				rs1.MoveNext()
			End If
		Next i
		
		'UPGRADE_WARNING: Couldn't resolve default property of object flag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If flag = False Then
			MsgBox("SORRY... RECORD NOT FOUND")
			Text2.Text = ""
		End If
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Dim i As Object
		Dim conn As ADODB.Connection
		Dim flg As Boolean
		Dim rs As ADODB.Recordset
		Dim f As Short
		running = True
		conn = New ADODB.Connection
		conn.ConnectionString = "Provider = MSDAORA;user id=scott; password=tiger;"
		conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		conn.Open()
		
		conn.Execute("create view fir_vw2 as select fir.firno,fir.fdate,fir.ftime,fir.cp_id,fir.v_id,fir.o_id,fir.rname,crime.cdate,crime.ctime,crime.ch_no,crime.crime_spec,crime.cri_add,suspect.sname,suspect.id_mark,complainant.cpname,complainant.dob,complainant.nationality,complainant.occ,complainant.cp_add,officer.offname,officer.rank,victim.vname,victim.vnationality from fir,crime,suspect,complainant,officer,victim where fir.firno = crime.firno and fir.c_id = suspect.s_id and fir.v_id = victim.v_id and fir.o_id = officer.o_id and fir.rname='" & frmlogin.domain & "'")
		f = CShort(Text1.Text)
		
		rs = New ADODB.Recordset
		rs.Open("fir_vw2", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		
		For i = 1 To rs.RecordCount
			If (rs.Fields("FIRNO").Value = Val(CStr(f))) Then
				frmfir.Show()
				frmfir.firno.Enabled = False
				frmfir.fdate.Enabled = False
				frmfir.ftime.Enabled = False
				frmfir.Combo16.Enabled = False
				frmfir.crspec.Enabled = False
				frmfir.crdate.Enabled = False
				frmfir.crdate.Visible = True
				frmfir.Combo1.Visible = False
				frmfir.Combo2.Visible = False
				frmfir.Combo3.Visible = False
				frmfir.ctime.Enabled = False
				frmfir.occ.Enabled = False
				frmfir.sname.Enabled = False
				frmfir.id.Enabled = False
				
				frmfir.firno.Text = rs.Fields("FIRNO").Value
				frmfir.fdate.Text = rs.Fields("FDATE").Value
				frmfir.ftime.Text = rs.Fields("FTIME").Value
				frmfir.Combo16.Text = rs.Fields("CRIMETYPE").Value
				frmfir.crspec.Text = rs.Fields("CRIME_SPEC").Value
				frmfir.crdate.Text = rs.Fields("CDATE").Value
				frmfir.ctime.Text = rs.Fields("CTIME").Value
				frmfir.occ.Text = rs.Fields("OCC").Value
				frmfir.sname.Text = rs.Fields("SNAME").Value
				frmfir.id.Text = rs.Fields("ID_MARK").Value
				
				frmfir2.cmplnt.Enabled = False
				frmfir2.dob.Enabled = False
				frmfir2.nat.Enabled = False
				frmfir2.occu.Enabled = False
				frmfir2.uid.Enabled = False
				frmfir2.offname.Enabled = False
				frmfir2.rank.Enabled = False
				frmfir2.oid.Enabled = False
				
				frmfir2.cmplnt.Text = rs.Fields("CPNAME").Value
				frmfir2.dob.Text = rs.Fields("DOB").Value
				frmfir2.nat.Text = rs.Fields("NATIONALITY").Value
				frmfir2.occu.Text = rs.Fields("OCC").Value
				frmfir2.uid.Text = rs.Fields("CP_ID").Value
				frmfir2.add_Renamed.Text = rs.Fields("CP_ADD").Value
				frmfir2.offname.Text = rs.Fields("OFFNAME").Value
				frmfir2.rank.Text = rs.Fields("RANK").Value
				frmfir2.oid.Text = rs.Fields("O_ID").Value
				
				frmfir3.victim.Enabled = False
				frmfir3.nat.Enabled = False
				frmfir3.uid.Enabled = False
				frmfir3.comp.Visible = False
				frmfir3.Label5.Visible = True
				
				frmfir3.victim.Text = rs.Fields("VNAME").Value
				frmfir3.nat.Text = rs.Fields("VNATIONALITY").Value
				frmfir3.uid.Text = rs.Fields("V_ID").Value
				flg = True
			Else
				rs.MoveNext()
			End If
			
		Next i
		
		If flg = False Then
			MsgBox("SORRY.. RECORD NOT FOUND !!")
		End If
		
		conn.Execute("drop view fir_vw2")
		
	End Sub
	
	Private Sub Command3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command3.Click
		Dim Text3 As Object
		Dim flag As Object
		Dim i As Object
		Dim f As Short
		Dim conn1 As ADODB.Connection
		Dim rs1 As ADODB.Recordset
		
		conn1 = New ADODB.Connection
		conn1.ConnectionString = "Provider = MSDAORA;user id=scott; password=tiger;"
		conn1.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		conn1.Open()
		rs1 = New ADODB.Recordset
		rs1.Open("chargesheet", conn1, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		
		f = Val(Text6.Text)
		For i = 1 To rs1.RecordCount
			If (rs1.Fields("CH_NO").Value = f) Then
				frmchrge.Show()
				frmchrge.chno.Text = rs1.Fields("CH_NO").Value
				frmchrge.firno.Text = rs1.Fields("FIRNO").Value
				frmchrge.cmplnt.Text = rs1.Fields("CPNAME").Value
				frmchrge.victim.Text = rs1.Fields("VNAME").Value
				frmchrge.pstn.Text = rs1.Fields("RNAME").Value
				frmchrge.spct.Text = rs1.Fields("SNAME").Value
				frmchrge.add_Renamed.Text = rs1.Fields("CURR_ADD").Value
				frmchrge.off.Text = rs1.Fields("OFFNAME").Value
				frmchrge.crme.Text = rs1.Fields("CRIMETYPE").Value
				frmchrge.chrgespec.Text = rs1.Fields("CRIME_SPEC").Value
				'UPGRADE_WARNING: Couldn't resolve default property of object flag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				flag = True
				frmchrge.add_Renamed.Enabled = True
				frmchrge.chrgespec.Enabled = True
				frmchrge.off.Enabled = True
				frmchrge.Label12.Visible = True
				Me.Close()
			Else
				rs1.MoveNext()
			End If
		Next i
		
		'UPGRADE_WARNING: Couldn't resolve default property of object flag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If flag = False Then
			MsgBox("SORRY... RECORD NOT FOUND")
			Text2.Text = ""
			'UPGRADE_WARNING: Couldn't resolve default property of object Text3.Text. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			Text3.Text = ""
		End If
	End Sub
	
	Private Sub frml2_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		frml1.running = False
		Me.running = True
        'frml3.running = False
	End Sub
	
	Private Sub Label1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label1.Click
		Label2.Visible = True
		Text1.Visible = True
		Command2.Visible = True
	End Sub
	
	Private Sub Label10_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label10.Click
		Dim c As ADODB.Connection
		Dim r As ADODB.Recordset
		
		c = New ADODB.Connection
		c.ConnectionString = "provider=MSDAORA;user id=scott;password = tiger;"
		c.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		c.Open()
		
		r = New ADODB.Recordset
		r.Open("region", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		If pwd.Text = cpwd.Text Then
			r.AddNew()
			r.Fields("rname").Value = region_Renamed.Text
			r.Fields("dname").Value = frmlogin.domain
			r.Fields("username").Value = user.Text
			r.Fields("password").Value = pwd.Text
			r.Update()
			MsgBox("AREA REGISTERED SUCCESSFULLY !!!!!!")
			Me.Close()
			Me.Show()
		End If
		MsgBox("PLEASE RE-ENTER VALUES...")
		Me.Close()
		Me.Show()
	End Sub
	
	Private Sub Label17_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label17.Click
		Dim DataReport1 As Object
		'UPGRADE_WARNING: Couldn't resolve default property of object DataReport1.Show. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DataReport1.Show()
	End Sub
	
	Private Sub Label3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label3.Click
		Text2.Visible = True
		Label4.Visible = True
		Command1.Visible = True
	End Sub
	
	Private Sub Label5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label5.Click
		frmcat.Show()
		Me.Close()
	End Sub
	
	'UPGRADE_WARNING: Event pwd.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub pwd_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles pwd.TextChanged
		cpwd.Visible = True
		Label15.Visible = True
		Label10.Visible = True
	End Sub
End Class