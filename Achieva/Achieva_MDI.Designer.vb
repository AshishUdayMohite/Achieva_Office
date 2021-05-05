<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Achieva_MDI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub


    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.StaffInductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkBookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WorkReportAttendanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyAttendenceReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DayliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdditionalWorkToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgressReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StaffInductionToolStripMenuItem, Me.WorkBookToolStripMenuItem, Me.WorkReportAttendanceToolStripMenuItem, Me.DailyAttendenceReportToolStripMenuItem, Me.AdditionalWorkToolStripMenuItem, Me.ProgressReportToolStripMenuItem})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(1164, 30)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'StaffInductionToolStripMenuItem
        '
        Me.StaffInductionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.ShowToolStripMenuItem})
        Me.StaffInductionToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StaffInductionToolStripMenuItem.Name = "StaffInductionToolStripMenuItem"
        Me.StaffInductionToolStripMenuItem.Size = New System.Drawing.Size(142, 26)
        Me.StaffInductionToolStripMenuItem.Text = "Staff Induction"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.NewToolStripMenuItem.Text = "New"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'ShowToolStripMenuItem
        '
        Me.ShowToolStripMenuItem.Name = "ShowToolStripMenuItem"
        Me.ShowToolStripMenuItem.Size = New System.Drawing.Size(152, 26)
        Me.ShowToolStripMenuItem.Text = "Show All"
        '
        'WorkBookToolStripMenuItem
        '
        Me.WorkBookToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WorkBookToolStripMenuItem.Name = "WorkBookToolStripMenuItem"
        Me.WorkBookToolStripMenuItem.Size = New System.Drawing.Size(120, 26)
        Me.WorkBookToolStripMenuItem.Text = "Work Book "
        '
        'WorkReportAttendanceToolStripMenuItem
        '
        Me.WorkReportAttendanceToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.WorkReportAttendanceToolStripMenuItem.Name = "WorkReportAttendanceToolStripMenuItem"
        Me.WorkReportAttendanceToolStripMenuItem.Size = New System.Drawing.Size(181, 26)
        Me.WorkReportAttendanceToolStripMenuItem.Text = "Work Book Report "
        '
        'DailyAttendenceReportToolStripMenuItem
        '
        Me.DailyAttendenceReportToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonthlyToolStripMenuItem, Me.DayliToolStripMenuItem})
        Me.DailyAttendenceReportToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.DailyAttendenceReportToolStripMenuItem.Name = "DailyAttendenceReportToolStripMenuItem"
        Me.DailyAttendenceReportToolStripMenuItem.Size = New System.Drawing.Size(180, 26)
        Me.DailyAttendenceReportToolStripMenuItem.Text = "Attaindance Report"
        '
        'MonthlyToolStripMenuItem
        '
        Me.MonthlyToolStripMenuItem.Name = "MonthlyToolStripMenuItem"
        Me.MonthlyToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.MonthlyToolStripMenuItem.Text = "Month"
        '
        'DayliToolStripMenuItem
        '
        Me.DayliToolStripMenuItem.Name = "DayliToolStripMenuItem"
        Me.DayliToolStripMenuItem.Size = New System.Drawing.Size(134, 26)
        Me.DayliToolStripMenuItem.Text = "Today"
        '
        'AdditionalWorkToolStripMenuItem
        '
        Me.AdditionalWorkToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.AdditionalWorkToolStripMenuItem.Name = "AdditionalWorkToolStripMenuItem"
        Me.AdditionalWorkToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.AdditionalWorkToolStripMenuItem.Text = "Additional work"
        '
        'ProgressReportToolStripMenuItem
        '
        Me.ProgressReportToolStripMenuItem.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold)
        Me.ProgressReportToolStripMenuItem.Name = "ProgressReportToolStripMenuItem"
        Me.ProgressReportToolStripMenuItem.Size = New System.Drawing.Size(155, 26)
        Me.ProgressReportToolStripMenuItem.Text = "Progress Report"
        '
        'Achieva_MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 453)
        Me.Controls.Add(Me.MenuStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "Achieva_MDI"
        Me.Text = "Achieva_MDI"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents StaffInductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkBookToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WorkReportAttendanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DailyAttendenceReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProgressReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdditionalWorkToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ShowToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonthlyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DayliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
