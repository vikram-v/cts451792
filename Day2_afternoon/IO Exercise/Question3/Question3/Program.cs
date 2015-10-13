using System;
using System.IO;

namespace Question3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			TextReader inputFile = new StreamReader ("File.txt");
			TextWriter outputFile = new StreamWriter ("NewFile.txt");

			/* using ByteArray to copy content from source file to destination file */

			char[] charArray = new char[500];
			int position;

			while ((position = inputFile.Read(charArray, 0, charArray.Length)) > 0)
			{
				outputFile.Write (charArray, 0, position);
			}

			inputFile.Close ();
			outputFile.Close ();
		}
	}
}