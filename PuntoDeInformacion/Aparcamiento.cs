
using GMap.NET.MapProviders;
using GMap.NET;
using System.Windows.Forms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.ToolTips;
using System.Drawing;

namespace PuntoDeInformacion
{
    public partial class Aparcamiento : Form
    {
        public Aparcamiento()
        {
            InitializeComponent();
            // Establece la ubicación del mapa en función de la longitud y latitud
            double lat = 37.18427416851331;  
            double lng = -3.593387299813099;
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(lat, lng);
            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 17;
            gMapControl1.Zoom = 16;


            // Agrega un marcador en la latitud 37.18427416851331 y en la lng -3.593387299813099
            double markerLat = lat;
            double markerLng = lng;
            PointLatLng markerLocation = new PointLatLng(markerLat, markerLng);
            GMapMarker marker = new GMarkerGoogle(markerLocation, GMarkerGoogleType.red);
            marker.ToolTip = new GMapRoundedToolTip(marker)
            {
                Stroke = new Pen(SystemColors.ControlDarkDark),
                Fill = new SolidBrush(SystemColors.Info),
                Foreground = new SolidBrush(SystemColors.InfoText)
            };
            GMapOverlay markersOverlay = new GMapOverlay("markers");
            markersOverlay.Markers.Add(marker);
            gMapControl1.Overlays.Add(markersOverlay);

            // Agrega un marcador en la latitud 37.18420503186501 y en la lng -3.5960457598198783
            double markerLat2 = 37.18420503186501;
            double markerLng2 = -3.5960457598198783;
            PointLatLng markerLocation2 = new PointLatLng(markerLat2, markerLng2);
            GMapMarker marker2 = new GMarkerGoogle(markerLocation2, GMarkerGoogleType.blue);
            marker2.ToolTip = new GMapRoundedToolTip(marker2)
            {
                Stroke = new Pen(SystemColors.ControlDarkDark),
                Fill = new SolidBrush(SystemColors.Info),
                Foreground = new SolidBrush(SystemColors.InfoText)
            };
            GMapOverlay markersOverlay2 = new GMapOverlay("markers");
            markersOverlay2.Markers.Add(marker2);
            gMapControl1.Overlays.Add(markersOverlay2);


            // Agrega un marcador en la latitud 37.188087 y en la lng -3.594333
            double markerLat3 = 37.188087;
            double markerLng3 = -3.594333;
            PointLatLng markerLocation3 = new PointLatLng(markerLat3, markerLng3);
            GMapMarker marker3 = new GMarkerGoogle(markerLocation3, GMarkerGoogleType.blue);
            marker3.ToolTip = new GMapRoundedToolTip(marker3)
            {
                Stroke = new Pen(SystemColors.ControlDarkDark),
                Fill = new SolidBrush(SystemColors.Info),
                Foreground = new SolidBrush(SystemColors.InfoText),
                
                
            };
            GMapOverlay markersOverlay3 = new GMapOverlay("markers");
            markersOverlay3.Markers.Add(marker3);
            gMapControl1.Overlays.Add(markersOverlay3);

            
        }

    }

}
