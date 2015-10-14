using System;

namespace Question1
{		
	class MainClass
	{
		public static void Main (string[] args)
		{
			PartialClass1 partialClass1 = new PartialClass1();
			Console.WriteLine(partialClass1.Add (6, 3));
			Console.WriteLine(partialClass1.Subtract (6, 3));

			PartialClass2 partialClass2 = new PartialClass2();
			Console.WriteLine(partialClass2.Multiply (6, 3));
			Console.WriteLine(partialClass2.Divide (6, 3));
		}
	}
}
