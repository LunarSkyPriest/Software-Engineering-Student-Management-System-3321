Public Class AddGrades
    Private Sub AddGrades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Courses' table. You can move, or remove it, as needed.
        Me.CoursesTableAdapter.Fill(Me.School.Courses)
        'TODO: This line of code loads data into the 'School.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.School.Students)
        'TODO: This line of code loads data into the 'School.Grades' table. You can move, or remove it, as needed.
        Me.GradesTableAdapter.Fill(Me.School.Grades)
        'HWGrade.Text = 0
        'ExamGrade.Text = 0
    End Sub

    Private Sub SID_SelectedIndexChanged(sender As Object, e As EventArgs)
        'Unused, keep incase of changing based off of Student ID
    End Sub

    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        If SID.Text = "" Or SCourses.Text = "" Then
            MsgBox("Student ID and Course are required fields!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New InfoDBDataContext 'Calling up the database
        Dim CheckCourse = From p In db.Courses 'Check the students details, from the StudentInfo Table
                          Where p.[StudentID] = SID.Text 'Check to see if the StudentID is in the DB
                          Select p
        Dim CheckCourse2 = From p In db.Courses
                           Where p.Course = SCourses.Text
        If CheckCourse.Count = 0 And CheckCourse2.Count = 0 Then 'If there isn't already a value for the StudentID in the table, send an error
            MsgBox("This student is not enrolled in that course.", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

        'Unused, another method of avoiding students not enrolled
        'Dim CheckCourseDetails = From p In db.Courses 'Check the students details, from the Courses Table
        '                         Where p.[Course] = SCourses.Text And p.[StudentID] = SID.Text 'Check to see if the StudentID is already with that Course
        '                         Select p
        'If CheckStudentDetails.Count <> 0 Then 'If there is already a value for the StudentID + Course in the table, send an error
        '    MsgBox("This student is already enrolled in that course!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        '    Exit Sub
        'End If

        'Now add the changes to the Courses database, including the Student's ID, Name, and Course
        Dim NewGrade As New Grades With {.Course = SCourses.Text, .StudentID = SID.Text, .Homework = HWTitle.Text, .HomeworkG = HWGrade.Value, .Exam = ExamTitle.Text, .ExamG = ExamGrade.Value}
        db.Grades.InsertOnSubmit(NewGrade) 'These changes are for the newcourse
        db.SubmitChanges() 'append changes
        MsgBox("The grade(s) have been added!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        'Clear only the grades, so more can be added
        HWGrade.Value = 0
        HWTitle.Text = ""
        ExamTitle.Text = ""
        ExamGrade.Value = 0
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close() 'close out
    End Sub

    Private Sub bnClear_Click(sender As Object, e As EventArgs) Handles bnClear.Click
        'Clear all fields
        HWGrade.Value = 0
        HWTitle.Text = ""
        ExamTitle.Text = ""
        ExamGrade.Value = 0
        SCourses.Text = ""
        SID.Text = ""
    End Sub

    Private Sub HWGrade_TextChanged(sender As Object, e As EventArgs)
        'Unused event item
    End Sub
End Class