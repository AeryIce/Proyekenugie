Imports System.Data.SqlClient

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
		Else
			Call Koneksi()
			Cmd = New SqlCommand("SELECT * FROM AdminProyek WHERE NamaAdmin='" & TextBoxUserName.Text & "' and PasswordAdmin='" & TextBoxPassword.Text & "' ", Conn)
			Dr = Cmd.ExecuteReader
			Dr.Read()
			If Dr.HasRows Then
				FormAdmin.Show()
			Else
				Call Koneksi()
				Cmd = New SqlCommand("SELECT * FROM Customer Where NamaUser='" & TextBoxUserName.Text & "' and PasswordUser='" & TextBoxPassword.Text & "' ", Conn)
				Dr = Cmd.ExecuteReader
				Dr.Read()
				If Dr.HasRows Then
					FormUser.Show()
				Else
					MsgBox("Maaf User Tidak Ditemukan")

				End If
			End If


		End If
	End Sub
End Class
