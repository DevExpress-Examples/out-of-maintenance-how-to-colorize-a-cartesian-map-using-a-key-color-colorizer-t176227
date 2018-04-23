# How to colorize a Cartesian map using a key-color colorizer


This example demonstrates how to load Cartesian map data to a Map control and colorize this data using a key-color colorizer.


<h3>Description</h3>

To load a vector Cartesian map,&nbsp;do the following.<br />1. Crete a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapShapefileDataAdaptertopic">ShapefileDataAdapter</a>&nbsp;object<br />2. Set its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapCoordinateSystemDataAdapterBase_SourceCoordinateSystemtopic">SourceCoordinateSystem</a>&nbsp;property to a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapCartesianSourceCoordinateSystemtopic">CartesianSourceCoordinateSystem</a>&nbsp;object.<br />3. Specify its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapShapefileDataAdapter_FileUritopic">FileUri</a>&nbsp;property.<br />4. Assign this object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Datatopic">VectorItemsLayer.Data</a>&nbsp;property.<br /><br />To colorize the map using a key-color colorizer ,do the following.<br />1. Create a <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraMapKeyColorColorizertopic">KeyColorColorizer</a>&nbsp;object.<br />2. Specify its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapKeyColorColorizer_Colorstopic">Colors</a>&nbsp;collection or its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapPredefinedColorsColorizer_PredefinedColorSchematopic">PredefinedColorSchema</a>&nbsp;property value.<br />3. Specify its <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapKeyColorColorizer_Keystopic">Keys</a>&nbsp;collection (optionally).<br />4. Assign this object to the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapVectorItemsLayer_Colorizertopic">VectorItemsLayer.Colorizer</a>&nbsp;property.

<br/>


