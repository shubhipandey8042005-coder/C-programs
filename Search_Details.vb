Public Class Search_Details

    Private Sub Search_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginInDataSet.Add_Delivery_Details' table. You can move, or remove it, as needed.
        Me.Add_Delivery_DetailsTableAdapter.Fill(Me.LoginInDataSet.Add_Delivery_Details)

    End Sub
End Class