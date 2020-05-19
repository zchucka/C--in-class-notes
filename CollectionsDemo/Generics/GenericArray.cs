using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class GenericArray
    {
        
		public class MyGenericArray<T>
		{
			private T[] array;
			public MyGenericArray(int size)
			{
				array = new T[size];
			}
			public T Getitem(int index)
			{
				return array[index];
			}
			public T Setitem(int index, T value)
			{
				return array[index] = value;
			}


		}
		public static void Swap<R>(ref R val1, ref R val2)
		{
			R temp;
			temp = val1;
			val1 = val2;
			val2 = temp;

		}
		public static void GenericArrayMain()
		{
			Console.WriteLine("Hello World");
			MyGenericArray<int> myarray = new MyGenericArray<int>(5);
			for (int i = 0; i < 5; i++)
			{
				myarray.Setitem(i, i + 1);
			}
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(myarray.Getitem(i));
			}
			MyGenericArray<char> strarray = new MyGenericArray<char>(5);
			for (int i = 0; i < 5; i++)
			{
				strarray.Setitem(i, (char)(i + 97));
			}
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(strarray.Getitem(i));
			}
			int a = 10;
			int b = 20;
			string s1 = "satish";
			string s2 = "nagaraju";
			Swap<int>(ref a, ref b);
			Console.WriteLine("Swapped values are {0}, {1}", a, b);
			Swap<string>(ref s1, ref s2);
			Console.WriteLine("Swapped values are {0}, {1}", s1, s2);


		}
	}
}

