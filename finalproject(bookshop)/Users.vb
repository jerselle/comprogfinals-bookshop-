Imports System.Data.OleDb
Public Class Users
    Public Shared usermain
    Dim con As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dt As New DataTable
    Dim adap As New OleDbDataAdapter(cmd)

    Private bitmap As Bitmap


    Private Sub Users_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "provider=microsoft.jet.oledb.4.0;data source=" & Application.StartupPath & "\Database\dbase.mdb"
    End Sub

    Private Sub btnUSave_Click(sender As Object, e As EventArgs) Handles btnUSave.Click

        Try

            If txtName.Text = " " Or txtPhone.Text = " " Or txtAddress.Text = " " Or txtPass.Text = " " Then
                MsgBox("Please fill in all the fields", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If


            con.Open()


            cmd = New OleDbCommand("insert into userinformation([Name], [Phone], [Address], [Password]) values (?, ?, ?, ?)", con)


            cmd.Parameters.AddWithValue("?", txtName.Text)
            cmd.Parameters.AddWithValue("?", txtPhone.Text)
            cmd.Parameters.AddWithValue("?", txtAddress.Text)
            cmd.Parameters.AddWithValue("?", txtPass.Text)


            cmd.ExecuteNonQuery()


            MsgBox("Record saved successfully!", MessageBoxButtons.OK, MessageBoxIcon.Information)

        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally

            If con.State = ConnectionState.Open Then
                con.Close()
            End If
        End Try
        con.Open()
        cmd = con.CreateCommand()
        adap = New OleDbDataAdapter("select * from userinformation", con)
        adap.Fill(dt)
        dgUsersList.DataSource = dt
        con.Close()
    End Sub

    Private Sub btnUBooks_Click(sender As Object, e As EventArgs) Handles btnUBooks.Click
        ' Perform necessary actions, such as saving data

        ' Show the next form and close the current form
        Dim nextForm As New Books()
        nextForm.Show()
        Me.Close() ' Close the current form
    End Sub

    Private Sub btnUDashboard_Click(sender As Object, e As EventArgs) Handles btnUDashboard.Click
        ' Perform necessary actions, such as saving data

        ' Show the next form and close the current form
        Dim dsboard As New Dashboard()
        Dashboard.Show()
        Me.Close() ' Close the current form
    End Sub
End Class