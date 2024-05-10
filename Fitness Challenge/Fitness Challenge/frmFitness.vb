'Program: Fitness Challenge'
'Developer: Izabella Fortunata'
'Date: 1/4/24'
'Purpose: Enters weight loss from the team members for a fitness challenge'
Public Class frmFitnessChallenge
    Private Sub frmFitnessChallenge_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnWeightLoss_Click(sender As Object, e As EventArgs) Handles btnWeightLoss.Click
        'Declaring the variables'
        Dim strWeightLoss As String
        Dim decWeightLoss As Decimal
        Dim decAverageLoss As Decimal
        Dim decTotalWeightLoss As Decimal = 0D

        'Input box variables'
        Dim strInputMessage As String = "Enter the weight loss for a team member #"
        Dim strInputHeading As String = "Weight Loss"
        Dim strNormalMessage As String = "Enter the weight loss for team member #"
        Dim strNonNumericError As String = "Error - Enter a number for the weight loss of team member #"
        Dim strNegativeError As String = "Error - Enter a  positive number for the weight loss of team member #"

        'Declare and initialize loop variables'
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 8
        Dim intNumberOfEntries As Integer = 1

        'This loop allows the user to enter the weight loss of up to 8 team members'
        'The loop terminates when the user has entered 8 weight loss numbers'
        strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strWeightLoss = strCancelClicked
            'Checking if the input is numeric'
            If IsNumeric(strWeightLoss) Then
                decWeightLoss = Convert.ToDecimal(strWeightLoss)

                'Check if the value is positive'
                If decWeightLoss > 0 Then
                    'Weight loss value increment'
                    lstWeightLoss.Items.Add(decWeightLoss)
                    decTotalWeightLoss += decTotalWeightLoss
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNegativeError
            End If
            'Check if 8 value have been entered and capture next value'
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strWeightLoss = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'Calculates and displays the average'
        If intNumberOfEntries > 1 Then
            lblAverageLoss.Visible = True
            decAverageLoss = decTotalWeightLoss / (intNumberOfEntries - 1)
            lblAverageLoss.Text = "Average weight loss is " & decAverageLoss.ToString("F1") & " lbs"
        Else
            MsgBox("No weight loss value entered!")
        End If

        'Disabling button after calculation'
        btnWeightLoss.Enabled = False
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        lstWeightLoss.Items.Clear()
        lblAverageLoss.Visible = False
        btnWeightLoss.Enabled = True
    End Sub
    Private Sub EToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EToolStripMenuItem.Click
        'Exits the program'
        Close()
    End Sub
End Class
