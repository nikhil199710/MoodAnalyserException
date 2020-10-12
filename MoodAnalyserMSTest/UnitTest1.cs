using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserExceptionDeck;

namespace MoodAnalyserMSTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GiveSadMoodReturnSAD()
        {
            string message = "I am Sad";
            string expected = "Sad";
            MoodAnalyser moodanalyser = new MoodAnalyser(message);
            
            string mood = moodanalyser.analyseMood();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        [DataRow(null)]
        public void GiveNullReturnSAD(string message)
        {

            //string message = "I am Sad";
            string expected = "Happy";
            MoodAnalyser moodanalyser = new MoodAnalyser(message);

            string mood = moodanalyser.analyseMood();

            Assert.AreEqual(expected, mood);
        }

        [TestMethod]
        public void Given_Empty_Mood_Should_Throw_CustomException_Indicating_EmptyMood()
        {
            try
            {
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                string mood = moodAnalyser.analyseMoodCustom();
            }
            catch(MoodAnalyserCustomException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }
    }
}
