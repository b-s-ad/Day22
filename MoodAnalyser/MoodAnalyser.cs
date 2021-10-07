using System;

using System.Text;

namespace MoodAnalyser  // UC 2.1
{
    public class MoodAnalyser
    {
        private string message;
        public MoodAnalyser()
        { }
        public MoodAnalyser(string messgage)
        {
            this.message = messgage;

        }

        public string AnalyseMood()
        {
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }
            catch
            {
                    return "HAPPY";

                }
        
            }

        }

    }

