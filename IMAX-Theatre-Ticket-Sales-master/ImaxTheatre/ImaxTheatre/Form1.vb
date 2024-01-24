' Johnathan R. Burgess, 4/5/2019
' IMAX Theatre Ticket Application
Public Class Form1
    Private _matineeCost As Decimal = 16.0
    Private _regularCost As Decimal = 27.0

    ' returns the matinee ticket total cost
    Private Function MatineeCost(ByVal _numOfTickets As Integer) As Decimal
        Dim finalCost As Decimal = _matineeCost * _numOfTickets
        Return finalCost
    End Function

    ' returns the evening ticket total cost
    Private Function RegularCost(ByVal _numOfTickets As Integer) As Decimal
        Dim finalCost As Decimal = _regularCost * _numOfTickets
        Return finalCost
    End Function

    ' when you hit the ticket cost button
    Private Sub btnCalcCost_Click(sender As Object, e As EventArgs) Handles btnCalcCost.Click
        Dim _numOfTickets As Integer

        ' stores the key of the item you selected from the dropdown
        Dim intLocationChoice As Integer = inputTicketType.SelectedIndex
        Select Case intLocationChoice
            Case 0
                Try
                    _numOfTickets = Convert.ToInt32(inputNumberOfTickets.Text)
                    If (_numOfTickets > 0) Then
                        Dim number As Decimal = MatineeCost(_numOfTickets)
                        output.Text = number.ToString("C") & " for the tickets"
                    Else
                        MsgBox("Enter a number greater than zero!", , "Input Error")
                    End If
                Catch Exception As FormatException
                    MsgBox("Format Exception", , "Error")
                    inputNumberOfTickets.Focus()
                    inputNumberOfTickets.Clear()
                Catch Exception As OverflowException
                    MsgBox("Overflow Exception", , "Error")
                    inputNumberOfTickets.Focus()
                    inputNumberOfTickets.Clear()
                Catch Exception As SystemException
                    MsgBox("System Exception", , "Error")
                    inputNumberOfTickets.Focus()
                    inputNumberOfTickets.Clear()
                End Try
            Case 1
                Try
                    _numOfTickets = Convert.ToInt32(inputNumberOfTickets.Text)
                    If (_numOfTickets > 0) Then
                        Dim number As Decimal = RegularCost(_numOfTickets)
                        output.Text = number.ToString("C") & " for the tickets"
                    Else
                        MsgBox("Please enter a whole number greater than zero!", , "Input Error")
                    End If
                Catch Exception As FormatException
                    MsgBox("Format Exception", , "Error")
                    inputNumberOfTickets.Focus()
                    inputNumberOfTickets.Clear()
                Catch Exception As OverflowException
                    MsgBox("Overflow Exception", , "Error")
                    inputNumberOfTickets.Focus()
                    inputNumberOfTickets.Clear()
                Catch Exception As SystemException
                    MsgBox("System Exception", , "Error")
                    inputNumberOfTickets.Focus()
                    inputNumberOfTickets.Clear()
                End Try
        End Select
    End Sub

    Private Sub inputTicketType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles inputTicketType.SelectedIndexChanged
        Label2.Visible = True
        inputNumberOfTickets.Visible = True
        btnCalcCost.Visible = True
        btnClearFrm.Visible = True
    End Sub

    Private Sub btnClearFrm_Click(sender As Object, e As EventArgs) Handles btnClearFrm.Click
        inputTicketType.Text = ""
        inputNumberOfTickets.Text = ""
        Label2.Visible = False
        inputNumberOfTickets.Visible = False
        btnCalcCost.Visible = False
        btnClearFrm.Visible = False
        output.Text = ""
        output.Visible = False

    End Sub

    ' pauses long enough to display the splash screen for 5 seconds
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by Johnathan R. Burgess of Guilford Technical Community College", , "About the Creator")
    End Sub
End Class
