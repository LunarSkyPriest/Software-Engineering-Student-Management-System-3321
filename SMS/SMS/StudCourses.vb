Public Class StudCourses
    Private Sub StudCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.School.Courses)

    End Sub
    'Mostly visual forms, just a few cases of showing dialogs
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudGrades.ShowDialog() 'show student grades
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close() 'close the menu
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CourseDes.ShowDialog() 'show the course descriptions
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'unused, here to allow items to write into it from the courses db
    End Sub
End Class