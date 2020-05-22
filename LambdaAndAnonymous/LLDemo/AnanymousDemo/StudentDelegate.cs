using System;
using System.Collections.Generic;
using System.Text;

namespace AnanymousDemo
{
    class StudentDelegate
    {
		delegate bool IsTeenAger(Student stud);

		public static void Main()
		{
			IsTeenAger isTeenAger = delegate (Student s) { return s.Age > 12 && s.Age < 20; };

			Student stud = new Student() { Age = 25 };

			Console.WriteLine(isTeenAger(stud));

			
			AnanymousStudent();
		}
		public static void AnanymousStudent()
		{
			//Access Anonymous Types in C#
			var student = new { Id = 1, FirstName = "James", LastName = "Bond" };

			Console.WriteLine(student.Id); //output: 1
			Console.WriteLine(student.FirstName); //output: James
			Console.WriteLine(student.LastName);
		}
	}

	
	public class Student
	{

		public int Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
	}
}
