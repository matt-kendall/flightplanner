using FlightPlanner.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightPlanner.UnitTests.Model
{
    [TestClass]
    public class DirectionTests
    {
        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void DegreesLessThanZeroThrowsException()
        {
            new Direction(-0.1, ReferenceNorth.Magnetic);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void DegreesGreaterThan360ThrowsExeption()
        {
            new Direction(360.01, ReferenceNorth.Magnetic);
        }

        [TestMethod]
        public void DegreesEqualZeroAllowed()
        {
            new Direction(0, ReferenceNorth.Magnetic);
        }

        [TestMethod]
        public void DegreesEqual360Allowed()
        {
            new Direction(360, ReferenceNorth.Magnetic);
        }
    }
}
