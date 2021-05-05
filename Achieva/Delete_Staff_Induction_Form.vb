Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Delete_Staff_Induction_Form
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True")
    Dim i As New Integer
    Private Sub Delete_Staff_Induction_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con.Open()
        cmd.Connection = con
        cmd.CommandText = " Select * from Staff_Details "

        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)

        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        cmd.Connection = con
        cmd.CommandText = " Select * from Staff_Details where " & ComboBox1.Text & " LIKE '%" & TextBox21.Text & "%' "
        Dim da As New SqlDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        con.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ' con.ConnectionString = "Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True"
        con.Open()
        cmd.CommandText = "delete from Staff_Details  where  '" & ComboBox1.Text & "' = '" & TextBox21.Text & "'"
        i = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("Record deleted Succesfull!")
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Information, "Delete")

        End If
    End Sub

 
End Class