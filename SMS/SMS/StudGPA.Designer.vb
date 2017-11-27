<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudGPA
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudGPA))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Course4 = New System.Windows.Forms.TextBox()
        Me.Course3 = New System.Windows.Forms.TextBox()
        Me.Course5 = New System.Windows.Forms.TextBox()
        Me.bnClear = New System.Windows.Forms.Button()
        Me.bnCalculate = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.Course1 = New System.Windows.Forms.TextBox()
        Me.Course2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Hour1 = New System.Windows.Forms.TextBox()
        Me.Hour2 = New System.Windows.Forms.TextBox()
        Me.Hour3 = New System.Windows.Forms.TextBox()
        Me.Hour4 = New System.Windows.Forms.TextBox()
        Me.Hour5 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.myGPA = New System.Windows.Forms.Label()
        Me.LetterG1 = New System.Windows.Forms.Label()
        Me.LetterG2 = New System.Windows.Forms.Label()
        Me.LetterG3 = New System.Windows.Forms.Label()
        Me.LetterG4 = New System.Windows.Forms.Label()
        Me.LetterG5 = New System.Windows.Forms.Label()
        Me.bnHours = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(398, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Grades:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(327, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 32)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Course 1:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(327, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 32)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Course 3:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Course4
        '
        Me.Course4.Location = New System.Drawing.Point(402, 159)
        Me.Course4.Name = "Course4"
        Me.Course4.Size = New System.Drawing.Size(63, 20)
        Me.Course4.TabIndex = 3
        '
        'Course3
        '
        Me.Course3.Location = New System.Drawing.Point(402, 127)
        Me.Course3.Name = "Course3"
        Me.Course3.Size = New System.Drawing.Size(63, 20)
        Me.Course3.TabIndex = 4
        '
        'Course5
        '
        Me.Course5.Location = New System.Drawing.Point(402, 191)
        Me.Course5.Name = "Course5"
        Me.Course5.Size = New System.Drawing.Size(63, 20)
        Me.Course5.TabIndex = 5
        '
        'bnClear
        '
        Me.bnClear.Location = New System.Drawing.Point(163, 237)
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(114, 30)
        Me.bnClear.TabIndex = 6
        Me.bnClear.Text = "C L E A R"
        Me.bnClear.UseVisualStyleBackColor = True
        '
        'bnCalculate
        '
        Me.bnCalculate.Location = New System.Drawing.Point(499, 264)
        Me.bnCalculate.Name = "bnCalculate"
        Me.bnCalculate.Size = New System.Drawing.Size(108, 38)
        Me.bnCalculate.TabIndex = 7
        Me.bnCalculate.Text = "C A L C U L A T E "
        Me.bnCalculate.UseVisualStyleBackColor = True
        '
        'bnCancel
        '
        Me.bnCancel.Location = New System.Drawing.Point(293, 264)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(114, 38)
        Me.bnCancel.TabIndex = 8
        Me.bnCancel.Text = "C A N C E L"
        Me.bnCancel.UseVisualStyleBackColor = True
        '
        'Course1
        '
        Me.Course1.Location = New System.Drawing.Point(402, 63)
        Me.Course1.Name = "Course1"
        Me.Course1.Size = New System.Drawing.Size(63, 20)
        Me.Course1.TabIndex = 9
        '
        'Course2
        '
        Me.Course2.Location = New System.Drawing.Point(402, 95)
        Me.Course2.Name = "Course2"
        Me.Course2.Size = New System.Drawing.Size(63, 20)
        Me.Course2.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(164, 32)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Select your courses:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Items.AddRange(New Object() {"Calculus 5x", "DBZ Seminar", "Software Engineering", "Rugrats 101", "C++ 1-3 Ultimate Edition", "Visual Basics", "The Mathematics of Quantum Neutrino Fields", "Web Programming", "Operating Systems", "Data Mining in Utah", "Pseudorandomness"})
        Me.CheckedListBox1.Location = New System.Drawing.Point(12, 40)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(291, 191)
        Me.CheckedListBox1.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(327, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 32)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Course 2:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(327, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 32)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Course 4:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(327, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 32)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Course 5:"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(598, 12)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 32)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Hours:"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Hour1
        '
        Me.Hour1.Location = New System.Drawing.Point(584, 63)
        Me.Hour1.Name = "Hour1"
        Me.Hour1.Size = New System.Drawing.Size(81, 20)
        Me.Hour1.TabIndex = 18
        Me.Hour1.Text = "0"
        '
        'Hour2
        '
        Me.Hour2.Location = New System.Drawing.Point(584, 95)
        Me.Hour2.Name = "Hour2"
        Me.Hour2.Size = New System.Drawing.Size(81, 20)
        Me.Hour2.TabIndex = 19
        Me.Hour2.Text = "0"
        '
        'Hour3
        '
        Me.Hour3.Location = New System.Drawing.Point(584, 127)
        Me.Hour3.Name = "Hour3"
        Me.Hour3.Size = New System.Drawing.Size(81, 20)
        Me.Hour3.TabIndex = 20
        Me.Hour3.Text = "0"
        '
        'Hour4
        '
        Me.Hour4.Location = New System.Drawing.Point(584, 159)
        Me.Hour4.Name = "Hour4"
        Me.Hour4.Size = New System.Drawing.Size(81, 20)
        Me.Hour4.TabIndex = 21
        Me.Hour4.Text = "0"
        '
        'Hour5
        '
        Me.Hour5.Location = New System.Drawing.Point(584, 191)
        Me.Hour5.Name = "Hour5"
        Me.Hour5.Size = New System.Drawing.Size(81, 20)
        Me.Hour5.TabIndex = 22
        Me.Hour5.Text = "0"
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(468, 226)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 32)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "GPA:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'myGPA
        '
        Me.myGPA.BackColor = System.Drawing.Color.Transparent
        Me.myGPA.Font = New System.Drawing.Font("Century Gothic", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.myGPA.Location = New System.Drawing.Point(522, 226)
        Me.myGPA.Name = "myGPA"
        Me.myGPA.Size = New System.Drawing.Size(68, 32)
        Me.myGPA.TabIndex = 24
        Me.myGPA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LetterG1
        '
        Me.LetterG1.BackColor = System.Drawing.Color.Transparent
        Me.LetterG1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterG1.Location = New System.Drawing.Point(471, 56)
        Me.LetterG1.Name = "LetterG1"
        Me.LetterG1.Size = New System.Drawing.Size(71, 32)
        Me.LetterG1.TabIndex = 25
        Me.LetterG1.Text = "-"
        Me.LetterG1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LetterG2
        '
        Me.LetterG2.BackColor = System.Drawing.Color.Transparent
        Me.LetterG2.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterG2.Location = New System.Drawing.Point(471, 88)
        Me.LetterG2.Name = "LetterG2"
        Me.LetterG2.Size = New System.Drawing.Size(71, 32)
        Me.LetterG2.TabIndex = 26
        Me.LetterG2.Text = "-"
        Me.LetterG2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LetterG3
        '
        Me.LetterG3.BackColor = System.Drawing.Color.Transparent
        Me.LetterG3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterG3.Location = New System.Drawing.Point(471, 120)
        Me.LetterG3.Name = "LetterG3"
        Me.LetterG3.Size = New System.Drawing.Size(71, 32)
        Me.LetterG3.TabIndex = 27
        Me.LetterG3.Text = "-"
        Me.LetterG3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LetterG4
        '
        Me.LetterG4.BackColor = System.Drawing.Color.Transparent
        Me.LetterG4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterG4.Location = New System.Drawing.Point(471, 152)
        Me.LetterG4.Name = "LetterG4"
        Me.LetterG4.Size = New System.Drawing.Size(71, 32)
        Me.LetterG4.TabIndex = 28
        Me.LetterG4.Text = "-"
        Me.LetterG4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'LetterG5
        '
        Me.LetterG5.BackColor = System.Drawing.Color.Transparent
        Me.LetterG5.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LetterG5.Location = New System.Drawing.Point(471, 184)
        Me.LetterG5.Name = "LetterG5"
        Me.LetterG5.Size = New System.Drawing.Size(71, 32)
        Me.LetterG5.TabIndex = 29
        Me.LetterG5.Text = "-"
        Me.LetterG5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnHours
        '
        Me.bnHours.Location = New System.Drawing.Point(12, 237)
        Me.bnHours.Name = "bnHours"
        Me.bnHours.Size = New System.Drawing.Size(140, 30)
        Me.bnHours.TabIndex = 30
        Me.bnHours.Text = "C O U R S E   H O U R S"
        Me.bnHours.UseVisualStyleBackColor = True
        '
        'StudGPA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(680, 314)
        Me.Controls.Add(Me.bnHours)
        Me.Controls.Add(Me.LetterG5)
        Me.Controls.Add(Me.LetterG4)
        Me.Controls.Add(Me.LetterG3)
        Me.Controls.Add(Me.LetterG2)
        Me.Controls.Add(Me.LetterG1)
        Me.Controls.Add(Me.myGPA)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Hour5)
        Me.Controls.Add(Me.Hour4)
        Me.Controls.Add(Me.Hour3)
        Me.Controls.Add(Me.Hour2)
        Me.Controls.Add(Me.Hour1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Course5)
        Me.Controls.Add(Me.Course4)
        Me.Controls.Add(Me.Course2)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Course1)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnCalculate)
        Me.Controls.Add(Me.bnClear)
        Me.Controls.Add(Me.Course3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.Name = "StudGPA"
        Me.Text = "My GPA Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Course4 As TextBox
    Friend WithEvents Course3 As TextBox
    Friend WithEvents Course5 As TextBox
    Friend WithEvents bnClear As Button
    Friend WithEvents bnCalculate As Button
    Friend WithEvents bnCancel As Button
    Friend WithEvents Course1 As TextBox
    Friend WithEvents Course2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Hour1 As TextBox
    Friend WithEvents Hour2 As TextBox
    Friend WithEvents Hour3 As TextBox
    Friend WithEvents Hour4 As TextBox
    Friend WithEvents Hour5 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents myGPA As Label
    Friend WithEvents LetterG1 As Label
    Friend WithEvents LetterG2 As Label
    Friend WithEvents LetterG3 As Label
    Friend WithEvents LetterG4 As Label
    Friend WithEvents LetterG5 As Label
    Friend WithEvents bnHours As Button
End Class
