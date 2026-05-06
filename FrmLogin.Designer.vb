<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Btnlogin = New System.Windows.Forms.Button()
        Me.TxtUsername = New System.Windows.Forms.TextBox()
        Me.TxtPassword = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Btnsignup = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(543, 50)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Courier Mangement System"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(109, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(162, 18)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Login into your account"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(105, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 24)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Password"
        '
        'Btnlogin
        '
        Me.Btnlogin.BackColor = System.Drawing.Color.Chocolate
        Me.Btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnlogin.Location = New System.Drawing.Point(311, 328)
        Me.Btnlogin.Name = "Btnlogin"
        Me.Btnlogin.Size = New System.Drawing.Size(365, 42)
        Me.Btnlogin.TabIndex = 4
        Me.Btnlogin.Text = "Log In"
        Me.Btnlogin.UseVisualStyleBackColor = False
        '
        'TxtUsername
        '
        Me.TxtUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtUsername.Location = New System.Drawing.Point(13, 76)
        Me.TxtUsername.Name = "TxtUsername"
        Me.TxtUsername.Size = New System.Drawing.Size(341, 29)
        Me.TxtUsername.TabIndex = 5
        '
        'TxtPassword
        '
        Me.TxtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtPassword.Location = New System.Drawing.Point(11, 189)
        Me.TxtPassword.Name = "TxtPassword"
        Me.TxtPassword.Size = New System.Drawing.Size(343, 29)
        Me.TxtPassword.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPassword)
        Me.GroupBox1.Controls.Add(Me.TxtUsername)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(311, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 247)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(4, 75)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(284, 363)
        Me.Panel1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(321, 373)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(141, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "I have no account"
        '
        'Btnsignup
        '
        Me.Btnsignup.BackColor = System.Drawing.Color.Chocolate
        Me.Btnsignup.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsignup.Location = New System.Drawing.Point(311, 394)
        Me.Btnsignup.Name = "Btnsignup"
        Me.Btnsignup.Size = New System.Drawing.Size(365, 42)
        Me.Btnsignup.TabIndex = 10
        Me.Btnsignup.Text = "Sign Up"
        Me.Btnsignup.UseVisualStyleBackColor = False
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(693, 450)
        Me.Controls.Add(Me.Btnsignup)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Btnlogin)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Btnlogin As System.Windows.Forms.Button
    Friend WithEvents TxtUsername As System.Windows.Forms.TextBox
    Friend WithEvents TxtPassword As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Btnsignup As System.Windows.Forms.Button
End Class
