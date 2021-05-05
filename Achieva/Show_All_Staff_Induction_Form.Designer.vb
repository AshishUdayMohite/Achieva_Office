<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Show_All_Staff_Induction_Form
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Achieva_Demo_ApplicationDataSet = New Achieva.Achieva_Demo_ApplicationDataSet()
        Me.StaffDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Staff_DetailsTableAdapter = New Achieva.Achieva_Demo_ApplicationDataSetTableAdapters.Staff_DetailsTableAdapter()
        Me.EmpIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoinDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AppointedPositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SecondNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpQualificationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel1NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel1ProfessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel1MobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel2NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel2ProfessionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rel2MobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobStartingDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileExpansesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpSalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TravellingAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncentiveDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DatingAllowanceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OtherDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DutyTimingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SpecialAdvantageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobWorkDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Achieva_Demo_ApplicationDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpIDDataGridViewTextBoxColumn, Me.JoinDateDataGridViewTextBoxColumn, Me.AppointedPositionDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SecondNameDataGridViewTextBoxColumn, Me.LastNameDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.EmpEmailDataGridViewTextBoxColumn, Me.EmpAddressDataGridViewTextBoxColumn, Me.EmpQualificationDataGridViewTextBoxColumn, Me.Rel1DataGridViewTextBoxColumn, Me.Rel1NameDataGridViewTextBoxColumn, Me.Rel1ProfessionDataGridViewTextBoxColumn, Me.Rel1MobileNoDataGridViewTextBoxColumn, Me.Rel2DataGridViewTextBoxColumn, Me.Rel2NameDataGridViewTextBoxColumn, Me.Rel2ProfessionDataGridViewTextBoxColumn, Me.Rel2MobileNoDataGridViewTextBoxColumn, Me.JobStartingDateDataGridViewTextBoxColumn, Me.MobileExpansesDataGridViewTextBoxColumn, Me.EmpSalaryDataGridViewTextBoxColumn, Me.TravellingAllowanceDataGridViewTextBoxColumn, Me.IncentiveDataGridViewTextBoxColumn, Me.DatingAllowanceDataGridViewTextBoxColumn, Me.OtherDataGridViewTextBoxColumn, Me.DutyTimingDataGridViewTextBoxColumn, Me.SpecialAdvantageDataGridViewTextBoxColumn, Me.JobWorkDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StaffDetailsBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1300, 749)
        Me.DataGridView1.TabIndex = 0
        '
        'Achieva_Demo_ApplicationDataSet
        '
        Me.Achieva_Demo_ApplicationDataSet.DataSetName = "Achieva_Demo_ApplicationDataSet"
        Me.Achieva_Demo_ApplicationDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StaffDetailsBindingSource
        '
        Me.StaffDetailsBindingSource.DataMember = "Staff_Details"
        Me.StaffDetailsBindingSource.DataSource = Me.Achieva_Demo_ApplicationDataSet
        '
        'Staff_DetailsTableAdapter
        '
        Me.Staff_DetailsTableAdapter.ClearBeforeFill = True
        '
        'EmpIDDataGridViewTextBoxColumn
        '
        Me.EmpIDDataGridViewTextBoxColumn.DataPropertyName = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.HeaderText = "Emp_ID"
        Me.EmpIDDataGridViewTextBoxColumn.Name = "EmpIDDataGridViewTextBoxColumn"
        '
        'JoinDateDataGridViewTextBoxColumn
        '
        Me.JoinDateDataGridViewTextBoxColumn.DataPropertyName = "Join_Date"
        Me.JoinDateDataGridViewTextBoxColumn.HeaderText = "Join_Date"
        Me.JoinDateDataGridViewTextBoxColumn.Name = "JoinDateDataGridViewTextBoxColumn"
        '
        'AppointedPositionDataGridViewTextBoxColumn
        '
        Me.AppointedPositionDataGridViewTextBoxColumn.DataPropertyName = "Appointed_Position"
        Me.AppointedPositionDataGridViewTextBoxColumn.HeaderText = "Appointed_Position"
        Me.AppointedPositionDataGridViewTextBoxColumn.Name = "AppointedPositionDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "First_Name"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'SecondNameDataGridViewTextBoxColumn
        '
        Me.SecondNameDataGridViewTextBoxColumn.DataPropertyName = "Second_Name"
        Me.SecondNameDataGridViewTextBoxColumn.HeaderText = "Second_Name"
        Me.SecondNameDataGridViewTextBoxColumn.Name = "SecondNameDataGridViewTextBoxColumn"
        '
        'LastNameDataGridViewTextBoxColumn
        '
        Me.LastNameDataGridViewTextBoxColumn.DataPropertyName = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.HeaderText = "Last_Name"
        Me.LastNameDataGridViewTextBoxColumn.Name = "LastNameDataGridViewTextBoxColumn"
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "Contact_No"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "Contact_No"
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        '
        'EmpEmailDataGridViewTextBoxColumn
        '
        Me.EmpEmailDataGridViewTextBoxColumn.DataPropertyName = "Emp_Email"
        Me.EmpEmailDataGridViewTextBoxColumn.HeaderText = "Emp_Email"
        Me.EmpEmailDataGridViewTextBoxColumn.Name = "EmpEmailDataGridViewTextBoxColumn"
        '
        'EmpAddressDataGridViewTextBoxColumn
        '
        Me.EmpAddressDataGridViewTextBoxColumn.DataPropertyName = "Emp_Address"
        Me.EmpAddressDataGridViewTextBoxColumn.HeaderText = "Emp_Address"
        Me.EmpAddressDataGridViewTextBoxColumn.Name = "EmpAddressDataGridViewTextBoxColumn"
        '
        'EmpQualificationDataGridViewTextBoxColumn
        '
        Me.EmpQualificationDataGridViewTextBoxColumn.DataPropertyName = "Emp_Qualification"
        Me.EmpQualificationDataGridViewTextBoxColumn.HeaderText = "Emp_Qualification"
        Me.EmpQualificationDataGridViewTextBoxColumn.Name = "EmpQualificationDataGridViewTextBoxColumn"
        '
        'Rel1DataGridViewTextBoxColumn
        '
        Me.Rel1DataGridViewTextBoxColumn.DataPropertyName = "Rel_1"
        Me.Rel1DataGridViewTextBoxColumn.HeaderText = "Rel_1"
        Me.Rel1DataGridViewTextBoxColumn.Name = "Rel1DataGridViewTextBoxColumn"
        '
        'Rel1NameDataGridViewTextBoxColumn
        '
        Me.Rel1NameDataGridViewTextBoxColumn.DataPropertyName = "Rel_1_Name"
        Me.Rel1NameDataGridViewTextBoxColumn.HeaderText = "Rel_1_Name"
        Me.Rel1NameDataGridViewTextBoxColumn.Name = "Rel1NameDataGridViewTextBoxColumn"
        '
        'Rel1ProfessionDataGridViewTextBoxColumn
        '
        Me.Rel1ProfessionDataGridViewTextBoxColumn.DataPropertyName = "Rel_1_Profession"
        Me.Rel1ProfessionDataGridViewTextBoxColumn.HeaderText = "Rel_1_Profession"
        Me.Rel1ProfessionDataGridViewTextBoxColumn.Name = "Rel1ProfessionDataGridViewTextBoxColumn"
        '
        'Rel1MobileNoDataGridViewTextBoxColumn
        '
        Me.Rel1MobileNoDataGridViewTextBoxColumn.DataPropertyName = "Rel_1_MobileNo"
        Me.Rel1MobileNoDataGridViewTextBoxColumn.HeaderText = "Rel_1_MobileNo"
        Me.Rel1MobileNoDataGridViewTextBoxColumn.Name = "Rel1MobileNoDataGridViewTextBoxColumn"
        '
        'Rel2DataGridViewTextBoxColumn
        '
        Me.Rel2DataGridViewTextBoxColumn.DataPropertyName = "Rel_2"
        Me.Rel2DataGridViewTextBoxColumn.HeaderText = "Rel_2"
        Me.Rel2DataGridViewTextBoxColumn.Name = "Rel2DataGridViewTextBoxColumn"
        '
        'Rel2NameDataGridViewTextBoxColumn
        '
        Me.Rel2NameDataGridViewTextBoxColumn.DataPropertyName = "Rel_2_Name"
        Me.Rel2NameDataGridViewTextBoxColumn.HeaderText = "Rel_2_Name"
        Me.Rel2NameDataGridViewTextBoxColumn.Name = "Rel2NameDataGridViewTextBoxColumn"
        '
        'Rel2ProfessionDataGridViewTextBoxColumn
        '
        Me.Rel2ProfessionDataGridViewTextBoxColumn.DataPropertyName = "Rel_2_Profession"
        Me.Rel2ProfessionDataGridViewTextBoxColumn.HeaderText = "Rel_2_Profession"
        Me.Rel2ProfessionDataGridViewTextBoxColumn.Name = "Rel2ProfessionDataGridViewTextBoxColumn"
        '
        'Rel2MobileNoDataGridViewTextBoxColumn
        '
        Me.Rel2MobileNoDataGridViewTextBoxColumn.DataPropertyName = "Rel_2_MobileNo"
        Me.Rel2MobileNoDataGridViewTextBoxColumn.HeaderText = "Rel_2_MobileNo"
        Me.Rel2MobileNoDataGridViewTextBoxColumn.Name = "Rel2MobileNoDataGridViewTextBoxColumn"
        '
        'JobStartingDateDataGridViewTextBoxColumn
        '
        Me.JobStartingDateDataGridViewTextBoxColumn.DataPropertyName = "Job_Starting_Date"
        Me.JobStartingDateDataGridViewTextBoxColumn.HeaderText = "Job_Starting_Date"
        Me.JobStartingDateDataGridViewTextBoxColumn.Name = "JobStartingDateDataGridViewTextBoxColumn"
        '
        'MobileExpansesDataGridViewTextBoxColumn
        '
        Me.MobileExpansesDataGridViewTextBoxColumn.DataPropertyName = "Mobile_Expanses"
        Me.MobileExpansesDataGridViewTextBoxColumn.HeaderText = "Mobile_Expanses"
        Me.MobileExpansesDataGridViewTextBoxColumn.Name = "MobileExpansesDataGridViewTextBoxColumn"
        '
        'EmpSalaryDataGridViewTextBoxColumn
        '
        Me.EmpSalaryDataGridViewTextBoxColumn.DataPropertyName = "Emp_Salary"
        Me.EmpSalaryDataGridViewTextBoxColumn.HeaderText = "Emp_Salary"
        Me.EmpSalaryDataGridViewTextBoxColumn.Name = "EmpSalaryDataGridViewTextBoxColumn"
        '
        'TravellingAllowanceDataGridViewTextBoxColumn
        '
        Me.TravellingAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Travelling_Allowance"
        Me.TravellingAllowanceDataGridViewTextBoxColumn.HeaderText = "Travelling_Allowance"
        Me.TravellingAllowanceDataGridViewTextBoxColumn.Name = "TravellingAllowanceDataGridViewTextBoxColumn"
        '
        'IncentiveDataGridViewTextBoxColumn
        '
        Me.IncentiveDataGridViewTextBoxColumn.DataPropertyName = "Incentive"
        Me.IncentiveDataGridViewTextBoxColumn.HeaderText = "Incentive"
        Me.IncentiveDataGridViewTextBoxColumn.Name = "IncentiveDataGridViewTextBoxColumn"
        '
        'DatingAllowanceDataGridViewTextBoxColumn
        '
        Me.DatingAllowanceDataGridViewTextBoxColumn.DataPropertyName = "Dating_Allowance"
        Me.DatingAllowanceDataGridViewTextBoxColumn.HeaderText = "Dating_Allowance"
        Me.DatingAllowanceDataGridViewTextBoxColumn.Name = "DatingAllowanceDataGridViewTextBoxColumn"
        '
        'OtherDataGridViewTextBoxColumn
        '
        Me.OtherDataGridViewTextBoxColumn.DataPropertyName = "Other"
        Me.OtherDataGridViewTextBoxColumn.HeaderText = "Other"
        Me.OtherDataGridViewTextBoxColumn.Name = "OtherDataGridViewTextBoxColumn"
        '
        'DutyTimingDataGridViewTextBoxColumn
        '
        Me.DutyTimingDataGridViewTextBoxColumn.DataPropertyName = "Duty_Timing"
        Me.DutyTimingDataGridViewTextBoxColumn.HeaderText = "Duty_Timing"
        Me.DutyTimingDataGridViewTextBoxColumn.Name = "DutyTimingDataGridViewTextBoxColumn"
        '
        'SpecialAdvantageDataGridViewTextBoxColumn
        '
        Me.SpecialAdvantageDataGridViewTextBoxColumn.DataPropertyName = "Special_Advantage"
        Me.SpecialAdvantageDataGridViewTextBoxColumn.HeaderText = "Special_Advantage"
        Me.SpecialAdvantageDataGridViewTextBoxColumn.Name = "SpecialAdvantageDataGridViewTextBoxColumn"
        '
        'JobWorkDataGridViewTextBoxColumn
        '
        Me.JobWorkDataGridViewTextBoxColumn.DataPropertyName = "Job_Work"
        Me.JobWorkDataGridViewTextBoxColumn.HeaderText = "Job_Work"
        Me.JobWorkDataGridViewTextBoxColumn.Name = "JobWorkDataGridViewTextBoxColumn"
        '
        'Show_All_Staff_Induction_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 749)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Show_All_Staff_Induction_Form"
        Me.Text = "Show_All_Staff_Induction_Form"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Achieva_Demo_ApplicationDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StaffDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Achieva_Demo_ApplicationDataSet As Achieva.Achieva_Demo_ApplicationDataSet
    Friend WithEvents StaffDetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Staff_DetailsTableAdapter As Achieva.Achieva_Demo_ApplicationDataSetTableAdapters.Staff_DetailsTableAdapter
    Friend WithEvents EmpIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JoinDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AppointedPositionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SecondNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpQualificationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel1DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel1NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel1ProfessionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel1MobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel2DataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel2NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel2ProfessionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Rel2MobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobStartingDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileExpansesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpSalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TravellingAllowanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IncentiveDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatingAllowanceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OtherDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DutyTimingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SpecialAdvantageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JobWorkDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
