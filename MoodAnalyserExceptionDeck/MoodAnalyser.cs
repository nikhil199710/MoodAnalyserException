using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserExceptionDeck
{
    public class MoodAnalyser
    {
        private string message;

        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string analyseMood()
        {
            if (this.message.Contains("Sad"))
            {
                return "Sad";
            }
            else
                return "Happy";
        }
    }
}
