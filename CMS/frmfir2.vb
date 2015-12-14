Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmfir2
	Inherits System.Windows.Forms.Form
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
	
	Private Sub cmplnt_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmplnt.Leave
		If IsNumeric(cmplnt.Text) Then
			MsgBox("INVALID COMPLAINANT NAME..!!ENTER SUITABLE DATA.")
			cmplnt.Text = ""
			cmplnt.Focus()
		End If
	End Sub
	
	Private Sub Combo4_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo4.Leave
		'UPGRADE_NOTE: day was upgraded to day_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim day_Renamed, mon As Object
		Dim yr As String
		'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		day_Renamed = Combo6.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object mon. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mon = Combo5.Text
		yr = Combo4.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object mon. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		dob.Text = day_Renamed + "/" + mon + "/" + yr
	End Sub
	
	Private Sub Label1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label1.Click
		If (Me.cmplnt.Text = "" Or Me.dob.Text = "" Or Me.nat.Text = "" Or Me.occu.Text = "" Or Me.uid.Text = "" Or Me.add_Renamed.Text = "" Or Me.offname.Text = "" Or Me.rank.Text = "" Or Me.oid.Text = "") Then
			If Me.cmplnt.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF COMPLAINANT.")
				cmplnt.Focus()
				GoTo A
			End If
			If Me.dob.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF COMPLAINANT.")
				Combo6.Focus()
				GoTo A
			End If
			If Me.nat.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF COMPLAINANT.")
				nat.Focus()
				GoTo A
			End If
			If Me.occu.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF COMPLAINANT.")
				occu.Focus()
				GoTo A
			End If
			If Me.uid.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF COMPLAINANT.")
				uid.Focus()
				GoTo A
			End If
			If Me.add_Renamed.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF COMPLAINANT.")
				add_Renamed.Focus()
				GoTo A
			End If
			
			If Me.offname.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF OFFICER.")
				offname.Focus()
				GoTo A
			End If
			If Me.rank.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF OFFICER.")
				rank.Focus()
				GoTo A
			End If
			If Me.oid.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF OFFICER.")
				oid.Focus()
				GoTo A
			End If
		Else
			frmfir3.Show()
			Me.Visible = False
		End If
A: 
	End Sub
	
	Private Sub Label3_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label3.Click
		frmfir.Show()
		Me.Visible = False
	End Sub
	
	'UPGRADE_WARNING: Event offname.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub offname_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles offname.TextChanged
		If IsNumeric(offname.Text) Then
			MsgBox("INVALID OFFICER NAME..!!ENTER SUITABLE DATA.")
			offname.Text = ""
			offname.Focus()
		End If
		
	End Sub
	
	'UPGRADE_WARNING: Event oid.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub oid_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles oid.TextChanged
		If Not IsNumeric(oid.Text) Then
			MsgBox("INCORRECT OFF_ID, NOTE: UID IS A NUMBER..!!")
			oid.Text = ""
			oid.Focus()
		End If
		
	End Sub
	
	Private Sub uid_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles uid.Leave
		If Not IsNumeric(uid.Text) Then
			MsgBox("INCORRECT UID, NOTE: UID IS A NUMBER..!!")
			uid.Focus()
		End If
	End Sub
End Class