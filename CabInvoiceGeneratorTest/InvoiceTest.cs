using CabInvoiceGenerator;

namespace CabInvoiceGeneratorTest
{
    [TestClass]
    public class TotalFareTest
    {
        [TestMethod]
        public void GivenKmMinute_returnTotalFare()
        {
            Invoice obj = new Invoice();
            Ride r1 = new Ride(5, 30);
            Ride r2 = new Ride(10, 50);
            int result = obj.TotalFare(new List<Ride>() { r1,r2 });
            Assert.AreEqual(result, 235);
        }

        [TestMethod]
        public void GivenKmMinute_returnTotalNoOfRides()
        {
            Invoice obj = new Invoice();
            Ride r1 = new Ride(5, 30);
            Ride r2 = new Ride(10, 50);
            int result = obj.TotalNoOfRides(new List<Ride>() { r1, r2 });
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void GivenKmMinute_returnAverageFarePerRide()
        {
            Invoice obj = new Invoice();
            Ride r1 = new Ride(5, 30);
            Ride r2 = new Ride(10, 50);
            double result = obj.AverageFarePerRide(new List<Ride>() { r1, r2 }) ;
            Assert.AreEqual(result, 117.5);
        }
    }
}