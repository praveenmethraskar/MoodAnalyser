using System;

namespace MoodAnalyszer
{

    class Program
    {
        public static string Happy_Mood = "I am in happy mood";
        public static string Sad_Mood = "I am in sad mood";

        public static void Main(string[] args)
        {

            MoodAnalyser obj = new MoodAnalyser();
            obj.Moodanalyse(Happy_Mood);
            obj.Moodanalyse(Sad_Mood);


        }
    }
}