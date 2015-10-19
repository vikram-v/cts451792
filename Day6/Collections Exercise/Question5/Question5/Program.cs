using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Question5
{

	class Person{
		public string Name;
		public int Age;
	}

	class MainClass
	{
		public static void Main (string[] args)
		{

			/* Use of Equality Comparer */

			List<Person> groupList = new List<Person>() 
			{ new Person() { Name = "X", Age = 36 }, 
				new Person() { Name = "Y", Age = 35 } };

			List<Person> personList1 = new List<Person>() { 
				new Person() { Name = "A", Age = 36 }, 
				new Person() { Name = "B", Age = 36 }, 
				new Person() { Name = "C", Age = 35 }, 
				new Person() { Name = "D", Age = 35 }, 
				new Person() { Name = "E", Age = 36 } };


			EqualityComparer<Person> equalityComparer = new
				EqualityComparer<Person>((s1, s2) => s1.Age == s2.Age);

			var groupJoinItems = groupList.GroupJoin(
				personList1, 
				p => p, 
				p => p,
				(p1, p2) => new { Name = p1.Name, Person = p2 }, 
				equalityComparer);

			foreach (var item in groupJoinItems)
			{
				Console.WriteLine(item.Name);
			}

			/* Use of Comparer */

			List<Person> personList2 = new List<Person>() { 
				new Person() { Name = "A", Age = 36 }, 
				new Person() { Name = "B", Age = 23 }, 
				new Person() { Name = "C", Age = 39 }, 
				new Person() { Name = "D", Age = 25 }, 
				new Person() { Name = "E", Age = 26 } };

			Comparer<Person> comparer =
				new Comparer<Person>(
					(p1, p2) => (p1.Age < p2.Age) ? -1 : (p1.Age == p2.Age) ? 0 : 1);        

			personList2.Sort(comparer);

			foreach (var item in personList2)
			{
				Console.WriteLine(item.Name);                
			}
		}
	}

	/* Implementation of Equality Comparer */

	public class EqualityComparer<T> : IEqualityComparer<T>
	{
		private Func<T, T, bool> equalsFunction;
		private Func<T, int> getHashCodeFunction;

		public EqualityComparer(Func<T, T, bool> equalsFunction)
		{
			this.equalsFunction = equalsFunction;
		}

		public EqualityComparer(Func<T, T, bool> equalsFunction, 
			Func<T, int> getHashCodeFunction) : this(equalsFunction)
		{
			this.getHashCodeFunction = getHashCodeFunction;
		}

		public bool Equals(T a, T b)
		{
			return equalsFunction(a, b);
		}

		public int GetHashCode(T obj)
		{
			if (getHashCodeFunction == null)
				return obj.GetHashCode();
			return getHashCodeFunction(obj);
		}
	}

	/* Implementation of Comparer */

	public class Comparer<T> : IComparer<T>
	{
		private Func<T, T, int> comparerFunction;

		public Comparer(Func<T, T, int> comparerFunction)
		{
			this.comparerFunction = comparerFunction;
		}

		public int Compare(T a, T b)
		{
			if (object.ReferenceEquals(a, b))
				return 0;
			return comparerFunction(a, b);
		}
	}

}