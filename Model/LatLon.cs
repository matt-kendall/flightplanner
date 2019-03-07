using System.Device.Location;

namespace FlightPlanner.Model
{
    /// <summary>
    /// Represents a geographic location as a latitude / longitude.
    /// </summary>
    public class LatLon
    {
        private GeoCoordinate coordinate;

        /// <summary>
        /// The latitude of the location.
        /// </summary>
        public double Latitude {
            get { return coordinate.Latitude; }
        }

        /// <summary>
        /// The longitude of the location.
        /// </summary>
        public double Longitude
        {
            get { return coordinate.Longitude; }
        }

        /// <summary>
        /// Create a new LatLon instance.
        /// </summary>
        /// <param name="lat">The latitude in degrees (between -90 and 90)</param>
        /// <param name="lon">The longitude in degrees (between -180 and 180)</param>
        public LatLon(double lat, double lon)
        {
            this.coordinate = new GeoCoordinate(lat, lon);
        }
    }
}
