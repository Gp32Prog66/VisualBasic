Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub compareBtn_Click(sender As Object, e As EventArgs) Handles compareBtn.Click
        'Declare Variables
        Dim intVarA As Integer
        Dim intVarB As Integer

        Try
            'Use TryParse Method Before Comparing
            If Integer.TryParse(txtBoxA.Text, intVarA) Then
                intVarA = txtBoxA.Text
            ElseIf Integer.TryParse(txtBoxB.Text, intVarB) Then
                intVarB = txtBoxB.Text
            Else
                MessageBox.Show("Please Enter An Integer Value")
            End If

            'Assign the Textboxes to the Variables to Compare Numbers
            intVarA = CDbl(txtBoxA.Text)

            intVarB = CDbl(txtBoxB.Text)

            'Logic to Display Results in Label
            If intVarA > intVarB Then
                lblResult.Text = "Value A is Bigger than Value B"
            ElseIf intVarA < intVarB Then
                lblResult.Text = "Value B is Bigger than Value A"
            Else
                lblResult.Text = "Both Values are Equal"
            End If

        Catch ex As Exception
            'Error Message
            lblResult.Text = "Put in the Other Number"

        End Try


    End Sub
End Class
