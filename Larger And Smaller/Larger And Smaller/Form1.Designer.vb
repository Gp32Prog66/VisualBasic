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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.compareBtn = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.txtBoxA = New System.Windows.Forms.TextBox()
        Me.txtBoxB = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft PhagsPa", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Type Two Integers"
        '
        'compareBtn
        '
        Me.compareBtn.Location = New System.Drawing.Point(63, 188)
        Me.compareBtn.Name = "compareBtn"
        Me.compareBtn.Size = New System.Drawing.Size(75, 23)
        Me.compareBtn.TabIndex = 1
        Me.compareBtn.Text = "Comparing"
        Me.compareBtn.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(220, 187)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblResult.Location = New System.Drawing.Point(113, 136)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(158, 20)
        Me.lblResult.TabIndex = 3
        '
        'txtBoxA
        '
        Me.txtBoxA.Location = New System.Drawing.Point(63, 85)
        Me.txtBoxA.Name = "txtBoxA"
        Me.txtBoxA.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxA.TabIndex = 4
        '
        'txtBoxB
        '
        Me.txtBoxB.Location = New System.Drawing.Point(241, 84)
        Me.txtBoxB.Name = "txtBoxB"
        Me.txtBoxB.Size = New System.Drawing.Size(100, 20)
        Me.txtBoxB.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 78)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 27)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "A"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft PhagsPa", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(208, 80)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 27)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "B"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(355, 234)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtBoxB)
        Me.Controls.Add(Me.txtBoxA)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.compareBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Larger and Smaller"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents compareBtn As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblResult As Label
    Friend WithEvents txtBoxA As TextBox
    Friend WithEvents txtBoxB As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
