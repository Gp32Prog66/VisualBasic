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
        Me.lblOne = New System.Windows.Forms.Label()
        Me.lblTwo = New System.Windows.Forms.Label()
        Me.lblThree = New System.Windows.Forms.Label()
        Me.lblFour = New System.Windows.Forms.Label()
        Me.lblFive = New System.Windows.Forms.Label()
        Me.btnGenNum = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblOne
        '
        Me.lblOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOne.Location = New System.Drawing.Point(12, 50)
        Me.lblOne.Name = "lblOne"
        Me.lblOne.Size = New System.Drawing.Size(100, 23)
        Me.lblOne.TabIndex = 0
        Me.lblOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTwo
        '
        Me.lblTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTwo.Location = New System.Drawing.Point(131, 50)
        Me.lblTwo.Name = "lblTwo"
        Me.lblTwo.Size = New System.Drawing.Size(100, 23)
        Me.lblTwo.TabIndex = 1
        Me.lblTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblThree
        '
        Me.lblThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblThree.Location = New System.Drawing.Point(248, 50)
        Me.lblThree.Name = "lblThree"
        Me.lblThree.Size = New System.Drawing.Size(100, 23)
        Me.lblThree.TabIndex = 2
        Me.lblThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFour
        '
        Me.lblFour.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFour.Location = New System.Drawing.Point(366, 50)
        Me.lblFour.Name = "lblFour"
        Me.lblFour.Size = New System.Drawing.Size(100, 23)
        Me.lblFour.TabIndex = 3
        Me.lblFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblFive
        '
        Me.lblFive.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFive.Location = New System.Drawing.Point(482, 50)
        Me.lblFive.Name = "lblFive"
        Me.lblFive.Size = New System.Drawing.Size(100, 23)
        Me.lblFive.TabIndex = 4
        Me.lblFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnGenNum
        '
        Me.btnGenNum.Location = New System.Drawing.Point(81, 153)
        Me.btnGenNum.Name = "btnGenNum"
        Me.btnGenNum.Size = New System.Drawing.Size(75, 36)
        Me.btnGenNum.TabIndex = 5
        Me.btnGenNum.Text = "Generate Numbers"
        Me.btnGenNum.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(444, 166)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(595, 201)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnGenNum)
        Me.Controls.Add(Me.lblFive)
        Me.Controls.Add(Me.lblFour)
        Me.Controls.Add(Me.lblThree)
        Me.Controls.Add(Me.lblTwo)
        Me.Controls.Add(Me.lblOne)
        Me.Name = "Form1"
        Me.Text = "Lottery Numbers"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblOne As Label
    Friend WithEvents lblTwo As Label
    Friend WithEvents lblThree As Label
    Friend WithEvents lblFour As Label
    Friend WithEvents lblFive As Label
    Friend WithEvents btnGenNum As Button
    Friend WithEvents btnExit As Button
End Class
