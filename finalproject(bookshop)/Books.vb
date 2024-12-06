Imports System.Data.OleDb
Public Class Books
    Dim con As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim adap As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap
    Private Sub btnBUsers_Click(sender As Object, e As EventArgs) Handles btnBUsers.Click

        Dim usermain As New Users()
        Users.Show()
        Me.Close()
    End Sub

    Private Sub btnBDashboard_Click(sender As Object, e As EventArgs) Handles btnBDashboard.Click
        Dim dsboard As New Dashboard()
        Dashboard.Show()
        Me.Close()
    End Sub

    Private Sub Books_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\Database\dbase.mdb"
    End Sub

    Private Sub btnBSave_Click(sender As Object, e As EventArgs) Handles btnBSave.Click
        Try

            If txtBTitle.Text = " " Or txtAuthor.Text = " " Or cboCategories.Text = " " Or txtQuantity.Text = " " Or txtPrice.Text = " " Then
                MsgBox("Please fill in all the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim quantity As Integer
            If Not Integer.TryParse(txtQuantity.Text, quantity) Then
                MsgBox("Invalid quantity, please enter a number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim price As Decimal
            If Not Decimal.TryParse(txtPrice.Text, price) Then
                MsgBox("Invalid price, please enter a valid decimal number", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            con.Open()
            cmd = New OleDbCommand("insert into books([Book Title], [Author], [Category], [Quantity], [Price]) values (?, ?, ?, ?, ?)", con)
            cmd.Parameters.AddWithValue("?", txtBTitle.Text)
            cmd.Parameters.AddWithValue("?", txtAuthor.Text)
            cmd.Parameters.AddWithValue("?", cboCategories.Text)
            cmd.Parameters.AddWithValue("?", quantity)
            cmd.Parameters.AddWithValue("?", price)
            cmd.ExecuteNonQuery()

            MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()

            con.Open()
            adap = New OleDbDataAdapter("select * from books", con)
            adap.Fill(dt)
            dgBooksList.DataSource = dt
            con.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
    End Sub

    Private Sub btnBLogout_Click(sender As Object, e As EventArgs) Handles btnBLogout.Click
        Dim loginForm As New Form1()
        Form1.Show()
        MsgBox("User Succefully Log out!")
        Me.Close()


    End Sub
End Class