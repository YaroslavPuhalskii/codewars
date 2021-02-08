using System;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public class Kata
    {
        public static string sumStrings(string a, string b)
        {
            BigInteger BigIntA = new BigInteger();
            BigInteger BigIntB = new BigInteger();
            BigInteger result = new BigInteger();

            if ( a == "") { a = "0"; }
            if ( b == "") { b = "0"; }

            BigIntA = BigInteger.Parse(a, NumberStyles.Integer);
            BigIntB = BigInteger.Parse(b, NumberStyles.Integer);

            result = BigIntA + BigIntB;

            return result.ToString();            
        }
    }
}
