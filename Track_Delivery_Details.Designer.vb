<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Track_Delivery_Details
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtOrderID = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 38.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(550, 65)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Track Delivery Details"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(142, 134)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Order ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(142, 180)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Current Status"
        '
        'TxtOrderID
        '
        Me.TxtOrderID.Location = New System.Drawing.Point(386, 134)
        Me.TxtOrderID.Name = "TxtOrderID"
        Me.TxtOrderID.Size = New System.Drawing.Size(180, 20)
        Me.TxtOrderID.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Chocolate
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(146, 291)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Track"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Chocolate
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(324, 291)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(130, 47)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.Chocolate
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(498, 291)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(130, 47)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(386, 180)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(180, 21)
        Me.cmbStatus.TabIndex = 8
        '
        'Track_Delivery_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(767, 435)
        Me.Controls.Add(Me.cmbStatus)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TxtOrderID)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Track_Delivery_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Track_Delivery_Details"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtOrderID As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
End Class
