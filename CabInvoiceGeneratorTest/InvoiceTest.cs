using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class TotalFareTest
    {
        [TestMethod]
        public void GivenKmMinute_returnTotalFare()
        {
            Ride r1 = new Ride(5, 30);
            Ride r2 = new Ride(10, 50);
            Ride r3 = new Ride(20, 100);
            List<Ride> rides = new List<Ride>() { r1, r2, r3 };
            Dictionary<int,List<Ride>> dict = new Dictionary<int,List<Ride>>();
            dict.Add(1,rides);
            Invoice obj = new Invoice();
            List<Ride> ride = obj.GetAllRides(1, dict);
            int result = obj.TotalFare(ride);
            Assert.AreEqual(result, 535);
        }

        [TestMethod]
        public void GivenKmMinute_returnTotalNoOfRides()
        {
            Ride r1 = new Ride(5, 30);
            Ride r2 = new Ride(10, 50);
            Ride r3 = new Ride(20, 100);
            List<Ride> rides = new List<Ride>() { r1, r2, r3 };
            Dictionary<int, List<Ride>> dict = new Dictionary<int, List<Ride>>();
            dict.Add(1, rides);
            Invoice obj = new Invoice();
            List<Ride> ride = obj.GetAllRides(1, dict);
            int result = obj.TotalNoOfRides(ride);
            Assert.AreEqual(result, 3);
        }

        [TestMethod]
        public void GivenKmMinute_returnAverageFarePerRide()
        {
            Ride r1 = new Ride(5, 30);
            Ride r2 = new Ride(10, 55);
            Ride r3 = new Ride(20, 100);
            List<Ride> rides = new List<Ride>() { r1, r2, r3 };
            Dictionary<int, List<Ride>> dict = new Dictionary<int, List<Ride>>();
            dict.Add(1, rides);
            Invoice obj = new Invoice();
            List<Ride> ride = obj.GetAllRides(1, dict);
            double result = obj.AverageFarePerRide(ride);
            Assert.AreEqual(result, 180);
        }
    }
}