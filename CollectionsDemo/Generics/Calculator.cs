using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    class Calculator
    {
        public static void CalculatorMain()
        {
            var add1 = new Calculator<Double>();
            var sub = new Calculator<int>();
            var div = new Calculator<int>();
            var mul = new Calculator<int>();

            Console.WriteLine(add1.Add(10.1, 2));
            Console.WriteLine(sub.Subtract(8, 2));
            Console.WriteLine(div.divide(8, 2));
            Console.WriteLine(mul.multiply(8, 2));


        }
    }
    public class Calculator<T>
    {
        public T Add(T first, T second)
        {
            var result = default(T);

            if (typeof(T) == typeof(int))
            {
                dynamic a = first, b = second;

                result = a + b;
            }

            else if (typeof(T) == typeof(double))
            {
                dynamic a = first, b = second;

                result = a + b;
            }
            return result;

        }

        public T Subtract(T first, T second)
        {
            var result = default(T);

            if (typeof(T) == typeof(int))
            {
                dynamic a = first, b = second;

                result = a - b;
            }

            return result;

        }

        public T divide(T first, T second)
        {
            var result = default(T);

            if (typeof(T) == typeof(int))
            {
                dynamic a = first, b = second;

                result = a / b;
            }

            return result;

        }
        public T multiply(T first, T second)
        {
            var result = default(T);

            if (typeof(T) == typeof(int))
            {
                dynamic a = first, b = second;

                result = a * b;
            }

            return result;

        }
    }
}
