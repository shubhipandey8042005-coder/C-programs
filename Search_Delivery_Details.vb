Imports System.Data.OleDb
Public Class Search_Delivery_Details

    Dim pro As String
    Dim con As String
    Dim command As String
    Dim cmdd As OleDbCommand
    Dim mycon As OleDbConnection = New OleDbConnection
    Dim cmd As OleDbDataAdapter
    Dim dt As New DataTable
    Dim ra As Integer
    Dim ds As New DataSet
    Private Sub Search_Delivery_Details_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pro = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\LoginIn.accdb"
        con = pro
        mycon.ConnectionString = con
        Call LoadData()
    End Sub
    Private Sub LoadData()
        cmd = New OleDbDataAdapter("select * from Add_Delivery_Details ", con)
        cmd.Fill(dt)
        'DataGridView1.DataSource = dt.DefaultView

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        mycon.Open()
        dt.Columns.Clear()
        dt.Rows.Clear()
        cmd.Fill(dt)
        Search_Details.Show()
        Me.Hide()
        '  DataGridView1.DataSource = dt.DefaultView
        mycon.Close()
        
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub
End Class