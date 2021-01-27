using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*  You are going to be given a word. Your job is to return the middle character of the word.
    If the word's length is odd, return the middle character. If the word's length is even,
    return the middle 2 characters.

#Examples:
Kata.getMiddle("test") should return "es"
Kata.getMiddle("testing") should return "t"
Kata.getMiddle("middle") should return "dd"
Kata.getMiddle("A") should return "A"
*/


namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kata kata = new Kata();

            kata.GetMiddle("test");
            kata.GetMiddle("testing");
            kata.GetMiddle("middle");
            kata.GetMiddle("A");

            Console.ReadLine();
        }
    }
}
