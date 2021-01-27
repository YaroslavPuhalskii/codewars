using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Check to see if a string has the same amount of 'x's and 'o's. 
The method must return a boolean and be case insensitive. The string can contain any char.

Examples input/output:
XO("ooxx") => true
XO("xooxx") => false
XO("ooxXm") => true
XO("zpzpzpp") => true // when no 'x' and 'o' is present should return true
XO("zzoo") => false
*/
namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();

            kata.XO("ooxx");// true
            kata.XO("xooxx");// false
            kata.XO("ooxXm");// true
            kata.XO("zpzpzpp");// true
            kata.XO("zzoo");// false

            Console.ReadLine();
        }
    }
}
