using System;
using System.Collections.Generic;
using System.Text;
/* 
C# Anonymous Functions

Anonymous function is a type of function that does not has name.
In other words, we can say that a function without name is known as anonymous function.

In C#, there are two types of anonymous functions:

    Lambda Expressions
    Anonymous Methods

C# Lambda Expressions

Lambda expression is an anonymous function which we can use to create delegates. 
We can use lambda expression to create local functions that can be passed as an argument. It is also helpful to write LINQ queries.
*/
namespace AnanymousDemo
{
    class AnanymousFuncDefinition
    {
        delegate int Square(int num);
        public delegate void AnonymousFun();
        public static void Main(string[] args)
        {
            AnonymousFun fun = delegate () {
                Console.WriteLine("This is anonymous function");
            };
            fun();

            Square GetSquare = x => x * x;
            int j = GetSquare(5);
            Console.WriteLine("Square: " + j);
        }
    }
}

