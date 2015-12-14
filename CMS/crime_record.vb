Option Strict Off
Option Explicit On
Module Module1
	Public conn As ADODB.Connection
	Public crime_rec As ADODB.Recordset
	Public criminal_rec As ADODB.Recordset
	Public district_rec As ADODB.Recordset
	Public region_rec As ADODB.Recordset
	Public fir_rec As ADODB.Recordset
	Public rec1 As ADODB.Recordset
	Public off_rec As ADODB.Recordset
	Public ct As String
	Public suspect_rec As ADODB.Recordset
	Public victim_rec As ADODB.Recordset
	
	Public Sub crime_record(ByRef f As Short)
		Dim strsql As String
		conn = New ADODB.Connection
		conn.ConnectionString = "Provider = MSDAORA;user id=scott; password=tiger;"
		conn.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		conn.Open()
		rec1 = New ADODB.Recordset
		strsql = "select * from crime,suspect,victim,officer,fir where crime.firno = fir.firno AND suspect.s_id = fir.c_id AND victim.v_id = fir.v_id AND officer.o_id = fir.o_id AND fir.firno = " & f
		rec1.Open(strsql, conn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic, ADODB.CommandTypeEnum.adCmdText)
	End Sub
End Module