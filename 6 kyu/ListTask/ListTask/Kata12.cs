using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListTask
{
    public class Kata12
    {
        public static string[] TowerBuilder(int nFloors)
        {
            var tower = new List<string>(nFloors);

            for (var currFloor = 1; currFloor <= nFloors; currFloor++)
            {
                var padding = new string(' ', nFloors - currFloor);
                var blocks = new string('*', ((currFloor - 1) * 2) + 1);
                tower.Add($"{padding}{blocks}{padding}");
            }
            return tower.ToArray();
        }
    }
}
