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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.inputInches = New System.Windows.Forms.TextBox()
        Me.inputMeters = New System.Windows.Forms.TextBox()
        Me.btnInchesToMeters = New System.Windows.Forms.Button()
        Me.btnMetersToFeet = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(113, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inches"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 128)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Meters"
        '
        'inputInches
        '
        Me.inputInches.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputInches.Location = New System.Drawing.Point(94, 79)
        Me.inputInches.Name = "inputInches"
        Me.inputInches.Size = New System.Drawing.Size(100, 26)
        Me.inputInches.TabIndex = 2
        '
        'inputMeters
        '
        Me.inputMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inputMeters.Location = New System.Drawing.Point(94, 170)
        Me.inputMeters.Name = "inputMeters"
        Me.inputMeters.Size = New System.Drawing.Size(100, 26)
        Me.inputMeters.TabIndex = 3
        '
        'btnInchesToMeters
        '
        Me.btnInchesToMeters.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInchesToMeters.Location = New System.Drawing.Point(72, 228)
        Me.btnInchesToMeters.Name = "btnInchesToMeters"
        Me.btnInchesToMeters.Size = New System.Drawing.Size(144, 41)
        Me.btnInchesToMeters.TabIndex = 4
        Me.btnInchesToMeters.Text = "Inches To Meters"
        Me.btnInchesToMeters.UseVisualStyleBackColor = True
        '
        'btnMetersToFeet
        '
        Me.btnMetersToFeet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMetersToFeet.Location = New System.Drawing.Point(72, 275)
        Me.btnMetersToFeet.Name = "btnMetersToFeet"
        Me.btnMetersToFeet.Size = New System.Drawing.Size(144, 41)
        Me.btnMetersToFeet.TabIndex = 5
        Me.btnMetersToFeet.Text = "Meters To Inches"
        Me.btnMetersToFeet.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(288, 331)
        Me.Controls.Add(Me.btnMetersToFeet)
        Me.Controls.Add(Me.btnInchesToMeters)
        Me.Controls.Add(Me.inputMeters)
        Me.Controls.Add(Me.inputInches)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Building Plans Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents inputInches As TextBox
    Friend WithEvents inputMeters As TextBox
    Friend WithEvents btnInchesToMeters As Button
    Friend WithEvents btnMetersToFeet As Button
End Class
