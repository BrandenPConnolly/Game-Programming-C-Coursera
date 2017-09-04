using System;

namespace WeekOneLabTwo
{
    /// <summary>
    /// Lab Number 2 - Variables and Constants
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Variables and Constants
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            //Define Variables and Constants
            //int myAge = 29;
            const int MaxScore = 100;
            int score = 67;
            float percent = score / (float)MaxScore;

            //Outputs
            //Console.WriteLine("My age is: " + myAge);
            Console.WriteLine("Score Percentage: " + percent);


        }
    }
}
