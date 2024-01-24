<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CommissionBindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.CommissionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TailoringBusinessDataSet = New CommissionReports.TailoringBusinessDataSet()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton6 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.CommissionBindingNavigator1SaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CommissionDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommissionTableAdapter = New CommissionReports.TailoringBusinessDataSetTableAdapters.CommissionTableAdapter()
        Me.TableAdapterManager = New CommissionReports.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBoxMonth = New System.Windows.Forms.TextBox()
        Me.btnFilter = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtBoxName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtBoxEmployeeID = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.CommissionBindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CommissionBindingNavigator1.SuspendLayout()
        CType(Me.CommissionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommissionDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommissionBindingNavigator1
        '
        Me.CommissionBindingNavigator1.AddNewItem = Me.ToolStripButton5
        Me.CommissionBindingNavigator1.BindingSource = Me.CommissionBindingSource
        Me.CommissionBindingNavigator1.CountItem = Me.ToolStripLabel1
        Me.CommissionBindingNavigator1.DeleteItem = Me.ToolStripButton6
        Me.CommissionBindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripSeparator1, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripSeparator3, Me.ToolStripButton5, Me.ToolStripButton6, Me.CommissionBindingNavigator1SaveItem})
        Me.CommissionBindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.CommissionBindingNavigator1.MoveFirstItem = Me.ToolStripButton1
        Me.CommissionBindingNavigator1.MoveLastItem = Me.ToolStripButton4
        Me.CommissionBindingNavigator1.MoveNextItem = Me.ToolStripButton3
        Me.CommissionBindingNavigator1.MovePreviousItem = Me.ToolStripButton2
        Me.CommissionBindingNavigator1.Name = "CommissionBindingNavigator1"
        Me.CommissionBindingNavigator1.PositionItem = Me.ToolStripTextBox1
        Me.CommissionBindingNavigator1.Size = New System.Drawing.Size(769, 25)
        Me.CommissionBindingNavigator1.TabIndex = 0
        Me.CommissionBindingNavigator1.Text = "BindingNavigator1"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Add new"
        '
        'CommissionBindingSource
        '
        Me.CommissionBindingSource.DataMember = "Commission"
        Me.CommissionBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(35, 22)
        Me.ToolStripLabel1.Text = "of {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton6
        '
        Me.ToolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton6.Image = CType(resources.GetObject("ToolStripButton6.Image"), System.Drawing.Image)
        Me.ToolStripButton6.Name = "ToolStripButton6"
        Me.ToolStripButton6.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton6.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton6.Text = "Delete"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Move first"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move previous"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move next"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'CommissionBindingNavigator1SaveItem
        '
        Me.CommissionBindingNavigator1SaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CommissionBindingNavigator1SaveItem.Image = CType(resources.GetObject("CommissionBindingNavigator1SaveItem.Image"), System.Drawing.Image)
        Me.CommissionBindingNavigator1SaveItem.Name = "CommissionBindingNavigator1SaveItem"
        Me.CommissionBindingNavigator1SaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CommissionBindingNavigator1SaveItem.Text = "Save Data"
        '
        'CommissionDataGridView
        '
        Me.CommissionDataGridView.AutoGenerateColumns = False
        Me.CommissionDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CommissionDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.CommissionDataGridView.DataSource = Me.CommissionBindingSource
        Me.CommissionDataGridView.Location = New System.Drawing.Point(13, 177)
        Me.CommissionDataGridView.Name = "CommissionDataGridView"
        Me.CommissionDataGridView.Size = New System.Drawing.Size(744, 467)
        Me.CommissionDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Amount_Sold"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Amount_Sold"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Employee_ID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Employee_ID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Employee_Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Employee_Name"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Commission_%"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Commission_%"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Total_Commission"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Total_Commission"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Month"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Month"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'CommissionTableAdapter
        '
        Me.CommissionTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CommissionTableAdapter = Me.CommissionTableAdapter
        Me.TableAdapterManager.UpdateOrder = CommissionReports.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 15)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Month:"
        '
        'txtBoxMonth
        '
        Me.txtBoxMonth.Location = New System.Drawing.Point(85, 59)
        Me.txtBoxMonth.Name = "txtBoxMonth"
        Me.txtBoxMonth.Size = New System.Drawing.Size(174, 20)
        Me.txtBoxMonth.TabIndex = 9
        '
        'btnFilter
        '
        Me.btnFilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFilter.Location = New System.Drawing.Point(303, 89)
        Me.btnFilter.Name = "btnFilter"
        Me.btnFilter.Size = New System.Drawing.Size(141, 71)
        Me.btnFilter.TabIndex = 10
        Me.btnFilter.Text = "Filter"
        Me.btnFilter.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(470, 44)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(287, 116)
        Me.Button3.TabIndex = 11
        Me.Button3.Text = "Generate Report"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 15)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Employee Name to put on Report:"
        '
        'txtBoxName
        '
        Me.txtBoxName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBoxName.Location = New System.Drawing.Point(219, 44)
        Me.txtBoxName.Name = "txtBoxName"
        Me.txtBoxName.Size = New System.Drawing.Size(225, 21)
        Me.txtBoxName.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Employee ID:"
        '
        'txtBoxEmployeeID
        '
        Me.txtBoxEmployeeID.Location = New System.Drawing.Point(85, 19)
        Me.txtBoxEmployeeID.Name = "txtBoxEmployeeID"
        Me.txtBoxEmployeeID.Size = New System.Drawing.Size(174, 20)
        Me.txtBoxEmployeeID.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtBoxEmployeeID)
        Me.GroupBox1.Controls.Add(Me.txtBoxMonth)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 81)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(265, 90)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filter Items"
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(769, 656)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.txtBoxName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnFilter)
        Me.Controls.Add(Me.CommissionDataGridView)
        Me.Controls.Add(Me.CommissionBindingNavigator1)
        Me.Name = "Form1"
        Me.Text = "Commission Filtering"
        CType(Me.CommissionBindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CommissionBindingNavigator1.ResumeLayout(False)
        Me.CommissionBindingNavigator1.PerformLayout()
        CType(Me.CommissionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommissionDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Friend WithEvents CommissionBindingNavigator As BindingNavigator
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
    Friend WithEvents CommissionBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents CommissionBindingSource As BindingSource
    Friend WithEvents CommissionTableAdapter As TailoringBusinessDataSetTableAdapters.CommissionTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CommissionBindingNavigator1 As BindingNavigator
    Friend WithEvents ToolStripButton5 As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripButton6 As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents ToolStripButton4 As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents CommissionBindingNavigator1SaveItem As ToolStripButton
    Friend WithEvents CommissionDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxMonth As TextBox
    Friend WithEvents btnFilter As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtBoxName As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtBoxEmployeeID As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class
