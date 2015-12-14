Option Strict Off
Option Explicit On
Imports Microsoft.VisualBasic.PowerPacks
Friend Class frmSplash
	Inherits System.Windows.Forms.Form
	Dim f As Boolean
	
	Private Sub frmSplash_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Me.Close()
        'frmlogin.Show()
        frml3.Show()
        eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub frmSplash_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		f = False
	End Sub
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		If VB6.PixelsToTwipsX(Shape1.Width) < 9615 Then
			Shape1.Width = VB6.TwipsToPixelsX(VB6.PixelsToTwipsX(Shape1.Width) + 45)
		Else
			f = True
		End If
		If f = True Then
			frmlogin.Show()
			Me.Close()
		End If
	End Sub
End Class