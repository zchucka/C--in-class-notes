using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class Company
    {
        private List<Employee> empList; // constructor

        public Company()
        {
            empList = new List<Employee>();
        }

        public Employee this[int element]
        {
            get { return empList[element]; }
            // in order to add an extra element into the indexer, we use the add function on cases were we give a -1 element
            set
            {
                if (element < empList.Count)
                {
                    empList[element] = value;
                }
                else
                {
                    empList.Add(value);
                }
            }
        }

        public void printCompanyEmployees()
        {
            // loop through our list calling employee type
            foreach (var e in empList)
            {
                Type t = e.GetType();
                Console.WriteLine("this employee is of type: {0}", t);
                e.display();
            }
        }
    }
}
