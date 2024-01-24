' Program Name: Final Project, Addition and Multiplication Tables for Elementary
' Author:       Johnathan R. Burgess, Student ID: 1763590
' College:      Guilford Technical Community College
' Course:       CSC-139, Visual Basic Programming
' Project:      Final Project (a.k.a. Project #3)

Public Class Form1
    Dim early As Boolean = False
    Dim upper As Boolean = False
    Dim addition As Boolean = False
    Dim multiplication As Boolean = False
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub RBtnEarly_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnEarly.CheckedChanged
        early = True
        upper = False
    End Sub

    Private Sub RBtnUpper_CheckedChanged(sender As Object, e As EventArgs) Handles rBtnUpper.CheckedChanged
        early = False
        upper = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        ' If addition condition is met
        If (addition = True) Then

            ' if early condition is met
            If (early = True) Then
                Dim counter As Integer
                Dim stringInput As String
                Dim input As Integer
                stringInput = InputBox("Enter a number between 0 and 6: ", "Input")

                ' try to convert to integer
                Try
                    input = Convert.ToInt32(stringInput)

                    ' make sure your value is between the proper values
                    If ((input >= 0) And (input <= 6)) Then
                        listBoxOutput.Items.Clear()

                        ' simple loop to output the results
                        For counter = 0 To 6 Step 1
                            listBoxOutput.Items.Add(input.ToString() & "+" & counter.ToString() & "=" & (input + counter).ToString())
                        Next
                    Else
                        MsgBox("Please enter a valid number from 0 to 6. Thank you.", MsgBoxStyle.Exclamation, "FYI")
                    End If

                    'If you can't throw this exception:
                Catch ex As Exception
                    MsgBox(("Invalid data entered! Must enter a number. " & ex.ToString()), MsgBoxStyle.Critical, "Error")
                End Try
            ElseIf (upper = True) Then
                Dim counter As Integer
                Dim stringInput As String
                Dim input As Integer
                stringInput = InputBox("Enter a number between 0 and 12: ", "Input")
                Try
                    ' try to convert to integer
                    input = Convert.ToInt32(stringInput)
                    If ((input >= 0) And (input <= 12)) Then
                        listBoxOutput.Items.Clear()

                        ' simple loop to output the results
                        For counter = 0 To 12 Step 1
                            listBoxOutput.Items.Add(input.ToString() & "+" & counter.ToString() & "=" & (input + counter).ToString())
                        Next
                    Else
                        MsgBox("Please enter a valid number from 0 to 12. Thank you.", MsgBoxStyle.Exclamation, "FYI")
                    End If

                    'If you can't throw this exception:
                Catch ex As Exception
                    MsgBox(("Invalid data entered! Must enter a number. " & ex.ToString()), MsgBoxStyle.Critical, "Error")
                End Try
            Else
                MsgBox("You need to select either Early or Upper Elementary!", MsgBoxStyle.Critical, "Error")
            End If
            ' Thrown if the user wants to multiply
        ElseIf (multiplication = True) Then
            If (early = True) Then
                Dim counter As Integer
                Dim stringInput As String
                Dim input As Integer
                stringInput = InputBox("Enter a number between 0 and 6: ", "Input")
                Try
                    input = Convert.ToInt32(stringInput)
                    If ((input >= 0) And (input <= 6)) Then
                        listBoxOutput.Items.Clear()
                        For counter = 0 To 6 Step 1
                            listBoxOutput.Items.Add(input.ToString() & "x" & counter.ToString() & "=" & (input * counter).ToString())
                        Next
                    Else
                        MsgBox("Please enter a valid number from 0 to 6. Thank you.", MsgBoxStyle.Exclamation, "FYI")
                    End If
                Catch ex As Exception
                    MsgBox(("Invalid data entered! Must enter a number. " & ex.ToString()), MsgBoxStyle.Critical, "Error")
                End Try
            ElseIf (upper = True) Then
                Dim counter As Integer
                Dim stringInput As String
                Dim input As Integer
                stringInput = InputBox("Enter a number between 0 and 12: ", "Input")
                Try
                    input = Convert.ToInt32(stringInput)
                    If ((input >= 0) And (input <= 12)) Then
                        listBoxOutput.Items.Clear()
                        For counter = 0 To 12 Step 1
                            listBoxOutput.Items.Add(input.ToString() & "x" & counter.ToString() & "=" & (input * counter).ToString())
                        Next
                    Else
                        MsgBox("Please enter a valid number from 0 to 12. Thank you.", MsgBoxStyle.Exclamation, "FYI")
                    End If
                Catch ex As Exception
                    MsgBox(("Invalid data entered! Must enter a number. " & ex.ToString()), MsgBoxStyle.Critical, "Error")
                End Try

                ' If the user doesn't select early or upper elementary
            Else
                MsgBox("You need to select either Early or Upper Elementary!", MsgBoxStyle.Critical, "Error")

            End If
            ' If the user doesn't select addition or multiplication
        Else
            MsgBox("You need to select either addition or multiplication!", MsgBoxStyle.Critical, "Error")
        End If
    End Sub

    Private Sub AdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AdditionToolStripMenuItem.Click
        addition = True
        multiplication = False
    End Sub

    Private Sub MultiplicationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MultiplicationToolStripMenuItem.Click
        addition = False
        multiplication = True
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        ' Clears the contents of the radio buttons and the variables along with the list box
        listBoxOutput.Items.Clear()
        addition = False
        multiplication = False
        upper = False
        early = False
        rBtnEarly.Checked = False
        rBtnUpper.Checked = False
    End Sub
End Class
