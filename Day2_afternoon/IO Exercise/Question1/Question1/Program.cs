using System;
using System.IO;
using System.Collections.Generic;


namespace Question1
{
	class MainClass
	{
		public static void Main (string[] args)
		{		

			/* Creating a list to store the lines from the original file */
			 
			List<string> lineList = new List<string>();

			/* Reading line by line from the original file using StreamReader and adding to the list */

			using (StreamReader fileReader = new StreamReader("File.txt"))
			{
				string line;
				while ((line = fileReader.ReadLine()) != null)
				{
					lineList.Add(line); 
				}
			}

			/* Reversing the list */

			lineList.Reverse();

			/* Writing the lines from the list to a new File using StreamWriter */

			using (StreamWriter fileWriter = new StreamWriter ("FileReverse.txt")) {
				foreach (string line in lineList) {
					fileWriter.WriteLine (line);
				}
			}

		}
	}
}