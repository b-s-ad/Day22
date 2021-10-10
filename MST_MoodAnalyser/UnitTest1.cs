using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

using System;


namespace MoodAnalyser  // 4.1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]  // UC 4.1
                        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
                        {
                        object expected = new MoodAnalyser("HAPPY");
                        object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyser", "MoodAnalyser", "SAD");
                        expected.Equals(obj);
                        }




        /*
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

        */

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

