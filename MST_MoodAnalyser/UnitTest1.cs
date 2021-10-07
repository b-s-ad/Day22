using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;


namespace MoodAnalyser // UC 2.1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] // HAPPY
        [DataRow(null)]
        public void UC2_GivenHappyMoodShouldReturnHAPPY(string message)
        {

            //Arrange
            string expected = "HAPPY";
            MoodAnalyser moodanalyse = new MoodAnalyser(message);

            //Act
            string mood = moodanalyse.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, mood);




        }
    }

}