using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;
using System;


namespace MoodAnalyser // UC 1 // TC 1.1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod] // SAD
        public void UC1_GivenSadMoodShouldReturnSAD()// TC 1.1
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

            }
        }

