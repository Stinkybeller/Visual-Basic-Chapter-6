<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHomePayment
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
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.lblAcceptanceStat = New System.Windows.Forms.Label()
        Me.lstYearAmt = New System.Windows.Forms.ListBox()
        Me.txtFinalAmt = New System.Windows.Forms.TextBox()
        Me.txtYears = New System.Windows.Forms.TextBox()
        Me.txtRate = New System.Windows.Forms.TextBox()
        Me.txtStartingAmt = New System.Windows.Forms.TextBox()
        Me.lblYears = New System.Windows.Forms.Label()
        Me.lblFinalAmt = New System.Windows.Forms.Label()
        Me.lblRate = New System.Windows.Forms.Label()
        Me.lblStartingAmt = New System.Windows.Forms.Label()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.mnuHomeDownPayment = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHomeDownPayment.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(411, 344)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(120, 38)
        Me.btnCalculate.TabIndex = 55
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'lblInstructions
        '
        Me.lblInstructions.AutoSize = True
        Me.lblInstructions.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(270, 92)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(324, 26)
        Me.lblInstructions.TabIndex = 54
        Me.lblInstructions.Text = "Enter a value for each of the following"
        '
        'lblAcceptanceStat
        '
        Me.lblAcceptanceStat.AutoSize = True
        Me.lblAcceptanceStat.Font = New System.Drawing.Font("Palatino Linotype", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAcceptanceStat.Location = New System.Drawing.Point(128, 396)
        Me.lblAcceptanceStat.Name = "lblAcceptanceStat"
        Me.lblAcceptanceStat.Size = New System.Drawing.Size(405, 44)
        Me.lblAcceptanceStat.TabIndex = 53
        Me.lblAcceptanceStat.Text = "You have not saved enough"
        '
        'lstYearAmt
        '
        Me.lstYearAmt.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstYearAmt.FormattingEnabled = True
        Me.lstYearAmt.ItemHeight = 26
        Me.lstYearAmt.Location = New System.Drawing.Point(30, 81)
        Me.lstYearAmt.Name = "lstYearAmt"
        Me.lstYearAmt.Size = New System.Drawing.Size(195, 290)
        Me.lstYearAmt.TabIndex = 52
        '
        'txtFinalAmt
        '
        Me.txtFinalAmt.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFinalAmt.Location = New System.Drawing.Point(431, 281)
        Me.txtFinalAmt.Name = "txtFinalAmt"
        Me.txtFinalAmt.Size = New System.Drawing.Size(100, 36)
        Me.txtFinalAmt.TabIndex = 51
        '
        'txtYears
        '
        Me.txtYears.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYears.Location = New System.Drawing.Point(431, 236)
        Me.txtYears.Name = "txtYears"
        Me.txtYears.Size = New System.Drawing.Size(100, 36)
        Me.txtYears.TabIndex = 50
        '
        'txtRate
        '
        Me.txtRate.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRate.Location = New System.Drawing.Point(431, 191)
        Me.txtRate.Name = "txtRate"
        Me.txtRate.Size = New System.Drawing.Size(100, 36)
        Me.txtRate.TabIndex = 49
        '
        'txtStartingAmt
        '
        Me.txtStartingAmt.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStartingAmt.Location = New System.Drawing.Point(431, 146)
        Me.txtStartingAmt.Name = "txtStartingAmt"
        Me.txtStartingAmt.Size = New System.Drawing.Size(100, 36)
        Me.txtStartingAmt.TabIndex = 48
        '
        'lblYears
        '
        Me.lblYears.AutoSize = True
        Me.lblYears.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYears.Location = New System.Drawing.Point(362, 239)
        Me.lblYears.Name = "lblYears"
        Me.lblYears.Size = New System.Drawing.Size(63, 28)
        Me.lblYears.TabIndex = 47
        Me.lblYears.Text = "Years"
        '
        'lblFinalAmt
        '
        Me.lblFinalAmt.AutoSize = True
        Me.lblFinalAmt.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFinalAmt.Location = New System.Drawing.Point(261, 284)
        Me.lblFinalAmt.Name = "lblFinalAmt"
        Me.lblFinalAmt.Size = New System.Drawing.Size(164, 28)
        Me.lblFinalAmt.TabIndex = 46
        Me.lblFinalAmt.Text = "Down Payment"
        '
        'lblRate
        '
        Me.lblRate.AutoSize = True
        Me.lblRate.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRate.Location = New System.Drawing.Point(369, 194)
        Me.lblRate.Name = "lblRate"
        Me.lblRate.Size = New System.Drawing.Size(56, 28)
        Me.lblRate.TabIndex = 45
        Me.lblRate.Text = "Rate"
        '
        'lblStartingAmt
        '
        Me.lblStartingAmt.AutoSize = True
        Me.lblStartingAmt.Font = New System.Drawing.Font("Palatino Linotype", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStartingAmt.Location = New System.Drawing.Point(248, 149)
        Me.lblStartingAmt.Name = "lblStartingAmt"
        Me.lblStartingAmt.Size = New System.Drawing.Size(177, 28)
        Me.lblStartingAmt.TabIndex = 44
        Me.lblStartingAmt.Text = "Starting Amount"
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.Font = New System.Drawing.Font("Palatino Linotype", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(249, 45)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(372, 47)
        Me.lblHeader.TabIndex = 43
        Me.lblHeader.Text = "Home Down Payment"
        '
        'mnuHomeDownPayment
        '
        Me.mnuHomeDownPayment.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuHomeDownPayment.Location = New System.Drawing.Point(0, 0)
        Me.mnuHomeDownPayment.Name = "mnuHomeDownPayment"
        Me.mnuHomeDownPayment.Size = New System.Drawing.Size(660, 24)
        Me.mnuHomeDownPayment.TabIndex = 42
        Me.mnuHomeDownPayment.Text = "MenuStrip1"
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
        'frmHomePayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(660, 466)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.lblAcceptanceStat)
        Me.Controls.Add(Me.lstYearAmt)
        Me.Controls.Add(Me.txtFinalAmt)
        Me.Controls.Add(Me.txtYears)
        Me.Controls.Add(Me.txtRate)
        Me.Controls.Add(Me.txtStartingAmt)
        Me.Controls.Add(Me.lblYears)
        Me.Controls.Add(Me.lblFinalAmt)
        Me.Controls.Add(Me.lblRate)
        Me.Controls.Add(Me.lblStartingAmt)
        Me.Controls.Add(Me.lblHeader)
        Me.Controls.Add(Me.mnuHomeDownPayment)
        Me.Name = "frmHomePayment"
        Me.Text = "Home Down Payment"
        Me.mnuHomeDownPayment.ResumeLayout(False)
        Me.mnuHomeDownPayment.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblAcceptanceStat As Label
    Friend WithEvents lstYearAmt As ListBox
    Friend WithEvents txtFinalAmt As TextBox
    Friend WithEvents txtYears As TextBox
    Friend WithEvents txtRate As TextBox
    Friend WithEvents txtStartingAmt As TextBox
    Friend WithEvents lblYears As Label
    Friend WithEvents lblFinalAmt As Label
    Friend WithEvents lblRate As Label
    Friend WithEvents lblStartingAmt As Label
    Friend WithEvents lblHeader As Label
    Friend WithEvents mnuHomeDownPayment As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
