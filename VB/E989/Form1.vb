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
            gridControl1.DataSource = DataHelper.GetData(100)
        End Sub
        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            Dim groupToolTip As New GridViewGroupToolTipController(gridView1, toolTipController1)
            Dim column = gridView1.Columns("ParentID")
            column.Group()
            groupToolTip.AddColumnGroupRowToolTip(column, AddressOf GetToolTip)
        End Sub
        Private Sub GetToolTip(ByVal value As Object, ByRef title As String, ByRef text As String)
            title = String.Format("<b><color=Blue>Group</color></b>")
            text = String.Format("<b>Value</b>: {0}", value)
        End Sub

    End Class
End Namespace