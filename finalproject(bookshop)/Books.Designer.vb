﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Books
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dgBooksList = New System.Windows.Forms.DataGridView()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.cboCategories = New System.Windows.Forms.ComboBox()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.txtBTitle = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.btnBRefresh = New System.Windows.Forms.Button()
        Me.btnBSave = New System.Windows.Forms.Button()
        Me.btnBEdit = New System.Windows.Forms.Button()
        Me.btnBDelete = New System.Windows.Forms.Button()
        Me.btnBAdd = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.btnBDashboard = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnBUsers = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.btnBBooks = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.txtBSearch = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.dgBooksList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgBooksList
        '
        Me.dgBooksList.BackgroundColor = System.Drawing.Color.White
        Me.dgBooksList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgBooksList.Location = New System.Drawing.Point(-1, 296)
        Me.dgBooksList.Name = "dgBooksList"
        Me.dgBooksList.RowHeadersWidth = 51
        Me.dgBooksList.RowTemplate.Height = 24
        Me.dgBooksList.Size = New System.Drawing.Size(807, 246)
        Me.dgBooksList.TabIndex = 20
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(361, 229)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 22)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Books List"
        '
        'txtPrice
        '
        Me.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrice.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrice.Location = New System.Drawing.Point(656, 122)
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(78, 30)
        Me.txtPrice.TabIndex = 10
        '
        'cboCategories
        '
        Me.cboCategories.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategories.FormattingEnabled = True
        Me.cboCategories.Location = New System.Drawing.Point(374, 121)
        Me.cboCategories.Name = "cboCategories"
        Me.cboCategories.Size = New System.Drawing.Size(145, 30)
        Me.cboCategories.TabIndex = 8
        '
        'txtAuthor
        '
        Me.txtAuthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAuthor.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(204, 121)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(145, 30)
        Me.txtAuthor.TabIndex = 7
        '
        'txtBTitle
        '
        Me.txtBTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBTitle.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBTitle.Location = New System.Drawing.Point(29, 121)
        Me.txtBTitle.Name = "txtBTitle"
        Me.txtBTitle.Size = New System.Drawing.Size(145, 30)
        Me.txtBTitle.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(652, 96)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(54, 22)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Price"
        '
        'txtQuantity
        '
        Me.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtQuantity.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(549, 122)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(78, 30)
        Me.txtQuantity.TabIndex = 9
        '
        'Button4
        '
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(46, 498)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(115, 31)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'btnBRefresh
        '
        Me.btnBRefresh.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBRefresh.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBRefresh.ForeColor = System.Drawing.Color.White
        Me.btnBRefresh.Location = New System.Drawing.Point(535, 257)
        Me.btnBRefresh.Name = "btnBRefresh"
        Me.btnBRefresh.Size = New System.Drawing.Size(104, 28)
        Me.btnBRefresh.TabIndex = 17
        Me.btnBRefresh.Text = "Refresh"
        Me.btnBRefresh.UseVisualStyleBackColor = False
        '
        'btnBSave
        '
        Me.btnBSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBSave.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBSave.ForeColor = System.Drawing.Color.White
        Me.btnBSave.Location = New System.Drawing.Point(164, 185)
        Me.btnBSave.Name = "btnBSave"
        Me.btnBSave.Size = New System.Drawing.Size(113, 28)
        Me.btnBSave.TabIndex = 16
        Me.btnBSave.Text = "Save"
        Me.btnBSave.UseVisualStyleBackColor = False
        '
        'btnBEdit
        '
        Me.btnBEdit.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBEdit.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBEdit.ForeColor = System.Drawing.Color.White
        Me.btnBEdit.Location = New System.Drawing.Point(296, 185)
        Me.btnBEdit.Name = "btnBEdit"
        Me.btnBEdit.Size = New System.Drawing.Size(104, 28)
        Me.btnBEdit.TabIndex = 15
        Me.btnBEdit.Text = "Edit"
        Me.btnBEdit.UseVisualStyleBackColor = False
        '
        'btnBDelete
        '
        Me.btnBDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBDelete.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDelete.ForeColor = System.Drawing.Color.White
        Me.btnBDelete.Location = New System.Drawing.Point(549, 185)
        Me.btnBDelete.Name = "btnBDelete"
        Me.btnBDelete.Size = New System.Drawing.Size(102, 28)
        Me.btnBDelete.TabIndex = 14
        Me.btnBDelete.Text = "Delete"
        Me.btnBDelete.UseVisualStyleBackColor = False
        '
        'btnBAdd
        '
        Me.btnBAdd.BackColor = System.Drawing.Color.FromArgb(CType(CType(104, Byte), Integer), CType(CType(140, Byte), Integer), CType(CType(202, Byte), Integer))
        Me.btnBAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBAdd.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBAdd.ForeColor = System.Drawing.Color.White
        Me.btnBAdd.Location = New System.Drawing.Point(420, 185)
        Me.btnBAdd.Name = "btnBAdd"
        Me.btnBAdd.Size = New System.Drawing.Size(113, 28)
        Me.btnBAdd.TabIndex = 13
        Me.btnBAdd.Text = "Add"
        Me.btnBAdd.UseVisualStyleBackColor = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(544, 96)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 22)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Quantity"
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
        'Panel7
        '
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.btnBDashboard)
        Me.Panel7.Location = New System.Drawing.Point(3, 341)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(192, 51)
        Me.Panel7.TabIndex = 7
        '
        'btnBDashboard
        '
        Me.btnBDashboard.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnBDashboard.FlatAppearance.BorderSize = 0
        Me.btnBDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBDashboard.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBDashboard.ForeColor = System.Drawing.Color.White
        Me.btnBDashboard.Location = New System.Drawing.Point(-1, 2)
        Me.btnBDashboard.Name = "btnBDashboard"
        Me.btnBDashboard.Size = New System.Drawing.Size(195, 48)
        Me.btnBDashboard.TabIndex = 8
        Me.btnBDashboard.Text = "Dashboard"
        Me.btnBDashboard.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.btnBUsers)
        Me.Panel5.Location = New System.Drawing.Point(3, 258)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(192, 51)
        Me.Panel5.TabIndex = 1
        '
        'btnBUsers
        '
        Me.btnBUsers.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnBUsers.FlatAppearance.BorderSize = 0
        Me.btnBUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBUsers.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBUsers.ForeColor = System.Drawing.Color.White
        Me.btnBUsers.Location = New System.Drawing.Point(-4, -1)
        Me.btnBUsers.Name = "btnBUsers"
        Me.btnBUsers.Size = New System.Drawing.Size(195, 51)
        Me.btnBUsers.TabIndex = 5
        Me.btnBUsers.Text = "Users"
        Me.btnBUsers.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Controls.Add(Me.btnBBooks)
        Me.Panel4.Location = New System.Drawing.Point(3, 173)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(192, 51)
        Me.Panel4.TabIndex = 0
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.ForeColor = System.Drawing.Color.Black
        Me.Panel6.Location = New System.Drawing.Point(13, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(17, 51)
        Me.Panel6.TabIndex = 21
        '
        'btnBBooks
        '
        Me.btnBBooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.btnBBooks.FlatAppearance.BorderSize = 0
        Me.btnBBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBBooks.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBBooks.ForeColor = System.Drawing.Color.White
        Me.btnBBooks.Location = New System.Drawing.Point(-4, -1)
        Me.btnBBooks.Name = "btnBBooks"
        Me.btnBBooks.Size = New System.Drawing.Size(195, 51)
        Me.btnBBooks.TabIndex = 4
        Me.btnBBooks.Text = "Books"
        Me.btnBBooks.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(58, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 21)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "BookShop"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(200, 96)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 22)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Author"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(25, 96)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(92, 22)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Book Title"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(243, Byte), Integer))
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.txtBSearch)
        Me.Panel3.Controls.Add(Me.dgBooksList)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.btnBRefresh)
        Me.Panel3.Controls.Add(Me.btnBSave)
        Me.Panel3.Controls.Add(Me.btnBEdit)
        Me.Panel3.Controls.Add(Me.btnBDelete)
        Me.Panel3.Controls.Add(Me.btnBAdd)
        Me.Panel3.Controls.Add(Me.txtPrice)
        Me.Panel3.Controls.Add(Me.txtQuantity)
        Me.Panel3.Controls.Add(Me.cboCategories)
        Me.Panel3.Controls.Add(Me.txtAuthor)
        Me.Panel3.Controls.Add(Me.txtBTitle)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Location = New System.Drawing.Point(207, 11)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(807, 544)
        Me.Panel3.TabIndex = 7
        '
        'txtBSearch
        '
        Me.txtBSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBSearch.ForeColor = System.Drawing.Color.DarkGray
        Me.txtBSearch.Location = New System.Drawing.Point(281, 257)
        Me.txtBSearch.Multiline = True
        Me.txtBSearch.Name = "txtBSearch"
        Me.txtBSearch.Size = New System.Drawing.Size(238, 28)
        Me.txtBSearch.TabIndex = 21
        Me.txtBSearch.Text = "Search"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(371, 96)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 22)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Categories"
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
        Me.Panel1.TabIndex = 6
        '
        'Books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(126, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1020, 568)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Books"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Books"
        CType(Me.dgBooksList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgBooksList As DataGridView
    Friend WithEvents Label11 As Label
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents cboCategories As ComboBox
    Friend WithEvents txtAuthor As TextBox
    Friend WithEvents txtBTitle As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents btnBRefresh As Button
    Friend WithEvents btnBSave As Button
    Friend WithEvents btnBEdit As Button
    Friend WithEvents btnBDelete As Button
    Friend WithEvents btnBAdd As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel7 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnBBooks As Button
    Friend WithEvents btnBDashboard As Button
    Friend WithEvents btnBUsers As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents txtBSearch As TextBox
End Class
