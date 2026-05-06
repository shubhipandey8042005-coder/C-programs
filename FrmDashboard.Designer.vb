<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDashboard))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AddStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModifyStaffToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeliveryDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsignmentDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TrackDeliveryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddStaffToolStripMenuItem, Me.ModifyStaffToolStripMenuItem, Me.DeliveryDetailsToolStripMenuItem, Me.ConsignmentDetailsToolStripMenuItem, Me.SearchDeliveryToolStripMenuItem, Me.TrackDeliveryToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(759, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AddStaffToolStripMenuItem
        '
        Me.AddStaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.AddStaffToolStripMenuItem.Name = "AddStaffToolStripMenuItem"
        Me.AddStaffToolStripMenuItem.Size = New System.Drawing.Size(88, 24)
        Me.AddStaffToolStripMenuItem.Text = "Add Staff"
        '
        'ModifyStaffToolStripMenuItem
        '
        Me.ModifyStaffToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ModifyStaffToolStripMenuItem.Name = "ModifyStaffToolStripMenuItem"
        Me.ModifyStaffToolStripMenuItem.Size = New System.Drawing.Size(109, 24)
        Me.ModifyStaffToolStripMenuItem.Text = "Modify Staff"
        '
        'DeliveryDetailsToolStripMenuItem
        '
        Me.DeliveryDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.DeliveryDetailsToolStripMenuItem.Name = "DeliveryDetailsToolStripMenuItem"
        Me.DeliveryDetailsToolStripMenuItem.Size = New System.Drawing.Size(131, 24)
        Me.DeliveryDetailsToolStripMenuItem.Text = "Delivery Details"
        '
        'ConsignmentDetailsToolStripMenuItem
        '
        Me.ConsignmentDetailsToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.ConsignmentDetailsToolStripMenuItem.Name = "ConsignmentDetailsToolStripMenuItem"
        Me.ConsignmentDetailsToolStripMenuItem.Size = New System.Drawing.Size(166, 24)
        Me.ConsignmentDetailsToolStripMenuItem.Text = "Consignment Details"
        '
        'SearchDeliveryToolStripMenuItem
        '
        Me.SearchDeliveryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.SearchDeliveryToolStripMenuItem.Name = "SearchDeliveryToolStripMenuItem"
        Me.SearchDeliveryToolStripMenuItem.Size = New System.Drawing.Size(129, 24)
        Me.SearchDeliveryToolStripMenuItem.Text = "Search Delivery"
        '
        'TrackDeliveryToolStripMenuItem
        '
        Me.TrackDeliveryToolStripMenuItem.BackColor = System.Drawing.Color.SandyBrown
        Me.TrackDeliveryToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 11.0!, System.Drawing.FontStyle.Bold)
        Me.TrackDeliveryToolStripMenuItem.Name = "TrackDeliveryToolStripMenuItem"
        Me.TrackDeliveryToolStripMenuItem.Size = New System.Drawing.Size(120, 24)
        Me.TrackDeliveryToolStripMenuItem.Text = "Track Delivery"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Location = New System.Drawing.Point(0, 31)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(759, 369)
        Me.Panel1.TabIndex = 2
        '
        'FrmDashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(759, 402)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmDashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmDashboard"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AddStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ModifyStaffToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeliveryDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsignmentDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchDeliveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TrackDeliveryToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
