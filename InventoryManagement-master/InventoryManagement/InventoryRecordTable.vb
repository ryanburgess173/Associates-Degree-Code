Public Class InventoryRecordTable
    Private Sub InventoryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles InventoryBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.InventoryBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub InventoryRecordTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Inventory' table. You can move, or remove it, as needed.
        Me.InventoryTableAdapter.Fill(Me.TailoringBusinessDataSet.Inventory)

    End Sub
End Class