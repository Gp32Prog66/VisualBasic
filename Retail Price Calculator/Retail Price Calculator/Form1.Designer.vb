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
        Me.btnRetailPrice = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtWholesalePrice = New System.Windows.Forms.TextBox()
        Me.txtMarkPercentage = New System.Windows.Forms.TextBox()
        Me.lblRetailPrice = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'exitBtn
        '
        Me.exitBtn.Location = New System.Drawing.Point(158, 302)
        Me.exitBtn.Name = "exitBtn"
        Me.exitBtn.Size = New System.Drawing.Size(75, 23)
        Me.exitBtn.TabIndex = 0
        Me.exitBtn.Text = "Exit"
        Me.exitBtn.UseVisualStyleBackColor = True
        '
        'btnRetailPrice
        '
        Me.btnRetailPrice.Location = New System.Drawing.Point(4, 290)
        Me.btnRetailPrice.Name = "btnRetailPrice"
        Me.btnRetailPrice.Size = New System.Drawing.Size(75, 35)
        Me.btnRetailPrice.TabIndex = 1
        Me.btnRetailPrice.Text = "Get Retail Price"
        Me.btnRetailPrice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(41, 211)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Retail Price"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(1, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Markup Percentage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Wholesale Price"
        '
        'txtWholesalePrice
        '
        Me.txtWholesalePrice.Location = New System.Drawing.Point(122, 53)
        Me.txtWholesalePrice.Name = "txtWholesalePrice"
        Me.txtWholesalePrice.Size = New System.Drawing.Size(100, 20)
        Me.txtWholesalePrice.TabIndex = 5
        '
        'txtMarkPercentage
        '
        Me.txtMarkPercentage.Location = New System.Drawing.Point(122, 129)
        Me.txtMarkPercentage.Name = "txtMarkPercentage"
        Me.txtMarkPercentage.Size = New System.Drawing.Size(100, 20)
        Me.txtMarkPercentage.TabIndex = 6
        '
        'lblRetailPrice
        '
        Me.lblRetailPrice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRetailPrice.Location = New System.Drawing.Point(108, 210)
        Me.lblRetailPrice.Name = "lblRetailPrice"
        Me.lblRetailPrice.Size = New System.Drawing.Size(114, 23)
        Me.lblRetailPrice.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 334)
        Me.Controls.Add(Me.lblRetailPrice)
        Me.Controls.Add(Me.txtMarkPercentage)
        Me.Controls.Add(Me.txtWholesalePrice)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnRetailPrice)
        Me.Controls.Add(Me.exitBtn)
        Me.Name = "Form1"
        Me.Text = "Retail Price Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents exitBtn As Button
    Friend WithEvents btnRetailPrice As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtWholesalePrice As TextBox
    Friend WithEvents txtMarkPercentage As TextBox
    Friend WithEvents lblRetailPrice As Label
End Class
