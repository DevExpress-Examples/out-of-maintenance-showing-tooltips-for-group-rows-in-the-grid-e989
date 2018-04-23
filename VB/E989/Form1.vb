Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.ToolTip

Namespace E989
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			Dim groupToolTip As New GridViewGroupToolTipController(gridView1, toolTipController1)
			groupToolTip.AddColumnGroupRowToolTip(colEmployeeID, AddressOf EmployeeToolTip)
			groupToolTip.AddColumnGroupRowToolTip(colCustomerID, AddressOf CustomerToolTip)
		End Sub
		Private Sub EmployeeToolTip(ByVal value As Object, <System.Runtime.InteropServices.Out()> ByRef text As String, <System.Runtime.InteropServices.Out()> ByRef title As String)
			Dim row As E989.Data.nwindDataSet.EmployeesRow = Me.nwindDataSet.Employees.FindByEmployeeID(CInt(Fix(value)))
			title = String.Format("<b><color=Blue>{0} {1}</color></b>", row.FirstName, row.LastName)
			text = String.Format("<b>Birth date</b>: {0}" & Constants.vbLf & "<b>Home phone</b>: {1}" & Constants.vbLf & " <size=-1>{2}", row.BirthDate, row.HomePhone, row.Notes)
		End Sub
		Private Sub CustomerToolTip(ByVal value As Object, <System.Runtime.InteropServices.Out()> ByRef text As String, <System.Runtime.InteropServices.Out()> ByRef title As String)
			Dim row As E989.Data.nwindDataSet.CustomersRow = Me.nwindDataSet.Customers.FindByCustomerID(CStr(value))

			title = String.Format("<b><color=Green>{0}</color></b>", row.CompanyName)
			text = String.Format("<b>Contact Name</b>: {0}" & Constants.vbLf & "<b>Phone</b>: {1}" & Constants.vbLf & "<b>Country</b>: {2}" & Constants.vbLf & "<b>City</b>: {3}" & Constants.vbLf & "<b>Address</b>: {4}" & Constants.vbLf, row.ContactName, row.Phone, row.Country, row.City, row.Address)
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Employees' table. You can move, or remove it, as needed.
			Me.employeesTableAdapter.Fill(Me.nwindDataSet.Employees)
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)
			' TODO: This line of code loads data into the 'nwindDataSet.Orders' table. You can move, or remove it, as needed.
			Me.ordersTableAdapter.Fill(Me.nwindDataSet.Orders)

		End Sub

	End Class
End Namespace