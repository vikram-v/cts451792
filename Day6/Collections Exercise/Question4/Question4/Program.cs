using System;
using System.Collections.Generic;

namespace Question4
{
	class MainClass
	{
		public static void Main (string[] args)
		{

			/* List Operations */

			List<int> list = new List<int>();

			list.Add (10);

			list.AddRange (new List<int> () { 20, 30, 40 });

			list.Remove (10);

			list.Insert (0, 10);

			list.Clear ();

			/* Dictionary Operations */

			Dictionary<int, string> dictionary = new Dictionary<int, string> ();
											
			dictionary.Add (1, "Sanjana");
			dictionary.Add (2, "Sumana");

			dictionary.ContainsValue ("Sanjana");
			dictionary.Remove (1);

			dictionary.Add (3, "Srinivas");

			dictionary.Clear ();

		}
	}
}