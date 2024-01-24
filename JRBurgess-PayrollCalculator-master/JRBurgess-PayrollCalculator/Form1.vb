''' Johnathan R. Burgess
''' 2/12/2019
''' CSC-139, Chapter 4, Case Assignment #4

Public Class MainApplicationWindow

    Dim gross As Double
    Dim fica As Double
    Dim fed As Double
    Dim state As Double
    Dim net As Double
    Const ficaTax = 0.0765
    Const fedTax = 0.22
    Const stTax = 0.04

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        inputGross.Text = ""
        outputFICA.Text = ""
        outputFed.Text = ""
        outputState.Text = ""
        outputNet.Text = ""

        btnCalc.Enabled = True

    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        gross = CDbl(inputGross.Text)
        fica = gross * ficaTax
        fed = gross * fedTax
        state = gross * stTax
        net = gross - (fica + fed + state)

        inputGross.Text = gross.ToString("C")
        outputFICA.Text = fica.ToString("C")
        outputFed.Text = fed.ToString("C")
        outputState.Text = state.ToString("C")
        outputNet.Text = net.ToString("C")

        btnCalc.Enabled = False

    End Sub
End Class
