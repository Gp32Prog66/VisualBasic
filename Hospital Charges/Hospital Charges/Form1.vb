Public Class Form1
    'Declare Variables
    Dim intDaysSpent As Integer = 0
    Dim decStayCharges As Decimal = 0.00
    Const decHospitalCharges As Decimal = 350D '$350 Per Day
    Dim decMED_CHARGES As Decimal = 0.00
    Dim decSURGCHARGES As Decimal = 0.00
    Dim decLAB_FEE As Decimal = 0.00
    Dim decPHYSICALREHAB As Decimal = 0.00
    Dim decTotalCharges As Decimal = 0.0
    Dim decMiscCharges As Decimal = 0.0
    Dim decInputInfoValid As Boolean

    'Function Find the Amount of Days the Patient is Spent at the Hospital
    Function CalcStayCharges(ByVal decHospitalCharges As Decimal) As Decimal
        Dim intDaysSpent As Integer

        'Formula to find Days Spent
        decStayCharges = decHospitalCharges * intDaysSpent

        Return decStayCharges

    End Function

    'Function Calculates and Returns the total of Physical Rehab, Medicine, Surgical, and Laboratory Fees
    Function CalcMiscCharges(ByVal decMedicationCharges As Decimal, ByVal decSurgCharges As Decimal,
                             ByVal decLabFee As Decimal, ByVal decPhysicalRehabilitation As Decimal) As Decimal

        'Adding Up All Fees Into the decMiscCharges Variable
        decMiscCharges = (decMedicationCharges + decSurgCharges + decLabFee + decPhysicalRehabilitation)


        Return decMiscCharges

    End Function

    'Function Calculates the Total Charges
    Function CalcTotalCharges(ByVal decStayCharges As Decimal, ByVal decMiscCharges As Decimal) As Decimal

        Dim decTotalCharge As Decimal

        decTotalCharge = CalcStayCharges(decHospitalCharges) + CalcMiscCharges(decMED_CHARGES, decSURGCHARGES, decLAB_FEE, decPHYSICALREHAB)


        Return decTotalCharge

    End Function

    'Check For Valid Input Fields and If Correct Numbers are Added
    Private Function ValidateInputFields() As Boolean

        'Invalid User Input Check
        If Not Integer.TryParse(txtDaysSpent.Text, decHospitalCharges) Then
            lblTotalCharges.Text = "Days Spent Invalid"
            Return False
        End If

        If Not Decimal.TryParse(txtMedication.Text, decMED_CHARGES) Then
            lblTotalCharges.Text = "Medication Amount Invalid"
            Return False
        End If

        If Not Decimal.TryParse(txtSurgicalCharges.Text, decSURGCHARGES) Then
            lblTotalCharges.Text = "Surgical Amount Invalid"
            Return False
        End If

        If Not Decimal.TryParse(txtLabratoryFees.Text, decLAB_FEE) Then
            lblTotalCharges.Text = "Laboratory Amount Invalid"
        End If

        If Not Decimal.TryParse(txtPhysicalRehab.Text, decPHYSICALREHAB) Then
            lblTotalCharges.Text = "Physical Rehab Amount Invalid"
        End If

        'Negative Amount Check
        If decStayCharges <= 0 Then
            lblTotalCharges.Text = "Days Spent Cant be Negative"
            Return False


        ElseIf decMED_CHARGES <= 0 Then
            lblTotalCharges.Text = "Medication Fee Can't be Negative"
            Return False


        ElseIf decSurgCharges <= 0 Then
            lblTotalCharges.Text = "Surgical Charges Can't be Negative"
            Return False

        ElseIf decLAB_FEE <= 0 Then
            lblTotalCharges.Text = "Labratory Fees Can't be Negative"
            Return False

        ElseIf decPHYSICALREHAB <= 0 Then
            lblTotalCharges.Text = "Physical Fees Can't be Negative"
            Return False
        End If


        Return decInputInfoValid
        Return True
    End Function


    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear Everything from the form
        txtDaysSpent.Clear()
        txtLabratoryFees.Clear()
        txtMedication.Clear()
        txtPhysicalRehab.Clear()
        txtSurgicalCharges.Clear()
        lblTotalCharges.Text = String.Empty
    End Sub

    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click

        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim decTotalCharges As Decimal
        Dim decHospitalCharges As Decimal
        Dim decMiscCharges As Decimal
      

        If ValidateInputFields()
            decHospitalCharges = CalcStayCharges(decHospitalCharges)
            decMiscCharges = CalcMiscCharges(decLAB_FEE, decMED_CHARGES, decPHYSICALREHAB, decSURGCHARGES)
            decTotalCharges = CalcTotalCharges(decMiscCharges, decStayCharges)



        End If

    End Sub
End Class
