<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddStudent))
        Me.StudentN = New System.Windows.Forms.TextBox()
        Me.SGender = New System.Windows.Forms.ComboBox()
        Me.SAge = New System.Windows.Forms.NumericUpDown()
        Me.SAddress = New System.Windows.Forms.TextBox()
        Me.SPhone = New System.Windows.Forms.TextBox()
        Me.StudentID = New System.Windows.Forms.TextBox()
        Me.SEmail = New System.Windows.Forms.TextBox()
        Me.SEClass = New System.Windows.Forms.ComboBox()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnClear = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.bnCancel = New System.Windows.Forms.Button()
        CType(Me.SAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StudentN
        '
        Me.StudentN.Location = New System.Drawing.Point(49, 53)
        Me.StudentN.Name = "StudentN"
        Me.StudentN.Size = New System.Drawing.Size(176, 20)
        Me.StudentN.TabIndex = 0
        '
        'SGender
        '
        Me.SGender.FormattingEnabled = True
        Me.SGender.Items.AddRange(New Object() {"Female", "Male", "Other"})
        Me.SGender.Location = New System.Drawing.Point(49, 149)
        Me.SGender.Name = "SGender"
        Me.SGender.Size = New System.Drawing.Size(176, 21)
        Me.SGender.TabIndex = 1
        '
        'SAge
        '
        Me.SAge.Location = New System.Drawing.Point(49, 211)
        Me.SAge.Name = "SAge"
        Me.SAge.Size = New System.Drawing.Size(176, 20)
        Me.SAge.TabIndex = 2
        '
        'SAddress
        '
        Me.SAddress.Location = New System.Drawing.Point(261, 53)
        Me.SAddress.Name = "SAddress"
        Me.SAddress.Size = New System.Drawing.Size(220, 20)
        Me.SAddress.TabIndex = 3
        '
        'SPhone
        '
        Me.SPhone.Location = New System.Drawing.Point(261, 150)
        Me.SPhone.Name = "SPhone"
        Me.SPhone.Size = New System.Drawing.Size(219, 20)
        Me.SPhone.TabIndex = 4
        '
        'StudentID
        '
        Me.StudentID.Location = New System.Drawing.Point(49, 99)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.Size = New System.Drawing.Size(176, 20)
        Me.StudentID.TabIndex = 5
        '
        'SEmail
        '
        Me.SEmail.Location = New System.Drawing.Point(262, 211)
        Me.SEmail.Name = "SEmail"
        Me.SEmail.Size = New System.Drawing.Size(218, 20)
        Me.SEmail.TabIndex = 6
        '
        'SEClass
        '
        Me.SEClass.FormattingEnabled = True
        Me.SEClass.Items.AddRange(New Object() {"Freshman", "Sophomore", "Junior", "Senior", "Graduate"})
        Me.SEClass.Location = New System.Drawing.Point(260, 98)
        Me.SEClass.Name = "SEClass"
        Me.SEClass.Size = New System.Drawing.Size(220, 21)
        Me.SEClass.TabIndex = 7
        '
        'bnSave
        '
        Me.bnSave.Location = New System.Drawing.Point(218, 254)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(128, 50)
        Me.bnSave.TabIndex = 8
        Me.bnSave.Text = "Save"
        Me.bnSave.UseVisualStyleBackColor = True
        '
        'bnClear
        '
        Me.bnClear.Location = New System.Drawing.Point(59, 254)
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(98, 34)
        Me.bnClear.TabIndex = 9
        Me.bnClear.Text = "Clear"
        Me.bnClear.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 20)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Student Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(275, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Address:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(275, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(122, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Phone Number:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(55, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Student ID:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(55, 188)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 20)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Age:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(270, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(112, 20)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Email Address:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(270, 76)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(108, 20)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Classification:"
        '
        'bnCancel
        '
        Me.bnCancel.Location = New System.Drawing.Point(353, 254)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(128, 50)
        Me.bnCancel.TabIndex = 18
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = True
        '
        'AddStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(522, 349)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnClear)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.SEClass)
        Me.Controls.Add(Me.SEmail)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.SPhone)
        Me.Controls.Add(Me.SAddress)
        Me.Controls.Add(Me.SAge)
        Me.Controls.Add(Me.SGender)
        Me.Controls.Add(Me.StudentN)
        Me.DoubleBuffered = True
        Me.Name = "AddStudent"
        Me.Text = "Add Students"
        CType(Me.SAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents StudentN As TextBox
    Friend WithEvents SGender As ComboBox
    Friend WithEvents SAge As NumericUpDown
    Friend WithEvents SAddress As TextBox
    Friend WithEvents SPhone As TextBox
    Friend WithEvents StudentID As TextBox
    Friend WithEvents SEmail As TextBox
    Friend WithEvents SEClass As ComboBox
    Friend WithEvents bnSave As Button
    Friend WithEvents bnClear As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents bnCancel As Button
End Class
