Imports Microsoft.VisualBasic
Imports System
Namespace E989
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.ordersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New E989.Data.nwindDataSet()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCustomerID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.colEmployeeID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.repositoryItemLookUpEdit2 = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
			Me.employeesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.colOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colRequiredDate = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipAddress = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colShipCountry = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.ordersTableAdapter = New E989.Data.nwindDataSetTableAdapters.OrdersTableAdapter()
			Me.customersTableAdapter = New E989.Data.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.employeesTableAdapter = New E989.Data.nwindDataSetTableAdapters.EmployeesTableAdapter()
			Me.toolTipController1 = New DevExpress.Utils.ToolTipController(Me.components)
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.ordersBindingSource
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemLookUpEdit1, Me.repositoryItemLookUpEdit2})
			Me.gridControl1.Size = New System.Drawing.Size(884, 414)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' ordersBindingSource
			' 
			Me.ordersBindingSource.DataMember = "Orders"
			Me.ordersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCustomerID, Me.colEmployeeID, Me.colOrderDate, Me.colRequiredDate, Me.colShipName, Me.colShipAddress, Me.colShipCity, Me.colShipCountry})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupCount = 2
			Me.gridView1.Name = "gridView1"
			Me.gridView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() { New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colEmployeeID, DevExpress.Data.ColumnSortOrder.Ascending), New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.colCustomerID, DevExpress.Data.ColumnSortOrder.Ascending)})
			' 
			' colCustomerID
			' 
			Me.colCustomerID.Caption = "CustomerID"
			Me.colCustomerID.ColumnEdit = Me.repositoryItemLookUpEdit1
			Me.colCustomerID.FieldName = "CustomerID"
			Me.colCustomerID.Name = "colCustomerID"
			Me.colCustomerID.Visible = True
			Me.colCustomerID.VisibleIndex = 0
			' 
			' repositoryItemLookUpEdit1
			' 
			Me.repositoryItemLookUpEdit1.AutoHeight = False
			Me.repositoryItemLookUpEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit1.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "CustomerID", 76, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "CompanyName", 78, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "ContactName", 71, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 45, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("Phone", "Phone", 36, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.repositoryItemLookUpEdit1.DataSource = Me.customersBindingSource
			Me.repositoryItemLookUpEdit1.DisplayMember = "CompanyName"
			Me.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1"
			Me.repositoryItemLookUpEdit1.PopupWidth = 350
			Me.repositoryItemLookUpEdit1.ValueMember = "CustomerID"
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' colEmployeeID
			' 
			Me.colEmployeeID.Caption = "EmployeeID"
			Me.colEmployeeID.ColumnEdit = Me.repositoryItemLookUpEdit2
			Me.colEmployeeID.FieldName = "EmployeeID"
			Me.colEmployeeID.Name = "colEmployeeID"
			Me.colEmployeeID.Visible = True
			Me.colEmployeeID.VisibleIndex = 1
			' 
			' repositoryItemLookUpEdit2
			' 
			Me.repositoryItemLookUpEdit2.AutoHeight = False
			Me.repositoryItemLookUpEdit2.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.repositoryItemLookUpEdit2.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() { New DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "LastName", 53, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "FirstName", 54, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirthDate", "BirthDate", 51, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HireDate", "HireDate", 48, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", True, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 25, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near), New DevExpress.XtraEditors.Controls.LookUpColumnInfo("HomePhone", "HomePhone", 63, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
			Me.repositoryItemLookUpEdit2.DataSource = Me.employeesBindingSource
			Me.repositoryItemLookUpEdit2.DisplayMember = "LastName"
			Me.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2"
			Me.repositoryItemLookUpEdit2.PopupWidth = 350
			Me.repositoryItemLookUpEdit2.ValueMember = "EmployeeID"
			' 
			' employeesBindingSource
			' 
			Me.employeesBindingSource.DataMember = "Employees"
			Me.employeesBindingSource.DataSource = Me.nwindDataSet
			' 
			' colOrderDate
			' 
			Me.colOrderDate.Caption = "OrderDate"
			Me.colOrderDate.FieldName = "OrderDate"
			Me.colOrderDate.Name = "colOrderDate"
			Me.colOrderDate.Visible = True
			Me.colOrderDate.VisibleIndex = 0
			' 
			' colRequiredDate
			' 
			Me.colRequiredDate.Caption = "RequiredDate"
			Me.colRequiredDate.FieldName = "RequiredDate"
			Me.colRequiredDate.Name = "colRequiredDate"
			Me.colRequiredDate.Visible = True
			Me.colRequiredDate.VisibleIndex = 1
			' 
			' colShipName
			' 
			Me.colShipName.Caption = "ShipName"
			Me.colShipName.FieldName = "ShipName"
			Me.colShipName.Name = "colShipName"
			Me.colShipName.Visible = True
			Me.colShipName.VisibleIndex = 2
			' 
			' colShipAddress
			' 
			Me.colShipAddress.Caption = "ShipAddress"
			Me.colShipAddress.FieldName = "ShipAddress"
			Me.colShipAddress.Name = "colShipAddress"
			Me.colShipAddress.Visible = True
			Me.colShipAddress.VisibleIndex = 3
			' 
			' colShipCity
			' 
			Me.colShipCity.Caption = "ShipCity"
			Me.colShipCity.FieldName = "ShipCity"
			Me.colShipCity.Name = "colShipCity"
			Me.colShipCity.Visible = True
			Me.colShipCity.VisibleIndex = 4
			' 
			' colShipCountry
			' 
			Me.colShipCountry.Caption = "ShipCountry"
			Me.colShipCountry.FieldName = "ShipCountry"
			Me.colShipCountry.Name = "colShipCountry"
			Me.colShipCountry.Visible = True
			Me.colShipCountry.VisibleIndex = 5
			' 
			' ordersTableAdapter
			' 
			Me.ordersTableAdapter.ClearBeforeFill = True
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' employeesTableAdapter
			' 
			Me.employeesTableAdapter.ClearBeforeFill = True
			' 
			' toolTipController1
			' 
			Me.toolTipController1.AllowHtmlText = True
			' 
			' Form1
			' 
			Me.toolTipController1.SetAllowHtmlText(Me, DevExpress.Utils.DefaultBoolean.False)
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(884, 414)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.toolTipController1.SetSuperTip(Me, Nothing)
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.ordersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemLookUpEdit2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.employeesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As E989.Data.nwindDataSet
		Private ordersBindingSource As System.Windows.Forms.BindingSource
		Private ordersTableAdapter As E989.Data.nwindDataSetTableAdapters.OrdersTableAdapter
		Private colCustomerID As DevExpress.XtraGrid.Columns.GridColumn
		Private colEmployeeID As DevExpress.XtraGrid.Columns.GridColumn
		Private colOrderDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colRequiredDate As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipName As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipAddress As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colShipCountry As DevExpress.XtraGrid.Columns.GridColumn
		Private repositoryItemLookUpEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As E989.Data.nwindDataSetTableAdapters.CustomersTableAdapter
		Private repositoryItemLookUpEdit2 As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
		Private employeesBindingSource As System.Windows.Forms.BindingSource
		Private employeesTableAdapter As E989.Data.nwindDataSetTableAdapters.EmployeesTableAdapter
		Private toolTipController1 As DevExpress.Utils.ToolTipController
	End Class
End Namespace

