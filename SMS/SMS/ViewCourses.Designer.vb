<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewCourses
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OverallDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GPADataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.School = New SMS.School()
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CoursesTableAdapter = New SMS.SchoolTableAdapters.CoursesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnSearch = New System.Windows.Forms.TextBox()
        Me.bnAddCourses = New System.Windows.Forms.Button()
        Me.bnDelete = New System.Windows.Forms.Button()
        Me.bnRefresh = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.ExamDataGridViewTextBoxColumn, Me.OverallDataGridViewTextBoxColumn, Me.GPADataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CoursesBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(405, 173)
        Me.DataGridView1.TabIndex = 3
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class"
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        Me.ClassDataGridViewTextBoxColumn.Visible = False
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        Me.CourseDataGridViewTextBoxColumn.Width = 160
        '
        'ExamDataGridViewTextBoxColumn
        '
        Me.ExamDataGridViewTextBoxColumn.DataPropertyName = "Exam"
        Me.ExamDataGridViewTextBoxColumn.HeaderText = "Exam"
        Me.ExamDataGridViewTextBoxColumn.Name = "ExamDataGridViewTextBoxColumn"
        Me.ExamDataGridViewTextBoxColumn.Visible = False
        '
        'OverallDataGridViewTextBoxColumn
        '
        Me.OverallDataGridViewTextBoxColumn.DataPropertyName = "Overall"
        Me.OverallDataGridViewTextBoxColumn.HeaderText = "Overall"
        Me.OverallDataGridViewTextBoxColumn.Name = "OverallDataGridViewTextBoxColumn"
        Me.OverallDataGridViewTextBoxColumn.Visible = False
        '
        'GPADataGridViewTextBoxColumn
        '
        Me.GPADataGridViewTextBoxColumn.DataPropertyName = "GPA"
        Me.GPADataGridViewTextBoxColumn.HeaderText = "GPA"
        Me.GPADataGridViewTextBoxColumn.Name = "GPADataGridViewTextBoxColumn"
        Me.GPADataGridViewTextBoxColumn.Visible = False
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.Visible = False
        '
        'CoursesBindingSource1
        '
        Me.CoursesBindingSource1.DataMember = "Courses"
        Me.CoursesBindingSource1.DataSource = Me.School
        '
        'School
        '
        Me.School.DataSetName = "School"
        Me.School.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(423, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 20)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search by Student ID:"
        '
        'bnSearch
        '
        Me.bnSearch.Location = New System.Drawing.Point(426, 30)
        Me.bnSearch.Name = "bnSearch"
        Me.bnSearch.Size = New System.Drawing.Size(161, 20)
        Me.bnSearch.TabIndex = 5
        '
        'bnAddCourses
        '
        Me.bnAddCourses.Location = New System.Drawing.Point(426, 56)
        Me.bnAddCourses.Name = "bnAddCourses"
        Me.bnAddCourses.Size = New System.Drawing.Size(161, 39)
        Me.bnAddCourses.TabIndex = 6
        Me.bnAddCourses.Text = "Add Courses"
        Me.bnAddCourses.UseVisualStyleBackColor = True
        '
        'bnDelete
        '
        Me.bnDelete.Location = New System.Drawing.Point(426, 101)
        Me.bnDelete.Name = "bnDelete"
        Me.bnDelete.Size = New System.Drawing.Size(161, 39)
        Me.bnDelete.TabIndex = 7
        Me.bnDelete.Text = "Remove Courses"
        Me.bnDelete.UseVisualStyleBackColor = True
        '
        'bnRefresh
        '
        Me.bnRefresh.Location = New System.Drawing.Point(426, 146)
        Me.bnRefresh.Name = "bnRefresh"
        Me.bnRefresh.Size = New System.Drawing.Size(161, 39)
        Me.bnRefresh.TabIndex = 8
        Me.bnRefresh.Text = "Refresh Table"
        Me.bnRefresh.UseVisualStyleBackColor = True
        '
        'ViewCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(592, 195)
        Me.Controls.Add(Me.bnRefresh)
        Me.Controls.Add(Me.bnDelete)
        Me.Controls.Add(Me.bnAddCourses)
        Me.Controls.Add(Me.bnSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewCourses"
        Me.Text = "View Courses"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents School As School
    Friend WithEvents CoursesBindingSource As BindingSource
    Friend WithEvents CoursesTableAdapter As SchoolTableAdapters.CoursesTableAdapter
    Friend WithEvents CoursesBindingSource1 As BindingSource
    Friend WithEvents Label1 As Label
    Friend WithEvents bnSearch As TextBox
    Friend WithEvents bnAddCourses As Button
    Friend WithEvents bnDelete As Button
    Friend WithEvents bnRefresh As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ExamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OverallDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GPADataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
