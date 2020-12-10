Public Class Form1
    'Class-Level Declarations
    Const decTAX_RATE As Decimal = 0.06D
    Const decWHITE_BAGEL As Decimal = 1.25D
    Const decWHEAT_BAGEL As Decimal = 1.5D
    Const decCREAM_CHEESE As Decimal = 0.5D
    Const decBUTTER As Decimal = 0.25D
    Const decBLUEBERRY As Decimal = 0.75D
    Const decRASPBERRY As Decimal = 0.75D
    Const decPEACH As Decimal = 0.75D
    Const decREG_COFFEE As Decimal = 1.25D
    Const decCAPPUCCINO As Decimal = 2D
    Const decDAFE_AU_LAIT As Decimal = 1.75D

    Function CalcBagelCost() As Decimal
        'This fuction returns the cost of the selected bagel
        Dim decBagel As Decimal

        If radPlain.Checked = True Then
            decBagel = decWHITE_BAGEL
        Else
            decBagel = decWHEAT_BAGEL
        End If

        Return decBagel
    End Function

    Function CalcToppingCost() As Decimal
        'This function returns the cost of the toppings
        Dim decCostOfTopping As Decimal = 0D

        If chkCreamCheese.Checked = True Then
            decCostOfTopping += decCREAM_CHEESE
        End If

        If chkButter.Checked = True Then
            decCostOfTopping += decBUTTER
        End If

        If chkBlueBerry.Checked = True Then
            decCostOfTopping += decBLUEBERRY
        End If

        If chkRaspberry.Checked = True Then
            decCostOfTopping += decRASPBERRY
        End If

        If chkPeach.Checked = True Then
            decCostOfTopping += decPEACH
        End If

        Return decCostOfTopping
    End Function

    Function CalcCoffeeCost() As Decimal
        'This function returns the cost of the selected coffee.
        Dim decCoffee As Decimal

        If radNoCoffee.Checked Then
            decCoffee = 0D
        ElseIf radStandardCoffee.Checked Then
            decCoffee = decREG_COFFEE
        ElseIf radCappuccino.Checked Then
            decCoffee = decCAPPUCCINO
        ElseIf radCafeAuLait.Checked = True Then
            decCoffee = decDAFE_AU_LAIT

        End If

        Return decCoffee
    End Function

    Function CalcTax(ByVal decAmount As Decimal) As Decimal
        'This function receives the sale amount and returns the amount of sales tax
        Return decAmount * decTAX_RATE
    End Function

    Sub ResetBagels()
        'This Function receives the sale amount and returns the amount of sales tax
        radPlain.Checked = True
    End Sub

    Sub ResetToppings()
        'This procedure resets the toppping selection.
        chkCreamCheese.Checked = False
        chkButter.Checked = False
        chkBlueBerry.Checked = False
        chkPeach.Checked = False
        chkRaspberry.Checked = False
    End Sub

    Sub ResetCoffee()
        'This procedure resets the coffee selection
        radStandardCoffee.Checked = True
    End Sub

    Sub ResetPrice()
        'This procedure resets the price.
        lblSubTotal.Text = String.Empty
        lblTax.Text = String.Empty
        lblTotal.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Calculating total of an order

        Dim decSubtotal As Decimal
        Dim decTax As Decimal
        Dim decTotal As Decimal
        decSubtotal = CalcBagelCost() + CalcToppingCost() + CalcCoffeeCost()
        decTax = CalcTax(decSubtotal)
        decTotal = decSubtotal + decTax

        lblSubtotal.Text = decSubtotal.ToString("c")
        lblTax.Text = decTax.ToString("c")
        lblTotal.Text = decTotal.ToString("c")

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ResetBagels()
        ResetToppings()
        ResetCoffee()
        ResetPrice()
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
