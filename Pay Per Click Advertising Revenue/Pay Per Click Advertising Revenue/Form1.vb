Public Class Form1
    Private Sub exitBtn_Click(sender As Object, e As EventArgs) Handles exitBtn.Click
        Me.Close()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        'Clear Revenue
        lblWeekOneRevenue.Text = String.Empty
        lblWeekTwoRevenue.Text = String.Empty
        lblWeekThreeRevenue.Text = String.Empty
        lblWeekFourRevenue.Text = String.Empty

        'Clear Clicks
        weeklyClicksOne.Text = String.Empty
        weeklyClicksTwo.Text = String.Empty
        weeklyClicksThree.Text = String.Empty
        weeklyClicksFour.Text = String.Empty

        'Clear Cost Per Week
        txtCostPerWeek.Clear()

        'Clear Error Message
        lblError.Text = String.Empty

    End Sub

    Private Sub calcBtn_Click(sender As Object, e As EventArgs) Handles calcBtn.Click
        Dim decNumClicks As Integer
        Dim decCostOfAdvertisement As Decimal
        Dim decPayPerClick As Double

        Try

            'Catch Invalid Input For Advertising Cost Per Week
            If Integer.TryParse(txtCostPerWeek.Text, decNumClicks) Then
                decCostOfAdvertisement = txtCostPerWeek.Text
            Else
                lblError.Text = "Please Enter a Valid Number in Advertisement Cost Per Week"
            End If

            'Calculate Week 1
            If Integer.TryParse(weeklyClicksOne.Text, decPayPerClick) Then
                decPayPerClick = txtCostPerWeek.Text / weeklyClicksOne.Text
            Else
                lblError.Text = "Please Enter a Valid Number in Week 1"
            End If

            'Display Week 1 Revenue
            lblWeekOneRevenue.Text = CStr(decPayPerClick.ToString("f"))

            'Calculate Week 2
            If Integer.TryParse(weeklyClicksTwo.Text, decPayPerClick) Then
                decPayPerClick = txtCostPerWeek.Text / weeklyClicksTwo.Text
            Else
                lblError.Text = "Please Enter a Valid Number in Week 2"
            End If

            'Display Week 2 Revenue
            lblWeekTwoRevenue.Text = CStr(decPayPerClick.ToString("f"))


            If Integer.TryParse(weeklyClicksThree.Text, decPayPerClick) Then
                'Calculate Week 3
                decPayPerClick = txtCostPerWeek.Text / weeklyClicksThree.Text
            Else
                lblError.Text = "Please Enter a Valid Number in Week 3"
            End If



            'Display Week 3 Revenue
            lblWeekThreeRevenue.Text = CStr(decPayPerClick.ToString("f"))

            If Integer.TryParse(weeklyClicksFour.Text, decPayPerClick) Then
                'Calculate Week 4
                decPayPerClick = txtCostPerWeek.Text / weeklyClicksFour.Text
            Else
                lblError.Text = "Please Enter a Valid Number in Week 4"
            End If

            'Display Week 4 Revenue
            lblWeekFourRevenue.Text = CStr(decPayPerClick.ToString("f"))



        Catch ex As Exception
            'Error Message
            lblError.Text = "Error: You need to fill in all of the information is all of the boxes."

        End Try

    End Sub
End Class
