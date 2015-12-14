Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmfir3
	Inherits System.Windows.Forms.Form
	Dim conn As ADODB.Connection
	Dim rs As ADODB.Recordset
	Dim rs2 As ADODB.Recordset
	Dim rs3 As ADODB.Recordset
	Dim rs4 As ADODB.Recordset
	Dim rs5 As ADODB.Recordset
	Dim ct As String
	Dim table As String
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Close()
		If frml1.running = True Then
			frml1.Show()
		ElseIf frml2.running = True Then 
			frml2.Show()
		ElseIf frml3.running = True Then 
			frml3.Show()
		End If
	End Sub
	
	Private Sub comp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles comp.Click
		Dim dist As Object
		
		If Me.victim.Text = "" Or Me.nat.Text = "" Or Me.uid.Text = "" Then
			If Me.victim.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF VICTIM.")
				victim.Focus()
				GoTo A
			End If
			If Me.uid.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF VICTIM.")
				uid.Focus()
				GoTo A
			End If
			If Me.nat.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF VICTIM.")
				nat.Focus()
				GoTo A
			End If
			
		Else
			
			conn = New ADODB.Connection
			conn.ConnectionString = "Provider = MSDAORA;user id=scott; password=tiger;"
			conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
			conn.Open()
			table = "crime"
			rs = New ADODB.Recordset
			rs5 = New ADODB.Recordset
			rs.Open(table, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			
			rs2 = New ADODB.Recordset
			
			rs5.Open("select dname from region where rname='" & frmlogin.domain & "'", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
			'UPGRADE_WARNING: Couldn't resolve default property of object dist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			dist = rs5.Fields("dname").Value
			rs5.Close()
			
			
			rs2.Open("fir", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			rs2.AddNew()
			
			rs3 = New ADODB.Recordset
			rs3.Open("chargesheet", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			rs3.AddNew()
			
			
			rs4 = New ADODB.Recordset
			rs4.Open("status", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			rs4.AddNew()
			
			rs.AddNew()
			rs.Fields("FIRNO").Value = frmfir.firno.Text
			rs.Fields("CDATE").Value = frmfir.crdate.Text
			rs.Fields("CTIME").Value = frmfir.ctime.Text
			rs.Fields("CRIME_SPEC").Value = frmfir.crspec.Text
			rs.Fields("CRI_ADD").Value = frmfir.occ.Text
			rs.Fields("RNAME").Value = frmlogin.domain
			rs.Fields("ch_no").Value = rs.Fields("FIRNO").Value * 2 + 100
			
			rs2.Fields("FIRNO").Value = rs.Fields("FIRNO").Value
			rs4.Fields("FIRNO").Value = rs.Fields("FIRNO").Value
			rs4.Fields("ch_no").Value = rs.Fields("CH_NO").Value
			
			rs3.Fields("CH_NO").Value = rs.Fields("CH_NO").Value
			rs3.Fields("FIRNO").Value = rs.Fields("FIRNO").Value
			rs3.Fields("RNAME").Value = rs.Fields("RNAME").Value
			rs3.Fields("CRIME_SPEC").Value = rs.Fields("CRIME_SPEC").Value
			'UPGRADE_WARNING: Couldn't resolve default property of object dist. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			rs3.Fields("DNAME").Value = dist
			
			rs.Update()
			rs.Close()
			
			table = "suspect"
			rs.Open(table, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			
			rs.AddNew()
			rs.Fields("FDATE").Value = frmfir.fdate.Text
			rs.Fields("FTIME").Value = frmfir.ftime.Text
			
			If frmfir.sname.Text = "" Then
				rs.Fields("SNAME").Value = "NIL"
			Else
				rs.Fields("SNAME").Value = frmfir.sname.Text
			End If
			
			If frmfir.id.Text = "" Then
				rs.Fields("ID_MARK").Value = "NIL"
			Else
				rs.Fields("ID_MARK").Value = frmfir.id.Text
			End If
			
			rs.Fields("S_ID").Value = rs.RecordCount + 200
			rs.Fields("CRIMETYPE").Value = frmfir.Combo16.Text
			rs.Fields("status").Value = 0
			rs2.Fields("C_ID").Value = rs.Fields("S_ID").Value
			rs2.Fields("FDATE").Value = rs.Fields("FDATE").Value
			rs2.Fields("FTIME").Value = rs.Fields("FTIME").Value
			rs4.Fields("C_ID").Value = rs.Fields("S_ID").Value
			
			
			rs3.Fields("SNAME").Value = rs.Fields("SNAME").Value
			rs3.Fields("CRIMETYPE").Value = rs.Fields("CRIMETYPE").Value
			rs4.Fields("cname").Value = rs.Fields("SNAME").Value
			rs4.Fields("stat").Value = 0
			
			rs.Update()
			rs.Close()
			
			table = "complainant"
			rs.Open(table, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			
			rs.AddNew()
			rs.Fields("CPNAME").Value = frmfir2.cmplnt.Text
			rs.Fields("DOB").Value = frmfir2.dob.Text
			rs.Fields("NATIONALITY").Value = frmfir2.nat.Text
			rs.Fields("OCC").Value = frmfir2.occu.Text
			rs.Fields("CP_ID").Value = frmfir2.uid.Text
			rs.Fields("CP_ADD").Value = frmfir2.add_Renamed.Text
			
			rs2.Fields("CP_ID").Value = rs.Fields("CP_ID").Value
			
			rs3.Fields("CPNAME").Value = rs.Fields("CPNAME").Value
			rs3.Fields("CURR_ADD").Value = "NOT KNOWN"
			
			rs.Update()
			rs.Close()
			
			table = "officer"
			rs.Open(table, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			
			rs.AddNew()
			rs.Fields("OFFNAME").Value = frmfir2.offname.Text
			rs.Fields("RANK").Value = frmfir2.rank.Text
			rs.Fields("O_ID").Value = frmfir2.oid.Text
			
			rs2.Fields("O_ID").Value = rs.Fields("O_ID").Value
			
			rs3.Fields("OFFNAME").Value = rs.Fields("OFFNAME").Value
			
			rs.Update()
			rs.Close()
			
			table = "victim"
			rs.Open(table, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
			rs.AddNew()
			rs.Fields("VNAME").Value = Me.victim.Text
			rs.Fields("VNATIONALITY").Value = Me.nat.Text
			rs.Fields("V_ID").Value = Me.uid.Text
			
			rs2.Fields("V_ID").Value = rs.Fields("V_ID").Value
			rs2.Fields("RNAME").Value = frmlogin.domain
			
			rs3.Fields("VNAME").Value = rs.Fields("VNAME").Value
			
			rs.Update()
			
			rs4.Update()
			rs3.Update()
			rs2.Update()
			rs.Close()
			rs2.Close()
			rs3.Close()
			
			MsgBox("FIR lodged SUCCESSFULLY..!!")
			frml1.Show()
			Me.Close()
		End If
A: 
	End Sub
	
	Private Sub Label5_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label5.Click
		If frml2.running = False Then
			frml1.Show()
			frml1.Label1.Visible = False
			frml1.Text1.Visible = False
			frml1.Label4.Visible = False
		End If
		Me.Close()
	End Sub
	
	Private Sub Label6_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label6.Click
		frmfir2.Show()
		Me.Visible = False
	End Sub
	
	
	
	Private Sub uid_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles uid.Leave
		If Not IsNumeric(uid.Text) Then
			MsgBox("INCORRECT UID, NOTE: UID IS A NUMBER..!!")
			uid.Text = ""
			uid.Focus()
		End If
		
	End Sub
	
	Private Sub victim_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles victim.Leave
		If IsNumeric(victim.Text) Then
			MsgBox("INVALID VICTIM NAME..!!ENTER SUITABLE DATA.")
			victim.Text = ""
			victim.Focus()
		End If
		
	End Sub
End Class