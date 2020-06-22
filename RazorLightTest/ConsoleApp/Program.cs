using System;
using RazorEngine;

namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 10; i++)
			{
				var tmp = RazorRendere.Render("Test.Success");
				Console.WriteLine(tmp);
			}

			Console.ReadLine();
		}
	}
}
