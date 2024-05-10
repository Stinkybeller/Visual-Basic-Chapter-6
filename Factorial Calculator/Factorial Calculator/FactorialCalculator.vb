'Program Name: Factorial Calculator'
'Developer: Izabella Fortunata'
'Date: 02/9/24'
'Purpose: Calculates user input and displays a list of factorials up to their number'
Public Class frmFactorialCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Declare variables'
        Dim intUserInput As Integer
        Dim intCounter As Integer = 1
        Dim intLastNumber As Integer = 1

        'Is it numeric?'
        If Integer.TryParse(txtNumber.Text, intUserInput) Then
            'Check if value if a positive number less than 13'
            intUserInput = Convert.ToDecimal(txtNumber.Text)
            If intUserInput > 0 And intUserInput <= 12 Then
                'Loop until counter is equal to the users input'
                For intCounter = 1 To intUserInput
                    intLastNumber = intCounter * intLastNumber
                    lstFactorial.Items.Add(intCounter.ToString() + "! = " + intLastNumber.ToString())
                Next
            Else
                'Message box displays telling user to enter a positive value less than or equal to 12'
                MsgBox("Please enter a positive value less than or equal to 12")
                txtNumber.Clear()
                lstFactorial.Items.Clear()
            End If
        Else
            'Message box displays telling user to enter a numeric value'
            MsgBox("Enter a numeric value")
            txtNumber.Clear()
            lstFactorial.Items.Clear()
        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        'Clears out all values'
        lstFactorial.Items.Clear()
        txtNumber.Clear()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        'Closes the program'
        Close()
    End Sub

    Private Sub frmFactorialCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class

