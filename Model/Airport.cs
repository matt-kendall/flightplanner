namespace FlightPlanner.Model
{
    /// <summary>
    /// Data relating to an airport facility.
    /// </summary>
    public class Airport
    {
        /// <summary>
        /// The location of the airport
        /// </summary>
        public LatLon Location { get; private set; }

        /// <summary>
        /// The name of the airport facility.
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// The four-letter ICAO code of the airport facility.
        /// </summary>
        public string ICAOCode { get; private set; }

        /// <summary>
        /// Create a new Airport instance.
        /// </summary>
        /// <param name="location">The location of the airport</param>
        /// <param name="name">The airport's name</param>
        /// <param name="icaoCode">The airport's ICAO coe</param>
        public Airport(LatLon location, string name, string icaoCode)
        {
            this.Location = location;
            this.Name = name;
            this.ICAOCode = icaoCode;
        }
    }
}
