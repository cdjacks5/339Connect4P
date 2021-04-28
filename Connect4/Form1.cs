using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Name: Christopher Jackson
// CSC339 - Spring 2021
// Assignment 4

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connect4
{
    public partial class Form1 : Form
    {
        private Board board;
       
        public Form1()
        {
            InitializeComponent();

            //adds the event handler for when the screen is painted
            this.Paint += new PaintEventHandler(pic_board_Paint);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //gets called when the main form is loaded
            board = new Board();
          }
        

        private void pic_board_Paint(object sender, PaintEventArgs e)
        {
            //gets called whenever the screen is painted
            board.DrawBoard(e.Graphics);
        }

        
        
        //button 1
        private void btn_col1_Click(object sender, EventArgs e)
        {
             if(board.checkWin()==true)
            {
              DialogResult d = MessageBox.Show("There is a winner,Do you want to play again?","Winner",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    board.ResetBoard();
                }
                else if(d == DialogResult.No){
                    Application.Exit();
                }
            }
           
            //insert piece into board
           if (board.ColumnIsFull(0)) { 
                btn_col1.Enabled = false;
                }
            else
            {
                board.PlayPiece(col:0);
                this.Refresh();
                board.NextTurn();
                
            }
          
        }
        //button2
        private void btn_col2_Click(object sender, EventArgs e)
        {
            if(board.checkWin()==true)
            {
              DialogResult d = MessageBox.Show("There is a winner,Do you want to play again?","Winner",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    board.ResetBoard();
                }
                else if(d == DialogResult.No){
                    Application.Exit();
                }
            }
            //insert piece into board
            if (board.ColumnIsFull(1))
            {
                btn_col2.Enabled = false;
            }
            else
            {
                board.PlayPiece(col: 1);
                this.Refresh();
                board.NextTurn();
            }
        }
        //button 3
        private void btn_col3_Click(object sender, EventArgs e)
        {
             if(board.checkWin()==true)
            {
              DialogResult d = MessageBox.Show("There is a winner,Do you want to play again?","Winner",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    board.ResetBoard();
                }
                else if(d == DialogResult.No){
                    Application.Exit();
                }
            }
            //insert piece into board
            if (board.ColumnIsFull(2))
            {
                btn_col3.Enabled = false;
            }
            else
            {
                board.PlayPiece(col: 2);
                this.Refresh();
                board.NextTurn();
            }
        }
        //button 4
        private void btn_col4_Click(object sender, EventArgs e)
        {
            if(board.checkWin()==true)
            {
              DialogResult d = MessageBox.Show("There is a winner,Do you want to play again?","Winner",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    board.ResetBoard();
                }
                else if(d == DialogResult.No){
                    Application.Exit();
                }
            }
            //insert piece into board
            if (board.ColumnIsFull(3))
            {
                btn_col4.Enabled = false;
            }
            else
            {
                board.PlayPiece(col: 3);
                this.Refresh();
                board.NextTurn();
            }
        }
        //button 5
        private void btn_col5_Click(object sender, EventArgs e)
        {
            if(board.checkWin()==true)
            {
              DialogResult d = MessageBox.Show("There is a winner,Do you want to play again?","Winner",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    board.ResetBoard();
                }
                else if(d == DialogResult.No){
                    Application.Exit();
                }
            }
            //insert piece into board
            if (board.ColumnIsFull(4))
            {
                btn_col5.Enabled = false;
            }
            else
            {
                board.PlayPiece(col: 4);
                this.Refresh();
                board.NextTurn();
            }
        }
        //button 6
        private void btn_col6_Click(object sender, EventArgs e)
        {
            if(board.checkWin()==true)
            {
              DialogResult d = MessageBox.Show("There is a winner,Do you want to play again?","Winner",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    board.ResetBoard();
                }
                else if(d == DialogResult.No){
                    Application.Exit();
                }
            }
            //insert piece into board
            if (board.ColumnIsFull(5))
            {
                btn_col6.Enabled = false;
            }
            else
            {
                board.PlayPiece(col: 5);
                this.Refresh();
                board.NextTurn();
            }
        }
        //button 7
        private void btn_col7_Click(object sender, EventArgs e)
        {
             if(board.checkWin()==true)
            {
              DialogResult d = MessageBox.Show("There is a winner,Do you want to play again?","Winner",MessageBoxButtons.YesNo);
                if(d == DialogResult.Yes)
                {
                    board.ResetBoard();
                }
                else if(d == DialogResult.No){
                    Application.Exit();
                }
            }
            //insert piece into board
            if (board.ColumnIsFull(6))
            {
                btn_col7.Enabled = false;
            }
            else
            {
                board.PlayPiece(col: 6);
                this.Refresh();
                board.NextTurn();
            }
        }
        //restart button
        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            board.ResetBoard();
            this.Refresh();
        }
        //quit button
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}