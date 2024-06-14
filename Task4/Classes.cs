using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	public class FullTimeEmployee : Employee
	{
		public int AnnualSalary { get; set; }
		public FullTimeEmployee(string name, int employeeId, int annualSalary) : base(name, employeeId)
		{
			this.AnnualSalary = annualSalary;
		}
		public override double CalculateMonthlySalary()
		{
			return AnnualSalary / 12;
		}
		public override void DisplayEmployeeDetails()
		{
			Console.WriteLine($"employee name: {Name}, id: {EmployeeId}, salary: {CalculateMonthlySalary()}");
		}
	}
	public class ContractEmployee : Employee
	{
		public int HourRate { get; set; }
		public int HoursWorked { get; set; }
		public ContractEmployee(string name, int employeeId, int hourRate, int hoursWorked) : base(name, employeeId)
		{
			this.HourRate = hourRate;
			this.HoursWorked = hoursWorked;
		}
		public override double CalculateMonthlySalary()
		{
			return HourRate * HoursWorked;
		}
		public override void DisplayEmployeeDetails()
		{
			Console.WriteLine($"employee name: {Name}, id: {EmployeeId}, salary: {CalculateMonthlySalary()}");
		}
	}
	public class Traffic
	{
		public string GetName(int value)
		{
			if (Enum.IsDefined(typeof(TrafficLight), value))
				return Enum.GetName(typeof(TrafficLight), value);
			else
				return "given value is not defined";
		}
	}
	public class CoffeeShop
	{
		public static int GetPrice(CoffeeSize size)
		{
			switch (size)
			{
				case CoffeeSize.Small:
					return 1;
				case CoffeeSize.Medium:
					return 2;
				case CoffeeSize.Large:
					return 3;
				default:
					return 0;
			}
		}
		public static string CalculateTotal(CoffeeSize size, int quantity)
		{
			return $"total will be {GetPrice(size) * quantity}$";
		}
	}
}