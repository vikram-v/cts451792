using System;
using System.Collections.Generic;
using System.Collections;

namespace Question1
{

	/* Custom Class Person */

	class Person{
		public int Id;
		public string Name;
		public string Location;
	}

	class MainClass
	{
		public static void Main (string[] args)
		{
			MyEnumerable myEnumerable = new MyEnumerable();

			foreach (Person person in myEnumerable) 
			{
				Console.WriteLine (person.Name);
			}

		}
	}

	/* IEnumerable */

	class MyEnumerable : IEnumerable
	{

		public IEnumerator GetEnumerator ()
		{
			return new MyEnumerator();
		}

	}

	/* IEnumerator */

	class MyEnumerator : IEnumerator
	{
		public static LinkedList<Person> personLinkedList;

		public LinkedListNode<Person> currentObj;
		public object Current {
			get{
				return currentObj.Value;
			}
		}

		public bool MoveNext ()
		{
			if (personLinkedList == null) {
				personLinkedList = new LinkedList<Person>();

				personLinkedList.AddLast(new Person {Id = 1, Name = "Sanjana", Location = "Hyderabad"} );
				personLinkedList.AddLast(new Person {Id = 2, Name = "Sumana", Location = "Hyderabad"} );
				personLinkedList.AddLast(new Person {Id = 3, Name = "Srinivas", Location = "Hyderabad"} );
			}
			if (currentObj == null && personLinkedList.First != null) 
			{

				currentObj = personLinkedList.First;
				return true;
			} 
			if ( currentObj.Next!=null) 
			{
				currentObj = currentObj.Next;
				return true;
			} 
			else 
			{
				return false;
			}

		}

		public void Reset ()
		{
			currentObj = null;
		}
	}

}