using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class Executive : Employee
    {

        public override void display()
        {
            Console.WriteLine("I am a Executive");
        }

        public void display(string name)
        {
            Console.WriteLine("My name is {0} and I am a manager", name);
        }
    }
}
