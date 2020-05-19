using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class ClassTemplate
    {
		public static void Main()
		{
			MyGenericClass<string> strGenericClass1 = new MyGenericClass<string>("Hello World");

			strGenericClass1.genericMethod("Hello World!");

			MyGenericClass<Student> strGenericClass2 = new MyGenericClass<Student>(new Student());

			//following will throw an exception
			//MyGenericClass<int> intGenericClass = new MyGenericClass<int>(10);
		}
	}
	class MyGenericClass<T> where T : class
	{
		private T genericMemberVariable;

		public MyGenericClass(T value)
		{
			genericMemberVariable = value;
		}

		public T genericMethod(T genericParameter)
		{
			Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParameter);
			Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), genericMemberVariable);

			return genericMemberVariable;
		}

		public T genericProperty { get; set; }
	}

	public class Student
	{
	}
}
