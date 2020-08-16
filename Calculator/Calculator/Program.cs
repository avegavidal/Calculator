using System;

namespace Calculator
{
	public class Calculator
	{
		public int Add(int a, int b) { return a + b; }
	}

	public class Logger
	{
		public void Log(string message) { Console.WriteLine(message); }
	}

	public class Program
	{
		public static void Main(string[] args)
		{
			int a, b;
			Logger _log = new Logger();
			try
            {
				_log.Log("Enter first number (integer): ");
				string inputA = Console.ReadLine();

				_log.Log("Enter second number(integer): ");
				string inputB = Console.ReadLine();

				if (int.TryParse(inputA, out a) && int.TryParse(inputB, out b))
				{
					Calculator _calculator = new Calculator();
					int result = _calculator.Add(a, b);
					_log.Log($"The result of {a} + {b} is: {result}");
				}
				else {
					_log.Log("Please check the numbers that your entered and try again.");
				}
			}
            catch (Exception)
            {

				_log.Log("Something went wrong while we try to add your numbers, please try again later");
			}
			

		}
	}
}
