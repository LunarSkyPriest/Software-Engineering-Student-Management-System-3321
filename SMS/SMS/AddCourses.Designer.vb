<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCourses
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
        Me.SCourses = New System.Windows.Forms.ComboBox()
        Me.bnClear = New System.Windows.Forms.Button()
        Me.bnInfo = New System.Windows.Forms.Button()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SName = New System.Windows.Forms.TextBox()
        Me.SID = New System.Windows.Forms.ComboBox()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School = New SMS.School()
        Me.StudentsTableAdapter = New SMS.SchoolTableAdapters.StudentsTableAdapter()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SCourses
        '
        Me.SCourses.FormattingEnabled = True
        Me.SCourses.Items.AddRange(New Object() {"Calculus 5x", "DBZ Seminar", "Software Engineering", "Rugrats 101", "C++ 1-3 Ultimate Edition", "Visual Basics", "The Mathematics of Quantum Neutrino Fields", "Web Programming", "Operating Systems", "Data Mining in Utah", "Pseudorandomness", "请通过我们", ""})
        Me.SCourses.Location = New System.Drawing.Point(121, 82)
        Me.SCourses.Name = "SCourses"
        Me.SCourses.Size = New System.Drawing.Size(276, 21)
        Me.SCourses.TabIndex = 2
        '
        'bnClear
        '
        Me.bnClear.Location = New System.Drawing.Point(12, 228)
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(96, 36)
        Me.bnClear.TabIndex = 3
        Me.bnClear.Text = "Clear"
        Me.bnClear.UseVisualStyleBackColor = True
        '
        'bnInfo
        '
        Me.bnInfo.Location = New System.Drawing.Point(114, 228)
        Me.bnInfo.Name = "bnInfo"
        Me.bnInfo.Size = New System.Drawing.Size(96, 36)
        Me.bnInfo.TabIndex = 4
        Me.bnInfo.Text = "Descriptions"
        Me.bnInfo.UseVisualStyleBackColor = True
        '
        'bnSave
        '
        Me.bnSave.Location = New System.Drawing.Point(216, 228)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(96, 36)
        Me.bnSave.TabIndex = 5
        Me.bnSave.Text = "Save"
        Me.bnSave.UseVisualStyleBackColor = True
        '
        'bnCancel
        '
        Me.bnCancel.Location = New System.Drawing.Point(318, 228)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(96, 36)
        Me.bnCancel.TabIndex = 6
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Student ID:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(37, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 23)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Courses:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(26, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 23)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Student Name:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SName
        '
        Me.SName.Location = New System.Drawing.Point(160, 53)
        Me.SName.Name = "SName"
        Me.SName.Size = New System.Drawing.Size(202, 20)
        Me.SName.TabIndex = 10
        '
        'SID
        '
        Me.SID.DataSource = Me.StudentsBindingSource
        Me.SID.DisplayMember = "StudentID"
        Me.SID.FormattingEnabled = True
        Me.SID.Location = New System.Drawing.Point(146, 24)
        Me.SID.Name = "SID"
        Me.SID.Size = New System.Drawing.Size(216, 21)
        Me.SID.TabIndex = 23
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
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'AddCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SMS.My.Resources.Resources.foldogogo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(426, 276)
        Me.Controls.Add(Me.SID)
        Me.Controls.Add(Me.SCourses)
        Me.Controls.Add(Me.SName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.bnInfo)
        Me.Controls.Add(Me.bnClear)
        Me.DoubleBuffered = True
        Me.Name = "AddCourses"
        Me.Text = "Add Courses"
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SCourses As ComboBox
    Friend WithEvents bnClear As Button
    Friend WithEvents bnInfo As Button
    Friend WithEvents bnSave As Button
    Friend WithEvents bnCancel As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents SName As TextBox
    Friend WithEvents SID As ComboBox
    Friend WithEvents School As School
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As SchoolTableAdapters.StudentsTableAdapter
End Class
