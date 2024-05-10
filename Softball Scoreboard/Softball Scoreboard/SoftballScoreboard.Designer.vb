<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSoftballScoreboard
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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.lstScoreboard = New System.Windows.Forms.ListBox()
        Me.btnEnterScore = New System.Windows.Forms.Button()
        Me.lblTotalScore = New System.Windows.Forms.Label()
        Me.mnuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.ForeColor = System.Drawing.Color.White
        Me.lblHeading.Location = New System.Drawing.Point(197, 38)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(306, 39)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Softball Scoreboard"
        '
        'lstScoreboard
        '
        Me.lstScoreboard.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstScoreboard.FormattingEnabled = True
        Me.lstScoreboard.ItemHeight = 19
        Me.lstScoreboard.Location = New System.Drawing.Point(88, 108)
        Me.lstScoreboard.Name = "lstScoreboard"
        Me.lstScoreboard.Size = New System.Drawing.Size(525, 213)
        Me.lstScoreboard.TabIndex = 1
        '
        'btnEnterScore
        '
        Me.btnEnterScore.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterScore.Location = New System.Drawing.Point(295, 360)
        Me.btnEnterScore.Name = "btnEnterScore"
        Me.btnEnterScore.Size = New System.Drawing.Size(108, 47)
        Me.btnEnterScore.TabIndex = 2
        Me.btnEnterScore.Text = "Enter Score"
        Me.btnEnterScore.UseVisualStyleBackColor = True
        '
        'lblTotalScore
        '
        Me.lblTotalScore.AutoSize = True
        Me.lblTotalScore.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalScore.Font = New System.Drawing.Font("Microsoft YaHei", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalScore.ForeColor = System.Drawing.Color.White
        Me.lblTotalScore.Location = New System.Drawing.Point(204, 433)
        Me.lblTotalScore.Name = "lblTotalScore"
        Me.lblTotalScore.Size = New System.Drawing.Size(272, 39)
        Me.lblTotalScore.TabIndex = 4
        Me.lblTotalScore.Text = "The final score is:"
        '
        'mnuStrip
        '
        Me.mnuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuStrip.Location = New System.Drawing.Point(0, 0)
        Me.mnuStrip.Name = "mnuStrip"
        Me.mnuStrip.Size = New System.Drawing.Size(701, 24)
        Me.mnuStrip.TabIndex = 5
        Me.mnuStrip.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(101, 22)
        Me.ExitToolStripMenuItem1.Text = "Exit"
        '
        'frmSoftballScoreboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Softball_Scoreboard.My.Resources.Resources._360_F_496057196_Thw7Cf5gA5o3bjYkEYe9rMBJ8Dx56fpp1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(701, 497)
        Me.Controls.Add(Me.lblTotalScore)
        Me.Controls.Add(Me.btnEnterScore)
        Me.Controls.Add(Me.lstScoreboard)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.mnuStrip)
        Me.MainMenuStrip = Me.mnuStrip
        Me.Name = "frmSoftballScoreboard"
        Me.Text = "Softball Scoreboard"
        Me.mnuStrip.ResumeLayout(False)
        Me.mnuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lstScoreboard As ListBox
    Friend WithEvents btnEnterScore As Button
    Friend WithEvents lblTotalScore As Label
    Friend WithEvents mnuStrip As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem1 As ToolStripMenuItem
End Class
