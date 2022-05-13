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
        Me.lblCreditCard = New System.Windows.Forms.Label()
        Me.txtCardNumber = New System.Windows.Forms.TextBox()
        Me.btnValidateNumber = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtValid = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lblCreditCard
        '
        Me.lblCreditCard.AutoSize = True
        Me.lblCreditCard.Location = New System.Drawing.Point(40, 31)
        Me.lblCreditCard.Name = "lblCreditCard"
        Me.lblCreditCard.Size = New System.Drawing.Size(102, 13)
        Me.lblCreditCard.TabIndex = 0
        Me.lblCreditCard.Text = "Credit Card Number:"
        '
        'txtCardNumber
        '
        Me.txtCardNumber.Location = New System.Drawing.Point(174, 31)
        Me.txtCardNumber.Name = "txtCardNumber"
        Me.txtCardNumber.Size = New System.Drawing.Size(187, 20)
        Me.txtCardNumber.TabIndex = 1
        '
        'btnValidateNumber
        '
        Me.btnValidateNumber.Location = New System.Drawing.Point(174, 86)
        Me.btnValidateNumber.Name = "btnValidateNumber"
        Me.btnValidateNumber.Size = New System.Drawing.Size(187, 23)
        Me.btnValidateNumber.TabIndex = 2
        Me.btnValidateNumber.Text = "Validate Number"
        Me.btnValidateNumber.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(140, 148)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Is number valid?"
        '
        'txtValid
        '
        Me.txtValid.Location = New System.Drawing.Point(269, 141)
        Me.txtValid.Name = "txtValid"
        Me.txtValid.Size = New System.Drawing.Size(92, 20)
        Me.txtValid.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 209)
        Me.Controls.Add(Me.txtValid)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnValidateNumber)
        Me.Controls.Add(Me.txtCardNumber)
        Me.Controls.Add(Me.lblCreditCard)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCreditCard As Label
    Friend WithEvents txtCardNumber As TextBox
    Friend WithEvents btnValidateNumber As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txtValid As TextBox
End Class
