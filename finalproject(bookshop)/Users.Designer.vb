<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Users
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dgUsersList = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btnUSave = New System.Windows.Forms.Button()
        Me.btnUView = New System.Windows.Forms.Button()
        Me.btnUDelete = New System.Windows.Forms.Button()
        Me.btnUAdd = New System.Windows.Forms.Button()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnUBooks = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnUUsers = New System.Windows.Forms.Button()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnUDashboard = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        CType(Me.dgUsersList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.dgUsersList)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.btnUSave)
        Me.Panel3.Controls.Add(Me.btnUView)
        Me.Panel3.Controls.Add(Me.btnUDelete)
        Me.Panel3.Controls.Add(Me.btnUAdd)
        Me.Panel3.Controls.Add(Me.txtPass)
        Me.Panel3.Controls.Add(Me.txtAddress)
        Me.Panel3.Controls.Add(Me.txtPhone)
        Me.Panel3.Controls.Add(Me.txtName)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(207, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(807, 544)
        Me.Panel3.TabIndex = 9
        '
        'dgUsersList
        '
        Me.dgUsersList.BackgroundColor = System.Drawing.Color.White
        Me.dgUsersList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgUsersList.Location = New System.Drawing.Point(-1, 297)
        Me.dgUsersList.Name = "dgUsersList"
        Me.dgUsersList.RowHeadersWidth = 51
        Me.dgUsersList.RowTemplate.Height = 24
        Me.dgUsersList.Size = New System.Drawing.Size(807, 256)
        Me.dgUsersList.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(360, 265)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 22)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Users List"
        '
        'btnUSave
        '
        Me.btnUSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUSave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUSave.ForeColor = System.Drawing.Color.White
        Me.btnUSave.Location = New System.Drawing.Point(169, 223)
        Me.btnUSave.Name = "btnUSave"
        Me.btnUSave.Size = New System.Drawing.Size(113, 28)
        Me.btnUSave.TabIndex = 16
        Me.btnUSave.Text = "Save"
        Me.btnUSave.UseVisualStyleBackColor = False
        '
        'btnUView
        '
        Me.btnUView.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUView.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUView.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUView.ForeColor = System.Drawing.Color.White
        Me.btnUView.Location = New System.Drawing.Point(302, 223)
        Me.btnUView.Name = "btnUView"
        Me.btnUView.Size = New System.Drawing.Size(104, 28)
        Me.btnUView.TabIndex = 15
        Me.btnUView.Text = "View"
        Me.btnUView.UseVisualStyleBackColor = False
        '
        'btnUDelete
        '
        Me.btnUDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUDelete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUDelete.ForeColor = System.Drawing.Color.White
        Me.btnUDelete.Location = New System.Drawing.Point(559, 223)
        Me.btnUDelete.Name = "btnUDelete"
        Me.btnUDelete.Size = New System.Drawing.Size(102, 28)
        Me.btnUDelete.TabIndex = 14
        Me.btnUDelete.Text = "Delete"
        Me.btnUDelete.UseVisualStyleBackColor = False
        '
        'btnUAdd
        '
        Me.btnUAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnUAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUAdd.ForeColor = System.Drawing.Color.White
        Me.btnUAdd.Location = New System.Drawing.Point(426, 223)
        Me.btnUAdd.Name = "btnUAdd"
        Me.btnUAdd.Size = New System.Drawing.Size(113, 28)
        Me.btnUAdd.TabIndex = 13
        Me.btnUAdd.Text = "Add"
        Me.btnUAdd.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPass.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.Location = New System.Drawing.Point(637, 122)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(148, 30)
        Me.txtPass.TabIndex = 10
        '
        'txtAddress
        '
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAddress.Location = New System.Drawing.Point(375, 122)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(237, 90)
        Me.txtAddress.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPhone.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPhone.Location = New System.Drawing.Point(204, 121)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(145, 30)
        Me.txtPhone.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(29, 121)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(145, 30)
        Me.txtName.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(633, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 22)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Address"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(66, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Phone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(320, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(178, 22)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "BookShop Software"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BookShop"
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.btnUBooks)
        Me.Panel4.Location = New System.Drawing.Point(3, 173)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(192, 51)
        Me.Panel4.TabIndex = 0
        '
        'btnUBooks
        '
        Me.btnUBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnUBooks.FlatAppearance.BorderSize = 0
        Me.btnUBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUBooks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUBooks.ForeColor = System.Drawing.Color.White
        Me.btnUBooks.Location = New System.Drawing.Point(-2, -1)
        Me.btnUBooks.Name = "btnUBooks"
        Me.btnUBooks.Size = New System.Drawing.Size(195, 51)
        Me.btnUBooks.TabIndex = 5
        Me.btnUBooks.Text = "Books"
        Me.btnUBooks.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(12, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(17, 51)
        Me.Panel2.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Controls.Add(Me.btnUUsers)
        Me.Panel5.Location = New System.Drawing.Point(3, 258)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(192, 51)
        Me.Panel5.TabIndex = 1
        '
        'btnUUsers
        '
        Me.btnUUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnUUsers.FlatAppearance.BorderSize = 0
        Me.btnUUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUUsers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUUsers.ForeColor = System.Drawing.Color.White
        Me.btnUUsers.Location = New System.Drawing.Point(-2, -1)
        Me.btnUUsers.Name = "btnUUsers"
        Me.btnUUsers.Size = New System.Drawing.Size(195, 51)
        Me.btnUUsers.TabIndex = 5
        Me.btnUUsers.Text = "Users"
        Me.btnUUsers.UseVisualStyleBackColor = False
        '
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.btnUDashboard)
        Me.Panel7.Location = New System.Drawing.Point(3, 341)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(192, 51)
        Me.Panel7.TabIndex = 7
        '
        'btnUDashboard
        '
        Me.btnUDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnUDashboard.FlatAppearance.BorderSize = 0
        Me.btnUDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUDashboard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUDashboard.ForeColor = System.Drawing.Color.White
        Me.btnUDashboard.Location = New System.Drawing.Point(-2, -1)
        Me.btnUDashboard.Name = "btnUDashboard"
        Me.btnUDashboard.Size = New System.Drawing.Size(195, 51)
        Me.btnUDashboard.TabIndex = 5
        Me.btnUDashboard.Text = "Dashboard"
        Me.btnUDashboard.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Location = New System.Drawing.Point(6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(205, 568)
        Me.Panel1.TabIndex = 8
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(47, 497)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 31)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Users
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1020, 568)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Users"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Users"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.dgUsersList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents dgUsersList As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents btnUSave As Button
    Friend WithEvents btnUView As Button
    Friend WithEvents btnUDelete As Button
    Friend WithEvents btnUAdd As Button
    Friend WithEvents txtPass As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button4 As Button
    Friend WithEvents btnUBooks As Button
    Friend WithEvents btnUUsers As Button
    Friend WithEvents btnUDashboard As Button
End Class
