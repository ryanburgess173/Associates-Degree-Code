''' -------------------------------------------------------------
''' 
''' Johnathan R. Burgess, CSC-139, Visual Basic Programming
''' Project #1, 3/12/2019
''' 
'''--------------------------------------------------------------
Public Class Form1
    Dim type As String = "None"
    Dim total As Double = 0D
    Dim finalText As String
    Dim currTextBox As TextBox

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inputBox.Focus()
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "1"
        Else
            currTextBox.Text = currTextBox.Text & "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "2"
        Else
            currTextBox.Text = currTextBox.Text & "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "3"
        Else
            currTextBox.Text = currTextBox.Text & "3"
        End If
    End Sub

    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "0"
        Else
            currTextBox.Text = currTextBox.Text & "0"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "4"
        Else
            currTextBox.Text = currTextBox.Text & "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "5"
        Else
            currTextBox.Text = currTextBox.Text & "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "6"
        Else
            currTextBox.Text = currTextBox.Text & "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "7"
        Else
            currTextBox.Text = currTextBox.Text & "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "8"
        Else
            currTextBox.Text = currTextBox.Text & "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "9"
        Else
            currTextBox.Text = currTextBox.Text & "9"
        End If
    End Sub

    Private Sub btnDecimal_Click(sender As Object, e As EventArgs) Handles btnDecimal.Click
        If (type = "None") Then
            currTextBox.Text = currTextBox.Text & "."
        Else
            currTextBox.Text = currTextBox.Text & "."
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        inputBox.Text = ""
        total = 0D
        type = "None"
        Label1.Text = ""
        inputBox2.Text = ""
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        total = Convert.ToDouble(inputBox.Text) / Convert.ToDouble(inputBox2.Text)
        type = "/"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        total = Convert.ToDouble(inputBox.Text) * Convert.ToDouble(inputBox2.Text)
        type = "x"
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        total = Convert.ToDouble(inputBox.Text) - Convert.ToDouble(inputBox2.Text)
        type = "-"
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        total = Convert.ToDouble(inputBox.Text) + Convert.ToDouble(inputBox2.Text)
        type = "+"
    End Sub

    Private Sub btnTotal_Click(sender As Object, e As EventArgs) Handles btnTotal.Click
        finalText = finalText & inputBox.Text & type & inputBox2.Text & " = " & total
        Label1.Text = finalText
    End Sub

    Private Sub inputBox_Enter(sender As Object, e As EventArgs) Handles inputBox.Enter
        currTextBox = inputBox
    End Sub

    Private Sub inputBox2_Enter(sender As Object, e As EventArgs) Handles inputBox2.Enter
        currTextBox = inputBox2
    End Sub
End Class
