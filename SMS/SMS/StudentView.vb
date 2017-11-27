Public Class StudentView
    'Mostly visual form!
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles INFO.Click
        StudProfile.ShowDialog() 'Show the Students Profile
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)
        'Unused
    End Sub

    Private Sub StudentView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.School.Students) 'Welcome, ____ Message

    End Sub

    Private Sub bnAbout_Click(sender As Object, e As EventArgs) Handles bnAbout.Click
        AboutBox1.Show() ' Show About Box
    End Sub

    Private Sub bnLogout_Click(sender As Object, e As EventArgs) Handles bnLogout.Click
        Me.Close()
        Login.Show() 'Close Menu and Show logout screen
        Me.Close()
    End Sub

    Private Sub MyCourses_Click(sender As Object, e As EventArgs) Handles MyCourses.Click
        StudCourses.ShowDialog() 'Show their courses
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudGPA.ShowDialog() 'Show the GPA Calculator
    End Sub

    Private Sub MyGrades_Click(sender As Object, e As EventArgs) Handles MyGrades.Click
        StudGrades.ShowDialog() ' Show their grades
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ChangePass.ShowDialog()
    End Sub
End Class
