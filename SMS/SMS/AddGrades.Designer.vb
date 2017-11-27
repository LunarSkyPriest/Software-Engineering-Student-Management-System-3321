<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddGrades
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddGrades))
        Me.HWTitle = New System.Windows.Forms.TextBox()
        Me.ExamTitle = New System.Windows.Forms.TextBox()
        Me.bnClear = New System.Windows.Forms.Button()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School = New SMS.School()
        Me.GradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GradesTableAdapter = New SMS.SchoolTableAdapters.GradesTableAdapter()
        Me.StudentsTableAdapter = New SMS.SchoolTableAdapters.StudentsTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoursesTableAdapter = New SMS.SchoolTableAdapters.CoursesTableAdapter()
        Me.SCourses = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.HWGrade = New System.Windows.Forms.NumericUpDown()
        Me.ExamGrade = New System.Windows.Forms.NumericUpDown()
        Me.StudentsBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SID = New System.Windows.Forms.ComboBox()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HWGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ExamGrade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'HWTitle
        '
        Me.HWTitle.Location = New System.Drawing.Point(195, 97)
        Me.HWTitle.Name = "HWTitle"
        Me.HWTitle.Size = New System.Drawing.Size(173, 20)
        Me.HWTitle.TabIndex = 2
        '
        'ExamTitle
        '
        Me.ExamTitle.Location = New System.Drawing.Point(195, 152)
        Me.ExamTitle.Name = "ExamTitle"
        Me.ExamTitle.Size = New System.Drawing.Size(173, 20)
        Me.ExamTitle.TabIndex = 5
        '
        'bnClear
        '
        Me.bnClear.Location = New System.Drawing.Point(28, 224)
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(75, 30)
        Me.bnClear.TabIndex = 8
        Me.bnClear.Text = "Clear"
        Me.bnClear.UseVisualStyleBackColor = True
        '
        'bnSave
        '
        Me.bnSave.Location = New System.Drawing.Point(195, 224)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(103, 30)
        Me.bnSave.TabIndex = 9
        Me.bnSave.Text = "Save"
        Me.bnSave.UseVisualStyleBackColor = True
        '
        'bnCancel
        '
        Me.bnCancel.Location = New System.Drawing.Point(317, 224)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(101, 30)
        Me.bnCancel.TabIndex = 10
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = True
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.School
        '
        'School
        '
        Me.School.DataSetName = "School"
        Me.School.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GradesBindingSource
        '
        Me.GradesBindingSource.DataMember = "Grades"
        Me.GradesBindingSource.DataSource = Me.School
        '
        'GradesTableAdapter
        '
        Me.GradesTableAdapter.ClearBeforeFill = True
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 23)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Student ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "Courses"
        Me.CoursesBindingSource.DataSource = Me.School
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'SCourses
        '
        Me.SCourses.FormattingEnabled = True
        Me.SCourses.Items.AddRange(New Object() {"Calculus 5x", "DBZ Seminar", "Software Engineering", "Rugrats 101", "C++ 1-3 Ultimate Edition", "Visual Basics", "The Mathematics of Quantum Neutrino Fields", "Web Programming", "Operating Systems", "Data Mining in Utah", "Pseudorandomness", "请通过我们", ""})
        Me.SCourses.Location = New System.Drawing.Point(130, 67)
        Me.SCourses.Name = "SCourses"
        Me.SCourses.Size = New System.Drawing.Size(261, 21)
        Me.SCourses.TabIndex = 14
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(57, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 23)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Course:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(58, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(140, 23)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Homework Title:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(151, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Grade:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(101, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 23)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Exam Title:"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(151, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 23)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Grade:"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'HWGrade
        '
        Me.HWGrade.DecimalPlaces = 2
        Me.HWGrade.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.HWGrade.Location = New System.Drawing.Point(213, 123)
        Me.HWGrade.Name = "HWGrade"
        Me.HWGrade.Size = New System.Drawing.Size(98, 20)
        Me.HWGrade.TabIndex = 20
        '
        'ExamGrade
        '
        Me.ExamGrade.DecimalPlaces = 2
        Me.ExamGrade.Increment = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.ExamGrade.Location = New System.Drawing.Point(213, 175)
        Me.ExamGrade.Name = "ExamGrade"
        Me.ExamGrade.Size = New System.Drawing.Size(98, 20)
        Me.ExamGrade.TabIndex = 21
        '
        'StudentsBindingSource1
        '
        Me.StudentsBindingSource1.DataMember = "Students"
        Me.StudentsBindingSource1.DataSource = Me.School
        '
        'SID
        '
        Me.SID.DataSource = Me.StudentsBindingSource
        Me.SID.DisplayMember = "StudentID"
        Me.SID.FormattingEnabled = True
        Me.SID.Location = New System.Drawing.Point(151, 35)
        Me.SID.Name = "SID"
        Me.SID.Size = New System.Drawing.Size(216, 21)
        Me.SID.TabIndex = 22
        '
        'AddGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(447, 263)
        Me.Controls.Add(Me.SID)
        Me.Controls.Add(Me.ExamGrade)
        Me.Controls.Add(Me.HWGrade)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.HWTitle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SCourses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.bnClear)
        Me.Controls.Add(Me.ExamTitle)
        Me.Controls.Add(Me.Label4)
        Me.DoubleBuffered = True
        Me.Name = "AddGrades"
        Me.Text = "Add Grades"
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HWGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ExamGrade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HWTitle As TextBox
    Friend WithEvents ExamTitle As TextBox
    Friend WithEvents bnClear As Button
    Friend WithEvents bnSave As Button
    Friend WithEvents bnCancel As Button
    Friend WithEvents School As School
    Friend WithEvents GradesBindingSource As BindingSource
    Friend WithEvents GradesTableAdapter As SchoolTableAdapters.GradesTableAdapter
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As SchoolTableAdapters.StudentsTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents CoursesBindingSource As BindingSource
    Friend WithEvents CoursesTableAdapter As SchoolTableAdapters.CoursesTableAdapter
    Friend WithEvents SCourses As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents HWGrade As NumericUpDown
    Friend WithEvents ExamGrade As NumericUpDown
    Friend WithEvents StudentsBindingSource1 As BindingSource
    Friend WithEvents SID As ComboBox
End Class
