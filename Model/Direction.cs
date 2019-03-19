using System;

namespace FlightPlanner.Model
{
    /// <summary>
    /// A direction which may be relative to either true north or magnetic north.
    /// </summary>
    public class Direction
    {
        /// <summary>
        /// The reference North (0 degrees) for this direction (e.g. magnetic or true).
        /// </summary>
        public ReferenceNorth North { get; private set; }

        /// <summary>
        /// Get the direction in degrees (0 - 360).
        /// </summary>
        public double Degrees { get; private set; }

        /// <summary>
        /// Create a new direction instance.
        /// </summary>
        /// <param name="degrees">The direction in degrees (0 - 360)</param>
        /// <param name="referenceNorth">The reference North to which this direction is relative</param>
        public Direction(double degrees, ReferenceNorth referenceNorth)
        {
            if (degrees < 0 || degrees > 360)
            {
                throw new ArgumentOutOfRangeException($"The degrees for a direction must be between 0 and 360 (was {degrees}).");
            }

            this.North = referenceNorth;
            this.Degrees = degrees;
        }
    }
}
