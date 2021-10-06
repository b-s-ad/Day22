using System;

using System.Text;

namespace MoodAnalyser  // UC 1 // Refactor
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
            if (this.message.Contains("Sad"))
            {
                return "SAD";
            } else
            {
                return "HAPPY";

            }

        }

    }
}
