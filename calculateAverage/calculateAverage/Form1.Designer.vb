<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.lblTest1 = New System.Windows.Forms.Label()
        Me.lblTest2 = New System.Windows.Forms.Label()
        Me.lblTest3 = New System.Windows.Forms.Label()
        Me.lblTest4 = New System.Windows.Forms.Label()
        Me.studentName = New System.Windows.Forms.Label()
        Me.textBoxStudentName = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblTest1
        '
        Me.lblTest1.AutoSize = True
        Me.lblTest1.Location = New System.Drawing.Point(409, 101)
        Me.lblTest1.Name = "lblTest1"
        Me.lblTest1.Size = New System.Drawing.Size(37, 13)
        Me.lblTest1.TabIndex = 0
        Me.lblTest1.Text = "Test 1"
        '
        'lblTest2
        '
        Me.lblTest2.AutoSize = True
        Me.lblTest2.Location = New System.Drawing.Point(409, 135)
        Me.lblTest2.Name = "lblTest2"
        Me.lblTest2.Size = New System.Drawing.Size(37, 13)
        Me.lblTest2.TabIndex = 1
        Me.lblTest2.Text = "Test 2"
        '
        'lblTest3
        '
        Me.lblTest3.AutoSize = True
        Me.lblTest3.Location = New System.Drawing.Point(409, 177)
        Me.lblTest3.Name = "lblTest3"
        Me.lblTest3.Size = New System.Drawing.Size(37, 13)
        Me.lblTest3.TabIndex = 2
        Me.lblTest3.Text = "Test 3"
        '
        'lblTest4
        '
        Me.lblTest4.AutoSize = True
        Me.lblTest4.Location = New System.Drawing.Point(409, 213)
        Me.lblTest4.Name = "lblTest4"
        Me.lblTest4.Size = New System.Drawing.Size(37, 13)
        Me.lblTest4.TabIndex = 3
        Me.lblTest4.Text = "Test 4"
        '
        'studentName
        '
        Me.studentName.AutoSize = True
        Me.studentName.Location = New System.Drawing.Point(407, 55)
        Me.studentName.Name = "studentName"
        Me.studentName.Size = New System.Drawing.Size(75, 13)
        Me.studentName.TabIndex = 4
        Me.studentName.Text = "Student Name"
        '
        'textBoxStudentName
        '
        Me.textBoxStudentName.Location = New System.Drawing.Point(517, 48)
        Me.textBoxStudentName.Name = "textBoxStudentName"
        Me.textBoxStudentName.Size = New System.Drawing.Size(100, 20)
        Me.textBoxStudentName.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.textBoxStudentName)
        Me.Controls.Add(Me.studentName)
        Me.Controls.Add(Me.lblTest4)
        Me.Controls.Add(Me.lblTest3)
        Me.Controls.Add(Me.lblTest2)
        Me.Controls.Add(Me.lblTest1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTest1 As Label
    Friend WithEvents lblTest2 As Label
    Friend WithEvents lblTest3 As Label
    Friend WithEvents lblTest4 As Label
    Friend WithEvents studentName As Label
    Friend WithEvents textBoxStudentName As TextBox
End Class
