using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace interimAssessmentDev
{
    class CreatingEmp
    {
        public static Employee createNewEmployee()
        {
            Console.WriteLine("Enter a number for the type of Employee: ");
            Console.WriteLine("Enter 1 for executive");
            Console.WriteLine("Enter 2 for manager");
            Console.WriteLine("Enter 3 for employee");
            Console.WriteLine("Enter 4 for developer");

            int input = -1;
            try
            {
                input = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine("Invalid input: {0}", e.Message);
            }
            Program.writeNewLine(2);
            Employee temp = new Employee();

            switch (input)
            {
                case 1:
                    temp = createExec();
                    break;
                case 2:
                    temp = createMan();
                    break;
                case 3:
                    temp = createEmp();
                    break;
                case 4:
                    temp = createDev();
                    break;
                default:
                    Console.WriteLine("invalid input, canceling add");
                    break;
            }
            
            return temp;
        }
        
        // emp name, emp num
        private static Employee createExec()
        {
            Employee temp = new Executive();
            Console.WriteLine("What is the executive's name?");
            string str = Console.ReadLine();

            int input = -1;
            bool isSet = false;
            
            while(!isSet)
            {
                Console.WriteLine("What is the executive's number?");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    isSet = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input: {0}", e.Message);
                }
            }

            temp.name = str;
            temp.empNum = input;
            return temp;
        }

        private static Employee createMan()
        {
            Employee temp = new Manager();
            Console.WriteLine("What is the Manager's name?");
            string str = Console.ReadLine();

            int input = -1;
            bool isSet = false;

            while (!isSet)
            {
                Console.WriteLine("What is the Manager's number?");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    isSet = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input: {0}", e.Message);
                }
            }

            temp.name = str;
            temp.empNum = input;
            return temp;
        }

        private static Employee createEmp()
        {
            Employee temp = new Employee();
            Console.WriteLine("What is the Employee's name?");
            string str = Console.ReadLine();

            int input = -1;
            bool isSet = false;

            while (!isSet)
            {
                Console.WriteLine("What is the Employee's number?");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    isSet = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input: {0}", e.Message);
                }
            }

            temp.name = str;
            temp.empNum = input;
            return temp;
        }

        // emp name, emp num, sal
        private static Employee createDev()
        {
            Console.WriteLine("What is the Developer's name?");
            string str = Console.ReadLine();

            int input = -1;
            int input2 = -1;
            bool isSet = false;

            while (!isSet)
            {
                Console.WriteLine("What is the Developer's number?");
                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                    isSet = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input: {0}", e.Message);
                }
            }
            isSet = false;

            while (!isSet)
            {
                Console.WriteLine("What is the Developer's salary?");
                try
                {
                    input2 = Convert.ToInt32(Console.ReadLine());
                    isSet = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input: {0}", e.Message);
                }
            }

            Developer dev = new Developer();
            dev.name = str;
            dev.empNum = input;
            dev.salary = input2;

            return dev;
        }
    }
}
