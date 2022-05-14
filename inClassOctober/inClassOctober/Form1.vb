Public Class Form1
    'variables globales
    Dim itemFoundBoolean As Boolean
    Dim itemIndexInteger As Boolean
    Private Sub ComboBoxCoffee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCoffee.SelectedIndexChanged
        ComboBoxCoffee.Items.Add("Decaf")
        ComboBoxCoffee.Items.Add("Cafe con leche")
        ComboBoxCoffee.Items.Add("Mocca")
        ComboBoxCoffee.Items.Add("Frapuccino")

        ComboBoxCoffee.Show()
        lblCafe.Text = ComboBoxCoffee.ToString

    End Sub

    Private Sub btnShowCafe_Click(sender As Object, e As EventArgs) Handles btnShowCafe.Click
        lblCafe.Text = ComboBoxCoffee.Text


    End Sub
    'Add a new cafe flavor to the list
    Sub addCafe()
        'Test for a blanck input
        If ComboBoxCoffee.Text <> "" Then
            'Make sure itme is not already on the list
            Do Until itemFoundBoolean Or itemIndexInteger = ComboBoxCoffee.Items.Count
                If ComboBoxCoffee.Text = ComboBoxCoffee.Items(itemIndexInteger).ToString Then

                    itemFoundBoolean = True
                    Exit Do ' Fin del Do loop

                Else
                    itemIndexInteger += 1
                End If

            Loop 'END OF LOOP
            If itemFoundBoolean Then
                MessageBox.Show("Duplicate item. ", "add failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

            Else
                'if it is not in the list, add it
                ComboBoxCoffee.Items.Add(ComboBoxCoffee.Text)
                ComboBoxCoffee.Text = ""

            End If
        Else
            MessageBox.Show("Enter a coffe flavor ot add. ", "Missing Data", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

        End If
        'We need to make the loop usando un do


    End Sub
End Class
