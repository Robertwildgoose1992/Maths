using System;
namespace Maths_Library
{
	public class Volume
	{
		public int Cube(int Side)
		{
			return (Side * Side) * Side;
		}
		public int Rectagular_Container(int Length,int Width,int Height)
		{
			return Length * Width * Height;
		}
		public int Square_Pyramid(int BaseLength, int Height)
		{
			return ((BaseLength / 3) * (BaseLength / 3)) * Height;
		}
		public double Cylinder(int Radius, int Height)
		{
			return 3.14 * ((Radius * Radius) * Height);
		}
		public double Cone(int Radius,int Height)
		{
			return (1 / 3) * 3.14 * (Radius * Radius) * Height;
		}
		public double Sphere(int Radius)
		{
			return (4 / 3) * 3.14 * ((Radius * Radius) * Radius);
		}
		public double Right_Circular_Cylinder(int Radius, int Height)
		{
			return 3.14 * ((Radius * Radius) * Height);
		}
	}
}
