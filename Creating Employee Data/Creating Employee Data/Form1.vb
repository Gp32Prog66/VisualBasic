Imports System.IO

Public Class Form1

    'File Variables
    Private strFileName As String = String.Empty
    Dim blnFileFlag As Boolean = False


    'Save Statement
    Sub SaveFile()
        Dim employeeFile As StreamWriter

        Try
            'Create the File
            employeeFile = File.CreateText(strFileName)

            'Write Inputs to File
            employeeFile.Write(txtFirstName.Text & vbCrLf)
            employeeFile.Write(txtMiddleName.Text & vbCrLf)
            employeeFile.Write(txtLastName.Text & vbCrLf)
            employeeFile.Write(txtEmployee.Text & vbCrLf)
            employeeFile.Write(cmbDepartment.Text & vbCrLf)
            employeeFile.Write(txtPhone.Text & vbCrLf)
            employeeFile.Write(txtExtension.Text & vbCrLf)
            employeeFile.Write(txtEmail.Text & vbCrLf)

            'Close File
            employeeFile.Close()

            'Update File Flag
            blnFileFlag = False

        Catch ex As Exception
            'Error Message
            MessageBox.Show("Couldn't Read or Find the File")
        End Try
    End Sub



    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtMiddleName.Clear()
        txtLastName.Clear()
        txtEmployee.Clear()
        cmbDepartment.Text = ""
        txtPhone.Clear()
        txtExtension.Clear()
        txtEmail.Clear()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'Save As File/Record
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFileName = sfdSaveFile.FileName
            SaveFile()
        End If
    End Sub

    Private Sub txtFirstName_TextChanged(sender As Object, e As EventArgs) Handles txtFirstName.TextChanged
        blnFileFlag = True
    End Sub
End Class
