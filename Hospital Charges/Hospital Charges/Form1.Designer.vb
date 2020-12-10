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
        Me.exitBtn = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDaysSpent = New System.Windows.Forms.TextBox()
        Me.txtMedication = New System.Windows.Forms.TextBox()
        Me.txtSurgicalCharges = New System.Windows.Forms.TextBox()
        Me.txtLabratoryFees = New System.Windows.Forms.TextBox()
        Me.txtPhysicalRehab = New System.Windows.Forms.TextBox()
        Me.lblTotalCharges = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(264, 308)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 0
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(133, 308)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 1
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(12, 308)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 2
        Me.btnCalculate.Text = "Calculate Charges"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(34, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Length of Days Stayed"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(64, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Medication Fees"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Surgical Charges"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(72, 163)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Labratory Fees"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 207)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Physical Rehab"
        '
        'txtDaysSpent
        '
        Me.txtDaysSpent.Location = New System.Drawing.Point(155, 28)
        Me.txtDaysSpent.Name = "txtDaysSpent"
        Me.txtDaysSpent.Size = New System.Drawing.Size(100, 20)
        Me.txtDaysSpent.TabIndex = 8
        '
        'txtMedication
        '
        Me.txtMedication.Location = New System.Drawing.Point(155, 77)
        Me.txtMedication.Name = "txtMedication"
        Me.txtMedication.Size = New System.Drawing.Size(100, 20)
        Me.txtMedication.TabIndex = 9
        '
        'txtSurgicalCharges
        '
        Me.txtSurgicalCharges.Location = New System.Drawing.Point(155, 119)
        Me.txtSurgicalCharges.Name = "txtSurgicalCharges"
        Me.txtSurgicalCharges.Size = New System.Drawing.Size(100, 20)
        Me.txtSurgicalCharges.TabIndex = 10
        '
        'txtLabratoryFees
        '
        Me.txtLabratoryFees.Location = New System.Drawing.Point(155, 163)
        Me.txtLabratoryFees.Name = "txtLabratoryFees"
        Me.txtLabratoryFees.Size = New System.Drawing.Size(100, 20)
        Me.txtLabratoryFees.TabIndex = 11
        '
        'txtPhysicalRehab
        '
        Me.txtPhysicalRehab.Location = New System.Drawing.Point(155, 207)
        Me.txtPhysicalRehab.Name = "txtPhysicalRehab"
        Me.txtPhysicalRehab.Size = New System.Drawing.Size(100, 20)
        Me.txtPhysicalRehab.TabIndex = 12
        '
        'lblTotalCharges
        '
        Me.lblTotalCharges.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblTotalCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCharges.Location = New System.Drawing.Point(26, 256)
        Me.lblTotalCharges.Name = "lblTotalCharges"
        Me.lblTotalCharges.Size = New System.Drawing.Size(303, 35)
        Me.lblTotalCharges.TabIndex = 13
        Me.lblTotalCharges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 338)
        Me.Controls.Add(Me.lblTotalCharges)
        Me.Controls.Add(Me.txtPhysicalRehab)
        Me.Controls.Add(Me.txtLabratoryFees)
        Me.Controls.Add(Me.txtSurgicalCharges)
        Me.Controls.Add(Me.txtMedication)
        Me.Controls.Add(Me.txtDaysSpent)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.exitBtn)
        Me.Name = "Form1"
        Me.Text = "Hospital Charges"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitBtn As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDaysSpent As TextBox
    Friend WithEvents txtMedication As TextBox
    Friend WithEvents txtSurgicalCharges As TextBox
    Friend WithEvents txtLabratoryFees As TextBox
    Friend WithEvents txtPhysicalRehab As TextBox
    Friend WithEvents lblTotalCharges As Label
End Class
