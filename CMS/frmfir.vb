Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmfir
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
	
	Private Sub Combo3_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo3.Leave
		'UPGRADE_NOTE: day was upgraded to day_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim day_Renamed, mon As Object
		Dim yr As String
		'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		day_Renamed = Combo1.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object mon. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		mon = Combo2.Text
		yr = Combo3.Text
		'UPGRADE_WARNING: Couldn't resolve default property of object mon. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: Couldn't resolve default property of object day_Renamed. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		crdate.Text = day_Renamed + "/" + mon + "/" + yr
	End Sub
	
	Private Sub frmfir_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Dim table As Object
		Dim adconn As ADODB.Connection
		Dim adrs As ADODB.Recordset
		adconn = New ADODB.Connection
		adconn.ConnectionString = "Provider = MSDAORA;user id=scott; password=tiger;"
		adconn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		adconn.Open()
		
		'UPGRADE_WARNING: Couldn't resolve default property of object table. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		table = "crime"
		adrs = New ADODB.Recordset
		adrs.Open(table, adconn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		
		firno.Text = CStr(adrs.RecordCount + 120)
		'UPGRADE_WARNING: Couldn't resolve default property of object frml1.viewflag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frml1.viewflag = False Then
			fdate.Text = DateString
		End If
	End Sub
	
	Private Sub Label7_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Label7.Click
		If (Me.Combo16.Text = "" Or Me.crdate.Text = "" Or Me.ctime.Text = "" Or Me.crspec.Text = "" Or Me.occ.Text = "") Or (Me.sname.Text = "" And Me.id.Text = "") Then
			
			If Me.Combo16.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF CRIME.")
				Combo16.Focus()
				GoTo A
			End If
			If Me.crspec.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF CRIME.")
				crspec.Focus()
				GoTo A
			End If
			If Me.crdate.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF CRIME.")
				Combo1.Focus()
				GoTo A
			End If
			If Me.ctime.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF CRIME.")
				ctime.Focus()
				GoTo A
			End If
			
			If Me.occ.Text = "" Then
				MsgBox("PLEASE FILL IN ALL DETAILS OF CRIME.")
				occ.Focus()
				GoTo A
			End If
			
			
			If Me.sname.Text = "" And Me.id.Text = "" Then
				MsgBox("FILL IN ATLEAST OF THE TWO, NAME OR IDMARK OF THE SUSPECT.")
				sname.Focus()
				GoTo A
			End If
		Else
			
			frmfir2.Show()
			Me.Visible = False
		End If
A: 
	End Sub
	
	
	Private Sub sname_Leave(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles sname.Leave
		If IsNumeric(sname.Text) Then
			MsgBox("INVALID SUSPECT NAME..!!ENTER SUITABLE DATA.")
			sname.Text = ""
			sname.Focus()
		End If
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		'UPGRADE_WARNING: Couldn't resolve default property of object frml1.viewflag. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If frml1.viewflag = False Then
			ftime.Text = TimeString
		End If
	End Sub
End Class