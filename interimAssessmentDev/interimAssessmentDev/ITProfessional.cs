using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    abstract class ITProfessional : Employee
    {
        public abstract int salary
        {
            get;
            set;
        }

        public override Type employeeType
        {
            get => base.employeeType;
            set => base.employeeType = value;
        }
        public abstract void displaySal();

    }
}
