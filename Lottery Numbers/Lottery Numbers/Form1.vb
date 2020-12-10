Public Class Form1
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnGenNum_Click(sender As Object, e As EventArgs) Handles btnGenNum.Click
        Const intMAX_SUBSCRIPT As Integer = 4 ' Max Subscript
        Dim intLottery(intMAX_SUBSCRIPT) As Integer
        Dim intCount As Integer

        'Random Object
        Dim rand As New Random

        'Fill the array with random numbers
        'Each number will be 0-99
        For intCount = 0 To intMAX_SUBSCRIPT
            intLottery(intCount) = rand.Next(100)
        Next

        'Display the array elements in the labels.
        lblOne.Text = intLottery(0).ToString()
        lblTwo.Text = intLottery(1).ToString()
        lblThree.Text = intLottery(2).ToString()
        lblFour.Text = intLottery(3).ToString()
        lblFive.Text = intLottery(4).ToString()
    End Sub


End Class
