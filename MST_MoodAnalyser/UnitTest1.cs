using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;


namespace MoodAnalyser // UC 1 // Refactor 1.2 HAPPY
{
    [TestClass]
    public class UnitTest1
    {
        /*[TestMethod] // SAD
        public void UC1_GivenSadMoodShouldReturnSAD()
        {
            //Arrange
            
            MoodAnalyser moodanalyse = new MoodAnalyser(" I am in Sad Mood ");

            //Act
            string mood = moodanalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("SAD", mood);

        }*/

        [TestMethod] // HAPPY

        public void UC1_GivenHappyMoodShouldReturnHAPPY()
        {
            //Arrange

            MoodAnalyser moodanalyse = new MoodAnalyser(" I am in Happy Mood ");

            //Act
            string mood = moodanalyse.AnalyseMood();

            //Assert
            Assert.AreEqual("HAPPY", mood);




        }
    }

}