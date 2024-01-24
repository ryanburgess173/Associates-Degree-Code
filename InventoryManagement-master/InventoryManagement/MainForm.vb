Public Class MainForm
    Dim InventoryRecordForm1 = New InventoryRecordForm
    Dim InventoryRecordTable1 = New InventoryRecordTable
    Dim InventoryReportTable1 = New InventoryReportTable
    Dim InventoryReportForm1 = New InventoryReportForm
    Private Sub DarkOceanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkOceanToolStripMenuItem.Click
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditInventoryDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.EditInventoryReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.TableViewToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.FormViewToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ApplicationThemesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DarkOceanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DarkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LightToolStripMenuItem.BackColor = Color.White

        Me.DarkToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DarkOceanToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ApplicationThemesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FormViewToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.TableViewToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.EditInventoryReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FormViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TableViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditInventoryDataToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.ForeColor = Color.White
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.LightToolStripMenuItem.ForeColor = Color.Black

        Me.btnInventoryRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnInventoryReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.btnInventoryRecords.ForeColor = Color.White
        Me.btnInventoryReports.ForeColor = Color.White
        Me.btnExit.ForeColor = Color.White

        Me.BackColor = Color.FromArgb(0, 0, 64)

    End Sub

    Private Sub DarkToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DarkToolStripMenuItem.Click
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.EditToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.EditInventoryDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TableViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FormViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.EditInventoryReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.TableViewToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.FormViewToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ApplicationThemesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DarkOceanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.DarkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.LightToolStripMenuItem.BackColor = Color.White

        Me.DarkToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.DarkOceanToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ApplicationThemesToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FormViewToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.TableViewToolStripMenuItem1.ForeColor = System.Drawing.Color.White
        Me.EditInventoryReportsToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FormViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.TableViewToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditInventoryDataToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.EditToolStripMenuItem.ForeColor = Color.White
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.White
        Me.MenuStrip1.ForeColor = System.Drawing.Color.White
        Me.LightToolStripMenuItem.ForeColor = Color.Black

        Me.btnInventoryRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnInventoryReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.btnInventoryRecords.ForeColor = Color.White
        Me.btnInventoryReports.ForeColor = Color.White
        Me.btnExit.ForeColor = Color.White

        Me.BackColor = Color.FromArgb(35, 35, 35)
    End Sub

    Private Sub ApplicationThemesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ApplicationThemesToolStripMenuItem.Click

    End Sub

    Private Sub LightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LightToolStripMenuItem.Click
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer), CType(CType(245, Byte), Integer))
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.AboutToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ExitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.EditToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.EditInventoryDataToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TableViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.FormViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.EditInventoryReportsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.TableViewToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.FormViewToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ViewToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.ApplicationThemesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DarkOceanToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.DarkToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.LightToolStripMenuItem.BackColor = Color.White

        Me.DarkToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.DarkOceanToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ApplicationThemesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ViewToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FormViewToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.TableViewToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.EditInventoryReportsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FormViewToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.TableViewToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditInventoryDataToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EditToolStripMenuItem.ForeColor = Color.Black
        Me.ExitToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.MenuStrip1.ForeColor = System.Drawing.Color.Black
        Me.LightToolStripMenuItem.ForeColor = Color.Black

        Me.BackColor = Color.FromArgb(235, 235, 235)

        Me.btnInventoryRecords.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnInventoryReports.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer), CType(CType(235, Byte), Integer))
        Me.btnInventoryRecords.ForeColor = Color.Black
        Me.btnInventoryReports.ForeColor = Color.Black
        Me.btnExit.ForeColor = Color.Black

    End Sub

    Private Sub BtnInventoryRecords_Click(sender As Object, e As EventArgs) Handles btnInventoryRecords.Click
        InventoryRecordTable1 = New InventoryRecordTable
        InventoryRecordTable1.Show()
        InventoryRecordTable1.Activate()
    End Sub

    Private Sub BtnInventoryReports_Click(sender As Object, e As EventArgs) Handles btnInventoryReports.Click
        InventoryReportTable1 = New InventoryReportTable
        InventoryReportTable1.Show()
        InventoryReportTable.Activate()
    End Sub

    Private Sub TableViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TableViewToolStripMenuItem.Click
        InventoryRecordTable1 = New InventoryRecordTable
        InventoryRecordTable1.Show()
        InventoryRecordTable1.Activate()
    End Sub

    Private Sub FormViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormViewToolStripMenuItem.Click
        InventoryRecordForm1 = New InventoryRecordForm
        InventoryRecordForm1.Show()
        InventoryRecordForm1.Activate()
    End Sub

    Private Sub TableViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TableViewToolStripMenuItem1.Click
        InventoryReportTable1 = New InventoryReportTable
        InventoryReportTable1.Show()
        InventoryReportTable1.Activate()
    End Sub

    Private Sub FormViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles FormViewToolStripMenuItem1.Click
        InventoryReportForm1 = New InventoryReportForm
        InventoryReportForm1.Show()
        InventoryReportForm1.Activate()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MsgBox("Created by Johnathan R. Burgess, Guilford Technical Community College.", , "About The Author")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
End Class
