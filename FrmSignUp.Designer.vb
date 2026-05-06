<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSignUp
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TxtFirstName = New System.Windows.Forms.TextBox()
        Me.TxtLastName = New System.Windows.Forms.TextBox()
        Me.TxtContactNumber = New System.Windows.Forms.TextBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.BtnSignUp = New System.Windows.Forms.Button()
        Me.LblBack = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Tai Le", 30.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(284, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(169, 51)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Sign Up"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(176, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(180, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(108, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Last Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(127, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contact Number"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(176, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(112, 24)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Your Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(183, 218)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(105, 24)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(188, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(100, 24)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Password"
        '
        'TxtFirstName
        '
        Me.TxtFirstName.Location = New System.Drawing.Point(359, 65)
        Me.TxtFirstName.Name = "TxtFirstName"
        Me.TxtFirstName.Size = New System.Drawing.Size(221, 20)
        Me.TxtFirstName.TabIndex = 7
        '
        'TxtLastName
        '
        Me.TxtLastName.Location = New System.Drawing.Point(359, 103)
        Me.TxtLastName.Name = "TxtLastName"
        Me.TxtLastName.Size = New System.Drawing.Size(221, 20)
        Me.TxtLastName.TabIndex = 8
        '
        'TxtContactNumber
        '
        Me.TxtContactNumber.Location = New System.Drawing.Point(359, 141)
        Me.TxtContactNumber.Name = "TxtContactNumber"
        Me.TxtContactNumber.Size = New System.Drawing.Size(221, 20)
        Me.TxtContactNumber.TabIndex = 9
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(359, 179)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(221, 20)
        Me.TxtEmail.TabIndex = 10
        '
        'TxtUsername
        '
        Me.TxtUsername.Location = New System.Drawing.Point(359, 218)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(221, 20)
        Me.TxtUsername.TabIndex = 11
        '
        'TxtPassword
        '
        Me.TxtPassword.Location = New System.Drawing.Point(359, 256)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(221, 20)
        Me.TxtPassword.TabIndex = 12
        '
        'BtnSignUp
        '
        Me.BtnSignUp.BackColor = System.Drawing.Color.Chocolate
        Me.BtnSignUp.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSignUp.Location = New System.Drawing.Point(266, 295)
        Me.BtnSignUp.Name = "BtnSignUp"
        Me.BtnSignUp.Size = New System.Drawing.Size(176, 51)
        Me.BtnSignUp.TabIndex = 13
        Me.BtnSignUp.Text = "Sign Up"
        Me.BtnSignUp.UseVisualStyleBackColor = False
        '
        'LblBack
        '
        Me.LblBack.AutoSize = True
        Me.LblBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblBack.Location = New System.Drawing.Point(629, 354)
        Me.LblBack.Name = "LblBack"
        Me.LblBack.Size = New System.Drawing.Size(70, 29)
        Me.LblBack.TabIndex = 14
        Me.LblBack.Text = "Back"
        '
        'FrmSignUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(711, 392)
        Me.Controls.Add(Me.LblBack)
        Me.Controls.Add(Me.BtnSignUp)
        Me.Controls.Add(Me.TxtPassword)
        Me.Controls.Add(Me.TxtUsername)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.TxtContactNumber)
        Me.Controls.Add(Me.TxtLastName)
        Me.Controls.Add(Me.TxtFirstName)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmSignUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign Up"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TxtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents TxtLastName As System.Windows.Forms.TextBox
    Friend WithEvents TxtContactNumber As System.Windows.Forms.TextBox
    Friend WithEvents TxtEmail As System.Windows.Forms.TextBox
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents BtnSignUp As System.Windows.Forms.Button
    Friend WithEvents LblBack As System.Windows.Forms.Label
End Class
