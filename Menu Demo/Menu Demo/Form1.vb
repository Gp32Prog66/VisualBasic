Public Class Form1
    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Close Form Via File Exit
        Me.Close()
    End Sub

    Private Sub mnuColorRed_Click(sender As Object, e As EventArgs) Handles mnuColorRed.Click
        'Set the label's foreground color to red
        lblMessage.ForeColor = Color.Red
    End Sub

    Private Sub mnuColorGreen_Click(sender As Object, e As EventArgs) Handles mnuColorGreen.Click
        'Set the label's foreground color to green
        lblMessage.ForeColor = Color.Green
    End Sub

    Private Sub mnuColorBlue_Click(sender As Object, e As EventArgs) Handles mnuColorBlue.Click
        'Set the label's foreground color to blue
        lblMessage.ForeColor = Color.Blue
    End Sub

    Private Sub mnuColorBlack_Click(sender As Object, e As EventArgs) Handles mnuColorBlack.Click
        'Set the label's foreground color to black
        lblMessage.ForeColor = Color.Black
    End Sub

    Private Sub mnuColorVisible_Click(sender As Object, e As EventArgs) Handles mnuColorVisible.Click
        'Make the label visible or invisible
        If mnuColorVisible.Checked = True Then
            lblMessage.Visible = True
        Else
            lblMessage.Visible = False
        End If
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'Display a simple About Box.
        MessageBox.Show("A Simple Menu System Demo")
    End Sub
End Class
