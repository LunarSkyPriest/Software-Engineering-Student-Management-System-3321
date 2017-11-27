<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudCourses
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudCourses))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.CoursesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School = New SMS.School()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CoursesTableAdapter = New SMS.SchoolTableAdapters.CoursesTableAdapter()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.CoursesBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CoursesBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(306, 113)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(148, 53)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "G R A D E S"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(306, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(148, 53)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "C L O S E"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(306, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(148, 53)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "C O U R S E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "D E S C R I P T I O N S"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'CoursesBindingSource
        '
        Me.CoursesBindingSource.DataMember = "Courses"
        Me.CoursesBindingSource.DataSource = Me.School
        '
        'School
        '
        Me.School.DataSetName = "School"
        Me.School.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(105, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 32)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Enrolled Courses:"
        '
        'CoursesTableAdapter
        '
        Me.CoursesTableAdapter.ClearBeforeFill = True
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBox1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.CoursesBindingSource, "Course", True))
        Me.ListBox1.DataSource = Me.CoursesBindingSource1
        Me.ListBox1.DisplayMember = "Course"
        Me.ListBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.HorizontalScrollbar = True
        Me.ListBox1.ItemHeight = 20
        Me.ListBox1.Location = New System.Drawing.Point(109, 79)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.ListBox1.Size = New System.Drawing.Size(153, 160)
        Me.ListBox1.TabIndex = 19
        '
        'CoursesBindingSource1
        '
        Me.CoursesBindingSource1.DataMember = "Courses"
        Me.CoursesBindingSource1.DataSource = Me.School
        '
        'StudCourses
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(483, 340)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "StudCourses"
        Me.Text = "My Courses"
        CType(Me.CoursesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CoursesBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents School As School
    Friend WithEvents CoursesBindingSource As BindingSource
    Friend WithEvents CoursesTableAdapter As SchoolTableAdapters.CoursesTableAdapter
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents CoursesBindingSource1 As BindingSource
End Class
