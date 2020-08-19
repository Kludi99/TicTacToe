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
    public partial class Form1 : Form
    {
        bool turn = true;
        int turn_counter = 0;
        bool computer_against = false;
        //static string player1, player2;
        public Form1()
        {
            InitializeComponent();
        }
       /* public static void setPlayer(string p1, string p2)
        {
            player1 = p1;
            player2 = p2;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
           /* Form form = new Form2();
            form.ShowDialog();
            label1.Text = player1;
            label3.Text = player2; */
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tic Tac Toe game, everyone knows", "TicTacToe About");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void NewGame()
        {
            turn = true;
            turn_counter = 0;

            foreach (Control control in Controls)
            {
                try
                {
                    Button button = (Button)control;
                    button.Enabled = true;
                    button.BackColor = Color.FromArgb(232, 232, 232);
                    button.Text = "";

                }
                catch { }
            }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            
        }

        private void Button_click(object sender, EventArgs e)
        {
            if (p1.Text == "Player 1" && p2.Text == "Player 2")
                MessageBox.Show("You must specify players' names before you start. If you want to play against the computer type 'computer' in the second textbox", "Error");
            else
            {
                Button button = (Button)sender;

                if (turn)
                    button.Text = "X";

                else
                    button.Text = "O";


                turn = !turn;
                turn_counter++;
                button.Enabled = false;
                CheckWinner();
            }
            if ((!turn) && (computer_against) &&(LookForSpace()!=null))
                ComputerMove();
            
        }

        private void ComputerMove()
        {
            Button computerMove = null;

            computerMove = LookForWinOrBlockOpponent("O"); //Look for win
            if(computerMove == null) //can't win on one click
            {
                computerMove = LookForWinOrBlockOpponent("X"); //look for block opponent
                if(computerMove == null) // there aren't 2 X in 1 line
                {
                    computerMove = LookForCorner(); //look for empty corner
                    if (computerMove == null) //there isn't any empty corner
                        computerMove = LookForSpace(); // look for empty space
                }
            }

            computerMove.PerformClick();
            computerMove.BackColor = Color.DarkBlue;
        }
        private Button LookForWinOrBlockOpponent(string character)
        {
            //Horizontal
            //first line
            if ((A00.Text == character) && (A01.Text == character) && (A02.Text == ""))
                return A02;
            if ((A00.Text == character) && (A01.Text == "") && (A02.Text == character))
                return A01;
            if ((A00.Text == "") && (A01.Text == character) && (A02.Text == character))
                return A00;
            //second line
            if ((A10.Text == character) && (A11.Text == character) && (A12.Text == ""))
                return A12;
            if ((A10.Text == character) && (A11.Text == "") && (A12.Text == character))
                return A11;
            if ((A10.Text == "") && (A11.Text == character) && (A12.Text == character))
                return A10;
            //third line
            if ((A20.Text == character) && (A21.Text == character) && (A22.Text == ""))
                return A22;
            if ((A20.Text == character) && (A21.Text == "") && (A22.Text == character))
                return A21;
            if ((A20.Text == "") && (A21.Text == character) && (A22.Text == character))
                return A20;
            //vertical
            //first line
            if ((A00.Text == character) && (A10.Text == character) && (A20.Text == ""))
                return A20;
            if ((A00.Text == character) && (A10.Text == "") && (A20.Text == character))
                return A10;
            if ((A00.Text == "") && (A10.Text == character) && (A20.Text == character))
                return A00;
            //second line
            if ((A01.Text == character) && (A11.Text == character) && (A21.Text == ""))
                return A21;
            if ((A01.Text == character) && (A11.Text == "") && (A21.Text == character))
                return A11;
            if ((A01.Text == "") && (A11.Text == character) && (A21.Text == character))
                return A01;
            //third line
            if ((A02.Text == character) && (A12.Text == character) && (A22.Text == ""))
                return A21;
            if ((A02.Text == character) && (A12.Text == "") && (A22.Text == character))
                return A11;
            if ((A02.Text == "") && (A12.Text == character) && (A22.Text == character))
                return A02;
            //Diagonal 
            //up-left down-right
            if ((A00.Text == character) && (A11.Text == character) && (A22.Text == ""))
                return A22;
            if ((A00.Text == character) && (A11.Text == "") && (A22.Text == character))
                return A11;
            if ((A00.Text == "") && (A11.Text == character) && (A22.Text == character))
                return A00;
            //up-right down-left
            if ((A02.Text == character) && (A11.Text == character) && (A20.Text == ""))
                return A20;
            if ((A02.Text == character) && (A11.Text == "") && (A20.Text == character))
                return A11;
            if ((A02.Text == "") && (A11.Text == character) && (A20.Text == character))
                return A02;

            return null;
        }
        private Button LookForCorner()
        {

            if(A00.Text=="O") //left-up corner
            {
                if (A02.Text == "") return A02;
                if (A20.Text == "") return A20;
                if (A22.Text == "") return A22;
            }
            if (A02.Text == "O") //Right-Up corner
            {
                if (A00.Text == "") return A00;
                if (A20.Text == "") return A20;
                if (A22.Text == "") return A22;
            }
            if (A20.Text == "O") //left-down corner
            {
                if (A02.Text == "") return A02;
                if (A00.Text == "") return A00;
                if (A22.Text == "") return A22;
            }
            if (A22.Text == "O") //right-down corner
            {
                if (A02.Text == "") return A02;
                if (A20.Text == "") return A20;
                if (A00.Text == "") return A00;
            }
            //there isn't any "O" in the corners check if there is any empty corner
            if (A00.Text == "") return A00;
            if (A02.Text == "") return A02;
            if (A20.Text == "") return A20;
            if (A22.Text == "") return A22;

            return null; 
        }
        private Button LookForSpace()
        {
            Button button = null;
            foreach(Control control in Controls)
            {
                button = control as Button;
                if (button != null && button.Text == "")
                    return button;
            }
            return null;
        }
        private void CheckWinner()
        {
            bool winner = false;
            //horizontal
            if ((A00.Text == A01.Text) && (A01.Text == A02.Text) && (!A00.Enabled))
                winner = true;
            else if ((A10.Text == A11.Text) && (A11.Text == A12.Text) && (!A10.Enabled))
                winner = true;
            else if ((A20.Text == A21.Text) && (A21.Text == A22.Text) && (!A20.Enabled))
                winner = true;
            //vertical
            else if ((A00.Text == A10.Text) && (A10.Text == A20.Text) && (!A00.Enabled))
                winner = true;
            else if ((A01.Text == A11.Text) && (A11.Text == A21.Text) && (!A01.Enabled))
                winner = true;
            else if ((A02.Text == A12.Text) && (A12.Text == A22.Text) && (!A02.Enabled))
                winner = true;
            //diagonal
            else if ((A00.Text == A11.Text) && (A11.Text == A22.Text) && (!A00.Enabled))
                winner = true;
            else if ((A02.Text == A11.Text) && (A11.Text == A20.Text) && (!A02.Enabled))
                winner = true;




            if (winner)
            {
                disableButton();
                String win = "";
                if (turn)
                {
                    win = p2.Text;
                    OWinCount.Text = (int.Parse(OWinCount.Text)+1).ToString();
                }
                    
                else
                {
                    win = p1.Text;
                    XWinCount.Text = (int.Parse(XWinCount.Text) + 1).ToString();
                }
                    

                MessageBox.Show(win + " wins!", "End");
                NewGame();
            }
            else 
            {
                if (turn_counter == 9)
                {
                    DrawCount.Text = (int.Parse(DrawCount.Text) + 1).ToString();
                    MessageBox.Show("Draw!", "End");
                    NewGame();
                }
                    
            }
            
            

        }
        private void disableButton()
        {
            try
            {
                foreach (Control control in Controls)
                {
                    Button button = (Button)control;
                    button.Enabled = false;
                }
            }
            catch { }
            
        }

        private void button_enter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Enabled)
            {
                if (turn)
                {
                    button.Text = "X";
                    button.BackColor = Color.DarkGreen;
                }
                    
                
                else
                {
                    button.Text = "O";
                    button.BackColor = Color.DarkRed;
                }
                    
            }
            
            
        }

        private void button_leave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(button.Enabled)
            {
                button.Text = "";
                button.BackColor = Color.FromArgb(232,232,232);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OWinCount.Text = XWinCount.Text = DrawCount.Text = "0";
            NewGame();
            p1.Text = "Player 1";
            p2.Text = "Player 2";
        }

        private void p2_TextChanged(object sender, EventArgs e)
        {
            if (p2.Text.ToLower() == "computer")
                computer_against = true;
            else
                computer_against = false;
        }

        private void setPlayerDefaultsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            p1.Text = "Ann";
            p2.Text = "computer";
        }
    }
}
