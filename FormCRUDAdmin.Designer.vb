<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCRUDAdmin
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
		Me.GroupBox1 = New System.Windows.Forms.GroupBox()
		Me.TextBoxPasswordAdmin = New System.Windows.Forms.TextBox()
		Me.TextBoxNamaAdmin = New System.Windows.Forms.TextBox()
		Me.TextBoxKodeAdmin = New System.Windows.Forms.TextBox()
		Me.LabelPasswordAdmin = New System.Windows.Forms.Label()
		Me.LabelNamaAdmin = New System.Windows.Forms.Label()
		Me.LabelKodeAdmin = New System.Windows.Forms.Label()
		Me.GroupBox2 = New System.Windows.Forms.GroupBox()
		Me.ButtonCari = New System.Windows.Forms.Button()
		Me.TextBoxCariKodeAdmin = New System.Windows.Forms.TextBox()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.GroupBox3 = New System.Windows.Forms.GroupBox()
		Me.ButtonHapus = New System.Windows.Forms.Button()
		Me.ButtonEdit = New System.Windows.Forms.Button()
		Me.ButtonTambah = New System.Windows.Forms.Button()
		Me.GroupBoxQuit = New System.Windows.Forms.GroupBox()
		Me.ButtonKeluarBatal = New System.Windows.Forms.Button()
		Me.GroupBoxDatabaseAdmin = New System.Windows.Forms.GroupBox()
		Me.DGVDatabaseAdmin = New System.Windows.Forms.DataGridView()
		Me.GroupBox1.SuspendLayout()
		Me.GroupBox2.SuspendLayout()
		Me.GroupBox3.SuspendLayout()
		Me.GroupBoxQuit.SuspendLayout()
		Me.GroupBoxDatabaseAdmin.SuspendLayout()
		CType(Me.DGVDatabaseAdmin, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'GroupBox1
		'
		Me.GroupBox1.Controls.Add(Me.TextBoxPasswordAdmin)
		Me.GroupBox1.Controls.Add(Me.TextBoxNamaAdmin)
		Me.GroupBox1.Controls.Add(Me.TextBoxKodeAdmin)
		Me.GroupBox1.Controls.Add(Me.LabelPasswordAdmin)
		Me.GroupBox1.Controls.Add(Me.LabelNamaAdmin)
		Me.GroupBox1.Controls.Add(Me.LabelKodeAdmin)
		Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
		Me.GroupBox1.Name = "GroupBox1"
		Me.GroupBox1.Size = New System.Drawing.Size(394, 150)
		Me.GroupBox1.TabIndex = 0
		Me.GroupBox1.TabStop = False
		Me.GroupBox1.Text = "Data Admin"
		'
		'TextBoxPasswordAdmin
		'
		Me.TextBoxPasswordAdmin.Location = New System.Drawing.Point(103, 105)
		Me.TextBoxPasswordAdmin.Name = "TextBoxPasswordAdmin"
		Me.TextBoxPasswordAdmin.Size = New System.Drawing.Size(236, 20)
		Me.TextBoxPasswordAdmin.TabIndex = 5
		'
		'TextBoxNamaAdmin
		'
		Me.TextBoxNamaAdmin.Location = New System.Drawing.Point(103, 65)
		Me.TextBoxNamaAdmin.Name = "TextBoxNamaAdmin"
		Me.TextBoxNamaAdmin.Size = New System.Drawing.Size(236, 20)
		Me.TextBoxNamaAdmin.TabIndex = 4
		'
		'TextBoxKodeAdmin
		'
		Me.TextBoxKodeAdmin.Location = New System.Drawing.Point(103, 29)
		Me.TextBoxKodeAdmin.Name = "TextBoxKodeAdmin"
		Me.TextBoxKodeAdmin.Size = New System.Drawing.Size(236, 20)
		Me.TextBoxKodeAdmin.TabIndex = 3
		'
		'LabelPasswordAdmin
		'
		Me.LabelPasswordAdmin.AutoSize = True
		Me.LabelPasswordAdmin.Location = New System.Drawing.Point(6, 108)
		Me.LabelPasswordAdmin.Name = "LabelPasswordAdmin"
		Me.LabelPasswordAdmin.Size = New System.Drawing.Size(94, 13)
		Me.LabelPasswordAdmin.TabIndex = 2
		Me.LabelPasswordAdmin.Text = "Password Admin  :"
		'
		'LabelNamaAdmin
		'
		Me.LabelNamaAdmin.AutoSize = True
		Me.LabelNamaAdmin.Location = New System.Drawing.Point(6, 68)
		Me.LabelNamaAdmin.Name = "LabelNamaAdmin"
		Me.LabelNamaAdmin.Size = New System.Drawing.Size(94, 13)
		Me.LabelNamaAdmin.TabIndex = 1
		Me.LabelNamaAdmin.Text = "Nama Admin        :"
		'
		'LabelKodeAdmin
		'
		Me.LabelKodeAdmin.AutoSize = True
		Me.LabelKodeAdmin.Location = New System.Drawing.Point(6, 32)
		Me.LabelKodeAdmin.Name = "LabelKodeAdmin"
		Me.LabelKodeAdmin.Size = New System.Drawing.Size(94, 13)
		Me.LabelKodeAdmin.TabIndex = 0
		Me.LabelKodeAdmin.Text = "Kode Admin         :"
		'
		'GroupBox2
		'
		Me.GroupBox2.Controls.Add(Me.ButtonCari)
		Me.GroupBox2.Controls.Add(Me.TextBoxCariKodeAdmin)
		Me.GroupBox2.Controls.Add(Me.Label1)
		Me.GroupBox2.Location = New System.Drawing.Point(422, 12)
		Me.GroupBox2.Name = "GroupBox2"
		Me.GroupBox2.Size = New System.Drawing.Size(283, 100)
		Me.GroupBox2.TabIndex = 1
		Me.GroupBox2.TabStop = False
		Me.GroupBox2.Text = "Cari Kode Admin"
		'
		'ButtonCari
		'
		Me.ButtonCari.Location = New System.Drawing.Point(144, 65)
		Me.ButtonCari.Name = "ButtonCari"
		Me.ButtonCari.Size = New System.Drawing.Size(129, 23)
		Me.ButtonCari.TabIndex = 2
		Me.ButtonCari.Text = "Cari"
		Me.ButtonCari.UseVisualStyleBackColor = True
		'
		'TextBoxCariKodeAdmin
		'
		Me.TextBoxCariKodeAdmin.Location = New System.Drawing.Point(144, 25)
		Me.TextBoxCariKodeAdmin.Name = "TextBoxCariKodeAdmin"
		Me.TextBoxCariKodeAdmin.Size = New System.Drawing.Size(129, 20)
		Me.TextBoxCariKodeAdmin.TabIndex = 6
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Location = New System.Drawing.Point(6, 29)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(132, 13)
		Me.Label1.TabIndex = 6
		Me.Label1.Text = "Masukan Kode Admin      :"
		'
		'GroupBox3
		'
		Me.GroupBox3.Controls.Add(Me.ButtonHapus)
		Me.GroupBox3.Controls.Add(Me.ButtonEdit)
		Me.GroupBox3.Controls.Add(Me.ButtonTambah)
		Me.GroupBox3.Location = New System.Drawing.Point(422, 117)
		Me.GroupBox3.Name = "GroupBox3"
		Me.GroupBox3.Size = New System.Drawing.Size(283, 45)
		Me.GroupBox3.TabIndex = 2
		Me.GroupBox3.TabStop = False
		Me.GroupBox3.Text = "Modifikasi Data"
		'
		'ButtonHapus
		'
		Me.ButtonHapus.Location = New System.Drawing.Point(189, 16)
		Me.ButtonHapus.Name = "ButtonHapus"
		Me.ButtonHapus.Size = New System.Drawing.Size(84, 23)
		Me.ButtonHapus.TabIndex = 9
		Me.ButtonHapus.Text = "Hapus"
		Me.ButtonHapus.UseVisualStyleBackColor = True
		'
		'ButtonEdit
		'
		Me.ButtonEdit.Location = New System.Drawing.Point(104, 16)
		Me.ButtonEdit.Name = "ButtonEdit"
		Me.ButtonEdit.Size = New System.Drawing.Size(79, 23)
		Me.ButtonEdit.TabIndex = 8
		Me.ButtonEdit.Text = "Edit"
		Me.ButtonEdit.UseVisualStyleBackColor = True
		'
		'ButtonTambah
		'
		Me.ButtonTambah.Location = New System.Drawing.Point(9, 16)
		Me.ButtonTambah.Name = "ButtonTambah"
		Me.ButtonTambah.Size = New System.Drawing.Size(89, 23)
		Me.ButtonTambah.TabIndex = 7
		Me.ButtonTambah.Text = "Tambah"
		Me.ButtonTambah.UseVisualStyleBackColor = True
		'
		'GroupBoxQuit
		'
		Me.GroupBoxQuit.Controls.Add(Me.ButtonKeluarBatal)
		Me.GroupBoxQuit.Location = New System.Drawing.Point(711, 12)
		Me.GroupBoxQuit.Name = "GroupBoxQuit"
		Me.GroupBoxQuit.Size = New System.Drawing.Size(84, 150)
		Me.GroupBoxQuit.TabIndex = 3
		Me.GroupBoxQuit.TabStop = False
		Me.GroupBoxQuit.Text = "Quit"
		'
		'ButtonKeluarBatal
		'
		Me.ButtonKeluarBatal.Location = New System.Drawing.Point(6, 40)
		Me.ButtonKeluarBatal.Name = "ButtonKeluarBatal"
		Me.ButtonKeluarBatal.Size = New System.Drawing.Size(71, 81)
		Me.ButtonKeluarBatal.TabIndex = 10
		Me.ButtonKeluarBatal.Text = "."
		Me.ButtonKeluarBatal.UseVisualStyleBackColor = True
		'
		'GroupBoxDatabaseAdmin
		'
		Me.GroupBoxDatabaseAdmin.Controls.Add(Me.DGVDatabaseAdmin)
		Me.GroupBoxDatabaseAdmin.Location = New System.Drawing.Point(12, 168)
		Me.GroupBoxDatabaseAdmin.Name = "GroupBoxDatabaseAdmin"
		Me.GroupBoxDatabaseAdmin.Size = New System.Drawing.Size(783, 208)
		Me.GroupBoxDatabaseAdmin.TabIndex = 4
		Me.GroupBoxDatabaseAdmin.TabStop = False
		Me.GroupBoxDatabaseAdmin.Text = "DataBase Admin"
		'
		'DGVDatabaseAdmin
		'
		Me.DGVDatabaseAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
		Me.DGVDatabaseAdmin.Location = New System.Drawing.Point(9, 32)
		Me.DGVDatabaseAdmin.Name = "DGVDatabaseAdmin"
		Me.DGVDatabaseAdmin.Size = New System.Drawing.Size(767, 150)
		Me.DGVDatabaseAdmin.TabIndex = 0
		'
		'FormCRUDAdmin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.GroupBoxDatabaseAdmin)
		Me.Controls.Add(Me.GroupBoxQuit)
		Me.Controls.Add(Me.GroupBox3)
		Me.Controls.Add(Me.GroupBox2)
		Me.Controls.Add(Me.GroupBox1)
		Me.Name = "FormCRUDAdmin"
		Me.Text = "Form CRUD Admin"
		Me.GroupBox1.ResumeLayout(False)
		Me.GroupBox1.PerformLayout()
		Me.GroupBox2.ResumeLayout(False)
		Me.GroupBox2.PerformLayout()
		Me.GroupBox3.ResumeLayout(False)
		Me.GroupBoxQuit.ResumeLayout(False)
		Me.GroupBoxDatabaseAdmin.ResumeLayout(False)
		CType(Me.DGVDatabaseAdmin, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)

	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents TextBoxPasswordAdmin As TextBox
	Friend WithEvents TextBoxNamaAdmin As TextBox
	Friend WithEvents TextBoxKodeAdmin As TextBox
	Friend WithEvents LabelPasswordAdmin As Label
	Friend WithEvents LabelNamaAdmin As Label
	Friend WithEvents LabelKodeAdmin As Label
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents ButtonCari As Button
	Friend WithEvents TextBoxCariKodeAdmin As TextBox
	Friend WithEvents Label1 As Label
	Friend WithEvents GroupBox3 As GroupBox
	Friend WithEvents ButtonHapus As Button
	Friend WithEvents ButtonEdit As Button
	Friend WithEvents ButtonTambah As Button
	Friend WithEvents GroupBoxQuit As GroupBox
	Friend WithEvents ButtonKeluarBatal As Button
	Friend WithEvents GroupBoxDatabaseAdmin As GroupBox
	Friend WithEvents DGVDatabaseAdmin As DataGridView
End Class
