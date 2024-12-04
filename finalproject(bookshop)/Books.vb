Public Class Books
    Private Sub btnBUsers_Click(sender As Object, e As EventArgs) Handles btnBUsers.Click
        ' Perform necessary actions, such as saving data

        ' Show the next form and close the current form
        Dim usermain As New Users()
        Users.Show()
        Me.Close() ' Close the current form
    End Sub

    Private Sub btnBDashboard_Click(sender As Object, e As EventArgs) Handles btnBDashboard.Click
        ' Perform necessary actions, such as saving data

        ' Show the next form and close the current form
        Dim dsboard As New Dashboard()
        Dashboard.Show()
        Me.Close() ' Close the current form
    End Sub
End Class