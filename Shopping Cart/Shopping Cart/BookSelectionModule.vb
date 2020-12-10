Module BookSelectionModule

    Public Constant

    Const decTaxRATE As Decimal = 0.6D

    Public Function CalculateSubTotal(ByVal decBar As Decimal) As Decimal
        Dim decSubtotal As Decimal

        Return decBar
    End Function

    Public Function CalculateTax(ByVal decAmount As Decimal) As Decimal

        Return decAmount * decTaxRATE
    End Function

    Public Function CalculateShipping(ByVal itemCount As Integer) As Decimal
        Dim decShipping As Decimal
    End Function

    Public Function CalculateTotal()
        Dim decTotal As Decimal
    End Function

    'ShoppingCartForm.lblSubtotal.Text = decSubtotal.ToString("c")
    'ShoppingCartForm.lblTax.Text = decSubtotal.ToString("c")
    'ShoppingCartForm.lblTotal.Text = decSubtotal.ToString("c")
End Module
