Public Class Edit
    Private Sub EmployeesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EmployeesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmployeesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Employees' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.TailoringBusinessDataSet.Employees)

    End Sub

    Private Sub FaxNumberTextBox_TextChanged(sender As Object, e As EventArgs) Handles FaxNumberTextBox.TextChanged

    End Sub

    Private Sub MobilePhoneTextBox_TextChanged(sender As Object, e As EventArgs) Handles MobilePhoneTextBox.TextChanged

    End Sub
End Class