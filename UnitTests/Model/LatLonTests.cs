using FlightPlanner.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FlightPlanner.UnitTests
{
    [TestClass]
    public class LatLonTests
    {
        [TestMethod]
        public void ValidLatLonAllowed()
        {
            LatLon latlon = new LatLon(77, 70);
        }

        [TestMethod]
        public void CanGetLatitude()
        {
            LatLon latlon = new LatLon(77, 70);
            Assert.AreEqual(latlon.Latitude, 77);
        }

        [TestMethod]
        public void CanGetLongitude()
        {
            LatLon latlon = new LatLon(77, 70);
            Assert.AreEqual(latlon.Longitude, 70);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void LatitudeGreaterThan90ThrowsException()
        {
            LatLon latlon = new LatLon(90.1, 0);
        }

        [TestMethod]
        public void Latitude90Allowed()
        {
            LatLon latlon = new LatLon(90, 0);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void LatitudeLessThanMinus90ThrowsException()
        {
            LatLon latlon = new LatLon(-90.1, 0);
        }

        [TestMethod]
        public void LatitudeMinus90Allowed()
        {
            LatLon latlon = new LatLon(-90, 0);
        }


        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void LongitudeGreaterThan180ThrowsException()
        {
            LatLon latlon = new LatLon(0, 180.1);
        }

        [TestMethod]
        public void Longitude180Allowed()
        {
            LatLon latlon = new LatLon(0, 180);
        }

        [TestMethod]
        [ExpectedException(typeof(System.ArgumentOutOfRangeException))]
        public void LongitudeLessThanMinus90ThrowsException()
        {
            LatLon latlon = new LatLon(0, -180.01);
        }

        [TestMethod]
        public void LongitudeMinus180Allowed()
        {
            LatLon latlon = new LatLon(0, -180);
        }
    }
}
