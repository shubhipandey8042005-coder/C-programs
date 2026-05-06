Imports System.Data.OleDb
Public Class FrmLogin

    Private Sub Btnsignup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsignup.Click
        FrmSignUp.Show()
        Me.Hide()
    End Sub
    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet
  
    Private Sub FrmLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub Btnlogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnlogin.Click
        Dim username As String = TxtUsername.Text
        Dim password As String = TxtPassword.Text

        If String.IsNullOrWhiteSpace(username) OrElse String.IsNullOrWhiteSpace(password) Then
            MessageBox.Show("Please enter both username and password.")
            Return
        End If


        Dim query As String = "SELECT * FROM  LogIn WHERE Username = ? AND Password = ?"
        Dim cmd As New OleDbCommand(query, mycon)
        cmd.Parameters.AddWithValue("?", username)
        cmd.Parameters.AddWithValue("?", password)

        Try

            If mycon.State = ConnectionState.Closed Then
                mycon.Open()
            End If


            Dim reader As OleDbDataReader = cmd.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("Login Successful!")
                FrmDashboard.Show()
                Me.Hide()
            Else
                MessageBox.Show("Incorrect Username or Password.")
            End If
            reader.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally

            If mycon.State = ConnectionState.Open Then
                mycon.Close()
            End If
        End Try

    End Sub
End Class





