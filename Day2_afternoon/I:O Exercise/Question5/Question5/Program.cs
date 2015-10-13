using System;
using Newtonsoft.Json;
using System.IO;

namespace Question5
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

			/* Using JSON Serialization and writing it to a file */

			string output = JsonConvert.SerializeObject(detailsArray);
			File.WriteAllText ("File.json", output);
		}
	}

	/* Custom type Person */

	class Person
	{
		public string FirstName;
		public string LastName;
		public int Age;
	
	}

}