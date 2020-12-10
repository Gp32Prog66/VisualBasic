<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblExtension = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblDepartment = New System.Windows.Forms.Label()
        Me.lblEmployee = New System.Windows.Forms.Label()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.lblMiddleName = New System.Windows.Forms.Label()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.LabelMiddle = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblRecordNumber = New System.Windows.Forms.Label()
        Me.ofdOpenFile = New System.Windows.Forms.OpenFileDialog()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(12, 313)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 0
        Me.btnNext.Text = "Next Record"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(140, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(291, 313)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblExtension)
        Me.GroupBox1.Controls.Add(Me.lblPhone)
        Me.GroupBox1.Controls.Add(Me.lblEmail)
        Me.GroupBox1.Controls.Add(Me.lblDepartment)
        Me.GroupBox1.Controls.Add(Me.lblEmployee)
        Me.GroupBox1.Controls.Add(Me.lblLastName)
        Me.GroupBox1.Controls.Add(Me.lblMiddleName)
        Me.GroupBox1.Controls.Add(Me.lblFirstName)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.LabelMiddle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 35)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(277, 272)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter Employee Data"
        '
        'lblExtension
        '
        Me.lblExtension.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblExtension.Location = New System.Drawing.Point(123, 202)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(88, 23)
        Me.lblExtension.TabIndex = 15
        '
        'lblPhone
        '
        Me.lblPhone.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblPhone.Location = New System.Drawing.Point(123, 167)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(88, 23)
        Me.lblPhone.TabIndex = 14
        '
        'lblEmail
        '
        Me.lblEmail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmail.Location = New System.Drawing.Point(123, 237)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(88, 23)
        Me.lblEmail.TabIndex = 13
        '
        'lblDepartment
        '
        Me.lblDepartment.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDepartment.Location = New System.Drawing.Point(123, 132)
        Me.lblDepartment.Name = "lblDepartment"
        Me.lblDepartment.Size = New System.Drawing.Size(88, 23)
        Me.lblDepartment.TabIndex = 12
        '
        'lblEmployee
        '
        Me.lblEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblEmployee.Location = New System.Drawing.Point(123, 101)
        Me.lblEmployee.Name = "lblEmployee"
        Me.lblEmployee.Size = New System.Drawing.Size(88, 23)
        Me.lblEmployee.TabIndex = 11
        '
        'lblLastName
        '
        Me.lblLastName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLastName.Location = New System.Drawing.Point(123, 75)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(88, 23)
        Me.lblLastName.TabIndex = 10
        '
        'lblMiddleName
        '
        Me.lblMiddleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblMiddleName.Location = New System.Drawing.Point(123, 45)
        Me.lblMiddleName.Name = "lblMiddleName"
        Me.lblMiddleName.Size = New System.Drawing.Size(88, 23)
        Me.lblMiddleName.TabIndex = 9
        '
        'lblFirstName
        '
        Me.lblFirstName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFirstName.Location = New System.Drawing.Point(123, 16)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(88, 23)
        Me.lblFirstName.TabIndex = 8
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(76, 238)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Email:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(61, 203)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(56, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Extension:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(76, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 13)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Phone:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Department:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Employee ID:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 75)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Last Name:"
        '
        'LabelMiddle
        '
        Me.LabelMiddle.AutoSize = True
        Me.LabelMiddle.Location = New System.Drawing.Point(45, 46)
        Me.LabelMiddle.Name = "LabelMiddle"
        Me.LabelMiddle.Size = New System.Drawing.Size(72, 13)
        Me.LabelMiddle.TabIndex = 1
        Me.LabelMiddle.Text = "Middle Name:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(57, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "First Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(67, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Record Number:"
        '
        'lblRecordNumber
        '
        Me.lblRecordNumber.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRecordNumber.Location = New System.Drawing.Point(170, 9)
        Me.lblRecordNumber.Name = "lblRecordNumber"
        Me.lblRecordNumber.Size = New System.Drawing.Size(75, 23)
        Me.lblRecordNumber.TabIndex = 5
        '
        'ofdOpenFile
        '
        Me.ofdOpenFile.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 348)
        Me.Controls.Add(Me.lblRecordNumber)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnNext)
        Me.Name = "Form1"
        Me.Text = "Employee Data"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNext As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents LabelMiddle As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblRecordNumber As Label
    Friend WithEvents lblExtension As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblDepartment As Label
    Friend WithEvents lblEmployee As Label
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblMiddleName As Label
    Friend WithEvents ofdOpenFile As OpenFileDialog
End Class
