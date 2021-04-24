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

        

        private void btn_col1_Click(object sender, EventArgs e)

        {
            //insert piece into board
            board.PlayPiece(col:0);
           if (board.ColumnIsFull(0))
                btn_col1.Enabled = false;
        }
    }
}