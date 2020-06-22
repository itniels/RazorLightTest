using System;
using RazorEngine;

namespace ConsoleAppNetFramework
{
	class Program
	{
		static void Main(string[] args)
		{
			for (int i = 0; i < 1000; i++)
			{
				var tmp = RazorRendere.Render("Test.Success");
				Console.WriteLine(tmp);
			}

			Console.ReadLine();
		}
	}
}
