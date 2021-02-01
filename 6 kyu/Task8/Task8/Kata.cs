using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    public class Kata
    {
        public static string SpinWords(string sentence)
        {
            string[] words = sentence.Split(new char[] { ' ' });
            
            for(int i = 0; i <words.Length;i++)
            {
                if(words[i].Length>= 5)
                {
                    words[i] = new string(words[i].Reverse().ToArray());
                }
                Console.WriteLine(words[i]);
            }
            return string.Join(" ", words);
        }
    }
}
