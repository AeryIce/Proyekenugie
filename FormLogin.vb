Public Class FormLogin
	Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click
		Me.Close()


	End Sub

	Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Call Koneksi()
		TextBoxUserName.Focus()
		ButtonLogin.Enabled = False


	End Sub

	Private Sub TextBoxUserName_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxUserName.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxPassword.Focus()
		If TextBoxUserName.Text = "" Then
			ButtonLogin.Enabled = False
		Else
			ButtonLogin.Enabled = True

		End If

	End Sub
	Private Sub TextBoxPassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPassword.KeyPress
		If e.KeyChar = Chr(13) Then ButtonLogin.Focus()

	End Sub

	Private Sub ButtonLogin_Click(sender As Object, e As EventArgs) Handles ButtonLogin.Click
		If TextBoxUserName.Text = "" Or TextBoxPassword.Text = "" Then
			If MsgBox("Data Belum Lengkap, Lanjutkan Login?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				Me.Show()
			Else
				Me.Close()
			End If


		End If
	End Sub
End Class
