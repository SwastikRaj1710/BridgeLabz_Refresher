using UserRegistrationProblem;

namespace UserRegistrationProblemTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestFirstName()
        {
            Program obj = new Program();
            bool result = obj.CheckFirstName("Swastik");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestLastName()
        {
            Program obj = new Program();
            bool result = obj.CheckLastName("Singh");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestEmail()
        {
            Program obj = new Program();
            bool result = obj.CheckEmail("swastikraj1710@gmail.com");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPhone()
        {
            Program obj = new Program();
            bool result = obj.CheckPhoneNumber("91 7760484255");
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestPassword()
        {
            Program obj = new Program();
            bool result = obj.CheckPassword("Srs@7777");
            Assert.IsTrue(result);
        }
    }
}