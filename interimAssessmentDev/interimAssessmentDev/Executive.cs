using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class Executive : Employee
    {
        private Type _empType;
        public override Type employeeType
        {
            get => _empType;
            set => _empType = value;
        }

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
