Imports System.IO

Public Class Form1
    'Class Level Variables
    Private strFilename As String = String.Empty
    Dim blnIsChanged As Boolean = False

    Sub ClearDocument()
        'Clear contents
        txtDocument.Clear()

        'Clear the document name
        strFilename = String.Empty

        'Set isChanged to False
        blnIsChanged = False
    End Sub

    Sub OpenDocument()
        Dim inputFile As StreamReader

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Retrieve the selected filename
            strFilename = ofdOpenFile.FileName

            Try
                'Open the File
                inputFile = File.OpenText(strFilename)

                'Read the file's contents into the TextBox
                txtDocument.Text = inputFile.ReadToEnd

                'Close File
                inputFile.Close()

                'Update the isChanged variable
                blnIsChanged = False
            Catch ex As Exception
                'Error Message
                MessageBox.Show("Error opening the file.")

            End Try
        End If
    End Sub

    Sub SaveDocument()
        Dim outputFile As StreamWriter 'Object Variable

        Try
            'Create File
            outputFile = File.CreateText(strFilename)

            'Write the TextBox to the file.
            outputFile.Write(txtDocument.Text)

            'Close file
            outputFile.Close()

            'Update isChanged Variable
            blnIsChanged = False
        Catch ex As Exception
            'Error Message
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub

    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        'Has the current document changed?
        If blnIsChanged = True Then
            'Confirm before clearing the document
            If MessageBox.Show("The Current documentis not sabved." &
                               "Are you sure?", "Confirm", MessageBoxButtons.YesNo) =
                               Windows.Forms.DialogResult.Yes Then
                ClearDocument()
            End If
        Else
            'Document hasn't changed, so clear it.
            ClearDocument()
        End If
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        'Has the current document changed?
        If blnIsChanged = True Then
            'Confirm before clearing and replacing
            If MessageBox.Show("The Current document is not saved. " &
                               "Are you sure?", "Confirm",
                                MessageBoxButtons.YesNo) =
                                Windows.Forms.DialogResult.Yes Then
                ClearDocument()
                OpenDocument()
            End If
        Else
            'Document hasn't changed, so replace it.
            ClearDocument()
            OpenDocument()
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        'Does the current document have a file name?
        If strFilename = String.Empty Then
            'The document hasn't been saved, so use Save As Dialog Box.
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFilename = sfdSaveFile.FileName
                SaveDocument()

            End If
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        'Save the current document under a new filename
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFilename = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        MessageBox.Show("Simple Text Editor Version 1.0")
    End Sub

    Private Sub Form1_FormClosing(sender As System.Object, e As System.ComponentModel.CancelEventArgs) Handles Me.FormClosing
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " &
                               "Do you wish to discard your changes?",
                                "Confirm",
                                MessageBoxButtons.YesNo) =
                                Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles ofdOpenFile.FileOk

    End Sub

    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        'Print the contents of the text box
        e.Graphics.DrawString(txtDocument.Text, New Font("MS Sans Serif",
        12, FontStyle.Regular), Brushes.Black, 10, 10)
    End Sub

    Private Sub mnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        'Open the Print Dialog
        If pddPrintDialog.ShowDialog() = DialogResult.OK Then
            'Get the printer settings
            pdPrint.PrinterSettings = pddPrintDialog.PrinterSettings

            'Print the document
            pdPrint.Print()
        End If
    End Sub
End Class
