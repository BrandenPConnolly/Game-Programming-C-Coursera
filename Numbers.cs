using System;

namespace Numbers
{
    /// <summary>
    /// Learning about data types in C#
    /// </summary>
    class MainClass
    {
        /// <summary>
        /// Learning about data types in C#
        /// </summary>
        /// <param name="args">The command-line arguments.</param>
        public static void Main(string[] args)
        {
            //Declaring Data type
            int totalSecondsPlayed = 100;

            const int SecondsPerMinute = 60;

            int minutes = totalSecondsPlayed / SecondsPerMinute;
            int seconds = totalSecondsPlayed % SecondsPerMinute;

            string Output = "Time played: " + minutes + "min" + seconds + "sec";

            Console.WriteLine(Output);

            Console.WriteLine();
        }
    }
}
