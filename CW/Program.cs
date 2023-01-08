using CW;
using System;

namespace MyApp 
{
	internal class Program
	{
		static void Main(string[] args)
		{
		
 			SimpleStack<double> s1= new SimpleStack<double>();
			s1.Push(1.2);
			s1.Push(2.3);
			s1.Push(3.4);
			s1.Push(4.5);
			s1.Push(5.6);
			while (s1.Count > 0)
			{
				double value = s1.Pop();
				Console.WriteLine(value);	
			}
		}
	}
}