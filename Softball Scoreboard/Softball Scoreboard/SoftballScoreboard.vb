'Program: Softball Scoreboard'
'Developer: Izabella Fortunata'
'Date: 1/18/24'
'Purpose: calculates the score of each inning during a softball game for one team.'
Public Class frmSoftballScoreboard
    Private Sub frmSoftballScoreboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnEnterScore_Click(sender As Object, e As EventArgs) Handles btnEnterScore.Click

        Dim strInningScores As String
        Dim decInningScores As Decimal
        Dim decTotalScores As Decimal
        Dim strInputMessage As String = "Enter the inning  score for #"
        Dim strInputHeading As String = "Inning Score Input"
        Dim strNormalMessage As String = "Enter the inning score for #"
        Dim strNonNumericError As String = "Error - Enter a numerical value for the inning  score for #"
        Dim strNegativeError As String = "Error - Enter a positive number for the inning  score for #"
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 7
        Dim intNumberofEntries As Integer = 1

        'Capture user's first value'
        strInningScores = InputBox(strInputMessage & intNumberofEntries, strInputHeading, " ")

        'Continue the loop until the user enters  entries or cancel is clicked'
        Do Until intNumberofEntries > intMaxNumberOfEntries Or strInningScores = strCancelClicked

            'Is it numeric?'
            If IsNumeric(strInningScores) Then
                decInningScores = Convert.ToDecimal(strInningScores)
                If decInningScores >= 0 Then
                    'Display and add the inning sores as well as the number of entries
                    decTotalScores += decInningScores
                    lstScoreboard.Items.Add("Inning: " + intNumberofEntries.ToString() + " Runs: " + decInningScores.ToString() + " Total Score: " + decTotalScores.ToString())
                    intNumberofEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    'Show message box telling user to enter a positive'
                    strInputMessage = strNegativeError
                End If
            Else
                'Show message box telling user to enter a numerical value'
                strInputMessage = strNonNumericError
            End If

            'Checks if entry number is equal or less than the max # of entries
            If intNumberofEntries <= intMaxNumberOfEntries Then

                strInningScores = InputBox(strInputMessage & intNumberofEntries, strInputHeading, " ")
            End If
        Loop

        'Display the total inning score'
        lblTotalScore.Visible = True
        lblTotalScore.Text = "Total score: " + decTotalScores.ToString()
        btnEnterScore.Enabled = False
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Clear out values from lst box and label
        lstScoreboard.Items.Clear()
        lblTotalScore.Visible = False
        btnEnterScore.Enabled = True

    End Sub
    Private Sub ExitToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem1.Click
        'Closes the program'
        Close()
    End Sub
End Class
