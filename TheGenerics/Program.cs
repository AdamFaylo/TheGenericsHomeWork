using System;

namespace MyApp
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SimpleStack<double> stackOfDouble = new SimpleStack<double>();

			stackOfDouble.Push(1.2);
			stackOfDouble.Push(2.4);
			stackOfDouble.Push(5.6);
			stackOfDouble.Push(7.8);
			stackOfDouble.Push(9.10);

			while (stackOfDouble.Count > 0)
			{
				double value = stackOfDouble.Pop();
				Console.WriteLine(value);
			}

			Console.WriteLine("--------------------------------------------------");

			SimpleStack<string> stackOfString = new SimpleStack<string>();

			stackOfString.Push("Adam");
			stackOfString.Push("Is");
			stackOfString.Push("Cool");

			while (stackOfString.Count > 0)
			{
				string value = stackOfString.Pop();
				Console.WriteLine(value);
			}
		}
	}
} 