using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyser
{
    public class Analyze
    {
        public string AnalyseMood(string sentence)
        {
            string mood = "";
            try
            {
                if(sentence=="")
                {
                    mood = "Happy";
                    throw new InvalidMoodException(InvalidMoodException.ExceptionType.ENTERED_NULL, "Entered a null string");
                } 
                sentence = sentence.ToLower();
                if (sentence.Contains("happy"))
                {
                    mood = "Happy";
                }
                else if (sentence.Contains("sad"))
                {
                    mood = "Sad";
                }
                else
                {
                    mood = "";
                    throw new InvalidMoodException(InvalidMoodException.ExceptionType.ENTERED_EMPTY, "Entered an empty mood string");
                }
            }
            catch(InvalidMoodException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return mood;
        }
    }
}
