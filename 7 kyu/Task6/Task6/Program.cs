using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
   Simple, given a string of words, return the length of the shortest word(s).
   String will never be empty and you do not need to account for different data types.
*/


namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();
            kata.FindShort("hgjhg j ghjvh jj");
            Console.ReadLine();
        }
    }
}
