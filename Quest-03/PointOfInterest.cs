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

        public int GetDistance(PointOfInterest other)
        {
            return (int)Math.Round(CalculationDistance(this.Latitude, this.Longitude, other.Latitude, other.Longitude));
        }

         public static int GetDistance(PointOfInterest p1, PointOfInterest p2) {
            return (int)Math.Round(CalculationDistance(p1.Latitude, p1.Longitude, p2.Latitude, p2.Longitude));
        }
        private static double CalculationDistance(double lat1, double lon1, double lat2, double lon2) {
            const double R = 6371.0; // Radius of the Earth in kilometers
            var lat1Rad = DegreesToRadians(lat1);
            var lat2Rad = DegreesToRadians(lat2);
            var deltaLat = DegreesToRadians(lat2 - lat1);
            var deltaLon = DegreesToRadians(lon2 - lon1);
            var a = Math.Sin(deltaLat / 2) * Math.Sin(deltaLat / 2) +
                    Math.Cos(lat1Rad) * Math.Cos(lat2Rad) * 
                    Math.Sin(deltaLon / 2) * Math.Sin(deltaLon / 2);
            var c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));
            return R * c;
        }

        private static double DegreesToRadians(double degrees) {
            return degrees * (Math.PI / 180);
        }

        public override string ToString() {
            return $"{Name} (Lat={Latitude}, Long={Longitude})";
        }

}