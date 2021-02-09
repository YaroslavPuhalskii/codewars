using System;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
The aim of the kata is to decompose n! (factorial n) into its prime factors.
Examples:

n = 12; decomp(12) -> "2^10 * 3^5 * 5^2 * 7 * 11"
since 12! is divisible by 2 ten times, by 3 five times, by 5 two times and by 7 and 11 only once.

n = 22; decomp(22) -> "2^19 * 3^9 * 5^4 * 7^3 * 11^2 * 13 * 17 * 19"

n = 25; decomp(25) -> 2^22 * 3^10 * 5^6 * 7^3 * 11^2 * 13 * 17 * 19 * 23
Prime numbers should be in increasing order. When the exponent of a prime is 1 don't put the exponent.

Notes
the function is decomp(n) and should return the decomposition of n! into its prime factors
in increasing order of the primes, as a string.
factorial can be a very big number (4000! has 12674 digits, n can go from 300 to 4000).
In Fortran - as in any other language - the returned string is not permitted to contain
any redundant trailing whitespace: you can use dynamically allocated character strings.
*/

namespace ListTask
{
	public class FactDecomp
	{
		public static string Decomp(int n)
		{
			bool[] u = new bool[n + 1]; // маркеры для решета Эратосфена
			var list = new List<string>();
			for (int i = 2; i <= n; ++i)
				if (!u[i]) // если i - очередное простое число
				{
					// считаем показатель степени в разложении
					int k = n / i;
					int c = 0;
					while (k > 0)
					{
						c += k;
						k /= i;
					}
					// запоминаем множитель и его показатель степени
					list.Add(String.Format(c > 1 ? "{0}^{1}" : "{0}", i, c));
					// просеиваем составные числа через решето               
					int j = 2;
					while (i * j <= n)
					{
						u[i * j] = true;
						++j;
					}
				}
			var res = String.Join(" * ", list);
			return res;
			
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
		}
	}
}
