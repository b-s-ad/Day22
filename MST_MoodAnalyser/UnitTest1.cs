using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;


namespace MoodAnalyser // UC 1 // TC 1.2
{
    [TestClass]
    public class UnitTest1
    {
        /*[TestMethod] // SAD
        public void UC1_GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            string expected = "SAD";
            string message = " I am in Sad Mood ";
            MoodAnalyser moodanalyse = new MoodAnalyser(message);

            //Act
            string mood = moodanalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);

        }
*/
        [TestMethod] // HAPPY

        public void UC1_GivenHappyMoodShouldReturnHAPPY()
        {
            //Arrange
            string expected = "HAPPY";
            string message = " I am in Happy Mood ";
            MoodAnalyser moodanalyse = new MoodAnalyser(message);

            //Act
            string mood = moodanalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);




        }
    }
}
