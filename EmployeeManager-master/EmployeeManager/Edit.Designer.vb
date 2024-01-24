<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Edit))
        Dim IDLabel As System.Windows.Forms.Label
        Dim NameLabel As System.Windows.Forms.Label
        Dim DepartmentLabel As System.Windows.Forms.Label
        Dim TitleLabel As System.Windows.Forms.Label
        Dim Address1Label As System.Windows.Forms.Label
        Dim CityLabel As System.Windows.Forms.Label
        Dim StateProvinceLabel As System.Windows.Forms.Label
        Dim ZIPPostalLabel As System.Windows.Forms.Label
        Dim CountryRegionLabel As System.Windows.Forms.Label
        Dim BusinessPhoneLabel As System.Windows.Forms.Label
        Dim HomePhoneLabel As System.Windows.Forms.Label
        Dim MobilePhoneLabel As System.Windows.Forms.Label
        Dim FaxNumberLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Me.TailoringBusinessDataSet = New EmployeeManager.TailoringBusinessDataSet()
        Me.EmployeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeesTableAdapter = New EmployeeManager.TailoringBusinessDataSetTableAdapters.EmployeesTableAdapter()
        Me.TableAdapterManager = New EmployeeManager.TailoringBusinessDataSetTableAdapters.TableAdapterManager()
        Me.EmployeesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EmployeesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.TitleTextBox = New System.Windows.Forms.TextBox()
        Me.Address1TextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StateProvinceTextBox = New System.Windows.Forms.TextBox()
        Me.ZIPPostalTextBox = New System.Windows.Forms.TextBox()
        Me.CountryRegionTextBox = New System.Windows.Forms.TextBox()
        Me.BusinessPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.HomePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.MobilePhoneTextBox = New System.Windows.Forms.TextBox()
        Me.FaxNumberTextBox = New System.Windows.Forms.TextBox()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        IDLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        DepartmentLabel = New System.Windows.Forms.Label()
        TitleLabel = New System.Windows.Forms.Label()
        Address1Label = New System.Windows.Forms.Label()
        CityLabel = New System.Windows.Forms.Label()
        StateProvinceLabel = New System.Windows.Forms.Label()
        ZIPPostalLabel = New System.Windows.Forms.Label()
        CountryRegionLabel = New System.Windows.Forms.Label()
        BusinessPhoneLabel = New System.Windows.Forms.Label()
        HomePhoneLabel = New System.Windows.Forms.Label()
        MobilePhoneLabel = New System.Windows.Forms.Label()
        FaxNumberLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeesBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'TailoringBusinessDataSet
        '
        Me.TailoringBusinessDataSet.DataSetName = "TailoringBusinessDataSet"
        Me.TailoringBusinessDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmployeesBindingSource
        '
        Me.EmployeesBindingSource.DataMember = "Employees"
        Me.EmployeesBindingSource.DataSource = Me.TailoringBusinessDataSet
        '
        'EmployeesTableAdapter
        '
        Me.EmployeesTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.EmployeesTableAdapter = Me.EmployeesTableAdapter
        Me.TableAdapterManager.UpdateOrder = EmployeeManager.TailoringBusinessDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'EmployeesBindingNavigator
        '
        Me.EmployeesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeesBindingNavigator.BindingSource = Me.EmployeesBindingSource
        Me.EmployeesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmployeesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeesBindingNavigatorSaveItem})
        Me.EmployeesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmployeesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmployeesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmployeesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmployeesBindingNavigator.Name = "EmployeesBindingNavigator"
        Me.EmployeesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmployeesBindingNavigator.Size = New System.Drawing.Size(972, 25)
        Me.EmployeesBindingNavigator.TabIndex = 0
        Me.EmployeesBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'EmployeesBindingNavigatorSaveItem
        '
        Me.EmployeesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeesBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeesBindingNavigatorSaveItem.Name = "EmployeesBindingNavigatorSaveItem"
        Me.EmployeesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'IDLabel
        '
        IDLabel.AutoSize = True
        IDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IDLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        IDLabel.Location = New System.Drawing.Point(100, 69)
        IDLabel.Name = "IDLabel"
        IDLabel.Size = New System.Drawing.Size(32, 24)
        IDLabel.TabIndex = 1
        IDLabel.Text = "ID:"
        '
        'IDTextBox
        '
        Me.IDTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.IDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "ID", True))
        Me.IDTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IDTextBox.ForeColor = System.Drawing.Color.White
        Me.IDTextBox.Location = New System.Drawing.Point(157, 69)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(100, 29)
        Me.IDTextBox.TabIndex = 2
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NameLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        NameLabel.Location = New System.Drawing.Point(73, 149)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(66, 24)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Name", True))
        Me.NameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameTextBox.ForeColor = System.Drawing.Color.White
        Me.NameTextBox.Location = New System.Drawing.Point(157, 146)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(321, 29)
        Me.NameTextBox.TabIndex = 4
        '
        'DepartmentLabel
        '
        DepartmentLabel.AutoSize = True
        DepartmentLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DepartmentLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        DepartmentLabel.Location = New System.Drawing.Point(32, 223)
        DepartmentLabel.Name = "DepartmentLabel"
        DepartmentLabel.Size = New System.Drawing.Size(112, 24)
        DepartmentLabel.TabIndex = 5
        DepartmentLabel.Text = "Department:"
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.DepartmentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Department", True))
        Me.DepartmentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepartmentTextBox.ForeColor = System.Drawing.Color.White
        Me.DepartmentTextBox.Location = New System.Drawing.Point(157, 220)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(321, 29)
        Me.DepartmentTextBox.TabIndex = 6
        '
        'TitleLabel
        '
        TitleLabel.AutoSize = True
        TitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        TitleLabel.Location = New System.Drawing.Point(89, 290)
        TitleLabel.Name = "TitleLabel"
        TitleLabel.Size = New System.Drawing.Size(50, 24)
        TitleLabel.TabIndex = 7
        TitleLabel.Text = "Title:"
        '
        'TitleTextBox
        '
        Me.TitleTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.TitleTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Title", True))
        Me.TitleTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitleTextBox.ForeColor = System.Drawing.Color.White
        Me.TitleTextBox.Location = New System.Drawing.Point(157, 287)
        Me.TitleTextBox.Name = "TitleTextBox"
        Me.TitleTextBox.Size = New System.Drawing.Size(321, 29)
        Me.TitleTextBox.TabIndex = 8
        '
        'Address1Label
        '
        Address1Label.AutoSize = True
        Address1Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Address1Label.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Address1Label.Location = New System.Drawing.Point(49, 366)
        Address1Label.Name = "Address1Label"
        Address1Label.Size = New System.Drawing.Size(95, 24)
        Address1Label.TabIndex = 9
        Address1Label.Text = "Address1:"
        '
        'Address1TextBox
        '
        Me.Address1TextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.Address1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Address1", True))
        Me.Address1TextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address1TextBox.ForeColor = System.Drawing.Color.White
        Me.Address1TextBox.Location = New System.Drawing.Point(157, 366)
        Me.Address1TextBox.Name = "Address1TextBox"
        Me.Address1TextBox.Size = New System.Drawing.Size(321, 29)
        Me.Address1TextBox.TabIndex = 10
        '
        'CityLabel
        '
        CityLabel.AutoSize = True
        CityLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CityLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CityLabel.Location = New System.Drawing.Point(100, 440)
        CityLabel.Name = "CityLabel"
        CityLabel.Size = New System.Drawing.Size(45, 24)
        CityLabel.TabIndex = 11
        CityLabel.Text = "City:"
        '
        'CityTextBox
        '
        Me.CityTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CityTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "City", True))
        Me.CityTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CityTextBox.ForeColor = System.Drawing.Color.White
        Me.CityTextBox.Location = New System.Drawing.Point(157, 437)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(321, 29)
        Me.CityTextBox.TabIndex = 12
        '
        'StateProvinceLabel
        '
        StateProvinceLabel.AutoSize = True
        StateProvinceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StateProvinceLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        StateProvinceLabel.Location = New System.Drawing.Point(9, 502)
        StateProvinceLabel.Name = "StateProvinceLabel"
        StateProvinceLabel.Size = New System.Drawing.Size(135, 24)
        StateProvinceLabel.TabIndex = 13
        StateProvinceLabel.Text = "State Province:"
        '
        'StateProvinceTextBox
        '
        Me.StateProvinceTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.StateProvinceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "StateProvince", True))
        Me.StateProvinceTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StateProvinceTextBox.ForeColor = System.Drawing.Color.White
        Me.StateProvinceTextBox.Location = New System.Drawing.Point(157, 502)
        Me.StateProvinceTextBox.Name = "StateProvinceTextBox"
        Me.StateProvinceTextBox.Size = New System.Drawing.Size(100, 29)
        Me.StateProvinceTextBox.TabIndex = 14
        '
        'ZIPPostalLabel
        '
        ZIPPostalLabel.AutoSize = True
        ZIPPostalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ZIPPostalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        ZIPPostalLabel.Location = New System.Drawing.Point(559, 74)
        ZIPPostalLabel.Name = "ZIPPostalLabel"
        ZIPPostalLabel.Size = New System.Drawing.Size(93, 24)
        ZIPPostalLabel.TabIndex = 15
        ZIPPostalLabel.Text = "ZIPPostal:"
        '
        'ZIPPostalTextBox
        '
        Me.ZIPPostalTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ZIPPostalTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "ZIPPostal", True))
        Me.ZIPPostalTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZIPPostalTextBox.ForeColor = System.Drawing.Color.White
        Me.ZIPPostalTextBox.Location = New System.Drawing.Point(661, 69)
        Me.ZIPPostalTextBox.Name = "ZIPPostalTextBox"
        Me.ZIPPostalTextBox.Size = New System.Drawing.Size(254, 29)
        Me.ZIPPostalTextBox.TabIndex = 16
        '
        'CountryRegionLabel
        '
        CountryRegionLabel.AutoSize = True
        CountryRegionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CountryRegionLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        CountryRegionLabel.Location = New System.Drawing.Point(509, 148)
        CountryRegionLabel.Name = "CountryRegionLabel"
        CountryRegionLabel.Size = New System.Drawing.Size(146, 24)
        CountryRegionLabel.TabIndex = 17
        CountryRegionLabel.Text = "Country Region:"
        '
        'CountryRegionTextBox
        '
        Me.CountryRegionTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.CountryRegionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "CountryRegion", True))
        Me.CountryRegionTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CountryRegionTextBox.ForeColor = System.Drawing.Color.White
        Me.CountryRegionTextBox.Location = New System.Drawing.Point(661, 143)
        Me.CountryRegionTextBox.Name = "CountryRegionTextBox"
        Me.CountryRegionTextBox.Size = New System.Drawing.Size(254, 29)
        Me.CountryRegionTextBox.TabIndex = 18
        '
        'BusinessPhoneLabel
        '
        BusinessPhoneLabel.AutoSize = True
        BusinessPhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BusinessPhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        BusinessPhoneLabel.Location = New System.Drawing.Point(503, 215)
        BusinessPhoneLabel.Name = "BusinessPhoneLabel"
        BusinessPhoneLabel.Size = New System.Drawing.Size(152, 24)
        BusinessPhoneLabel.TabIndex = 19
        BusinessPhoneLabel.Text = "Business Phone:"
        '
        'BusinessPhoneTextBox
        '
        Me.BusinessPhoneTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.BusinessPhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "BusinessPhone", True))
        Me.BusinessPhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BusinessPhoneTextBox.ForeColor = System.Drawing.Color.White
        Me.BusinessPhoneTextBox.Location = New System.Drawing.Point(661, 210)
        Me.BusinessPhoneTextBox.Name = "BusinessPhoneTextBox"
        Me.BusinessPhoneTextBox.Size = New System.Drawing.Size(254, 29)
        Me.BusinessPhoneTextBox.TabIndex = 20
        '
        'HomePhoneLabel
        '
        HomePhoneLabel.AutoSize = True
        HomePhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HomePhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        HomePhoneLabel.Location = New System.Drawing.Point(524, 295)
        HomePhoneLabel.Name = "HomePhoneLabel"
        HomePhoneLabel.Size = New System.Drawing.Size(128, 24)
        HomePhoneLabel.TabIndex = 21
        HomePhoneLabel.Text = "Home Phone:"
        '
        'HomePhoneTextBox
        '
        Me.HomePhoneTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.HomePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "HomePhone", True))
        Me.HomePhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HomePhoneTextBox.ForeColor = System.Drawing.Color.White
        Me.HomePhoneTextBox.Location = New System.Drawing.Point(661, 291)
        Me.HomePhoneTextBox.Name = "HomePhoneTextBox"
        Me.HomePhoneTextBox.Size = New System.Drawing.Size(254, 29)
        Me.HomePhoneTextBox.TabIndex = 22
        '
        'MobilePhoneLabel
        '
        MobilePhoneLabel.AutoSize = True
        MobilePhoneLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MobilePhoneLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        MobilePhoneLabel.Location = New System.Drawing.Point(522, 370)
        MobilePhoneLabel.Name = "MobilePhoneLabel"
        MobilePhoneLabel.Size = New System.Drawing.Size(133, 24)
        MobilePhoneLabel.TabIndex = 23
        MobilePhoneLabel.Text = "Mobile Phone:"
        '
        'MobilePhoneTextBox
        '
        Me.MobilePhoneTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.MobilePhoneTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "MobilePhone", True))
        Me.MobilePhoneTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MobilePhoneTextBox.ForeColor = System.Drawing.Color.White
        Me.MobilePhoneTextBox.Location = New System.Drawing.Point(661, 365)
        Me.MobilePhoneTextBox.Name = "MobilePhoneTextBox"
        Me.MobilePhoneTextBox.Size = New System.Drawing.Size(254, 29)
        Me.MobilePhoneTextBox.TabIndex = 24
        '
        'FaxNumberLabel
        '
        FaxNumberLabel.AutoSize = True
        FaxNumberLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FaxNumberLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        FaxNumberLabel.Location = New System.Drawing.Point(534, 442)
        FaxNumberLabel.Name = "FaxNumberLabel"
        FaxNumberLabel.Size = New System.Drawing.Size(121, 24)
        FaxNumberLabel.TabIndex = 25
        FaxNumberLabel.Text = "Fax Number:"
        '
        'FaxNumberTextBox
        '
        Me.FaxNumberTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.FaxNumberTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "FaxNumber", True))
        Me.FaxNumberTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FaxNumberTextBox.ForeColor = System.Drawing.Color.White
        Me.FaxNumberTextBox.Location = New System.Drawing.Point(661, 437)
        Me.FaxNumberTextBox.Name = "FaxNumberTextBox"
        Me.FaxNumberTextBox.Size = New System.Drawing.Size(254, 29)
        Me.FaxNumberTextBox.TabIndex = 26
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmailLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        EmailLabel.Location = New System.Drawing.Point(70, 578)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(62, 24)
        EmailLabel.TabIndex = 27
        EmailLabel.Text = "Email:"
        '
        'EmailTextBox
        '
        Me.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeesBindingSource, "Email", True))
        Me.EmailTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailTextBox.ForeColor = System.Drawing.Color.White
        Me.EmailTextBox.Location = New System.Drawing.Point(157, 573)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(321, 29)
        Me.EmailTextBox.TabIndex = 28
        '
        'Edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(972, 664)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(FaxNumberLabel)
        Me.Controls.Add(Me.FaxNumberTextBox)
        Me.Controls.Add(MobilePhoneLabel)
        Me.Controls.Add(Me.MobilePhoneTextBox)
        Me.Controls.Add(HomePhoneLabel)
        Me.Controls.Add(Me.HomePhoneTextBox)
        Me.Controls.Add(BusinessPhoneLabel)
        Me.Controls.Add(Me.BusinessPhoneTextBox)
        Me.Controls.Add(CountryRegionLabel)
        Me.Controls.Add(Me.CountryRegionTextBox)
        Me.Controls.Add(ZIPPostalLabel)
        Me.Controls.Add(Me.ZIPPostalTextBox)
        Me.Controls.Add(StateProvinceLabel)
        Me.Controls.Add(Me.StateProvinceTextBox)
        Me.Controls.Add(CityLabel)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Address1Label)
        Me.Controls.Add(Me.Address1TextBox)
        Me.Controls.Add(TitleLabel)
        Me.Controls.Add(Me.TitleTextBox)
        Me.Controls.Add(DepartmentLabel)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(NameLabel)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(IDLabel)
        Me.Controls.Add(Me.IDTextBox)
        Me.Controls.Add(Me.EmployeesBindingNavigator)
        Me.Name = "Edit"
        Me.Text = "Edit"
        CType(Me.TailoringBusinessDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeesBindingNavigator.ResumeLayout(False)
        Me.EmployeesBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TailoringBusinessDataSet As TailoringBusinessDataSet
    Friend WithEvents EmployeesBindingSource As BindingSource
    Friend WithEvents EmployeesTableAdapter As TailoringBusinessDataSetTableAdapters.EmployeesTableAdapter
    Friend WithEvents TableAdapterManager As TailoringBusinessDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmployeesBindingNavigator As BindingNavigator
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
    Friend WithEvents EmployeesBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents TitleTextBox As TextBox
    Friend WithEvents Address1TextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StateProvinceTextBox As TextBox
    Friend WithEvents ZIPPostalTextBox As TextBox
    Friend WithEvents CountryRegionTextBox As TextBox
    Friend WithEvents BusinessPhoneTextBox As TextBox
    Friend WithEvents HomePhoneTextBox As TextBox
    Friend WithEvents MobilePhoneTextBox As TextBox
    Friend WithEvents FaxNumberTextBox As TextBox
    Friend WithEvents EmailTextBox As TextBox
End Class
