using System.Drawing;
using System.Reflection.Metadata.Ecma335;

namespace CSharpDiscovery.Quest03;

    public class PointOfInterest{

        private string name;
        public string Name   // property
        {
            get { return name; }
            set { name = "f "; }
        }

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
        
        private static string googleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
        public static string GoogleMapsUrlTemplate{
            get { return googleMapsUrlTemplate; }
        }

        public PointOfInterest(){
            name = "Bordeaux Ynov Campus";
            latitude = 44.854186;
            longitude = -0.5663056;
        }

        public PointOfInterest(string nameParam, double latitudeParam, double longitudeParam){
            name = nameParam;
            latitude = latitudeParam;
            longitude = longitudeParam;
        }

        public string GetGoogleMapsUrl() {
            string a = googleMapsUrlTemplate;
            string.Format(a, name, latitude, longitude);
            return a;
        }
        
    }