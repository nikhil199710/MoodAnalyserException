using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserExceptionDeck
{
    public class MoodAnalyserCustomException:Exception
    {
        public enum Exceptiontypes
        {
            Empty_Message,Null_Message 
        }

        public readonly Exceptiontypes type;
        
        public MoodAnalyserCustomException(Exceptiontypes type,string message):base(message)
        {
            this.type = type;
        }

    }
}
