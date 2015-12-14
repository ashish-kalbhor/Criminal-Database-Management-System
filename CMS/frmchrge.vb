Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmchrge
	Inherits System.Windows.Forms.Form
	Dim f1, f2 As Object
	Dim f3 As Boolean
	
	
	'UPGRADE_WARNING: Event add_Renamed.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub add_Renamed_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles add_Renamed.TextChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f1 = True
	End Sub
	
	'UPGRADE_WARNING: Event chrgespec.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub chrgespec_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles chrgespec.TextChanged
		'UPGRADE_WARNING: Couldn't resolve default property of object f2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f2 = True
	End Sub
	
	Private Sub frmchrge_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'DataEnvironment1.rsCHARGESHEET.Close
		'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f1 = False
		'UPGRADE_WARNING: Couldn't resolve default property of object f2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		f2 = False
		f3 = False
	End Sub
	
	Private Sub Label11_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label11.Click
		Me.Close()
		If frml1.running = True Then
			frml1.Show()
		ElseIf frml2.running = True Then 
			frml2.Show()
		ElseIf frml3.running = True Then 
			frml3.Show()
		End If
	End Sub
	
	Private Sub Label12_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label12.Click
		Dim i As Object
		Dim f As Short
		Dim conn As ADODB.Connection
		Dim rs As ADODB.Recordset
		
		conn = New ADODB.Connection
		conn.ConnectionString = "Provider = MSDAORA;user id=scott; password=tiger;"
		conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		conn.Open()
		rs = New ADODB.Recordset
		rs.Open("chargesheet", conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		
		For i = 1 To rs.RecordCount
			If rs.Fields("ch_no").Value = Val(chno.Text) Then
				'UPGRADE_WARNING: Couldn't resolve default property of object f1. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If f1 = True Then
					rs.Fields("curr_add").Value = add_Renamed.Text
				End If
				'UPGRADE_WARNING: Couldn't resolve default property of object f2. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If f2 = True Then
					rs.Fields("crime_spec").Value = chrgespec.Text
				End If
				If f3 = True Then
					rs.Fields("offname").Value = off.Text
				End If
				rs.Update()
				rs.Close()
				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				i = MsgBox("CHARGESHEET UPDATED SUCCESSFULLY !!!", MsgBoxStyle.Information) = MsgBoxResult.OK
				Exit For
			End If
		Next i
		
	End Sub
	
	
	
	'UPGRADE_WARNING: Event off.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub off_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles off.TextChanged
		f3 = True
	End Sub
End Class