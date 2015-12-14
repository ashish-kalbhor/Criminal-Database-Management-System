Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class off
	Inherits System.Windows.Forms.Form
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		If frml3.running = True Then
			frml3.Show()
		Else
			frml1.Show()
		End If
		Me.Close()
	End Sub
End Class