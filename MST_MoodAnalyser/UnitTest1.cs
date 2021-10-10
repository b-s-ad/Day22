using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

using System;


namespace MoodAnalyser  // 3.1 Null 
{
    [TestClass]
    public class UnitTest1
    {

       

[TestMethod] // Null 3.1
        
        public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
         {
                try
                {
                    //Arrange
                    string message = null;
                    MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                    //Act    
                    string mood = moodAnalyse.AnalyseMood();    
            }

                //Assert
                catch (MoodAnalyserCustomException e)
                {
                    Assert.AreNotEqual("Mood Should not be null", e.Message);
                }
            }



/*
[TestMethod] // Empty 3.2
        
        public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_EmptyMood()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyser moodAnalyse = new MoodAnalyser(message);
                //Act    
                string mood = moodAnalyse.AnalyseMood();
            }

            //Assert
            catch (MoodAnalyserCustomException e)
            {
                Assert.AreNotEqual("Mood Should not be Empty", e.Message);
            }
        }

*/


    }
}

