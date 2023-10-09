namespace CSharpDiscovery.Quest03;

    public class PointOfInterest{

        private double latitude;
        public double Latitude{
            get { return latitude; }
            set { latitude = 0.0d; }
        }
        private double longitude;
        public double Longitude{
            get { return longitude; }
            set { longitude = 0.0d; }
        }
        private string name;
        public string Name   // property
        {
            get { return name; }
            set { name = "f "; }
        }

        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
    }