<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_Details
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
        Me.StaffIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PositionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DepartmentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JoiningDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BranchDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ManagerNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmploymentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WorkShiftTimingDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalaryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankAccountNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IFSCcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ESICcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PFcodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadharcardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PancardDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyContactNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmergencyContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Add_Staff_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LoginInDataSet = New Courier_Management_System.LoginInDataSet()
        Me.Add_Staff_DetailsTableAdapter = New Courier_Management_System.LoginInDataSetTableAdapters.Add_Staff_DetailsTableAdapter()
        Me.TableAdapterManager = New Courier_Management_System.LoginInDataSetTableAdapters.TableAdapterManager()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_Staff_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginInDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StaffIDDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.ContactNumberDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.PositionDataGridViewTextBoxColumn, Me.EmployeeCodeDataGridViewTextBoxColumn, Me.DepartmentDataGridViewTextBoxColumn, Me.JoiningDateDataGridViewTextBoxColumn, Me.BranchDataGridViewTextBoxColumn, Me.ManagerNameDataGridViewTextBoxColumn, Me.EmploymentTypeDataGridViewTextBoxColumn, Me.WorkShiftTimingDataGridViewTextBoxColumn, Me.SalaryDataGridViewTextBoxColumn, Me.BankNameDataGridViewTextBoxColumn, Me.BankAccountNoDataGridViewTextBoxColumn, Me.IFSCcodeDataGridViewTextBoxColumn, Me.ESICcodeDataGridViewTextBoxColumn, Me.PFcodeDataGridViewTextBoxColumn, Me.EmployeeStatusDataGridViewTextBoxColumn, Me.AadharcardDataGridViewTextBoxColumn, Me.PancardDataGridViewTextBoxColumn, Me.EmergencyContactNameDataGridViewTextBoxColumn, Me.EmergencyContactNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Add_Staff_DetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(22, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(977, 459)
        Me.DataGridView1.TabIndex = 0
        '
        'StaffIDDataGridViewTextBoxColumn
        '
        Me.StaffIDDataGridViewTextBoxColumn.DataPropertyName = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.HeaderText = "StaffID"
        Me.StaffIDDataGridViewTextBoxColumn.Name = "StaffIDDataGridViewTextBoxColumn"
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'ContactNumberDataGridViewTextBoxColumn
        '
        Me.ContactNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.HeaderText = "ContactNumber"
        Me.ContactNumberDataGridViewTextBoxColumn.Name = "ContactNumberDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'PositionDataGridViewTextBoxColumn
        '
        Me.PositionDataGridViewTextBoxColumn.DataPropertyName = "Position"
        Me.PositionDataGridViewTextBoxColumn.HeaderText = "Position"
        Me.PositionDataGridViewTextBoxColumn.Name = "PositionDataGridViewTextBoxColumn"
        '
        'EmployeeCodeDataGridViewTextBoxColumn
        '
        Me.EmployeeCodeDataGridViewTextBoxColumn.DataPropertyName = "EmployeeCode"
        Me.EmployeeCodeDataGridViewTextBoxColumn.HeaderText = "EmployeeCode"
        Me.EmployeeCodeDataGridViewTextBoxColumn.Name = "EmployeeCodeDataGridViewTextBoxColumn"
        '
        'DepartmentDataGridViewTextBoxColumn
        '
        Me.DepartmentDataGridViewTextBoxColumn.DataPropertyName = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.HeaderText = "Department"
        Me.DepartmentDataGridViewTextBoxColumn.Name = "DepartmentDataGridViewTextBoxColumn"
        '
        'JoiningDateDataGridViewTextBoxColumn
        '
        Me.JoiningDateDataGridViewTextBoxColumn.DataPropertyName = "JoiningDate"
        Me.JoiningDateDataGridViewTextBoxColumn.HeaderText = "JoiningDate"
        Me.JoiningDateDataGridViewTextBoxColumn.Name = "JoiningDateDataGridViewTextBoxColumn"
        '
        'BranchDataGridViewTextBoxColumn
        '
        Me.BranchDataGridViewTextBoxColumn.DataPropertyName = "Branch"
        Me.BranchDataGridViewTextBoxColumn.HeaderText = "Branch"
        Me.BranchDataGridViewTextBoxColumn.Name = "BranchDataGridViewTextBoxColumn"
        '
        'ManagerNameDataGridViewTextBoxColumn
        '
        Me.ManagerNameDataGridViewTextBoxColumn.DataPropertyName = "ManagerName"
        Me.ManagerNameDataGridViewTextBoxColumn.HeaderText = "ManagerName"
        Me.ManagerNameDataGridViewTextBoxColumn.Name = "ManagerNameDataGridViewTextBoxColumn"
        '
        'EmploymentTypeDataGridViewTextBoxColumn
        '
        Me.EmploymentTypeDataGridViewTextBoxColumn.DataPropertyName = "EmploymentType"
        Me.EmploymentTypeDataGridViewTextBoxColumn.HeaderText = "EmploymentType"
        Me.EmploymentTypeDataGridViewTextBoxColumn.Name = "EmploymentTypeDataGridViewTextBoxColumn"
        '
        'WorkShiftTimingDataGridViewTextBoxColumn
        '
        Me.WorkShiftTimingDataGridViewTextBoxColumn.DataPropertyName = "WorkShiftTiming"
        Me.WorkShiftTimingDataGridViewTextBoxColumn.HeaderText = "WorkShiftTiming"
        Me.WorkShiftTimingDataGridViewTextBoxColumn.Name = "WorkShiftTimingDataGridViewTextBoxColumn"
        '
        'SalaryDataGridViewTextBoxColumn
        '
        Me.SalaryDataGridViewTextBoxColumn.DataPropertyName = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.HeaderText = "Salary"
        Me.SalaryDataGridViewTextBoxColumn.Name = "SalaryDataGridViewTextBoxColumn"
        '
        'BankNameDataGridViewTextBoxColumn
        '
        Me.BankNameDataGridViewTextBoxColumn.DataPropertyName = "BankName"
        Me.BankNameDataGridViewTextBoxColumn.HeaderText = "BankName"
        Me.BankNameDataGridViewTextBoxColumn.Name = "BankNameDataGridViewTextBoxColumn"
        '
        'BankAccountNoDataGridViewTextBoxColumn
        '
        Me.BankAccountNoDataGridViewTextBoxColumn.DataPropertyName = "BankAccountNo"
        Me.BankAccountNoDataGridViewTextBoxColumn.HeaderText = "BankAccountNo"
        Me.BankAccountNoDataGridViewTextBoxColumn.Name = "BankAccountNoDataGridViewTextBoxColumn"
        '
        'IFSCcodeDataGridViewTextBoxColumn
        '
        Me.IFSCcodeDataGridViewTextBoxColumn.DataPropertyName = "IFSCcode"
        Me.IFSCcodeDataGridViewTextBoxColumn.HeaderText = "IFSCcode"
        Me.IFSCcodeDataGridViewTextBoxColumn.Name = "IFSCcodeDataGridViewTextBoxColumn"
        '
        'ESICcodeDataGridViewTextBoxColumn
        '
        Me.ESICcodeDataGridViewTextBoxColumn.DataPropertyName = "ESICcode"
        Me.ESICcodeDataGridViewTextBoxColumn.HeaderText = "ESICcode"
        Me.ESICcodeDataGridViewTextBoxColumn.Name = "ESICcodeDataGridViewTextBoxColumn"
        '
        'PFcodeDataGridViewTextBoxColumn
        '
        Me.PFcodeDataGridViewTextBoxColumn.DataPropertyName = "PFcode"
        Me.PFcodeDataGridViewTextBoxColumn.HeaderText = "PFcode"
        Me.PFcodeDataGridViewTextBoxColumn.Name = "PFcodeDataGridViewTextBoxColumn"
        '
        'EmployeeStatusDataGridViewTextBoxColumn
        '
        Me.EmployeeStatusDataGridViewTextBoxColumn.DataPropertyName = "EmployeeStatus"
        Me.EmployeeStatusDataGridViewTextBoxColumn.HeaderText = "EmployeeStatus"
        Me.EmployeeStatusDataGridViewTextBoxColumn.Name = "EmployeeStatusDataGridViewTextBoxColumn"
        '
        'AadharcardDataGridViewTextBoxColumn
        '
        Me.AadharcardDataGridViewTextBoxColumn.DataPropertyName = "Aadharcard"
        Me.AadharcardDataGridViewTextBoxColumn.HeaderText = "Aadharcard"
        Me.AadharcardDataGridViewTextBoxColumn.Name = "AadharcardDataGridViewTextBoxColumn"
        '
        'PancardDataGridViewTextBoxColumn
        '
        Me.PancardDataGridViewTextBoxColumn.DataPropertyName = "Pancard"
        Me.PancardDataGridViewTextBoxColumn.HeaderText = "Pancard"
        Me.PancardDataGridViewTextBoxColumn.Name = "PancardDataGridViewTextBoxColumn"
        '
        'EmergencyContactNameDataGridViewTextBoxColumn
        '
        Me.EmergencyContactNameDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContactName"
        Me.EmergencyContactNameDataGridViewTextBoxColumn.HeaderText = "EmergencyContactName"
        Me.EmergencyContactNameDataGridViewTextBoxColumn.Name = "EmergencyContactNameDataGridViewTextBoxColumn"
        '
        'EmergencyContactNoDataGridViewTextBoxColumn
        '
        Me.EmergencyContactNoDataGridViewTextBoxColumn.DataPropertyName = "EmergencyContactNo"
        Me.EmergencyContactNoDataGridViewTextBoxColumn.HeaderText = "EmergencyContactNo"
        Me.EmergencyContactNoDataGridViewTextBoxColumn.Name = "EmergencyContactNoDataGridViewTextBoxColumn"
        '
        'Add_Staff_DetailsBindingSource
        '
        Me.Add_Staff_DetailsBindingSource.DataMember = "Add_Staff_Details"
        Me.Add_Staff_DetailsBindingSource.DataSource = Me.LoginInDataSet
        '
        'LoginInDataSet
        '
        Me.LoginInDataSet.DataSetName = "LoginInDataSet"
        Me.LoginInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Add_Staff_DetailsTableAdapter
        '
        Me.Add_Staff_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_Delivery_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Add_Staff_DetailsTableAdapter = Me.Add_Staff_DetailsTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Consignment_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.LogInTableAdapter = Nothing
        Me.TableAdapterManager.Search_Delivery_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Tracking_delivery_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Courier_Management_System.LoginInDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'Display_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(1020, 464)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Display_Details"
        Me.Text = "Display_Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_Staff_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginInDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LoginInDataSet As Courier_Management_System.LoginInDataSet
    Friend WithEvents Add_Staff_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Add_Staff_DetailsTableAdapter As Courier_Management_System.LoginInDataSetTableAdapters.Add_Staff_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Courier_Management_System.LoginInDataSetTableAdapters.TableAdapterManager
    Friend WithEvents StaffIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ContactNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PositionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DepartmentDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents JoiningDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BranchDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ManagerNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmploymentTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WorkShiftTimingDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalaryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BankAccountNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IFSCcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ESICcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PFcodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmployeeStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadharcardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PancardDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmergencyContactNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmergencyContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
