using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{

	using System;
	using System.Collections.Generic;

	public class ListSample
	{
		public static void ListSampleMain()
		{


			// Very basic list, like JS arrays.
			var myList = new List<string>();
			myList.Add("Item one");
			// Etc.

			// Can also remove.
			myList.Add("Item Two");
			myList.Remove("Item Two");

			Console.WriteLine(myList[0]);
			Console.WriteLine(" ");

			// Adding multiple els.
			var myList2 = new List<string> { "Item one", "Item two", "Item three" };

			// For each to iterate through.
			foreach (var myItem in myList2)
			{
				Console.WriteLine(myItem + " ");
			}

		}

		public static void ListSampleTwo()
		{
			var items = new List<string> { };

			for (var i = 0; i < 5; i++)
			{
				items.Add("Item " + i);
			}

			foreach (var item in items)
			{
				Console.WriteLine(item);
			}

		}

		public static void ListSampleThree()
		{
			var items = new List<string> { };


			Console.WriteLine("Add an item: ");
			var r1 = Console.ReadLine();


			items.Add(r1);



			foreach (var item in items)
			{
				Console.Write(item);
			}
		}
		public static void ListSampleFour()
		{
			
			var thecars = new List<cars>
			{
				new cars() { name = "lamborghini",weight = 6678935},
				new cars() { name = "Audi",weight = 867567686},
				new cars() { name = "BMW",weight = 437787467}
			};
			foreach (cars thecar in thecars)
			{
				Console.WriteLine(thecar.name + " " + thecar.weight);
			}
		}

		public static void LsitSampleFive()
		{
			Console.WriteLine("Hello World");

			List<string> colorList = new List<string>();

			colorList.Add("Red");
			colorList.Add("Green");
			colorList.Add("Yellow");
			colorList.Add("Purple");
			colorList.Add("Orange");

			Console.WriteLine(colorList[1]);

			colorList[2] = "Indigo";

			foreach (string color in colorList)
			{
				Console.WriteLine(color);
			}

			Console.WriteLine(" ");

			colorList.Remove("Red");

			foreach (string color in colorList)
			{
				Console.WriteLine(color);
			}

			Console.WriteLine(" ");

			colorList.Insert(2, "White");


			foreach (string color in colorList)
			{
				Console.WriteLine(color);
			}

			Console.WriteLine(" ");

			colorList.Sort();

			foreach (string color in colorList)
			{
				Console.WriteLine(color);
			}

		}
	}
	public class cars
	{
		public string name { get; set; }
		public int weight { get; set; }
	}

	
}
