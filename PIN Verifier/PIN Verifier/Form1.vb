Public Class Form1

    Dim intMinimumArray = New Integer() {7, 5, 0, 0, 6, 3, 4}
    Dim intMaximumArray = New Integer() {9, 7, 4, 9, 9, 6, 8}
    Const intMAXIMUM_SUBSCRIPT As Integer = 6

    Dim intPinHolder As Integer = 0

    Dim intPinNumber As Integer
    Dim intCounter As Integer


    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click

        'Checking Index
        Try

            If txtDigitOne.Text >= intMinimumArray.Index(0) And txtDigitOne <= intMaximumArray.Length(0) Then
                txtDigitOne.Text = (intPinHolder)


                'Validates First Number
                intPinNumber = intPinNumber + 1
            End If

            If txtDigitOne.Text >= intMinimumArray.Index(1) And txtDigitOne <= intMaximumArray.Length(1) Then
                txtDigitTwo.Text = (intPinHolder)

                'Validates Second Number
                intPinNumber = intPinNumber + 1
            End If
            If txtDigitThree.Text >= intMinimumArray.Index(2) And txtDigitOne <= intMaximumArray.Length(2) Then
                txtDigitThree.Text = (intPinHolder)

                'Validates Third Number
                intPinNumber = intPinNumber + 1
            End If
            If txtDigitFour.Text >= intMinimumArray.Index(3) And txtDigitOne <= intMaximumArray.Length(3) Then
                txtDigitFour.Text = (intPinHolder)

                'Validates Fourth Number
                intPinNumber = intPinNumber + 1
            End If
            If txtDigitFive.Text >= intMinimumArray.Index(4) And txtDigitOne <= intMaximumArray.Length(4) Then
                txtDigitFive.Text = (intPinHolder)

                'Validates Fifth Number
                intPinNumber = intPinNumber + 1
            End If
            If txtDigitSix.Text >= intMinimumArray.Index(5) And txtDigitOne <= intMaximumArray.Length(5) Then
                txtDigitSix.Text = (intPinHolder)

                'Validates Sixth Number
                intPinNumber = intPinNumber + 1
            End If
            If txtDigitSeven.Text >= intMinimumArray.Index(6) And txtDigitOne <= intMaximumArray.Length(6) Then

                    txtDigitSeven.Text = (intPinHolder)
                    'Validates Seventh Number
                    intPinNumber = intPinNumber + 1
                End If

                If intPinNumber = 7 Then
                'Display that the User's Pin Number is Verified
                MessageBox.Show("Your Pin Number has been Verified")

            Else
                'Display that the User's Pin Number is Verified
                MessageBox.Show("Your Pin Number Couldn't be Verified")

            End If

        Catch ex As Exception
            'Display Error Message
            MessageBox.Show("Please Enter a Valid Numeric Value")

        End Try

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clears Every Text Box
        txtDigitOne.Text = String.Empty
        txtDigitTwo.Text = String.Empty
        txtDigitThree.Text = String.Empty
        txtDigitFour.Text = String.Empty
        txtDigitFive.Text = String.Empty
        txtDigitSix.Text = String.Empty
        txtDigitSeven.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close Application
        Me.Close()
    End Sub

End Class
