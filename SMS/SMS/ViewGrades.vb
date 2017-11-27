Public Class ViewGrades
    Private Sub ViewGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.School.Grades)

    End Sub

    Private Sub Search_TextChanged(sender As Object, e As EventArgs) Handles Search.TextChanged
        'Unused
    End Sub

    Private Sub bnAdd_Click(sender As Object, e As EventArgs) Handles bnAdd.Click
        AddGrades.Show() 'View Add Student form
        ViewGrades_Load(sender, e)

    End Sub

    Private Sub bnEdit_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub bnDelete_Click(sender As Object, e As EventArgs) Handles bnDelete.Click
        Try
            Dim db As New InfoDBDataContext 'load up the database
            Dim thisGrade = From p In db.Grades
                            Where p.Id = Val(DataGridView1.CurrentRow.Cells(0).Value)
                            Select p 'Check to see if the current cell has a value

            db.Grades.DeleteOnSubmit(thisGrade.FirstOrDefault) 'delete the cell info
            db.SubmitChanges() 'save these changes
            MsgBox("Okay, the record has been deleted!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ViewGrades_Load(sender, e) 'refresh the table
        Catch ex As Exception 'Otherwise, there is no data in the table to delete
            MsgBox("No course selected.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub bnUpdate_Click(sender As Object, e As EventArgs) Handles bnUpdate.Click
        ViewGrades_Load(sender, e) 'Refresh the table
    End Sub

    Private Sub Search_KeyUp(sender As Object, e As KeyEventArgs) Handles Search.KeyUp
        If Search.Text = "" Then 'If the search field is empty, refresh table
            ViewGrades_Load(sender, e)
        Else 'Otherwise load it up with student info
            Me.GradesTableAdapter.FillByCourse(Me.School.Grades, Search.Text & "%")
        End If
    End Sub
End Class