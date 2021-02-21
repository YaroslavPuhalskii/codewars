using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a function, persistence, that takes in a positive parameter num and returns its
multiplicative persistence, which is the number of times you must multiply the digits
in num until you reach a single digit.
For example:

 persistence(39) == 3 // because 3*9 = 27, 2*7 = 14, 1*4=4
                      // and 4 has only one digit

 persistence(999) == 4 // because 9*9*9 = 729, 7*2*9 = 126,
                       // 1*2*6 = 12, and finally 1*2 = 2

 persistence(4) == 0 // because 4 is already a one-digit number
*/
namespace ListTask
{
	public class Persist
	{
		public static int Persistence(long n)
		{
            if (n < 10) return 0;
            var count = 0;
            return PersistentBuggerFunction(n, count);
        }

        private static int PersistentBuggerFunction(long n, int count)
        {
            var i = n.ToString().ToCharArray();
            var temp = 1;
            foreach (var target in i) temp *= (target - 48);
            count++;
            if (temp < 10) return count;
            return PersistentBuggerFunction(temp, count);
        }
    }
}
