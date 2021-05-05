Imports System.Data.SqlClient

Public Class New_Staff_Induction_Form
    Private Sub BTN_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTN_Save.Click
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim i As Integer = 0

        con.ConnectionString = "Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True"
        cmd.Connection = con

        con.Open()
        cmd.CommandText = "Insert Into Staff_Details (Emp_ID , Join_Date , Appointed_Position , First_Name , Second_Name , Last_Name , Contact_No , Emp_Email , Emp_Address , Emp_Qualification , Rel_1 , Rel_1_Name , Rel_1_Profession , Rel_1_MobileNo , Rel_2 , Rel_2_Name , Rel_2_Profession , Rel_2_MobileNo , Job_Starting_Date , Mobile_Expanses , Emp_Salary , Travelling_Allowance , Incentive , Dating_Allowance , Other , Duty_Timing , Special_Advantage , Job_Work , Department)values('" & TB_Emp_ID.Text & "','" & DTP_Join_Date.Text & "','" & TB_Appointed_Position.Text & "','" & TB_First_Name.Text & "','" & TB_Second_Name.Text & "','" & TB_Last_Name.Text & "','" & TB_Contact_No.Text & "','" & TB_Emp_Email.Text & "','" & TB_Emp_Address.Text & "','" & TB_Emp_Qualification.Text & "','" & TB_Rel_1.Text & "','" & TB_Rel_1_Name.Text & "','" & TB_Rel_1_Profession.Text & "','" & TB_Rel_1_MobileNo.Text & "','" & TB_Rel_2.Text & "','" & TB_Rel_2_Name.Text & "','" & TB_Rel_2_Profession.Text & "','" & TB_Rel_2_MobileNo.Text & "','" & DTP_Job_Starting_Date.Text & "','" & TB_Mobile_Expanses.Text & "','" & TB_Emp_Salary.Text & "','" & TB_Travelling_Allowance.Text & "','" & TB_Incentive.Text & "','" & TB_Dating_Allowance.Text & "','" & TB_Other.Text & "','" & TB_Duty_Timing.Text & "','" & TB_Special_Advantage.Text & "','" & TB_Job_Work.Text & "','" & CB_Department.Text & "')"

        i = cmd.ExecuteNonQuery()
        If (i > 0) Then
            MessageBox.Show("Record Saved")
        Else
            MessageBox.Show("Record Not Save")
        End If
    End Sub

    Private Sub TB_Emp_ID_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Emp_ID.MouseClick
        TB_Emp_ID.Text = ""
    End Sub

    Private Sub TB_Appointed_Position_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Appointed_Position.MouseClick
        TB_Appointed_Position.Text = ""
    End Sub

    Private Sub TB_First_Name_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_First_Name.MouseClick
        TB_First_Name.Text = ""
    End Sub

    Private Sub TB_Second_Name_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Second_Name.MouseClick
        TB_Second_Name.Text = ""
    End Sub

    Private Sub TB_Last_Name_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Last_Name.MouseClick
        TB_Last_Name.Text = ""
    End Sub

    Private Sub TB_Contact_No_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Contact_No.MouseClick
        TB_Contact_No.Text = ""
    End Sub

    Private Sub TB_Emp_Email_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Emp_Email.MouseClick
        TB_Emp_Email.Text = ""
    End Sub

    Private Sub TB_Emp_Address_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Emp_Address.MouseClick
        TB_Emp_Address.Text = ""
    End Sub

    Private Sub TB_Emp_Qualification_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Emp_Qualification.MouseClick
        TB_Emp_Qualification.Text = ""
    End Sub

    Private Sub TB_Rel_1_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_1.MouseClick
        TB_Rel_1.Text = ""
    End Sub

    Private Sub TB_Rel_1_Name_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_1_Name.MouseClick
        TB_Rel_1_Name.Text = ""
    End Sub

    Private Sub TB_Rel_1_Profession_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_1_Profession.MouseClick
        TB_Rel_1_Profession.Text = ""
    End Sub

    Private Sub TB_Rel_1_MobileNo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_1_MobileNo.MouseClick
        TB_Rel_1_MobileNo.Text = ""
    End Sub

    Private Sub TB_Rel_2_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_2.MouseClick
        TB_Rel_2.Text = ""
    End Sub

    Private Sub TB_Rel_2_Name_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_2_Name.MouseClick
        TB_Rel_2_Name.Text = ""
    End Sub

    Private Sub TB_Rel_2_Profession_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_2_Profession.MouseClick
        TB_Rel_2_Profession.Text = ""
    End Sub

    Private Sub TB_Rel_2_MobileNo_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Rel_2_MobileNo.MouseClick
        TB_Rel_2_MobileNo.Text = ""
    End Sub

    Private Sub TB_Mobile_Expanses_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Mobile_Expanses.MouseClick
        TB_Mobile_Expanses.Text = ""
    End Sub

    Private Sub TB_Emp_Salary_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Emp_Salary.MouseClick
        TB_Emp_Salary.Text = ""
    End Sub

    Private Sub TB_Travelling_Allowance_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Travelling_Allowance.MouseClick
        TB_Travelling_Allowance.Text = ""
    End Sub

    Private Sub TB_Incentive_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Incentive.MouseClick
        TB_Travelling_Allowance.Text = ""
    End Sub

    Private Sub TB_Dating_Allowance_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Dating_Allowance.MouseClick
        TB_Dating_Allowance.Text = ""
    End Sub

    Private Sub TB_Other_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Other.MouseClick
        TB_Other.Text = ""
    End Sub

    Private Sub TB_Duty_Timing_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Duty_Timing.MouseClick
        TB_Duty_Timing.Text = ""
    End Sub

    Private Sub TB_Special_Advantage_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Special_Advantage.MouseClick
        TB_Special_Advantage.Text = ""
    End Sub

    Private Sub TB_Job_Work_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TB_Job_Work.MouseClick
        TB_Job_Work.Text = ""
    End Sub

    Private Sub New_Staff_Induction_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection
        Dim cmd As New SqlCommand
        Dim a As Integer = 0

        con.ConnectionString = "Data Source=HOME-7\SQLEXPRESS2;Initial Catalog=Achieva_Demo_Application;Integrated Security=True"
        cmd.Connection = con

        con.Open()
        cmd = New SqlCommand("select MAX(Emp_ID)from Staff_Details ", con)

        a = cmd.ExecuteScalar
        con.Close()
        If (a > 0) Then
            a = a + 1
        Else
            a = 100
        End If
        TB_Emp_ID.Text = a
    End Sub

    Private Sub TB_Appointed_Position_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Appointed_Position.TextChanged
        TB_First_Name.Enabled = True
    End Sub

    Private Sub TB_First_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_First_Name.TextChanged
        TB_Second_Name.Enabled = True
    End Sub

    Private Sub TB_Second_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Second_Name.TextChanged
        TB_Last_Name.Enabled = True
    End Sub

    Private Sub TB_Last_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Last_Name.TextChanged
        TB_Contact_No.Enabled = True
    End Sub

    Private Sub TB_Contact_No_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Contact_No.TextChanged
        TB_Emp_Email.Enabled = True
    End Sub

    Private Sub TB_Emp_Email_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Email.TextChanged
        TB_Emp_Address.Enabled = True
    End Sub

    Private Sub TB_Emp_Address_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Address.TextChanged
        TB_Emp_Qualification.Enabled = True
    End Sub

    Private Sub TB_Emp_Qualification_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Qualification.TextChanged
        TB_Rel_1.Enabled = True
    End Sub

    Private Sub TB_Rel_1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1.TextChanged
        TB_Rel_1_Name.Enabled = True
    End Sub

    Private Sub TB_Rel_1_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1_Name.TextChanged
        TB_Rel_1_Profession.Enabled = True
    End Sub

    Private Sub TB_Rel_1_Profession_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1_Profession.TextChanged
        TB_Rel_1_MobileNo.Enabled = True
    End Sub

    Private Sub TB_Rel_1_MobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_1_MobileNo.TextChanged
        TB_Rel_2.Enabled = True
    End Sub

    Private Sub TB_Rel_2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2.TextChanged
        TB_Rel_2_Name.Enabled = True
    End Sub

    Private Sub TB_Rel_2_Name_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2_Name.TextChanged
        TB_Rel_2_Profession.Enabled = True
    End Sub

    Private Sub TB_Rel_2_Profession_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2_Profession.TextChanged
        TB_Rel_2_MobileNo.Enabled = True
    End Sub

    Private Sub TB_Rel_2_MobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Rel_2_MobileNo.TextChanged
        DTP_Job_Starting_Date.Enabled = True
        TB_Mobile_Expanses.Enabled = True
    End Sub

    Private Sub TB_Mobile_Expanses_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Mobile_Expanses.TextChanged
        TB_Emp_Salary.Enabled = True
    End Sub

    Private Sub TB_Emp_Salary_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Emp_Salary.TextChanged
        TB_Travelling_Allowance.Enabled = True
    End Sub

    Private Sub TB_Travelling_Allowance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Travelling_Allowance.TextChanged
        TB_Incentive.Enabled = True
    End Sub

    Private Sub TB_Incentive_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Incentive.TextChanged
        TB_Dating_Allowance.Enabled = True
    End Sub

    Private Sub TB_Dating_Allowance_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Dating_Allowance.TextChanged
        TB_Other.Enabled = True
    End Sub

    Private Sub TB_Other_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Other.TextChanged
        TB_Duty_Timing.Enabled = True
    End Sub

    Private Sub TB_Duty_Timing_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Duty_Timing.TextChanged
        TB_Special_Advantage.Enabled = True
    End Sub

    Private Sub TB_Special_Advantage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Special_Advantage.TextChanged
        TB_Job_Work.Enabled = True
    End Sub

    Private Sub TB_Job_Work_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TB_Job_Work.TextChanged
        BTN_Save.Enabled = True
    End Sub
End Class