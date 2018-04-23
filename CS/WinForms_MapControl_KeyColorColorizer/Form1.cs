using System;
using System.Windows.Forms;
using DevExpress.XtraMap;

namespace WinForms_MapControl_KeyColorColorizer {
    public partial class Form1 : Form {
        const string filepath = "..\\..\\Data\\Hotel1.shp";
        
        public Form1() {
            InitializeComponent();
            InitializeMap();
        }

        private void InitializeMap() {
            // Create a Map control.
            MapControl map = new MapControl() {
                Dock = DockStyle.Fill,
                CoordinateSystem = new CartesianMapCoordinateSystem(),
                CenterPoint = new CartesianPoint(-100, -50),
                MaxZoomLevel = 3,
                MinZoomLevel = 1
            };
            this.Controls.Add(map);

            #region #CreateLayer
            // Create a vector layer and add it to the map.
            VectorItemsLayer hotelLayer = new VectorItemsLayer() {
                Data = CreateData(),
                Colorizer = CreateColorizer()
            };
            map.Layers.Add(hotelLayer);
            #endregion #CreateLayer

            #region #AddLegend
            // Add a legend to the map.
            map.Legends.Add(new ColorListLegend() {
                Header = "Room Type",
                Layer = hotelLayer
            });
            #endregion #AddLegend
        }

        #region #CreateData
        // Creates a shapefile data adapter.
        private IMapDataAdapter CreateData() {
            Uri baseUri = new Uri(System.Reflection.Assembly.GetEntryAssembly().Location);

            ShapefileDataAdapter adapter = new ShapefileDataAdapter() {
                SourceCoordinateSystem = new CartesianSourceCoordinateSystem(),
                FileUri = new Uri(baseUri, filepath)
            };
        
            return adapter;
        }
        #endregion #CreateData

        #region #CreateColorizer
        // Creates a key color colorizer.
        private MapColorizer CreateColorizer() {
            KeyColorColorizer colorizer = new KeyColorColorizer() {
                ItemKeyProvider = new AttributeItemKeyProvider() { AttributeName = "CATEGORY" },
                PredefinedColorSchema = PredefinedColorSchema.Palette
            };

            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 1, Name = "Restaurant" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 2, Name = "Business room" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 3, Name = "Bathroom" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 4, Name = "Living room" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 5, Name = "Other" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 6, Name = "Service room" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 7, Name = "Pool" });
            colorizer.Keys.Add(new ColorizerKeyItem() { Key = 8, Name = "Gym" });

            return colorizer;
        }
        #endregion #CreateColorizer
    }

}
