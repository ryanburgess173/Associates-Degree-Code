''' Johnathan R. Burgess
''' 2/10/2019
''' Visual Basic Programming
''' Case Programming Assignment, Chapter 4, Problem #1
Public Class Form1
    Dim days As Integer
    Dim cost As Double
    Dim rate As Double = 79D
    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        days = Convert.ToInt32(entryDays.Text)
        cost = days * rate
        lblCost.Text = cost.ToString("C") ' Outputs as currency $X.XX
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblCost.Text = ""
        entryDays.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
