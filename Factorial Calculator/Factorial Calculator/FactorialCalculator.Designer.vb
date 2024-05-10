<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFactorialCalculator
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
        Me.lstFactorial = New System.Windows.Forms.ListBox()
        Me.lblHeading2 = New System.Windows.Forms.Label()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.mnuFactorialCalc = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFactorialCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("MS Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.MidnightBlue
        Me.btnCalculate.Location = New System.Drawing.Point(278, 353)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(133, 35)
        Me.btnCalculate.TabIndex = 16
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lstFactorial
        '
        Me.lstFactorial.Font = New System.Drawing.Font("MS Gothic", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstFactorial.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lstFactorial.FormattingEnabled = True
        Me.lstFactorial.ItemHeight = 24
        Me.lstFactorial.Location = New System.Drawing.Point(29, 216)
        Me.lstFactorial.Name = "lstFactorial"
        Me.lstFactorial.Size = New System.Drawing.Size(212, 172)
        Me.lstFactorial.TabIndex = 15
        '
        'lblHeading2
        '
        Me.lblHeading2.AutoSize = True
        Me.lblHeading2.BackColor = System.Drawing.Color.SkyBlue
        Me.lblHeading2.Font = New System.Drawing.Font("MS Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading2.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblHeading2.Location = New System.Drawing.Point(10, 125)
        Me.lblHeading2.Name = "lblHeading2"
        Me.lblHeading2.Size = New System.Drawing.Size(457, 33)
        Me.lblHeading2.TabIndex = 13
        Me.lblHeading2.Text = "Enter a number from 1 - 12"
        '
        'txtNumber
        '
        Me.txtNumber.Font = New System.Drawing.Font("MS Gothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumber.Location = New System.Drawing.Point(302, 302)
        Me.txtNumber.MaxLength = 2
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(85, 39)
        Me.txtNumber.TabIndex = 12
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.Color.SkyBlue
        Me.lblHeader.Font = New System.Drawing.Font("MS Gothic", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.MidnightBlue
        Me.lblHeader.Location = New System.Drawing.Point(30, 67)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(417, 37)
        Me.lblHeader.TabIndex = 11
        Me.lblHeader.Text = "Factorial Calculator"
        '
        'mnuFactorialCalc
        '
        Me.mnuFactorialCalc.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuFactorialCalc.Location = New System.Drawing.Point(0, 0)
        Me.mnuFactorialCalc.Name = "mnuFactorialCalc"
        Me.mnuFactorialCalc.Size = New System.Drawing.Size(477, 24)
        Me.mnuFactorialCalc.TabIndex = 14
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "&Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        '
        'frmFactorialCalculator
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Factorial_Calculator.My.Resources.Resources.Screenshot_2024_02_09_080637
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(477, 461)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lstFactorial)
        Me.Controls.Add(Me.lblHeading2)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.mnuFactorialCalc)
        Me.DoubleBuffered = True
        Me.Name = "frmFactorialCalculator"
        Me.Text = "Factorial Calculator"
        Me.mnuFactorialCalc.ResumeLayout(False)
        Me.mnuFactorialCalc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lstFactorial As ListBox
    Friend WithEvents lblHeading2 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblHeader As Label
    Friend WithEvents mnuFactorialCalc As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
