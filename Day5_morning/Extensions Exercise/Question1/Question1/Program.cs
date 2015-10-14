using System;

namespace Question1
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Console.Write ("Enter a string: ");
			string inputString = Console.ReadLine ();
			Console.WriteLine ();
			Console.WriteLine ("Number of words: " + inputString.wordCount ());
			Console.WriteLine ("Number of characters: " + inputString.characterCount ());
		}
	}
}