Public Class AddStudent ' 11/05 menu to add a new student to the 
    'beginning of unused subs, these are just here in case we want functionality for when the user is typing
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SGender.SelectedIndexChanged

    End Sub

    Private Sub AddStudent_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub StudentN_TextChanged(sender As Object, e As EventArgs) Handles StudentN.TextChanged

    End Sub

    Private Sub SAge_ValueChanged(sender As Object, e As EventArgs) Handles SAge.ValueChanged

    End Sub

    Private Sub SAddress_TextChanged(sender As Object, e As EventArgs) Handles SAddress.TextChanged

    End Sub

    Private Sub SPhone_TextChanged(sender As Object, e As EventArgs) Handles SPhone.TextChanged

    End Sub

    Private Sub SEmail_TextChanged(sender As Object, e As EventArgs) Handles SEmail.TextChanged

    End Sub

    Private Sub StudentID_TextChanged(sender As Object, e As EventArgs) Handles StudentID.TextChanged

    End Sub

    Private Sub SEClass_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SEClass.SelectedIndexChanged

    End Sub
    'End of unused subs
    'When save button is clicked
    Private Sub bnSave_Click(sender As Object, e As EventArgs) Handles bnSave.Click
        'Throw error for when the crucial fields are left empty, AKA, Student ID, Age,Name, Gender, and Classification
        If StudentID.Text = "" Or StudentN.Text = "" Or SGender.Text = "" Or SEClass.Text = "" Or SAge.Value = 0 Then
            MsgBox("Student ID, Full Name, Gender, ans Class are Required Fields!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        Dim db As New InfoDBDataContext 'Calling up the database
        Dim CheckStudentDetails = From p In db.Students 'Check the students details, from the StudentInfo Table
                                  Where p.[StudentID] = StudentID.Text 'Check to see if the StudentID is taken
                                  Select p
        If CheckStudentDetails.Count <> 0 Then 'If there is already a value for the StudentID in the table, send an error
            MsgBox("The Student ID entered is already in use, please use a new Student ID number!", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly)
            Exit Sub
        End If
        'Now add the changes to the StudentInfo database, aka Name, ID, Address, Age, Gender, Email, Classifcation, and Number
        Dim NewStudent As New Students With {.Address = SAddress.Text, .Age = SAge.Value, .Class = SEClass.Text, .ContactNumber = SPhone.Text, .EmailAddress = SEmail.Text, .StudentName = StudentN.Text, .Gender = SGender.Text, .StudentID = StudentID.Text}
        db.Students.InsertOnSubmit(NewStudent) 'These changes are for the newstudent
        db.SubmitChanges() 'append changes
        MsgBox("Time to welcome our new Student!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly)
        bnClear_Click(sender, e) 'Clear after adding

    End Sub

    Private Sub bnClear_Click(sender As Object, e As EventArgs) Handles bnClear.Click 'When wanting to clear every field
        SEmail.Clear()
        SPhone.Clear()
        StudentID.Clear()
        StudentN.Clear()
        SAddress.Clear()
        SEClass.Text = ""
        SGender.Text = ""
        SAge.Value = 0
        StudentID.Focus()
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click 'Cancel Button closes the AddStudent Menu/Form
        Me.Close()
    End Sub
End Class