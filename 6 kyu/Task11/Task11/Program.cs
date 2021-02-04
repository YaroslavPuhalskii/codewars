using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, 5, -2, -1 };
            Kata.find_it(a);
            Console.ReadLine();
        }
    }
}
