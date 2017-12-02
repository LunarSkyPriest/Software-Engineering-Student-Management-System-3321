Public Class EditStudent

    Private Sub EditStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'School.Students' table. You can move, or remove it, as needed.
        Me.StudentsTableAdapter.Fill(Me.School.Students)

    End Sub
    'Unused functions as usual
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SGender.SelectedIndexChanged

    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles SAge.ValueChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub 'end of unused functions

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles bnSearch.Click 'Searching by the student's ID num
        'Ideally, it was to pull items into the text fields for editing
        If StudentID.Text = "" Then
            MsgBox("You must enter a Student ID!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
        End If

        Dim db As New InfoDBDataContext 'Calling up the database
        Dim CheckStudentDetails = From p In db.Students 'Check the students details, from the StudentInfo Table
                                  Where p.[StudentID] = StudentID.Text 'Check to see if the StudentID is taken
                                  Select p
        If CheckStudentDetails.Count = 0 Then ' if the username or password isnt found
            MsgBox("Student ID not found!", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly)
        ElseIf CheckStudentDetails.Count <> 0 Then 'If there is already a value for the StudentID in the table, 
            MsgBox("Edit the student's information using the text fields below.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            'SEmail.Text
            'SPhone.Clear()
            'StudentID.Clear()
            'StudentN.Clear()
            ' With {StudentN = .StudentName}
            'Students.StudentName = StudentN.Text
            ' Me.StudentN.Text = CheckStudentDetails.Rows(0).Item("StudentName")
            'SAddress.Text = ("Address").ToString()
            'SEClass.Text = ""
            'SGender.Text = ""
            'SAge.Value = { .Age}
            'StudentID.Focus()

        End If
        Exit Sub
    End Sub 'Not fully active

    Private Sub bnClear_Click(sender As Object, e As EventArgs) Handles bnClear.Click 'Clear all fields
        SEmail.Clear()
        SPhone.Clear()
        StudentID.Text = ""
        StudentN.Clear()
        SAddress.Clear()
        SEClass.Text = ""
        SGender.Text = ""
        SAge.Value = 0
        StudentID.Focus()
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close() 'Close menu
    End Sub

    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        Dim db As New InfoDBDataContext
        Dim CheckStudentDetails = From p In db.Students 'Check the students details, from the StudentInfo Table
                                  Where p.[StudentID] = StudentID.Text 'Check to see if the StudentID is taken
                                  Select p
        If CheckStudentDetails.Count <> 0 Then 'If there is already a value for the StudentID in the table, send an error
            Dim NewStudent As New Students With {.Address = SAddress.Text, .Age = SAge.Value, .Class = SEClass.Text, .ContactNumber = SPhone.Text, .EmailAddress = SEmail.Text, .StudentName = StudentN.Text, .Gender = SGender.Text}
            db.Students.InsertOnSubmit(NewStudent)
            db.SubmitChanges() 'append changes
            MsgBox("The changes have been appended!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
            Exit Sub
        End If

    End Sub 'Ideally to append changes to the database, currently only overwrites because of as new
End Class