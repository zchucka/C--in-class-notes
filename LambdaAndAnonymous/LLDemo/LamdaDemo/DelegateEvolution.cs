using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;
namespace LamdaDemo
{
    class DelegateEvolution
    {
        delegate void TestDelegate(string s);
        static void M(string s)
        {
            Console.WriteLine(s);
        }
        public static void DelegateEvolutionMain()
        {
            // Original delegate syntax required
            // initialization with a named method.
            TestDelegate testDelA = new TestDelegate(M);
            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegate testDelB = delegate (string s) { Console.WriteLine(s); };
            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a string
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };
            // Invoke the delegates.
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");
            // Keep console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    class LamdaExpr
    {
        delegate int del(int i);
        public static void ExecuteMain()
        {            
            del myDelegate = x => x * x; //thelambdaexpression x => x * x
            //specifies a parameter that’s named x and returns thevalue of x squared
            int j = myDelegate(5); //j = 25
            Console.WriteLine("j:" + j);
        }
    }
    class StatementLambda
    {
        delegate void TestDelegate(string s);
        public static void StatementLambdaMain()
        {
            // Expression<Delegate> myET = x => x * x;
            /* By using lambdaexpressions, you can writelocal functions that can be passed as arguments
            or returned as thevalue of function calls.*/
            //Statement lambdas, likeanonymous methods,cannot be used to createexpression trees
            TestDelegate del = n => {
                string s = n + " World";
                Console.WriteLine(s);
            };
            del( "Empty");
         }
    }

}
