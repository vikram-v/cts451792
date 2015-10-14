using System;

namespace Question1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/* Assigning null and printing */

			int? number = null;
			if(!number.HasValue)
				Console.WriteLine ("Null Value");

			/* Assigning value and printing */
			
			number = 1;

			if(number.HasValue)
				Console.WriteLine (number.Value);
		}
	}
}
