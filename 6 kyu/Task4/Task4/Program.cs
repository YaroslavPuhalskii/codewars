using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
There is an array with some numbers. All numbers are equal except for one. Try to find it!

findUniq([ 1, 1, 1, 2, 1, 1 ]) === 2
findUniq([ 0, 0, 0.55, 0, 0 ]) === 0.55
It’s guaranteed that array contains at least 3 numbers.

The tests contain some very huge arrays, so think about performance.
*/
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> a = new List<int>() { 1, 1, 1, 2, 1, 1 };
            List<int> b = new List<int>() { 2, 2, 2, 1, 2, 2 };
            Kata.GetUnique(a);
            Kata.GetUnique(b);
            Console.ReadLine();
        }
    }
}
