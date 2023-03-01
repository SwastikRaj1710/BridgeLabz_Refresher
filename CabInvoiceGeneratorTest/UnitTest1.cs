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
            int result = obj.TotalFare(5, 30);
            Assert.AreEqual(result, 85);
        }
    }
}