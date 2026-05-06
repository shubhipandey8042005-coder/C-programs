Imports System.Data.OleDb
Public Class Modify_Staff_Details

    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet
    Private Sub Modify_Staff_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginIn.accdb"
        con = pro
        mycon.ConnectionString = con
        Call LoadData()
    End Sub
    Private Sub LoadData()
        cmd = New OleDbDataAdapter("select * from Add_Staff_Details ", con)
        cmd.Fill(dt)
        '  DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mycon.Open()
        dt.Columns.Clear()
        dt.Rows.Clear()
        cmd.Fill(dt)
        Display_Details.Show()
        Me.Hide()
        '  DataGridView1.DataSource = dt.DefaultView
        mycon.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Try
            mycon.Open()
            '  command = "DELETE FROM Add_Staff_Details WHERE " & "StaffID = " & TxtStaffID.Text & " AND " & "FullName = '" & TxtFullName.Text & "' AND " & "Gender = '" & TxtGender.Text & "' AND " & "DOB = '" & TxtDOB.Value.ToString("yyyy-MM-dd") & "' AND " & "ContactNo = " & TxtContactNo.Text & " AND " & "Email = '" & TxtEmail.Text & "' AND " & "Address = '" & TxtAddress.Text & "' AND " & "Position = '" & TxtPosition.Text & "' AND " & "EmployeeCode = " & TxtEmployeecode.Text & " AND " & "Department = '" & TxtDepartment.Text & "' AND " & "JoiningDate = '" & TxtJoiningDate.Value.ToString("yyyy-MM-dd") & "' AND " & "Branch = '" & TxtBranch.Text & "' AND " & "ManagerName = '" & TxtManagerName.Text & "' AND " & "EmploymentType = '" & TxtEmploymentType.Text & "' AND " & "WorkShiftTiming = '" & TxtWorkShiftTiming.Text & "' AND " & "Salary = " & TxtSalary.Text & " AND " & "BankName = '" & TxtBankName.Text & "' AND " & "BankAccountNo = " & TxtBankAccountNo.Text & " AND " & "IFSCCode = '" & TxtIFSCcode.Text & "' AND " & "ESICCode = '" & TxtESICcode.Text & "' AND " & "PFCode = '" & TxtPFcode.Text & "' AND " & "EmployeeStatus = '" & TxtEmployeestatus.Text & "' AND " & "AadharCard = " & TxtAadharcard.Text & " AND " & "Pancard = '" & TxtPancard.Text & "' AND " & "EmergencyContactName = '" & TxtEmergencyContactName.Text & "' AND " & "EmergencyContactNo = " & TxtEmergencyContactNo.Text & ""
            command = "DELETE FROM Add_Staff_Details WHERE " & "StaffID = " & TxtStaffID.Text & " AND " & "FullName = '" & TxtFullName.Text & "' AND " & "Gender = '" & TxtGender.Text & "' AND " & "DOB = '" & DtpDOB.Value.ToString("yyyy-MM-dd") & "' AND " & "ContactNo = " & TxtContactNo.Text & " AND " & "Email = '" & TxtEmail.Text & "' AND " & "Address = '" & TxtAddress.Text & "' AND " & "Position = '" & TxtPosition.Text & "' AND " & "EmployeeCode = " & TxtEmployeecode.Text & " AND " & "Department = '" & TxtDepartment.Text & "' AND " & "JoiningDate = '" & DtpJoiningDate.Value.ToString("yyyy-MM-dd") & "' AND " & "Branch = '" & TxtBranch.Text & "' AND " & "ManagerName = '" & TxtManagerName.Text & "' AND " & "EmploymentType = '" & TxtEmploymentType.Text & "' AND " & "WorkShiftTiming = '" & TxtWorkShiftTiming.Text & "' AND " & "Salary = " & TxtSalary.Text & " AND " & "BankName = '" & TxtBankName.Text & "' AND " & "BankAccountNo = " & TxtBankAccountNo.Text & " AND " & "IFSCCode = '" & TxtIFSCcode.Text & "' AND " & "ESICCode = '" & TxtESICcode.Text & "' AND " & "PFCode = '" & TxtPFcode.Text & "' AND " & "EmployeeStatus = '" & TxtEmployeestatus.Text & "' AND " & "AadharCard = " & TxtAadharcard.Text & " AND " & "Pancard = '" & TxtPancard.Text & "' AND " & "EmergencyContactName = '" & TxtEmergencyContactName.Text & "' AND " & "EmergencyContactNo = " & TxtEmergencyContactNo.Text & ""
            cmdd = New OleDbCommand(command, mycon)
            ra = cmdd.ExecuteNonQuery
            MsgBox("Record deleted " & ra)
            dt.Columns.Clear()
            dt.Rows.Clear()

            cmd.Fill(dt)
            '    DataGridView1.DataSource = dt.DefaultView
            mycon.Close()
        Catch ex As Exception
            MsgBox("Record not deleted " & ra)
            ' MsgBox(ex.ToString())
        End Try

    End Sub
  

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            mycon.Open()
            command = "UPDATE Add_Staff_Details SET " &
                      "FullName = '" & TxtFullName.Text & "', " &
                      "Gender = '" & TxtGender.Text & "', " &
                      "DOB = '" & DtpDOB.Value.ToString("yyyy-MM-dd") & "', " &
                      "ContactNo = " & TxtContactNo.Text & ", " &
                      "Email = '" & TxtEmail.Text & "', " &
                      "Address = '" & TxtAddress.Text & "', " &
                      "Position = '" & TxtPosition.Text & "', " &
                      "EmployeeCode = " & TxtEmployeecode.Text & ", " &
                      "Department = '" & TxtDepartment.Text & "', " &
                      "JoiningDate = '" & DtpJoiningDate.Value.ToString("yyyy-MM-dd") & "', " &
                      "Branch = '" & TxtBranch.Text & "', " &
                      "ManagerName = '" & TxtManagerName.Text & "', " &
                      "EmploymentType = '" & TxtEmploymentType.Text & "', " &
                      "WorkShiftTiming = '" & TxtWorkShiftTiming.Text & "', " &
                      "Salary = " & TxtSalary.Text & ", " &
                      "BankName = '" & TxtBankName.Text & "', " &
                      "BankAccountNo = " & TxtBankAccountNo.Text & ", " &
                      "IFSCCode = '" & TxtIFSCcode.Text & "', " &
                      "ESICCode = '" & TxtESICcode.Text & "', " &
                      "PFCode = '" & TxtPFcode.Text & "', " &
                      "EmployeeStatus = '" & TxtEmployeestatus.Text & "', " &
                      "AadharCard = " & TxtAadharcard.Text & ", " &
                      "Pancard = '" & TxtPancard.Text & "', " &
                      "EmergencyContactName = '" & TxtEmergencyContactName.Text & "', " &
                      "EmergencyContactNo = " & TxtEmergencyContactNo.Text & " " &
                      "WHERE StaffID = " & TxtStaffID.Text & " AND " &
                      "FullName = '" & TxtFullName.Text & "' AND " &
                      "Gender = '" & TxtGender.Text & "' AND " &
                      "DOB = '" & DtpDOB.Value.ToString("yyyy-MM-dd") & "' AND " &
                      "ContactNo = " & TxtContactNo.Text & " AND " &
                      "Email = '" & TxtEmail.Text & "' AND " &
                      "Address = '" & TxtAddress.Text & "' AND " &
                      "Position = '" & TxtPosition.Text & "' AND " &
                      "EmployeeCode = " & TxtEmployeecode.Text & " AND " &
                      "Department = '" & TxtDepartment.Text & "' AND " &
                      "JoiningDate = '" & DtpJoiningDate.Value.ToString("yyyy-MM-dd") & "' AND " &
                      "Branch = '" & TxtBranch.Text & "' AND " &
                      "ManagerName = '" & TxtManagerName.Text & "' AND " &
                      "EmploymentType = '" & TxtEmploymentType.Text & "' AND " &
                      "WorkShiftTiming = '" & TxtWorkShiftTiming.Text & "' AND " &
                      "Salary = " & TxtSalary.Text & " AND " &
                      "BankName = '" & TxtBankName.Text & "' AND " &
                      "BankAccountNo = " & TxtBankAccountNo.Text & " AND " &
                      "IFSCCode = '" & TxtIFSCcode.Text & "' AND " &
                      "ESICCode = '" & TxtESICcode.Text & "' AND " &
                      "PFCode = '" & TxtPFcode.Text & "' AND " &
                      "EmployeeStatus = '" & TxtEmployeestatus.Text & "' AND " &
                      "AadharCard = " & TxtAadharcard.Text & " AND " &
                      "Pancard = '" & TxtPancard.Text & "' AND " &
                      "EmergencyContactName = '" & TxtEmergencyContactName.Text & "' AND " &
                      "EmergencyContactNo = " & TxtEmergencyContactNo.Text

            cmdd = New OleDbCommand(command, mycon)
            ra = cmdd.ExecuteNonQuery
            MsgBox("Record updated successfully. Rows affected: " & ra)
            mycon.Close()
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            If mycon.State = ConnectionState.Open Then
                mycon.Close()
            End If
        End Try
 


    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End
    End Sub
End Class