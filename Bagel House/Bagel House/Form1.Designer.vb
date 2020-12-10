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
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.radWholeWheat = New System.Windows.Forms.RadioButton()
        Me.radPlain = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radCafeAuLait = New System.Windows.Forms.RadioButton()
        Me.radCappuccino = New System.Windows.Forms.RadioButton()
        Me.radStandardCoffee = New System.Windows.Forms.RadioButton()
        Me.radNoCoffee = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblTax = New System.Windows.Forms.Label()
        Me.lblSubTotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.chkPeach = New System.Windows.Forms.CheckBox()
        Me.chkRaspberry = New System.Windows.Forms.CheckBox()
        Me.chkBlueBerry = New System.Windows.Forms.CheckBox()
        Me.chkButter = New System.Windows.Forms.CheckBox()
        Me.chkCreamCheese = New System.Windows.Forms.CheckBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(32, 415)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(263, 415)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 1
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(508, 415)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 2
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.radWholeWheat)
        Me.GroupBox1.Controls.Add(Me.radPlain)
        Me.GroupBox1.Location = New System.Drawing.Point(48, 39)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 73)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Bagel Options"
        '
        'radWholeWheat
        '
        Me.radWholeWheat.AutoSize = True
        Me.radWholeWheat.Location = New System.Drawing.Point(6, 43)
        Me.radWholeWheat.Name = "radWholeWheat"
        Me.radWholeWheat.Size = New System.Drawing.Size(91, 17)
        Me.radWholeWheat.TabIndex = 1
        Me.radWholeWheat.TabStop = True
        Me.radWholeWheat.Text = "Whole Wheat"
        Me.radWholeWheat.UseVisualStyleBackColor = True
        '
        'radPlain
        '
        Me.radPlain.AutoSize = True
        Me.radPlain.Location = New System.Drawing.Point(7, 20)
        Me.radPlain.Name = "radPlain"
        Me.radPlain.Size = New System.Drawing.Size(48, 17)
        Me.radPlain.TabIndex = 0
        Me.radPlain.TabStop = True
        Me.radPlain.Text = "Plain"
        Me.radPlain.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.radCafeAuLait)
        Me.GroupBox2.Controls.Add(Me.radCappuccino)
        Me.GroupBox2.Controls.Add(Me.radStandardCoffee)
        Me.GroupBox2.Controls.Add(Me.radNoCoffee)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 39)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 116)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Coffee"
        '
        'radCafeAuLait
        '
        Me.radCafeAuLait.AutoSize = True
        Me.radCafeAuLait.Location = New System.Drawing.Point(7, 94)
        Me.radCafeAuLait.Name = "radCafeAuLait"
        Me.radCafeAuLait.Size = New System.Drawing.Size(78, 17)
        Me.radCafeAuLait.TabIndex = 3
        Me.radCafeAuLait.TabStop = True
        Me.radCafeAuLait.Text = "Cafe au lait"
        Me.radCafeAuLait.UseVisualStyleBackColor = True
        '
        'radCappuccino
        '
        Me.radCappuccino.AutoSize = True
        Me.radCappuccino.Location = New System.Drawing.Point(7, 70)
        Me.radCappuccino.Name = "radCappuccino"
        Me.radCappuccino.Size = New System.Drawing.Size(82, 17)
        Me.radCappuccino.TabIndex = 2
        Me.radCappuccino.TabStop = True
        Me.radCappuccino.Text = "Cappuccino"
        Me.radCappuccino.UseVisualStyleBackColor = True
        '
        'radStandardCoffee
        '
        Me.radStandardCoffee.AutoSize = True
        Me.radStandardCoffee.Location = New System.Drawing.Point(7, 46)
        Me.radStandardCoffee.Name = "radStandardCoffee"
        Me.radStandardCoffee.Size = New System.Drawing.Size(102, 17)
        Me.radStandardCoffee.TabIndex = 1
        Me.radStandardCoffee.TabStop = True
        Me.radStandardCoffee.Text = "Standard Coffee"
        Me.radStandardCoffee.UseVisualStyleBackColor = True
        '
        'radNoCoffee
        '
        Me.radNoCoffee.AutoSize = True
        Me.radNoCoffee.Location = New System.Drawing.Point(7, 22)
        Me.radNoCoffee.Name = "radNoCoffee"
        Me.radNoCoffee.Size = New System.Drawing.Size(73, 17)
        Me.radNoCoffee.TabIndex = 0
        Me.radNoCoffee.TabStop = True
        Me.radNoCoffee.Text = "No Coffee"
        Me.radNoCoffee.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.lblTotal)
        Me.GroupBox3.Controls.Add(Me.lblTax)
        Me.GroupBox3.Controls.Add(Me.lblSubTotal)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(328, 212)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 5
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Total Price"
        '
        'lblTotal
        '
        Me.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTotal.Location = New System.Drawing.Point(82, 74)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblTotal.TabIndex = 5
        '
        'lblTax
        '
        Me.lblTax.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblTax.Location = New System.Drawing.Point(82, 49)
        Me.lblTax.Name = "lblTax"
        Me.lblTax.Size = New System.Drawing.Size(100, 23)
        Me.lblTax.TabIndex = 4
        '
        'lblSubTotal
        '
        Me.lblSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSubTotal.Location = New System.Drawing.Point(82, 16)
        Me.lblSubTotal.Name = "lblSubTotal"
        Me.lblSubTotal.Size = New System.Drawing.Size(100, 23)
        Me.lblSubTotal.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tax"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Subtotal"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.chkPeach)
        Me.GroupBox4.Controls.Add(Me.chkRaspberry)
        Me.GroupBox4.Controls.Add(Me.chkBlueBerry)
        Me.GroupBox4.Controls.Add(Me.chkButter)
        Me.GroupBox4.Controls.Add(Me.chkCreamCheese)
        Me.GroupBox4.Location = New System.Drawing.Point(42, 171)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(200, 141)
        Me.GroupBox4.TabIndex = 6
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Choice of Toppings"
        '
        'chkPeach
        '
        Me.chkPeach.AutoSize = True
        Me.chkPeach.Location = New System.Drawing.Point(6, 88)
        Me.chkPeach.Name = "chkPeach"
        Me.chkPeach.Size = New System.Drawing.Size(80, 17)
        Me.chkPeach.TabIndex = 4
        Me.chkPeach.Text = "Peach Jelly"
        Me.chkPeach.UseVisualStyleBackColor = True
        '
        'chkRaspberry
        '
        Me.chkRaspberry.AutoSize = True
        Me.chkRaspberry.Location = New System.Drawing.Point(6, 111)
        Me.chkRaspberry.Name = "chkRaspberry"
        Me.chkRaspberry.Size = New System.Drawing.Size(96, 17)
        Me.chkRaspberry.TabIndex = 3
        Me.chkRaspberry.Text = "Raspberry Jam"
        Me.chkRaspberry.UseVisualStyleBackColor = True
        '
        'chkBlueBerry
        '
        Me.chkBlueBerry.AutoSize = True
        Me.chkBlueBerry.Location = New System.Drawing.Point(6, 19)
        Me.chkBlueBerry.Name = "chkBlueBerry"
        Me.chkBlueBerry.Size = New System.Drawing.Size(93, 17)
        Me.chkBlueBerry.TabIndex = 2
        Me.chkBlueBerry.Text = "BlueBerry Jam"
        Me.chkBlueBerry.UseVisualStyleBackColor = True
        '
        'chkButter
        '
        Me.chkButter.AutoSize = True
        Me.chkButter.Location = New System.Drawing.Point(6, 42)
        Me.chkButter.Name = "chkButter"
        Me.chkButter.Size = New System.Drawing.Size(54, 17)
        Me.chkButter.TabIndex = 1
        Me.chkButter.Text = "Butter"
        Me.chkButter.UseVisualStyleBackColor = True
        '
        'chkCreamCheese
        '
        Me.chkCreamCheese.AutoSize = True
        Me.chkCreamCheese.Location = New System.Drawing.Point(6, 65)
        Me.chkCreamCheese.Name = "chkCreamCheese"
        Me.chkCreamCheese.Size = New System.Drawing.Size(95, 17)
        Me.chkCreamCheese.TabIndex = 0
        Me.chkCreamCheese.Text = "Cream Cheese"
        Me.chkCreamCheese.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(606, 446)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Bagel and Coffee Price Calculator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents radWholeWheat As RadioButton
    Friend WithEvents radPlain As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radCafeAuLait As RadioButton
    Friend WithEvents radCappuccino As RadioButton
    Friend WithEvents radStandardCoffee As RadioButton
    Friend WithEvents radNoCoffee As RadioButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents chkPeach As CheckBox
    Friend WithEvents chkRaspberry As CheckBox
    Friend WithEvents chkBlueBerry As CheckBox
    Friend WithEvents chkButter As CheckBox
    Friend WithEvents chkCreamCheese As CheckBox
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblTax As Label
    Friend WithEvents lblSubTotal As Label
End Class
