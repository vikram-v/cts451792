using System;

namespace Question2
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/* Declaring and initializing two arrays of different dimensions */

			string[,,,] fourDArray = new string[2, 2, 2, 2] 
			{{{{ "A", "B" }, { "C", "D" }},{{ "E", "F" }, { "G", "H" }}}, 
				{{{ "I", "J" }, { "K", "L" }},{{ "M", "M" }, { "N", "O" }}}};
			
			int[,] twoDArray = new int[1, 2] {{ 1, 2 }};

			printDArray (fourDArray);
			printDArray (twoDArray);

		}

		/* Function which accepts an array of any dimension and prints the elements of the array */

		public static void printDArray(Array nDArray){
			foreach (var element in nDArray) {
				Console.Write (element + " ");
			}
			Console.WriteLine ();
		}

	}
}
