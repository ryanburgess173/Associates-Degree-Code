'   Johnathan R. Burgess
'   CSC-139, Visual Basic Programming
'   Programming Project #2, Vending Machine Program

' This is the class for our VendingMachine form
Public Class VendingMachine

    ' This variable will hold the total amount of money inserted so far and what is left over
    ' after different transactions that may occur.
    Dim decTotalEntered As Decimal = 0.0D

    ' This is the cost of all of the drinks.
    Dim decCostOfDrink As Decimal = 1.25D

    ' This function updates the amount in our totals text box
    Sub UpdateTotal()
        TextBoxTotal.Text = decTotalEntered.ToString("C")
    End Sub

    ' This function below increments our total amount entered by $1.00
    Private Sub BtnDollar_Click(sender As Object, e As EventArgs) Handles btnDollar.Click
        decTotalEntered += 1D
        UpdateTotal()
    End Sub

    ' This function below increments our total amount entered by $0.25
    Private Sub BtnQuarter_Click(sender As Object, e As EventArgs) Handles btnQuarter.Click
        decTotalEntered += 0.25D
        UpdateTotal()
    End Sub

    ' This function below increments our total amount entered by $0.10
    Private Sub BtnDime_Click(sender As Object, e As EventArgs) Handles btnDime.Click
        decTotalEntered += 0.1D
        UpdateTotal()
    End Sub

    ' This function below increments our total amount entered by $0.05
    Private Sub BtnNickel_Click(sender As Object, e As EventArgs) Handles btnNickel.Click
        decTotalEntered += 0.05D
        UpdateTotal()
    End Sub

    Private Sub VendingMachine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTotal()
    End Sub

    ' On Coca-Cola Classic Button Click
    Private Sub BtnClassic_Click(sender As Object, e As EventArgs) Handles btnClassic.Click
        If (decTotalEntered >= decCostOfDrink) Then
            ' subtracts the cost of the drink from our total inserted
            decTotalEntered -= decCostOfDrink
            ' IF the left over change is greater than the cost of a new drink than only update the total inserted.
            ' Don't yet give change to the user.
            If (decTotalEntered >= decCostOfDrink) Then
                UpdateTotal()
                MsgBox("Enjoy your Coca-Cola Classic!", MsgBoxStyle.Exclamation, "Goodbye!")
                ' Only returns change IF the change due is less than or equal to the cost of an additional beverage
            Else
                MsgBox("Enjoy your Coca-Cola Classic! Your change is: " & decTotalEntered.ToString("C"), MsgBoxStyle.Information, "Have a Great Day!")
                decTotalEntered = 0.0D
                UpdateTotal()
            End If
        Else
            MsgBox("Insufficient Funds Inserted!", MsgBoxStyle.OkOnly, "Sorry!")
        End If
    End Sub

    ' On Coca-Cola Vanilla Button Click
    Private Sub BtnVanilla_Click(sender As Object, e As EventArgs) Handles btnVanilla.Click
        If (decTotalEntered >= decCostOfDrink) Then
            ' subtracts the cost of the drink from our total inserted
            decTotalEntered -= decCostOfDrink
            ' IF the left over change is greater than the cost of a new drink than only update the total inserted.
            ' Don't yet give change to the user.
            If (decTotalEntered >= decCostOfDrink) Then
                UpdateTotal()
                MsgBox("Enjoy your Vanilla Coca-Cola!", MsgBoxStyle.Exclamation, "Goodbye!")
                ' Only returns change IF the change due is less than or equal to the cost of an additional beverage
            Else
                MsgBox("Enjoy your Vanilla Coca-Cola! Your change is: " & decTotalEntered.ToString("C"), MsgBoxStyle.Information, "Have a Great Day!")
                decTotalEntered = 0.0D
                UpdateTotal()
            End If
        Else
            MsgBox("Insufficient Funds Inserted!", MsgBoxStyle.OkOnly, "Sorry!")
        End If

    End Sub

    ' On Coca-Cola Cherry Button Click
    Private Sub BtnCherry_Click(sender As Object, e As EventArgs) Handles btnCherry.Click
        If (decTotalEntered >= decCostOfDrink) Then
            ' subtracts the cost of the drink from our total inserted
            decTotalEntered -= decCostOfDrink
            ' IF the left over change is greater than the cost of a new drink than only update the total inserted.
            ' Don't yet give change to the user.
            If (decTotalEntered >= decCostOfDrink) Then
                UpdateTotal()
                MsgBox("Enjoy your Cherry Coca-Cola!", MsgBoxStyle.Exclamation, "Goodbye!")
                ' Only returns change IF the change due is less than or equal to the cost of an additional beverage
            Else
                MsgBox("Enjoy your Cherry Coca-Cola! Your change is: " & decTotalEntered.ToString("C"), MsgBoxStyle.Information, "Have a Great Day!")
                decTotalEntered = 0.0D
                UpdateTotal()
            End If
        Else
            MsgBox("Insufficient Funds Inserted!", MsgBoxStyle.OkOnly, "Sorry!")
        End If
    End Sub

    ' On Sprite Button Click
    Private Sub BtnSprite_Click(sender As Object, e As EventArgs) Handles btnSprite.Click
        If (decTotalEntered >= decCostOfDrink) Then
            ' subtracts the cost of the drink from our total inserted
            decTotalEntered -= decCostOfDrink
            ' IF the left over change is greater than the cost of a new drink than only update the total inserted.
            ' Don't yet give change to the user.
            If (decTotalEntered >= decCostOfDrink) Then
                UpdateTotal()
                MsgBox("Enjoy your Sprite!", MsgBoxStyle.Exclamation, "Goodbye!")
                ' Only returns change IF the change due is less than or equal to the cost of an additional beverage
            Else
                MsgBox("Enjoy your Sprite! Your change is: " & decTotalEntered.ToString("C"), MsgBoxStyle.Information, "Have a Great Day!")
                decTotalEntered = 0.0D
                UpdateTotal()
            End If
        Else
            MsgBox("Insufficient Funds Inserted!", MsgBoxStyle.OkOnly, "Sorry!")
        End If
    End Sub

    ' On Coca-Cola Orange Vanilla Button Click
    Private Sub BtnOrange_Click(sender As Object, e As EventArgs) Handles btnOrange.Click
        If (decTotalEntered >= decCostOfDrink) Then
            ' subtracts the cost of the drink from our total inserted
            decTotalEntered -= decCostOfDrink
            ' IF the left over change is greater than the cost of a new drink than only update the total inserted.
            ' Don't yet give change to the user.
            If (decTotalEntered >= decCostOfDrink) Then
                UpdateTotal()
                MsgBox("Enjoy your Orange Vanilla Coca-Cola!", MsgBoxStyle.Exclamation, "Goodbye!")
                ' Only returns change IF the change due is less than or equal to the cost of an additional beverage
            Else
                MsgBox("Enjoy your Orange Vanilla Coca-Cola! Your change is: " & decTotalEntered.ToString("C"), MsgBoxStyle.Information, "Have a Great Day!")
                decTotalEntered = 0.0D
                UpdateTotal()
            End If
        Else
            MsgBox("Insufficient Funds Inserted!", MsgBoxStyle.OkOnly, "Sorry!")
        End If
    End Sub

    ' On Water Button Click
    Private Sub BtnWater_Click(sender As Object, e As EventArgs) Handles btnWater.Click
        If (decTotalEntered >= decCostOfDrink) Then
            ' subtracts the cost of the drink from our total inserted
            decTotalEntered -= decCostOfDrink
            ' IF the left over change is greater than the cost of a new drink than only update the total inserted.
            ' Don't yet give change to the user.
            If (decTotalEntered >= decCostOfDrink) Then
                UpdateTotal()
                MsgBox("Enjoy your Water!", MsgBoxStyle.Exclamation, "Goodbye!")
                ' Only returns change IF the change due is less than or equal to the cost of an additional beverage
            Else
                MsgBox("Enjoy your Water! Your change is: " & decTotalEntered.ToString("C"), MsgBoxStyle.Information, "Have a Great Day!")
                decTotalEntered = 0.0D
                UpdateTotal()
            End If
        Else
            MsgBox("Insufficient Funds Inserted!", MsgBoxStyle.OkOnly, "Sorry!")
        End If
    End Sub

    ' On Exit Button Click
    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    ' This function will give you your change if you change your mind like a real vending machine :-)
    Private Sub BtnCancelGetChange_Click(sender As Object, e As EventArgs) Handles btnCancelGetChange.Click
        If (decTotalEntered > 0.0D) Then
            MsgBox("No worries! Hope to see you again! Your Change Is: " & decTotalEntered.ToString("C"), MsgBoxStyle.MsgBoxHelp, "Bye!")
            decTotalEntered = 0.0D
            UpdateTotal()
        End If
    End Sub
End Class
