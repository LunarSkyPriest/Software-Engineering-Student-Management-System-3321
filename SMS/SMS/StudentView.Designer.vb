<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentView
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudentView))
        Me.INFO = New System.Windows.Forms.Button()
        Me.School = New SMS.School()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New SMS.SchoolTableAdapters.StudentsTableAdapter()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MyCourses = New System.Windows.Forms.Button()
        Me.MyGrades = New System.Windows.Forms.Button()
        Me.bnLogout = New System.Windows.Forms.Button()
        Me.bnAbout = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'INFO
        '
        Me.INFO.Location = New System.Drawing.Point(44, 47)
        Me.INFO.Name = "INFO"
        Me.INFO.Size = New System.Drawing.Size(134, 39)
        Me.INFO.TabIndex = 0
        Me.INFO.Text = "P R O F I L E"
        Me.INFO.UseVisualStyleBackColor = True
        '
        'School
        '
        Me.School.DataSetName = "School"
        Me.School.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StudentsBindingSource
        '
        Me.StudentsBindingSource.DataMember = "Students"
        Me.StudentsBindingSource.DataSource = Me.School
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 373)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(626, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(42, 17)
        Me.ToolStripStatusLabel1.Text = "Online"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(262, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 27)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Welcome,"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MyCourses
        '
        Me.MyCourses.Location = New System.Drawing.Point(44, 145)
        Me.MyCourses.Name = "MyCourses"
        Me.MyCourses.Size = New System.Drawing.Size(134, 39)
        Me.MyCourses.TabIndex = 3
        Me.MyCourses.Text = "C O U R S E S"
        Me.MyCourses.UseVisualStyleBackColor = True
        '
        'MyGrades
        '
        Me.MyGrades.Location = New System.Drawing.Point(44, 241)
        Me.MyGrades.Name = "MyGrades"
        Me.MyGrades.Size = New System.Drawing.Size(134, 39)
        Me.MyGrades.TabIndex = 4
        Me.MyGrades.Text = "G R A D E S"
        Me.MyGrades.UseVisualStyleBackColor = True
        '
        'bnLogout
        '
        Me.bnLogout.Location = New System.Drawing.Point(480, 331)
        Me.bnLogout.Name = "bnLogout"
        Me.bnLogout.Size = New System.Drawing.Size(134, 39)
        Me.bnLogout.TabIndex = 5
        Me.bnLogout.Text = "L O G O U T"
        Me.bnLogout.UseVisualStyleBackColor = True
        '
        'bnAbout
        '
        Me.bnAbout.Location = New System.Drawing.Point(480, 241)
        Me.bnAbout.Name = "bnAbout"
        Me.bnAbout.Size = New System.Drawing.Size(134, 39)
        Me.bnAbout.TabIndex = 6
        Me.bnAbout.Text = "A B O U T"
        Me.bnAbout.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(44, 331)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(134, 39)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "C H A N G E  " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "P A S S W O R D"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(390, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(236, 22)
        Me.DateTimePicker1.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StudentsBindingSource, "StudentName", True))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(248, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 78)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Name Here"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(234, 47)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(134, 39)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "G P A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C A L C U L A T O R"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(626, 395)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.bnAbout)
        Me.Controls.Add(Me.bnLogout)
        Me.Controls.Add(Me.MyGrades)
        Me.Controls.Add(Me.MyCourses)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.INFO)
        Me.Name = "StudentView"
        Me.Text = "Student View"
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents INFO As Button
    Friend WithEvents School As School
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As SchoolTableAdapters.StudentsTableAdapter
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents MyCourses As Button
    Friend WithEvents MyGrades As Button
    Friend WithEvents bnLogout As Button
    Friend WithEvents bnAbout As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
