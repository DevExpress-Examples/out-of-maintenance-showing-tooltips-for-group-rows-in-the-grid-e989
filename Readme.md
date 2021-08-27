<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128632582/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E989)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
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


