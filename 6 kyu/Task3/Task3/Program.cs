using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*говно-код - хорошо, что сработал
Complete the solution so that it splits the string into pairs of two characters.
If the string contains an odd number of characters then it should replace the missing
second character of the final pair with an underscore ('_').

Examples:
SplitString.Solution("abc"); // should return ["ab", "c_"]
SplitString.Solution("abcdef"); // should return ["ab", "cd", "ef"]
*/
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            SplitString.Solution("abljjkvbklkjhjlv");
            Console.ReadLine();
        }
    }
}
