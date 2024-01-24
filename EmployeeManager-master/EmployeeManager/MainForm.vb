Public Class MainForm
    Dim EmployeeView As New View
    Dim EmployeeEdit As New Edit
    Private Sub BtnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        EmployeeView = New View
        EmployeeView.Show()
        EmployeeView.Activate()
    End Sub

    Private Sub ViewInTableToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInTableToolStripMenuItem.Click
        EmployeeView = New View
        EmployeeView.Show()
        EmployeeView.Activate()
    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        EmployeeEdit = New Edit
        EmployeeEdit.Show()
        EmployeeEdit.Activate()
    End Sub

    Private Sub AddDeleteModifyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddDeleteModifyToolStripMenuItem.Click
        EmployeeEdit = New Edit
        EmployeeEdit.Show()
        EmployeeEdit.Activate()
    End Sub

    Private Sub ViewInFormsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewInFormsToolStripMenuItem.Click
        EmployeeEdit = New Edit
        EmployeeEdit.Show()
        EmployeeEdit.Activate()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by Johnathan R. Burgess of Guilford Technical Community College. This application is for my Computer Programming Capstone Project.", , "About This Application")
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub
End Class
