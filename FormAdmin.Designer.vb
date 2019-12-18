<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAdmin
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
		Me.AdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.TransaksiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.PaketModulToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
		Me.MenuStrip1.SuspendLayout()
		Me.SuspendLayout()
		'
		'MenuStrip1
		'
		Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdminToolStripMenuItem, Me.UserToolStripMenuItem, Me.TransaksiToolStripMenuItem, Me.PaketModulToolStripMenuItem, Me.KeluarToolStripMenuItem})
		Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
		Me.MenuStrip1.Name = "MenuStrip1"
		Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
		Me.MenuStrip1.TabIndex = 0
		Me.MenuStrip1.Text = "MenuStrip1"
		'
		'AdminToolStripMenuItem
		'
		Me.AdminToolStripMenuItem.Name = "AdminToolStripMenuItem"
		Me.AdminToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
		Me.AdminToolStripMenuItem.Text = "Admin"
		'
		'UserToolStripMenuItem
		'
		Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
		Me.UserToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
		Me.UserToolStripMenuItem.Text = "User"
		'
		'TransaksiToolStripMenuItem
		'
		Me.TransaksiToolStripMenuItem.Name = "TransaksiToolStripMenuItem"
		Me.TransaksiToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
		Me.TransaksiToolStripMenuItem.Text = "Transaksi"
		'
		'PaketModulToolStripMenuItem
		'
		Me.PaketModulToolStripMenuItem.Name = "PaketModulToolStripMenuItem"
		Me.PaketModulToolStripMenuItem.Size = New System.Drawing.Size(86, 20)
		Me.PaketModulToolStripMenuItem.Text = "Paket Modul"
		'
		'KeluarToolStripMenuItem
		'
		Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
		Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
		Me.KeluarToolStripMenuItem.Text = "Keluar"
		'
		'FormAdmin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.MenuStrip1)
		Me.MainMenuStrip = Me.MenuStrip1
		Me.Name = "FormAdmin"
		Me.Text = "FormAdmin"
		Me.MenuStrip1.ResumeLayout(False)
		Me.MenuStrip1.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents AdminToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents UserToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents TransaksiToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents PaketModulToolStripMenuItem As ToolStripMenuItem
	Friend WithEvents KeluarToolStripMenuItem As ToolStripMenuItem
End Class
