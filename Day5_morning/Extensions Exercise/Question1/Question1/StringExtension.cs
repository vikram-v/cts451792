using System;

namespace Question1
{

	/* String Extension Class */

	public static class StringExtension
	{

		/* Function for counting number of words */

		public static int wordCount(this string inputString){
			
			string[] wordList = inputString.Split (new char[]{ ' ' });

			return wordList.Length;
		}

		/* Function for counting number of characters */

		public static int characterCount(this string inputString){
			
			char[] characterList = inputString.ToCharArray ();
			int count = 0;

			foreach (char ch in characterList) {
				if (!char.IsWhiteSpace (ch))
					count++;
			}

			return count;
		}
	}
}
