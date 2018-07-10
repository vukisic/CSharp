using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        bool turn = true; //true->X , false->O
        int turns_counter = 0;
        bool end = false;
        public TicTacToe()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Vuk Isic\nPR39/2016", "TicTacToe");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            ++turns_counter;
            Button btn = sender as Button;
            if (turn)
                btn.Text = "X";
            else
                btn.Text = "O";
            turn = !turn;

            btn.Enabled = false;
            CheckForWinner();
        }

        private void CheckForWinner()
        {
            if(turns_counter>=5)
            {
                //Vertical
                if ((button11.Text == button21.Text) && (button21.Text == button31.Text) && button11.Text!="")
                    end = true;
                if ((button12.Text == button22.Text) && (button22.Text == button32.Text) && button12.Text != "")
                    end = true;
                if ((button13.Text == button23.Text) && (button23.Text == button33.Text) && button13.Text != "")
                    end = true;

                //Horizontal
                if ((button11.Text == button12.Text) && (button12.Text == button13.Text) && button11.Text != "")
                    end = true;
                if ((button21.Text == button22.Text) && (button22.Text == button23.Text) && button21.Text != "")
                    end = true;
                if ((button31.Text == button32.Text) && (button32.Text == button33.Text) && button31.Text != "")
                    end = true;

                //Diagonal
                if ((button11.Text == button22.Text) && (button22.Text == button33.Text) && button22.Text != "")
                    end = true;
                if ((button13.Text == button22.Text) && (button22.Text == button31.Text) && button22.Text != "")
                    end = true;

                if (end)
                {
                    string winner = turn ? "O" : "X";
                    MessageBox.Show("Winner is " + winner + " !", "TicTacToe");
                    DisableButtons();
                    if (winner == "X")
                        labelXP.Text = (Convert.ToInt32(labelXP.Text)+1).ToString();
                    else
                        labelOP.Text = (Convert.ToInt32(labelOP.Text) + 1).ToString();
                }
                else if(turns_counter==9)
                {
                    MessageBox.Show("Draw !", "TicTacToe");
                    labelDP.Text = (Convert.ToInt32(labelDP.Text) + 1).ToString();
                    DisableButtons();
                }
            } 
        }


        private void DisableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    Button b = c as Button;
                    b.Enabled = false;
                }
            }
            catch{ }
            
        }

        private void EnableButtons()
        {
            try
            {
                foreach (Control c in Controls)
                {
                    try
                    {
                        Button b = c as Button;
                        b.Enabled = true;
                        b.Text = "";
                    }
                    catch { }
                    
                }
            }
            catch { }

        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            end = false;
            turns_counter = 0;
            turn = true;
            EnableButtons();
        }

        private void Mouse_Enter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Enabled)
                btn.Text = turn ? "X" : "O";
        }

        private void Mouse_Leave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn.Enabled)
                btn.Text = "";
        }

        private void resetCountsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelXP.Text = (0).ToString();
            labelOP.Text = (0).ToString();
            labelDP.Text = (0).ToString();
        }
    }
}
