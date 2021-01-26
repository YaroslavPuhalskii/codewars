using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Welcome.In this kata, you are asked to square every digit of a number and concatenate them.
  For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.
 Note: The function accepts an integer and returns an integer*/


namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            int n = 128;
            kata.Disemvowel(n);

            Console.ReadLine();
        }
    }
}
