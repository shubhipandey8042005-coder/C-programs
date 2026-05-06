Public Class FrmWelcome

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.PerformStep()
        Label2.Text = "Loading......."
        If ProgressBar1.Value = 100 Then
            FrmLogin.Show()
            Me.Hide()
            Timer1.Enabled = False
        End If
    End Sub

   
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class