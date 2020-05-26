using System;
using System.Collections;
/*
* Generic Methods Constraints
Constraints are validations on type arguments which type of parameter we can pass in generic method. Generic class and Generic methods follow the same constraints.

There are six types of constraints.

where T : struct  – Type argument must be a value type
where T : class – Type argument must be a reference type
where T : new() – Type argument must have a public parameterless constructor.
where T : <base class> – Type argument must inherit from <base class> class.
where T : <interface> –  Type argument must implement from <interface> interface.
where T : U – There are two type arguments T and U. T must be inherit from U.
Below is the example of usage of above constraints in Generic methods.
static void Swap<T>(ref T input1, ref T input2) where T : struct { }

static void Swap<T>(ref T input1, ref T input2) where T : class { }

static void Swap<T>(ref T input1, ref T input2) where T : new() { }

static void Swap<T>(ref T input1, ref T input2) where T : BaseEmployee { }

static void Swap<T>(ref T input1, ref T input2) where T : IEmployee { }

static void Swap<T, U>(ref T input1, ref U input2) where T : U { }
* 
* */
namespace Generics
{
    public class NewConstraint
    {
        public static void Main(string[] args)
        {
            var genericClass = new GenericClass<Product>();
            var testingNew = new GenericClass<int>();
            var instance = genericClass.NewObject();
            Console.WriteLine(instance.GetType());

            Console.ReadLine();
        }
    }

    public class GenericClass<T> where T: new()
    {
        public T NewObject()
        {
            return new T();
        }
    }

    public class Product
    {

    }
}