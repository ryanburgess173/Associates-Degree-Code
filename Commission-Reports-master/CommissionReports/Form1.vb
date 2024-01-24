Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim strSql As String = "SELECT Employee_ID, Amount_Sold, "
    End Sub

    Private Sub CommissionBindingNavigator1SaveItem_Click(sender As Object, e As EventArgs) Handles CommissionBindingNavigator1SaveItem.Click
        Me.Validate()
        Me.CommissionBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.TailoringBusinessDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TailoringBusinessDataSet.Commission' table. You can move, or remove it, as needed.
        Me.CommissionTableAdapter.Fill(Me.TailoringBusinessDataSet.Commission)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.CommissionTableAdapter.FillBy(Me.TailoringBusinessDataSet.Commission, New System.Nullable(Of Integer)(CType(txtBoxEmployeeID.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnFilter.Click
        Try
            Me.CommissionBindingSource.Filter = "[Month] = '" & txtBoxMonth.Text & "'" & " And [Employee_ID] = '" & txtBoxEmployeeID.Text & "'"
        Catch ex As Exception
            MsgBox("Showing All Data", MsgBoxStyle.Information, "Resetting...")
            Me.CommissionBindingSource.RemoveFilter()
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim strSql As String = "SELECT Employee_ID, Employee_Name, Total_Commission FROM Commission"

        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=C:\Users\ryanb\source\repos\CommissionReports\CommissionReports\TailoringBusiness.accdb"
        Dim odaItems As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        odaItems.Fill(datValue)
        odaItems.Dispose()

        For Each row As DataRow In TailoringBusinessDataSet.Commission.Rows
            If (row("Employee_ID") = Convert.ToInt32(txtBoxEmployeeID.Text)) Then
                If (row("Month") = Convert.ToInt32(txtBoxMonth.Text)) Then
                    decTotalValue += Convert.ToDecimal(row("Total_Commission"))
                End If
            End If
        Next


        Dim FILE_NAME As String = "CommissionReport-" & "-Month-" & txtBoxMonth.Text & "-Employee-" & txtBoxEmployeeID.Text & ".txt"
        MsgBox(FILE_NAME)
        If System.IO.File.Exists(FILE_NAME) = False Then
            System.IO.File.Create(FILE_NAME).Dispose()
        End If
        Dim objWriter As New System.IO.StreamWriter(FILE_NAME, True)
        objWriter.WriteLine("Commission Report for" & Format(Now, "dddd, d MMM yyyy"))
        objWriter.WriteLine("Employee ID #......: " & txtBoxEmployeeID.Text)
        objWriter.WriteLine("Employee Name......: " & txtBoxName.Text)
        objWriter.WriteLine("Total Commission...: $" & decTotalValue.ToString())
        objWriter.Close()
    End Sub

End Class
