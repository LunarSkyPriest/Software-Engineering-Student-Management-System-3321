<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudProfile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(StudProfile))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.School1 = New SMS.School()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.bnExit = New System.Windows.Forms.Button()
        Me.StudentsTableAdapter1 = New SMS.SchoolTableAdapters.StudentsTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        CType(Me.School1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.Gender", True))
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(152, 193)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'School1
        '
        Me.School1.DataSetName = "School"
        Me.School1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.Age", True))
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(152, 219)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 28)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.ContactNumber", True))
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(152, 248)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 28)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Label3"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.EmailAddress", True))
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(152, 277)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 28)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(33, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 28)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender -"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(33, 219)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 28)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Age - "
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(33, 248)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 28)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Phone Number -"
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(33, 277)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 28)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Email Address -"
        '
        'SName
        '
        Me.SName.BackColor = System.Drawing.Color.Transparent
        Me.SName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.StudentName", True))
        Me.SName.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SName.Location = New System.Drawing.Point(261, 51)
        Me.SName.Name = "SName"
        Me.SName.Size = New System.Drawing.Size(110, 28)
        Me.SName.TabIndex = 8
        Me.SName.Text = "Label9"
        Me.SName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.StudentID", True))
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(264, 79)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(107, 28)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Label10"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.Class", True))
        Me.Label11.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(264, 107)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 28)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Label11"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bnExit
        '
        Me.bnExit.Location = New System.Drawing.Point(380, 325)
        Me.bnExit.Name = "bnExit"
        Me.bnExit.Size = New System.Drawing.Size(118, 38)
        Me.bnExit.TabIndex = 11
        Me.bnExit.Text = "C L O S E"
        Me.bnExit.UseVisualStyleBackColor = True
        '
        'StudentsTableAdapter1
        '
        Me.StudentsTableAdapter1.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(33, 305)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(96, 28)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Address - "
        '
        'Label12
        '
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.School1, "Students.Address", True))
        Me.Label12.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(152, 305)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(96, 28)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "Label12"
        '
        'StudProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(510, 375)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.bnExit)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.SName)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "StudProfile"
        Me.Text = "My Profile"
        CType(Me.School1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents bnExit As Button
    Friend WithEvents School1 As School
    Friend WithEvents StudentsTableAdapter1 As SchoolTableAdapters.StudentsTableAdapter
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
End Class
