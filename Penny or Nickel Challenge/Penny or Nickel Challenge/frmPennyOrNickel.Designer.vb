<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPennyOrNickel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lstPayAmount = New System.Windows.Forms.ListBox()
        Me.lblTotalPay = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.grpBox = New System.Windows.Forms.GroupBox()
        Me.radNickel = New System.Windows.Forms.RadioButton()
        Me.radPenny = New System.Windows.Forms.RadioButton()
        Me.txtDaysWorked = New System.Windows.Forms.TextBox()
        Me.lblDaysWorked = New System.Windows.Forms.Label()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lblCalculatedPay = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.grpBox.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lstPayAmount
        '
        Me.lstPayAmount.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstPayAmount.FormattingEnabled = True
        Me.lstPayAmount.ItemHeight = 16
        Me.lstPayAmount.Location = New System.Drawing.Point(268, 97)
        Me.lstPayAmount.Name = "lstPayAmount"
        Me.lstPayAmount.Size = New System.Drawing.Size(212, 148)
        Me.lstPayAmount.TabIndex = 15
        '
        'lblTotalPay
        '
        Me.lblTotalPay.AutoSize = True
        Me.lblTotalPay.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPay.Location = New System.Drawing.Point(147, 419)
        Me.lblTotalPay.Name = "lblTotalPay"
        Me.lblTotalPay.Size = New System.Drawing.Size(0, 18)
        Me.lblTotalPay.TabIndex = 14
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(202, 278)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(101, 39)
        Me.btnCalculate.TabIndex = 13
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'grpBox
        '
        Me.grpBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.grpBox.Controls.Add(Me.radNickel)
        Me.grpBox.Controls.Add(Me.radPenny)
        Me.grpBox.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBox.Location = New System.Drawing.Point(38, 143)
        Me.grpBox.Name = "grpBox"
        Me.grpBox.Size = New System.Drawing.Size(215, 107)
        Me.grpBox.TabIndex = 12
        Me.grpBox.TabStop = False
        Me.grpBox.Text = "Pay Amount:"
        '
        'radNickel
        '
        Me.radNickel.AutoSize = True
        Me.radNickel.Location = New System.Drawing.Point(19, 72)
        Me.radNickel.Name = "radNickel"
        Me.radNickel.Size = New System.Drawing.Size(69, 23)
        Me.radNickel.TabIndex = 1
        Me.radNickel.TabStop = True
        Me.radNickel.Text = "Nickel"
        Me.radNickel.UseVisualStyleBackColor = True
        '
        'radPenny
        '
        Me.radPenny.AutoSize = True
        Me.radPenny.Location = New System.Drawing.Point(19, 29)
        Me.radPenny.Name = "radPenny"
        Me.radPenny.Size = New System.Drawing.Size(70, 23)
        Me.radPenny.TabIndex = 0
        Me.radPenny.TabStop = True
        Me.radPenny.Text = "Penny"
        Me.radPenny.UseVisualStyleBackColor = True
        '
        'txtDaysWorked
        '
        Me.txtDaysWorked.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDaysWorked.Location = New System.Drawing.Point(153, 97)
        Me.txtDaysWorked.Name = "txtDaysWorked"
        Me.txtDaysWorked.Size = New System.Drawing.Size(100, 30)
        Me.txtDaysWorked.TabIndex = 11
        '
        'lblDaysWorked
        '
        Me.lblDaysWorked.AutoSize = True
        Me.lblDaysWorked.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDaysWorked.Location = New System.Drawing.Point(20, 97)
        Me.lblDaysWorked.Name = "lblDaysWorked"
        Me.lblDaysWorked.Size = New System.Drawing.Size(127, 23)
        Me.lblDaysWorked.TabIndex = 10
        Me.lblDaysWorked.Text = "Days Worked:"
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(71, 24)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(352, 58)
        Me.lblHeading.TabIndex = 9
        Me.lblHeading.Text = "Penny or Nickel"
        '
        'lblCalculatedPay
        '
        Me.lblCalculatedPay.AutoSize = True
        Me.lblCalculatedPay.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCalculatedPay.Location = New System.Drawing.Point(52, 337)
        Me.lblCalculatedPay.Name = "lblCalculatedPay"
        Me.lblCalculatedPay.Size = New System.Drawing.Size(321, 23)
        Me.lblCalculatedPay.TabIndex = 16
        Me.lblCalculatedPay.Text = "Your calculated pay for the period is:"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 17
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmPennyOrNickel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 405)
        Me.Controls.Add(Me.lblCalculatedPay)
        Me.Controls.Add(Me.lstPayAmount)
        Me.Controls.Add(Me.lblTotalPay)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.grpBox)
        Me.Controls.Add(Me.txtDaysWorked)
        Me.Controls.Add(Me.lblDaysWorked)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPennyOrNickel"
        Me.Text = "Penny or Nickel Challenge"
        Me.grpBox.ResumeLayout(False)
        Me.grpBox.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstPayAmount As ListBox
    Friend WithEvents lblTotalPay As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents grpBox As GroupBox
    Friend WithEvents radNickel As RadioButton
    Friend WithEvents radPenny As RadioButton
    Friend WithEvents txtDaysWorked As TextBox
    Friend WithEvents lblDaysWorked As Label
    Friend WithEvents lblHeading As Label
    Friend WithEvents lblCalculatedPay As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
