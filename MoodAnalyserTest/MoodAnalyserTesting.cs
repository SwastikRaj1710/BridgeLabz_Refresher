using MoodAnalyser;

namespace MoodAnalyserTest
{
    [TestClass]
    public class MoodAnalyserTesting
    {

        [TestMethod]
        public void GivenHappyString_returnHappyMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("I am very happy today");
            Assert.AreEqual(mood, "Happy");
        }

        [TestMethod]
        public void GivenSadString_returnSadMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("I am sad");
            Assert.AreEqual(mood, "Sad");
        }

        [TestMethod]
        public void GivenNullString_returnHappyMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("");
            Assert.AreEqual(mood, "Happy");
        }

        [TestMethod]
        public void GivenEmptyString_returnEmptyMood()
        {
            Analyze obj = new Analyze();
            string mood = obj.AnalyseMood("I am doing good today");
            Assert.AreEqual(mood, "");
        }


    }
}