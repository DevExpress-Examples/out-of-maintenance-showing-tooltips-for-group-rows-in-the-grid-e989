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
            gridControl1.DataSource = DataHelper.GetData(100);
        }
        protected override void OnShown(EventArgs e) {
            base.OnShown(e);
            GridViewGroupToolTipController groupToolTip = new GridViewGroupToolTipController(gridView1, toolTipController1);
            var column = gridView1.Columns["ParentID"];
            column.Group();
            groupToolTip.AddColumnGroupRowToolTip(column, GetToolTip);
        }
        void GetToolTip(object value, out string title, out string text) {
            title = string.Format("<b><color=Blue>Group</color></b>");
            text = string.Format("<b>Value</b>: {0}", value);
        }

    }
}