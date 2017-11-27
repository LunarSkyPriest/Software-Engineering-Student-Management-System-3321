<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudGrades
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudGrades))
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GradesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School = New SMS.School()
        Me.GradesTableAdapter = New SMS.SchoolTableAdapters.GradesTableAdapter()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(130, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(145, 40)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "C L O S E"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 36)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Current Grades:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(130, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(145, 43)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "G P A" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "C A L C U L A T O R"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "Homework", True))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(130, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 36)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Homework Title"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "HomeworkG", True))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 152)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 36)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Homework Grade"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "Exam", True))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(130, 200)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(165, 36)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Exam Title"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GradesBindingSource, "ExamG", True))
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(143, 36)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Exam Grade"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'StudGrades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(402, 427)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.DoubleBuffered = True
        Me.Name = "StudGrades"
        Me.Text = "My Grades"
        CType(Me.GradesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents School As School
    Friend WithEvents GradesBindingSource As BindingSource
    Friend WithEvents GradesTableAdapter As SchoolTableAdapters.GradesTableAdapter
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
