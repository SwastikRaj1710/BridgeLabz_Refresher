using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestHappyMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("I am very happy today");
            Assert.AreEqual(mood, "Happy");
        }

        [TestMethod]
        public void TestSadMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("I am sad");
            Assert.AreEqual(mood, "Sad");
        }

        [TestMethod]
        public void TestNullMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("");
            Assert.AreEqual(mood, "Happy");
        }

        [TestMethod]
        public void TestEmptyMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("I am doing good today");
            Assert.AreEqual(mood, "");
        }


    }
}