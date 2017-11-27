<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewGrades
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
        Me.Search = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeworkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HomeworkG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Exam = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ExamG = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School = New SMS.School()
        Me.GradesTableAdapter = New SMS.SchoolTableAdapters.GradesTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bnAdd = New System.Windows.Forms.Button()
        Me.bnDelete = New System.Windows.Forms.Button()
        Me.bnUpdate = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(179, 12)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(141, 20)
        Me.Search.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.CourseDataGridViewTextBoxColumn, Me.HomeworkDataGridViewTextBoxColumn, Me.HomeworkG, Me.Exam, Me.ExamG})
        Me.DataGridView1.DataSource = Me.GradesBindingSource
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DataGridView1.Size = New System.Drawing.Size(646, 195)
        Me.DataGridView1.TabIndex = 1
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
        Me.StudentNameDataGridViewTextBoxColumn.Visible = False
        '
        'CourseDataGridViewTextBoxColumn
        '
        Me.CourseDataGridViewTextBoxColumn.DataPropertyName = "Course"
        Me.CourseDataGridViewTextBoxColumn.HeaderText = "Course"
        Me.CourseDataGridViewTextBoxColumn.Name = "CourseDataGridViewTextBoxColumn"
        '
        'HomeworkDataGridViewTextBoxColumn
        '
        Me.HomeworkDataGridViewTextBoxColumn.DataPropertyName = "Homework"
        Me.HomeworkDataGridViewTextBoxColumn.HeaderText = "Homework"
        Me.HomeworkDataGridViewTextBoxColumn.Name = "HomeworkDataGridViewTextBoxColumn"
        '
        'HomeworkG
        '
        Me.HomeworkG.DataPropertyName = "HomeworkG"
        Me.HomeworkG.HeaderText = "HomeworkG"
        Me.HomeworkG.Name = "HomeworkG"
        '
        'Exam
        '
        Me.Exam.DataPropertyName = "Exam"
        Me.Exam.HeaderText = "Exam"
        Me.Exam.Name = "Exam"
        '
        'ExamG
        '
        Me.ExamG.DataPropertyName = "ExamG"
        Me.ExamG.HeaderText = "ExamG"
        Me.ExamG.Name = "ExamG"
        '
        'GradesBindingSource
        '
        Me.GradesBindingSource.DataMember = "Grades"
        Me.GradesBindingSource.DataSource = Me.School
        '
        'School
        '
        Me.School.DataSetName = "School"
        Me.School.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GradesTableAdapter
        '
        Me.GradesTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search by Student ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnAdd
        '
        Me.bnAdd.Location = New System.Drawing.Point(326, 10)
        Me.bnAdd.Name = "bnAdd"
        Me.bnAdd.Size = New System.Drawing.Size(99, 23)
        Me.bnAdd.TabIndex = 3
        Me.bnAdd.Text = "Input Grades"
        Me.bnAdd.UseVisualStyleBackColor = True
        '
        'bnDelete
        '
        Me.bnDelete.Location = New System.Drawing.Point(431, 10)
        Me.bnDelete.Name = "bnDelete"
        Me.bnDelete.Size = New System.Drawing.Size(120, 23)
        Me.bnDelete.TabIndex = 5
        Me.bnDelete.Text = "Delete Grades"
        Me.bnDelete.UseVisualStyleBackColor = True
        '
        'bnUpdate
        '
        Me.bnUpdate.Location = New System.Drawing.Point(557, 10)
        Me.bnUpdate.Name = "bnUpdate"
        Me.bnUpdate.Size = New System.Drawing.Size(101, 23)
        Me.bnUpdate.TabIndex = 6
        Me.bnUpdate.Text = "Update List"
        Me.bnUpdate.UseVisualStyleBackColor = True
        '
        'ViewGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(675, 243)
        Me.Controls.Add(Me.bnUpdate)
        Me.Controls.Add(Me.bnDelete)
        Me.Controls.Add(Me.bnAdd)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewGrades"
        Me.Text = "View Grades"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Search As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents School As School
    Friend WithEvents GradesBindingSource As BindingSource
    Friend WithEvents GradesTableAdapter As SchoolTableAdapters.GradesTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents bnAdd As Button
    Friend WithEvents bnDelete As Button
    Friend WithEvents bnUpdate As Button
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomeworkDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HomeworkG As DataGridViewTextBoxColumn
    Friend WithEvents Exam As DataGridViewTextBoxColumn
    Friend WithEvents ExamG As DataGridViewTextBoxColumn
End Class
