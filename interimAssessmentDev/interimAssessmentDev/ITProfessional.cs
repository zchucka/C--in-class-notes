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
        public abstract void displaySal();

    }
}
