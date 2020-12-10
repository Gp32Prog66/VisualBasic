Public Class Form1
    Dim intSpeed As Integer
    Dim intTime As Integer
    Dim strSpeed As String
    Dim strTime As String
    Dim intDistance As Integer
    Dim intDistancePerHour As Integer
    Dim intHourCounter As Integer = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Try


            For intDistance = 0 To 7

                'Hopefully Clear the Previous Results Automatically When Entered Multiple Times
                lstOutput.Items.Clear()


                strSpeed = InputBox("Please Enter the Speed of the Vehicle")
                intSpeed = CDbl(strSpeed)
                lstOutput.Items.Add("Vehicle Speed: " & strSpeed & " m.p.h ")

                strTime = InputBox("Pleae Enter the Time")
                intTime = CDbl(strTime)
                lstOutput.Items.Add("Time Traveled: " & strTime & " hours ")

                'Displaying the Hours and Time Headers 
                lstOutput.Items.Add("Hours:  " & " Distance Traveled ")
                lstOutput.Items.Add("-------------------------------------------")

                'Display Each Hour
                For Index = 1 To intTime

                    'Display Each Distance Traveled at Each Hour
                    Do While intHourCounter < strTime

                        'Distance Formula
                        intDistance = (intTime * intSpeed)

                        intHourCounter += 1

                        'Figure Out Each Distance Per Hour
                        intDistancePerHour = (intSpeed / intHourCounter)

                        'Display Each Distance Traveled Per Hour
                        lstOutput.Items.Add(intHourCounter & "          " & intDistance / intTime * intHourCounter)
                    Loop
                Next

                'Displaying the Total Distance
                lstOutput.Items.Add("Total Distance: " & intDistance)

            Next
        Catch
            'Show Error
            MessageBox.Show("An Error has Occured")
        End Try


    End Sub
End Class
