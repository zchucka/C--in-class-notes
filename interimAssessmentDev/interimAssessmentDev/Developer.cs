using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class Developer : ITProfessional
    {
        private int _salary;
        public override int salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public override void displaySal()
        {
            Console.WriteLine(salary);
        }
    }
}
