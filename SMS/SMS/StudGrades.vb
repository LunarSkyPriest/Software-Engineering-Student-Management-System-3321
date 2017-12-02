Public Class StudGrades
    'View profile screen
    Private Sub StudGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.School.Grades)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close() 'close menu
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        StudGPA.ShowDialog() 'pull up the gpa calculator
    End Sub
End Class