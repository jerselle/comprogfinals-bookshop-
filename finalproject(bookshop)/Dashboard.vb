Public Class Dashboard
    Private Sub btnDBooks_Click(sender As Object, e As EventArgs) Handles btnDBooks.Click
        ' Perform necessary actions, such as saving data

        ' Show the next form and close the current form
        Dim nextForm As New Books()
        nextForm.Show()
        Me.Close() ' Close the current form
    End Sub

    Private Sub btnDUsers_Click(sender As Object, e As EventArgs) Handles btnDUsers.Click
        ' Perform necessary actions, such as saving data

        ' Show the next form and close the current form
        Dim usermain As New Users()
        Users.Show()
        Me.Close() ' Close the current form
    End Sub
End Class