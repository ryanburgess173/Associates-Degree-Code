<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainApplicationWindow
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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblGrossPay = New System.Windows.Forms.Label()
        Me.lblFICAtax = New System.Windows.Forms.Label()
        Me.lblFedTax = New System.Windows.Forms.Label()
        Me.lblStateTax = New System.Windows.Forms.Label()
        Me.lblNetPay = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.inputGross = New System.Windows.Forms.TextBox()
        Me.outputFICA = New System.Windows.Forms.TextBox()
        Me.outputFed = New System.Windows.Forms.TextBox()
        Me.outputState = New System.Windows.Forms.TextBox()
        Me.outputNet = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnReset.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnReset.Location = New System.Drawing.Point(81, 514)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(104, 56)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnExit.Location = New System.Drawing.Point(232, 514)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(104, 56)
        Me.btnExit.TabIndex = 1
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnCalc
        '
        Me.btnCalc.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btnCalc.Font = New System.Drawing.Font("MS Reference Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalc.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnCalc.Location = New System.Drawing.Point(127, 423)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(162, 69)
        Me.btnCalc.TabIndex = 2
        Me.btnCalc.Text = "Process Payroll"
        Me.btnCalc.UseVisualStyleBackColor = False
        '
        'lblGrossPay
        '
        Me.lblGrossPay.AutoSize = True
        Me.lblGrossPay.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGrossPay.ForeColor = System.Drawing.SystemColors.Info
        Me.lblGrossPay.Location = New System.Drawing.Point(44, 35)
        Me.lblGrossPay.Name = "lblGrossPay"
        Me.lblGrossPay.Size = New System.Drawing.Size(105, 24)
        Me.lblGrossPay.TabIndex = 3
        Me.lblGrossPay.Text = "Gross Pay"
        '
        'lblFICAtax
        '
        Me.lblFICAtax.AutoSize = True
        Me.lblFICAtax.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFICAtax.ForeColor = System.Drawing.SystemColors.Info
        Me.lblFICAtax.Location = New System.Drawing.Point(44, 137)
        Me.lblFICAtax.Name = "lblFICAtax"
        Me.lblFICAtax.Size = New System.Drawing.Size(96, 24)
        Me.lblFICAtax.TabIndex = 4
        Me.lblFICAtax.Text = "FICA Tax"
        '
        'lblFedTax
        '
        Me.lblFedTax.AutoSize = True
        Me.lblFedTax.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFedTax.ForeColor = System.Drawing.SystemColors.Info
        Me.lblFedTax.Location = New System.Drawing.Point(44, 209)
        Me.lblFedTax.Name = "lblFedTax"
        Me.lblFedTax.Size = New System.Drawing.Size(121, 24)
        Me.lblFedTax.TabIndex = 5
        Me.lblFedTax.Text = "Federal Tax"
        '
        'lblStateTax
        '
        Me.lblStateTax.AutoSize = True
        Me.lblStateTax.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStateTax.ForeColor = System.Drawing.SystemColors.Info
        Me.lblStateTax.Location = New System.Drawing.Point(44, 281)
        Me.lblStateTax.Name = "lblStateTax"
        Me.lblStateTax.Size = New System.Drawing.Size(100, 24)
        Me.lblStateTax.TabIndex = 6
        Me.lblStateTax.Text = "State Tax"
        '
        'lblNetPay
        '
        Me.lblNetPay.AutoSize = True
        Me.lblNetPay.Font = New System.Drawing.Font("MS Reference Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNetPay.ForeColor = System.Drawing.SystemColors.Info
        Me.lblNetPay.Location = New System.Drawing.Point(44, 353)
        Me.lblNetPay.Name = "lblNetPay"
        Me.lblNetPay.Size = New System.Drawing.Size(82, 24)
        Me.lblNetPay.TabIndex = 7
        Me.lblNetPay.Text = "Net Pay"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(-10, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(436, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "---------------------------------------------------------------------------------" &
    "--------------------------------------------------------------"
        '
        'inputGross
        '
        Me.inputGross.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputGross.Location = New System.Drawing.Point(207, 35)
        Me.inputGross.Name = "inputGross"
        Me.inputGross.Size = New System.Drawing.Size(166, 29)
        Me.inputGross.TabIndex = 9
        Me.inputGross.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'outputFICA
        '
        Me.outputFICA.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputFICA.Location = New System.Drawing.Point(207, 140)
        Me.outputFICA.Name = "outputFICA"
        Me.outputFICA.Size = New System.Drawing.Size(166, 29)
        Me.outputFICA.TabIndex = 10
        Me.outputFICA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'outputFed
        '
        Me.outputFed.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputFed.Location = New System.Drawing.Point(207, 212)
        Me.outputFed.Name = "outputFed"
        Me.outputFed.Size = New System.Drawing.Size(166, 29)
        Me.outputFed.TabIndex = 11
        Me.outputFed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'outputState
        '
        Me.outputState.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputState.Location = New System.Drawing.Point(207, 284)
        Me.outputState.Name = "outputState"
        Me.outputState.Size = New System.Drawing.Size(166, 29)
        Me.outputState.TabIndex = 12
        Me.outputState.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'outputNet
        '
        Me.outputNet.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.outputNet.Location = New System.Drawing.Point(207, 356)
        Me.outputNet.Name = "outputNet"
        Me.outputNet.Size = New System.Drawing.Size(166, 29)
        Me.outputNet.TabIndex = 13
        Me.outputNet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MainApplicationWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(40, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(417, 596)
        Me.Controls.Add(Me.outputNet)
        Me.Controls.Add(Me.outputState)
        Me.Controls.Add(Me.outputFed)
        Me.Controls.Add(Me.outputFICA)
        Me.Controls.Add(Me.inputGross)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNetPay)
        Me.Controls.Add(Me.lblStateTax)
        Me.Controls.Add(Me.lblFedTax)
        Me.Controls.Add(Me.lblFICAtax)
        Me.Controls.Add(Me.lblGrossPay)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Name = "MainApplicationWindow"
        Me.Text = "Payroll Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnCalc As Button
    Friend WithEvents lblGrossPay As Label
    Friend WithEvents lblFICAtax As Label
    Friend WithEvents lblFedTax As Label
    Friend WithEvents lblStateTax As Label
    Friend WithEvents lblNetPay As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents inputGross As TextBox
    Friend WithEvents outputFICA As TextBox
    Friend WithEvents outputFed As TextBox
    Friend WithEvents outputState As TextBox
    Friend WithEvents outputNet As TextBox
End Class
