Public Class Form1

    Private decRetail As Decimal     'Retail price
    Private decPercentage As Decimal 'Discount Percentage

    Private Function ValidateInputFields() As Boolean
        'Converting each of the input fields. Returns False if any field
        'is invalid, and display a suitable error message

        If Not Decimal.TryParse(txtRetailPrice.Text, decRetail) Then
            lblMessage.Text = "Retail price must be numeric"
            Return False
        End If

        If Not Decimal.TryParse(txtDiscountPercent.Text, decPercentage) Then
            lblMessage.Text = "Discount percentage must be numeric"
            Return False
        End If

        Return True
    End Function

    Function CalculateSalePrice(ByVal decRetail As Decimal,
                                ByVal decPercentage As Decimal) As Decimal
        'Calculating and returning Sale Price
        Dim decSalePrice As Decimal
        decSalePrice = decRetail - (decRetail * decPercentage)
        Return decSalePrice
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtSalePriceClick(sender As Object, e As EventArgs) Handles lblSalePrice.Click

    End Sub

    Private Sub calcSalePrice_Click(sender As Object, e As EventArgs) Handles calcSalePrice.Click
        Dim decSalePrice As Decimal
        lblMessage.Text = String.Empty

        'If the input is valid, display the sale price.
        If ValidateInputFields() Then
            decSalePrice = CalculateSalePrice(decRetail, decPercentage)
            lblSalePrice.Text = decSalePrice.ToString("c")
        End If
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub
End Class
