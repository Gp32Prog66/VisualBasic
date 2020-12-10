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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtDigitSeven = New System.Windows.Forms.TextBox()
        Me.txtDigitSix = New System.Windows.Forms.TextBox()
        Me.txtDigitFive = New System.Windows.Forms.TextBox()
        Me.txtDigitFour = New System.Windows.Forms.TextBox()
        Me.txtDigitThree = New System.Windows.Forms.TextBox()
        Me.txtDigitTwo = New System.Windows.Forms.TextBox()
        Me.txtDigitOne = New System.Windows.Forms.TextBox()
        Me.btnVerify = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtDigitSeven)
        Me.GroupBox1.Controls.Add(Me.txtDigitSix)
        Me.GroupBox1.Controls.Add(Me.txtDigitFive)
        Me.GroupBox1.Controls.Add(Me.txtDigitFour)
        Me.GroupBox1.Controls.Add(Me.txtDigitThree)
        Me.GroupBox1.Controls.Add(Me.txtDigitTwo)
        Me.GroupBox1.Controls.Add(Me.txtDigitOne)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(421, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Enter the Pin"
        '
        'txtDigitSeven
        '
        Me.txtDigitSeven.Location = New System.Drawing.Point(353, 47)
        Me.txtDigitSeven.Name = "txtDigitSeven"
        Me.txtDigitSeven.Size = New System.Drawing.Size(54, 20)
        Me.txtDigitSeven.TabIndex = 6
        '
        'txtDigitSix
        '
        Me.txtDigitSix.Location = New System.Drawing.Point(293, 47)
        Me.txtDigitSix.Name = "txtDigitSix"
        Me.txtDigitSix.Size = New System.Drawing.Size(54, 20)
        Me.txtDigitSix.TabIndex = 5
        '
        'txtDigitFive
        '
        Me.txtDigitFive.Location = New System.Drawing.Point(234, 47)
        Me.txtDigitFive.Name = "txtDigitFive"
        Me.txtDigitFive.Size = New System.Drawing.Size(54, 20)
        Me.txtDigitFive.TabIndex = 4
        '
        'txtDigitFour
        '
        Me.txtDigitFour.Location = New System.Drawing.Point(178, 47)
        Me.txtDigitFour.Name = "txtDigitFour"
        Me.txtDigitFour.Size = New System.Drawing.Size(50, 20)
        Me.txtDigitFour.TabIndex = 3
        '
        'txtDigitThree
        '
        Me.txtDigitThree.Location = New System.Drawing.Point(124, 47)
        Me.txtDigitThree.Name = "txtDigitThree"
        Me.txtDigitThree.Size = New System.Drawing.Size(48, 20)
        Me.txtDigitThree.TabIndex = 2
        '
        'txtDigitTwo
        '
        Me.txtDigitTwo.Location = New System.Drawing.Point(70, 47)
        Me.txtDigitTwo.Name = "txtDigitTwo"
        Me.txtDigitTwo.Size = New System.Drawing.Size(48, 20)
        Me.txtDigitTwo.TabIndex = 1
        '
        'txtDigitOne
        '
        Me.txtDigitOne.Location = New System.Drawing.Point(16, 47)
        Me.txtDigitOne.Name = "txtDigitOne"
        Me.txtDigitOne.Size = New System.Drawing.Size(48, 20)
        Me.txtDigitOne.TabIndex = 0
        '
        'btnVerify
        '
        Me.btnVerify.Location = New System.Drawing.Point(13, 134)
        Me.btnVerify.Name = "btnVerify"
        Me.btnVerify.Size = New System.Drawing.Size(75, 23)
        Me.btnVerify.TabIndex = 1
        Me.btnVerify.Text = "Verify"
        Me.btnVerify.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(196, 134)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 2
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(369, 134)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 3
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 169)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnVerify)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "PIN Verifier"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtDigitSeven As TextBox
    Friend WithEvents txtDigitSix As TextBox
    Friend WithEvents txtDigitFive As TextBox
    Friend WithEvents txtDigitFour As TextBox
    Friend WithEvents txtDigitThree As TextBox
    Friend WithEvents txtDigitTwo As TextBox
    Friend WithEvents txtDigitOne As TextBox
    Friend WithEvents btnVerify As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
