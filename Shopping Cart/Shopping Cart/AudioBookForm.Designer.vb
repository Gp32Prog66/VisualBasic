<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AudioBookForm
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
        Me.lstAudio = New System.Windows.Forms.ListBox()
        Me.btnAddToCart = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lstAudio)
        Me.GroupBox1.Location = New System.Drawing.Point(98, 104)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(268, 160)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Choose An Audio Book"
        '
        'lstAudio
        '
        Me.lstAudio.FormattingEnabled = True
        Me.lstAudio.Location = New System.Drawing.Point(6, 19)
        Me.lstAudio.Name = "lstAudio"
        Me.lstAudio.Size = New System.Drawing.Size(237, 121)
        Me.lstAudio.TabIndex = 0
        '
        'btnAddToCart
        '
        Me.btnAddToCart.Location = New System.Drawing.Point(12, 374)
        Me.btnAddToCart.Name = "btnAddToCart"
        Me.btnAddToCart.Size = New System.Drawing.Size(102, 23)
        Me.btnAddToCart.TabIndex = 1
        Me.btnAddToCart.Text = "Add Book to Cart"
        Me.btnAddToCart.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(391, 374)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'AudioBookForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 404)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddToCart)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "AudioBookForm"
        Me.Text = "Audio Books"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnAddToCart As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents lstAudio As ListBox
End Class
