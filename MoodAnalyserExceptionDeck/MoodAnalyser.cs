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


        public string analyseMoodCustom()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyserCustomException(MoodAnalyserCustomException.Exceptiontypes.Empty_Message, "Mood should not be empty");
                }

                if (this.message.Contains("Sad"))
                    {
                        return "Sad";
                    }
                    else
                        return "Happy";
                
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalyserCustomException(MoodAnalyserCustomException.Exceptiontypes.Null_Message, "Mood should not be Null");
            }
        }
    }
}
