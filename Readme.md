<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576122/15.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T176227)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/WinForms_MapControl_KeyColorColorizer/Form1.cs) (VB: [Form1.vb](./VB/WinForms_MapControl_KeyColorColorizer/Form1.vb))
<!-- default file list end -->
# How to colorize a Cartesian map using a key-color colorizer


This example demonstrates how to load Cartesian map data to a Map control and colorize this data using a key-color colorizer.


<h3>Description</h3>

To load a vector Cartesian map,&nbsp;do the following.<br />1. Crete a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapShapefileDataAdaptertopic">ShapefileDataAdapter</a>&nbsp;object<br />2. Set its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapCoordinateSystemDataAdapterBase_SourceCoordinateSystemtopic">SourceCoordinateSystem</a>&nbsp;property to a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapCartesianSourceCoordinateSystemtopic">CartesianSourceCoordinateSystem</a>&nbsp;object.<br />3. Specify its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapShapefileDataAdapter_FileUritopic">FileUri</a>&nbsp;property.<br />4. Assign this object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Datatopic">VectorItemsLayer.Data</a>&nbsp;property.<br /><br />To colorize the map using a key-color colorizer ,do the following.<br />1. Create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapKeyColorColorizertopic">KeyColorColorizer</a>&nbsp;object.<br />2. Specify its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapKeyColorColorizer_Colorstopic">Colors</a>&nbsp;collection or its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapPredefinedColorsColorizer_PredefinedColorSchematopic">PredefinedColorSchema</a>&nbsp;property value.<br />3. Specify its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapKeyColorColorizer_Keystopic">Keys</a>&nbsp;collection (optionally).<br />4. Assign this object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Colorizertopic">VectorItemsLayer.Colorizer</a>&nbsp;property.

<br/>


