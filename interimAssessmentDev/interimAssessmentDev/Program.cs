using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

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
// threading?
//
// modules: Create, Retrieve, Update, Delete
// types objects: Company, Employee, Manager, Executive, ITProfessional
// 
// UI goals: Start at company level with CRUD
//           R -> goes to company and allows employee interactions
//           Employee -> CRUD operations
// 
// this is going to get ugly fast- maybe we wait at this point
// company format: company <company name>
//                 employee <employee <employee type> <employee info>>
//
// Left to do:
//        Complete View (display all employees)
//        Edit/Remove (pick an employee from the list and edit or remove)
//        Finish creating
//              writing to the file
//        Add reading from the file so that the data will persist (do before writing so that it isn't super ugly)

namespace interimAssessmentDev
{
    class Program
    {
        public delegate void displayDelegate();
        public static Company comp = new Company("Zach's Employees");
        static void Main(string[] args)
        {
            // check if the file exits
            if (!File.Exists("C:/Users/zchuc/EmployeeInfo.txt"))
            {
                File.CreateText("C:/Users/zchuc/EmployeeInfo.txt");
            } else
            {
                // read in employees in the company
            }

            bool cont = true;
            Console.WriteLine("Welcome to the Employee Editor for {0}", comp.name);
            writeNewLine(2);
            while (cont)
            {
                Console.WriteLine("Company Portal");
                Console.WriteLine("Enter 1 to create a new employee");
                Console.WriteLine("Enter 2 to view an existing employee");
                Console.WriteLine("Enter 3 to remove an existing employee");
                Console.WriteLine("Enter 4 to exit");
                int input = -1;
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                } catch (Exception e)
                {
                    Console.WriteLine("Invalid input: {0}", e.Message);
                }
                writeNewLine(2);

                switch (input)
                {
                    case 1:
                        comp[comp.length] = CreatingEmp.createNewEmployee();
                        break;
                    case 2:
                        viewCompany();
                        break;
                    case 3:
                        removeCompany();
                        break;
                    case -1:
                        break;
                    case 4:
                        cont = false;
                        Console.WriteLine("Goodbye");
                        System.Threading.Thread.Sleep(1000);
                        break;
                    default:
                        Console.WriteLine("invalid input");
                        break;
                }

                writeNewLine(2);
            }








            /*
            Company c = new Company();
            

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
            */
        }

        

        public static void viewCompany()
        {
            Console.WriteLine("in view");
        }

        public static void removeCompany()
        {
            Console.WriteLine("in remove");
        }

        public static void writeNewLine(int num)
        {
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
