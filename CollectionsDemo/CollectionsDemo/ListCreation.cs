using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    class ListCreation
    {
		public static void ListCreationMain()
		{

			List<int> NumberValues = new List<int>();

			NumberValues.Add(100);
			NumberValues.Add(200);
			NumberValues.Add(300);
			NumberValues.Add(400);
			NumberValues.Add(500);

			Console.WriteLine("Value of 3 is : " + NumberValues[2]);


			List<string> StringValues = new List<string>();
			StringValues.Add("APPLE");
			StringValues.Add("GRAPES");
			StringValues.Add("MANGOS");

			Console.WriteLine("Value of 2 is : " + StringValues[2]);

			List<student> StudentList = new List<student>();

			student NewStudent = new student();
			NewStudent.id = 100;
			NewStudent.fname = "One";
			NewStudent.fname = "Hundred";
			StudentList.Add(NewStudent);

			NewStudent = new student();
			NewStudent.id = 200;
			NewStudent.fname = "Two";
			NewStudent.fname = "Hundred";
			StudentList.Add(NewStudent);

			NewStudent = new student();
			NewStudent.id = 300;
			NewStudent.fname = "Three";
			NewStudent.fname = "Hundred";
			StudentList.Add(NewStudent);

			Console.WriteLine("Total in List : " + StudentList.Count);
			Console.WriteLine("Total in List : " + StudentList.Count);
		}



		public class student
		{
			public int id { get; set; }
			public string fname { get; set; }
			public string lname { get; set; }
		}
	}
}
