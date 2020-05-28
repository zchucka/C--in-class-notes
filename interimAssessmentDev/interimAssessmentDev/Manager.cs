using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class Manager : Employee
    {
        public override void display() // example of method overriding
        {
            Console.WriteLine("I am a Manager");
        }

        public void display(string name)
        {
            Console.WriteLine("My name is {0} and I am a manager", name);
        }

    }
}
