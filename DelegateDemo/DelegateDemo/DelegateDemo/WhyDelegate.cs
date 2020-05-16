using System;
using System.Collections.Generic;
using System.Text;

namespace DelegateDemo
{
    //Declare Delegate
    public delegate int CalculatorDelegate(int x, int y);
    class Calculator
    {
      

        //Create Delegate Reference
        CalculatorDelegate delegateObj = null;

        //Depending upon request we will assign Delegate
        public CalculatorDelegate GetDelegateRef(int intoperation)
        {
            //And Finally assign based on request
            switch (intoperation)
            {
                case 1:
                    delegateObj = Add;
                    break;
                case 2:
                    delegateObj = Sub;
                    break;
                case 3:
                    delegateObj = Multi;
                    break;
                case 4:
                    delegateObj = Div;
                    break;
                default: break;
            }
            return delegateObj;
        }
        private int Add(int x, int y) { return x + y; }
        private int Sub(int x, int y) { return x - y; }
        private int Multi(int x, int y) { return x * y; }
        private int Div(int x, int y) { return x / y; }
    }

    class Client
    {
        public static void ExecuteMain(string[] args)
        {
            int intoperation = Convert.ToInt32(args[0]);
            int operatorX = Convert.ToInt32(args[1]);
            int operatorY = Convert.ToInt32(args[2]);

            Calculator obj = new Calculator();
            Console.WriteLine(obj.GetDelegateRef(intoperation).Invoke(operatorX, operatorY));
        }
    }
}
