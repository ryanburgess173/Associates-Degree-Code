' Johnathan R. Burgess
Public Class Form1
    Const inchToMeters As Double = 0.0254D
    Const meterToInches As Double = 39.37008D
    Dim result As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnInchesToMeters.Click
        If IsNumeric(inputInches.Text) Then
            If IsNothing(inputInches.Text) Then
                MsgBox("Enter something for inches!")
            Else
                result = Convert.ToDouble(inputInches.Text)
                result *= inchToMeters
                inputMeters.Text = result.ToString()
            End If
        Else
            MsgBox("Enter a numerical value!")
        End If
    End Sub

    Private Sub btnMetersToFeet_Click(sender As Object, e As EventArgs) Handles btnMetersToFeet.Click
        If IsNumeric(inputMeters.Text) Then
            If IsNothing(inputMeters.Text) Then
                MsgBox("Enter something for inches!")
            Else
                result = Convert.ToDouble(inputMeters.Text)
                result *= meterToInches
                inputInches.Text = result.ToString()
            End If
        Else
            MsgBox("Enter a numerical value!")
        End If
    End Sub
End Class
