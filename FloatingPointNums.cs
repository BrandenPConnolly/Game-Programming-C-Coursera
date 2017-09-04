using System;

namespace FloatingPointNums
{
    /// <summary>
    /// Demonstrates Flaoting Point Numbers
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Demonstrates Floating Point Numbers
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            //Declaring variables

            int score = 2546;
            int totalSecondsPlayed = 6574;

            //calculate and display result

            float scorePerSecond = (float)score / totalSecondsPlayed;

            Console.WriteLine("Score / Second: " + scorePerSecond);
            Console.WriteLine();
        }
    }
}
