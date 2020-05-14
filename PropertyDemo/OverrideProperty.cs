using System;
using System.Collections.Generic;
using System.Text;

namespace PropertyDemo
{
	public class OverrideProperty
	{
		public static void OverridePropertyMain()
		{
			Derived d2 = new Derived();
			bbase b2 = d2; // copied by reference since it is a reference type?
			b2.id = 6;
			Console.WriteLine("d2: " + d2.id);
			Console.WriteLine("b2: " + b2.id);
		}
	}

	class bbase
	{
		public virtual int id
		{
			get;
			set;
		}
	}

	class Derived : bbase
	{
		public override int id
		{
			get;
			set;
		}
	}

}
