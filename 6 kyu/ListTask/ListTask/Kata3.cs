using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Text;
using System.Threading.Tasks;
/*
Welcome.

In this kata you are required to, given a string, replace every letter with its position in the alphabet.
If anything in the text isn't a letter, ignore it and don't return it.
"a" = 1, "b" = 2, etc.

Example
Kata.AlphabetPosition("The sunset sets at twelve o' clock.")
Should return "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11" (as a string)
*/
namespace ListTask
{
    public static class Kata3
    {
        public static string AlphabetPosition(string text)
        {
            List<int> list = new List<int>();
            foreach(var p in Regex.Replace(text, "(?i)[^А-ЯЁA-Z]", ""))
            {
                int index = (int)p % 32;
                list.Add(index);
            }
            return String.Join(" ", list);
        }
    }
}
