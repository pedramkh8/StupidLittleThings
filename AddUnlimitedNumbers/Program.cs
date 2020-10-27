using AddUnlimitedNumbers.Class;
using System;
using System.Text.RegularExpressions;

namespace AddUnlimitedNumbers
{
	class Program
	{
		static void Main(string[] args)
		{
			Regex regex = new Regex(@"^\d+$");

			while (true)
			{
			EnterFirstNumber:
				Console.WriteLine("Enter The First Number:");
				string firstNumber = Console.ReadLine();

				if (!regex.IsMatch(firstNumber))
				{
					Console.WriteLine("Please Enter A Number!");
					goto EnterFirstNumber;
				}

			EnterSecondNumber:
				Console.WriteLine("Enter The Second Number:");
				string secondNumber = Console.ReadLine();

				if (!regex.IsMatch(secondNumber))
				{
					Console.WriteLine("Please Enter A Number!");
					goto EnterSecondNumber;
				}

				NodeList first = new NodeList(firstNumber);
				NodeList second = new NodeList(secondNumber);
				NodeList result = first.Add(first, second);
				string resultToShow = string.Empty;

				while (result != null)
				{
					resultToShow += result.Value.ToString();
					result = result.Next;
				}

				Console.WriteLine($"Result: {resultToShow}");
			}
		}
	}
}
