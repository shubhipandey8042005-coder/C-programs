Public Class Track_Delivery_Details
    Private Sub Track_Delivery_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbStatus.Items.Add("Pending")
        cmbStatus.Items.Add("Shipped")
        cmbStatus.Items.Add("In Transit")
        cmbStatus.Items.Add("Delivered")
        cmbStatus.Items.Add("Cancelled")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim orderID As String = TxtOrderID.Text
        If orderID = "" Then
            MessageBox.Show("Please enter Order ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ' Randomly ek status assign karna (dummy logic)
            Dim statuses As String() = {"Pending", "Shipped", "In Transit", "Delivered", "Cancelled"}
            Dim rnd As New Random()
            cmbStatus.Text = statuses(rnd.Next(statuses.Length))
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TxtOrderID.Text = ""
        cmbStatus.SelectedIndex = -1
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        MessageBox.Show("Status changed to: " & cmbStatus.Text, "Status Update", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class



