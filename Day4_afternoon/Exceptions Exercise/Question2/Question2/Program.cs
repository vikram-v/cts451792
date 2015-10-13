using System;

namespace Question2
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			try
			{
				Console.Write("Enter a number: ");
				int number = Convert.ToInt32 (Console.ReadLine ());

				if(number < 0)
				{
					throw new NegativeNumberException();
				}
				else{
					Console.WriteLine("The square root is: " + Math.Sqrt(number));
				}
			}

			/* Format Exception */

			catch(FormatException e){
				Console.WriteLine ("Invalid number");
			}

			/* Negative Number Exception */

			catch(NegativeNumberException e){
				Console.WriteLine ("Invalid number");
			}

			/* Exception */

			catch(Exception e){
				Console.WriteLine ("Invalid number");
			}
			finally
			{
				Console.WriteLine ("Goodbye");
			}
		}
	}

	/* Custom Class Exception */

	class NegativeNumberException : Exception
	{
	}
}