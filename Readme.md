# How to colorize a Cartesian map using a key-color colorizer


This example demonstrates how to load Cartesian map data to a Map control and colorize this data using a key-color colorizer.


<h3>Description</h3>

<p>To load a vector Cartesian map,&nbsp;do the following.<br />1. Crete a <strong>ShapefileDataAdapter</strong> object<br />2. Set its&nbsp;<strong>SourceCoordinateSystem</strong> property to a <strong>CartesianSourceCoordinateSystem</strong> object.<br />3. Specify its <strong>FileUri</strong> property.<br />4. Assign this object to the <strong>VectorItemsLayer.Data</strong> property.<br /><br />To colorize the map using a key-color colorizer ,do the following.<br />1. Create a <strong>KeyColorColorizer</strong> object.<br />2. Specify its <strong>Colors</strong> collection or its <strong>PredefinedColorSchema</strong> property value.<br />3. Specify its <strong>Keys</strong> collection (optionally).<br />4. Assign this object to the <strong>VectorItemsLayer.Colorizer</strong> property.</p>

<br/>


