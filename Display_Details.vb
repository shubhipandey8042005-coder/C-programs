Public Class Display_Details

    Private Sub Display_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginInDataSet.Add_Staff_Details' table. You can move, or remove it, as needed.
        Me.Add_Staff_DetailsTableAdapter.Fill(Me.LoginInDataSet.Add_Staff_Details)

    End Sub
End Class