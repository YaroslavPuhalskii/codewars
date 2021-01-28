using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
	public static class Kata
	{
		public static int sumTwoSmallestNumbers(int[] numbers)
		{
			var c = numbers.OrderBy(x =>x).Take(2);
			int sum = 0;
			foreach (int p in c)
			{
				sum += p;
			}
			return sum;
		}
	}
}
