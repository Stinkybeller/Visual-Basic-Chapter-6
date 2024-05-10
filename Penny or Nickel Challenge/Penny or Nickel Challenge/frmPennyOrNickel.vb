'Program: Penny Or Nickel Challenge'
'Developer: Izabella Fortunata'
'Date: 2/12/24'
'Purpose: Finds out the monthly pay if you are paid a penny or nickle for the first workday. The pay is doubled each subsequent workday.'
Public Class frmPennyOrNickel
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables'
        Dim intDaysWorked As Integer
        Dim intNumOfEntries As Integer = 1
        Dim decTotal As Decimal = 0

        'Is user's input numeric?'
        If Integer.TryParse(txtDaysWorked.Text, intDaysWorked) Then
            intDaysWorked = Convert.ToDecimal(txtDaysWorked.Text)
            'How many days has the user worked?'
            If intDaysWorked > 9 And intDaysWorked < 23 Then
                'Penny or nickel checked?'
                If radPenny.Checked = True Then
                    decTotal = 0.01

                    For intNumOfEntries = 1 To intDaysWorked
                        lstPayAmount.Items.Add("Day " + intNumOfEntries.ToString() + ": " + decTotal.ToString())
                        decTotal = decTotal * 2
                    Next
                ElseIf radNickel.Checked Then
                    decTotal = 0.05
                    For intNumOfEntries = 1 To intDaysWorked
                        lstPayAmount.Items.Add("Day " + intNumOfEntries.ToString() + ": " + decTotal.ToString())
                        decTotal = decTotal * 2
                    Next
                Else
                    'Display a message box telling the user to select a radio button'
                    MsgBox("Select either penny or nickel")
                End If
            Else
                'A message box displays, telling the user to enter a positive number'
                MsgBox("Enter a positive value more between 10 and 22")
            End If
        Else
            'A message box displays, telling the user to enter a numeric value'
            MsgBox("Please enter a numeric value")
        End If

        'Display final calculations'
        lblCalculatedPay.Visible = True
        lblCalculatedPay.Text = "Your calculated pay for the period is: " + decTotal.ToString("C")
        btnCalculate.Enabled = False
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear all values'
        txtDaysWorked.Text = ""
        lstPayAmount.Items.Clear()
        lblCalculatedPay.Visible = False
        radPenny.Checked = False
        radNickel.Checked = False
        btnCalculate.Enabled = True
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the program'
        Close()
    End Sub
End Class
