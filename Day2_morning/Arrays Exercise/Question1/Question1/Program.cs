using System;

namespace Question1
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/* Declaring and Initializing 4DArray */

			string[,,,] fourDArray = new string[2, 2, 2, 2] 
			{{{{ "A", "B" }, { "C", "D" }},{{ "E", "F" }, { "G", "H" }}}, 
			 {{{ "I", "J" }, { "K", "L" }},{{ "M", "M" }, { "N", "O" }}}};

			/* Printing 4DArray */
			
			for (int i = 0; i < fourDArray.GetLength (3); i++) {
				for (int j = 0; j < fourDArray.GetLength (2); j++) {
					for (int k = 0; k < fourDArray.GetLength (1); k++) {
						for (int l = 0; l < fourDArray.GetLength (0); l++) {
							Console.Write (fourDArray [i, j, k, l] + " ");
						}
					}
				}
			}

		}
	}
}
