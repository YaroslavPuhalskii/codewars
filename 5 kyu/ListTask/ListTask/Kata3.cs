using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
Greed is a dice game played with five six-sided dice.
Your mission, should you choose to accept it, is to score a throw according to these rules.
You will always be given an array with five six-sided dice values.

 Three 1's => 1000 points
 Three 6's =>  600 points
 Three 5's =>  500 points
 Three 4's =>  400 points
 Three 3's =>  300 points
 Three 2's =>  200 points
 One   1   =>  100 points
 One   5   =>   50 point
A single die can only be counted once in each roll. For example,
a given "5" can only count as part of a triplet (contributing to the 500 points) 
or as a single 50 points, but not both in the same roll.

Example scoring

 Throw       Score
 ---------   ------------------
 5 1 3 4 1   250:  50 (for the 5) + 2 * 100 (for the 1s)
 1 1 1 3 1   1100: 1000 (for three 1s) + 100 (for the other 1)
 2 4 4 5 4   450:  400 (for three 4s) + 50 (for the 5)
*/
namespace ListTask
{
    public static class Kata3
    {
        public static int Score(int[] dice)
        {
            var c = dice.ToList();
            var res = 0;
            foreach(var p in c.Distinct())
            {
               var count = c.Count(x => x == p);
               while(count>0)
                {
                    if (p == 1) 
                    {
                        if (count > 2) { res += 1000; count -= 3; }
                        else { res += 100; count -= 1; }
                    }
                    if(p>1 && p <7)
                    {
                        if (count > 2) { res = res + p * 100; count -= 3; }
                        if (p == 5 && count == 1) { res += 50; count--; }
                        else { count = 0; }
                    }
                } 
            }
            Console.WriteLine(res);
            return res;
        }
    }
}
