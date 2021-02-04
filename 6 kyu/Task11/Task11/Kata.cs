using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    public class Kata
    {
        public static int find_it(int[] seq)
        {
            var arr = seq.ToList().OrderBy(xo => xo).ToArray();
            int count = 1; int x = 0;
            for(int i = 0; i<arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                if(i <arr.Count()-1)
                {
                    if (arr[i] == arr[i + 1])
                    { count++; }
                    if (arr[i] != arr[i + 1] && (count % 2 == 1 || count == 1))
                    {
                        x = arr[i];
                        count = 1;
                    }
                    else if (arr[i] != arr[i+1] && count%2==0){ count = 1; }
                }                
            }
            Console.WriteLine(x);
            return x;
        }
    }
}
