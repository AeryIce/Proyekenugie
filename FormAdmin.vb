Public Class FormAdmin
	Private Sub AdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdminToolStripMenuItem.Click
		FormCRUDAdmin.Show()
		Me.Close()
	End Sub

	Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
		Me.Close()
		FormLogin.Close()
	End Sub
End Class