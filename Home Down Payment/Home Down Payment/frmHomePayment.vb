
'Program Name: Home Down Payment'
'Developer: Izabella Fortunata'
'Date: 02/9/24'
'Purpose: Program decides whether or not a user saved enough money for a new home based on their values'

Public Class frmHomePayment
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Declare variables'
        Dim decStartingAmount As Decimal
        Dim decRate As Decimal
        Dim intYears As Integer
        Dim decDownPayment As Decimal
        Dim decYearlyPayment As Decimal
        Dim decYearsListed As Decimal = 0

        'Are all values numeric?'
        If Decimal.TryParse(txtStartingAmt.Text, decStartingAmount) Then
            If Decimal.TryParse(txtRate.Text, decRate) Then
                If Integer.TryParse(txtYears.Text, intYears) Then
                    If Decimal.TryParse(txtFinalAmt.Text, decDownPayment) Then

                        'Is dec rate positive and less than 101?'
                        If 0 < decRate Then
                            'Is starting amount positive?'
                            If 0 < decStartingAmount Then
                                'Is years positive?'
                                If 0 < intYears Then

                                    'Is down payment positive?'
                                    If 0 < decDownPayment Then
                                        'Divide the rate by 100'
                                        decRate = decRate / 100
                                        For intYears 
                                            'Calculations'
                                            decYearlyPayment = decStartingAmount * (1 + decRate)
                                            decStartingAmount = decYearlyPayment
                                            decYearsListed = decYearsListed + 1
                                            lstYearAmt.Items.Add("Year " + decYearsListed.ToString() + " : " + decYearlyPayment.ToString("C"))
                                        Next
                                        'Change labels based on whether or not the starting amount is more than or equal to the down payment'
                                        If decStartingAmount >= decDownPayment Then
                                            lblAcceptanceStat.Text = "You have saved enough"
                                        Else
                                            lblAcceptanceStat.Text = "You have not saved enough"
                                        End If
                                    Else
                                        'Display a message box that tells the user what to change and clear out corresponding textbox'
                                        MsgBox("Enter a positive value for down payment")
                                        txtFinalAmt.Clear()
                                    End If
                                Else
                                    'Display a message box that tells the user what to change and clear out corresponding textbox'
                                    MsgBox("Enter a positive value for the amount of years")
                                    txtYears.Clear()
                                End If
                            Else
                                'Display a message box that tells the user what to change and clear out corresponding textbox'
                                MsgBox("Enter a positive value for the starting amount ")
                                txtStartingAmt.Clear()
                            End If
                        Else
                            'Display a message box that tells the user what to change and clear out corresponding textbox'
                            MsgBox("Enter a positive value for the rate")
                            txtRate.Clear()
                        End If
                    Else
                        'Display a message box that tells the user what to change and clear out corresponding textbox'
                        MsgBox("Enter a numerical value for the final amount")
                        txtFinalAmt.Clear()
                    End If
                Else
                    'Display a message box that tells the user what to change and clear out corresponding textbox'
                    MsgBox("Enter a numerical whole value for the amount of years")
                    txtYears.Clear()
                End If
            Else
                'Display a message box that tells the user what to change and clear out corresponding textbox'
                MsgBox("Enter a numerical value for the rate")
                txtRate.Clear()
            End If
        Else
            'Display a message box that tells the user what to change and clear out corresponding textbox'
            MsgBox("Enter a numerical value for the starting amount")
            txtStartingAmt.Clear()
        End If
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear all values from textboxes and the listbox'
        txtStartingAmt.Clear()
        txtRate.Clear()
        txtYears.Clear()
        txtFinalAmt.Clear()
        lstYearAmt.Items.Clear()
        btnCalculate.Enabled = True
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes program 
        Close()
    End Sub
    Private Sub frmHomePayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
