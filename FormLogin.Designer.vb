<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
		Me.GroupBoxLogin = New System.Windows.Forms.GroupBox()
		Me.Label2 = New System.Windows.Forms.Label()
		Me.ButtonLogin = New System.Windows.Forms.Button()
		Me.ButtonCancel = New System.Windows.Forms.Button()
		Me.TextBoxPassword = New System.Windows.Forms.TextBox()
		Me.TextBoxUserName = New System.Windows.Forms.TextBox()
		Me.LabelPassword = New System.Windows.Forms.Label()
		Me.LabelDataBase = New System.Windows.Forms.Label()
		Me.Label1 = New System.Windows.Forms.Label()
		Me.LabelDB = New System.Windows.Forms.Label()
		Me.GroupBoxLogin.SuspendLayout()
		Me.SuspendLayout()
		'
		'GroupBoxLogin
		'
		Me.GroupBoxLogin.Controls.Add(Me.Label2)
		Me.GroupBoxLogin.Controls.Add(Me.ButtonLogin)
		Me.GroupBoxLogin.Controls.Add(Me.ButtonCancel)
		Me.GroupBoxLogin.Controls.Add(Me.TextBoxPassword)
		Me.GroupBoxLogin.Controls.Add(Me.TextBoxUserName)
		Me.GroupBoxLogin.Controls.Add(Me.LabelPassword)
		Me.GroupBoxLogin.Location = New System.Drawing.Point(316, 129)
		Me.GroupBoxLogin.Name = "GroupBoxLogin"
		Me.GroupBoxLogin.Size = New System.Drawing.Size(239, 137)
		Me.GroupBoxLogin.TabIndex = 0
		Me.GroupBoxLogin.TabStop = False
		Me.GroupBoxLogin.Text = "Silahkan Login"
		'
		'Label2
		'
		Me.Label2.AutoSize = True
		Me.Label2.Location = New System.Drawing.Point(27, 28)
		Me.Label2.Name = "Label2"
		Me.Label2.Size = New System.Drawing.Size(63, 13)
		Me.Label2.TabIndex = 5
		Me.Label2.Text = "UserName :"
		'
		'ButtonLogin
		'
		Me.ButtonLogin.Location = New System.Drawing.Point(90, 93)
		Me.ButtonLogin.Name = "ButtonLogin"
		Me.ButtonLogin.Size = New System.Drawing.Size(49, 23)
		Me.ButtonLogin.TabIndex = 1
		Me.ButtonLogin.Text = "Login"
		Me.ButtonLogin.UseVisualStyleBackColor = True
		'
		'ButtonCancel
		'
		Me.ButtonCancel.Location = New System.Drawing.Point(145, 93)
		Me.ButtonCancel.Name = "ButtonCancel"
		Me.ButtonCancel.Size = New System.Drawing.Size(52, 23)
		Me.ButtonCancel.TabIndex = 4
		Me.ButtonCancel.Text = "Cancel"
		Me.ButtonCancel.UseVisualStyleBackColor = True
		'
		'TextBoxPassword
		'
		Me.TextBoxPassword.Location = New System.Drawing.Point(90, 56)
		Me.TextBoxPassword.Name = "TextBoxPassword"
		Me.TextBoxPassword.Size = New System.Drawing.Size(107, 20)
		Me.TextBoxPassword.TabIndex = 3
		'
		'TextBoxUserName
		'
		Me.TextBoxUserName.Location = New System.Drawing.Point(90, 25)
		Me.TextBoxUserName.Name = "TextBoxUserName"
		Me.TextBoxUserName.Size = New System.Drawing.Size(107, 20)
		Me.TextBoxUserName.TabIndex = 2
		'
		'LabelPassword
		'
		Me.LabelPassword.AutoSize = True
		Me.LabelPassword.Location = New System.Drawing.Point(27, 56)
		Me.LabelPassword.Name = "LabelPassword"
		Me.LabelPassword.Size = New System.Drawing.Size(62, 13)
		Me.LabelPassword.TabIndex = 1
		Me.LabelPassword.Text = "Password  :"
		'
		'LabelDataBase
		'
		Me.LabelDataBase.AutoSize = True
		Me.LabelDataBase.Font = New System.Drawing.Font("Lucida Console", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelDataBase.Location = New System.Drawing.Point(490, 269)
		Me.LabelDataBase.Name = "LabelDataBase"
		Me.LabelDataBase.Size = New System.Drawing.Size(0, 9)
		Me.LabelDataBase.TabIndex = 0
		'
		'Label1
		'
		Me.Label1.AutoSize = True
		Me.Label1.Font = New System.Drawing.Font("Lucida Console", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label1.Location = New System.Drawing.Point(403, 269)
		Me.Label1.Name = "Label1"
		Me.Label1.Size = New System.Drawing.Size(90, 9)
		Me.Label1.TabIndex = 5
		Me.Label1.Text = "Database Status :"
		'
		'LabelDB
		'
		Me.LabelDB.AutoSize = True
		Me.LabelDB.Font = New System.Drawing.Font("Lucida Console", 6.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.LabelDB.ForeColor = System.Drawing.SystemColors.Highlight
		Me.LabelDB.Location = New System.Drawing.Point(490, 269)
		Me.LabelDB.Name = "LabelDB"
		Me.LabelDB.Size = New System.Drawing.Size(11, 9)
		Me.LabelDB.TabIndex = 6
		Me.LabelDB.Text = "."
		'
		'FormLogin
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(800, 450)
		Me.Controls.Add(Me.LabelDB)
		Me.Controls.Add(Me.Label1)
		Me.Controls.Add(Me.GroupBoxLogin)
		Me.Controls.Add(Me.LabelDataBase)
		Me.Name = "FormLogin"
		Me.Text = "FormLogin"
		Me.GroupBoxLogin.ResumeLayout(False)
		Me.GroupBoxLogin.PerformLayout()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub

	Friend WithEvents GroupBoxLogin As GroupBox
	Friend WithEvents LabelPassword As Label
	Friend WithEvents TextBoxPassword As TextBox
	Friend WithEvents TextBoxUserName As TextBox
	Friend WithEvents ButtonLogin As Button
	Friend WithEvents ButtonCancel As Button
	Friend WithEvents Label1 As Label
	Public WithEvents LabelDataBase As Label
	Friend WithEvents Label2 As Label
	Public WithEvents LabelDB As Label
End Class
