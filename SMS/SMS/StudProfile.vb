Public Class StudProfile
    'Showing the database information
    Private Sub bnExit_Click(sender As Object, e As EventArgs) Handles bnExit.Click
        Me.Close() 'close menu
    End Sub

    Private Sub StudProfile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim db As New InfoDBDataContext
        'Dim nProfile = From p In db.Students 'testing various fill label methods
        'Dim uProfile = From p In db.Users
        StudentsTableAdapter1.Fill(Me.School1.Students)


        'Dim CheckUser = From p In db.Users Where p.Username 


        'SName.Text = 
    End Sub


End Class