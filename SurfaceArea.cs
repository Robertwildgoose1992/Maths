using System;
namespace Maths_Library
{
	public class SurfaceArea
	{
		public int Cube(int Side)
		{
			return (Side * Side) * 6;
		}
		public double Cuboid(int Radius,int Height)
		{
			return ((Radius * Height) * 3.14) * 2;
		}
	}
}
