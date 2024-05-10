<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInternetSpeedTest
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
        Me.btnEnterInternetSpeed = New System.Windows.Forms.Button()
        Me.lblAverageInternetSpeed = New System.Windows.Forms.Label()
        Me.lstInternetSpeed = New System.Windows.Forms.ListBox()
        Me.mnuInternet = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInternet.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(259, 48)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(401, 37)
        Me.lblHeading.TabIndex = 1
        Me.lblHeading.Text = "Internet Speed Test Survey"
        '
        'btnEnterInternetSpeed
        '
        Me.btnEnterInternetSpeed.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnEnterInternetSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterInternetSpeed.Location = New System.Drawing.Point(332, 102)
        Me.btnEnterInternetSpeed.Name = "btnEnterInternetSpeed"
        Me.btnEnterInternetSpeed.Size = New System.Drawing.Size(142, 44)
        Me.btnEnterInternetSpeed.TabIndex = 2
        Me.btnEnterInternetSpeed.Text = "Enter Internet Speed"
        Me.btnEnterInternetSpeed.UseVisualStyleBackColor = True
        '
        'lblAverageInternetSpeed
        '
        Me.lblAverageInternetSpeed.AutoSize = True
        Me.lblAverageInternetSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageInternetSpeed.Location = New System.Drawing.Point(383, 459)
        Me.lblAverageInternetSpeed.Name = "lblAverageInternetSpeed"
        Me.lblAverageInternetSpeed.Size = New System.Drawing.Size(332, 24)
        Me.lblAverageInternetSpeed.TabIndex = 3
        Me.lblAverageInternetSpeed.Text = "Average Internet Speed: XX.XX Mbps"
        '
        'lstInternetSpeed
        '
        Me.lstInternetSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstInternetSpeed.FormattingEnabled = True
        Me.lstInternetSpeed.ItemHeight = 15
        Me.lstInternetSpeed.Location = New System.Drawing.Point(566, 102)
        Me.lstInternetSpeed.Name = "lstInternetSpeed"
        Me.lstInternetSpeed.Size = New System.Drawing.Size(70, 169)
        Me.lstInternetSpeed.TabIndex = 4
        '
        'mnuInternet
        '
        Me.mnuInternet.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.mnuInternet.Location = New System.Drawing.Point(0, 0)
        Me.mnuInternet.Name = "mnuInternet"
        Me.mnuInternet.Size = New System.Drawing.Size(745, 24)
        Me.mnuInternet.TabIndex = 5
        Me.mnuInternet.Text = "MenuStrip1"
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
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'frmInternetSpeedTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Internet_Speed_Test.My.Resources.Resources.speed
        Me.ClientSize = New System.Drawing.Size(745, 510)
        Me.Controls.Add(Me.lstInternetSpeed)
        Me.Controls.Add(Me.lblAverageInternetSpeed)
        Me.Controls.Add(Me.btnEnterInternetSpeed)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.mnuInternet)
        Me.MainMenuStrip = Me.mnuInternet
        Me.Name = "frmInternetSpeedTest"
        Me.Text = "Internet Speed Test"
        Me.mnuInternet.ResumeLayout(False)
        Me.mnuInternet.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picComputer As PictureBox
    Friend WithEvents lblHeading As Label
    Friend WithEvents btnEnterInternetSpeed As Button
    Friend WithEvents lblAverageInternetSpeed As Label
    Friend WithEvents lstInternetSpeed As ListBox
    Friend WithEvents mnuInternet As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClearToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
End Class
