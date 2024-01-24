<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InventoryRecordForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InventoryRecordForm))
        Dim Item_IDLabel As System.Windows.Forms.Label
        Dim Amount_On_HandLabel As System.Windows.Forms.Label
        Dim What_We_Should_HaveLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New InventoryManagement.TailoringBusinessDataSet()
        Me.InventoryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.InventoryTableAdapter = New InventoryManagement.TailoringBusinessDataSetTableAdapters.InventoryTableAdapter()
        Me.TableAdapterManager = New InventoryManagement.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.InventoryBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.InventoryBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Item_IDTextBox = New System.Windows.Forms.TextBox()
        Me.Amount_On_HandTextBox = New System.Windows.Forms.TextBox()
        Me.What_We_Should_HaveTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        Item_IDLabel = New System.Windows.Forms.Label()
        Amount_On_HandLabel = New System.Windows.Forms.Label()
        What_We_Should_HaveLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.InventoryBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'InventoryBindingSource
        '
        Me.InventoryBindingSource.DataMember = "Inventory"
        Me.InventoryBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'InventoryTableAdapter
        '
        Me.InventoryTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Inventory_ReportsTableAdapter = Nothing
        Me.TableAdapterManager.InventoryTableAdapter = Me.InventoryTableAdapter
        Me.TableAdapterManager.UpdateOrder = InventoryManagement.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'InventoryBindingNavigator
        '
        Me.InventoryBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.InventoryBindingNavigator.BindingSource = Me.InventoryBindingSource
        Me.InventoryBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.InventoryBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.InventoryBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.InventoryBindingNavigatorSaveItem})
        Me.InventoryBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.InventoryBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.InventoryBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.InventoryBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.InventoryBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.InventoryBindingNavigator.Name = "InventoryBindingNavigator"
        Me.InventoryBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.InventoryBindingNavigator.Size = New System.Drawing.Size(440, 25)
        Me.InventoryBindingNavigator.TabIndex = 0
        Me.InventoryBindingNavigator.Text = "BindingNavigator1"
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
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        IDLabel.Location = New System.Drawing.Point(219, 71)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(32, 24)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.IDTextBox.Location = New System.Drawing.Point(269, 68)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 29)
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
        'InventoryBindingNavigatorSaveItem
        '
        Me.InventoryBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.InventoryBindingNavigatorSaveItem.Image = CType(resources.GetObject("InventoryBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.InventoryBindingNavigatorSaveItem.Name = "InventoryBindingNavigatorSaveItem"
        Me.InventoryBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.InventoryBindingNavigatorSaveItem.Text = "Save Data"
        '
        'Item_IDLabel
        '
        Item_IDLabel.AutoSize = True
        Item_IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Item_IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Item_IDLabel.Location = New System.Drawing.Point(179, 127)
        Item_IDLabel.Name = "Item_IDLabel"
        Item_IDLabel.Size = New System.Drawing.Size(72, 24)
        Item_IDLabel.TabIndex = 3
        Item_IDLabel.Text = "Item ID:"
        '
        'Item_IDTextBox
        '
        Me.Item_IDTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Item_IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Item_ID", True))
        Me.Item_IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item_IDTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Item_IDTextBox.Location = New System.Drawing.Point(269, 124)
        Me.Item_IDTextBox.Name = "Item_IDTextBox"
        Me.Item_IDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Item_IDTextBox.TabIndex = 4
        '
        'Amount_On_HandLabel
        '
        Amount_On_HandLabel.AutoSize = True
        Amount_On_HandLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Amount_On_HandLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Amount_On_HandLabel.Location = New System.Drawing.Point(88, 190)
        Amount_On_HandLabel.Name = "Amount_On_HandLabel"
        Amount_On_HandLabel.Size = New System.Drawing.Size(163, 24)
        Amount_On_HandLabel.TabIndex = 5
        Amount_On_HandLabel.Text = "Amount On Hand:"
        '
        'Amount_On_HandTextBox
        '
        Me.Amount_On_HandTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Amount_On_HandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "Amount On Hand", True))
        Me.Amount_On_HandTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Amount_On_HandTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Amount_On_HandTextBox.Location = New System.Drawing.Point(269, 187)
        Me.Amount_On_HandTextBox.Name = "Amount_On_HandTextBox"
        Me.Amount_On_HandTextBox.Size = New System.Drawing.Size(100, 29)
        Me.Amount_On_HandTextBox.TabIndex = 6
        '
        'What_We_Should_HaveLabel
        '
        What_We_Should_HaveLabel.AutoSize = True
        What_We_Should_HaveLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        What_We_Should_HaveLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        What_We_Should_HaveLabel.Location = New System.Drawing.Point(45, 247)
        What_We_Should_HaveLabel.Name = "What_We_Should_HaveLabel"
        What_We_Should_HaveLabel.Size = New System.Drawing.Size(206, 24)
        What_We_Should_HaveLabel.TabIndex = 7
        What_We_Should_HaveLabel.Text = "What We Should Have:"
        '
        'What_We_Should_HaveTextBox
        '
        Me.What_We_Should_HaveTextBox.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.What_We_Should_HaveTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.InventoryBindingSource, "What We Should Have", True))
        Me.What_We_Should_HaveTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.What_We_Should_HaveTextBox.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.What_We_Should_HaveTextBox.Location = New System.Drawing.Point(269, 244)
        Me.What_We_Should_HaveTextBox.Name = "What_We_Should_HaveTextBox"
        Me.What_We_Should_HaveTextBox.Size = New System.Drawing.Size(100, 29)
        Me.What_We_Should_HaveTextBox.TabIndex = 8
        '
        'InventoryRecordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(440, 338)
        Me.Controls.Add(What_We_Should_HaveLabel)
        Me.Controls.Add(Me.What_We_Should_HaveTextBox)
        Me.Controls.Add(Amount_On_HandLabel)
        Me.Controls.Add(Me.Amount_On_HandTextBox)
        Me.Controls.Add(Item_IDLabel)
        Me.Controls.Add(Me.Item_IDTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.InventoryBindingNavigator)
        Me.Name = "InventoryRecordForm"
        Me.Text = "InventoryRecordForm"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.InventoryBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.InventoryBindingNavigator.ResumeLayout(False)
        Me.InventoryBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents InventoryBindingSource As BindingSource
    Friend WithEvents InventoryTableAdapter As TailoringBusinessDataSetTableAdapters.InventoryTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents InventoryBindingNavigator As BindingNavigator
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
    Friend WithEvents InventoryBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents Item_IDTextBox As TextBox
    Friend WithEvents Amount_On_HandTextBox As TextBox
    Friend WithEvents What_We_Should_HaveTextBox As TextBox
End Class
