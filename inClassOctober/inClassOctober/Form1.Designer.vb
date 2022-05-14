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
        Me.ComboBoxCoffee = New System.Windows.Forms.ComboBox()
        Me.lblCafe = New System.Windows.Forms.Label()
        Me.btnShowCafe = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ComboBoxCoffee
        '
        Me.ComboBoxCoffee.FormattingEnabled = True
        Me.ComboBoxCoffee.Items.AddRange(New Object() {"Leche", "Mocca", "Decaf", "Frapucchino", "Italian"})
        Me.ComboBoxCoffee.Location = New System.Drawing.Point(26, 21)
        Me.ComboBoxCoffee.Name = "ComboBoxCoffee"
        Me.ComboBoxCoffee.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCoffee.TabIndex = 0
        '
        'lblCafe
        '
        Me.lblCafe.Location = New System.Drawing.Point(229, 29)
        Me.lblCafe.Name = "lblCafe"
        Me.lblCafe.Size = New System.Drawing.Size(100, 23)
        Me.lblCafe.TabIndex = 1
        '
        'btnShowCafe
        '
        Me.btnShowCafe.Location = New System.Drawing.Point(35, 193)
        Me.btnShowCafe.Name = "btnShowCafe"
        Me.btnShowCafe.Size = New System.Drawing.Size(75, 23)
        Me.btnShowCafe.TabIndex = 2
        Me.btnShowCafe.Text = "Add Item"
        Me.btnShowCafe.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(549, 319)
        Me.Controls.Add(Me.btnShowCafe)
        Me.Controls.Add(Me.lblCafe)
        Me.Controls.Add(Me.ComboBoxCoffee)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ComboBoxCoffee As ComboBox
    Friend WithEvents lblCafe As Label
    Friend WithEvents btnShowCafe As Button
End Class
