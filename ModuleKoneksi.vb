Imports System.Data.SqlClient
Module ModuleKoneksi
	Public Conn As SqlConnection
	Public Cmd As SqlCommand
	Public Dr As SqlDataReader
	Public Da As SqlDataAdapter
	Public Ds As DataSet

	Sub Koneksi()
		Try
			Conn = New SqlConnection("Data Source=aeryice-pc666;Initial Catalog=proyekenugie;integrated security=true")
			Conn.Open()

			FormLogin.LabelDB.Text = "Connected"
		Catch ex As Exception
			FormLogin.LabelDB.Text = "Not Connected"

		End Try


	End Sub

End Module
