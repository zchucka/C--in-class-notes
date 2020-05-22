
using System;
using System.Collections.Generic;



namespace LamdaDemo
{
	delegate bool IsPromotable(Employee empl); // delegate
	class Employee
	{
	public int ID { get; set; }
	public string Name { get; set; }
	public int Salary { get; set; }
	public int Experience { get; set; }

	public static void PromoteEmployee(List<Employee> employeeList, IsPromotable IsEligiblePromote)
	{
		foreach (Employee employee in employeeList)
		{
			if (IsEligiblePromote(employee))
			{
				Console.WriteLine(employee.Name + " " + "Promoted");
			}
		}

	}
	public static void Main()
	{
		//Console.WriteLine("Hello World");
		List<Employee> empList = new List<Employee>();

		empList.Add(new Employee() { ID = 101, Name = "Prashant", Salary = 5000, Experience = 4 });
		empList.Add(new Employee() { ID = 101, Name = "Mike", Salary = 6000, Experience = 6 });
		empList.Add(new Employee() { ID = 101, Name = "John", Salary = 3000, Experience = 3 });
		empList.Add(new Employee() { ID = 101, Name = "Prash", Salary = 5000, Experience = 5 });


		//creating instance of dekegate

		//IsPromotable isPromotable = new IsPromotable(Promotion);

		Employee.PromoteEmployee(empList, emp => emp.Experience < 5); // Lambda expression

	}

}

}

// Define other methods, classes and namespaces here
