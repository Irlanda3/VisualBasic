Public Class Form1
    Dim statesArray() As String
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'EJEMPLO 52 PAGINA 316
        'solo queremos leeer los estamos que digan NEW  y displa en el listbox
        '--------------------------------------------------------------
        'WE ARE READING AND PUTTING ALL IN THESE ARRAY
        statesArray = IO.File.ReadAllLines("States.txt")

        'TENEMOS QUE ITERAR ARRAY PARA ENCONTRAR EL NEW
        For i As Integer = 0 To statesArray.Length - 1

            'TMB PUEDO USAR STARTS WITH
            If statesArray(i).Contains("New") Then
                MessageBox.Show("si esta en la lista")
                ListBox1.Items.Add(statesArray(i))
            End If

        Next




    End Sub
End Class
