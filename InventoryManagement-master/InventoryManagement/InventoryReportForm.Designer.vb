<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryReportForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IDLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryReportForm))
        Dim ItemLabel As System.Windows.Forms.Label
        Dim Starting_InventoryLabel As System.Windows.Forms.Label
        Dim Ending_InventoryLabel As System.Windows.Forms.Label
        Dim SalesLabel As System.Windows.Forms.Label
        Dim ThresholdsLabel As System.Windows.Forms.Label
        Dim What_To_OrderLabel As System.Windows.Forms.Label
        Dim Period_EndingLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New InventoryManagement.TailoringBusinessDataSet()
        Me.Inventory_ReportsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Inventory_ReportsTableAdapter = New InventoryManagement.TailoringBusinessDataSetTableAdapters.Inventory_ReportsTableAdapter()
        Me.TableAdapterManager = New InventoryManagement.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.Inventory_ReportsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.Inventory_ReportsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ItemTextBox = New System.Windows.Forms.TextBox()
        Me.Starting_InventoryTextBox = New System.Windows.Forms.TextBox()
        Me.Ending_InventoryTextBox = New System.Windows.Forms.TextBox()
        Me.SalesTextBox = New System.Windows.Forms.TextBox()
        Me.ThresholdsTextBox = New System.Windows.Forms.TextBox()
        Me.What_To_OrderTextBox = New System.Windows.Forms.TextBox()
        Me.Period_EndingDateTimePicker = New System.Windows.Forms.DateTimePicker()
        IDLabel = New System.Windows.Forms.Label()
        ItemLabel = New System.Windows.Forms.Label()
        Starting_InventoryLabel = New System.Windows.Forms.Label()
        Ending_InventoryLabel = New System.Windows.Forms.Label()
        SalesLabel = New System.Windows.Forms.Label()
        ThresholdsLabel = New System.Windows.Forms.Label()
        What_To_OrderLabel = New System.Windows.Forms.Label()
        Period_EndingLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_ReportsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Inventory_ReportsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Inventory_ReportsBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Inventory_ReportsBindingSource
        '
        Me.Inventory_ReportsBindingSource.DataMember = "Inventory Reports"
        Me.Inventory_ReportsBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'Inventory_ReportsTableAdapter
        '
        Me.Inventory_ReportsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Inventory_ReportsTableAdapter = Me.Inventory_ReportsTableAdapter
        Me.TableAdapterManager.InventoryTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = InventoryManagement.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Inventory_ReportsBindingNavigator
        '
        Me.Inventory_ReportsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.Inventory_ReportsBindingNavigator.BindingSource = Me.Inventory_ReportsBindingSource
        Me.Inventory_ReportsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.Inventory_ReportsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.Inventory_ReportsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.Inventory_ReportsBindingNavigatorSaveItem})
        Me.Inventory_ReportsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.Inventory_ReportsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.Inventory_ReportsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.Inventory_ReportsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.Inventory_ReportsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.Inventory_ReportsBindingNavigator.Name = "Inventory_ReportsBindingNavigator"
        Me.Inventory_ReportsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.Inventory_ReportsBindingNavigator.Size = New System.Drawing.Size(578, 25)
        Me.Inventory_ReportsBindingNavigator.TabIndex = 0
        Me.Inventory_ReportsBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        IDLabel.Location = New System.Drawing.Point(161, 84)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(30, 20)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        AddHandler IDLabel.Click, AddressOf Me.IDLabel_Click
        '
        'IDTextBox
        '
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventory_ReportsBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.Location = New System.Drawing.Point(197, 81)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 26)
        Me.IDTextBox.TabIndex = 2
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'Inventory_ReportsBindingNavigatorSaveItem
        '
        Me.Inventory_ReportsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Inventory_ReportsBindingNavigatorSaveItem.Image = CType(resources.GetObject("Inventory_ReportsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.Inventory_ReportsBindingNavigatorSaveItem.Name = "Inventory_ReportsBindingNavigatorSaveItem"
        Me.Inventory_ReportsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.Inventory_ReportsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'ItemLabel
        '
        ItemLabel.AutoSize = True
        ItemLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ItemLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ItemLabel.Location = New System.Drawing.Point(142, 152)
        ItemLabel.Name = "ItemLabel"
        ItemLabel.Size = New System.Drawing.Size(45, 20)
        ItemLabel.TabIndex = 3
        ItemLabel.Text = "Item:"
        '
        'ItemTextBox
        '
        Me.ItemTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventory_ReportsBindingSource, "Item", True))
        Me.ItemTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ItemTextBox.Location = New System.Drawing.Point(197, 149)
        Me.ItemTextBox.Name = "ItemTextBox"
        Me.ItemTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ItemTextBox.TabIndex = 4
        '
        'Starting_InventoryLabel
        '
        Starting_InventoryLabel.AutoSize = True
        Starting_InventoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Starting_InventoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Starting_InventoryLabel.Location = New System.Drawing.Point(53, 220)
        Starting_InventoryLabel.Name = "Starting_InventoryLabel"
        Starting_InventoryLabel.Size = New System.Drawing.Size(138, 20)
        Starting_InventoryLabel.TabIndex = 5
        Starting_InventoryLabel.Text = "Starting Inventory:"
        '
        'Starting_InventoryTextBox
        '
        Me.Starting_InventoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventory_ReportsBindingSource, "Starting Inventory", True))
        Me.Starting_InventoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Starting_InventoryTextBox.Location = New System.Drawing.Point(197, 217)
        Me.Starting_InventoryTextBox.Name = "Starting_InventoryTextBox"
        Me.Starting_InventoryTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Starting_InventoryTextBox.TabIndex = 6
        '
        'Ending_InventoryLabel
        '
        Ending_InventoryLabel.AutoSize = True
        Ending_InventoryLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Ending_InventoryLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Ending_InventoryLabel.Location = New System.Drawing.Point(59, 290)
        Ending_InventoryLabel.Name = "Ending_InventoryLabel"
        Ending_InventoryLabel.Size = New System.Drawing.Size(132, 20)
        Ending_InventoryLabel.TabIndex = 7
        Ending_InventoryLabel.Text = "Ending Inventory:"
        '
        'Ending_InventoryTextBox
        '
        Me.Ending_InventoryTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventory_ReportsBindingSource, "Ending Inventory", True))
        Me.Ending_InventoryTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ending_InventoryTextBox.Location = New System.Drawing.Point(197, 287)
        Me.Ending_InventoryTextBox.Name = "Ending_InventoryTextBox"
        Me.Ending_InventoryTextBox.Size = New System.Drawing.Size(100, 26)
        Me.Ending_InventoryTextBox.TabIndex = 8
        '
        'SalesLabel
        '
        SalesLabel.AutoSize = True
        SalesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SalesLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        SalesLabel.Location = New System.Drawing.Point(134, 364)
        SalesLabel.Name = "SalesLabel"
        SalesLabel.Size = New System.Drawing.Size(53, 20)
        SalesLabel.TabIndex = 9
        SalesLabel.Text = "Sales:"
        '
        'SalesTextBox
        '
        Me.SalesTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventory_ReportsBindingSource, "Sales", True))
        Me.SalesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SalesTextBox.Location = New System.Drawing.Point(197, 361)
        Me.SalesTextBox.Name = "SalesTextBox"
        Me.SalesTextBox.Size = New System.Drawing.Size(100, 26)
        Me.SalesTextBox.TabIndex = 10
        '
        'ThresholdsLabel
        '
        ThresholdsLabel.AutoSize = True
        ThresholdsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ThresholdsLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ThresholdsLabel.Location = New System.Drawing.Point(100, 437)
        ThresholdsLabel.Name = "ThresholdsLabel"
        ThresholdsLabel.Size = New System.Drawing.Size(91, 20)
        ThresholdsLabel.TabIndex = 11
        ThresholdsLabel.Text = "Thresholds:"
        '
        'ThresholdsTextBox
        '
        Me.ThresholdsTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventory_ReportsBindingSource, "Thresholds", True))
        Me.ThresholdsTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ThresholdsTextBox.Location = New System.Drawing.Point(197, 437)
        Me.ThresholdsTextBox.Name = "ThresholdsTextBox"
        Me.ThresholdsTextBox.Size = New System.Drawing.Size(100, 26)
        Me.ThresholdsTextBox.TabIndex = 12
        '
        'What_To_OrderLabel
        '
        What_To_OrderLabel.AutoSize = True
        What_To_OrderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        What_To_OrderLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        What_To_OrderLabel.Location = New System.Drawing.Point(74, 511)
        What_To_OrderLabel.Name = "What_To_OrderLabel"
        What_To_OrderLabel.Size = New System.Drawing.Size(117, 20)
        What_To_OrderLabel.TabIndex = 13
        What_To_OrderLabel.Text = "What To Order:"
        '
        'What_To_OrderTextBox
        '
        Me.What_To_OrderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Inventory_ReportsBindingSource, "What To Order", True))
        Me.What_To_OrderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.What_To_OrderTextBox.Location = New System.Drawing.Point(197, 508)
        Me.What_To_OrderTextBox.Name = "What_To_OrderTextBox"
        Me.What_To_OrderTextBox.Size = New System.Drawing.Size(100, 26)
        Me.What_To_OrderTextBox.TabIndex = 14
        '
        'Period_EndingLabel
        '
        Period_EndingLabel.AutoSize = True
        Period_EndingLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Period_EndingLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Period_EndingLabel.Location = New System.Drawing.Point(79, 578)
        Period_EndingLabel.Name = "Period_EndingLabel"
        Period_EndingLabel.Size = New System.Drawing.Size(112, 20)
        Period_EndingLabel.TabIndex = 15
        Period_EndingLabel.Text = "Period Ending:"
        '
        'Period_EndingDateTimePicker
        '
        Me.Period_EndingDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.Inventory_ReportsBindingSource, "Period Ending", True))
        Me.Period_EndingDateTimePicker.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Period_EndingDateTimePicker.Location = New System.Drawing.Point(197, 573)
        Me.Period_EndingDateTimePicker.Name = "Period_EndingDateTimePicker"
        Me.Period_EndingDateTimePicker.Size = New System.Drawing.Size(295, 26)
        Me.Period_EndingDateTimePicker.TabIndex = 16
        '
        'InventoryReportForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(578, 683)
        Me.Controls.Add(Period_EndingLabel)
        Me.Controls.Add(Me.Period_EndingDateTimePicker)
        Me.Controls.Add(What_To_OrderLabel)
        Me.Controls.Add(Me.What_To_OrderTextBox)
        Me.Controls.Add(ThresholdsLabel)
        Me.Controls.Add(Me.ThresholdsTextBox)
        Me.Controls.Add(SalesLabel)
        Me.Controls.Add(Me.SalesTextBox)
        Me.Controls.Add(Ending_InventoryLabel)
        Me.Controls.Add(Me.Ending_InventoryTextBox)
        Me.Controls.Add(Starting_InventoryLabel)
        Me.Controls.Add(Me.Starting_InventoryTextBox)
        Me.Controls.Add(ItemLabel)
        Me.Controls.Add(Me.ItemTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.Inventory_ReportsBindingNavigator)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "InventoryReportForm"
        Me.Text = "InventoryReportForm"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_ReportsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Inventory_ReportsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Inventory_ReportsBindingNavigator.ResumeLayout(False)
        Me.Inventory_ReportsBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents Inventory_ReportsBindingSource As BindingSource
    Friend WithEvents Inventory_ReportsTableAdapter As TailoringBusinessDataSetTableAdapters.Inventory_ReportsTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Inventory_ReportsBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents Inventory_ReportsBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents ItemTextBox As TextBox
    Friend WithEvents Starting_InventoryTextBox As TextBox
    Friend WithEvents Ending_InventoryTextBox As TextBox
    Friend WithEvents SalesTextBox As TextBox
    Friend WithEvents ThresholdsTextBox As TextBox
    Friend WithEvents What_To_OrderTextBox As TextBox
    Friend WithEvents Period_EndingDateTimePicker As DateTimePicker
End Class
