Public Class Form1
    Dim cardNumber As String
    Dim cardIntegers As Integer
    Dim i As Integer
    Dim numeroMenosNueve, totalAllIntegers As Integer
    Dim totalTemp As Integer


    Private Sub btnValidateNumber_Click(sender As Object, e As EventArgs) Handles btnValidateNumber.Click
        cardNumber = txtCardNumber.Text 'recibo un string de numeros y lo guardo como String


        'txtValid.Text = cardNumber

        For i = 0 To cardNumber.Length - 1 ' solo puedo iterar un string no un integer type

            'Debug.Print(cardNumber(i))
            Dim total, porDoble As Integer

            txtValid.Text = cardNumber(i) 'Imprime los numeros pero en columna por eso solo me aparece el ultimo
            MessageBox.Show(cardNumber.Length - 1)

            'total += Val(cardNumber(i)) 'Este convierte char a integer y acumula
            total = Val(cardNumber(i)) 'Este convierte char a integer y imprimime todos los caracteres en todos los indices
            Debug.Print(total)
            'AHORA NECESITO MULTIPLICAR CADA DIGITO  X2 
            porDoble = total * 2
            Debug.Print(porDoble)
            i += 1 ' add 1 to i. In other words is next one plus one

            Dim temp, temp2 As Integer

            ' convertimos a string otra vez para por usar el .length
            'temp = CStr(porDoble)
            'im temp2 As String = temp(i)



            'si porDoble tiene dos digitos. si es numero de dos dijitos entonces resta 9
            If porDoble >= 10 Then

                'resta  9 de el numero que tenga dos digitos

                numeroMenosNueve = porDoble - 9
                Debug.Print(numeroMenosNueve)

                'numeroMenosNueve += CStr(numeroMenosNueve(i))
                'temp = CStr(numeroMenosNueve) 'convertimos el resultado de los numeros destados menos 9 a string

                ' 
                temp += (numeroMenosNueve + numeroMenosNueve) - numeroMenosNueve
                Debug.Print(temp)
                MessageBox.Show(temp)
            ElseIf porDoble < 10 Then
                temp2 += porDoble
                MessageBox.Show("este es si poDoble es < 10 entonces deberia darme 16")
                MessageBox.Show(temp2)


            End If

            totalTemp = temp + temp2
            MessageBox.Show("este nos tiene que dar 25:   " & totalTemp)
            Debug.Print(totalTemp)

            sumando()




        Next



    End Sub
        
    Sub sumando()
        'llamamos function add
        cardIntegers = add(cardNumber)
        MessageBox.Show("ESTE TENDRIA QUE DAR 35:   " & cardIntegers)

        totalAllIntegers = totalTemp + cardIntegers
        MessageBox.Show(totalAllIntegers)

        'if 60 mod 10 = 0 entonces es entero
        If totalAllIntegers Mod 10 = 0 Then
            'if it returns cero then it is an integer and a multiple of 10
            ' if 60 mod 10 = 0 Then accept credit card
            txtValid.Text = True

        Else
            txtValid.Text = False

        End If
    End Sub


    Function add(s As String) As Integer

        cardNumber = txtCardNumber.Text 'recibo un string de numeros y lo guardo como String
        Dim total2 As Integer
        Dim j As Integer ' tenemos que usar j pq si uso i me da un error
        For j = 1 To cardNumber.Length - 1



            'IMPLEMENTEMOS ALGO PARA SUMAR LOS DIGITOS REQUERIDOS
            'total = CType(cardNumber(i), Integer) ' esta funcion es muy util para convertir excepto char a integer


            'total += Val(cardNumber(i)) 'Este convierte char a integer y acumula
            total2 += Val(cardNumber(j)) 'Este convierte char a integer y imprimime todos los caracteres en todos los indices
            Debug.Print(total2)

            j += 1 'el siguiente index mas uno

        Next

        Return total2

    End Function



End Class
