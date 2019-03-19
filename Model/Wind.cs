namespace FlightPlanner.Model
{
    /// <summary>
    /// Represents a wind measurement or forecast.
    /// </summary>
    public class Wind
    {
        /// <summary>
        /// The reported or forecast wind speed in knots.
        /// This may be zero if wind is calm or null if wind is variable.
        /// </summary>
        public double Speed { get; private set; }

        /// <summary>
        /// The direction of the wind.
        /// This may be null if wind is calm or variable.
        /// </summary>
        public Direction Heading { get; private set; }

        /// <summary>
        /// The altitude at which the wind measurement is valid.
        /// </summary>
        public double Altitude { get; private set; }

        /// <summary>
        /// Create a new Wind instance.
        /// </summary>
        /// <param name="heading">The heading of the wind (or null if calm or variable)</param>
        /// <param name="speed">The speed of the wind (or null if variable)</param>
        /// <param name="altitude">The altitude at which the wind measurement is valid</param>
        public Wind(Direction heading, double speed, double altitude)
        {
            this.Heading = heading;
            this.Speed = speed;
            this.Altitude = altitude;
        }
    }
}
