<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class EditStudent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditStudent))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StudentN = New System.Windows.Forms.TextBox()
        Me.SEmail = New System.Windows.Forms.TextBox()
        Me.SPhone = New System.Windows.Forms.TextBox()
        Me.SAddress = New System.Windows.Forms.TextBox()
        Me.SGender = New System.Windows.Forms.ComboBox()
        Me.SAge = New System.Windows.Forms.NumericUpDown()
        Me.SEClass = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.bnClear = New System.Windows.Forms.Button()
        Me.bnSave = New System.Windows.Forms.Button()
        Me.bnCancel = New System.Windows.Forms.Button()
        Me.bnSearch = New System.Windows.Forms.Button()
        Me.StudentID = New System.Windows.Forms.ComboBox()
        Me.School = New SMS.School()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StudentsTableAdapter = New SMS.SchoolTableAdapters.StudentsTableAdapter()
        CType(Me.SAge, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Enter the Student's ID:"
        '
        'StudentN
        '
        Me.StudentN.Location = New System.Drawing.Point(16, 81)
        Me.StudentN.Name = "StudentN"
        Me.StudentN.Size = New System.Drawing.Size(169, 20)
        Me.StudentN.TabIndex = 2
        '
        'SEmail
        '
        Me.SEmail.Location = New System.Drawing.Point(16, 130)
        Me.SEmail.Name = "SEmail"
        Me.SEmail.Size = New System.Drawing.Size(169, 20)
        Me.SEmail.TabIndex = 3
        '
        'SPhone
        '
        Me.SPhone.Location = New System.Drawing.Point(224, 130)
        Me.SPhone.Name = "SPhone"
        Me.SPhone.Size = New System.Drawing.Size(134, 20)
        Me.SPhone.TabIndex = 5
        '
        'SAddress
        '
        Me.SAddress.Location = New System.Drawing.Point(16, 181)
        Me.SAddress.Name = "SAddress"
        Me.SAddress.Size = New System.Drawing.Size(342, 20)
        Me.SAddress.TabIndex = 6
        '
        'SGender
        '
        Me.SGender.FormattingEnabled = True
        Me.SGender.Location = New System.Drawing.Point(224, 80)
        Me.SGender.Name = "SGender"
        Me.SGender.Size = New System.Drawing.Size(134, 21)
        Me.SGender.TabIndex = 7
        '
        'SAge
        '
        Me.SAge.Location = New System.Drawing.Point(383, 80)
        Me.SAge.Name = "SAge"
        Me.SAge.Size = New System.Drawing.Size(123, 20)
        Me.SAge.TabIndex = 8
        '
        'SEClass
        '
        Me.SEClass.FormattingEnabled = True
        Me.SEClass.Location = New System.Drawing.Point(383, 129)
        Me.SEClass.Name = "SEClass"
        Me.SEClass.Size = New System.Drawing.Size(123, 21)
        Me.SEClass.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Student Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(379, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Age:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(220, 59)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 20)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Gender:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(379, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Classification:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(220, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(122, 20)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Phone Number:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(16, 107)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 20)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Email Address:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(130, 32)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(273, 17)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "Fill in the forms below with your changes."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(364, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(169, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "STUDENT ID WILL NOT CHANGE"
        '
        'bnClear
        '
        Me.bnClear.Location = New System.Drawing.Point(16, 222)
        Me.bnClear.Name = "bnClear"
        Me.bnClear.Size = New System.Drawing.Size(154, 31)
        Me.bnClear.TabIndex = 19
        Me.bnClear.Text = "Clear"
        Me.bnClear.UseVisualStyleBackColor = True
        '
        'bnSave
        '
        Me.bnSave.Location = New System.Drawing.Point(224, 222)
        Me.bnSave.Name = "bnSave"
        Me.bnSave.Size = New System.Drawing.Size(143, 45)
        Me.bnSave.TabIndex = 20
        Me.bnSave.Text = "Save"
        Me.bnSave.UseVisualStyleBackColor = True
        '
        'bnCancel
        '
        Me.bnCancel.Location = New System.Drawing.Point(381, 222)
        Me.bnCancel.Name = "bnCancel"
        Me.bnCancel.Size = New System.Drawing.Size(143, 45)
        Me.bnCancel.TabIndex = 21
        Me.bnCancel.Text = "Cancel"
        Me.bnCancel.UseVisualStyleBackColor = True
        '
        'bnSearch
        '
        Me.bnSearch.Location = New System.Drawing.Point(292, 6)
        Me.bnSearch.Name = "bnSearch"
        Me.bnSearch.Size = New System.Drawing.Size(66, 23)
        Me.bnSearch.TabIndex = 22
        Me.bnSearch.Text = "Search"
        Me.bnSearch.UseVisualStyleBackColor = True
        '
        'StudentID
        '
        Me.StudentID.DataSource = Me.StudentsBindingSource
        Me.StudentID.DisplayMember = "StudentID"
        Me.StudentID.FormattingEnabled = True
        Me.StudentID.Location = New System.Drawing.Point(172, 8)
        Me.StudentID.Name = "StudentID"
        Me.StudentID.Size = New System.Drawing.Size(114, 21)
        Me.StudentID.TabIndex = 23
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
        'EditStudent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(536, 273)
        Me.Controls.Add(Me.StudentID)
        Me.Controls.Add(Me.bnSearch)
        Me.Controls.Add(Me.bnCancel)
        Me.Controls.Add(Me.bnSave)
        Me.Controls.Add(Me.bnClear)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SEClass)
        Me.Controls.Add(Me.SAge)
        Me.Controls.Add(Me.SGender)
        Me.Controls.Add(Me.SAddress)
        Me.Controls.Add(Me.SPhone)
        Me.Controls.Add(Me.SEmail)
        Me.Controls.Add(Me.StudentN)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditStudent"
        Me.Text = "Edit Student"
        CType(Me.SAge, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents StudentN As TextBox
    Friend WithEvents SEmail As TextBox
    Friend WithEvents SPhone As TextBox
    Friend WithEvents SAddress As TextBox
    Friend WithEvents SGender As ComboBox
    Friend WithEvents SAge As NumericUpDown
    Friend WithEvents SEClass As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents bnClear As Button
    Friend WithEvents bnSave As Button
    Friend WithEvents bnCancel As Button
    Friend WithEvents bnSearch As Button
    Friend WithEvents StudentID As ComboBox
    Friend WithEvents School As School
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As SchoolTableAdapters.StudentsTableAdapter
End Class
