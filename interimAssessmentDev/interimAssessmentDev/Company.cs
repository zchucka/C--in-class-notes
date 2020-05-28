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
        public string name;
        public int length;

        public Company(string name)
        {
            empList = new List<Employee>();
            this.name = name;
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
                    length++;
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
