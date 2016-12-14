using System;
namespace Maths_Library
{
	public class Area
	{
		public static int Square(int Side)
		{
			return Side * Side;
		}
		public static int Rectangle(int Length,int Width)
		{
			return Length * Width;
		}
		public static int Parallelogram(int Base,int Height)
		{
			return Base * Height;
		}
		public static int Triangle(int Base, int Height)
		{
			return (Base * Height) / 2;
		}
		public static double Circle(int Radius)
		{
			return (3.14 * Radius) * (3.14 * Radius);
		}
		public static int Trapezoid(int Base1,int Base2,int Height)
		{
			return ((Base1 + Base2) * Height) / 2;
		}
		public static double Sphere(int Radius)
		{
			return ((3.14 * Radius) * (3.14 * Radius)) * 4;
		}
	}
}
