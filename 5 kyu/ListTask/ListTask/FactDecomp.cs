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
			var list = new List<string>();
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
			return c;
		}
	}
}
