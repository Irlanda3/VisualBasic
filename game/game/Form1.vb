Public Class Form1
    Dim sticks As String
    Dim remainder As Integer
    Dim computer As Boolean

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        'Aqui el user selects # of matchsticks(from5to40) to place in a pile o sea que 35 en total maximo
        'necezitamos un imputbox para que seleccione sticks y las recivo en variable sticks
        'convierto a integer por que voy a recivir un string
        sticks = CInt(InputBox("Enter a number between 5 and 40", "Number of Sticks"))
        txtCurrentStatusPile.Text = sticks




        'si el numero de sticks dado es = que 5
        If sticks = 5 Then
            'quiero imprimir 5 sticks
            txtCurrentStatusPile.Text = "| | | | |"

        ElseIf sticks = 6 Then
            txtCurrentStatusPile.Text = "||||||"

        ElseIf sticks = 7 Then
            txtCurrentStatusPile.Text = "|||||||"

        ElseIf sticks = 8 Then
            txtCurrentStatusPile.Text = "||||||||"

        ElseIf sticks = 9 Then
            txtCurrentStatusPile.Text = "|||||||||"

        ElseIf sticks = 10 Then
            txtCurrentStatusPile.Text = "||||||||||"

        ElseIf sticks = 11 Then
            txtCurrentStatusPile.Text = "|||||||||||"

        ElseIf sticks = 12 Then
            txtCurrentStatusPile.Text = "||||||||||||"

        ElseIf sticks = 13 Then
            txtCurrentStatusPile.Text = "|||||||||||||"

        ElseIf sticks = 14 Then
            txtCurrentStatusPile.Text = "||||||||||||||"

        ElseIf sticks = 15 Then
            txtCurrentStatusPile.Text = "|||||||||||||||"

        ElseIf sticks = 16 Then
            txtCurrentStatusPile.Text = "||||||||||||||||"

        ElseIf sticks = 17 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||"

        ElseIf sticks = 18 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||"

        ElseIf sticks = 19 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||"

        ElseIf sticks = 20 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||"

        ElseIf sticks = 21 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||"

        ElseIf sticks = 22 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||"

        ElseIf sticks = 23 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||"

        ElseIf sticks = 24 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||"

        ElseIf sticks = 25 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||"

        ElseIf sticks = 26 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||"

        ElseIf sticks = 27 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||||"

        ElseIf sticks = 28 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||||"

        ElseIf sticks = 29 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||||||"

        ElseIf sticks = 30 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||||||"

        ElseIf sticks = 31 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||||||||"

        ElseIf sticks = 32 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||||||||"

        ElseIf sticks = 33 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||||||||||"

        ElseIf sticks = 34 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||||||||||"

        ElseIf sticks = 35 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||||||||||||"

        ElseIf sticks = 36 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||||||||||||"

        ElseIf sticks = 37 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||||||||||||||"

        ElseIf sticks = 38 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||||||||||||||"

        ElseIf sticks = 39 Then
            txtCurrentStatusPile.Text = "|||||||||||||||||||||||||||||||||||||||"

        ElseIf sticks = 40 Then
            txtCurrentStatusPile.Text = "||||||||||||||||||||||||||||||||||||||||"


        End If

        computerChoosePlayer()

        'luego yo como user tengo que removerlo manualment pero LA COMPUTER ES AUTOMATICAMENTE
    End Sub

    Sub computerChoosePlayer()

        'si los sticks que divida entre 4 medan remainder de 1 then user go first
        If sticks Mod 4 = 1 Then
            MessageBox.Show("User or person goes first because of remainder 1")

        Else

            If sticks Mod 4 = 0 Then
                MessageBox.Show("Computer goes first remainder 0")
                'entocnes es turno de la computer

            ElseIf sticks Mod 4 = 2 Then
                MessageBox.Show("Computer goes first remainder 2")
                'solo remueve un stick si quiero remover mas le pongo - otro stick en btndos

            ElseIf sticks Mod 4 = 3 Then
                MessageBox.Show("Computer goes first remainder 3")


            End If

            computerRemovingSticks()

        End If

    End Sub

    Sub computerRemovingSticks()
        'If computer = True Then
        If (sticks Mod 4) = 0 Then
            MsgBox("There are " & sticks & " And 3 sticks seran removidas por computer")
            sticks -= 3
            txtCurrentStatusPile.Text = sticks.ToString
            MsgBox("There are " & sticks & " And 3 sticks fueron removidas por computer")
            If sticks = 1 Then ' si queda un stick nadamas se acabo el juego
                txtCurrentStatusPile.Text = sticks.ToString
                MessageBox.Show("Computer won, there is only one stick  and it is user turn")
                txtCurrentStatusPile.Text = sticks.ToString
            End If

        ElseIf (sticks Mod 4) = 3 Then
            MsgBox("There are " & sticks & " And 2 sticks seran removidas por computer")
            sticks -= 2
            txtCurrentStatusPile.Text = sticks.ToString
            If sticks = 1 Then ' si queda un stick nadamas se acabo el juego
                txtCurrentStatusPile.Text = sticks.ToString
                MessageBox.Show("Computer won, there is only one stick  and it is user turn")
                txtCurrentStatusPile.Text = sticks.ToString
            End If
        ElseIf (sticks Mod 4) = 2 Then
            MsgBox("There are " & sticks & " And 1 stick sera removida por computer")
            sticks -= 1
            txtCurrentStatusPile.Text = sticks.ToString
            If sticks = 1 Then ' si queda un stick nadamas se acabo el juego
                txtCurrentStatusPile.Text = sticks.ToString
                MessageBox.Show("Computer won, there is only one stick  and it is user turn")
                txtCurrentStatusPile.Text = sticks.ToString
            End If
        End If
        'SOLO HACE FALTA ALGO QUE DIGA Q DESPUES DE LA COM SIGUE EL USUARIO
    End Sub

    'ESTE BOTON ES PARA EL HUMANO LA COMPUTADORA DEBE SE AUTOMATICAMENTE SEGUN LE TOQUE
    Private Sub bntSelectOneStick_Click(sender As Object, e As EventArgs) Handles bntSelectOneStick.Click, btnSelectTwoSticks.Click, btnSelectThreeSticks.Click

        If sender.Equals(bntSelectOneStick) Then


            If sticks = 0 Then
                MessageBox.Show("There are no sticks to play with. Start a new game")

            Else ' pero si tenemos stickes. es turno humano remover

                sticks = sticks - 1
                MessageBox.Show("One stick was removed by user or person, now there are  " & sticks)
                'ahora display cuantos sticks fueron removed
                txtCurrentStatusPile.Text = sticks.ToString

                'ADESPUES DE MOVER LE HUMANO LE TOCA A LA COMPUTER AKI PODRIA LLAMAR ESA FUNCION
                computerRemovingSticks()
                txtCurrentStatusPile.Text = sticks.ToString
            End If

        ElseIf sender.Equals(btnSelectTwoSticks) Then

            If sticks = 0 Then
                MessageBox.Show("There are no sticks to play with. Start a new game")

            Else ' pero si tenemos stickes. es turno humano remover

                sticks = sticks - 2
                MessageBox.Show("Two sticks were removed by user or person, now there are  " & sticks)
                'ahora display cuantos sticks fueron removed
                txtCurrentStatusPile.Text = sticks.ToString

                'ADESPUES DE MOVER LE HUMANO LE TOCA A LA COMPUTER AKI PODRIA LLAMAR ESA FUNCION
                computerRemovingSticks()
                txtCurrentStatusPile.Text = sticks.ToString

            End If

        ElseIf sender.Equals(btnSelectThreeSticks) Then

            If sticks = 0 Then
                MessageBox.Show("There are no sticks to play with. Start a new game")

            Else ' pero si tenemos stickes. es turno humano remover

                sticks = sticks - 3
                MessageBox.Show("Three sticks were removed by user or person, now there are  " & sticks)
                'ahora display cuantos sticks fueron removed
                txtCurrentStatusPile.Text = sticks.ToString

                'ADESPUES DE MOVER LE HUMANO LE TOCA A LA COMPUTER AKI PODRIA LLAMAR ESA FUNCION
                computerRemovingSticks()
                txtCurrentStatusPile.Text = sticks.ToString

            End If

        End If

    End Sub

    Private Sub btnRulesOfGame_Click(sender As Object, e As EventArgs) Handles btnRulesOfGame.Click
        MessageBox.Show("Choose a number of sticks between 5 and 40. Then the computer will choose who is going to start playing. You can remove 1, 2 or 3 sticks and the last player that removes the last sticks loses")
    End Sub
End Class

'Note: en casa turno debo de remover 1,2 o 3 sticks del pile
''sticks = Convert.ToString(txtCurrentStatusPile.Text)
