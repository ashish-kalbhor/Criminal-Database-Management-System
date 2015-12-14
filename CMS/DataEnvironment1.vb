Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.Compatibility

Module DataEnvironment_DataEnvironment1_Module
	Friend DataEnvironment1 As DataEnvironment_DataEnvironment1 = New DataEnvironment_DataEnvironment1()
End Module

Friend Class DataEnvironment_DataEnvironment1
	Inherits VB6.BaseDataEnvironment
	Public WithEvents Connection1 As ADODB.Connection
	Public WithEvents rsCHARGESHEET As ADODB.Recordset
	Private m_CHARGESHEET As ADODB.Command
	Public Sub New()
		MyBase.New()
		Dim par As ADODB.Parameter
		
		
		Connection1 = New ADODB.Connection()
		Connection1.ConnectionString = "Provider=MSDAORA.1;Password=tiger;User ID=scott;Persist Security Info=True;"
		m_Connections.Add(Connection1, "Connection1")
		m_CHARGESHEET = New ADODB.Command()
		rsCHARGESHEET = New ADODB.Recordset()
		m_CHARGESHEET.Name = "CHARGESHEET"
		m_CHARGESHEET.CommandText = """SCOTT"".""CHARGESHEET"""
		m_CHARGESHEET.CommandType = ADODB.CommandTypeEnum.adCmdTable
		rsCHARGESHEET.CursorLocation = ADODB.CursorLocationEnum.adUseClient
		rsCHARGESHEET.CursorType = ADODB.CursorTypeEnum.adOpenStatic
		rsCHARGESHEET.LockType = ADODB.LockTypeEnum.adLockReadOnly
		rsCHARGESHEET.Source = m_CHARGESHEET
		m_Commands.Add(m_CHARGESHEET, "CHARGESHEET")
		m_Recordsets.Add(rsCHARGESHEET, "CHARGESHEET")
	End Sub
	Public Sub CHARGESHEET()
		If Connection1.State = ADODB.ObjectStateEnum.adStateClosed Then
			Connection1.Open()
		End If
		If rsCHARGESHEET.State = ADODB.ObjectStateEnum.adStateOpen Then
			rsCHARGESHEET.Close()
		End If
		m_CHARGESHEET.ActiveConnection = Connection1
		rsCHARGESHEET.Open()
	End Sub
End Class