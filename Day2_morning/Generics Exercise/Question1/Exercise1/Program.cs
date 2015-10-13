using System;
using System.Collections.Generic;

namespace Exercise1
{
	class MainClass
	{

		public static void PrintList(LinkedList<Object> MyLinkedList)
		{
			foreach (var element in MyLinkedList)
			{
				Console.WriteLine(element);
			}
		}

		public static void Main (string[] args)
		{

			/* Creating a Simple Linked List */

			LinkedList<Object> MyLinkedList = new LinkedList<Object>();

			/* Inserting Elements */

			MyLinkedList.AddLast ("A");
			MyLinkedList.AddLast(1);

			/* Implementing Find */

			MyLinkedList.AddAfter(MyLinkedList.Find("A"), 'a');

			/* Printing Elements of the List */

			PrintList (MyLinkedList);

			/* Remove a particular element from the List */

			MyLinkedList.Remove (1);

			PrintList (MyLinkedList);

			/* Printing the Count of the List */

			int countList = MyLinkedList.Count;

			Console.WriteLine (countList);

		}

	}

}
