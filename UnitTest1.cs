using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserDay20;

namespace MoodAnalyserDay20Test
{
    [TestClass]
    public class TestMood
    {
        [TestMethod]
        public void SadMood()

        {
            string msg = "Iam in sad mood";
            string expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser();
            string actual = moodAnalyser.AnalyseMood(msg);
            Assert.AreEqual(expected, actual);

        }

        public void HappyMood()
        {
            string msg = "I am in Any mood";
            string expected = "HAPPY";

            MoodAnalyser mood = new MoodAnalyser();

            string actual = mood.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
        }

    }
}

