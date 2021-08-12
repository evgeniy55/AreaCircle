using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
	[TestClass]
	public class UnitTest1
	{
		const double eps = 1e-2;


		[TestMethod]

		public void TestAreaRadius()
		{
			var s = AreaCircleLib.Circle.AreaRadius(3);

			Assert.IsTrue(Math.Abs(s - 28.27) < eps);
		}

		[TestMethod]
		[DataRow(3,4,5, 19.63)]	// треугольник с 90 гр. углом
		[DataRow(5,6,8, 50.39)]
		public void TestAreaTriangle(double a, double b, double c, double result)
		{
			var s = AreaCircleLib.Circle.AreaCircleTriagle(a,b,c);

			Assert.IsTrue(Math.Abs(s - result) < eps);
		}



	}
}
