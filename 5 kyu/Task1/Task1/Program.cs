using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[,] { { 1, 1, 1 },
                                        { 0, 2, 2 },
                                        { 0, 0, 0 } };
            TicTacToe.IsSolved(board);
            Console.ReadLine();
        }
    }
}
