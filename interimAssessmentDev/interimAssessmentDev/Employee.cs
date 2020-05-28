using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class Employee : IEmployeeInfo
    {

        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _empNum;
        public int empNum
        {
            get { return _empNum; }
            set { _empNum = value; }
        }


        public virtual void display()
        {
            Console.WriteLine("I am an Employee");
        }

        public void displayEmpInfo()
        {
            Console.WriteLine("my name is {0} and my employee number is {1}", name, empNum);
        }
    }
}
