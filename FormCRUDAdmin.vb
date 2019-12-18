Imports System.Data.SqlClient
Public Class FormCRUDAdmin

	Sub Bersihkan()
		TextBoxKodeAdmin.Clear()
		TextBoxNamaAdmin.Clear()
		TextBoxPasswordAdmin.Clear()
	End Sub

	Sub RefreshDGVDatabasAdmin()
		Call Koneksi()
		Da = New SqlDataAdapter("SELECT * from AdminProyek", Conn)
		Ds = New DataSet
		Da.Fill(Ds)
		DGVDatabaseAdmin.DataSource = Ds.Tables(0)
		DGVDatabaseAdmin.ReadOnly = True
	End Sub
	Private Sub FormCRUDAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		Call RefreshDGVDatabasAdmin()
		Call Bersihkan()
		ButtonKeluarBatal.Text = "Keluar"

	End Sub

	Private Sub ButtonKeluarBatal_Click(sender As Object, e As EventArgs) Handles ButtonKeluarBatal.Click
		If ButtonKeluarBatal.Text = "Keluar" Then
			Me.Close()
			FormAdmin.Show()

		Else
			Call Bersihkan()

		End If
	End Sub

	Private Sub ButtonTambah_Click(sender As Object, e As EventArgs) Handles ButtonTambah.Click
		ButtonKeluarBatal.Text = "Batal"

		If TextBoxKodeAdmin.Text = "" Or TextBoxNamaAdmin.Text = "" Or TextBoxPasswordAdmin.Text = "" Then
			If MsgBox("Maaf Data Belum Lengkap, Lengkapi Data?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
				Me.Show()
			Else
				Call Bersihkan()
				ButtonKeluarBatal.Text = "Keluar"
			End If
		Else
			Call Koneksi()
			Cmd = New SqlCommand("SELECT * FROM AdminProyek WHERE KodeAdmin ='" & TextBoxKodeAdmin.Text & "' ", Conn)
			Dr = Cmd.ExecuteReader()
			Dr.Read()
			If Dr.HasRows Then
				If MsgBox("Maaf Kode Admin Sudah Ada, Ganti Kode Admin?", MsgBoxStyle.YesNo, "Konfirmasi") = MsgBoxResult.Yes Then
					TextBoxKodeAdmin.Clear()
				Else
					MsgBox("Operasi Dibatalkan")
					Me.Close()
				End If
			Else
				Call Koneksi()
				Dim Simpan As String = "INSERT INTO AdminProyek VALUES ('" & TextBoxKodeAdmin.Text & "','" & TextBoxNamaAdmin.Text & "','" & TextBoxPasswordAdmin.Text & "')"
				Cmd = New SqlCommand(Simpan, Conn)
				Cmd.ExecuteNonQuery()
				MsgBox("Data Sudah Diinput. Terima Kasih")
				Me.Show()
				Call RefreshDGVDatabasAdmin()
				Call Bersihkan()

			End If
		End If

	End Sub

	Private Sub TextBoxKodeAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxKodeAdmin.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxNamaAdmin.Focus()
		If TextBoxKodeAdmin.Text = "" Then
			ButtonKeluarBatal.Text = "Keluar"
		Else
			ButtonKeluarBatal.Text = "Batal"
		End If

	End Sub
	Private Sub TextBoxNamaAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxNamaAdmin.KeyPress
		If e.KeyChar = Chr(13) Then TextBoxPasswordAdmin.Focus()

	End Sub
	Private Sub TextBoxPasswordAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxPasswordAdmin.KeyPress
		If e.KeyChar = Chr(13) Then ButtonTambah.Focus()

	End Sub

	Private Sub ButtonCari_Click(sender As Object, e As EventArgs) Handles ButtonCari.Click
		Call Koneksi()
		Cmd = New SqlCommand("SELECT * FROM AdminProyek WHERE KodeAdmin='" & TextBoxCariKodeAdmin.Text & "' ", Conn)
		Dr = Cmd.ExecuteReader
		Dr.Read()
		If Dr.HasRows Then
			Call Koneksi()
			Da = New SqlDataAdapter("SELECT * FROM AdminProyek WHERE KodeAdmin='" & TextBoxCariKodeAdmin.Text & "' ", Conn)
			Ds = New DataSet
			Da.Fill(Ds)
			DGVDatabaseAdmin.DataSource = Ds.Tables(0)
			DGVDatabaseAdmin.ReadOnly = True
			TextBoxKodeAdmin.Text = Dr.Item("KodeAdmin")
			TextBoxNamaAdmin.Text = Dr.Item("NamaAdmin")
			TextBoxPasswordAdmin.Text = Dr.Item("PasswordAdmin")
			TextBoxCariKodeAdmin.Clear()
		Else
			MsgBox("Data tidak ada")
			Call Bersihkan()
			TextBoxCariKodeAdmin.Clear()
		End If

	End Sub

	Private Sub TextBoxCariKodeAdmin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxCariKodeAdmin.KeyPress
		If e.KeyChar = Chr(13) Then ButtonCari.Focus()

	End Sub
End Class