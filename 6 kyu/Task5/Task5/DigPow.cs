using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class DigPow
    {
        public static long digPow(int n, int p)
        {
            List<int> list = new List<int>(); int k; int v= -1;
            int sum=0; int u = 0; int o = n;
            #region Запись в массив
            int Count = (int)Math.Log10(n) + 1;
            for (int i = 0; i<Count; i++)
            {
                k = n % 10;
                list.Add(k);
                n /= 10;
            }
            #endregion
            list.Reverse();
            #region Вычисление Суммы
            foreach (int q in list)
            {
                u = (int)Math.Pow(q, p);
                sum = sum + u;
                p++;
            }
            #endregion

            if(o != 0 && sum%o==0)
            {
                v = sum / n;
            }
            Console.WriteLine(sum);
            return v;
        }
    }
}
