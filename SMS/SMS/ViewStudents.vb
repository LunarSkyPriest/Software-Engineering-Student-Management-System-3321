'Imports System.Data.Table
Public Class ViewStudents
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'Dim index As Integer
        'index = e.RowIndex
        'Dim selectedRow As DataGridViewRow
        'selectedRow = DataGridView1.Rows(index)
        'StudentName.Text = selectedRow.Cells(0).Value.ToString()
        ' Me.StudentName.Text = Val(DataGridView1.CurrentRow.Cells(0).Value)

    End Sub

    Private Sub Search_KeyUp(sender As Object, e As KeyEventArgs) Handles Search.KeyUp
        If Search.Text = "" Then 'If the search field is empty, refresh table
            ViewStudents_Load(sender, e)
        Else 'Otherwise load it up with student info
            Me.StudentsTableAdapter.FillByStudentName(Me.School.Students, Search.Text & "%")

        End If
    End Sub

    Private Sub ViewStudents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.School.Students)

    End Sub

    Private Sub bnAdd_Click(sender As Object, e As EventArgs) Handles bnAdd.Click
        AddStudent.Show() 'View Add Student form
        ViewStudents_Load(sender, e)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ViewStudents_Load(sender, e) 'Refresh the Table
    End Sub

    Private Sub bnEdit_Click(sender As Object, e As EventArgs) Handles bnEdit.Click ''Open New Form
        'Dim edits As New EditStudent
        'edits.SAge.Value = DataGridView1.CurrentRow.Cells(2).Value.ToString()
        'EditStudent.Show()
        'Dim db As New InfoDBDataContext
        'Dim thisStudent = From p In db.Students
        '                  Where p.STUDENTINF = Val(DataGridView1.CurrentRow.Cells(0).Value)
        '                  Select p
        'Dim newStudent As New Students With {.Address = SAddress.Text, .Age = SAge.Value, .Class = SEClass.Text, .ContactNumber = SPhone.Text, .EmailAddress = SEmail.Text, .StudentName = StudentN.Text, .Gender = SGender.Text, .StudentID = StudentID.Text}
        'db.Students.InsertOnSubmit(newStudent) 'These changes are for the newstudent
        'db.SubmitChanges()
        'Dim newDataRow As DataGridViewRow
        '  newDataRow = DataGridView1.Rows(Index)
        'newDataRow.Cells(0).Value = StudentName.Text
        'Try
        '    Dim db As New InfoDBDataContext
        '    Dim thisStudent = From p In db.Students
        '                      Where p.STUDENTINF = Val(DataGridView1.CurrentRow.Cells(0).Value)
        '                      Select p
        '    Dim NewStudent As New Students With {.Address = Val(DataGridView1.CurrentRow.Cells(0).Value)} ', .Age = SAge.Value, .Class = SEClass.Text, .ContactNumber = SPhone.Text, .EmailAddress = SEmail.Text, .StudentName = StudentN.Text, .Gender = SGender.Text, .StudentID = StudentID.Text}

        '    db.Students.InsertOnSubmit(thisStudent.FirstOrDefault)
        '    db.SubmitChanges()
        '    MsgBox("Okay, the student information has been updated!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        '    ViewStudents_Load(sender, e)
        'Catch ex As Exception
        '    MsgBox("No student selected.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        'End Try
        EditStudent.ShowDialog()

    End Sub

    Private Sub bnDelete_Click(sender As Object, e As EventArgs) Handles bnDelete.Click 'For deleting a record
        Try
            Dim db As New InfoDBDataContext 'load up the database
            Dim thisStudent = From p In db.Students
                              Where p.STUDENTINF = Val(DataGridView1.CurrentRow.Cells(0).Value)
                              Select p 'Check to see if the current cell has a value

            db.Students.DeleteOnSubmit(thisStudent.FirstOrDefault) 'delete the cell info
            db.SubmitChanges() 'save these changes
            MsgBox("Okay, the student has been deleted!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            ViewStudents_Load(sender, e) 'refresh the table
        Catch ex As Exception 'Otherwise, there is no data in the table to delete
            MsgBox("No student selected.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End Try
    End Sub

    Private Sub StudentName_TextChanged(sender As Object, e As EventArgs) 
        'Me.StudentName.Text = Val(DataGridView1.CurrentRow.Cells(0).Value)
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) 

    End Sub
End Class