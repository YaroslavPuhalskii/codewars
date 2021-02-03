using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Move the first letter of each word to the end of it, then add "ay" to the end of the word.
Leave punctuation marks untouched.

Examples
Kata.PigIt("Pig latin is cool"); // igPay atinlay siay oolcay
Kata.PigIt("Hello world !");     // elloHay orldway !
*/
namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = "Pig latin is cool !";
            Kata.PigIt(str);
            Console.ReadLine();
        }
    }
}
