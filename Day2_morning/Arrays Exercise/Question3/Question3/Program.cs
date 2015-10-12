using System;

namespace Question3
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Person[] detailsArray = new Person[3] {
				new Person{ FirstName = "Sanjana", LastName = "Reddy", Age = 23 },
				new Person{ FirstName = "Sumana", LastName = "Reddy", Age = 48 },
				new Person{ FirstName = "Srinivas", LastName = "Reddy", Age = 52 }
			};

			Console.WriteLine("Before Sorting");

			foreach (Person person in detailsArray) {
				Console.WriteLine (person.FirstName);
			};

			Console.WriteLine("After Sorting");

			Array.Sort (detailsArray);

			foreach (Person person in detailsArray) {
				Console.WriteLine (person.FirstName);
			};

		}
	}

	/* Custom type Person */

	class Person : IComparable <Person>
	{
		public string FirstName;
		public string LastName;
		public int Age;

		/* Re-usable function that can sort Person[] Array by age */

		public int CompareTo(Person person)
		{
			return person.Age.CompareTo(this.Age);
		}
	}

}
