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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnProcessOrder = New System.Windows.Forms.Button()
        Me.btnClearOrderForm = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.txtCityStateZip = New System.Windows.Forms.TextBox()
        Me.txtNumberOfSofasOrdered = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNumberOfChairsOrdered = New System.Windows.Forms.TextBox()
        Me.lstInvoiceDisplay = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "(Last, First):"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Address:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "City, State, Zip:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Number of sofas ordered"
        '
        'btnProcessOrder
        '
        Me.btnProcessOrder.Location = New System.Drawing.Point(15, 276)
        Me.btnProcessOrder.Name = "btnProcessOrder"
        Me.btnProcessOrder.Size = New System.Drawing.Size(98, 23)
        Me.btnProcessOrder.TabIndex = 5
        Me.btnProcessOrder.Text = "Process Order"
        Me.btnProcessOrder.UseVisualStyleBackColor = True
        '
        'btnClearOrderForm
        '
        Me.btnClearOrderForm.Location = New System.Drawing.Point(166, 276)
        Me.btnClearOrderForm.Name = "btnClearOrderForm"
        Me.btnClearOrderForm.Size = New System.Drawing.Size(75, 23)
        Me.btnClearOrderForm.TabIndex = 6
        Me.btnClearOrderForm.Text = "Clear Order Form"
        Me.btnClearOrderForm.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(317, 276)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 7
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(122, 15)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(142, 20)
        Me.txtCustomerName.TabIndex = 8
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(122, 79)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(142, 20)
        Me.txtAddress.TabIndex = 9
        '
        'txtCityStateZip
        '
        Me.txtCityStateZip.Location = New System.Drawing.Point(122, 119)
        Me.txtCityStateZip.Name = "txtCityStateZip"
        Me.txtCityStateZip.Size = New System.Drawing.Size(142, 20)
        Me.txtCityStateZip.TabIndex = 10
        '
        'txtNumberOfSofasOrdered
        '
        Me.txtNumberOfSofasOrdered.Location = New System.Drawing.Point(153, 207)
        Me.txtNumberOfSofasOrdered.Name = "txtNumberOfSofasOrdered"
        Me.txtNumberOfSofasOrdered.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfSofasOrdered.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(126, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Number of chairs ordered"
        '
        'txtNumberOfChairsOrdered
        '
        Me.txtNumberOfChairsOrdered.Location = New System.Drawing.Point(153, 168)
        Me.txtNumberOfChairsOrdered.Name = "txtNumberOfChairsOrdered"
        Me.txtNumberOfChairsOrdered.Size = New System.Drawing.Size(100, 20)
        Me.txtNumberOfChairsOrdered.TabIndex = 13
        '
        'lstInvoiceDisplay
        '
        Me.lstInvoiceDisplay.FormattingEnabled = True
        Me.lstInvoiceDisplay.Location = New System.Drawing.Point(299, 15)
        Me.lstInvoiceDisplay.Name = "lstInvoiceDisplay"
        Me.lstInvoiceDisplay.Size = New System.Drawing.Size(253, 251)
        Me.lstInvoiceDisplay.TabIndex = 14
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 311)
        Me.Controls.Add(Me.lstInvoiceDisplay)
        Me.Controls.Add(Me.txtNumberOfChairsOrdered)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNumberOfSofasOrdered)
        Me.Controls.Add(Me.txtCityStateZip)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.txtCustomerName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClearOrderForm)
        Me.Controls.Add(Me.btnProcessOrder)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnProcessOrder As Button
    Friend WithEvents btnClearOrderForm As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents txtCityStateZip As TextBox
    Friend WithEvents txtNumberOfSofasOrdered As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNumberOfChairsOrdered As TextBox
    Friend WithEvents lstInvoiceDisplay As ListBox
End Class
