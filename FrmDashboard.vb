Public Class FrmDashboard

    Private Sub AddStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddStaffToolStripMenuItem.Click
        Add_Staff_Details.Show()
        Me.Hide()
    End Sub

    Private Sub ModifyStaffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModifyStaffToolStripMenuItem.Click
        Modify_Staff_Details.Show()
        Me.Hide()
    End Sub

    Private Sub DeliveryDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeliveryDetailsToolStripMenuItem.Click
        Add_Delivery_Details.Show()
    End Sub

    Private Sub ConsignmentDetailsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsignmentDetailsToolStripMenuItem.Click
        Consignment_Details.Show()
        Me.Hide()
    End Sub

    Private Sub SearchDeliveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchDeliveryToolStripMenuItem.Click
        Search_Delivery_Details.Show()
        Me.Hide()
    End Sub

    Private Sub TrackDeliveryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackDeliveryToolStripMenuItem.Click
        Track_Delivery_Details.Show()
        Me.Hide()
    End Sub

    Private Sub FrmDashboard_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class