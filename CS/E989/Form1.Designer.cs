namespace E989 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nwindDataSet = new E989.Data.nwindDataSet();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCustomerID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colEmployeeID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.employeesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRequiredDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipAddress = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colShipCountry = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ordersTableAdapter = new E989.Data.nwindDataSetTableAdapters.OrdersTableAdapter();
            this.customersTableAdapter = new E989.Data.nwindDataSetTableAdapters.CustomersTableAdapter();
            this.employeesTableAdapter = new E989.Data.nwindDataSetTableAdapters.EmployeesTableAdapter();
            this.toolTipController1 = new DevExpress.Utils.ToolTipController(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ordersBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1,
            this.repositoryItemLookUpEdit2});
            this.gridControl1.Size = new System.Drawing.Size(884, 414);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.nwindDataSet;
            // 
            // nwindDataSet
            // 
            this.nwindDataSet.DataSetName = "nwindDataSet";
            this.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCustomerID,
            this.colEmployeeID,
            this.colOrderDate,
            this.colRequiredDate,
            this.colShipName,
            this.colShipAddress,
            this.colShipCity,
            this.colShipCountry});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 2;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colEmployeeID, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colCustomerID, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // colCustomerID
            // 
            this.colCustomerID.Caption = "CustomerID";
            this.colCustomerID.ColumnEdit = this.repositoryItemLookUpEdit1;
            this.colCustomerID.FieldName = "CustomerID";
            this.colCustomerID.Name = "colCustomerID";
            this.colCustomerID.Visible = true;
            this.colCustomerID.VisibleIndex = 0;
            // 
            // repositoryItemLookUpEdit1
            // 
            this.repositoryItemLookUpEdit1.AutoHeight = false;
            this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit1.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CustomerID", "CustomerID", 76, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CompanyName", "CompanyName", 78, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ContactName", "ContactName", 71, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Country", "Country", 45, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Phone", "Phone", 36, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit1.DataSource = this.customersBindingSource;
            this.repositoryItemLookUpEdit1.DisplayMember = "CompanyName";
            this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
            this.repositoryItemLookUpEdit1.PopupWidth = 350;
            this.repositoryItemLookUpEdit1.ValueMember = "CustomerID";
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "Customers";
            this.customersBindingSource.DataSource = this.nwindDataSet;
            // 
            // colEmployeeID
            // 
            this.colEmployeeID.Caption = "EmployeeID";
            this.colEmployeeID.ColumnEdit = this.repositoryItemLookUpEdit2;
            this.colEmployeeID.FieldName = "EmployeeID";
            this.colEmployeeID.Name = "colEmployeeID";
            this.colEmployeeID.Visible = true;
            this.colEmployeeID.VisibleIndex = 1;
            // 
            // repositoryItemLookUpEdit2
            // 
            this.repositoryItemLookUpEdit2.AutoHeight = false;
            this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemLookUpEdit2.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("LastName", "LastName", 53, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FirstName", "FirstName", 54, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("BirthDate", "BirthDate", 51, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HireDate", "HireDate", 48, DevExpress.Utils.FormatType.DateTime, "M/d/yyyy", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.None),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("City", "City", 25, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("HomePhone", "HomePhone", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.repositoryItemLookUpEdit2.DataSource = this.employeesBindingSource;
            this.repositoryItemLookUpEdit2.DisplayMember = "LastName";
            this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
            this.repositoryItemLookUpEdit2.PopupWidth = 350;
            this.repositoryItemLookUpEdit2.ValueMember = "EmployeeID";
            // 
            // employeesBindingSource
            // 
            this.employeesBindingSource.DataMember = "Employees";
            this.employeesBindingSource.DataSource = this.nwindDataSet;
            // 
            // colOrderDate
            // 
            this.colOrderDate.Caption = "OrderDate";
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 0;
            // 
            // colRequiredDate
            // 
            this.colRequiredDate.Caption = "RequiredDate";
            this.colRequiredDate.FieldName = "RequiredDate";
            this.colRequiredDate.Name = "colRequiredDate";
            this.colRequiredDate.Visible = true;
            this.colRequiredDate.VisibleIndex = 1;
            // 
            // colShipName
            // 
            this.colShipName.Caption = "ShipName";
            this.colShipName.FieldName = "ShipName";
            this.colShipName.Name = "colShipName";
            this.colShipName.Visible = true;
            this.colShipName.VisibleIndex = 2;
            // 
            // colShipAddress
            // 
            this.colShipAddress.Caption = "ShipAddress";
            this.colShipAddress.FieldName = "ShipAddress";
            this.colShipAddress.Name = "colShipAddress";
            this.colShipAddress.Visible = true;
            this.colShipAddress.VisibleIndex = 3;
            // 
            // colShipCity
            // 
            this.colShipCity.Caption = "ShipCity";
            this.colShipCity.FieldName = "ShipCity";
            this.colShipCity.Name = "colShipCity";
            this.colShipCity.Visible = true;
            this.colShipCity.VisibleIndex = 4;
            // 
            // colShipCountry
            // 
            this.colShipCountry.Caption = "ShipCountry";
            this.colShipCountry.FieldName = "ShipCountry";
            this.colShipCountry.Name = "colShipCountry";
            this.colShipCountry.Visible = true;
            this.colShipCountry.VisibleIndex = 5;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // employeesTableAdapter
            // 
            this.employeesTableAdapter.ClearBeforeFill = true;
            // 
            // toolTipController1
            // 
            this.toolTipController1.AllowHtmlText = true;
            // 
            // Form1
            // 
            this.toolTipController1.SetAllowHtmlText(this, DevExpress.Utils.DefaultBoolean.False);
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 414);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.toolTipController1.SetSuperTip(this, null);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private E989.Data.nwindDataSet nwindDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private E989.Data.nwindDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerID;
        private DevExpress.XtraGrid.Columns.GridColumn colEmployeeID;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colRequiredDate;
        private DevExpress.XtraGrid.Columns.GridColumn colShipName;
        private DevExpress.XtraGrid.Columns.GridColumn colShipAddress;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCity;
        private DevExpress.XtraGrid.Columns.GridColumn colShipCountry;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private E989.Data.nwindDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
        private System.Windows.Forms.BindingSource employeesBindingSource;
        private E989.Data.nwindDataSetTableAdapters.EmployeesTableAdapter employeesTableAdapter;
        private DevExpress.Utils.ToolTipController toolTipController1;
    }
}

