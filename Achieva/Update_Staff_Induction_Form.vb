Imports System
Imports System.Data
Imports System.Data.Sql
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Public Class Update_Staff_Induction_Form
    Dim dr As SqlDataReader
    Dim cmd As New SqlCommand
    Dim con As New SqlConnection("Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True")
    Dim i As New Integer

    Public Sub connection()
        con = New SqlConnection("Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True")
        con.Open()
    End Sub

    Private Sub BTN_Fetch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Fetch.Click
        connection()
        If (con.State = ConnectionState.Closed) Then
            con.Open()
        End If
        cmd.CommandText = "select * from Staff_Details where Emp_ID = '" & TB_Emp_ID.Text & "'"
        cmd.Connection = con
        dr = cmd.ExecuteReader()
        If (dr.Read()) Then
            DTP_Join_Date.Text = dr("Join_Date").ToString
            TB_Appointed_Position.Text = dr("Appointed_Position").ToString
            TB_First_Name.Text = dr("First_Name").ToString
            TB_Second_Name.Text = dr("Second_Name").ToString
            TB_Last_Name.Text = dr("Last_Name").ToString
            TB_Contact_No.Text = dr("Contact_No").ToString
            TB_Emp_Email.Text = dr("Emp_Email").ToString
            TB_Emp_Address.Text = dr("Emp_Address").ToString
            TB_Emp_Qualification.Text = dr("Emp_Qualification").ToString
            TB_Rel_1.Text = dr("Rel_1").ToString
            TB_Rel_1_Name.Text = dr("Rel_1_Name").ToString
            TB_Rel_1_Profession.Text = dr("Rel_1_Profession").ToString
            TB_Rel_1_MobileNo.Text = dr("Rel_1_MobileNo").ToString
            TB_Rel_2.Text = dr("Rel_2").ToString
            TB_Rel_2_Name.Text = dr("Rel_2_Name").ToString
            TB_Rel_2_Profession.Text = dr("Rel_2_Profession").ToString
            TB_Rel_2_MobileNo.Text = dr("Rel_2_MobileNo").ToString
            DTP_Job_Starting_Date.Text = dr("Job_Starting_Date").ToString
            TB_Mobile_Expanses.Text = dr("Mobile_Expanses").ToString
            TB_Emp_Salary.Text = dr("Emp_Salary").ToString
            TB_Travelling_Allowance.Text = dr("Travelling_Allowance").ToString
            TB_Incentive.Text = dr("Incentive").ToString
            TB_Dating_Allowance.Text = dr("Dating_Allowance").ToString
            TB_Other.Text = dr("Other").ToString
            TB_Duty_Timing.Text = dr("Duty_Timing").ToString
            TB_Special_Advantage.Text = dr("Special_Advantage").ToString
            TB_Job_Work.Text = dr("Job_Work").ToString

            DTP_Join_Date.Enabled = True
            TB_Appointed_Position.Enabled = True
            TB_First_Name.Enabled = True
            TB_Second_Name.Enabled = True
            TB_Last_Name.Enabled = True
            TB_Contact_No.Enabled = True
            TB_Emp_Email.Enabled = True
            TB_Emp_Address.Enabled = True
            TB_Emp_Qualification.Enabled = True
            TB_Rel_1.Enabled = True
            TB_Rel_1_Name.Enabled = True
            TB_Rel_1_Profession.Enabled = True
            TB_Rel_1_MobileNo.Enabled = True
            TB_Rel_2.Enabled = True
            TB_Rel_2_Name.Enabled = True
            TB_Rel_2_Profession.Enabled = True
            TB_Rel_2_MobileNo.Enabled = True
            DTP_Job_Starting_Date.Enabled = True
            TB_Mobile_Expanses.Enabled = True
            TB_Emp_Salary.Enabled = True
            TB_Travelling_Allowance.Enabled = True
            TB_Incentive.Enabled = True
            TB_Dating_Allowance.Enabled = True
            TB_Other.Enabled = True
            TB_Duty_Timing.Enabled = True
            TB_Special_Advantage.Enabled = True
            TB_Job_Work.Enabled = True
            BTN_Update.Enabled = False
            TB_Emp_ID.Enabled = False
            BTN_New.Enabled = True
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Information, "Fetch")

        End If
        dr.Close()
        con.Close()
    End Sub

    Private Sub TB_Emp_ID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_ID.TextChanged
        BTN_Fetch.Enabled = True
        'BTN_New.Enabled = True
    End Sub

    Private Sub BTN_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_New.Click
        DTP_Join_Date.Text = ""
        TB_Appointed_Position.Text = "Appointed Position"
        TB_First_Name.Text = "First Name"
        TB_Second_Name.Text = "Second Name"
        TB_Last_Name.Text = "Last Name"
        TB_Contact_No.Text = "Contact No"
        TB_Emp_Email.Text = "Emp Email"
        TB_Emp_Address.Text = "Emp Address"
        TB_Emp_Qualification.Text = "Emp Qualification"
        TB_Rel_1.Text = "Relation"
        TB_Rel_1_Name.Text = "Relation Name"
        TB_Rel_1_Profession.Text = "Relation Profession"
        TB_Rel_1_MobileNo.Text = "Relation MobileNo"
        TB_Rel_2.Text = "Relation"
        TB_Rel_2_Name.Text = "Relation Name"
        TB_Rel_2_Profession.Text = "Relation Profession"
        TB_Rel_2_MobileNo.Text = "Relation MobileNo"
        DTP_Job_Starting_Date.Text = ""
        TB_Mobile_Expanses.Text = "Mobile Expanses"
        TB_Emp_Salary.Text = "Decided Salary"
        TB_Travelling_Allowance.Text = "Travelling Allowance"
        TB_Incentive.Text = "Incentive"
        TB_Dating_Allowance.Text = "Dating Allowance"
        TB_Other.Text = "Other"
        TB_Duty_Timing.Text = "Duty Timing"
        TB_Special_Advantage.Text = "Any Special Advantage"
        TB_Job_Work.Text = "Job Work"

        TB_Emp_ID.Enabled = True
        DTP_Join_Date.Enabled = False
        TB_Appointed_Position.Enabled = False
        TB_First_Name.Enabled = False
        TB_Second_Name.Enabled = False
        TB_Last_Name.Enabled = False
        TB_Contact_No.Enabled = False
        TB_Emp_Email.Enabled = False
        TB_Emp_Address.Enabled = False
        TB_Emp_Qualification.Enabled = False
        TB_Rel_1.Enabled = False
        TB_Rel_1_Name.Enabled = False
        TB_Rel_1_Profession.Enabled = False
        TB_Rel_1_MobileNo.Enabled = False
        TB_Rel_2.Enabled = False
        TB_Rel_2_Name.Enabled = False
        TB_Rel_2_Profession.Enabled = False
        TB_Rel_2_MobileNo.Enabled = False
        DTP_Job_Starting_Date.Enabled = False
        TB_Mobile_Expanses.Enabled = False
        TB_Emp_Salary.Enabled = False
        TB_Travelling_Allowance.Enabled = False
        TB_Incentive.Enabled = False
        TB_Dating_Allowance.Enabled = False
        TB_Other.Enabled = False
        TB_Duty_Timing.Enabled = False
        TB_Special_Advantage.Enabled = False
        TB_Job_Work.Enabled = False
        BTN_Update.Enabled = False
        BTN_Fetch.Enabled = False
    End Sub

    Private Sub TB_First_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_First_Name.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Second_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Second_Name.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Last_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Last_Name.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Contact_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Contact_No.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Emp_Email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Email.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Emp_Address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Address.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Emp_Qualification_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Qualification.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_1_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1_Name.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_1_Profession_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1_Profession.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_1_MobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1_MobileNo.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_2_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2_Name.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_2_Profession_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2_Profession.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Rel_2_MobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2_MobileNo.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Mobile_Expanses_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Mobile_Expanses.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Emp_Salary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Salary.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Travelling_Allowance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Travelling_Allowance.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Incentive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Incentive.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Dating_Allowance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Dating_Allowance.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Other_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Other.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Duty_Timing_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Duty_Timing.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Special_Advantage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Special_Advantage.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Job_Work_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Job_Work.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub TB_Appointed_Position_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Appointed_Position.TextChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub DTP_Join_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_Join_Date.ValueChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub DTP_Job_Starting_Date_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DTP_Job_Starting_Date.ValueChanged
        BTN_Update.Enabled = True
    End Sub

    Private Sub BTN_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Update.Click
        con.ConnectionString = "Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True"
        con.Open()
        cmd.CommandText = "Update Staff_Details set Join_Date ='" & DTP_Join_Date.Text & "', Appointed_Position ='" & TB_Appointed_Position.Text & "', First_Name ='" & TB_First_Name.Text & "', Second_Name ='" & TB_Second_Name.Text & "', Last_Name ='" & TB_Last_Name.Text & "', Contact_No ='" & TB_Contact_No.Text & "', Emp_Email ='" & TB_Emp_Email.Text & "', Emp_Address ='" & TB_Emp_Address.Text & "', Emp_Qualification ='" & TB_Emp_Qualification.Text & "', Rel_1 ='" & TB_Rel_1.Text & "', Rel_1_Name ='" & TB_Rel_1_Name.Text & "', Rel_1_Profession ='" & TB_Rel_1_Profession.Text & "', Rel_1_MobileNo ='" & TB_Rel_1_MobileNo.Text & "', Rel_2 ='" & TB_Rel_2.Text & "', Rel_2_Name ='" & TB_Rel_2_Name.Text & "', Rel_2_Profession ='" & TB_Rel_2_Profession.Text & "', Rel_2_MobileNo ='" & TB_Rel_2_MobileNo.Text & "', Job_Starting_Date ='" & DTP_Job_Starting_Date.Text & "', Mobile_Expanses ='" & TB_Mobile_Expanses.Text & "', Emp_Salary ='" & TB_Emp_Salary.Text & "', Travelling_Allowance ='" & TB_Travelling_Allowance.Text & "', Incentive ='" & TB_Incentive.Text & "', Dating_Allowance ='" & TB_Dating_Allowance.Text & "', Other ='" & TB_Other.Text & "', Duty_Timing ='" & TB_Duty_Timing.Text & "', Special_Advantage ='" & TB_Special_Advantage.Text & "', Job_Work ='" & TB_Job_Work.Text & "' where  Emp_ID = '" & TB_Emp_ID.Text & "'"
        i = cmd.ExecuteNonQuery()

        If (i > 0) Then
            MessageBox.Show("Record Update Succesfull!")
        Else
            MsgBox("Record Not Found", MsgBoxStyle.Information, "Fetch")
        End If
        DTP_Join_Date.Text = ""
        TB_Appointed_Position.Text = "Appointed Position"
        TB_First_Name.Text = "First Name"
        TB_Second_Name.Text = "Second Name"
        TB_Last_Name.Text = "Last Name"
        TB_Contact_No.Text = "Contact No"
        TB_Emp_Email.Text = "Emp Email"
        TB_Emp_Address.Text = "Emp Address"
        TB_Emp_Qualification.Text = "Emp Qualification"
        TB_Rel_1.Text = "Relation"
        TB_Rel_1_Name.Text = "Relation Name"
        TB_Rel_1_Profession.Text = "Relation Profession"
        TB_Rel_1_MobileNo.Text = "Relation MobileNo"
        TB_Rel_2.Text = "Relation"
        TB_Rel_2_Name.Text = "Relation Name"
        TB_Rel_2_Profession.Text = "Relation Profession"
        TB_Rel_2_MobileNo.Text = "Relation MobileNo"
        DTP_Job_Starting_Date.Text = ""
        TB_Mobile_Expanses.Text = "Mobile Expanses"
        TB_Emp_Salary.Text = "Decided Salary"
        TB_Travelling_Allowance.Text = "Travelling Allowance"
        TB_Incentive.Text = "Incentive"
        TB_Dating_Allowance.Text = "Dating Allowance"
        TB_Other.Text = "Other"
        TB_Duty_Timing.Text = "Duty Timing"
        TB_Special_Advantage.Text = "Any Special Advantage"
        TB_Job_Work.Text = "Job Work"
        TB_Emp_ID.Enabled = True
        BTN_Fetch.Enabled = False
        BTN_Update.Enabled = False
        BTN_New.Enabled = False
    End Sub
End Class