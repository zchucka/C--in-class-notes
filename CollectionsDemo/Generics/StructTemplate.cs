using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
	public class GenericsStructConstraint
	{
		public static void Main()
		{
			MyGenericStruct<int> strGenericClass1 = new MyGenericStruct<int>(1);

			strGenericClass1.genericMethod(1);

			MyGenericStruct<StudentStruct> strGenericClass2 = new MyGenericStruct<StudentStruct>(new StudentStruct());

			//following will throw an exception
			//MyGenericStruct<int> intGenericClass = new MyGenericStruct<int>(10);
		}
	}

	class MyGenericStruct<T> where T : struct
	{
		private T genericMemberVariable;

		public MyGenericStruct(T value)
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

	public struct StudentStruct
	{
	}

}
