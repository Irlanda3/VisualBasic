Public Class Form1

    Dim student(4) As String
    Private Sub ContextMenuStrip1_Opening(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ContextMenuStrip1.Opening

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cuando haga click quiero store la information del text box


        student(0) = TextBox1.Text

        student(1) = TextBox1.Text
        student(2) = TextBox1.Text
        student(3) = TextBox1.Text

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each element As String In student
            ListBox1.Items.Clear()
            ListBox1.Items.Add(element)
            Debug.Print(student)

        Next element
    End Sub
End Class
