using System.Drawing;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace CSharpDiscovery.Quest03;

    public class PointOfInterest{
        public string Name {get; set;} 
        public double Latitude{get; set;}
        public double Longitude{get; set;}
        
        public static string GoogleMapsUrlTemplate { get; } = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest(){
            Name = "Bordeaux Ynov Campus";
            Latitude = 44.854186;
            Longitude = -0.5663056;
        }

        public PointOfInterest(string nameParam, double latitudeParam, double longitudeParam){
            Name = nameParam;
            Latitude = latitudeParam;
            Longitude = longitudeParam;
        }

        public string GetGoogleMapsUrl() {
            string encodedName = WebUtility.UrlEncode(Name);
            return string.Format(GoogleMapsUrlTemplate, encodedName, Latitude, Longitude);
        }

        public override string ToString() {
            return $"{Name} (Lat={Latitude}, Long={Longitude})";
        }

}