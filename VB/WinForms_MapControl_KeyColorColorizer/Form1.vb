Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraMap

Namespace WinForms_MapControl_KeyColorColorizer
    Partial Public Class Form1
        Inherits Form

        Private Const filepath As String = "..\..\Data\Hotel1.shp"

        Public Sub New()
            InitializeComponent()
            InitializeMap()
        End Sub

        Private Sub InitializeMap()
            ' Create a Map control.
            Dim map As New MapControl() With {.Dock = DockStyle.Fill, .CoordinateSystem = New CartesianMapCoordinateSystem(), .CenterPoint = New CartesianPoint(-100, -50), .MaxZoomLevel = 3, .MinZoomLevel = 1}
            Me.Controls.Add(map)

'            #Region "#CreateLayer"
            ' Create a vector layer and add it to the map.
            Dim hotelLayer As New VectorItemsLayer() With {.Data = CreateData(), .Colorizer = CreateColorizer()}
            map.Layers.Add(hotelLayer)
'            #End Region ' #CreateLayer

'            #Region "#AddLegend"
            ' Add a legend to the map.
            map.Legends.Add(New ColorListLegend() With {.Header = "Room Type", .Layer = hotelLayer})
'            #End Region ' #AddLegend
        End Sub

        #Region "#CreateData"
        ' Creates a shapefile data adapter.
        Private Function CreateData() As IMapDataAdapter
            Dim baseUri As New Uri(System.Reflection.Assembly.GetEntryAssembly().Location)

            Dim adapter As New ShapefileDataAdapter() With {.SourceCoordinateSystem = New CartesianSourceCoordinateSystem(), .FileUri = New Uri(baseUri, filepath)}

            Return adapter
        End Function
        #End Region ' #CreateData

        #Region "#CreateColorizer"
        ' Creates a key color colorizer.
        Private Function CreateColorizer() As MapColorizer
            Dim colorizer As New KeyColorColorizer() With {.ItemKeyProvider = New AttributeItemKeyProvider() With {.AttributeName = "CATEGORY"}, .PredefinedColorSchema = PredefinedColorSchema.Palette}

            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 1, .Name = "Restaurant"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 2, .Name = "Business room"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 3, .Name = "Bathroom"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 4, .Name = "Living room"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 5, .Name = "Other"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 6, .Name = "Service room"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 7, .Name = "Pool"})
            colorizer.Keys.Add(New ColorizerKeyItem() With {.Key = 8, .Name = "Gym"})

            Return colorizer
        End Function
        #End Region ' #CreateColorizer
    End Class

End Namespace
