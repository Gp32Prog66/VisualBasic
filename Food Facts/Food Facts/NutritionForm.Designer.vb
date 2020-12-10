<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NutritionForm
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
        Me.lblFood = New System.Windows.Forms.Label()
        Me.lblCalories = New System.Windows.Forms.Label()
        Me.lblFat = New System.Windows.Forms.Label()
        Me.lblCarb = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblFood
        '
        Me.lblFood.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFood.Location = New System.Drawing.Point(88, 34)
        Me.lblFood.Name = "lblFood"
        Me.lblFood.Size = New System.Drawing.Size(100, 23)
        Me.lblFood.TabIndex = 0
        '
        'lblCalories
        '
        Me.lblCalories.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCalories.Location = New System.Drawing.Point(88, 75)
        Me.lblCalories.Name = "lblCalories"
        Me.lblCalories.Size = New System.Drawing.Size(100, 23)
        Me.lblCalories.TabIndex = 1
        '
        'lblFat
        '
        Me.lblFat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblFat.Location = New System.Drawing.Point(88, 118)
        Me.lblFat.Name = "lblFat"
        Me.lblFat.Size = New System.Drawing.Size(100, 23)
        Me.lblFat.TabIndex = 2
        '
        'lblCarb
        '
        Me.lblCarb.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCarb.Location = New System.Drawing.Point(88, 157)
        Me.lblCarb.Name = "lblCarb"
        Me.lblCarb.Size = New System.Drawing.Size(100, 23)
        Me.lblCarb.TabIndex = 3
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(88, 198)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(51, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Food"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Calories"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(27, 118)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Fat Grams"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(20, 157)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(62, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Carb Grams"
        '
        'NutritionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(232, 233)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblCarb)
        Me.Controls.Add(Me.lblFat)
        Me.Controls.Add(Me.lblCalories)
        Me.Controls.Add(Me.lblFood)
        Me.Name = "NutritionForm"
        Me.Text = "NutritionForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblFood As Label
    Friend WithEvents lblCalories As Label
    Friend WithEvents lblFat As Label
    Friend WithEvents lblCarb As Label
    Friend WithEvents btnClose As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
