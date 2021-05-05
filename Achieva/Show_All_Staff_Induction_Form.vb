Public Class Show_All_Staff_Induction_Form

    Private Sub Show_All_Staff_Induction_Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Achieva_Demo_ApplicationDataSet.Staff_Details' table. You can move, or remove it, as needed.
        Me.Staff_DetailsTableAdapter.Fill(Me.Achieva_Demo_ApplicationDataSet.Staff_Details)

    End Sub
End Class