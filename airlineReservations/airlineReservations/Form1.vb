Public Class airlineReservations
    Dim namePasajero, searchItem As String
    Dim i, j, strX As Integer
    Dim addPeopleArray(,) As String = {{1, 1, 1, 1}, {2, 5, 7, 2}, {3, 3, 3, 3}, {4, 4, 4, 4}, {5, 5, 5, 5}, {6, 6, 6, 6}, {7, 7, 7, 7}, {8, 8, 8, 8}, {9, 9, 9, 9}, {10, 10, 10, 10}} '{5, 6, 7, 8}, {5, 6, 7, 8}}
    Dim print As String = ""

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    'Dim print As String = ""
    Private Sub airlineReservations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim addArray(,) As String = {{1, 1, 1, 1}, {2, 5, 7, 2}, {3, 3, 3, 3}, {4, 4, 4, 4}, {5, 5, 5, 5}, {6, 6, 6, 6}, {7, 7, 7, 7}, {8, 8, 8, 8}, {9, 9, 9, 9}, {10, 10, 10, 10}}
        For i = 0 To 9 'rows 03
            print = ""
            For j = 0 To 3 'columnas03

                'buscamos x
                Dim erase1 As String
                'MessageBox.Show("we found el seat que queriamos")
                erase1 = "."
                'System.Array.Clear(addPeopleArray, i, j)
                addArray(i, j) = erase1



                print = print & "        " & addArray(i, j)
            Next

            lstSeatsDraw.Items.Add(print)

        Next
    End Sub

    Private Sub btnAddPassenger_Click(sender As Object, e As EventArgs) Handles btnAddPassenger.Click
        'Dim addPeopleArray(,) As String = {{1, 1, 1, 1}, {2, 2, 7, 2}} '{5, 6, 7, 8}, {5, 6, 7, 8}}
        namePasajero = txtName.Text
        lstSeatsDraw.Items.Clear()
        'agrego nombre y escojo asiento
        'Display array
        'Dim print As String = ""
        For i = 0 To 9 'rows 03
            print = ""
            For j = 0 To 3 'columnas03

                print = print & "        " & addPeopleArray(i, j)

                'lstSeatsDraw.Items.Add(addPeopleArray(i, j))


            Next
            'lstSeatsDraw.Items.Add(print)

        Next
        'escojer asiento

        'if seats are available que escojan uno

        ' Dim print As String = ""
        For i = 0 To 9 'rows 03
            print = ""
            For j = 0 To 3 'columnas03



                'lstSeatsDraw.Items.Add(addPeopleArray(i, j))
                'searchItem is given by seat text box
                If (String.Compare(addPeopleArray(i, 0), txtSeat.Text)) = 0 Then
                    Dim replaceStr As String
                    MessageBox.Show("we found el seat que queriamos")
                    'replaceStr = "X"
                    replaceStr = txtSeat.Text
                    addPeopleArray(i, j) = replaceStr & "A"

                    If addPeopleArray(i, j) = "1A" Then
                        Dim replaceWithX As String
                        replaceWithX = "X"
                        addPeopleArray(i, j) = replaceWithX


                    End If


                End If
                'If addPeopleArray(i, j) IsNot "1A" Then
                'addPeopleArray(i, j) = "."
                'End If

                print = print & "        " & addPeopleArray(i, j)
            Next

            lstSeatsDraw.Items.Add(print)

        Next
        lstSeatsDraw.Items.Clear()

        For i = 0 To 9 'rows 03
            print = ""
            For j = 0 To 3 'columnas03
                If addPeopleArray(i, j) <> "X" Then
                    addPeopleArray(i, j) = "."
                    'addPeopleArray(0, 0) = "X"
                End If
                'addPeopleArray(0, 0) = "X"
                print = print & "        " & addPeopleArray(i, j)
            Next
            lstSeatsDraw.Items.Add(print)
        Next



    End Sub

    Private Sub btnDeletePassenger_Click(sender As Object, e As EventArgs) Handles btnDeletePassenger.Click
        MessageBox.Show("To delete type the name and the select seat followed by the letter. Ex 1A")
        lstSeatsDraw.Items.Clear()

        For i = 0 To 9 'rows 03
            print = ""
            For j = 0 To 3 'columnas03

                'buscamos x
                If (String.Compare(addPeopleArray(i, j), "X")) = 0 Then
                    Dim eraseStr As String
                    MessageBox.Show("we found el seat que queriamos")
                    eraseStr = "."
                    'System.Array.Clear(addPeopleArray, i, j)
                    addPeopleArray(i, j) = eraseStr

                End If

                print = print & "        " & addPeopleArray(i, j)
            Next

            lstSeatsDraw.Items.Add(print)

        Next
    End Sub
End Class
