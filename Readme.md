<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576122/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T176227)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinForms_MapControl_KeyColorColorizer/Form1.cs) (VB: [Form1.vb](./VB/WinForms_MapControl_KeyColorColorizer/Form1.vb))
* [Program.cs](./CS/WinForms_MapControl_KeyColorColorizer/Program.cs) (VB: [Program.vb](./VB/WinForms_MapControl_KeyColorColorizer/Program.vb))
<!-- default file list end -->
# How to colorize a Cartesian map using a key-color colorizer


This example demonstrates how to load Cartesian map data to a Map control and colorize this data using a key-color colorizer.


<h3>Description</h3>

<p>To load a vector Cartesian map,&nbsp;do the following.<br />1. Crete a <strong>ShapefileDataAdapter</strong> object<br />2. Set its&nbsp;<strong>SourceCoordinateSystem</strong> property to a <strong>CartesianSourceCoordinateSystem</strong> object.<br />3. Specify its <strong>FileUri</strong> property.<br />4. Assign this object to the <strong>VectorItemsLayer.Data</strong> property.<br /><br />To colorize the map using a key-color colorizer ,do the following.<br />1. Create a <strong>KeyColorColorizer</strong> object.<br />2. Specify its <strong>Colors</strong> collection or its <strong>PredefinedColorSchema</strong> property value.<br />3. Specify its <strong>Keys</strong> collection (optionally).<br />4. Assign this object to the <strong>VectorItemsLayer.Colorizer</strong> property.</p>

<br/>


