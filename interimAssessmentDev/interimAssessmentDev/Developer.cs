using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class Developer : ITProfessional
    {
        public override int salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public override Type employeeType
        {
            get => base.employeeType;
            set => base.employeeType = value;
        }
        public override void displaySal()
        {
            Console.WriteLine(salary);
        }
    }
}
