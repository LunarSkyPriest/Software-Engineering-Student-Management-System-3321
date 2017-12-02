Imports System.Windows.Forms

Public Class MainView
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click 'Edit Student
        EditStudent.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click 'Add Student
        AddStudent.ShowDialog()
        'AddStudent.MdiParent = Me 'Un-needed
    End Sub

    Private Sub ToolStripButton5_Click(sender As Object, e As EventArgs) Handles ToolStripButton5.Click 'View Students
        ViewStudents.Show()
    End Sub

    Private Sub MainView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ToolStripButton10_Click(sender As Object, e As EventArgs) Handles ToolStripButton10.Click 'View Courses
        ViewCourses.ShowDialog()
    End Sub

    Private Sub ToolStripButton11_Click(sender As Object, e As EventArgs) Handles ToolStripButton11.Click 'Add Courses
        AddCourses.ShowDialog()
    End Sub

    Private Sub ToolStripButton12_Click(sender As Object, e As EventArgs) Handles ToolStripButton12.Click 'View Grades
        ViewGrades.ShowDialog()
    End Sub

    Private Sub bnAbout_Click(sender As Object, e As EventArgs) Handles bnAbout.Click 'Show About
        AboutBox1.Show()
    End Sub

    Private Sub bnChange_Click(sender As Object, e As EventArgs) Handles bnChange.Click 'Change Password
        ChangePass.ShowDialog()
    End Sub

    Private Sub bnLogout_Click(sender As Object, e As EventArgs) Handles bnLogout.Click 'Close Menu to See LogIn
        Me.Close()
        Login.Show() 'View Login
        Me.Close()
    End Sub

    Private Sub bnExit_Click(sender As Object, e As EventArgs) Handles bnExit.Click 'Exit the Menu
        Me.Close()
    End Sub

    Private Sub ToolStripButton13_Click(sender As Object, e As EventArgs) Handles ToolStripButton13.Click 'Add Grades
        AddGrades.ShowDialog()
    End Sub
End Class
