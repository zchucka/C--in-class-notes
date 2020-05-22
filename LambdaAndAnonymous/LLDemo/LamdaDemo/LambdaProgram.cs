using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaProgram
{
    public class Lambdas
    {
        public static void LambdaProgramMain()
        {
            var p = new Lambdas();

            p.SomeMethod();
            p.SomeOtherMethod();
            p.SomeLambdaMethodCaller();
            p.SomeLambdaGeneratorCaller();
            p.MapExample();
            p.FlatMapExample();
            p.FilterExample();
            p.SkipExample();
            p.LimitExample();
            p.DistinctExample();
            p.SortExample();
            p.ReduceExample();

            Console.ReadKey();
        }

        public void SomeMethod()
        {
            Action<string, string, string> foo = (a, b, c) =>
            {
                Console.WriteLine(a + ", " + b + " and " + c);
            };

            // outputs "One, Two and Three"
            foo("One", "Two", "Three");

            // outputs "Six, Nine and Ten"
            foo("Six", "Nine", "Ten");
        }

        public void SomeOtherMethod()
        {
            Func<int, int, string> foo = (a, b) => {
                return "The product of " + a + " and " + b + " is " + (a * b);
            };

            string foo1 = foo(5, 10);
            string foo2 = foo(3, 5);

            // outputs "The product of 5 and 10 is 50"
            Console.WriteLine(foo1);

            // outputs "The product of 3 and -5 is -15"
            Console.WriteLine(foo2);
        }

        public void SomeLambdaMethodExecutor(Func<int, int, int> fn)
        {
            Console.WriteLine("Result of fn(1, 2) is " + fn(1, 2));
        }

        public void SomeLambdaMethodCaller()
        {
            Func<int, int, int> add = (a, b) => { return a + b; };
            // this is also valid
            Func<int, int, int> multiply = (a, b) => a * b;

            // outputs "Result of fn(1, 2) is 3"
            SomeLambdaMethodExecutor(add);

            // outputs "Result of fn(1, 2) is 2"
            SomeLambdaMethodExecutor(multiply);
        }

        public Func<int, int, int> SomeLambdaGenerator(string which)
        {
            if (which == "add")
                return (a, b) => { return a + b; };
            else
                return (a, b) => { return a * b; };
        }

        public void SomeLambdaGeneratorCaller()
        {
            Func<int, int, int> add = SomeLambdaGenerator("add");
            Func<int, int, int> multiply = SomeLambdaGenerator("multiply");

            // outputs "1 + 2 = 3"
            Console.WriteLine("1 + 2 = " + add(1, 2));

            // outputs "1 * 2 = 2"
            Console.WriteLine("1 * 2 = " + multiply(1, 2));
        }

        public void MapExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var mapped = numbers.Select(number => number * 5).ToList();

            // outputs "5, 10, 15, 20, 25"
            Console.WriteLine(string.Join(", ", mapped));
        }

        public void FlatMapExample()
        {
            var john = new Person()
            {
                Name = "John",
                Addresses = new List<string>() { "John's Home", "John's Office" },
                Age = 26
            };

            var mary = new Person()
            {
                Name = "Mary",
                Addresses = new List<string>() { "Mary's Home" },
                Age = 25
            };

            var people = new List<Person>() { john, mary };

            // the type of this object is List<List<string>> which is obviously incorrect
            var incorrect = people.Select(person => person.Addresses).ToList();

            var allAddresses = people.SelectMany(person => person.Addresses).ToList();

            // outputs two lists which is incorrect, we want a list of all addresses
            Console.WriteLine(string.Join(", ", incorrect));

            // outputs "John's Home, John's Office, Mary's Home"
            Console.WriteLine(string.Join(", ", allAddresses));
        }

        public void FilterExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var odds = numbers.Where(number => number % 2 == 1).ToList();

            // outputs "1, 3, 5"
            Console.WriteLine(string.Join(", ", odds));
        }

        public void SkipExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var remainder = numbers.Skip(3).ToList();

            // outputs "4, 5"
            Console.WriteLine(string.Join(", ", remainder));
        }

        public void LimitExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var taken = numbers.Take(3).ToList();

            // outputs "1, 2, 3"
            Console.WriteLine(string.Join(", ", taken));
        }

        public void DistinctExample()
        {
            var numbers = new List<int>() { 1, 1, 2, 3, 5 };
            var distinct = numbers.Distinct().ToList();

            // outputs "1, 2, 3, 5"
            Console.WriteLine(string.Join(", ", distinct));
        }

        public void SortExample()
        {
            var john = new Person()
            {
                Name = "John",
                Addresses = new List<string>() { "John's Home", "John's Office" },
                Age = 26
            };

            var mary = new Person()
            {
                Name = "Mary",
                Addresses = new List<string>() { "Mary's Home" },
                Age = 25
            };

            var sean = new Person()
            {
                Name = "Sean",
                Addresses = new List<string>() { "Sean's Home" },
                Age = 33
            };

            var people = new List<Person>() { john, mary, sean };

            // sorts people to their ages in a descending order
            var sorted = people.OrderByDescending(x => x.Age).ToList();

            // outputs "Sean (33), John (26), Mary (25)"
            Console.WriteLine(string.Join(", ", sorted));
        }

        public void ReduceExample()
        {
            var numbers = new List<int>() { 1, 2, 3, 4, 5 };
            var sum = numbers.Aggregate(50, (a, b) => a + b);

            // we can emulate IEnumerable.ToList() using the reduce operation!
            var asList = numbers.Aggregate(new List<int>(), (list, number) =>
            {
                list.Add(number);
                return list;
            });

            // outputs "65"
            Console.WriteLine(sum);

            // outputs "1, 2, 3, 4, 5"
            Console.WriteLine(string.Join(", ", asList));
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public List<string> Addresses { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return Name + " (" + Age + ")";
        }
    }
}