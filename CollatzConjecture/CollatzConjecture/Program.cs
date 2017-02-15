using System;

namespace CollatzConjecture
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int input;
			bool validInput = false;
			bool endProgram = false;
			Console.WriteLine("COLLATZ CONJECTURE ALGORITHM");
			while (!endProgram)
			{
				Console.WriteLine("Please type in any number, n , such that n > 1. Type 'END' to end program");
				do
				{
					string userInput = Console.ReadLine();
					if (userInput == "END" || userInput == "end")
					{
						endProgram = true;
					}
					else
					{
						validInput = int.TryParse(userInput, out input);
						if (validInput)
						{
							Console.WriteLine("It takes " + getNumberOfSteps(input) + " steps to reach 1");
						}
						else
						{
							Console.WriteLine("Please type in a valid integer.");
						}
					}
				}
				while (!validInput);
			}
		}

		private static int getNumberOfSteps (int n) {
			int count = 0;

			while (n > 1)
			{
				if (n % 2 == 0)
				{
					n = n / 2;
					count++;
				}
				else if (n % 2 == 1)
				{
					n = (3 * n) + 1;
					count++;
				}
			}
			return count;
		}
	}
}


