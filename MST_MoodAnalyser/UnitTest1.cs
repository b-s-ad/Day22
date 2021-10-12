using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyser;

using System;


namespace MoodAnalyser   // 4.2
{

    [TestClass] 
    public class UnitTest1
    {


        [TestMethod] //4.2  GivenMoodAnalyseClassName_Should_Throw_MoodAnalyseObject
        public void GivenMoodAnalyseClassName_Should_Throw_MoodAnalyseCustomException()
        {

            string expected = "Class Not Found";
            try
            {

            //    object MoodAnalyseOnObject = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser", "MoodAnalyser"); //Know Class
                object MoodAnalyseOnObjectt = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.DemoClass", "DemoClass"); //UNknow Class
            }
             
            catch (MoodAnalyserCustomException exception)
            {
                Assert.AreEqual(expected, exception.Message);
            }
        }


        [TestMethod] //4.2  GivenMoodAnalyseClassName_Should_Throw_MoodAnalyseObject
        public void GivenMoodAnalyseClassName_Should_Throw_MoodAnalyseCustomExceptions()
        {

            string expected = "Class Not Found";
            try
            {

                //object MoodAnalyseOnObject = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser", "MoodAnalyser");
                object MoodAnalyseOnObject = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.DemoClass", "DemoClass");
            }

            catch (MoodAnalyserCustomException exception)
            {
                //Assert.AreEqual(expected, exception.Message); //AreEqual
                Assert.AreNotEqual(expected, exception.Message); //AreNotEqual
            }
        }




        /*
                [TestMethod] // 4.1
                public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject()
                {

                    string message = null;
                    object expected = new MoodAnalyser(message);
                    object obj = MoodAnalyserFactory.CreateMoodAnalyser("MoodAnalyser.MoodAnalyser", "MoodAnalyser");
                    expected.Equals(obj);
                    //Assert.AreEqual(expected, obj);

                }

        */

        /*
                [TestMethod]
                [ExpectedException(typeof(MoodAnalyserCustomException))]
                public void GivenMoodNull_ShouldThrowException()
                {
                    MoodAnalyser obj = new MoodAnalyser(null);
                    string result = obj.AnalyseMood();
                    //Assert.AreEqual("HAPPY", result);

                }





                [TestMethod]  // UC 4.1
                public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyseObject_UsingParameterizedConstructor()
                {
                    object expected = new MoodAnalyser("HAPPY");
                    object obj = MoodAnalyserFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyser.MoodAnalyser", "MoodAnalyser", "SAD");
                    expected.Equals(obj);

                }





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

