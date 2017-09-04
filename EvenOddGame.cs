using System;

namespace FirstCSharpProgram
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Even or Odd!");

            int s;
            string replay;
            replay = "true";
            while (replay == "true")
            {

                Console.WriteLine("Enter a number, any number!");
                s = Convert.ToInt32(Console.ReadLine());

                if (s % 2 == 0)
                {
                    Console.WriteLine("It is an even number!");
                }
                else
                {
                    Console.WriteLine("It is an odd number!");
                }
                Console.WriteLine("Do you want to play again?(true/false)");
                replay = Console.ReadLine();
            }
        }
    }
}
