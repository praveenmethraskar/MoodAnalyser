using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyszer;

namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenHappyMoodMessage_ShouldreturnHappy()
        {
            //arrange
            MoodAnalyser mood = new MoodAnalyser("");
            string Expectedresult = "Happy";
            //act
            string Actualresult = mood.Moodanalyse();

            //assert
            Assert.AreEqual(Expectedresult, Actualresult);
        }


        [TestMethod]
        public void GivenSadMoodMessage_ShouldreturnSad()
        {
            //arrange
            MoodAnalyser mood = new MoodAnalyser("Sad");
            string Expectedresult = "Sad";
            //act
            string Actualresult = mood.Moodanalyse();

            //assert
            Assert.AreEqual(Expectedresult, Actualresult);
        }


    }
}