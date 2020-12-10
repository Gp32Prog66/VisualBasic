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
        Me.calcBtn = New System.Windows.Forms.Button()
        Me.clearBtn = New System.Windows.Forms.Button()
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.weeklyClicksFour = New System.Windows.Forms.TextBox()
        Me.weeklyClicksThree = New System.Windows.Forms.TextBox()
        Me.weeklyClicksTwo = New System.Windows.Forms.TextBox()
        Me.weeklyClicksOne = New System.Windows.Forms.TextBox()
        Me.lblWeekOneRevenue = New System.Windows.Forms.Label()
        Me.lblWeekTwoRevenue = New System.Windows.Forms.Label()
        Me.lblWeekThreeRevenue = New System.Windows.Forms.Label()
        Me.lblWeekFourRevenue = New System.Windows.Forms.Label()
        Me.txtCostPerWeek = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.info2Lbl = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.infoLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'calcBtn
        '
        Me.calcBtn.Location = New System.Drawing.Point(66, 407)
        Me.calcBtn.Name = "calcBtn"
        Me.calcBtn.Size = New System.Drawing.Size(75, 23)
        Me.calcBtn.TabIndex = 0
        Me.calcBtn.Text = "Calculate"
        Me.calcBtn.UseVisualStyleBackColor = True
        '
        'clearBtn
        '
        Me.clearBtn.Location = New System.Drawing.Point(263, 407)
        Me.clearBtn.Name = "clearBtn"
        Me.clearBtn.Size = New System.Drawing.Size(75, 23)
        Me.clearBtn.TabIndex = 1
        Me.clearBtn.Text = "Clear Info"
        Me.clearBtn.UseVisualStyleBackColor = True
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(468, 407)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 2
        Me.exitBtn.Text = "Exit Program"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'weeklyClicksFour
        '
        Me.weeklyClicksFour.Location = New System.Drawing.Point(291, 317)
        Me.weeklyClicksFour.Name = "weeklyClicksFour"
        Me.weeklyClicksFour.Size = New System.Drawing.Size(100, 20)
        Me.weeklyClicksFour.TabIndex = 3
        Me.weeklyClicksFour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'weeklyClicksThree
        '
        Me.weeklyClicksThree.Location = New System.Drawing.Point(291, 275)
        Me.weeklyClicksThree.Name = "weeklyClicksThree"
        Me.weeklyClicksThree.Size = New System.Drawing.Size(100, 20)
        Me.weeklyClicksThree.TabIndex = 4
        Me.weeklyClicksThree.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'weeklyClicksTwo
        '
        Me.weeklyClicksTwo.Location = New System.Drawing.Point(291, 233)
        Me.weeklyClicksTwo.Name = "weeklyClicksTwo"
        Me.weeklyClicksTwo.Size = New System.Drawing.Size(100, 20)
        Me.weeklyClicksTwo.TabIndex = 5
        Me.weeklyClicksTwo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'weeklyClicksOne
        '
        Me.weeklyClicksOne.Location = New System.Drawing.Point(291, 192)
        Me.weeklyClicksOne.Name = "weeklyClicksOne"
        Me.weeklyClicksOne.Size = New System.Drawing.Size(100, 20)
        Me.weeklyClicksOne.TabIndex = 6
        Me.weeklyClicksOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblWeekOneRevenue
        '
        Me.lblWeekOneRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekOneRevenue.Location = New System.Drawing.Point(428, 189)
        Me.lblWeekOneRevenue.Name = "lblWeekOneRevenue"
        Me.lblWeekOneRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekOneRevenue.TabIndex = 7
        Me.lblWeekOneRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeekTwoRevenue
        '
        Me.lblWeekTwoRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekTwoRevenue.Location = New System.Drawing.Point(428, 230)
        Me.lblWeekTwoRevenue.Name = "lblWeekTwoRevenue"
        Me.lblWeekTwoRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekTwoRevenue.TabIndex = 8
        Me.lblWeekTwoRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeekThreeRevenue
        '
        Me.lblWeekThreeRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekThreeRevenue.Location = New System.Drawing.Point(428, 272)
        Me.lblWeekThreeRevenue.Name = "lblWeekThreeRevenue"
        Me.lblWeekThreeRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekThreeRevenue.TabIndex = 9
        Me.lblWeekThreeRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblWeekFourRevenue
        '
        Me.lblWeekFourRevenue.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWeekFourRevenue.Location = New System.Drawing.Point(428, 314)
        Me.lblWeekFourRevenue.Name = "lblWeekFourRevenue"
        Me.lblWeekFourRevenue.Size = New System.Drawing.Size(100, 23)
        Me.lblWeekFourRevenue.TabIndex = 10
        Me.lblWeekFourRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txtCostPerWeek
        '
        Me.txtCostPerWeek.Location = New System.Drawing.Point(341, 92)
        Me.txtCostPerWeek.Name = "txtCostPerWeek"
        Me.txtCostPerWeek.Size = New System.Drawing.Size(100, 20)
        Me.txtCostPerWeek.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(445, 158)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 16)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Revenue"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(89, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(146, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Advertisment Cost Per Week:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(272, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "1"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(272, 240)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(272, 278)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "3"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(272, 324)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "4"
        '
        'lblError
        '
        Me.lblError.ForeColor = System.Drawing.Color.DarkRed
        Me.lblError.Location = New System.Drawing.Point(25, 240)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(157, 132)
        Me.lblError.TabIndex = 18
        Me.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'info2Lbl
        '
        Me.info2Lbl.Location = New System.Drawing.Point(25, 171)
        Me.info2Lbl.Name = "info2Lbl"
        Me.info2Lbl.Size = New System.Drawing.Size(197, 20)
        Me.info2Lbl.TabIndex = 19
        Me.info2Lbl.Text = "Number of Ad Clicks The Past 4 Weeks"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(25, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(525, 10)
        Me.Label2.TabIndex = 20
        '
        'infoLabel
        '
        Me.infoLabel.Location = New System.Drawing.Point(54, 19)
        Me.infoLabel.Name = "infoLabel"
        Me.infoLabel.Size = New System.Drawing.Size(474, 55)
        Me.infoLabel.TabIndex = 21
        Me.infoLabel.Text = "This Program Calculates the amount of advertising revenue paid to a Site that dis" &
    "plays links to a selected vendor."
        Me.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(565, 442)
        Me.Controls.Add(Me.infoLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.info2Lbl)
        Me.Controls.Add(Me.lblError)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCostPerWeek)
        Me.Controls.Add(Me.lblWeekFourRevenue)
        Me.Controls.Add(Me.lblWeekThreeRevenue)
        Me.Controls.Add(Me.lblWeekTwoRevenue)
        Me.Controls.Add(Me.lblWeekOneRevenue)
        Me.Controls.Add(Me.weeklyClicksOne)
        Me.Controls.Add(Me.weeklyClicksTwo)
        Me.Controls.Add(Me.weeklyClicksThree)
        Me.Controls.Add(Me.weeklyClicksFour)
        Me.Controls.Add(Me.exitBtn)
        Me.Controls.Add(Me.clearBtn)
        Me.Controls.Add(Me.calcBtn)
        Me.Name = "Form1"
        Me.Text = "Pay Per Click Advertising Revenue"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents calcBtn As Button
    Friend WithEvents clearBtn As Button
    Friend WithEvents exitBtn As Button
    Friend WithEvents weeklyClicksFour As TextBox
    Friend WithEvents weeklyClicksThree As TextBox
    Friend WithEvents weeklyClicksTwo As TextBox
    Friend WithEvents weeklyClicksOne As TextBox
    Friend WithEvents lblWeekOneRevenue As Label
    Friend WithEvents lblWeekTwoRevenue As Label
    Friend WithEvents lblWeekThreeRevenue As Label
    Friend WithEvents lblWeekFourRevenue As Label
    Friend WithEvents txtCostPerWeek As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents lblError As Label
    Friend WithEvents info2Lbl As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents infoLabel As Label
End Class
