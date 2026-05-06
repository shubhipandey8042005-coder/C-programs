Imports System.Data.OleDb
Public Class FrmSignUp
  
    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet


  
    Private Sub FrmSignUp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginIn.accdb"
        con = pro
        mycon.ConnectionString = con
        Call LoadData()
    End Sub
    Private Sub LoadData()
        cmd = New OleDbDataAdapter("select * from LogIn ", con)
        cmd.Fill(dt)
        ' DataGridView1.DataSource = dt.DefaultView

    End Sub

    Private Sub BtnSignUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSignUp.Click
        Try
            mycon.Open()
            command = "insert into LogIn values('" & TxtFirstName.Text & "','" & TxtLastName.Text & "'," & TxtContactNumber.Text & ",'" & TxtEmail.Text & "','" & TxtUsername.Text & "'," & TxtPassword.Text & ")"
            cmdd = New OleDbCommand(command, mycon)
            ra = cmdd.ExecuteNonQuery
            MsgBox("Record inserted successfully" & ra)
            FrmLogin.Show()
            Me.Hide()
            dt.Columns.Clear()
            dt.Rows.Clear()
            cmd.Fill(dt)
            '    DataGridView1.DataSource = dt.DefaultView
            mycon.Close()
        Catch ex As Exception
            MsgBox("Record not inserted " & ra)

        End Try
    End Sub

    Private Sub LblBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblBack.Click
        FrmLogin.Show()
        Me.Hide()
    End Sub
End Class