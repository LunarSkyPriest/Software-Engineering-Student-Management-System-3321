Public Class Login 'Dara 11/4-5, login menu

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click 'on clicking
        If UsernameTextBox.Text = "" Or PasswordTextBox.Text = "" Then 'if the text boxes are empty and click ok
            MsgBox("You must enter a Username AND Password!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly) 'input
            Exit Sub
        End If
        Dim db As New InfoDBDataContext 'calling up the database for the log in
        Dim CheckUser = From p In db.Users Where p.Username = UsernameTextBox.Text And p.Password = PasswordTextBox.Text Select p 'if the usernames and passwords are in the table
        If UsernameTextBox.Text = "admin" And PasswordTextBox.Text = "password" Then
            MainView.Show() 'admin logs in and sees the main menu to edit and change data, as well as the profile form
            'Me.Close() no need to close immediately
        End If
        If CheckUser.Count = 0 Then ' if the username or password isnt found
            MsgBox("Invalid Username or Password Entered!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
            Exit Sub
        ElseIf UsernameTextBox.Text <> "admin" Then 'If the user logging in isnt the admin
            StudentView.Show() 'no errors, and not an admin, it should show the student form, currently empty 11/05
            'Me.Close()
        End If


    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close() 'clicking cancel closes the menu
    End Sub

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        'extra changes that are unused
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class