<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblWelcomeMsg = New System.Windows.Forms.Label()
        Me.lblSubMsg = New System.Windows.Forms.Label()
        Me.lblNumOfNights = New System.Windows.Forms.Label()
        Me.entryDays = New System.Windows.Forms.TextBox()
        Me.lblCostMsg = New System.Windows.Forms.Label()
        Me.lblCost = New System.Windows.Forms.Label()
        Me.btnDisplayCost = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(337, 503)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblWelcomeMsg
        '
        Me.lblWelcomeMsg.AutoSize = True
        Me.lblWelcomeMsg.Font = New System.Drawing.Font("Sitka Text", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWelcomeMsg.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblWelcomeMsg.Location = New System.Drawing.Point(415, 67)
        Me.lblWelcomeMsg.Name = "lblWelcomeMsg"
        Me.lblWelcomeMsg.Size = New System.Drawing.Size(271, 47)
        Me.lblWelcomeMsg.TabIndex = 1
        Me.lblWelcomeMsg.Text = "Orlando AirBnB"
        '
        'lblSubMsg
        '
        Me.lblSubMsg.AutoSize = True
        Me.lblSubMsg.Font = New System.Drawing.Font("Sitka Text", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubMsg.Location = New System.Drawing.Point(441, 114)
        Me.lblSubMsg.Name = "lblSubMsg"
        Me.lblSubMsg.Size = New System.Drawing.Size(231, 30)
        Me.lblSubMsg.TabIndex = 2
        Me.lblSubMsg.Text = "Only $79.00 per night"
        '
        'lblNumOfNights
        '
        Me.lblNumOfNights.AutoSize = True
        Me.lblNumOfNights.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumOfNights.Location = New System.Drawing.Point(401, 215)
        Me.lblNumOfNights.Name = "lblNumOfNights"
        Me.lblNumOfNights.Size = New System.Drawing.Size(178, 28)
        Me.lblNumOfNights.TabIndex = 3
        Me.lblNumOfNights.Text = "Number of Nights:"
        '
        'entryDays
        '
        Me.entryDays.Location = New System.Drawing.Point(585, 223)
        Me.entryDays.Name = "entryDays"
        Me.entryDays.Size = New System.Drawing.Size(100, 20)
        Me.entryDays.TabIndex = 4
        '
        'lblCostMsg
        '
        Me.lblCostMsg.AutoSize = True
        Me.lblCostMsg.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCostMsg.Location = New System.Drawing.Point(401, 307)
        Me.lblCostMsg.Name = "lblCostMsg"
        Me.lblCostMsg.Size = New System.Drawing.Size(126, 28)
        Me.lblCostMsg.TabIndex = 5
        Me.lblCostMsg.Text = "Cost Of Stay:"
        '
        'lblCost
        '
        Me.lblCost.AutoSize = True
        Me.lblCost.Font = New System.Drawing.Font("Sitka Text", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCost.Location = New System.Drawing.Point(580, 307)
        Me.lblCost.Name = "lblCost"
        Me.lblCost.Size = New System.Drawing.Size(64, 28)
        Me.lblCost.TabIndex = 6
        Me.lblCost.Text = "$0.00"
        '
        'btnDisplayCost
        '
        Me.btnDisplayCost.BackColor = System.Drawing.Color.White
        Me.btnDisplayCost.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisplayCost.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisplayCost.ForeColor = System.Drawing.Color.Maroon
        Me.btnDisplayCost.Location = New System.Drawing.Point(365, 414)
        Me.btnDisplayCost.Name = "btnDisplayCost"
        Me.btnDisplayCost.Size = New System.Drawing.Size(109, 78)
        Me.btnDisplayCost.TabIndex = 7
        Me.btnDisplayCost.Text = "Display Cost"
        Me.btnDisplayCost.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.Maroon
        Me.btnClear.Location = New System.Drawing.Point(508, 414)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(104, 78)
        Me.btnClear.TabIndex = 8
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("Sitka Text", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Maroon
        Me.btnExit.Location = New System.Drawing.Point(645, 414)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 78)
        Me.btnExit.TabIndex = 9
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(761, 527)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnDisplayCost)
        Me.Controls.Add(Me.lblCost)
        Me.Controls.Add(Me.lblCostMsg)
        Me.Controls.Add(Me.entryDays)
        Me.Controls.Add(Me.lblNumOfNights)
        Me.Controls.Add(Me.lblSubMsg)
        Me.Controls.Add(Me.lblWelcomeMsg)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "AirBnB Reservations"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblWelcomeMsg As Label
    Friend WithEvents lblSubMsg As Label
    Friend WithEvents lblNumOfNights As Label
    Friend WithEvents entryDays As TextBox
    Friend WithEvents lblCostMsg As Label
    Friend WithEvents lblCost As Label
    Friend WithEvents btnDisplayCost As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
