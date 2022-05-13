Public Class Form1
    'Declaramos variables globales

    Dim Address As String
    Dim cityStateZip As String
    Dim numberOfChairs, n As Integer
    Dim numberOfSofas As Integer
    Dim firstName, lastName As String
    Dim fullName As String
    Dim zipCode, zipLastFour, right As String

    Private Sub btnClearOrderForm_Click(sender As Object, e As EventArgs) Handles btnClearOrderForm.Click
        txtCustomerName.Clear()
        txtAddress.Clear()
        txtCityStateZip.Clear()
        txtNumberOfChairsOrdered.Clear()
        txtNumberOfSofasOrdered.Clear()
        lstInvoiceDisplay.Items.Clear()

    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        End
    End Sub

    Private Sub btnProcessOrder_Click(sender As Object, e As EventArgs) Handles btnProcessOrder.Click

        'Dim name As String
        'Dim firstName, lastName As String
        'Dim fullName As String
        Dim totalPriceChairs As Integer
        Dim totalPriceSofas, totalPriceChairSofa As Integer
        Dim percentage, precioTotalConPercentage As Double



        'los argumentos se separan con comas
        lstInvoiceDisplay.Items.Add("Invoice number is: " & createInvoice(txtCustomerName.Text, txtCityStateZip.Text))
        lstInvoiceDisplay.Items.Add("")
        cambialastToFirstName(txtCustomerName.Text)

        'fullName = txtCustomerName.Text 'aqui recibimos en nombre completo
        'n = fullName.IndexOf(" ") 'Este nos regresa el index donde se encuentra el espacio
        'lastName = fullName.Substring(0, n - 1) 'quiero que empieze en cero y me de caracteres hasta donde esta un espacio pero sin la coma
        'la sig linea muestra first name y last name en el lstbox
        'firstName = fullName.Substring(n)
        'lstInvoiceDisplay.Items.Add("First Name is: " & firstName & " " & lastName)




        Address = txtAddress.Text 'Aqui recivimos el address del textbox
        lstInvoiceDisplay.Items.Add("Address: " & Address)


        cityStateZip = txtCityStateZip.Text 'aqui recivimos el city, state and city en el txtbox
        lstInvoiceDisplay.Items.Add("City: " & cityStateZip)

        lstInvoiceDisplay.Items.Add("")
        numberOfChairs = txtNumberOfChairsOrdered.Text
        totalPriceChairs = numberOfChairs * 350
        lstInvoiceDisplay.Items.Add("Number of Chairs: " & numberOfChairs)

        'lstInvoiceDisplay.Items.Add("")
        numberOfSofas = txtNumberOfSofasOrdered.Text
        totalPriceSofas = numberOfSofas * 925
        lstInvoiceDisplay.Items.Add("Number of Sofas:  " & numberOfSofas)

        lstInvoiceDisplay.Items.Add("")
        totalPriceChairSofa = totalPriceChairs + totalPriceSofas
        lstInvoiceDisplay.Items.Add("                Price:  " & (totalPriceChairSofa).ToString("C")) ' asi se hace para pner$ y comas o pto
        'sales tax o porcentaje de 5%
        percentage = (totalPriceChairSofa * 5) / 100
        lstInvoiceDisplay.Items.Add("          Sales Tax:  " & (percentage).ToString("C"))
        lstInvoiceDisplay.Items.Add("               --------------------------------")
        precioTotalConPercentage = totalPriceChairSofa + percentage
        lstInvoiceDisplay.Items.Add("         Total Price: " & (precioTotalConPercentage).ToString("C"))




    End Sub
    'la sig linea cambia el last name al ultimo y pone el firstname primero
    Function cambialastToFirstName(name As String) As String


        fullName = txtCustomerName.Text 'aqui recibimos en nombre completo
        n = fullName.IndexOf(" ") 'Este nos regresa el index donde se encuentra el espacio
        lastName = fullName.Substring(0, n - 1) 'quiero que empieze en cero y me de caracteres hasta donde esta un espacio pero sin la coma
        'la sig linea muestra first name y last name en el lstbox
        firstName = fullName.Substring(n)
        lstInvoiceDisplay.Items.Add("Name: " & firstName & " " & lastName)

        'Return firstN

    End Function

    'la sig funcion es para display the invoice 2uppercase primeras letras del apellido y last 4 del zipcode
    Function createInvoice(s As String, c As String) As String

        'Genera invoice, capital first 2 letters de lastname + 4 ultimos del zipcode
        'n = fullName.IndexOf(" ") 'Este nos regresa el index donde se encuentra el espacio
        fullName = txtCustomerName.Text
        lastName = fullName.Substring(0, 2)
        'lastName.ToUpper() ' si quisiera hacer el display asi como esta necesito guardarlo en una variable para poder mostrarlo
        'lstInvoiceDisplay.Items.Add("Invoice number is: " & lastName)
        'lstInvoiceDisplay.Items.Add("Invoice number is: " & (lastName).ToUpper)


        cityStateZip = txtCityStateZip.Text 'aqui recivimos el city, state and city en el txtbox
        n = cityStateZip.IndexOf(" ") 'Este nos regresa el index donde se encuentra el espacio
        zipCode = cityStateZip.Substring(n + 1) 'quiero que me imprima despues de espacio, o sea que sin incluirlo
        'lstInvoiceDisplay.Items.Add(zipCode)

        n = zipCode.IndexOf(" ")
        zipLastFour = zipCode.Substring(n)
        'la sig linea es para imprimir los ultimos 4 digitos
        right = zipLastFour.Substring(zipLastFour.Length - 4, 4)
        'lstInvoiceDisplay.Items.Add("n esta en el index: " + n.ToString + " zip las four: " + zipLastFour)
        'lstInvoiceDisplay.Items.Add("el resutado de right es: " + right)
        'lstInvoiceDisplay.Items.Add("Invoice Number: " & (lastName).ToUpper & right)

        Return (lastName).ToUpper & right
    End Function


End Class
