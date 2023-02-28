using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class InvalidMoodException:Exception
    {
        public enum ExceptionType
        {
            ENTERED_NULL, ENTERED_EMPTY
        }

        ExceptionType type;

        public InvalidMoodException(ExceptionType type, string message): base (message)
        {
            this.type = type;
        }
    }
}
