using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

// company is a class
// company that printCompanyEmployees
// employee is a class with a property that decides whether it is a manager or executive
// manager class that inherits employee
// executive class inherits employee
// both contain display()
//
// abstract class, polymorphism, delegates, events, indexers, reflection, override
// Dynamic polymorphism: use employee vs executive
// static polymorphism: function overloading, two display functions in manager
// abstract class: create a new abstract class called IT professionals
// interfaces: use a interface for employee and children called salary
// delegates: use to handle functions created by interface
// indexers: create indexer for company
// reflection: use it to determine the type in the foreach loop
// override: display function
// file handling: write to the file instead of the console and read from the file
// exception handling: throw an exception to deal with read


namespace interimAssessmentDev
{
    class Program
    {
        public delegate void displayDelegate();
        static void Main(string[] args)
        {
            Company c = new Company();
            StreamWriter write = File.CreateText("EmployeeInfo.txt");

            // dynamic polymorphism contained within an indexer example
            Employee Dave = new Executive();
            c[0] = Dave;
            Employee Reggie = new Manager();
            c[1] = Reggie;
            c.printCompanyEmployees();
            Console.WriteLine();

            // static polymorphism: function overloading
            Manager Steve = new Manager();
            Steve.display();
            Steve.display("Steve");
            Console.WriteLine();

            // inheriting an interface
            Employee Roger = new Employee();
            Roger.empNum = 10;
            Roger.name = "Roger";
            Roger.displayEmpInfo();
            Console.WriteLine();

            // delegate for an interface
            displayDelegate del = Roger.display;
            del += Roger.displayEmpInfo;
            Console.WriteLine("using the delegate to call the display functions");
            del.Invoke();
            Console.WriteLine();

            // reading and writing to a file and using exception handling
            write.WriteLine("employee dave's number: {0}", Dave.empNum);
            write.WriteLine("employee Reggie's number: {0}", Reggie.empNum);
            // write.Close(); // if we do not close, we cannot open and will have an error

            try
            {
                StreamReader reader = File.OpenText("EmployeeInfo.txt");
                Console.WriteLine(reader.ReadToEnd());
            }
            catch (Exception e)
            {
                Console.WriteLine("we caught an error! {0}", e.Message);
                Console.WriteLine();
            } finally
            {
                Console.WriteLine("Just to show off that I know how finally works");
            }
            Console.ReadLine();
        }
    }
}
