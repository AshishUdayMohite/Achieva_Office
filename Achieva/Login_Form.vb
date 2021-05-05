Public Class Login_Form


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If CB_UserName.Text = "a" And TB_Password.Text = "a" Then
            Me.Hide()
            MessageBox.Show("Login Succesfuly")
            Achieva_MDI.Show()
        End If
        Label2.Text = "Invalid Username or Password"
    End Sub
End Class
