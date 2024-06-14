using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region employee
			//Employee employee1 = new ContractEmployee("yusif", 1, 100, 10);
			//employee1.DisplayEmployeeDetails();
			#endregion

			#region traffic
			//Traffic obj = new Traffic();
			//Console.Write("enter a value: ");
			//int value = int.Parse(Console.ReadLine());
			//Console.WriteLine(obj.GetName(value));
			#endregion

			#region coffee shop
			//Console.WriteLine(CoffeeShop.CalculateTotal(CoffeeSize.Medium, 2));
			#endregion

			#region palindrome number
			//Console.Write("enter a number: ");
			//int num = int.Parse(Console.ReadLine());
			//Console.WriteLine(IsPalindrome(num));
			#endregion
        }
		static string IsPalindrome(int num)
		{
			string s = num.ToString();
			for (int i = 0; i < s.Length / 2;)
			{
				if ((num % Power(10, i + 1) - num % Power(10, i)) / Power(10, i) == (num % Power(10, s.Length) - num % Power(10, s.Length - 1)) / Power(10, s.Length - 1))
				{
					break;
				}
				else
				{
					return "number is not palindrome";
				}
			}
			return "number is palindrome";

			//for (int i = 0; i < s.Length;)
			//{
			//	if (s[i] == s[s.Length - 1])
			//	{
			//		break;
			//	}
			//	else
			//	{
			//		return "number is not palindrome";
			//	}
			//}
			//return "number is palindrome";
		}
		static int Power(int num, int power)
		{
			int newNum = 1;
			for (int i = 0; i < power; i++)
			{
				newNum *= num;
			}
			return newNum;
		}
	}
}
