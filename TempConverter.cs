using System;

namespace weekonelabthree
{
	class MainClass
	{
		public static float FtoC(float value)
		{
			//declare variables
			value = value - 32;
			value = value / 9;
			value = value * 5;

			return value;
		}
		public static float CtoF(float value)
		{
			//declare variables
			value = value * 1.8f + 32;

			return value;
		}
		public static void Main(string[] args)
		{
			//Declaring variables
			bool contProg = true;
			bool ans1 = true;
			bool ans2 = false;
			string origValue = "C";
			float origTemp;
			string nextTurn = "Yes";
			bool endProg = false;
			bool endProg2 = false;

			//Main loop
			Console.WriteLine("Welcome to the tempurature translator!");
			while (contProg == true)
			{
				while (endProg2 == false)
				{
					Console.WriteLine("Is original value C or F? (C or F only)");
					origValue = Console.ReadLine();
					ans1 = origValue.Equals("C", StringComparison.Ordinal);
					ans2 = origValue.Equals("F", StringComparison.Ordinal);
					//result = root.Equals(root2, StringComparison.Ordinal);
					if (ans1 || ans2)
					{
						Console.WriteLine("What is the starting value?");
						origTemp = float.Parse(Console.ReadLine());
						if (ans1 == true)
						{
							Console.WriteLine("Your temp in F: " + CtoF(origTemp));
							endProg2 = true;
						}
						else if (ans2 == true)
						{
							Console.WriteLine("Your temp in C: " + FtoC(origTemp));
							endProg2 = true;
						}
					}
					else
					{
						Console.WriteLine("Please enter only F or C");
					}
				}


				Console.WriteLine("Do you have another conversion needed? (Yes or No)");
				nextTurn = Console.ReadLine();
				while (endProg == false)
				{


					if (nextTurn.Equals("Yes", StringComparison.Ordinal))
					{
						contProg = true;
						endProg = true;
					}
					else if (nextTurn.Equals("No", StringComparison.Ordinal))
					{
						contProg = false;
						endProg = true;
					}
					else
					{
						Console.WriteLine("Wrong Value...Please Enter Yes or No");
						endProg = false;
						Console.WriteLine("Do you have another conversion needed? (Yes or No)");
						nextTurn = Console.ReadLine();
					}

				}
				Console.WriteLine();
				Console.WriteLine("---------------------------------");
				Console.WriteLine();

			}

		}
	}
}
