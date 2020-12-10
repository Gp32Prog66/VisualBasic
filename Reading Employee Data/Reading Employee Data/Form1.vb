Imports System.IO


Public Class Form1
    'File Variables
    Dim friendFile As StreamReader
    Dim strFile As String
    Dim boolChange As Boolean


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            'Retrive Selected File
            strFile = ofdOpenFile.FileName

            Try
                'Open the file.
                friendFile = File.OpenText(strFile)

                'Close File
                friendFile.Close()

                'Update boolChange Variable
                boolChange = False
            Catch
                'Error
                MessageBox.Show("File Couldn't be Opened")

            End Try
        End If
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear all Results
        lblRecordNumber.Text = String.Empty
        lblFirstName.Text = String.Empty
        lblMiddleName.Text = String.Empty
        lblLastName.Text = String.Empty
        lblEmployee.Text = String.Empty
        lblDepartment.Text = String.Empty
        lblPhone.Text = String.Empty
        lblExtension.Text = String.Empty
        lblEmail.Text = String.Empty

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        'Variables on MainForm
        Dim strFirstName As String
        Dim strMiddleName As String
        Dim strLastName As String
        Dim strEmployee As String
        Dim strDepartment As String
        Dim strPhone As String
        Dim strExtension As String
        Dim strEmail As String

        Try

            'Read Data
            Do Until friendFile.EndOfStream

                strFirstName = friendFile.ReadLine()
                strMiddleName = friendFile.ReadLine()
                strLastName = friendFile.ReadLine()
                strEmployee = friendFile.ReadLine()
                strDepartment = friendFile.ReadLine()
                strPhone = friendFile.ReadLine()
                strExtension = friendFile.ReadLine()
                strEmail = friendFile.ReadLine()

            Loop

            'Close File
            friendFile.Close()

        Catch ex As Exception
            'Error Message
            MessageBox.Show("The Program Couldn't Read the File. It Could be Possibly Missing")

        End Try

    End Sub


End Class
