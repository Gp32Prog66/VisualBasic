Public Class Form1

    Dim strUserNumber As String
    Dim intNumberInput As Integer

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMaxValue_Click(sender As Object, e As EventArgs) Handles btnMaxValue.Click

        'Use Try and Catch For Error Catching
        Try
            'Prompt User To Enter Integer and Translate The Input From String To Integer
            strUserNumber = InputBox(Prompt:="Please enter a positive integer to be used as the maximum value.", "Input Needed", 1) 'Make Default 1
            intNumberInput = CDbl(strUserNumber)

            If strUserNumber <= 0 Then
                MessageBox.Show("The Numbers can't be negative or 0")

            Else


                'Formula For The Program using a For Loop
                For index = 0 To intNumberInput

                    'Formula Itself
                    intNumberInput = strUserNumber * (strUserNumber + 1) / 2

                Next

                'Results
                MessageBox.Show("The sum of numbers through 1 through " & strUserNumber & " is " & intNumberInput)
            End If
        Catch
            'Show Error with Message Box and on the Console
            MessageBox.Show("You entered an invalid input. Please enter valid input")
            Console.WriteLine("Invalid User Input")
        End Try

    End Sub
End Class
