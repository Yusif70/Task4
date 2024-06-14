using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	public abstract class Employee
	{
		public string Name { get; set; }
		public int EmployeeId { get; set; }

		public Employee(string name, int employeeId)
		{
			this.Name = name;
			this.EmployeeId = employeeId;
		}
		public abstract double CalculateMonthlySalary();
		public abstract void DisplayEmployeeDetails();
	}
}
