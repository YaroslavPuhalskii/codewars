using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
	public class FactDecomp
	{
		public static string Decomp(int n)
		{
			BigInteger intResult = new BigInteger(1);
			var count = 0;
			var list = new List<string>();
			for (int i = 1; i <= n; i++)
			{
				intResult = intResult * i;
			}
			while (intResult % 2 == 0) { count++; intResult /= 2; }
			list.Add(String.Format(count > 1 ? "{0}^{1}" : "{0}", 2, count));
			int div = 3;
			while (Math.Pow(div, 2) <= n*n)
			{
				count = 0;
				while (intResult % div == 0) { count++; intResult /= div; }
				if (count == 0) { div += 2; continue; }
				list.Add(String.Format(count > 1 ? "{0}^{1}" : "{0}", div, count));
			}
			var c = String.Join(" * ", list);
			Console.WriteLine(c);

			/*
			for(int i =1; i<=n;i++)
            {
				intResult = intResult * i;
            }

			for(var number = 2; number<=intResult;number++)
            {
				var count = 0;
				while (intResult % number == 0) { count++; intResult /= number; }
				if (count == 0) { continue; }
				list.Add(String.Format(count > 1 ? "{0}^{1}" : "{0}", number, count));
            }
			var c = String.Join(" * ", list);
			Console.WriteLine(c);
			*/
			return c;
		}
	}
}
