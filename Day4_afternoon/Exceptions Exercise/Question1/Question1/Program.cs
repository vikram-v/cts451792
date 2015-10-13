using System;

namespace Question1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int arraySize = 5;
			int[] numberArray = new int[arraySize];
			int arrayCount = 0;

			do 
			{
				try
				{
					Console.Write("Enter a number: ");
					int number = Convert.ToInt32(Console.ReadLine());
					numberArray[arrayCount] = number;


					Console.WriteLine("Numbers in the array: ");

					Console.Write(numberArray[0]);
					for(int i = 1
						; i <= arrayCount; i++)
					{
						Console.Write(", " + numberArray[i]);
					}
					Console.WriteLine();

					arrayCount++;

				}

				/* Index Out Of Range Exception */

				catch(IndexOutOfRangeException e){
					Console.WriteLine(e.Message);
				}

				/* Format Exception */

				catch(FormatException e){
					Console.WriteLine(e.Message);
				}

				/* Exception */

				catch(Exception e){
					Console.WriteLine(e.Message);
				}

			} while(arrayCount < arraySize);
		}
	}
}