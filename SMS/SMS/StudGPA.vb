Public Class StudGPA
    'Heavy Calculation form
    'Below are integers to perform the calculations
    Dim okGrade As Decimal
    Dim LetterG As String
    Dim CreditH As Double
    'Setting the Values of the letter grades
    Dim A As Double = 4.0
    Dim Amin As Double = 3.67 'Plus and Minus are used on the normal scale, not so much here
    Dim Bplus As Double = 3.33 'These values are based off the normal GPA scale
    Dim B As Double = 3.0
    Dim Bmin As Double = 2.67
    Dim Cplus As Double = 2.33
    Dim C As Double = 2.0
    Dim Cmin As Double = 1.67
    Dim D As Double = 1.0
    Dim F As Double = 0.0
    'The calculated integers
    Dim calc As Double = 0
    Dim tcalc As Double = 0
    Dim tcredith As Double = 0
    Dim tgpa As Double = 0


    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CheckedListBox1.SelectedIndexChanged
        For i = 4 To CheckedListBox1.Items.Count - 1 'Only allow up to 5 items to be checked at once
            CheckedListBox1.SetItemCheckState(i, CheckState.Unchecked)
        Next 'If the user attempts to select 6 items, then the "6th" item they select becomes the 5th
        CheckedListBox1.SetItemCheckState(CheckedListBox1.SelectedIndex, CheckState.Checked)
    End Sub

    Private Sub StudGPA_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Loader
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bnCalculate.Click 'Calculate their GPA
        'Setting the initital values to 0 and empty
        LetterG = ""
        CreditH = 0
        calc = 0
        tcalc = 0
        tcredith = 0
        tgpa = 0
        'Comparing the labels (Letter grade) and the hours (textbox)
        Dim part1 = New Label()
        Dim part2 = New TextBox()
        'There are only 5 cases, since the user can only have up to 5 courses
        For i As Integer = 1 To 5
            Select Case i
                Case 1
                    part1 = LetterG1
                    part2 = Hour1
                    Exit Select
                Case 2
                    part1 = LetterG2
                    part2 = Hour2
                    Exit Select
                Case 3
                    part1 = LetterG3
                    part2 = Hour3
                    Exit Select
                Case 4
                    part1 = LetterG4
                    part2 = Hour4
                    Exit Select
                Case 5
                    part1 = LetterG5
                    part2 = Hour5
                    Exit Select
            End Select
            'Set the letter grades and credit hours
            LetterG = part1.Text
            CreditH = [Double].Parse(part2.Text.ToString())

            If LetterG <> [String].Empty AndAlso CreditH <> 0 Then 'As long as they're not empty or 0, calculate
                Select Case LetterG 'Depending on which letter grade, the calculation will be the credit hours * letter grade
                    Case "A"
                        calc = CreditH * A
                        Exit Select
                    Case "B"
                        calc = CreditH * B
                        Exit Select
                    Case "C"
                        calc = CreditH * C
                        Exit Select
                    Case "D"
                        calc = CreditH * D
                        Exit Select
                    Case "F"
                        calc = CreditH * F
                        Exit Select
                    Case ""
                        Exit Select
                    Case "-"
                        Exit Select
                End Select
                tcredith = tcredith + CreditH 'total credit hours = total credit + credit hours
                tcalc = tcalc + calc 'total calculated value will be the sum too
            End If
        Next
        tgpa = tcalc / tcredith 'the gpa is their divisor
        myGPA.Text = tgpa.ToString("#.00") 'set the gpa as the label
    End Sub

    Private Sub Hour1_TextChanged(sender As Object, e As EventArgs) Handles Hour1.TextChanged
        'Unused credit hour function
    End Sub

    'All 5 course boxes just compared the inputted value num, and sets the label as the letter grade
    Private Sub Course1_TextChanged(sender As Object, e As EventArgs) Handles Course1.TextChanged
        okGrade = Val(Course1.Text)
        If (okGrade >= 90) Then LetterG1.Text = "A"
        If (okGrade <= 89) Then LetterG1.Text = "B"
        If (okGrade <= 79) Then LetterG1.Text = "C"
        If (okGrade <= 69) Then LetterG1.Text = "D"
        If (okGrade <= 50) Then LetterG1.Text = "F"
    End Sub

    Private Sub Course2_TextChanged(sender As Object, e As EventArgs) Handles Course2.TextChanged
        okGrade = Val(Course2.Text)
        If (okGrade >= 90) Then LetterG2.Text = "A"
        If (okGrade <= 89) Then LetterG2.Text = "B"
        If (okGrade <= 79) Then LetterG2.Text = "C"
        If (okGrade <= 69) Then LetterG2.Text = "D"
        If (okGrade <= 50) Then LetterG2.Text = "F"
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Course3.TextChanged
        okGrade = Val(Course3.Text)
        If (okGrade >= 90) Then LetterG3.Text = "A"
        If (okGrade <= 89) Then LetterG3.Text = "B"
        If (okGrade <= 79) Then LetterG3.Text = "C"
        If (okGrade <= 69) Then LetterG3.Text = "D"
        If (okGrade <= 50) Then LetterG3.Text = "F"
    End Sub

    Private Sub Course4_TextChanged(sender As Object, e As EventArgs) Handles Course4.TextChanged
        okGrade = Val(Course4.Text)
        If (okGrade >= 90) Then LetterG4.Text = "A"
        If (okGrade <= 89) Then LetterG4.Text = "B"
        If (okGrade <= 79) Then LetterG4.Text = "C"
        If (okGrade <= 69) Then LetterG4.Text = "D"
        If (okGrade <= 50) Then LetterG4.Text = "F"
    End Sub

    Private Sub Course5_TextChanged(sender As Object, e As EventArgs) Handles Course5.TextChanged

        okGrade = Val(Course5.Text)
        If (okGrade >= 90) Then LetterG5.Text = "A"
        If (okGrade <= 89) Then LetterG5.Text = "B"
        If (okGrade <= 79) Then LetterG5.Text = "C"
        If (okGrade <= 69) Then LetterG5.Text = "D"
        If (okGrade >= 0 And okGrade <= 50) Then LetterG5.Text = "F"
    End Sub

    Private Sub bnCancel_Click(sender As Object, e As EventArgs) Handles bnCancel.Click
        Me.Close() 'close menu
    End Sub

    Private Sub bnClear_Click(sender As Object, e As EventArgs) Handles bnClear.Click 'clear all fields
        CheckedListBox1.Text = ""
        Course1.Text = ""
        Course2.Text = ""
        Course3.Text = ""
        Course4.Text = ""
        Course5.Text = ""
        Hour1.Text = "0"
        Hour2.Text = "0"
        Hour3.Text = "0"
        Hour4.Text = "0"
        Hour5.Text = "0"
        LetterG1.Text = "-"
        LetterG2.Text = "-"
        LetterG3.Text = "-"
        LetterG4.Text = "-"
        LetterG5.Text = "-"
        myGPA.Text = ""
    End Sub

    Private Sub bnHours_Click(sender As Object, e As EventArgs) Handles bnHours.Click
        CourseDes.ShowDialog() 'show the course description, for hours, mostly cosmetic
    End Sub
End Class