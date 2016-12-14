using System;
using System.Collections.Generic;

namespace Maths_Library
{
	public class Perimeter
	{
		public int Square(int Side)
		{
			return Side * 4;
		}
		public int Rectangle(int Length, int Height)
		{
			return (2 * Length) + (2 * Height);
		}
		public int Triangle(int Sidea, int Sideb, int Sidec)
		{
			return Sidea + Sideb + Sidec;
		}
		public double Circle(int Diameter)
		{
			return 3.14 * Diameter;
		}
		public int Shape(List<int> Sides)
		{
			int Perimeter = 0;
			foreach (var item in Sides)
			{
				Perimeter = Perimeter + item;
			}
			return Perimeter;
		}
	}
}
