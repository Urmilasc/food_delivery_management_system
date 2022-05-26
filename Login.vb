Public Class Login
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        If txtUsername.Text = "admin" And txtPassword.Text = "12345" Then
            Home.Show()
            Me.Hide()
        ElseIf txtUsername.Text = "" Then
            MessageBox.Show("Username can't be empty")
        ElseIf txtPassword.Text = "" Then
            MessageBox.Show("Password can't be empty")
        ElseIf txtUsername.Text = "" And txtPassword.Text = "" Then
            MessageBox.Show("Please fill all the fields")
        Else
            MessageBox.Show("Invalid Password or username please write valid credentials", "Warning !")
        End If

        txtUsername.Text = ""
        txtPassword.Text = ""
    End Sub
End Class