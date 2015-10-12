using System;
using System.Collections.Generic;

namespace Question4
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

			MyComparer comparer = new MyComparer ();

			Array.Sort (detailsArray, comparer);

			foreach (Person person in detailsArray) {
				Console.WriteLine (person.FirstName);
			};

		}
	}

	/* Custom Type Person */

	class Person 
	{
		public string FirstName;
		public string LastName;
		public int Age;

	}

	/* Function that can sort Person[] Array on the property of our choice */

	class MyComparer : IComparer <Person>
	{
		public int Compare(Person person1, Person person2)
		{
			return person1.FirstName.CompareTo(person2.FirstName);
		}
	}

}
