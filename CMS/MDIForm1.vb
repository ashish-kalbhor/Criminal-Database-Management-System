Option Strict Off
Option Explicit On
Friend Class MDIForm1
	Inherits System.Windows.Forms.Form
	Dim f As Boolean
	
	Public Sub exit_Renamed_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles exit_Renamed.Click
		End
	End Sub
	
	Public Sub info_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles info.Click
		frmu.Show()
	End Sub
	
	Public Sub logout_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles logout.Click
		If logout.Text = "LOGIN" Then
			frmlogin.Show()
		ElseIf MsgBox("ARE YOU SURE TO LOGOUT ?", MsgBoxStyle.OKCancel) = MsgBoxResult.OK Then 
			logout.Text = "LOGIN"
		End If
		
	End Sub
	
	Private Sub MDIForm1_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		'UPGRADE_WARNING: Lower bound of collection StatusBar1.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		StatusBar1.Items.Item(1).Text = DateString
		f = False
		frmlogin.pass = ""
	End Sub
	
	'UPGRADE_ISSUE: Form event MDIForm.MouseDown was not upgraded. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="ABD9AF39-7E24-4AFF-AD8D-3675C1AA3054"'
	Private Sub MDIForm_MouseDown(ByRef Button As Short, ByRef Shift As Short, ByRef X As Single, ByRef Y As Single)
		Me.Show()
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		
		If f = False Then
			frmSplash.Show()
			f = True
		End If
		'UPGRADE_WARNING: Lower bound of collection StatusBar1.Panels has changed from 1 to 0. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A3B628A0-A810-4AE2-BFA2-9E7A29EB9AD0"'
		StatusBar1.Items.Item(2).Text = TimeString
	End Sub
End Class