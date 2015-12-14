Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frminfo
	Inherits System.Windows.Forms.Form
	Dim c As ADODB.Connection
	Dim r As ADODB.Recordset
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		r.Open("select * from criminal where c_id=" & Text1.Text, c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		
		r.Fields("curr_add").Value = Text4.Text
		r.Fields("occ").Value = Text5.Text
		r.Update()
		r.Close()
		MsgBox("RECORD UPDATED SUCCESSFULLY !!!")
	End Sub
	
	Private Sub Command2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command2.Click
		Me.Close()
	End Sub
	
	Private Sub frminfo_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		c = New ADODB.Connection
		r = New ADODB.Recordset
		c.Open("provider=MSDAORA;user id=scott;password=tiger;")
		c.CursorLocation = ADODB.CursorLocationEnum.adUseClient
	End Sub
	
	'UPGRADE_WARNING: Event Text3.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Text3_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text3.TextChanged
		Command1.Visible = True
	End Sub
	
	'UPGRADE_WARNING: Event Text4.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Text4_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text4.TextChanged
		Command1.Visible = True
	End Sub
	
	'UPGRADE_WARNING: Event Text5.TextChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Text5_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Text5.TextChanged
		Command1.Visible = True
	End Sub
End Class