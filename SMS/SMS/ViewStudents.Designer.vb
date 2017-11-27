<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewStudents
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.STUDENTINFDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClassDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StreamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentPictureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.School = New SMS.School()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.bnEdit = New System.Windows.Forms.Button()
        Me.bnDelete = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.bnAdd = New System.Windows.Forms.Button()
        Me.StudentsTableAdapter = New SMS.SchoolTableAdapters.StudentsTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.STUDENTINFDataGridViewTextBoxColumn, Me.StudentNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.StudentIDDataGridViewTextBoxColumn, Me.EmailAddressDataGridViewTextBoxColumn, Me.ClassDataGridViewTextBoxColumn, Me.StreamDataGridViewTextBoxColumn, Me.StudentPictureDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StudentsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 54)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(643, 202)
        Me.DataGridView1.TabIndex = 0
        '
        'STUDENTINFDataGridViewTextBoxColumn
        '
        Me.STUDENTINFDataGridViewTextBoxColumn.DataPropertyName = "STUDENTINF"
        Me.STUDENTINFDataGridViewTextBoxColumn.HeaderText = "STUDENTINF"
        Me.STUDENTINFDataGridViewTextBoxColumn.Name = "STUDENTINFDataGridViewTextBoxColumn"
        Me.STUDENTINFDataGridViewTextBoxColumn.ReadOnly = True
        Me.STUDENTINFDataGridViewTextBoxColumn.Visible = False
        '
        'StudentNameDataGridViewTextBoxColumn
        '
        Me.StudentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName"
        Me.StudentNameDataGridViewTextBoxColumn.HeaderText = "Student Name"
        Me.StudentNameDataGridViewTextBoxColumn.Name = "StudentNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "Phone #"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "Student ID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        '
        'EmailAddressDataGridViewTextBoxColumn
        '
        Me.EmailAddressDataGridViewTextBoxColumn.DataPropertyName = "EmailAddress"
        Me.EmailAddressDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailAddressDataGridViewTextBoxColumn.Name = "EmailAddressDataGridViewTextBoxColumn"
        '
        'ClassDataGridViewTextBoxColumn
        '
        Me.ClassDataGridViewTextBoxColumn.DataPropertyName = "Class"
        Me.ClassDataGridViewTextBoxColumn.HeaderText = "Class."
        Me.ClassDataGridViewTextBoxColumn.Name = "ClassDataGridViewTextBoxColumn"
        '
        'StreamDataGridViewTextBoxColumn
        '
        Me.StreamDataGridViewTextBoxColumn.DataPropertyName = "Stream"
        Me.StreamDataGridViewTextBoxColumn.HeaderText = "Stream"
        Me.StreamDataGridViewTextBoxColumn.Name = "StreamDataGridViewTextBoxColumn"
        Me.StreamDataGridViewTextBoxColumn.Visible = False
        '
        'StudentPictureDataGridViewTextBoxColumn
        '
        Me.StudentPictureDataGridViewTextBoxColumn.DataPropertyName = "StudentPicture"
        Me.StudentPictureDataGridViewTextBoxColumn.HeaderText = "StudentPicture"
        Me.StudentPictureDataGridViewTextBoxColumn.Name = "StudentPictureDataGridViewTextBoxColumn"
        Me.StudentPictureDataGridViewTextBoxColumn.Visible = False
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
        'Search
        '
        Me.Search.Location = New System.Drawing.Point(12, 31)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(247, 20)
        Me.Search.TabIndex = 1
        '
        'bnEdit
        '
        Me.bnEdit.Location = New System.Drawing.Point(462, 27)
        Me.bnEdit.Name = "bnEdit"
        Me.bnEdit.Size = New System.Drawing.Size(101, 26)
        Me.bnEdit.TabIndex = 2
        Me.bnEdit.Text = "Edit Student Info"
        Me.bnEdit.UseVisualStyleBackColor = True
        '
        'bnDelete
        '
        Me.bnDelete.Location = New System.Drawing.Point(569, 27)
        Me.bnDelete.Name = "bnDelete"
        Me.bnDelete.Size = New System.Drawing.Size(86, 26)
        Me.bnDelete.TabIndex = 3
        Me.bnDelete.Text = "Delete Student"
        Me.bnDelete.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.AccessibleDescription = "bnUpdate"
        Me.Button3.Location = New System.Drawing.Point(265, 27)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(99, 26)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Update List"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'bnAdd
        '
        Me.bnAdd.Location = New System.Drawing.Point(370, 27)
        Me.bnAdd.Name = "bnAdd"
        Me.bnAdd.Size = New System.Drawing.Size(86, 26)
        Me.bnAdd.TabIndex = 5
        Me.bnAdd.Text = "Add Student"
        Me.bnAdd.UseVisualStyleBackColor = True
        '
        'StudentsTableAdapter
        '
        Me.StudentsTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Search by Name:"
        '
        'ViewStudents
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(668, 269)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bnAdd)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.bnDelete)
        Me.Controls.Add(Me.bnEdit)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "ViewStudents"
        Me.Text = "View Students"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.School, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Search As TextBox
    Friend WithEvents School As School
    Friend WithEvents StudentsBindingSource As BindingSource
    Friend WithEvents StudentsTableAdapter As SchoolTableAdapters.StudentsTableAdapter
    Friend WithEvents STUDENTINFDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailAddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ClassDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StreamDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StudentPictureDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents bnEdit As Button
    Friend WithEvents bnDelete As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents bnAdd As Button
    Friend WithEvents Label1 As Label
End Class
