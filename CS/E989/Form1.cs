using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.ToolTip;

namespace E989 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            GridViewGroupToolTipController groupToolTip = new GridViewGroupToolTipController(gridView1, toolTipController1);
            groupToolTip.AddColumnGroupRowToolTip(colEmployeeID, EmployeeToolTip);
            groupToolTip.AddColumnGroupRowToolTip(colCustomerID, CustomerToolTip);
        }
        void EmployeeToolTip(object value, out string text, out string title) {
            E989.Data.nwindDataSet.EmployeesRow row = this.nwindDataSet.Employees.FindByEmployeeID((int)value);
            title = string.Format("<b><color=Blue>{0} {1}</color></b>", row.FirstName, row.LastName);
            text = string.Format("<b>Birth date</b>: {0}\n<b>Home phone</b>: {1}\n <size=-1>{2}", row.BirthDate, row.HomePhone, row.Notes);
        }
        void CustomerToolTip(object value, out string text, out string title) {
            E989.Data.nwindDataSet.CustomersRow row = this.nwindDataSet.Customers.FindByCustomerID((string)value);

            title = string.Format("<b><color=Green>{0}</color></b>", row.CompanyName);
            text = string.Format("<b>Contact Name</b>: {0}\n<b>Phone</b>: {1}\n<b>Country</b>: {2}\n<b>City</b>: {3}\n<b>Address</b>: {4}\n", row.ContactName, row.Phone, row.Country, row.City, row.Address);
        }

        private void Form1_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.nwindDataSet.Employees);
            // TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.nwindDataSet.Customers);
            // TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.nwindDataSet.Orders);

        }

    }
}