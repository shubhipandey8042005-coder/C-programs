Imports System.Data.OleDb
Public Class Consignment_Details

    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet

    Private Sub Consignment_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginIn.accdb"
        con = pro
        mycon.ConnectionString = con
        Call LoadData()
    End Sub
    Private Sub LoadData()
        cmd = New OleDbDataAdapter("select * from Consignment_Details", con)
        cmd.Fill(dt)
        ' DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            mycon.Open()
            command = "INSERT INTO Consignment_Details " & _
                      "VALUES (" & TxtConsignmentNo.Text & ", " & _
                      "'" & DtpBookingDate.Value.ToString("yyyy-MM-dd") & "', " & _
                      "'" & TxtConsignmentType.Text & "', " & _
                      "'" & TxtWeight.Text & "', " & _
                      "'" & TxtLength.Text & "', " & _
                      "'" & TxtWidth.Text & "', " & _
                      "'" & TxtHeight.Text & "', " & _
                      TxtNoOfPackages.Text & ", " & _
                      "'" & TxtServiceType.Text & "', " & _
                      "'" & DtpPickupDate.Value.ToString("yyyy-MM-dd") & "', " & _
                      "'" & TxtSenderName.Text & "', " & _
                      TxtSenderContactNo.Text & ", " & _
                      "'" & TxtSenderEmail.Text & "', " & _
                      "'" & TxtPickupAddress.Text & "', " & _
                      TxtZipcode.Text & ", " & _
                      "'" & TxtReceiverName.Text & "', " & _
                      TxtReceiverContactNo.Text & ", " & _
                      "'" & TxtReceiverEmail.Text & "', " & _
                      "'" & TxtDeliveryAddress.Text & "', " & _
                      TxtPincode.Text & ", " & _
                      "'" & TxtCurrentStatus.Text & "', " & _
                      "'" & DtpEstimatedDeliveryDate.Value.ToString("yyyy-MM-dd") & "', " & _
                      "'" & TxtAssignedDeliveryAgent.Text & "', " & _
                      "'" & TxtVehicleNo.Text & "', " & _
                      TxtReferenceNo.Text & ", " & _
                      "'" & TxtConsignmentPriority.Text & "', " & _
                      "'" & TxtSource.Text & "', " & _
                      "'" & TxtDestination.Text & "')"
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
            TxtConsignmentNo.Text = ""
            DtpBookingDate.Value = DateTime.Now
            TxtConsignmentType.Text = ""
            TxtWeight.Text = ""
            TxtLength.Text = ""
            TxtWidth.Text = ""
            TxtHeight.Text = ""
            TxtNoOfPackages.Text = ""
            DtpPickupDate.Value = DateTime.Now
            TxtSenderName.Text = ""
            TxtSenderContactNo.Text = ""
            TxtSenderEmail.Text = ""
            TxtPickupAddress.Text = ""
            TxtZipcode.Text = ""
            TxtReceiverName.Text = ""
            TxtReceiverContactNo.Text = ""
            TxtReceiverEmail.Text = ""
            TxtDeliveryAddress.Text = ""
            TxtPincode.Text = ""
            TxtCurrentStatus.Text = ""
            DtpEstimatedDeliveryDate.Value = DateTime.Now
            TxtAssignedDeliveryAgent.Text = ""
            TxtVehicleNo.Text = ""
            TxtConsignmentPriority.Text = ""
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
            command = "DELETE FROM Consignment_Details WHERE " & _
                      "ConsignmentNo = " & TxtConsignmentNo.Text & " AND " & _
                      "BookingDate = '" & DtpBookingDate.Value.ToString("yyyy-MM-dd") & "' AND " & _
                      "ConsignmentType = '" & TxtConsignmentType.Text.Replace("'", "''") & "' AND " & _
                      "Weight = '" & TxtWeight.Text.Replace("'", "''") & "' AND " & _
                      "Length = '" & TxtLength.Text.Replace("'", "''") & "' AND " & _
                      "Width = '" & TxtWidth.Text.Replace("'", "''") & "' AND " & _
                      "Height = '" & TxtHeight.Text.Replace("'", "''") & "' AND " & _
                      "NoOfPackages = " & TxtNoOfPackages.Text & " AND " & _
                      "ServiceType = '" & TxtServiceType.Text.Replace("'", "''") & "' AND " & _
                      "PickUpDate = '" & DtpPickupDate.Value.ToString("yyyy-MM-dd") & "' AND " & _
                      "SenderName = '" & TxtSenderName.Text.Replace("'", "''") & "' AND " & _
                      "SenderContactNo = " & TxtSenderContactNo.Text & " AND " & _
                      "SenderEmail = '" & TxtSenderEmail.Text.Replace("'", "''") & "' AND " & _
                      "PickupAddress = '" & TxtPickupAddress.Text.Replace("'", "''") & "' AND " & _
                      "Zipcode = " & TxtZipcode.Text & " AND " & _
                      "ReceiverName = '" & TxtReceiverName.Text.Replace("'", "''") & "' AND " & _
                      "ReceiverContactNo = " & TxtReceiverContactNo.Text & " AND " & _
                      "ReceiverEmail = '" & TxtReceiverEmail.Text.Replace("'", "''") & "' AND " & _
                      "DeliveryAddress = '" & TxtDeliveryAddress.Text.Replace("'", "''") & "' AND " & _
                      "Pincode = " & TxtPincode.Text & " AND " & _
                      "CurrentStatus = '" & TxtCurrentStatus.Text.Replace("'", "''") & "' AND " & _
                      "EstimatedDeliveryDate = '" & DtpEstimatedDeliveryDate.Value.ToString("yyyy-MM-dd") & "' AND " & _
                      "AssignedDeliveryAgent = '" & TxtAssignedDeliveryAgent.Text.Replace("'", "''") & "' AND " & _
                      "VehicleNo = '" & TxtVehicleNo.Text.Replace("'", "''") & "' AND " & _
                      "ReferenceNo = " & TxtReferenceNo.Text & " AND " & _
                      "ConsignmentPriority = '" & TxtConsignmentPriority.Text.Replace("'", "''") & "' AND " & _
                      "Source = '" & TxtSource.Text.Replace("'", "''") & "' AND " & _
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