using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoodAnalyszer
{
    public class MoodAnalyser
    {
        public string Mood;



        public MoodAnalyser(string Mood)
        {
            this.Mood = Mood;
        }

        public string Moodanalyse()
        {
            try
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
            catch (InvalidCastException ex)
            {
                Console.WriteLine(ex.Message);
            }

            return default(string);
        }
    }
}
