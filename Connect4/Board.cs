using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Connect4
{
   public enum Player
    {
        EMPTY, RED, YELLOW
    }
    class Board
    {
        public const int rows = 6;
        public const int cols = 7;
        public static Player[,] board = new Player[rows, cols];
      public static Player currentTurn = Player.YELLOW;
        Player winningPlayer = Player.EMPTY;
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
            currentTurn = Player.YELLOW;
            win = false;

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
         if(win == true)
            {
                return currentTurn;
            }
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

        public bool checkWin()
        {
            //check win for across
            for (int y = 0; y < cols -3; y++)
            {
                for (int x = 0; x < rows; x++)
                {
                    if ((board[x,y] != Player.EMPTY) && (board[x, y] == board[x, y + 1]) && (board[x, y] == board[x, y + 2]) && (board[x, y] == board[x, y + 3]))
                    {
                        win = true;
                        currentTurn = winningPlayer;
                        return win;
                       }
                    }
                    }
            //check win for up and down
            for (int x = 0; x < rows -3 ; x++)
            {
                for (int y = 0; y < cols; y++)
                {
                    if ((board[x,y] != Player.EMPTY)&&(board[x, y] == board[x + 1, y]) && (board[x, y] == board[x + 2, y]) && (board[x, y] == board[x + 3, y])) { 
                        win = true;
                    currentTurn = winningPlayer;
                        return win;
                    }
                }
            }
                
            //check win for diagonal
            for (int x = 3; x < rows ; x++)
            {
                for (int y = 0; y < cols - 3; y++)
                {
                    if ((board[x,y] != Player.EMPTY)&&(board[x, y] == board[x - 1, y+1]) && (board[x, y] == board[x - 2, y+2]) && (board[x, y] == board[x - 3, y+3])) { 
                        win = true;
                    currentTurn = winningPlayer;
                        return win;
                    }
                }
            }
            
            //check win for other diagonal
            for (int x = 0; x < rows -3 ; x++)
            {
                for (int y = 0; y < cols -3; y++)
                {
                    if ((board[x,y] != Player.EMPTY)&&(board[x, y] == board[x - 1, y-1]) && (board[x, y] == board[x - 2, y-2]) && (board[x, y] == board[x - 3, y-3])) { 
                        win = true;
                    currentTurn = winningPlayer;
                        return win;
                    }
                }
            }
            return win;
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
           

        
    
