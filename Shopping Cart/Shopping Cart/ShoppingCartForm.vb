Public Class ShoppingCartForm
    Public Const decTaxRATE As Decimal = 0.06D

    Public decSubtotal As Decimal
    Public decTax As Decimal
    Public decTotal As Decimal




    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuReset_Click(sender As Object, e As EventArgs) Handles mnuReset.Click
        'Clear Labels
        lblSubtotal.Text = ""
        lblTax.Text = ""
        lblShipping.Text = ""
        lblTotal.Text = ""
    End Sub




    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        MessageBox.Show("Book Ordering Shopping Cart Demo Version 1.0")
    End Sub

    Private Sub mnuPrintBooks_Click(sender As Object, e As EventArgs) Handles mnuPrintBooks.Click
        'Creating instance of Print Books Form
        Dim frmPrintBook As New PrintBookForm

        'Display PrintBook Form
        frmPrintBook.ShowDialog()
    End Sub

    Private Sub mnuAudioBooks_Click(sender As Object, e As EventArgs) Handles mnuAudioBooks.Click
        'Creating instance of Audio Books Form
        Dim frmAudioBook As New AudioBookForm

        'Display AudioBook Form
        frmAudioBook.ShowDialog()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'Remove Selected Item In List
        lstSelection.Items.Remove(lstSelection.SelectedItem)


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
