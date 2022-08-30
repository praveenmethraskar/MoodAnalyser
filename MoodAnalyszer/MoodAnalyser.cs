using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyszer
{
    public class MoodAnalyser
    {


        public string Moodanalyse(string Mood)
        {
            if (Mood.ToLower().Contains("sad"))
            {
                Console.WriteLine("Sad");
                return "Sad";
            }

            else
            {
                Console.WriteLine("Happy");
                return "Happy";
            }
        }
    }
}
