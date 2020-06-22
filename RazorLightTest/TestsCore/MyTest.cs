using RazorEngine;
using NUnit.Framework;

namespace Tests
{
	[Parallelizable]
	class MyTest
	{
		[Test]
		public void TestSuccess()
		{
			RazorRendere.Render("Test.Success");
		}
	}
}
