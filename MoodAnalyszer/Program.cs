using System;

namespace MoodAnalyszer
{

    class Program
    {
        public static string Happy_Mood = "I am in happy mood";
        public static string Sad_Mood = "I am in sad mood";

        public static void Main(string[] args)
        {

            MoodAnalyser obj = new MoodAnalyser(Happy_Mood);
            obj.Moodanalyse();
            MoodAnalyser obj1 = new MoodAnalyser(Sad_Mood);
            obj1.Moodanalyse();


        }
    }
}