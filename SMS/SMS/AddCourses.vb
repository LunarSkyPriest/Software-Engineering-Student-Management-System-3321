Public Class AddCourses
    Private Sub AddCourses_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.School.Students)

    End Sub
    'Unused Functions, no need
    Private Sub SID_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub SName_TextChanged(sender As Object, e As EventArgs) Handles SName.TextChanged

    End Sub

    Private Sub SCourses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SCourses.SelectedIndexChanged

    End Sub 'End of Unused Functions

    Private Sub bnClear_Click(sender As Object, e As EventArgs) Handles bnClear.Click
        SName.Clear()
        SCourses.Text = ""
        SID.Focus()
    End Sub

    Private Sub bnInfo_Click(sender As Object, e As EventArgs) Handles bnInfo.Click
        CourseDes.ShowDialog()
    End Sub

    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        If SID.Text = "" Or SName.Text = "" Or SCourses.Text = "" Then
            MsgBox("Student ID, Student Name, Courses are required fields!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New InfoDBDataContext 'Calling up the database
        Dim CheckStudentDetails = From p In db.Students 'Check the students details, from the StudentInfo Table
                                  Where p.[StudentID] = SID.Text 'Check to see if the StudentID is in the DB
                                  Select p
        If CheckStudentDetails.Count = 0 Then 'If there isn't already a value for the StudentID in the table, send an error
            MsgBox("This student ID does not exist in our system!!!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        'To make sure a student isn't already enrolled in the course
        'Dim CheckCourseDetails = From p In db.Courses 'Check the students details, from the Courses Table
        '                         Where p.[Course] = SCourses.Text And p.[StudentID] = SID.Text 'Check to see if the StudentID is already with that Course
        '                         Select p
        'If CheckStudentDetails.Count <> 0 Then 'If there is already a value for the StudentID + Course in the table, send an error
        '    MsgBox("This student is already enrolled in that course!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End If

        'Now add the changes to the Courses database, including the Student's ID, Name, and Course
        Dim NewCourse As New Courses With {.Course = SCourses.Text, .StudentName = SName.Text, .StudentID = SID.Text}
        db.Courses.InsertOnSubmit(NewCourse) 'These changes are for the newcourse
        db.SubmitChanges() 'append changes
        MsgBox("The course has been added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        SCourses.Text = ""
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close() ' Close out
    End Sub
End Class