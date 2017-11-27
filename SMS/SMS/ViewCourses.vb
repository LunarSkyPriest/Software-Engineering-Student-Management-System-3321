
Public Class ViewCourses
    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub StudentBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Dim db As New InfoDBDataContext
        'StudentBox.DataSource = db.Students["StudentID"]
        'StudentBox.DisplayMember = "StudentID"
    End Sub

    Private Sub ViewCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.School.Courses)
        'Dim Query As String
        'Query = "Select * from InfoDB.STUDENTINFO"
        'Command = New
    End Sub

    Private Sub bnAddCourses_Click(sender As Object, e As EventArgs) Handles bnAddCourses.Click 'View Add Courses 
        AddCourses.Show()
        ViewCourses_Load(sender, e)
    End Sub

    Private Sub bnDelete_Click(sender As Object, e As EventArgs) Handles bnDelete.Click
        Try 'When removing a student from a course
            Dim db As New InfoDBDataContext
            Dim thisStudent = From p In db.Courses
                              Where p.Id = Val(DataGridView1.CurrentRow.Cells(0).Value)
                              Select p 'Check the current value in the cell, so there is an object to remove

            db.Courses.DeleteOnSubmit(thisStudent.FirstOrDefault) 'Deleting the entry
            db.SubmitChanges()  'submitting the deletion
            MsgBox("Okay, the student has been removed from the course.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ViewCourses_Load(sender, e) 'refresh the table upon deletion
        Catch ex As Exception 'If there is no entry selected
            MsgBox("No student selected.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub bnRefresh_Click(sender As Object, e As EventArgs) Handles bnRefresh.Click
        ViewCourses_Load(sender, e) 'Reloading the form if needed
    End Sub

    Private Sub bnSearch_TextChanged(sender As Object, e As EventArgs) Handles bnSearch.TextChanged
        If bnSearch.Text = "" Then   'when searching, if the search box is now empty, just refresh
            ViewCourses_Load(sender, e)
        Else 'Otherwise, search for the student in the data set
            Me.CoursesTableAdapter.FillByStudentID(Me.School.Courses, bnSearch.Text & "%")

        End If
    End Sub
End Class