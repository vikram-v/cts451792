using System;

namespace Question2
{
	delegate void printDetails(Person person);

	class MainClass
	{

		/* Delegate for representing Anonymous method */

		delegate void personDetails(Person person);

		public static void Main (string[] args)
		{
			Person myDetails = new Person {Id = 451792, Name = "Sanjana", City = "Hyderabad"};

			/* Anonymous method using delegate keyword */

			printDetails details = delegate(Person person){
				Console.WriteLine("Id: " + person.Id);
				Console.WriteLine("Name: " + person.Name);
				Console.WriteLine("City: " + person.City);
			};

			details (myDetails);

		}
	}

	/* Custom Class Person */

	public class Person
	{
		public int Id;
		public string Name;
		public string City;
	}
}