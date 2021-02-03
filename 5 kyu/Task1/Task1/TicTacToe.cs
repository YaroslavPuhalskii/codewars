using System;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Task1
{
    public class TicTacToe
    {
        public static int IsSolved(int[,] board)
        {
            int a = -1;int b = 1;int c = 2; int d = 0; int sum =0;

                if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
                {
                    if (board[0, 0] != 0)
                    {
                        if (board[0, 0] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }

                if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
                {
                    if (board[1, 0] != 0)
                    {
                        if (board[0, 0] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }

                if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
                {
                    if (board[2, 0] != 0)
                    {
                        if (board[0, 0] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }

                if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
                {
                    if (board[0, 1] != 0)
                    {
                        if (board[0, 0] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }

                if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
                {
                    if (board[0, 0] != 0)
                    {
                        if (board[0, 2] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }

                if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
                {
                    if (board[0, 0] != 0)
                    {
                        if (board[0, 0] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }

                if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
                {
                    if (board[0, 0] != 0)
                    {
                        if (board[0, 0] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }

                if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
                {
                    if (board[2, 0] != 0)
                    {
                        if (board[0, 0] == 1)
                        { sum = b; }
                        if (board[0, 0] == 2)
                        { sum = c; }
                    }
                }
            int count = 0;
            if(sum == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (board[i, j] == 0)
                        {
                            count++;  
                        }
                    }
                }
                sum = count > 0 ? a : d;
            }
            return sum;
        }
    }
}
