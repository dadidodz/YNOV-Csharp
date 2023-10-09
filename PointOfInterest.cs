namespace CSharpDiscovery.Quest03;

public class PointOfInterest{

        public double Latitude;

        public double Longitude;
        public string Name;

        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest(){
            Latitude = 0;
            Longitude = 0;
            Name = "";
        }
    }