Public Class InventoryReportForm
    Private Sub Inventory_ReportsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles Inventory_ReportsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.Inventory_ReportsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub InventoryReportForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Inventory_Reports' table. You can move, or remove it, as needed.
        Me.Inventory_ReportsTableAdapter.Fill(Me.TailoringBusinessDataSet.Inventory_Reports)

    End Sub

    Private Sub IDLabel_Click(sender As Object, e As EventArgs)

    End Sub
End Class