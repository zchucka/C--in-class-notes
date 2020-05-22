using System;
using System.Diagnostics;
using System.Linq;

namespace LamdaDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample_AsEnumerable_Lambda();
            Console.WriteLine("Hello World!");
         //   LambdaProgram.Lambdas.LambdaProgramMain();
       //     DelegateEvolution.DelegateEvolutionMain();
            LamdaExpr.ExecuteMain();
            StatementLambda.StatementLambdaMain();
        }

        static void Sample_AsEnumerable_Lambda()
        {
            string[] names = { "John", "Suzy", "Dave" };

            var result = names.AsEnumerable();

            Debug.WriteLine("Iterating over IEnumerable collection:");
            foreach (var name in result)
                Debug.WriteLine(name);
        }
    }
}
