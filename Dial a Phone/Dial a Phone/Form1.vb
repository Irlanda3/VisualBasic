Public Class pushButtons
    Dim one As String
    Dim two As String
    Dim tres As String
    Dim cuatro As String
    Dim cinco As String
    Dim seis As String
    Dim siete As String
    Dim ocho As String
    Dim nueve As String
    Dim star As String
    Dim zero As Integer
    Dim gato, k, p As String
    'Dim arraystr() As String
    Dim array() As String
    Dim acumulado As String
    Friend acumuladoTransferir As String

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Calc()
        txtNumeros.Text = acumulado
        acumuladoTransferir = acumulado

    End Sub
    Sub Calc()
        'manda los numeros recivicos a la otra forma


        'Dim array() As String = {1, 2, 3, 4}


        'usaremos join para poder escribir todos los numeros juntos sino solo imprimira el ultimo

        For i As Integer = 0 To array.Length - 1
            ' Join array.
            Dim result As String = String.Join("", array) 'los va a concatenar sin espacios
            txtNumeros.Text = result

        Next
    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'si el boton es clicked guarda el numero para ponerlo en el text box;
        'pero sin encimarlo
        one = "1"
        acumulado += one

        'array(0) = one
        'MessageBox.Show(array(0))
        'one = txtNumeros.Text


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        two = "2"
        acumulado += two
        'array(1) = two
        'MessageBox.Show(array(1))

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        tres = 3
        acumulado += tres
        'array(2) = tres
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        cuatro = "4"
        array(3) = 4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        cinco = "5"
        array(4) = 5
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        seis = 6
        array(5) = seis

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        siete = 7
        array(6) = siete
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        ocho = 8
        array(7) = ocho

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        nueve = 9
        array(8) = nueve
    End Sub

    Private Sub btnStar_Click(sender As Object, e As EventArgs) Handles btnStar.Click
        star = "*"
        array(9) = star
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumeros.Clear()
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        zero = 0
        array(10) = zero
    End Sub

    Private Sub btnGato_Click(sender As Object, e As EventArgs) Handles btnGato.Click
        gato = "#"
        array(11) = gato
    End Sub


End Class
