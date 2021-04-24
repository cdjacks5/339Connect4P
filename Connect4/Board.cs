using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
    enum Player
    {
        EMPTY, RED, YELLOW
    }
    class Board
    {
        public const int rows = 6;
        public const int cols = 7;
        public static Player[,] board = new Player[rows, cols];
        Player currentTurn = Player.RED;
        bool win = false;

        public Board()
        {
            //constructor
            ResetBoard();
        }

        public void ResetBoard()
        {
            //reset the game board to empty
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    board[i, j] = Player.EMPTY;
                }
            }

        }

        

       
        //bool method to check if cols is full
        public bool ColumnIsFull(int col)
        {
            if(board[0,col] != Player.EMPTY)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //create next turn method
        public Player NextTurn()
        {
         
            if(currentTurn == Player.RED)
            {
                currentTurn = Player.YELLOW;
            }
            else if(currentTurn == Player.YELLOW) {
                currentTurn = Player.RED;
            }
            return currentTurn;
        }

        public void DrawBoard(Graphics g)
        {
            int start = 50; //board top left corner offset

            g.FillRectangle(Brushes.Navy, start, start, 700, 600);

            //draw the board columns
            for (int i = 100; i <= 600; i = i + 100)
                g.DrawLine(Pens.White, start + i, start, start + i, start + 600);

            //draw the board rows
            for (int i = 100; i <= 500; i = i + 100)
                g.DrawLine(Pens.White, start, start + i, start + 700, start + i);


            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (board[i, j] == Player.RED)
                    {
                        g.FillEllipse(Brushes.Red, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else if (board[i, j] == Player.YELLOW)
                    {
                        g.FillEllipse(Brushes.Yellow, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                    else
                    {
                        g.FillEllipse(Brushes.White, (start + 5) + (j * 100), (start + 5) + (i * 100), 90, 90);
                    }
                }
            }
        }

        //play piece method to input piece
        public void PlayPiece(int col)
        {
            for (int i = rows - 1; i >= 0; i--)
            {
                if (board[i, col] == Player.EMPTY)
               {
                    board[i, col] = currentTurn;
                    break;
                }
           }

        }
   

    }
}