Imports System.Windows.Forms

Public Class Achieva_MDI
    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click
        New_Staff_Induction_Form.MdiParent = Me
        New_Staff_Induction_Form.WindowState = FormWindowState.Maximized
        New_Staff_Induction_Form.Show()
    End Sub
    Private Sub WorkReportAttendanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkReportAttendanceToolStripMenuItem.Click
        Work_Book_Report_Form.MdiParent = Me
        Work_Book_Report_Form.WindowState = FormWindowState.Maximized
        Work_Book_Report_Form.Show()
    End Sub

    Private Sub MonthlyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonthlyToolStripMenuItem.Click
        Monthly_Attendence_Report_Form.MdiParent = Me
        Monthly_Attendence_Report_Form.WindowState = FormWindowState.Maximized
        Monthly_Attendence_Report_Form.Show()
    End Sub

    Private Sub DayliToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DayliToolStripMenuItem.Click
        Daily_Attaindance_Form.MdiParent = Me
        Daily_Attaindance_Form.WindowState = FormWindowState.Maximized
        Daily_Attaindance_Form.Show()
    End Sub

    Private Sub AdditionalWorkToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdditionalWorkToolStripMenuItem.Click
        Additional_Work_Form.MdiParent = Me
        Additional_Work_Form.WindowState = FormWindowState.Maximized
        Additional_Work_Form.Show()
    End Sub

    Private Sub ProgressReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressReportToolStripMenuItem.Click
        Progress_Report_Form.MdiParent = Me
        Progress_Report_Form.WindowState = FormWindowState.Maximized
        Progress_Report_Form.Show()
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        Update_Staff_Induction_Form.MdiParent = Me
        Update_Staff_Induction_Form.WindowState = FormWindowState.Maximized
        Update_Staff_Induction_Form.Show()
    End Sub

    Private Sub DeleteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteToolStripMenuItem.Click
        Delete_Staff_Induction_Form.MdiParent = Me
        Delete_Staff_Induction_Form.WindowState = FormWindowState.Maximized
        Delete_Staff_Induction_Form.Show()
    End Sub

    Private Sub ShowToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShowToolStripMenuItem.Click
        Show_All_Staff_Induction_Form.MdiParent = Me
        Show_All_Staff_Induction_Form.WindowState = FormWindowState.Maximized
        Show_All_Staff_Induction_Form.Show()
    End Sub

    Private Sub WorkBookToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkBookToolStripMenuItem.Click
        Work_Book_Form.MdiParent = Me
        Work_Book_Form.WindowState = FormWindowState.Maximized
        Work_Book_Form.Show()
    End Sub
End Class
