<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class airlineReservations
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
        Me.btnAddPassenger = New System.Windows.Forms.Button()
        Me.btnDeletePassenger = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lstWaitingList = New System.Windows.Forms.ListBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtSeat = New System.Windows.Forms.TextBox()
        Me.lstSeatsDraw = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 213)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Waiting list:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(386, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(168, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "(1A,  1B,  1C,  1D,   2A,  ... ,  10D)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Seat:"
        '
        'btnAddPassenger
        '
        Me.btnAddPassenger.Location = New System.Drawing.Point(73, 51)
        Me.btnAddPassenger.Name = "btnAddPassenger"
        Me.btnAddPassenger.Size = New System.Drawing.Size(103, 23)
        Me.btnAddPassenger.TabIndex = 4
        Me.btnAddPassenger.Text = "Add Passenger"
        Me.btnAddPassenger.UseVisualStyleBackColor = True
        '
        'btnDeletePassenger
        '
        Me.btnDeletePassenger.Location = New System.Drawing.Point(73, 81)
        Me.btnDeletePassenger.Name = "btnDeletePassenger"
        Me.btnDeletePassenger.Size = New System.Drawing.Size(103, 23)
        Me.btnDeletePassenger.TabIndex = 5
        Me.btnDeletePassenger.Text = "Delete Passenger"
        Me.btnDeletePassenger.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(73, 111)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(103, 23)
        Me.btnQuit.TabIndex = 6
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'lstWaitingList
        '
        Me.lstWaitingList.FormattingEnabled = True
        Me.lstWaitingList.Location = New System.Drawing.Point(73, 231)
        Me.lstWaitingList.Name = "lstWaitingList"
        Me.lstWaitingList.Size = New System.Drawing.Size(120, 95)
        Me.lstWaitingList.TabIndex = 7
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(76, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 8
        '
        'txtSeat
        '
        Me.txtSeat.Location = New System.Drawing.Point(454, 22)
        Me.txtSeat.Name = "txtSeat"
        Me.txtSeat.Size = New System.Drawing.Size(100, 20)
        Me.txtSeat.TabIndex = 9
        '
        'lstSeatsDraw
        '
        Me.lstSeatsDraw.FormattingEnabled = True
        Me.lstSeatsDraw.Location = New System.Drawing.Point(375, 90)
        Me.lstSeatsDraw.Name = "lstSeatsDraw"
        Me.lstSeatsDraw.Size = New System.Drawing.Size(200, 238)
        Me.lstSeatsDraw.TabIndex = 10
        '
        'airlineReservations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 338)
        Me.Controls.Add(Me.lstSeatsDraw)
        Me.Controls.Add(Me.txtSeat)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lstWaitingList)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnDeletePassenger)
        Me.Controls.Add(Me.btnAddPassenger)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "airlineReservations"
        Me.Text = "airlineReservations"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btnAddPassenger As Button
    Friend WithEvents btnDeletePassenger As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lstWaitingList As ListBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtSeat As TextBox
    Friend WithEvents lstSeatsDraw As ListBox
End Class
