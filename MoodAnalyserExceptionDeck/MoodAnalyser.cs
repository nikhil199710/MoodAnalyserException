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
            try
            {
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                    return "Happy";
            }
            catch
            {
                return "Happy";
            }
        }
    }
}
