using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class Kata
    {
        public static int CountBits(int n)
        {
            int count=0;
            string BinaryCode = Convert.ToString(n, 2);
            for(int i =0;i<BinaryCode.Length;i++)
            {
                if(BinaryCode[i]=='1')
                {
                    count++;
                }
            }
            Console.WriteLine(BinaryCode +"-"+ count);
            return count;
        }
    }
}
