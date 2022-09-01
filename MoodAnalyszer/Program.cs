using System;

namespace MoodAnalyszer
{

    class Program
    {
       
        
       // public static string Sad_Mood = Console.ReadLine();

        public static void Main(string[] args)
        {
            Console.WriteLine();
           string Happy_Mood = Console.ReadLine();
            MoodAnalyser obj = new MoodAnalyser(Happy_Mood);
            obj.Moodanalyse();
            //MoodAnalyser obj1 = new MoodAnalyser(Sad_Mood);
            //obj1.Moodanalyse();


        }
    }
}