using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.Utils;

namespace DevExpress.XtraGrid.Views.ToolTip {

    public delegate void GridViewGroupToolTipControllerShowControlInfo(object value, out string text, out string title);

    public class GridViewGroupToolTipController {
        GridView _gridView;
        Dictionary<GridColumn, GridViewGroupToolTipControllerShowControlInfo> columns;
        ToolTipController tooltip;

        //Use Default Tooltip controller
        public GridViewGroupToolTipController(GridView _gridView) : this(_gridView, null) { }
        public GridViewGroupToolTipController(GridView _gridView, ToolTipController tooltip) {
            this._gridView = _gridView;
            this.columns = new Dictionary<GridColumn, GridViewGroupToolTipControllerShowControlInfo>();
            this.tooltip = tooltip;
            View.MouseLeave += new EventHandler(OnView_MouseLeave);
            View.MouseMove += new MouseEventHandler(OnView_MouseMove);
        }
        public void AddColumnGroupRowToolTip(GridColumn column, GridViewGroupToolTipControllerShowControlInfo toolTipCallback) {
            Columns[column] = toolTipCallback;
        }
        void OnView_MouseMove(object sender, MouseEventArgs e) {
            GridHitInfo hitInfo = View.CalcHitInfo(e.X, e.Y);
            if (!View.IsGroupRow(hitInfo.RowHandle)) {
                ToolTip.HideHint();
            } else {
                GridColumn column = GetColumnByGroupRowHandle(hitInfo.RowHandle);
                if (column != null && Columns.ContainsKey(column)) {
                    object value = View.GetGroupRowValue(hitInfo.RowHandle);
                    string text, title;
                    Columns[column](value, out text, out title);
                    ToolTip.ShowHint(new DevExpress.Utils.ToolTipControlInfo(hitInfo.RowHandle, text, title));
                } else {
                    ToolTip.HideHint();
                }
            }
            
        }
        GridColumn GetColumnByGroupRowHandle(int rowHandle) {
            return View.GroupedColumns[View.GetRowLevel(rowHandle)];
        }
        void OnView_MouseLeave(object sender, EventArgs e) {
            ToolTip.HideHint();
        }
        public GridView View { get { return _gridView; } }
        protected Dictionary<GridColumn, GridViewGroupToolTipControllerShowControlInfo> Columns { get { return columns; } }
        protected ToolTipController ToolTip { get { return tooltip != null ? tooltip : ToolTipController.DefaultController; } }
    }
}
