Imports System.Data.SqlClient
Public Class Additional_Work_Form
    Dim con As New SqlConnection
    Dim cmd As New SqlCommand
    Dim i As Integer = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        con.ConnectionString = "Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True"
        cmd.Connection = con
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
        cmd.CommandText = "Insert Into Assign_Task (Task_Date,Department,Employee,Task_Name,Daily_Routine)values('" & DTP_Current_Date.Text & "','" & CB_Department.Text & "','" & CB_Employee.Text & "','" & TB_Task_Name.Text & "','" & CB_Daily_Routine.Checked & "')"

        i = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("Record Save")
        Else
            MessageBox.Show("Record Not Save")
        End If
        con.Close()
    End Sub

End Class