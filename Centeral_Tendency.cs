using System;
using System.Collections.Generic;

namespace Maths_Library
{
	public class Centeral_Tendency
	{
		public int Mean(List<int> results)
		{
			int ResultCount = 0;
			foreach (var item in results)
			{
				ResultCount = ResultCount + item;
			}
			return ResultCount / results.Count;
		}
		public decimal Median(List<int> results)
		{
			int[] Temp = results.ToArray();
			Array.Sort(Temp);
			int count = Temp.Length;
			if (count == 0)
			{
				throw new InvalidOperationException("Empty Collection");
			}
			else if (count % 2 == 0)
			{
				int a = Temp[count / 2 - 1];
				int b = Temp[count / 2];
				return (a + b) / 2;
			}
			else {
				return Temp[count / 2];
			}
		}
	}
}
