using System;
using ClassLibrary2;


namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Calc calc = new Calc();

			Console.WriteLine("small test");
			Console.WriteLine($"Adding {calc.Add(3,4)}");
			Console.ReadLine();
		}
	}
}
