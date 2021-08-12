using System;

namespace AreaCircleLib
{
	public static class Circle
	{


		public static double AreaRadius(double radius)
		{
			if (radius < 0d)
			{
				throw new ArgumentException();
			}

			return Math.PI * Math.Pow(radius, 2);
		}

		public static double AreaCircleTriagle(double a, double b, double c)
		{
			if (a < 0 || b < 0 || c < 0)
			{
				throw new ArgumentException();
			}
			// проверка длинн сторон 
			if (!(a < (b + c) || b < (a + c) || c < (a + b)))
			{
				throw new ArgumentException();
			}


			// проверяем по теореме пифагора угол на 90 гр. и расчитываем площадь
			if (a * a + b * b == c * c)
			{
				return AreaTriangleRightAngle(a, b);
			}
			if (a * a + c * c == b * b)
			{
				return AreaTriangleRightAngle(a, c);
			}
			if (c * c + b * b == a * a)
			{
				return AreaTriangleRightAngle(c, b);
			}


			// площадь треугольника с известными сторонами
			return AreaTriangleSides(a, b, c);
		}


		// для добавления других способов проверки добавляем перегрузку метода AreaCircleTriagle с новыми параметрами
		// для добавления других фигур добавляем новые классы в библиотеку
		// не понял задание: Вычисление площади фигуры без знания типа фигуры в compile-time

		private static double AreaTriangleRightAngle(double a, double b)
		{
			return Math.PI / 4 * (a * a + b * b);
		}

		private static double AreaTriangleSides(double a, double b, double c)
		{
			double p = (a + b + c) / 2;

			double sTr = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
			double r = (a * b * c) / (4 * sTr);

			return Math.PI * Math.Pow(r, 2);
		}


	}
}
