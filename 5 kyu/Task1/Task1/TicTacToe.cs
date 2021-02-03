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
            if (board[0, 0] == board[0, 1] && board[0, 1] == board[0, 2])
            {
                
            }

            if (board[1, 0] == board[1, 1] && board[1, 1] == board[1, 2])
            {
                
            }

            if (board[2, 0] == board[2, 1] && board[2, 1] == board[2, 2])
            {
               
            }

            if (board[0, 1] == board[1, 1] && board[1, 1] == board[2, 1])
            {
                
            }

            if (board[0, 2] == board[1, 2] && board[1, 2] == board[2, 2])
            {
                
            }

            if (board[0, 0] == board[1, 0] && board[1, 0] == board[2, 0])
            {
                
            }

            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2])
            {
                
            }

            if (board[2, 0] == board[1, 1] && board[1, 1] == board[0, 2])
            {
                
            }
            return 0;
        }
    }
}
