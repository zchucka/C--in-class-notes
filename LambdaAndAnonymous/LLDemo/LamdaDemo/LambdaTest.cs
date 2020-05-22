using System;
using System.Collections.Generic;
using System.Linq;

namespace LamdaDemo
{

    /*
     * A lambda expression is like an anonymous method written in place of a delegate instance
     * */
    public class LambdaTest
    {
        public static void Main()
        {
          //  Console.WriteLine("Hello World");
         //   Test1();
         //   Console.WriteLine();
         //   Test2();

            Console.WriteLine();
            MovieTest();
        }
        //Named Method
        public static bool MovieRatingCondition(Movie movie)
        {
            return movie.Year > 2010;
        }
        public static void MovieTest()
        {
            var movies = new List<Movie>
        {
            new Movie{Title="Aj Jadoon",Year=2015},
            new Movie{Title="Avengers",Year=2018},
            new Movie{Title="IronMan",Year=2009},
            new Movie{Title="Transformers",Year=2003},
        };

            //Lambda Expression
            Console.WriteLine("{0},{1}",movies.Where(x => x.Year > 2010));
            //Lambda Expression: Not necessary
            Console.WriteLine(movies.Where((Movie x) => x.Year > 2010));
            //Anonymous Mehtod C#2.0
            Console.WriteLine(movies.Where(delegate (Movie movie) { return movie.Year > 2010; }));
            //Named Method
            Console.WriteLine(movies.Where(MovieRatingCondition));
        }
        public class Movie
        {
            public string Title { get; set; }

            public int Year { get; set; }
        }
        static void Test1()
        {
            List<int> elements = new List<int>() { 10, 20, 31, 40 };
            // ... Find index of first odd element.
            int oddIndex = elements.FindIndex(x => x % 2 != 0);
            Console.WriteLine(oddIndex);
        }

        static void Test3()
        {
            Func<string, int> returnLength1; returnLength1 = delegate (String text) { return text.Length; };
            Console.WriteLine(returnLength1("Hello"));

            Func<string, int> returnLength2; returnLength2 = (string text) => { return text.Length; }; Console.WriteLine(returnLength2("Hello"));

            Func<string, int> returnLength3; returnLength3 = (text) => { return text.Length; }; Console.WriteLine(returnLength3("Hello"));

            Func<string, int> returnLength4; returnLength4 = text => text.Length; Console.WriteLine(returnLength4("Hello"));
        }
        static void Test2()
        {
            //

            // Use implicitly-typed lambda expression.
            // ... Assign it to a Func instance.
            //
            Func<int, int> func1 = x => x + 1;
            //
            // Use lambda expression with statement body.
            //
            Func<int, int> func2 = x => { return x + 1; };
            //
            // Use formal parameters with expression body.
            //
            Func<int, int> func3 = (int x) => x + 1;
            //
            // Use parameters with a statement body.
            //
            Func<int, int> func4 = (int x) => { return x + 1; };
            //
            // Use multiple parameters.
            //
            Func<int, int, int> func5 = (x, y) => x * y;
            //
            // Use no parameters in a lambda expression.
            //
            Action func6 = () => Console.WriteLine();
            //
            // Use delegate method expression.
            //
            Func<int, int> func7 = delegate (int x) { return x + 1; };
            //
            // Use delegate expression with no parameter list.
            //
            Func<int> func8 = delegate { return 1 + 1; };
            //
            // Invoke each of the lambda expressions and delegates we created.
            // ... The methods above are executed.
            //
            Console.WriteLine(func1.Invoke(1));
            Console.WriteLine(func2.Invoke(1));
            Console.WriteLine(func3.Invoke(1));
            Console.WriteLine(func4.Invoke(1));
            Console.WriteLine(func5.Invoke(2, 2));
            func6.Invoke();
            Console.WriteLine(func7.Invoke(1));
            Console.WriteLine(func8.Invoke());

            /*
    2
    2
    2
    2
    4

    2
    2
            */
        }
    }
}