using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    interface IEmployeeInfo
    {
        string name { get; set; }
        int empNum { get; set; }

        void displayEmpInfo();
    }
}
