Public Class AudioBookForm
    'Declare Variables
    Dim decAudioOne_FEE As Decimal = 29.95D
    Dim decAudioTwo_FEE As Decimal = 14.5D
    Dim decAudioThree_FEE As Decimal = 12.95D
    Dim decAudioFour_FEE As Decimal = 11.5D
    Dim decShipping_FEE As Decimal = 2D

    Public Const decTaxRATE As Decimal = 0.06D

    Public decSubtotal As Decimal
    Public decTax As Decimal
    Public decShipping As Decimal
    Public decTotal As Decimal

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub AudioBookForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        DisplayAudioBooks()

    End Sub

    Function AudioBooksSelection(ByVal decTotal As Decimal) As Decimal
        Dim decAudioBookChoice As Decimal = 0D

        Select Case lstAudio.SelectedIndex
            Case 0
                decAudioBookChoice += decAudioOne_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("Learn Calculus in One Day")
            Case 1
                decAudioBookChoice += decAudioTwo_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("The History Of Scotland")
            Case 2
                decAudioBookChoice += decAudioThree_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("The Science of Body Language")
            Case 3
                decAudioBookChoice += decAudioFour_FEE
                decShipping += decShipping_FEE
                ShoppingCartForm.lstSelection.Items.Add("Relaxation Techniques")
        End Select

        'Add to Subtotal in the Shopping Cart Form
        ShoppingCartForm.lblSubtotal.Text = decAudioBookChoice.ToString("c")

        Return decAudioBookChoice
    End Function

    Public Function CalculateTax(ByVal decAmount As Decimal) As Decimal

        Return decAmount * decTaxRATE
    End Function

    'Display Audio Books
    Sub DisplayAudioBooks()
        lstAudio.Items.Add("Learn Calculus in One Day   ($29.95)")
        lstAudio.Items.Add("The History Of Scotland     ($14.50)")
        lstAudio.Items.Add("The Science of Body Language    ($12.95)")
        lstAudio.Items.Add("Relaxation Techniques       ($11.50)")
    End Sub



    Private Sub lstAudio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAudio.SelectedIndexChanged

    End Sub

    Private Sub btnAddToCart_Click(sender As Object, e As EventArgs) Handles btnAddToCart.Click


        AudioBooksSelection(decAudioFour_FEE)
        CalculateTax(decTaxRATE)


        ShoppingCartForm.lblTotal.Text = decTotal.ToString("c")

        ShoppingCartForm.lblShipping.Text = decShipping.ToString("c")


        'Subtotal Formula
        decSubtotal = PrintBookForm.PrintBooksSelection(decTotal) + AudioBooksSelection(decTotal)

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