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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RColor = New System.Windows.Forms.NumericUpDown()
        Me.GColor = New System.Windows.Forms.NumericUpDown()
        Me.BColor = New System.Windows.Forms.NumericUpDown()
        Me.Rtext = New System.Windows.Forms.Label()
        Me.Btext = New System.Windows.Forms.Label()
        Me.Gtext = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GColor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(181, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(401, 362)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(163, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "open image"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 44)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 20)
        Me.TextBox1.TabIndex = 2
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 70)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(163, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "copy code"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RColor
        '
        Me.RColor.Location = New System.Drawing.Point(30, 99)
        Me.RColor.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.RColor.Name = "RColor"
        Me.RColor.Size = New System.Drawing.Size(120, 20)
        Me.RColor.TabIndex = 4
        '
        'GColor
        '
        Me.GColor.Location = New System.Drawing.Point(30, 125)
        Me.GColor.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.GColor.Name = "GColor"
        Me.GColor.Size = New System.Drawing.Size(120, 20)
        Me.GColor.TabIndex = 4
        '
        'BColor
        '
        Me.BColor.Location = New System.Drawing.Point(29, 149)
        Me.BColor.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.BColor.Name = "BColor"
        Me.BColor.Size = New System.Drawing.Size(120, 20)
        Me.BColor.TabIndex = 4
        '
        'Rtext
        '
        Me.Rtext.AutoSize = True
        Me.Rtext.Location = New System.Drawing.Point(9, 101)
        Me.Rtext.Name = "Rtext"
        Me.Rtext.Size = New System.Drawing.Size(15, 13)
        Me.Rtext.TabIndex = 5
        Me.Rtext.Text = "R"
        '
        'Btext
        '
        Me.Btext.AutoSize = True
        Me.Btext.Location = New System.Drawing.Point(9, 151)
        Me.Btext.Name = "Btext"
        Me.Btext.Size = New System.Drawing.Size(14, 13)
        Me.Btext.TabIndex = 5
        Me.Btext.Text = "B"
        '
        'Gtext
        '
        Me.Gtext.AutoSize = True
        Me.Gtext.Location = New System.Drawing.Point(9, 127)
        Me.Gtext.Name = "Gtext"
        Me.Gtext.Size = New System.Drawing.Size(15, 13)
        Me.Gtext.TabIndex = 5
        Me.Gtext.Text = "G"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 385)
        Me.Controls.Add(Me.Gtext)
        Me.Controls.Add(Me.Btext)
        Me.Controls.Add(Me.Rtext)
        Me.Controls.Add(Me.BColor)
        Me.Controls.Add(Me.GColor)
        Me.Controls.Add(Me.RColor)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GColor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RColor As System.Windows.Forms.NumericUpDown
    Friend WithEvents GColor As System.Windows.Forms.NumericUpDown
    Friend WithEvents BColor As System.Windows.Forms.NumericUpDown
    Friend WithEvents Rtext As System.Windows.Forms.Label
    Friend WithEvents Btext As System.Windows.Forms.Label
    Friend WithEvents Gtext As System.Windows.Forms.Label

End Class
