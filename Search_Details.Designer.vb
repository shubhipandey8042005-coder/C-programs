<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Search_Details
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
        Me.LoginInDataSet = New Courier_Management_System.LoginInDataSet()
        Me.Add_Delivery_DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Add_Delivery_DetailsTableAdapter = New Courier_Management_System.LoginInDataSetTableAdapters.Add_Delivery_DetailsTableAdapter()
        Me.TableAdapterManager = New Courier_Management_System.LoginInDataSetTableAdapters.TableAdapterManager()
        Me.TrackingNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrderIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ShipmentTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageWeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageLengthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageWidthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PackageHeightDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenderNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenderContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SenderEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PickupAddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PickupDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiverNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiverContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReceiverEmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryDateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlternateContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CurrentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryAgentNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VehicleNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentModeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaymentStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CODamountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InvoiceNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeliveryPriorityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SourceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DestinationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LoginInDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Add_Delivery_DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TrackingNoDataGridViewTextBoxColumn, Me.OrderIDDataGridViewTextBoxColumn, Me.ShipmentTypeDataGridViewTextBoxColumn, Me.PackageWeightDataGridViewTextBoxColumn, Me.PackageLengthDataGridViewTextBoxColumn, Me.PackageWidthDataGridViewTextBoxColumn, Me.PackageHeightDataGridViewTextBoxColumn, Me.SenderNameDataGridViewTextBoxColumn, Me.SenderContactNoDataGridViewTextBoxColumn, Me.SenderEmailDataGridViewTextBoxColumn, Me.PickupAddressDataGridViewTextBoxColumn, Me.PickupDateDataGridViewTextBoxColumn, Me.ReceiverNameDataGridViewTextBoxColumn, Me.ReceiverContactNoDataGridViewTextBoxColumn, Me.ReceiverEmailDataGridViewTextBoxColumn, Me.DeliveryDateDataGridViewTextBoxColumn, Me.AlternateContactNoDataGridViewTextBoxColumn, Me.CurrentStatusDataGridViewTextBoxColumn, Me.DeliveryAgentNameDataGridViewTextBoxColumn, Me.VehicleNoDataGridViewTextBoxColumn, Me.PaymentModeDataGridViewTextBoxColumn, Me.PaymentStatusDataGridViewTextBoxColumn, Me.CODamountDataGridViewTextBoxColumn, Me.InvoiceNoDataGridViewTextBoxColumn, Me.DeliveryPriorityDataGridViewTextBoxColumn, Me.SourceDataGridViewTextBoxColumn, Me.DestinationDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.Add_Delivery_DetailsBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(847, 436)
        Me.DataGridView1.TabIndex = 0
        '
        'LoginInDataSet
        '
        Me.LoginInDataSet.DataSetName = "LoginInDataSet"
        Me.LoginInDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Add_Delivery_DetailsBindingSource
        '
        Me.Add_Delivery_DetailsBindingSource.DataMember = "Add_Delivery_Details"
        Me.Add_Delivery_DetailsBindingSource.DataSource = Me.LoginInDataSet
        '
        'Add_Delivery_DetailsTableAdapter
        '
        Me.Add_Delivery_DetailsTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.Add_Delivery_DetailsTableAdapter = Me.Add_Delivery_DetailsTableAdapter
        Me.TableAdapterManager.Add_Staff_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Consignment_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.LogInTableAdapter = Nothing
        Me.TableAdapterManager.Search_Delivery_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.Tracking_delivery_DetailsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Courier_Management_System.LoginInDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TrackingNoDataGridViewTextBoxColumn
        '
        Me.TrackingNoDataGridViewTextBoxColumn.DataPropertyName = "TrackingNo"
        Me.TrackingNoDataGridViewTextBoxColumn.HeaderText = "TrackingNo"
        Me.TrackingNoDataGridViewTextBoxColumn.Name = "TrackingNoDataGridViewTextBoxColumn"
        '
        'OrderIDDataGridViewTextBoxColumn
        '
        Me.OrderIDDataGridViewTextBoxColumn.DataPropertyName = "OrderID"
        Me.OrderIDDataGridViewTextBoxColumn.HeaderText = "OrderID"
        Me.OrderIDDataGridViewTextBoxColumn.Name = "OrderIDDataGridViewTextBoxColumn"
        '
        'ShipmentTypeDataGridViewTextBoxColumn
        '
        Me.ShipmentTypeDataGridViewTextBoxColumn.DataPropertyName = "ShipmentType"
        Me.ShipmentTypeDataGridViewTextBoxColumn.HeaderText = "ShipmentType"
        Me.ShipmentTypeDataGridViewTextBoxColumn.Name = "ShipmentTypeDataGridViewTextBoxColumn"
        '
        'PackageWeightDataGridViewTextBoxColumn
        '
        Me.PackageWeightDataGridViewTextBoxColumn.DataPropertyName = "PackageWeight"
        Me.PackageWeightDataGridViewTextBoxColumn.HeaderText = "PackageWeight"
        Me.PackageWeightDataGridViewTextBoxColumn.Name = "PackageWeightDataGridViewTextBoxColumn"
        '
        'PackageLengthDataGridViewTextBoxColumn
        '
        Me.PackageLengthDataGridViewTextBoxColumn.DataPropertyName = "PackageLength"
        Me.PackageLengthDataGridViewTextBoxColumn.HeaderText = "PackageLength"
        Me.PackageLengthDataGridViewTextBoxColumn.Name = "PackageLengthDataGridViewTextBoxColumn"
        '
        'PackageWidthDataGridViewTextBoxColumn
        '
        Me.PackageWidthDataGridViewTextBoxColumn.DataPropertyName = "PackageWidth"
        Me.PackageWidthDataGridViewTextBoxColumn.HeaderText = "PackageWidth"
        Me.PackageWidthDataGridViewTextBoxColumn.Name = "PackageWidthDataGridViewTextBoxColumn"
        '
        'PackageHeightDataGridViewTextBoxColumn
        '
        Me.PackageHeightDataGridViewTextBoxColumn.DataPropertyName = "PackageHeight"
        Me.PackageHeightDataGridViewTextBoxColumn.HeaderText = "PackageHeight"
        Me.PackageHeightDataGridViewTextBoxColumn.Name = "PackageHeightDataGridViewTextBoxColumn"
        '
        'SenderNameDataGridViewTextBoxColumn
        '
        Me.SenderNameDataGridViewTextBoxColumn.DataPropertyName = "SenderName"
        Me.SenderNameDataGridViewTextBoxColumn.HeaderText = "SenderName"
        Me.SenderNameDataGridViewTextBoxColumn.Name = "SenderNameDataGridViewTextBoxColumn"
        '
        'SenderContactNoDataGridViewTextBoxColumn
        '
        Me.SenderContactNoDataGridViewTextBoxColumn.DataPropertyName = "SenderContactNo"
        Me.SenderContactNoDataGridViewTextBoxColumn.HeaderText = "SenderContactNo"
        Me.SenderContactNoDataGridViewTextBoxColumn.Name = "SenderContactNoDataGridViewTextBoxColumn"
        '
        'SenderEmailDataGridViewTextBoxColumn
        '
        Me.SenderEmailDataGridViewTextBoxColumn.DataPropertyName = "SenderEmail"
        Me.SenderEmailDataGridViewTextBoxColumn.HeaderText = "SenderEmail"
        Me.SenderEmailDataGridViewTextBoxColumn.Name = "SenderEmailDataGridViewTextBoxColumn"
        '
        'PickupAddressDataGridViewTextBoxColumn
        '
        Me.PickupAddressDataGridViewTextBoxColumn.DataPropertyName = "PickupAddress"
        Me.PickupAddressDataGridViewTextBoxColumn.HeaderText = "PickupAddress"
        Me.PickupAddressDataGridViewTextBoxColumn.Name = "PickupAddressDataGridViewTextBoxColumn"
        '
        'PickupDateDataGridViewTextBoxColumn
        '
        Me.PickupDateDataGridViewTextBoxColumn.DataPropertyName = "PickupDate"
        Me.PickupDateDataGridViewTextBoxColumn.HeaderText = "PickupDate"
        Me.PickupDateDataGridViewTextBoxColumn.Name = "PickupDateDataGridViewTextBoxColumn"
        '
        'ReceiverNameDataGridViewTextBoxColumn
        '
        Me.ReceiverNameDataGridViewTextBoxColumn.DataPropertyName = "ReceiverName"
        Me.ReceiverNameDataGridViewTextBoxColumn.HeaderText = "ReceiverName"
        Me.ReceiverNameDataGridViewTextBoxColumn.Name = "ReceiverNameDataGridViewTextBoxColumn"
        '
        'ReceiverContactNoDataGridViewTextBoxColumn
        '
        Me.ReceiverContactNoDataGridViewTextBoxColumn.DataPropertyName = "ReceiverContactNo"
        Me.ReceiverContactNoDataGridViewTextBoxColumn.HeaderText = "ReceiverContactNo"
        Me.ReceiverContactNoDataGridViewTextBoxColumn.Name = "ReceiverContactNoDataGridViewTextBoxColumn"
        '
        'ReceiverEmailDataGridViewTextBoxColumn
        '
        Me.ReceiverEmailDataGridViewTextBoxColumn.DataPropertyName = "ReceiverEmail"
        Me.ReceiverEmailDataGridViewTextBoxColumn.HeaderText = "ReceiverEmail"
        Me.ReceiverEmailDataGridViewTextBoxColumn.Name = "ReceiverEmailDataGridViewTextBoxColumn"
        '
        'DeliveryDateDataGridViewTextBoxColumn
        '
        Me.DeliveryDateDataGridViewTextBoxColumn.DataPropertyName = "DeliveryDate"
        Me.DeliveryDateDataGridViewTextBoxColumn.HeaderText = "DeliveryDate"
        Me.DeliveryDateDataGridViewTextBoxColumn.Name = "DeliveryDateDataGridViewTextBoxColumn"
        '
        'AlternateContactNoDataGridViewTextBoxColumn
        '
        Me.AlternateContactNoDataGridViewTextBoxColumn.DataPropertyName = "AlternateContactNo"
        Me.AlternateContactNoDataGridViewTextBoxColumn.HeaderText = "AlternateContactNo"
        Me.AlternateContactNoDataGridViewTextBoxColumn.Name = "AlternateContactNoDataGridViewTextBoxColumn"
        '
        'CurrentStatusDataGridViewTextBoxColumn
        '
        Me.CurrentStatusDataGridViewTextBoxColumn.DataPropertyName = "CurrentStatus"
        Me.CurrentStatusDataGridViewTextBoxColumn.HeaderText = "CurrentStatus"
        Me.CurrentStatusDataGridViewTextBoxColumn.Name = "CurrentStatusDataGridViewTextBoxColumn"
        '
        'DeliveryAgentNameDataGridViewTextBoxColumn
        '
        Me.DeliveryAgentNameDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAgentName"
        Me.DeliveryAgentNameDataGridViewTextBoxColumn.HeaderText = "DeliveryAgentName"
        Me.DeliveryAgentNameDataGridViewTextBoxColumn.Name = "DeliveryAgentNameDataGridViewTextBoxColumn"
        '
        'VehicleNoDataGridViewTextBoxColumn
        '
        Me.VehicleNoDataGridViewTextBoxColumn.DataPropertyName = "VehicleNo"
        Me.VehicleNoDataGridViewTextBoxColumn.HeaderText = "VehicleNo"
        Me.VehicleNoDataGridViewTextBoxColumn.Name = "VehicleNoDataGridViewTextBoxColumn"
        '
        'PaymentModeDataGridViewTextBoxColumn
        '
        Me.PaymentModeDataGridViewTextBoxColumn.DataPropertyName = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.HeaderText = "PaymentMode"
        Me.PaymentModeDataGridViewTextBoxColumn.Name = "PaymentModeDataGridViewTextBoxColumn"
        '
        'PaymentStatusDataGridViewTextBoxColumn
        '
        Me.PaymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus"
        Me.PaymentStatusDataGridViewTextBoxColumn.Name = "PaymentStatusDataGridViewTextBoxColumn"
        '
        'CODamountDataGridViewTextBoxColumn
        '
        Me.CODamountDataGridViewTextBoxColumn.DataPropertyName = "CODamount"
        Me.CODamountDataGridViewTextBoxColumn.HeaderText = "CODamount"
        Me.CODamountDataGridViewTextBoxColumn.Name = "CODamountDataGridViewTextBoxColumn"
        '
        'InvoiceNoDataGridViewTextBoxColumn
        '
        Me.InvoiceNoDataGridViewTextBoxColumn.DataPropertyName = "InvoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.HeaderText = "InvoiceNo"
        Me.InvoiceNoDataGridViewTextBoxColumn.Name = "InvoiceNoDataGridViewTextBoxColumn"
        '
        'DeliveryPriorityDataGridViewTextBoxColumn
        '
        Me.DeliveryPriorityDataGridViewTextBoxColumn.DataPropertyName = "DeliveryPriority"
        Me.DeliveryPriorityDataGridViewTextBoxColumn.HeaderText = "DeliveryPriority"
        Me.DeliveryPriorityDataGridViewTextBoxColumn.Name = "DeliveryPriorityDataGridViewTextBoxColumn"
        '
        'SourceDataGridViewTextBoxColumn
        '
        Me.SourceDataGridViewTextBoxColumn.DataPropertyName = "Source"
        Me.SourceDataGridViewTextBoxColumn.HeaderText = "Source"
        Me.SourceDataGridViewTextBoxColumn.Name = "SourceDataGridViewTextBoxColumn"
        '
        'DestinationDataGridViewTextBoxColumn
        '
        Me.DestinationDataGridViewTextBoxColumn.DataPropertyName = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.HeaderText = "Destination"
        Me.DestinationDataGridViewTextBoxColumn.Name = "DestinationDataGridViewTextBoxColumn"
        '
        'Search_Details
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(892, 460)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Search_Details"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Search_Details"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LoginInDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Add_Delivery_DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents LoginInDataSet As Courier_Management_System.LoginInDataSet
    Friend WithEvents Add_Delivery_DetailsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Add_Delivery_DetailsTableAdapter As Courier_Management_System.LoginInDataSetTableAdapters.Add_Delivery_DetailsTableAdapter
    Friend WithEvents TableAdapterManager As Courier_Management_System.LoginInDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TrackingNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OrderIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ShipmentTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackageWeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackageLengthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackageWidthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PackageHeightDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenderNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenderContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SenderEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PickupAddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PickupDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiverNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiverContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReceiverEmailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryDateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AlternateContactNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CurrentStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryAgentNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VehicleNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentModeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PaymentStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CODamountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents InvoiceNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeliveryPriorityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SourceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DestinationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
