Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class Frmgraph
	Inherits System.Windows.Forms.Form
	Dim c As ADODB.Connection
	Dim r As ADODB.Recordset
	Dim r1 As ADODB.Recordset
	
	'UPGRADE_WARNING: Event Combo1.SelectedIndexChanged may fire when form is initialized. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub Combo1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Combo1.SelectedIndexChanged
		Dim i As Object
		
		r1.Open("district", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdTable)
		
        'MSChart1.Visible = True
		
		If Combo1.Text = "MURDER" Then
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='MURDER' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            '			MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo A
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
A: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.Row = i
                    '					MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "ROBBERY" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='ROBBERY' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            '			MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo b
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
b: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '			MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "RAPE" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='RAPE' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo c
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '	MSChart1.Row = i
                    '	MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
c: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '	MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "KIDNAPPING" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='KIDNAPPING' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo d
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '	MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
d: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.Row = i
                    '				MSChart1.RowLabel = r1.Fields("dname").Value
                    '				'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "EXTORTION" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='EXTORTION' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo e
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.Row = i
                    '				MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
                Else
e:                  'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '    MSChart1.Row = i
                    '   MSChart1.RowLabel = r1.Fields("dname").Value
                    'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '  MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "FRAUD" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='FRAUD' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo f
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.Row = i
                    '				MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
f: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.Row = i
                    '					MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.DataGrid.SetData(i, 1, 0, False)
                    '					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "MOLESTATION" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='MOLESTATION' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo g
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '			MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
g: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "ILLEGAL POSSESSION" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='ILLEGAL POSSESSION' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo h
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.Row = i
                    '				MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
h: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.Row = i
                    '					MSChart1.RowLabel = r1.Fields("dname").Value
                    '					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "THEFT" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='THEFT' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo i
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '	MSChart1.Row = i
                    '	MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '				MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
i: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.Row = i
                    '					MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    '					MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		ElseIf Combo1.Text = "OTHERS" Then 
			r.Open("select dname,count(ch_no) from chargesheet where crimetype='OTHERS' group by dname", c, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
            'MSChart1.RowCount = r1.RecordCount
			For i = 1 To r1.RecordCount
				If r.EOF = True Then
					GoTo j
				End If
				If r.Fields("dname").Value = r1.Fields("dname").Value Then
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.DataGrid.SetData(i, 1, r.Fields("count(ch_no)").Value, False)
				Else
j: 'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.Row = i
                    'MSChart1.RowLabel = r1.Fields("dname").Value
					'UPGRADE_WARNING: Couldn't resolve default property of object i. Click for more: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                    'MSChart1.DataGrid.SetData(i, 1, 0, False)
					
				End If
				r1.MoveNext()
			Next i
			r.Close()
		End If
		r1.Close()
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		frml3.Show()
		Me.Close()
	End Sub
	
	Private Sub Frmgraph_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        'c = New ADODB.Connection
        'r = New ADODB.Recordset
        'r1 = New ADODB.Recordset
		
        '		c.Open("provider=MSDAORA;user id=scott;password=tiger;")
        '		c.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		
		
	End Sub
End Class