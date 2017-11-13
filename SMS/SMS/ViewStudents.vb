Public Class ViewStudents
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Search_KeyUp(sender As Object, e As KeyEventArgs) Handles Search.KeyUp
        If Search.Text = "" Then
            ViewStudents_Load(sender, e)
        Else
            Me.StudentsTableAdapter.FillByStudentName(Me.School.Students, Search.Text & "%")
        End If
    End Sub

    Private Sub ViewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.School.Students)

    End Sub

    Private Sub bnAdd_Click(sender As Object, e As EventArgs) Handles bnAdd.Click
        AddStudent.Show()
        ViewStudents_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ViewStudents_Load(sender, e)
    End Sub

    Private Sub bnEdit_Click(sender As Object, e As EventArgs) Handles bnEdit.Click

    End Sub

    Private Sub bnDelete_Click(sender As Object, e As EventArgs) Handles bnDelete.Click
        Try
            Dim db As New InfoDBDataContext
            Dim thisStudent = From p In db.Students
                              Where p.STUDENTINF = Val(DataGridView1.CurrentRow.Cells(0).Value)
                              Select p

            db.Students.DeleteOnSubmit(thisStudent.FirstOrDefault)
            db.SubmitChanges()
            MsgBox("Okay, the student has been deleted!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ViewStudents_Load(sender, e)
        Catch ex As Exception
            MsgBox("No student selected.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub
End Class