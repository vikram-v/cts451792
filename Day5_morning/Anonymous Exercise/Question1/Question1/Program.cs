using System;

namespace Question1
{
	delegate int Addition(int number1, int number2);

	class MainClass
	{
			/* Delegate for representing Anonymous method */

			delegate int Add(int num1, int num2);

			public static void Main(string[] args)
			{
				/* Anonymous method using delegate keyword */

				Add addNumbers = delegate(int num1, int num2) { return num1 + num2; };
				int Sum = addNumbers(2, 3);

				Console.WriteLine(Sum);
			}
	}
}