'Program: Internet Speed Survey'
'Developer: Izabella Fortunata'
'Date: 1/17/24'
'Purpose: This app takes 10 input values of the users internet speed, then averages it.'
Public Class frmInternetSpeedTest
    Private Sub btnEnterInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnEnterInternetSpeed.Click
        'Declare variables'
        Dim strInternetSpeed As String
        Dim decInternetSpeed As Decimal
        Dim decAverageInternetSpeed As Decimal
        Dim decTotalInternetSpeed As Decimal = 0D

        'Messeage boxes for user input'
        Dim strInputMessage As String = "Enter the internet speed for #"
        Dim strInputHeading As String = "Internet Speed"
        Dim strNormalMessage As String = "Enter the internet speed for #"
        Dim strNonNumericError As String = "Error - Enter a number for the internet speed survey "
        Dim strNegativeError As String = "Error - Enter a positive number for the internet speed survey "

        'Declare and intialize loop variables'
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        'Capture first value'
        strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strInternetSpeed = strCancelClicked

            'Check if entry is numeric'
            If IsNumeric(strInternetSpeed) Then
                decInternetSpeed = Convert.ToDecimal(strInternetSpeed)
                'Check if value is positive'
                If decInternetSpeed > 0 Then
                    lstInternetSpeed.Items.Add(decInternetSpeed)
                    decTotalInternetSpeed += decInternetSpeed
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberofEntries <= intMaxNumberOfEntries Then
                strInternetSpeed = InputBox(strInputMessage & intNumberofEntries, strInputHeading, " ")
            End If

        Loop
        'Calculate and display average
        If intNumberOfEntries > 1 Then
            lblAverageInternetSpeed.Visible = True
            decAverageInternetSpeed = decTotalInternetSpeed / (intNumberOfEntries - 1)
            lblAverageInternetSpeed.Text = "Average Internet Speed: " & decAverageInternetSpeed.ToString("F1") & " Mbps"
        End If
        btnEnterInternetSpeed.Enabled = True
    End Sub
    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clear out list box'
        lstInternetSpeed.Items.Clear()
        lblAverageInternetSpeed.Visible = False
        btnEnterInternetSpeed.Enabled = True
    End Sub
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub
    Private Sub frmInternetSpeedTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
