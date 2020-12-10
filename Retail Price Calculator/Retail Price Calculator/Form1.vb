Public Class Form1
    'Declaring Variables
    Dim decWholeCost As Decimal
    Dim decMarkupPercentage As Decimal

    'Check To See if the Input is Valid before performing the Calculations of the Retail Price by checking the decWholeCost and decMarkupCPercentage
    Private Function ValidationOfInputFields() As Boolean

        If Not Decimal.TryParse(txtMarkPercentage.Text, decMarkupPercentage) Then
            lblRetailPrice.Text = "Markup Invalid"
            Return False
        End If

        If Not Decimal.TryParse(txtWholesalePrice.Text, decWholeCost) Then
            lblRetailPrice.Text = "WholeSale Invalid"
            Return False
        End If

        'Check to See if The Markup Percentage and the Whole Sale Price are negative Numbers
        If decMarkupPercentage <= 0 Then
            lblRetailPrice.Text = "Negative Markup"
            Return False
        ElseIf decWholeCost <= 0 Then
            lblRetailPrice.Text = "Negative WholeSale"
            Return False
        End If

        Return True
    End Function

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub btnRetailPrice_Click(sender As Object, e As EventArgs) Handles btnRetailPrice.Click
        Dim decRetailPrice As Decimal
        lblRetailPrice.Text = String.Empty

        'If the input is valid, display the sale price.
        If ValidationOfInputFields() Then
            decRetailPrice = CalculateRetail(decMarkupPercentage, decWholeCost)
            lblRetailPrice.Text = decRetailPrice.ToString("c")
        End If

    End Sub

    'CalculateRetail Price Function
    Function CalculateRetail(ByVal decWholeCost As Decimal,
                             ByVal decMarkupPercentage As Decimal) As Decimal

        Dim decRetailPrice As Decimal


        'Formula To Find the Retail Price

        'Use of 100 to make sure the MarkupPercentage is converted to a proper percentage and not a full number
        decRetailPrice = CInt(((decMarkupPercentage / 100) * decWholeCost + decWholeCost))

        'Return Retail Price
        Return decRetailPrice + decWholeCost 'Add the Whole Cost from the Formula Above in the CalculateRetail Function

    End Function

End Class
