using System;
using System.Collections.Generic;
using System.Text;

namespace CollectionsDemo
{
    using System;
    using System.Collections.Generic;

    public class employee
    {
        private string name;
        private int age;
        private string designation;

        // constructor
        public employee(string name, int age, string designation)
        {
            this.name = name;
            this.age = age;
            this.designation = designation;
        }
        // utility functions for the class
        public string getName
        {
            get { return name; }
        }
        public int getAge
        {
            get { return age; }
        }
        public string getDesignation
        {
            get { return designation; }
        }
    }

    public class Employee
    {
        public static void EmployeeMain()
        {
            // create a list of type 'employee'
            List<employee> employeeList = new List<employee>();
            // populate the list with objects of 'employee'
            employeeList.Add(new employee("John", 29, "Developer"));
            employeeList.Add(new employee("Mike", 23, "Engineer"));
            employeeList.Add(new employee("Alex", 29, "Manager"));
            employeeList.Add(new employee("Smith", 29, "Intern"));

            // printing out the list
            foreach (var item in employeeList)
                Console.WriteLine("Name: {0}, Age: {1}, Designation: {2}", item.getName, item.getAge, item.getDesignation);
        }
    }
}
