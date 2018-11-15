<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/E989/Form1.cs) (VB: [Form1.vb](./VB/E989/Form1.vb))
* [GridViewGroupToolTipController.cs](./CS/E989/GridViewGroupToolTipController.cs) (VB: [GridViewGroupToolTipController.vb](./VB/E989/GridViewGroupToolTipController.vb))
<!-- default file list end -->
# Showing tooltips for group rows in the grid


<p>You can use the GridViewGroupToolTipController helper class to show a tooltip for group rows.<br />
There are two constructors:<br />


```cs
<newline/>
GridViewGroupToolTipController(GridView view); // Use the default Tooltip controller<newline/>
GridViewGroupToolTipController(GridView view, ToolTipController tooltip);<newline/>

```

</p><p>Call the AddColumnGroupRowToolTip method to enable tooltips for particular group rows.<br />


```cs
<newline/>
void AddColumnGroupRowToolTip(GridColumn column, GridViewGroupToolTipControllerShowControlInfo toolTipCallback)<newline/>

```

column - the grouped column. The tooltip will be shown for its group rows only.<br />
toolTipCallback - a delegate that allows you to set the tooltip's title and text.<br />


```cs
<newline/>
delegate void GridViewGroupToolTipControllerShowControlInfo(object value, out string text, out string title)<newline/>

```

value - the grouped value<br />
text - tooltip text<br />
title - tooltip title</p>

<br/>


