Imports System.Data.OleDb
Public Class Add_Delivery_Details
    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet

    Private Sub Add_Delivery_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginIn.accdb"
        con = pro
        mycon.ConnectionString = con
        Call LoadData()
    End Sub
    Private Sub LoadData()
        cmd = New OleDbDataAdapter("select * from Add_Delivery_Details", con)
        cmd.Fill(dt)
        ' DataGridView1.DataSource = dt.DefaultView

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            mycon.Open()
            command = "INSERT INTO Add_Delivery_Details VALUES(" &
            TxtTrackingNo.Text & ", " &
            TxtOrderID.Text & ", '" &
            TxtShipmentType.Text.Replace("'", "''") & "', '" &
            TxtPackageWeight.Text.Replace("'", "''") & "', '" &
            TxtPackageLength.Text.Replace("'", "''") & "', '" &
            TxtPackageWidth.Text.Replace("'", "''") & "', '" &
            TxtPackageHeight.Text.Replace("'", "''") & "', '" &
            TxtSenderName.Text.Replace("'", "''") & "', " &
            TxtSenderContactNo.Text & ", '" &
            TxtSenderEmail.Text.Replace("'", "''") & "', '" &
            TxtPickupAddress.Text.Replace("'", "''") & "', '" &
            DtpPickUpDate.Value.ToString("yyyy-MM-dd") & "', '" &
            TxtReceiverName.Text.Replace("'", "''") & "', " &
            TxtReceiverContactNo.Text & ", '" &
            TxtReceiverEmail.Text.Replace("'", "''") & "', '" &
            DtpDeliveryDate.Value.ToString("yyyy-MM-dd") & "', " &
            TxtAlternateContactNo.Text & ", '" &
            TxtCurrentStatus.Text.Replace("'", "''") & "', '" &
            TxtDeliveryAgentName.Text.Replace("'", "''") & "', '" &
            TxtVehicleNo.Text.Replace("'", "''") & "', '" &
            TxtPaymentMode.Text.Replace("'", "''") & "', '" &
            TxtPaymentStatus.Text.Replace("'", "''") & "', " &
            TxtCODamount.Text & ", " &
            TxtInvoiceNo.Text & ", '" &
            TxtDeliveryPriority.Text.Replace("'", "''") & "', '" &
            TxtSource.Text.Replace("'", "''") & "', '" &
            TxtDestination.Text.Replace("'", "''") & "')"
            cmdd = New OleDbCommand(command, mycon)
            ra = cmdd.ExecuteNonQuery
            MsgBox("Record inserted successfully" & ra)
            dt.Columns.Clear()
            dt.Rows.Clear()
            cmd.Fill(dt)
            '     DataGridView1.DataSource = dt.DefaultView
            mycon.Close()
        Catch ex As Exception
            MsgBox("Record not inserted " & ra)

        End Try
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try

            TxtTrackingNo.Text = ""
            TxtOrderID.Text = ""
            TxtShipmentType.Text = ""
            TxtPackageWeight.Text = ""
            TxtPackageLength.Text = ""
            TxtPackageWidth.Text = ""
            TxtPackageHeight.Text = ""
            TxtSenderName.Text = ""
            TxtSenderContactNo.Text = ""
            TxtSenderEmail.Text = ""
            TxtPickupAddress.Text = ""
            DtpPickUpDate.Value = DateTime.Now
            TxtReceiverName.Text = ""
            TxtReceiverContactNo.Text = ""
            TxtReceiverEmail.Text = ""
            DtpDeliveryDate.Value = DateTime.Now
            TxtAlternateContactNo.Text = ""
            TxtCurrentStatus.Text = ""
            TxtDeliveryAgentName.Text = ""
            TxtVehicleNo.Text = ""
            TxtPaymentMode.Text = ""
            TxtPaymentStatus.Text = ""
            TxtCODamount.Text = ""
            TxtInvoiceNo.Text = ""
            TxtDeliveryPriority.Text = ""
            TxtSource.Text = ""
            TxtDestination.Text = ""    
            dt.Columns.Clear()
            dt.Rows.Clear()
            ' DataGridView1.DataSource = Nothing

            MsgBox("All fields have been reset.")
        Catch ex As Exception
            MsgBox("An error occurred while resetting fields: " & ex.Message)
        End Try
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            mycon.Open()
            command = "DELETE FROM Add_Delivery_Details WHERE " &
                      "TrackingNo = " & TxtTrackingNo.Text & " AND " &
                      "OrderID = " & TxtOrderID.Text & " AND " &
                      "ShipmentType = '" & TxtShipmentType.Text.Replace("'", "''") & "' AND " &
                      "PackageWeight = '" & TxtPackageWeight.Text.Replace("'", "''") & "' AND " &
                      "PackageLength = '" & TxtPackageLength.Text.Replace("'", "''") & "' AND " &
                      "PackageWidth = '" & TxtPackageWidth.Text.Replace("'", "''") & "' AND " &
                      "PackageHeight = '" & TxtPackageHeight.Text.Replace("'", "''") & "' AND " &
                      "SenderName = '" & TxtSenderName.Text.Replace("'", "''") & "' AND " &
                      "SenderContactNo = " & TxtSenderContactNo.Text & " AND " &
                      "SenderEmail = '" & TxtSenderEmail.Text.Replace("'", "''") & "' AND " &
                      "PickupAddress = '" & TxtPickupAddress.Text.Replace("'", "''") & "' AND " &
                      "PickUpDate = '" & DtpPickUpDate.Value.ToString("yyyy-MM-dd") & "' AND " &
                      "ReceiverName = '" & TxtReceiverName.Text.Replace("'", "''") & "' AND " &
                      "ReceiverContactNo = " & TxtReceiverContactNo.Text & " AND " &
                      "ReceiverEmail = '" & TxtReceiverEmail.Text.Replace("'", "''") & "' AND " &
                      "DeliveryDate = '" & DtpDeliveryDate.Value.ToString("yyyy-MM-dd") & "' AND " &
                      "AlternateContactNo = " & TxtAlternateContactNo.Text & " AND " &
                      "CurrentStatus = '" & TxtCurrentStatus.Text.Replace("'", "''") & "' AND " &
                      "DeliveryAgentName = '" & TxtDeliveryAgentName.Text.Replace("'", "''") & "' AND " &
                      "VehicleNo = '" & TxtVehicleNo.Text.Replace("'", "''") & "' AND " &
                      "PaymentMode = '" & TxtPaymentMode.Text.Replace("'", "''") & "' AND " &
                      "PaymentStatus = '" & TxtPaymentStatus.Text.Replace("'", "''") & "' AND " &
                      "CODamount = " & TxtCODamount.Text & " AND " &
                      "InvoiceNo = " & TxtInvoiceNo.Text & " AND " &
                      "DeliveryPriority = '" & TxtDeliveryPriority.Text.Replace("'", "''") & "' AND " &
                      "Source = '" & TxtSource.Text.Replace("'", "''") & "' AND " &
                      "Destination = '" & TxtDestination.Text.Replace("'", "''") & "'"

            cmdd = New OleDbCommand(command, mycon)
            ra = cmdd.ExecuteNonQuery
            MsgBox("Record deleted: " & ra)

            dt.Columns.Clear()
            dt.Rows.Clear()
            cmd.Fill(dt)
            mycon.Close()
        Catch ex As Exception
            MsgBox("Record not deleted")
            ' MsgBox(ex.ToString()) 'Uncomment to debug
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
End Class