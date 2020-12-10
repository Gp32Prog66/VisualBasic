Public Class PrintBookForm
    'Declare Variables
    Dim decBookOne_FEE As Decimal = 11.95D
    Dim decBookTwo_FEE As Decimal = 14.5D
    Dim decBookThree_FEE As Decimal = 29.95D
    Dim decBookFour_FEE As Decimal = 18.5D
    Dim decShipping_FEE As Decimal = 2D

    Public Const decTaxRATE As Decimal = 0.06D

    Public decSubtotal As Decimal
    Public decTax As Decimal
    Public decShipping As Decimal
    Public decTotal As Decimal

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub PrintBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DisplayPrintBooks()

    End Sub

    Function PrintBooksSelection(ByVal decTotal As Decimal) As Decimal
        Dim decPrintBookChoice As Decimal = 0D


        Select Case lstPrint.SelectedIndex
            Case 0
                decPrintBookChoice += decBookOne_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("I Did It Your Way")
            Case 1
                decPrintBookChoice += decBookTwo_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("The History Of Scotland")
            Case 2
                decPrintBookChoice += decBookThree_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("Learn Calculus in One Day")
            Case 3
                decPrintBookChoice += decBookFour_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("Feel The Stress")
        End Select

        'Add to Subtotal in the Shopping Cart Form
        ShoppingCartForm.lblSubtotal.Text = decPrintBookChoice.ToString("c")

        Return decPrintBookChoice
    End Function

    Public Function CalculateTax(ByVal decAmount As Decimal) As Decimal

        Return decAmount * decTaxRATE
    End Function

    Private Sub lstPrint_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstPrint.SelectedIndexChanged


    End Sub

    'Display Print Books
    Sub DisplayPrintBooks()
        lstPrint.Items.Add("I Did It Your Way   ($11.95)")
        lstPrint.Items.Add("The History Of Scotland     ($14.50)")
        lstPrint.Items.Add("Learn Calculus in One Day   ($29.95)")
        lstPrint.Items.Add("Feel The Stress     ($18.50)")

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click

        PrintBooksSelection(decBookOne_FEE)
        CalculateTax(decTaxRATE)


        'Print to Shipping Label on ShoppingCart Form
        ShoppingCartForm.lblShipping.Text = decShipping.ToString("c")

        'Subtotal Formula
        decSubtotal = AudioBookForm.AudioBooksSelection(decTotal) + PrintBooksSelection(decTotal)

        'Calling Tax Function
        decTax = CalculateTax(decSubtotal)

        'Print Tax on ShoppingCart Form
        ShoppingCartForm.lblTax.Text = decTax.ToString("c")

        'Total Formula
        decTotal = decSubtotal + decTax + decShipping

        'Print to Total Label on ShoppingCart Form
        ShoppingCartForm.lblTotal.Text = decTotal.ToString("c")


    End Sub
End Class