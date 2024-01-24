<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendingMachine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendingMachine))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnClassic = New System.Windows.Forms.Button()
        Me.btnCherry = New System.Windows.Forms.Button()
        Me.btnOrange = New System.Windows.Forms.Button()
        Me.btnVanilla = New System.Windows.Forms.Button()
        Me.btnSprite = New System.Windows.Forms.Button()
        Me.btnWater = New System.Windows.Forms.Button()
        Me.lblDrinkCost = New System.Windows.Forms.Label()
        Me.btnDollar = New System.Windows.Forms.Button()
        Me.btnQuarter = New System.Windows.Forms.Button()
        Me.btnDime = New System.Windows.Forms.Button()
        Me.btnNickel = New System.Windows.Forms.Button()
        Me.lblTender = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.TextBoxTotal = New System.Windows.Forms.TextBox()
        Me.DirectorySearcher1 = New System.DirectoryServices.DirectorySearcher()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCancelGetChange = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 27)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(612, 805)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnClassic
        '
        Me.btnClassic.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnClassic.BackgroundImage = CType(resources.GetObject("btnClassic.BackgroundImage"), System.Drawing.Image)
        Me.btnClassic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnClassic.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClassic.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClassic.Location = New System.Drawing.Point(26, 208)
        Me.btnClassic.Name = "btnClassic"
        Me.btnClassic.Size = New System.Drawing.Size(77, 65)
        Me.btnClassic.TabIndex = 1
        Me.btnClassic.UseVisualStyleBackColor = False
        '
        'btnCherry
        '
        Me.btnCherry.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCherry.BackgroundImage = CType(resources.GetObject("btnCherry.BackgroundImage"), System.Drawing.Image)
        Me.btnCherry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCherry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCherry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCherry.Location = New System.Drawing.Point(26, 284)
        Me.btnCherry.Name = "btnCherry"
        Me.btnCherry.Size = New System.Drawing.Size(77, 65)
        Me.btnCherry.TabIndex = 2
        Me.btnCherry.UseVisualStyleBackColor = False
        '
        'btnOrange
        '
        Me.btnOrange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnOrange.BackgroundImage = CType(resources.GetObject("btnOrange.BackgroundImage"), System.Drawing.Image)
        Me.btnOrange.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnOrange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOrange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrange.Location = New System.Drawing.Point(26, 360)
        Me.btnOrange.Name = "btnOrange"
        Me.btnOrange.Size = New System.Drawing.Size(77, 65)
        Me.btnOrange.TabIndex = 3
        Me.btnOrange.UseVisualStyleBackColor = False
        '
        'btnVanilla
        '
        Me.btnVanilla.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnVanilla.BackgroundImage = CType(resources.GetObject("btnVanilla.BackgroundImage"), System.Drawing.Image)
        Me.btnVanilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVanilla.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVanilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVanilla.Location = New System.Drawing.Point(109, 209)
        Me.btnVanilla.Name = "btnVanilla"
        Me.btnVanilla.Size = New System.Drawing.Size(77, 65)
        Me.btnVanilla.TabIndex = 4
        Me.btnVanilla.UseVisualStyleBackColor = False
        '
        'btnSprite
        '
        Me.btnSprite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSprite.BackgroundImage = CType(resources.GetObject("btnSprite.BackgroundImage"), System.Drawing.Image)
        Me.btnSprite.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSprite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSprite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSprite.Location = New System.Drawing.Point(109, 285)
        Me.btnSprite.Name = "btnSprite"
        Me.btnSprite.Size = New System.Drawing.Size(77, 65)
        Me.btnSprite.TabIndex = 5
        Me.btnSprite.UseVisualStyleBackColor = False
        '
        'btnWater
        '
        Me.btnWater.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnWater.BackgroundImage = CType(resources.GetObject("btnWater.BackgroundImage"), System.Drawing.Image)
        Me.btnWater.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnWater.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWater.Location = New System.Drawing.Point(109, 361)
        Me.btnWater.Name = "btnWater"
        Me.btnWater.Size = New System.Drawing.Size(77, 65)
        Me.btnWater.TabIndex = 6
        Me.btnWater.UseVisualStyleBackColor = False
        '
        'lblDrinkCost
        '
        Me.lblDrinkCost.AutoSize = True
        Me.lblDrinkCost.BackColor = System.Drawing.Color.White
        Me.lblDrinkCost.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDrinkCost.Location = New System.Drawing.Point(28, 164)
        Me.lblDrinkCost.Name = "lblDrinkCost"
        Me.lblDrinkCost.Size = New System.Drawing.Size(133, 20)
        Me.lblDrinkCost.TabIndex = 7
        Me.lblDrinkCost.Text = "$1.25 Per Drink"
        '
        'btnDollar
        '
        Me.btnDollar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDollar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDollar.Location = New System.Drawing.Point(461, 209)
        Me.btnDollar.Name = "btnDollar"
        Me.btnDollar.Size = New System.Drawing.Size(139, 47)
        Me.btnDollar.TabIndex = 8
        Me.btnDollar.Text = "One Dollar $1.00"
        Me.btnDollar.UseVisualStyleBackColor = True
        '
        'btnQuarter
        '
        Me.btnQuarter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuarter.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuarter.Location = New System.Drawing.Point(461, 262)
        Me.btnQuarter.Name = "btnQuarter"
        Me.btnQuarter.Size = New System.Drawing.Size(139, 47)
        Me.btnQuarter.TabIndex = 9
        Me.btnQuarter.Text = "One Quarter $0.25"
        Me.btnQuarter.UseVisualStyleBackColor = True
        '
        'btnDime
        '
        Me.btnDime.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDime.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDime.Location = New System.Drawing.Point(461, 315)
        Me.btnDime.Name = "btnDime"
        Me.btnDime.Size = New System.Drawing.Size(139, 47)
        Me.btnDime.TabIndex = 10
        Me.btnDime.Text = "One Dime $0.10"
        Me.btnDime.UseVisualStyleBackColor = True
        '
        'btnNickel
        '
        Me.btnNickel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNickel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNickel.Location = New System.Drawing.Point(461, 368)
        Me.btnNickel.Name = "btnNickel"
        Me.btnNickel.Size = New System.Drawing.Size(139, 47)
        Me.btnNickel.TabIndex = 11
        Me.btnNickel.Text = "One Nickel $0.05"
        Me.btnNickel.UseVisualStyleBackColor = True
        '
        'lblTender
        '
        Me.lblTender.AutoSize = True
        Me.lblTender.BackColor = System.Drawing.Color.White
        Me.lblTender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTender.Location = New System.Drawing.Point(472, 164)
        Me.lblTender.Name = "lblTender"
        Me.lblTender.Size = New System.Drawing.Size(119, 20)
        Me.lblTender.TabIndex = 12
        Me.lblTender.Text = "Enter Tender:"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.BackColor = System.Drawing.Color.White
        Me.lblTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotal.Location = New System.Drawing.Point(476, 440)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(54, 20)
        Me.lblTotal.TabIndex = 13
        Me.lblTotal.Text = "Total:"
        '
        'TextBoxTotal
        '
        Me.TextBoxTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxTotal.Location = New System.Drawing.Point(476, 466)
        Me.TextBoxTotal.Name = "TextBoxTotal"
        Me.TextBoxTotal.Size = New System.Drawing.Size(110, 26)
        Me.TextBoxTotal.TabIndex = 14
        '
        'DirectorySearcher1
        '
        Me.DirectorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01")
        Me.DirectorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01")
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Red
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(528, 789)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(86, 32)
        Me.btnExit.TabIndex = 16
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCancelGetChange
        '
        Me.btnCancelGetChange.BackColor = System.Drawing.Color.Red
        Me.btnCancelGetChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancelGetChange.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelGetChange.Location = New System.Drawing.Point(461, 520)
        Me.btnCancelGetChange.Name = "btnCancelGetChange"
        Me.btnCancelGetChange.Size = New System.Drawing.Size(139, 47)
        Me.btnCancelGetChange.TabIndex = 17
        Me.btnCancelGetChange.Text = "Cancel and Get Change"
        Me.btnCancelGetChange.UseVisualStyleBackColor = False
        '
        'VendingMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(636, 844)
        Me.Controls.Add(Me.btnCancelGetChange)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.TextBoxTotal)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblTender)
        Me.Controls.Add(Me.btnNickel)
        Me.Controls.Add(Me.btnDime)
        Me.Controls.Add(Me.btnQuarter)
        Me.Controls.Add(Me.btnDollar)
        Me.Controls.Add(Me.lblDrinkCost)
        Me.Controls.Add(Me.btnWater)
        Me.Controls.Add(Me.btnSprite)
        Me.Controls.Add(Me.btnVanilla)
        Me.Controls.Add(Me.btnOrange)
        Me.Controls.Add(Me.btnCherry)
        Me.Controls.Add(Me.btnClassic)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "VendingMachine"
        Me.Text = "Vending Machine"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnClassic As Button
    Friend WithEvents btnCherry As Button
    Friend WithEvents btnOrange As Button
    Friend WithEvents btnVanilla As Button
    Friend WithEvents btnSprite As Button
    Friend WithEvents btnWater As Button
    Friend WithEvents lblDrinkCost As Label
    Friend WithEvents btnDollar As Button
    Friend WithEvents btnQuarter As Button
    Friend WithEvents btnDime As Button
    Friend WithEvents btnNickel As Button
    Friend WithEvents lblTender As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents TextBoxTotal As TextBox
    Friend WithEvents DirectorySearcher1 As DirectoryServices.DirectorySearcher
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCancelGetChange As Button
End Class
