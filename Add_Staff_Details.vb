Imports System.Data.OleDb
Public Class Add_Staff_Details


    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet

    Private Sub Add_Staff_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginIn.accdb"
        con = pro
        mycon.ConnectionString = con
        Call LoadData()
    End Sub
    Private Sub LoadData()
        cmd = New OleDbDataAdapter("select * from Add_Staff_Details", con)
        cmd.Fill(dt)
        'DataGridView1.DataSource = dt.DefaultView

    End Sub
  

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try

            mycon.Open()
            '  command = "INSERT INTO Add_Staff_Details VALUES (" & TxtStaffID.Text & ",'" & TxtFullName.Text & "','" & TxtGender.Text & "','" & TxtDOB.Value.ToString("yyyy-MM-dd") & "'," & TxtContactNo.Text & ",'" & TxtEmail.Text & "','" & TxtAddress.Text & "','" & TxtPosition.Text & "'," & TxtEmployeecode.Text & ",'" & TxtDepartment.Text & "','" & TxtJoiningDate.Value.ToString("yyyy-MM-dd") & "','" & TxtBranch.Text & "','" & TxtManagerName.Text & "','" & TxtEmploymentType.Text & "', '" & TxtWorkShiftTiming.Text & "'," & TxtSalary.Text & ",'" & TxtBankName.Text & "'," & TxtBankAccountNo.Text & ",'" & TxtIFSCcode.Text & "','" & TxtESICcode.Text & "','" & TxtPFcode.Text & "','" & TxtEmployeestatus.Text & "'," & TxtAadharcard.Text & ",'" & TxtPancard.Text & "','" & TxtEmergencyContactName.Text & "'," & TxtEmergencyContactNo.Text & ")"
            '  command = "INSERT INTO Add_Staff_Details VALUES (" & TxtStaffID.Text & ",'" & TxtFullName.Text & "','" & TxtGender.Text & "','" & DtpDOB.Value.ToString("yyyy-MM-dd") & "'," & TxtContactNo.Text & ",'" & TxtEmail.Text & "','" & TxtAddress.Text & "','" & TxtPosition.Text & "'," & TxtEmployeecode.Text & ",'" & TxtDepartment.Text & "','" & DtpJoiningDate.Value.ToString("yyyy-MM-dd") & "','" & TxtBranch.Text & "','" & TxtManagerName.Text & "','" & TxtEmploymentType.Text & "', '" & TxtWorkShiftTiming.Text & "'," & TxtSalary.Text & ",'" & TxtBankName.Text & "'," & TxtBankAccountNo.Text & ",'" & TxtIFSCcode.Text & "','" & TxtESICcode.Text & "','" & TxtPFcode.Text & "','" & TxtEmployeestatus.Text & "'," & TxtAadharcard.Text & ",'" & TxtPancard.Text & "','" & TxtEmergencyContactName.Text & "'," & TxtEmergencyContactNo.Text & ")"
            ' command = "INSERT INTO Add_Staff_Details VALUES (" & TxtStaffID.Text & ",'" & TxtFullName.Text & "','" & TxtGender.Text & "','" & Convert.ToDateTime(TxtDOB.Text).ToString("yyyy-MM-dd") & "'," & TxtContactNo.Text & ",'" & TxtEmail.Text & "','" & TxtAddress.Text & "','" & TxtPosition.Text & "'," & TxtEmployeecode.Text & ",'" & TxtDepartment.Text & "','" & Convert.ToDateTime(TxtJoiningDate.Text).ToString("yyyy-MM-dd") & "','" & TxtBranch.Text & "','" & TxtManagerName.Text & "','" & TxtEmploymentType.Text & "', '" & TxtWorkShiftTiming.Text & "'," & TxtSalary.Text & ",'" & TxtBankName.Text & "'," & TxtBankAccountNo.Text & ",'" & TxtIFSCcode.Text & "','" & TxtESICcode.Text & "','" & TxtPFcode.Text & "','" & TxtEmployeestatus.Text & "'," & TxtAadharcard.Text & ",'" & TxtPancard.Text & "','" & TxtEmergencyContactName.Text & "'," & TxtEmergencyContactNo.Text & ")"
            command = "INSERT INTO Add_Staff_Details VALUES (" &
TxtStaffID.Text & ",'" &
TxtFullName.Text.Replace("'", "''") & "','" &
TxtGender.Text.Replace("'", "''") & "','" &
DtpDOB.Value.ToString("yyyy-MM-dd") & "'," &
TxtContactNo.Text & ",'" &
TxtEmail.Text.Replace("'", "''") & "','" &
TxtAddress.Text.Replace("'", "''") & "','" &
TxtPosition.Text.Replace("'", "''") & "'," &
TxtEmployeecode.Text & ",'" &
TxtDepartment.Text.Replace("'", "''") & "','" &
DtpJoiningDate.Value.ToString("yyyy-MM-dd") & "','" &
TxtBranch.Text.Replace("'", "''") & "','" &
TxtManagerName.Text.Replace("'", "''") & "','" &
TxtEmploymentType.Text.Replace("'", "''") & "','" &
TxtWorkShiftTiming.Text.Replace("'", "''") & "'," &
TxtSalary.Text & ",'" &
TxtBankName.Text.Replace("'", "''") & "'," &
TxtBankAccountNo.Text & ",'" &
TxtIFSCcode.Text.Replace("'", "''") & "','" &
TxtESICcode.Text.Replace("'", "''") & "','" &
TxtPFcode.Text.Replace("'", "''") & "','" &
TxtEmployeestatus.Text.Replace("'", "''") & "'," &
TxtAadharcard.Text & ",'" &
TxtPancard.Text.Replace("'", "''") & "','" &
TxtEmergencyContactName.Text.Replace("'", "''") & "'," &
TxtEmergencyContactNo.Text & ")"

            cmdd = New OleDbCommand(command, mycon)
            ra = cmdd.ExecuteNonQuery
            MsgBox("Record inserted successfully" & ra)
            dt.Columns.Clear()
            dt.Rows.Clear()
            cmd.Fill(dt)
            ' DataGridView1.DataSource = dt.DefaultView
            mycon.Close()
        Catch ex As Exception
            MsgBox("Record not inserted " & ra)

        End Try
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

            TxtStaffID.Text = ""
            TxtFullName.Text = ""
            TxtGender.Text = ""
            DtpDOB.Value = DateTime.Now
            TxtContactNo.Text = ""
            TxtEmail.Text = ""
            TxtAddress.Text = ""
            TxtPosition.Text = ""
            TxtEmployeecode.Text = ""
            TxtDepartment.Text = ""
            DtpJoiningDate.Value = DateTime.Now
            TxtBranch.Text = ""
            TxtManagerName.Text = ""
            TxtEmploymentType.Text = ""
            TxtWorkShiftTiming.Text = ""
            TxtSalary.Text = ""
            TxtBankName.Text = ""
            TxtBankAccountNo.Text = ""
            TxtIFSCcode.Text = ""
            TxtESICcode.Text = ""
            TxtPFcode.Text = ""
            TxtEmployeestatus.Text = ""
            TxtAadharcard.Text = ""
            TxtPancard.Text = ""
            TxtEmergencyContactName.Text = ""
            TxtEmergencyContactNo.Text = ""
            dt.Columns.Clear()
            dt.Rows.Clear()
            ' DataGridView1.DataSource = Nothing

            MsgBox("All fields have been reset.")
        Catch ex As Exception
            MsgBox("An error occurred while resetting fields: " & ex.Message)
        End Try
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        End

    End Sub
End Class
