Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmlogin
	Inherits System.Windows.Forms.Form
	Public domain As String
	Public pass As String

    Dim conn As New OleDb.OleDbConnection
    Dim provider As String
    Dim dsource As String
    Dim ds As New DataSet
    Dim ds1 As New DataSet
    Dim da As OleDb.OleDbDataAdapter
    Dim da1 As OleDb.OleDbDataAdapter
    Dim sql As String
    Dim sql1 As String

	Dim i As Short
	Dim flag As Object
	Dim flag2 As Boolean
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		Me.Close()
	End Sub
	
	Private Sub frmlogin_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		If KeyAscii = 27 Then
			Me.Close()
		End If
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmlogin_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        provider = "PROVIDER = Microsoft.Jet.OLEDB.4.0;"
        dsource = "Data Source = D:\C.M.S\cms.mdb"

        conn.ConnectionString = provider & dsource
        conn.Open()
        sql = "SELECT * from Rname"
        sql1 = "SELECT * from Dname"
        da = New OleDb.OleDbDataAdapter(sql, conn)
        da1 = New OleDb.OleDbDataAdapter(sql1, conn)
        da.Fill(ds, "Rname")
        da1.Fill(ds1, "Dname")
        conn.Close()

	End Sub
	
	Private Sub Image2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Image2.Click
		Shape3.Visible = True
		Label3.Visible = True
	End Sub
	
	Private Sub ommand1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles ommand1.Click
		
		flag = False
        Dim cnt As Integer
        cnt = ds.Tables("Rname").Rows.Count

        For i = 0 To cnt - 1        'CHECKING REGIONS
            If (Text1.Text = ds.Tables("Rname").Rows(i).Item(2)) And (Text2.Text = ds.Tables("Rname").Rows(i).Item(3)) Then
                MsgBox("Successful login.!! ")
                frml1.Show()
                Me.Hide()
                GoTo x
            End If
        Next i

        cnt = ds1.Tables("Dname").Rows.Count

        For i = 0 To cnt - 1        ''CHECKIN DISTRICTS
            If (Text1.Text = ds1.Tables("Dname").Rows(i).Item(3)) And (Text2.Text = ds1.Tables("Dname").Rows(i).Item(2)) Then
                MsgBox("Successful login.!! ")
                frml2.Show()
                Me.Hide()
                GoTo x
            End If
        Next i


        If (Text1.Text = "ADMIN") And (Text2.Text = "0000") Then
            MsgBox("Successful login.!! ")
            frml3.Show()
            Me.Hide()
            GoTo x
        End If

        MsgBox("Incorrect Login")
        Text1.Text = ""
        Text2.Text = ""
		
x:
	End Sub
End Class