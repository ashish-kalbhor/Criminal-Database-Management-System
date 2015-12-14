Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmcat
	Inherits System.Windows.Forms.Form
	Dim c As ADODB.Connection
	Dim r As ADODB.Recordset
	
	Dim id As Short
	Dim m As Short
	
	'UPGRADE_WARNING: Event Combo1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
		
		r.Open("select * from criminal where crime_type='" & Combo1.Text & "'", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
		
		Adodc1.Recordset = r
		Adodc1.Refresh()
		r.Close()
	End Sub
	
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
	
	Private Sub frmcat_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		c = New ADODB.Connection
		r = New ADODB.Recordset
		c.Open("provider = MSDAORA;user id=scott;password=tiger;")
	End Sub
	
	Private Sub MSHFlexGrid1_SelChange(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MSHFlexGrid1.SelChange
		m = MSHFlexGrid1.RowSel
		id = CShort(MSHFlexGrid1.get_TextMatrix(m, 3))
		
		r.Open("criminal", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		
		r.MoveFirst()
		While (r.EOF = False)
			If r.Fields("C_ID").Value = id Then
				frminfo.Show()
				frminfo.Text1.Text = r.Fields("c_id").Value
				frminfo.Text2.Text = r.Fields("cname").Value
				frminfo.Text3.Text = r.Fields("dob").Value
				frminfo.Text4.Text = r.Fields("curr_add").Value
				frminfo.Text5.Text = r.Fields("occ").Value
				frminfo.Text6.Text = r.Fields("crime_type").Value
			End If
			r.MoveNext()
		End While
		r.Close()
	End Sub
End Class