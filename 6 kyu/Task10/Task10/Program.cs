using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Write a simple parser that will parse and run Deadfish.

Deadfish has 4 commands, each 1 character long:

i increments the value (initially 0)
d decrements the value
s squares the value
o outputs the value into the return array
Invalid characters should be ignored.

Deadfish.Parse("iiisdoso") => new int[] {8, 64};
*/
namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "iiisdoso";
            Deadfish.Parse(str);
            Console.ReadLine();
        }
    }
}
