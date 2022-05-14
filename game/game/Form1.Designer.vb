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
        Me.btnRulesOfGame = New System.Windows.Forms.Button()
        Me.btnNewGame = New System.Windows.Forms.Button()
        Me.bntSelectOneStick = New System.Windows.Forms.Button()
        Me.btnSelectTwoSticks = New System.Windows.Forms.Button()
        Me.btnSelectThreeSticks = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCurrentStatusPile = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnRulesOfGame
        '
        Me.btnRulesOfGame.Location = New System.Drawing.Point(77, 21)
        Me.btnRulesOfGame.Name = "btnRulesOfGame"
        Me.btnRulesOfGame.Size = New System.Drawing.Size(167, 23)
        Me.btnRulesOfGame.TabIndex = 0
        Me.btnRulesOfGame.Text = "Give the Rules of the Game"
        Me.btnRulesOfGame.UseVisualStyleBackColor = True
        '
        'btnNewGame
        '
        Me.btnNewGame.Location = New System.Drawing.Point(299, 21)
        Me.btnNewGame.Name = "btnNewGame"
        Me.btnNewGame.Size = New System.Drawing.Size(120, 23)
        Me.btnNewGame.TabIndex = 1
        Me.btnNewGame.Text = "Begin a New Game"
        Me.btnNewGame.UseVisualStyleBackColor = True
        '
        'bntSelectOneStick
        '
        Me.bntSelectOneStick.Location = New System.Drawing.Point(199, 100)
        Me.bntSelectOneStick.Name = "bntSelectOneStick"
        Me.bntSelectOneStick.Size = New System.Drawing.Size(75, 23)
        Me.bntSelectOneStick.TabIndex = 2
        Me.bntSelectOneStick.Text = "One"
        Me.bntSelectOneStick.UseVisualStyleBackColor = True
        '
        'btnSelectTwoSticks
        '
        Me.btnSelectTwoSticks.Location = New System.Drawing.Point(323, 100)
        Me.btnSelectTwoSticks.Name = "btnSelectTwoSticks"
        Me.btnSelectTwoSticks.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectTwoSticks.TabIndex = 3
        Me.btnSelectTwoSticks.Text = "Two"
        Me.btnSelectTwoSticks.UseVisualStyleBackColor = True
        '
        'btnSelectThreeSticks
        '
        Me.btnSelectThreeSticks.Location = New System.Drawing.Point(439, 100)
        Me.btnSelectThreeSticks.Name = "btnSelectThreeSticks"
        Me.btnSelectThreeSticks.Size = New System.Drawing.Size(75, 23)
        Me.btnSelectThreeSticks.TabIndex = 4
        Me.btnSelectThreeSticks.Text = "Three"
        Me.btnSelectThreeSticks.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 39)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "How many matchsticks" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " would you like to pick up?" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtCurrentStatusPile
        '
        Me.txtCurrentStatusPile.Location = New System.Drawing.Point(93, 167)
        Me.txtCurrentStatusPile.Name = "txtCurrentStatusPile"
        Me.txtCurrentStatusPile.Size = New System.Drawing.Size(502, 20)
        Me.txtCurrentStatusPile.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 167)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 26)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Current status" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "of the pile:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 210)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCurrentStatusPile)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnSelectThreeSticks)
        Me.Controls.Add(Me.btnSelectTwoSticks)
        Me.Controls.Add(Me.bntSelectOneStick)
        Me.Controls.Add(Me.btnNewGame)
        Me.Controls.Add(Me.btnRulesOfGame)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnRulesOfGame As Button
    Friend WithEvents btnNewGame As Button
    Friend WithEvents bntSelectOneStick As Button
    Friend WithEvents btnSelectTwoSticks As Button
    Friend WithEvents btnSelectThreeSticks As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCurrentStatusPile As TextBox
    Friend WithEvents Label2 As Label
End Class
