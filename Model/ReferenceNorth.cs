namespace FlightPlanner.Model
{
    /// <summary>
    /// Enum to represent different references for measuring north.
    /// </summary>
    public enum ReferenceNorth
    {
        /// <summary>
        /// North is relative to the magnetic north pole.
        /// </summary>
        Magnetic,

        /// <summary>
        /// North is relative to the geographical (true) north pole.
        /// </summary>
        True
    }
}
