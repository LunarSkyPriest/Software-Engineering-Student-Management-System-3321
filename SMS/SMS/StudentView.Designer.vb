<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentView
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
        Me.INFO = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'INFO
        '
        Me.INFO.Location = New System.Drawing.Point(12, 386)
        Me.INFO.Name = "INFO"
        Me.INFO.Size = New System.Drawing.Size(526, 94)
        Me.INFO.TabIndex = 0
        Me.INFO.Text = "I N F O "
        Me.INFO.UseVisualStyleBackColor = True
        '
        'StudentView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 492)
        Me.Controls.Add(Me.INFO)
        Me.Name = "StudentView"
        Me.Text = "Student"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents INFO As Button
End Class
